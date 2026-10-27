using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D26 RID: 27942
	public struct IPlayMapMusic : IFlatbufferObject
	{
		// Token: 0x1700D01D RID: 53277
		// (get) Token: 0x0603148A RID: 201866 RVA: 0x006AF2F7 File Offset: 0x006AD4F7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603148B RID: 201867 RVA: 0x006AF304 File Offset: 0x006AD504
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603148C RID: 201868 RVA: 0x006AF30C File Offset: 0x006AD50C
		public static IPlayMapMusic GetRootAsIPlayMapMusic(ByteBuffer _bb)
		{
			return IPlayMapMusic.GetRootAsIPlayMapMusic(_bb, default(IPlayMapMusic));
		}

		// Token: 0x0603148D RID: 201869 RVA: 0x006AF328 File Offset: 0x006AD528
		public static IPlayMapMusic GetRootAsIPlayMapMusic(ByteBuffer _bb, IPlayMapMusic obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603148E RID: 201870 RVA: 0x006AF345 File Offset: 0x006AD545
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603148F RID: 201871 RVA: 0x006AF354 File Offset: 0x006AD554
		public IPlayMapMusic __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D01E RID: 53278
		// (get) Token: 0x06031490 RID: 201872 RVA: 0x006AF364 File Offset: 0x006AD564
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

		// Token: 0x06031491 RID: 201873 RVA: 0x006AF3A0 File Offset: 0x006AD5A0
		public static Offset<IPlayMapMusic> CreateIPlayMapMusic(FlatBufferBuilder builder, EAkEventMap Type = EAkEventMap.PlayMapMusic)
		{
			builder.StartTable(1);
			IPlayMapMusic.AddType(builder, Type);
			return IPlayMapMusic.EndIPlayMapMusic(builder);
		}

		// Token: 0x06031492 RID: 201874 RVA: 0x006AF3B6 File Offset: 0x006AD5B6
		public static void StartIPlayMapMusic(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031493 RID: 201875 RVA: 0x006AF3BF File Offset: 0x006AD5BF
		public static void AddType(FlatBufferBuilder builder, EAkEventMap type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031494 RID: 201876 RVA: 0x006AF3CA File Offset: 0x006AD5CA
		public static Offset<IPlayMapMusic> EndIPlayMapMusic(FlatBufferBuilder builder)
		{
			return new Offset<IPlayMapMusic>(builder.EndTable());
		}

		// Token: 0x06031495 RID: 201877 RVA: 0x006AF3D8 File Offset: 0x006AD5D8
		public IPlayMapMusicT UnPack()
		{
			IPlayMapMusicT playMapMusicT = new IPlayMapMusicT();
			this.UnPackTo(playMapMusicT);
			return playMapMusicT;
		}

		// Token: 0x06031496 RID: 201878 RVA: 0x006AF3F3 File Offset: 0x006AD5F3
		public void UnPackTo(IPlayMapMusicT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031497 RID: 201879 RVA: 0x006AF404 File Offset: 0x006AD604
		public static Offset<IPlayMapMusic> Pack(FlatBufferBuilder builder, IPlayMapMusicT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayMapMusic>);
			}
			return IPlayMapMusic.CreateIPlayMapMusic(builder, _o.Type);
		}

		// Token: 0x040116AF RID: 71343
		private Table __p;
	}
}
