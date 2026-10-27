using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200734F RID: 29519
	public struct ITalkOptionRogueRandomEvent : IFlatbufferObject
	{
		// Token: 0x1700E020 RID: 57376
		// (get) Token: 0x0603590C RID: 219404 RVA: 0x0074B891 File Offset: 0x00749A91
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603590D RID: 219405 RVA: 0x0074B89E File Offset: 0x00749A9E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603590E RID: 219406 RVA: 0x0074B8A8 File Offset: 0x00749AA8
		public static ITalkOptionRogueRandomEvent GetRootAsITalkOptionRogueRandomEvent(ByteBuffer _bb)
		{
			return ITalkOptionRogueRandomEvent.GetRootAsITalkOptionRogueRandomEvent(_bb, default(ITalkOptionRogueRandomEvent));
		}

		// Token: 0x0603590F RID: 219407 RVA: 0x0074B8C4 File Offset: 0x00749AC4
		public static ITalkOptionRogueRandomEvent GetRootAsITalkOptionRogueRandomEvent(ByteBuffer _bb, ITalkOptionRogueRandomEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035910 RID: 219408 RVA: 0x0074B8E1 File Offset: 0x00749AE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035911 RID: 219409 RVA: 0x0074B8F0 File Offset: 0x00749AF0
		public ITalkOptionRogueRandomEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E021 RID: 57377
		// (get) Token: 0x06035912 RID: 219410 RVA: 0x0074B900 File Offset: 0x00749B00
		public ETalkOptionParamType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkOptionParamType.QteSucceed;
				}
				return (ETalkOptionParamType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E022 RID: 57378
		// (get) Token: 0x06035913 RID: 219411 RVA: 0x0074B93C File Offset: 0x00749B3C
		public int OptionId
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

		// Token: 0x1700E023 RID: 57379
		// (get) Token: 0x06035914 RID: 219412 RVA: 0x0074B978 File Offset: 0x00749B78
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035915 RID: 219413 RVA: 0x0074B9B4 File Offset: 0x00749BB4
		public static Offset<ITalkOptionRogueRandomEvent> CreateITalkOptionRogueRandomEvent(FlatBufferBuilder builder, ETalkOptionParamType Type = ETalkOptionParamType.QteSucceed, int OptionId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ITalkOptionRogueRandomEvent.AddOptionId(builder, OptionId);
			ITalkOptionRogueRandomEvent.AddNullMask(builder, NullMask);
			ITalkOptionRogueRandomEvent.AddType(builder, Type);
			return ITalkOptionRogueRandomEvent.EndITalkOptionRogueRandomEvent(builder);
		}

		// Token: 0x06035916 RID: 219414 RVA: 0x0074B9D8 File Offset: 0x00749BD8
		public static void StartITalkOptionRogueRandomEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06035917 RID: 219415 RVA: 0x0074B9E1 File Offset: 0x00749BE1
		public static void AddType(FlatBufferBuilder builder, ETalkOptionParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035918 RID: 219416 RVA: 0x0074B9EC File Offset: 0x00749BEC
		public static void AddOptionId(FlatBufferBuilder builder, int optionId)
		{
			builder.AddInt(1, optionId, 0);
		}

		// Token: 0x06035919 RID: 219417 RVA: 0x0074B9F7 File Offset: 0x00749BF7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0603591A RID: 219418 RVA: 0x0074BA02 File Offset: 0x00749C02
		public static Offset<ITalkOptionRogueRandomEvent> EndITalkOptionRogueRandomEvent(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionRogueRandomEvent>(builder.EndTable());
		}

		// Token: 0x0603591B RID: 219419 RVA: 0x0074BA10 File Offset: 0x00749C10
		public ITalkOptionRogueRandomEventT UnPack()
		{
			ITalkOptionRogueRandomEventT talkOptionRogueRandomEventT = new ITalkOptionRogueRandomEventT();
			this.UnPackTo(talkOptionRogueRandomEventT);
			return talkOptionRogueRandomEventT;
		}

		// Token: 0x0603591C RID: 219420 RVA: 0x0074BA2B File Offset: 0x00749C2B
		public void UnPackTo(ITalkOptionRogueRandomEventT _o)
		{
			_o.Type = this.Type;
			_o.OptionId = this.OptionId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603591D RID: 219421 RVA: 0x0074BA54 File Offset: 0x00749C54
		public static Offset<ITalkOptionRogueRandomEvent> Pack(FlatBufferBuilder builder, ITalkOptionRogueRandomEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionRogueRandomEvent>);
			}
			return ITalkOptionRogueRandomEvent.CreateITalkOptionRogueRandomEvent(builder, _o.Type, _o.OptionId, _o.NullMask);
		}

		// Token: 0x04012146 RID: 74054
		private Table __p;
	}
}
