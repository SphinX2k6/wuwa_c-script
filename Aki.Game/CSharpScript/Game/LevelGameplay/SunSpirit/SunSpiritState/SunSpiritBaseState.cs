using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritState
{
	// Token: 0x02005B56 RID: 23382
	[NullableContext(1)]
	[Nullable(0)]
	[OverrideFunctionRoot]
	public class SunSpiritBaseState
	{
		// Token: 0x06039823 RID: 235555 RVA: 0x01025221 File Offset: 0x01023421
		protected SunSpiritBaseState(ESunSpiritStateType stateTypeInternal, SunSpiritData sunSpiritData)
		{
			this.StateTypeInternal = stateTypeInternal;
			this.SunSpiritData = sunSpiritData;
			this.NeedTick = this.NeedTickInternal;
		}

		// Token: 0x17006D6D RID: 28013
		// (get) Token: 0x06039824 RID: 235556 RVA: 0x01025243 File Offset: 0x01023443
		public ESunSpiritStateType StateType
		{
			get
			{
				return this.StateTypeInternal;
			}
		}

		// Token: 0x06039825 RID: 235557 RVA: 0x0102524B File Offset: 0x0102344B
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

		// Token: 0x06039826 RID: 235558 RVA: 0x0102527B File Offset: 0x0102347B
		protected virtual bool OnEnter()
		{
			return true;
		}

		// Token: 0x06039827 RID: 235559 RVA: 0x0102527E File Offset: 0x0102347E
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

		// Token: 0x06039828 RID: 235560 RVA: 0x010252AD File Offset: 0x010234AD
		protected virtual void OnExit()
		{
		}

		// Token: 0x06039829 RID: 235561 RVA: 0x010252AF File Offset: 0x010234AF
		public void Tick(float deltaSeconds)
		{
			if (!this.IsTickable())
			{
				return;
			}
			this.OnTick(deltaSeconds);
		}

		// Token: 0x0603982A RID: 235562 RVA: 0x010252C1 File Offset: 0x010234C1
		[OverrideFunction]
		protected virtual void OnTick(float deltaSeconds)
		{
		}

		// Token: 0x0603982B RID: 235563 RVA: 0x010252C3 File Offset: 0x010234C3
		public virtual bool IsSameState(SunSpiritBaseState otherState)
		{
			return this.StateType == otherState.StateType && otherState.GetType() == base.GetType();
		}

		// Token: 0x0603982C RID: 235564 RVA: 0x010252E6 File Offset: 0x010234E6
		public bool IsTickable()
		{
			return (this.Status & ESunSpiritStateStatus.Entered) != ESunSpiritStateStatus.None && (this.Status & ESunSpiritStateStatus.Exited) == ESunSpiritStateStatus.None && this.NeedTick;
		}

		// Token: 0x17006D6E RID: 28014
		// (get) Token: 0x0603982D RID: 235565 RVA: 0x01025304 File Offset: 0x01023504
		public virtual bool NeedTickInternal
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0401E59F RID: 124319
		protected ESunSpiritStateType StateTypeInternal;

		// Token: 0x0401E5A0 RID: 124320
		protected SunSpiritData SunSpiritData;

		// Token: 0x0401E5A1 RID: 124321
		public readonly bool NeedTick;

		// Token: 0x0401E5A2 RID: 124322
		private ESunSpiritStateStatus Status;

		// Token: 0x0401E5A3 RID: 124323
		public bool IsFinished;
	}
}
