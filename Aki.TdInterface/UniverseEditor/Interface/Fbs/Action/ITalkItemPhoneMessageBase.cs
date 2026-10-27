using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072EC RID: 29420
	public struct ITalkItemPhoneMessageBase : IFlatbufferObject
	{
		// Token: 0x1700DD60 RID: 56672
		// (get) Token: 0x06034E71 RID: 216689 RVA: 0x0072A6D2 File Offset: 0x007288D2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034E72 RID: 216690 RVA: 0x0072A6DF File Offset: 0x007288DF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034E73 RID: 216691 RVA: 0x0072A6E8 File Offset: 0x007288E8
		public static ITalkItemPhoneMessageBase GetRootAsITalkItemPhoneMessageBase(ByteBuffer _bb)
		{
			return ITalkItemPhoneMessageBase.GetRootAsITalkItemPhoneMessageBase(_bb, default(ITalkItemPhoneMessageBase));
		}

		// Token: 0x06034E74 RID: 216692 RVA: 0x0072A704 File Offset: 0x00728904
		public static ITalkItemPhoneMessageBase GetRootAsITalkItemPhoneMessageBase(ByteBuffer _bb, ITalkItemPhoneMessageBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034E75 RID: 216693 RVA: 0x0072A721 File Offset: 0x00728921
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034E76 RID: 216694 RVA: 0x0072A730 File Offset: 0x00728930
		public ITalkItemPhoneMessageBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD61 RID: 56673
		// (get) Token: 0x06034E77 RID: 216695 RVA: 0x0072A740 File Offset: 0x00728940
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

		// Token: 0x06034E78 RID: 216696 RVA: 0x0072A77C File Offset: 0x0072897C
		public static Offset<ITalkItemPhoneMessageBase> CreateITalkItemPhoneMessageBase(FlatBufferBuilder builder, EPhoneMessageType Type = EPhoneMessageType.Voice)
		{
			builder.StartTable(1);
			ITalkItemPhoneMessageBase.AddType(builder, Type);
			return ITalkItemPhoneMessageBase.EndITalkItemPhoneMessageBase(builder);
		}

		// Token: 0x06034E79 RID: 216697 RVA: 0x0072A792 File Offset: 0x00728992
		public static void StartITalkItemPhoneMessageBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034E7A RID: 216698 RVA: 0x0072A79B File Offset: 0x0072899B
		public static void AddType(FlatBufferBuilder builder, EPhoneMessageType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034E7B RID: 216699 RVA: 0x0072A7A6 File Offset: 0x007289A6
		public static Offset<ITalkItemPhoneMessageBase> EndITalkItemPhoneMessageBase(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemPhoneMessageBase>(builder.EndTable());
		}

		// Token: 0x06034E7C RID: 216700 RVA: 0x0072A7B4 File Offset: 0x007289B4
		public ITalkItemPhoneMessageBaseT UnPack()
		{
			ITalkItemPhoneMessageBaseT talkItemPhoneMessageBaseT = new ITalkItemPhoneMessageBaseT();
			this.UnPackTo(talkItemPhoneMessageBaseT);
			return talkItemPhoneMessageBaseT;
		}

		// Token: 0x06034E7D RID: 216701 RVA: 0x0072A7CF File Offset: 0x007289CF
		public void UnPackTo(ITalkItemPhoneMessageBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034E7E RID: 216702 RVA: 0x0072A7E0 File Offset: 0x007289E0
		public static Offset<ITalkItemPhoneMessageBase> Pack(FlatBufferBuilder builder, ITalkItemPhoneMessageBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemPhoneMessageBase>);
			}
			return ITalkItemPhoneMessageBase.CreateITalkItemPhoneMessageBase(builder, _o.Type);
		}

		// Token: 0x04011FA3 RID: 73635
		private Table __p;
	}
}
