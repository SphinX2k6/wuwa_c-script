using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066E1 RID: 26337
	public struct IEntityLookAtPerform : IFlatbufferObject
	{
		// Token: 0x1700C3AA RID: 50090
		// (get) Token: 0x0602DC95 RID: 187541 RVA: 0x00643047 File Offset: 0x00641247
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DC96 RID: 187542 RVA: 0x00643054 File Offset: 0x00641254
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DC97 RID: 187543 RVA: 0x0064305C File Offset: 0x0064125C
		public static IEntityLookAtPerform GetRootAsIEntityLookAtPerform(ByteBuffer _bb)
		{
			return IEntityLookAtPerform.GetRootAsIEntityLookAtPerform(_bb, default(IEntityLookAtPerform));
		}

		// Token: 0x0602DC98 RID: 187544 RVA: 0x00643078 File Offset: 0x00641278
		public static IEntityLookAtPerform GetRootAsIEntityLookAtPerform(ByteBuffer _bb, IEntityLookAtPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DC99 RID: 187545 RVA: 0x00643095 File Offset: 0x00641295
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DC9A RID: 187546 RVA: 0x006430A4 File Offset: 0x006412A4
		public IEntityLookAtPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3AB RID: 50091
		// (get) Token: 0x0602DC9B RID: 187547 RVA: 0x006430B4 File Offset: 0x006412B4
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

		// Token: 0x1700C3AC RID: 50092
		// (get) Token: 0x0602DC9C RID: 187548 RVA: 0x006430F0 File Offset: 0x006412F0
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

		// Token: 0x1700C3AD RID: 50093
		// (get) Token: 0x0602DC9D RID: 187549 RVA: 0x0064312C File Offset: 0x0064132C
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

		// Token: 0x1700C3AE RID: 50094
		// (get) Token: 0x0602DC9E RID: 187550 RVA: 0x00643168 File Offset: 0x00641368
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

		// Token: 0x1700C3AF RID: 50095
		// (get) Token: 0x0602DC9F RID: 187551 RVA: 0x006431C8 File Offset: 0x006413C8
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

		// Token: 0x0602DCA0 RID: 187552 RVA: 0x00643205 File Offset: 0x00641405
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

		// Token: 0x0602DCA1 RID: 187553 RVA: 0x00643239 File Offset: 0x00641439
		public static void StartIEntityLookAtPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602DCA2 RID: 187554 RVA: 0x00643242 File Offset: 0x00641442
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0602DCA3 RID: 187555 RVA: 0x0064324D File Offset: 0x0064144D
		public static void AddFaceExpressionId(FlatBufferBuilder builder, int faceExpressionId)
		{
			builder.AddInt(1, faceExpressionId, 0);
		}

		// Token: 0x0602DCA4 RID: 187556 RVA: 0x00643258 File Offset: 0x00641458
		public static void AddOverlapMontageId(FlatBufferBuilder builder, int overlapMontageId)
		{
			builder.AddInt(2, overlapMontageId, 0);
		}

		// Token: 0x0602DCA5 RID: 187557 RVA: 0x00643263 File Offset: 0x00641463
		public static void AddOverlapMontageConfig(FlatBufferBuilder builder, Offset<ILookAtPerformOverlapMontageConfig> overlapMontageConfigOffset)
		{
			builder.AddOffset(3, overlapMontageConfigOffset.Value, 0);
		}

		// Token: 0x0602DCA6 RID: 187558 RVA: 0x00643273 File Offset: 0x00641473
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602DCA7 RID: 187559 RVA: 0x0064327E File Offset: 0x0064147E
		public static Offset<IEntityLookAtPerform> EndIEntityLookAtPerform(FlatBufferBuilder builder)
		{
			return new Offset<IEntityLookAtPerform>(builder.EndTable());
		}

		// Token: 0x0602DCA8 RID: 187560 RVA: 0x0064328C File Offset: 0x0064148C
		public IEntityLookAtPerformT UnPack()
		{
			IEntityLookAtPerformT entityLookAtPerformT = new IEntityLookAtPerformT();
			this.UnPackTo(entityLookAtPerformT);
			return entityLookAtPerformT;
		}

		// Token: 0x0602DCA9 RID: 187561 RVA: 0x006432A8 File Offset: 0x006414A8
		public void UnPackTo(IEntityLookAtPerformT _o)
		{
			_o.EntityId = this.EntityId;
			_o.FaceExpressionId = this.FaceExpressionId;
			_o.OverlapMontageId = this.OverlapMontageId;
			_o.OverlapMontageConfig = ((this.OverlapMontageConfig != null) ? this.OverlapMontageConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602DCAA RID: 187562 RVA: 0x00643314 File Offset: 0x00641514
		public static Offset<IEntityLookAtPerform> Pack(FlatBufferBuilder builder, IEntityLookAtPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityLookAtPerform>);
			}
			Offset<ILookAtPerformOverlapMontageConfig> overlapMontageConfigOffset = (_o.OverlapMontageConfig == null) ? default(Offset<ILookAtPerformOverlapMontageConfig>) : ILookAtPerformOverlapMontageConfig.Pack(builder, _o.OverlapMontageConfig);
			return IEntityLookAtPerform.CreateIEntityLookAtPerform(builder, _o.EntityId, _o.FaceExpressionId, _o.OverlapMontageId, overlapMontageConfigOffset, _o.NullMask);
		}

		// Token: 0x04010DAD RID: 69037
		private Table __p;
	}
}
