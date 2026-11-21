using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B5A RID: 27482
	public struct ICurrentTeam : IFlatbufferObject
	{
		// Token: 0x1700C9C0 RID: 51648
		// (get) Token: 0x0602F4AF RID: 193711 RVA: 0x00674BFC File Offset: 0x00672DFC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F4B0 RID: 193712 RVA: 0x00674C09 File Offset: 0x00672E09
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F4B1 RID: 193713 RVA: 0x00674C10 File Offset: 0x00672E10
		public static ICurrentTeam GetRootAsICurrentTeam(ByteBuffer _bb)
		{
			return ICurrentTeam.GetRootAsICurrentTeam(_bb, default(ICurrentTeam));
		}

		// Token: 0x0602F4B2 RID: 193714 RVA: 0x00674C2C File Offset: 0x00672E2C
		public static ICurrentTeam GetRootAsICurrentTeam(ByteBuffer _bb, ICurrentTeam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F4B3 RID: 193715 RVA: 0x00674C49 File Offset: 0x00672E49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F4B4 RID: 193716 RVA: 0x00674C58 File Offset: 0x00672E58
		public ICurrentTeam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9C1 RID: 51649
		// (get) Token: 0x0602F4B5 RID: 193717 RVA: 0x00674C68 File Offset: 0x00672E68
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

		// Token: 0x0602F4B6 RID: 193718 RVA: 0x00674CA4 File Offset: 0x00672EA4
		public static Offset<ICurrentTeam> CreateICurrentTeam(FlatBufferBuilder builder, ETeamType Type = ETeamType.Current)
		{
			builder.StartTable(1);
			ICurrentTeam.AddType(builder, Type);
			return ICurrentTeam.EndICurrentTeam(builder);
		}

		// Token: 0x0602F4B7 RID: 193719 RVA: 0x00674CBA File Offset: 0x00672EBA
		public static void StartICurrentTeam(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F4B8 RID: 193720 RVA: 0x00674CC3 File Offset: 0x00672EC3
		public static void AddType(FlatBufferBuilder builder, ETeamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F4B9 RID: 193721 RVA: 0x00674CCE File Offset: 0x00672ECE
		public static Offset<ICurrentTeam> EndICurrentTeam(FlatBufferBuilder builder)
		{
			return new Offset<ICurrentTeam>(builder.EndTable());
		}

		// Token: 0x0602F4BA RID: 193722 RVA: 0x00674CDC File Offset: 0x00672EDC
		public ICurrentTeamT UnPack()
		{
			ICurrentTeamT currentTeamT = new ICurrentTeamT();
			this.UnPackTo(currentTeamT);
			return currentTeamT;
		}

		// Token: 0x0602F4BB RID: 193723 RVA: 0x00674CF7 File Offset: 0x00672EF7
		public void UnPackTo(ICurrentTeamT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F4BC RID: 193724 RVA: 0x00674D08 File Offset: 0x00672F08
		public static Offset<ICurrentTeam> Pack(FlatBufferBuilder builder, ICurrentTeamT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICurrentTeam>);
			}
			return ICurrentTeam.CreateICurrentTeam(builder, _o.Type);
		}

		// Token: 0x04011949 RID: 72009
		private Table __p;
	}
}
