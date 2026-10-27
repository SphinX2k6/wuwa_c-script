using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A36 RID: 18998
	public struct ICheckGiantRegionCultivationTriggeredUpgradeLevel : IFlatbufferObject
	{
		// Token: 0x17008989 RID: 35209
		// (get) Token: 0x0601DBD0 RID: 121808 RVA: 0x0042EB74 File Offset: 0x0042CD74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DBD1 RID: 121809 RVA: 0x0042EB81 File Offset: 0x0042CD81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DBD2 RID: 121810 RVA: 0x0042EB88 File Offset: 0x0042CD88
		public static ICheckGiantRegionCultivationTriggeredUpgradeLevel GetRootAsICheckGiantRegionCultivationTriggeredUpgradeLevel(ByteBuffer _bb)
		{
			return ICheckGiantRegionCultivationTriggeredUpgradeLevel.GetRootAsICheckGiantRegionCultivationTriggeredUpgradeLevel(_bb, default(ICheckGiantRegionCultivationTriggeredUpgradeLevel));
		}

		// Token: 0x0601DBD3 RID: 121811 RVA: 0x0042EBA4 File Offset: 0x0042CDA4
		public static ICheckGiantRegionCultivationTriggeredUpgradeLevel GetRootAsICheckGiantRegionCultivationTriggeredUpgradeLevel(ByteBuffer _bb, ICheckGiantRegionCultivationTriggeredUpgradeLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DBD4 RID: 121812 RVA: 0x0042EBC1 File Offset: 0x0042CDC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DBD5 RID: 121813 RVA: 0x0042EBD0 File Offset: 0x0042CDD0
		public ICheckGiantRegionCultivationTriggeredUpgradeLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700898A RID: 35210
		// (get) Token: 0x0601DBD6 RID: 121814 RVA: 0x0042EBE0 File Offset: 0x0042CDE0
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700898B RID: 35211
		// (get) Token: 0x0601DBD7 RID: 121815 RVA: 0x0042EC1C File Offset: 0x0042CE1C
		public EGiantEcoType EcoType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EGiantEcoType.Fire;
				}
				return (EGiantEcoType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DBD8 RID: 121816 RVA: 0x0042EC58 File Offset: 0x0042CE58
		public int Levels(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700898C RID: 35212
		// (get) Token: 0x0601DBD9 RID: 121817 RVA: 0x0042EC98 File Offset: 0x0042CE98
		public int LevelsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601DBDA RID: 121818 RVA: 0x0042ECC3 File Offset: 0x0042CEC3
		public Span<int> GetLevelsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0601DBDB RID: 121819 RVA: 0x0042ECD2 File Offset: 0x0042CED2
		public int[] GetLevelsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x0601DBDC RID: 121820 RVA: 0x0042ECE0 File Offset: 0x0042CEE0
		public static Offset<ICheckGiantRegionCultivationTriggeredUpgradeLevel> CreateICheckGiantRegionCultivationTriggeredUpgradeLevel(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, EGiantEcoType EcoType = EGiantEcoType.Fire, VectorOffset LevelsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ICheckGiantRegionCultivationTriggeredUpgradeLevel.AddLevels(builder, LevelsOffset);
			ICheckGiantRegionCultivationTriggeredUpgradeLevel.AddEcoType(builder, EcoType);
			ICheckGiantRegionCultivationTriggeredUpgradeLevel.AddType(builder, Type);
			return ICheckGiantRegionCultivationTriggeredUpgradeLevel.EndICheckGiantRegionCultivationTriggeredUpgradeLevel(builder);
		}

		// Token: 0x0601DBDD RID: 121821 RVA: 0x0042ED04 File Offset: 0x0042CF04
		public static void StartICheckGiantRegionCultivationTriggeredUpgradeLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DBDE RID: 121822 RVA: 0x0042ED0D File Offset: 0x0042CF0D
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DBDF RID: 121823 RVA: 0x0042ED18 File Offset: 0x0042CF18
		public static void AddEcoType(FlatBufferBuilder builder, EGiantEcoType ecoType)
		{
			builder.AddByte(1, (byte)ecoType, 0);
		}

		// Token: 0x0601DBE0 RID: 121824 RVA: 0x0042ED23 File Offset: 0x0042CF23
		public static void AddLevels(FlatBufferBuilder builder, VectorOffset levelsOffset)
		{
			builder.AddOffset(2, levelsOffset.Value, 0);
		}

		// Token: 0x0601DBE1 RID: 121825 RVA: 0x0042ED34 File Offset: 0x0042CF34
		public static VectorOffset CreateLevelsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DBE2 RID: 121826 RVA: 0x0042ED6B File Offset: 0x0042CF6B
		public static VectorOffset CreateLevelsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DBE3 RID: 121827 RVA: 0x0042ED85 File Offset: 0x0042CF85
		public static VectorOffset CreateLevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DBE4 RID: 121828 RVA: 0x0042EDA3 File Offset: 0x0042CFA3
		public static VectorOffset CreateLevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DBE5 RID: 121829 RVA: 0x0042EDBC File Offset: 0x0042CFBC
		public static void StartLevelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DBE6 RID: 121830 RVA: 0x0042EDC7 File Offset: 0x0042CFC7
		public static Offset<ICheckGiantRegionCultivationTriggeredUpgradeLevel> EndICheckGiantRegionCultivationTriggeredUpgradeLevel(FlatBufferBuilder builder)
		{
			return new Offset<ICheckGiantRegionCultivationTriggeredUpgradeLevel>(builder.EndTable());
		}

		// Token: 0x0601DBE7 RID: 121831 RVA: 0x0042EDD4 File Offset: 0x0042CFD4
		public ICheckGiantRegionCultivationTriggeredUpgradeLevelT UnPack()
		{
			ICheckGiantRegionCultivationTriggeredUpgradeLevelT checkGiantRegionCultivationTriggeredUpgradeLevelT = new ICheckGiantRegionCultivationTriggeredUpgradeLevelT();
			this.UnPackTo(checkGiantRegionCultivationTriggeredUpgradeLevelT);
			return checkGiantRegionCultivationTriggeredUpgradeLevelT;
		}

		// Token: 0x0601DBE8 RID: 121832 RVA: 0x0042EDF0 File Offset: 0x0042CFF0
		public void UnPackTo(ICheckGiantRegionCultivationTriggeredUpgradeLevelT _o)
		{
			_o.Type = this.Type;
			_o.EcoType = this.EcoType;
			_o.Levels = new List<int>();
			for (int i = 0; i < this.LevelsLength; i++)
			{
				_o.Levels.Add(this.Levels(i));
			}
		}

		// Token: 0x0601DBE9 RID: 121833 RVA: 0x0042EE44 File Offset: 0x0042D044
		public static Offset<ICheckGiantRegionCultivationTriggeredUpgradeLevel> Pack(FlatBufferBuilder builder, ICheckGiantRegionCultivationTriggeredUpgradeLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckGiantRegionCultivationTriggeredUpgradeLevel>);
			}
			VectorOffset levelsOffset = default(VectorOffset);
			if (_o.Levels != null)
			{
				int[] data = _o.Levels.ToArray();
				levelsOffset = ICheckGiantRegionCultivationTriggeredUpgradeLevel.CreateLevelsVector(builder, data);
			}
			return ICheckGiantRegionCultivationTriggeredUpgradeLevel.CreateICheckGiantRegionCultivationTriggeredUpgradeLevel(builder, _o.Type, _o.EcoType, levelsOffset);
		}

		// Token: 0x0400D28B RID: 53899
		private Table __p;
	}
}
