using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AC1 RID: 31425
	public struct ITalkItemPhoneMessageBase : IFlatbufferObject
	{
		// Token: 0x1700E959 RID: 59737
		// (get) Token: 0x06038177 RID: 229751 RVA: 0x0078BB36 File Offset: 0x00789D36
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038178 RID: 229752 RVA: 0x0078BB43 File Offset: 0x00789D43
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038179 RID: 229753 RVA: 0x0078BB4C File Offset: 0x00789D4C
		public static ITalkItemPhoneMessageBase GetRootAsITalkItemPhoneMessageBase(ByteBuffer _bb)
		{
			return ITalkItemPhoneMessageBase.GetRootAsITalkItemPhoneMessageBase(_bb, default(ITalkItemPhoneMessageBase));
		}

		// Token: 0x0603817A RID: 229754 RVA: 0x0078BB68 File Offset: 0x00789D68
		public static ITalkItemPhoneMessageBase GetRootAsITalkItemPhoneMessageBase(ByteBuffer _bb, ITalkItemPhoneMessageBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603817B RID: 229755 RVA: 0x0078BB85 File Offset: 0x00789D85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603817C RID: 229756 RVA: 0x0078BB94 File Offset: 0x00789D94
		public ITalkItemPhoneMessageBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E95A RID: 59738
		// (get) Token: 0x0603817D RID: 229757 RVA: 0x0078BBA4 File Offset: 0x00789DA4
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

		// Token: 0x0603817E RID: 229758 RVA: 0x0078BBE0 File Offset: 0x00789DE0
		public static Offset<ITalkItemPhoneMessageBase> CreateITalkItemPhoneMessageBase(FlatBufferBuilder builder, EPhoneMessageType Type = EPhoneMessageType.Voice)
		{
			builder.StartTable(1);
			ITalkItemPhoneMessageBase.AddType(builder, Type);
			return ITalkItemPhoneMessageBase.EndITalkItemPhoneMessageBase(builder);
		}

		// Token: 0x0603817F RID: 229759 RVA: 0x0078BBF6 File Offset: 0x00789DF6
		public static void StartITalkItemPhoneMessageBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06038180 RID: 229760 RVA: 0x0078BBFF File Offset: 0x00789DFF
		public static void AddType(FlatBufferBuilder builder, EPhoneMessageType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038181 RID: 229761 RVA: 0x0078BC0A File Offset: 0x00789E0A
		public static Offset<ITalkItemPhoneMessageBase> EndITalkItemPhoneMessageBase(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemPhoneMessageBase>(builder.EndTable());
		}

		// Token: 0x06038182 RID: 229762 RVA: 0x0078BC18 File Offset: 0x00789E18
		public ITalkItemPhoneMessageBaseT UnPack()
		{
			ITalkItemPhoneMessageBaseT talkItemPhoneMessageBaseT = new ITalkItemPhoneMessageBaseT();
			this.UnPackTo(talkItemPhoneMessageBaseT);
			return talkItemPhoneMessageBaseT;
		}

		// Token: 0x06038183 RID: 229763 RVA: 0x0078BC33 File Offset: 0x00789E33
		public void UnPackTo(ITalkItemPhoneMessageBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06038184 RID: 229764 RVA: 0x0078BC44 File Offset: 0x00789E44
		public static Offset<ITalkItemPhoneMessageBase> Pack(FlatBufferBuilder builder, ITalkItemPhoneMessageBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemPhoneMessageBase>);
			}
			return ITalkItemPhoneMessageBase.CreateITalkItemPhoneMessageBase(builder, _o.Type);
		}

		// Token: 0x04012FA6 RID: 77734
		private Table __p;
	}
}
