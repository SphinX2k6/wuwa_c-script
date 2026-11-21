using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011EE RID: 4590
	public struct SolarSchoolItem : IFlatbufferObject
	{
		// Token: 0x170039B8 RID: 14776
		// (get) Token: 0x0600E1D3 RID: 57811 RVA: 0x00341BEF File Offset: 0x0033FDEF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E1D4 RID: 57812 RVA: 0x00341BFC File Offset: 0x0033FDFC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E1D5 RID: 57813 RVA: 0x00341C04 File Offset: 0x0033FE04
		public static SolarSchoolItem GetRootAsSolarSchoolItem(ByteBuffer _bb)
		{
			return SolarSchoolItem.GetRootAsSolarSchoolItem(_bb, default(SolarSchoolItem));
		}

		// Token: 0x0600E1D6 RID: 57814 RVA: 0x00341C20 File Offset: 0x0033FE20
		public static SolarSchoolItem GetRootAsSolarSchoolItem(ByteBuffer _bb, SolarSchoolItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E1D7 RID: 57815 RVA: 0x00341C3D File Offset: 0x0033FE3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E1D8 RID: 57816 RVA: 0x00341C4C File Offset: 0x0033FE4C
		public SolarSchoolItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170039B9 RID: 14777
		// (get) Token: 0x0600E1D9 RID: 57817 RVA: 0x00341C5C File Offset: 0x0033FE5C
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

		// Token: 0x170039BA RID: 14778
		// (get) Token: 0x0600E1DA RID: 57818 RVA: 0x00341C98 File Offset: 0x0033FE98
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

		// Token: 0x170039BB RID: 14779
		// (get) Token: 0x0600E1DB RID: 57819 RVA: 0x00341CD4 File Offset: 0x0033FED4
		public int SortId
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

		// Token: 0x170039BC RID: 14780
		// (get) Token: 0x0600E1DC RID: 57820 RVA: 0x00341D10 File Offset: 0x0033FF10
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

		// Token: 0x0600E1DD RID: 57821 RVA: 0x00341D48 File Offset: 0x0033FF48
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E1DE RID: 57822 RVA: 0x00341D58 File Offset: 0x0033FF58
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170039BD RID: 14781
		// (get) Token: 0x0600E1DF RID: 57823 RVA: 0x00341D70 File Offset: 0x0033FF70
		public int ItemType
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

		// Token: 0x170039BE RID: 14782
		// (get) Token: 0x0600E1E0 RID: 57824 RVA: 0x00341DB0 File Offset: 0x0033FFB0
		public string Icon
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

		// Token: 0x0600E1E1 RID: 57825 RVA: 0x00341DE8 File Offset: 0x0033FFE8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E1E2 RID: 57826 RVA: 0x00341DF8 File Offset: 0x0033FFF8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170039BF RID: 14783
		// (get) Token: 0x0600E1E3 RID: 57827 RVA: 0x00341E10 File Offset: 0x00340010
		public string Desc
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

		// Token: 0x0600E1E4 RID: 57828 RVA: 0x00341E48 File Offset: 0x00340048
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E1E5 RID: 57829 RVA: 0x00341E58 File Offset: 0x00340058
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170039C0 RID: 14784
		// (get) Token: 0x0600E1E6 RID: 57830 RVA: 0x00341E70 File Offset: 0x00340070
		public string SourceDesc
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

		// Token: 0x0600E1E7 RID: 57831 RVA: 0x00341EA8 File Offset: 0x003400A8
		public Span<byte> GetSourceDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E1E8 RID: 57832 RVA: 0x00341EB8 File Offset: 0x003400B8
		public byte[] GetSourceDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170039C1 RID: 14785
		// (get) Token: 0x0600E1E9 RID: 57833 RVA: 0x00341ED0 File Offset: 0x003400D0
		public int StackLimit
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

		// Token: 0x170039C2 RID: 14786
		// (get) Token: 0x0600E1EA RID: 57834 RVA: 0x00341F10 File Offset: 0x00340110
		public bool ShowFirstGetTip
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170039C3 RID: 14787
		// (get) Token: 0x0600E1EB RID: 57835 RVA: 0x00341F50 File Offset: 0x00340150
		public bool CanUse
		{
			get
			{
				int num = this.__p.__offset(24);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600E1EC RID: 57836 RVA: 0x00341F90 File Offset: 0x00340190
		public int EffectIds(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170039C4 RID: 14788
		// (get) Token: 0x0600E1ED RID: 57837 RVA: 0x00341FD0 File Offset: 0x003401D0
		public int EffectIdsLength
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

		// Token: 0x0600E1EE RID: 57838 RVA: 0x00341FFC File Offset: 0x003401FC
		public Span<int> GetEffectIdsBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600E1EF RID: 57839 RVA: 0x0034200C File Offset: 0x0034020C
		public int[] GetEffectIdsArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x170039C5 RID: 14789
		// (get) Token: 0x0600E1F0 RID: 57840 RVA: 0x00342024 File Offset: 0x00340224
		public int BitFlag
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

		// Token: 0x0600E1F1 RID: 57841 RVA: 0x00342064 File Offset: 0x00340264
		public int FavorRoleList(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170039C6 RID: 14790
		// (get) Token: 0x0600E1F2 RID: 57842 RVA: 0x003420A4 File Offset: 0x003402A4
		public int FavorRoleListLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E1F3 RID: 57843 RVA: 0x003420D0 File Offset: 0x003402D0
		public Span<int> GetFavorRoleListBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x0600E1F4 RID: 57844 RVA: 0x003420E0 File Offset: 0x003402E0
		public int[] GetFavorRoleListArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x170039C7 RID: 14791
		// (get) Token: 0x0600E1F5 RID: 57845 RVA: 0x003420F8 File Offset: 0x003402F8
		public int DailyMax
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 99;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E1F6 RID: 57846 RVA: 0x00342136 File Offset: 0x00340336
		[NullableContext(1)]
		public int[] EffectIds()
		{
			return this.GetEffectIdsArray();
		}

		// Token: 0x0600E1F7 RID: 57847 RVA: 0x0034213E File Offset: 0x0034033E
		[NullableContext(1)]
		public IEnumerable<int> EffectIdsIter()
		{
			SolarSchoolItem.<EffectIdsIter>d__53 <EffectIdsIter>d__ = new SolarSchoolItem.<EffectIdsIter>d__53(-2);
			<EffectIdsIter>d__.<>3__<>4__this = this;
			return <EffectIdsIter>d__;
		}

		// Token: 0x0600E1F8 RID: 57848 RVA: 0x00342153 File Offset: 0x00340353
		[NullableContext(1)]
		public int[] FavorRoleList()
		{
			return this.GetFavorRoleListArray();
		}

		// Token: 0x0600E1F9 RID: 57849 RVA: 0x0034215B File Offset: 0x0034035B
		[NullableContext(1)]
		public IEnumerable<int> FavorRoleListIter()
		{
			SolarSchoolItem.<FavorRoleListIter>d__55 <FavorRoleListIter>d__ = new SolarSchoolItem.<FavorRoleListIter>d__55(-2);
			<FavorRoleListIter>d__.<>3__<>4__this = this;
			return <FavorRoleListIter>d__;
		}

		// Token: 0x0400582B RID: 22571
		private Table __p;
	}
}
