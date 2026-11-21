using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004304 RID: 17156
	public struct IKillChildQuestCondition : IFlatbufferObject
	{
		// Token: 0x17007576 RID: 30070
		// (get) Token: 0x060181AD RID: 98733 RVA: 0x003705F4 File Offset: 0x0036E7F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060181AE RID: 98734 RVA: 0x00370601 File Offset: 0x0036E801
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060181AF RID: 98735 RVA: 0x00370608 File Offset: 0x0036E808
		public static IKillChildQuestCondition GetRootAsIKillChildQuestCondition(ByteBuffer _bb)
		{
			return IKillChildQuestCondition.GetRootAsIKillChildQuestCondition(_bb, default(IKillChildQuestCondition));
		}

		// Token: 0x060181B0 RID: 98736 RVA: 0x00370624 File Offset: 0x0036E824
		public static IKillChildQuestCondition GetRootAsIKillChildQuestCondition(ByteBuffer _bb, IKillChildQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060181B1 RID: 98737 RVA: 0x00370641 File Offset: 0x0036E841
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060181B2 RID: 98738 RVA: 0x00370650 File Offset: 0x0036E850
		public IKillChildQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007577 RID: 30071
		// (get) Token: 0x060181B3 RID: 98739 RVA: 0x00370660 File Offset: 0x0036E860
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

		// Token: 0x17007578 RID: 30072
		// (get) Token: 0x060181B4 RID: 98740 RVA: 0x0037069C File Offset: 0x0036E89C
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

		// Token: 0x060181B5 RID: 98741 RVA: 0x003706FC File Offset: 0x0036E8FC
		public int ExistTargets(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007579 RID: 30073
		// (get) Token: 0x060181B6 RID: 98742 RVA: 0x0037073C File Offset: 0x0036E93C
		public int ExistTargetsLength
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

		// Token: 0x060181B7 RID: 98743 RVA: 0x00370767 File Offset: 0x0036E967
		public Span<int> GetExistTargetsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060181B8 RID: 98744 RVA: 0x00370776 File Offset: 0x0036E976
		public int[] GetExistTargetsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x060181B9 RID: 98745 RVA: 0x00370784 File Offset: 0x0036E984
		public int TargetsToAwake(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700757A RID: 30074
		// (get) Token: 0x060181BA RID: 98746 RVA: 0x003707C4 File Offset: 0x0036E9C4
		public int TargetsToAwakeLength
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

		// Token: 0x060181BB RID: 98747 RVA: 0x003707F0 File Offset: 0x0036E9F0
		public Span<int> GetTargetsToAwakeBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060181BC RID: 98748 RVA: 0x00370800 File Offset: 0x0036EA00
		public int[] GetTargetsToAwakeArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700757B RID: 30075
		// (get) Token: 0x060181BD RID: 98749 RVA: 0x00370810 File Offset: 0x0036EA10
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

		// Token: 0x060181BE RID: 98750 RVA: 0x00370850 File Offset: 0x0036EA50
		public TTable? PrefabVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060181BF RID: 98751 RVA: 0x00370898 File Offset: 0x0036EA98
		public IConstVarRef PrefabVarAsIConstVarRef()
		{
			return this.PrefabVar<IConstVarRef>().Value;
		}

		// Token: 0x060181C0 RID: 98752 RVA: 0x003708B4 File Offset: 0x0036EAB4
		public IGlobalVarRef PrefabVarAsIGlobalVarRef()
		{
			return this.PrefabVar<IGlobalVarRef>().Value;
		}

		// Token: 0x060181C1 RID: 98753 RVA: 0x003708D0 File Offset: 0x0036EAD0
		public IOtherVarRef PrefabVarAsIOtherVarRef()
		{
			return this.PrefabVar<IOtherVarRef>().Value;
		}

		// Token: 0x060181C2 RID: 98754 RVA: 0x003708EC File Offset: 0x0036EAEC
		public ISelfVarRef PrefabVarAsISelfVarRef()
		{
			return this.PrefabVar<ISelfVarRef>().Value;
		}

		// Token: 0x060181C3 RID: 98755 RVA: 0x00370908 File Offset: 0x0036EB08
		public ISystemVarRef PrefabVarAsISystemVarRef()
		{
			return this.PrefabVar<ISystemVarRef>().Value;
		}

		// Token: 0x060181C4 RID: 98756 RVA: 0x00370924 File Offset: 0x0036EB24
		public IEntityDeadPosition? EntityDeadPositions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IEntityDeadPosition?(default(IEntityDeadPosition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700757C RID: 30076
		// (get) Token: 0x060181C5 RID: 98757 RVA: 0x00370988 File Offset: 0x0036EB88
		public int EntityDeadPositionsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060181C6 RID: 98758 RVA: 0x003709B4 File Offset: 0x0036EBB4
		public ISpecificMonsterDeadPosition? SpecificMonsterDeadPositions(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new ISpecificMonsterDeadPosition?(default(ISpecificMonsterDeadPosition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700757D RID: 30077
		// (get) Token: 0x060181C7 RID: 98759 RVA: 0x00370A18 File Offset: 0x0036EC18
		public int SpecificMonsterDeadPositionsLength
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

		// Token: 0x1700757E RID: 30078
		// (get) Token: 0x060181C8 RID: 98760 RVA: 0x00370A44 File Offset: 0x0036EC44
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

		// Token: 0x060181C9 RID: 98761 RVA: 0x00370A84 File Offset: 0x0036EC84
		public static Offset<IKillChildQuestCondition> CreateIKillChildQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), VectorOffset ExistTargetsOffset = default(VectorOffset), VectorOffset TargetsToAwakeOffset = default(VectorOffset), TVarRef PrefabVar_type = TVarRef.NONE, int PrefabVarOffset = 0, VectorOffset EntityDeadPositionsOffset = default(VectorOffset), VectorOffset SpecificMonsterDeadPositionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(9);
			IKillChildQuestCondition.AddSpecificMonsterDeadPositions(builder, SpecificMonsterDeadPositionsOffset);
			IKillChildQuestCondition.AddEntityDeadPositions(builder, EntityDeadPositionsOffset);
			IKillChildQuestCondition.AddPrefabVar(builder, PrefabVarOffset);
			IKillChildQuestCondition.AddTargetsToAwake(builder, TargetsToAwakeOffset);
			IKillChildQuestCondition.AddExistTargets(builder, ExistTargetsOffset);
			IKillChildQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IKillChildQuestCondition.AddNullMask(builder, NullMask);
			IKillChildQuestCondition.AddPrefabVarType(builder, PrefabVar_type);
			IKillChildQuestCondition.AddType(builder, Type);
			return IKillChildQuestCondition.EndIKillChildQuestCondition(builder);
		}

		// Token: 0x060181CA RID: 98762 RVA: 0x00370AE4 File Offset: 0x0036ECE4
		public static void StartIKillChildQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x060181CB RID: 98763 RVA: 0x00370AEE File Offset: 0x0036ECEE
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060181CC RID: 98764 RVA: 0x00370AF9 File Offset: 0x0036ECF9
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x060181CD RID: 98765 RVA: 0x00370B09 File Offset: 0x0036ED09
		public static void AddExistTargets(FlatBufferBuilder builder, VectorOffset existTargetsOffset)
		{
			builder.AddOffset(2, existTargetsOffset.Value, 0);
		}

		// Token: 0x060181CE RID: 98766 RVA: 0x00370B1C File Offset: 0x0036ED1C
		public static VectorOffset CreateExistTargetsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060181CF RID: 98767 RVA: 0x00370B53 File Offset: 0x0036ED53
		public static VectorOffset CreateExistTargetsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060181D0 RID: 98768 RVA: 0x00370B6D File Offset: 0x0036ED6D
		public static VectorOffset CreateExistTargetsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060181D1 RID: 98769 RVA: 0x00370B8B File Offset: 0x0036ED8B
		public static VectorOffset CreateExistTargetsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060181D2 RID: 98770 RVA: 0x00370BA4 File Offset: 0x0036EDA4
		public static void StartExistTargetsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060181D3 RID: 98771 RVA: 0x00370BAF File Offset: 0x0036EDAF
		public static void AddTargetsToAwake(FlatBufferBuilder builder, VectorOffset targetsToAwakeOffset)
		{
			builder.AddOffset(3, targetsToAwakeOffset.Value, 0);
		}

		// Token: 0x060181D4 RID: 98772 RVA: 0x00370BC0 File Offset: 0x0036EDC0
		public static VectorOffset CreateTargetsToAwakeVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060181D5 RID: 98773 RVA: 0x00370BF7 File Offset: 0x0036EDF7
		public static VectorOffset CreateTargetsToAwakeVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060181D6 RID: 98774 RVA: 0x00370C11 File Offset: 0x0036EE11
		public static VectorOffset CreateTargetsToAwakeVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060181D7 RID: 98775 RVA: 0x00370C2F File Offset: 0x0036EE2F
		public static VectorOffset CreateTargetsToAwakeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060181D8 RID: 98776 RVA: 0x00370C48 File Offset: 0x0036EE48
		public static void StartTargetsToAwakeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060181D9 RID: 98777 RVA: 0x00370C53 File Offset: 0x0036EE53
		public static void AddPrefabVarType(FlatBufferBuilder builder, TVarRef prefabVarType)
		{
			builder.AddByte(4, (byte)prefabVarType, 0);
		}

		// Token: 0x060181DA RID: 98778 RVA: 0x00370C5E File Offset: 0x0036EE5E
		public static void AddPrefabVar(FlatBufferBuilder builder, int prefabVarOffset)
		{
			builder.AddOffset(5, prefabVarOffset, 0);
		}

		// Token: 0x060181DB RID: 98779 RVA: 0x00370C69 File Offset: 0x0036EE69
		public static void AddEntityDeadPositions(FlatBufferBuilder builder, VectorOffset entityDeadPositionsOffset)
		{
			builder.AddOffset(6, entityDeadPositionsOffset.Value, 0);
		}

		// Token: 0x060181DC RID: 98780 RVA: 0x00370C7C File Offset: 0x0036EE7C
		public static VectorOffset CreateEntityDeadPositionsVector(FlatBufferBuilder builder, Offset<IEntityDeadPosition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060181DD RID: 98781 RVA: 0x00370CBC File Offset: 0x0036EEBC
		public static VectorOffset CreateEntityDeadPositionsVectorBlock(FlatBufferBuilder builder, Offset<IEntityDeadPosition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityDeadPosition>>(data);
			return builder.EndVector();
		}

		// Token: 0x060181DE RID: 98782 RVA: 0x00370CD6 File Offset: 0x0036EED6
		public static VectorOffset CreateEntityDeadPositionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityDeadPosition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityDeadPosition>>(data);
			return builder.EndVector();
		}

		// Token: 0x060181DF RID: 98783 RVA: 0x00370CF4 File Offset: 0x0036EEF4
		public static VectorOffset CreateEntityDeadPositionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityDeadPosition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060181E0 RID: 98784 RVA: 0x00370D0D File Offset: 0x0036EF0D
		public static void StartEntityDeadPositionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060181E1 RID: 98785 RVA: 0x00370D18 File Offset: 0x0036EF18
		public static void AddSpecificMonsterDeadPositions(FlatBufferBuilder builder, VectorOffset specificMonsterDeadPositionsOffset)
		{
			builder.AddOffset(7, specificMonsterDeadPositionsOffset.Value, 0);
		}

		// Token: 0x060181E2 RID: 98786 RVA: 0x00370D28 File Offset: 0x0036EF28
		public static VectorOffset CreateSpecificMonsterDeadPositionsVector(FlatBufferBuilder builder, Offset<ISpecificMonsterDeadPosition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060181E3 RID: 98787 RVA: 0x00370D68 File Offset: 0x0036EF68
		public static VectorOffset CreateSpecificMonsterDeadPositionsVectorBlock(FlatBufferBuilder builder, Offset<ISpecificMonsterDeadPosition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISpecificMonsterDeadPosition>>(data);
			return builder.EndVector();
		}

		// Token: 0x060181E4 RID: 98788 RVA: 0x00370D82 File Offset: 0x0036EF82
		public static VectorOffset CreateSpecificMonsterDeadPositionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISpecificMonsterDeadPosition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISpecificMonsterDeadPosition>>(data);
			return builder.EndVector();
		}

		// Token: 0x060181E5 RID: 98789 RVA: 0x00370DA0 File Offset: 0x0036EFA0
		public static VectorOffset CreateSpecificMonsterDeadPositionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISpecificMonsterDeadPosition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060181E6 RID: 98790 RVA: 0x00370DB9 File Offset: 0x0036EFB9
		public static void StartSpecificMonsterDeadPositionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060181E7 RID: 98791 RVA: 0x00370DC4 File Offset: 0x0036EFC4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x060181E8 RID: 98792 RVA: 0x00370DCF File Offset: 0x0036EFCF
		public static Offset<IKillChildQuestCondition> EndIKillChildQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IKillChildQuestCondition>(builder.EndTable());
		}

		// Token: 0x060181E9 RID: 98793 RVA: 0x00370DDC File Offset: 0x0036EFDC
		public IKillChildQuestConditionT UnPack()
		{
			IKillChildQuestConditionT killChildQuestConditionT = new IKillChildQuestConditionT();
			this.UnPackTo(killChildQuestConditionT);
			return killChildQuestConditionT;
		}

		// Token: 0x060181EA RID: 98794 RVA: 0x00370DF8 File Offset: 0x0036EFF8
		public void UnPackTo(IKillChildQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.ExistTargets = new List<int>();
			for (int i = 0; i < this.ExistTargetsLength; i++)
			{
				_o.ExistTargets.Add(this.ExistTargets(i));
			}
			_o.TargetsToAwake = new List<int>();
			for (int j = 0; j < this.TargetsToAwakeLength; j++)
			{
				_o.TargetsToAwake.Add(this.TargetsToAwake(j));
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
			_o.EntityDeadPositions = new List<IEntityDeadPositionT>();
			for (int k = 0; k < this.EntityDeadPositionsLength; k++)
			{
				_o.EntityDeadPositions.Add((this.EntityDeadPositions(k) != null) ? this.EntityDeadPositions(k).Value.UnPack() : null);
			}
			_o.SpecificMonsterDeadPositions = new List<ISpecificMonsterDeadPositionT>();
			for (int l = 0; l < this.SpecificMonsterDeadPositionsLength; l++)
			{
				_o.SpecificMonsterDeadPositions.Add((this.SpecificMonsterDeadPositions(l) != null) ? this.SpecificMonsterDeadPositions(l).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060181EB RID: 98795 RVA: 0x003710C8 File Offset: 0x0036F2C8
		public static Offset<IKillChildQuestCondition> Pack(FlatBufferBuilder builder, IKillChildQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKillChildQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			VectorOffset existTargetsOffset = default(VectorOffset);
			if (_o.ExistTargets != null)
			{
				int[] data = _o.ExistTargets.ToArray();
				existTargetsOffset = IKillChildQuestCondition.CreateExistTargetsVector(builder, data);
			}
			VectorOffset targetsToAwakeOffset = default(VectorOffset);
			if (_o.TargetsToAwake != null)
			{
				int[] data2 = _o.TargetsToAwake.ToArray();
				targetsToAwakeOffset = IKillChildQuestCondition.CreateTargetsToAwakeVector(builder, data2);
			}
			TVarRef prefabVar_type = (_o.PrefabVar == null) ? TVarRef.NONE : _o.PrefabVar.Type;
			int prefabVarOffset = (_o.PrefabVar == null) ? 0 : TVarRefUnion.Pack(builder, _o.PrefabVar);
			VectorOffset entityDeadPositionsOffset = default(VectorOffset);
			if (_o.EntityDeadPositions != null)
			{
				Offset<IEntityDeadPosition>[] array = new Offset<IEntityDeadPosition>[_o.EntityDeadPositions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityDeadPosition.Pack(builder, _o.EntityDeadPositions[i]);
				}
				entityDeadPositionsOffset = IKillChildQuestCondition.CreateEntityDeadPositionsVector(builder, array);
			}
			VectorOffset specificMonsterDeadPositionsOffset = default(VectorOffset);
			if (_o.SpecificMonsterDeadPositions != null)
			{
				Offset<ISpecificMonsterDeadPosition>[] array2 = new Offset<ISpecificMonsterDeadPosition>[_o.SpecificMonsterDeadPositions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = ISpecificMonsterDeadPosition.Pack(builder, _o.SpecificMonsterDeadPositions[j]);
				}
				specificMonsterDeadPositionsOffset = IKillChildQuestCondition.CreateSpecificMonsterDeadPositionsVector(builder, array2);
			}
			return IKillChildQuestCondition.CreateIKillChildQuestCondition(builder, _o.Type, preConditionsOffset, existTargetsOffset, targetsToAwakeOffset, prefabVar_type, prefabVarOffset, entityDeadPositionsOffset, specificMonsterDeadPositionsOffset, _o.NullMask);
		}

		// Token: 0x0400C279 RID: 49785
		private Table __p;
	}
}
