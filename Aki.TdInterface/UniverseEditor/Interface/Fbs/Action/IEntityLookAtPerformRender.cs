using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066E4 RID: 26340
	public struct IEntityLookAtPerformRender : IFlatbufferObject
	{
		// Token: 0x1700C3B5 RID: 50101
		// (get) Token: 0x0602DCB7 RID: 187575 RVA: 0x00643473 File Offset: 0x00641673
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DCB8 RID: 187576 RVA: 0x00643480 File Offset: 0x00641680
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DCB9 RID: 187577 RVA: 0x00643488 File Offset: 0x00641688
		public static IEntityLookAtPerformRender GetRootAsIEntityLookAtPerformRender(ByteBuffer _bb)
		{
			return IEntityLookAtPerformRender.GetRootAsIEntityLookAtPerformRender(_bb, default(IEntityLookAtPerformRender));
		}

		// Token: 0x0602DCBA RID: 187578 RVA: 0x006434A4 File Offset: 0x006416A4
		public static IEntityLookAtPerformRender GetRootAsIEntityLookAtPerformRender(ByteBuffer _bb, IEntityLookAtPerformRender obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DCBB RID: 187579 RVA: 0x006434C1 File Offset: 0x006416C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DCBC RID: 187580 RVA: 0x006434D0 File Offset: 0x006416D0
		public IEntityLookAtPerformRender __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3B6 RID: 50102
		// (get) Token: 0x0602DCBD RID: 187581 RVA: 0x006434E0 File Offset: 0x006416E0
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

		// Token: 0x1700C3B7 RID: 50103
		// (get) Token: 0x0602DCBE RID: 187582 RVA: 0x0064351C File Offset: 0x0064171C
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

		// Token: 0x1700C3B8 RID: 50104
		// (get) Token: 0x0602DCBF RID: 187583 RVA: 0x00643558 File Offset: 0x00641758
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

		// Token: 0x1700C3B9 RID: 50105
		// (get) Token: 0x0602DCC0 RID: 187584 RVA: 0x006435B8 File Offset: 0x006417B8
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

		// Token: 0x1700C3BA RID: 50106
		// (get) Token: 0x0602DCC1 RID: 187585 RVA: 0x00643618 File Offset: 0x00641818
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

		// Token: 0x0602DCC2 RID: 187586 RVA: 0x00643655 File Offset: 0x00641855
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

		// Token: 0x0602DCC3 RID: 187587 RVA: 0x00643689 File Offset: 0x00641889
		public static void StartIEntityLookAtPerformRender(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602DCC4 RID: 187588 RVA: 0x00643692 File Offset: 0x00641892
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0602DCC5 RID: 187589 RVA: 0x0064369D File Offset: 0x0064189D
		public static void AddFaceExpressionId(FlatBufferBuilder builder, int faceExpressionId)
		{
			builder.AddInt(1, faceExpressionId, 0);
		}

		// Token: 0x0602DCC6 RID: 187590 RVA: 0x006436A8 File Offset: 0x006418A8
		public static void AddOverlapMontageId(FlatBufferBuilder builder, Offset<IMontageId> overlapMontageIdOffset)
		{
			builder.AddOffset(2, overlapMontageIdOffset.Value, 0);
		}

		// Token: 0x0602DCC7 RID: 187591 RVA: 0x006436B8 File Offset: 0x006418B8
		public static void AddOverlapMontageConfig(FlatBufferBuilder builder, Offset<ILookAtPerformOverlapMontageConfig> overlapMontageConfigOffset)
		{
			builder.AddOffset(3, overlapMontageConfigOffset.Value, 0);
		}

		// Token: 0x0602DCC8 RID: 187592 RVA: 0x006436C8 File Offset: 0x006418C8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602DCC9 RID: 187593 RVA: 0x006436D3 File Offset: 0x006418D3
		public static Offset<IEntityLookAtPerformRender> EndIEntityLookAtPerformRender(FlatBufferBuilder builder)
		{
			return new Offset<IEntityLookAtPerformRender>(builder.EndTable());
		}

		// Token: 0x0602DCCA RID: 187594 RVA: 0x006436E0 File Offset: 0x006418E0
		public IEntityLookAtPerformRenderT UnPack()
		{
			IEntityLookAtPerformRenderT entityLookAtPerformRenderT = new IEntityLookAtPerformRenderT();
			this.UnPackTo(entityLookAtPerformRenderT);
			return entityLookAtPerformRenderT;
		}

		// Token: 0x0602DCCB RID: 187595 RVA: 0x006436FC File Offset: 0x006418FC
		public void UnPackTo(IEntityLookAtPerformRenderT _o)
		{
			_o.EntityId = this.EntityId;
			_o.FaceExpressionId = this.FaceExpressionId;
			_o.OverlapMontageId = ((this.OverlapMontageId != null) ? this.OverlapMontageId.Value.UnPack() : null);
			_o.OverlapMontageConfig = ((this.OverlapMontageConfig != null) ? this.OverlapMontageConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602DCCC RID: 187596 RVA: 0x0064378C File Offset: 0x0064198C
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

		// Token: 0x04010DB3 RID: 69043
		private Table __p;
	}
}
