using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078C6 RID: 30918
	public struct IShowTalkFrameEvent : IFlatbufferObject
	{
		// Token: 0x1700E2E4 RID: 58084
		// (get) Token: 0x060366E5 RID: 222949 RVA: 0x00749F3C File Offset: 0x0074813C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060366E6 RID: 222950 RVA: 0x00749F49 File Offset: 0x00748149
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060366E7 RID: 222951 RVA: 0x00749F50 File Offset: 0x00748150
		public static IShowTalkFrameEvent GetRootAsIShowTalkFrameEvent(ByteBuffer _bb)
		{
			return IShowTalkFrameEvent.GetRootAsIShowTalkFrameEvent(_bb, default(IShowTalkFrameEvent));
		}

		// Token: 0x060366E8 RID: 222952 RVA: 0x00749F6C File Offset: 0x0074816C
		public static IShowTalkFrameEvent GetRootAsIShowTalkFrameEvent(ByteBuffer _bb, IShowTalkFrameEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060366E9 RID: 222953 RVA: 0x00749F89 File Offset: 0x00748189
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060366EA RID: 222954 RVA: 0x00749F98 File Offset: 0x00748198
		public IShowTalkFrameEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2E5 RID: 58085
		// (get) Token: 0x060366EB RID: 222955 RVA: 0x00749FA8 File Offset: 0x007481A8
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

		// Token: 0x1700E2E6 RID: 58086
		// (get) Token: 0x060366EC RID: 222956 RVA: 0x0074A008 File Offset: 0x00748208
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

		// Token: 0x060366ED RID: 222957 RVA: 0x0074A065 File Offset: 0x00748265
		public static Offset<IShowTalkFrameEvent> CreateIShowTalkFrameEvent(FlatBufferBuilder builder, Offset<ISequenceFrameEvent> FrameEventOffset = default(Offset<ISequenceFrameEvent>), Offset<IShowTalkFrameEventPosition> PositionOffset = default(Offset<IShowTalkFrameEventPosition>))
		{
			builder.StartTable(2);
			IShowTalkFrameEvent.AddPosition(builder, PositionOffset);
			IShowTalkFrameEvent.AddFrameEvent(builder, FrameEventOffset);
			return IShowTalkFrameEvent.EndIShowTalkFrameEvent(builder);
		}

		// Token: 0x060366EE RID: 222958 RVA: 0x0074A082 File Offset: 0x00748282
		public static void StartIShowTalkFrameEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060366EF RID: 222959 RVA: 0x0074A08B File Offset: 0x0074828B
		public static void AddFrameEvent(FlatBufferBuilder builder, Offset<ISequenceFrameEvent> frameEventOffset)
		{
			builder.AddOffset(0, frameEventOffset.Value, 0);
		}

		// Token: 0x060366F0 RID: 222960 RVA: 0x0074A09B File Offset: 0x0074829B
		public static void AddPosition(FlatBufferBuilder builder, Offset<IShowTalkFrameEventPosition> positionOffset)
		{
			builder.AddOffset(1, positionOffset.Value, 0);
		}

		// Token: 0x060366F1 RID: 222961 RVA: 0x0074A0AB File Offset: 0x007482AB
		public static Offset<IShowTalkFrameEvent> EndIShowTalkFrameEvent(FlatBufferBuilder builder)
		{
			return new Offset<IShowTalkFrameEvent>(builder.EndTable());
		}

		// Token: 0x060366F2 RID: 222962 RVA: 0x0074A0B8 File Offset: 0x007482B8
		public IShowTalkFrameEventT UnPack()
		{
			IShowTalkFrameEventT showTalkFrameEventT = new IShowTalkFrameEventT();
			this.UnPackTo(showTalkFrameEventT);
			return showTalkFrameEventT;
		}

		// Token: 0x060366F3 RID: 222963 RVA: 0x0074A0D4 File Offset: 0x007482D4
		public void UnPackTo(IShowTalkFrameEventT _o)
		{
			_o.FrameEvent = ((this.FrameEvent != null) ? this.FrameEvent.Value.UnPack() : null);
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
		}

		// Token: 0x060366F4 RID: 222964 RVA: 0x0074A140 File Offset: 0x00748340
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

		// Token: 0x04012B76 RID: 76662
		private Table __p;
	}
}
