using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CCD RID: 19661
	public struct ISkillUseTypeRoleSkill : IFlatbufferObject
	{
		// Token: 0x17008EB1 RID: 36529
		// (get) Token: 0x0601F31B RID: 127771 RVA: 0x0045ACA9 File Offset: 0x00458EA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F31C RID: 127772 RVA: 0x0045ACB6 File Offset: 0x00458EB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F31D RID: 127773 RVA: 0x0045ACC0 File Offset: 0x00458EC0
		public static ISkillUseTypeRoleSkill GetRootAsISkillUseTypeRoleSkill(ByteBuffer _bb)
		{
			return ISkillUseTypeRoleSkill.GetRootAsISkillUseTypeRoleSkill(_bb, default(ISkillUseTypeRoleSkill));
		}

		// Token: 0x0601F31E RID: 127774 RVA: 0x0045ACDC File Offset: 0x00458EDC
		public static ISkillUseTypeRoleSkill GetRootAsISkillUseTypeRoleSkill(ByteBuffer _bb, ISkillUseTypeRoleSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F31F RID: 127775 RVA: 0x0045ACF9 File Offset: 0x00458EF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F320 RID: 127776 RVA: 0x0045AD08 File Offset: 0x00458F08
		public ISkillUseTypeRoleSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008EB2 RID: 36530
		// (get) Token: 0x0601F321 RID: 127777 RVA: 0x0045AD18 File Offset: 0x00458F18
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

		// Token: 0x17008EB3 RID: 36531
		// (get) Token: 0x0601F322 RID: 127778 RVA: 0x0045AD54 File Offset: 0x00458F54
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

		// Token: 0x0601F323 RID: 127779 RVA: 0x0045AD90 File Offset: 0x00458F90
		public static Offset<ISkillUseTypeRoleSkill> CreateISkillUseTypeRoleSkill(FlatBufferBuilder builder, ESkillUseType Type = ESkillUseType.RoleSkill, int SkillId = 0)
		{
			builder.StartTable(2);
			ISkillUseTypeRoleSkill.AddSkillId(builder, SkillId);
			ISkillUseTypeRoleSkill.AddType(builder, Type);
			return ISkillUseTypeRoleSkill.EndISkillUseTypeRoleSkill(builder);
		}

		// Token: 0x0601F324 RID: 127780 RVA: 0x0045ADAD File Offset: 0x00458FAD
		public static void StartISkillUseTypeRoleSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F325 RID: 127781 RVA: 0x0045ADB6 File Offset: 0x00458FB6
		public static void AddType(FlatBufferBuilder builder, ESkillUseType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F326 RID: 127782 RVA: 0x0045ADC1 File Offset: 0x00458FC1
		public static void AddSkillId(FlatBufferBuilder builder, int skillId)
		{
			builder.AddInt(1, skillId, 0);
		}

		// Token: 0x0601F327 RID: 127783 RVA: 0x0045ADCC File Offset: 0x00458FCC
		public static Offset<ISkillUseTypeRoleSkill> EndISkillUseTypeRoleSkill(FlatBufferBuilder builder)
		{
			return new Offset<ISkillUseTypeRoleSkill>(builder.EndTable());
		}

		// Token: 0x0601F328 RID: 127784 RVA: 0x0045ADDC File Offset: 0x00458FDC
		public ISkillUseTypeRoleSkillT UnPack()
		{
			ISkillUseTypeRoleSkillT skillUseTypeRoleSkillT = new ISkillUseTypeRoleSkillT();
			this.UnPackTo(skillUseTypeRoleSkillT);
			return skillUseTypeRoleSkillT;
		}

		// Token: 0x0601F329 RID: 127785 RVA: 0x0045ADF7 File Offset: 0x00458FF7
		public void UnPackTo(ISkillUseTypeRoleSkillT _o)
		{
			_o.Type = this.Type;
			_o.SkillId = this.SkillId;
		}

		// Token: 0x0601F32A RID: 127786 RVA: 0x0045AE14 File Offset: 0x00459014
		public static Offset<ISkillUseTypeRoleSkill> Pack(FlatBufferBuilder builder, ISkillUseTypeRoleSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkillUseTypeRoleSkill>);
			}
			return ISkillUseTypeRoleSkill.CreateISkillUseTypeRoleSkill(builder, _o.Type, _o.SkillId);
		}

		// Token: 0x0400D694 RID: 54932
		private Table __p;
	}
}
