using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046A9 RID: 18089
	public struct IUseSkillCheckBySkillGenre : IFlatbufferObject
	{
		// Token: 0x17007EAE RID: 32430
		// (get) Token: 0x0601A913 RID: 108819 RVA: 0x003C76E6 File Offset: 0x003C58E6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A914 RID: 108820 RVA: 0x003C76F3 File Offset: 0x003C58F3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A915 RID: 108821 RVA: 0x003C76FC File Offset: 0x003C58FC
		public static IUseSkillCheckBySkillGenre GetRootAsIUseSkillCheckBySkillGenre(ByteBuffer _bb)
		{
			return IUseSkillCheckBySkillGenre.GetRootAsIUseSkillCheckBySkillGenre(_bb, default(IUseSkillCheckBySkillGenre));
		}

		// Token: 0x0601A916 RID: 108822 RVA: 0x003C7718 File Offset: 0x003C5918
		public static IUseSkillCheckBySkillGenre GetRootAsIUseSkillCheckBySkillGenre(ByteBuffer _bb, IUseSkillCheckBySkillGenre obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A917 RID: 108823 RVA: 0x003C7735 File Offset: 0x003C5935
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A918 RID: 108824 RVA: 0x003C7744 File Offset: 0x003C5944
		public IUseSkillCheckBySkillGenre __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EAF RID: 32431
		// (get) Token: 0x0601A919 RID: 108825 RVA: 0x003C7754 File Offset: 0x003C5954
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

		// Token: 0x17007EB0 RID: 32432
		// (get) Token: 0x0601A91A RID: 108826 RVA: 0x003C7790 File Offset: 0x003C5990
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

		// Token: 0x0601A91B RID: 108827 RVA: 0x003C77CC File Offset: 0x003C59CC
		public static Offset<IUseSkillCheckBySkillGenre> CreateIUseSkillCheckBySkillGenre(FlatBufferBuilder builder, EUseSkillCheckType Type = EUseSkillCheckType.CheckSkillGenre, ESkillCategory SkillGenre = ESkillCategory.Normal)
		{
			builder.StartTable(2);
			IUseSkillCheckBySkillGenre.AddSkillGenre(builder, SkillGenre);
			IUseSkillCheckBySkillGenre.AddType(builder, Type);
			return IUseSkillCheckBySkillGenre.EndIUseSkillCheckBySkillGenre(builder);
		}

		// Token: 0x0601A91C RID: 108828 RVA: 0x003C77E9 File Offset: 0x003C59E9
		public static void StartIUseSkillCheckBySkillGenre(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A91D RID: 108829 RVA: 0x003C77F2 File Offset: 0x003C59F2
		public static void AddType(FlatBufferBuilder builder, EUseSkillCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A91E RID: 108830 RVA: 0x003C77FD File Offset: 0x003C59FD
		public static void AddSkillGenre(FlatBufferBuilder builder, ESkillCategory skillGenre)
		{
			builder.AddSbyte(1, (sbyte)skillGenre, 0);
		}

		// Token: 0x0601A91F RID: 108831 RVA: 0x003C7808 File Offset: 0x003C5A08
		public static Offset<IUseSkillCheckBySkillGenre> EndIUseSkillCheckBySkillGenre(FlatBufferBuilder builder)
		{
			return new Offset<IUseSkillCheckBySkillGenre>(builder.EndTable());
		}

		// Token: 0x0601A920 RID: 108832 RVA: 0x003C7818 File Offset: 0x003C5A18
		public IUseSkillCheckBySkillGenreT UnPack()
		{
			IUseSkillCheckBySkillGenreT useSkillCheckBySkillGenreT = new IUseSkillCheckBySkillGenreT();
			this.UnPackTo(useSkillCheckBySkillGenreT);
			return useSkillCheckBySkillGenreT;
		}

		// Token: 0x0601A921 RID: 108833 RVA: 0x003C7833 File Offset: 0x003C5A33
		public void UnPackTo(IUseSkillCheckBySkillGenreT _o)
		{
			_o.Type = this.Type;
			_o.SkillGenre = this.SkillGenre;
		}

		// Token: 0x0601A922 RID: 108834 RVA: 0x003C7850 File Offset: 0x003C5A50
		public static Offset<IUseSkillCheckBySkillGenre> Pack(FlatBufferBuilder builder, IUseSkillCheckBySkillGenreT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseSkillCheckBySkillGenre>);
			}
			return IUseSkillCheckBySkillGenre.CreateIUseSkillCheckBySkillGenre(builder, _o.Type, _o.SkillGenre);
		}

		// Token: 0x0400C8E4 RID: 51428
		private Table __p;
	}
}
