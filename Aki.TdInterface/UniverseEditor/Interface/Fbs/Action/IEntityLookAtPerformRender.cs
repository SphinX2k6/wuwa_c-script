using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D64 RID: 28004
	public struct IEntityLookAtPerformRender : IFlatbufferObject
	{
		// Token: 0x1700CD6B RID: 52587
		// (get) Token: 0x060304F4 RID: 197876 RVA: 0x006909E7 File Offset: 0x0068EBE7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060304F5 RID: 197877 RVA: 0x006909F4 File Offset: 0x0068EBF4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060304F6 RID: 197878 RVA: 0x006909FC File Offset: 0x0068EBFC
		public static IEntityLookAtPerformRender GetRootAsIEntityLookAtPerformRender(ByteBuffer _bb)
		{
			return IEntityLookAtPerformRender.GetRootAsIEntityLookAtPerformRender(_bb, default(IEntityLookAtPerformRender));
		}

		// Token: 0x060304F7 RID: 197879 RVA: 0x00690A18 File Offset: 0x0068EC18
		public static IEntityLookAtPerformRender GetRootAsIEntityLookAtPerformRender(ByteBuffer _bb, IEntityLookAtPerformRender obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060304F8 RID: 197880 RVA: 0x00690A35 File Offset: 0x0068EC35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060304F9 RID: 197881 RVA: 0x00690A44 File Offset: 0x0068EC44
		public IEntityLookAtPerformRender __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD6C RID: 52588
		// (get) Token: 0x060304FA RID: 197882 RVA: 0x00690A54 File Offset: 0x0068EC54
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CD6D RID: 52589
		// (get) Token: 0x060304FB RID: 197883 RVA: 0x00690A90 File Offset: 0x0068EC90
		public int FaceExpressionId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CD6E RID: 52590
		// (get) Token: 0x060304FC RID: 197884 RVA: 0x00690ACC File Offset: 0x0068ECCC
		public IMontageId? OverlapMontageId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IMontageId?(default(IMontageId).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CD6F RID: 52591
		// (get) Token: 0x060304FD RID: 197885 RVA: 0x00690B2C File Offset: 0x0068ED2C
		public ILookAtPerformOverlapMontageConfig? OverlapMontageConfig
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ILookAtPerformOverlapMontageConfig?(default(ILookAtPerformOverlapMontageConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CD70 RID: 52592
		// (get) Token: 0x060304FE RID: 197886 RVA: 0x00690B8C File Offset: 0x0068ED8C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060304FF RID: 197887 RVA: 0x00690BC9 File Offset: 0x0068EDC9
		public static Offset<IEntityLookAtPerformRender> CreateIEntityLookAtPerformRender(FlatBufferBuilder builder, int EntityId = 0, int FaceExpressionId = 0, Offset<IMontageId> OverlapMontageIdOffset = default(Offset<IMontageId>), Offset<ILookAtPerformOverlapMontageConfig> OverlapMontageConfigOffset = default(Offset<ILookAtPerformOverlapMontageConfig>), byte NullMask = 0)
		{
			builder.StartTable(5);
			IEntityLookAtPerformRender.AddOverlapMontageConfig(builder, OverlapMontageConfigOffset);
			IEntityLookAtPerformRender.AddOverlapMontageId(builder, OverlapMontageIdOffset);
			IEntityLookAtPerformRender.AddFaceExpressionId(builder, FaceExpressionId);
			IEntityLookAtPerformRender.AddEntityId(builder, EntityId);
			IEntityLookAtPerformRender.AddNullMask(builder, NullMask);
			return IEntityLookAtPerformRender.EndIEntityLookAtPerformRender(builder);
		}

		// Token: 0x06030500 RID: 197888 RVA: 0x00690BFD File Offset: 0x0068EDFD
		public static void StartIEntityLookAtPerformRender(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06030501 RID: 197889 RVA: 0x00690C06 File Offset: 0x0068EE06
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06030502 RID: 197890 RVA: 0x00690C11 File Offset: 0x0068EE11
		public static void AddFaceExpressionId(FlatBufferBuilder builder, int faceExpressionId)
		{
			builder.AddInt(1, faceExpressionId, 0);
		}

		// Token: 0x06030503 RID: 197891 RVA: 0x00690C1C File Offset: 0x0068EE1C
		public static void AddOverlapMontageId(FlatBufferBuilder builder, Offset<IMontageId> overlapMontageIdOffset)
		{
			builder.AddOffset(2, overlapMontageIdOffset.Value, 0);
		}

		// Token: 0x06030504 RID: 197892 RVA: 0x00690C2C File Offset: 0x0068EE2C
		public static void AddOverlapMontageConfig(FlatBufferBuilder builder, Offset<ILookAtPerformOverlapMontageConfig> overlapMontageConfigOffset)
		{
			builder.AddOffset(3, overlapMontageConfigOffset.Value, 0);
		}

		// Token: 0x06030505 RID: 197893 RVA: 0x00690C3C File Offset: 0x0068EE3C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06030506 RID: 197894 RVA: 0x00690C47 File Offset: 0x0068EE47
		public static Offset<IEntityLookAtPerformRender> EndIEntityLookAtPerformRender(FlatBufferBuilder builder)
		{
			return new Offset<IEntityLookAtPerformRender>(builder.EndTable());
		}

		// Token: 0x06030507 RID: 197895 RVA: 0x00690C54 File Offset: 0x0068EE54
		public IEntityLookAtPerformRenderT UnPack()
		{
			IEntityLookAtPerformRenderT entityLookAtPerformRenderT = new IEntityLookAtPerformRenderT();
			this.UnPackTo(entityLookAtPerformRenderT);
			return entityLookAtPerformRenderT;
		}

		// Token: 0x06030508 RID: 197896 RVA: 0x00690C70 File Offset: 0x0068EE70
		public void UnPackTo(IEntityLookAtPerformRenderT _o)
		{
			_o.EntityId = this.EntityId;
			_o.FaceExpressionId = this.FaceExpressionId;
			_o.OverlapMontageId = ((this.OverlapMontageId != null) ? this.OverlapMontageId.Value.UnPack() : null);
			_o.OverlapMontageConfig = ((this.OverlapMontageConfig != null) ? this.OverlapMontageConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030509 RID: 197897 RVA: 0x00690D00 File Offset: 0x0068EF00
		public static Offset<IEntityLookAtPerformRender> Pack(FlatBufferBuilder builder, IEntityLookAtPerformRenderT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityLookAtPerformRender>);
			}
			Offset<IMontageId> overlapMontageIdOffset = (_o.OverlapMontageId == null) ? default(Offset<IMontageId>) : IMontageId.Pack(builder, _o.OverlapMontageId);
			Offset<ILookAtPerformOverlapMontageConfig> overlapMontageConfigOffset = (_o.OverlapMontageConfig == null) ? default(Offset<ILookAtPerformOverlapMontageConfig>) : ILookAtPerformOverlapMontageConfig.Pack(builder, _o.OverlapMontageConfig);
			return IEntityLookAtPerformRender.CreateIEntityLookAtPerformRender(builder, _o.EntityId, _o.FaceExpressionId, overlapMontageIdOffset, overlapMontageConfigOffset, _o.NullMask);
		}

		// Token: 0x04011BE2 RID: 72674
		private Table __p;
	}
}
