using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070FA RID: 28922
	public struct IShowTalkFrameEvent : IFlatbufferObject
	{
		// Token: 0x1700D701 RID: 55041
		// (get) Token: 0x06033443 RID: 209987 RVA: 0x006E9930 File Offset: 0x006E7B30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033444 RID: 209988 RVA: 0x006E993D File Offset: 0x006E7B3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033445 RID: 209989 RVA: 0x006E9944 File Offset: 0x006E7B44
		public static IShowTalkFrameEvent GetRootAsIShowTalkFrameEvent(ByteBuffer _bb)
		{
			return IShowTalkFrameEvent.GetRootAsIShowTalkFrameEvent(_bb, default(IShowTalkFrameEvent));
		}

		// Token: 0x06033446 RID: 209990 RVA: 0x006E9960 File Offset: 0x006E7B60
		public static IShowTalkFrameEvent GetRootAsIShowTalkFrameEvent(ByteBuffer _bb, IShowTalkFrameEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033447 RID: 209991 RVA: 0x006E997D File Offset: 0x006E7B7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033448 RID: 209992 RVA: 0x006E998C File Offset: 0x006E7B8C
		public IShowTalkFrameEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D702 RID: 55042
		// (get) Token: 0x06033449 RID: 209993 RVA: 0x006E999C File Offset: 0x006E7B9C
		public ISequenceFrameEvent? FrameEvent
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ISequenceFrameEvent?(default(ISequenceFrameEvent).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D703 RID: 55043
		// (get) Token: 0x0603344A RID: 209994 RVA: 0x006E99FC File Offset: 0x006E7BFC
		public IShowTalkFrameEventPosition? Position
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IShowTalkFrameEventPosition?(default(IShowTalkFrameEventPosition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0603344B RID: 209995 RVA: 0x006E9A59 File Offset: 0x006E7C59
		public static Offset<IShowTalkFrameEvent> CreateIShowTalkFrameEvent(FlatBufferBuilder builder, Offset<ISequenceFrameEvent> FrameEventOffset = default(Offset<ISequenceFrameEvent>), Offset<IShowTalkFrameEventPosition> PositionOffset = default(Offset<IShowTalkFrameEventPosition>))
		{
			builder.StartTable(2);
			IShowTalkFrameEvent.AddPosition(builder, PositionOffset);
			IShowTalkFrameEvent.AddFrameEvent(builder, FrameEventOffset);
			return IShowTalkFrameEvent.EndIShowTalkFrameEvent(builder);
		}

		// Token: 0x0603344C RID: 209996 RVA: 0x006E9A76 File Offset: 0x006E7C76
		public static void StartIShowTalkFrameEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603344D RID: 209997 RVA: 0x006E9A7F File Offset: 0x006E7C7F
		public static void AddFrameEvent(FlatBufferBuilder builder, Offset<ISequenceFrameEvent> frameEventOffset)
		{
			builder.AddOffset(0, frameEventOffset.Value, 0);
		}

		// Token: 0x0603344E RID: 209998 RVA: 0x006E9A8F File Offset: 0x006E7C8F
		public static void AddPosition(FlatBufferBuilder builder, Offset<IShowTalkFrameEventPosition> positionOffset)
		{
			builder.AddOffset(1, positionOffset.Value, 0);
		}

		// Token: 0x0603344F RID: 209999 RVA: 0x006E9A9F File Offset: 0x006E7C9F
		public static Offset<IShowTalkFrameEvent> EndIShowTalkFrameEvent(FlatBufferBuilder builder)
		{
			return new Offset<IShowTalkFrameEvent>(builder.EndTable());
		}

		// Token: 0x06033450 RID: 210000 RVA: 0x006E9AAC File Offset: 0x006E7CAC
		public IShowTalkFrameEventT UnPack()
		{
			IShowTalkFrameEventT showTalkFrameEventT = new IShowTalkFrameEventT();
			this.UnPackTo(showTalkFrameEventT);
			return showTalkFrameEventT;
		}

		// Token: 0x06033451 RID: 210001 RVA: 0x006E9AC8 File Offset: 0x006E7CC8
		public void UnPackTo(IShowTalkFrameEventT _o)
		{
			_o.FrameEvent = ((this.FrameEvent != null) ? this.FrameEvent.Value.UnPack() : null);
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
		}

		// Token: 0x06033452 RID: 210002 RVA: 0x006E9B34 File Offset: 0x006E7D34
		public static Offset<IShowTalkFrameEvent> Pack(FlatBufferBuilder builder, IShowTalkFrameEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTalkFrameEvent>);
			}
			Offset<ISequenceFrameEvent> frameEventOffset = (_o.FrameEvent == null) ? default(Offset<ISequenceFrameEvent>) : ISequenceFrameEvent.Pack(builder, _o.FrameEvent);
			Offset<IShowTalkFrameEventPosition> positionOffset = (_o.Position == null) ? default(Offset<IShowTalkFrameEventPosition>) : IShowTalkFrameEventPosition.Pack(builder, _o.Position);
			return IShowTalkFrameEvent.CreateIShowTalkFrameEvent(builder, frameEventOffset, positionOffset);
		}

		// Token: 0x04011B88 RID: 72584
		private Table __p;
	}
}
