using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074A1 RID: 29857
	public struct IPlayMapMusic : IFlatbufferObject
	{
		// Token: 0x1700DB63 RID: 56163
		// (get) Token: 0x06034482 RID: 214146 RVA: 0x0070A93B File Offset: 0x00708B3B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034483 RID: 214147 RVA: 0x0070A948 File Offset: 0x00708B48
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034484 RID: 214148 RVA: 0x0070A950 File Offset: 0x00708B50
		public static IPlayMapMusic GetRootAsIPlayMapMusic(ByteBuffer _bb)
		{
			return IPlayMapMusic.GetRootAsIPlayMapMusic(_bb, default(IPlayMapMusic));
		}

		// Token: 0x06034485 RID: 214149 RVA: 0x0070A96C File Offset: 0x00708B6C
		public static IPlayMapMusic GetRootAsIPlayMapMusic(ByteBuffer _bb, IPlayMapMusic obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034486 RID: 214150 RVA: 0x0070A989 File Offset: 0x00708B89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034487 RID: 214151 RVA: 0x0070A998 File Offset: 0x00708B98
		public IPlayMapMusic __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DB64 RID: 56164
		// (get) Token: 0x06034488 RID: 214152 RVA: 0x0070A9A8 File Offset: 0x00708BA8
		public EAkEventMap Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAkEventMap.PlayMapMusic;
				}
				return (EAkEventMap)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034489 RID: 214153 RVA: 0x0070A9E4 File Offset: 0x00708BE4
		public static Offset<IPlayMapMusic> CreateIPlayMapMusic(FlatBufferBuilder builder, EAkEventMap Type = EAkEventMap.PlayMapMusic)
		{
			builder.StartTable(1);
			IPlayMapMusic.AddType(builder, Type);
			return IPlayMapMusic.EndIPlayMapMusic(builder);
		}

		// Token: 0x0603448A RID: 214154 RVA: 0x0070A9FA File Offset: 0x00708BFA
		public static void StartIPlayMapMusic(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603448B RID: 214155 RVA: 0x0070AA03 File Offset: 0x00708C03
		public static void AddType(FlatBufferBuilder builder, EAkEventMap type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603448C RID: 214156 RVA: 0x0070AA0E File Offset: 0x00708C0E
		public static Offset<IPlayMapMusic> EndIPlayMapMusic(FlatBufferBuilder builder)
		{
			return new Offset<IPlayMapMusic>(builder.EndTable());
		}

		// Token: 0x0603448D RID: 214157 RVA: 0x0070AA1C File Offset: 0x00708C1C
		public IPlayMapMusicT UnPack()
		{
			IPlayMapMusicT playMapMusicT = new IPlayMapMusicT();
			this.UnPackTo(playMapMusicT);
			return playMapMusicT;
		}

		// Token: 0x0603448E RID: 214158 RVA: 0x0070AA37 File Offset: 0x00708C37
		public void UnPackTo(IPlayMapMusicT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603448F RID: 214159 RVA: 0x0070AA48 File Offset: 0x00708C48
		public static Offset<IPlayMapMusic> Pack(FlatBufferBuilder builder, IPlayMapMusicT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayMapMusic>);
			}
			return IPlayMapMusic.CreateIPlayMapMusic(builder, _o.Type);
		}

		// Token: 0x0401262A RID: 75306
		private Table __p;
	}
}
