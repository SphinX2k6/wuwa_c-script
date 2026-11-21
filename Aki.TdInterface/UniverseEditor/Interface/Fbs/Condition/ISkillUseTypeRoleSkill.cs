using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051C9 RID: 20937
	public struct ISkillUseTypeRoleSkill : IFlatbufferObject
	{
		// Token: 0x170095EA RID: 38378
		// (get) Token: 0x06020F5F RID: 135007 RVA: 0x0048EBA1 File Offset: 0x0048CDA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020F60 RID: 135008 RVA: 0x0048EBAE File Offset: 0x0048CDAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020F61 RID: 135009 RVA: 0x0048EBB8 File Offset: 0x0048CDB8
		public static ISkillUseTypeRoleSkill GetRootAsISkillUseTypeRoleSkill(ByteBuffer _bb)
		{
			return ISkillUseTypeRoleSkill.GetRootAsISkillUseTypeRoleSkill(_bb, default(ISkillUseTypeRoleSkill));
		}

		// Token: 0x06020F62 RID: 135010 RVA: 0x0048EBD4 File Offset: 0x0048CDD4
		public static ISkillUseTypeRoleSkill GetRootAsISkillUseTypeRoleSkill(ByteBuffer _bb, ISkillUseTypeRoleSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020F63 RID: 135011 RVA: 0x0048EBF1 File Offset: 0x0048CDF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020F64 RID: 135012 RVA: 0x0048EC00 File Offset: 0x0048CE00
		public ISkillUseTypeRoleSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170095EB RID: 38379
		// (get) Token: 0x06020F65 RID: 135013 RVA: 0x0048EC10 File Offset: 0x0048CE10
		public ESkillUseType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESkillUseType.RoleSkill;
				}
				return (ESkillUseType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170095EC RID: 38380
		// (get) Token: 0x06020F66 RID: 135014 RVA: 0x0048EC4C File Offset: 0x0048CE4C
		public int SkillId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020F67 RID: 135015 RVA: 0x0048EC88 File Offset: 0x0048CE88
		public static Offset<ISkillUseTypeRoleSkill> CreateISkillUseTypeRoleSkill(FlatBufferBuilder builder, ESkillUseType Type = ESkillUseType.RoleSkill, int SkillId = 0)
		{
			builder.StartTable(2);
			ISkillUseTypeRoleSkill.AddSkillId(builder, SkillId);
			ISkillUseTypeRoleSkill.AddType(builder, Type);
			return ISkillUseTypeRoleSkill.EndISkillUseTypeRoleSkill(builder);
		}

		// Token: 0x06020F68 RID: 135016 RVA: 0x0048ECA5 File Offset: 0x0048CEA5
		public static void StartISkillUseTypeRoleSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020F69 RID: 135017 RVA: 0x0048ECAE File Offset: 0x0048CEAE
		public static void AddType(FlatBufferBuilder builder, ESkillUseType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020F6A RID: 135018 RVA: 0x0048ECB9 File Offset: 0x0048CEB9
		public static void AddSkillId(FlatBufferBuilder builder, int skillId)
		{
			builder.AddInt(1, skillId, 0);
		}

		// Token: 0x06020F6B RID: 135019 RVA: 0x0048ECC4 File Offset: 0x0048CEC4
		public static Offset<ISkillUseTypeRoleSkill> EndISkillUseTypeRoleSkill(FlatBufferBuilder builder)
		{
			return new Offset<ISkillUseTypeRoleSkill>(builder.EndTable());
		}

		// Token: 0x06020F6C RID: 135020 RVA: 0x0048ECD4 File Offset: 0x0048CED4
		public ISkillUseTypeRoleSkillT UnPack()
		{
			ISkillUseTypeRoleSkillT skillUseTypeRoleSkillT = new ISkillUseTypeRoleSkillT();
			this.UnPackTo(skillUseTypeRoleSkillT);
			return skillUseTypeRoleSkillT;
		}

		// Token: 0x06020F6D RID: 135021 RVA: 0x0048ECEF File Offset: 0x0048CEEF
		public void UnPackTo(ISkillUseTypeRoleSkillT _o)
		{
			_o.Type = this.Type;
			_o.SkillId = this.SkillId;
		}

		// Token: 0x06020F6E RID: 135022 RVA: 0x0048ED0C File Offset: 0x0048CF0C
		public static Offset<ISkillUseTypeRoleSkill> Pack(FlatBufferBuilder builder, ISkillUseTypeRoleSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkillUseTypeRoleSkill>);
			}
			return ISkillUseTypeRoleSkill.CreateISkillUseTypeRoleSkill(builder, _o.Type, _o.SkillId);
		}

		// Token: 0x0400E1C1 RID: 57793
		private Table __p;
	}
}
