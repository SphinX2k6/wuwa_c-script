using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BD3 RID: 3027
	public struct AkiMap : IFlatbufferObject
	{
		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06004CBA RID: 19642 RVA: 0x001F4B50 File Offset: 0x001F2D50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004CBB RID: 19643 RVA: 0x001F4B5D File Offset: 0x001F2D5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004CBC RID: 19644 RVA: 0x001F4B64 File Offset: 0x001F2D64
		public static AkiMap GetRootAsAkiMap(ByteBuffer _bb)
		{
			return AkiMap.GetRootAsAkiMap(_bb, default(AkiMap));
		}

		// Token: 0x06004CBD RID: 19645 RVA: 0x001F4B80 File Offset: 0x001F2D80
		public static AkiMap GetRootAsAkiMap(ByteBuffer _bb, AkiMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004CBE RID: 19646 RVA: 0x001F4B9D File Offset: 0x001F2D9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004CBF RID: 19647 RVA: 0x001F4BAC File Offset: 0x001F2DAC
		public AkiMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06004CC0 RID: 19648 RVA: 0x001F4BBC File Offset: 0x001F2DBC
		public int MapId
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

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06004CC1 RID: 19649 RVA: 0x001F4BF8 File Offset: 0x001F2DF8
		public string MapName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004CC2 RID: 19650 RVA: 0x001F4C2F File Offset: 0x001F2E2F
		public Span<byte> GetMapNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004CC3 RID: 19651 RVA: 0x001F4C3E File Offset: 0x001F2E3E
		public byte[] GetMapNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06004CC4 RID: 19652 RVA: 0x001F4C58 File Offset: 0x001F2E58
		public int FatherMap
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

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06004CC5 RID: 19653 RVA: 0x001F4C94 File Offset: 0x001F2E94
		public int GroupMark
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

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06004CC6 RID: 19654 RVA: 0x001F4CD4 File Offset: 0x001F2ED4
		public int Floor
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

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06004CC7 RID: 19655 RVA: 0x001F4D14 File Offset: 0x001F2F14
		public string SwitchCondition
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

		// Token: 0x06004CC8 RID: 19656 RVA: 0x001F4D4C File Offset: 0x001F2F4C
		public Span<byte> GetSwitchConditionBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004CC9 RID: 19657 RVA: 0x001F4D5C File Offset: 0x001F2F5C
		public byte[] GetSwitchConditionArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06004CCA RID: 19658 RVA: 0x001F4D74 File Offset: 0x001F2F74
		public string MapPic3d
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

		// Token: 0x06004CCB RID: 19659 RVA: 0x001F4DAC File Offset: 0x001F2FAC
		public Span<byte> GetMapPic3dBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004CCC RID: 19660 RVA: 0x001F4DBC File Offset: 0x001F2FBC
		public byte[] GetMapPic3dArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06004CCD RID: 19661 RVA: 0x001F4DD4 File Offset: 0x001F2FD4
		public string MapPic2d
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

		// Token: 0x06004CCE RID: 19662 RVA: 0x001F4E0C File Offset: 0x001F300C
		public Span<byte> GetMapPic2dBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004CCF RID: 19663 RVA: 0x001F4E1C File Offset: 0x001F301C
		public byte[] GetMapPic2dArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06004CD0 RID: 19664 RVA: 0x001F4E34 File Offset: 0x001F3034
		public int BigMapDefaultScale
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

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06004CD1 RID: 19665 RVA: 0x001F4E74 File Offset: 0x001F3074
		public int BigMapMinScale
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

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06004CD2 RID: 19666 RVA: 0x001F4EB4 File Offset: 0x001F30B4
		public int BigMapMaxScale
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

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06004CD3 RID: 19667 RVA: 0x001F4EF4 File Offset: 0x001F30F4
		public int LittleMapDefaultScale
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

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06004CD4 RID: 19668 RVA: 0x001F4F34 File Offset: 0x001F3134
		public string LimitContent
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

		// Token: 0x06004CD5 RID: 19669 RVA: 0x001F4F6C File Offset: 0x001F316C
		public Span<byte> GetLimitContentBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06004CD6 RID: 19670 RVA: 0x001F4F7C File Offset: 0x001F317C
		public byte[] GetLimitContentArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06004CD7 RID: 19671 RVA: 0x001F4F94 File Offset: 0x001F3194
		public bool IsGravityMap
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06004CD8 RID: 19672 RVA: 0x001F4FD4 File Offset: 0x001F31D4
		public bool IsNeedCustomizedThumbnail
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06004CD9 RID: 19673 RVA: 0x001F5014 File Offset: 0x001F3214
		public int SafeAreaOffset(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06004CDA RID: 19674 RVA: 0x001F5054 File Offset: 0x001F3254
		public int SafeAreaOffsetLength
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

		// Token: 0x06004CDB RID: 19675 RVA: 0x001F5080 File Offset: 0x001F3280
		public Span<int> GetSafeAreaOffsetBytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x06004CDC RID: 19676 RVA: 0x001F5090 File Offset: 0x001F3290
		public int[] GetSafeAreaOffsetArray()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06004CDD RID: 19677 RVA: 0x001F50A8 File Offset: 0x001F32A8
		public int ShowMode
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

		// Token: 0x06004CDE RID: 19678 RVA: 0x001F50E8 File Offset: 0x001F32E8
		public int FogFullUnlockDungeonList(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06004CDF RID: 19679 RVA: 0x001F5128 File Offset: 0x001F3328
		public int FogFullUnlockDungeonListLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004CE0 RID: 19680 RVA: 0x001F5154 File Offset: 0x001F3354
		public Span<int> GetFogFullUnlockDungeonListBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x06004CE1 RID: 19681 RVA: 0x001F5164 File Offset: 0x001F3364
		public int[] GetFogFullUnlockDungeonListArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06004CE2 RID: 19682 RVA: 0x001F517C File Offset: 0x001F337C
		public int ExtraMapScale
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004CE3 RID: 19683 RVA: 0x001F51B9 File Offset: 0x001F33B9
		[NullableContext(1)]
		public int[] FogFullUnlockDungeonList()
		{
			return this.GetFogFullUnlockDungeonListArray();
		}

		// Token: 0x06004CE4 RID: 19684 RVA: 0x001F51C1 File Offset: 0x001F33C1
		[NullableContext(1)]
		public IEnumerable<int> FogFullUnlockDungeonListIter()
		{
			AkiMap.<FogFullUnlockDungeonListIter>d__63 <FogFullUnlockDungeonListIter>d__ = new AkiMap.<FogFullUnlockDungeonListIter>d__63(-2);
			<FogFullUnlockDungeonListIter>d__.<>3__<>4__this = this;
			return <FogFullUnlockDungeonListIter>d__;
		}

		// Token: 0x06004CE5 RID: 19685 RVA: 0x001F51D6 File Offset: 0x001F33D6
		[NullableContext(1)]
		public int[] SafeAreaOffset()
		{
			return this.GetSafeAreaOffsetArray();
		}

		// Token: 0x06004CE6 RID: 19686 RVA: 0x001F51DE File Offset: 0x001F33DE
		[NullableContext(1)]
		public IEnumerable<int> SafeAreaOffsetIter()
		{
			AkiMap.<SafeAreaOffsetIter>d__65 <SafeAreaOffsetIter>d__ = new AkiMap.<SafeAreaOffsetIter>d__65(-2);
			<SafeAreaOffsetIter>d__.<>3__<>4__this = this;
			return <SafeAreaOffsetIter>d__;
		}

		// Token: 0x040050B4 RID: 20660
		private Table __p;
	}
}
