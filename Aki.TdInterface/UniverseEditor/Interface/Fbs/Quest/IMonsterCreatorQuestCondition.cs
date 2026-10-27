using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F32 RID: 16178
	public struct IMonsterCreatorQuestCondition : IFlatbufferObject
	{
		// Token: 0x17007077 RID: 28791
		// (get) Token: 0x06016F9C RID: 94108 RVA: 0x00350765 File Offset: 0x0034E965
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016F9D RID: 94109 RVA: 0x00350772 File Offset: 0x0034E972
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016F9E RID: 94110 RVA: 0x0035077C File Offset: 0x0034E97C
		public static IMonsterCreatorQuestCondition GetRootAsIMonsterCreatorQuestCondition(ByteBuffer _bb)
		{
			return IMonsterCreatorQuestCondition.GetRootAsIMonsterCreatorQuestCondition(_bb, default(IMonsterCreatorQuestCondition));
		}

		// Token: 0x06016F9F RID: 94111 RVA: 0x00350798 File Offset: 0x0034E998
		public static IMonsterCreatorQuestCondition GetRootAsIMonsterCreatorQuestCondition(ByteBuffer _bb, IMonsterCreatorQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016FA0 RID: 94112 RVA: 0x003507B5 File Offset: 0x0034E9B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016FA1 RID: 94113 RVA: 0x003507C4 File Offset: 0x0034E9C4
		public IMonsterCreatorQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007078 RID: 28792
		// (get) Token: 0x06016FA2 RID: 94114 RVA: 0x003507D4 File Offset: 0x0034E9D4
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007079 RID: 28793
		// (get) Token: 0x06016FA3 RID: 94115 RVA: 0x00350810 File Offset: 0x0034EA10
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700707A RID: 28794
		// (get) Token: 0x06016FA4 RID: 94116 RVA: 0x00350870 File Offset: 0x0034EA70
		public string TidMonsterGroupName
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

		// Token: 0x06016FA5 RID: 94117 RVA: 0x003508A7 File Offset: 0x0034EAA7
		public Span<byte> GetTidMonsterGroupNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06016FA6 RID: 94118 RVA: 0x003508B6 File Offset: 0x0034EAB6
		public byte[] GetTidMonsterGroupNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06016FA7 RID: 94119 RVA: 0x003508C4 File Offset: 0x0034EAC4
		public int MonsterCreatorEntityIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700707B RID: 28795
		// (get) Token: 0x06016FA8 RID: 94120 RVA: 0x00350904 File Offset: 0x0034EB04
		public int MonsterCreatorEntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06016FA9 RID: 94121 RVA: 0x00350930 File Offset: 0x0034EB30
		public Span<int> GetMonsterCreatorEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06016FAA RID: 94122 RVA: 0x00350940 File Offset: 0x0034EB40
		public int[] GetMonsterCreatorEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700707C RID: 28796
		// (get) Token: 0x06016FAB RID: 94123 RVA: 0x00350950 File Offset: 0x0034EB50
		public TVarRef PrefabVarType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016FAC RID: 94124 RVA: 0x00350990 File Offset: 0x0034EB90
		public TTable? PrefabVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06016FAD RID: 94125 RVA: 0x003509D8 File Offset: 0x0034EBD8
		public IConstVarRef PrefabVarAsIConstVarRef()
		{
			return this.PrefabVar<IConstVarRef>().Value;
		}

		// Token: 0x06016FAE RID: 94126 RVA: 0x003509F4 File Offset: 0x0034EBF4
		public IGlobalVarRef PrefabVarAsIGlobalVarRef()
		{
			return this.PrefabVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06016FAF RID: 94127 RVA: 0x00350A10 File Offset: 0x0034EC10
		public IOtherVarRef PrefabVarAsIOtherVarRef()
		{
			return this.PrefabVar<IOtherVarRef>().Value;
		}

		// Token: 0x06016FB0 RID: 94128 RVA: 0x00350A2C File Offset: 0x0034EC2C
		public ISelfVarRef PrefabVarAsISelfVarRef()
		{
			return this.PrefabVar<ISelfVarRef>().Value;
		}

		// Token: 0x06016FB1 RID: 94129 RVA: 0x00350A48 File Offset: 0x0034EC48
		public ISystemVarRef PrefabVarAsISystemVarRef()
		{
			return this.PrefabVar<ISystemVarRef>().Value;
		}

		// Token: 0x1700707D RID: 28797
		// (get) Token: 0x06016FB2 RID: 94130 RVA: 0x00350A64 File Offset: 0x0034EC64
		public bool ShowMonsterMergedHpBar
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700707E RID: 28798
		// (get) Token: 0x06016FB3 RID: 94131 RVA: 0x00350AA4 File Offset: 0x0034ECA4
		public IMonsterMergedHpBarSettings? MonsterMergedHpBarSettings
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new IMonsterMergedHpBarSettings?(default(IMonsterMergedHpBarSettings).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700707F RID: 28799
		// (get) Token: 0x06016FB4 RID: 94132 RVA: 0x00350B04 File Offset: 0x0034ED04
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016FB5 RID: 94133 RVA: 0x00350B44 File Offset: 0x0034ED44
		public static Offset<IMonsterCreatorQuestCondition> CreateIMonsterCreatorQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), StringOffset TidMonsterGroupNameOffset = default(StringOffset), VectorOffset MonsterCreatorEntityIdsOffset = default(VectorOffset), TVarRef PrefabVar_type = TVarRef.NONE, int PrefabVarOffset = 0, bool ShowMonsterMergedHpBar = false, Offset<IMonsterMergedHpBarSettings> MonsterMergedHpBarSettingsOffset = default(Offset<IMonsterMergedHpBarSettings>), byte NullMask = 0)
		{
			builder.StartTable(9);
			IMonsterCreatorQuestCondition.AddMonsterMergedHpBarSettings(builder, MonsterMergedHpBarSettingsOffset);
			IMonsterCreatorQuestCondition.AddPrefabVar(builder, PrefabVarOffset);
			IMonsterCreatorQuestCondition.AddMonsterCreatorEntityIds(builder, MonsterCreatorEntityIdsOffset);
			IMonsterCreatorQuestCondition.AddTidMonsterGroupName(builder, TidMonsterGroupNameOffset);
			IMonsterCreatorQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IMonsterCreatorQuestCondition.AddNullMask(builder, NullMask);
			IMonsterCreatorQuestCondition.AddShowMonsterMergedHpBar(builder, ShowMonsterMergedHpBar);
			IMonsterCreatorQuestCondition.AddPrefabVarType(builder, PrefabVar_type);
			IMonsterCreatorQuestCondition.AddType(builder, Type);
			return IMonsterCreatorQuestCondition.EndIMonsterCreatorQuestCondition(builder);
		}

		// Token: 0x06016FB6 RID: 94134 RVA: 0x00350BA4 File Offset: 0x0034EDA4
		public static void StartIMonsterCreatorQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06016FB7 RID: 94135 RVA: 0x00350BAE File Offset: 0x0034EDAE
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016FB8 RID: 94136 RVA: 0x00350BB9 File Offset: 0x0034EDB9
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06016FB9 RID: 94137 RVA: 0x00350BC9 File Offset: 0x0034EDC9
		public static void AddTidMonsterGroupName(FlatBufferBuilder builder, StringOffset tidMonsterGroupNameOffset)
		{
			builder.AddOffset(2, tidMonsterGroupNameOffset.Value, 0);
		}

		// Token: 0x06016FBA RID: 94138 RVA: 0x00350BD9 File Offset: 0x0034EDD9
		public static void AddMonsterCreatorEntityIds(FlatBufferBuilder builder, VectorOffset monsterCreatorEntityIdsOffset)
		{
			builder.AddOffset(3, monsterCreatorEntityIdsOffset.Value, 0);
		}

		// Token: 0x06016FBB RID: 94139 RVA: 0x00350BEC File Offset: 0x0034EDEC
		public static VectorOffset CreateMonsterCreatorEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06016FBC RID: 94140 RVA: 0x00350C23 File Offset: 0x0034EE23
		public static VectorOffset CreateMonsterCreatorEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016FBD RID: 94141 RVA: 0x00350C3D File Offset: 0x0034EE3D
		public static VectorOffset CreateMonsterCreatorEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016FBE RID: 94142 RVA: 0x00350C5B File Offset: 0x0034EE5B
		public static VectorOffset CreateMonsterCreatorEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016FBF RID: 94143 RVA: 0x00350C74 File Offset: 0x0034EE74
		public static void StartMonsterCreatorEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016FC0 RID: 94144 RVA: 0x00350C7F File Offset: 0x0034EE7F
		public static void AddPrefabVarType(FlatBufferBuilder builder, TVarRef prefabVarType)
		{
			builder.AddByte(4, (byte)prefabVarType, 0);
		}

		// Token: 0x06016FC1 RID: 94145 RVA: 0x00350C8A File Offset: 0x0034EE8A
		public static void AddPrefabVar(FlatBufferBuilder builder, int prefabVarOffset)
		{
			builder.AddOffset(5, prefabVarOffset, 0);
		}

		// Token: 0x06016FC2 RID: 94146 RVA: 0x00350C95 File Offset: 0x0034EE95
		public static void AddShowMonsterMergedHpBar(FlatBufferBuilder builder, bool showMonsterMergedHpBar)
		{
			builder.AddBool(6, showMonsterMergedHpBar, false);
		}

		// Token: 0x06016FC3 RID: 94147 RVA: 0x00350CA0 File Offset: 0x0034EEA0
		public static void AddMonsterMergedHpBarSettings(FlatBufferBuilder builder, Offset<IMonsterMergedHpBarSettings> monsterMergedHpBarSettingsOffset)
		{
			builder.AddOffset(7, monsterMergedHpBarSettingsOffset.Value, 0);
		}

		// Token: 0x06016FC4 RID: 94148 RVA: 0x00350CB0 File Offset: 0x0034EEB0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06016FC5 RID: 94149 RVA: 0x00350CBB File Offset: 0x0034EEBB
		public static Offset<IMonsterCreatorQuestCondition> EndIMonsterCreatorQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterCreatorQuestCondition>(builder.EndTable());
		}

		// Token: 0x06016FC6 RID: 94150 RVA: 0x00350CC8 File Offset: 0x0034EEC8
		public IMonsterCreatorQuestConditionT UnPack()
		{
			IMonsterCreatorQuestConditionT monsterCreatorQuestConditionT = new IMonsterCreatorQuestConditionT();
			this.UnPackTo(monsterCreatorQuestConditionT);
			return monsterCreatorQuestConditionT;
		}

		// Token: 0x06016FC7 RID: 94151 RVA: 0x00350CE4 File Offset: 0x0034EEE4
		public void UnPackTo(IMonsterCreatorQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.TidMonsterGroupName = this.TidMonsterGroupName;
			_o.MonsterCreatorEntityIds = new List<int>();
			for (int i = 0; i < this.MonsterCreatorEntityIdsLength; i++)
			{
				_o.MonsterCreatorEntityIds.Add(this.MonsterCreatorEntityIds(i));
			}
			_o.PrefabVar = new TVarRefUnion();
			_o.PrefabVar.Type = this.PrefabVarType;
			switch (this.PrefabVarType)
			{
			case TVarRef.IConstVarRef:
				_o.PrefabVar.Value = ((this.PrefabVar<IConstVarRef>() != null) ? this.PrefabVar<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.PrefabVar.Value = ((this.PrefabVar<IGlobalVarRef>() != null) ? this.PrefabVar<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.PrefabVar.Value = ((this.PrefabVar<IOtherVarRef>() != null) ? this.PrefabVar<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.PrefabVar.Value = ((this.PrefabVar<ISelfVarRef>() != null) ? this.PrefabVar<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.PrefabVar.Value = ((this.PrefabVar<ISystemVarRef>() != null) ? this.PrefabVar<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.ShowMonsterMergedHpBar = this.ShowMonsterMergedHpBar;
			_o.MonsterMergedHpBarSettings = ((this.MonsterMergedHpBarSettings != null) ? this.MonsterMergedHpBarSettings.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016FC8 RID: 94152 RVA: 0x00350F18 File Offset: 0x0034F118
		public static Offset<IMonsterCreatorQuestCondition> Pack(FlatBufferBuilder builder, IMonsterCreatorQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterCreatorQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			StringOffset tidMonsterGroupNameOffset = (_o.TidMonsterGroupName == null) ? default(StringOffset) : builder.CreateString(_o.TidMonsterGroupName);
			VectorOffset monsterCreatorEntityIdsOffset = default(VectorOffset);
			if (_o.MonsterCreatorEntityIds != null)
			{
				int[] data = _o.MonsterCreatorEntityIds.ToArray();
				monsterCreatorEntityIdsOffset = IMonsterCreatorQuestCondition.CreateMonsterCreatorEntityIdsVector(builder, data);
			}
			TVarRef prefabVar_type = (_o.PrefabVar == null) ? TVarRef.NONE : _o.PrefabVar.Type;
			int prefabVarOffset = (_o.PrefabVar == null) ? 0 : TVarRefUnion.Pack(builder, _o.PrefabVar);
			Offset<IMonsterMergedHpBarSettings> monsterMergedHpBarSettingsOffset = (_o.MonsterMergedHpBarSettings == null) ? default(Offset<IMonsterMergedHpBarSettings>) : IMonsterMergedHpBarSettings.Pack(builder, _o.MonsterMergedHpBarSettings);
			return IMonsterCreatorQuestCondition.CreateIMonsterCreatorQuestCondition(builder, _o.Type, preConditionsOffset, tidMonsterGroupNameOffset, monsterCreatorEntityIdsOffset, prefabVar_type, prefabVarOffset, _o.ShowMonsterMergedHpBar, monsterMergedHpBarSettingsOffset, _o.NullMask);
		}

		// Token: 0x0400B93C RID: 47420
		private Table __p;
	}
}
