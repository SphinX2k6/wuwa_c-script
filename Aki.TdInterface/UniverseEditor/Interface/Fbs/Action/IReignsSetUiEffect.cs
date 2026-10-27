using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E31 RID: 28209
	public struct IReignsSetUiEffect : IFlatbufferObject
	{
		// Token: 0x1700D236 RID: 53814
		// (get) Token: 0x06031D72 RID: 204146 RVA: 0x006BEFCE File Offset: 0x006BD1CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031D73 RID: 204147 RVA: 0x006BEFDB File Offset: 0x006BD1DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031D74 RID: 204148 RVA: 0x006BEFE4 File Offset: 0x006BD1E4
		public static IReignsSetUiEffect GetRootAsIReignsSetUiEffect(ByteBuffer _bb)
		{
			return IReignsSetUiEffect.GetRootAsIReignsSetUiEffect(_bb, default(IReignsSetUiEffect));
		}

		// Token: 0x06031D75 RID: 204149 RVA: 0x006BF000 File Offset: 0x006BD200
		public static IReignsSetUiEffect GetRootAsIReignsSetUiEffect(ByteBuffer _bb, IReignsSetUiEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031D76 RID: 204150 RVA: 0x006BF01D File Offset: 0x006BD21D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031D77 RID: 204151 RVA: 0x006BF02C File Offset: 0x006BD22C
		public IReignsSetUiEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D237 RID: 53815
		// (get) Token: 0x06031D78 RID: 204152 RVA: 0x006BF03C File Offset: 0x006BD23C
		public string Effect
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

		// Token: 0x06031D79 RID: 204153 RVA: 0x006BF073 File Offset: 0x006BD273
		public Span<byte> GetEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06031D7A RID: 204154 RVA: 0x006BF082 File Offset: 0x006BD282
		public byte[] GetEffectArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D238 RID: 53816
		// (get) Token: 0x06031D7B RID: 204155 RVA: 0x006BF090 File Offset: 0x006BD290
		public bool IsVisible
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06031D7C RID: 204156 RVA: 0x006BF0CF File Offset: 0x006BD2CF
		public static Offset<IReignsSetUiEffect> CreateIReignsSetUiEffect(FlatBufferBuilder builder, StringOffset EffectOffset = default(StringOffset), bool IsVisible = false)
		{
			builder.StartTable(2);
			IReignsSetUiEffect.AddEffect(builder, EffectOffset);
			IReignsSetUiEffect.AddIsVisible(builder, IsVisible);
			return IReignsSetUiEffect.EndIReignsSetUiEffect(builder);
		}

		// Token: 0x06031D7D RID: 204157 RVA: 0x006BF0EC File Offset: 0x006BD2EC
		public static void StartIReignsSetUiEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031D7E RID: 204158 RVA: 0x006BF0F5 File Offset: 0x006BD2F5
		public static void AddEffect(FlatBufferBuilder builder, StringOffset effectOffset)
		{
			builder.AddOffset(0, effectOffset.Value, 0);
		}

		// Token: 0x06031D7F RID: 204159 RVA: 0x006BF105 File Offset: 0x006BD305
		public static void AddIsVisible(FlatBufferBuilder builder, bool isVisible)
		{
			builder.AddBool(1, isVisible, false);
		}

		// Token: 0x06031D80 RID: 204160 RVA: 0x006BF110 File Offset: 0x006BD310
		public static Offset<IReignsSetUiEffect> EndIReignsSetUiEffect(FlatBufferBuilder builder)
		{
			return new Offset<IReignsSetUiEffect>(builder.EndTable());
		}

		// Token: 0x06031D81 RID: 204161 RVA: 0x006BF120 File Offset: 0x006BD320
		public IReignsSetUiEffectT UnPack()
		{
			IReignsSetUiEffectT reignsSetUiEffectT = new IReignsSetUiEffectT();
			this.UnPackTo(reignsSetUiEffectT);
			return reignsSetUiEffectT;
		}

		// Token: 0x06031D82 RID: 204162 RVA: 0x006BF13B File Offset: 0x006BD33B
		public void UnPackTo(IReignsSetUiEffectT _o)
		{
			_o.Effect = this.Effect;
			_o.IsVisible = this.IsVisible;
		}

		// Token: 0x06031D83 RID: 204163 RVA: 0x006BF158 File Offset: 0x006BD358
		public static Offset<IReignsSetUiEffect> Pack(FlatBufferBuilder builder, IReignsSetUiEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReignsSetUiEffect>);
			}
			StringOffset effectOffset = (_o.Effect == null) ? default(StringOffset) : builder.CreateString(_o.Effect);
			return IReignsSetUiEffect.CreateIReignsSetUiEffect(builder, effectOffset, _o.IsVisible);
		}

		// Token: 0x04011816 RID: 71702
		private Table __p;
	}
}
