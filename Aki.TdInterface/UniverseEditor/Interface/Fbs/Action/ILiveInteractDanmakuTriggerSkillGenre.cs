using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007103 RID: 28931
	public struct ILiveInteractDanmakuTriggerSkillGenre : IFlatbufferObject
	{
		// Token: 0x1700D3E0 RID: 54240
		// (get) Token: 0x060323F5 RID: 205813 RVA: 0x006CBA9C File Offset: 0x006C9C9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060323F6 RID: 205814 RVA: 0x006CBAA9 File Offset: 0x006C9CA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060323F7 RID: 205815 RVA: 0x006CBAB0 File Offset: 0x006C9CB0
		public static ILiveInteractDanmakuTriggerSkillGenre GetRootAsILiveInteractDanmakuTriggerSkillGenre(ByteBuffer _bb)
		{
			return ILiveInteractDanmakuTriggerSkillGenre.GetRootAsILiveInteractDanmakuTriggerSkillGenre(_bb, default(ILiveInteractDanmakuTriggerSkillGenre));
		}

		// Token: 0x060323F8 RID: 205816 RVA: 0x006CBACC File Offset: 0x006C9CCC
		public static ILiveInteractDanmakuTriggerSkillGenre GetRootAsILiveInteractDanmakuTriggerSkillGenre(ByteBuffer _bb, ILiveInteractDanmakuTriggerSkillGenre obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060323F9 RID: 205817 RVA: 0x006CBAE9 File Offset: 0x006C9CE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060323FA RID: 205818 RVA: 0x006CBAF8 File Offset: 0x006C9CF8
		public ILiveInteractDanmakuTriggerSkillGenre __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3E1 RID: 54241
		// (get) Token: 0x060323FB RID: 205819 RVA: 0x006CBB08 File Offset: 0x006C9D08
		public ELiveInteractDanmakuTriggerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiveInteractDanmakuTriggerType.SkillGenre;
				}
				return (ELiveInteractDanmakuTriggerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D3E2 RID: 54242
		// (get) Token: 0x060323FC RID: 205820 RVA: 0x006CBB44 File Offset: 0x006C9D44
		public int SkillGenre
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

		// Token: 0x060323FD RID: 205821 RVA: 0x006CBB80 File Offset: 0x006C9D80
		public static Offset<ILiveInteractDanmakuTriggerSkillGenre> CreateILiveInteractDanmakuTriggerSkillGenre(FlatBufferBuilder builder, ELiveInteractDanmakuTriggerType Type = ELiveInteractDanmakuTriggerType.SkillGenre, int SkillGenre = 0)
		{
			builder.StartTable(2);
			ILiveInteractDanmakuTriggerSkillGenre.AddSkillGenre(builder, SkillGenre);
			ILiveInteractDanmakuTriggerSkillGenre.AddType(builder, Type);
			return ILiveInteractDanmakuTriggerSkillGenre.EndILiveInteractDanmakuTriggerSkillGenre(builder);
		}

		// Token: 0x060323FE RID: 205822 RVA: 0x006CBB9D File Offset: 0x006C9D9D
		public static void StartILiveInteractDanmakuTriggerSkillGenre(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060323FF RID: 205823 RVA: 0x006CBBA6 File Offset: 0x006C9DA6
		public static void AddType(FlatBufferBuilder builder, ELiveInteractDanmakuTriggerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032400 RID: 205824 RVA: 0x006CBBB1 File Offset: 0x006C9DB1
		public static void AddSkillGenre(FlatBufferBuilder builder, int skillGenre)
		{
			builder.AddInt(1, skillGenre, 0);
		}

		// Token: 0x06032401 RID: 205825 RVA: 0x006CBBBC File Offset: 0x006C9DBC
		public static Offset<ILiveInteractDanmakuTriggerSkillGenre> EndILiveInteractDanmakuTriggerSkillGenre(FlatBufferBuilder builder)
		{
			return new Offset<ILiveInteractDanmakuTriggerSkillGenre>(builder.EndTable());
		}

		// Token: 0x06032402 RID: 205826 RVA: 0x006CBBCC File Offset: 0x006C9DCC
		public ILiveInteractDanmakuTriggerSkillGenreT UnPack()
		{
			ILiveInteractDanmakuTriggerSkillGenreT liveInteractDanmakuTriggerSkillGenreT = new ILiveInteractDanmakuTriggerSkillGenreT();
			this.UnPackTo(liveInteractDanmakuTriggerSkillGenreT);
			return liveInteractDanmakuTriggerSkillGenreT;
		}

		// Token: 0x06032403 RID: 205827 RVA: 0x006CBBE7 File Offset: 0x006C9DE7
		public void UnPackTo(ILiveInteractDanmakuTriggerSkillGenreT _o)
		{
			_o.Type = this.Type;
			_o.SkillGenre = this.SkillGenre;
		}

		// Token: 0x06032404 RID: 205828 RVA: 0x006CBC04 File Offset: 0x006C9E04
		public static Offset<ILiveInteractDanmakuTriggerSkillGenre> Pack(FlatBufferBuilder builder, ILiveInteractDanmakuTriggerSkillGenreT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveInteractDanmakuTriggerSkillGenre>);
			}
			return ILiveInteractDanmakuTriggerSkillGenre.CreateILiveInteractDanmakuTriggerSkillGenre(builder, _o.Type, _o.SkillGenre);
		}

		// Token: 0x040120D6 RID: 73942
		private Table __p;
	}
}
