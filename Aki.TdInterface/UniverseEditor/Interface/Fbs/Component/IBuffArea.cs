using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200545A RID: 21594
	public struct IBuffArea : IFlatbufferObject
	{
		// Token: 0x1700998A RID: 39306
		// (get) Token: 0x06021E70 RID: 138864 RVA: 0x004AC52E File Offset: 0x004AA72E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021E71 RID: 138865 RVA: 0x004AC53B File Offset: 0x004AA73B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021E72 RID: 138866 RVA: 0x004AC544 File Offset: 0x004AA744
		public static IBuffArea GetRootAsIBuffArea(ByteBuffer _bb)
		{
			return IBuffArea.GetRootAsIBuffArea(_bb, default(IBuffArea));
		}

		// Token: 0x06021E73 RID: 138867 RVA: 0x004AC560 File Offset: 0x004AA760
		public static IBuffArea GetRootAsIBuffArea(ByteBuffer _bb, IBuffArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021E74 RID: 138868 RVA: 0x004AC57D File Offset: 0x004AA77D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021E75 RID: 138869 RVA: 0x004AC58C File Offset: 0x004AA78C
		public IBuffArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700998B RID: 39307
		// (get) Token: 0x06021E76 RID: 138870 RVA: 0x004AC59C File Offset: 0x004AA79C
		public EEffectAreaType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEffectAreaType.BuffArea;
				}
				return (EEffectAreaType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021E77 RID: 138871 RVA: 0x004AC5D8 File Offset: 0x004AA7D8
		public IBuffAreaStateConfig? BuffConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IBuffAreaStateConfig?(default(IBuffAreaStateConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700998C RID: 39308
		// (get) Token: 0x06021E78 RID: 138872 RVA: 0x004AC638 File Offset: 0x004AA838
		public int BuffConfigsLength
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

		// Token: 0x06021E79 RID: 138873 RVA: 0x004AC663 File Offset: 0x004AA863
		public static Offset<IBuffArea> CreateIBuffArea(FlatBufferBuilder builder, EEffectAreaType Type = EEffectAreaType.BuffArea, VectorOffset BuffConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IBuffArea.AddBuffConfigs(builder, BuffConfigsOffset);
			IBuffArea.AddType(builder, Type);
			return IBuffArea.EndIBuffArea(builder);
		}

		// Token: 0x06021E7A RID: 138874 RVA: 0x004AC680 File Offset: 0x004AA880
		public static void StartIBuffArea(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021E7B RID: 138875 RVA: 0x004AC689 File Offset: 0x004AA889
		public static void AddType(FlatBufferBuilder builder, EEffectAreaType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021E7C RID: 138876 RVA: 0x004AC694 File Offset: 0x004AA894
		public static void AddBuffConfigs(FlatBufferBuilder builder, VectorOffset buffConfigsOffset)
		{
			builder.AddOffset(1, buffConfigsOffset.Value, 0);
		}

		// Token: 0x06021E7D RID: 138877 RVA: 0x004AC6A4 File Offset: 0x004AA8A4
		public static VectorOffset CreateBuffConfigsVector(FlatBufferBuilder builder, Offset<IBuffAreaStateConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021E7E RID: 138878 RVA: 0x004AC6E4 File Offset: 0x004AA8E4
		public static VectorOffset CreateBuffConfigsVectorBlock(FlatBufferBuilder builder, Offset<IBuffAreaStateConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IBuffAreaStateConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021E7F RID: 138879 RVA: 0x004AC6FE File Offset: 0x004AA8FE
		public static VectorOffset CreateBuffConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IBuffAreaStateConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IBuffAreaStateConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021E80 RID: 138880 RVA: 0x004AC71C File Offset: 0x004AA91C
		public static VectorOffset CreateBuffConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IBuffAreaStateConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021E81 RID: 138881 RVA: 0x004AC735 File Offset: 0x004AA935
		public static void StartBuffConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021E82 RID: 138882 RVA: 0x004AC740 File Offset: 0x004AA940
		public static Offset<IBuffArea> EndIBuffArea(FlatBufferBuilder builder)
		{
			return new Offset<IBuffArea>(builder.EndTable());
		}

		// Token: 0x06021E83 RID: 138883 RVA: 0x004AC750 File Offset: 0x004AA950
		public IBuffAreaT UnPack()
		{
			IBuffAreaT buffAreaT = new IBuffAreaT();
			this.UnPackTo(buffAreaT);
			return buffAreaT;
		}

		// Token: 0x06021E84 RID: 138884 RVA: 0x004AC76C File Offset: 0x004AA96C
		public void UnPackTo(IBuffAreaT _o)
		{
			_o.Type = this.Type;
			_o.BuffConfigs = new List<IBuffAreaStateConfigT>();
			for (int i = 0; i < this.BuffConfigsLength; i++)
			{
				_o.BuffConfigs.Add((this.BuffConfigs(i) != null) ? this.BuffConfigs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06021E85 RID: 138885 RVA: 0x004AC7D8 File Offset: 0x004AA9D8
		public static Offset<IBuffArea> Pack(FlatBufferBuilder builder, IBuffAreaT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBuffArea>);
			}
			VectorOffset buffConfigsOffset = default(VectorOffset);
			if (_o.BuffConfigs != null)
			{
				Offset<IBuffAreaStateConfig>[] array = new Offset<IBuffAreaStateConfig>[_o.BuffConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IBuffAreaStateConfig.Pack(builder, _o.BuffConfigs[i]);
				}
				buffConfigsOffset = IBuffArea.CreateBuffConfigsVector(builder, array);
			}
			return IBuffArea.CreateIBuffArea(builder, _o.Type, buffConfigsOffset);
		}

		// Token: 0x0400E939 RID: 59705
		private Table __p;
	}
}
