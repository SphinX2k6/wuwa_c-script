using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069D5 RID: 27093
	public struct IJumpTalk : IFlatbufferObject
	{
		// Token: 0x1700C90D RID: 51469
		// (get) Token: 0x0602F5CB RID: 193995 RVA: 0x006732B7 File Offset: 0x006714B7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F5CC RID: 193996 RVA: 0x006732C4 File Offset: 0x006714C4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F5CD RID: 193997 RVA: 0x006732CC File Offset: 0x006714CC
		public static IJumpTalk GetRootAsIJumpTalk(ByteBuffer _bb)
		{
			return IJumpTalk.GetRootAsIJumpTalk(_bb, default(IJumpTalk));
		}

		// Token: 0x0602F5CE RID: 193998 RVA: 0x006732E8 File Offset: 0x006714E8
		public static IJumpTalk GetRootAsIJumpTalk(ByteBuffer _bb, IJumpTalk obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F5CF RID: 193999 RVA: 0x00673305 File Offset: 0x00671505
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F5D0 RID: 194000 RVA: 0x00673314 File Offset: 0x00671514
		public IJumpTalk __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C90E RID: 51470
		// (get) Token: 0x0602F5D1 RID: 194001 RVA: 0x00673324 File Offset: 0x00671524
		public int TalkId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F5D2 RID: 194002 RVA: 0x00673360 File Offset: 0x00671560
		public static Offset<IJumpTalk> CreateIJumpTalk(FlatBufferBuilder builder, int TalkId = 0)
		{
			builder.StartTable(1);
			IJumpTalk.AddTalkId(builder, TalkId);
			return IJumpTalk.EndIJumpTalk(builder);
		}

		// Token: 0x0602F5D3 RID: 194003 RVA: 0x00673376 File Offset: 0x00671576
		public static void StartIJumpTalk(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F5D4 RID: 194004 RVA: 0x0067337F File Offset: 0x0067157F
		public static void AddTalkId(FlatBufferBuilder builder, int talkId)
		{
			builder.AddInt(0, talkId, 0);
		}

		// Token: 0x0602F5D5 RID: 194005 RVA: 0x0067338A File Offset: 0x0067158A
		public static Offset<IJumpTalk> EndIJumpTalk(FlatBufferBuilder builder)
		{
			return new Offset<IJumpTalk>(builder.EndTable());
		}

		// Token: 0x0602F5D6 RID: 194006 RVA: 0x00673398 File Offset: 0x00671598
		public IJumpTalkT UnPack()
		{
			IJumpTalkT jumpTalkT = new IJumpTalkT();
			this.UnPackTo(jumpTalkT);
			return jumpTalkT;
		}

		// Token: 0x0602F5D7 RID: 194007 RVA: 0x006733B3 File Offset: 0x006715B3
		public void UnPackTo(IJumpTalkT _o)
		{
			_o.TalkId = this.TalkId;
		}

		// Token: 0x0602F5D8 RID: 194008 RVA: 0x006733C4 File Offset: 0x006715C4
		public static Offset<IJumpTalk> Pack(FlatBufferBuilder builder, IJumpTalkT _o)
		{
			if (_o == null)
			{
				return default(Offset<IJumpTalk>);
			}
			return IJumpTalk.CreateIJumpTalk(builder, _o.TalkId);
		}

		// Token: 0x04011195 RID: 70037
		private Table __p;
	}
}
