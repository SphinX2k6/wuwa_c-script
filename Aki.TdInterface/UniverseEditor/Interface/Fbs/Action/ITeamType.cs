using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B51 RID: 31569
	public struct ITeamType : IFlatbufferObject
	{
		// Token: 0x1700EC64 RID: 60516
		// (get) Token: 0x06038D97 RID: 232855 RVA: 0x007AFBBA File Offset: 0x007ADDBA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038D98 RID: 232856 RVA: 0x007AFBC7 File Offset: 0x007ADDC7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038D99 RID: 232857 RVA: 0x007AFBD0 File Offset: 0x007ADDD0
		public static ITeamType GetRootAsITeamType(ByteBuffer _bb)
		{
			return ITeamType.GetRootAsITeamType(_bb, default(ITeamType));
		}

		// Token: 0x06038D9A RID: 232858 RVA: 0x007AFBEC File Offset: 0x007ADDEC
		public static ITeamType GetRootAsITeamType(ByteBuffer _bb, ITeamType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038D9B RID: 232859 RVA: 0x007AFC09 File Offset: 0x007ADE09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038D9C RID: 232860 RVA: 0x007AFC18 File Offset: 0x007ADE18
		public ITeamType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC65 RID: 60517
		// (get) Token: 0x06038D9D RID: 232861 RVA: 0x007AFC28 File Offset: 0x007ADE28
		public ETeamType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeamType.Current;
				}
				return (ETeamType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038D9E RID: 232862 RVA: 0x007AFC64 File Offset: 0x007ADE64
		public static Offset<ITeamType> CreateITeamType(FlatBufferBuilder builder, ETeamType Type = ETeamType.Current)
		{
			builder.StartTable(1);
			ITeamType.AddType(builder, Type);
			return ITeamType.EndITeamType(builder);
		}

		// Token: 0x06038D9F RID: 232863 RVA: 0x007AFC7A File Offset: 0x007ADE7A
		public static void StartITeamType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06038DA0 RID: 232864 RVA: 0x007AFC83 File Offset: 0x007ADE83
		public static void AddType(FlatBufferBuilder builder, ETeamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038DA1 RID: 232865 RVA: 0x007AFC8E File Offset: 0x007ADE8E
		public static Offset<ITeamType> EndITeamType(FlatBufferBuilder builder)
		{
			return new Offset<ITeamType>(builder.EndTable());
		}

		// Token: 0x06038DA2 RID: 232866 RVA: 0x007AFC9C File Offset: 0x007ADE9C
		public ITeamTypeT UnPack()
		{
			ITeamTypeT teamTypeT = new ITeamTypeT();
			this.UnPackTo(teamTypeT);
			return teamTypeT;
		}

		// Token: 0x06038DA3 RID: 232867 RVA: 0x007AFCB7 File Offset: 0x007ADEB7
		public void UnPackTo(ITeamTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06038DA4 RID: 232868 RVA: 0x007AFCC8 File Offset: 0x007ADEC8
		public static Offset<ITeamType> Pack(FlatBufferBuilder builder, ITeamTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeamType>);
			}
			return ITeamType.CreateITeamType(builder, _o.Type);
		}

		// Token: 0x0401318E RID: 78222
		private Table __p;
	}
}
