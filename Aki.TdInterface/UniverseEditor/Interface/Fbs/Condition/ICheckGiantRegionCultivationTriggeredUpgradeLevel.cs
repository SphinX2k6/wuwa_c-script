using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EF9 RID: 20217
	public struct ICheckGiantRegionCultivationTriggeredUpgradeLevel : IFlatbufferObject
	{
		// Token: 0x1700905E RID: 36958
		// (get) Token: 0x0601F659 RID: 128601 RVA: 0x0045FA6C File Offset: 0x0045DC6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F65A RID: 128602 RVA: 0x0045FA79 File Offset: 0x0045DC79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F65B RID: 128603 RVA: 0x0045FA80 File Offset: 0x0045DC80
		public static ICheckGiantRegionCultivationTriggeredUpgradeLevel GetRootAsICheckGiantRegionCultivationTriggeredUpgradeLevel(ByteBuffer _bb)
		{
			return ICheckGiantRegionCultivationTriggeredUpgradeLevel.GetRootAsICheckGiantRegionCultivationTriggeredUpgradeLevel(_bb, default(ICheckGiantRegionCultivationTriggeredUpgradeLevel));
		}

		// Token: 0x0601F65C RID: 128604 RVA: 0x0045FA9C File Offset: 0x0045DC9C
		public static ICheckGiantRegionCultivationTriggeredUpgradeLevel GetRootAsICheckGiantRegionCultivationTriggeredUpgradeLevel(ByteBuffer _bb, ICheckGiantRegionCultivationTriggeredUpgradeLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F65D RID: 128605 RVA: 0x0045FAB9 File Offset: 0x0045DCB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F65E RID: 128606 RVA: 0x0045FAC8 File Offset: 0x0045DCC8
		public ICheckGiantRegionCultivationTriggeredUpgradeLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700905F RID: 36959
		// (get) Token: 0x0601F65F RID: 128607 RVA: 0x0045FAD8 File Offset: 0x0045DCD8
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

		// Token: 0x17009060 RID: 36960
		// (get) Token: 0x0601F660 RID: 128608 RVA: 0x0045FB14 File Offset: 0x0045DD14
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

		// Token: 0x0601F661 RID: 128609 RVA: 0x0045FB50 File Offset: 0x0045DD50
		public int Levels(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009061 RID: 36961
		// (get) Token: 0x0601F662 RID: 128610 RVA: 0x0045FB90 File Offset: 0x0045DD90
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

		// Token: 0x0601F663 RID: 128611 RVA: 0x0045FBBB File Offset: 0x0045DDBB
		public Span<int> GetLevelsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0601F664 RID: 128612 RVA: 0x0045FBCA File Offset: 0x0045DDCA
		public int[] GetLevelsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x0601F665 RID: 128613 RVA: 0x0045FBD8 File Offset: 0x0045DDD8
		public static Offset<ICheckGiantRegionCultivationTriggeredUpgradeLevel> CreateICheckGiantRegionCultivationTriggeredUpgradeLevel(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, EGiantEcoType EcoType = EGiantEcoType.Fire, VectorOffset LevelsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ICheckGiantRegionCultivationTriggeredUpgradeLevel.AddLevels(builder, LevelsOffset);
			ICheckGiantRegionCultivationTriggeredUpgradeLevel.AddEcoType(builder, EcoType);
			ICheckGiantRegionCultivationTriggeredUpgradeLevel.AddType(builder, Type);
			return ICheckGiantRegionCultivationTriggeredUpgradeLevel.EndICheckGiantRegionCultivationTriggeredUpgradeLevel(builder);
		}

		// Token: 0x0601F666 RID: 128614 RVA: 0x0045FBFC File Offset: 0x0045DDFC
		public static void StartICheckGiantRegionCultivationTriggeredUpgradeLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F667 RID: 128615 RVA: 0x0045FC05 File Offset: 0x0045DE05
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F668 RID: 128616 RVA: 0x0045FC10 File Offset: 0x0045DE10
		public static void AddEcoType(FlatBufferBuilder builder, EGiantEcoType ecoType)
		{
			builder.AddByte(1, (byte)ecoType, 0);
		}

		// Token: 0x0601F669 RID: 128617 RVA: 0x0045FC1B File Offset: 0x0045DE1B
		public static void AddLevels(FlatBufferBuilder builder, VectorOffset levelsOffset)
		{
			builder.AddOffset(2, levelsOffset.Value, 0);
		}

		// Token: 0x0601F66A RID: 128618 RVA: 0x0045FC2C File Offset: 0x0045DE2C
		public static VectorOffset CreateLevelsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601F66B RID: 128619 RVA: 0x0045FC63 File Offset: 0x0045DE63
		public static VectorOffset CreateLevelsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F66C RID: 128620 RVA: 0x0045FC7D File Offset: 0x0045DE7D
		public static VectorOffset CreateLevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F66D RID: 128621 RVA: 0x0045FC9B File Offset: 0x0045DE9B
		public static VectorOffset CreateLevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601F66E RID: 128622 RVA: 0x0045FCB4 File Offset: 0x0045DEB4
		public static void StartLevelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601F66F RID: 128623 RVA: 0x0045FCBF File Offset: 0x0045DEBF
		public static Offset<ICheckGiantRegionCultivationTriggeredUpgradeLevel> EndICheckGiantRegionCultivationTriggeredUpgradeLevel(FlatBufferBuilder builder)
		{
			return new Offset<ICheckGiantRegionCultivationTriggeredUpgradeLevel>(builder.EndTable());
		}

		// Token: 0x0601F670 RID: 128624 RVA: 0x0045FCCC File Offset: 0x0045DECC
		public ICheckGiantRegionCultivationTriggeredUpgradeLevelT UnPack()
		{
			ICheckGiantRegionCultivationTriggeredUpgradeLevelT checkGiantRegionCultivationTriggeredUpgradeLevelT = new ICheckGiantRegionCultivationTriggeredUpgradeLevelT();
			this.UnPackTo(checkGiantRegionCultivationTriggeredUpgradeLevelT);
			return checkGiantRegionCultivationTriggeredUpgradeLevelT;
		}

		// Token: 0x0601F671 RID: 128625 RVA: 0x0045FCE8 File Offset: 0x0045DEE8
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

		// Token: 0x0601F672 RID: 128626 RVA: 0x0045FD3C File Offset: 0x0045DF3C
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

		// Token: 0x0400DD62 RID: 56674
		private Table __p;
	}
}
