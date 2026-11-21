using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074F2 RID: 29938
	public struct IPostAkEventMusicSubtitle : IFlatbufferObject
	{
		// Token: 0x1700DC59 RID: 56409
		// (get) Token: 0x060347EC RID: 215020 RVA: 0x0071142F File Offset: 0x0070F62F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060347ED RID: 215021 RVA: 0x0071143C File Offset: 0x0070F63C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060347EE RID: 215022 RVA: 0x00711444 File Offset: 0x0070F644
		public static IPostAkEventMusicSubtitle GetRootAsIPostAkEventMusicSubtitle(ByteBuffer _bb)
		{
			return IPostAkEventMusicSubtitle.GetRootAsIPostAkEventMusicSubtitle(_bb, default(IPostAkEventMusicSubtitle));
		}

		// Token: 0x060347EF RID: 215023 RVA: 0x00711460 File Offset: 0x0070F660
		public static IPostAkEventMusicSubtitle GetRootAsIPostAkEventMusicSubtitle(ByteBuffer _bb, IPostAkEventMusicSubtitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060347F0 RID: 215024 RVA: 0x0071147D File Offset: 0x0070F67D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060347F1 RID: 215025 RVA: 0x0071148C File Offset: 0x0070F68C
		public IPostAkEventMusicSubtitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC5A RID: 56410
		// (get) Token: 0x060347F2 RID: 215026 RVA: 0x0071149C File Offset: 0x0070F69C
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

		// Token: 0x1700DC5B RID: 56411
		// (get) Token: 0x060347F3 RID: 215027 RVA: 0x007114D8 File Offset: 0x0070F6D8
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

		// Token: 0x060347F4 RID: 215028 RVA: 0x0071150F File Offset: 0x0070F70F
		public Span<byte> GetMusicSubtitleGroupTagBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060347F5 RID: 215029 RVA: 0x0071151E File Offset: 0x0070F71E
		public byte[] GetMusicSubtitleGroupTagArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700DC5C RID: 56412
		// (get) Token: 0x060347F6 RID: 215030 RVA: 0x0071152C File Offset: 0x0070F72C
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

		// Token: 0x060347F7 RID: 215031 RVA: 0x00711563 File Offset: 0x0070F763
		public Span<byte> GetAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060347F8 RID: 215032 RVA: 0x00711572 File Offset: 0x0070F772
		public byte[] GetAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700DC5D RID: 56413
		// (get) Token: 0x060347F9 RID: 215033 RVA: 0x00711580 File Offset: 0x0070F780
		public bool IsLoop
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DC5E RID: 56414
		// (get) Token: 0x060347FA RID: 215034 RVA: 0x007115C0 File Offset: 0x0070F7C0
		public bool IsEndAkEvent
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DC5F RID: 56415
		// (get) Token: 0x060347FB RID: 215035 RVA: 0x00711600 File Offset: 0x0070F800
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

		// Token: 0x060347FC RID: 215036 RVA: 0x0071163D File Offset: 0x0070F83D
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

		// Token: 0x060347FD RID: 215037 RVA: 0x00711679 File Offset: 0x0070F879
		public static void StartIPostAkEventMusicSubtitle(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060347FE RID: 215038 RVA: 0x00711682 File Offset: 0x0070F882
		public static void AddType(FlatBufferBuilder builder, EPostAkEvent type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060347FF RID: 215039 RVA: 0x0071168D File Offset: 0x0070F88D
		public static void AddMusicSubtitleGroupTag(FlatBufferBuilder builder, StringOffset musicSubtitleGroupTagOffset)
		{
			builder.AddOffset(1, musicSubtitleGroupTagOffset.Value, 0);
		}

		// Token: 0x06034800 RID: 215040 RVA: 0x0071169D File Offset: 0x0070F89D
		public static void AddAkEvent(FlatBufferBuilder builder, StringOffset akEventOffset)
		{
			builder.AddOffset(2, akEventOffset.Value, 0);
		}

		// Token: 0x06034801 RID: 215041 RVA: 0x007116AD File Offset: 0x0070F8AD
		public static void AddIsLoop(FlatBufferBuilder builder, bool isLoop)
		{
			builder.AddBool(3, isLoop, false);
		}

		// Token: 0x06034802 RID: 215042 RVA: 0x007116B8 File Offset: 0x0070F8B8
		public static void AddIsEndAkEvent(FlatBufferBuilder builder, bool isEndAkEvent)
		{
			builder.AddBool(4, isEndAkEvent, false);
		}

		// Token: 0x06034803 RID: 215043 RVA: 0x007116C3 File Offset: 0x0070F8C3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06034804 RID: 215044 RVA: 0x007116CE File Offset: 0x0070F8CE
		public static Offset<IPostAkEventMusicSubtitle> EndIPostAkEventMusicSubtitle(FlatBufferBuilder builder)
		{
			return new Offset<IPostAkEventMusicSubtitle>(builder.EndTable());
		}

		// Token: 0x06034805 RID: 215045 RVA: 0x007116DC File Offset: 0x0070F8DC
		public IPostAkEventMusicSubtitleT UnPack()
		{
			IPostAkEventMusicSubtitleT postAkEventMusicSubtitleT = new IPostAkEventMusicSubtitleT();
			this.UnPackTo(postAkEventMusicSubtitleT);
			return postAkEventMusicSubtitleT;
		}

		// Token: 0x06034806 RID: 215046 RVA: 0x007116F8 File Offset: 0x0070F8F8
		public void UnPackTo(IPostAkEventMusicSubtitleT _o)
		{
			_o.Type = this.Type;
			_o.MusicSubtitleGroupTag = this.MusicSubtitleGroupTag;
			_o.AkEvent = this.AkEvent;
			_o.IsLoop = this.IsLoop;
			_o.IsEndAkEvent = this.IsEndAkEvent;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034807 RID: 215047 RVA: 0x00711750 File Offset: 0x0070F950
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

		// Token: 0x040126B7 RID: 75447
		private Table __p;
	}
}
