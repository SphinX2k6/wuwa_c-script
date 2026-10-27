using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FF5 RID: 16373
	public struct IQuestMonsterPoint : IFlatbufferObject
	{
		// Token: 0x170072F5 RID: 29429
		// (get) Token: 0x0601797B RID: 96635 RVA: 0x00367337 File Offset: 0x00365537
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601797C RID: 96636 RVA: 0x00367344 File Offset: 0x00365544
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601797D RID: 96637 RVA: 0x0036734C File Offset: 0x0036554C
		public static IQuestMonsterPoint GetRootAsIQuestMonsterPoint(ByteBuffer _bb)
		{
			return IQuestMonsterPoint.GetRootAsIQuestMonsterPoint(_bb, default(IQuestMonsterPoint));
		}

		// Token: 0x0601797E RID: 96638 RVA: 0x00367368 File Offset: 0x00365568
		public static IQuestMonsterPoint GetRootAsIQuestMonsterPoint(ByteBuffer _bb, IQuestMonsterPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601797F RID: 96639 RVA: 0x00367385 File Offset: 0x00365585
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017980 RID: 96640 RVA: 0x00367394 File Offset: 0x00365594
		public IQuestMonsterPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170072F6 RID: 29430
		// (get) Token: 0x06017981 RID: 96641 RVA: 0x003673A4 File Offset: 0x003655A4
		public EStatisticsEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EStatisticsEventType.Collect;
				}
				return (EStatisticsEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170072F7 RID: 29431
		// (get) Token: 0x06017982 RID: 96642 RVA: 0x003673E0 File Offset: 0x003655E0
		public TVarRef VarType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017983 RID: 96643 RVA: 0x0036741C File Offset: 0x0036561C
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017984 RID: 96644 RVA: 0x00367460 File Offset: 0x00365660
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06017985 RID: 96645 RVA: 0x0036747C File Offset: 0x0036567C
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06017986 RID: 96646 RVA: 0x00367498 File Offset: 0x00365698
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06017987 RID: 96647 RVA: 0x003674B4 File Offset: 0x003656B4
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06017988 RID: 96648 RVA: 0x003674D0 File Offset: 0x003656D0
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x170072F8 RID: 29432
		// (get) Token: 0x06017989 RID: 96649 RVA: 0x003674EC File Offset: 0x003656EC
		public EElementCategory DamageElementType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EElementCategory.Element0;
				}
				return (EElementCategory)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170072F9 RID: 29433
		// (get) Token: 0x0601798A RID: 96650 RVA: 0x0036752C File Offset: 0x0036572C
		public ESkillCategory SkillCategory
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return ESkillCategory.Normal;
				}
				return (ESkillCategory)this.__p.bb.GetSbyte(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601798B RID: 96651 RVA: 0x0036756C File Offset: 0x0036576C
		public int KillByEntities(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170072FA RID: 29434
		// (get) Token: 0x0601798C RID: 96652 RVA: 0x003675AC File Offset: 0x003657AC
		public int KillByEntitiesLength
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

		// Token: 0x0601798D RID: 96653 RVA: 0x003675D8 File Offset: 0x003657D8
		public Span<int> GetKillByEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0601798E RID: 96654 RVA: 0x003675E8 File Offset: 0x003657E8
		public int[] GetKillByEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(14);
		}

		// Token: 0x170072FB RID: 29435
		// (get) Token: 0x0601798F RID: 96655 RVA: 0x003675F8 File Offset: 0x003657F8
		public bool KilledByAny
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06017990 RID: 96656 RVA: 0x00367638 File Offset: 0x00365838
		public IMonsterPointTypeConfig? TypeConfigs(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new IMonsterPointTypeConfig?(default(IMonsterPointTypeConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170072FC RID: 29436
		// (get) Token: 0x06017991 RID: 96657 RVA: 0x0036769C File Offset: 0x0036589C
		public int TypeConfigsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06017992 RID: 96658 RVA: 0x003676C8 File Offset: 0x003658C8
		public IMonsterPointEntityConfig? EntityConfigs(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new IMonsterPointEntityConfig?(default(IMonsterPointEntityConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170072FD RID: 29437
		// (get) Token: 0x06017993 RID: 96659 RVA: 0x0036772C File Offset: 0x0036592C
		public int EntityConfigsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170072FE RID: 29438
		// (get) Token: 0x06017994 RID: 96660 RVA: 0x00367758 File Offset: 0x00365958
		public bool OnlyCountThisTreeAwakeEntities
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170072FF RID: 29439
		// (get) Token: 0x06017995 RID: 96661 RVA: 0x00367798 File Offset: 0x00365998
		public IBindCrossSceneSyncKillMonster? BindCrossSceneSyncKillMonster
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new IBindCrossSceneSyncKillMonster?(default(IBindCrossSceneSyncKillMonster).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007300 RID: 29440
		// (get) Token: 0x06017996 RID: 96662 RVA: 0x003677F8 File Offset: 0x003659F8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017997 RID: 96663 RVA: 0x00367838 File Offset: 0x00365A38
		public static Offset<IQuestMonsterPoint> CreateIQuestMonsterPoint(FlatBufferBuilder builder, EStatisticsEventType Type = EStatisticsEventType.Collect, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0, EElementCategory DamageElementType = EElementCategory.Element0, ESkillCategory SkillCategory = ESkillCategory.Normal, VectorOffset KillByEntitiesOffset = default(VectorOffset), bool KilledByAny = false, VectorOffset TypeConfigsOffset = default(VectorOffset), VectorOffset EntityConfigsOffset = default(VectorOffset), bool OnlyCountThisTreeAwakeEntities = false, Offset<IBindCrossSceneSyncKillMonster> BindCrossSceneSyncKillMonsterOffset = default(Offset<IBindCrossSceneSyncKillMonster>), byte NullMask = 0)
		{
			builder.StartTable(12);
			IQuestMonsterPoint.AddBindCrossSceneSyncKillMonster(builder, BindCrossSceneSyncKillMonsterOffset);
			IQuestMonsterPoint.AddEntityConfigs(builder, EntityConfigsOffset);
			IQuestMonsterPoint.AddTypeConfigs(builder, TypeConfigsOffset);
			IQuestMonsterPoint.AddKillByEntities(builder, KillByEntitiesOffset);
			IQuestMonsterPoint.AddVar(builder, VarOffset);
			IQuestMonsterPoint.AddNullMask(builder, NullMask);
			IQuestMonsterPoint.AddOnlyCountThisTreeAwakeEntities(builder, OnlyCountThisTreeAwakeEntities);
			IQuestMonsterPoint.AddKilledByAny(builder, KilledByAny);
			IQuestMonsterPoint.AddSkillCategory(builder, SkillCategory);
			IQuestMonsterPoint.AddDamageElementType(builder, DamageElementType);
			IQuestMonsterPoint.AddVarType(builder, Var_type);
			IQuestMonsterPoint.AddType(builder, Type);
			return IQuestMonsterPoint.EndIQuestMonsterPoint(builder);
		}

		// Token: 0x06017998 RID: 96664 RVA: 0x003678B0 File Offset: 0x00365AB0
		public static void StartIQuestMonsterPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x06017999 RID: 96665 RVA: 0x003678BA File Offset: 0x00365ABA
		public static void AddType(FlatBufferBuilder builder, EStatisticsEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601799A RID: 96666 RVA: 0x003678C5 File Offset: 0x00365AC5
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x0601799B RID: 96667 RVA: 0x003678D0 File Offset: 0x00365AD0
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x0601799C RID: 96668 RVA: 0x003678DB File Offset: 0x00365ADB
		public static void AddDamageElementType(FlatBufferBuilder builder, EElementCategory damageElementType)
		{
			builder.AddByte(3, (byte)damageElementType, 0);
		}

		// Token: 0x0601799D RID: 96669 RVA: 0x003678E6 File Offset: 0x00365AE6
		public static void AddSkillCategory(FlatBufferBuilder builder, ESkillCategory skillCategory)
		{
			builder.AddSbyte(4, (sbyte)skillCategory, 0);
		}

		// Token: 0x0601799E RID: 96670 RVA: 0x003678F1 File Offset: 0x00365AF1
		public static void AddKillByEntities(FlatBufferBuilder builder, VectorOffset killByEntitiesOffset)
		{
			builder.AddOffset(5, killByEntitiesOffset.Value, 0);
		}

		// Token: 0x0601799F RID: 96671 RVA: 0x00367904 File Offset: 0x00365B04
		public static VectorOffset CreateKillByEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060179A0 RID: 96672 RVA: 0x0036793B File Offset: 0x00365B3B
		public static VectorOffset CreateKillByEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060179A1 RID: 96673 RVA: 0x00367955 File Offset: 0x00365B55
		public static VectorOffset CreateKillByEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060179A2 RID: 96674 RVA: 0x00367973 File Offset: 0x00365B73
		public static VectorOffset CreateKillByEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060179A3 RID: 96675 RVA: 0x0036798C File Offset: 0x00365B8C
		public static void StartKillByEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060179A4 RID: 96676 RVA: 0x00367997 File Offset: 0x00365B97
		public static void AddKilledByAny(FlatBufferBuilder builder, bool killedByAny)
		{
			builder.AddBool(6, killedByAny, false);
		}

		// Token: 0x060179A5 RID: 96677 RVA: 0x003679A2 File Offset: 0x00365BA2
		public static void AddTypeConfigs(FlatBufferBuilder builder, VectorOffset typeConfigsOffset)
		{
			builder.AddOffset(7, typeConfigsOffset.Value, 0);
		}

		// Token: 0x060179A6 RID: 96678 RVA: 0x003679B4 File Offset: 0x00365BB4
		public static VectorOffset CreateTypeConfigsVector(FlatBufferBuilder builder, Offset<IMonsterPointTypeConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060179A7 RID: 96679 RVA: 0x003679F4 File Offset: 0x00365BF4
		public static VectorOffset CreateTypeConfigsVectorBlock(FlatBufferBuilder builder, Offset<IMonsterPointTypeConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMonsterPointTypeConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060179A8 RID: 96680 RVA: 0x00367A0E File Offset: 0x00365C0E
		public static VectorOffset CreateTypeConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMonsterPointTypeConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMonsterPointTypeConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060179A9 RID: 96681 RVA: 0x00367A2C File Offset: 0x00365C2C
		public static VectorOffset CreateTypeConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMonsterPointTypeConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060179AA RID: 96682 RVA: 0x00367A45 File Offset: 0x00365C45
		public static void StartTypeConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060179AB RID: 96683 RVA: 0x00367A50 File Offset: 0x00365C50
		public static void AddEntityConfigs(FlatBufferBuilder builder, VectorOffset entityConfigsOffset)
		{
			builder.AddOffset(8, entityConfigsOffset.Value, 0);
		}

		// Token: 0x060179AC RID: 96684 RVA: 0x00367A60 File Offset: 0x00365C60
		public static VectorOffset CreateEntityConfigsVector(FlatBufferBuilder builder, Offset<IMonsterPointEntityConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060179AD RID: 96685 RVA: 0x00367AA0 File Offset: 0x00365CA0
		public static VectorOffset CreateEntityConfigsVectorBlock(FlatBufferBuilder builder, Offset<IMonsterPointEntityConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMonsterPointEntityConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060179AE RID: 96686 RVA: 0x00367ABA File Offset: 0x00365CBA
		public static VectorOffset CreateEntityConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMonsterPointEntityConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMonsterPointEntityConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060179AF RID: 96687 RVA: 0x00367AD8 File Offset: 0x00365CD8
		public static VectorOffset CreateEntityConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMonsterPointEntityConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060179B0 RID: 96688 RVA: 0x00367AF1 File Offset: 0x00365CF1
		public static void StartEntityConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060179B1 RID: 96689 RVA: 0x00367AFC File Offset: 0x00365CFC
		public static void AddOnlyCountThisTreeAwakeEntities(FlatBufferBuilder builder, bool onlyCountThisTreeAwakeEntities)
		{
			builder.AddBool(9, onlyCountThisTreeAwakeEntities, false);
		}

		// Token: 0x060179B2 RID: 96690 RVA: 0x00367B08 File Offset: 0x00365D08
		public static void AddBindCrossSceneSyncKillMonster(FlatBufferBuilder builder, Offset<IBindCrossSceneSyncKillMonster> bindCrossSceneSyncKillMonsterOffset)
		{
			builder.AddOffset(10, bindCrossSceneSyncKillMonsterOffset.Value, 0);
		}

		// Token: 0x060179B3 RID: 96691 RVA: 0x00367B19 File Offset: 0x00365D19
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(11, nullMask, 0);
		}

		// Token: 0x060179B4 RID: 96692 RVA: 0x00367B25 File Offset: 0x00365D25
		public static Offset<IQuestMonsterPoint> EndIQuestMonsterPoint(FlatBufferBuilder builder)
		{
			return new Offset<IQuestMonsterPoint>(builder.EndTable());
		}

		// Token: 0x060179B5 RID: 96693 RVA: 0x00367B34 File Offset: 0x00365D34
		public IQuestMonsterPointT UnPack()
		{
			IQuestMonsterPointT questMonsterPointT = new IQuestMonsterPointT();
			this.UnPackTo(questMonsterPointT);
			return questMonsterPointT;
		}

		// Token: 0x060179B6 RID: 96694 RVA: 0x00367B50 File Offset: 0x00365D50
		public void UnPackTo(IQuestMonsterPointT _o)
		{
			_o.Type = this.Type;
			_o.Var = new TVarRefUnion();
			_o.Var.Type = this.VarType;
			switch (this.VarType)
			{
			case TVarRef.IConstVarRef:
				_o.Var.Value = ((this.Var<IConstVarRef>() != null) ? this.Var<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.Var.Value = ((this.Var<IGlobalVarRef>() != null) ? this.Var<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.Var.Value = ((this.Var<IOtherVarRef>() != null) ? this.Var<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.Var.Value = ((this.Var<ISelfVarRef>() != null) ? this.Var<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.Var.Value = ((this.Var<ISystemVarRef>() != null) ? this.Var<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.DamageElementType = this.DamageElementType;
			_o.SkillCategory = this.SkillCategory;
			_o.KillByEntities = new List<int>();
			for (int i = 0; i < this.KillByEntitiesLength; i++)
			{
				_o.KillByEntities.Add(this.KillByEntities(i));
			}
			_o.KilledByAny = this.KilledByAny;
			_o.TypeConfigs = new List<IMonsterPointTypeConfigT>();
			for (int j = 0; j < this.TypeConfigsLength; j++)
			{
				_o.TypeConfigs.Add((this.TypeConfigs(j) != null) ? this.TypeConfigs(j).Value.UnPack() : null);
			}
			_o.EntityConfigs = new List<IMonsterPointEntityConfigT>();
			for (int k = 0; k < this.EntityConfigsLength; k++)
			{
				_o.EntityConfigs.Add((this.EntityConfigs(k) != null) ? this.EntityConfigs(k).Value.UnPack() : null);
			}
			_o.OnlyCountThisTreeAwakeEntities = this.OnlyCountThisTreeAwakeEntities;
			_o.BindCrossSceneSyncKillMonster = ((this.BindCrossSceneSyncKillMonster != null) ? this.BindCrossSceneSyncKillMonster.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060179B7 RID: 96695 RVA: 0x00367E20 File Offset: 0x00366020
		public static Offset<IQuestMonsterPoint> Pack(FlatBufferBuilder builder, IQuestMonsterPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestMonsterPoint>);
			}
			TVarRef var_type = (_o.Var == null) ? TVarRef.NONE : _o.Var.Type;
			int varOffset = (_o.Var == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var);
			VectorOffset killByEntitiesOffset = default(VectorOffset);
			if (_o.KillByEntities != null)
			{
				int[] data = _o.KillByEntities.ToArray();
				killByEntitiesOffset = IQuestMonsterPoint.CreateKillByEntitiesVector(builder, data);
			}
			VectorOffset typeConfigsOffset = default(VectorOffset);
			if (_o.TypeConfigs != null)
			{
				Offset<IMonsterPointTypeConfig>[] array = new Offset<IMonsterPointTypeConfig>[_o.TypeConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IMonsterPointTypeConfig.Pack(builder, _o.TypeConfigs[i]);
				}
				typeConfigsOffset = IQuestMonsterPoint.CreateTypeConfigsVector(builder, array);
			}
			VectorOffset entityConfigsOffset = default(VectorOffset);
			if (_o.EntityConfigs != null)
			{
				Offset<IMonsterPointEntityConfig>[] array2 = new Offset<IMonsterPointEntityConfig>[_o.EntityConfigs.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IMonsterPointEntityConfig.Pack(builder, _o.EntityConfigs[j]);
				}
				entityConfigsOffset = IQuestMonsterPoint.CreateEntityConfigsVector(builder, array2);
			}
			Offset<IBindCrossSceneSyncKillMonster> bindCrossSceneSyncKillMonsterOffset = (_o.BindCrossSceneSyncKillMonster == null) ? default(Offset<IBindCrossSceneSyncKillMonster>) : IBindCrossSceneSyncKillMonster.Pack(builder, _o.BindCrossSceneSyncKillMonster);
			return IQuestMonsterPoint.CreateIQuestMonsterPoint(builder, _o.Type, var_type, varOffset, _o.DamageElementType, _o.SkillCategory, killByEntitiesOffset, _o.KilledByAny, typeConfigsOffset, entityConfigsOffset, _o.OnlyCountThisTreeAwakeEntities, bindCrossSceneSyncKillMonsterOffset, _o.NullMask);
		}

		// Token: 0x0400BAFD RID: 47869
		private Table __p;
	}
}
