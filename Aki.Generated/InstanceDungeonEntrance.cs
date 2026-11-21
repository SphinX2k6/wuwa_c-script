using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E55 RID: 3669
	public struct InstanceDungeonEntrance : IFlatbufferObject
	{
		// Token: 0x17001A06 RID: 6662
		// (get) Token: 0x06008B6C RID: 35692 RVA: 0x00281E84 File Offset: 0x00280084
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008B6D RID: 35693 RVA: 0x00281E91 File Offset: 0x00280091
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008B6E RID: 35694 RVA: 0x00281E98 File Offset: 0x00280098
		public static InstanceDungeonEntrance GetRootAsInstanceDungeonEntrance(ByteBuffer _bb)
		{
			return InstanceDungeonEntrance.GetRootAsInstanceDungeonEntrance(_bb, default(InstanceDungeonEntrance));
		}

		// Token: 0x06008B6F RID: 35695 RVA: 0x00281EB4 File Offset: 0x002800B4
		public static InstanceDungeonEntrance GetRootAsInstanceDungeonEntrance(ByteBuffer _bb, InstanceDungeonEntrance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008B70 RID: 35696 RVA: 0x00281ED1 File Offset: 0x002800D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008B71 RID: 35697 RVA: 0x00281EE0 File Offset: 0x002800E0
		public InstanceDungeonEntrance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A07 RID: 6663
		// (get) Token: 0x06008B72 RID: 35698 RVA: 0x00281EF0 File Offset: 0x002800F0
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

		// Token: 0x17001A08 RID: 6664
		// (get) Token: 0x06008B73 RID: 35699 RVA: 0x00281F2C File Offset: 0x0028012C
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

		// Token: 0x17001A09 RID: 6665
		// (get) Token: 0x06008B74 RID: 35700 RVA: 0x00281F68 File Offset: 0x00280168
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

		// Token: 0x06008B75 RID: 35701 RVA: 0x00281F9F File Offset: 0x0028019F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008B76 RID: 35702 RVA: 0x00281FAE File Offset: 0x002801AE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A0A RID: 6666
		// (get) Token: 0x06008B77 RID: 35703 RVA: 0x00281FC8 File Offset: 0x002801C8
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

		// Token: 0x06008B78 RID: 35704 RVA: 0x00282000 File Offset: 0x00280200
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008B79 RID: 35705 RVA: 0x00282010 File Offset: 0x00280210
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06008B7A RID: 35706 RVA: 0x00282028 File Offset: 0x00280228
		public int InstanceDungeonList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A0B RID: 6667
		// (get) Token: 0x06008B7B RID: 35707 RVA: 0x00282068 File Offset: 0x00280268
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

		// Token: 0x06008B7C RID: 35708 RVA: 0x00282094 File Offset: 0x00280294
		public Span<int> GetInstanceDungeonListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06008B7D RID: 35709 RVA: 0x002820A4 File Offset: 0x002802A4
		public int[] GetInstanceDungeonListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17001A0C RID: 6668
		// (get) Token: 0x06008B7E RID: 35710 RVA: 0x002820BC File Offset: 0x002802BC
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

		// Token: 0x17001A0D RID: 6669
		// (get) Token: 0x06008B7F RID: 35711 RVA: 0x002820FC File Offset: 0x002802FC
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

		// Token: 0x17001A0E RID: 6670
		// (get) Token: 0x06008B80 RID: 35712 RVA: 0x0028213C File Offset: 0x0028033C
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

		// Token: 0x06008B81 RID: 35713 RVA: 0x00282174 File Offset: 0x00280374
		public Span<byte> GetTitleSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06008B82 RID: 35714 RVA: 0x00282184 File Offset: 0x00280384
		public byte[] GetTitleSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x06008B83 RID: 35715 RVA: 0x0028219C File Offset: 0x0028039C
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

		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x06008B84 RID: 35716 RVA: 0x002821DC File Offset: 0x002803DC
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

		// Token: 0x06008B85 RID: 35717 RVA: 0x0028221C File Offset: 0x0028041C
		public IntArray? RegularReward(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x06008B86 RID: 35718 RVA: 0x00282280 File Offset: 0x00280480
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

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x06008B87 RID: 35719 RVA: 0x002822AC File Offset: 0x002804AC
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

		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x06008B88 RID: 35720 RVA: 0x002822EC File Offset: 0x002804EC
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

		// Token: 0x06008B89 RID: 35721 RVA: 0x00282324 File Offset: 0x00280524
		public Span<byte> GetMapBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06008B8A RID: 35722 RVA: 0x00282334 File Offset: 0x00280534
		public byte[] GetMapBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x06008B8B RID: 35723 RVA: 0x0028234C File Offset: 0x0028054C
		[NullableContext(1)]
		public int[] InstanceDungeonList()
		{
			return this.GetInstanceDungeonListArray();
		}

		// Token: 0x06008B8C RID: 35724 RVA: 0x00282354 File Offset: 0x00280554
		[NullableContext(1)]
		public IEnumerable<int> InstanceDungeonListIter()
		{
			InstanceDungeonEntrance.<InstanceDungeonListIter>d__47 <InstanceDungeonListIter>d__ = new InstanceDungeonEntrance.<InstanceDungeonListIter>d__47(-2);
			<InstanceDungeonListIter>d__.<>3__<>4__this = this;
			return <InstanceDungeonListIter>d__;
		}

		// Token: 0x06008B8D RID: 35725 RVA: 0x00282369 File Offset: 0x00280569
		[NullableContext(1)]
		public IntArray[] RegularReward()
		{
			return this.RegularRewardIter().ToArray<IntArray>();
		}

		// Token: 0x06008B8E RID: 35726 RVA: 0x00282376 File Offset: 0x00280576
		[NullableContext(1)]
		public IEnumerable<IntArray> RegularRewardIter()
		{
			InstanceDungeonEntrance.<RegularRewardIter>d__49 <RegularRewardIter>d__ = new InstanceDungeonEntrance.<RegularRewardIter>d__49(-2);
			<RegularRewardIter>d__.<>3__<>4__this = this;
			return <RegularRewardIter>d__;
		}

		// Token: 0x040053DD RID: 21469
		private Table __p;
	}
}
