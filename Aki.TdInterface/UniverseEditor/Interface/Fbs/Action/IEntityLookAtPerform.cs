using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D61 RID: 28001
	public struct IEntityLookAtPerform : IFlatbufferObject
	{
		// Token: 0x1700CD60 RID: 52576
		// (get) Token: 0x060304D2 RID: 197842 RVA: 0x006905BB File Offset: 0x0068E7BB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060304D3 RID: 197843 RVA: 0x006905C8 File Offset: 0x0068E7C8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060304D4 RID: 197844 RVA: 0x006905D0 File Offset: 0x0068E7D0
		public static IEntityLookAtPerform GetRootAsIEntityLookAtPerform(ByteBuffer _bb)
		{
			return IEntityLookAtPerform.GetRootAsIEntityLookAtPerform(_bb, default(IEntityLookAtPerform));
		}

		// Token: 0x060304D5 RID: 197845 RVA: 0x006905EC File Offset: 0x0068E7EC
		public static IEntityLookAtPerform GetRootAsIEntityLookAtPerform(ByteBuffer _bb, IEntityLookAtPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060304D6 RID: 197846 RVA: 0x00690609 File Offset: 0x0068E809
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060304D7 RID: 197847 RVA: 0x00690618 File Offset: 0x0068E818
		public IEntityLookAtPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD61 RID: 52577
		// (get) Token: 0x060304D8 RID: 197848 RVA: 0x00690628 File Offset: 0x0068E828
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

		// Token: 0x1700CD62 RID: 52578
		// (get) Token: 0x060304D9 RID: 197849 RVA: 0x00690664 File Offset: 0x0068E864
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

		// Token: 0x1700CD63 RID: 52579
		// (get) Token: 0x060304DA RID: 197850 RVA: 0x006906A0 File Offset: 0x0068E8A0
		public int OverlapMontageId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CD64 RID: 52580
		// (get) Token: 0x060304DB RID: 197851 RVA: 0x006906DC File Offset: 0x0068E8DC
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

		// Token: 0x1700CD65 RID: 52581
		// (get) Token: 0x060304DC RID: 197852 RVA: 0x0069073C File Offset: 0x0068E93C
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

		// Token: 0x060304DD RID: 197853 RVA: 0x00690779 File Offset: 0x0068E979
		public static Offset<IEntityLookAtPerform> CreateIEntityLookAtPerform(FlatBufferBuilder builder, int EntityId = 0, int FaceExpressionId = 0, int OverlapMontageId = 0, Offset<ILookAtPerformOverlapMontageConfig> OverlapMontageConfigOffset = default(Offset<ILookAtPerformOverlapMontageConfig>), byte NullMask = 0)
		{
			builder.StartTable(5);
			IEntityLookAtPerform.AddOverlapMontageConfig(builder, OverlapMontageConfigOffset);
			IEntityLookAtPerform.AddOverlapMontageId(builder, OverlapMontageId);
			IEntityLookAtPerform.AddFaceExpressionId(builder, FaceExpressionId);
			IEntityLookAtPerform.AddEntityId(builder, EntityId);
			IEntityLookAtPerform.AddNullMask(builder, NullMask);
			return IEntityLookAtPerform.EndIEntityLookAtPerform(builder);
		}

		// Token: 0x060304DE RID: 197854 RVA: 0x006907AD File Offset: 0x0068E9AD
		public static void StartIEntityLookAtPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060304DF RID: 197855 RVA: 0x006907B6 File Offset: 0x0068E9B6
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x060304E0 RID: 197856 RVA: 0x006907C1 File Offset: 0x0068E9C1
		public static void AddFaceExpressionId(FlatBufferBuilder builder, int faceExpressionId)
		{
			builder.AddInt(1, faceExpressionId, 0);
		}

		// Token: 0x060304E1 RID: 197857 RVA: 0x006907CC File Offset: 0x0068E9CC
		public static void AddOverlapMontageId(FlatBufferBuilder builder, int overlapMontageId)
		{
			builder.AddInt(2, overlapMontageId, 0);
		}

		// Token: 0x060304E2 RID: 197858 RVA: 0x006907D7 File Offset: 0x0068E9D7
		public static void AddOverlapMontageConfig(FlatBufferBuilder builder, Offset<ILookAtPerformOverlapMontageConfig> overlapMontageConfigOffset)
		{
			builder.AddOffset(3, overlapMontageConfigOffset.Value, 0);
		}

		// Token: 0x060304E3 RID: 197859 RVA: 0x006907E7 File Offset: 0x0068E9E7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060304E4 RID: 197860 RVA: 0x006907F2 File Offset: 0x0068E9F2
		public static Offset<IEntityLookAtPerform> EndIEntityLookAtPerform(FlatBufferBuilder builder)
		{
			return new Offset<IEntityLookAtPerform>(builder.EndTable());
		}

		// Token: 0x060304E5 RID: 197861 RVA: 0x00690800 File Offset: 0x0068EA00
		public IEntityLookAtPerformT UnPack()
		{
			IEntityLookAtPerformT entityLookAtPerformT = new IEntityLookAtPerformT();
			this.UnPackTo(entityLookAtPerformT);
			return entityLookAtPerformT;
		}

		// Token: 0x060304E6 RID: 197862 RVA: 0x0069081C File Offset: 0x0068EA1C
		public void UnPackTo(IEntityLookAtPerformT _o)
		{
			_o.EntityId = this.EntityId;
			_o.FaceExpressionId = this.FaceExpressionId;
			_o.OverlapMontageId = this.OverlapMontageId;
			_o.OverlapMontageConfig = ((this.OverlapMontageConfig != null) ? this.OverlapMontageConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060304E7 RID: 197863 RVA: 0x00690888 File Offset: 0x0068EA88
		public static Offset<IEntityLookAtPerform> Pack(FlatBufferBuilder builder, IEntityLookAtPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityLookAtPerform>);
			}
			Offset<ILookAtPerformOverlapMontageConfig> overlapMontageConfigOffset = (_o.OverlapMontageConfig == null) ? default(Offset<ILookAtPerformOverlapMontageConfig>) : ILookAtPerformOverlapMontageConfig.Pack(builder, _o.OverlapMontageConfig);
			return IEntityLookAtPerform.CreateIEntityLookAtPerform(builder, _o.EntityId, _o.FaceExpressionId, _o.OverlapMontageId, overlapMontageConfigOffset, _o.NullMask);
		}

		// Token: 0x04011BDC RID: 72668
		private Table __p;
	}
}
