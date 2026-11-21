using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DC3 RID: 3523
	public struct GachaEffectConfig : IFlatbufferObject
	{
		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x06007E13 RID: 32275 RVA: 0x002645D4 File Offset: 0x002627D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007E14 RID: 32276 RVA: 0x002645E1 File Offset: 0x002627E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007E15 RID: 32277 RVA: 0x002645E8 File Offset: 0x002627E8
		public static GachaEffectConfig GetRootAsGachaEffectConfig(ByteBuffer _bb)
		{
			return GachaEffectConfig.GetRootAsGachaEffectConfig(_bb, default(GachaEffectConfig));
		}

		// Token: 0x06007E16 RID: 32278 RVA: 0x00264604 File Offset: 0x00262804
		public static GachaEffectConfig GetRootAsGachaEffectConfig(ByteBuffer _bb, GachaEffectConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007E17 RID: 32279 RVA: 0x00264621 File Offset: 0x00262821
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007E18 RID: 32280 RVA: 0x00264630 File Offset: 0x00262830
		public GachaEffectConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x06007E19 RID: 32281 RVA: 0x00264640 File Offset: 0x00262840
		public int Id
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

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x06007E1A RID: 32282 RVA: 0x0026467C File Offset: 0x0026287C
		public int Times
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x06007E1B RID: 32283 RVA: 0x002646B8 File Offset: 0x002628B8
		public int Quality
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x06007E1C RID: 32284 RVA: 0x002646F4 File Offset: 0x002628F4
		public string FinalShowSequencePath
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007E1D RID: 32285 RVA: 0x0026472C File Offset: 0x0026292C
		public Span<byte> GetFinalShowSequencePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007E1E RID: 32286 RVA: 0x0026473C File Offset: 0x0026293C
		public byte[] GetFinalShowSequencePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x06007E1F RID: 32287 RVA: 0x00264754 File Offset: 0x00262954
		public Color? DefaultColor
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new Color?(default(Color).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x06007E20 RID: 32288 RVA: 0x002647B4 File Offset: 0x002629B4
		public Color? FinalColor
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new Color?(default(Color).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x06007E21 RID: 32289 RVA: 0x00264814 File Offset: 0x00262A14
		public float DefaultProcess
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

		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x06007E22 RID: 32290 RVA: 0x00264858 File Offset: 0x00262A58
		public float ChangeColorProcess
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

		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x06007E23 RID: 32291 RVA: 0x0026489C File Offset: 0x00262A9C
		public float CompleteChangeColorProcess
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x06007E24 RID: 32292 RVA: 0x002648E0 File Offset: 0x00262AE0
		public float PlaySequenceProcess
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x06007E25 RID: 32293 RVA: 0x00264924 File Offset: 0x00262B24
		public string SlideCurveAssetPath
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007E26 RID: 32294 RVA: 0x0026495C File Offset: 0x00262B5C
		public Span<byte> GetSlideCurveAssetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06007E27 RID: 32295 RVA: 0x0026496C File Offset: 0x00262B6C
		public byte[] GetSlideCurveAssetPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x04005334 RID: 21300
		private Table __p;
	}
}
