using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004370 RID: 17264
	public struct IMonsterCreatorQuestCondition : IFlatbufferObject
	{
		// Token: 0x17007666 RID: 30310
		// (get) Token: 0x060185F4 RID: 99828 RVA: 0x0037998D File Offset: 0x00377B8D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060185F5 RID: 99829 RVA: 0x0037999A File Offset: 0x00377B9A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060185F6 RID: 99830 RVA: 0x003799A4 File Offset: 0x00377BA4
		public static IMonsterCreatorQuestCondition GetRootAsIMonsterCreatorQuestCondition(ByteBuffer _bb)
		{
			return IMonsterCreatorQuestCondition.GetRootAsIMonsterCreatorQuestCondition(_bb, default(IMonsterCreatorQuestCondition));
		}

		// Token: 0x060185F7 RID: 99831 RVA: 0x003799C0 File Offset: 0x00377BC0
		public static IMonsterCreatorQuestCondition GetRootAsIMonsterCreatorQuestCondition(ByteBuffer _bb, IMonsterCreatorQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060185F8 RID: 99832 RVA: 0x003799DD File Offset: 0x00377BDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060185F9 RID: 99833 RVA: 0x003799EC File Offset: 0x00377BEC
		public IMonsterCreatorQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007667 RID: 30311
		// (get) Token: 0x060185FA RID: 99834 RVA: 0x003799FC File Offset: 0x00377BFC
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

		// Token: 0x17007668 RID: 30312
		// (get) Token: 0x060185FB RID: 99835 RVA: 0x00379A38 File Offset: 0x00377C38
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

		// Token: 0x17007669 RID: 30313
		// (get) Token: 0x060185FC RID: 99836 RVA: 0x00379A98 File Offset: 0x00377C98
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

		// Token: 0x060185FD RID: 99837 RVA: 0x00379ACF File Offset: 0x00377CCF
		public Span<byte> GetTidMonsterGroupNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060185FE RID: 99838 RVA: 0x00379ADE File Offset: 0x00377CDE
		public byte[] GetTidMonsterGroupNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x060185FF RID: 99839 RVA: 0x00379AEC File Offset: 0x00377CEC
		public int MonsterCreatorEntityIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700766A RID: 30314
		// (get) Token: 0x06018600 RID: 99840 RVA: 0x00379B2C File Offset: 0x00377D2C
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

		// Token: 0x06018601 RID: 99841 RVA: 0x00379B58 File Offset: 0x00377D58
		public Span<int> GetMonsterCreatorEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06018602 RID: 99842 RVA: 0x00379B68 File Offset: 0x00377D68
		public int[] GetMonsterCreatorEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700766B RID: 30315
		// (get) Token: 0x06018603 RID: 99843 RVA: 0x00379B78 File Offset: 0x00377D78
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

		// Token: 0x06018604 RID: 99844 RVA: 0x00379BB8 File Offset: 0x00377DB8
		public TTable? PrefabVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06018605 RID: 99845 RVA: 0x00379C00 File Offset: 0x00377E00
		public IConstVarRef PrefabVarAsIConstVarRef()
		{
			return this.PrefabVar<IConstVarRef>().Value;
		}

		// Token: 0x06018606 RID: 99846 RVA: 0x00379C1C File Offset: 0x00377E1C
		public IGlobalVarRef PrefabVarAsIGlobalVarRef()
		{
			return this.PrefabVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06018607 RID: 99847 RVA: 0x00379C38 File Offset: 0x00377E38
		public IOtherVarRef PrefabVarAsIOtherVarRef()
		{
			return this.PrefabVar<IOtherVarRef>().Value;
		}

		// Token: 0x06018608 RID: 99848 RVA: 0x00379C54 File Offset: 0x00377E54
		public ISelfVarRef PrefabVarAsISelfVarRef()
		{
			return this.PrefabVar<ISelfVarRef>().Value;
		}

		// Token: 0x06018609 RID: 99849 RVA: 0x00379C70 File Offset: 0x00377E70
		public ISystemVarRef PrefabVarAsISystemVarRef()
		{
			return this.PrefabVar<ISystemVarRef>().Value;
		}

		// Token: 0x1700766C RID: 30316
		// (get) Token: 0x0601860A RID: 99850 RVA: 0x00379C8C File Offset: 0x00377E8C
		public bool ShowMonsterMergedHpBar
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700766D RID: 30317
		// (get) Token: 0x0601860B RID: 99851 RVA: 0x00379CCC File Offset: 0x00377ECC
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

		// Token: 0x0601860C RID: 99852 RVA: 0x00379D2C File Offset: 0x00377F2C
		public ISpecificMonsterDeadPosition? SpecificMonsterDeadPositions(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new ISpecificMonsterDeadPosition?(default(ISpecificMonsterDeadPosition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700766E RID: 30318
		// (get) Token: 0x0601860D RID: 99853 RVA: 0x00379D90 File Offset: 0x00377F90
		public int SpecificMonsterDeadPositionsLength
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

		// Token: 0x1700766F RID: 30319
		// (get) Token: 0x0601860E RID: 99854 RVA: 0x00379DBC File Offset: 0x00377FBC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601860F RID: 99855 RVA: 0x00379DFC File Offset: 0x00377FFC
		public static Offset<IMonsterCreatorQuestCondition> CreateIMonsterCreatorQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), StringOffset TidMonsterGroupNameOffset = default(StringOffset), VectorOffset MonsterCreatorEntityIdsOffset = default(VectorOffset), TVarRef PrefabVar_type = TVarRef.NONE, int PrefabVarOffset = 0, bool ShowMonsterMergedHpBar = false, Offset<IMonsterMergedHpBarSettings> MonsterMergedHpBarSettingsOffset = default(Offset<IMonsterMergedHpBarSettings>), VectorOffset SpecificMonsterDeadPositionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(10);
			IMonsterCreatorQuestCondition.AddSpecificMonsterDeadPositions(builder, SpecificMonsterDeadPositionsOffset);
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

		// Token: 0x06018610 RID: 99856 RVA: 0x00379E64 File Offset: 0x00378064
		public static void StartIMonsterCreatorQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06018611 RID: 99857 RVA: 0x00379E6E File Offset: 0x0037806E
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018612 RID: 99858 RVA: 0x00379E79 File Offset: 0x00378079
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06018613 RID: 99859 RVA: 0x00379E89 File Offset: 0x00378089
		public static void AddTidMonsterGroupName(FlatBufferBuilder builder, StringOffset tidMonsterGroupNameOffset)
		{
			builder.AddOffset(2, tidMonsterGroupNameOffset.Value, 0);
		}

		// Token: 0x06018614 RID: 99860 RVA: 0x00379E99 File Offset: 0x00378099
		public static void AddMonsterCreatorEntityIds(FlatBufferBuilder builder, VectorOffset monsterCreatorEntityIdsOffset)
		{
			builder.AddOffset(3, monsterCreatorEntityIdsOffset.Value, 0);
		}

		// Token: 0x06018615 RID: 99861 RVA: 0x00379EAC File Offset: 0x003780AC
		public static VectorOffset CreateMonsterCreatorEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018616 RID: 99862 RVA: 0x00379EE3 File Offset: 0x003780E3
		public static VectorOffset CreateMonsterCreatorEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018617 RID: 99863 RVA: 0x00379EFD File Offset: 0x003780FD
		public static VectorOffset CreateMonsterCreatorEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018618 RID: 99864 RVA: 0x00379F1B File Offset: 0x0037811B
		public static VectorOffset CreateMonsterCreatorEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018619 RID: 99865 RVA: 0x00379F34 File Offset: 0x00378134
		public static void StartMonsterCreatorEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601861A RID: 99866 RVA: 0x00379F3F File Offset: 0x0037813F
		public static void AddPrefabVarType(FlatBufferBuilder builder, TVarRef prefabVarType)
		{
			builder.AddByte(4, (byte)prefabVarType, 0);
		}

		// Token: 0x0601861B RID: 99867 RVA: 0x00379F4A File Offset: 0x0037814A
		public static void AddPrefabVar(FlatBufferBuilder builder, int prefabVarOffset)
		{
			builder.AddOffset(5, prefabVarOffset, 0);
		}

		// Token: 0x0601861C RID: 99868 RVA: 0x00379F55 File Offset: 0x00378155
		public static void AddShowMonsterMergedHpBar(FlatBufferBuilder builder, bool showMonsterMergedHpBar)
		{
			builder.AddBool(6, showMonsterMergedHpBar, false);
		}

		// Token: 0x0601861D RID: 99869 RVA: 0x00379F60 File Offset: 0x00378160
		public static void AddMonsterMergedHpBarSettings(FlatBufferBuilder builder, Offset<IMonsterMergedHpBarSettings> monsterMergedHpBarSettingsOffset)
		{
			builder.AddOffset(7, monsterMergedHpBarSettingsOffset.Value, 0);
		}

		// Token: 0x0601861E RID: 99870 RVA: 0x00379F70 File Offset: 0x00378170
		public static void AddSpecificMonsterDeadPositions(FlatBufferBuilder builder, VectorOffset specificMonsterDeadPositionsOffset)
		{
			builder.AddOffset(8, specificMonsterDeadPositionsOffset.Value, 0);
		}

		// Token: 0x0601861F RID: 99871 RVA: 0x00379F80 File Offset: 0x00378180
		public static VectorOffset CreateSpecificMonsterDeadPositionsVector(FlatBufferBuilder builder, Offset<ISpecificMonsterDeadPosition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018620 RID: 99872 RVA: 0x00379FC0 File Offset: 0x003781C0
		public static VectorOffset CreateSpecificMonsterDeadPositionsVectorBlock(FlatBufferBuilder builder, Offset<ISpecificMonsterDeadPosition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISpecificMonsterDeadPosition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018621 RID: 99873 RVA: 0x00379FDA File Offset: 0x003781DA
		public static VectorOffset CreateSpecificMonsterDeadPositionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISpecificMonsterDeadPosition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISpecificMonsterDeadPosition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018622 RID: 99874 RVA: 0x00379FF8 File Offset: 0x003781F8
		public static VectorOffset CreateSpecificMonsterDeadPositionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISpecificMonsterDeadPosition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018623 RID: 99875 RVA: 0x0037A011 File Offset: 0x00378211
		public static void StartSpecificMonsterDeadPositionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018624 RID: 99876 RVA: 0x0037A01C File Offset: 0x0037821C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x06018625 RID: 99877 RVA: 0x0037A028 File Offset: 0x00378228
		public static Offset<IMonsterCreatorQuestCondition> EndIMonsterCreatorQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterCreatorQuestCondition>(builder.EndTable());
		}

		// Token: 0x06018626 RID: 99878 RVA: 0x0037A038 File Offset: 0x00378238
		public IMonsterCreatorQuestConditionT UnPack()
		{
			IMonsterCreatorQuestConditionT monsterCreatorQuestConditionT = new IMonsterCreatorQuestConditionT();
			this.UnPackTo(monsterCreatorQuestConditionT);
			return monsterCreatorQuestConditionT;
		}

		// Token: 0x06018627 RID: 99879 RVA: 0x0037A054 File Offset: 0x00378254
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
			_o.SpecificMonsterDeadPositions = new List<ISpecificMonsterDeadPositionT>();
			for (int j = 0; j < this.SpecificMonsterDeadPositionsLength; j++)
			{
				_o.SpecificMonsterDeadPositions.Add((this.SpecificMonsterDeadPositions(j) != null) ? this.SpecificMonsterDeadPositions(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018628 RID: 99880 RVA: 0x0037A2E0 File Offset: 0x003784E0
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
			VectorOffset specificMonsterDeadPositionsOffset = default(VectorOffset);
			if (_o.SpecificMonsterDeadPositions != null)
			{
				Offset<ISpecificMonsterDeadPosition>[] array = new Offset<ISpecificMonsterDeadPosition>[_o.SpecificMonsterDeadPositions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISpecificMonsterDeadPosition.Pack(builder, _o.SpecificMonsterDeadPositions[i]);
				}
				specificMonsterDeadPositionsOffset = IMonsterCreatorQuestCondition.CreateSpecificMonsterDeadPositionsVector(builder, array);
			}
			return IMonsterCreatorQuestCondition.CreateIMonsterCreatorQuestCondition(builder, _o.Type, preConditionsOffset, tidMonsterGroupNameOffset, monsterCreatorEntityIdsOffset, prefabVar_type, prefabVarOffset, _o.ShowMonsterMergedHpBar, monsterMergedHpBarSettingsOffset, specificMonsterDeadPositionsOffset, _o.NullMask);
		}

		// Token: 0x0400C319 RID: 49945
		private Table __p;
	}
}
