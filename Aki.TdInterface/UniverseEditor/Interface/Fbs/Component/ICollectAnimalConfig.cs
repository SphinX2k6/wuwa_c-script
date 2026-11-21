using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200550B RID: 21771
	public struct ICollectAnimalConfig : IFlatbufferObject
	{
		// Token: 0x17009B96 RID: 39830
		// (get) Token: 0x0602266B RID: 140907 RVA: 0x004BDB7B File Offset: 0x004BBD7B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602266C RID: 140908 RVA: 0x004BDB88 File Offset: 0x004BBD88
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602266D RID: 140909 RVA: 0x004BDB90 File Offset: 0x004BBD90
		public static ICollectAnimalConfig GetRootAsICollectAnimalConfig(ByteBuffer _bb)
		{
			return ICollectAnimalConfig.GetRootAsICollectAnimalConfig(_bb, default(ICollectAnimalConfig));
		}

		// Token: 0x0602266E RID: 140910 RVA: 0x004BDBAC File Offset: 0x004BBDAC
		public static ICollectAnimalConfig GetRootAsICollectAnimalConfig(ByteBuffer _bb, ICollectAnimalConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602266F RID: 140911 RVA: 0x004BDBC9 File Offset: 0x004BBDC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022670 RID: 140912 RVA: 0x004BDBD8 File Offset: 0x004BBDD8
		public ICollectAnimalConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B97 RID: 39831
		// (get) Token: 0x06022671 RID: 140913 RVA: 0x004BDBE8 File Offset: 0x004BBDE8
		public ESpecialAnimalType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpecialAnimalType.CollectAnimal;
				}
				return (ESpecialAnimalType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022672 RID: 140914 RVA: 0x004BDC24 File Offset: 0x004BBE24
		public ICollectAnimalPartsConfig? PartsMap(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICollectAnimalPartsConfig?(default(ICollectAnimalPartsConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009B98 RID: 39832
		// (get) Token: 0x06022673 RID: 140915 RVA: 0x004BDC84 File Offset: 0x004BBE84
		public int PartsMapLength
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

		// Token: 0x06022674 RID: 140916 RVA: 0x004BDCAF File Offset: 0x004BBEAF
		public static Offset<ICollectAnimalConfig> CreateICollectAnimalConfig(FlatBufferBuilder builder, ESpecialAnimalType Type = ESpecialAnimalType.CollectAnimal, VectorOffset PartsMapOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ICollectAnimalConfig.AddPartsMap(builder, PartsMapOffset);
			ICollectAnimalConfig.AddType(builder, Type);
			return ICollectAnimalConfig.EndICollectAnimalConfig(builder);
		}

		// Token: 0x06022675 RID: 140917 RVA: 0x004BDCCC File Offset: 0x004BBECC
		public static void StartICollectAnimalConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022676 RID: 140918 RVA: 0x004BDCD5 File Offset: 0x004BBED5
		public static void AddType(FlatBufferBuilder builder, ESpecialAnimalType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022677 RID: 140919 RVA: 0x004BDCE0 File Offset: 0x004BBEE0
		public static void AddPartsMap(FlatBufferBuilder builder, VectorOffset partsMapOffset)
		{
			builder.AddOffset(1, partsMapOffset.Value, 0);
		}

		// Token: 0x06022678 RID: 140920 RVA: 0x004BDCF0 File Offset: 0x004BBEF0
		public static VectorOffset CreatePartsMapVector(FlatBufferBuilder builder, Offset<ICollectAnimalPartsConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022679 RID: 140921 RVA: 0x004BDD30 File Offset: 0x004BBF30
		public static VectorOffset CreatePartsMapVectorBlock(FlatBufferBuilder builder, Offset<ICollectAnimalPartsConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICollectAnimalPartsConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602267A RID: 140922 RVA: 0x004BDD4A File Offset: 0x004BBF4A
		public static VectorOffset CreatePartsMapVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICollectAnimalPartsConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICollectAnimalPartsConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602267B RID: 140923 RVA: 0x004BDD68 File Offset: 0x004BBF68
		public static VectorOffset CreatePartsMapVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICollectAnimalPartsConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602267C RID: 140924 RVA: 0x004BDD81 File Offset: 0x004BBF81
		public static void StartPartsMapVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602267D RID: 140925 RVA: 0x004BDD8C File Offset: 0x004BBF8C
		public static Offset<ICollectAnimalConfig> EndICollectAnimalConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICollectAnimalConfig>(builder.EndTable());
		}

		// Token: 0x0602267E RID: 140926 RVA: 0x004BDD9C File Offset: 0x004BBF9C
		public ICollectAnimalConfigT UnPack()
		{
			ICollectAnimalConfigT collectAnimalConfigT = new ICollectAnimalConfigT();
			this.UnPackTo(collectAnimalConfigT);
			return collectAnimalConfigT;
		}

		// Token: 0x0602267F RID: 140927 RVA: 0x004BDDB8 File Offset: 0x004BBFB8
		public void UnPackTo(ICollectAnimalConfigT _o)
		{
			_o.Type = this.Type;
			_o.PartsMap = new List<ICollectAnimalPartsConfigT>();
			for (int i = 0; i < this.PartsMapLength; i++)
			{
				_o.PartsMap.Add((this.PartsMap(i) != null) ? this.PartsMap(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06022680 RID: 140928 RVA: 0x004BDE24 File Offset: 0x004BC024
		public static Offset<ICollectAnimalConfig> Pack(FlatBufferBuilder builder, ICollectAnimalConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICollectAnimalConfig>);
			}
			VectorOffset partsMapOffset = default(VectorOffset);
			if (_o.PartsMap != null)
			{
				Offset<ICollectAnimalPartsConfig>[] array = new Offset<ICollectAnimalPartsConfig>[_o.PartsMap.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICollectAnimalPartsConfig.Pack(builder, _o.PartsMap[i]);
				}
				partsMapOffset = ICollectAnimalConfig.CreatePartsMapVector(builder, array);
			}
			return ICollectAnimalConfig.CreateICollectAnimalConfig(builder, _o.Type, partsMapOffset);
		}

		// Token: 0x0400EA76 RID: 60022
		private Table __p;
	}
}
