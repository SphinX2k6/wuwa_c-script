using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CCA RID: 19658
	public struct ISkillUseType : IFlatbufferObject
	{
		// Token: 0x17008EAE RID: 36526
		// (get) Token: 0x0601F309 RID: 127753 RVA: 0x0045AB32 File Offset: 0x00458D32
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F30A RID: 127754 RVA: 0x0045AB3F File Offset: 0x00458D3F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F30B RID: 127755 RVA: 0x0045AB48 File Offset: 0x00458D48
		public static ISkillUseType GetRootAsISkillUseType(ByteBuffer _bb)
		{
			return ISkillUseType.GetRootAsISkillUseType(_bb, default(ISkillUseType));
		}

		// Token: 0x0601F30C RID: 127756 RVA: 0x0045AB64 File Offset: 0x00458D64
		public static ISkillUseType GetRootAsISkillUseType(ByteBuffer _bb, ISkillUseType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F30D RID: 127757 RVA: 0x0045AB81 File Offset: 0x00458D81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F30E RID: 127758 RVA: 0x0045AB90 File Offset: 0x00458D90
		public ISkillUseType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008EAF RID: 36527
		// (get) Token: 0x0601F30F RID: 127759 RVA: 0x0045ABA0 File Offset: 0x00458DA0
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

		// Token: 0x0601F310 RID: 127760 RVA: 0x0045ABDC File Offset: 0x00458DDC
		public static Offset<ISkillUseType> CreateISkillUseType(FlatBufferBuilder builder, ESkillUseType Type = ESkillUseType.RoleSkill)
		{
			builder.StartTable(1);
			ISkillUseType.AddType(builder, Type);
			return ISkillUseType.EndISkillUseType(builder);
		}

		// Token: 0x0601F311 RID: 127761 RVA: 0x0045ABF2 File Offset: 0x00458DF2
		public static void StartISkillUseType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601F312 RID: 127762 RVA: 0x0045ABFB File Offset: 0x00458DFB
		public static void AddType(FlatBufferBuilder builder, ESkillUseType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F313 RID: 127763 RVA: 0x0045AC06 File Offset: 0x00458E06
		public static Offset<ISkillUseType> EndISkillUseType(FlatBufferBuilder builder)
		{
			return new Offset<ISkillUseType>(builder.EndTable());
		}

		// Token: 0x0601F314 RID: 127764 RVA: 0x0045AC14 File Offset: 0x00458E14
		public ISkillUseTypeT UnPack()
		{
			ISkillUseTypeT skillUseTypeT = new ISkillUseTypeT();
			this.UnPackTo(skillUseTypeT);
			return skillUseTypeT;
		}

		// Token: 0x0601F315 RID: 127765 RVA: 0x0045AC2F File Offset: 0x00458E2F
		public void UnPackTo(ISkillUseTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F316 RID: 127766 RVA: 0x0045AC40 File Offset: 0x00458E40
		public static Offset<ISkillUseType> Pack(FlatBufferBuilder builder, ISkillUseTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkillUseType>);
			}
			return ISkillUseType.CreateISkillUseType(builder, _o.Type);
		}

		// Token: 0x0400D692 RID: 54930
		private Table __p;
	}
}
