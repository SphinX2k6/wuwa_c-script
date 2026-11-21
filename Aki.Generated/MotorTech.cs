using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F52 RID: 3922
	public struct MotorTech : IFlatbufferObject
	{
		// Token: 0x170022B8 RID: 8888
		// (get) Token: 0x0600A2A7 RID: 41639 RVA: 0x002B5BC5 File Offset: 0x002B3DC5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A2A8 RID: 41640 RVA: 0x002B5BD2 File Offset: 0x002B3DD2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A2A9 RID: 41641 RVA: 0x002B5BDC File Offset: 0x002B3DDC
		public static MotorTech GetRootAsMotorTech(ByteBuffer _bb)
		{
			return MotorTech.GetRootAsMotorTech(_bb, default(MotorTech));
		}

		// Token: 0x0600A2AA RID: 41642 RVA: 0x002B5BF8 File Offset: 0x002B3DF8
		public static MotorTech GetRootAsMotorTech(ByteBuffer _bb, MotorTech obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A2AB RID: 41643 RVA: 0x002B5C15 File Offset: 0x002B3E15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A2AC RID: 41644 RVA: 0x002B5C24 File Offset: 0x002B3E24
		public MotorTech __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170022B9 RID: 8889
		// (get) Token: 0x0600A2AD RID: 41645 RVA: 0x002B5C34 File Offset: 0x002B3E34
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

		// Token: 0x170022BA RID: 8890
		// (get) Token: 0x0600A2AE RID: 41646 RVA: 0x002B5C70 File Offset: 0x002B3E70
		public int TreeType
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

		// Token: 0x170022BB RID: 8891
		// (get) Token: 0x0600A2AF RID: 41647 RVA: 0x002B5CAC File Offset: 0x002B3EAC
		public int GeneralNodeSortOrder
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

		// Token: 0x0600A2B0 RID: 41648 RVA: 0x002B5CE8 File Offset: 0x002B3EE8
		public int ExclusiveNodeSortOrder(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022BC RID: 8892
		// (get) Token: 0x0600A2B1 RID: 41649 RVA: 0x002B5D28 File Offset: 0x002B3F28
		public int ExclusiveNodeSortOrderLength
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

		// Token: 0x0600A2B2 RID: 41650 RVA: 0x002B5D54 File Offset: 0x002B3F54
		public Span<int> GetExclusiveNodeSortOrderBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600A2B3 RID: 41651 RVA: 0x002B5D64 File Offset: 0x002B3F64
		public int[] GetExclusiveNodeSortOrderArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170022BD RID: 8893
		// (get) Token: 0x0600A2B4 RID: 41652 RVA: 0x002B5D7C File Offset: 0x002B3F7C
		public int DetailOrder
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

		// Token: 0x170022BE RID: 8894
		// (get) Token: 0x0600A2B5 RID: 41653 RVA: 0x002B5DBC File Offset: 0x002B3FBC
		public int ShowStyle
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

		// Token: 0x170022BF RID: 8895
		// (get) Token: 0x0600A2B6 RID: 41654 RVA: 0x002B5DFC File Offset: 0x002B3FFC
		public string Icon
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

		// Token: 0x0600A2B7 RID: 41655 RVA: 0x002B5E34 File Offset: 0x002B4034
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A2B8 RID: 41656 RVA: 0x002B5E44 File Offset: 0x002B4044
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170022C0 RID: 8896
		// (get) Token: 0x0600A2B9 RID: 41657 RVA: 0x002B5E5C File Offset: 0x002B405C
		public string VideoName
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

		// Token: 0x0600A2BA RID: 41658 RVA: 0x002B5E94 File Offset: 0x002B4094
		public Span<byte> GetVideoNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A2BB RID: 41659 RVA: 0x002B5EA4 File Offset: 0x002B40A4
		public byte[] GetVideoNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170022C1 RID: 8897
		// (get) Token: 0x0600A2BC RID: 41660 RVA: 0x002B5EBC File Offset: 0x002B40BC
		public string Video
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

		// Token: 0x0600A2BD RID: 41661 RVA: 0x002B5EF4 File Offset: 0x002B40F4
		public Span<byte> GetVideoBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A2BE RID: 41662 RVA: 0x002B5F04 File Offset: 0x002B4104
		public byte[] GetVideoArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170022C2 RID: 8898
		// (get) Token: 0x0600A2BF RID: 41663 RVA: 0x002B5F1C File Offset: 0x002B411C
		public string VideoFemale
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

		// Token: 0x0600A2C0 RID: 41664 RVA: 0x002B5F54 File Offset: 0x002B4154
		public Span<byte> GetVideoFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600A2C1 RID: 41665 RVA: 0x002B5F64 File Offset: 0x002B4164
		public byte[] GetVideoFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170022C3 RID: 8899
		// (get) Token: 0x0600A2C2 RID: 41666 RVA: 0x002B5F7C File Offset: 0x002B417C
		public string Title
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

		// Token: 0x0600A2C3 RID: 41667 RVA: 0x002B5FB4 File Offset: 0x002B41B4
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600A2C4 RID: 41668 RVA: 0x002B5FC4 File Offset: 0x002B41C4
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170022C4 RID: 8900
		// (get) Token: 0x0600A2C5 RID: 41669 RVA: 0x002B5FDC File Offset: 0x002B41DC
		public string DescSimple
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

		// Token: 0x0600A2C6 RID: 41670 RVA: 0x002B6014 File Offset: 0x002B4214
		public Span<byte> GetDescSimpleBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600A2C7 RID: 41671 RVA: 0x002B6024 File Offset: 0x002B4224
		public byte[] GetDescSimpleArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170022C5 RID: 8901
		// (get) Token: 0x0600A2C8 RID: 41672 RVA: 0x002B603C File Offset: 0x002B423C
		public int TagId
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

		// Token: 0x170022C6 RID: 8902
		// (get) Token: 0x0600A2C9 RID: 41673 RVA: 0x002B607C File Offset: 0x002B427C
		public int Type
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

		// Token: 0x0600A2CA RID: 41674 RVA: 0x002B60BC File Offset: 0x002B42BC
		public int PreNode(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022C7 RID: 8903
		// (get) Token: 0x0600A2CB RID: 41675 RVA: 0x002B60FC File Offset: 0x002B42FC
		public int PreNodeLength
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

		// Token: 0x0600A2CC RID: 41676 RVA: 0x002B6128 File Offset: 0x002B4328
		public Span<int> GetPreNodeBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x0600A2CD RID: 41677 RVA: 0x002B6138 File Offset: 0x002B4338
		public int[] GetPreNodeArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x0600A2CE RID: 41678 RVA: 0x002B6150 File Offset: 0x002B4350
		public int TechLv(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022C8 RID: 8904
		// (get) Token: 0x0600A2CF RID: 41679 RVA: 0x002B6190 File Offset: 0x002B4390
		public int TechLvLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A2D0 RID: 41680 RVA: 0x002B61BC File Offset: 0x002B43BC
		public Span<int> GetTechLvBytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x0600A2D1 RID: 41681 RVA: 0x002B61CC File Offset: 0x002B43CC
		public int[] GetTechLvArray()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x170022C9 RID: 8905
		// (get) Token: 0x0600A2D2 RID: 41682 RVA: 0x002B61E4 File Offset: 0x002B43E4
		public int InitLevel
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

		// Token: 0x170022CA RID: 8906
		// (get) Token: 0x0600A2D3 RID: 41683 RVA: 0x002B6224 File Offset: 0x002B4424
		public int UnlockCondition
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

		// Token: 0x170022CB RID: 8907
		// (get) Token: 0x0600A2D4 RID: 41684 RVA: 0x002B6264 File Offset: 0x002B4464
		public string UnlockConditionDesc
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

		// Token: 0x0600A2D5 RID: 41685 RVA: 0x002B629C File Offset: 0x002B449C
		public Span<byte> GetUnlockConditionDescBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600A2D6 RID: 41686 RVA: 0x002B62AC File Offset: 0x002B44AC
		public byte[] GetUnlockConditionDescArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x170022CC RID: 8908
		// (get) Token: 0x0600A2D7 RID: 41687 RVA: 0x002B62C4 File Offset: 0x002B44C4
		public string NotActivatedPreviewDesc
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

		// Token: 0x0600A2D8 RID: 41688 RVA: 0x002B62FC File Offset: 0x002B44FC
		public Span<byte> GetNotActivatedPreviewDescBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600A2D9 RID: 41689 RVA: 0x002B630C File Offset: 0x002B450C
		public byte[] GetNotActivatedPreviewDescArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A2DA RID: 41690 RVA: 0x002B6324 File Offset: 0x002B4524
		[NullableContext(1)]
		public int[] ExclusiveNodeSortOrder()
		{
			return this.GetExclusiveNodeSortOrderArray();
		}

		// Token: 0x0600A2DB RID: 41691 RVA: 0x002B632C File Offset: 0x002B452C
		[NullableContext(1)]
		public IEnumerable<int> ExclusiveNodeSortOrderIter()
		{
			MotorTech.<ExclusiveNodeSortOrderIter>d__74 <ExclusiveNodeSortOrderIter>d__ = new MotorTech.<ExclusiveNodeSortOrderIter>d__74(-2);
			<ExclusiveNodeSortOrderIter>d__.<>3__<>4__this = this;
			return <ExclusiveNodeSortOrderIter>d__;
		}

		// Token: 0x0600A2DC RID: 41692 RVA: 0x002B6341 File Offset: 0x002B4541
		[NullableContext(1)]
		public int[] PreNode()
		{
			return this.GetPreNodeArray();
		}

		// Token: 0x0600A2DD RID: 41693 RVA: 0x002B6349 File Offset: 0x002B4549
		[NullableContext(1)]
		public IEnumerable<int> PreNodeIter()
		{
			MotorTech.<PreNodeIter>d__76 <PreNodeIter>d__ = new MotorTech.<PreNodeIter>d__76(-2);
			<PreNodeIter>d__.<>3__<>4__this = this;
			return <PreNodeIter>d__;
		}

		// Token: 0x0600A2DE RID: 41694 RVA: 0x002B635E File Offset: 0x002B455E
		[NullableContext(1)]
		public int[] TechLv()
		{
			return this.GetTechLvArray();
		}

		// Token: 0x0600A2DF RID: 41695 RVA: 0x002B6366 File Offset: 0x002B4566
		[NullableContext(1)]
		public IEnumerable<int> TechLvIter()
		{
			MotorTech.<TechLvIter>d__78 <TechLvIter>d__ = new MotorTech.<TechLvIter>d__78(-2);
			<TechLvIter>d__.<>3__<>4__this = this;
			return <TechLvIter>d__;
		}

		// Token: 0x04005500 RID: 21760
		private Table __p;
	}
}
