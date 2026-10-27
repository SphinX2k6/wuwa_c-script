using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.World.Controller
{
	// Token: 0x0200453D RID: 17725
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class SneakController : ControllerBase
	{
		// Token: 0x0602DCEB RID: 187627 RVA: 0x00A86C14 File Offset: 0x00A84E14
		public void StartSneaking()
		{
			this.InSneakGameplay = true;
			this.AddOrRemoveSneakBuff(true);
			this.AddSneakEvent();
			EventSystem.Instance.Emit(EEventName.SneakStart);
		}

		// Token: 0x0602DCEC RID: 187628 RVA: 0x00A86C3A File Offset: 0x00A84E3A
		public void EndSneaking()
		{
			this.InSneakGameplay = false;
			this.AddOrRemoveSneakBuff(false);
			this.RemoveSneakEvent();
			EventSystem.Instance.Emit(EEventName.SneakEnd);
		}

		// Token: 0x17007547 RID: 30023
		// (get) Token: 0x0602DCED RID: 187629 RVA: 0x00A86C60 File Offset: 0x00A84E60
		public bool IsSneaking
		{
			get
			{
				return this.InSneakGameplay;
			}
		}

		// Token: 0x0602DCEE RID: 187630 RVA: 0x00A86C68 File Offset: 0x00A84E68
		private void AddSneakEvent()
		{
			EventSystem.Instance.Add<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
		}

		// Token: 0x0602DCEF RID: 187631 RVA: 0x00A86C86 File Offset: 0x00A84E86
		private void RemoveSneakEvent()
		{
			if (EventSystem.Instance.Has<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged)))
			{
				EventSystem.Instance.Remove<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
			}
		}

		// Token: 0x0602DCF0 RID: 187632 RVA: 0x00A86CC1 File Offset: 0x00A84EC1
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

		// Token: 0x0602DCF1 RID: 187633 RVA: 0x00A86CF8 File Offset: 0x00A84EF8
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

		// Token: 0x17007548 RID: 30024
		// (get) Token: 0x0602DCF2 RID: 187634 RVA: 0x00A86D80 File Offset: 0x00A84F80
		public static SneakController Instance
		{
			get
			{
				return SneakController._Instance;
			}
		}

		// Token: 0x0602DCF3 RID: 187635 RVA: 0x00A86D87 File Offset: 0x00A84F87
		public static SneakController GetOrCreateInstance()
		{
			if (SneakController._Instance == null)
			{
				SneakController.CreateInstance();
			}
			return SneakController._Instance;
		}

		// Token: 0x0602DCF4 RID: 187636 RVA: 0x00A86D9B File Offset: 0x00A84F9B
		public static bool CreateInstance()
		{
			if (SneakController._Instance != null)
			{
				return true;
			}
			SneakController._Instance = new SneakController();
			return true;
		}

		// Token: 0x0602DCF5 RID: 187637 RVA: 0x00A86DB1 File Offset: 0x00A84FB1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DCF6 RID: 187638 RVA: 0x00A86DB3 File Offset: 0x00A84FB3
		public static void ResetStaticDefaultValue()
		{
			SneakController._Instance = null;
		}

		// Token: 0x0602DCF7 RID: 187639 RVA: 0x00A86DBB File Offset: 0x00A84FBB
		static SneakController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SneakController.CreateStaticDefaultValue), new Action(SneakController.ResetStaticDefaultValue));
		}

		// Token: 0x04018765 RID: 100197
		private bool InSneakGameplay;

		// Token: 0x04018766 RID: 100198
		private bool SneakState;

		// Token: 0x04018767 RID: 100199
		[Nullable(2)]
		private static SneakController _Instance;
	}
}
