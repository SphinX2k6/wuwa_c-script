using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DEE RID: 15854
	public struct IEavesdropGamePlayConfig : IFlatbufferObject
	{
		// Token: 0x17006D89 RID: 28041
		// (get) Token: 0x06016287 RID: 90759 RVA: 0x0033380C File Offset: 0x00331A0C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016288 RID: 90760 RVA: 0x00333819 File Offset: 0x00331A19
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016289 RID: 90761 RVA: 0x00333820 File Offset: 0x00331A20
		public static IEavesdropGamePlayConfig GetRootAsIEavesdropGamePlayConfig(ByteBuffer _bb)
		{
			return IEavesdropGamePlayConfig.GetRootAsIEavesdropGamePlayConfig(_bb, default(IEavesdropGamePlayConfig));
		}

		// Token: 0x0601628A RID: 90762 RVA: 0x0033383C File Offset: 0x00331A3C
		public static IEavesdropGamePlayConfig GetRootAsIEavesdropGamePlayConfig(ByteBuffer _bb, IEavesdropGamePlayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601628B RID: 90763 RVA: 0x00333859 File Offset: 0x00331A59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601628C RID: 90764 RVA: 0x00333868 File Offset: 0x00331A68
		public IEavesdropGamePlayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D8A RID: 28042
		// (get) Token: 0x0601628D RID: 90765 RVA: 0x00333878 File Offset: 0x00331A78
		public ESpecialGamePlayConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpecialGamePlayConfigType.Stalking;
				}
				return (ESpecialGamePlayConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006D8B RID: 28043
		// (get) Token: 0x0601628E RID: 90766 RVA: 0x003338B4 File Offset: 0x00331AB4
		public int EavesdropEntityId
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

		// Token: 0x17006D8C RID: 28044
		// (get) Token: 0x0601628F RID: 90767 RVA: 0x003338F0 File Offset: 0x00331AF0
		public int HintRangeEntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006D8D RID: 28045
		// (get) Token: 0x06016290 RID: 90768 RVA: 0x0033392C File Offset: 0x00331B2C
		public int ListenableRangeEntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006D8E RID: 28046
		// (get) Token: 0x06016291 RID: 90769 RVA: 0x0033396C File Offset: 0x00331B6C
		public int TooCloseRangeEntityId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006D8F RID: 28047
		// (get) Token: 0x06016292 RID: 90770 RVA: 0x003339AC File Offset: 0x00331BAC
		public int HintTag
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006D90 RID: 28048
		// (get) Token: 0x06016293 RID: 90771 RVA: 0x003339EC File Offset: 0x00331BEC
		public int ListenableTag
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006D91 RID: 28049
		// (get) Token: 0x06016294 RID: 90772 RVA: 0x00333A2C File Offset: 0x00331C2C
		public int TooCloseTag
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006D92 RID: 28050
		// (get) Token: 0x06016295 RID: 90773 RVA: 0x00333A6C File Offset: 0x00331C6C
		public int ListenedTag
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016296 RID: 90774 RVA: 0x00333AAC File Offset: 0x00331CAC
		public static Offset<IEavesdropGamePlayConfig> CreateIEavesdropGamePlayConfig(FlatBufferBuilder builder, ESpecialGamePlayConfigType Type = ESpecialGamePlayConfigType.Stalking, int EavesdropEntityId = 0, int HintRangeEntityId = 0, int ListenableRangeEntityId = 0, int TooCloseRangeEntityId = 0, int HintTag = 0, int ListenableTag = 0, int TooCloseTag = 0, int ListenedTag = 0)
		{
			builder.StartTable(9);
			IEavesdropGamePlayConfig.AddListenedTag(builder, ListenedTag);
			IEavesdropGamePlayConfig.AddTooCloseTag(builder, TooCloseTag);
			IEavesdropGamePlayConfig.AddListenableTag(builder, ListenableTag);
			IEavesdropGamePlayConfig.AddHintTag(builder, HintTag);
			IEavesdropGamePlayConfig.AddTooCloseRangeEntityId(builder, TooCloseRangeEntityId);
			IEavesdropGamePlayConfig.AddListenableRangeEntityId(builder, ListenableRangeEntityId);
			IEavesdropGamePlayConfig.AddHintRangeEntityId(builder, HintRangeEntityId);
			IEavesdropGamePlayConfig.AddEavesdropEntityId(builder, EavesdropEntityId);
			IEavesdropGamePlayConfig.AddType(builder, Type);
			return IEavesdropGamePlayConfig.EndIEavesdropGamePlayConfig(builder);
		}

		// Token: 0x06016297 RID: 90775 RVA: 0x00333B0C File Offset: 0x00331D0C
		public static void StartIEavesdropGamePlayConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06016298 RID: 90776 RVA: 0x00333B16 File Offset: 0x00331D16
		public static void AddType(FlatBufferBuilder builder, ESpecialGamePlayConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016299 RID: 90777 RVA: 0x00333B21 File Offset: 0x00331D21
		public static void AddEavesdropEntityId(FlatBufferBuilder builder, int eavesdropEntityId)
		{
			builder.AddInt(1, eavesdropEntityId, 0);
		}

		// Token: 0x0601629A RID: 90778 RVA: 0x00333B2C File Offset: 0x00331D2C
		public static void AddHintRangeEntityId(FlatBufferBuilder builder, int hintRangeEntityId)
		{
			builder.AddInt(2, hintRangeEntityId, 0);
		}

		// Token: 0x0601629B RID: 90779 RVA: 0x00333B37 File Offset: 0x00331D37
		public static void AddListenableRangeEntityId(FlatBufferBuilder builder, int listenableRangeEntityId)
		{
			builder.AddInt(3, listenableRangeEntityId, 0);
		}

		// Token: 0x0601629C RID: 90780 RVA: 0x00333B42 File Offset: 0x00331D42
		public static void AddTooCloseRangeEntityId(FlatBufferBuilder builder, int tooCloseRangeEntityId)
		{
			builder.AddInt(4, tooCloseRangeEntityId, 0);
		}

		// Token: 0x0601629D RID: 90781 RVA: 0x00333B4D File Offset: 0x00331D4D
		public static void AddHintTag(FlatBufferBuilder builder, int hintTag)
		{
			builder.AddInt(5, hintTag, 0);
		}

		// Token: 0x0601629E RID: 90782 RVA: 0x00333B58 File Offset: 0x00331D58
		public static void AddListenableTag(FlatBufferBuilder builder, int listenableTag)
		{
			builder.AddInt(6, listenableTag, 0);
		}

		// Token: 0x0601629F RID: 90783 RVA: 0x00333B63 File Offset: 0x00331D63
		public static void AddTooCloseTag(FlatBufferBuilder builder, int tooCloseTag)
		{
			builder.AddInt(7, tooCloseTag, 0);
		}

		// Token: 0x060162A0 RID: 90784 RVA: 0x00333B6E File Offset: 0x00331D6E
		public static void AddListenedTag(FlatBufferBuilder builder, int listenedTag)
		{
			builder.AddInt(8, listenedTag, 0);
		}

		// Token: 0x060162A1 RID: 90785 RVA: 0x00333B79 File Offset: 0x00331D79
		public static Offset<IEavesdropGamePlayConfig> EndIEavesdropGamePlayConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEavesdropGamePlayConfig>(builder.EndTable());
		}

		// Token: 0x060162A2 RID: 90786 RVA: 0x00333B88 File Offset: 0x00331D88
		public IEavesdropGamePlayConfigT UnPack()
		{
			IEavesdropGamePlayConfigT eavesdropGamePlayConfigT = new IEavesdropGamePlayConfigT();
			this.UnPackTo(eavesdropGamePlayConfigT);
			return eavesdropGamePlayConfigT;
		}

		// Token: 0x060162A3 RID: 90787 RVA: 0x00333BA4 File Offset: 0x00331DA4
		public void UnPackTo(IEavesdropGamePlayConfigT _o)
		{
			_o.Type = this.Type;
			_o.EavesdropEntityId = this.EavesdropEntityId;
			_o.HintRangeEntityId = this.HintRangeEntityId;
			_o.ListenableRangeEntityId = this.ListenableRangeEntityId;
			_o.TooCloseRangeEntityId = this.TooCloseRangeEntityId;
			_o.HintTag = this.HintTag;
			_o.ListenableTag = this.ListenableTag;
			_o.TooCloseTag = this.TooCloseTag;
			_o.ListenedTag = this.ListenedTag;
		}

		// Token: 0x060162A4 RID: 90788 RVA: 0x00333C20 File Offset: 0x00331E20
		public static Offset<IEavesdropGamePlayConfig> Pack(FlatBufferBuilder builder, IEavesdropGamePlayConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEavesdropGamePlayConfig>);
			}
			return IEavesdropGamePlayConfig.CreateIEavesdropGamePlayConfig(builder, _o.Type, _o.EavesdropEntityId, _o.HintRangeEntityId, _o.ListenableRangeEntityId, _o.TooCloseRangeEntityId, _o.HintTag, _o.ListenableTag, _o.TooCloseTag, _o.ListenedTag);
		}

		// Token: 0x0400B743 RID: 46915
		private Table __p;
	}
}
