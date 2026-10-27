using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EC0 RID: 20160
	public class IAttachTarget_UnionUnion
	{
		// Token: 0x170090A4 RID: 37028
		// (get) Token: 0x0601FC0B RID: 130059 RVA: 0x0046B9F6 File Offset: 0x00469BF6
		// (set) Token: 0x0601FC0C RID: 130060 RVA: 0x0046B9FE File Offset: 0x00469BFE
		public IAttachTarget_Union Type { get; set; }

		// Token: 0x170090A5 RID: 37029
		// (get) Token: 0x0601FC0D RID: 130061 RVA: 0x0046BA07 File Offset: 0x00469C07
		// (set) Token: 0x0601FC0E RID: 130062 RVA: 0x0046BA0F File Offset: 0x00469C0F
		public object Value { get; set; }

		// Token: 0x0601FC0F RID: 130063 RVA: 0x0046BA18 File Offset: 0x00469C18
		public IAttachTarget_UnionUnion()
		{
			this.Type = IAttachTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601FC10 RID: 130064 RVA: 0x0046BA2E File Offset: 0x00469C2E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601FC11 RID: 130065 RVA: 0x0046BA40 File Offset: 0x00469C40
		public IAttachTargetT AsIAttachTarget()
		{
			return this.As<IAttachTargetT>();
		}

		// Token: 0x0601FC12 RID: 130066 RVA: 0x0046BA48 File Offset: 0x00469C48
		public static IAttachTarget_UnionUnion FromIAttachTarget(IAttachTargetT _iattachtarget)
		{
			return new IAttachTarget_UnionUnion
			{
				Type = IAttachTarget_Union.IAttachTarget,
				Value = _iattachtarget
			};
		}

		// Token: 0x0601FC13 RID: 130067 RVA: 0x0046BA5D File Offset: 0x00469C5D
		public IActorAttachTargetT AsIActorAttachTarget()
		{
			return this.As<IActorAttachTargetT>();
		}

		// Token: 0x0601FC14 RID: 130068 RVA: 0x0046BA65 File Offset: 0x00469C65
		public static IAttachTarget_UnionUnion FromIActorAttachTarget(IActorAttachTargetT _iactorattachtarget)
		{
			return new IAttachTarget_UnionUnion
			{
				Type = IAttachTarget_Union.IActorAttachTarget,
				Value = _iactorattachtarget
			};
		}

		// Token: 0x0601FC15 RID: 130069 RVA: 0x0046BA7A File Offset: 0x00469C7A
		public IEntityAttachTargetT AsIEntityAttachTarget()
		{
			return this.As<IEntityAttachTargetT>();
		}

		// Token: 0x0601FC16 RID: 130070 RVA: 0x0046BA82 File Offset: 0x00469C82
		public static IAttachTarget_UnionUnion FromIEntityAttachTarget(IEntityAttachTargetT _ientityattachtarget)
		{
			return new IAttachTarget_UnionUnion
			{
				Type = IAttachTarget_Union.IEntityAttachTarget,
				Value = _ientityattachtarget
			};
		}

		// Token: 0x0601FC17 RID: 130071 RVA: 0x0046BA97 File Offset: 0x00469C97
		public IDynamicAttachTargetT AsIDynamicAttachTarget()
		{
			return this.As<IDynamicAttachTargetT>();
		}

		// Token: 0x0601FC18 RID: 130072 RVA: 0x0046BA9F File Offset: 0x00469C9F
		public static IAttachTarget_UnionUnion FromIDynamicAttachTarget(IDynamicAttachTargetT _idynamicattachtarget)
		{
			return new IAttachTarget_UnionUnion
			{
				Type = IAttachTarget_Union.IDynamicAttachTarget,
				Value = _idynamicattachtarget
			};
		}

		// Token: 0x0601FC19 RID: 130073 RVA: 0x0046BAB4 File Offset: 0x00469CB4
		public IPlayerAttachTargetT AsIPlayerAttachTarget()
		{
			return this.As<IPlayerAttachTargetT>();
		}

		// Token: 0x0601FC1A RID: 130074 RVA: 0x0046BABC File Offset: 0x00469CBC
		public static IAttachTarget_UnionUnion FromIPlayerAttachTarget(IPlayerAttachTargetT _iplayerattachtarget)
		{
			return new IAttachTarget_UnionUnion
			{
				Type = IAttachTarget_Union.IPlayerAttachTarget,
				Value = _iplayerattachtarget
			};
		}

		// Token: 0x0601FC1B RID: 130075 RVA: 0x0046BAD1 File Offset: 0x00469CD1
		public IPointAttachTargetT AsIPointAttachTarget()
		{
			return this.As<IPointAttachTargetT>();
		}

		// Token: 0x0601FC1C RID: 130076 RVA: 0x0046BAD9 File Offset: 0x00469CD9
		public static IAttachTarget_UnionUnion FromIPointAttachTarget(IPointAttachTargetT _ipointattachtarget)
		{
			return new IAttachTarget_UnionUnion
			{
				Type = IAttachTarget_Union.IPointAttachTarget,
				Value = _ipointattachtarget
			};
		}

		// Token: 0x0601FC1D RID: 130077 RVA: 0x0046BAF0 File Offset: 0x00469CF0
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
