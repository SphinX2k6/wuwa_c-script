using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200736A RID: 29546
	public struct ITeammateTeleportConfig : IFlatbufferObject
	{
		// Token: 0x1700E054 RID: 57428
		// (get) Token: 0x06035A00 RID: 219648 RVA: 0x0074D70A File Offset: 0x0074B90A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035A01 RID: 219649 RVA: 0x0074D717 File Offset: 0x0074B917
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035A02 RID: 219650 RVA: 0x0074D720 File Offset: 0x0074B920
		public static ITeammateTeleportConfig GetRootAsITeammateTeleportConfig(ByteBuffer _bb)
		{
			return ITeammateTeleportConfig.GetRootAsITeammateTeleportConfig(_bb, default(ITeammateTeleportConfig));
		}

		// Token: 0x06035A03 RID: 219651 RVA: 0x0074D73C File Offset: 0x0074B93C
		public static ITeammateTeleportConfig GetRootAsITeammateTeleportConfig(ByteBuffer _bb, ITeammateTeleportConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035A04 RID: 219652 RVA: 0x0074D759 File Offset: 0x0074B959
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035A05 RID: 219653 RVA: 0x0074D768 File Offset: 0x0074B968
		public ITeammateTeleportConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E055 RID: 57429
		// (get) Token: 0x06035A06 RID: 219654 RVA: 0x0074D778 File Offset: 0x0074B978
		public ETeammateTeleportType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeammateTeleportType.TelePortAfterTimeOut;
				}
				return (ETeammateTeleportType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035A07 RID: 219655 RVA: 0x0074D7B4 File Offset: 0x0074B9B4
		public static Offset<ITeammateTeleportConfig> CreateITeammateTeleportConfig(FlatBufferBuilder builder, ETeammateTeleportType Type = ETeammateTeleportType.TelePortAfterTimeOut)
		{
			builder.StartTable(1);
			ITeammateTeleportConfig.AddType(builder, Type);
			return ITeammateTeleportConfig.EndITeammateTeleportConfig(builder);
		}

		// Token: 0x06035A08 RID: 219656 RVA: 0x0074D7CA File Offset: 0x0074B9CA
		public static void StartITeammateTeleportConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035A09 RID: 219657 RVA: 0x0074D7D3 File Offset: 0x0074B9D3
		public static void AddType(FlatBufferBuilder builder, ETeammateTeleportType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035A0A RID: 219658 RVA: 0x0074D7DE File Offset: 0x0074B9DE
		public static Offset<ITeammateTeleportConfig> EndITeammateTeleportConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITeammateTeleportConfig>(builder.EndTable());
		}

		// Token: 0x06035A0B RID: 219659 RVA: 0x0074D7EC File Offset: 0x0074B9EC
		public ITeammateTeleportConfigT UnPack()
		{
			ITeammateTeleportConfigT teammateTeleportConfigT = new ITeammateTeleportConfigT();
			this.UnPackTo(teammateTeleportConfigT);
			return teammateTeleportConfigT;
		}

		// Token: 0x06035A0C RID: 219660 RVA: 0x0074D807 File Offset: 0x0074BA07
		public void UnPackTo(ITeammateTeleportConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035A0D RID: 219661 RVA: 0x0074D818 File Offset: 0x0074BA18
		public static Offset<ITeammateTeleportConfig> Pack(FlatBufferBuilder builder, ITeammateTeleportConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeammateTeleportConfig>);
			}
			return ITeammateTeleportConfig.CreateITeammateTeleportConfig(builder, _o.Type);
		}

		// Token: 0x04012177 RID: 74103
		private Table __p;
	}
}
