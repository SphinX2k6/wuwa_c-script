using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CD8 RID: 27864
	public struct IPlayCommonEffect : IFlatbufferObject
	{
		// Token: 0x1700CF79 RID: 53113
		// (get) Token: 0x060311D3 RID: 201171 RVA: 0x006AA138 File Offset: 0x006A8338
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060311D4 RID: 201172 RVA: 0x006AA145 File Offset: 0x006A8345
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060311D5 RID: 201173 RVA: 0x006AA14C File Offset: 0x006A834C
		public static IPlayCommonEffect GetRootAsIPlayCommonEffect(ByteBuffer _bb)
		{
			return IPlayCommonEffect.GetRootAsIPlayCommonEffect(_bb, default(IPlayCommonEffect));
		}

		// Token: 0x060311D6 RID: 201174 RVA: 0x006AA168 File Offset: 0x006A8368
		public static IPlayCommonEffect GetRootAsIPlayCommonEffect(ByteBuffer _bb, IPlayCommonEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060311D7 RID: 201175 RVA: 0x006AA185 File Offset: 0x006A8385
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060311D8 RID: 201176 RVA: 0x006AA194 File Offset: 0x006A8394
		public IPlayCommonEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF7A RID: 53114
		// (get) Token: 0x060311D9 RID: 201177 RVA: 0x006AA1A4 File Offset: 0x006A83A4
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

		// Token: 0x1700CF7B RID: 53115
		// (get) Token: 0x060311DA RID: 201178 RVA: 0x006AA1E0 File Offset: 0x006A83E0
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

		// Token: 0x060311DB RID: 201179 RVA: 0x006AA217 File Offset: 0x006A8417
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060311DC RID: 201180 RVA: 0x006AA226 File Offset: 0x006A8426
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700CF7C RID: 53116
		// (get) Token: 0x060311DD RID: 201181 RVA: 0x006AA234 File Offset: 0x006A8434
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

		// Token: 0x060311DE RID: 201182 RVA: 0x006AA270 File Offset: 0x006A8470
		public TTable? Pos2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060311DF RID: 201183 RVA: 0x006AA2B8 File Offset: 0x006A84B8
		public IAbsolutePos2 Pos2AsIAbsolutePos2()
		{
			return this.Pos2<IAbsolutePos2>().Value;
		}

		// Token: 0x060311E0 RID: 201184 RVA: 0x006AA2D4 File Offset: 0x006A84D4
		public IEffectEntityPos2 Pos2AsIEffectEntityPos2()
		{
			return this.Pos2<IEffectEntityPos2>().Value;
		}

		// Token: 0x060311E1 RID: 201185 RVA: 0x006AA2F0 File Offset: 0x006A84F0
		public IEffectPlayerPos2 Pos2AsIEffectPlayerPos2()
		{
			return this.Pos2<IEffectPlayerPos2>().Value;
		}

		// Token: 0x1700CF7D RID: 53117
		// (get) Token: 0x060311E2 RID: 201186 RVA: 0x006AA30C File Offset: 0x006A850C
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

		// Token: 0x1700CF7E RID: 53118
		// (get) Token: 0x060311E3 RID: 201187 RVA: 0x006AA350 File Offset: 0x006A8550
		public bool PlayEffectEnd
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CF7F RID: 53119
		// (get) Token: 0x060311E4 RID: 201188 RVA: 0x006AA390 File Offset: 0x006A8590
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

		// Token: 0x060311E5 RID: 201189 RVA: 0x006AA3D0 File Offset: 0x006A85D0
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

		// Token: 0x060311E6 RID: 201190 RVA: 0x006AA41F File Offset: 0x006A861F
		public static void StartIPlayCommonEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060311E7 RID: 201191 RVA: 0x006AA428 File Offset: 0x006A8628
		public static void AddType(FlatBufferBuilder builder, EEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060311E8 RID: 201192 RVA: 0x006AA433 File Offset: 0x006A8633
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x060311E9 RID: 201193 RVA: 0x006AA443 File Offset: 0x006A8643
		public static void AddPos2Type(FlatBufferBuilder builder, TEffectPos2 pos2Type)
		{
			builder.AddByte(2, (byte)pos2Type, 0);
		}

		// Token: 0x060311EA RID: 201194 RVA: 0x006AA44E File Offset: 0x006A864E
		public static void AddPos2(FlatBufferBuilder builder, int pos2Offset)
		{
			builder.AddOffset(3, pos2Offset, 0);
		}

		// Token: 0x060311EB RID: 201195 RVA: 0x006AA459 File Offset: 0x006A8659
		public static void AddDestroyTime(FlatBufferBuilder builder, float destroyTime)
		{
			builder.AddFloat(4, destroyTime, 0.0);
		}

		// Token: 0x060311EC RID: 201196 RVA: 0x006AA46C File Offset: 0x006A866C
		public static void AddPlayEffectEnd(FlatBufferBuilder builder, bool playEffectEnd)
		{
			builder.AddBool(5, playEffectEnd, false);
		}

		// Token: 0x060311ED RID: 201197 RVA: 0x006AA477 File Offset: 0x006A8677
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060311EE RID: 201198 RVA: 0x006AA482 File Offset: 0x006A8682
		public static Offset<IPlayCommonEffect> EndIPlayCommonEffect(FlatBufferBuilder builder)
		{
			return new Offset<IPlayCommonEffect>(builder.EndTable());
		}

		// Token: 0x060311EF RID: 201199 RVA: 0x006AA490 File Offset: 0x006A8690
		public IPlayCommonEffectT UnPack()
		{
			IPlayCommonEffectT playCommonEffectT = new IPlayCommonEffectT();
			this.UnPackTo(playCommonEffectT);
			return playCommonEffectT;
		}

		// Token: 0x060311F0 RID: 201200 RVA: 0x006AA4AC File Offset: 0x006A86AC
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

		// Token: 0x060311F1 RID: 201201 RVA: 0x006AA5D8 File Offset: 0x006A87D8
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

		// Token: 0x04011643 RID: 71235
		private Table __p;
	}
}
