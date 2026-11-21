using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051C6 RID: 20934
	public struct ISkillUseType : IFlatbufferObject
	{
		// Token: 0x170095E7 RID: 38375
		// (get) Token: 0x06020F4D RID: 134989 RVA: 0x0048EA2A File Offset: 0x0048CC2A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020F4E RID: 134990 RVA: 0x0048EA37 File Offset: 0x0048CC37
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020F4F RID: 134991 RVA: 0x0048EA40 File Offset: 0x0048CC40
		public static ISkillUseType GetRootAsISkillUseType(ByteBuffer _bb)
		{
			return ISkillUseType.GetRootAsISkillUseType(_bb, default(ISkillUseType));
		}

		// Token: 0x06020F50 RID: 134992 RVA: 0x0048EA5C File Offset: 0x0048CC5C
		public static ISkillUseType GetRootAsISkillUseType(ByteBuffer _bb, ISkillUseType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020F51 RID: 134993 RVA: 0x0048EA79 File Offset: 0x0048CC79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020F52 RID: 134994 RVA: 0x0048EA88 File Offset: 0x0048CC88
		public ISkillUseType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170095E8 RID: 38376
		// (get) Token: 0x06020F53 RID: 134995 RVA: 0x0048EA98 File Offset: 0x0048CC98
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

		// Token: 0x06020F54 RID: 134996 RVA: 0x0048EAD4 File Offset: 0x0048CCD4
		public static Offset<ISkillUseType> CreateISkillUseType(FlatBufferBuilder builder, ESkillUseType Type = ESkillUseType.RoleSkill)
		{
			builder.StartTable(1);
			ISkillUseType.AddType(builder, Type);
			return ISkillUseType.EndISkillUseType(builder);
		}

		// Token: 0x06020F55 RID: 134997 RVA: 0x0048EAEA File Offset: 0x0048CCEA
		public static void StartISkillUseType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020F56 RID: 134998 RVA: 0x0048EAF3 File Offset: 0x0048CCF3
		public static void AddType(FlatBufferBuilder builder, ESkillUseType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020F57 RID: 134999 RVA: 0x0048EAFE File Offset: 0x0048CCFE
		public static Offset<ISkillUseType> EndISkillUseType(FlatBufferBuilder builder)
		{
			return new Offset<ISkillUseType>(builder.EndTable());
		}

		// Token: 0x06020F58 RID: 135000 RVA: 0x0048EB0C File Offset: 0x0048CD0C
		public ISkillUseTypeT UnPack()
		{
			ISkillUseTypeT skillUseTypeT = new ISkillUseTypeT();
			this.UnPackTo(skillUseTypeT);
			return skillUseTypeT;
		}

		// Token: 0x06020F59 RID: 135001 RVA: 0x0048EB27 File Offset: 0x0048CD27
		public void UnPackTo(ISkillUseTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020F5A RID: 135002 RVA: 0x0048EB38 File Offset: 0x0048CD38
		public static Offset<ISkillUseType> Pack(FlatBufferBuilder builder, ISkillUseTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkillUseType>);
			}
			return ISkillUseType.CreateISkillUseType(builder, _o.Type);
		}

		// Token: 0x0400E1BF RID: 57791
		private Table __p;
	}
}
