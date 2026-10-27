using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EC6 RID: 16070
	public struct IKillChildQuestCondition : IFlatbufferObject
	{
		// Token: 0x17006F89 RID: 28553
		// (get) Token: 0x06016B60 RID: 93024 RVA: 0x0034766C File Offset: 0x0034586C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016B61 RID: 93025 RVA: 0x00347679 File Offset: 0x00345879
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016B62 RID: 93026 RVA: 0x00347680 File Offset: 0x00345880
		public static IKillChildQuestCondition GetRootAsIKillChildQuestCondition(ByteBuffer _bb)
		{
			return IKillChildQuestCondition.GetRootAsIKillChildQuestCondition(_bb, default(IKillChildQuestCondition));
		}

		// Token: 0x06016B63 RID: 93027 RVA: 0x0034769C File Offset: 0x0034589C
		public static IKillChildQuestCondition GetRootAsIKillChildQuestCondition(ByteBuffer _bb, IKillChildQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016B64 RID: 93028 RVA: 0x003476B9 File Offset: 0x003458B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016B65 RID: 93029 RVA: 0x003476C8 File Offset: 0x003458C8
		public IKillChildQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F8A RID: 28554
		// (get) Token: 0x06016B66 RID: 93030 RVA: 0x003476D8 File Offset: 0x003458D8
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

		// Token: 0x17006F8B RID: 28555
		// (get) Token: 0x06016B67 RID: 93031 RVA: 0x00347714 File Offset: 0x00345914
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

		// Token: 0x06016B68 RID: 93032 RVA: 0x00347774 File Offset: 0x00345974
		public int ExistTargets(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006F8C RID: 28556
		// (get) Token: 0x06016B69 RID: 93033 RVA: 0x003477B4 File Offset: 0x003459B4
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

		// Token: 0x06016B6A RID: 93034 RVA: 0x003477DF File Offset: 0x003459DF
		public Span<int> GetExistTargetsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06016B6B RID: 93035 RVA: 0x003477EE File Offset: 0x003459EE
		public int[] GetExistTargetsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x06016B6C RID: 93036 RVA: 0x003477FC File Offset: 0x003459FC
		public int TargetsToAwake(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006F8D RID: 28557
		// (get) Token: 0x06016B6D RID: 93037 RVA: 0x0034783C File Offset: 0x00345A3C
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

		// Token: 0x06016B6E RID: 93038 RVA: 0x00347868 File Offset: 0x00345A68
		public Span<int> GetTargetsToAwakeBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06016B6F RID: 93039 RVA: 0x00347878 File Offset: 0x00345A78
		public int[] GetTargetsToAwakeArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x17006F8E RID: 28558
		// (get) Token: 0x06016B70 RID: 93040 RVA: 0x00347888 File Offset: 0x00345A88
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

		// Token: 0x06016B71 RID: 93041 RVA: 0x003478C8 File Offset: 0x00345AC8
		public TTable? PrefabVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06016B72 RID: 93042 RVA: 0x00347910 File Offset: 0x00345B10
		public IConstVarRef PrefabVarAsIConstVarRef()
		{
			return this.PrefabVar<IConstVarRef>().Value;
		}

		// Token: 0x06016B73 RID: 93043 RVA: 0x0034792C File Offset: 0x00345B2C
		public IGlobalVarRef PrefabVarAsIGlobalVarRef()
		{
			return this.PrefabVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06016B74 RID: 93044 RVA: 0x00347948 File Offset: 0x00345B48
		public IOtherVarRef PrefabVarAsIOtherVarRef()
		{
			return this.PrefabVar<IOtherVarRef>().Value;
		}

		// Token: 0x06016B75 RID: 93045 RVA: 0x00347964 File Offset: 0x00345B64
		public ISelfVarRef PrefabVarAsISelfVarRef()
		{
			return this.PrefabVar<ISelfVarRef>().Value;
		}

		// Token: 0x06016B76 RID: 93046 RVA: 0x00347980 File Offset: 0x00345B80
		public ISystemVarRef PrefabVarAsISystemVarRef()
		{
			return this.PrefabVar<ISystemVarRef>().Value;
		}

		// Token: 0x06016B77 RID: 93047 RVA: 0x0034799C File Offset: 0x00345B9C
		public IEntityDeadPosition? EntityDeadPositions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IEntityDeadPosition?(default(IEntityDeadPosition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006F8F RID: 28559
		// (get) Token: 0x06016B78 RID: 93048 RVA: 0x00347A00 File Offset: 0x00345C00
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

		// Token: 0x17006F90 RID: 28560
		// (get) Token: 0x06016B79 RID: 93049 RVA: 0x00347A2C File Offset: 0x00345C2C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016B7A RID: 93050 RVA: 0x00347A6C File Offset: 0x00345C6C
		public static Offset<IKillChildQuestCondition> CreateIKillChildQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), VectorOffset ExistTargetsOffset = default(VectorOffset), VectorOffset TargetsToAwakeOffset = default(VectorOffset), TVarRef PrefabVar_type = TVarRef.NONE, int PrefabVarOffset = 0, VectorOffset EntityDeadPositionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(8);
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

		// Token: 0x06016B7B RID: 93051 RVA: 0x00347AC3 File Offset: 0x00345CC3
		public static void StartIKillChildQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06016B7C RID: 93052 RVA: 0x00347ACC File Offset: 0x00345CCC
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016B7D RID: 93053 RVA: 0x00347AD7 File Offset: 0x00345CD7
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06016B7E RID: 93054 RVA: 0x00347AE7 File Offset: 0x00345CE7
		public static void AddExistTargets(FlatBufferBuilder builder, VectorOffset existTargetsOffset)
		{
			builder.AddOffset(2, existTargetsOffset.Value, 0);
		}

		// Token: 0x06016B7F RID: 93055 RVA: 0x00347AF8 File Offset: 0x00345CF8
		public static VectorOffset CreateExistTargetsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06016B80 RID: 93056 RVA: 0x00347B2F File Offset: 0x00345D2F
		public static VectorOffset CreateExistTargetsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016B81 RID: 93057 RVA: 0x00347B49 File Offset: 0x00345D49
		public static VectorOffset CreateExistTargetsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016B82 RID: 93058 RVA: 0x00347B67 File Offset: 0x00345D67
		public static VectorOffset CreateExistTargetsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016B83 RID: 93059 RVA: 0x00347B80 File Offset: 0x00345D80
		public static void StartExistTargetsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016B84 RID: 93060 RVA: 0x00347B8B File Offset: 0x00345D8B
		public static void AddTargetsToAwake(FlatBufferBuilder builder, VectorOffset targetsToAwakeOffset)
		{
			builder.AddOffset(3, targetsToAwakeOffset.Value, 0);
		}

		// Token: 0x06016B85 RID: 93061 RVA: 0x00347B9C File Offset: 0x00345D9C
		public static VectorOffset CreateTargetsToAwakeVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06016B86 RID: 93062 RVA: 0x00347BD3 File Offset: 0x00345DD3
		public static VectorOffset CreateTargetsToAwakeVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016B87 RID: 93063 RVA: 0x00347BED File Offset: 0x00345DED
		public static VectorOffset CreateTargetsToAwakeVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016B88 RID: 93064 RVA: 0x00347C0B File Offset: 0x00345E0B
		public static VectorOffset CreateTargetsToAwakeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016B89 RID: 93065 RVA: 0x00347C24 File Offset: 0x00345E24
		public static void StartTargetsToAwakeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016B8A RID: 93066 RVA: 0x00347C2F File Offset: 0x00345E2F
		public static void AddPrefabVarType(FlatBufferBuilder builder, TVarRef prefabVarType)
		{
			builder.AddByte(4, (byte)prefabVarType, 0);
		}

		// Token: 0x06016B8B RID: 93067 RVA: 0x00347C3A File Offset: 0x00345E3A
		public static void AddPrefabVar(FlatBufferBuilder builder, int prefabVarOffset)
		{
			builder.AddOffset(5, prefabVarOffset, 0);
		}

		// Token: 0x06016B8C RID: 93068 RVA: 0x00347C45 File Offset: 0x00345E45
		public static void AddEntityDeadPositions(FlatBufferBuilder builder, VectorOffset entityDeadPositionsOffset)
		{
			builder.AddOffset(6, entityDeadPositionsOffset.Value, 0);
		}

		// Token: 0x06016B8D RID: 93069 RVA: 0x00347C58 File Offset: 0x00345E58
		public static VectorOffset CreateEntityDeadPositionsVector(FlatBufferBuilder builder, Offset<IEntityDeadPosition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016B8E RID: 93070 RVA: 0x00347C98 File Offset: 0x00345E98
		public static VectorOffset CreateEntityDeadPositionsVectorBlock(FlatBufferBuilder builder, Offset<IEntityDeadPosition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityDeadPosition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016B8F RID: 93071 RVA: 0x00347CB2 File Offset: 0x00345EB2
		public static VectorOffset CreateEntityDeadPositionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityDeadPosition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityDeadPosition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016B90 RID: 93072 RVA: 0x00347CD0 File Offset: 0x00345ED0
		public static VectorOffset CreateEntityDeadPositionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityDeadPosition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016B91 RID: 93073 RVA: 0x00347CE9 File Offset: 0x00345EE9
		public static void StartEntityDeadPositionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016B92 RID: 93074 RVA: 0x00347CF4 File Offset: 0x00345EF4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06016B93 RID: 93075 RVA: 0x00347CFF File Offset: 0x00345EFF
		public static Offset<IKillChildQuestCondition> EndIKillChildQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IKillChildQuestCondition>(builder.EndTable());
		}

		// Token: 0x06016B94 RID: 93076 RVA: 0x00347D0C File Offset: 0x00345F0C
		public IKillChildQuestConditionT UnPack()
		{
			IKillChildQuestConditionT killChildQuestConditionT = new IKillChildQuestConditionT();
			this.UnPackTo(killChildQuestConditionT);
			return killChildQuestConditionT;
		}

		// Token: 0x06016B95 RID: 93077 RVA: 0x00347D28 File Offset: 0x00345F28
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
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016B96 RID: 93078 RVA: 0x00347F9C File Offset: 0x0034619C
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
			return IKillChildQuestCondition.CreateIKillChildQuestCondition(builder, _o.Type, preConditionsOffset, existTargetsOffset, targetsToAwakeOffset, prefabVar_type, prefabVarOffset, entityDeadPositionsOffset, _o.NullMask);
		}

		// Token: 0x0400B89D RID: 47261
		private Table __p;
	}
}
