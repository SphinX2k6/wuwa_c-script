using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C34 RID: 15412
	public struct IRelativeTipsActorTransformResult : IFlatbufferObject
	{
		// Token: 0x17006A1C RID: 27164
		// (get) Token: 0x06015467 RID: 87143 RVA: 0x003145E6 File Offset: 0x003127E6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015468 RID: 87144 RVA: 0x003145F3 File Offset: 0x003127F3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015469 RID: 87145 RVA: 0x003145FC File Offset: 0x003127FC
		public static IRelativeTipsActorTransformResult GetRootAsIRelativeTipsActorTransformResult(ByteBuffer _bb)
		{
			return IRelativeTipsActorTransformResult.GetRootAsIRelativeTipsActorTransformResult(_bb, default(IRelativeTipsActorTransformResult));
		}

		// Token: 0x0601546A RID: 87146 RVA: 0x00314618 File Offset: 0x00312818
		public static IRelativeTipsActorTransformResult GetRootAsIRelativeTipsActorTransformResult(ByteBuffer _bb, IRelativeTipsActorTransformResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601546B RID: 87147 RVA: 0x00314635 File Offset: 0x00312835
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601546C RID: 87148 RVA: 0x00314644 File Offset: 0x00312844
		public IRelativeTipsActorTransformResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006A1D RID: 27165
		// (get) Token: 0x0601546D RID: 87149 RVA: 0x00314654 File Offset: 0x00312854
		public bool IsSuccess
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006A1E RID: 27166
		// (get) Token: 0x0601546E RID: 87150 RVA: 0x00314694 File Offset: 0x00312894
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

		// Token: 0x0601546F RID: 87151 RVA: 0x003146CB File Offset: 0x003128CB
		public Span<byte> GetReasonBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06015470 RID: 87152 RVA: 0x003146DA File Offset: 0x003128DA
		public byte[] GetReasonArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006A1F RID: 27167
		// (get) Token: 0x06015471 RID: 87153 RVA: 0x003146E8 File Offset: 0x003128E8
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

		// Token: 0x17006A20 RID: 27168
		// (get) Token: 0x06015472 RID: 87154 RVA: 0x00314724 File Offset: 0x00312924
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

		// Token: 0x17006A21 RID: 27169
		// (get) Token: 0x06015473 RID: 87155 RVA: 0x00314784 File Offset: 0x00312984
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

		// Token: 0x17006A22 RID: 27170
		// (get) Token: 0x06015474 RID: 87156 RVA: 0x003147E4 File Offset: 0x003129E4
		public IShapeTransform? TransformEntity
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IShapeTransform?(default(IShapeTransform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06015475 RID: 87157 RVA: 0x00314842 File Offset: 0x00312A42
		public static Offset<IRelativeTipsActorTransformResult> CreateIRelativeTipsActorTransformResult(FlatBufferBuilder builder, bool IsSuccess = false, StringOffset ReasonOffset = default(StringOffset), ETipsActorTransformType Type = ETipsActorTransformType.Absolute, Offset<IShapeTransform> TransformWorldOffset = default(Offset<IShapeTransform>), Offset<IHollowTipsActorComponent> HollowTipsActorComponentOffset = default(Offset<IHollowTipsActorComponent>), Offset<IShapeTransform> TransformEntityOffset = default(Offset<IShapeTransform>))
		{
			builder.StartTable(6);
			IRelativeTipsActorTransformResult.AddTransformEntity(builder, TransformEntityOffset);
			IRelativeTipsActorTransformResult.AddHollowTipsActorComponent(builder, HollowTipsActorComponentOffset);
			IRelativeTipsActorTransformResult.AddTransformWorld(builder, TransformWorldOffset);
			IRelativeTipsActorTransformResult.AddReason(builder, ReasonOffset);
			IRelativeTipsActorTransformResult.AddType(builder, Type);
			IRelativeTipsActorTransformResult.AddIsSuccess(builder, IsSuccess);
			return IRelativeTipsActorTransformResult.EndIRelativeTipsActorTransformResult(builder);
		}

		// Token: 0x06015476 RID: 87158 RVA: 0x0031487E File Offset: 0x00312A7E
		public static void StartIRelativeTipsActorTransformResult(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06015477 RID: 87159 RVA: 0x00314887 File Offset: 0x00312A87
		public static void AddIsSuccess(FlatBufferBuilder builder, bool isSuccess)
		{
			builder.AddBool(0, isSuccess, false);
		}

		// Token: 0x06015478 RID: 87160 RVA: 0x00314892 File Offset: 0x00312A92
		public static void AddReason(FlatBufferBuilder builder, StringOffset reasonOffset)
		{
			builder.AddOffset(1, reasonOffset.Value, 0);
		}

		// Token: 0x06015479 RID: 87161 RVA: 0x003148A2 File Offset: 0x00312AA2
		public static void AddType(FlatBufferBuilder builder, ETipsActorTransformType type)
		{
			builder.AddByte(2, (byte)type, 0);
		}

		// Token: 0x0601547A RID: 87162 RVA: 0x003148AD File Offset: 0x00312AAD
		public static void AddTransformWorld(FlatBufferBuilder builder, Offset<IShapeTransform> transformWorldOffset)
		{
			builder.AddOffset(3, transformWorldOffset.Value, 0);
		}

		// Token: 0x0601547B RID: 87163 RVA: 0x003148BD File Offset: 0x00312ABD
		public static void AddHollowTipsActorComponent(FlatBufferBuilder builder, Offset<IHollowTipsActorComponent> hollowTipsActorComponentOffset)
		{
			builder.AddOffset(4, hollowTipsActorComponentOffset.Value, 0);
		}

		// Token: 0x0601547C RID: 87164 RVA: 0x003148CD File Offset: 0x00312ACD
		public static void AddTransformEntity(FlatBufferBuilder builder, Offset<IShapeTransform> transformEntityOffset)
		{
			builder.AddOffset(5, transformEntityOffset.Value, 0);
		}

		// Token: 0x0601547D RID: 87165 RVA: 0x003148DD File Offset: 0x00312ADD
		public static Offset<IRelativeTipsActorTransformResult> EndIRelativeTipsActorTransformResult(FlatBufferBuilder builder)
		{
			return new Offset<IRelativeTipsActorTransformResult>(builder.EndTable());
		}

		// Token: 0x0601547E RID: 87166 RVA: 0x003148EC File Offset: 0x00312AEC
		public IRelativeTipsActorTransformResultT UnPack()
		{
			IRelativeTipsActorTransformResultT relativeTipsActorTransformResultT = new IRelativeTipsActorTransformResultT();
			this.UnPackTo(relativeTipsActorTransformResultT);
			return relativeTipsActorTransformResultT;
		}

		// Token: 0x0601547F RID: 87167 RVA: 0x00314908 File Offset: 0x00312B08
		public void UnPackTo(IRelativeTipsActorTransformResultT _o)
		{
			_o.IsSuccess = this.IsSuccess;
			_o.Reason = this.Reason;
			_o.Type = this.Type;
			_o.TransformWorld = ((this.TransformWorld != null) ? this.TransformWorld.Value.UnPack() : null);
			_o.HollowTipsActorComponent = ((this.HollowTipsActorComponent != null) ? this.HollowTipsActorComponent.Value.UnPack() : null);
			_o.TransformEntity = ((this.TransformEntity != null) ? this.TransformEntity.Value.UnPack() : null);
		}

		// Token: 0x06015480 RID: 87168 RVA: 0x003149C8 File Offset: 0x00312BC8
		public static Offset<IRelativeTipsActorTransformResult> Pack(FlatBufferBuilder builder, IRelativeTipsActorTransformResultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRelativeTipsActorTransformResult>);
			}
			StringOffset reasonOffset = (_o.Reason == null) ? default(StringOffset) : builder.CreateString(_o.Reason);
			Offset<IShapeTransform> transformWorldOffset = (_o.TransformWorld == null) ? default(Offset<IShapeTransform>) : IShapeTransform.Pack(builder, _o.TransformWorld);
			Offset<IHollowTipsActorComponent> hollowTipsActorComponentOffset = (_o.HollowTipsActorComponent == null) ? default(Offset<IHollowTipsActorComponent>) : IHollowTipsActorComponent.Pack(builder, _o.HollowTipsActorComponent);
			Offset<IShapeTransform> transformEntityOffset = (_o.TransformEntity == null) ? default(Offset<IShapeTransform>) : IShapeTransform.Pack(builder, _o.TransformEntity);
			return IRelativeTipsActorTransformResult.CreateIRelativeTipsActorTransformResult(builder, _o.IsSuccess, reasonOffset, _o.Type, transformWorldOffset, hollowTipsActorComponentOffset, transformEntityOffset);
		}

		// Token: 0x0400B231 RID: 45617
		private Table __p;
	}
}
