using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D77 RID: 28023
	public struct IPostAkEventMusicSubtitle : IFlatbufferObject
	{
		// Token: 0x1700D111 RID: 53521
		// (get) Token: 0x060317F0 RID: 202736 RVA: 0x006B5D47 File Offset: 0x006B3F47
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060317F1 RID: 202737 RVA: 0x006B5D54 File Offset: 0x006B3F54
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060317F2 RID: 202738 RVA: 0x006B5D5C File Offset: 0x006B3F5C
		public static IPostAkEventMusicSubtitle GetRootAsIPostAkEventMusicSubtitle(ByteBuffer _bb)
		{
			return IPostAkEventMusicSubtitle.GetRootAsIPostAkEventMusicSubtitle(_bb, default(IPostAkEventMusicSubtitle));
		}

		// Token: 0x060317F3 RID: 202739 RVA: 0x006B5D78 File Offset: 0x006B3F78
		public static IPostAkEventMusicSubtitle GetRootAsIPostAkEventMusicSubtitle(ByteBuffer _bb, IPostAkEventMusicSubtitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060317F4 RID: 202740 RVA: 0x006B5D95 File Offset: 0x006B3F95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060317F5 RID: 202741 RVA: 0x006B5DA4 File Offset: 0x006B3FA4
		public IPostAkEventMusicSubtitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D112 RID: 53522
		// (get) Token: 0x060317F6 RID: 202742 RVA: 0x006B5DB4 File Offset: 0x006B3FB4
		public EPostAkEvent Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPostAkEvent.Global;
				}
				return (EPostAkEvent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D113 RID: 53523
		// (get) Token: 0x060317F7 RID: 202743 RVA: 0x006B5DF0 File Offset: 0x006B3FF0
		public string MusicSubtitleGroupTag
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

		// Token: 0x060317F8 RID: 202744 RVA: 0x006B5E27 File Offset: 0x006B4027
		public Span<byte> GetMusicSubtitleGroupTagBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060317F9 RID: 202745 RVA: 0x006B5E36 File Offset: 0x006B4036
		public byte[] GetMusicSubtitleGroupTagArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D114 RID: 53524
		// (get) Token: 0x060317FA RID: 202746 RVA: 0x006B5E44 File Offset: 0x006B4044
		public string AkEvent
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060317FB RID: 202747 RVA: 0x006B5E7B File Offset: 0x006B407B
		public Span<byte> GetAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060317FC RID: 202748 RVA: 0x006B5E8A File Offset: 0x006B408A
		public byte[] GetAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700D115 RID: 53525
		// (get) Token: 0x060317FD RID: 202749 RVA: 0x006B5E98 File Offset: 0x006B4098
		public bool IsLoop
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D116 RID: 53526
		// (get) Token: 0x060317FE RID: 202750 RVA: 0x006B5ED8 File Offset: 0x006B40D8
		public bool IsEndAkEvent
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D117 RID: 53527
		// (get) Token: 0x060317FF RID: 202751 RVA: 0x006B5F18 File Offset: 0x006B4118
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031800 RID: 202752 RVA: 0x006B5F55 File Offset: 0x006B4155
		public static Offset<IPostAkEventMusicSubtitle> CreateIPostAkEventMusicSubtitle(FlatBufferBuilder builder, EPostAkEvent Type = EPostAkEvent.Global, StringOffset MusicSubtitleGroupTagOffset = default(StringOffset), StringOffset AkEventOffset = default(StringOffset), bool IsLoop = false, bool IsEndAkEvent = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			IPostAkEventMusicSubtitle.AddAkEvent(builder, AkEventOffset);
			IPostAkEventMusicSubtitle.AddMusicSubtitleGroupTag(builder, MusicSubtitleGroupTagOffset);
			IPostAkEventMusicSubtitle.AddNullMask(builder, NullMask);
			IPostAkEventMusicSubtitle.AddIsEndAkEvent(builder, IsEndAkEvent);
			IPostAkEventMusicSubtitle.AddIsLoop(builder, IsLoop);
			IPostAkEventMusicSubtitle.AddType(builder, Type);
			return IPostAkEventMusicSubtitle.EndIPostAkEventMusicSubtitle(builder);
		}

		// Token: 0x06031801 RID: 202753 RVA: 0x006B5F91 File Offset: 0x006B4191
		public static void StartIPostAkEventMusicSubtitle(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06031802 RID: 202754 RVA: 0x006B5F9A File Offset: 0x006B419A
		public static void AddType(FlatBufferBuilder builder, EPostAkEvent type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031803 RID: 202755 RVA: 0x006B5FA5 File Offset: 0x006B41A5
		public static void AddMusicSubtitleGroupTag(FlatBufferBuilder builder, StringOffset musicSubtitleGroupTagOffset)
		{
			builder.AddOffset(1, musicSubtitleGroupTagOffset.Value, 0);
		}

		// Token: 0x06031804 RID: 202756 RVA: 0x006B5FB5 File Offset: 0x006B41B5
		public static void AddAkEvent(FlatBufferBuilder builder, StringOffset akEventOffset)
		{
			builder.AddOffset(2, akEventOffset.Value, 0);
		}

		// Token: 0x06031805 RID: 202757 RVA: 0x006B5FC5 File Offset: 0x006B41C5
		public static void AddIsLoop(FlatBufferBuilder builder, bool isLoop)
		{
			builder.AddBool(3, isLoop, false);
		}

		// Token: 0x06031806 RID: 202758 RVA: 0x006B5FD0 File Offset: 0x006B41D0
		public static void AddIsEndAkEvent(FlatBufferBuilder builder, bool isEndAkEvent)
		{
			builder.AddBool(4, isEndAkEvent, false);
		}

		// Token: 0x06031807 RID: 202759 RVA: 0x006B5FDB File Offset: 0x006B41DB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06031808 RID: 202760 RVA: 0x006B5FE6 File Offset: 0x006B41E6
		public static Offset<IPostAkEventMusicSubtitle> EndIPostAkEventMusicSubtitle(FlatBufferBuilder builder)
		{
			return new Offset<IPostAkEventMusicSubtitle>(builder.EndTable());
		}

		// Token: 0x06031809 RID: 202761 RVA: 0x006B5FF4 File Offset: 0x006B41F4
		public IPostAkEventMusicSubtitleT UnPack()
		{
			IPostAkEventMusicSubtitleT postAkEventMusicSubtitleT = new IPostAkEventMusicSubtitleT();
			this.UnPackTo(postAkEventMusicSubtitleT);
			return postAkEventMusicSubtitleT;
		}

		// Token: 0x0603180A RID: 202762 RVA: 0x006B6010 File Offset: 0x006B4210
		public void UnPackTo(IPostAkEventMusicSubtitleT _o)
		{
			_o.Type = this.Type;
			_o.MusicSubtitleGroupTag = this.MusicSubtitleGroupTag;
			_o.AkEvent = this.AkEvent;
			_o.IsLoop = this.IsLoop;
			_o.IsEndAkEvent = this.IsEndAkEvent;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603180B RID: 202763 RVA: 0x006B6068 File Offset: 0x006B4268
		public static Offset<IPostAkEventMusicSubtitle> Pack(FlatBufferBuilder builder, IPostAkEventMusicSubtitleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPostAkEventMusicSubtitle>);
			}
			StringOffset musicSubtitleGroupTagOffset = (_o.MusicSubtitleGroupTag == null) ? default(StringOffset) : builder.CreateString(_o.MusicSubtitleGroupTag);
			StringOffset akEventOffset = (_o.AkEvent == null) ? default(StringOffset) : builder.CreateString(_o.AkEvent);
			return IPostAkEventMusicSubtitle.CreateIPostAkEventMusicSubtitle(builder, _o.Type, musicSubtitleGroupTagOffset, akEventOffset, _o.IsLoop, _o.IsEndAkEvent, _o.NullMask);
		}

		// Token: 0x0401173B RID: 71483
		private Table __p;
	}
}
