using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056A9 RID: 22185
	public struct IEnrichmentAreaComponent : IFlatbufferObject
	{
		// Token: 0x17009FA2 RID: 40866
		// (get) Token: 0x0602386A RID: 145514 RVA: 0x004E2E9E File Offset: 0x004E109E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602386B RID: 145515 RVA: 0x004E2EAB File Offset: 0x004E10AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602386C RID: 145516 RVA: 0x004E2EB4 File Offset: 0x004E10B4
		public static IEnrichmentAreaComponent GetRootAsIEnrichmentAreaComponent(ByteBuffer _bb)
		{
			return IEnrichmentAreaComponent.GetRootAsIEnrichmentAreaComponent(_bb, default(IEnrichmentAreaComponent));
		}

		// Token: 0x0602386D RID: 145517 RVA: 0x004E2ED0 File Offset: 0x004E10D0
		public static IEnrichmentAreaComponent GetRootAsIEnrichmentAreaComponent(ByteBuffer _bb, IEnrichmentAreaComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602386E RID: 145518 RVA: 0x004E2EED File Offset: 0x004E10ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602386F RID: 145519 RVA: 0x004E2EFC File Offset: 0x004E10FC
		public IEnrichmentAreaComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009FA3 RID: 40867
		// (get) Token: 0x06023870 RID: 145520 RVA: 0x004E2F0C File Offset: 0x004E110C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009FA4 RID: 40868
		// (get) Token: 0x06023871 RID: 145521 RVA: 0x004E2F4C File Offset: 0x004E114C
		public EEnrichmentAreaType EnrichmentAreaType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EEnrichmentAreaType.BigWorld;
				}
				return (EEnrichmentAreaType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023872 RID: 145522 RVA: 0x004E2F88 File Offset: 0x004E1188
		public int RefEntityIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009FA5 RID: 40869
		// (get) Token: 0x06023873 RID: 145523 RVA: 0x004E2FC8 File Offset: 0x004E11C8
		public int RefEntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06023874 RID: 145524 RVA: 0x004E2FF3 File Offset: 0x004E11F3
		public Span<int> GetRefEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06023875 RID: 145525 RVA: 0x004E3002 File Offset: 0x004E1202
		public int[] GetRefEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x06023876 RID: 145526 RVA: 0x004E3010 File Offset: 0x004E1210
		public int FogIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009FA6 RID: 40870
		// (get) Token: 0x06023877 RID: 145527 RVA: 0x004E3050 File Offset: 0x004E1250
		public int FogIdsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06023878 RID: 145528 RVA: 0x004E307C File Offset: 0x004E127C
		public Span<int> GetFogIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06023879 RID: 145529 RVA: 0x004E308C File Offset: 0x004E128C
		public int[] GetFogIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x17009FA7 RID: 40871
		// (get) Token: 0x0602387A RID: 145530 RVA: 0x004E309C File Offset: 0x004E129C
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

		// Token: 0x0602387B RID: 145531 RVA: 0x004E30D9 File Offset: 0x004E12D9
		public static Offset<IEnrichmentAreaComponent> CreateIEnrichmentAreaComponent(FlatBufferBuilder builder, bool Disabled = false, EEnrichmentAreaType EnrichmentAreaType = EEnrichmentAreaType.BigWorld, VectorOffset RefEntityIdsOffset = default(VectorOffset), VectorOffset FogIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IEnrichmentAreaComponent.AddFogIds(builder, FogIdsOffset);
			IEnrichmentAreaComponent.AddRefEntityIds(builder, RefEntityIdsOffset);
			IEnrichmentAreaComponent.AddNullMask(builder, NullMask);
			IEnrichmentAreaComponent.AddEnrichmentAreaType(builder, EnrichmentAreaType);
			IEnrichmentAreaComponent.AddDisabled(builder, Disabled);
			return IEnrichmentAreaComponent.EndIEnrichmentAreaComponent(builder);
		}

		// Token: 0x0602387C RID: 145532 RVA: 0x004E310D File Offset: 0x004E130D
		public static void StartIEnrichmentAreaComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602387D RID: 145533 RVA: 0x004E3116 File Offset: 0x004E1316
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602387E RID: 145534 RVA: 0x004E3121 File Offset: 0x004E1321
		public static void AddEnrichmentAreaType(FlatBufferBuilder builder, EEnrichmentAreaType enrichmentAreaType)
		{
			builder.AddByte(1, (byte)enrichmentAreaType, 0);
		}

		// Token: 0x0602387F RID: 145535 RVA: 0x004E312C File Offset: 0x004E132C
		public static void AddRefEntityIds(FlatBufferBuilder builder, VectorOffset refEntityIdsOffset)
		{
			builder.AddOffset(2, refEntityIdsOffset.Value, 0);
		}

		// Token: 0x06023880 RID: 145536 RVA: 0x004E313C File Offset: 0x004E133C
		public static VectorOffset CreateRefEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06023881 RID: 145537 RVA: 0x004E3173 File Offset: 0x004E1373
		public static VectorOffset CreateRefEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023882 RID: 145538 RVA: 0x004E318D File Offset: 0x004E138D
		public static VectorOffset CreateRefEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023883 RID: 145539 RVA: 0x004E31AB File Offset: 0x004E13AB
		public static VectorOffset CreateRefEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023884 RID: 145540 RVA: 0x004E31C4 File Offset: 0x004E13C4
		public static void StartRefEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023885 RID: 145541 RVA: 0x004E31CF File Offset: 0x004E13CF
		public static void AddFogIds(FlatBufferBuilder builder, VectorOffset fogIdsOffset)
		{
			builder.AddOffset(3, fogIdsOffset.Value, 0);
		}

		// Token: 0x06023886 RID: 145542 RVA: 0x004E31E0 File Offset: 0x004E13E0
		public static VectorOffset CreateFogIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06023887 RID: 145543 RVA: 0x004E3217 File Offset: 0x004E1417
		public static VectorOffset CreateFogIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023888 RID: 145544 RVA: 0x004E3231 File Offset: 0x004E1431
		public static VectorOffset CreateFogIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023889 RID: 145545 RVA: 0x004E324F File Offset: 0x004E144F
		public static VectorOffset CreateFogIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602388A RID: 145546 RVA: 0x004E3268 File Offset: 0x004E1468
		public static void StartFogIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602388B RID: 145547 RVA: 0x004E3273 File Offset: 0x004E1473
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602388C RID: 145548 RVA: 0x004E327E File Offset: 0x004E147E
		public static Offset<IEnrichmentAreaComponent> EndIEnrichmentAreaComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEnrichmentAreaComponent>(builder.EndTable());
		}

		// Token: 0x0602388D RID: 145549 RVA: 0x004E328C File Offset: 0x004E148C
		public IEnrichmentAreaComponentT UnPack()
		{
			IEnrichmentAreaComponentT enrichmentAreaComponentT = new IEnrichmentAreaComponentT();
			this.UnPackTo(enrichmentAreaComponentT);
			return enrichmentAreaComponentT;
		}

		// Token: 0x0602388E RID: 145550 RVA: 0x004E32A8 File Offset: 0x004E14A8
		public void UnPackTo(IEnrichmentAreaComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.EnrichmentAreaType = this.EnrichmentAreaType;
			_o.RefEntityIds = new List<int>();
			for (int i = 0; i < this.RefEntityIdsLength; i++)
			{
				_o.RefEntityIds.Add(this.RefEntityIds(i));
			}
			_o.FogIds = new List<int>();
			for (int j = 0; j < this.FogIdsLength; j++)
			{
				_o.FogIds.Add(this.FogIds(j));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602388F RID: 145551 RVA: 0x004E3338 File Offset: 0x004E1538
		public static Offset<IEnrichmentAreaComponent> Pack(FlatBufferBuilder builder, IEnrichmentAreaComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnrichmentAreaComponent>);
			}
			VectorOffset refEntityIdsOffset = default(VectorOffset);
			if (_o.RefEntityIds != null)
			{
				int[] data = _o.RefEntityIds.ToArray();
				refEntityIdsOffset = IEnrichmentAreaComponent.CreateRefEntityIdsVector(builder, data);
			}
			VectorOffset fogIdsOffset = default(VectorOffset);
			if (_o.FogIds != null)
			{
				int[] data2 = _o.FogIds.ToArray();
				fogIdsOffset = IEnrichmentAreaComponent.CreateFogIdsVector(builder, data2);
			}
			return IEnrichmentAreaComponent.CreateIEnrichmentAreaComponent(builder, _o.Disabled, _o.EnrichmentAreaType, refEntityIdsOffset, fogIdsOffset, _o.NullMask);
		}

		// Token: 0x0400EDD9 RID: 60889
		private Table __p;
	}
}
