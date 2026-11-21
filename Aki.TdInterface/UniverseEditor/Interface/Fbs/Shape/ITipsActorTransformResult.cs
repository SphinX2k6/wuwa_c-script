using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200406D RID: 16493
	public struct ITipsActorTransformResult : IFlatbufferObject
	{
		// Token: 0x17007048 RID: 28744
		// (get) Token: 0x06016B1D RID: 92957 RVA: 0x0033E614 File Offset: 0x0033C814
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016B1E RID: 92958 RVA: 0x0033E621 File Offset: 0x0033C821
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016B1F RID: 92959 RVA: 0x0033E628 File Offset: 0x0033C828
		public static ITipsActorTransformResult GetRootAsITipsActorTransformResult(ByteBuffer _bb)
		{
			return ITipsActorTransformResult.GetRootAsITipsActorTransformResult(_bb, default(ITipsActorTransformResult));
		}

		// Token: 0x06016B20 RID: 92960 RVA: 0x0033E644 File Offset: 0x0033C844
		public static ITipsActorTransformResult GetRootAsITipsActorTransformResult(ByteBuffer _bb, ITipsActorTransformResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016B21 RID: 92961 RVA: 0x0033E661 File Offset: 0x0033C861
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016B22 RID: 92962 RVA: 0x0033E670 File Offset: 0x0033C870
		public ITipsActorTransformResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007049 RID: 28745
		// (get) Token: 0x06016B23 RID: 92963 RVA: 0x0033E680 File Offset: 0x0033C880
		public bool IsSuccess
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700704A RID: 28746
		// (get) Token: 0x06016B24 RID: 92964 RVA: 0x0033E6C0 File Offset: 0x0033C8C0
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

		// Token: 0x06016B25 RID: 92965 RVA: 0x0033E6F7 File Offset: 0x0033C8F7
		public Span<byte> GetReasonBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06016B26 RID: 92966 RVA: 0x0033E706 File Offset: 0x0033C906
		public byte[] GetReasonArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700704B RID: 28747
		// (get) Token: 0x06016B27 RID: 92967 RVA: 0x0033E714 File Offset: 0x0033C914
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

		// Token: 0x1700704C RID: 28748
		// (get) Token: 0x06016B28 RID: 92968 RVA: 0x0033E750 File Offset: 0x0033C950
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

		// Token: 0x1700704D RID: 28749
		// (get) Token: 0x06016B29 RID: 92969 RVA: 0x0033E7B0 File Offset: 0x0033C9B0
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

		// Token: 0x06016B2A RID: 92970 RVA: 0x0033E80E File Offset: 0x0033CA0E
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

		// Token: 0x06016B2B RID: 92971 RVA: 0x0033E842 File Offset: 0x0033CA42
		public static void StartITipsActorTransformResult(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06016B2C RID: 92972 RVA: 0x0033E84B File Offset: 0x0033CA4B
		public static void AddIsSuccess(FlatBufferBuilder builder, bool isSuccess)
		{
			builder.AddBool(0, isSuccess, false);
		}

		// Token: 0x06016B2D RID: 92973 RVA: 0x0033E856 File Offset: 0x0033CA56
		public static void AddReason(FlatBufferBuilder builder, StringOffset reasonOffset)
		{
			builder.AddOffset(1, reasonOffset.Value, 0);
		}

		// Token: 0x06016B2E RID: 92974 RVA: 0x0033E866 File Offset: 0x0033CA66
		public static void AddType(FlatBufferBuilder builder, ETipsActorTransformType type)
		{
			builder.AddByte(2, (byte)type, 0);
		}

		// Token: 0x06016B2F RID: 92975 RVA: 0x0033E871 File Offset: 0x0033CA71
		public static void AddTransformWorld(FlatBufferBuilder builder, Offset<IShapeTransform> transformWorldOffset)
		{
			builder.AddOffset(3, transformWorldOffset.Value, 0);
		}

		// Token: 0x06016B30 RID: 92976 RVA: 0x0033E881 File Offset: 0x0033CA81
		public static void AddHollowTipsActorComponent(FlatBufferBuilder builder, Offset<IHollowTipsActorComponent> hollowTipsActorComponentOffset)
		{
			builder.AddOffset(4, hollowTipsActorComponentOffset.Value, 0);
		}

		// Token: 0x06016B31 RID: 92977 RVA: 0x0033E891 File Offset: 0x0033CA91
		public static Offset<ITipsActorTransformResult> EndITipsActorTransformResult(FlatBufferBuilder builder)
		{
			return new Offset<ITipsActorTransformResult>(builder.EndTable());
		}

		// Token: 0x06016B32 RID: 92978 RVA: 0x0033E8A0 File Offset: 0x0033CAA0
		public ITipsActorTransformResultT UnPack()
		{
			ITipsActorTransformResultT tipsActorTransformResultT = new ITipsActorTransformResultT();
			this.UnPackTo(tipsActorTransformResultT);
			return tipsActorTransformResultT;
		}

		// Token: 0x06016B33 RID: 92979 RVA: 0x0033E8BC File Offset: 0x0033CABC
		public void UnPackTo(ITipsActorTransformResultT _o)
		{
			_o.IsSuccess = this.IsSuccess;
			_o.Reason = this.Reason;
			_o.Type = this.Type;
			_o.TransformWorld = ((this.TransformWorld != null) ? this.TransformWorld.Value.UnPack() : null);
			_o.HollowTipsActorComponent = ((this.HollowTipsActorComponent != null) ? this.HollowTipsActorComponent.Value.UnPack() : null);
		}

		// Token: 0x06016B34 RID: 92980 RVA: 0x0033E94C File Offset: 0x0033CB4C
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

		// Token: 0x0400BC0B RID: 48139
		private Table __p;
	}
}
