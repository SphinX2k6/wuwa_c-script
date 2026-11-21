using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007459 RID: 29785
	public struct IPlayEffect : IFlatbufferObject
	{
		// Token: 0x1700DAE4 RID: 56036
		// (get) Token: 0x06034244 RID: 213572 RVA: 0x00706855 File Offset: 0x00704A55
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034245 RID: 213573 RVA: 0x00706862 File Offset: 0x00704A62
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034246 RID: 213574 RVA: 0x0070686C File Offset: 0x00704A6C
		public static IPlayEffect GetRootAsIPlayEffect(ByteBuffer _bb)
		{
			return IPlayEffect.GetRootAsIPlayEffect(_bb, default(IPlayEffect));
		}

		// Token: 0x06034247 RID: 213575 RVA: 0x00706888 File Offset: 0x00704A88
		public static IPlayEffect GetRootAsIPlayEffect(ByteBuffer _bb, IPlayEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034248 RID: 213576 RVA: 0x007068A5 File Offset: 0x00704AA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034249 RID: 213577 RVA: 0x007068B4 File Offset: 0x00704AB4
		public IPlayEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DAE5 RID: 56037
		// (get) Token: 0x0603424A RID: 213578 RVA: 0x007068C4 File Offset: 0x00704AC4
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

		// Token: 0x0603424B RID: 213579 RVA: 0x007068FB File Offset: 0x00704AFB
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0603424C RID: 213580 RVA: 0x0070690A File Offset: 0x00704B0A
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700DAE6 RID: 56038
		// (get) Token: 0x0603424D RID: 213581 RVA: 0x00706918 File Offset: 0x00704B18
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

		// Token: 0x0603424E RID: 213582 RVA: 0x00706954 File Offset: 0x00704B54
		public TTable? Pos2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603424F RID: 213583 RVA: 0x00706998 File Offset: 0x00704B98
		public IAbsolutePos2 Pos2AsIAbsolutePos2()
		{
			return this.Pos2<IAbsolutePos2>().Value;
		}

		// Token: 0x06034250 RID: 213584 RVA: 0x007069B4 File Offset: 0x00704BB4
		public IEntityPos2 Pos2AsIEntityPos2()
		{
			return this.Pos2<IEntityPos2>().Value;
		}

		// Token: 0x06034251 RID: 213585 RVA: 0x007069D0 File Offset: 0x00704BD0
		public IPlayerPos2 Pos2AsIPlayerPos2()
		{
			return this.Pos2<IPlayerPos2>().Value;
		}

		// Token: 0x06034252 RID: 213586 RVA: 0x007069EC File Offset: 0x00704BEC
		public IEffectPlayerPos2 Pos2AsIEffectPlayerPos2()
		{
			return this.Pos2<IEffectPlayerPos2>().Value;
		}

		// Token: 0x06034253 RID: 213587 RVA: 0x00706A08 File Offset: 0x00704C08
		public IEffectEntityPos2 Pos2AsIEffectEntityPos2()
		{
			return this.Pos2<IEffectEntityPos2>().Value;
		}

		// Token: 0x06034254 RID: 213588 RVA: 0x00706A23 File Offset: 0x00704C23
		public static Offset<IPlayEffect> CreateIPlayEffect(FlatBufferBuilder builder, StringOffset PathOffset = default(StringOffset), TPos2 Pos2_type = TPos2.NONE, int Pos2Offset = 0)
		{
			builder.StartTable(3);
			IPlayEffect.AddPos2(builder, Pos2Offset);
			IPlayEffect.AddPath(builder, PathOffset);
			IPlayEffect.AddPos2Type(builder, Pos2_type);
			return IPlayEffect.EndIPlayEffect(builder);
		}

		// Token: 0x06034255 RID: 213589 RVA: 0x00706A47 File Offset: 0x00704C47
		public static void StartIPlayEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06034256 RID: 213590 RVA: 0x00706A50 File Offset: 0x00704C50
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(0, pathOffset.Value, 0);
		}

		// Token: 0x06034257 RID: 213591 RVA: 0x00706A60 File Offset: 0x00704C60
		public static void AddPos2Type(FlatBufferBuilder builder, TPos2 pos2Type)
		{
			builder.AddByte(1, (byte)pos2Type, 0);
		}

		// Token: 0x06034258 RID: 213592 RVA: 0x00706A6B File Offset: 0x00704C6B
		public static void AddPos2(FlatBufferBuilder builder, int pos2Offset)
		{
			builder.AddOffset(2, pos2Offset, 0);
		}

		// Token: 0x06034259 RID: 213593 RVA: 0x00706A76 File Offset: 0x00704C76
		public static Offset<IPlayEffect> EndIPlayEffect(FlatBufferBuilder builder)
		{
			return new Offset<IPlayEffect>(builder.EndTable());
		}

		// Token: 0x0603425A RID: 213594 RVA: 0x00706A84 File Offset: 0x00704C84
		public IPlayEffectT UnPack()
		{
			IPlayEffectT playEffectT = new IPlayEffectT();
			this.UnPackTo(playEffectT);
			return playEffectT;
		}

		// Token: 0x0603425B RID: 213595 RVA: 0x00706AA0 File Offset: 0x00704CA0
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

		// Token: 0x0603425C RID: 213596 RVA: 0x00706C0C File Offset: 0x00704E0C
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

		// Token: 0x040125CC RID: 75212
		private Table __p;
	}
}
