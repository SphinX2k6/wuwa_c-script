using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CDE RID: 27870
	public struct IPlayDissolveEffect : IFlatbufferObject
	{
		// Token: 0x1700CF8F RID: 53135
		// (get) Token: 0x06031226 RID: 201254 RVA: 0x006AABF2 File Offset: 0x006A8DF2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031227 RID: 201255 RVA: 0x006AABFF File Offset: 0x006A8DFF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031228 RID: 201256 RVA: 0x006AAC08 File Offset: 0x006A8E08
		public static IPlayDissolveEffect GetRootAsIPlayDissolveEffect(ByteBuffer _bb)
		{
			return IPlayDissolveEffect.GetRootAsIPlayDissolveEffect(_bb, default(IPlayDissolveEffect));
		}

		// Token: 0x06031229 RID: 201257 RVA: 0x006AAC24 File Offset: 0x006A8E24
		public static IPlayDissolveEffect GetRootAsIPlayDissolveEffect(ByteBuffer _bb, IPlayDissolveEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603122A RID: 201258 RVA: 0x006AAC41 File Offset: 0x006A8E41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603122B RID: 201259 RVA: 0x006AAC50 File Offset: 0x006A8E50
		public IPlayDissolveEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF90 RID: 53136
		// (get) Token: 0x0603122C RID: 201260 RVA: 0x006AAC60 File Offset: 0x006A8E60
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

		// Token: 0x1700CF91 RID: 53137
		// (get) Token: 0x0603122D RID: 201261 RVA: 0x006AAC9C File Offset: 0x006A8E9C
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

		// Token: 0x0603122E RID: 201262 RVA: 0x006AACD3 File Offset: 0x006A8ED3
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603122F RID: 201263 RVA: 0x006AACE2 File Offset: 0x006A8EE2
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700CF92 RID: 53138
		// (get) Token: 0x06031230 RID: 201264 RVA: 0x006AACF0 File Offset: 0x006A8EF0
		public IVector2? ScreenPos
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVector2?(default(IVector2).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CF93 RID: 53139
		// (get) Token: 0x06031231 RID: 201265 RVA: 0x006AAD50 File Offset: 0x006A8F50
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CF94 RID: 53140
		// (get) Token: 0x06031232 RID: 201266 RVA: 0x006AAD94 File Offset: 0x006A8F94
		public float DissolveParam
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CF95 RID: 53141
		// (get) Token: 0x06031233 RID: 201267 RVA: 0x006AADD8 File Offset: 0x006A8FD8
		public float FadeInTime
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CF96 RID: 53142
		// (get) Token: 0x06031234 RID: 201268 RVA: 0x006AAE1C File Offset: 0x006A901C
		public float FadeOutTime
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CF97 RID: 53143
		// (get) Token: 0x06031235 RID: 201269 RVA: 0x006AAE60 File Offset: 0x006A9060
		public bool IsFullScreenMask
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CF98 RID: 53144
		// (get) Token: 0x06031236 RID: 201270 RVA: 0x006AAEA0 File Offset: 0x006A90A0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031237 RID: 201271 RVA: 0x006AAEE0 File Offset: 0x006A90E0
		public static Offset<IPlayDissolveEffect> CreateIPlayDissolveEffect(FlatBufferBuilder builder, EEffectType Type = EEffectType.Effect, StringOffset PathOffset = default(StringOffset), Offset<IVector2> ScreenPosOffset = default(Offset<IVector2>), float Scale = 0f, float DissolveParam = 0f, float FadeInTime = 0f, float FadeOutTime = 0f, bool IsFullScreenMask = false, byte NullMask = 0)
		{
			builder.StartTable(9);
			IPlayDissolveEffect.AddFadeOutTime(builder, FadeOutTime);
			IPlayDissolveEffect.AddFadeInTime(builder, FadeInTime);
			IPlayDissolveEffect.AddDissolveParam(builder, DissolveParam);
			IPlayDissolveEffect.AddScale(builder, Scale);
			IPlayDissolveEffect.AddScreenPos(builder, ScreenPosOffset);
			IPlayDissolveEffect.AddPath(builder, PathOffset);
			IPlayDissolveEffect.AddNullMask(builder, NullMask);
			IPlayDissolveEffect.AddIsFullScreenMask(builder, IsFullScreenMask);
			IPlayDissolveEffect.AddType(builder, Type);
			return IPlayDissolveEffect.EndIPlayDissolveEffect(builder);
		}

		// Token: 0x06031238 RID: 201272 RVA: 0x006AAF40 File Offset: 0x006A9140
		public static void StartIPlayDissolveEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06031239 RID: 201273 RVA: 0x006AAF4A File Offset: 0x006A914A
		public static void AddType(FlatBufferBuilder builder, EEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603123A RID: 201274 RVA: 0x006AAF55 File Offset: 0x006A9155
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x0603123B RID: 201275 RVA: 0x006AAF65 File Offset: 0x006A9165
		public static void AddScreenPos(FlatBufferBuilder builder, Offset<IVector2> screenPosOffset)
		{
			builder.AddOffset(2, screenPosOffset.Value, 0);
		}

		// Token: 0x0603123C RID: 201276 RVA: 0x006AAF75 File Offset: 0x006A9175
		public static void AddScale(FlatBufferBuilder builder, float scale)
		{
			builder.AddFloat(3, scale, 0.0);
		}

		// Token: 0x0603123D RID: 201277 RVA: 0x006AAF88 File Offset: 0x006A9188
		public static void AddDissolveParam(FlatBufferBuilder builder, float dissolveParam)
		{
			builder.AddFloat(4, dissolveParam, 0.0);
		}

		// Token: 0x0603123E RID: 201278 RVA: 0x006AAF9B File Offset: 0x006A919B
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(5, fadeInTime, 0.0);
		}

		// Token: 0x0603123F RID: 201279 RVA: 0x006AAFAE File Offset: 0x006A91AE
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(6, fadeOutTime, 0.0);
		}

		// Token: 0x06031240 RID: 201280 RVA: 0x006AAFC1 File Offset: 0x006A91C1
		public static void AddIsFullScreenMask(FlatBufferBuilder builder, bool isFullScreenMask)
		{
			builder.AddBool(7, isFullScreenMask, false);
		}

		// Token: 0x06031241 RID: 201281 RVA: 0x006AAFCC File Offset: 0x006A91CC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06031242 RID: 201282 RVA: 0x006AAFD7 File Offset: 0x006A91D7
		public static Offset<IPlayDissolveEffect> EndIPlayDissolveEffect(FlatBufferBuilder builder)
		{
			return new Offset<IPlayDissolveEffect>(builder.EndTable());
		}

		// Token: 0x06031243 RID: 201283 RVA: 0x006AAFE4 File Offset: 0x006A91E4
		public IPlayDissolveEffectT UnPack()
		{
			IPlayDissolveEffectT playDissolveEffectT = new IPlayDissolveEffectT();
			this.UnPackTo(playDissolveEffectT);
			return playDissolveEffectT;
		}

		// Token: 0x06031244 RID: 201284 RVA: 0x006AB000 File Offset: 0x006A9200
		public void UnPackTo(IPlayDissolveEffectT _o)
		{
			_o.Type = this.Type;
			_o.Path = this.Path;
			_o.ScreenPos = ((this.ScreenPos != null) ? this.ScreenPos.Value.UnPack() : null);
			_o.Scale = this.Scale;
			_o.DissolveParam = this.DissolveParam;
			_o.FadeInTime = this.FadeInTime;
			_o.FadeOutTime = this.FadeOutTime;
			_o.IsFullScreenMask = this.IsFullScreenMask;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031245 RID: 201285 RVA: 0x006AB09C File Offset: 0x006A929C
		public static Offset<IPlayDissolveEffect> Pack(FlatBufferBuilder builder, IPlayDissolveEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayDissolveEffect>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			Offset<IVector2> screenPosOffset = (_o.ScreenPos == null) ? default(Offset<IVector2>) : IVector2.Pack(builder, _o.ScreenPos);
			return IPlayDissolveEffect.CreateIPlayDissolveEffect(builder, _o.Type, pathOffset, screenPosOffset, _o.Scale, _o.DissolveParam, _o.FadeInTime, _o.FadeOutTime, _o.IsFullScreenMask, _o.NullMask);
		}

		// Token: 0x0401164F RID: 71247
		private Table __p;
	}
}
