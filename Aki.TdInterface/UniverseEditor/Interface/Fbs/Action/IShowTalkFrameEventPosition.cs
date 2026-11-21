using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078C9 RID: 30921
	public struct IShowTalkFrameEventPosition : IFlatbufferObject
	{
		// Token: 0x1700E2E9 RID: 58089
		// (get) Token: 0x060366FB RID: 222971 RVA: 0x0074A247 File Offset: 0x00748447
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060366FC RID: 222972 RVA: 0x0074A254 File Offset: 0x00748454
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060366FD RID: 222973 RVA: 0x0074A25C File Offset: 0x0074845C
		public static IShowTalkFrameEventPosition GetRootAsIShowTalkFrameEventPosition(ByteBuffer _bb)
		{
			return IShowTalkFrameEventPosition.GetRootAsIShowTalkFrameEventPosition(_bb, default(IShowTalkFrameEventPosition));
		}

		// Token: 0x060366FE RID: 222974 RVA: 0x0074A278 File Offset: 0x00748478
		public static IShowTalkFrameEventPosition GetRootAsIShowTalkFrameEventPosition(ByteBuffer _bb, IShowTalkFrameEventPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060366FF RID: 222975 RVA: 0x0074A295 File Offset: 0x00748495
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036700 RID: 222976 RVA: 0x0074A2A4 File Offset: 0x007484A4
		public IShowTalkFrameEventPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2EA RID: 58090
		// (get) Token: 0x06036701 RID: 222977 RVA: 0x0074A2B4 File Offset: 0x007484B4
		public int TalkItemId
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

		// Token: 0x1700E2EB RID: 58091
		// (get) Token: 0x06036702 RID: 222978 RVA: 0x0074A2F0 File Offset: 0x007484F0
		public int Offset
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

		// Token: 0x06036703 RID: 222979 RVA: 0x0074A32C File Offset: 0x0074852C
		public static Offset<IShowTalkFrameEventPosition> CreateIShowTalkFrameEventPosition(FlatBufferBuilder builder, int TalkItemId = 0, int Offset = 0)
		{
			builder.StartTable(2);
			IShowTalkFrameEventPosition.AddOffset(builder, Offset);
			IShowTalkFrameEventPosition.AddTalkItemId(builder, TalkItemId);
			return IShowTalkFrameEventPosition.EndIShowTalkFrameEventPosition(builder);
		}

		// Token: 0x06036704 RID: 222980 RVA: 0x0074A349 File Offset: 0x00748549
		public static void StartIShowTalkFrameEventPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036705 RID: 222981 RVA: 0x0074A352 File Offset: 0x00748552
		public static void AddTalkItemId(FlatBufferBuilder builder, int talkItemId)
		{
			builder.AddInt(0, talkItemId, 0);
		}

		// Token: 0x06036706 RID: 222982 RVA: 0x0074A35D File Offset: 0x0074855D
		public static void AddOffset(FlatBufferBuilder builder, int offset)
		{
			builder.AddInt(1, offset, 0);
		}

		// Token: 0x06036707 RID: 222983 RVA: 0x0074A368 File Offset: 0x00748568
		public static Offset<IShowTalkFrameEventPosition> EndIShowTalkFrameEventPosition(FlatBufferBuilder builder)
		{
			return new Offset<IShowTalkFrameEventPosition>(builder.EndTable());
		}

		// Token: 0x06036708 RID: 222984 RVA: 0x0074A378 File Offset: 0x00748578
		public IShowTalkFrameEventPositionT UnPack()
		{
			IShowTalkFrameEventPositionT showTalkFrameEventPositionT = new IShowTalkFrameEventPositionT();
			this.UnPackTo(showTalkFrameEventPositionT);
			return showTalkFrameEventPositionT;
		}

		// Token: 0x06036709 RID: 222985 RVA: 0x0074A393 File Offset: 0x00748593
		public void UnPackTo(IShowTalkFrameEventPositionT _o)
		{
			_o.TalkItemId = this.TalkItemId;
			_o.Offset = this.Offset;
		}

		// Token: 0x0603670A RID: 222986 RVA: 0x0074A3B0 File Offset: 0x007485B0
		public static Offset<IShowTalkFrameEventPosition> Pack(FlatBufferBuilder builder, IShowTalkFrameEventPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTalkFrameEventPosition>);
			}
			return IShowTalkFrameEventPosition.CreateIShowTalkFrameEventPosition(builder, _o.TalkItemId, _o.Offset);
		}

		// Token: 0x04012B79 RID: 76665
		private Table __p;
	}
}
