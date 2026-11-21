using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Teleport;
using UnrealEngine;

namespace CSharpScript.Game.World.Controller
{
	// Token: 0x02003463 RID: 13411
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class PlayerVelocityController : ControllerBase
	{
		// Token: 0x060223A7 RID: 140199 RVA: 0x009B1CB2 File Offset: 0x009AFEB2
		protected override bool OnInit()
		{
			this.PlayerVelocityFilter = EntityToLoadFilter.Create();
			base.InitTickOptimize(5, 10);
			this.InitConsoleVariables();
			this.OnAddEvents();
			WaitEntityToLoadTask.GetPlayerVelocityOverride = new Func<Vector>(this.GetAvgVelocity);
			return base.OnInit();
		}

		// Token: 0x060223A8 RID: 140200 RVA: 0x009B1CEB File Offset: 0x009AFEEB
		private void InitConsoleVariables()
		{
			this.ImposterUpdateBatch = UKismetSystemLibrary.GetConsoleVariableIntValue("r.imp.UpdateBatch");
		}

		// Token: 0x060223A9 RID: 140201 RVA: 0x009B1CFD File Offset: 0x009AFEFD
		protected override bool OnClear()
		{
			this.OnRemoveEvents();
			this.IsHighSpeed = false;
			this.UpdateConsoleVariables();
			WaitEntityToLoadTask.GetPlayerVelocityOverride = null;
			this.PlayerVelocityFilter.Cleanup();
			return base.OnClear();
		}

		// Token: 0x060223AA RID: 140202 RVA: 0x009B1D2C File Offset: 0x009AFF2C
		private void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.BeforeLoadMap, new Action(this.OnBeforeLoadMap));
			EventSystem.Instance.Add<bool>(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
			EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportEnd));
		}

		// Token: 0x060223AB RID: 140203 RVA: 0x009B1DAC File Offset: 0x009AFFAC
		private void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.BeforeLoadMap, new Action(this.OnBeforeLoadMap));
			EventSystem.Instance.Remove<bool>(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
			EventSystem.Instance.Remove<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportEnd));
		}

		// Token: 0x060223AC RID: 140204 RVA: 0x009B1E29 File Offset: 0x009B0029
		private void OnWorldDone()
		{
			this.Start();
		}

		// Token: 0x060223AD RID: 140205 RVA: 0x009B1E31 File Offset: 0x009B0031
		private void OnBeforeLoadMap()
		{
			this.Stop();
		}

		// Token: 0x060223AE RID: 140206 RVA: 0x009B1E39 File Offset: 0x009B0039
		private void OnTeleportStart(bool loading)
		{
			this.Stop();
		}

		// Token: 0x060223AF RID: 140207 RVA: 0x009B1E41 File Offset: 0x009B0041
		[NullableContext(2)]
		private void OnTeleportEnd(TeleportContext teleportContext)
		{
			this.Start();
		}

		// Token: 0x060223B0 RID: 140208 RVA: 0x009B1E49 File Offset: 0x009B0049
		private void Start()
		{
			base.ResumeTick();
			this.Reset();
		}

		// Token: 0x060223B1 RID: 140209 RVA: 0x009B1E57 File Offset: 0x009B0057
		private void Stop()
		{
			base.PauseTick();
		}

		// Token: 0x060223B2 RID: 140210 RVA: 0x009B1E5F File Offset: 0x009B005F
		private void Reset()
		{
			this.LastPosition.DeepCopy(this.GetPlayerPosition());
			this.ResetVelocity();
		}

		// Token: 0x060223B3 RID: 140211 RVA: 0x009B1E78 File Offset: 0x009B0078
		private void ResetVelocity()
		{
			this.AvgVelocity.Set(0.0, 0.0, 0.0);
		}

		// Token: 0x060223B4 RID: 140212 RVA: 0x009B1EA0 File Offset: 0x009B00A0
		protected override void OnTick(float delta)
		{
			this.CalculateVelocity(delta * 0.001f);
		}

		// Token: 0x060223B5 RID: 140213 RVA: 0x009B1EB0 File Offset: 0x009B00B0
		private Vector GetPlayerPosition()
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			CharacterActorComponent characterActorComponent;
			if (getCurrentEntity == null)
			{
				characterActorComponent = null;
			}
			else
			{
				WorldEntity entity = getCurrentEntity.Entity;
				characterActorComponent = ((entity != null) ? entity.GetComponent<CharacterActorComponent>() : null);
			}
			CharacterActorComponent characterActorComponent2 = characterActorComponent;
			if (characterActorComponent2 == null)
			{
				return this.LastPosition;
			}
			return characterActorComponent2.ActorLocationProxy;
		}

		// Token: 0x060223B6 RID: 140214 RVA: 0x009B1EF0 File Offset: 0x009B00F0
		private void CalculateVelocity(float delta)
		{
			if (delta <= 0f)
			{
				if (CreatureModel.Instance.EnableEntityLog)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.World;
					ELogAuthor author = ELogAuthor.XY;
					string message = "计算玩家移动速度时检测到间隔时间异常";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("delta", delta);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				this.ResetVelocity();
			}
			else if (delta > 5f)
			{
				if (CreatureModel.Instance.EnableEntityLog)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.World;
					ELogAuthor author2 = ELogAuthor.XY;
					string message2 = "计算玩家移动速度时检测到间隔时间过长";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("delta", delta);
					instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
				this.Reset();
			}
			else
			{
				Vector playerPosition = this.GetPlayerPosition();
				playerPosition.Subtraction(this.LastPosition, this.AbsVelocity);
				this.AbsVelocity.DivisionEqual((double)delta);
				this.LastPosition.DeepCopy(playerPosition);
				float num = MathCommon.Clamp(delta * 6f, 0f, 1f);
				this.AvgVelocity.MultiplyEqual((double)(1f - num));
				this.AbsVelocity.MultiplyEqual((double)num);
				this.AvgVelocity.AdditionEqual(this.AbsVelocity);
			}
			this.UpdateHighSpeedMode();
		}

		// Token: 0x060223B7 RID: 140215 RVA: 0x009B2018 File Offset: 0x009B0218
		private unsafe void UpdateHighSpeedMode()
		{
			double num = this.AvgVelocity.SizeSquared();
			bool flag = num > 640000.0;
			if (flag == this.IsHighSpeed)
			{
				return;
			}
			this.IsHighSpeed = flag;
			if (CreatureModel.Instance.EnableEntityLog)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.World;
				ELogAuthor author = ELogAuthor.XY;
				string message = "高速模式切换";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("IsHighSpeed", this.IsHighSpeed);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AvgVelocity", num);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			if (!FormationDataController.Instance.GlobalIsInFight)
			{
				this.UpdateConsoleVariables();
			}
			EventSystem.Instance.Emit<bool>(EEventName.OnHighSpeedModeChanged, this.IsHighSpeed);
		}

		// Token: 0x060223B8 RID: 140216 RVA: 0x009B20E5 File Offset: 0x009B02E5
		private void UpdateConsoleVariables()
		{
			if (this.IsHighSpeed)
			{
				this.UpdateImposterUpdateBatch((int)Math.Floor((double)((float)this.ImposterUpdateBatch / 2f)));
				return;
			}
			this.UpdateImposterUpdateBatch(this.ImposterUpdateBatch);
		}

		// Token: 0x060223B9 RID: 140217 RVA: 0x009B2116 File Offset: 0x009B0316
		private void UpdateImposterUpdateBatch(int batch)
		{
			this.TempStringArray[0] = "r.imp.UpdateBatch";
			this.TempStringArray[1] = batch.ToString();
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, string.Join(" ", this.TempStringArray), null);
		}

		// Token: 0x060223BA RID: 140218 RVA: 0x009B214F File Offset: 0x009B034F
		public Vector GetAvgVelocity()
		{
			return this.AvgVelocity;
		}

		// Token: 0x060223BB RID: 140219 RVA: 0x009B2157 File Offset: 0x009B0357
		public bool IsHighSpeedMode()
		{
			return this.IsHighSpeed;
		}

		// Token: 0x170047FC RID: 18428
		// (get) Token: 0x060223BC RID: 140220 RVA: 0x009B215F File Offset: 0x009B035F
		public static PlayerVelocityController Instance
		{
			get
			{
				return PlayerVelocityController._Instance;
			}
		}

		// Token: 0x060223BD RID: 140221 RVA: 0x009B2166 File Offset: 0x009B0366
		public static PlayerVelocityController GetOrCreateInstance()
		{
			if (PlayerVelocityController._Instance == null)
			{
				PlayerVelocityController.CreateInstance();
			}
			return PlayerVelocityController._Instance;
		}

		// Token: 0x060223BE RID: 140222 RVA: 0x009B217A File Offset: 0x009B037A
		public static bool CreateInstance()
		{
			if (PlayerVelocityController._Instance != null)
			{
				return true;
			}
			PlayerVelocityController._Instance = new PlayerVelocityController();
			return true;
		}

		// Token: 0x060223BF RID: 140223 RVA: 0x009B2190 File Offset: 0x009B0390
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060223C0 RID: 140224 RVA: 0x009B2192 File Offset: 0x009B0392
		public static void ResetStaticDefaultValue()
		{
			PlayerVelocityController._Instance = null;
		}

		// Token: 0x060223C1 RID: 140225 RVA: 0x009B219A File Offset: 0x009B039A
		static PlayerVelocityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlayerVelocityController.CreateStaticDefaultValue), new Action(PlayerVelocityController.ResetStaticDefaultValue));
		}

		// Token: 0x04012D8F RID: 77199
		private const float MAX_DELTA_TIME = 5f;

		// Token: 0x04012D90 RID: 77200
		private const int HIGH_SPEED_SQUARED = 640000;

		// Token: 0x04012D91 RID: 77201
		private const string IMPOSTER_UPDATE_BATCH = "r.imp.UpdateBatch";

		// Token: 0x04012D92 RID: 77202
		private readonly Vector LastPosition = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x04012D93 RID: 77203
		private readonly Vector AbsVelocity = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x04012D94 RID: 77204
		private readonly Vector AvgVelocity = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x04012D95 RID: 77205
		private bool IsHighSpeed;

		// Token: 0x04012D96 RID: 77206
		private int ImposterUpdateBatch = 128;

		// Token: 0x04012D97 RID: 77207
		private readonly string[] TempStringArray = new string[]
		{
			"",
			"0"
		};

		// Token: 0x04012D98 RID: 77208
		private readonly Stat CalculateVelocityStat = Stat.Create("PlayerVelocityController.CalculateVelocity", "", "");

		// Token: 0x04012D99 RID: 77209
		private EntityToLoadFilter PlayerVelocityFilter;

		// Token: 0x04012D9A RID: 77210
		[Nullable(2)]
		private static PlayerVelocityController _Instance;
	}
}
