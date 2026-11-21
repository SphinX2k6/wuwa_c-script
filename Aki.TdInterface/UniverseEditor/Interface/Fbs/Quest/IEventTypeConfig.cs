using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200424D RID: 16973
	public struct IEventTypeConfig : IFlatbufferObject
	{
		// Token: 0x170073BB RID: 29627
		// (get) Token: 0x060179FF RID: 96767 RVA: 0x0035E921 File Offset: 0x0035CB21
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017A00 RID: 96768 RVA: 0x0035E92E File Offset: 0x0035CB2E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017A01 RID: 96769 RVA: 0x0035E938 File Offset: 0x0035CB38
		public static IEventTypeConfig GetRootAsIEventTypeConfig(ByteBuffer _bb)
		{
			return IEventTypeConfig.GetRootAsIEventTypeConfig(_bb, default(IEventTypeConfig));
		}

		// Token: 0x06017A02 RID: 96770 RVA: 0x0035E954 File Offset: 0x0035CB54
		public static IEventTypeConfig GetRootAsIEventTypeConfig(ByteBuffer _bb, IEventTypeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017A03 RID: 96771 RVA: 0x0035E971 File Offset: 0x0035CB71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017A04 RID: 96772 RVA: 0x0035E980 File Offset: 0x0035CB80
		public IEventTypeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170073BC RID: 29628
		// (get) Token: 0x06017A05 RID: 96773 RVA: 0x0035E990 File Offset: 0x0035CB90
		public ECommonEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonEventType.VarValueChange;
				}
				return (ECommonEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017A06 RID: 96774 RVA: 0x0035E9CC File Offset: 0x0035CBCC
		public static Offset<IEventTypeConfig> CreateIEventTypeConfig(FlatBufferBuilder builder, ECommonEventType Type = ECommonEventType.VarValueChange)
		{
			builder.StartTable(1);
			IEventTypeConfig.AddType(builder, Type);
			return IEventTypeConfig.EndIEventTypeConfig(builder);
		}

		// Token: 0x06017A07 RID: 96775 RVA: 0x0035E9E2 File Offset: 0x0035CBE2
		public static void StartIEventTypeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06017A08 RID: 96776 RVA: 0x0035E9EB File Offset: 0x0035CBEB
		public static void AddType(FlatBufferBuilder builder, ECommonEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017A09 RID: 96777 RVA: 0x0035E9F6 File Offset: 0x0035CBF6
		public static Offset<IEventTypeConfig> EndIEventTypeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEventTypeConfig>(builder.EndTable());
		}

		// Token: 0x06017A0A RID: 96778 RVA: 0x0035EA04 File Offset: 0x0035CC04
		public IEventTypeConfigT UnPack()
		{
			IEventTypeConfigT eventTypeConfigT = new IEventTypeConfigT();
			this.UnPackTo(eventTypeConfigT);
			return eventTypeConfigT;
		}

		// Token: 0x06017A0B RID: 96779 RVA: 0x0035EA1F File Offset: 0x0035CC1F
		public void UnPackTo(IEventTypeConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06017A0C RID: 96780 RVA: 0x0035EA30 File Offset: 0x0035CC30
		public static Offset<IEventTypeConfig> Pack(FlatBufferBuilder builder, IEventTypeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEventTypeConfig>);
			}
			return IEventTypeConfig.CreateIEventTypeConfig(builder, _o.Type);
		}

		// Token: 0x0400C15E RID: 49502
		private Table __p;
	}
}
