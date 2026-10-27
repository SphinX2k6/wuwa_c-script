using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F6F RID: 28527
	public struct ISendClientEvent : IFlatbufferObject
	{
		// Token: 0x1700D3EB RID: 54251
		// (get) Token: 0x0603265D RID: 206429 RVA: 0x006CDA5A File Offset: 0x006CBC5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603265E RID: 206430 RVA: 0x006CDA67 File Offset: 0x006CBC67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603265F RID: 206431 RVA: 0x006CDA70 File Offset: 0x006CBC70
		public static ISendClientEvent GetRootAsISendClientEvent(ByteBuffer _bb)
		{
			return ISendClientEvent.GetRootAsISendClientEvent(_bb, default(ISendClientEvent));
		}

		// Token: 0x06032660 RID: 206432 RVA: 0x006CDA8C File Offset: 0x006CBC8C
		public static ISendClientEvent GetRootAsISendClientEvent(ByteBuffer _bb, ISendClientEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032661 RID: 206433 RVA: 0x006CDAA9 File Offset: 0x006CBCA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032662 RID: 206434 RVA: 0x006CDAB8 File Offset: 0x006CBCB8
		public ISendClientEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3EC RID: 54252
		// (get) Token: 0x06032663 RID: 206435 RVA: 0x006CDAC8 File Offset: 0x006CBCC8
		public string EventName
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032664 RID: 206436 RVA: 0x006CDAFF File Offset: 0x006CBCFF
		public Span<byte> GetEventNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06032665 RID: 206437 RVA: 0x006CDB0E File Offset: 0x006CBD0E
		public byte[] GetEventNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D3ED RID: 54253
		// (get) Token: 0x06032666 RID: 206438 RVA: 0x006CDB1C File Offset: 0x006CBD1C
		public TClientEvent TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TClientEvent.NONE;
				}
				return (TClientEvent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032667 RID: 206439 RVA: 0x006CDB58 File Offset: 0x006CBD58
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032668 RID: 206440 RVA: 0x006CDB9C File Offset: 0x006CBD9C
		public IClientUiEvent TargetAsIClientUiEvent()
		{
			return this.Target<IClientUiEvent>().Value;
		}

		// Token: 0x06032669 RID: 206441 RVA: 0x006CDBB8 File Offset: 0x006CBDB8
		public ISelfClientEvent TargetAsISelfClientEvent()
		{
			return this.Target<ISelfClientEvent>().Value;
		}

		// Token: 0x0603266A RID: 206442 RVA: 0x006CDBD3 File Offset: 0x006CBDD3
		public static Offset<ISendClientEvent> CreateISendClientEvent(FlatBufferBuilder builder, StringOffset EventNameOffset = default(StringOffset), TClientEvent Target_type = TClientEvent.NONE, int TargetOffset = 0)
		{
			builder.StartTable(3);
			ISendClientEvent.AddTarget(builder, TargetOffset);
			ISendClientEvent.AddEventName(builder, EventNameOffset);
			ISendClientEvent.AddTargetType(builder, Target_type);
			return ISendClientEvent.EndISendClientEvent(builder);
		}

		// Token: 0x0603266B RID: 206443 RVA: 0x006CDBF7 File Offset: 0x006CBDF7
		public static void StartISendClientEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603266C RID: 206444 RVA: 0x006CDC00 File Offset: 0x006CBE00
		public static void AddEventName(FlatBufferBuilder builder, StringOffset eventNameOffset)
		{
			builder.AddOffset(0, eventNameOffset.Value, 0);
		}

		// Token: 0x0603266D RID: 206445 RVA: 0x006CDC10 File Offset: 0x006CBE10
		public static void AddTargetType(FlatBufferBuilder builder, TClientEvent targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0603266E RID: 206446 RVA: 0x006CDC1B File Offset: 0x006CBE1B
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0603266F RID: 206447 RVA: 0x006CDC26 File Offset: 0x006CBE26
		public static Offset<ISendClientEvent> EndISendClientEvent(FlatBufferBuilder builder)
		{
			return new Offset<ISendClientEvent>(builder.EndTable());
		}

		// Token: 0x06032670 RID: 206448 RVA: 0x006CDC34 File Offset: 0x006CBE34
		public ISendClientEventT UnPack()
		{
			ISendClientEventT sendClientEventT = new ISendClientEventT();
			this.UnPackTo(sendClientEventT);
			return sendClientEventT;
		}

		// Token: 0x06032671 RID: 206449 RVA: 0x006CDC50 File Offset: 0x006CBE50
		public void UnPackTo(ISendClientEventT _o)
		{
			_o.EventName = this.EventName;
			_o.Target = new TClientEventUnion();
			_o.Target.Type = this.TargetType;
			TClientEvent targetType = this.TargetType;
			if (targetType == TClientEvent.IClientUiEvent)
			{
				_o.Target.Value = ((this.Target<IClientUiEvent>() != null) ? this.Target<IClientUiEvent>().Value.UnPack() : null);
				return;
			}
			if (targetType != TClientEvent.ISelfClientEvent)
			{
				return;
			}
			_o.Target.Value = ((this.Target<ISelfClientEvent>() != null) ? this.Target<ISelfClientEvent>().Value.UnPack() : null);
		}

		// Token: 0x06032672 RID: 206450 RVA: 0x006CDD00 File Offset: 0x006CBF00
		public static Offset<ISendClientEvent> Pack(FlatBufferBuilder builder, ISendClientEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISendClientEvent>);
			}
			StringOffset eventNameOffset = (_o.EventName == null) ? default(StringOffset) : builder.CreateString(_o.EventName);
			TClientEvent target_type = (_o.Target == null) ? TClientEvent.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TClientEventUnion.Pack(builder, _o.Target);
			return ISendClientEvent.CreateISendClientEvent(builder, eventNameOffset, target_type, targetOffset);
		}

		// Token: 0x0401196D RID: 72045
		private Table __p;
	}
}
