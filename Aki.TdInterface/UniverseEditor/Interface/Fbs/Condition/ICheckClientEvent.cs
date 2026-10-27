using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049A0 RID: 18848
	public struct ICheckClientEvent : IFlatbufferObject
	{
		// Token: 0x17008834 RID: 34868
		// (get) Token: 0x0601D66E RID: 120430 RVA: 0x00424C50 File Offset: 0x00422E50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D66F RID: 120431 RVA: 0x00424C5D File Offset: 0x00422E5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D670 RID: 120432 RVA: 0x00424C64 File Offset: 0x00422E64
		public static ICheckClientEvent GetRootAsICheckClientEvent(ByteBuffer _bb)
		{
			return ICheckClientEvent.GetRootAsICheckClientEvent(_bb, default(ICheckClientEvent));
		}

		// Token: 0x0601D671 RID: 120433 RVA: 0x00424C80 File Offset: 0x00422E80
		public static ICheckClientEvent GetRootAsICheckClientEvent(ByteBuffer _bb, ICheckClientEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D672 RID: 120434 RVA: 0x00424C9D File Offset: 0x00422E9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D673 RID: 120435 RVA: 0x00424CAC File Offset: 0x00422EAC
		public ICheckClientEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008835 RID: 34869
		// (get) Token: 0x0601D674 RID: 120436 RVA: 0x00424CBC File Offset: 0x00422EBC
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008836 RID: 34870
		// (get) Token: 0x0601D675 RID: 120437 RVA: 0x00424CF8 File Offset: 0x00422EF8
		public string EventName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D676 RID: 120438 RVA: 0x00424D2F File Offset: 0x00422F2F
		public Span<byte> GetEventNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601D677 RID: 120439 RVA: 0x00424D3E File Offset: 0x00422F3E
		public byte[] GetEventNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008837 RID: 34871
		// (get) Token: 0x0601D678 RID: 120440 RVA: 0x00424D4C File Offset: 0x00422F4C
		public ISelfClientEvent? ListenerTarget
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ISelfClientEvent?(default(ISelfClientEvent).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601D679 RID: 120441 RVA: 0x00424DA9 File Offset: 0x00422FA9
		public static Offset<ICheckClientEvent> CreateICheckClientEvent(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, StringOffset EventNameOffset = default(StringOffset), Offset<ISelfClientEvent> ListenerTargetOffset = default(Offset<ISelfClientEvent>))
		{
			builder.StartTable(3);
			ICheckClientEvent.AddListenerTarget(builder, ListenerTargetOffset);
			ICheckClientEvent.AddEventName(builder, EventNameOffset);
			ICheckClientEvent.AddType(builder, Type);
			return ICheckClientEvent.EndICheckClientEvent(builder);
		}

		// Token: 0x0601D67A RID: 120442 RVA: 0x00424DCD File Offset: 0x00422FCD
		public static void StartICheckClientEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601D67B RID: 120443 RVA: 0x00424DD6 File Offset: 0x00422FD6
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D67C RID: 120444 RVA: 0x00424DE1 File Offset: 0x00422FE1
		public static void AddEventName(FlatBufferBuilder builder, StringOffset eventNameOffset)
		{
			builder.AddOffset(1, eventNameOffset.Value, 0);
		}

		// Token: 0x0601D67D RID: 120445 RVA: 0x00424DF1 File Offset: 0x00422FF1
		public static void AddListenerTarget(FlatBufferBuilder builder, Offset<ISelfClientEvent> listenerTargetOffset)
		{
			builder.AddOffset(2, listenerTargetOffset.Value, 0);
		}

		// Token: 0x0601D67E RID: 120446 RVA: 0x00424E01 File Offset: 0x00423001
		public static Offset<ICheckClientEvent> EndICheckClientEvent(FlatBufferBuilder builder)
		{
			return new Offset<ICheckClientEvent>(builder.EndTable());
		}

		// Token: 0x0601D67F RID: 120447 RVA: 0x00424E10 File Offset: 0x00423010
		public ICheckClientEventT UnPack()
		{
			ICheckClientEventT checkClientEventT = new ICheckClientEventT();
			this.UnPackTo(checkClientEventT);
			return checkClientEventT;
		}

		// Token: 0x0601D680 RID: 120448 RVA: 0x00424E2C File Offset: 0x0042302C
		public void UnPackTo(ICheckClientEventT _o)
		{
			_o.Type = this.Type;
			_o.EventName = this.EventName;
			_o.ListenerTarget = ((this.ListenerTarget != null) ? this.ListenerTarget.Value.UnPack() : null);
		}

		// Token: 0x0601D681 RID: 120449 RVA: 0x00424E80 File Offset: 0x00423080
		public static Offset<ICheckClientEvent> Pack(FlatBufferBuilder builder, ICheckClientEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckClientEvent>);
			}
			StringOffset eventNameOffset = (_o.EventName == null) ? default(StringOffset) : builder.CreateString(_o.EventName);
			Offset<ISelfClientEvent> listenerTargetOffset = (_o.ListenerTarget == null) ? default(Offset<ISelfClientEvent>) : ISelfClientEvent.Pack(builder, _o.ListenerTarget);
			return ICheckClientEvent.CreateICheckClientEvent(builder, _o.Type, eventNameOffset, listenerTargetOffset);
		}

		// Token: 0x0400D1B8 RID: 53688
		private Table __p;
	}
}
