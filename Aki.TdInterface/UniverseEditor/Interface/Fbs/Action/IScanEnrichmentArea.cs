using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076A2 RID: 30370
	public struct IScanEnrichmentArea : IFlatbufferObject
	{
		// Token: 0x1700DED0 RID: 57040
		// (get) Token: 0x06035463 RID: 218211 RVA: 0x00725D99 File Offset: 0x00723F99
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035464 RID: 218212 RVA: 0x00725DA6 File Offset: 0x00723FA6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035465 RID: 218213 RVA: 0x00725DB0 File Offset: 0x00723FB0
		public static IScanEnrichmentArea GetRootAsIScanEnrichmentArea(ByteBuffer _bb)
		{
			return IScanEnrichmentArea.GetRootAsIScanEnrichmentArea(_bb, default(IScanEnrichmentArea));
		}

		// Token: 0x06035466 RID: 218214 RVA: 0x00725DCC File Offset: 0x00723FCC
		public static IScanEnrichmentArea GetRootAsIScanEnrichmentArea(ByteBuffer _bb, IScanEnrichmentArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035467 RID: 218215 RVA: 0x00725DE9 File Offset: 0x00723FE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035468 RID: 218216 RVA: 0x00725DF8 File Offset: 0x00723FF8
		public IScanEnrichmentArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DED1 RID: 57041
		// (get) Token: 0x06035469 RID: 218217 RVA: 0x00725E08 File Offset: 0x00724008
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

		// Token: 0x1700DED2 RID: 57042
		// (get) Token: 0x0603546A RID: 218218 RVA: 0x00725E44 File Offset: 0x00724044
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

		// Token: 0x0603546B RID: 218219 RVA: 0x00725E80 File Offset: 0x00724080
		public static Offset<IScanEnrichmentArea> CreateIScanEnrichmentArea(FlatBufferBuilder builder, EEnrichmentAreaType EnrichmentAreaType = EEnrichmentAreaType.BigWorld, int EnrichmentAreaEntityId = 0)
		{
			builder.StartTable(2);
			IScanEnrichmentArea.AddEnrichmentAreaEntityId(builder, EnrichmentAreaEntityId);
			IScanEnrichmentArea.AddEnrichmentAreaType(builder, EnrichmentAreaType);
			return IScanEnrichmentArea.EndIScanEnrichmentArea(builder);
		}

		// Token: 0x0603546C RID: 218220 RVA: 0x00725E9D File Offset: 0x0072409D
		public static void StartIScanEnrichmentArea(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603546D RID: 218221 RVA: 0x00725EA6 File Offset: 0x007240A6
		public static void AddEnrichmentAreaType(FlatBufferBuilder builder, EEnrichmentAreaType enrichmentAreaType)
		{
			builder.AddByte(0, (byte)enrichmentAreaType, 0);
		}

		// Token: 0x0603546E RID: 218222 RVA: 0x00725EB1 File Offset: 0x007240B1
		public static void AddEnrichmentAreaEntityId(FlatBufferBuilder builder, int enrichmentAreaEntityId)
		{
			builder.AddInt(1, enrichmentAreaEntityId, 0);
		}

		// Token: 0x0603546F RID: 218223 RVA: 0x00725EBC File Offset: 0x007240BC
		public static Offset<IScanEnrichmentArea> EndIScanEnrichmentArea(FlatBufferBuilder builder)
		{
			return new Offset<IScanEnrichmentArea>(builder.EndTable());
		}

		// Token: 0x06035470 RID: 218224 RVA: 0x00725ECC File Offset: 0x007240CC
		public IScanEnrichmentAreaT UnPack()
		{
			IScanEnrichmentAreaT scanEnrichmentAreaT = new IScanEnrichmentAreaT();
			this.UnPackTo(scanEnrichmentAreaT);
			return scanEnrichmentAreaT;
		}

		// Token: 0x06035471 RID: 218225 RVA: 0x00725EE7 File Offset: 0x007240E7
		public void UnPackTo(IScanEnrichmentAreaT _o)
		{
			_o.EnrichmentAreaType = this.EnrichmentAreaType;
			_o.EnrichmentAreaEntityId = this.EnrichmentAreaEntityId;
		}

		// Token: 0x06035472 RID: 218226 RVA: 0x00725F04 File Offset: 0x00724104
		public static Offset<IScanEnrichmentArea> Pack(FlatBufferBuilder builder, IScanEnrichmentAreaT _o)
		{
			if (_o == null)
			{
				return default(Offset<IScanEnrichmentArea>);
			}
			return IScanEnrichmentArea.CreateIScanEnrichmentArea(builder, _o.EnrichmentAreaType, _o.EnrichmentAreaEntityId);
		}

		// Token: 0x0401288E RID: 75918
		private Table __p;
	}
}
