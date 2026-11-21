using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004B92 RID: 19346
	public struct ICameraFlowTemplateConfig : IFlatbufferObject
	{
		// Token: 0x170088D3 RID: 35027
		// (get) Token: 0x0601D7B0 RID: 120752 RVA: 0x00423A47 File Offset: 0x00421C47
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D7B1 RID: 120753 RVA: 0x00423A54 File Offset: 0x00421C54
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D7B2 RID: 120754 RVA: 0x00423A5C File Offset: 0x00421C5C
		public static ICameraFlowTemplateConfig GetRootAsICameraFlowTemplateConfig(ByteBuffer _bb)
		{
			return ICameraFlowTemplateConfig.GetRootAsICameraFlowTemplateConfig(_bb, default(ICameraFlowTemplateConfig));
		}

		// Token: 0x0601D7B3 RID: 120755 RVA: 0x00423A78 File Offset: 0x00421C78
		public static ICameraFlowTemplateConfig GetRootAsICameraFlowTemplateConfig(ByteBuffer _bb, ICameraFlowTemplateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D7B4 RID: 120756 RVA: 0x00423A95 File Offset: 0x00421C95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D7B5 RID: 120757 RVA: 0x00423AA4 File Offset: 0x00421CA4
		public ICameraFlowTemplateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601D7B6 RID: 120758 RVA: 0x00423AB4 File Offset: 0x00421CB4
		public ICameraTemplate? List(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new ICameraTemplate?(default(ICameraTemplate).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170088D4 RID: 35028
		// (get) Token: 0x0601D7B7 RID: 120759 RVA: 0x00423B14 File Offset: 0x00421D14
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

		// Token: 0x0601D7B8 RID: 120760 RVA: 0x00423B3F File Offset: 0x00421D3F
		public static Offset<ICameraFlowTemplateConfig> CreateICameraFlowTemplateConfig(FlatBufferBuilder builder, VectorOffset ListOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ICameraFlowTemplateConfig.AddList(builder, ListOffset);
			return ICameraFlowTemplateConfig.EndICameraFlowTemplateConfig(builder);
		}

		// Token: 0x0601D7B9 RID: 120761 RVA: 0x00423B55 File Offset: 0x00421D55
		public static void StartICameraFlowTemplateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601D7BA RID: 120762 RVA: 0x00423B5E File Offset: 0x00421D5E
		public static void AddList(FlatBufferBuilder builder, VectorOffset listOffset)
		{
			builder.AddOffset(0, listOffset.Value, 0);
		}

		// Token: 0x0601D7BB RID: 120763 RVA: 0x00423B70 File Offset: 0x00421D70
		public static VectorOffset CreateListVector(FlatBufferBuilder builder, Offset<ICameraTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D7BC RID: 120764 RVA: 0x00423BB0 File Offset: 0x00421DB0
		public static VectorOffset CreateListVectorBlock(FlatBufferBuilder builder, Offset<ICameraTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICameraTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D7BD RID: 120765 RVA: 0x00423BCA File Offset: 0x00421DCA
		public static VectorOffset CreateListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICameraTemplate>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICameraTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D7BE RID: 120766 RVA: 0x00423BE8 File Offset: 0x00421DE8
		public static VectorOffset CreateListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICameraTemplate>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D7BF RID: 120767 RVA: 0x00423C01 File Offset: 0x00421E01
		public static void StartListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D7C0 RID: 120768 RVA: 0x00423C0C File Offset: 0x00421E0C
		public static Offset<ICameraFlowTemplateConfig> EndICameraFlowTemplateConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICameraFlowTemplateConfig>(builder.EndTable());
		}

		// Token: 0x0601D7C1 RID: 120769 RVA: 0x00423C1C File Offset: 0x00421E1C
		public ICameraFlowTemplateConfigT UnPack()
		{
			ICameraFlowTemplateConfigT cameraFlowTemplateConfigT = new ICameraFlowTemplateConfigT();
			this.UnPackTo(cameraFlowTemplateConfigT);
			return cameraFlowTemplateConfigT;
		}

		// Token: 0x0601D7C2 RID: 120770 RVA: 0x00423C38 File Offset: 0x00421E38
		public void UnPackTo(ICameraFlowTemplateConfigT _o)
		{
			_o.List = new List<ICameraTemplateT>();
			for (int i = 0; i < this.ListLength; i++)
			{
				_o.List.Add((this.List(i) != null) ? this.List(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601D7C3 RID: 120771 RVA: 0x00423C98 File Offset: 0x00421E98
		public static Offset<ICameraFlowTemplateConfig> Pack(FlatBufferBuilder builder, ICameraFlowTemplateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraFlowTemplateConfig>);
			}
			VectorOffset listOffset = default(VectorOffset);
			if (_o.List != null)
			{
				Offset<ICameraTemplate>[] array = new Offset<ICameraTemplate>[_o.List.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICameraTemplate.Pack(builder, _o.List[i]);
				}
				listOffset = ICameraFlowTemplateConfig.CreateListVector(builder, array);
			}
			return ICameraFlowTemplateConfig.CreateICameraFlowTemplateConfig(builder, listOffset);
		}

		// Token: 0x0400D432 RID: 54322
		private Table __p;
	}
}
