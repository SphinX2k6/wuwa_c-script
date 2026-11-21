using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C98 RID: 27800
	public struct IEasterEggTrackingEvent : IFlatbufferObject
	{
		// Token: 0x1700CBE5 RID: 52197
		// (get) Token: 0x0602FE5E RID: 196190 RVA: 0x006855F2 File Offset: 0x006837F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FE5F RID: 196191 RVA: 0x006855FF File Offset: 0x006837FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FE60 RID: 196192 RVA: 0x00685608 File Offset: 0x00683808
		public static IEasterEggTrackingEvent GetRootAsIEasterEggTrackingEvent(ByteBuffer _bb)
		{
			return IEasterEggTrackingEvent.GetRootAsIEasterEggTrackingEvent(_bb, default(IEasterEggTrackingEvent));
		}

		// Token: 0x0602FE61 RID: 196193 RVA: 0x00685624 File Offset: 0x00683824
		public static IEasterEggTrackingEvent GetRootAsIEasterEggTrackingEvent(ByteBuffer _bb, IEasterEggTrackingEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FE62 RID: 196194 RVA: 0x00685641 File Offset: 0x00683841
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FE63 RID: 196195 RVA: 0x00685650 File Offset: 0x00683850
		public IEasterEggTrackingEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CBE6 RID: 52198
		// (get) Token: 0x0602FE64 RID: 196196 RVA: 0x00685660 File Offset: 0x00683860
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

		// Token: 0x1700CBE7 RID: 52199
		// (get) Token: 0x0602FE65 RID: 196197 RVA: 0x0068569C File Offset: 0x0068389C
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

		// Token: 0x0602FE66 RID: 196198 RVA: 0x006856D8 File Offset: 0x006838D8
		public static Offset<IEasterEggTrackingEvent> CreateIEasterEggTrackingEvent(FlatBufferBuilder builder, ETrackingEventType Type = ETrackingEventType.EasterEgg, int EasterEggId = 0)
		{
			builder.StartTable(2);
			IEasterEggTrackingEvent.AddEasterEggId(builder, EasterEggId);
			IEasterEggTrackingEvent.AddType(builder, Type);
			return IEasterEggTrackingEvent.EndIEasterEggTrackingEvent(builder);
		}

		// Token: 0x0602FE67 RID: 196199 RVA: 0x006856F5 File Offset: 0x006838F5
		public static void StartIEasterEggTrackingEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602FE68 RID: 196200 RVA: 0x006856FE File Offset: 0x006838FE
		public static void AddType(FlatBufferBuilder builder, ETrackingEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FE69 RID: 196201 RVA: 0x00685709 File Offset: 0x00683909
		public static void AddEasterEggId(FlatBufferBuilder builder, int easterEggId)
		{
			builder.AddInt(1, easterEggId, 0);
		}

		// Token: 0x0602FE6A RID: 196202 RVA: 0x00685714 File Offset: 0x00683914
		public static Offset<IEasterEggTrackingEvent> EndIEasterEggTrackingEvent(FlatBufferBuilder builder)
		{
			return new Offset<IEasterEggTrackingEvent>(builder.EndTable());
		}

		// Token: 0x0602FE6B RID: 196203 RVA: 0x00685724 File Offset: 0x00683924
		public IEasterEggTrackingEventT UnPack()
		{
			IEasterEggTrackingEventT easterEggTrackingEventT = new IEasterEggTrackingEventT();
			this.UnPackTo(easterEggTrackingEventT);
			return easterEggTrackingEventT;
		}

		// Token: 0x0602FE6C RID: 196204 RVA: 0x0068573F File Offset: 0x0068393F
		public void UnPackTo(IEasterEggTrackingEventT _o)
		{
			_o.Type = this.Type;
			_o.EasterEggId = this.EasterEggId;
		}

		// Token: 0x0602FE6D RID: 196205 RVA: 0x0068575C File Offset: 0x0068395C
		public static Offset<IEasterEggTrackingEvent> Pack(FlatBufferBuilder builder, IEasterEggTrackingEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEasterEggTrackingEvent>);
			}
			return IEasterEggTrackingEvent.CreateIEasterEggTrackingEvent(builder, _o.Type, _o.EasterEggId);
		}

		// Token: 0x04011AD2 RID: 72402
		private Table __p;
	}
}
