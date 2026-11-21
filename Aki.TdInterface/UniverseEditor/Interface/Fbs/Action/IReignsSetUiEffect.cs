using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075AF RID: 30127
	public struct IReignsSetUiEffect : IFlatbufferObject
	{
		// Token: 0x1700DD85 RID: 56709
		// (get) Token: 0x06034D88 RID: 216456 RVA: 0x0071A956 File Offset: 0x00718B56
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034D89 RID: 216457 RVA: 0x0071A963 File Offset: 0x00718B63
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034D8A RID: 216458 RVA: 0x0071A96C File Offset: 0x00718B6C
		public static IReignsSetUiEffect GetRootAsIReignsSetUiEffect(ByteBuffer _bb)
		{
			return IReignsSetUiEffect.GetRootAsIReignsSetUiEffect(_bb, default(IReignsSetUiEffect));
		}

		// Token: 0x06034D8B RID: 216459 RVA: 0x0071A988 File Offset: 0x00718B88
		public static IReignsSetUiEffect GetRootAsIReignsSetUiEffect(ByteBuffer _bb, IReignsSetUiEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034D8C RID: 216460 RVA: 0x0071A9A5 File Offset: 0x00718BA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034D8D RID: 216461 RVA: 0x0071A9B4 File Offset: 0x00718BB4
		public IReignsSetUiEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD86 RID: 56710
		// (get) Token: 0x06034D8E RID: 216462 RVA: 0x0071A9C4 File Offset: 0x00718BC4
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

		// Token: 0x06034D8F RID: 216463 RVA: 0x0071A9FB File Offset: 0x00718BFB
		public Span<byte> GetEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06034D90 RID: 216464 RVA: 0x0071AA0A File Offset: 0x00718C0A
		public byte[] GetEffectArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700DD87 RID: 56711
		// (get) Token: 0x06034D91 RID: 216465 RVA: 0x0071AA18 File Offset: 0x00718C18
		public bool IsVisible
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06034D92 RID: 216466 RVA: 0x0071AA57 File Offset: 0x00718C57
		public static Offset<IReignsSetUiEffect> CreateIReignsSetUiEffect(FlatBufferBuilder builder, StringOffset EffectOffset = default(StringOffset), bool IsVisible = false)
		{
			builder.StartTable(2);
			IReignsSetUiEffect.AddEffect(builder, EffectOffset);
			IReignsSetUiEffect.AddIsVisible(builder, IsVisible);
			return IReignsSetUiEffect.EndIReignsSetUiEffect(builder);
		}

		// Token: 0x06034D93 RID: 216467 RVA: 0x0071AA74 File Offset: 0x00718C74
		public static void StartIReignsSetUiEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034D94 RID: 216468 RVA: 0x0071AA7D File Offset: 0x00718C7D
		public static void AddEffect(FlatBufferBuilder builder, StringOffset effectOffset)
		{
			builder.AddOffset(0, effectOffset.Value, 0);
		}

		// Token: 0x06034D95 RID: 216469 RVA: 0x0071AA8D File Offset: 0x00718C8D
		public static void AddIsVisible(FlatBufferBuilder builder, bool isVisible)
		{
			builder.AddBool(1, isVisible, false);
		}

		// Token: 0x06034D96 RID: 216470 RVA: 0x0071AA98 File Offset: 0x00718C98
		public static Offset<IReignsSetUiEffect> EndIReignsSetUiEffect(FlatBufferBuilder builder)
		{
			return new Offset<IReignsSetUiEffect>(builder.EndTable());
		}

		// Token: 0x06034D97 RID: 216471 RVA: 0x0071AAA8 File Offset: 0x00718CA8
		public IReignsSetUiEffectT UnPack()
		{
			IReignsSetUiEffectT reignsSetUiEffectT = new IReignsSetUiEffectT();
			this.UnPackTo(reignsSetUiEffectT);
			return reignsSetUiEffectT;
		}

		// Token: 0x06034D98 RID: 216472 RVA: 0x0071AAC3 File Offset: 0x00718CC3
		public void UnPackTo(IReignsSetUiEffectT _o)
		{
			_o.Effect = this.Effect;
			_o.IsVisible = this.IsVisible;
		}

		// Token: 0x06034D99 RID: 216473 RVA: 0x0071AAE0 File Offset: 0x00718CE0
		public static Offset<IReignsSetUiEffect> Pack(FlatBufferBuilder builder, IReignsSetUiEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReignsSetUiEffect>);
			}
			StringOffset effectOffset = (_o.Effect == null) ? default(StringOffset) : builder.CreateString(_o.Effect);
			return IReignsSetUiEffect.CreateIReignsSetUiEffect(builder, effectOffset, _o.IsVisible);
		}

		// Token: 0x04012796 RID: 75670
		private Table __p;
	}
}
