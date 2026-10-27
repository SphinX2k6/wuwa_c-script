using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B05 RID: 19205
	public struct ICheckPlayerUseSkillCondition : IFlatbufferObject
	{
		// Token: 0x17008B4D RID: 35661
		// (get) Token: 0x0601E328 RID: 123688 RVA: 0x0043C138 File Offset: 0x0043A338
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E329 RID: 123689 RVA: 0x0043C145 File Offset: 0x0043A345
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E32A RID: 123690 RVA: 0x0043C14C File Offset: 0x0043A34C
		public static ICheckPlayerUseSkillCondition GetRootAsICheckPlayerUseSkillCondition(ByteBuffer _bb)
		{
			return ICheckPlayerUseSkillCondition.GetRootAsICheckPlayerUseSkillCondition(_bb, default(ICheckPlayerUseSkillCondition));
		}

		// Token: 0x0601E32B RID: 123691 RVA: 0x0043C168 File Offset: 0x0043A368
		public static ICheckPlayerUseSkillCondition GetRootAsICheckPlayerUseSkillCondition(ByteBuffer _bb, ICheckPlayerUseSkillCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E32C RID: 123692 RVA: 0x0043C185 File Offset: 0x0043A385
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E32D RID: 123693 RVA: 0x0043C194 File Offset: 0x0043A394
		public ICheckPlayerUseSkillCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B4E RID: 35662
		// (get) Token: 0x0601E32E RID: 123694 RVA: 0x0043C1A4 File Offset: 0x0043A3A4
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

		// Token: 0x17008B4F RID: 35663
		// (get) Token: 0x0601E32F RID: 123695 RVA: 0x0043C1E0 File Offset: 0x0043A3E0
		public ECommonMatchType CheckType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECommonMatchType.MatchAll;
				}
				return (ECommonMatchType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E330 RID: 123696 RVA: 0x0043C21C File Offset: 0x0043A41C
		public ISkillUseTypeRoleSkill? CheckSkills(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ISkillUseTypeRoleSkill?(default(ISkillUseTypeRoleSkill).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008B50 RID: 35664
		// (get) Token: 0x0601E331 RID: 123697 RVA: 0x0043C27C File Offset: 0x0043A47C
		public int CheckSkillsLength
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

		// Token: 0x0601E332 RID: 123698 RVA: 0x0043C2A7 File Offset: 0x0043A4A7
		public static Offset<ICheckPlayerUseSkillCondition> CreateICheckPlayerUseSkillCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECommonMatchType CheckType = ECommonMatchType.MatchAll, VectorOffset CheckSkillsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ICheckPlayerUseSkillCondition.AddCheckSkills(builder, CheckSkillsOffset);
			ICheckPlayerUseSkillCondition.AddCheckType(builder, CheckType);
			ICheckPlayerUseSkillCondition.AddType(builder, Type);
			return ICheckPlayerUseSkillCondition.EndICheckPlayerUseSkillCondition(builder);
		}

		// Token: 0x0601E333 RID: 123699 RVA: 0x0043C2CB File Offset: 0x0043A4CB
		public static void StartICheckPlayerUseSkillCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E334 RID: 123700 RVA: 0x0043C2D4 File Offset: 0x0043A4D4
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E335 RID: 123701 RVA: 0x0043C2DF File Offset: 0x0043A4DF
		public static void AddCheckType(FlatBufferBuilder builder, ECommonMatchType checkType)
		{
			builder.AddByte(1, (byte)checkType, 0);
		}

		// Token: 0x0601E336 RID: 123702 RVA: 0x0043C2EA File Offset: 0x0043A4EA
		public static void AddCheckSkills(FlatBufferBuilder builder, VectorOffset checkSkillsOffset)
		{
			builder.AddOffset(2, checkSkillsOffset.Value, 0);
		}

		// Token: 0x0601E337 RID: 123703 RVA: 0x0043C2FC File Offset: 0x0043A4FC
		public static VectorOffset CreateCheckSkillsVector(FlatBufferBuilder builder, Offset<ISkillUseTypeRoleSkill>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E338 RID: 123704 RVA: 0x0043C33C File Offset: 0x0043A53C
		public static VectorOffset CreateCheckSkillsVectorBlock(FlatBufferBuilder builder, Offset<ISkillUseTypeRoleSkill>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISkillUseTypeRoleSkill>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E339 RID: 123705 RVA: 0x0043C356 File Offset: 0x0043A556
		public static VectorOffset CreateCheckSkillsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISkillUseTypeRoleSkill>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISkillUseTypeRoleSkill>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E33A RID: 123706 RVA: 0x0043C374 File Offset: 0x0043A574
		public static VectorOffset CreateCheckSkillsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISkillUseTypeRoleSkill>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E33B RID: 123707 RVA: 0x0043C38D File Offset: 0x0043A58D
		public static void StartCheckSkillsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E33C RID: 123708 RVA: 0x0043C398 File Offset: 0x0043A598
		public static Offset<ICheckPlayerUseSkillCondition> EndICheckPlayerUseSkillCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerUseSkillCondition>(builder.EndTable());
		}

		// Token: 0x0601E33D RID: 123709 RVA: 0x0043C3A8 File Offset: 0x0043A5A8
		public ICheckPlayerUseSkillConditionT UnPack()
		{
			ICheckPlayerUseSkillConditionT checkPlayerUseSkillConditionT = new ICheckPlayerUseSkillConditionT();
			this.UnPackTo(checkPlayerUseSkillConditionT);
			return checkPlayerUseSkillConditionT;
		}

		// Token: 0x0601E33E RID: 123710 RVA: 0x0043C3C4 File Offset: 0x0043A5C4
		public void UnPackTo(ICheckPlayerUseSkillConditionT _o)
		{
			_o.Type = this.Type;
			_o.CheckType = this.CheckType;
			_o.CheckSkills = new List<ISkillUseTypeRoleSkillT>();
			for (int i = 0; i < this.CheckSkillsLength; i++)
			{
				_o.CheckSkills.Add((this.CheckSkills(i) != null) ? this.CheckSkills(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601E33F RID: 123711 RVA: 0x0043C43C File Offset: 0x0043A63C
		public static Offset<ICheckPlayerUseSkillCondition> Pack(FlatBufferBuilder builder, ICheckPlayerUseSkillConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerUseSkillCondition>);
			}
			VectorOffset checkSkillsOffset = default(VectorOffset);
			if (_o.CheckSkills != null)
			{
				Offset<ISkillUseTypeRoleSkill>[] array = new Offset<ISkillUseTypeRoleSkill>[_o.CheckSkills.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISkillUseTypeRoleSkill.Pack(builder, _o.CheckSkills[i]);
				}
				checkSkillsOffset = ICheckPlayerUseSkillCondition.CreateCheckSkillsVector(builder, array);
			}
			return ICheckPlayerUseSkillCondition.CreateICheckPlayerUseSkillCondition(builder, _o.Type, _o.CheckType, checkSkillsOffset);
		}

		// Token: 0x0400D39E RID: 54174
		private Table __p;
	}
}
