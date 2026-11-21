using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012AE RID: 4782
	public struct TrialPhantomPropItem : IFlatbufferObject
	{
		// Token: 0x1700403F RID: 16447
		// (get) Token: 0x0600F2D1 RID: 62161 RVA: 0x00367825 File Offset: 0x00365A25
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F2D2 RID: 62162 RVA: 0x00367832 File Offset: 0x00365A32
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F2D3 RID: 62163 RVA: 0x0036783C File Offset: 0x00365A3C
		public static TrialPhantomPropItem GetRootAsTrialPhantomPropItem(ByteBuffer _bb)
		{
			return TrialPhantomPropItem.GetRootAsTrialPhantomPropItem(_bb, default(TrialPhantomPropItem));
		}

		// Token: 0x0600F2D4 RID: 62164 RVA: 0x00367858 File Offset: 0x00365A58
		public static TrialPhantomPropItem GetRootAsTrialPhantomPropItem(ByteBuffer _bb, TrialPhantomPropItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F2D5 RID: 62165 RVA: 0x00367875 File Offset: 0x00365A75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F2D6 RID: 62166 RVA: 0x00367884 File Offset: 0x00365A84
		public TrialPhantomPropItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004040 RID: 16448
		// (get) Token: 0x0600F2D7 RID: 62167 RVA: 0x00367894 File Offset: 0x00365A94
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

		// Token: 0x17004041 RID: 16449
		// (get) Token: 0x0600F2D8 RID: 62168 RVA: 0x003678D0 File Offset: 0x00365AD0
		public ConfigPropValue? Prop
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ConfigPropValue?(default(ConfigPropValue).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x04005901 RID: 22785
		private Table __p;
	}
}
