using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200121B RID: 4635
	public struct SpringFestival : IFlatbufferObject
	{
		// Token: 0x17003B4C RID: 15180
		// (get) Token: 0x0600E59B RID: 58779 RVA: 0x0034A371 File Offset: 0x00348571
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E59C RID: 58780 RVA: 0x0034A37E File Offset: 0x0034857E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E59D RID: 58781 RVA: 0x0034A388 File Offset: 0x00348588
		public static SpringFestival GetRootAsSpringFestival(ByteBuffer _bb)
		{
			return SpringFestival.GetRootAsSpringFestival(_bb, default(SpringFestival));
		}

		// Token: 0x0600E59E RID: 58782 RVA: 0x0034A3A4 File Offset: 0x003485A4
		public static SpringFestival GetRootAsSpringFestival(ByteBuffer _bb, SpringFestival obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E59F RID: 58783 RVA: 0x0034A3C1 File Offset: 0x003485C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E5A0 RID: 58784 RVA: 0x0034A3D0 File Offset: 0x003485D0
		public SpringFestival __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B4D RID: 15181
		// (get) Token: 0x0600E5A1 RID: 58785 RVA: 0x0034A3E0 File Offset: 0x003485E0
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

		// Token: 0x17003B4E RID: 15182
		// (get) Token: 0x0600E5A2 RID: 58786 RVA: 0x0034A41C File Offset: 0x0034861C
		public int InstanceId
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

		// Token: 0x17003B4F RID: 15183
		// (get) Token: 0x0600E5A3 RID: 58787 RVA: 0x0034A458 File Offset: 0x00348658
		public int ScoreItemId
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

		// Token: 0x17003B50 RID: 15184
		// (get) Token: 0x0600E5A4 RID: 58788 RVA: 0x0034A494 File Offset: 0x00348694
		public int ShopId
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

		// Token: 0x17003B51 RID: 15185
		// (get) Token: 0x0600E5A5 RID: 58789 RVA: 0x0034A4D4 File Offset: 0x003486D4
		public int ShopNpcEntityId
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

		// Token: 0x17003B52 RID: 15186
		// (get) Token: 0x0600E5A6 RID: 58790 RVA: 0x0034A514 File Offset: 0x00348714
		public int SpareShopNpcEntityId
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

		// Token: 0x17003B53 RID: 15187
		// (get) Token: 0x0600E5A7 RID: 58791 RVA: 0x0034A554 File Offset: 0x00348754
		public string ShopNpcName
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E5A8 RID: 58792 RVA: 0x0034A58C File Offset: 0x0034878C
		public Span<byte> GetShopNpcNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E5A9 RID: 58793 RVA: 0x0034A59C File Offset: 0x0034879C
		public byte[] GetShopNpcNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B54 RID: 15188
		// (get) Token: 0x0600E5AA RID: 58794 RVA: 0x0034A5B4 File Offset: 0x003487B4
		public string ShopNpcSpeak
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

		// Token: 0x0600E5AB RID: 58795 RVA: 0x0034A5EC File Offset: 0x003487EC
		public Span<byte> GetShopNpcSpeakBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E5AC RID: 58796 RVA: 0x0034A5FC File Offset: 0x003487FC
		public byte[] GetShopNpcSpeakArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B55 RID: 15189
		// (get) Token: 0x0600E5AD RID: 58797 RVA: 0x0034A614 File Offset: 0x00348814
		public string ShopNpcStartMontage
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

		// Token: 0x0600E5AE RID: 58798 RVA: 0x0034A64C File Offset: 0x0034884C
		public Span<byte> GetShopNpcStartMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600E5AF RID: 58799 RVA: 0x0034A65C File Offset: 0x0034885C
		public byte[] GetShopNpcStartMontageArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B56 RID: 15190
		// (get) Token: 0x0600E5B0 RID: 58800 RVA: 0x0034A674 File Offset: 0x00348874
		public int VisionSkinItemId
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

		// Token: 0x17003B57 RID: 15191
		// (get) Token: 0x0600E5B1 RID: 58801 RVA: 0x0034A6B4 File Offset: 0x003488B4
		public string TrackRewardIconPath
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E5B2 RID: 58802 RVA: 0x0034A6EC File Offset: 0x003488EC
		public Span<byte> GetTrackRewardIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600E5B3 RID: 58803 RVA: 0x0034A6FC File Offset: 0x003488FC
		public byte[] GetTrackRewardIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E5B4 RID: 58804 RVA: 0x0034A714 File Offset: 0x00348914
		public int EntityWhiteList(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B58 RID: 15192
		// (get) Token: 0x0600E5B5 RID: 58805 RVA: 0x0034A754 File Offset: 0x00348954
		public int EntityWhiteListLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E5B6 RID: 58806 RVA: 0x0034A780 File Offset: 0x00348980
		public Span<int> GetEntityWhiteListBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600E5B7 RID: 58807 RVA: 0x0034A790 File Offset: 0x00348990
		public int[] GetEntityWhiteListArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x0600E5B8 RID: 58808 RVA: 0x0034A7A8 File Offset: 0x003489A8
		[NullableContext(1)]
		public int[] EntityWhiteList()
		{
			return this.GetEntityWhiteListArray();
		}

		// Token: 0x0600E5B9 RID: 58809 RVA: 0x0034A7B0 File Offset: 0x003489B0
		[NullableContext(1)]
		public IEnumerable<int> EntityWhiteListIter()
		{
			SpringFestival.<EntityWhiteListIter>d__44 <EntityWhiteListIter>d__ = new SpringFestival.<EntityWhiteListIter>d__44(-2);
			<EntityWhiteListIter>d__.<>3__<>4__this = this;
			return <EntityWhiteListIter>d__;
		}

		// Token: 0x0400585B RID: 22619
		private Table __p;
	}
}
