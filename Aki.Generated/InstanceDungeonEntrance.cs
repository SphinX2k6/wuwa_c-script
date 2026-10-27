using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D70 RID: 3440
	public struct InstanceDungeonEntrance : IFlatbufferObject
	{
		// Token: 0x170019A2 RID: 6562
		// (get) Token: 0x06008551 RID: 34129 RVA: 0x00263AE0 File Offset: 0x00261CE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008552 RID: 34130 RVA: 0x00263AED File Offset: 0x00261CED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008553 RID: 34131 RVA: 0x00263AF4 File Offset: 0x00261CF4
		public static InstanceDungeonEntrance GetRootAsInstanceDungeonEntrance(ByteBuffer _bb)
		{
			return InstanceDungeonEntrance.GetRootAsInstanceDungeonEntrance(_bb, default(InstanceDungeonEntrance));
		}

		// Token: 0x06008554 RID: 34132 RVA: 0x00263B10 File Offset: 0x00261D10
		public static InstanceDungeonEntrance GetRootAsInstanceDungeonEntrance(ByteBuffer _bb, InstanceDungeonEntrance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008555 RID: 34133 RVA: 0x00263B2D File Offset: 0x00261D2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008556 RID: 34134 RVA: 0x00263B3C File Offset: 0x00261D3C
		public InstanceDungeonEntrance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170019A3 RID: 6563
		// (get) Token: 0x06008557 RID: 34135 RVA: 0x00263B4C File Offset: 0x00261D4C
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

		// Token: 0x170019A4 RID: 6564
		// (get) Token: 0x06008558 RID: 34136 RVA: 0x00263B88 File Offset: 0x00261D88
		public int MarkId
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

		// Token: 0x170019A5 RID: 6565
		// (get) Token: 0x06008559 RID: 34137 RVA: 0x00263BC4 File Offset: 0x00261DC4
		public string Name
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600855A RID: 34138 RVA: 0x00263BFB File Offset: 0x00261DFB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600855B RID: 34139 RVA: 0x00263C0A File Offset: 0x00261E0A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170019A6 RID: 6566
		// (get) Token: 0x0600855C RID: 34140 RVA: 0x00263C24 File Offset: 0x00261E24
		public string Description
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

		// Token: 0x0600855D RID: 34141 RVA: 0x00263C5C File Offset: 0x00261E5C
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600855E RID: 34142 RVA: 0x00263C6C File Offset: 0x00261E6C
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600855F RID: 34143 RVA: 0x00263C84 File Offset: 0x00261E84
		public int InstanceDungeonList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019A7 RID: 6567
		// (get) Token: 0x06008560 RID: 34144 RVA: 0x00263CC4 File Offset: 0x00261EC4
		public int InstanceDungeonListLength
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

		// Token: 0x06008561 RID: 34145 RVA: 0x00263CF0 File Offset: 0x00261EF0
		public Span<int> GetInstanceDungeonListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06008562 RID: 34146 RVA: 0x00263D00 File Offset: 0x00261F00
		public int[] GetInstanceDungeonListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x170019A8 RID: 6568
		// (get) Token: 0x06008563 RID: 34147 RVA: 0x00263D18 File Offset: 0x00261F18
		public int FlowId
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

		// Token: 0x170019A9 RID: 6569
		// (get) Token: 0x06008564 RID: 34148 RVA: 0x00263D58 File Offset: 0x00261F58
		public int HelpButtonId
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

		// Token: 0x170019AA RID: 6570
		// (get) Token: 0x06008565 RID: 34149 RVA: 0x00263D98 File Offset: 0x00261F98
		public string TitleSprite
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008566 RID: 34150 RVA: 0x00263DD0 File Offset: 0x00261FD0
		public Span<byte> GetTitleSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06008567 RID: 34151 RVA: 0x00263DE0 File Offset: 0x00261FE0
		public byte[] GetTitleSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170019AB RID: 6571
		// (get) Token: 0x06008568 RID: 34152 RVA: 0x00263DF8 File Offset: 0x00261FF8
		public int TeleportEntityConfigId
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

		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x06008569 RID: 34153 RVA: 0x00263E38 File Offset: 0x00262038
		public int UnLockCondition
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

		// Token: 0x0600856A RID: 34154 RVA: 0x00263E78 File Offset: 0x00262078
		public IntArray? RegularReward(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x0600856B RID: 34155 RVA: 0x00263EDC File Offset: 0x002620DC
		public int RegularRewardLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x0600856C RID: 34156 RVA: 0x00263F08 File Offset: 0x00262108
		public int PowerCostShow
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170019AF RID: 6575
		// (get) Token: 0x0600856D RID: 34157 RVA: 0x00263F48 File Offset: 0x00262148
		public string MapBgPath
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600856E RID: 34158 RVA: 0x00263F80 File Offset: 0x00262180
		public Span<byte> GetMapBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600856F RID: 34159 RVA: 0x00263F90 File Offset: 0x00262190
		public byte[] GetMapBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x06008570 RID: 34160 RVA: 0x00263FA8 File Offset: 0x002621A8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InstanceDungeonListIter()或GetInstanceDungeonListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InstanceDungeonList()
		{
			InstanceDungeonEntrance instanceDungeonEntrance = this;
			return instanceDungeonEntrance.GetInstanceDungeonListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008571 RID: 34161 RVA: 0x00263FCC File Offset: 0x002621CC
		[NullableContext(1)]
		public readonly IEnumerable<int> InstanceDungeonListIter()
		{
			InstanceDungeonEntrance.<InstanceDungeonListIter>d__47 <InstanceDungeonListIter>d__ = new InstanceDungeonEntrance.<InstanceDungeonListIter>d__47(-2);
			<InstanceDungeonListIter>d__.<>3__<>4__this = this;
			return <InstanceDungeonListIter>d__;
		}

		// Token: 0x06008572 RID: 34162 RVA: 0x00263FE1 File Offset: 0x002621E1
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RegularRewardIter()或GetRegularRewardBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] RegularReward()
		{
			return this.RegularRewardIter().ToArray<IntArray>();
		}

		// Token: 0x06008573 RID: 34163 RVA: 0x00263FEE File Offset: 0x002621EE
		[NullableContext(1)]
		public readonly IEnumerable<IntArray> RegularRewardIter()
		{
			InstanceDungeonEntrance.<RegularRewardIter>d__49 <RegularRewardIter>d__ = new InstanceDungeonEntrance.<RegularRewardIter>d__49(-2);
			<RegularRewardIter>d__.<>3__<>4__this = this;
			return <RegularRewardIter>d__;
		}

		// Token: 0x04004DF8 RID: 19960
		private Table __p;
	}
}
