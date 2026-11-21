using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007310 RID: 29456
	public struct INpcGroupSequenceBlendAnim : IFlatbufferObject
	{
		// Token: 0x1700D7ED RID: 55277
		// (get) Token: 0x060335CF RID: 210383 RVA: 0x006ED1B2 File Offset: 0x006EB3B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060335D0 RID: 210384 RVA: 0x006ED1BF File Offset: 0x006EB3BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060335D1 RID: 210385 RVA: 0x006ED1C8 File Offset: 0x006EB3C8
		public static INpcGroupSequenceBlendAnim GetRootAsINpcGroupSequenceBlendAnim(ByteBuffer _bb)
		{
			return INpcGroupSequenceBlendAnim.GetRootAsINpcGroupSequenceBlendAnim(_bb, default(INpcGroupSequenceBlendAnim));
		}

		// Token: 0x060335D2 RID: 210386 RVA: 0x006ED1E4 File Offset: 0x006EB3E4
		public static INpcGroupSequenceBlendAnim GetRootAsINpcGroupSequenceBlendAnim(ByteBuffer _bb, INpcGroupSequenceBlendAnim obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060335D3 RID: 210387 RVA: 0x006ED201 File Offset: 0x006EB401
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060335D4 RID: 210388 RVA: 0x006ED210 File Offset: 0x006EB410
		public INpcGroupSequenceBlendAnim __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7EE RID: 55278
		// (get) Token: 0x060335D5 RID: 210389 RVA: 0x006ED220 File Offset: 0x006EB420
		public int Target
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D7EF RID: 55279
		// (get) Token: 0x060335D6 RID: 210390 RVA: 0x006ED25C File Offset: 0x006EB45C
		public INpcGroupSequenceMontageBlendAnimType? BlendType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new INpcGroupSequenceMontageBlendAnimType?(default(INpcGroupSequenceMontageBlendAnimType).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060335D7 RID: 210391 RVA: 0x006ED2B9 File Offset: 0x006EB4B9
		public static Offset<INpcGroupSequenceBlendAnim> CreateINpcGroupSequenceBlendAnim(FlatBufferBuilder builder, int Target = 0, Offset<INpcGroupSequenceMontageBlendAnimType> BlendTypeOffset = default(Offset<INpcGroupSequenceMontageBlendAnimType>))
		{
			builder.StartTable(2);
			INpcGroupSequenceBlendAnim.AddBlendType(builder, BlendTypeOffset);
			INpcGroupSequenceBlendAnim.AddTarget(builder, Target);
			return INpcGroupSequenceBlendAnim.EndINpcGroupSequenceBlendAnim(builder);
		}

		// Token: 0x060335D8 RID: 210392 RVA: 0x006ED2D6 File Offset: 0x006EB4D6
		public static void StartINpcGroupSequenceBlendAnim(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060335D9 RID: 210393 RVA: 0x006ED2DF File Offset: 0x006EB4DF
		public static void AddTarget(FlatBufferBuilder builder, int target)
		{
			builder.AddInt(0, target, 0);
		}

		// Token: 0x060335DA RID: 210394 RVA: 0x006ED2EA File Offset: 0x006EB4EA
		public static void AddBlendType(FlatBufferBuilder builder, Offset<INpcGroupSequenceMontageBlendAnimType> blendTypeOffset)
		{
			builder.AddOffset(1, blendTypeOffset.Value, 0);
		}

		// Token: 0x060335DB RID: 210395 RVA: 0x006ED2FA File Offset: 0x006EB4FA
		public static Offset<INpcGroupSequenceBlendAnim> EndINpcGroupSequenceBlendAnim(FlatBufferBuilder builder)
		{
			return new Offset<INpcGroupSequenceBlendAnim>(builder.EndTable());
		}

		// Token: 0x060335DC RID: 210396 RVA: 0x006ED308 File Offset: 0x006EB508
		public INpcGroupSequenceBlendAnimT UnPack()
		{
			INpcGroupSequenceBlendAnimT npcGroupSequenceBlendAnimT = new INpcGroupSequenceBlendAnimT();
			this.UnPackTo(npcGroupSequenceBlendAnimT);
			return npcGroupSequenceBlendAnimT;
		}

		// Token: 0x060335DD RID: 210397 RVA: 0x006ED324 File Offset: 0x006EB524
		public void UnPackTo(INpcGroupSequenceBlendAnimT _o)
		{
			_o.Target = this.Target;
			_o.BlendType = ((this.BlendType != null) ? this.BlendType.Value.UnPack() : null);
		}

		// Token: 0x060335DE RID: 210398 RVA: 0x006ED36C File Offset: 0x006EB56C
		public static Offset<INpcGroupSequenceBlendAnim> Pack(FlatBufferBuilder builder, INpcGroupSequenceBlendAnimT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcGroupSequenceBlendAnim>);
			}
			Offset<INpcGroupSequenceMontageBlendAnimType> blendTypeOffset = (_o.BlendType == null) ? default(Offset<INpcGroupSequenceMontageBlendAnimType>) : INpcGroupSequenceMontageBlendAnimType.Pack(builder, _o.BlendType);
			return INpcGroupSequenceBlendAnim.CreateINpcGroupSequenceBlendAnim(builder, _o.Target, blendTypeOffset);
		}

		// Token: 0x040123CF RID: 74703
		private Table __p;
	}
}
