using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C5E RID: 15454
	public struct ITipsActorTransformResult : IFlatbufferObject
	{
		// Token: 0x17006A97 RID: 27287
		// (get) Token: 0x06015609 RID: 87561 RVA: 0x00317774 File Offset: 0x00315974
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601560A RID: 87562 RVA: 0x00317781 File Offset: 0x00315981
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601560B RID: 87563 RVA: 0x00317788 File Offset: 0x00315988
		public static ITipsActorTransformResult GetRootAsITipsActorTransformResult(ByteBuffer _bb)
		{
			return ITipsActorTransformResult.GetRootAsITipsActorTransformResult(_bb, default(ITipsActorTransformResult));
		}

		// Token: 0x0601560C RID: 87564 RVA: 0x003177A4 File Offset: 0x003159A4
		public static ITipsActorTransformResult GetRootAsITipsActorTransformResult(ByteBuffer _bb, ITipsActorTransformResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601560D RID: 87565 RVA: 0x003177C1 File Offset: 0x003159C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601560E RID: 87566 RVA: 0x003177D0 File Offset: 0x003159D0
		public ITipsActorTransformResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006A98 RID: 27288
		// (get) Token: 0x0601560F RID: 87567 RVA: 0x003177E0 File Offset: 0x003159E0
		public bool IsSuccess
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006A99 RID: 27289
		// (get) Token: 0x06015610 RID: 87568 RVA: 0x00317820 File Offset: 0x00315A20
		public string Reason
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015611 RID: 87569 RVA: 0x00317857 File Offset: 0x00315A57
		public Span<byte> GetReasonBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06015612 RID: 87570 RVA: 0x00317866 File Offset: 0x00315A66
		public byte[] GetReasonArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006A9A RID: 27290
		// (get) Token: 0x06015613 RID: 87571 RVA: 0x00317874 File Offset: 0x00315A74
		public ETipsActorTransformType Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ETipsActorTransformType.Absolute;
				}
				return (ETipsActorTransformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006A9B RID: 27291
		// (get) Token: 0x06015614 RID: 87572 RVA: 0x003178B0 File Offset: 0x00315AB0
		public IShapeTransform? TransformWorld
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IShapeTransform?(default(IShapeTransform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006A9C RID: 27292
		// (get) Token: 0x06015615 RID: 87573 RVA: 0x00317910 File Offset: 0x00315B10
		public IHollowTipsActorComponent? HollowTipsActorComponent
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IHollowTipsActorComponent?(default(IHollowTipsActorComponent).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06015616 RID: 87574 RVA: 0x0031796E File Offset: 0x00315B6E
		public static Offset<ITipsActorTransformResult> CreateITipsActorTransformResult(FlatBufferBuilder builder, bool IsSuccess = false, StringOffset ReasonOffset = default(StringOffset), ETipsActorTransformType Type = ETipsActorTransformType.Absolute, Offset<IShapeTransform> TransformWorldOffset = default(Offset<IShapeTransform>), Offset<IHollowTipsActorComponent> HollowTipsActorComponentOffset = default(Offset<IHollowTipsActorComponent>))
		{
			builder.StartTable(5);
			ITipsActorTransformResult.AddHollowTipsActorComponent(builder, HollowTipsActorComponentOffset);
			ITipsActorTransformResult.AddTransformWorld(builder, TransformWorldOffset);
			ITipsActorTransformResult.AddReason(builder, ReasonOffset);
			ITipsActorTransformResult.AddType(builder, Type);
			ITipsActorTransformResult.AddIsSuccess(builder, IsSuccess);
			return ITipsActorTransformResult.EndITipsActorTransformResult(builder);
		}

		// Token: 0x06015617 RID: 87575 RVA: 0x003179A2 File Offset: 0x00315BA2
		public static void StartITipsActorTransformResult(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06015618 RID: 87576 RVA: 0x003179AB File Offset: 0x00315BAB
		public static void AddIsSuccess(FlatBufferBuilder builder, bool isSuccess)
		{
			builder.AddBool(0, isSuccess, false);
		}

		// Token: 0x06015619 RID: 87577 RVA: 0x003179B6 File Offset: 0x00315BB6
		public static void AddReason(FlatBufferBuilder builder, StringOffset reasonOffset)
		{
			builder.AddOffset(1, reasonOffset.Value, 0);
		}

		// Token: 0x0601561A RID: 87578 RVA: 0x003179C6 File Offset: 0x00315BC6
		public static void AddType(FlatBufferBuilder builder, ETipsActorTransformType type)
		{
			builder.AddByte(2, (byte)type, 0);
		}

		// Token: 0x0601561B RID: 87579 RVA: 0x003179D1 File Offset: 0x00315BD1
		public static void AddTransformWorld(FlatBufferBuilder builder, Offset<IShapeTransform> transformWorldOffset)
		{
			builder.AddOffset(3, transformWorldOffset.Value, 0);
		}

		// Token: 0x0601561C RID: 87580 RVA: 0x003179E1 File Offset: 0x00315BE1
		public static void AddHollowTipsActorComponent(FlatBufferBuilder builder, Offset<IHollowTipsActorComponent> hollowTipsActorComponentOffset)
		{
			builder.AddOffset(4, hollowTipsActorComponentOffset.Value, 0);
		}

		// Token: 0x0601561D RID: 87581 RVA: 0x003179F1 File Offset: 0x00315BF1
		public static Offset<ITipsActorTransformResult> EndITipsActorTransformResult(FlatBufferBuilder builder)
		{
			return new Offset<ITipsActorTransformResult>(builder.EndTable());
		}

		// Token: 0x0601561E RID: 87582 RVA: 0x00317A00 File Offset: 0x00315C00
		public ITipsActorTransformResultT UnPack()
		{
			ITipsActorTransformResultT tipsActorTransformResultT = new ITipsActorTransformResultT();
			this.UnPackTo(tipsActorTransformResultT);
			return tipsActorTransformResultT;
		}

		// Token: 0x0601561F RID: 87583 RVA: 0x00317A1C File Offset: 0x00315C1C
		public void UnPackTo(ITipsActorTransformResultT _o)
		{
			_o.IsSuccess = this.IsSuccess;
			_o.Reason = this.Reason;
			_o.Type = this.Type;
			_o.TransformWorld = ((this.TransformWorld != null) ? this.TransformWorld.Value.UnPack() : null);
			_o.HollowTipsActorComponent = ((this.HollowTipsActorComponent != null) ? this.HollowTipsActorComponent.Value.UnPack() : null);
		}

		// Token: 0x06015620 RID: 87584 RVA: 0x00317AAC File Offset: 0x00315CAC
		public static Offset<ITipsActorTransformResult> Pack(FlatBufferBuilder builder, ITipsActorTransformResultT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITipsActorTransformResult>);
			}
			StringOffset reasonOffset = (_o.Reason == null) ? default(StringOffset) : builder.CreateString(_o.Reason);
			Offset<IShapeTransform> transformWorldOffset = (_o.TransformWorld == null) ? default(Offset<IShapeTransform>) : IShapeTransform.Pack(builder, _o.TransformWorld);
			Offset<IHollowTipsActorComponent> hollowTipsActorComponentOffset = (_o.HollowTipsActorComponent == null) ? default(Offset<IHollowTipsActorComponent>) : IHollowTipsActorComponent.Pack(builder, _o.HollowTipsActorComponent);
			return ITipsActorTransformResult.CreateITipsActorTransformResult(builder, _o.IsSuccess, reasonOffset, _o.Type, transformWorldOffset, hollowTipsActorComponentOffset);
		}

		// Token: 0x0400B27B RID: 45691
		private Table __p;
	}
}
