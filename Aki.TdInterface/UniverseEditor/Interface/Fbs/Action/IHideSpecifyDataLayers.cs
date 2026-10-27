using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068FD RID: 26877
	public struct IHideSpecifyDataLayers : IFlatbufferObject
	{
		// Token: 0x1700C761 RID: 51041
		// (get) Token: 0x0602EE2F RID: 192047 RVA: 0x006653EA File Offset: 0x006635EA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EE30 RID: 192048 RVA: 0x006653F7 File Offset: 0x006635F7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EE31 RID: 192049 RVA: 0x00665400 File Offset: 0x00663600
		public static IHideSpecifyDataLayers GetRootAsIHideSpecifyDataLayers(ByteBuffer _bb)
		{
			return IHideSpecifyDataLayers.GetRootAsIHideSpecifyDataLayers(_bb, default(IHideSpecifyDataLayers));
		}

		// Token: 0x0602EE32 RID: 192050 RVA: 0x0066541C File Offset: 0x0066361C
		public static IHideSpecifyDataLayers GetRootAsIHideSpecifyDataLayers(ByteBuffer _bb, IHideSpecifyDataLayers obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EE33 RID: 192051 RVA: 0x00665439 File Offset: 0x00663639
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EE34 RID: 192052 RVA: 0x00665448 File Offset: 0x00663648
		public IHideSpecifyDataLayers __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C762 RID: 51042
		// (get) Token: 0x0602EE35 RID: 192053 RVA: 0x00665458 File Offset: 0x00663658
		public EHideType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHideType.WorldMonsterAndMonsterTreasure;
				}
				return (EHideType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EE36 RID: 192054 RVA: 0x00665494 File Offset: 0x00663694
		public int DataLayers(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C763 RID: 51043
		// (get) Token: 0x0602EE37 RID: 192055 RVA: 0x006654D4 File Offset: 0x006636D4
		public int DataLayersLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602EE38 RID: 192056 RVA: 0x006654FF File Offset: 0x006636FF
		public Span<int> GetDataLayersBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602EE39 RID: 192057 RVA: 0x0066550E File Offset: 0x0066370E
		public int[] GetDataLayersArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0602EE3A RID: 192058 RVA: 0x0066551C File Offset: 0x0066371C
		public static Offset<IHideSpecifyDataLayers> CreateIHideSpecifyDataLayers(FlatBufferBuilder builder, EHideType Type = EHideType.WorldMonsterAndMonsterTreasure, VectorOffset DataLayersOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IHideSpecifyDataLayers.AddDataLayers(builder, DataLayersOffset);
			IHideSpecifyDataLayers.AddType(builder, Type);
			return IHideSpecifyDataLayers.EndIHideSpecifyDataLayers(builder);
		}

		// Token: 0x0602EE3B RID: 192059 RVA: 0x00665539 File Offset: 0x00663739
		public static void StartIHideSpecifyDataLayers(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602EE3C RID: 192060 RVA: 0x00665542 File Offset: 0x00663742
		public static void AddType(FlatBufferBuilder builder, EHideType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EE3D RID: 192061 RVA: 0x0066554D File Offset: 0x0066374D
		public static void AddDataLayers(FlatBufferBuilder builder, VectorOffset dataLayersOffset)
		{
			builder.AddOffset(1, dataLayersOffset.Value, 0);
		}

		// Token: 0x0602EE3E RID: 192062 RVA: 0x00665560 File Offset: 0x00663760
		public static VectorOffset CreateDataLayersVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602EE3F RID: 192063 RVA: 0x00665597 File Offset: 0x00663797
		public static VectorOffset CreateDataLayersVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EE40 RID: 192064 RVA: 0x006655B1 File Offset: 0x006637B1
		public static VectorOffset CreateDataLayersVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EE41 RID: 192065 RVA: 0x006655CF File Offset: 0x006637CF
		public static VectorOffset CreateDataLayersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602EE42 RID: 192066 RVA: 0x006655E8 File Offset: 0x006637E8
		public static void StartDataLayersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602EE43 RID: 192067 RVA: 0x006655F3 File Offset: 0x006637F3
		public static Offset<IHideSpecifyDataLayers> EndIHideSpecifyDataLayers(FlatBufferBuilder builder)
		{
			return new Offset<IHideSpecifyDataLayers>(builder.EndTable());
		}

		// Token: 0x0602EE44 RID: 192068 RVA: 0x00665600 File Offset: 0x00663800
		public IHideSpecifyDataLayersT UnPack()
		{
			IHideSpecifyDataLayersT hideSpecifyDataLayersT = new IHideSpecifyDataLayersT();
			this.UnPackTo(hideSpecifyDataLayersT);
			return hideSpecifyDataLayersT;
		}

		// Token: 0x0602EE45 RID: 192069 RVA: 0x0066561C File Offset: 0x0066381C
		public void UnPackTo(IHideSpecifyDataLayersT _o)
		{
			_o.Type = this.Type;
			_o.DataLayers = new List<int>();
			for (int i = 0; i < this.DataLayersLength; i++)
			{
				_o.DataLayers.Add(this.DataLayers(i));
			}
		}

		// Token: 0x0602EE46 RID: 192070 RVA: 0x00665664 File Offset: 0x00663864
		public static Offset<IHideSpecifyDataLayers> Pack(FlatBufferBuilder builder, IHideSpecifyDataLayersT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideSpecifyDataLayers>);
			}
			VectorOffset dataLayersOffset = default(VectorOffset);
			if (_o.DataLayers != null)
			{
				int[] data = _o.DataLayers.ToArray();
				dataLayersOffset = IHideSpecifyDataLayers.CreateDataLayersVector(builder, data);
			}
			return IHideSpecifyDataLayers.CreateIHideSpecifyDataLayers(builder, _o.Type, dataLayersOffset);
		}

		// Token: 0x04011070 RID: 69744
		private Table __p;
	}
}
