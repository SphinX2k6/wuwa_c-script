using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006519 RID: 25881
	public struct ICustomSkill : IFlatbufferObject
	{
		// Token: 0x1700C06F RID: 49263
		// (get) Token: 0x0602CE4F RID: 183887 RVA: 0x0062A657 File Offset: 0x00628857
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CE50 RID: 183888 RVA: 0x0062A664 File Offset: 0x00628864
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CE51 RID: 183889 RVA: 0x0062A66C File Offset: 0x0062886C
		public static ICustomSkill GetRootAsICustomSkill(ByteBuffer _bb)
		{
			return ICustomSkill.GetRootAsICustomSkill(_bb, default(ICustomSkill));
		}

		// Token: 0x0602CE52 RID: 183890 RVA: 0x0062A688 File Offset: 0x00628888
		public static ICustomSkill GetRootAsICustomSkill(ByteBuffer _bb, ICustomSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CE53 RID: 183891 RVA: 0x0062A6A5 File Offset: 0x006288A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CE54 RID: 183892 RVA: 0x0062A6B4 File Offset: 0x006288B4
		public ICustomSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C070 RID: 49264
		// (get) Token: 0x0602CE55 RID: 183893 RVA: 0x0062A6C4 File Offset: 0x006288C4
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C071 RID: 49265
		// (get) Token: 0x0602CE56 RID: 183894 RVA: 0x0062A700 File Offset: 0x00628900
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

		// Token: 0x0602CE57 RID: 183895 RVA: 0x0062A73C File Offset: 0x0062893C
		public static Offset<ICustomSkill> CreateICustomSkill(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, int SkillId = 0)
		{
			builder.StartTable(2);
			ICustomSkill.AddSkillId(builder, SkillId);
			ICustomSkill.AddType(builder, Type);
			return ICustomSkill.EndICustomSkill(builder);
		}

		// Token: 0x0602CE58 RID: 183896 RVA: 0x0062A759 File Offset: 0x00628959
		public static void StartICustomSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CE59 RID: 183897 RVA: 0x0062A762 File Offset: 0x00628962
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CE5A RID: 183898 RVA: 0x0062A76D File Offset: 0x0062896D
		public static void AddSkillId(FlatBufferBuilder builder, int skillId)
		{
			builder.AddInt(1, skillId, 0);
		}

		// Token: 0x0602CE5B RID: 183899 RVA: 0x0062A778 File Offset: 0x00628978
		public static Offset<ICustomSkill> EndICustomSkill(FlatBufferBuilder builder)
		{
			return new Offset<ICustomSkill>(builder.EndTable());
		}

		// Token: 0x0602CE5C RID: 183900 RVA: 0x0062A788 File Offset: 0x00628988
		public ICustomSkillT UnPack()
		{
			ICustomSkillT customSkillT = new ICustomSkillT();
			this.UnPackTo(customSkillT);
			return customSkillT;
		}

		// Token: 0x0602CE5D RID: 183901 RVA: 0x0062A7A3 File Offset: 0x006289A3
		public void UnPackTo(ICustomSkillT _o)
		{
			_o.Type = this.Type;
			_o.SkillId = this.SkillId;
		}

		// Token: 0x0602CE5E RID: 183902 RVA: 0x0062A7C0 File Offset: 0x006289C0
		public static Offset<ICustomSkill> Pack(FlatBufferBuilder builder, ICustomSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomSkill>);
			}
			return ICustomSkill.CreateICustomSkill(builder, _o.Type, _o.SkillId);
		}

		// Token: 0x04010B63 RID: 68451
		private Table __p;
	}
}
