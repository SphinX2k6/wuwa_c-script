using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001291 RID: 4753
	public struct TrapDefenseBdGroup : IFlatbufferObject
	{
		// Token: 0x17003F48 RID: 16200
		// (get) Token: 0x0600F042 RID: 61506 RVA: 0x00361FD0 File Offset: 0x003601D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F043 RID: 61507 RVA: 0x00361FDD File Offset: 0x003601DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F044 RID: 61508 RVA: 0x00361FE4 File Offset: 0x003601E4
		public static TrapDefenseBdGroup GetRootAsTrapDefenseBdGroup(ByteBuffer _bb)
		{
			return TrapDefenseBdGroup.GetRootAsTrapDefenseBdGroup(_bb, default(TrapDefenseBdGroup));
		}

		// Token: 0x0600F045 RID: 61509 RVA: 0x00362000 File Offset: 0x00360200
		public static TrapDefenseBdGroup GetRootAsTrapDefenseBdGroup(ByteBuffer _bb, TrapDefenseBdGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F046 RID: 61510 RVA: 0x0036201D File Offset: 0x0036021D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F047 RID: 61511 RVA: 0x0036202C File Offset: 0x0036022C
		public TrapDefenseBdGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F49 RID: 16201
		// (get) Token: 0x0600F048 RID: 61512 RVA: 0x0036203C File Offset: 0x0036023C
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

		// Token: 0x17003F4A RID: 16202
		// (get) Token: 0x0600F049 RID: 61513 RVA: 0x00362078 File Offset: 0x00360278
		public int BelongBd
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

		// Token: 0x17003F4B RID: 16203
		// (get) Token: 0x0600F04A RID: 61514 RVA: 0x003620B4 File Offset: 0x003602B4
		public int ShopPrice
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003F4C RID: 16204
		// (get) Token: 0x0600F04B RID: 61515 RVA: 0x003620F4 File Offset: 0x003602F4
		public int Quality
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

		// Token: 0x0600F04C RID: 61516 RVA: 0x00362134 File Offset: 0x00360334
		public int PreorderBdGroupIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F4D RID: 16205
		// (get) Token: 0x0600F04D RID: 61517 RVA: 0x00362174 File Offset: 0x00360374
		public int PreorderBdGroupIdsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600F04E RID: 61518 RVA: 0x003621A0 File Offset: 0x003603A0
		public Span<int> GetPreorderBdGroupIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600F04F RID: 61519 RVA: 0x003621B0 File Offset: 0x003603B0
		public int[] GetPreorderBdGroupIdsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600F050 RID: 61520 RVA: 0x003621C8 File Offset: 0x003603C8
		[NullableContext(1)]
		public int[] PreorderBdGroupIds()
		{
			return this.GetPreorderBdGroupIdsArray();
		}

		// Token: 0x0600F051 RID: 61521 RVA: 0x003621D0 File Offset: 0x003603D0
		[NullableContext(1)]
		public IEnumerable<int> PreorderBdGroupIdsIter()
		{
			TrapDefenseBdGroup.<PreorderBdGroupIdsIter>d__22 <PreorderBdGroupIdsIter>d__ = new TrapDefenseBdGroup.<PreorderBdGroupIdsIter>d__22(-2);
			<PreorderBdGroupIdsIter>d__.<>3__<>4__this = this;
			return <PreorderBdGroupIdsIter>d__;
		}

		// Token: 0x040058E3 RID: 22755
		private Table __p;
	}
}
