using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CDF RID: 3295
	public struct GachaEffectConfig : IFlatbufferObject
	{
		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x06007808 RID: 30728 RVA: 0x00245A58 File Offset: 0x00243C58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007809 RID: 30729 RVA: 0x00245A65 File Offset: 0x00243C65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600780A RID: 30730 RVA: 0x00245A6C File Offset: 0x00243C6C
		public static GachaEffectConfig GetRootAsGachaEffectConfig(ByteBuffer _bb)
		{
			return GachaEffectConfig.GetRootAsGachaEffectConfig(_bb, default(GachaEffectConfig));
		}

		// Token: 0x0600780B RID: 30731 RVA: 0x00245A88 File Offset: 0x00243C88
		public static GachaEffectConfig GetRootAsGachaEffectConfig(ByteBuffer _bb, GachaEffectConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600780C RID: 30732 RVA: 0x00245AA5 File Offset: 0x00243CA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600780D RID: 30733 RVA: 0x00245AB4 File Offset: 0x00243CB4
		public GachaEffectConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x0600780E RID: 30734 RVA: 0x00245AC4 File Offset: 0x00243CC4
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

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x0600780F RID: 30735 RVA: 0x00245B00 File Offset: 0x00243D00
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

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x06007810 RID: 30736 RVA: 0x00245B3C File Offset: 0x00243D3C
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

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x06007811 RID: 30737 RVA: 0x00245B78 File Offset: 0x00243D78
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

		// Token: 0x06007812 RID: 30738 RVA: 0x00245BB0 File Offset: 0x00243DB0
		public Span<byte> GetFinalShowSequencePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007813 RID: 30739 RVA: 0x00245BC0 File Offset: 0x00243DC0
		public byte[] GetFinalShowSequencePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x06007814 RID: 30740 RVA: 0x00245BD8 File Offset: 0x00243DD8
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

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x06007815 RID: 30741 RVA: 0x00245C38 File Offset: 0x00243E38
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

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x06007816 RID: 30742 RVA: 0x00245C98 File Offset: 0x00243E98
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

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x06007817 RID: 30743 RVA: 0x00245CDC File Offset: 0x00243EDC
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

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x06007818 RID: 30744 RVA: 0x00245D20 File Offset: 0x00243F20
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

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x06007819 RID: 30745 RVA: 0x00245D64 File Offset: 0x00243F64
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

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x0600781A RID: 30746 RVA: 0x00245DA8 File Offset: 0x00243FA8
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

		// Token: 0x0600781B RID: 30747 RVA: 0x00245DE0 File Offset: 0x00243FE0
		public Span<byte> GetSlideCurveAssetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600781C RID: 30748 RVA: 0x00245DF0 File Offset: 0x00243FF0
		public byte[] GetSlideCurveAssetPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D50 RID: 19792
		private Table __p;
	}
}
