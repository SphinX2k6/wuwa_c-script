using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200652B RID: 25899
	public struct IDangoAbyssCreateRewardTreasureBox : IFlatbufferObject
	{
		// Token: 0x1700C095 RID: 49301
		// (get) Token: 0x0602CEF4 RID: 184052 RVA: 0x0062BAB2 File Offset: 0x00629CB2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CEF5 RID: 184053 RVA: 0x0062BABF File Offset: 0x00629CBF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CEF6 RID: 184054 RVA: 0x0062BAC8 File Offset: 0x00629CC8
		public static IDangoAbyssCreateRewardTreasureBox GetRootAsIDangoAbyssCreateRewardTreasureBox(ByteBuffer _bb)
		{
			return IDangoAbyssCreateRewardTreasureBox.GetRootAsIDangoAbyssCreateRewardTreasureBox(_bb, default(IDangoAbyssCreateRewardTreasureBox));
		}

		// Token: 0x0602CEF7 RID: 184055 RVA: 0x0062BAE4 File Offset: 0x00629CE4
		public static IDangoAbyssCreateRewardTreasureBox GetRootAsIDangoAbyssCreateRewardTreasureBox(ByteBuffer _bb, IDangoAbyssCreateRewardTreasureBox obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CEF8 RID: 184056 RVA: 0x0062BB01 File Offset: 0x00629D01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CEF9 RID: 184057 RVA: 0x0062BB10 File Offset: 0x00629D10
		public IDangoAbyssCreateRewardTreasureBox __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602CEFA RID: 184058 RVA: 0x0062BB20 File Offset: 0x00629D20
		public static void StartIDangoAbyssCreateRewardTreasureBox(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602CEFB RID: 184059 RVA: 0x0062BB29 File Offset: 0x00629D29
		public static Offset<IDangoAbyssCreateRewardTreasureBox> EndIDangoAbyssCreateRewardTreasureBox(FlatBufferBuilder builder)
		{
			return new Offset<IDangoAbyssCreateRewardTreasureBox>(builder.EndTable());
		}

		// Token: 0x0602CEFC RID: 184060 RVA: 0x0062BB38 File Offset: 0x00629D38
		public IDangoAbyssCreateRewardTreasureBoxT UnPack()
		{
			IDangoAbyssCreateRewardTreasureBoxT dangoAbyssCreateRewardTreasureBoxT = new IDangoAbyssCreateRewardTreasureBoxT();
			this.UnPackTo(dangoAbyssCreateRewardTreasureBoxT);
			return dangoAbyssCreateRewardTreasureBoxT;
		}

		// Token: 0x0602CEFD RID: 184061 RVA: 0x0062BB53 File Offset: 0x00629D53
		public void UnPackTo(IDangoAbyssCreateRewardTreasureBoxT _o)
		{
		}

		// Token: 0x0602CEFE RID: 184062 RVA: 0x0062BB58 File Offset: 0x00629D58
		public static Offset<IDangoAbyssCreateRewardTreasureBox> Pack(FlatBufferBuilder builder, IDangoAbyssCreateRewardTreasureBoxT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDangoAbyssCreateRewardTreasureBox>);
			}
			IDangoAbyssCreateRewardTreasureBox.StartIDangoAbyssCreateRewardTreasureBox(builder);
			return IDangoAbyssCreateRewardTreasureBox.EndIDangoAbyssCreateRewardTreasureBox(builder);
		}

		// Token: 0x04010B79 RID: 68473
		private Table __p;
	}
}
