using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C49 RID: 3145
	public struct ChatCharm : IFlatbufferObject
	{
		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x0600590D RID: 22797 RVA: 0x002112CE File Offset: 0x0020F4CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600590E RID: 22798 RVA: 0x002112DB File Offset: 0x0020F4DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600590F RID: 22799 RVA: 0x002112E4 File Offset: 0x0020F4E4
		public static ChatCharm GetRootAsChatCharm(ByteBuffer _bb)
		{
			return ChatCharm.GetRootAsChatCharm(_bb, default(ChatCharm));
		}

		// Token: 0x06005910 RID: 22800 RVA: 0x00211300 File Offset: 0x0020F500
		public static ChatCharm GetRootAsChatCharm(ByteBuffer _bb, ChatCharm obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005911 RID: 22801 RVA: 0x0021131D File Offset: 0x0020F51D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005912 RID: 22802 RVA: 0x0021132C File Offset: 0x0020F52C
		public ChatCharm __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06005913 RID: 22803 RVA: 0x0021133C File Offset: 0x0020F53C
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

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06005914 RID: 22804 RVA: 0x00211378 File Offset: 0x0020F578
		public int QualityId
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

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06005915 RID: 22805 RVA: 0x002113B4 File Offset: 0x0020F5B4
		public string ChatCharmPathSmall
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

		// Token: 0x06005916 RID: 22806 RVA: 0x002113EB File Offset: 0x0020F5EB
		public Span<byte> GetChatCharmPathSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005917 RID: 22807 RVA: 0x002113FA File Offset: 0x0020F5FA
		public byte[] GetChatCharmPathSmallArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06005918 RID: 22808 RVA: 0x00211414 File Offset: 0x0020F614
		public string Name
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

		// Token: 0x06005919 RID: 22809 RVA: 0x0021144C File Offset: 0x0020F64C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600591A RID: 22810 RVA: 0x0021145C File Offset: 0x0020F65C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x0600591B RID: 22811 RVA: 0x00211474 File Offset: 0x0020F674
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600591C RID: 22812 RVA: 0x002114AC File Offset: 0x0020F6AC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600591D RID: 22813 RVA: 0x002114BC File Offset: 0x0020F6BC
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x0600591E RID: 22814 RVA: 0x002114D4 File Offset: 0x0020F6D4
		public string GetWay
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

		// Token: 0x0600591F RID: 22815 RVA: 0x0021150C File Offset: 0x0020F70C
		public Span<byte> GetGetWayBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005920 RID: 22816 RVA: 0x0021151C File Offset: 0x0020F71C
		public byte[] GetGetWayArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06005921 RID: 22817 RVA: 0x00211534 File Offset: 0x0020F734
		public int SortId
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

		// Token: 0x06005922 RID: 22818 RVA: 0x00211574 File Offset: 0x0020F774
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06005923 RID: 22819 RVA: 0x002115B4 File Offset: 0x0020F7B4
		public int ItemAccessLength
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

		// Token: 0x06005924 RID: 22820 RVA: 0x002115E0 File Offset: 0x0020F7E0
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06005925 RID: 22821 RVA: 0x002115F0 File Offset: 0x0020F7F0
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06005926 RID: 22822 RVA: 0x00211608 File Offset: 0x0020F808
		public string SpineAtlas
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

		// Token: 0x06005927 RID: 22823 RVA: 0x00211640 File Offset: 0x0020F840
		public Span<byte> GetSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06005928 RID: 22824 RVA: 0x00211650 File Offset: 0x0020F850
		public byte[] GetSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06005929 RID: 22825 RVA: 0x00211668 File Offset: 0x0020F868
		public string SpineSkeleton
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600592A RID: 22826 RVA: 0x002116A0 File Offset: 0x0020F8A0
		public Span<byte> GetSpineSkeletonBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600592B RID: 22827 RVA: 0x002116B0 File Offset: 0x0020F8B0
		public byte[] GetSpineSkeletonArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0600592C RID: 22828 RVA: 0x002116C8 File Offset: 0x0020F8C8
		public string SpineAnimStandby(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x0600592D RID: 22829 RVA: 0x00211704 File Offset: 0x0020F904
		public int SpineAnimStandbyLength
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

		// Token: 0x0600592E RID: 22830 RVA: 0x00211730 File Offset: 0x0020F930
		public string SpineAnimTouch(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x0600592F RID: 22831 RVA: 0x0021176C File Offset: 0x0020F96C
		public int SpineAnimTouchLength
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

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06005930 RID: 22832 RVA: 0x00211798 File Offset: 0x0020F998
		public string SpineAnimIdle
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

		// Token: 0x06005931 RID: 22833 RVA: 0x002117D0 File Offset: 0x0020F9D0
		public Span<byte> GetSpineAnimIdleBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06005932 RID: 22834 RVA: 0x002117E0 File Offset: 0x0020F9E0
		public byte[] GetSpineAnimIdleArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06005933 RID: 22835 RVA: 0x002117F8 File Offset: 0x0020F9F8
		public float SpineProbability
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06005934 RID: 22836 RVA: 0x0021183C File Offset: 0x0020FA3C
		public string Spinepre
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005935 RID: 22837 RVA: 0x00211874 File Offset: 0x0020FA74
		public Span<byte> GetSpinepreBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06005936 RID: 22838 RVA: 0x00211884 File Offset: 0x0020FA84
		public byte[] GetSpinepreArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06005937 RID: 22839 RVA: 0x0021189C File Offset: 0x0020FA9C
		public string Icon
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

		// Token: 0x06005938 RID: 22840 RVA: 0x002118D4 File Offset: 0x0020FAD4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06005939 RID: 22841 RVA: 0x002118E4 File Offset: 0x0020FAE4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x0600593A RID: 22842 RVA: 0x002118FC File Offset: 0x0020FAFC
		public string IconMiddle
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600593B RID: 22843 RVA: 0x00211934 File Offset: 0x0020FB34
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600593C RID: 22844 RVA: 0x00211944 File Offset: 0x0020FB44
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x0600593D RID: 22845 RVA: 0x0021195C File Offset: 0x0020FB5C
		public string IconSmall
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

		// Token: 0x0600593E RID: 22846 RVA: 0x00211994 File Offset: 0x0020FB94
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600593F RID: 22847 RVA: 0x002119A4 File Offset: 0x0020FBA4
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06005940 RID: 22848 RVA: 0x002119BC File Offset: 0x0020FBBC
		public string TypeDescription
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

		// Token: 0x06005941 RID: 22849 RVA: 0x002119F4 File Offset: 0x0020FBF4
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06005942 RID: 22850 RVA: 0x00211A04 File Offset: 0x0020FC04
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06005943 RID: 22851 RVA: 0x00211A1C File Offset: 0x0020FC1C
		public string AttributesDescription
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005944 RID: 22852 RVA: 0x00211A54 File Offset: 0x0020FC54
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06005945 RID: 22853 RVA: 0x00211A64 File Offset: 0x0020FC64
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06005946 RID: 22854 RVA: 0x00211A7C File Offset: 0x0020FC7C
		public string BgDescription
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005947 RID: 22855 RVA: 0x00211AB4 File Offset: 0x0020FCB4
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06005948 RID: 22856 RVA: 0x00211AC4 File Offset: 0x0020FCC4
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x06005949 RID: 22857 RVA: 0x00211ADC File Offset: 0x0020FCDC
		[NullableContext(1)]
		public int[] ItemAccess()
		{
			return this.GetItemAccessArray();
		}

		// Token: 0x0600594A RID: 22858 RVA: 0x00211AE4 File Offset: 0x0020FCE4
		[NullableContext(1)]
		public IEnumerable<int> ItemAccessIter()
		{
			ChatCharm.<ItemAccessIter>d__84 <ItemAccessIter>d__ = new ChatCharm.<ItemAccessIter>d__84(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x0600594B RID: 22859 RVA: 0x00211AF9 File Offset: 0x0020FCF9
		[NullableContext(1)]
		public string[] SpineAnimStandby()
		{
			return this.SpineAnimStandbyIter().ToArray<string>();
		}

		// Token: 0x0600594C RID: 22860 RVA: 0x00211B06 File Offset: 0x0020FD06
		[NullableContext(1)]
		public IEnumerable<string> SpineAnimStandbyIter()
		{
			ChatCharm.<SpineAnimStandbyIter>d__86 <SpineAnimStandbyIter>d__ = new ChatCharm.<SpineAnimStandbyIter>d__86(-2);
			<SpineAnimStandbyIter>d__.<>3__<>4__this = this;
			return <SpineAnimStandbyIter>d__;
		}

		// Token: 0x0600594D RID: 22861 RVA: 0x00211B1B File Offset: 0x0020FD1B
		[NullableContext(1)]
		public string[] SpineAnimTouch()
		{
			return this.SpineAnimTouchIter().ToArray<string>();
		}

		// Token: 0x0600594E RID: 22862 RVA: 0x00211B28 File Offset: 0x0020FD28
		[NullableContext(1)]
		public IEnumerable<string> SpineAnimTouchIter()
		{
			ChatCharm.<SpineAnimTouchIter>d__88 <SpineAnimTouchIter>d__ = new ChatCharm.<SpineAnimTouchIter>d__88(-2);
			<SpineAnimTouchIter>d__.<>3__<>4__this = this;
			return <SpineAnimTouchIter>d__;
		}

		// Token: 0x0400514B RID: 20811
		private Table __p;
	}
}
