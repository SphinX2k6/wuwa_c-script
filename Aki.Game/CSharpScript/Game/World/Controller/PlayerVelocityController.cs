using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Teleport;
using UnrealEngine;

namespace CSharpScript.Game.World.Controller
{
	// Token: 0x0200453B RID: 17723
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class PlayerVelocityController : ControllerBase
	{
		// Token: 0x0602DCC5 RID: 187589 RVA: 0x00A8648A File Offset: 0x00A8468A
		protected override bool OnInit()
		{
			this.PlayerVelocityFilter = EntityToLoadFilter.Create();
			base.InitTickOptimize(5, 10);
			this.InitConsoleVariables();
			this.OnAddEvents();
			WaitEntityToLoadTask.GetPlayerVelocityOverride = new Func<Vector>(this.GetAvgVelocity);
			return base.OnInit();
		}

		// Token: 0x0602DCC6 RID: 187590 RVA: 0x00A864C3 File Offset: 0x00A846C3
		private void InitConsoleVariables()
		{
			this.ImposterUpdateBatch = UKismetSystemLibrary.GetConsoleVariableIntValue("r.imp.UpdateBatch");
		}

		// Token: 0x0602DCC7 RID: 187591 RVA: 0x00A864D5 File Offset: 0x00A846D5
		protected override bool OnClear()
		{
			this.OnRemoveEvents();
			this.IsHighSpeed = false;
			this.UpdateConsoleVariables();
			WaitEntityToLoadTask.GetPlayerVelocityOverride = null;
			this.PlayerVelocityFilter.Cleanup();
			return base.OnClear();
		}

		// Token: 0x0602DCC8 RID: 187592 RVA: 0x00A86504 File Offset: 0x00A84704
		private void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.BeforeLoadMap, new Action(this.OnBeforeLoadMap));
			EventSystem.Instance.Add<bool>(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
			EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportEnd));
		}

		// Token: 0x0602DCC9 RID: 187593 RVA: 0x00A86584 File Offset: 0x00A84784
		private void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.BeforeLoadMap, new Action(this.OnBeforeLoadMap));
			EventSystem.Instance.Remove<bool>(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
			EventSystem.Instance.Remove<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportEnd));
		}

		// Token: 0x0602DCCA RID: 187594 RVA: 0x00A86601 File Offset: 0x00A84801
		private void OnWorldDone()
		{
			this.Start();
		}

		// Token: 0x0602DCCB RID: 187595 RVA: 0x00A86609 File Offset: 0x00A84809
		private void OnBeforeLoadMap()
		{
			this.Stop();
		}

		// Token: 0x0602DCCC RID: 187596 RVA: 0x00A86611 File Offset: 0x00A84811
		private void OnTeleportStart(bool loading)
		{
			this.Stop();
		}

		// Token: 0x0602DCCD RID: 187597 RVA: 0x00A86619 File Offset: 0x00A84819
		[NullableContext(2)]
		private void OnTeleportEnd(TeleportContext teleportContext)
		{
			this.Start();
		}

		// Token: 0x0602DCCE RID: 187598 RVA: 0x00A86621 File Offset: 0x00A84821
		private void Start()
		{
			base.ResumeTick();
			this.Reset();
		}

		// Token: 0x0602DCCF RID: 187599 RVA: 0x00A8662F File Offset: 0x00A8482F
		private void Stop()
		{
			base.PauseTick();
		}

		// Token: 0x0602DCD0 RID: 187600 RVA: 0x00A86637 File Offset: 0x00A84837
		private void Reset()
		{
			this.LastPosition.DeepCopy(this.GetPlayerPosition());
			this.ResetVelocity();
		}

		// Token: 0x0602DCD1 RID: 187601 RVA: 0x00A86650 File Offset: 0x00A84850
		private void ResetVelocity()
		{
			this.AvgVelocity.Set(0.0, 0.0, 0.0);
		}

		// Token: 0x0602DCD2 RID: 187602 RVA: 0x00A86678 File Offset: 0x00A84878
		protected override void OnTick(float delta)
		{
			this.CalculateVelocity(delta * 0.001f);
		}

		// Token: 0x0602DCD3 RID: 187603 RVA: 0x00A86688 File Offset: 0x00A84888
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

		// Token: 0x0602DCD4 RID: 187604 RVA: 0x00A866C8 File Offset: 0x00A848C8
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

		// Token: 0x0602DCD5 RID: 187605 RVA: 0x00A867F0 File Offset: 0x00A849F0
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

		// Token: 0x0602DCD6 RID: 187606 RVA: 0x00A868BD File Offset: 0x00A84ABD
		private void UpdateConsoleVariables()
		{
			if (this.IsHighSpeed)
			{
				this.UpdateImposterUpdateBatch((int)Math.Floor((double)((float)this.ImposterUpdateBatch / 2f)));
				return;
			}
			this.UpdateImposterUpdateBatch(this.ImposterUpdateBatch);
		}

		// Token: 0x0602DCD7 RID: 187607 RVA: 0x00A868EE File Offset: 0x00A84AEE
		private void UpdateImposterUpdateBatch(int batch)
		{
			this.TempStringArray[0] = "r.imp.UpdateBatch";
			this.TempStringArray[1] = batch.ToString();
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, string.Join(" ", this.TempStringArray), null);
		}

		// Token: 0x0602DCD8 RID: 187608 RVA: 0x00A86927 File Offset: 0x00A84B27
		public Vector GetAvgVelocity()
		{
			return this.AvgVelocity;
		}

		// Token: 0x0602DCD9 RID: 187609 RVA: 0x00A8692F File Offset: 0x00A84B2F
		public bool IsHighSpeedMode()
		{
			return this.IsHighSpeed;
		}

		// Token: 0x17007545 RID: 30021
		// (get) Token: 0x0602DCDA RID: 187610 RVA: 0x00A86937 File Offset: 0x00A84B37
		public static PlayerVelocityController Instance
		{
			get
			{
				return PlayerVelocityController._Instance;
			}
		}

		// Token: 0x0602DCDB RID: 187611 RVA: 0x00A8693E File Offset: 0x00A84B3E
		public static PlayerVelocityController GetOrCreateInstance()
		{
			if (PlayerVelocityController._Instance == null)
			{
				PlayerVelocityController.CreateInstance();
			}
			return PlayerVelocityController._Instance;
		}

		// Token: 0x0602DCDC RID: 187612 RVA: 0x00A86952 File Offset: 0x00A84B52
		public static bool CreateInstance()
		{
			if (PlayerVelocityController._Instance != null)
			{
				return true;
			}
			PlayerVelocityController._Instance = new PlayerVelocityController();
			return true;
		}

		// Token: 0x0602DCDD RID: 187613 RVA: 0x00A86968 File Offset: 0x00A84B68
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DCDE RID: 187614 RVA: 0x00A8696A File Offset: 0x00A84B6A
		public static void ResetStaticDefaultValue()
		{
			PlayerVelocityController._Instance = null;
		}

		// Token: 0x0602DCDF RID: 187615 RVA: 0x00A86972 File Offset: 0x00A84B72
		static PlayerVelocityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlayerVelocityController.CreateStaticDefaultValue), new Action(PlayerVelocityController.ResetStaticDefaultValue));
		}

		// Token: 0x04018755 RID: 100181
		private const float MAX_DELTA_TIME = 5f;

		// Token: 0x04018756 RID: 100182
		private const int HIGH_SPEED_SQUARED = 640000;

		// Token: 0x04018757 RID: 100183
		private const string IMPOSTER_UPDATE_BATCH = "r.imp.UpdateBatch";

		// Token: 0x04018758 RID: 100184
		private readonly Vector LastPosition = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x04018759 RID: 100185
		private readonly Vector AbsVelocity = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x0401875A RID: 100186
		private readonly Vector AvgVelocity = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x0401875B RID: 100187
		private bool IsHighSpeed;

		// Token: 0x0401875C RID: 100188
		private int ImposterUpdateBatch = 128;

		// Token: 0x0401875D RID: 100189
		private readonly string[] TempStringArray = new string[]
		{
			"",
			"0"
		};

		// Token: 0x0401875E RID: 100190
		private readonly Stat CalculateVelocityStat = Stat.Create("PlayerVelocityController.CalculateVelocity", "", "");

		// Token: 0x0401875F RID: 100191
		private EntityToLoadFilter PlayerVelocityFilter;

		// Token: 0x04018760 RID: 100192
		[Nullable(2)]
		private static PlayerVelocityController _Instance;
	}
}
