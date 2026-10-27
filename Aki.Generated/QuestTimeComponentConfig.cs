using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F78 RID: 3960
	public struct QuestTimeComponentConfig : IFlatbufferObject
	{
		// Token: 0x17002BED RID: 11245
		// (get) Token: 0x0600B63C RID: 46652 RVA: 0x002D1134 File Offset: 0x002CF334
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B63D RID: 46653 RVA: 0x002D1141 File Offset: 0x002CF341
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B63E RID: 46654 RVA: 0x002D1148 File Offset: 0x002CF348
		public static QuestTimeComponentConfig GetRootAsQuestTimeComponentConfig(ByteBuffer _bb)
		{
			return QuestTimeComponentConfig.GetRootAsQuestTimeComponentConfig(_bb, default(QuestTimeComponentConfig));
		}

		// Token: 0x0600B63F RID: 46655 RVA: 0x002D1164 File Offset: 0x002CF364
		public static QuestTimeComponentConfig GetRootAsQuestTimeComponentConfig(ByteBuffer _bb, QuestTimeComponentConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B640 RID: 46656 RVA: 0x002D1181 File Offset: 0x002CF381
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B641 RID: 46657 RVA: 0x002D1190 File Offset: 0x002CF390
		public QuestTimeComponentConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002BEE RID: 11246
		// (get) Token: 0x0600B642 RID: 46658 RVA: 0x002D11A0 File Offset: 0x002CF3A0
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

		// Token: 0x17002BEF RID: 11247
		// (get) Token: 0x0600B643 RID: 46659 RVA: 0x002D11DC File Offset: 0x002CF3DC
		public IntVector2D? Location
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IntVector2D?(default(IntVector2D).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17002BF0 RID: 11248
		// (get) Token: 0x0600B644 RID: 46660 RVA: 0x002D123C File Offset: 0x002CF43C
		public int Type
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

		// Token: 0x17002BF1 RID: 11249
		// (get) Token: 0x0600B645 RID: 46661 RVA: 0x002D1278 File Offset: 0x002CF478
		public int StatusType
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

		// Token: 0x0600B646 RID: 46662 RVA: 0x002D12B8 File Offset: 0x002CF4B8
		public string ComponentIcon(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002BF2 RID: 11250
		// (get) Token: 0x0600B647 RID: 46663 RVA: 0x002D12F4 File Offset: 0x002CF4F4
		public int ComponentIconLength
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

		// Token: 0x0600B648 RID: 46664 RVA: 0x002D1320 File Offset: 0x002CF520
		public string MultiPersonAvatar(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002BF3 RID: 11251
		// (get) Token: 0x0600B649 RID: 46665 RVA: 0x002D135C File Offset: 0x002CF55C
		public int MultiPersonAvatarLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17002BF4 RID: 11252
		// (get) Token: 0x0600B64A RID: 46666 RVA: 0x002D1388 File Offset: 0x002CF588
		public string ComponentQualityFrame
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

		// Token: 0x0600B64B RID: 46667 RVA: 0x002D13C0 File Offset: 0x002CF5C0
		public Span<byte> GetComponentQualityFrameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B64C RID: 46668 RVA: 0x002D13D0 File Offset: 0x002CF5D0
		public byte[] GetComponentQualityFrameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BF5 RID: 11253
		// (get) Token: 0x0600B64D RID: 46669 RVA: 0x002D13E8 File Offset: 0x002CF5E8
		public string ComponentQualityFrameHold
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

		// Token: 0x0600B64E RID: 46670 RVA: 0x002D1420 File Offset: 0x002CF620
		public Span<byte> GetComponentQualityFrameHoldBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B64F RID: 46671 RVA: 0x002D1430 File Offset: 0x002CF630
		public byte[] GetComponentQualityFrameHoldArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BF6 RID: 11254
		// (get) Token: 0x0600B650 RID: 46672 RVA: 0x002D1448 File Offset: 0x002CF648
		public string HeadIconBgInTip
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

		// Token: 0x0600B651 RID: 46673 RVA: 0x002D1480 File Offset: 0x002CF680
		public Span<byte> GetHeadIconBgInTipBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B652 RID: 46674 RVA: 0x002D1490 File Offset: 0x002CF690
		public byte[] GetHeadIconBgInTipArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BF7 RID: 11255
		// (get) Token: 0x0600B653 RID: 46675 RVA: 0x002D14A8 File Offset: 0x002CF6A8
		public string TipsQualityBg
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

		// Token: 0x0600B654 RID: 46676 RVA: 0x002D14E0 File Offset: 0x002CF6E0
		public Span<byte> GetTipsQualityBgBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B655 RID: 46677 RVA: 0x002D14F0 File Offset: 0x002CF6F0
		public byte[] GetTipsQualityBgArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BF8 RID: 11256
		// (get) Token: 0x0600B656 RID: 46678 RVA: 0x002D1508 File Offset: 0x002CF708
		public string TipsTitle
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

		// Token: 0x0600B657 RID: 46679 RVA: 0x002D1540 File Offset: 0x002CF740
		public Span<byte> GetTipsTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600B658 RID: 46680 RVA: 0x002D1550 File Offset: 0x002CF750
		public byte[] GetTipsTitleArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BF9 RID: 11257
		// (get) Token: 0x0600B659 RID: 46681 RVA: 0x002D1568 File Offset: 0x002CF768
		public string TipsDesc
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

		// Token: 0x0600B65A RID: 46682 RVA: 0x002D15A0 File Offset: 0x002CF7A0
		public Span<byte> GetTipsDescBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600B65B RID: 46683 RVA: 0x002D15B0 File Offset: 0x002CF7B0
		public byte[] GetTipsDescArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BFA RID: 11258
		// (get) Token: 0x0600B65C RID: 46684 RVA: 0x002D15C8 File Offset: 0x002CF7C8
		public string TipsArea
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

		// Token: 0x0600B65D RID: 46685 RVA: 0x002D1600 File Offset: 0x002CF800
		public Span<byte> GetTipsAreaBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600B65E RID: 46686 RVA: 0x002D1610 File Offset: 0x002CF810
		public byte[] GetTipsAreaArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BFB RID: 11259
		// (get) Token: 0x0600B65F RID: 46687 RVA: 0x002D1628 File Offset: 0x002CF828
		public string TipsStatusDesc
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B660 RID: 46688 RVA: 0x002D1660 File Offset: 0x002CF860
		public Span<byte> GetTipsStatusDescBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600B661 RID: 46689 RVA: 0x002D1670 File Offset: 0x002CF870
		public byte[] GetTipsStatusDescArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B662 RID: 46690 RVA: 0x002D1688 File Offset: 0x002CF888
		public IntVector2D? AnimMovePoint(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new IntVector2D?(default(IntVector2D).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002BFC RID: 11260
		// (get) Token: 0x0600B663 RID: 46691 RVA: 0x002D16EC File Offset: 0x002CF8EC
		public int AnimMovePointLength
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

		// Token: 0x0600B664 RID: 46692 RVA: 0x002D1718 File Offset: 0x002CF918
		public int BranchFinishQuestNode(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002BFD RID: 11261
		// (get) Token: 0x0600B665 RID: 46693 RVA: 0x002D1758 File Offset: 0x002CF958
		public int BranchFinishQuestNodeLength
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

		// Token: 0x0600B666 RID: 46694 RVA: 0x002D1784 File Offset: 0x002CF984
		public Span<int> GetBranchFinishQuestNodeBytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x0600B667 RID: 46695 RVA: 0x002D1794 File Offset: 0x002CF994
		public int[] GetBranchFinishQuestNodeArray()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x17002BFE RID: 11262
		// (get) Token: 0x0600B668 RID: 46696 RVA: 0x002D17AC File Offset: 0x002CF9AC
		public string OnGoingDesc
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

		// Token: 0x0600B669 RID: 46697 RVA: 0x002D17E4 File Offset: 0x002CF9E4
		public Span<byte> GetOnGoingDescBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600B66A RID: 46698 RVA: 0x002D17F4 File Offset: 0x002CF9F4
		public byte[] GetOnGoingDescArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BFF RID: 11263
		// (get) Token: 0x0600B66B RID: 46699 RVA: 0x002D180C File Offset: 0x002CFA0C
		public int MoveSpeed
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 2000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002C00 RID: 11264
		// (get) Token: 0x0600B66C RID: 46700 RVA: 0x002D1850 File Offset: 0x002CFA50
		public int PathSpeed
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 2000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002C01 RID: 11265
		// (get) Token: 0x0600B66D RID: 46701 RVA: 0x002D1894 File Offset: 0x002CFA94
		public string HeadLoopEffect
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

		// Token: 0x0600B66E RID: 46702 RVA: 0x002D18CC File Offset: 0x002CFACC
		public Span<byte> GetHeadLoopEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600B66F RID: 46703 RVA: 0x002D18DC File Offset: 0x002CFADC
		public byte[] GetHeadLoopEffectArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B670 RID: 46704 RVA: 0x002D18F4 File Offset: 0x002CFAF4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AnimMovePointIter()或GetAnimMovePointBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntVector2D[] AnimMovePoint()
		{
			return this.AnimMovePointIter().ToArray<IntVector2D>();
		}

		// Token: 0x0600B671 RID: 46705 RVA: 0x002D1901 File Offset: 0x002CFB01
		[NullableContext(1)]
		public readonly IEnumerable<IntVector2D> AnimMovePointIter()
		{
			QuestTimeComponentConfig.<AnimMovePointIter>d__75 <AnimMovePointIter>d__ = new QuestTimeComponentConfig.<AnimMovePointIter>d__75(-2);
			<AnimMovePointIter>d__.<>3__<>4__this = this;
			return <AnimMovePointIter>d__;
		}

		// Token: 0x0600B672 RID: 46706 RVA: 0x002D1918 File Offset: 0x002CFB18
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BranchFinishQuestNodeIter()或GetBranchFinishQuestNodeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BranchFinishQuestNode()
		{
			QuestTimeComponentConfig questTimeComponentConfig = this;
			return questTimeComponentConfig.GetBranchFinishQuestNodeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B673 RID: 46707 RVA: 0x002D193C File Offset: 0x002CFB3C
		[NullableContext(1)]
		public readonly IEnumerable<int> BranchFinishQuestNodeIter()
		{
			QuestTimeComponentConfig.<BranchFinishQuestNodeIter>d__77 <BranchFinishQuestNodeIter>d__ = new QuestTimeComponentConfig.<BranchFinishQuestNodeIter>d__77(-2);
			<BranchFinishQuestNodeIter>d__.<>3__<>4__this = this;
			return <BranchFinishQuestNodeIter>d__;
		}

		// Token: 0x0600B674 RID: 46708 RVA: 0x002D1951 File Offset: 0x002CFB51
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ComponentIconIter()或GetComponentIconBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ComponentIcon()
		{
			return this.ComponentIconIter().ToArray<string>();
		}

		// Token: 0x0600B675 RID: 46709 RVA: 0x002D195E File Offset: 0x002CFB5E
		[NullableContext(1)]
		public readonly IEnumerable<string> ComponentIconIter()
		{
			QuestTimeComponentConfig.<ComponentIconIter>d__79 <ComponentIconIter>d__ = new QuestTimeComponentConfig.<ComponentIconIter>d__79(-2);
			<ComponentIconIter>d__.<>3__<>4__this = this;
			return <ComponentIconIter>d__;
		}

		// Token: 0x0600B676 RID: 46710 RVA: 0x002D1973 File Offset: 0x002CFB73
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MultiPersonAvatarIter()或GetMultiPersonAvatarBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] MultiPersonAvatar()
		{
			return this.MultiPersonAvatarIter().ToArray<string>();
		}

		// Token: 0x0600B677 RID: 46711 RVA: 0x002D1980 File Offset: 0x002CFB80
		[NullableContext(1)]
		public readonly IEnumerable<string> MultiPersonAvatarIter()
		{
			QuestTimeComponentConfig.<MultiPersonAvatarIter>d__81 <MultiPersonAvatarIter>d__ = new QuestTimeComponentConfig.<MultiPersonAvatarIter>d__81(-2);
			<MultiPersonAvatarIter>d__.<>3__<>4__this = this;
			return <MultiPersonAvatarIter>d__;
		}

		// Token: 0x04005046 RID: 20550
		private Table __p;
	}
}
