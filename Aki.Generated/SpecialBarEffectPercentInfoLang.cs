using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200131B RID: 4891
	public struct SpecialBarEffectPercentInfoLang : IFlatbufferObject
	{
		// Token: 0x170042A1 RID: 17057
		// (get) Token: 0x0600F914 RID: 63764 RVA: 0x00375654 File Offset: 0x00373854
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F915 RID: 63765 RVA: 0x00375661 File Offset: 0x00373861
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F916 RID: 63766 RVA: 0x00375668 File Offset: 0x00373868
		public static SpecialBarEffectPercentInfoLang GetRootAsSpecialBarEffectPercentInfoLang(ByteBuffer _bb)
		{
			return SpecialBarEffectPercentInfoLang.GetRootAsSpecialBarEffectPercentInfoLang(_bb, default(SpecialBarEffectPercentInfoLang));
		}

		// Token: 0x0600F917 RID: 63767 RVA: 0x00375684 File Offset: 0x00373884
		public static SpecialBarEffectPercentInfoLang GetRootAsSpecialBarEffectPercentInfoLang(ByteBuffer _bb, SpecialBarEffectPercentInfoLang obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F918 RID: 63768 RVA: 0x003756A1 File Offset: 0x003738A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F919 RID: 63769 RVA: 0x003756B0 File Offset: 0x003738B0
		public SpecialBarEffectPercentInfoLang __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170042A2 RID: 17058
		// (get) Token: 0x0600F91A RID: 63770 RVA: 0x003756C0 File Offset: 0x003738C0
		public int MinPercent
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

		// Token: 0x170042A3 RID: 17059
		// (get) Token: 0x0600F91B RID: 63771 RVA: 0x003756FC File Offset: 0x003738FC
		public int MaxPercent
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

		// Token: 0x170042A4 RID: 17060
		// (get) Token: 0x0600F91C RID: 63772 RVA: 0x00375738 File Offset: 0x00373938
		public float MinValue
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170042A5 RID: 17061
		// (get) Token: 0x0600F91D RID: 63773 RVA: 0x00375778 File Offset: 0x00373978
		public float MaxValue
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170042A6 RID: 17062
		// (get) Token: 0x0600F91E RID: 63774 RVA: 0x003757BC File Offset: 0x003739BC
		public int FloatParameterName
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040059A1 RID: 22945
		private Table __p;
	}
}
