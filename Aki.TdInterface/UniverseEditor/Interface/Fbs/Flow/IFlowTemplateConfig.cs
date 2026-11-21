using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004BA1 RID: 19361
	public struct IFlowTemplateConfig : IFlatbufferObject
	{
		// Token: 0x17008908 RID: 35080
		// (get) Token: 0x0601D874 RID: 120948 RVA: 0x0042548F File Offset: 0x0042368F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D875 RID: 120949 RVA: 0x0042549C File Offset: 0x0042369C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D876 RID: 120950 RVA: 0x004254A4 File Offset: 0x004236A4
		public static IFlowTemplateConfig GetRootAsIFlowTemplateConfig(ByteBuffer _bb)
		{
			return IFlowTemplateConfig.GetRootAsIFlowTemplateConfig(_bb, default(IFlowTemplateConfig));
		}

		// Token: 0x0601D877 RID: 120951 RVA: 0x004254C0 File Offset: 0x004236C0
		public static IFlowTemplateConfig GetRootAsIFlowTemplateConfig(ByteBuffer _bb, IFlowTemplateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D878 RID: 120952 RVA: 0x004254DD File Offset: 0x004236DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D879 RID: 120953 RVA: 0x004254EC File Offset: 0x004236EC
		public IFlowTemplateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601D87A RID: 120954 RVA: 0x004254FC File Offset: 0x004236FC
		public IFlowTemplateData? List(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IFlowTemplateData?(default(IFlowTemplateData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008909 RID: 35081
		// (get) Token: 0x0601D87B RID: 120955 RVA: 0x0042555C File Offset: 0x0042375C
		public int ListLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601D87C RID: 120956 RVA: 0x00425587 File Offset: 0x00423787
		public static Offset<IFlowTemplateConfig> CreateIFlowTemplateConfig(FlatBufferBuilder builder, VectorOffset ListOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IFlowTemplateConfig.AddList(builder, ListOffset);
			return IFlowTemplateConfig.EndIFlowTemplateConfig(builder);
		}

		// Token: 0x0601D87D RID: 120957 RVA: 0x0042559D File Offset: 0x0042379D
		public static void StartIFlowTemplateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601D87E RID: 120958 RVA: 0x004255A6 File Offset: 0x004237A6
		public static void AddList(FlatBufferBuilder builder, VectorOffset listOffset)
		{
			builder.AddOffset(0, listOffset.Value, 0);
		}

		// Token: 0x0601D87F RID: 120959 RVA: 0x004255B8 File Offset: 0x004237B8
		public static VectorOffset CreateListVector(FlatBufferBuilder builder, Offset<IFlowTemplateData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D880 RID: 120960 RVA: 0x004255F8 File Offset: 0x004237F8
		public static VectorOffset CreateListVectorBlock(FlatBufferBuilder builder, Offset<IFlowTemplateData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFlowTemplateData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D881 RID: 120961 RVA: 0x00425612 File Offset: 0x00423812
		public static VectorOffset CreateListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFlowTemplateData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFlowTemplateData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D882 RID: 120962 RVA: 0x00425630 File Offset: 0x00423830
		public static VectorOffset CreateListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFlowTemplateData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D883 RID: 120963 RVA: 0x00425649 File Offset: 0x00423849
		public static void StartListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D884 RID: 120964 RVA: 0x00425654 File Offset: 0x00423854
		public static Offset<IFlowTemplateConfig> EndIFlowTemplateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFlowTemplateConfig>(builder.EndTable());
		}

		// Token: 0x0601D885 RID: 120965 RVA: 0x00425664 File Offset: 0x00423864
		public IFlowTemplateConfigT UnPack()
		{
			IFlowTemplateConfigT flowTemplateConfigT = new IFlowTemplateConfigT();
			this.UnPackTo(flowTemplateConfigT);
			return flowTemplateConfigT;
		}

		// Token: 0x0601D886 RID: 120966 RVA: 0x00425680 File Offset: 0x00423880
		public void UnPackTo(IFlowTemplateConfigT _o)
		{
			_o.List = new List<IFlowTemplateDataT>();
			for (int i = 0; i < this.ListLength; i++)
			{
				_o.List.Add((this.List(i) != null) ? this.List(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601D887 RID: 120967 RVA: 0x004256E0 File Offset: 0x004238E0
		public static Offset<IFlowTemplateConfig> Pack(FlatBufferBuilder builder, IFlowTemplateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowTemplateConfig>);
			}
			VectorOffset listOffset = default(VectorOffset);
			if (_o.List != null)
			{
				Offset<IFlowTemplateData>[] array = new Offset<IFlowTemplateData>[_o.List.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IFlowTemplateData.Pack(builder, _o.List[i]);
				}
				listOffset = IFlowTemplateConfig.CreateListVector(builder, array);
			}
			return IFlowTemplateConfig.CreateIFlowTemplateConfig(builder, listOffset);
		}

		// Token: 0x0400D44F RID: 54351
		private Table __p;
	}
}
