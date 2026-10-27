using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006627 RID: 26151
	public struct IEasterEggTrackingEvent : IFlatbufferObject
	{
		// Token: 0x1700C247 RID: 49735
		// (get) Token: 0x0602D68D RID: 185997 RVA: 0x00638A8A File Offset: 0x00636C8A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D68E RID: 185998 RVA: 0x00638A97 File Offset: 0x00636C97
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D68F RID: 185999 RVA: 0x00638AA0 File Offset: 0x00636CA0
		public static IEasterEggTrackingEvent GetRootAsIEasterEggTrackingEvent(ByteBuffer _bb)
		{
			return IEasterEggTrackingEvent.GetRootAsIEasterEggTrackingEvent(_bb, default(IEasterEggTrackingEvent));
		}

		// Token: 0x0602D690 RID: 186000 RVA: 0x00638ABC File Offset: 0x00636CBC
		public static IEasterEggTrackingEvent GetRootAsIEasterEggTrackingEvent(ByteBuffer _bb, IEasterEggTrackingEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D691 RID: 186001 RVA: 0x00638AD9 File Offset: 0x00636CD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D692 RID: 186002 RVA: 0x00638AE8 File Offset: 0x00636CE8
		public IEasterEggTrackingEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C248 RID: 49736
		// (get) Token: 0x0602D693 RID: 186003 RVA: 0x00638AF8 File Offset: 0x00636CF8
		public ETrackingEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrackingEventType.EasterEgg;
				}
				return (ETrackingEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C249 RID: 49737
		// (get) Token: 0x0602D694 RID: 186004 RVA: 0x00638B34 File Offset: 0x00636D34
		public int EasterEggId
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

		// Token: 0x0602D695 RID: 186005 RVA: 0x00638B70 File Offset: 0x00636D70
		public static Offset<IEasterEggTrackingEvent> CreateIEasterEggTrackingEvent(FlatBufferBuilder builder, ETrackingEventType Type = ETrackingEventType.EasterEgg, int EasterEggId = 0)
		{
			builder.StartTable(2);
			IEasterEggTrackingEvent.AddEasterEggId(builder, EasterEggId);
			IEasterEggTrackingEvent.AddType(builder, Type);
			return IEasterEggTrackingEvent.EndIEasterEggTrackingEvent(builder);
		}

		// Token: 0x0602D696 RID: 186006 RVA: 0x00638B8D File Offset: 0x00636D8D
		public static void StartIEasterEggTrackingEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D697 RID: 186007 RVA: 0x00638B96 File Offset: 0x00636D96
		public static void AddType(FlatBufferBuilder builder, ETrackingEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D698 RID: 186008 RVA: 0x00638BA1 File Offset: 0x00636DA1
		public static void AddEasterEggId(FlatBufferBuilder builder, int easterEggId)
		{
			builder.AddInt(1, easterEggId, 0);
		}

		// Token: 0x0602D699 RID: 186009 RVA: 0x00638BAC File Offset: 0x00636DAC
		public static Offset<IEasterEggTrackingEvent> EndIEasterEggTrackingEvent(FlatBufferBuilder builder)
		{
			return new Offset<IEasterEggTrackingEvent>(builder.EndTable());
		}

		// Token: 0x0602D69A RID: 186010 RVA: 0x00638BBC File Offset: 0x00636DBC
		public IEasterEggTrackingEventT UnPack()
		{
			IEasterEggTrackingEventT easterEggTrackingEventT = new IEasterEggTrackingEventT();
			this.UnPackTo(easterEggTrackingEventT);
			return easterEggTrackingEventT;
		}

		// Token: 0x0602D69B RID: 186011 RVA: 0x00638BD7 File Offset: 0x00636DD7
		public void UnPackTo(IEasterEggTrackingEventT _o)
		{
			_o.Type = this.Type;
			_o.EasterEggId = this.EasterEggId;
		}

		// Token: 0x0602D69C RID: 186012 RVA: 0x00638BF4 File Offset: 0x00636DF4
		public static Offset<IEasterEggTrackingEvent> Pack(FlatBufferBuilder builder, IEasterEggTrackingEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEasterEggTrackingEvent>);
			}
			return IEasterEggTrackingEvent.CreateIEasterEggTrackingEvent(builder, _o.Type, _o.EasterEggId);
		}

		// Token: 0x04010CB7 RID: 68791
		private Table __p;
	}
}
