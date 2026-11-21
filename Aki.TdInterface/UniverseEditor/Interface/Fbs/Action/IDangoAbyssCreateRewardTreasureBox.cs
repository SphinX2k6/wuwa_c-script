using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B99 RID: 27545
	public struct IDangoAbyssCreateRewardTreasureBox : IFlatbufferObject
	{
		// Token: 0x1700CA27 RID: 51751
		// (get) Token: 0x0602F692 RID: 194194 RVA: 0x00677F5E File Offset: 0x0067615E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F693 RID: 194195 RVA: 0x00677F6B File Offset: 0x0067616B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F694 RID: 194196 RVA: 0x00677F74 File Offset: 0x00676174
		public static IDangoAbyssCreateRewardTreasureBox GetRootAsIDangoAbyssCreateRewardTreasureBox(ByteBuffer _bb)
		{
			return IDangoAbyssCreateRewardTreasureBox.GetRootAsIDangoAbyssCreateRewardTreasureBox(_bb, default(IDangoAbyssCreateRewardTreasureBox));
		}

		// Token: 0x0602F695 RID: 194197 RVA: 0x00677F90 File Offset: 0x00676190
		public static IDangoAbyssCreateRewardTreasureBox GetRootAsIDangoAbyssCreateRewardTreasureBox(ByteBuffer _bb, IDangoAbyssCreateRewardTreasureBox obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F696 RID: 194198 RVA: 0x00677FAD File Offset: 0x006761AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F697 RID: 194199 RVA: 0x00677FBC File Offset: 0x006761BC
		public IDangoAbyssCreateRewardTreasureBox __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602F698 RID: 194200 RVA: 0x00677FCC File Offset: 0x006761CC
		public static void StartIDangoAbyssCreateRewardTreasureBox(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602F699 RID: 194201 RVA: 0x00677FD5 File Offset: 0x006761D5
		public static Offset<IDangoAbyssCreateRewardTreasureBox> EndIDangoAbyssCreateRewardTreasureBox(FlatBufferBuilder builder)
		{
			return new Offset<IDangoAbyssCreateRewardTreasureBox>(builder.EndTable());
		}

		// Token: 0x0602F69A RID: 194202 RVA: 0x00677FE4 File Offset: 0x006761E4
		public IDangoAbyssCreateRewardTreasureBoxT UnPack()
		{
			IDangoAbyssCreateRewardTreasureBoxT dangoAbyssCreateRewardTreasureBoxT = new IDangoAbyssCreateRewardTreasureBoxT();
			this.UnPackTo(dangoAbyssCreateRewardTreasureBoxT);
			return dangoAbyssCreateRewardTreasureBoxT;
		}

		// Token: 0x0602F69B RID: 194203 RVA: 0x00677FFF File Offset: 0x006761FF
		public void UnPackTo(IDangoAbyssCreateRewardTreasureBoxT _o)
		{
		}

		// Token: 0x0602F69C RID: 194204 RVA: 0x00678004 File Offset: 0x00676204
		public static Offset<IDangoAbyssCreateRewardTreasureBox> Pack(FlatBufferBuilder builder, IDangoAbyssCreateRewardTreasureBoxT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDangoAbyssCreateRewardTreasureBox>);
			}
			IDangoAbyssCreateRewardTreasureBox.StartIDangoAbyssCreateRewardTreasureBox(builder);
			return IDangoAbyssCreateRewardTreasureBox.EndIDangoAbyssCreateRewardTreasureBox(builder);
		}

		// Token: 0x04011992 RID: 72082
		private Table __p;
	}
}
