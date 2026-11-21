using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.World.Controller
{
	// Token: 0x02003465 RID: 13413
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class SneakController : ControllerBase
	{
		// Token: 0x060223CD RID: 140237 RVA: 0x009B243C File Offset: 0x009B063C
		public void StartSneaking()
		{
			this.InSneakGameplay = true;
			this.AddOrRemoveSneakBuff(true);
			this.AddSneakEvent();
			EventSystem.Instance.Emit(EEventName.SneakStart);
		}

		// Token: 0x060223CE RID: 140238 RVA: 0x009B2462 File Offset: 0x009B0662
		public void EndSneaking()
		{
			this.InSneakGameplay = false;
			this.AddOrRemoveSneakBuff(false);
			this.RemoveSneakEvent();
			EventSystem.Instance.Emit(EEventName.SneakEnd);
		}

		// Token: 0x170047FE RID: 18430
		// (get) Token: 0x060223CF RID: 140239 RVA: 0x009B2488 File Offset: 0x009B0688
		public bool IsSneaking
		{
			get
			{
				return this.InSneakGameplay;
			}
		}

		// Token: 0x060223D0 RID: 140240 RVA: 0x009B2490 File Offset: 0x009B0690
		private void AddSneakEvent()
		{
			EventSystem.Instance.Add<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
		}

		// Token: 0x060223D1 RID: 140241 RVA: 0x009B24AE File Offset: 0x009B06AE
		private void RemoveSneakEvent()
		{
			if (EventSystem.Instance.Has<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged)))
			{
				EventSystem.Instance.Remove<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
			}
		}

		// Token: 0x060223D2 RID: 140242 RVA: 0x009B24E9 File Offset: 0x009B06E9
		private void OnBattleStateChanged(bool isInBattleState)
		{
			this.AddOrRemoveSneakBuff(!isInBattleState);
			if (isInBattleState == this.SneakState)
			{
				return;
			}
			this.SneakState = isInBattleState;
			EventSystem.Instance.Emit<bool, long>(EEventName.OnSneakFoundChange, this.SneakState, 0L);
		}

		// Token: 0x060223D3 RID: 140243 RVA: 0x009B2520 File Offset: 0x009B0720
		private void AddOrRemoveSneakBuff(bool isAdd)
		{
			CharacterBuffComponent component = Global.BaseCharacter.GetEntityNoBlueprint().GetComponent<CharacterBuffComponent>();
			if (component == null || !component.Valid)
			{
				return;
			}
			if (isAdd)
			{
				component.AddBuff(70000049L, new AddBuffParam
				{
					InstigatorId = component.CreatureDataId,
					Reason = "SneakController"
				});
				return;
			}
			component.RemoveBuff(70000049L, -1, "SneakController", null, null, null);
		}

		// Token: 0x170047FF RID: 18431
		// (get) Token: 0x060223D4 RID: 140244 RVA: 0x009B25A8 File Offset: 0x009B07A8
		public static SneakController Instance
		{
			get
			{
				return SneakController._Instance;
			}
		}

		// Token: 0x060223D5 RID: 140245 RVA: 0x009B25AF File Offset: 0x009B07AF
		public static SneakController GetOrCreateInstance()
		{
			if (SneakController._Instance == null)
			{
				SneakController.CreateInstance();
			}
			return SneakController._Instance;
		}

		// Token: 0x060223D6 RID: 140246 RVA: 0x009B25C3 File Offset: 0x009B07C3
		public static bool CreateInstance()
		{
			if (SneakController._Instance != null)
			{
				return true;
			}
			SneakController._Instance = new SneakController();
			return true;
		}

		// Token: 0x060223D7 RID: 140247 RVA: 0x009B25D9 File Offset: 0x009B07D9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060223D8 RID: 140248 RVA: 0x009B25DB File Offset: 0x009B07DB
		public static void ResetStaticDefaultValue()
		{
			SneakController._Instance = null;
		}

		// Token: 0x060223D9 RID: 140249 RVA: 0x009B25E3 File Offset: 0x009B07E3
		static SneakController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SneakController.CreateStaticDefaultValue), new Action(SneakController.ResetStaticDefaultValue));
		}

		// Token: 0x04012D9F RID: 77215
		private bool InSneakGameplay;

		// Token: 0x04012DA0 RID: 77216
		private bool SneakState;

		// Token: 0x04012DA1 RID: 77217
		[Nullable(2)]
		private static SneakController _Instance;
	}
}
