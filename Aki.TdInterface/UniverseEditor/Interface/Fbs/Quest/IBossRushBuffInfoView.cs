using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200414E RID: 16718
	public struct IBossRushBuffInfoView : IFlatbufferObject
	{
		// Token: 0x17007135 RID: 28981
		// (get) Token: 0x06016F7F RID: 94079 RVA: 0x00346D22 File Offset: 0x00344F22
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016F80 RID: 94080 RVA: 0x00346D2F File Offset: 0x00344F2F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016F81 RID: 94081 RVA: 0x00346D38 File Offset: 0x00344F38
		public static IBossRushBuffInfoView GetRootAsIBossRushBuffInfoView(ByteBuffer _bb)
		{
			return IBossRushBuffInfoView.GetRootAsIBossRushBuffInfoView(_bb, default(IBossRushBuffInfoView));
		}

		// Token: 0x06016F82 RID: 94082 RVA: 0x00346D54 File Offset: 0x00344F54
		public static IBossRushBuffInfoView GetRootAsIBossRushBuffInfoView(ByteBuffer _bb, IBossRushBuffInfoView obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016F83 RID: 94083 RVA: 0x00346D71 File Offset: 0x00344F71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016F84 RID: 94084 RVA: 0x00346D80 File Offset: 0x00344F80
		public IBossRushBuffInfoView __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007136 RID: 28982
		// (get) Token: 0x06016F85 RID: 94085 RVA: 0x00346D90 File Offset: 0x00344F90
		public EInformationViewType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInformationViewType.LevelPlay;
				}
				return (EInformationViewType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016F86 RID: 94086 RVA: 0x00346DCC File Offset: 0x00344FCC
		public static Offset<IBossRushBuffInfoView> CreateIBossRushBuffInfoView(FlatBufferBuilder builder, EInformationViewType Type = EInformationViewType.LevelPlay)
		{
			builder.StartTable(1);
			IBossRushBuffInfoView.AddType(builder, Type);
			return IBossRushBuffInfoView.EndIBossRushBuffInfoView(builder);
		}

		// Token: 0x06016F87 RID: 94087 RVA: 0x00346DE2 File Offset: 0x00344FE2
		public static void StartIBossRushBuffInfoView(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016F88 RID: 94088 RVA: 0x00346DEB File Offset: 0x00344FEB
		public static void AddType(FlatBufferBuilder builder, EInformationViewType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016F89 RID: 94089 RVA: 0x00346DF6 File Offset: 0x00344FF6
		public static Offset<IBossRushBuffInfoView> EndIBossRushBuffInfoView(FlatBufferBuilder builder)
		{
			return new Offset<IBossRushBuffInfoView>(builder.EndTable());
		}

		// Token: 0x06016F8A RID: 94090 RVA: 0x00346E04 File Offset: 0x00345004
		public IBossRushBuffInfoViewT UnPack()
		{
			IBossRushBuffInfoViewT bossRushBuffInfoViewT = new IBossRushBuffInfoViewT();
			this.UnPackTo(bossRushBuffInfoViewT);
			return bossRushBuffInfoViewT;
		}

		// Token: 0x06016F8B RID: 94091 RVA: 0x00346E1F File Offset: 0x0034501F
		public void UnPackTo(IBossRushBuffInfoViewT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016F8C RID: 94092 RVA: 0x00346E30 File Offset: 0x00345030
		public static Offset<IBossRushBuffInfoView> Pack(FlatBufferBuilder builder, IBossRushBuffInfoViewT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBossRushBuffInfoView>);
			}
			return IBossRushBuffInfoView.CreateIBossRushBuffInfoView(builder, _o.Type);
		}

		// Token: 0x0400BFA4 RID: 49060
		private Table __p;
	}
}
