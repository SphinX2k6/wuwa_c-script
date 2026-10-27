using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CE4 RID: 27876
	public struct IPlayEffect : IFlatbufferObject
	{
		// Token: 0x1700CFA5 RID: 53157
		// (get) Token: 0x06031270 RID: 201328 RVA: 0x006AB5E5 File Offset: 0x006A97E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031271 RID: 201329 RVA: 0x006AB5F2 File Offset: 0x006A97F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031272 RID: 201330 RVA: 0x006AB5FC File Offset: 0x006A97FC
		public static IPlayEffect GetRootAsIPlayEffect(ByteBuffer _bb)
		{
			return IPlayEffect.GetRootAsIPlayEffect(_bb, default(IPlayEffect));
		}

		// Token: 0x06031273 RID: 201331 RVA: 0x006AB618 File Offset: 0x006A9818
		public static IPlayEffect GetRootAsIPlayEffect(ByteBuffer _bb, IPlayEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031274 RID: 201332 RVA: 0x006AB635 File Offset: 0x006A9835
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031275 RID: 201333 RVA: 0x006AB644 File Offset: 0x006A9844
		public IPlayEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFA6 RID: 53158
		// (get) Token: 0x06031276 RID: 201334 RVA: 0x006AB654 File Offset: 0x006A9854
		public string Path
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031277 RID: 201335 RVA: 0x006AB68B File Offset: 0x006A988B
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06031278 RID: 201336 RVA: 0x006AB69A File Offset: 0x006A989A
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700CFA7 RID: 53159
		// (get) Token: 0x06031279 RID: 201337 RVA: 0x006AB6A8 File Offset: 0x006A98A8
		public TPos2 Pos2Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TPos2.NONE;
				}
				return (TPos2)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603127A RID: 201338 RVA: 0x006AB6E4 File Offset: 0x006A98E4
		public TTable? Pos2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603127B RID: 201339 RVA: 0x006AB728 File Offset: 0x006A9928
		public IAbsolutePos2 Pos2AsIAbsolutePos2()
		{
			return this.Pos2<IAbsolutePos2>().Value;
		}

		// Token: 0x0603127C RID: 201340 RVA: 0x006AB744 File Offset: 0x006A9944
		public IEntityPos2 Pos2AsIEntityPos2()
		{
			return this.Pos2<IEntityPos2>().Value;
		}

		// Token: 0x0603127D RID: 201341 RVA: 0x006AB760 File Offset: 0x006A9960
		public IPlayerPos2 Pos2AsIPlayerPos2()
		{
			return this.Pos2<IPlayerPos2>().Value;
		}

		// Token: 0x0603127E RID: 201342 RVA: 0x006AB77C File Offset: 0x006A997C
		public IEffectPlayerPos2 Pos2AsIEffectPlayerPos2()
		{
			return this.Pos2<IEffectPlayerPos2>().Value;
		}

		// Token: 0x0603127F RID: 201343 RVA: 0x006AB798 File Offset: 0x006A9998
		public IEffectEntityPos2 Pos2AsIEffectEntityPos2()
		{
			return this.Pos2<IEffectEntityPos2>().Value;
		}

		// Token: 0x06031280 RID: 201344 RVA: 0x006AB7B3 File Offset: 0x006A99B3
		public static Offset<IPlayEffect> CreateIPlayEffect(FlatBufferBuilder builder, StringOffset PathOffset = default(StringOffset), TPos2 Pos2_type = TPos2.NONE, int Pos2Offset = 0)
		{
			builder.StartTable(3);
			IPlayEffect.AddPos2(builder, Pos2Offset);
			IPlayEffect.AddPath(builder, PathOffset);
			IPlayEffect.AddPos2Type(builder, Pos2_type);
			return IPlayEffect.EndIPlayEffect(builder);
		}

		// Token: 0x06031281 RID: 201345 RVA: 0x006AB7D7 File Offset: 0x006A99D7
		public static void StartIPlayEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06031282 RID: 201346 RVA: 0x006AB7E0 File Offset: 0x006A99E0
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(0, pathOffset.Value, 0);
		}

		// Token: 0x06031283 RID: 201347 RVA: 0x006AB7F0 File Offset: 0x006A99F0
		public static void AddPos2Type(FlatBufferBuilder builder, TPos2 pos2Type)
		{
			builder.AddByte(1, (byte)pos2Type, 0);
		}

		// Token: 0x06031284 RID: 201348 RVA: 0x006AB7FB File Offset: 0x006A99FB
		public static void AddPos2(FlatBufferBuilder builder, int pos2Offset)
		{
			builder.AddOffset(2, pos2Offset, 0);
		}

		// Token: 0x06031285 RID: 201349 RVA: 0x006AB806 File Offset: 0x006A9A06
		public static Offset<IPlayEffect> EndIPlayEffect(FlatBufferBuilder builder)
		{
			return new Offset<IPlayEffect>(builder.EndTable());
		}

		// Token: 0x06031286 RID: 201350 RVA: 0x006AB814 File Offset: 0x006A9A14
		public IPlayEffectT UnPack()
		{
			IPlayEffectT playEffectT = new IPlayEffectT();
			this.UnPackTo(playEffectT);
			return playEffectT;
		}

		// Token: 0x06031287 RID: 201351 RVA: 0x006AB830 File Offset: 0x006A9A30
		public void UnPackTo(IPlayEffectT _o)
		{
			_o.Path = this.Path;
			_o.Pos2 = new TPos2Union();
			_o.Pos2.Type = this.Pos2Type;
			switch (this.Pos2Type)
			{
			case TPos2.IAbsolutePos2:
				_o.Pos2.Value = ((this.Pos2<IAbsolutePos2>() != null) ? this.Pos2<IAbsolutePos2>().Value.UnPack() : null);
				return;
			case TPos2.IEntityPos2:
				_o.Pos2.Value = ((this.Pos2<IEntityPos2>() != null) ? this.Pos2<IEntityPos2>().Value.UnPack() : null);
				return;
			case TPos2.IPlayerPos2:
				_o.Pos2.Value = ((this.Pos2<IPlayerPos2>() != null) ? this.Pos2<IPlayerPos2>().Value.UnPack() : null);
				return;
			case TPos2.IEffectPlayerPos2:
				_o.Pos2.Value = ((this.Pos2<IEffectPlayerPos2>() != null) ? this.Pos2<IEffectPlayerPos2>().Value.UnPack() : null);
				return;
			case TPos2.IEffectEntityPos2:
				_o.Pos2.Value = ((this.Pos2<IEffectEntityPos2>() != null) ? this.Pos2<IEffectEntityPos2>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06031288 RID: 201352 RVA: 0x006AB99C File Offset: 0x006A9B9C
		public static Offset<IPlayEffect> Pack(FlatBufferBuilder builder, IPlayEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayEffect>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			TPos2 pos2_type = (_o.Pos2 == null) ? TPos2.NONE : _o.Pos2.Type;
			int pos2Offset = (_o.Pos2 == null) ? 0 : TPos2Union.Pack(builder, _o.Pos2);
			return IPlayEffect.CreateIPlayEffect(builder, pathOffset, pos2_type, pos2Offset);
		}

		// Token: 0x0401165B RID: 71259
		private Table __p;
	}
}
