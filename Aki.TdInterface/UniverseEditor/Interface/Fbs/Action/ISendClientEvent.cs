using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007735 RID: 30517
	public struct ISendClientEvent : IFlatbufferObject
	{
		// Token: 0x1700DFBA RID: 57274
		// (get) Token: 0x060358AD RID: 219309 RVA: 0x0072D411 File Offset: 0x0072B611
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060358AE RID: 219310 RVA: 0x0072D41E File Offset: 0x0072B61E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060358AF RID: 219311 RVA: 0x0072D428 File Offset: 0x0072B628
		public static ISendClientEvent GetRootAsISendClientEvent(ByteBuffer _bb)
		{
			return ISendClientEvent.GetRootAsISendClientEvent(_bb, default(ISendClientEvent));
		}

		// Token: 0x060358B0 RID: 219312 RVA: 0x0072D444 File Offset: 0x0072B644
		public static ISendClientEvent GetRootAsISendClientEvent(ByteBuffer _bb, ISendClientEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060358B1 RID: 219313 RVA: 0x0072D461 File Offset: 0x0072B661
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060358B2 RID: 219314 RVA: 0x0072D470 File Offset: 0x0072B670
		public ISendClientEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DFBB RID: 57275
		// (get) Token: 0x060358B3 RID: 219315 RVA: 0x0072D480 File Offset: 0x0072B680
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

		// Token: 0x060358B4 RID: 219316 RVA: 0x0072D4B7 File Offset: 0x0072B6B7
		public Span<byte> GetEventNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060358B5 RID: 219317 RVA: 0x0072D4C6 File Offset: 0x0072B6C6
		public byte[] GetEventNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700DFBC RID: 57276
		// (get) Token: 0x060358B6 RID: 219318 RVA: 0x0072D4D4 File Offset: 0x0072B6D4
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

		// Token: 0x060358B7 RID: 219319 RVA: 0x0072D510 File Offset: 0x0072B710
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060358B8 RID: 219320 RVA: 0x0072D554 File Offset: 0x0072B754
		public IClientUiEvent TargetAsIClientUiEvent()
		{
			return this.Target<IClientUiEvent>().Value;
		}

		// Token: 0x060358B9 RID: 219321 RVA: 0x0072D570 File Offset: 0x0072B770
		public ISelfClientEvent TargetAsISelfClientEvent()
		{
			return this.Target<ISelfClientEvent>().Value;
		}

		// Token: 0x060358BA RID: 219322 RVA: 0x0072D58B File Offset: 0x0072B78B
		public static Offset<ISendClientEvent> CreateISendClientEvent(FlatBufferBuilder builder, StringOffset EventNameOffset = default(StringOffset), TClientEvent Target_type = TClientEvent.NONE, int TargetOffset = 0)
		{
			builder.StartTable(3);
			ISendClientEvent.AddTarget(builder, TargetOffset);
			ISendClientEvent.AddEventName(builder, EventNameOffset);
			ISendClientEvent.AddTargetType(builder, Target_type);
			return ISendClientEvent.EndISendClientEvent(builder);
		}

		// Token: 0x060358BB RID: 219323 RVA: 0x0072D5AF File Offset: 0x0072B7AF
		public static void StartISendClientEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060358BC RID: 219324 RVA: 0x0072D5B8 File Offset: 0x0072B7B8
		public static void AddEventName(FlatBufferBuilder builder, StringOffset eventNameOffset)
		{
			builder.AddOffset(0, eventNameOffset.Value, 0);
		}

		// Token: 0x060358BD RID: 219325 RVA: 0x0072D5C8 File Offset: 0x0072B7C8
		public static void AddTargetType(FlatBufferBuilder builder, TClientEvent targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x060358BE RID: 219326 RVA: 0x0072D5D3 File Offset: 0x0072B7D3
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x060358BF RID: 219327 RVA: 0x0072D5DE File Offset: 0x0072B7DE
		public static Offset<ISendClientEvent> EndISendClientEvent(FlatBufferBuilder builder)
		{
			return new Offset<ISendClientEvent>(builder.EndTable());
		}

		// Token: 0x060358C0 RID: 219328 RVA: 0x0072D5EC File Offset: 0x0072B7EC
		public ISendClientEventT UnPack()
		{
			ISendClientEventT sendClientEventT = new ISendClientEventT();
			this.UnPackTo(sendClientEventT);
			return sendClientEventT;
		}

		// Token: 0x060358C1 RID: 219329 RVA: 0x0072D608 File Offset: 0x0072B808
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

		// Token: 0x060358C2 RID: 219330 RVA: 0x0072D6B8 File Offset: 0x0072B8B8
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

		// Token: 0x0401294F RID: 76111
		private Table __p;
	}
}
