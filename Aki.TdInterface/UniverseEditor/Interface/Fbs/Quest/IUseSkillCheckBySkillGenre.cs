using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200424D RID: 16973
	public struct IUseSkillCheckBySkillGenre : IFlatbufferObject
	{
		// Token: 0x1700787D RID: 30845
		// (get) Token: 0x060191A7 RID: 102823 RVA: 0x0039C00E File Offset: 0x0039A20E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060191A8 RID: 102824 RVA: 0x0039C01B File Offset: 0x0039A21B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060191A9 RID: 102825 RVA: 0x0039C024 File Offset: 0x0039A224
		public static IUseSkillCheckBySkillGenre GetRootAsIUseSkillCheckBySkillGenre(ByteBuffer _bb)
		{
			return IUseSkillCheckBySkillGenre.GetRootAsIUseSkillCheckBySkillGenre(_bb, default(IUseSkillCheckBySkillGenre));
		}

		// Token: 0x060191AA RID: 102826 RVA: 0x0039C040 File Offset: 0x0039A240
		public static IUseSkillCheckBySkillGenre GetRootAsIUseSkillCheckBySkillGenre(ByteBuffer _bb, IUseSkillCheckBySkillGenre obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060191AB RID: 102827 RVA: 0x0039C05D File Offset: 0x0039A25D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060191AC RID: 102828 RVA: 0x0039C06C File Offset: 0x0039A26C
		public IUseSkillCheckBySkillGenre __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700787E RID: 30846
		// (get) Token: 0x060191AD RID: 102829 RVA: 0x0039C07C File Offset: 0x0039A27C
		public EUseSkillCheckType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EUseSkillCheckType.CheckSkillGenre;
				}
				return (EUseSkillCheckType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700787F RID: 30847
		// (get) Token: 0x060191AE RID: 102830 RVA: 0x0039C0B8 File Offset: 0x0039A2B8
		public ESkillCategory SkillGenre
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ESkillCategory.Normal;
				}
				return (ESkillCategory)this.__p.bb.GetSbyte(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060191AF RID: 102831 RVA: 0x0039C0F4 File Offset: 0x0039A2F4
		public static Offset<IUseSkillCheckBySkillGenre> CreateIUseSkillCheckBySkillGenre(FlatBufferBuilder builder, EUseSkillCheckType Type = EUseSkillCheckType.CheckSkillGenre, ESkillCategory SkillGenre = ESkillCategory.Normal)
		{
			builder.StartTable(2);
			IUseSkillCheckBySkillGenre.AddSkillGenre(builder, SkillGenre);
			IUseSkillCheckBySkillGenre.AddType(builder, Type);
			return IUseSkillCheckBySkillGenre.EndIUseSkillCheckBySkillGenre(builder);
		}

		// Token: 0x060191B0 RID: 102832 RVA: 0x0039C111 File Offset: 0x0039A311
		public static void StartIUseSkillCheckBySkillGenre(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060191B1 RID: 102833 RVA: 0x0039C11A File Offset: 0x0039A31A
		public static void AddType(FlatBufferBuilder builder, EUseSkillCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060191B2 RID: 102834 RVA: 0x0039C125 File Offset: 0x0039A325
		public static void AddSkillGenre(FlatBufferBuilder builder, ESkillCategory skillGenre)
		{
			builder.AddSbyte(1, (sbyte)skillGenre, 0);
		}

		// Token: 0x060191B3 RID: 102835 RVA: 0x0039C130 File Offset: 0x0039A330
		public static Offset<IUseSkillCheckBySkillGenre> EndIUseSkillCheckBySkillGenre(FlatBufferBuilder builder)
		{
			return new Offset<IUseSkillCheckBySkillGenre>(builder.EndTable());
		}

		// Token: 0x060191B4 RID: 102836 RVA: 0x0039C140 File Offset: 0x0039A340
		public IUseSkillCheckBySkillGenreT UnPack()
		{
			IUseSkillCheckBySkillGenreT useSkillCheckBySkillGenreT = new IUseSkillCheckBySkillGenreT();
			this.UnPackTo(useSkillCheckBySkillGenreT);
			return useSkillCheckBySkillGenreT;
		}

		// Token: 0x060191B5 RID: 102837 RVA: 0x0039C15B File Offset: 0x0039A35B
		public void UnPackTo(IUseSkillCheckBySkillGenreT _o)
		{
			_o.Type = this.Type;
			_o.SkillGenre = this.SkillGenre;
		}

		// Token: 0x060191B6 RID: 102838 RVA: 0x0039C178 File Offset: 0x0039A378
		public static Offset<IUseSkillCheckBySkillGenre> Pack(FlatBufferBuilder builder, IUseSkillCheckBySkillGenreT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseSkillCheckBySkillGenre>);
			}
			return IUseSkillCheckBySkillGenre.CreateIUseSkillCheckBySkillGenre(builder, _o.Type, _o.SkillGenre);
		}

		// Token: 0x0400BED7 RID: 48855
		private Table __p;
	}
}
