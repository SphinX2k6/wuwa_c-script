using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F1B RID: 28443
	public struct IScanEnrichmentArea : IFlatbufferObject
	{
		// Token: 0x1700D374 RID: 54132
		// (get) Token: 0x0603240B RID: 205835 RVA: 0x006C9E31 File Offset: 0x006C8031
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603240C RID: 205836 RVA: 0x006C9E3E File Offset: 0x006C803E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603240D RID: 205837 RVA: 0x006C9E48 File Offset: 0x006C8048
		public static IScanEnrichmentArea GetRootAsIScanEnrichmentArea(ByteBuffer _bb)
		{
			return IScanEnrichmentArea.GetRootAsIScanEnrichmentArea(_bb, default(IScanEnrichmentArea));
		}

		// Token: 0x0603240E RID: 205838 RVA: 0x006C9E64 File Offset: 0x006C8064
		public static IScanEnrichmentArea GetRootAsIScanEnrichmentArea(ByteBuffer _bb, IScanEnrichmentArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603240F RID: 205839 RVA: 0x006C9E81 File Offset: 0x006C8081
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032410 RID: 205840 RVA: 0x006C9E90 File Offset: 0x006C8090
		public IScanEnrichmentArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D375 RID: 54133
		// (get) Token: 0x06032411 RID: 205841 RVA: 0x006C9EA0 File Offset: 0x006C80A0
		public EEnrichmentAreaType EnrichmentAreaType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEnrichmentAreaType.BigWorld;
				}
				return (EEnrichmentAreaType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D376 RID: 54134
		// (get) Token: 0x06032412 RID: 205842 RVA: 0x006C9EDC File Offset: 0x006C80DC
		public int EnrichmentAreaEntityId
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

		// Token: 0x06032413 RID: 205843 RVA: 0x006C9F18 File Offset: 0x006C8118
		public static Offset<IScanEnrichmentArea> CreateIScanEnrichmentArea(FlatBufferBuilder builder, EEnrichmentAreaType EnrichmentAreaType = EEnrichmentAreaType.BigWorld, int EnrichmentAreaEntityId = 0)
		{
			builder.StartTable(2);
			IScanEnrichmentArea.AddEnrichmentAreaEntityId(builder, EnrichmentAreaEntityId);
			IScanEnrichmentArea.AddEnrichmentAreaType(builder, EnrichmentAreaType);
			return IScanEnrichmentArea.EndIScanEnrichmentArea(builder);
		}

		// Token: 0x06032414 RID: 205844 RVA: 0x006C9F35 File Offset: 0x006C8135
		public static void StartIScanEnrichmentArea(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032415 RID: 205845 RVA: 0x006C9F3E File Offset: 0x006C813E
		public static void AddEnrichmentAreaType(FlatBufferBuilder builder, EEnrichmentAreaType enrichmentAreaType)
		{
			builder.AddByte(0, (byte)enrichmentAreaType, 0);
		}

		// Token: 0x06032416 RID: 205846 RVA: 0x006C9F49 File Offset: 0x006C8149
		public static void AddEnrichmentAreaEntityId(FlatBufferBuilder builder, int enrichmentAreaEntityId)
		{
			builder.AddInt(1, enrichmentAreaEntityId, 0);
		}

		// Token: 0x06032417 RID: 205847 RVA: 0x006C9F54 File Offset: 0x006C8154
		public static Offset<IScanEnrichmentArea> EndIScanEnrichmentArea(FlatBufferBuilder builder)
		{
			return new Offset<IScanEnrichmentArea>(builder.EndTable());
		}

		// Token: 0x06032418 RID: 205848 RVA: 0x006C9F64 File Offset: 0x006C8164
		public IScanEnrichmentAreaT UnPack()
		{
			IScanEnrichmentAreaT scanEnrichmentAreaT = new IScanEnrichmentAreaT();
			this.UnPackTo(scanEnrichmentAreaT);
			return scanEnrichmentAreaT;
		}

		// Token: 0x06032419 RID: 205849 RVA: 0x006C9F7F File Offset: 0x006C817F
		public void UnPackTo(IScanEnrichmentAreaT _o)
		{
			_o.EnrichmentAreaType = this.EnrichmentAreaType;
			_o.EnrichmentAreaEntityId = this.EnrichmentAreaEntityId;
		}

		// Token: 0x0603241A RID: 205850 RVA: 0x006C9F9C File Offset: 0x006C819C
		public static Offset<IScanEnrichmentArea> Pack(FlatBufferBuilder builder, IScanEnrichmentAreaT _o)
		{
			if (_o == null)
			{
				return default(Offset<IScanEnrichmentArea>);
			}
			return IScanEnrichmentArea.CreateIScanEnrichmentArea(builder, _o.EnrichmentAreaType, _o.EnrichmentAreaEntityId);
		}

		// Token: 0x04011906 RID: 71942
		private Table __p;
	}
}
