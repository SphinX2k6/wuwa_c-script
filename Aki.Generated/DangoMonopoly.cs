using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CB8 RID: 3256
	public struct DangoMonopoly : IFlatbufferObject
	{
		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x06006627 RID: 26151 RVA: 0x0022EAE4 File Offset: 0x0022CCE4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006628 RID: 26152 RVA: 0x0022EAF1 File Offset: 0x0022CCF1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006629 RID: 26153 RVA: 0x0022EAF8 File Offset: 0x0022CCF8
		public static DangoMonopoly GetRootAsDangoMonopoly(ByteBuffer _bb)
		{
			return DangoMonopoly.GetRootAsDangoMonopoly(_bb, default(DangoMonopoly));
		}

		// Token: 0x0600662A RID: 26154 RVA: 0x0022EB14 File Offset: 0x0022CD14
		public static DangoMonopoly GetRootAsDangoMonopoly(ByteBuffer _bb, DangoMonopoly obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600662B RID: 26155 RVA: 0x0022EB31 File Offset: 0x0022CD31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600662C RID: 26156 RVA: 0x0022EB40 File Offset: 0x0022CD40
		public DangoMonopoly __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x0600662D RID: 26157 RVA: 0x0022EB50 File Offset: 0x0022CD50
		public int ActivityId
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

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x0600662E RID: 26158 RVA: 0x0022EB8C File Offset: 0x0022CD8C
		public int BoardGroupId
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

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x0600662F RID: 26159 RVA: 0x0022EBC8 File Offset: 0x0022CDC8
		public int TaskGroupId
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

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06006630 RID: 26160 RVA: 0x0022EC04 File Offset: 0x0022CE04
		public int InstId
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

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06006631 RID: 26161 RVA: 0x0022EC44 File Offset: 0x0022CE44
		public int MaleDangoId
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

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x06006632 RID: 26162 RVA: 0x0022EC84 File Offset: 0x0022CE84
		public int FeMaleDangoId
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

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x06006633 RID: 26163 RVA: 0x0022ECC4 File Offset: 0x0022CEC4
		public int DiceId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040051E5 RID: 20965
		private Table __p;
	}
}
