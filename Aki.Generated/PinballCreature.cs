using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200100C RID: 4108
	public struct PinballCreature : IFlatbufferObject
	{
		// Token: 0x17002987 RID: 10631
		// (get) Token: 0x0600B4AB RID: 46251 RVA: 0x002DD806 File Offset: 0x002DBA06
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B4AC RID: 46252 RVA: 0x002DD813 File Offset: 0x002DBA13
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B4AD RID: 46253 RVA: 0x002DD81C File Offset: 0x002DBA1C
		public static PinballCreature GetRootAsPinballCreature(ByteBuffer _bb)
		{
			return PinballCreature.GetRootAsPinballCreature(_bb, default(PinballCreature));
		}

		// Token: 0x0600B4AE RID: 46254 RVA: 0x002DD838 File Offset: 0x002DBA38
		public static PinballCreature GetRootAsPinballCreature(ByteBuffer _bb, PinballCreature obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B4AF RID: 46255 RVA: 0x002DD855 File Offset: 0x002DBA55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B4B0 RID: 46256 RVA: 0x002DD864 File Offset: 0x002DBA64
		public PinballCreature __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002988 RID: 10632
		// (get) Token: 0x0600B4B1 RID: 46257 RVA: 0x002DD874 File Offset: 0x002DBA74
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

		// Token: 0x17002989 RID: 10633
		// (get) Token: 0x0600B4B2 RID: 46258 RVA: 0x002DD8B0 File Offset: 0x002DBAB0
		public int KscEntityId
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

		// Token: 0x1700298A RID: 10634
		// (get) Token: 0x0600B4B3 RID: 46259 RVA: 0x002DD8EC File Offset: 0x002DBAEC
		public int AttrId
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

		// Token: 0x0600B4B4 RID: 46260 RVA: 0x002DD928 File Offset: 0x002DBB28
		public int BornBuff(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700298B RID: 10635
		// (get) Token: 0x0600B4B5 RID: 46261 RVA: 0x002DD968 File Offset: 0x002DBB68
		public int BornBuffLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B4B6 RID: 46262 RVA: 0x002DD994 File Offset: 0x002DBB94
		public Span<int> GetBornBuffBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600B4B7 RID: 46263 RVA: 0x002DD9A4 File Offset: 0x002DBBA4
		public int[] GetBornBuffArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x1700298C RID: 10636
		// (get) Token: 0x0600B4B8 RID: 46264 RVA: 0x002DD9BC File Offset: 0x002DBBBC
		public int SummonBuffId
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

		// Token: 0x1700298D RID: 10637
		// (get) Token: 0x0600B4B9 RID: 46265 RVA: 0x002DD9FC File Offset: 0x002DBBFC
		public int SummonLifeInherit
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

		// Token: 0x0600B4BA RID: 46266 RVA: 0x002DDA39 File Offset: 0x002DBC39
		[NullableContext(1)]
		public int[] BornBuff()
		{
			return this.GetBornBuffArray();
		}

		// Token: 0x0600B4BB RID: 46267 RVA: 0x002DDA41 File Offset: 0x002DBC41
		[NullableContext(1)]
		public IEnumerable<int> BornBuffIter()
		{
			PinballCreature.<BornBuffIter>d__24 <BornBuffIter>d__ = new PinballCreature.<BornBuffIter>d__24(-2);
			<BornBuffIter>d__.<>3__<>4__this = this;
			return <BornBuffIter>d__;
		}

		// Token: 0x040055D5 RID: 21973
		private Table __p;
	}
}
