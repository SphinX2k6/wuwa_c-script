using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C07 RID: 3079
	public struct DrinksRequireList : IFlatbufferObject
	{
		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x0600649E RID: 25758 RVA: 0x002191DC File Offset: 0x002173DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600649F RID: 25759 RVA: 0x002191E9 File Offset: 0x002173E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060064A0 RID: 25760 RVA: 0x002191F0 File Offset: 0x002173F0
		public static DrinksRequireList GetRootAsDrinksRequireList(ByteBuffer _bb)
		{
			return DrinksRequireList.GetRootAsDrinksRequireList(_bb, default(DrinksRequireList));
		}

		// Token: 0x060064A1 RID: 25761 RVA: 0x0021920C File Offset: 0x0021740C
		public static DrinksRequireList GetRootAsDrinksRequireList(ByteBuffer _bb, DrinksRequireList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060064A2 RID: 25762 RVA: 0x00219229 File Offset: 0x00217429
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060064A3 RID: 25763 RVA: 0x00219238 File Offset: 0x00217438
		public DrinksRequireList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x060064A4 RID: 25764 RVA: 0x00219248 File Offset: 0x00217448
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

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x060064A5 RID: 25765 RVA: 0x00219284 File Offset: 0x00217484
		public int RoleId
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

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x060064A6 RID: 25766 RVA: 0x002192C0 File Offset: 0x002174C0
		public int ScoreMax
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

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x060064A7 RID: 25767 RVA: 0x002192FC File Offset: 0x002174FC
		public int FlavorRequire
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

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x060064A8 RID: 25768 RVA: 0x0021933C File Offset: 0x0021753C
		public int DrinkNeedV2
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

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x060064A9 RID: 25769 RVA: 0x0021937C File Offset: 0x0021757C
		public string DrinkNeedKey
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

		// Token: 0x060064AA RID: 25770 RVA: 0x002193B4 File Offset: 0x002175B4
		public Span<byte> GetDrinkNeedKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060064AB RID: 25771 RVA: 0x002193C4 File Offset: 0x002175C4
		public byte[] GetDrinkNeedKeyArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x060064AC RID: 25772 RVA: 0x002193DC File Offset: 0x002175DC
		public int DrinkLikePoint
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

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x060064AD RID: 25773 RVA: 0x0021941C File Offset: 0x0021761C
		public int BatchingNeedV2
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x060064AE RID: 25774 RVA: 0x0021945C File Offset: 0x0021765C
		public string BatchingNeedKey
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060064AF RID: 25775 RVA: 0x00219494 File Offset: 0x00217694
		public Span<byte> GetBatchingNeedKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060064B0 RID: 25776 RVA: 0x002194A4 File Offset: 0x002176A4
		public byte[] GetBatchingNeedKeyArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x060064B1 RID: 25777 RVA: 0x002194BC File Offset: 0x002176BC
		public int BatchingLikePoint
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x060064B2 RID: 25778 RVA: 0x002194FC File Offset: 0x002176FC
		public int OrnamentNeedV2
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x060064B3 RID: 25779 RVA: 0x0021953C File Offset: 0x0021773C
		public string OrnamentNeedKey
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060064B4 RID: 25780 RVA: 0x00219574 File Offset: 0x00217774
		public Span<byte> GetOrnamentNeedKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060064B5 RID: 25781 RVA: 0x00219584 File Offset: 0x00217784
		public byte[] GetOrnamentNeedKeyArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x060064B6 RID: 25782 RVA: 0x0021959C File Offset: 0x0021779C
		public int OrnaLike
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x060064B7 RID: 25783 RVA: 0x002195DC File Offset: 0x002177DC
		public int Reward
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060064B8 RID: 25784 RVA: 0x0021961C File Offset: 0x0021781C
		public int RoleLikeSetting(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x060064B9 RID: 25785 RVA: 0x0021965C File Offset: 0x0021785C
		public int RoleLikeSettingLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060064BA RID: 25786 RVA: 0x00219688 File Offset: 0x00217888
		public Span<int> GetRoleLikeSettingBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x060064BB RID: 25787 RVA: 0x00219698 File Offset: 0x00217898
		public int[] GetRoleLikeSettingArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x060064BC RID: 25788 RVA: 0x002196B0 File Offset: 0x002178B0
		public string ScriptName
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060064BD RID: 25789 RVA: 0x002196E8 File Offset: 0x002178E8
		public Span<byte> GetScriptNameBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x060064BE RID: 25790 RVA: 0x002196F8 File Offset: 0x002178F8
		public byte[] GetScriptNameArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x060064BF RID: 25791 RVA: 0x00219710 File Offset: 0x00217910
		public int ScriptId
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x060064C0 RID: 25792 RVA: 0x00219750 File Offset: 0x00217950
		public int ScriptStateId
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060064C1 RID: 25793 RVA: 0x00219790 File Offset: 0x00217990
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RoleLikeSettingIter()或GetRoleLikeSettingBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RoleLikeSetting()
		{
			DrinksRequireList drinksRequireList = this;
			return drinksRequireList.GetRoleLikeSettingArray() ?? Array.Empty<int>();
		}

		// Token: 0x060064C2 RID: 25794 RVA: 0x002197B4 File Offset: 0x002179B4
		[NullableContext(1)]
		public readonly IEnumerable<int> RoleLikeSettingIter()
		{
			DrinksRequireList.<RoleLikeSettingIter>d__56 <RoleLikeSettingIter>d__ = new DrinksRequireList.<RoleLikeSettingIter>d__56(-2);
			<RoleLikeSettingIter>d__.<>3__<>4__this = this;
			return <RoleLikeSettingIter>d__;
		}

		// Token: 0x04004C43 RID: 19523
		private Table __p;
	}
}
