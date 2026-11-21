using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C15 RID: 3093
	public struct BlackCoastThemeConfig : IFlatbufferObject
	{
		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06005331 RID: 21297 RVA: 0x00204381 File Offset: 0x00202581
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005332 RID: 21298 RVA: 0x0020438E File Offset: 0x0020258E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005333 RID: 21299 RVA: 0x00204398 File Offset: 0x00202598
		public static BlackCoastThemeConfig GetRootAsBlackCoastThemeConfig(ByteBuffer _bb)
		{
			return BlackCoastThemeConfig.GetRootAsBlackCoastThemeConfig(_bb, default(BlackCoastThemeConfig));
		}

		// Token: 0x06005334 RID: 21300 RVA: 0x002043B4 File Offset: 0x002025B4
		public static BlackCoastThemeConfig GetRootAsBlackCoastThemeConfig(ByteBuffer _bb, BlackCoastThemeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005335 RID: 21301 RVA: 0x002043D1 File Offset: 0x002025D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005336 RID: 21302 RVA: 0x002043E0 File Offset: 0x002025E0
		public BlackCoastThemeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06005337 RID: 21303 RVA: 0x002043F0 File Offset: 0x002025F0
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

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06005338 RID: 21304 RVA: 0x0020442C File Offset: 0x0020262C
		public int ItemId
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

		// Token: 0x06005339 RID: 21305 RVA: 0x00204468 File Offset: 0x00202668
		public int WeaponPreviewId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x0600533A RID: 21306 RVA: 0x002044A8 File Offset: 0x002026A8
		public int WeaponPreviewIdLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600533B RID: 21307 RVA: 0x002044D3 File Offset: 0x002026D3
		public Span<int> GetWeaponPreviewIdBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600533C RID: 21308 RVA: 0x002044E2 File Offset: 0x002026E2
		public int[] GetWeaponPreviewIdArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600533D RID: 21309 RVA: 0x002044F9 File Offset: 0x002026F9
		[NullableContext(1)]
		public int[] WeaponPreviewId()
		{
			return this.GetWeaponPreviewIdArray();
		}

		// Token: 0x0600533E RID: 21310 RVA: 0x00204501 File Offset: 0x00202701
		[NullableContext(1)]
		public IEnumerable<int> WeaponPreviewIdIter()
		{
			BlackCoastThemeConfig.<WeaponPreviewIdIter>d__18 <WeaponPreviewIdIter>d__ = new BlackCoastThemeConfig.<WeaponPreviewIdIter>d__18(-2);
			<WeaponPreviewIdIter>d__.<>3__<>4__this = this;
			return <WeaponPreviewIdIter>d__;
		}

		// Token: 0x04005110 RID: 20752
		private Table __p;
	}
}
