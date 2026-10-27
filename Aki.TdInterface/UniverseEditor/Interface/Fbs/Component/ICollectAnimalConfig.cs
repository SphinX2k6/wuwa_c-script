using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FAF RID: 20399
	public struct ICollectAnimalConfig : IFlatbufferObject
	{
		// Token: 0x170093BE RID: 37822
		// (get) Token: 0x06020777 RID: 132983 RVA: 0x00484697 File Offset: 0x00482897
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020778 RID: 132984 RVA: 0x004846A4 File Offset: 0x004828A4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020779 RID: 132985 RVA: 0x004846AC File Offset: 0x004828AC
		public static ICollectAnimalConfig GetRootAsICollectAnimalConfig(ByteBuffer _bb)
		{
			return ICollectAnimalConfig.GetRootAsICollectAnimalConfig(_bb, default(ICollectAnimalConfig));
		}

		// Token: 0x0602077A RID: 132986 RVA: 0x004846C8 File Offset: 0x004828C8
		public static ICollectAnimalConfig GetRootAsICollectAnimalConfig(ByteBuffer _bb, ICollectAnimalConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602077B RID: 132987 RVA: 0x004846E5 File Offset: 0x004828E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602077C RID: 132988 RVA: 0x004846F4 File Offset: 0x004828F4
		public ICollectAnimalConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170093BF RID: 37823
		// (get) Token: 0x0602077D RID: 132989 RVA: 0x00484704 File Offset: 0x00482904
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

		// Token: 0x0602077E RID: 132990 RVA: 0x00484740 File Offset: 0x00482940
		public ICollectAnimalPartsConfig? PartsMap(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICollectAnimalPartsConfig?(default(ICollectAnimalPartsConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170093C0 RID: 37824
		// (get) Token: 0x0602077F RID: 132991 RVA: 0x004847A0 File Offset: 0x004829A0
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

		// Token: 0x06020780 RID: 132992 RVA: 0x004847CB File Offset: 0x004829CB
		public static Offset<ICollectAnimalConfig> CreateICollectAnimalConfig(FlatBufferBuilder builder, ESpecialAnimalType Type = ESpecialAnimalType.CollectAnimal, VectorOffset PartsMapOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ICollectAnimalConfig.AddPartsMap(builder, PartsMapOffset);
			ICollectAnimalConfig.AddType(builder, Type);
			return ICollectAnimalConfig.EndICollectAnimalConfig(builder);
		}

		// Token: 0x06020781 RID: 132993 RVA: 0x004847E8 File Offset: 0x004829E8
		public static void StartICollectAnimalConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020782 RID: 132994 RVA: 0x004847F1 File Offset: 0x004829F1
		public static void AddType(FlatBufferBuilder builder, ESpecialAnimalType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020783 RID: 132995 RVA: 0x004847FC File Offset: 0x004829FC
		public static void AddPartsMap(FlatBufferBuilder builder, VectorOffset partsMapOffset)
		{
			builder.AddOffset(1, partsMapOffset.Value, 0);
		}

		// Token: 0x06020784 RID: 132996 RVA: 0x0048480C File Offset: 0x00482A0C
		public static VectorOffset CreatePartsMapVector(FlatBufferBuilder builder, Offset<ICollectAnimalPartsConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020785 RID: 132997 RVA: 0x0048484C File Offset: 0x00482A4C
		public static VectorOffset CreatePartsMapVectorBlock(FlatBufferBuilder builder, Offset<ICollectAnimalPartsConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICollectAnimalPartsConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020786 RID: 132998 RVA: 0x00484866 File Offset: 0x00482A66
		public static VectorOffset CreatePartsMapVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICollectAnimalPartsConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICollectAnimalPartsConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020787 RID: 132999 RVA: 0x00484884 File Offset: 0x00482A84
		public static VectorOffset CreatePartsMapVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICollectAnimalPartsConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020788 RID: 133000 RVA: 0x0048489D File Offset: 0x00482A9D
		public static void StartPartsMapVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020789 RID: 133001 RVA: 0x004848A8 File Offset: 0x00482AA8
		public static Offset<ICollectAnimalConfig> EndICollectAnimalConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICollectAnimalConfig>(builder.EndTable());
		}

		// Token: 0x0602078A RID: 133002 RVA: 0x004848B8 File Offset: 0x00482AB8
		public ICollectAnimalConfigT UnPack()
		{
			ICollectAnimalConfigT collectAnimalConfigT = new ICollectAnimalConfigT();
			this.UnPackTo(collectAnimalConfigT);
			return collectAnimalConfigT;
		}

		// Token: 0x0602078B RID: 133003 RVA: 0x004848D4 File Offset: 0x00482AD4
		public void UnPackTo(ICollectAnimalConfigT _o)
		{
			_o.Type = this.Type;
			_o.PartsMap = new List<ICollectAnimalPartsConfigT>();
			for (int i = 0; i < this.PartsMapLength; i++)
			{
				_o.PartsMap.Add((this.PartsMap(i) != null) ? this.PartsMap(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602078C RID: 133004 RVA: 0x00484940 File Offset: 0x00482B40
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

		// Token: 0x0400DE88 RID: 56968
		private Table __p;
	}
}
