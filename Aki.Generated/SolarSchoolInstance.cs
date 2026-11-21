using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011ED RID: 4589
	public struct SolarSchoolInstance : IFlatbufferObject
	{
		// Token: 0x170039AD RID: 14765
		// (get) Token: 0x0600E1AE RID: 57774 RVA: 0x0034175C File Offset: 0x0033F95C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E1AF RID: 57775 RVA: 0x00341769 File Offset: 0x0033F969
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E1B0 RID: 57776 RVA: 0x00341770 File Offset: 0x0033F970
		public static SolarSchoolInstance GetRootAsSolarSchoolInstance(ByteBuffer _bb)
		{
			return SolarSchoolInstance.GetRootAsSolarSchoolInstance(_bb, default(SolarSchoolInstance));
		}

		// Token: 0x0600E1B1 RID: 57777 RVA: 0x0034178C File Offset: 0x0033F98C
		public static SolarSchoolInstance GetRootAsSolarSchoolInstance(ByteBuffer _bb, SolarSchoolInstance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E1B2 RID: 57778 RVA: 0x003417A9 File Offset: 0x0033F9A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E1B3 RID: 57779 RVA: 0x003417B8 File Offset: 0x0033F9B8
		public SolarSchoolInstance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170039AE RID: 14766
		// (get) Token: 0x0600E1B4 RID: 57780 RVA: 0x003417C8 File Offset: 0x0033F9C8
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

		// Token: 0x170039AF RID: 14767
		// (get) Token: 0x0600E1B5 RID: 57781 RVA: 0x00341804 File Offset: 0x0033FA04
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

		// Token: 0x170039B0 RID: 14768
		// (get) Token: 0x0600E1B6 RID: 57782 RVA: 0x00341840 File Offset: 0x0033FA40
		public int InstanceType
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

		// Token: 0x170039B1 RID: 14769
		// (get) Token: 0x0600E1B7 RID: 57783 RVA: 0x0034187C File Offset: 0x0033FA7C
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

		// Token: 0x0600E1B8 RID: 57784 RVA: 0x003418B4 File Offset: 0x0033FAB4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E1B9 RID: 57785 RVA: 0x003418C4 File Offset: 0x0033FAC4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170039B2 RID: 14770
		// (get) Token: 0x0600E1BA RID: 57786 RVA: 0x003418DC File Offset: 0x0033FADC
		public string FestivalName
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

		// Token: 0x0600E1BB RID: 57787 RVA: 0x00341914 File Offset: 0x0033FB14
		public Span<byte> GetFestivalNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E1BC RID: 57788 RVA: 0x00341924 File Offset: 0x0033FB24
		public byte[] GetFestivalNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170039B3 RID: 14771
		// (get) Token: 0x0600E1BD RID: 57789 RVA: 0x0034193C File Offset: 0x0033FB3C
		public string OutBtnText
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

		// Token: 0x0600E1BE RID: 57790 RVA: 0x00341974 File Offset: 0x0033FB74
		public Span<byte> GetOutBtnTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E1BF RID: 57791 RVA: 0x00341984 File Offset: 0x0033FB84
		public byte[] GetOutBtnTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170039B4 RID: 14772
		// (get) Token: 0x0600E1C0 RID: 57792 RVA: 0x0034199C File Offset: 0x0033FB9C
		public int OutFrameId
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

		// Token: 0x0600E1C1 RID: 57793 RVA: 0x003419DC File Offset: 0x0033FBDC
		public int EnterActionIdList(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170039B5 RID: 14773
		// (get) Token: 0x0600E1C2 RID: 57794 RVA: 0x00341A1C File Offset: 0x0033FC1C
		public int EnterActionIdListLength
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

		// Token: 0x0600E1C3 RID: 57795 RVA: 0x00341A48 File Offset: 0x0033FC48
		public Span<int> GetEnterActionIdListBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600E1C4 RID: 57796 RVA: 0x00341A58 File Offset: 0x0033FC58
		public int[] GetEnterActionIdListArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600E1C5 RID: 57797 RVA: 0x00341A70 File Offset: 0x0033FC70
		public int MapActionIdList(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170039B6 RID: 14774
		// (get) Token: 0x0600E1C6 RID: 57798 RVA: 0x00341AB0 File Offset: 0x0033FCB0
		public int MapActionIdListLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E1C7 RID: 57799 RVA: 0x00341ADC File Offset: 0x0033FCDC
		public Span<int> GetMapActionIdListBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600E1C8 RID: 57800 RVA: 0x00341AEC File Offset: 0x0033FCEC
		public int[] GetMapActionIdListArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600E1C9 RID: 57801 RVA: 0x00341B04 File Offset: 0x0033FD04
		public int EndActionIdList(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170039B7 RID: 14775
		// (get) Token: 0x0600E1CA RID: 57802 RVA: 0x00341B44 File Offset: 0x0033FD44
		public int EndActionIdListLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E1CB RID: 57803 RVA: 0x00341B70 File Offset: 0x0033FD70
		public Span<int> GetEndActionIdListBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600E1CC RID: 57804 RVA: 0x00341B80 File Offset: 0x0033FD80
		public int[] GetEndActionIdListArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600E1CD RID: 57805 RVA: 0x00341B98 File Offset: 0x0033FD98
		[NullableContext(1)]
		public int[] EndActionIdList()
		{
			return this.GetEndActionIdListArray();
		}

		// Token: 0x0600E1CE RID: 57806 RVA: 0x00341BA0 File Offset: 0x0033FDA0
		[NullableContext(1)]
		public IEnumerable<int> EndActionIdListIter()
		{
			SolarSchoolInstance.<EndActionIdListIter>d__44 <EndActionIdListIter>d__ = new SolarSchoolInstance.<EndActionIdListIter>d__44(-2);
			<EndActionIdListIter>d__.<>3__<>4__this = this;
			return <EndActionIdListIter>d__;
		}

		// Token: 0x0600E1CF RID: 57807 RVA: 0x00341BB5 File Offset: 0x0033FDB5
		[NullableContext(1)]
		public int[] EnterActionIdList()
		{
			return this.GetEnterActionIdListArray();
		}

		// Token: 0x0600E1D0 RID: 57808 RVA: 0x00341BBD File Offset: 0x0033FDBD
		[NullableContext(1)]
		public IEnumerable<int> EnterActionIdListIter()
		{
			SolarSchoolInstance.<EnterActionIdListIter>d__46 <EnterActionIdListIter>d__ = new SolarSchoolInstance.<EnterActionIdListIter>d__46(-2);
			<EnterActionIdListIter>d__.<>3__<>4__this = this;
			return <EnterActionIdListIter>d__;
		}

		// Token: 0x0600E1D1 RID: 57809 RVA: 0x00341BD2 File Offset: 0x0033FDD2
		[NullableContext(1)]
		public int[] MapActionIdList()
		{
			return this.GetMapActionIdListArray();
		}

		// Token: 0x0600E1D2 RID: 57810 RVA: 0x00341BDA File Offset: 0x0033FDDA
		[NullableContext(1)]
		public IEnumerable<int> MapActionIdListIter()
		{
			SolarSchoolInstance.<MapActionIdListIter>d__48 <MapActionIdListIter>d__ = new SolarSchoolInstance.<MapActionIdListIter>d__48(-2);
			<MapActionIdListIter>d__.<>3__<>4__this = this;
			return <MapActionIdListIter>d__;
		}

		// Token: 0x0400582A RID: 22570
		private Table __p;
	}
}
