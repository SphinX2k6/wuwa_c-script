using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CE7 RID: 27879
	public struct IPlayEffect2 : IFlatbufferObject
	{
		// Token: 0x1700CFAA RID: 53162
		// (get) Token: 0x0603128F RID: 201359 RVA: 0x006ABAA8 File Offset: 0x006A9CA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031290 RID: 201360 RVA: 0x006ABAB5 File Offset: 0x006A9CB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031291 RID: 201361 RVA: 0x006ABABC File Offset: 0x006A9CBC
		public static IPlayEffect2 GetRootAsIPlayEffect2(ByteBuffer _bb)
		{
			return IPlayEffect2.GetRootAsIPlayEffect2(_bb, default(IPlayEffect2));
		}

		// Token: 0x06031292 RID: 201362 RVA: 0x006ABAD8 File Offset: 0x006A9CD8
		public static IPlayEffect2 GetRootAsIPlayEffect2(ByteBuffer _bb, IPlayEffect2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031293 RID: 201363 RVA: 0x006ABAF5 File Offset: 0x006A9CF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031294 RID: 201364 RVA: 0x006ABB04 File Offset: 0x006A9D04
		public IPlayEffect2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFAB RID: 53163
		// (get) Token: 0x06031295 RID: 201365 RVA: 0x006ABB14 File Offset: 0x006A9D14
		public EEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEffectType.Effect;
				}
				return (EEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CFAC RID: 53164
		// (get) Token: 0x06031296 RID: 201366 RVA: 0x006ABB50 File Offset: 0x006A9D50
		public string Path
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

		// Token: 0x06031297 RID: 201367 RVA: 0x006ABB87 File Offset: 0x006A9D87
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06031298 RID: 201368 RVA: 0x006ABB96 File Offset: 0x006A9D96
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06031299 RID: 201369 RVA: 0x006ABBA4 File Offset: 0x006A9DA4
		public static Offset<IPlayEffect2> CreateIPlayEffect2(FlatBufferBuilder builder, EEffectType Type = EEffectType.Effect, StringOffset PathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IPlayEffect2.AddPath(builder, PathOffset);
			IPlayEffect2.AddType(builder, Type);
			return IPlayEffect2.EndIPlayEffect2(builder);
		}

		// Token: 0x0603129A RID: 201370 RVA: 0x006ABBC1 File Offset: 0x006A9DC1
		public static void StartIPlayEffect2(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603129B RID: 201371 RVA: 0x006ABBCA File Offset: 0x006A9DCA
		public static void AddType(FlatBufferBuilder builder, EEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603129C RID: 201372 RVA: 0x006ABBD5 File Offset: 0x006A9DD5
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x0603129D RID: 201373 RVA: 0x006ABBE5 File Offset: 0x006A9DE5
		public static Offset<IPlayEffect2> EndIPlayEffect2(FlatBufferBuilder builder)
		{
			return new Offset<IPlayEffect2>(builder.EndTable());
		}

		// Token: 0x0603129E RID: 201374 RVA: 0x006ABBF4 File Offset: 0x006A9DF4
		public IPlayEffect2T UnPack()
		{
			IPlayEffect2T playEffect2T = new IPlayEffect2T();
			this.UnPackTo(playEffect2T);
			return playEffect2T;
		}

		// Token: 0x0603129F RID: 201375 RVA: 0x006ABC0F File Offset: 0x006A9E0F
		public void UnPackTo(IPlayEffect2T _o)
		{
			_o.Type = this.Type;
			_o.Path = this.Path;
		}

		// Token: 0x060312A0 RID: 201376 RVA: 0x006ABC2C File Offset: 0x006A9E2C
		public static Offset<IPlayEffect2> Pack(FlatBufferBuilder builder, IPlayEffect2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayEffect2>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			return IPlayEffect2.CreateIPlayEffect2(builder, _o.Type, pathOffset);
		}

		// Token: 0x0401165E RID: 71262
		private Table __p;
	}
}
