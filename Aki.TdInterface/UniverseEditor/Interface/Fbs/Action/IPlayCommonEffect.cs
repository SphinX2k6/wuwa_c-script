using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200744B RID: 29771
	public struct IPlayCommonEffect : IFlatbufferObject
	{
		// Token: 0x1700DAB3 RID: 55987
		// (get) Token: 0x06034198 RID: 213400 RVA: 0x007051F4 File Offset: 0x007033F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034199 RID: 213401 RVA: 0x00705201 File Offset: 0x00703401
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603419A RID: 213402 RVA: 0x00705208 File Offset: 0x00703408
		public static IPlayCommonEffect GetRootAsIPlayCommonEffect(ByteBuffer _bb)
		{
			return IPlayCommonEffect.GetRootAsIPlayCommonEffect(_bb, default(IPlayCommonEffect));
		}

		// Token: 0x0603419B RID: 213403 RVA: 0x00705224 File Offset: 0x00703424
		public static IPlayCommonEffect GetRootAsIPlayCommonEffect(ByteBuffer _bb, IPlayCommonEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603419C RID: 213404 RVA: 0x00705241 File Offset: 0x00703441
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603419D RID: 213405 RVA: 0x00705250 File Offset: 0x00703450
		public IPlayCommonEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DAB4 RID: 55988
		// (get) Token: 0x0603419E RID: 213406 RVA: 0x00705260 File Offset: 0x00703460
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

		// Token: 0x1700DAB5 RID: 55989
		// (get) Token: 0x0603419F RID: 213407 RVA: 0x0070529C File Offset: 0x0070349C
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

		// Token: 0x060341A0 RID: 213408 RVA: 0x007052D3 File Offset: 0x007034D3
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060341A1 RID: 213409 RVA: 0x007052E2 File Offset: 0x007034E2
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700DAB6 RID: 55990
		// (get) Token: 0x060341A2 RID: 213410 RVA: 0x007052F0 File Offset: 0x007034F0
		public TEffectPos2 Pos2Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TEffectPos2.NONE;
				}
				return (TEffectPos2)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060341A3 RID: 213411 RVA: 0x0070532C File Offset: 0x0070352C
		public TTable? Pos2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060341A4 RID: 213412 RVA: 0x00705374 File Offset: 0x00703574
		public IAbsolutePos2 Pos2AsIAbsolutePos2()
		{
			return this.Pos2<IAbsolutePos2>().Value;
		}

		// Token: 0x060341A5 RID: 213413 RVA: 0x00705390 File Offset: 0x00703590
		public IEffectEntityPos2 Pos2AsIEffectEntityPos2()
		{
			return this.Pos2<IEffectEntityPos2>().Value;
		}

		// Token: 0x060341A6 RID: 213414 RVA: 0x007053AC File Offset: 0x007035AC
		public IEffectPlayerPos2 Pos2AsIEffectPlayerPos2()
		{
			return this.Pos2<IEffectPlayerPos2>().Value;
		}

		// Token: 0x1700DAB7 RID: 55991
		// (get) Token: 0x060341A7 RID: 213415 RVA: 0x007053C8 File Offset: 0x007035C8
		public float DestroyTime
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

		// Token: 0x1700DAB8 RID: 55992
		// (get) Token: 0x060341A8 RID: 213416 RVA: 0x0070540C File Offset: 0x0070360C
		public bool PlayEffectEnd
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DAB9 RID: 55993
		// (get) Token: 0x060341A9 RID: 213417 RVA: 0x0070544C File Offset: 0x0070364C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060341AA RID: 213418 RVA: 0x0070548C File Offset: 0x0070368C
		public static Offset<IPlayCommonEffect> CreateIPlayCommonEffect(FlatBufferBuilder builder, EEffectType Type = EEffectType.Effect, StringOffset PathOffset = default(StringOffset), TEffectPos2 Pos2_type = TEffectPos2.NONE, int Pos2Offset = 0, float DestroyTime = 0f, bool PlayEffectEnd = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			IPlayCommonEffect.AddDestroyTime(builder, DestroyTime);
			IPlayCommonEffect.AddPos2(builder, Pos2Offset);
			IPlayCommonEffect.AddPath(builder, PathOffset);
			IPlayCommonEffect.AddNullMask(builder, NullMask);
			IPlayCommonEffect.AddPlayEffectEnd(builder, PlayEffectEnd);
			IPlayCommonEffect.AddPos2Type(builder, Pos2_type);
			IPlayCommonEffect.AddType(builder, Type);
			return IPlayCommonEffect.EndIPlayCommonEffect(builder);
		}

		// Token: 0x060341AB RID: 213419 RVA: 0x007054DB File Offset: 0x007036DB
		public static void StartIPlayCommonEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060341AC RID: 213420 RVA: 0x007054E4 File Offset: 0x007036E4
		public static void AddType(FlatBufferBuilder builder, EEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060341AD RID: 213421 RVA: 0x007054EF File Offset: 0x007036EF
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x060341AE RID: 213422 RVA: 0x007054FF File Offset: 0x007036FF
		public static void AddPos2Type(FlatBufferBuilder builder, TEffectPos2 pos2Type)
		{
			builder.AddByte(2, (byte)pos2Type, 0);
		}

		// Token: 0x060341AF RID: 213423 RVA: 0x0070550A File Offset: 0x0070370A
		public static void AddPos2(FlatBufferBuilder builder, int pos2Offset)
		{
			builder.AddOffset(3, pos2Offset, 0);
		}

		// Token: 0x060341B0 RID: 213424 RVA: 0x00705515 File Offset: 0x00703715
		public static void AddDestroyTime(FlatBufferBuilder builder, float destroyTime)
		{
			builder.AddFloat(4, destroyTime, 0.0);
		}

		// Token: 0x060341B1 RID: 213425 RVA: 0x00705528 File Offset: 0x00703728
		public static void AddPlayEffectEnd(FlatBufferBuilder builder, bool playEffectEnd)
		{
			builder.AddBool(5, playEffectEnd, false);
		}

		// Token: 0x060341B2 RID: 213426 RVA: 0x00705533 File Offset: 0x00703733
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060341B3 RID: 213427 RVA: 0x0070553E File Offset: 0x0070373E
		public static Offset<IPlayCommonEffect> EndIPlayCommonEffect(FlatBufferBuilder builder)
		{
			return new Offset<IPlayCommonEffect>(builder.EndTable());
		}

		// Token: 0x060341B4 RID: 213428 RVA: 0x0070554C File Offset: 0x0070374C
		public IPlayCommonEffectT UnPack()
		{
			IPlayCommonEffectT playCommonEffectT = new IPlayCommonEffectT();
			this.UnPackTo(playCommonEffectT);
			return playCommonEffectT;
		}

		// Token: 0x060341B5 RID: 213429 RVA: 0x00705568 File Offset: 0x00703768
		public void UnPackTo(IPlayCommonEffectT _o)
		{
			_o.Type = this.Type;
			_o.Path = this.Path;
			_o.Pos2 = new TEffectPos2Union();
			_o.Pos2.Type = this.Pos2Type;
			switch (this.Pos2Type)
			{
			case TEffectPos2.IAbsolutePos2:
				_o.Pos2.Value = ((this.Pos2<IAbsolutePos2>() != null) ? this.Pos2<IAbsolutePos2>().Value.UnPack() : null);
				break;
			case TEffectPos2.IEffectEntityPos2:
				_o.Pos2.Value = ((this.Pos2<IEffectEntityPos2>() != null) ? this.Pos2<IEffectEntityPos2>().Value.UnPack() : null);
				break;
			case TEffectPos2.IEffectPlayerPos2:
				_o.Pos2.Value = ((this.Pos2<IEffectPlayerPos2>() != null) ? this.Pos2<IEffectPlayerPos2>().Value.UnPack() : null);
				break;
			}
			_o.DestroyTime = this.DestroyTime;
			_o.PlayEffectEnd = this.PlayEffectEnd;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060341B6 RID: 213430 RVA: 0x00705694 File Offset: 0x00703894
		public static Offset<IPlayCommonEffect> Pack(FlatBufferBuilder builder, IPlayCommonEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayCommonEffect>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			TEffectPos2 pos2_type = (_o.Pos2 == null) ? TEffectPos2.NONE : _o.Pos2.Type;
			int pos2Offset = (_o.Pos2 == null) ? 0 : TEffectPos2Union.Pack(builder, _o.Pos2);
			return IPlayCommonEffect.CreateIPlayCommonEffect(builder, _o.Type, pathOffset, pos2_type, pos2Offset, _o.DestroyTime, _o.PlayEffectEnd, _o.NullMask);
		}

		// Token: 0x040125B1 RID: 75185
		private Table __p;
	}
}
