using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A68 RID: 23144
	public struct ILevelPrefab : IFlatbufferObject
	{
		// Token: 0x1700A876 RID: 43126
		// (get) Token: 0x06025E10 RID: 155152 RVA: 0x005313C8 File Offset: 0x0052F5C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025E11 RID: 155153 RVA: 0x005313D5 File Offset: 0x0052F5D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025E12 RID: 155154 RVA: 0x005313DC File Offset: 0x0052F5DC
		public static ILevelPrefab GetRootAsILevelPrefab(ByteBuffer _bb)
		{
			return ILevelPrefab.GetRootAsILevelPrefab(_bb, default(ILevelPrefab));
		}

		// Token: 0x06025E13 RID: 155155 RVA: 0x005313F8 File Offset: 0x0052F5F8
		public static ILevelPrefab GetRootAsILevelPrefab(ByteBuffer _bb, ILevelPrefab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025E14 RID: 155156 RVA: 0x00531415 File Offset: 0x0052F615
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025E15 RID: 155157 RVA: 0x00531424 File Offset: 0x0052F624
		public ILevelPrefab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A877 RID: 43127
		// (get) Token: 0x06025E16 RID: 155158 RVA: 0x00531434 File Offset: 0x0052F634
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

		// Token: 0x1700A878 RID: 43128
		// (get) Token: 0x06025E17 RID: 155159 RVA: 0x00531470 File Offset: 0x0052F670
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

		// Token: 0x1700A879 RID: 43129
		// (get) Token: 0x06025E18 RID: 155160 RVA: 0x005314AC File Offset: 0x0052F6AC
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

		// Token: 0x06025E19 RID: 155161 RVA: 0x005314E3 File Offset: 0x0052F6E3
		public Span<byte> GetPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06025E1A RID: 155162 RVA: 0x005314F2 File Offset: 0x0052F6F2
		public byte[] GetPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700A87A RID: 43130
		// (get) Token: 0x06025E1B RID: 155163 RVA: 0x00531500 File Offset: 0x0052F700
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

		// Token: 0x06025E1C RID: 155164 RVA: 0x00531540 File Offset: 0x0052F740
		public IPrefabStateConfig? PrefabStateList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IPrefabStateConfig?(default(IPrefabStateConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A87B RID: 43131
		// (get) Token: 0x06025E1D RID: 155165 RVA: 0x005315A4 File Offset: 0x0052F7A4
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

		// Token: 0x06025E1E RID: 155166 RVA: 0x005315D0 File Offset: 0x0052F7D0
		public IPrefabEffectConfig? EffectStateList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IPrefabEffectConfig?(default(IPrefabEffectConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A87C RID: 43132
		// (get) Token: 0x06025E1F RID: 155167 RVA: 0x00531634 File Offset: 0x0052F834
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

		// Token: 0x1700A87D RID: 43133
		// (get) Token: 0x06025E20 RID: 155168 RVA: 0x00531660 File Offset: 0x0052F860
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

		// Token: 0x06025E21 RID: 155169 RVA: 0x005316A0 File Offset: 0x0052F8A0
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

		// Token: 0x06025E22 RID: 155170 RVA: 0x005316EF File Offset: 0x0052F8EF
		public static void StartILevelPrefab(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06025E23 RID: 155171 RVA: 0x005316F8 File Offset: 0x0052F8F8
		public static void AddType(FlatBufferBuilder builder, EModelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025E24 RID: 155172 RVA: 0x00531703 File Offset: 0x0052F903
		public static void AddBlueprintPath(FlatBufferBuilder builder, ELevelPrefabBpType blueprintPath)
		{
			builder.AddByte(1, (byte)blueprintPath, 0);
		}

		// Token: 0x06025E25 RID: 155173 RVA: 0x0053170E File Offset: 0x0052F90E
		public static void AddPrefabPath(FlatBufferBuilder builder, StringOffset prefabPathOffset)
		{
			builder.AddOffset(2, prefabPathOffset.Value, 0);
		}

		// Token: 0x06025E26 RID: 155174 RVA: 0x0053171E File Offset: 0x0052F91E
		public static void AddNameOffsetZ(FlatBufferBuilder builder, int nameOffsetZ)
		{
			builder.AddInt(3, nameOffsetZ, 0);
		}

		// Token: 0x06025E27 RID: 155175 RVA: 0x00531729 File Offset: 0x0052F929
		public static void AddPrefabStateList(FlatBufferBuilder builder, VectorOffset prefabStateListOffset)
		{
			builder.AddOffset(4, prefabStateListOffset.Value, 0);
		}

		// Token: 0x06025E28 RID: 155176 RVA: 0x0053173C File Offset: 0x0052F93C
		public static VectorOffset CreatePrefabStateListVector(FlatBufferBuilder builder, Offset<IPrefabStateConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025E29 RID: 155177 RVA: 0x0053177C File Offset: 0x0052F97C
		public static VectorOffset CreatePrefabStateListVectorBlock(FlatBufferBuilder builder, Offset<IPrefabStateConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPrefabStateConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025E2A RID: 155178 RVA: 0x00531796 File Offset: 0x0052F996
		public static VectorOffset CreatePrefabStateListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPrefabStateConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPrefabStateConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025E2B RID: 155179 RVA: 0x005317B4 File Offset: 0x0052F9B4
		public static VectorOffset CreatePrefabStateListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPrefabStateConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025E2C RID: 155180 RVA: 0x005317CD File Offset: 0x0052F9CD
		public static void StartPrefabStateListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025E2D RID: 155181 RVA: 0x005317D8 File Offset: 0x0052F9D8
		public static void AddEffectStateList(FlatBufferBuilder builder, VectorOffset effectStateListOffset)
		{
			builder.AddOffset(5, effectStateListOffset.Value, 0);
		}

		// Token: 0x06025E2E RID: 155182 RVA: 0x005317E8 File Offset: 0x0052F9E8
		public static VectorOffset CreateEffectStateListVector(FlatBufferBuilder builder, Offset<IPrefabEffectConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025E2F RID: 155183 RVA: 0x00531828 File Offset: 0x0052FA28
		public static VectorOffset CreateEffectStateListVectorBlock(FlatBufferBuilder builder, Offset<IPrefabEffectConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPrefabEffectConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025E30 RID: 155184 RVA: 0x00531842 File Offset: 0x0052FA42
		public static VectorOffset CreateEffectStateListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPrefabEffectConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPrefabEffectConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025E31 RID: 155185 RVA: 0x00531860 File Offset: 0x0052FA60
		public static VectorOffset CreateEffectStateListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPrefabEffectConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025E32 RID: 155186 RVA: 0x00531879 File Offset: 0x0052FA79
		public static void StartEffectStateListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025E33 RID: 155187 RVA: 0x00531884 File Offset: 0x0052FA84
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06025E34 RID: 155188 RVA: 0x0053188F File Offset: 0x0052FA8F
		public static Offset<ILevelPrefab> EndILevelPrefab(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPrefab>(builder.EndTable());
		}

		// Token: 0x06025E35 RID: 155189 RVA: 0x0053189C File Offset: 0x0052FA9C
		public ILevelPrefabT UnPack()
		{
			ILevelPrefabT levelPrefabT = new ILevelPrefabT();
			this.UnPackTo(levelPrefabT);
			return levelPrefabT;
		}

		// Token: 0x06025E36 RID: 155190 RVA: 0x005318B8 File Offset: 0x0052FAB8
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

		// Token: 0x06025E37 RID: 155191 RVA: 0x005319A8 File Offset: 0x0052FBA8
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

		// Token: 0x0400F3E5 RID: 62437
		private Table __p;
	}
}
