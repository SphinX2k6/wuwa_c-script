using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005144 RID: 20804
	public struct IEnrichmentAreaComponent : IFlatbufferObject
	{
		// Token: 0x170097B5 RID: 38837
		// (get) Token: 0x06021916 RID: 137494 RVA: 0x004A8F12 File Offset: 0x004A7112
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021917 RID: 137495 RVA: 0x004A8F1F File Offset: 0x004A711F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021918 RID: 137496 RVA: 0x004A8F28 File Offset: 0x004A7128
		public static IEnrichmentAreaComponent GetRootAsIEnrichmentAreaComponent(ByteBuffer _bb)
		{
			return IEnrichmentAreaComponent.GetRootAsIEnrichmentAreaComponent(_bb, default(IEnrichmentAreaComponent));
		}

		// Token: 0x06021919 RID: 137497 RVA: 0x004A8F44 File Offset: 0x004A7144
		public static IEnrichmentAreaComponent GetRootAsIEnrichmentAreaComponent(ByteBuffer _bb, IEnrichmentAreaComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602191A RID: 137498 RVA: 0x004A8F61 File Offset: 0x004A7161
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602191B RID: 137499 RVA: 0x004A8F70 File Offset: 0x004A7170
		public IEnrichmentAreaComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170097B6 RID: 38838
		// (get) Token: 0x0602191C RID: 137500 RVA: 0x004A8F80 File Offset: 0x004A7180
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170097B7 RID: 38839
		// (get) Token: 0x0602191D RID: 137501 RVA: 0x004A8FC0 File Offset: 0x004A71C0
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

		// Token: 0x0602191E RID: 137502 RVA: 0x004A8FFC File Offset: 0x004A71FC
		public int RefEntityIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170097B8 RID: 38840
		// (get) Token: 0x0602191F RID: 137503 RVA: 0x004A903C File Offset: 0x004A723C
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

		// Token: 0x06021920 RID: 137504 RVA: 0x004A9067 File Offset: 0x004A7267
		public Span<int> GetRefEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06021921 RID: 137505 RVA: 0x004A9076 File Offset: 0x004A7276
		public int[] GetRefEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x06021922 RID: 137506 RVA: 0x004A9084 File Offset: 0x004A7284
		public int FogIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170097B9 RID: 38841
		// (get) Token: 0x06021923 RID: 137507 RVA: 0x004A90C4 File Offset: 0x004A72C4
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

		// Token: 0x06021924 RID: 137508 RVA: 0x004A90F0 File Offset: 0x004A72F0
		public Span<int> GetFogIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06021925 RID: 137509 RVA: 0x004A9100 File Offset: 0x004A7300
		public int[] GetFogIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x170097BA RID: 38842
		// (get) Token: 0x06021926 RID: 137510 RVA: 0x004A9110 File Offset: 0x004A7310
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

		// Token: 0x06021927 RID: 137511 RVA: 0x004A914D File Offset: 0x004A734D
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

		// Token: 0x06021928 RID: 137512 RVA: 0x004A9181 File Offset: 0x004A7381
		public static void StartIEnrichmentAreaComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06021929 RID: 137513 RVA: 0x004A918A File Offset: 0x004A738A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602192A RID: 137514 RVA: 0x004A9195 File Offset: 0x004A7395
		public static void AddEnrichmentAreaType(FlatBufferBuilder builder, EEnrichmentAreaType enrichmentAreaType)
		{
			builder.AddByte(1, (byte)enrichmentAreaType, 0);
		}

		// Token: 0x0602192B RID: 137515 RVA: 0x004A91A0 File Offset: 0x004A73A0
		public static void AddRefEntityIds(FlatBufferBuilder builder, VectorOffset refEntityIdsOffset)
		{
			builder.AddOffset(2, refEntityIdsOffset.Value, 0);
		}

		// Token: 0x0602192C RID: 137516 RVA: 0x004A91B0 File Offset: 0x004A73B0
		public static VectorOffset CreateRefEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602192D RID: 137517 RVA: 0x004A91E7 File Offset: 0x004A73E7
		public static VectorOffset CreateRefEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602192E RID: 137518 RVA: 0x004A9201 File Offset: 0x004A7401
		public static VectorOffset CreateRefEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602192F RID: 137519 RVA: 0x004A921F File Offset: 0x004A741F
		public static VectorOffset CreateRefEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021930 RID: 137520 RVA: 0x004A9238 File Offset: 0x004A7438
		public static void StartRefEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021931 RID: 137521 RVA: 0x004A9243 File Offset: 0x004A7443
		public static void AddFogIds(FlatBufferBuilder builder, VectorOffset fogIdsOffset)
		{
			builder.AddOffset(3, fogIdsOffset.Value, 0);
		}

		// Token: 0x06021932 RID: 137522 RVA: 0x004A9254 File Offset: 0x004A7454
		public static VectorOffset CreateFogIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06021933 RID: 137523 RVA: 0x004A928B File Offset: 0x004A748B
		public static VectorOffset CreateFogIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06021934 RID: 137524 RVA: 0x004A92A5 File Offset: 0x004A74A5
		public static VectorOffset CreateFogIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06021935 RID: 137525 RVA: 0x004A92C3 File Offset: 0x004A74C3
		public static VectorOffset CreateFogIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021936 RID: 137526 RVA: 0x004A92DC File Offset: 0x004A74DC
		public static void StartFogIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021937 RID: 137527 RVA: 0x004A92E7 File Offset: 0x004A74E7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06021938 RID: 137528 RVA: 0x004A92F2 File Offset: 0x004A74F2
		public static Offset<IEnrichmentAreaComponent> EndIEnrichmentAreaComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEnrichmentAreaComponent>(builder.EndTable());
		}

		// Token: 0x06021939 RID: 137529 RVA: 0x004A9300 File Offset: 0x004A7500
		public IEnrichmentAreaComponentT UnPack()
		{
			IEnrichmentAreaComponentT enrichmentAreaComponentT = new IEnrichmentAreaComponentT();
			this.UnPackTo(enrichmentAreaComponentT);
			return enrichmentAreaComponentT;
		}

		// Token: 0x0602193A RID: 137530 RVA: 0x004A931C File Offset: 0x004A751C
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

		// Token: 0x0602193B RID: 137531 RVA: 0x004A93AC File Offset: 0x004A75AC
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

		// Token: 0x0400E1DC RID: 57820
		private Table __p;
	}
}
