using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B1D RID: 2845
	public struct BabelTowerDailyTask : IFlatbufferObject
	{
		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06004A9B RID: 19099 RVA: 0x001DC88C File Offset: 0x001DAA8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004A9C RID: 19100 RVA: 0x001DC899 File Offset: 0x001DAA99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004A9D RID: 19101 RVA: 0x001DC8A0 File Offset: 0x001DAAA0
		public static BabelTowerDailyTask GetRootAsBabelTowerDailyTask(ByteBuffer _bb)
		{
			return BabelTowerDailyTask.GetRootAsBabelTowerDailyTask(_bb, default(BabelTowerDailyTask));
		}

		// Token: 0x06004A9E RID: 19102 RVA: 0x001DC8BC File Offset: 0x001DAABC
		public static BabelTowerDailyTask GetRootAsBabelTowerDailyTask(ByteBuffer _bb, BabelTowerDailyTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004A9F RID: 19103 RVA: 0x001DC8D9 File Offset: 0x001DAAD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004AA0 RID: 19104 RVA: 0x001DC8E8 File Offset: 0x001DAAE8
		public BabelTowerDailyTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06004AA1 RID: 19105 RVA: 0x001DC8F8 File Offset: 0x001DAAF8
		public int TaskId
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

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06004AA2 RID: 19106 RVA: 0x001DC934 File Offset: 0x001DAB34
		public int ActivityId
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

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06004AA3 RID: 19107 RVA: 0x001DC970 File Offset: 0x001DAB70
		public int GroupId
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

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06004AA4 RID: 19108 RVA: 0x001DC9AC File Offset: 0x001DABAC
		public int Weight
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

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06004AA5 RID: 19109 RVA: 0x001DC9EC File Offset: 0x001DABEC
		public int DropId
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

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06004AA6 RID: 19110 RVA: 0x001DCA2C File Offset: 0x001DAC2C
		public string Title
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004AA7 RID: 19111 RVA: 0x001DCA64 File Offset: 0x001DAC64
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004AA8 RID: 19112 RVA: 0x001DCA74 File Offset: 0x001DAC74
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x06004AA9 RID: 19113 RVA: 0x001DCA8C File Offset: 0x001DAC8C
		public int ShowDeTerm(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06004AAA RID: 19114 RVA: 0x001DCACC File Offset: 0x001DACCC
		public int ShowDeTermLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004AAB RID: 19115 RVA: 0x001DCAF8 File Offset: 0x001DACF8
		public Span<int> GetShowDeTermBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06004AAC RID: 19116 RVA: 0x001DCB08 File Offset: 0x001DAD08
		public int[] GetShowDeTermArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06004AAD RID: 19117 RVA: 0x001DCB20 File Offset: 0x001DAD20
		public int ShowBuff(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06004AAE RID: 19118 RVA: 0x001DCB60 File Offset: 0x001DAD60
		public int ShowBuffLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004AAF RID: 19119 RVA: 0x001DCB8C File Offset: 0x001DAD8C
		public Span<int> GetShowBuffBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06004AB0 RID: 19120 RVA: 0x001DCB9C File Offset: 0x001DAD9C
		public int[] GetShowBuffArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06004AB1 RID: 19121 RVA: 0x001DCBB4 File Offset: 0x001DADB4
		public int JumpToLevelId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004AB2 RID: 19122 RVA: 0x001DCBF4 File Offset: 0x001DADF4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowBuffIter()或GetShowBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowBuff()
		{
			BabelTowerDailyTask babelTowerDailyTask = this;
			return babelTowerDailyTask.GetShowBuffArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004AB3 RID: 19123 RVA: 0x001DCC18 File Offset: 0x001DAE18
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowBuffIter()
		{
			BabelTowerDailyTask.<ShowBuffIter>d__35 <ShowBuffIter>d__ = new BabelTowerDailyTask.<ShowBuffIter>d__35(-2);
			<ShowBuffIter>d__.<>3__<>4__this = this;
			return <ShowBuffIter>d__;
		}

		// Token: 0x06004AB4 RID: 19124 RVA: 0x001DCC30 File Offset: 0x001DAE30
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowDeTermIter()或GetShowDeTermBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowDeTerm()
		{
			BabelTowerDailyTask babelTowerDailyTask = this;
			return babelTowerDailyTask.GetShowDeTermArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004AB5 RID: 19125 RVA: 0x001DCC54 File Offset: 0x001DAE54
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowDeTermIter()
		{
			BabelTowerDailyTask.<ShowDeTermIter>d__37 <ShowDeTermIter>d__ = new BabelTowerDailyTask.<ShowDeTermIter>d__37(-2);
			<ShowDeTermIter>d__.<>3__<>4__this = this;
			return <ShowDeTermIter>d__;
		}

		// Token: 0x04004B0D RID: 19213
		private Table __p;
	}
}
