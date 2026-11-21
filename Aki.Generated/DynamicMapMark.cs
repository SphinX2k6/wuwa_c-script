using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CFA RID: 3322
	public struct DynamicMapMark : IFlatbufferObject
	{
		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x06006CB1 RID: 27825 RVA: 0x0023D6E4 File Offset: 0x0023B8E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006CB2 RID: 27826 RVA: 0x0023D6F1 File Offset: 0x0023B8F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006CB3 RID: 27827 RVA: 0x0023D6F8 File Offset: 0x0023B8F8
		public static DynamicMapMark GetRootAsDynamicMapMark(ByteBuffer _bb)
		{
			return DynamicMapMark.GetRootAsDynamicMapMark(_bb, default(DynamicMapMark));
		}

		// Token: 0x06006CB4 RID: 27828 RVA: 0x0023D714 File Offset: 0x0023B914
		public static DynamicMapMark GetRootAsDynamicMapMark(ByteBuffer _bb, DynamicMapMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006CB5 RID: 27829 RVA: 0x0023D731 File Offset: 0x0023B931
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006CB6 RID: 27830 RVA: 0x0023D740 File Offset: 0x0023B940
		public DynamicMapMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x06006CB7 RID: 27831 RVA: 0x0023D750 File Offset: 0x0023B950
		public int MarkId
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

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x06006CB8 RID: 27832 RVA: 0x0023D78C File Offset: 0x0023B98C
		public int InstanceDungeonId
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

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06006CB9 RID: 27833 RVA: 0x0023D7C8 File Offset: 0x0023B9C8
		public int MapId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06006CBA RID: 27834 RVA: 0x0023D804 File Offset: 0x0023BA04
		public int RelativeSubType
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

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06006CBB RID: 27835 RVA: 0x0023D844 File Offset: 0x0023BA44
		public int RelativeDungeonId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06006CBC RID: 27836 RVA: 0x0023D884 File Offset: 0x0023BA84
		public int FogHide
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

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06006CBD RID: 27837 RVA: 0x0023D8C4 File Offset: 0x0023BAC4
		public int RelativeType
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

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06006CBE RID: 27838 RVA: 0x0023D904 File Offset: 0x0023BB04
		public int RelativeId
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

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06006CBF RID: 27839 RVA: 0x0023D944 File Offset: 0x0023BB44
		public IntVector? MarkVector
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IntVector?(default(IntVector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06006CC0 RID: 27840 RVA: 0x0023D9A4 File Offset: 0x0023BBA4
		public int EntityConfigId
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

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06006CC1 RID: 27841 RVA: 0x0023D9E4 File Offset: 0x0023BBE4
		public int ObjectType
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

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06006CC2 RID: 27842 RVA: 0x0023DA24 File Offset: 0x0023BC24
		public string MarkTitle
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

		// Token: 0x06006CC3 RID: 27843 RVA: 0x0023DA5C File Offset: 0x0023BC5C
		public Span<byte> GetMarkTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06006CC4 RID: 27844 RVA: 0x0023DA6C File Offset: 0x0023BC6C
		public byte[] GetMarkTitleArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x06006CC5 RID: 27845 RVA: 0x0023DA84 File Offset: 0x0023BC84
		public string MarkDesc
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

		// Token: 0x06006CC6 RID: 27846 RVA: 0x0023DABC File Offset: 0x0023BCBC
		public Span<byte> GetMarkDescBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06006CC7 RID: 27847 RVA: 0x0023DACC File Offset: 0x0023BCCC
		public byte[] GetMarkDescArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x06006CC8 RID: 27848 RVA: 0x0023DAE4 File Offset: 0x0023BCE4
		public int ToBeDiscovered
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

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x06006CC9 RID: 27849 RVA: 0x0023DB24 File Offset: 0x0023BD24
		public int IsMonster
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x06006CCA RID: 27850 RVA: 0x0023DB64 File Offset: 0x0023BD64
		public int ShowPriority
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006CCB RID: 27851 RVA: 0x0023DBA4 File Offset: 0x0023BDA4
		public int ShowRange(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06006CCC RID: 27852 RVA: 0x0023DBE4 File Offset: 0x0023BDE4
		public int ShowRangeLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006CCD RID: 27853 RVA: 0x0023DC10 File Offset: 0x0023BE10
		public Span<int> GetShowRangeBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x06006CCE RID: 27854 RVA: 0x0023DC20 File Offset: 0x0023BE20
		public int[] GetShowRangeArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x06006CCF RID: 27855 RVA: 0x0023DC38 File Offset: 0x0023BE38
		public string LockMarkPic
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006CD0 RID: 27856 RVA: 0x0023DC70 File Offset: 0x0023BE70
		public Span<byte> GetLockMarkPicBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06006CD1 RID: 27857 RVA: 0x0023DC80 File Offset: 0x0023BE80
		public byte[] GetLockMarkPicArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06006CD2 RID: 27858 RVA: 0x0023DC98 File Offset: 0x0023BE98
		public string UnlockMarkPic
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006CD3 RID: 27859 RVA: 0x0023DCD0 File Offset: 0x0023BED0
		public Span<byte> GetUnlockMarkPicBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06006CD4 RID: 27860 RVA: 0x0023DCE0 File Offset: 0x0023BEE0
		public byte[] GetUnlockMarkPicArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06006CD5 RID: 27861 RVA: 0x0023DCF8 File Offset: 0x0023BEF8
		public int ShowCondition
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06006CD6 RID: 27862 RVA: 0x0023DD38 File Offset: 0x0023BF38
		public int FogShow
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06006CD7 RID: 27863 RVA: 0x0023DD78 File Offset: 0x0023BF78
		public int MapShow
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06006CD8 RID: 27864 RVA: 0x0023DDB8 File Offset: 0x0023BFB8
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06006CD9 RID: 27865 RVA: 0x0023DDFC File Offset: 0x0023BFFC
		public float FirstReward
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06006CDA RID: 27866 RVA: 0x0023DE40 File Offset: 0x0023C040
		public float Reward
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06006CDB RID: 27867 RVA: 0x0023DE84 File Offset: 0x0023C084
		public int TrackHudEnable
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06006CDC RID: 27868 RVA: 0x0023DEC4 File Offset: 0x0023C0C4
		public float TrackAutoCancelDistance
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return -1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006CDD RID: 27869 RVA: 0x0023DF05 File Offset: 0x0023C105
		[NullableContext(1)]
		public int[] ShowRange()
		{
			return this.GetShowRangeArray();
		}

		// Token: 0x06006CDE RID: 27870 RVA: 0x0023DF0D File Offset: 0x0023C10D
		[NullableContext(1)]
		public IEnumerable<int> ShowRangeIter()
		{
			DynamicMapMark.<ShowRangeIter>d__74 <ShowRangeIter>d__ = new DynamicMapMark.<ShowRangeIter>d__74(-2);
			<ShowRangeIter>d__.<>3__<>4__this = this;
			return <ShowRangeIter>d__;
		}

		// Token: 0x0400523A RID: 21050
		private Table __p;
	}
}
