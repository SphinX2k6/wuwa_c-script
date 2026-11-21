using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EA3 RID: 3747
	public struct LanguageDefine : IFlatbufferObject
	{
		// Token: 0x17001CFC RID: 7420
		// (get) Token: 0x0600932C RID: 37676 RVA: 0x0029403C File Offset: 0x0029223C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600932D RID: 37677 RVA: 0x00294049 File Offset: 0x00292249
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600932E RID: 37678 RVA: 0x00294050 File Offset: 0x00292250
		public static LanguageDefine GetRootAsLanguageDefine(ByteBuffer _bb)
		{
			return LanguageDefine.GetRootAsLanguageDefine(_bb, default(LanguageDefine));
		}

		// Token: 0x0600932F RID: 37679 RVA: 0x0029406C File Offset: 0x0029226C
		public static LanguageDefine GetRootAsLanguageDefine(ByteBuffer _bb, LanguageDefine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009330 RID: 37680 RVA: 0x00294089 File Offset: 0x00292289
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009331 RID: 37681 RVA: 0x00294098 File Offset: 0x00292298
		public LanguageDefine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001CFD RID: 7421
		// (get) Token: 0x06009332 RID: 37682 RVA: 0x002940A8 File Offset: 0x002922A8
		public int LanguageType
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

		// Token: 0x17001CFE RID: 7422
		// (get) Token: 0x06009333 RID: 37683 RVA: 0x002940E4 File Offset: 0x002922E4
		public string LanguageCode
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

		// Token: 0x06009334 RID: 37684 RVA: 0x0029411B File Offset: 0x0029231B
		public Span<byte> GetLanguageCodeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009335 RID: 37685 RVA: 0x0029412A File Offset: 0x0029232A
		public byte[] GetLanguageCodeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CFF RID: 7423
		// (get) Token: 0x06009336 RID: 37686 RVA: 0x00294144 File Offset: 0x00292344
		public bool IsShow
		{
			get
			{
				int num = this.__p.__offset(8);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001D00 RID: 7424
		// (get) Token: 0x06009337 RID: 37687 RVA: 0x00294184 File Offset: 0x00292384
		public int QuestionnaireId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001D01 RID: 7425
		// (get) Token: 0x06009338 RID: 37688 RVA: 0x002941C4 File Offset: 0x002923C4
		public string AudioCode
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009339 RID: 37689 RVA: 0x002941FC File Offset: 0x002923FC
		public Span<byte> GetAudioCodeBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600933A RID: 37690 RVA: 0x0029420C File Offset: 0x0029240C
		public byte[] GetAudioCodeArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D02 RID: 7426
		// (get) Token: 0x0600933B RID: 37691 RVA: 0x00294224 File Offset: 0x00292424
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005439 RID: 21561
		private Table __p;
	}
}
