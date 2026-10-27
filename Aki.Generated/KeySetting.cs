using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D8A RID: 3466
	public struct KeySetting : IFlatbufferObject
	{
		// Token: 0x17001A5A RID: 6746
		// (get) Token: 0x0600874A RID: 34634 RVA: 0x0026804D File Offset: 0x0026624D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600874B RID: 34635 RVA: 0x0026805A File Offset: 0x0026625A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600874C RID: 34636 RVA: 0x00268064 File Offset: 0x00266264
		public static KeySetting GetRootAsKeySetting(ByteBuffer _bb)
		{
			return KeySetting.GetRootAsKeySetting(_bb, default(KeySetting));
		}

		// Token: 0x0600874D RID: 34637 RVA: 0x00268080 File Offset: 0x00266280
		public static KeySetting GetRootAsKeySetting(ByteBuffer _bb, KeySetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600874E RID: 34638 RVA: 0x0026809D File Offset: 0x0026629D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600874F RID: 34639 RVA: 0x002680AC File Offset: 0x002662AC
		public KeySetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A5B RID: 6747
		// (get) Token: 0x06008750 RID: 34640 RVA: 0x002680BC File Offset: 0x002662BC
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

		// Token: 0x17001A5C RID: 6748
		// (get) Token: 0x06008751 RID: 34641 RVA: 0x002680F8 File Offset: 0x002662F8
		public int TypeId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A5D RID: 6749
		// (get) Token: 0x06008752 RID: 34642 RVA: 0x00268134 File Offset: 0x00266334
		public int ExclusiveType
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

		// Token: 0x17001A5E RID: 6750
		// (get) Token: 0x06008753 RID: 34643 RVA: 0x00268170 File Offset: 0x00266370
		public int InputControllerType
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

		// Token: 0x17001A5F RID: 6751
		// (get) Token: 0x06008754 RID: 34644 RVA: 0x002681B0 File Offset: 0x002663B0
		public int SortId
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

		// Token: 0x17001A60 RID: 6752
		// (get) Token: 0x06008755 RID: 34645 RVA: 0x002681F0 File Offset: 0x002663F0
		public string Name
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

		// Token: 0x06008756 RID: 34646 RVA: 0x00268228 File Offset: 0x00266428
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008757 RID: 34647 RVA: 0x00268238 File Offset: 0x00266438
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A61 RID: 6753
		// (get) Token: 0x06008758 RID: 34648 RVA: 0x00268250 File Offset: 0x00266450
		public int OpenViewType
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

		// Token: 0x17001A62 RID: 6754
		// (get) Token: 0x06008759 RID: 34649 RVA: 0x00268290 File Offset: 0x00266490
		public string ButtonTextId
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

		// Token: 0x0600875A RID: 34650 RVA: 0x002682C8 File Offset: 0x002664C8
		public Span<byte> GetButtonTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600875B RID: 34651 RVA: 0x002682D8 File Offset: 0x002664D8
		public byte[] GetButtonTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A63 RID: 6755
		// (get) Token: 0x0600875C RID: 34652 RVA: 0x002682F0 File Offset: 0x002664F0
		public int ActionOrAxis
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

		// Token: 0x17001A64 RID: 6756
		// (get) Token: 0x0600875D RID: 34653 RVA: 0x00268330 File Offset: 0x00266530
		public string ActionOrAxisName
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

		// Token: 0x0600875E RID: 34654 RVA: 0x00268368 File Offset: 0x00266568
		public Span<byte> GetActionOrAxisNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600875F RID: 34655 RVA: 0x00268378 File Offset: 0x00266578
		public byte[] GetActionOrAxisNameArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A65 RID: 6757
		// (get) Token: 0x06008760 RID: 34656 RVA: 0x00268390 File Offset: 0x00266590
		public bool CanCombination
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001A66 RID: 6758
		// (get) Token: 0x06008761 RID: 34657 RVA: 0x002683D0 File Offset: 0x002665D0
		public int PcKeyIndex
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

		// Token: 0x17001A67 RID: 6759
		// (get) Token: 0x06008762 RID: 34658 RVA: 0x00268410 File Offset: 0x00266610
		public int XBoxKeyIndex
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

		// Token: 0x17001A68 RID: 6760
		// (get) Token: 0x06008763 RID: 34659 RVA: 0x00268450 File Offset: 0x00266650
		public int ConnectedKeySettingId
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

		// Token: 0x06008764 RID: 34660 RVA: 0x00268490 File Offset: 0x00266690
		public int ConnectedKeySettingIdList(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A69 RID: 6761
		// (get) Token: 0x06008765 RID: 34661 RVA: 0x002684D0 File Offset: 0x002666D0
		public int ConnectedKeySettingIdListLength
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

		// Token: 0x06008766 RID: 34662 RVA: 0x002684FC File Offset: 0x002666FC
		public Span<int> GetConnectedKeySettingIdListBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x06008767 RID: 34663 RVA: 0x0026850C File Offset: 0x0026670C
		public int[] GetConnectedKeySettingIdListArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x17001A6A RID: 6762
		// (get) Token: 0x06008768 RID: 34664 RVA: 0x00268524 File Offset: 0x00266724
		public float PcAxisValue
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A6B RID: 6763
		// (get) Token: 0x06008769 RID: 34665 RVA: 0x00268568 File Offset: 0x00266768
		public float XBoxAxisValue
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A6C RID: 6764
		// (get) Token: 0x0600876A RID: 34666 RVA: 0x002685AC File Offset: 0x002667AC
		public bool IsLock
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600876B RID: 34667 RVA: 0x002685EC File Offset: 0x002667EC
		public string BothActionName(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A6D RID: 6765
		// (get) Token: 0x0600876C RID: 34668 RVA: 0x00268628 File Offset: 0x00266828
		public int BothActionNameLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001A6E RID: 6766
		// (get) Token: 0x0600876D RID: 34669 RVA: 0x00268654 File Offset: 0x00266854
		public bool BothActionSyncAllExclusive
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001A6F RID: 6767
		// (get) Token: 0x0600876E RID: 34670 RVA: 0x00268694 File Offset: 0x00266894
		public bool IsCheckSameKey
		{
			get
			{
				int num = this.__p.__offset(44);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001A70 RID: 6768
		// (get) Token: 0x0600876F RID: 34671 RVA: 0x002686D4 File Offset: 0x002668D4
		public bool CanDisable
		{
			get
			{
				int num = this.__p.__offset(46);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06008770 RID: 34672 RVA: 0x00268714 File Offset: 0x00266914
		public string AllowKeys(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A71 RID: 6769
		// (get) Token: 0x06008771 RID: 34673 RVA: 0x00268750 File Offset: 0x00266950
		public int AllowKeysLength
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008772 RID: 34674 RVA: 0x0026877C File Offset: 0x0026697C
		public string AllowMainKeys(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A72 RID: 6770
		// (get) Token: 0x06008773 RID: 34675 RVA: 0x002687B8 File Offset: 0x002669B8
		public int AllowMainKeysLength
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008774 RID: 34676 RVA: 0x002687E4 File Offset: 0x002669E4
		public string AllowSecondKeys(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A73 RID: 6771
		// (get) Token: 0x06008775 RID: 34677 RVA: 0x00268820 File Offset: 0x00266A20
		public int AllowSecondKeysLength
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001A74 RID: 6772
		// (get) Token: 0x06008776 RID: 34678 RVA: 0x0026884C File Offset: 0x00266A4C
		public string AllowKeysPool
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008777 RID: 34679 RVA: 0x00268884 File Offset: 0x00266A84
		public Span<byte> GetAllowKeysPoolBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x06008778 RID: 34680 RVA: 0x00268894 File Offset: 0x00266A94
		public byte[] GetAllowKeysPoolArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A75 RID: 6773
		// (get) Token: 0x06008779 RID: 34681 RVA: 0x002688AC File Offset: 0x00266AAC
		public string AllowMainKeysPool
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600877A RID: 34682 RVA: 0x002688E4 File Offset: 0x00266AE4
		public Span<byte> GetAllowMainKeysPoolBytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x0600877B RID: 34683 RVA: 0x002688F4 File Offset: 0x00266AF4
		public byte[] GetAllowMainKeysPoolArray()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A76 RID: 6774
		// (get) Token: 0x0600877C RID: 34684 RVA: 0x0026890C File Offset: 0x00266B0C
		public string AllowSecondKeysPool
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600877D RID: 34685 RVA: 0x00268944 File Offset: 0x00266B44
		public Span<byte> GetAllowSecondKeysPoolBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x0600877E RID: 34686 RVA: 0x00268954 File Offset: 0x00266B54
		public byte[] GetAllowSecondKeysPoolArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A77 RID: 6775
		// (get) Token: 0x0600877F RID: 34687 RVA: 0x0026896C File Offset: 0x00266B6C
		public string DetailTextId
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008780 RID: 34688 RVA: 0x002689A4 File Offset: 0x00266BA4
		public Span<byte> GetDetailTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x06008781 RID: 34689 RVA: 0x002689B4 File Offset: 0x00266BB4
		public byte[] GetDetailTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A78 RID: 6776
		// (get) Token: 0x06008782 RID: 34690 RVA: 0x002689CC File Offset: 0x00266BCC
		public bool OnlyWorkNotShow
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06008783 RID: 34691 RVA: 0x00268A0C File Offset: 0x00266C0C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AllowKeysIter()或GetAllowKeysBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] AllowKeys()
		{
			return this.AllowKeysIter().ToArray<string>();
		}

		// Token: 0x06008784 RID: 34692 RVA: 0x00268A19 File Offset: 0x00266C19
		[NullableContext(1)]
		public readonly IEnumerable<string> AllowKeysIter()
		{
			KeySetting.<AllowKeysIter>d__90 <AllowKeysIter>d__ = new KeySetting.<AllowKeysIter>d__90(-2);
			<AllowKeysIter>d__.<>3__<>4__this = this;
			return <AllowKeysIter>d__;
		}

		// Token: 0x06008785 RID: 34693 RVA: 0x00268A2E File Offset: 0x00266C2E
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AllowMainKeysIter()或GetAllowMainKeysBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] AllowMainKeys()
		{
			return this.AllowMainKeysIter().ToArray<string>();
		}

		// Token: 0x06008786 RID: 34694 RVA: 0x00268A3B File Offset: 0x00266C3B
		[NullableContext(1)]
		public readonly IEnumerable<string> AllowMainKeysIter()
		{
			KeySetting.<AllowMainKeysIter>d__92 <AllowMainKeysIter>d__ = new KeySetting.<AllowMainKeysIter>d__92(-2);
			<AllowMainKeysIter>d__.<>3__<>4__this = this;
			return <AllowMainKeysIter>d__;
		}

		// Token: 0x06008787 RID: 34695 RVA: 0x00268A50 File Offset: 0x00266C50
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AllowSecondKeysIter()或GetAllowSecondKeysBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] AllowSecondKeys()
		{
			return this.AllowSecondKeysIter().ToArray<string>();
		}

		// Token: 0x06008788 RID: 34696 RVA: 0x00268A5D File Offset: 0x00266C5D
		[NullableContext(1)]
		public readonly IEnumerable<string> AllowSecondKeysIter()
		{
			KeySetting.<AllowSecondKeysIter>d__94 <AllowSecondKeysIter>d__ = new KeySetting.<AllowSecondKeysIter>d__94(-2);
			<AllowSecondKeysIter>d__.<>3__<>4__this = this;
			return <AllowSecondKeysIter>d__;
		}

		// Token: 0x06008789 RID: 34697 RVA: 0x00268A72 File Offset: 0x00266C72
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BothActionNameIter()或GetBothActionNameBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BothActionName()
		{
			return this.BothActionNameIter().ToArray<string>();
		}

		// Token: 0x0600878A RID: 34698 RVA: 0x00268A7F File Offset: 0x00266C7F
		[NullableContext(1)]
		public readonly IEnumerable<string> BothActionNameIter()
		{
			KeySetting.<BothActionNameIter>d__96 <BothActionNameIter>d__ = new KeySetting.<BothActionNameIter>d__96(-2);
			<BothActionNameIter>d__.<>3__<>4__this = this;
			return <BothActionNameIter>d__;
		}

		// Token: 0x0600878B RID: 34699 RVA: 0x00268A94 File Offset: 0x00266C94
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ConnectedKeySettingIdListIter()或GetConnectedKeySettingIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ConnectedKeySettingIdList()
		{
			KeySetting keySetting = this;
			return keySetting.GetConnectedKeySettingIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600878C RID: 34700 RVA: 0x00268AB8 File Offset: 0x00266CB8
		[NullableContext(1)]
		public readonly IEnumerable<int> ConnectedKeySettingIdListIter()
		{
			KeySetting.<ConnectedKeySettingIdListIter>d__98 <ConnectedKeySettingIdListIter>d__ = new KeySetting.<ConnectedKeySettingIdListIter>d__98(-2);
			<ConnectedKeySettingIdListIter>d__.<>3__<>4__this = this;
			return <ConnectedKeySettingIdListIter>d__;
		}

		// Token: 0x04004E16 RID: 19990
		private Table __p;
	}
}
