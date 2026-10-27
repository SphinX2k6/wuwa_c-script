using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007301 RID: 29441
	public struct ITalkItemStyleInnerVoice : IFlatbufferObject
	{
		// Token: 0x1700DDC1 RID: 56769
		// (get) Token: 0x06034FEC RID: 217068 RVA: 0x0072E6D9 File Offset: 0x0072C8D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034FED RID: 217069 RVA: 0x0072E6E6 File Offset: 0x0072C8E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034FEE RID: 217070 RVA: 0x0072E6F0 File Offset: 0x0072C8F0
		public static ITalkItemStyleInnerVoice GetRootAsITalkItemStyleInnerVoice(ByteBuffer _bb)
		{
			return ITalkItemStyleInnerVoice.GetRootAsITalkItemStyleInnerVoice(_bb, default(ITalkItemStyleInnerVoice));
		}

		// Token: 0x06034FEF RID: 217071 RVA: 0x0072E70C File Offset: 0x0072C90C
		public static ITalkItemStyleInnerVoice GetRootAsITalkItemStyleInnerVoice(ByteBuffer _bb, ITalkItemStyleInnerVoice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034FF0 RID: 217072 RVA: 0x0072E729 File Offset: 0x0072C929
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034FF1 RID: 217073 RVA: 0x0072E738 File Offset: 0x0072C938
		public ITalkItemStyleInnerVoice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DDC2 RID: 56770
		// (get) Token: 0x06034FF2 RID: 217074 RVA: 0x0072E748 File Offset: 0x0072C948
		public ETalkItemStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkItemStyle.InnerVoice;
				}
				return (ETalkItemStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034FF3 RID: 217075 RVA: 0x0072E784 File Offset: 0x0072C984
		public static Offset<ITalkItemStyleInnerVoice> CreateITalkItemStyleInnerVoice(FlatBufferBuilder builder, ETalkItemStyle Type = ETalkItemStyle.InnerVoice)
		{
			builder.StartTable(1);
			ITalkItemStyleInnerVoice.AddType(builder, Type);
			return ITalkItemStyleInnerVoice.EndITalkItemStyleInnerVoice(builder);
		}

		// Token: 0x06034FF4 RID: 217076 RVA: 0x0072E79A File Offset: 0x0072C99A
		public static void StartITalkItemStyleInnerVoice(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034FF5 RID: 217077 RVA: 0x0072E7A3 File Offset: 0x0072C9A3
		public static void AddType(FlatBufferBuilder builder, ETalkItemStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034FF6 RID: 217078 RVA: 0x0072E7AE File Offset: 0x0072C9AE
		public static Offset<ITalkItemStyleInnerVoice> EndITalkItemStyleInnerVoice(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemStyleInnerVoice>(builder.EndTable());
		}

		// Token: 0x06034FF7 RID: 217079 RVA: 0x0072E7BC File Offset: 0x0072C9BC
		public ITalkItemStyleInnerVoiceT UnPack()
		{
			ITalkItemStyleInnerVoiceT talkItemStyleInnerVoiceT = new ITalkItemStyleInnerVoiceT();
			this.UnPackTo(talkItemStyleInnerVoiceT);
			return talkItemStyleInnerVoiceT;
		}

		// Token: 0x06034FF8 RID: 217080 RVA: 0x0072E7D7 File Offset: 0x0072C9D7
		public void UnPackTo(ITalkItemStyleInnerVoiceT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034FF9 RID: 217081 RVA: 0x0072E7E8 File Offset: 0x0072C9E8
		public static Offset<ITalkItemStyleInnerVoice> Pack(FlatBufferBuilder builder, ITalkItemStyleInnerVoiceT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemStyleInnerVoice>);
			}
			return ITalkItemStyleInnerVoice.CreateITalkItemStyleInnerVoice(builder, _o.Type);
		}

		// Token: 0x04011FDE RID: 73694
		private Table __p;
	}
}
