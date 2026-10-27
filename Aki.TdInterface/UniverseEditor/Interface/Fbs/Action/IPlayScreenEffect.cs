using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D3B RID: 27963
	public struct IPlayScreenEffect : IFlatbufferObject
	{
		// Token: 0x1700D076 RID: 53366
		// (get) Token: 0x060315AB RID: 202155 RVA: 0x006B19DC File Offset: 0x006AFBDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060315AC RID: 202156 RVA: 0x006B19E9 File Offset: 0x006AFBE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060315AD RID: 202157 RVA: 0x006B19F0 File Offset: 0x006AFBF0
		public static IPlayScreenEffect GetRootAsIPlayScreenEffect(ByteBuffer _bb)
		{
			return IPlayScreenEffect.GetRootAsIPlayScreenEffect(_bb, default(IPlayScreenEffect));
		}

		// Token: 0x060315AE RID: 202158 RVA: 0x006B1A0C File Offset: 0x006AFC0C
		public static IPlayScreenEffect GetRootAsIPlayScreenEffect(ByteBuffer _bb, IPlayScreenEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060315AF RID: 202159 RVA: 0x006B1A29 File Offset: 0x006AFC29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060315B0 RID: 202160 RVA: 0x006B1A38 File Offset: 0x006AFC38
		public IPlayScreenEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D077 RID: 53367
		// (get) Token: 0x060315B1 RID: 202161 RVA: 0x006B1A48 File Offset: 0x006AFC48
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

		// Token: 0x1700D078 RID: 53368
		// (get) Token: 0x060315B2 RID: 202162 RVA: 0x006B1A84 File Offset: 0x006AFC84
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

		// Token: 0x060315B3 RID: 202163 RVA: 0x006B1ABB File Offset: 0x006AFCBB
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060315B4 RID: 202164 RVA: 0x006B1ACA File Offset: 0x006AFCCA
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D079 RID: 53369
		// (get) Token: 0x060315B5 RID: 202165 RVA: 0x006B1AD8 File Offset: 0x006AFCD8
		public float DestroyTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D07A RID: 53370
		// (get) Token: 0x060315B6 RID: 202166 RVA: 0x006B1B18 File Offset: 0x006AFD18
		public string BindSubScreenKey
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060315B7 RID: 202167 RVA: 0x006B1B50 File Offset: 0x006AFD50
		public Span<byte> GetBindSubScreenKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060315B8 RID: 202168 RVA: 0x006B1B60 File Offset: 0x006AFD60
		public byte[] GetBindSubScreenKeyArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700D07B RID: 53371
		// (get) Token: 0x060315B9 RID: 202169 RVA: 0x006B1B70 File Offset: 0x006AFD70
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060315BA RID: 202170 RVA: 0x006B1BAD File Offset: 0x006AFDAD
		public static Offset<IPlayScreenEffect> CreateIPlayScreenEffect(FlatBufferBuilder builder, EEffectType Type = EEffectType.Effect, StringOffset PathOffset = default(StringOffset), float DestroyTime = 0f, StringOffset BindSubScreenKeyOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IPlayScreenEffect.AddBindSubScreenKey(builder, BindSubScreenKeyOffset);
			IPlayScreenEffect.AddDestroyTime(builder, DestroyTime);
			IPlayScreenEffect.AddPath(builder, PathOffset);
			IPlayScreenEffect.AddNullMask(builder, NullMask);
			IPlayScreenEffect.AddType(builder, Type);
			return IPlayScreenEffect.EndIPlayScreenEffect(builder);
		}

		// Token: 0x060315BB RID: 202171 RVA: 0x006B1BE1 File Offset: 0x006AFDE1
		public static void StartIPlayScreenEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060315BC RID: 202172 RVA: 0x006B1BEA File Offset: 0x006AFDEA
		public static void AddType(FlatBufferBuilder builder, EEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060315BD RID: 202173 RVA: 0x006B1BF5 File Offset: 0x006AFDF5
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x060315BE RID: 202174 RVA: 0x006B1C05 File Offset: 0x006AFE05
		public static void AddDestroyTime(FlatBufferBuilder builder, float destroyTime)
		{
			builder.AddFloat(2, destroyTime, 0.0);
		}

		// Token: 0x060315BF RID: 202175 RVA: 0x006B1C18 File Offset: 0x006AFE18
		public static void AddBindSubScreenKey(FlatBufferBuilder builder, StringOffset bindSubScreenKeyOffset)
		{
			builder.AddOffset(3, bindSubScreenKeyOffset.Value, 0);
		}

		// Token: 0x060315C0 RID: 202176 RVA: 0x006B1C28 File Offset: 0x006AFE28
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060315C1 RID: 202177 RVA: 0x006B1C33 File Offset: 0x006AFE33
		public static Offset<IPlayScreenEffect> EndIPlayScreenEffect(FlatBufferBuilder builder)
		{
			return new Offset<IPlayScreenEffect>(builder.EndTable());
		}

		// Token: 0x060315C2 RID: 202178 RVA: 0x006B1C40 File Offset: 0x006AFE40
		public IPlayScreenEffectT UnPack()
		{
			IPlayScreenEffectT playScreenEffectT = new IPlayScreenEffectT();
			this.UnPackTo(playScreenEffectT);
			return playScreenEffectT;
		}

		// Token: 0x060315C3 RID: 202179 RVA: 0x006B1C5B File Offset: 0x006AFE5B
		public void UnPackTo(IPlayScreenEffectT _o)
		{
			_o.Type = this.Type;
			_o.Path = this.Path;
			_o.DestroyTime = this.DestroyTime;
			_o.BindSubScreenKey = this.BindSubScreenKey;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060315C4 RID: 202180 RVA: 0x006B1C9C File Offset: 0x006AFE9C
		public static Offset<IPlayScreenEffect> Pack(FlatBufferBuilder builder, IPlayScreenEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayScreenEffect>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			StringOffset bindSubScreenKeyOffset = (_o.BindSubScreenKey == null) ? default(StringOffset) : builder.CreateString(_o.BindSubScreenKey);
			return IPlayScreenEffect.CreateIPlayScreenEffect(builder, _o.Type, pathOffset, _o.DestroyTime, bindSubScreenKeyOffset, _o.NullMask);
		}

		// Token: 0x040116DF RID: 71391
		private Table __p;
	}
}
