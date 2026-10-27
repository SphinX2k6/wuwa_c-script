using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054E2 RID: 21730
	public struct ILevelPrefab : IFlatbufferObject
	{
		// Token: 0x1700A03C RID: 41020
		// (get) Token: 0x06023D58 RID: 146776 RVA: 0x004F4354 File Offset: 0x004F2554
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023D59 RID: 146777 RVA: 0x004F4361 File Offset: 0x004F2561
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023D5A RID: 146778 RVA: 0x004F4368 File Offset: 0x004F2568
		public static ILevelPrefab GetRootAsILevelPrefab(ByteBuffer _bb)
		{
			return ILevelPrefab.GetRootAsILevelPrefab(_bb, default(ILevelPrefab));
		}

		// Token: 0x06023D5B RID: 146779 RVA: 0x004F4384 File Offset: 0x004F2584
		public static ILevelPrefab GetRootAsILevelPrefab(ByteBuffer _bb, ILevelPrefab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023D5C RID: 146780 RVA: 0x004F43A1 File Offset: 0x004F25A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023D5D RID: 146781 RVA: 0x004F43B0 File Offset: 0x004F25B0
		public ILevelPrefab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A03D RID: 41021
		// (get) Token: 0x06023D5E RID: 146782 RVA: 0x004F43C0 File Offset: 0x004F25C0
		public EModelType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EModelType.LevelPrefab;
				}
				return (EModelType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A03E RID: 41022
		// (get) Token: 0x06023D5F RID: 146783 RVA: 0x004F43FC File Offset: 0x004F25FC
		public ELevelPrefabBpType BlueprintPath
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ELevelPrefabBpType.Item;
				}
				return (ELevelPrefabBpType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A03F RID: 41023
		// (get) Token: 0x06023D60 RID: 146784 RVA: 0x004F4438 File Offset: 0x004F2638
		public string PrefabPath
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023D61 RID: 146785 RVA: 0x004F446F File Offset: 0x004F266F
		public Span<byte> GetPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06023D62 RID: 146786 RVA: 0x004F447E File Offset: 0x004F267E
		public byte[] GetPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700A040 RID: 41024
		// (get) Token: 0x06023D63 RID: 146787 RVA: 0x004F448C File Offset: 0x004F268C
		public int NameOffsetZ
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023D64 RID: 146788 RVA: 0x004F44CC File Offset: 0x004F26CC
		public IPrefabStateConfig? PrefabStateList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IPrefabStateConfig?(default(IPrefabStateConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A041 RID: 41025
		// (get) Token: 0x06023D65 RID: 146789 RVA: 0x004F4530 File Offset: 0x004F2730
		public int PrefabStateListLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06023D66 RID: 146790 RVA: 0x004F455C File Offset: 0x004F275C
		public IPrefabEffectConfig? EffectStateList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IPrefabEffectConfig?(default(IPrefabEffectConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A042 RID: 41026
		// (get) Token: 0x06023D67 RID: 146791 RVA: 0x004F45C0 File Offset: 0x004F27C0
		public int EffectStateListLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A043 RID: 41027
		// (get) Token: 0x06023D68 RID: 146792 RVA: 0x004F45EC File Offset: 0x004F27EC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023D69 RID: 146793 RVA: 0x004F462C File Offset: 0x004F282C
		public static Offset<ILevelPrefab> CreateILevelPrefab(FlatBufferBuilder builder, EModelType Type = EModelType.LevelPrefab, ELevelPrefabBpType BlueprintPath = ELevelPrefabBpType.Item, StringOffset PrefabPathOffset = default(StringOffset), int NameOffsetZ = 0, VectorOffset PrefabStateListOffset = default(VectorOffset), VectorOffset EffectStateListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(7);
			ILevelPrefab.AddEffectStateList(builder, EffectStateListOffset);
			ILevelPrefab.AddPrefabStateList(builder, PrefabStateListOffset);
			ILevelPrefab.AddNameOffsetZ(builder, NameOffsetZ);
			ILevelPrefab.AddPrefabPath(builder, PrefabPathOffset);
			ILevelPrefab.AddNullMask(builder, NullMask);
			ILevelPrefab.AddBlueprintPath(builder, BlueprintPath);
			ILevelPrefab.AddType(builder, Type);
			return ILevelPrefab.EndILevelPrefab(builder);
		}

		// Token: 0x06023D6A RID: 146794 RVA: 0x004F467B File Offset: 0x004F287B
		public static void StartILevelPrefab(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06023D6B RID: 146795 RVA: 0x004F4684 File Offset: 0x004F2884
		public static void AddType(FlatBufferBuilder builder, EModelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023D6C RID: 146796 RVA: 0x004F468F File Offset: 0x004F288F
		public static void AddBlueprintPath(FlatBufferBuilder builder, ELevelPrefabBpType blueprintPath)
		{
			builder.AddByte(1, (byte)blueprintPath, 0);
		}

		// Token: 0x06023D6D RID: 146797 RVA: 0x004F469A File Offset: 0x004F289A
		public static void AddPrefabPath(FlatBufferBuilder builder, StringOffset prefabPathOffset)
		{
			builder.AddOffset(2, prefabPathOffset.Value, 0);
		}

		// Token: 0x06023D6E RID: 146798 RVA: 0x004F46AA File Offset: 0x004F28AA
		public static void AddNameOffsetZ(FlatBufferBuilder builder, int nameOffsetZ)
		{
			builder.AddInt(3, nameOffsetZ, 0);
		}

		// Token: 0x06023D6F RID: 146799 RVA: 0x004F46B5 File Offset: 0x004F28B5
		public static void AddPrefabStateList(FlatBufferBuilder builder, VectorOffset prefabStateListOffset)
		{
			builder.AddOffset(4, prefabStateListOffset.Value, 0);
		}

		// Token: 0x06023D70 RID: 146800 RVA: 0x004F46C8 File Offset: 0x004F28C8
		public static VectorOffset CreatePrefabStateListVector(FlatBufferBuilder builder, Offset<IPrefabStateConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023D71 RID: 146801 RVA: 0x004F4708 File Offset: 0x004F2908
		public static VectorOffset CreatePrefabStateListVectorBlock(FlatBufferBuilder builder, Offset<IPrefabStateConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPrefabStateConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023D72 RID: 146802 RVA: 0x004F4722 File Offset: 0x004F2922
		public static VectorOffset CreatePrefabStateListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPrefabStateConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPrefabStateConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023D73 RID: 146803 RVA: 0x004F4740 File Offset: 0x004F2940
		public static VectorOffset CreatePrefabStateListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPrefabStateConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023D74 RID: 146804 RVA: 0x004F4759 File Offset: 0x004F2959
		public static void StartPrefabStateListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023D75 RID: 146805 RVA: 0x004F4764 File Offset: 0x004F2964
		public static void AddEffectStateList(FlatBufferBuilder builder, VectorOffset effectStateListOffset)
		{
			builder.AddOffset(5, effectStateListOffset.Value, 0);
		}

		// Token: 0x06023D76 RID: 146806 RVA: 0x004F4774 File Offset: 0x004F2974
		public static VectorOffset CreateEffectStateListVector(FlatBufferBuilder builder, Offset<IPrefabEffectConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023D77 RID: 146807 RVA: 0x004F47B4 File Offset: 0x004F29B4
		public static VectorOffset CreateEffectStateListVectorBlock(FlatBufferBuilder builder, Offset<IPrefabEffectConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPrefabEffectConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023D78 RID: 146808 RVA: 0x004F47CE File Offset: 0x004F29CE
		public static VectorOffset CreateEffectStateListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPrefabEffectConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPrefabEffectConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023D79 RID: 146809 RVA: 0x004F47EC File Offset: 0x004F29EC
		public static VectorOffset CreateEffectStateListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPrefabEffectConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023D7A RID: 146810 RVA: 0x004F4805 File Offset: 0x004F2A05
		public static void StartEffectStateListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023D7B RID: 146811 RVA: 0x004F4810 File Offset: 0x004F2A10
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06023D7C RID: 146812 RVA: 0x004F481B File Offset: 0x004F2A1B
		public static Offset<ILevelPrefab> EndILevelPrefab(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPrefab>(builder.EndTable());
		}

		// Token: 0x06023D7D RID: 146813 RVA: 0x004F4828 File Offset: 0x004F2A28
		public ILevelPrefabT UnPack()
		{
			ILevelPrefabT levelPrefabT = new ILevelPrefabT();
			this.UnPackTo(levelPrefabT);
			return levelPrefabT;
		}

		// Token: 0x06023D7E RID: 146814 RVA: 0x004F4844 File Offset: 0x004F2A44
		public void UnPackTo(ILevelPrefabT _o)
		{
			_o.Type = this.Type;
			_o.BlueprintPath = this.BlueprintPath;
			_o.PrefabPath = this.PrefabPath;
			_o.NameOffsetZ = this.NameOffsetZ;
			_o.PrefabStateList = new List<IPrefabStateConfigT>();
			for (int i = 0; i < this.PrefabStateListLength; i++)
			{
				_o.PrefabStateList.Add((this.PrefabStateList(i) != null) ? this.PrefabStateList(i).Value.UnPack() : null);
			}
			_o.EffectStateList = new List<IPrefabEffectConfigT>();
			for (int j = 0; j < this.EffectStateListLength; j++)
			{
				_o.EffectStateList.Add((this.EffectStateList(j) != null) ? this.EffectStateList(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023D7F RID: 146815 RVA: 0x004F4934 File Offset: 0x004F2B34
		public static Offset<ILevelPrefab> Pack(FlatBufferBuilder builder, ILevelPrefabT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPrefab>);
			}
			StringOffset prefabPathOffset = (_o.PrefabPath == null) ? default(StringOffset) : builder.CreateString(_o.PrefabPath);
			VectorOffset prefabStateListOffset = default(VectorOffset);
			if (_o.PrefabStateList != null)
			{
				Offset<IPrefabStateConfig>[] array = new Offset<IPrefabStateConfig>[_o.PrefabStateList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IPrefabStateConfig.Pack(builder, _o.PrefabStateList[i]);
				}
				prefabStateListOffset = ILevelPrefab.CreatePrefabStateListVector(builder, array);
			}
			VectorOffset effectStateListOffset = default(VectorOffset);
			if (_o.EffectStateList != null)
			{
				Offset<IPrefabEffectConfig>[] array2 = new Offset<IPrefabEffectConfig>[_o.EffectStateList.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IPrefabEffectConfig.Pack(builder, _o.EffectStateList[j]);
				}
				effectStateListOffset = ILevelPrefab.CreateEffectStateListVector(builder, array2);
			}
			return ILevelPrefab.CreateILevelPrefab(builder, _o.Type, _o.BlueprintPath, prefabPathOffset, _o.NameOffsetZ, prefabStateListOffset, effectStateListOffset, _o.NullMask);
		}

		// Token: 0x0400E7B4 RID: 59316
		private Table __p;
	}
}
