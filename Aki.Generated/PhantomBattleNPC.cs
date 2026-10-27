using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ED8 RID: 3800
	public struct PhantomBattleNPC : IFlatbufferObject
	{
		// Token: 0x17002674 RID: 9844
		// (get) Token: 0x0600A7A7 RID: 42919 RVA: 0x002B1190 File Offset: 0x002AF390
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A7A8 RID: 42920 RVA: 0x002B119D File Offset: 0x002AF39D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A7A9 RID: 42921 RVA: 0x002B11A4 File Offset: 0x002AF3A4
		public static PhantomBattleNPC GetRootAsPhantomBattleNPC(ByteBuffer _bb)
		{
			return PhantomBattleNPC.GetRootAsPhantomBattleNPC(_bb, default(PhantomBattleNPC));
		}

		// Token: 0x0600A7AA RID: 42922 RVA: 0x002B11C0 File Offset: 0x002AF3C0
		public static PhantomBattleNPC GetRootAsPhantomBattleNPC(ByteBuffer _bb, PhantomBattleNPC obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A7AB RID: 42923 RVA: 0x002B11DD File Offset: 0x002AF3DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A7AC RID: 42924 RVA: 0x002B11EC File Offset: 0x002AF3EC
		public PhantomBattleNPC __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002675 RID: 9845
		// (get) Token: 0x0600A7AD RID: 42925 RVA: 0x002B11FC File Offset: 0x002AF3FC
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

		// Token: 0x17002676 RID: 9846
		// (get) Token: 0x0600A7AE RID: 42926 RVA: 0x002B1238 File Offset: 0x002AF438
		public int GroupId
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

		// Token: 0x17002677 RID: 9847
		// (get) Token: 0x0600A7AF RID: 42927 RVA: 0x002B1274 File Offset: 0x002AF474
		public int BTId
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

		// Token: 0x0600A7B0 RID: 42928 RVA: 0x002B12B0 File Offset: 0x002AF4B0
		public int CardGroupId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002678 RID: 9848
		// (get) Token: 0x0600A7B1 RID: 42929 RVA: 0x002B12F0 File Offset: 0x002AF4F0
		public int CardGroupIdLength
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

		// Token: 0x0600A7B2 RID: 42930 RVA: 0x002B131C File Offset: 0x002AF51C
		public Span<int> GetCardGroupIdBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600A7B3 RID: 42931 RVA: 0x002B132C File Offset: 0x002AF52C
		public int[] GetCardGroupIdArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600A7B4 RID: 42932 RVA: 0x002B1344 File Offset: 0x002AF544
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CardGroupIdIter()或GetCardGroupIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] CardGroupId()
		{
			PhantomBattleNPC phantomBattleNPC = this;
			return phantomBattleNPC.GetCardGroupIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A7B5 RID: 42933 RVA: 0x002B1368 File Offset: 0x002AF568
		[NullableContext(1)]
		public readonly IEnumerable<int> CardGroupIdIter()
		{
			PhantomBattleNPC.<CardGroupIdIter>d__20 <CardGroupIdIter>d__ = new PhantomBattleNPC.<CardGroupIdIter>d__20(-2);
			<CardGroupIdIter>d__.<>3__<>4__this = this;
			return <CardGroupIdIter>d__;
		}

		// Token: 0x04004F96 RID: 20374
		private Table __p;
	}
}
