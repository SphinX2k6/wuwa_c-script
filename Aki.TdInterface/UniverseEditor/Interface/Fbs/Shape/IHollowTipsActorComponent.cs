using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004031 RID: 16433
	public struct IHollowTipsActorComponent : IFlatbufferObject
	{
		// Token: 0x17006FA6 RID: 28582
		// (get) Token: 0x060168E5 RID: 92389 RVA: 0x0033A373 File Offset: 0x00338573
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060168E6 RID: 92390 RVA: 0x0033A380 File Offset: 0x00338580
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060168E7 RID: 92391 RVA: 0x0033A388 File Offset: 0x00338588
		public static IHollowTipsActorComponent GetRootAsIHollowTipsActorComponent(ByteBuffer _bb)
		{
			return IHollowTipsActorComponent.GetRootAsIHollowTipsActorComponent(_bb, default(IHollowTipsActorComponent));
		}

		// Token: 0x060168E8 RID: 92392 RVA: 0x0033A3A4 File Offset: 0x003385A4
		public static IHollowTipsActorComponent GetRootAsIHollowTipsActorComponent(ByteBuffer _bb, IHollowTipsActorComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060168E9 RID: 92393 RVA: 0x0033A3C1 File Offset: 0x003385C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060168EA RID: 92394 RVA: 0x0033A3D0 File Offset: 0x003385D0
		public IHollowTipsActorComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FA7 RID: 28583
		// (get) Token: 0x060168EB RID: 92395 RVA: 0x0033A3E0 File Offset: 0x003385E0
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

		// Token: 0x17006FA8 RID: 28584
		// (get) Token: 0x060168EC RID: 92396 RVA: 0x0033A440 File Offset: 0x00338640
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

		// Token: 0x060168ED RID: 92397 RVA: 0x0033A49D File Offset: 0x0033869D
		public static Offset<IHollowTipsActorComponent> CreateIHollowTipsActorComponent(FlatBufferBuilder builder, Offset<IShapeTransform> InnerShapeCompTransformOffset = default(Offset<IShapeTransform>), Offset<IShapeTransform> OuterShapeCompTransformOffset = default(Offset<IShapeTransform>))
		{
			builder.StartTable(2);
			IHollowTipsActorComponent.AddOuterShapeCompTransform(builder, OuterShapeCompTransformOffset);
			IHollowTipsActorComponent.AddInnerShapeCompTransform(builder, InnerShapeCompTransformOffset);
			return IHollowTipsActorComponent.EndIHollowTipsActorComponent(builder);
		}

		// Token: 0x060168EE RID: 92398 RVA: 0x0033A4BA File Offset: 0x003386BA
		public static void StartIHollowTipsActorComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060168EF RID: 92399 RVA: 0x0033A4C3 File Offset: 0x003386C3
		public static void AddInnerShapeCompTransform(FlatBufferBuilder builder, Offset<IShapeTransform> innerShapeCompTransformOffset)
		{
			builder.AddOffset(0, innerShapeCompTransformOffset.Value, 0);
		}

		// Token: 0x060168F0 RID: 92400 RVA: 0x0033A4D3 File Offset: 0x003386D3
		public static void AddOuterShapeCompTransform(FlatBufferBuilder builder, Offset<IShapeTransform> outerShapeCompTransformOffset)
		{
			builder.AddOffset(1, outerShapeCompTransformOffset.Value, 0);
		}

		// Token: 0x060168F1 RID: 92401 RVA: 0x0033A4E3 File Offset: 0x003386E3
		public static Offset<IHollowTipsActorComponent> EndIHollowTipsActorComponent(FlatBufferBuilder builder)
		{
			return new Offset<IHollowTipsActorComponent>(builder.EndTable());
		}

		// Token: 0x060168F2 RID: 92402 RVA: 0x0033A4F0 File Offset: 0x003386F0
		public IHollowTipsActorComponentT UnPack()
		{
			IHollowTipsActorComponentT hollowTipsActorComponentT = new IHollowTipsActorComponentT();
			this.UnPackTo(hollowTipsActorComponentT);
			return hollowTipsActorComponentT;
		}

		// Token: 0x060168F3 RID: 92403 RVA: 0x0033A50C File Offset: 0x0033870C
		public void UnPackTo(IHollowTipsActorComponentT _o)
		{
			_o.InnerShapeCompTransform = ((this.InnerShapeCompTransform != null) ? this.InnerShapeCompTransform.Value.UnPack() : null);
			_o.OuterShapeCompTransform = ((this.OuterShapeCompTransform != null) ? this.OuterShapeCompTransform.Value.UnPack() : null);
		}

		// Token: 0x060168F4 RID: 92404 RVA: 0x0033A578 File Offset: 0x00338778
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

		// Token: 0x0400BBA4 RID: 48036
		private Table __p;
	}
}
