using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053E9 RID: 21481
	public class IAttachTarget_UnionUnion
	{
		// Token: 0x17009805 RID: 38917
		// (get) Token: 0x0602190D RID: 137485 RVA: 0x004A0ED2 File Offset: 0x0049F0D2
		// (set) Token: 0x0602190E RID: 137486 RVA: 0x004A0EDA File Offset: 0x0049F0DA
		public IAttachTarget_Union Type { get; set; }

		// Token: 0x17009806 RID: 38918
		// (get) Token: 0x0602190F RID: 137487 RVA: 0x004A0EE3 File Offset: 0x0049F0E3
		// (set) Token: 0x06021910 RID: 137488 RVA: 0x004A0EEB File Offset: 0x0049F0EB
		public object Value { get; set; }

		// Token: 0x06021911 RID: 137489 RVA: 0x004A0EF4 File Offset: 0x0049F0F4
		public IAttachTarget_UnionUnion()
		{
			this.Type = IAttachTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06021912 RID: 137490 RVA: 0x004A0F0A File Offset: 0x0049F10A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021913 RID: 137491 RVA: 0x004A0F1C File Offset: 0x0049F11C
		public IAttachTargetT AsIAttachTarget()
		{
			return this.As<IAttachTargetT>();
		}

		// Token: 0x06021914 RID: 137492 RVA: 0x004A0F24 File Offset: 0x0049F124
		public static IAttachTarget_UnionUnion FromIAttachTarget(IAttachTargetT _iattachtarget)
		{
			return new IAttachTarget_UnionUnion
			{
				Type = IAttachTarget_Union.IAttachTarget,
				Value = _iattachtarget
			};
		}

		// Token: 0x06021915 RID: 137493 RVA: 0x004A0F39 File Offset: 0x0049F139
		public IActorAttachTargetT AsIActorAttachTarget()
		{
			return this.As<IActorAttachTargetT>();
		}

		// Token: 0x06021916 RID: 137494 RVA: 0x004A0F41 File Offset: 0x0049F141
		public static IAttachTarget_UnionUnion FromIActorAttachTarget(IActorAttachTargetT _iactorattachtarget)
		{
			return new IAttachTarget_UnionUnion
			{
				Type = IAttachTarget_Union.IActorAttachTarget,
				Value = _iactorattachtarget
			};
		}

		// Token: 0x06021917 RID: 137495 RVA: 0x004A0F56 File Offset: 0x0049F156
		public IEntityAttachTargetT AsIEntityAttachTarget()
		{
			return this.As<IEntityAttachTargetT>();
		}

		// Token: 0x06021918 RID: 137496 RVA: 0x004A0F5E File Offset: 0x0049F15E
		public static IAttachTarget_UnionUnion FromIEntityAttachTarget(IEntityAttachTargetT _ientityattachtarget)
		{
			return new IAttachTarget_UnionUnion
			{
				Type = IAttachTarget_Union.IEntityAttachTarget,
				Value = _ientityattachtarget
			};
		}

		// Token: 0x06021919 RID: 137497 RVA: 0x004A0F73 File Offset: 0x0049F173
		public IDynamicAttachTargetT AsIDynamicAttachTarget()
		{
			return this.As<IDynamicAttachTargetT>();
		}

		// Token: 0x0602191A RID: 137498 RVA: 0x004A0F7B File Offset: 0x0049F17B
		public static IAttachTarget_UnionUnion FromIDynamicAttachTarget(IDynamicAttachTargetT _idynamicattachtarget)
		{
			return new IAttachTarget_UnionUnion
			{
				Type = IAttachTarget_Union.IDynamicAttachTarget,
				Value = _idynamicattachtarget
			};
		}

		// Token: 0x0602191B RID: 137499 RVA: 0x004A0F90 File Offset: 0x0049F190
		public IPlayerAttachTargetT AsIPlayerAttachTarget()
		{
			return this.As<IPlayerAttachTargetT>();
		}

		// Token: 0x0602191C RID: 137500 RVA: 0x004A0F98 File Offset: 0x0049F198
		public static IAttachTarget_UnionUnion FromIPlayerAttachTarget(IPlayerAttachTargetT _iplayerattachtarget)
		{
			return new IAttachTarget_UnionUnion
			{
				Type = IAttachTarget_Union.IPlayerAttachTarget,
				Value = _iplayerattachtarget
			};
		}

		// Token: 0x0602191D RID: 137501 RVA: 0x004A0FAD File Offset: 0x0049F1AD
		public IPointAttachTargetT AsIPointAttachTarget()
		{
			return this.As<IPointAttachTargetT>();
		}

		// Token: 0x0602191E RID: 137502 RVA: 0x004A0FB5 File Offset: 0x0049F1B5
		public static IAttachTarget_UnionUnion FromIPointAttachTarget(IPointAttachTargetT _ipointattachtarget)
		{
			return new IAttachTarget_UnionUnion
			{
				Type = IAttachTarget_Union.IPointAttachTarget,
				Value = _ipointattachtarget
			};
		}

		// Token: 0x0602191F RID: 137503 RVA: 0x004A0FCC File Offset: 0x0049F1CC
		public static int Pack(FlatBufferBuilder builder, IAttachTarget_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IAttachTarget_Union.IAttachTarget:
				return IAttachTarget.Pack(builder, _o.AsIAttachTarget()).Value;
			case IAttachTarget_Union.IActorAttachTarget:
				return IActorAttachTarget.Pack(builder, _o.AsIActorAttachTarget()).Value;
			case IAttachTarget_Union.IEntityAttachTarget:
				return IEntityAttachTarget.Pack(builder, _o.AsIEntityAttachTarget()).Value;
			case IAttachTarget_Union.IDynamicAttachTarget:
				return IDynamicAttachTarget.Pack(builder, _o.AsIDynamicAttachTarget()).Value;
			case IAttachTarget_Union.IPlayerAttachTarget:
				return IPlayerAttachTarget.Pack(builder, _o.AsIPlayerAttachTarget()).Value;
			case IAttachTarget_Union.IPointAttachTarget:
				return IPointAttachTarget.Pack(builder, _o.AsIPointAttachTarget()).Value;
			default:
				return 0;
			}
		}
	}
}
