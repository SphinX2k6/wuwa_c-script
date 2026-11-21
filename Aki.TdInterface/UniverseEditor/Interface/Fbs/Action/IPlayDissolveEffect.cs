using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007451 RID: 29777
	public struct IPlayDissolveEffect : IFlatbufferObject
	{
		// Token: 0x1700DAC9 RID: 56009
		// (get) Token: 0x060341EB RID: 213483 RVA: 0x00705CAE File Offset: 0x00703EAE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060341EC RID: 213484 RVA: 0x00705CBB File Offset: 0x00703EBB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060341ED RID: 213485 RVA: 0x00705CC4 File Offset: 0x00703EC4
		public static IPlayDissolveEffect GetRootAsIPlayDissolveEffect(ByteBuffer _bb)
		{
			return IPlayDissolveEffect.GetRootAsIPlayDissolveEffect(_bb, default(IPlayDissolveEffect));
		}

		// Token: 0x060341EE RID: 213486 RVA: 0x00705CE0 File Offset: 0x00703EE0
		public static IPlayDissolveEffect GetRootAsIPlayDissolveEffect(ByteBuffer _bb, IPlayDissolveEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060341EF RID: 213487 RVA: 0x00705CFD File Offset: 0x00703EFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060341F0 RID: 213488 RVA: 0x00705D0C File Offset: 0x00703F0C
		public IPlayDissolveEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DACA RID: 56010
		// (get) Token: 0x060341F1 RID: 213489 RVA: 0x00705D1C File Offset: 0x00703F1C
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

		// Token: 0x1700DACB RID: 56011
		// (get) Token: 0x060341F2 RID: 213490 RVA: 0x00705D58 File Offset: 0x00703F58
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

		// Token: 0x060341F3 RID: 213491 RVA: 0x00705D8F File Offset: 0x00703F8F
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060341F4 RID: 213492 RVA: 0x00705D9E File Offset: 0x00703F9E
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700DACC RID: 56012
		// (get) Token: 0x060341F5 RID: 213493 RVA: 0x00705DAC File Offset: 0x00703FAC
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

		// Token: 0x1700DACD RID: 56013
		// (get) Token: 0x060341F6 RID: 213494 RVA: 0x00705E0C File Offset: 0x0070400C
		public IPlayDissolveEffectInActorPosConfig? PlayInActorPos
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IPlayDissolveEffectInActorPosConfig?(default(IPlayDissolveEffectInActorPosConfig).__assign(num + this.__p.bb_pos, this.__p.bb));
			}
		}

		// Token: 0x1700DACE RID: 56014
		// (get) Token: 0x060341F7 RID: 213495 RVA: 0x00705E60 File Offset: 0x00704060
		public float Scale
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

		// Token: 0x1700DACF RID: 56015
		// (get) Token: 0x060341F8 RID: 213496 RVA: 0x00705EA4 File Offset: 0x007040A4
		public float DissolveParam
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

		// Token: 0x1700DAD0 RID: 56016
		// (get) Token: 0x060341F9 RID: 213497 RVA: 0x00705EE8 File Offset: 0x007040E8
		public float FadeInTime
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

		// Token: 0x1700DAD1 RID: 56017
		// (get) Token: 0x060341FA RID: 213498 RVA: 0x00705F2C File Offset: 0x0070412C
		public float FadeOutTime
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DAD2 RID: 56018
		// (get) Token: 0x060341FB RID: 213499 RVA: 0x00705F70 File Offset: 0x00704170
		public bool IsFullScreenMask
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DAD3 RID: 56019
		// (get) Token: 0x060341FC RID: 213500 RVA: 0x00705FB0 File Offset: 0x007041B0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060341FD RID: 213501 RVA: 0x00705FF0 File Offset: 0x007041F0
		public static Offset<IPlayDissolveEffect> CreateIPlayDissolveEffect(FlatBufferBuilder builder, EEffectType Type = EEffectType.Effect, StringOffset PathOffset = default(StringOffset), Offset<IVector2> ScreenPosOffset = default(Offset<IVector2>), IPlayDissolveEffectInActorPosConfigT PlayInActorPos = null, float Scale = 0f, float DissolveParam = 0f, float FadeInTime = 0f, float FadeOutTime = 0f, bool IsFullScreenMask = false, byte NullMask = 0)
		{
			builder.StartTable(10);
			IPlayDissolveEffect.AddFadeOutTime(builder, FadeOutTime);
			IPlayDissolveEffect.AddFadeInTime(builder, FadeInTime);
			IPlayDissolveEffect.AddDissolveParam(builder, DissolveParam);
			IPlayDissolveEffect.AddScale(builder, Scale);
			IPlayDissolveEffect.AddPlayInActorPos(builder, IPlayDissolveEffectInActorPosConfig.Pack(builder, PlayInActorPos));
			IPlayDissolveEffect.AddScreenPos(builder, ScreenPosOffset);
			IPlayDissolveEffect.AddPath(builder, PathOffset);
			IPlayDissolveEffect.AddNullMask(builder, NullMask);
			IPlayDissolveEffect.AddIsFullScreenMask(builder, IsFullScreenMask);
			IPlayDissolveEffect.AddType(builder, Type);
			return IPlayDissolveEffect.EndIPlayDissolveEffect(builder);
		}

		// Token: 0x060341FE RID: 213502 RVA: 0x0070605E File Offset: 0x0070425E
		public static void StartIPlayDissolveEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x060341FF RID: 213503 RVA: 0x00706068 File Offset: 0x00704268
		public static void AddType(FlatBufferBuilder builder, EEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034200 RID: 213504 RVA: 0x00706073 File Offset: 0x00704273
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x06034201 RID: 213505 RVA: 0x00706083 File Offset: 0x00704283
		public static void AddScreenPos(FlatBufferBuilder builder, Offset<IVector2> screenPosOffset)
		{
			builder.AddOffset(2, screenPosOffset.Value, 0);
		}

		// Token: 0x06034202 RID: 213506 RVA: 0x00706093 File Offset: 0x00704293
		public static void AddPlayInActorPos(FlatBufferBuilder builder, Offset<IPlayDissolveEffectInActorPosConfig> playInActorPosOffset)
		{
			builder.AddStruct(3, playInActorPosOffset.Value, 0);
		}

		// Token: 0x06034203 RID: 213507 RVA: 0x007060A3 File Offset: 0x007042A3
		public static void AddScale(FlatBufferBuilder builder, float scale)
		{
			builder.AddFloat(4, scale, 0.0);
		}

		// Token: 0x06034204 RID: 213508 RVA: 0x007060B6 File Offset: 0x007042B6
		public static void AddDissolveParam(FlatBufferBuilder builder, float dissolveParam)
		{
			builder.AddFloat(5, dissolveParam, 0.0);
		}

		// Token: 0x06034205 RID: 213509 RVA: 0x007060C9 File Offset: 0x007042C9
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(6, fadeInTime, 0.0);
		}

		// Token: 0x06034206 RID: 213510 RVA: 0x007060DC File Offset: 0x007042DC
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(7, fadeOutTime, 0.0);
		}

		// Token: 0x06034207 RID: 213511 RVA: 0x007060EF File Offset: 0x007042EF
		public static void AddIsFullScreenMask(FlatBufferBuilder builder, bool isFullScreenMask)
		{
			builder.AddBool(8, isFullScreenMask, false);
		}

		// Token: 0x06034208 RID: 213512 RVA: 0x007060FA File Offset: 0x007042FA
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x06034209 RID: 213513 RVA: 0x00706106 File Offset: 0x00704306
		public static Offset<IPlayDissolveEffect> EndIPlayDissolveEffect(FlatBufferBuilder builder)
		{
			return new Offset<IPlayDissolveEffect>(builder.EndTable());
		}

		// Token: 0x0603420A RID: 213514 RVA: 0x00706114 File Offset: 0x00704314
		public IPlayDissolveEffectT UnPack()
		{
			IPlayDissolveEffectT playDissolveEffectT = new IPlayDissolveEffectT();
			this.UnPackTo(playDissolveEffectT);
			return playDissolveEffectT;
		}

		// Token: 0x0603420B RID: 213515 RVA: 0x00706130 File Offset: 0x00704330
		public void UnPackTo(IPlayDissolveEffectT _o)
		{
			_o.Type = this.Type;
			_o.Path = this.Path;
			_o.ScreenPos = ((this.ScreenPos != null) ? this.ScreenPos.Value.UnPack() : null);
			_o.PlayInActorPos = ((this.PlayInActorPos != null) ? this.PlayInActorPos.Value.UnPack() : null);
			_o.Scale = this.Scale;
			_o.DissolveParam = this.DissolveParam;
			_o.FadeInTime = this.FadeInTime;
			_o.FadeOutTime = this.FadeOutTime;
			_o.IsFullScreenMask = this.IsFullScreenMask;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603420C RID: 213516 RVA: 0x007061FC File Offset: 0x007043FC
		public static Offset<IPlayDissolveEffect> Pack(FlatBufferBuilder builder, IPlayDissolveEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayDissolveEffect>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			Offset<IVector2> screenPosOffset = (_o.ScreenPos == null) ? default(Offset<IVector2>) : IVector2.Pack(builder, _o.ScreenPos);
			return IPlayDissolveEffect.CreateIPlayDissolveEffect(builder, _o.Type, pathOffset, screenPosOffset, _o.PlayInActorPos, _o.Scale, _o.DissolveParam, _o.FadeInTime, _o.FadeOutTime, _o.IsFullScreenMask, _o.NullMask);
		}

		// Token: 0x040125BD RID: 75197
		private Table __p;
	}
}
