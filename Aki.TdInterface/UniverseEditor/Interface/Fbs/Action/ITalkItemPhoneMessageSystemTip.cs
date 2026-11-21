using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ACA RID: 31434
	public struct ITalkItemPhoneMessageSystemTip : IFlatbufferObject
	{
		// Token: 0x1700E963 RID: 59747
		// (get) Token: 0x060381B1 RID: 229809 RVA: 0x0078C076 File Offset: 0x0078A276
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060381B2 RID: 229810 RVA: 0x0078C083 File Offset: 0x0078A283
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060381B3 RID: 229811 RVA: 0x0078C08C File Offset: 0x0078A28C
		public static ITalkItemPhoneMessageSystemTip GetRootAsITalkItemPhoneMessageSystemTip(ByteBuffer _bb)
		{
			return ITalkItemPhoneMessageSystemTip.GetRootAsITalkItemPhoneMessageSystemTip(_bb, default(ITalkItemPhoneMessageSystemTip));
		}

		// Token: 0x060381B4 RID: 229812 RVA: 0x0078C0A8 File Offset: 0x0078A2A8
		public static ITalkItemPhoneMessageSystemTip GetRootAsITalkItemPhoneMessageSystemTip(ByteBuffer _bb, ITalkItemPhoneMessageSystemTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060381B5 RID: 229813 RVA: 0x0078C0C5 File Offset: 0x0078A2C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060381B6 RID: 229814 RVA: 0x0078C0D4 File Offset: 0x0078A2D4
		public ITalkItemPhoneMessageSystemTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E964 RID: 59748
		// (get) Token: 0x060381B7 RID: 229815 RVA: 0x0078C0E4 File Offset: 0x0078A2E4
		public EPhoneMessageType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhoneMessageType.Voice;
				}
				return (EPhoneMessageType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060381B8 RID: 229816 RVA: 0x0078C120 File Offset: 0x0078A320
		public static Offset<ITalkItemPhoneMessageSystemTip> CreateITalkItemPhoneMessageSystemTip(FlatBufferBuilder builder, EPhoneMessageType Type = EPhoneMessageType.Voice)
		{
			builder.StartTable(1);
			ITalkItemPhoneMessageSystemTip.AddType(builder, Type);
			return ITalkItemPhoneMessageSystemTip.EndITalkItemPhoneMessageSystemTip(builder);
		}

		// Token: 0x060381B9 RID: 229817 RVA: 0x0078C136 File Offset: 0x0078A336
		public static void StartITalkItemPhoneMessageSystemTip(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060381BA RID: 229818 RVA: 0x0078C13F File Offset: 0x0078A33F
		public static void AddType(FlatBufferBuilder builder, EPhoneMessageType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060381BB RID: 229819 RVA: 0x0078C14A File Offset: 0x0078A34A
		public static Offset<ITalkItemPhoneMessageSystemTip> EndITalkItemPhoneMessageSystemTip(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemPhoneMessageSystemTip>(builder.EndTable());
		}

		// Token: 0x060381BC RID: 229820 RVA: 0x0078C158 File Offset: 0x0078A358
		public ITalkItemPhoneMessageSystemTipT UnPack()
		{
			ITalkItemPhoneMessageSystemTipT talkItemPhoneMessageSystemTipT = new ITalkItemPhoneMessageSystemTipT();
			this.UnPackTo(talkItemPhoneMessageSystemTipT);
			return talkItemPhoneMessageSystemTipT;
		}

		// Token: 0x060381BD RID: 229821 RVA: 0x0078C173 File Offset: 0x0078A373
		public void UnPackTo(ITalkItemPhoneMessageSystemTipT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060381BE RID: 229822 RVA: 0x0078C184 File Offset: 0x0078A384
		public static Offset<ITalkItemPhoneMessageSystemTip> Pack(FlatBufferBuilder builder, ITalkItemPhoneMessageSystemTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemPhoneMessageSystemTip>);
			}
			return ITalkItemPhoneMessageSystemTip.CreateITalkItemPhoneMessageSystemTip(builder, _o.Type);
		}

		// Token: 0x04012FB4 RID: 77748
		private Table __p;
	}
}
