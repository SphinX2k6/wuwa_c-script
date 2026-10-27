using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C25 RID: 15397
	public struct IHollowTipsActorComponent : IFlatbufferObject
	{
		// Token: 0x170069FE RID: 27134
		// (get) Token: 0x060153EF RID: 87023 RVA: 0x003137EB File Offset: 0x003119EB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060153F0 RID: 87024 RVA: 0x003137F8 File Offset: 0x003119F8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060153F1 RID: 87025 RVA: 0x00313800 File Offset: 0x00311A00
		public static IHollowTipsActorComponent GetRootAsIHollowTipsActorComponent(ByteBuffer _bb)
		{
			return IHollowTipsActorComponent.GetRootAsIHollowTipsActorComponent(_bb, default(IHollowTipsActorComponent));
		}

		// Token: 0x060153F2 RID: 87026 RVA: 0x0031381C File Offset: 0x00311A1C
		public static IHollowTipsActorComponent GetRootAsIHollowTipsActorComponent(ByteBuffer _bb, IHollowTipsActorComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060153F3 RID: 87027 RVA: 0x00313839 File Offset: 0x00311A39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060153F4 RID: 87028 RVA: 0x00313848 File Offset: 0x00311A48
		public IHollowTipsActorComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170069FF RID: 27135
		// (get) Token: 0x060153F5 RID: 87029 RVA: 0x00313858 File Offset: 0x00311A58
		public IShapeTransform? InnerShapeCompTransform
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IShapeTransform?(default(IShapeTransform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006A00 RID: 27136
		// (get) Token: 0x060153F6 RID: 87030 RVA: 0x003138B8 File Offset: 0x00311AB8
		public IShapeTransform? OuterShapeCompTransform
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IShapeTransform?(default(IShapeTransform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060153F7 RID: 87031 RVA: 0x00313915 File Offset: 0x00311B15
		public static Offset<IHollowTipsActorComponent> CreateIHollowTipsActorComponent(FlatBufferBuilder builder, Offset<IShapeTransform> InnerShapeCompTransformOffset = default(Offset<IShapeTransform>), Offset<IShapeTransform> OuterShapeCompTransformOffset = default(Offset<IShapeTransform>))
		{
			builder.StartTable(2);
			IHollowTipsActorComponent.AddOuterShapeCompTransform(builder, OuterShapeCompTransformOffset);
			IHollowTipsActorComponent.AddInnerShapeCompTransform(builder, InnerShapeCompTransformOffset);
			return IHollowTipsActorComponent.EndIHollowTipsActorComponent(builder);
		}

		// Token: 0x060153F8 RID: 87032 RVA: 0x00313932 File Offset: 0x00311B32
		public static void StartIHollowTipsActorComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060153F9 RID: 87033 RVA: 0x0031393B File Offset: 0x00311B3B
		public static void AddInnerShapeCompTransform(FlatBufferBuilder builder, Offset<IShapeTransform> innerShapeCompTransformOffset)
		{
			builder.AddOffset(0, innerShapeCompTransformOffset.Value, 0);
		}

		// Token: 0x060153FA RID: 87034 RVA: 0x0031394B File Offset: 0x00311B4B
		public static void AddOuterShapeCompTransform(FlatBufferBuilder builder, Offset<IShapeTransform> outerShapeCompTransformOffset)
		{
			builder.AddOffset(1, outerShapeCompTransformOffset.Value, 0);
		}

		// Token: 0x060153FB RID: 87035 RVA: 0x0031395B File Offset: 0x00311B5B
		public static Offset<IHollowTipsActorComponent> EndIHollowTipsActorComponent(FlatBufferBuilder builder)
		{
			return new Offset<IHollowTipsActorComponent>(builder.EndTable());
		}

		// Token: 0x060153FC RID: 87036 RVA: 0x00313968 File Offset: 0x00311B68
		public IHollowTipsActorComponentT UnPack()
		{
			IHollowTipsActorComponentT hollowTipsActorComponentT = new IHollowTipsActorComponentT();
			this.UnPackTo(hollowTipsActorComponentT);
			return hollowTipsActorComponentT;
		}

		// Token: 0x060153FD RID: 87037 RVA: 0x00313984 File Offset: 0x00311B84
		public void UnPackTo(IHollowTipsActorComponentT _o)
		{
			_o.InnerShapeCompTransform = ((this.InnerShapeCompTransform != null) ? this.InnerShapeCompTransform.Value.UnPack() : null);
			_o.OuterShapeCompTransform = ((this.OuterShapeCompTransform != null) ? this.OuterShapeCompTransform.Value.UnPack() : null);
		}

		// Token: 0x060153FE RID: 87038 RVA: 0x003139F0 File Offset: 0x00311BF0
		public static Offset<IHollowTipsActorComponent> Pack(FlatBufferBuilder builder, IHollowTipsActorComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHollowTipsActorComponent>);
			}
			Offset<IShapeTransform> innerShapeCompTransformOffset = (_o.InnerShapeCompTransform == null) ? default(Offset<IShapeTransform>) : IShapeTransform.Pack(builder, _o.InnerShapeCompTransform);
			Offset<IShapeTransform> outerShapeCompTransformOffset = (_o.OuterShapeCompTransform == null) ? default(Offset<IShapeTransform>) : IShapeTransform.Pack(builder, _o.OuterShapeCompTransform);
			return IHollowTipsActorComponent.CreateIHollowTipsActorComponent(builder, innerShapeCompTransformOffset, outerShapeCompTransformOffset);
		}

		// Token: 0x0400B219 RID: 45593
		private Table __p;
	}
}
