using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritState
{
	// Token: 0x020069F9 RID: 27129
	[NullableContext(1)]
	[Nullable(0)]
	public class SunSpiritBaseState
	{
		// Token: 0x060437DA RID: 276442 RVA: 0x01080BD9 File Offset: 0x0107EDD9
		protected SunSpiritBaseState(ESunSpiritStateType stateTypeInternal, SunSpiritData sunSpiritData)
		{
			this.StateTypeInternal = stateTypeInternal;
			this.SunSpiritData = sunSpiritData;
			this.NeedTickInternal = this.HasTickFunc();
		}

		// Token: 0x1700988C RID: 39052
		// (get) Token: 0x060437DB RID: 276443 RVA: 0x01080BFB File Offset: 0x0107EDFB
		public ESunSpiritStateType StateType
		{
			get
			{
				return this.StateTypeInternal;
			}
		}

		// Token: 0x060437DC RID: 276444 RVA: 0x01080C03 File Offset: 0x0107EE03
		public bool Enter()
		{
			if ((this.Status & ESunSpiritStateStatus.Entering) != ESunSpiritStateStatus.None)
			{
				return false;
			}
			this.Status |= ESunSpiritStateStatus.Entering;
			bool result = this.OnEnter();
			this.Status |= ESunSpiritStateStatus.Entered;
			return result;
		}

		// Token: 0x060437DD RID: 276445 RVA: 0x01080C33 File Offset: 0x0107EE33
		protected virtual bool OnEnter()
		{
			return true;
		}

		// Token: 0x060437DE RID: 276446 RVA: 0x01080C36 File Offset: 0x0107EE36
		public void Exit()
		{
			if ((this.Status & ESunSpiritStateStatus.Exiting) != ESunSpiritStateStatus.None)
			{
				return;
			}
			this.Status |= ESunSpiritStateStatus.Exiting;
			this.OnExit();
			this.Status |= ESunSpiritStateStatus.Exited;
		}

		// Token: 0x060437DF RID: 276447 RVA: 0x01080C65 File Offset: 0x0107EE65
		protected virtual void OnExit()
		{
		}

		// Token: 0x060437E0 RID: 276448 RVA: 0x01080C67 File Offset: 0x0107EE67
		public void Tick(float deltaSeconds)
		{
			if (!this.IsTickable())
			{
				return;
			}
			this.OnTick(deltaSeconds);
		}

		// Token: 0x060437E1 RID: 276449 RVA: 0x01080C79 File Offset: 0x0107EE79
		protected virtual void OnTick(float deltaSeconds)
		{
		}

		// Token: 0x060437E2 RID: 276450 RVA: 0x01080C7B File Offset: 0x0107EE7B
		public virtual bool IsSameState(SunSpiritBaseState otherState)
		{
			return this.StateType == otherState.StateType && otherState.GetType() == base.GetType();
		}

		// Token: 0x060437E3 RID: 276451 RVA: 0x01080C9E File Offset: 0x0107EE9E
		public bool IsTickable()
		{
			return (this.Status & ESunSpiritStateStatus.Entered) != ESunSpiritStateStatus.None && (this.Status & ESunSpiritStateStatus.Exited) == ESunSpiritStateStatus.None && this.NeedTickInternal;
		}

		// Token: 0x060437E4 RID: 276452 RVA: 0x01080CBC File Offset: 0x0107EEBC
		private bool HasTickFunc()
		{
			MethodInfo method = base.GetType().GetMethod("OnTick", BindingFlags.Instance | BindingFlags.NonPublic);
			return ((method != null) ? method.DeclaringType : null) != typeof(SunSpiritBaseState);
		}

		// Token: 0x040233AD RID: 144301
		protected ESunSpiritStateType StateTypeInternal;

		// Token: 0x040233AE RID: 144302
		protected SunSpiritData SunSpiritData;

		// Token: 0x040233AF RID: 144303
		private ESunSpiritStateStatus Status;

		// Token: 0x040233B0 RID: 144304
		public bool IsFinished;

		// Token: 0x040233B1 RID: 144305
		private bool NeedTickInternal;
	}
}
