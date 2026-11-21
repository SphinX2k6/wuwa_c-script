using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FE0 RID: 20448
	public struct ICheckPlayerUseSkillCondition : IFlatbufferObject
	{
		// Token: 0x1700924E RID: 37454
		// (get) Token: 0x0601FE69 RID: 130665 RVA: 0x0046E1E4 File Offset: 0x0046C3E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FE6A RID: 130666 RVA: 0x0046E1F1 File Offset: 0x0046C3F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FE6B RID: 130667 RVA: 0x0046E1F8 File Offset: 0x0046C3F8
		public static ICheckPlayerUseSkillCondition GetRootAsICheckPlayerUseSkillCondition(ByteBuffer _bb)
		{
			return ICheckPlayerUseSkillCondition.GetRootAsICheckPlayerUseSkillCondition(_bb, default(ICheckPlayerUseSkillCondition));
		}

		// Token: 0x0601FE6C RID: 130668 RVA: 0x0046E214 File Offset: 0x0046C414
		public static ICheckPlayerUseSkillCondition GetRootAsICheckPlayerUseSkillCondition(ByteBuffer _bb, ICheckPlayerUseSkillCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FE6D RID: 130669 RVA: 0x0046E231 File Offset: 0x0046C431
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FE6E RID: 130670 RVA: 0x0046E240 File Offset: 0x0046C440
		public ICheckPlayerUseSkillCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700924F RID: 37455
		// (get) Token: 0x0601FE6F RID: 130671 RVA: 0x0046E250 File Offset: 0x0046C450
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

		// Token: 0x17009250 RID: 37456
		// (get) Token: 0x0601FE70 RID: 130672 RVA: 0x0046E28C File Offset: 0x0046C48C
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

		// Token: 0x0601FE71 RID: 130673 RVA: 0x0046E2C8 File Offset: 0x0046C4C8
		public ISkillUseTypeRoleSkill? CheckSkills(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ISkillUseTypeRoleSkill?(default(ISkillUseTypeRoleSkill).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009251 RID: 37457
		// (get) Token: 0x0601FE72 RID: 130674 RVA: 0x0046E328 File Offset: 0x0046C528
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

		// Token: 0x0601FE73 RID: 130675 RVA: 0x0046E353 File Offset: 0x0046C553
		public static Offset<ICheckPlayerUseSkillCondition> CreateICheckPlayerUseSkillCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECommonMatchType CheckType = ECommonMatchType.MatchAll, VectorOffset CheckSkillsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ICheckPlayerUseSkillCondition.AddCheckSkills(builder, CheckSkillsOffset);
			ICheckPlayerUseSkillCondition.AddCheckType(builder, CheckType);
			ICheckPlayerUseSkillCondition.AddType(builder, Type);
			return ICheckPlayerUseSkillCondition.EndICheckPlayerUseSkillCondition(builder);
		}

		// Token: 0x0601FE74 RID: 130676 RVA: 0x0046E377 File Offset: 0x0046C577
		public static void StartICheckPlayerUseSkillCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FE75 RID: 130677 RVA: 0x0046E380 File Offset: 0x0046C580
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FE76 RID: 130678 RVA: 0x0046E38B File Offset: 0x0046C58B
		public static void AddCheckType(FlatBufferBuilder builder, ECommonMatchType checkType)
		{
			builder.AddByte(1, (byte)checkType, 0);
		}

		// Token: 0x0601FE77 RID: 130679 RVA: 0x0046E396 File Offset: 0x0046C596
		public static void AddCheckSkills(FlatBufferBuilder builder, VectorOffset checkSkillsOffset)
		{
			builder.AddOffset(2, checkSkillsOffset.Value, 0);
		}

		// Token: 0x0601FE78 RID: 130680 RVA: 0x0046E3A8 File Offset: 0x0046C5A8
		public static VectorOffset CreateCheckSkillsVector(FlatBufferBuilder builder, Offset<ISkillUseTypeRoleSkill>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601FE79 RID: 130681 RVA: 0x0046E3E8 File Offset: 0x0046C5E8
		public static VectorOffset CreateCheckSkillsVectorBlock(FlatBufferBuilder builder, Offset<ISkillUseTypeRoleSkill>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISkillUseTypeRoleSkill>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FE7A RID: 130682 RVA: 0x0046E402 File Offset: 0x0046C602
		public static VectorOffset CreateCheckSkillsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISkillUseTypeRoleSkill>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISkillUseTypeRoleSkill>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FE7B RID: 130683 RVA: 0x0046E420 File Offset: 0x0046C620
		public static VectorOffset CreateCheckSkillsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISkillUseTypeRoleSkill>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601FE7C RID: 130684 RVA: 0x0046E439 File Offset: 0x0046C639
		public static void StartCheckSkillsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601FE7D RID: 130685 RVA: 0x0046E444 File Offset: 0x0046C644
		public static Offset<ICheckPlayerUseSkillCondition> EndICheckPlayerUseSkillCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerUseSkillCondition>(builder.EndTable());
		}

		// Token: 0x0601FE7E RID: 130686 RVA: 0x0046E454 File Offset: 0x0046C654
		public ICheckPlayerUseSkillConditionT UnPack()
		{
			ICheckPlayerUseSkillConditionT checkPlayerUseSkillConditionT = new ICheckPlayerUseSkillConditionT();
			this.UnPackTo(checkPlayerUseSkillConditionT);
			return checkPlayerUseSkillConditionT;
		}

		// Token: 0x0601FE7F RID: 130687 RVA: 0x0046E470 File Offset: 0x0046C670
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

		// Token: 0x0601FE80 RID: 130688 RVA: 0x0046E4E8 File Offset: 0x0046C6E8
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

		// Token: 0x0400DE8F RID: 56975
		private Table __p;
	}
}
