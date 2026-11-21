using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007085 RID: 28805
	public struct IJumpTalk : IFlatbufferObject
	{
		// Token: 0x1700D30D RID: 54029
		// (get) Token: 0x06031F8B RID: 204683 RVA: 0x006C360F File Offset: 0x006C180F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031F8C RID: 204684 RVA: 0x006C361C File Offset: 0x006C181C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031F8D RID: 204685 RVA: 0x006C3624 File Offset: 0x006C1824
		public static IJumpTalk GetRootAsIJumpTalk(ByteBuffer _bb)
		{
			return IJumpTalk.GetRootAsIJumpTalk(_bb, default(IJumpTalk));
		}

		// Token: 0x06031F8E RID: 204686 RVA: 0x006C3640 File Offset: 0x006C1840
		public static IJumpTalk GetRootAsIJumpTalk(ByteBuffer _bb, IJumpTalk obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031F8F RID: 204687 RVA: 0x006C365D File Offset: 0x006C185D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031F90 RID: 204688 RVA: 0x006C366C File Offset: 0x006C186C
		public IJumpTalk __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D30E RID: 54030
		// (get) Token: 0x06031F91 RID: 204689 RVA: 0x006C367C File Offset: 0x006C187C
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

		// Token: 0x06031F92 RID: 204690 RVA: 0x006C36B8 File Offset: 0x006C18B8
		public static Offset<IJumpTalk> CreateIJumpTalk(FlatBufferBuilder builder, int TalkId = 0)
		{
			builder.StartTable(1);
			IJumpTalk.AddTalkId(builder, TalkId);
			return IJumpTalk.EndIJumpTalk(builder);
		}

		// Token: 0x06031F93 RID: 204691 RVA: 0x006C36CE File Offset: 0x006C18CE
		public static void StartIJumpTalk(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031F94 RID: 204692 RVA: 0x006C36D7 File Offset: 0x006C18D7
		public static void AddTalkId(FlatBufferBuilder builder, int talkId)
		{
			builder.AddInt(0, talkId, 0);
		}

		// Token: 0x06031F95 RID: 204693 RVA: 0x006C36E2 File Offset: 0x006C18E2
		public static Offset<IJumpTalk> EndIJumpTalk(FlatBufferBuilder builder)
		{
			return new Offset<IJumpTalk>(builder.EndTable());
		}

		// Token: 0x06031F96 RID: 204694 RVA: 0x006C36F0 File Offset: 0x006C18F0
		public IJumpTalkT UnPack()
		{
			IJumpTalkT jumpTalkT = new IJumpTalkT();
			this.UnPackTo(jumpTalkT);
			return jumpTalkT;
		}

		// Token: 0x06031F97 RID: 204695 RVA: 0x006C370B File Offset: 0x006C190B
		public void UnPackTo(IJumpTalkT _o)
		{
			_o.TalkId = this.TalkId;
		}

		// Token: 0x06031F98 RID: 204696 RVA: 0x006C371C File Offset: 0x006C191C
		public static Offset<IJumpTalk> Pack(FlatBufferBuilder builder, IJumpTalkT _o)
		{
			if (_o == null)
			{
				return default(Offset<IJumpTalk>);
			}
			return IJumpTalk.CreateIJumpTalk(builder, _o.TalkId);
		}

		// Token: 0x04011FFF RID: 73727
		private Table __p;
	}
}
