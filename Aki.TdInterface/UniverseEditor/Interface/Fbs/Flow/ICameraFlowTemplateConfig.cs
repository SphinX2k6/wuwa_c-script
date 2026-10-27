using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x0200472A RID: 18218
	public struct ICameraFlowTemplateConfig : IFlatbufferObject
	{
		// Token: 0x17008292 RID: 33426
		// (get) Token: 0x0601BFDB RID: 114651 RVA: 0x003F77AB File Offset: 0x003F59AB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BFDC RID: 114652 RVA: 0x003F77B8 File Offset: 0x003F59B8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BFDD RID: 114653 RVA: 0x003F77C0 File Offset: 0x003F59C0
		public static ICameraFlowTemplateConfig GetRootAsICameraFlowTemplateConfig(ByteBuffer _bb)
		{
			return ICameraFlowTemplateConfig.GetRootAsICameraFlowTemplateConfig(_bb, default(ICameraFlowTemplateConfig));
		}

		// Token: 0x0601BFDE RID: 114654 RVA: 0x003F77DC File Offset: 0x003F59DC
		public static ICameraFlowTemplateConfig GetRootAsICameraFlowTemplateConfig(ByteBuffer _bb, ICameraFlowTemplateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BFDF RID: 114655 RVA: 0x003F77F9 File Offset: 0x003F59F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BFE0 RID: 114656 RVA: 0x003F7808 File Offset: 0x003F5A08
		public ICameraFlowTemplateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601BFE1 RID: 114657 RVA: 0x003F7818 File Offset: 0x003F5A18
		public ICameraTemplate? List(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new ICameraTemplate?(default(ICameraTemplate).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008293 RID: 33427
		// (get) Token: 0x0601BFE2 RID: 114658 RVA: 0x003F7878 File Offset: 0x003F5A78
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

		// Token: 0x0601BFE3 RID: 114659 RVA: 0x003F78A3 File Offset: 0x003F5AA3
		public static Offset<ICameraFlowTemplateConfig> CreateICameraFlowTemplateConfig(FlatBufferBuilder builder, VectorOffset ListOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ICameraFlowTemplateConfig.AddList(builder, ListOffset);
			return ICameraFlowTemplateConfig.EndICameraFlowTemplateConfig(builder);
		}

		// Token: 0x0601BFE4 RID: 114660 RVA: 0x003F78B9 File Offset: 0x003F5AB9
		public static void StartICameraFlowTemplateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601BFE5 RID: 114661 RVA: 0x003F78C2 File Offset: 0x003F5AC2
		public static void AddList(FlatBufferBuilder builder, VectorOffset listOffset)
		{
			builder.AddOffset(0, listOffset.Value, 0);
		}

		// Token: 0x0601BFE6 RID: 114662 RVA: 0x003F78D4 File Offset: 0x003F5AD4
		public static VectorOffset CreateListVector(FlatBufferBuilder builder, Offset<ICameraTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BFE7 RID: 114663 RVA: 0x003F7914 File Offset: 0x003F5B14
		public static VectorOffset CreateListVectorBlock(FlatBufferBuilder builder, Offset<ICameraTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICameraTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BFE8 RID: 114664 RVA: 0x003F792E File Offset: 0x003F5B2E
		public static VectorOffset CreateListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICameraTemplate>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICameraTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BFE9 RID: 114665 RVA: 0x003F794C File Offset: 0x003F5B4C
		public static VectorOffset CreateListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICameraTemplate>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BFEA RID: 114666 RVA: 0x003F7965 File Offset: 0x003F5B65
		public static void StartListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BFEB RID: 114667 RVA: 0x003F7970 File Offset: 0x003F5B70
		public static Offset<ICameraFlowTemplateConfig> EndICameraFlowTemplateConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICameraFlowTemplateConfig>(builder.EndTable());
		}

		// Token: 0x0601BFEC RID: 114668 RVA: 0x003F7980 File Offset: 0x003F5B80
		public ICameraFlowTemplateConfigT UnPack()
		{
			ICameraFlowTemplateConfigT cameraFlowTemplateConfigT = new ICameraFlowTemplateConfigT();
			this.UnPackTo(cameraFlowTemplateConfigT);
			return cameraFlowTemplateConfigT;
		}

		// Token: 0x0601BFED RID: 114669 RVA: 0x003F799C File Offset: 0x003F5B9C
		public void UnPackTo(ICameraFlowTemplateConfigT _o)
		{
			_o.List = new List<ICameraTemplateT>();
			for (int i = 0; i < this.ListLength; i++)
			{
				_o.List.Add((this.List(i) != null) ? this.List(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601BFEE RID: 114670 RVA: 0x003F79FC File Offset: 0x003F5BFC
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

		// Token: 0x0400CA03 RID: 51715
		private Table __p;
	}
}
