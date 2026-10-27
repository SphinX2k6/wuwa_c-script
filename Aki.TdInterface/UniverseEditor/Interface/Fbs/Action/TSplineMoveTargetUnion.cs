using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077A2 RID: 30626
	public class TSplineMoveTargetUnion
	{
		// Token: 0x1700E6AF RID: 59055
		// (get) Token: 0x06037956 RID: 227670 RVA: 0x0078506A File Offset: 0x0078326A
		// (set) Token: 0x06037957 RID: 227671 RVA: 0x00785072 File Offset: 0x00783272
		public TSplineMoveTarget Type { get; set; }

		// Token: 0x1700E6B0 RID: 59056
		// (get) Token: 0x06037958 RID: 227672 RVA: 0x0078507B File Offset: 0x0078327B
		// (set) Token: 0x06037959 RID: 227673 RVA: 0x00785083 File Offset: 0x00783283
		public object Value { get; set; }

		// Token: 0x0603795A RID: 227674 RVA: 0x0078508C File Offset: 0x0078328C
		public TSplineMoveTargetUnion()
		{
			this.Type = TSplineMoveTarget.NONE;
			this.Value = null;
		}

		// Token: 0x0603795B RID: 227675 RVA: 0x007850A2 File Offset: 0x007832A2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603795C RID: 227676 RVA: 0x007850B4 File Offset: 0x007832B4
		public IEntitySplineMoveTargetT AsIEntitySplineMoveTarget()
		{
			return this.As<IEntitySplineMoveTargetT>();
		}

		// Token: 0x0603795D RID: 227677 RVA: 0x007850BC File Offset: 0x007832BC
		public static TSplineMoveTargetUnion FromIEntitySplineMoveTarget(IEntitySplineMoveTargetT _ientitysplinemovetarget)
		{
			return new TSplineMoveTargetUnion
			{
				Type = TSplineMoveTarget.IEntitySplineMoveTarget,
				Value = _ientitysplinemovetarget
			};
		}

		// Token: 0x0603795E RID: 227678 RVA: 0x007850D1 File Offset: 0x007832D1
		public IPlayerSplineMoveTargetT AsIPlayerSplineMoveTarget()
		{
			return this.As<IPlayerSplineMoveTargetT>();
		}

		// Token: 0x0603795F RID: 227679 RVA: 0x007850D9 File Offset: 0x007832D9
		public static TSplineMoveTargetUnion FromIPlayerSplineMoveTarget(IPlayerSplineMoveTargetT _iplayersplinemovetarget)
		{
			return new TSplineMoveTargetUnion
			{
				Type = TSplineMoveTarget.IPlayerSplineMoveTarget,
				Value = _iplayersplinemovetarget
			};
		}

		// Token: 0x06037960 RID: 227680 RVA: 0x007850F0 File Offset: 0x007832F0
		public static int Pack(FlatBufferBuilder builder, TSplineMoveTargetUnion _o)
		{
			TSplineMoveTarget type = _o.Type;
			if (type == TSplineMoveTarget.IEntitySplineMoveTarget)
			{
				return IEntitySplineMoveTarget.Pack(builder, _o.AsIEntitySplineMoveTarget()).Value;
			}
			if (type != TSplineMoveTarget.IPlayerSplineMoveTarget)
			{
				return 0;
			}
			return IPlayerSplineMoveTarget.Pack(builder, _o.AsIPlayerSplineMoveTarget()).Value;
		}
	}
}
