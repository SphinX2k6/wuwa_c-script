using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004739 RID: 18233
	public struct IFlowTemplateConfig : IFlatbufferObject
	{
		// Token: 0x170082C7 RID: 33479
		// (get) Token: 0x0601C09F RID: 114847 RVA: 0x003F91F3 File Offset: 0x003F73F3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C0A0 RID: 114848 RVA: 0x003F9200 File Offset: 0x003F7400
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C0A1 RID: 114849 RVA: 0x003F9208 File Offset: 0x003F7408
		public static IFlowTemplateConfig GetRootAsIFlowTemplateConfig(ByteBuffer _bb)
		{
			return IFlowTemplateConfig.GetRootAsIFlowTemplateConfig(_bb, default(IFlowTemplateConfig));
		}

		// Token: 0x0601C0A2 RID: 114850 RVA: 0x003F9224 File Offset: 0x003F7424
		public static IFlowTemplateConfig GetRootAsIFlowTemplateConfig(ByteBuffer _bb, IFlowTemplateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C0A3 RID: 114851 RVA: 0x003F9241 File Offset: 0x003F7441
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C0A4 RID: 114852 RVA: 0x003F9250 File Offset: 0x003F7450
		public IFlowTemplateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601C0A5 RID: 114853 RVA: 0x003F9260 File Offset: 0x003F7460
		public IFlowTemplateData? List(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IFlowTemplateData?(default(IFlowTemplateData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170082C8 RID: 33480
		// (get) Token: 0x0601C0A6 RID: 114854 RVA: 0x003F92C0 File Offset: 0x003F74C0
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

		// Token: 0x0601C0A7 RID: 114855 RVA: 0x003F92EB File Offset: 0x003F74EB
		public static Offset<IFlowTemplateConfig> CreateIFlowTemplateConfig(FlatBufferBuilder builder, VectorOffset ListOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IFlowTemplateConfig.AddList(builder, ListOffset);
			return IFlowTemplateConfig.EndIFlowTemplateConfig(builder);
		}

		// Token: 0x0601C0A8 RID: 114856 RVA: 0x003F9301 File Offset: 0x003F7501
		public static void StartIFlowTemplateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C0A9 RID: 114857 RVA: 0x003F930A File Offset: 0x003F750A
		public static void AddList(FlatBufferBuilder builder, VectorOffset listOffset)
		{
			builder.AddOffset(0, listOffset.Value, 0);
		}

		// Token: 0x0601C0AA RID: 114858 RVA: 0x003F931C File Offset: 0x003F751C
		public static VectorOffset CreateListVector(FlatBufferBuilder builder, Offset<IFlowTemplateData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C0AB RID: 114859 RVA: 0x003F935C File Offset: 0x003F755C
		public static VectorOffset CreateListVectorBlock(FlatBufferBuilder builder, Offset<IFlowTemplateData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFlowTemplateData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C0AC RID: 114860 RVA: 0x003F9376 File Offset: 0x003F7576
		public static VectorOffset CreateListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFlowTemplateData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFlowTemplateData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C0AD RID: 114861 RVA: 0x003F9394 File Offset: 0x003F7594
		public static VectorOffset CreateListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFlowTemplateData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C0AE RID: 114862 RVA: 0x003F93AD File Offset: 0x003F75AD
		public static void StartListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C0AF RID: 114863 RVA: 0x003F93B8 File Offset: 0x003F75B8
		public static Offset<IFlowTemplateConfig> EndIFlowTemplateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFlowTemplateConfig>(builder.EndTable());
		}

		// Token: 0x0601C0B0 RID: 114864 RVA: 0x003F93C8 File Offset: 0x003F75C8
		public IFlowTemplateConfigT UnPack()
		{
			IFlowTemplateConfigT flowTemplateConfigT = new IFlowTemplateConfigT();
			this.UnPackTo(flowTemplateConfigT);
			return flowTemplateConfigT;
		}

		// Token: 0x0601C0B1 RID: 114865 RVA: 0x003F93E4 File Offset: 0x003F75E4
		public void UnPackTo(IFlowTemplateConfigT _o)
		{
			_o.List = new List<IFlowTemplateDataT>();
			for (int i = 0; i < this.ListLength; i++)
			{
				_o.List.Add((this.List(i) != null) ? this.List(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601C0B2 RID: 114866 RVA: 0x003F9444 File Offset: 0x003F7644
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

		// Token: 0x0400CA20 RID: 51744
		private Table __p;
	}
}
