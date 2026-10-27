using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FC5 RID: 16325
	public struct IQuest : IFlatbufferObject
	{
		// Token: 0x170071FD RID: 29181
		// (get) Token: 0x06017589 RID: 95625 RVA: 0x0035D758 File Offset: 0x0035B958
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601758A RID: 95626 RVA: 0x0035D765 File Offset: 0x0035B965
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601758B RID: 95627 RVA: 0x0035D76C File Offset: 0x0035B96C
		public static IQuest GetRootAsIQuest(ByteBuffer _bb)
		{
			return IQuest.GetRootAsIQuest(_bb, default(IQuest));
		}

		// Token: 0x0601758C RID: 95628 RVA: 0x0035D788 File Offset: 0x0035B988
		public static IQuest GetRootAsIQuest(ByteBuffer _bb, IQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601758D RID: 95629 RVA: 0x0035D7A5 File Offset: 0x0035B9A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601758E RID: 95630 RVA: 0x0035D7B4 File Offset: 0x0035B9B4
		public IQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170071FE RID: 29182
		// (get) Token: 0x0601758F RID: 95631 RVA: 0x0035D7C4 File Offset: 0x0035B9C4
		public string ObjType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017590 RID: 95632 RVA: 0x0035D7FB File Offset: 0x0035B9FB
		public Span<byte> GetObjTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06017591 RID: 95633 RVA: 0x0035D80A File Offset: 0x0035BA0A
		public byte[] GetObjTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06017592 RID: 95634 RVA: 0x0035D818 File Offset: 0x0035BA18
		public string Children(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170071FF RID: 29183
		// (get) Token: 0x06017593 RID: 95635 RVA: 0x0035D854 File Offset: 0x0035BA54
		public int ChildrenLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06017594 RID: 95636 RVA: 0x0035D880 File Offset: 0x0035BA80
		public string Reference(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007200 RID: 29184
		// (get) Token: 0x06017595 RID: 95637 RVA: 0x0035D8BC File Offset: 0x0035BABC
		public int ReferenceLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06017596 RID: 95638 RVA: 0x0035D8E8 File Offset: 0x0035BAE8
		public string WeakReference(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007201 RID: 29185
		// (get) Token: 0x06017597 RID: 95639 RVA: 0x0035D924 File Offset: 0x0035BB24
		public int WeakReferenceLength
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

		// Token: 0x17007202 RID: 29186
		// (get) Token: 0x06017598 RID: 95640 RVA: 0x0035D950 File Offset: 0x0035BB50
		public EQuest Type
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return EQuest.None;
				}
				return (EQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007203 RID: 29187
		// (get) Token: 0x06017599 RID: 95641 RVA: 0x0035D990 File Offset: 0x0035BB90
		public EQuestSubType SubType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return EQuestSubType.None;
				}
				return (EQuestSubType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007204 RID: 29188
		// (get) Token: 0x0601759A RID: 95642 RVA: 0x0035D9D0 File Offset: 0x0035BBD0
		public int Id
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

		// Token: 0x17007205 RID: 29189
		// (get) Token: 0x0601759B RID: 95643 RVA: 0x0035DA10 File Offset: 0x0035BC10
		public int DungeonId
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

		// Token: 0x0601759C RID: 95644 RVA: 0x0035DA50 File Offset: 0x0035BC50
		public ESystemModuleName BindSystems(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return ESystemModuleName.Common;
			}
			return (ESystemModuleName)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007206 RID: 29190
		// (get) Token: 0x0601759D RID: 95645 RVA: 0x0035DA90 File Offset: 0x0035BC90
		public int BindSystemsLength
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

		// Token: 0x0601759E RID: 95646 RVA: 0x0035DABC File Offset: 0x0035BCBC
		public Span<ESystemModuleName> GetBindSystemsBytes()
		{
			return this.__p.__vector_as_span<ESystemModuleName>(20, 1);
		}

		// Token: 0x0601759F RID: 95647 RVA: 0x0035DACC File Offset: 0x0035BCCC
		public ESystemModuleName[] GetBindSystemsArray()
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			ESystemModuleName[] array = new ESystemModuleName[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (ESystemModuleName)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x17007207 RID: 29191
		// (get) Token: 0x060175A0 RID: 95648 RVA: 0x0035DB38 File Offset: 0x0035BD38
		public string TidName
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

		// Token: 0x060175A1 RID: 95649 RVA: 0x0035DB70 File Offset: 0x0035BD70
		public Span<byte> GetTidNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060175A2 RID: 95650 RVA: 0x0035DB80 File Offset: 0x0035BD80
		public byte[] GetTidNameArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x17007208 RID: 29192
		// (get) Token: 0x060175A3 RID: 95651 RVA: 0x0035DB90 File Offset: 0x0035BD90
		public string Key
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

		// Token: 0x060175A4 RID: 95652 RVA: 0x0035DBC8 File Offset: 0x0035BDC8
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060175A5 RID: 95653 RVA: 0x0035DBD8 File Offset: 0x0035BDD8
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(24);
		}

		// Token: 0x17007209 RID: 29193
		// (get) Token: 0x060175A6 RID: 95654 RVA: 0x0035DBE8 File Offset: 0x0035BDE8
		public string TidDesc
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

		// Token: 0x060175A7 RID: 95655 RVA: 0x0035DC20 File Offset: 0x0035BE20
		public Span<byte> GetTidDescBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060175A8 RID: 95656 RVA: 0x0035DC30 File Offset: 0x0035BE30
		public byte[] GetTidDescArray()
		{
			return this.__p.__vector_as_array<byte>(26);
		}

		// Token: 0x1700720A RID: 29194
		// (get) Token: 0x060175A9 RID: 95657 RVA: 0x0035DC40 File Offset: 0x0035BE40
		public EQuestOnlineType OnlineType
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return EQuestOnlineType.SingleHangUpOnline;
				}
				return (EQuestOnlineType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700720B RID: 29195
		// (get) Token: 0x060175AA RID: 95658 RVA: 0x0035DC80 File Offset: 0x0035BE80
		public bool IsAutoTrack
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700720C RID: 29196
		// (get) Token: 0x060175AB RID: 95659 RVA: 0x0035DCC0 File Offset: 0x0035BEC0
		public bool IsAutoCoverCurTrack
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700720D RID: 29197
		// (get) Token: 0x060175AC RID: 95660 RVA: 0x0035DD00 File Offset: 0x0035BF00
		public int RewardId
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

		// Token: 0x1700720E RID: 29198
		// (get) Token: 0x060175AD RID: 95661 RVA: 0x0035DD40 File Offset: 0x0035BF40
		public EQuestRegion RegionId
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return EQuestRegion.None;
				}
				return (EQuestRegion)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700720F RID: 29199
		// (get) Token: 0x060175AE RID: 95662 RVA: 0x0035DD80 File Offset: 0x0035BF80
		public int ChapterId
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

		// Token: 0x17007210 RID: 29200
		// (get) Token: 0x060175AF RID: 95663 RVA: 0x0035DDC0 File Offset: 0x0035BFC0
		public int TagId
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

		// Token: 0x17007211 RID: 29201
		// (get) Token: 0x060175B0 RID: 95664 RVA: 0x0035DE00 File Offset: 0x0035C000
		public int FunctionId
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

		// Token: 0x17007212 RID: 29202
		// (get) Token: 0x060175B1 RID: 95665 RVA: 0x0035DE40 File Offset: 0x0035C040
		public string RoleId
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

		// Token: 0x060175B2 RID: 95666 RVA: 0x0035DE78 File Offset: 0x0035C078
		public Span<byte> GetRoleIdBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x060175B3 RID: 95667 RVA: 0x0035DE88 File Offset: 0x0035C088
		public byte[] GetRoleIdArray()
		{
			return this.__p.__vector_as_array<byte>(44);
		}

		// Token: 0x17007213 RID: 29203
		// (get) Token: 0x060175B4 RID: 95668 RVA: 0x0035DE98 File Offset: 0x0035C098
		public EDistrubuteType DistributeType
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return EDistrubuteType.Interact;
				}
				return (EDistrubuteType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007214 RID: 29204
		// (get) Token: 0x060175B5 RID: 95669 RVA: 0x0035DED8 File Offset: 0x0035C0D8
		public IDistributeParams? DistributeParams
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return new IDistributeParams?(default(IDistributeParams).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007215 RID: 29205
		// (get) Token: 0x060175B6 RID: 95670 RVA: 0x0035DF38 File Offset: 0x0035C138
		public bool IsHideAcceptMarkOnNpc
		{
			get
			{
				int num = this.__p.__offset(50);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007216 RID: 29206
		// (get) Token: 0x060175B7 RID: 95671 RVA: 0x0035DF78 File Offset: 0x0035C178
		public bool IsHideInTaskList
		{
			get
			{
				int num = this.__p.__offset(52);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007217 RID: 29207
		// (get) Token: 0x060175B8 RID: 95672 RVA: 0x0035DFB8 File Offset: 0x0035C1B8
		public IAccessQuestCondition? ProvideType
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return new IAccessQuestCondition?(default(IAccessQuestCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007218 RID: 29208
		// (get) Token: 0x060175B9 RID: 95673 RVA: 0x0035E018 File Offset: 0x0035C218
		public IAccessQuestCondition? AutoTrackConditions
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return null;
				}
				return new IAccessQuestCondition?(default(IAccessQuestCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060175BA RID: 95674 RVA: 0x0035E078 File Offset: 0x0035C278
		public int RecommendPreQuest(int j)
		{
			int num = this.__p.__offset(58);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007219 RID: 29209
		// (get) Token: 0x060175BB RID: 95675 RVA: 0x0035E0B8 File Offset: 0x0035C2B8
		public int RecommendPreQuestLength
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060175BC RID: 95676 RVA: 0x0035E0E4 File Offset: 0x0035C2E4
		public Span<int> GetRecommendPreQuestBytes()
		{
			return this.__p.__vector_as_span<int>(58, 4);
		}

		// Token: 0x060175BD RID: 95677 RVA: 0x0035E0F4 File Offset: 0x0035C2F4
		public int[] GetRecommendPreQuestArray()
		{
			return this.__p.__vector_as_array<int>(58);
		}

		// Token: 0x1700721A RID: 29210
		// (get) Token: 0x060175BE RID: 95678 RVA: 0x0035E104 File Offset: 0x0035C304
		public int RecommendationPriority
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700721B RID: 29211
		// (get) Token: 0x060175BF RID: 95679 RVA: 0x0035E144 File Offset: 0x0035C344
		public IQuestUnlockDelayTime? UnlockDelayTime
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return null;
				}
				return new IQuestUnlockDelayTime?(default(IQuestUnlockDelayTime).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700721C RID: 29212
		// (get) Token: 0x060175C0 RID: 95680 RVA: 0x0035E1A4 File Offset: 0x0035C3A4
		public IPreShowInfo? PreShowInfo
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return null;
				}
				return new IPreShowInfo?(default(IPreShowInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700721D RID: 29213
		// (get) Token: 0x060175C1 RID: 95681 RVA: 0x0035E204 File Offset: 0x0035C404
		public IAddInteractOption? AddInteractOption
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return null;
				}
				return new IAddInteractOption?(default(IAddInteractOption).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060175C2 RID: 95682 RVA: 0x0035E264 File Offset: 0x0035C464
		public IActionInfo? ActiveActions(int j)
		{
			int num = this.__p.__offset(68);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700721E RID: 29214
		// (get) Token: 0x060175C3 RID: 95683 RVA: 0x0035E2C8 File Offset: 0x0035C4C8
		public int ActiveActionsLength
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060175C4 RID: 95684 RVA: 0x0035E2F4 File Offset: 0x0035C4F4
		public IActionInfo? AcceptActions(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700721F RID: 29215
		// (get) Token: 0x060175C5 RID: 95685 RVA: 0x0035E358 File Offset: 0x0035C558
		public int AcceptActionsLength
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060175C6 RID: 95686 RVA: 0x0035E384 File Offset: 0x0035C584
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(72);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007220 RID: 29216
		// (get) Token: 0x060175C7 RID: 95687 RVA: 0x0035E3E8 File Offset: 0x0035C5E8
		public int FinishActionsLength
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060175C8 RID: 95688 RVA: 0x0035E414 File Offset: 0x0035C614
		public IActionInfo? TerminateActions(int j)
		{
			int num = this.__p.__offset(74);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007221 RID: 29217
		// (get) Token: 0x060175C9 RID: 95689 RVA: 0x0035E478 File Offset: 0x0035C678
		public int TerminateActionsLength
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060175CA RID: 95690 RVA: 0x0035E4A4 File Offset: 0x0035C6A4
		public IActionInfo? TerminateActions2(int j)
		{
			int num = this.__p.__offset(76);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007222 RID: 29218
		// (get) Token: 0x060175CB RID: 95691 RVA: 0x0035E508 File Offset: 0x0035C708
		public int TerminateActions2Length
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060175CC RID: 95692 RVA: 0x0035E534 File Offset: 0x0035C734
		public int ReferenceAllEntity(int j)
		{
			int num = this.__p.__offset(78);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007223 RID: 29219
		// (get) Token: 0x060175CD RID: 95693 RVA: 0x0035E574 File Offset: 0x0035C774
		public int ReferenceAllEntityLength
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060175CE RID: 95694 RVA: 0x0035E5A0 File Offset: 0x0035C7A0
		public Span<int> GetReferenceAllEntityBytes()
		{
			return this.__p.__vector_as_span<int>(78, 4);
		}

		// Token: 0x060175CF RID: 95695 RVA: 0x0035E5B0 File Offset: 0x0035C7B0
		public int[] GetReferenceAllEntityArray()
		{
			return this.__p.__vector_as_array<int>(78);
		}

		// Token: 0x17007224 RID: 29220
		// (get) Token: 0x060175D0 RID: 95696 RVA: 0x0035E5C0 File Offset: 0x0035C7C0
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007225 RID: 29221
		// (get) Token: 0x060175D1 RID: 95697 RVA: 0x0035E600 File Offset: 0x0035C800
		public IFocusModeSetting? FocusModeSetting
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return null;
				}
				return new IFocusModeSetting?(default(IFocusModeSetting).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007226 RID: 29222
		// (get) Token: 0x060175D2 RID: 95698 RVA: 0x0035E660 File Offset: 0x0035C860
		public bool DelayDestroy
		{
			get
			{
				int num = this.__p.__offset(84);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007227 RID: 29223
		// (get) Token: 0x060175D3 RID: 95699 RVA: 0x0035E6A0 File Offset: 0x0035C8A0
		public IBehaviorTree? Tree
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return null;
				}
				return new IBehaviorTree?(default(IBehaviorTree).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007228 RID: 29224
		// (get) Token: 0x060175D4 RID: 95700 RVA: 0x0035E700 File Offset: 0x0035C900
		public IQuestRecallConfig? RecallConfig
		{
			get
			{
				int num = this.__p.__offset(88);
				if (num == 0)
				{
					return null;
				}
				return new IQuestRecallConfig?(default(IQuestRecallConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007229 RID: 29225
		// (get) Token: 0x060175D5 RID: 95701 RVA: 0x0035E760 File Offset: 0x0035C960
		public IEntityRefSearchProp? _EntityRefSearch
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return null;
				}
				return new IEntityRefSearchProp?(default(IEntityRefSearchProp).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060175D6 RID: 95702 RVA: 0x0035E7C0 File Offset: 0x0035C9C0
		public string _HighlightDataPaths(int j)
		{
			int num = this.__p.__offset(92);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700722A RID: 29226
		// (get) Token: 0x060175D7 RID: 95703 RVA: 0x0035E7FC File Offset: 0x0035C9FC
		public int _HighlightDataPathsLength
		{
			get
			{
				int num = this.__p.__offset(92);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700722B RID: 29227
		// (get) Token: 0x060175D8 RID: 95704 RVA: 0x0035E828 File Offset: 0x0035CA28
		public string _FocusDataPath
		{
			get
			{
				int num = this.__p.__offset(94);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060175D9 RID: 95705 RVA: 0x0035E860 File Offset: 0x0035CA60
		public Span<byte> Get_FocusDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(94, 1);
		}

		// Token: 0x060175DA RID: 95706 RVA: 0x0035E870 File Offset: 0x0035CA70
		public byte[] Get_FocusDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(94);
		}

		// Token: 0x1700722C RID: 29228
		// (get) Token: 0x060175DB RID: 95707 RVA: 0x0035E880 File Offset: 0x0035CA80
		public uint NullMask
		{
			get
			{
				int num = this.__p.__offset(96);
				if (num == 0)
				{
					return 0U;
				}
				return this.__p.bb.GetUint(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060175DC RID: 95708 RVA: 0x0035E8C0 File Offset: 0x0035CAC0
		public static Offset<IQuest> CreateIQuest(FlatBufferBuilder builder, StringOffset ObjTypeOffset = default(StringOffset), VectorOffset ChildrenOffset = default(VectorOffset), VectorOffset ReferenceOffset = default(VectorOffset), VectorOffset WeakReferenceOffset = default(VectorOffset), EQuest Type = EQuest.None, EQuestSubType SubType = EQuestSubType.None, int Id = 0, int DungeonId = 0, VectorOffset BindSystemsOffset = default(VectorOffset), StringOffset TidNameOffset = default(StringOffset), StringOffset KeyOffset = default(StringOffset), StringOffset TidDescOffset = default(StringOffset), EQuestOnlineType OnlineType = EQuestOnlineType.SingleHangUpOnline, bool IsAutoTrack = false, bool IsAutoCoverCurTrack = false, int RewardId = 0, EQuestRegion RegionId = EQuestRegion.None, int ChapterId = 0, int TagId = 0, int FunctionId = 0, StringOffset RoleIdOffset = default(StringOffset), EDistrubuteType DistributeType = EDistrubuteType.Interact, Offset<IDistributeParams> DistributeParamsOffset = default(Offset<IDistributeParams>), bool IsHideAcceptMarkOnNpc = false, bool IsHideInTaskList = false, Offset<IAccessQuestCondition> ProvideTypeOffset = default(Offset<IAccessQuestCondition>), Offset<IAccessQuestCondition> AutoTrackConditionsOffset = default(Offset<IAccessQuestCondition>), VectorOffset RecommendPreQuestOffset = default(VectorOffset), int RecommendationPriority = 0, Offset<IQuestUnlockDelayTime> UnlockDelayTimeOffset = default(Offset<IQuestUnlockDelayTime>), Offset<IPreShowInfo> PreShowInfoOffset = default(Offset<IPreShowInfo>), Offset<IAddInteractOption> AddInteractOptionOffset = default(Offset<IAddInteractOption>), VectorOffset ActiveActionsOffset = default(VectorOffset), VectorOffset AcceptActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), VectorOffset TerminateActionsOffset = default(VectorOffset), VectorOffset TerminateActions2Offset = default(VectorOffset), VectorOffset ReferenceAllEntityOffset = default(VectorOffset), int ActivityId = 0, Offset<IFocusModeSetting> FocusModeSettingOffset = default(Offset<IFocusModeSetting>), bool DelayDestroy = false, Offset<IBehaviorTree> TreeOffset = default(Offset<IBehaviorTree>), Offset<IQuestRecallConfig> RecallConfigOffset = default(Offset<IQuestRecallConfig>), Offset<IEntityRefSearchProp> _entityRefSearchOffset = default(Offset<IEntityRefSearchProp>), VectorOffset _highlightDataPathsOffset = default(VectorOffset), StringOffset _focusDataPathOffset = default(StringOffset), uint NullMask = 0U)
		{
			builder.StartTable(47);
			IQuest.AddNullMask(builder, NullMask);
			IQuest.Add_FocusDataPath(builder, _focusDataPathOffset);
			IQuest.Add_HighlightDataPaths(builder, _highlightDataPathsOffset);
			IQuest.Add_EntityRefSearch(builder, _entityRefSearchOffset);
			IQuest.AddRecallConfig(builder, RecallConfigOffset);
			IQuest.AddTree(builder, TreeOffset);
			IQuest.AddFocusModeSetting(builder, FocusModeSettingOffset);
			IQuest.AddActivityId(builder, ActivityId);
			IQuest.AddReferenceAllEntity(builder, ReferenceAllEntityOffset);
			IQuest.AddTerminateActions2(builder, TerminateActions2Offset);
			IQuest.AddTerminateActions(builder, TerminateActionsOffset);
			IQuest.AddFinishActions(builder, FinishActionsOffset);
			IQuest.AddAcceptActions(builder, AcceptActionsOffset);
			IQuest.AddActiveActions(builder, ActiveActionsOffset);
			IQuest.AddAddInteractOption(builder, AddInteractOptionOffset);
			IQuest.AddPreShowInfo(builder, PreShowInfoOffset);
			IQuest.AddUnlockDelayTime(builder, UnlockDelayTimeOffset);
			IQuest.AddRecommendationPriority(builder, RecommendationPriority);
			IQuest.AddRecommendPreQuest(builder, RecommendPreQuestOffset);
			IQuest.AddAutoTrackConditions(builder, AutoTrackConditionsOffset);
			IQuest.AddProvideType(builder, ProvideTypeOffset);
			IQuest.AddDistributeParams(builder, DistributeParamsOffset);
			IQuest.AddRoleId(builder, RoleIdOffset);
			IQuest.AddFunctionId(builder, FunctionId);
			IQuest.AddTagId(builder, TagId);
			IQuest.AddChapterId(builder, ChapterId);
			IQuest.AddRewardId(builder, RewardId);
			IQuest.AddTidDesc(builder, TidDescOffset);
			IQuest.AddKey(builder, KeyOffset);
			IQuest.AddTidName(builder, TidNameOffset);
			IQuest.AddBindSystems(builder, BindSystemsOffset);
			IQuest.AddDungeonId(builder, DungeonId);
			IQuest.AddId(builder, Id);
			IQuest.AddWeakReference(builder, WeakReferenceOffset);
			IQuest.AddReference(builder, ReferenceOffset);
			IQuest.AddChildren(builder, ChildrenOffset);
			IQuest.AddObjType(builder, ObjTypeOffset);
			IQuest.AddDelayDestroy(builder, DelayDestroy);
			IQuest.AddIsHideInTaskList(builder, IsHideInTaskList);
			IQuest.AddIsHideAcceptMarkOnNpc(builder, IsHideAcceptMarkOnNpc);
			IQuest.AddDistributeType(builder, DistributeType);
			IQuest.AddRegionId(builder, RegionId);
			IQuest.AddIsAutoCoverCurTrack(builder, IsAutoCoverCurTrack);
			IQuest.AddIsAutoTrack(builder, IsAutoTrack);
			IQuest.AddOnlineType(builder, OnlineType);
			IQuest.AddSubType(builder, SubType);
			IQuest.AddType(builder, Type);
			return IQuest.EndIQuest(builder);
		}

		// Token: 0x060175DD RID: 95709 RVA: 0x0035EA50 File Offset: 0x0035CC50
		public static void StartIQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(47);
		}

		// Token: 0x060175DE RID: 95710 RVA: 0x0035EA5A File Offset: 0x0035CC5A
		public static void AddObjType(FlatBufferBuilder builder, StringOffset objTypeOffset)
		{
			builder.AddOffset(0, objTypeOffset.Value, 0);
		}

		// Token: 0x060175DF RID: 95711 RVA: 0x0035EA6A File Offset: 0x0035CC6A
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(1, childrenOffset.Value, 0);
		}

		// Token: 0x060175E0 RID: 95712 RVA: 0x0035EA7C File Offset: 0x0035CC7C
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060175E1 RID: 95713 RVA: 0x0035EABC File Offset: 0x0035CCBC
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060175E2 RID: 95714 RVA: 0x0035EAD6 File Offset: 0x0035CCD6
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060175E3 RID: 95715 RVA: 0x0035EAF4 File Offset: 0x0035CCF4
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060175E4 RID: 95716 RVA: 0x0035EB0D File Offset: 0x0035CD0D
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060175E5 RID: 95717 RVA: 0x0035EB18 File Offset: 0x0035CD18
		public static void AddReference(FlatBufferBuilder builder, VectorOffset referenceOffset)
		{
			builder.AddOffset(2, referenceOffset.Value, 0);
		}

		// Token: 0x060175E6 RID: 95718 RVA: 0x0035EB28 File Offset: 0x0035CD28
		public static VectorOffset CreateReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060175E7 RID: 95719 RVA: 0x0035EB68 File Offset: 0x0035CD68
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060175E8 RID: 95720 RVA: 0x0035EB82 File Offset: 0x0035CD82
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060175E9 RID: 95721 RVA: 0x0035EBA0 File Offset: 0x0035CDA0
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060175EA RID: 95722 RVA: 0x0035EBB9 File Offset: 0x0035CDB9
		public static void StartReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060175EB RID: 95723 RVA: 0x0035EBC4 File Offset: 0x0035CDC4
		public static void AddWeakReference(FlatBufferBuilder builder, VectorOffset weakReferenceOffset)
		{
			builder.AddOffset(3, weakReferenceOffset.Value, 0);
		}

		// Token: 0x060175EC RID: 95724 RVA: 0x0035EBD4 File Offset: 0x0035CDD4
		public static VectorOffset CreateWeakReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060175ED RID: 95725 RVA: 0x0035EC14 File Offset: 0x0035CE14
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060175EE RID: 95726 RVA: 0x0035EC2E File Offset: 0x0035CE2E
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060175EF RID: 95727 RVA: 0x0035EC4C File Offset: 0x0035CE4C
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060175F0 RID: 95728 RVA: 0x0035EC65 File Offset: 0x0035CE65
		public static void StartWeakReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060175F1 RID: 95729 RVA: 0x0035EC70 File Offset: 0x0035CE70
		public static void AddType(FlatBufferBuilder builder, EQuest type)
		{
			builder.AddByte(4, (byte)type, 0);
		}

		// Token: 0x060175F2 RID: 95730 RVA: 0x0035EC7B File Offset: 0x0035CE7B
		public static void AddSubType(FlatBufferBuilder builder, EQuestSubType subType)
		{
			builder.AddByte(5, (byte)subType, 0);
		}

		// Token: 0x060175F3 RID: 95731 RVA: 0x0035EC86 File Offset: 0x0035CE86
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(6, id, 0);
		}

		// Token: 0x060175F4 RID: 95732 RVA: 0x0035EC91 File Offset: 0x0035CE91
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(7, dungeonId, 0);
		}

		// Token: 0x060175F5 RID: 95733 RVA: 0x0035EC9C File Offset: 0x0035CE9C
		public static void AddBindSystems(FlatBufferBuilder builder, VectorOffset bindSystemsOffset)
		{
			builder.AddOffset(8, bindSystemsOffset.Value, 0);
		}

		// Token: 0x060175F6 RID: 95734 RVA: 0x0035ECAC File Offset: 0x0035CEAC
		public static VectorOffset CreateBindSystemsVector(FlatBufferBuilder builder, ESystemModuleName[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060175F7 RID: 95735 RVA: 0x0035ECE3 File Offset: 0x0035CEE3
		public static VectorOffset CreateBindSystemsVectorBlock(FlatBufferBuilder builder, ESystemModuleName[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<ESystemModuleName>(data);
			return builder.EndVector();
		}

		// Token: 0x060175F8 RID: 95736 RVA: 0x0035ECFD File Offset: 0x0035CEFD
		public static VectorOffset CreateBindSystemsVectorBlock(FlatBufferBuilder builder, ArraySegment<ESystemModuleName> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<ESystemModuleName>(data);
			return builder.EndVector();
		}

		// Token: 0x060175F9 RID: 95737 RVA: 0x0035ED1B File Offset: 0x0035CF1B
		public static VectorOffset CreateBindSystemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<ESystemModuleName>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060175FA RID: 95738 RVA: 0x0035ED34 File Offset: 0x0035CF34
		public static void StartBindSystemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060175FB RID: 95739 RVA: 0x0035ED3F File Offset: 0x0035CF3F
		public static void AddTidName(FlatBufferBuilder builder, StringOffset tidNameOffset)
		{
			builder.AddOffset(9, tidNameOffset.Value, 0);
		}

		// Token: 0x060175FC RID: 95740 RVA: 0x0035ED50 File Offset: 0x0035CF50
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(10, keyOffset.Value, 0);
		}

		// Token: 0x060175FD RID: 95741 RVA: 0x0035ED61 File Offset: 0x0035CF61
		public static void AddTidDesc(FlatBufferBuilder builder, StringOffset tidDescOffset)
		{
			builder.AddOffset(11, tidDescOffset.Value, 0);
		}

		// Token: 0x060175FE RID: 95742 RVA: 0x0035ED72 File Offset: 0x0035CF72
		public static void AddOnlineType(FlatBufferBuilder builder, EQuestOnlineType onlineType)
		{
			builder.AddByte(12, (byte)onlineType, 0);
		}

		// Token: 0x060175FF RID: 95743 RVA: 0x0035ED7E File Offset: 0x0035CF7E
		public static void AddIsAutoTrack(FlatBufferBuilder builder, bool isAutoTrack)
		{
			builder.AddBool(13, isAutoTrack, false);
		}

		// Token: 0x06017600 RID: 95744 RVA: 0x0035ED8A File Offset: 0x0035CF8A
		public static void AddIsAutoCoverCurTrack(FlatBufferBuilder builder, bool isAutoCoverCurTrack)
		{
			builder.AddBool(14, isAutoCoverCurTrack, false);
		}

		// Token: 0x06017601 RID: 95745 RVA: 0x0035ED96 File Offset: 0x0035CF96
		public static void AddRewardId(FlatBufferBuilder builder, int rewardId)
		{
			builder.AddInt(15, rewardId, 0);
		}

		// Token: 0x06017602 RID: 95746 RVA: 0x0035EDA2 File Offset: 0x0035CFA2
		public static void AddRegionId(FlatBufferBuilder builder, EQuestRegion regionId)
		{
			builder.AddByte(16, (byte)regionId, 0);
		}

		// Token: 0x06017603 RID: 95747 RVA: 0x0035EDAE File Offset: 0x0035CFAE
		public static void AddChapterId(FlatBufferBuilder builder, int chapterId)
		{
			builder.AddInt(17, chapterId, 0);
		}

		// Token: 0x06017604 RID: 95748 RVA: 0x0035EDBA File Offset: 0x0035CFBA
		public static void AddTagId(FlatBufferBuilder builder, int tagId)
		{
			builder.AddInt(18, tagId, 0);
		}

		// Token: 0x06017605 RID: 95749 RVA: 0x0035EDC6 File Offset: 0x0035CFC6
		public static void AddFunctionId(FlatBufferBuilder builder, int functionId)
		{
			builder.AddInt(19, functionId, 0);
		}

		// Token: 0x06017606 RID: 95750 RVA: 0x0035EDD2 File Offset: 0x0035CFD2
		public static void AddRoleId(FlatBufferBuilder builder, StringOffset roleIdOffset)
		{
			builder.AddOffset(20, roleIdOffset.Value, 0);
		}

		// Token: 0x06017607 RID: 95751 RVA: 0x0035EDE3 File Offset: 0x0035CFE3
		public static void AddDistributeType(FlatBufferBuilder builder, EDistrubuteType distributeType)
		{
			builder.AddByte(21, (byte)distributeType, 0);
		}

		// Token: 0x06017608 RID: 95752 RVA: 0x0035EDEF File Offset: 0x0035CFEF
		public static void AddDistributeParams(FlatBufferBuilder builder, Offset<IDistributeParams> distributeParamsOffset)
		{
			builder.AddOffset(22, distributeParamsOffset.Value, 0);
		}

		// Token: 0x06017609 RID: 95753 RVA: 0x0035EE00 File Offset: 0x0035D000
		public static void AddIsHideAcceptMarkOnNpc(FlatBufferBuilder builder, bool isHideAcceptMarkOnNpc)
		{
			builder.AddBool(23, isHideAcceptMarkOnNpc, false);
		}

		// Token: 0x0601760A RID: 95754 RVA: 0x0035EE0C File Offset: 0x0035D00C
		public static void AddIsHideInTaskList(FlatBufferBuilder builder, bool isHideInTaskList)
		{
			builder.AddBool(24, isHideInTaskList, false);
		}

		// Token: 0x0601760B RID: 95755 RVA: 0x0035EE18 File Offset: 0x0035D018
		public static void AddProvideType(FlatBufferBuilder builder, Offset<IAccessQuestCondition> provideTypeOffset)
		{
			builder.AddOffset(25, provideTypeOffset.Value, 0);
		}

		// Token: 0x0601760C RID: 95756 RVA: 0x0035EE29 File Offset: 0x0035D029
		public static void AddAutoTrackConditions(FlatBufferBuilder builder, Offset<IAccessQuestCondition> autoTrackConditionsOffset)
		{
			builder.AddOffset(26, autoTrackConditionsOffset.Value, 0);
		}

		// Token: 0x0601760D RID: 95757 RVA: 0x0035EE3A File Offset: 0x0035D03A
		public static void AddRecommendPreQuest(FlatBufferBuilder builder, VectorOffset recommendPreQuestOffset)
		{
			builder.AddOffset(27, recommendPreQuestOffset.Value, 0);
		}

		// Token: 0x0601760E RID: 95758 RVA: 0x0035EE4C File Offset: 0x0035D04C
		public static VectorOffset CreateRecommendPreQuestVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601760F RID: 95759 RVA: 0x0035EE83 File Offset: 0x0035D083
		public static VectorOffset CreateRecommendPreQuestVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017610 RID: 95760 RVA: 0x0035EE9D File Offset: 0x0035D09D
		public static VectorOffset CreateRecommendPreQuestVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017611 RID: 95761 RVA: 0x0035EEBB File Offset: 0x0035D0BB
		public static VectorOffset CreateRecommendPreQuestVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017612 RID: 95762 RVA: 0x0035EED4 File Offset: 0x0035D0D4
		public static void StartRecommendPreQuestVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017613 RID: 95763 RVA: 0x0035EEDF File Offset: 0x0035D0DF
		public static void AddRecommendationPriority(FlatBufferBuilder builder, int recommendationPriority)
		{
			builder.AddInt(28, recommendationPriority, 0);
		}

		// Token: 0x06017614 RID: 95764 RVA: 0x0035EEEB File Offset: 0x0035D0EB
		public static void AddUnlockDelayTime(FlatBufferBuilder builder, Offset<IQuestUnlockDelayTime> unlockDelayTimeOffset)
		{
			builder.AddOffset(29, unlockDelayTimeOffset.Value, 0);
		}

		// Token: 0x06017615 RID: 95765 RVA: 0x0035EEFC File Offset: 0x0035D0FC
		public static void AddPreShowInfo(FlatBufferBuilder builder, Offset<IPreShowInfo> preShowInfoOffset)
		{
			builder.AddOffset(30, preShowInfoOffset.Value, 0);
		}

		// Token: 0x06017616 RID: 95766 RVA: 0x0035EF0D File Offset: 0x0035D10D
		public static void AddAddInteractOption(FlatBufferBuilder builder, Offset<IAddInteractOption> addInteractOptionOffset)
		{
			builder.AddOffset(31, addInteractOptionOffset.Value, 0);
		}

		// Token: 0x06017617 RID: 95767 RVA: 0x0035EF1E File Offset: 0x0035D11E
		public static void AddActiveActions(FlatBufferBuilder builder, VectorOffset activeActionsOffset)
		{
			builder.AddOffset(32, activeActionsOffset.Value, 0);
		}

		// Token: 0x06017618 RID: 95768 RVA: 0x0035EF30 File Offset: 0x0035D130
		public static VectorOffset CreateActiveActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017619 RID: 95769 RVA: 0x0035EF70 File Offset: 0x0035D170
		public static VectorOffset CreateActiveActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601761A RID: 95770 RVA: 0x0035EF8A File Offset: 0x0035D18A
		public static VectorOffset CreateActiveActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601761B RID: 95771 RVA: 0x0035EFA8 File Offset: 0x0035D1A8
		public static VectorOffset CreateActiveActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601761C RID: 95772 RVA: 0x0035EFC1 File Offset: 0x0035D1C1
		public static void StartActiveActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601761D RID: 95773 RVA: 0x0035EFCC File Offset: 0x0035D1CC
		public static void AddAcceptActions(FlatBufferBuilder builder, VectorOffset acceptActionsOffset)
		{
			builder.AddOffset(33, acceptActionsOffset.Value, 0);
		}

		// Token: 0x0601761E RID: 95774 RVA: 0x0035EFE0 File Offset: 0x0035D1E0
		public static VectorOffset CreateAcceptActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601761F RID: 95775 RVA: 0x0035F020 File Offset: 0x0035D220
		public static VectorOffset CreateAcceptActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017620 RID: 95776 RVA: 0x0035F03A File Offset: 0x0035D23A
		public static VectorOffset CreateAcceptActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017621 RID: 95777 RVA: 0x0035F058 File Offset: 0x0035D258
		public static VectorOffset CreateAcceptActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017622 RID: 95778 RVA: 0x0035F071 File Offset: 0x0035D271
		public static void StartAcceptActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017623 RID: 95779 RVA: 0x0035F07C File Offset: 0x0035D27C
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(34, finishActionsOffset.Value, 0);
		}

		// Token: 0x06017624 RID: 95780 RVA: 0x0035F090 File Offset: 0x0035D290
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017625 RID: 95781 RVA: 0x0035F0D0 File Offset: 0x0035D2D0
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017626 RID: 95782 RVA: 0x0035F0EA File Offset: 0x0035D2EA
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017627 RID: 95783 RVA: 0x0035F108 File Offset: 0x0035D308
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017628 RID: 95784 RVA: 0x0035F121 File Offset: 0x0035D321
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017629 RID: 95785 RVA: 0x0035F12C File Offset: 0x0035D32C
		public static void AddTerminateActions(FlatBufferBuilder builder, VectorOffset terminateActionsOffset)
		{
			builder.AddOffset(35, terminateActionsOffset.Value, 0);
		}

		// Token: 0x0601762A RID: 95786 RVA: 0x0035F140 File Offset: 0x0035D340
		public static VectorOffset CreateTerminateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601762B RID: 95787 RVA: 0x0035F180 File Offset: 0x0035D380
		public static VectorOffset CreateTerminateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601762C RID: 95788 RVA: 0x0035F19A File Offset: 0x0035D39A
		public static VectorOffset CreateTerminateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601762D RID: 95789 RVA: 0x0035F1B8 File Offset: 0x0035D3B8
		public static VectorOffset CreateTerminateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601762E RID: 95790 RVA: 0x0035F1D1 File Offset: 0x0035D3D1
		public static void StartTerminateActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601762F RID: 95791 RVA: 0x0035F1DC File Offset: 0x0035D3DC
		public static void AddTerminateActions2(FlatBufferBuilder builder, VectorOffset terminateActions2Offset)
		{
			builder.AddOffset(36, terminateActions2Offset.Value, 0);
		}

		// Token: 0x06017630 RID: 95792 RVA: 0x0035F1F0 File Offset: 0x0035D3F0
		public static VectorOffset CreateTerminateActions2Vector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017631 RID: 95793 RVA: 0x0035F230 File Offset: 0x0035D430
		public static VectorOffset CreateTerminateActions2VectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017632 RID: 95794 RVA: 0x0035F24A File Offset: 0x0035D44A
		public static VectorOffset CreateTerminateActions2VectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017633 RID: 95795 RVA: 0x0035F268 File Offset: 0x0035D468
		public static VectorOffset CreateTerminateActions2VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017634 RID: 95796 RVA: 0x0035F281 File Offset: 0x0035D481
		public static void StartTerminateActions2Vector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017635 RID: 95797 RVA: 0x0035F28C File Offset: 0x0035D48C
		public static void AddReferenceAllEntity(FlatBufferBuilder builder, VectorOffset referenceAllEntityOffset)
		{
			builder.AddOffset(37, referenceAllEntityOffset.Value, 0);
		}

		// Token: 0x06017636 RID: 95798 RVA: 0x0035F2A0 File Offset: 0x0035D4A0
		public static VectorOffset CreateReferenceAllEntityVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017637 RID: 95799 RVA: 0x0035F2D7 File Offset: 0x0035D4D7
		public static VectorOffset CreateReferenceAllEntityVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017638 RID: 95800 RVA: 0x0035F2F1 File Offset: 0x0035D4F1
		public static VectorOffset CreateReferenceAllEntityVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017639 RID: 95801 RVA: 0x0035F30F File Offset: 0x0035D50F
		public static VectorOffset CreateReferenceAllEntityVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601763A RID: 95802 RVA: 0x0035F328 File Offset: 0x0035D528
		public static void StartReferenceAllEntityVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601763B RID: 95803 RVA: 0x0035F333 File Offset: 0x0035D533
		public static void AddActivityId(FlatBufferBuilder builder, int activityId)
		{
			builder.AddInt(38, activityId, 0);
		}

		// Token: 0x0601763C RID: 95804 RVA: 0x0035F33F File Offset: 0x0035D53F
		public static void AddFocusModeSetting(FlatBufferBuilder builder, Offset<IFocusModeSetting> focusModeSettingOffset)
		{
			builder.AddOffset(39, focusModeSettingOffset.Value, 0);
		}

		// Token: 0x0601763D RID: 95805 RVA: 0x0035F350 File Offset: 0x0035D550
		public static void AddDelayDestroy(FlatBufferBuilder builder, bool delayDestroy)
		{
			builder.AddBool(40, delayDestroy, false);
		}

		// Token: 0x0601763E RID: 95806 RVA: 0x0035F35C File Offset: 0x0035D55C
		public static void AddTree(FlatBufferBuilder builder, Offset<IBehaviorTree> treeOffset)
		{
			builder.AddOffset(41, treeOffset.Value, 0);
		}

		// Token: 0x0601763F RID: 95807 RVA: 0x0035F36D File Offset: 0x0035D56D
		public static void AddRecallConfig(FlatBufferBuilder builder, Offset<IQuestRecallConfig> recallConfigOffset)
		{
			builder.AddOffset(42, recallConfigOffset.Value, 0);
		}

		// Token: 0x06017640 RID: 95808 RVA: 0x0035F37E File Offset: 0x0035D57E
		public static void Add_EntityRefSearch(FlatBufferBuilder builder, Offset<IEntityRefSearchProp> _EntityRefSearchOffset)
		{
			builder.AddOffset(43, _EntityRefSearchOffset.Value, 0);
		}

		// Token: 0x06017641 RID: 95809 RVA: 0x0035F38F File Offset: 0x0035D58F
		public static void Add_HighlightDataPaths(FlatBufferBuilder builder, VectorOffset _HighlightDataPathsOffset)
		{
			builder.AddOffset(44, _HighlightDataPathsOffset.Value, 0);
		}

		// Token: 0x06017642 RID: 95810 RVA: 0x0035F3A0 File Offset: 0x0035D5A0
		public static VectorOffset Create_HighlightDataPathsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017643 RID: 95811 RVA: 0x0035F3E0 File Offset: 0x0035D5E0
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06017644 RID: 95812 RVA: 0x0035F3FA File Offset: 0x0035D5FA
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06017645 RID: 95813 RVA: 0x0035F418 File Offset: 0x0035D618
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017646 RID: 95814 RVA: 0x0035F431 File Offset: 0x0035D631
		public static void Start_HighlightDataPathsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017647 RID: 95815 RVA: 0x0035F43C File Offset: 0x0035D63C
		public static void Add_FocusDataPath(FlatBufferBuilder builder, StringOffset _FocusDataPathOffset)
		{
			builder.AddOffset(45, _FocusDataPathOffset.Value, 0);
		}

		// Token: 0x06017648 RID: 95816 RVA: 0x0035F44D File Offset: 0x0035D64D
		public static void AddNullMask(FlatBufferBuilder builder, uint nullMask)
		{
			builder.AddUint(46, nullMask, 0U);
		}

		// Token: 0x06017649 RID: 95817 RVA: 0x0035F459 File Offset: 0x0035D659
		public static Offset<IQuest> EndIQuest(FlatBufferBuilder builder)
		{
			return new Offset<IQuest>(builder.EndTable());
		}

		// Token: 0x0601764A RID: 95818 RVA: 0x0035F468 File Offset: 0x0035D668
		public IQuestT UnPack()
		{
			IQuestT questT = new IQuestT();
			this.UnPackTo(questT);
			return questT;
		}

		// Token: 0x0601764B RID: 95819 RVA: 0x0035F484 File Offset: 0x0035D684
		public void UnPackTo(IQuestT _o)
		{
			_o.ObjType = this.ObjType;
			_o.Children = new List<string>();
			for (int i = 0; i < this.ChildrenLength; i++)
			{
				_o.Children.Add(this.Children(i));
			}
			_o.Reference = new List<string>();
			for (int j = 0; j < this.ReferenceLength; j++)
			{
				_o.Reference.Add(this.Reference(j));
			}
			_o.WeakReference = new List<string>();
			for (int k = 0; k < this.WeakReferenceLength; k++)
			{
				_o.WeakReference.Add(this.WeakReference(k));
			}
			_o.Type = this.Type;
			_o.SubType = this.SubType;
			_o.Id = this.Id;
			_o.DungeonId = this.DungeonId;
			_o.BindSystems = new List<ESystemModuleName>();
			for (int l = 0; l < this.BindSystemsLength; l++)
			{
				_o.BindSystems.Add(this.BindSystems(l));
			}
			_o.TidName = this.TidName;
			_o.Key = this.Key;
			_o.TidDesc = this.TidDesc;
			_o.OnlineType = this.OnlineType;
			_o.IsAutoTrack = this.IsAutoTrack;
			_o.IsAutoCoverCurTrack = this.IsAutoCoverCurTrack;
			_o.RewardId = this.RewardId;
			_o.RegionId = this.RegionId;
			_o.ChapterId = this.ChapterId;
			_o.TagId = this.TagId;
			_o.FunctionId = this.FunctionId;
			_o.RoleId = this.RoleId;
			_o.DistributeType = this.DistributeType;
			_o.DistributeParams = ((this.DistributeParams != null) ? this.DistributeParams.Value.UnPack() : null);
			_o.IsHideAcceptMarkOnNpc = this.IsHideAcceptMarkOnNpc;
			_o.IsHideInTaskList = this.IsHideInTaskList;
			_o.ProvideType = ((this.ProvideType != null) ? this.ProvideType.Value.UnPack() : null);
			_o.AutoTrackConditions = ((this.AutoTrackConditions != null) ? this.AutoTrackConditions.Value.UnPack() : null);
			_o.RecommendPreQuest = new List<int>();
			for (int m = 0; m < this.RecommendPreQuestLength; m++)
			{
				_o.RecommendPreQuest.Add(this.RecommendPreQuest(m));
			}
			_o.RecommendationPriority = this.RecommendationPriority;
			_o.UnlockDelayTime = ((this.UnlockDelayTime != null) ? this.UnlockDelayTime.Value.UnPack() : null);
			_o.PreShowInfo = ((this.PreShowInfo != null) ? this.PreShowInfo.Value.UnPack() : null);
			_o.AddInteractOption = ((this.AddInteractOption != null) ? this.AddInteractOption.Value.UnPack() : null);
			_o.ActiveActions = new List<IActionInfoT>();
			for (int n = 0; n < this.ActiveActionsLength; n++)
			{
				_o.ActiveActions.Add((this.ActiveActions(n) != null) ? this.ActiveActions(n).Value.UnPack() : null);
			}
			_o.AcceptActions = new List<IActionInfoT>();
			for (int num = 0; num < this.AcceptActionsLength; num++)
			{
				_o.AcceptActions.Add((this.AcceptActions(num) != null) ? this.AcceptActions(num).Value.UnPack() : null);
			}
			_o.FinishActions = new List<IActionInfoT>();
			for (int num2 = 0; num2 < this.FinishActionsLength; num2++)
			{
				_o.FinishActions.Add((this.FinishActions(num2) != null) ? this.FinishActions(num2).Value.UnPack() : null);
			}
			_o.TerminateActions = new List<IActionInfoT>();
			for (int num3 = 0; num3 < this.TerminateActionsLength; num3++)
			{
				_o.TerminateActions.Add((this.TerminateActions(num3) != null) ? this.TerminateActions(num3).Value.UnPack() : null);
			}
			_o.TerminateActions2 = new List<IActionInfoT>();
			for (int num4 = 0; num4 < this.TerminateActions2Length; num4++)
			{
				_o.TerminateActions2.Add((this.TerminateActions2(num4) != null) ? this.TerminateActions2(num4).Value.UnPack() : null);
			}
			_o.ReferenceAllEntity = new List<int>();
			for (int num5 = 0; num5 < this.ReferenceAllEntityLength; num5++)
			{
				_o.ReferenceAllEntity.Add(this.ReferenceAllEntity(num5));
			}
			_o.ActivityId = this.ActivityId;
			_o.FocusModeSetting = ((this.FocusModeSetting != null) ? this.FocusModeSetting.Value.UnPack() : null);
			_o.DelayDestroy = this.DelayDestroy;
			_o.Tree = ((this.Tree != null) ? this.Tree.Value.UnPack() : null);
			_o.RecallConfig = ((this.RecallConfig != null) ? this.RecallConfig.Value.UnPack() : null);
			_o._EntityRefSearch = ((this._EntityRefSearch != null) ? this._EntityRefSearch.Value.UnPack() : null);
			_o._HighlightDataPaths = new List<string>();
			for (int num6 = 0; num6 < this._HighlightDataPathsLength; num6++)
			{
				_o._HighlightDataPaths.Add(this._HighlightDataPaths(num6));
			}
			_o._FocusDataPath = this._FocusDataPath;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601764C RID: 95820 RVA: 0x0035FACC File Offset: 0x0035DCCC
		public static Offset<IQuest> Pack(FlatBufferBuilder builder, IQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuest>);
			}
			StringOffset objTypeOffset = (_o.ObjType == null) ? default(StringOffset) : builder.CreateString(_o.ObjType);
			VectorOffset childrenOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				StringOffset[] array = new StringOffset[_o.Children.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Children[i]);
				}
				childrenOffset = IQuest.CreateChildrenVector(builder, array);
			}
			VectorOffset referenceOffset = default(VectorOffset);
			if (_o.Reference != null)
			{
				StringOffset[] array2 = new StringOffset[_o.Reference.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = builder.CreateString(_o.Reference[j]);
				}
				referenceOffset = IQuest.CreateReferenceVector(builder, array2);
			}
			VectorOffset weakReferenceOffset = default(VectorOffset);
			if (_o.WeakReference != null)
			{
				StringOffset[] array3 = new StringOffset[_o.WeakReference.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = builder.CreateString(_o.WeakReference[k]);
				}
				weakReferenceOffset = IQuest.CreateWeakReferenceVector(builder, array3);
			}
			VectorOffset bindSystemsOffset = default(VectorOffset);
			if (_o.BindSystems != null)
			{
				ESystemModuleName[] data = _o.BindSystems.ToArray();
				bindSystemsOffset = IQuest.CreateBindSystemsVector(builder, data);
			}
			StringOffset tidNameOffset = (_o.TidName == null) ? default(StringOffset) : builder.CreateString(_o.TidName);
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			StringOffset tidDescOffset = (_o.TidDesc == null) ? default(StringOffset) : builder.CreateString(_o.TidDesc);
			StringOffset roleIdOffset = (_o.RoleId == null) ? default(StringOffset) : builder.CreateString(_o.RoleId);
			Offset<IDistributeParams> distributeParamsOffset = (_o.DistributeParams == null) ? default(Offset<IDistributeParams>) : IDistributeParams.Pack(builder, _o.DistributeParams);
			Offset<IAccessQuestCondition> provideTypeOffset = (_o.ProvideType == null) ? default(Offset<IAccessQuestCondition>) : IAccessQuestCondition.Pack(builder, _o.ProvideType);
			Offset<IAccessQuestCondition> autoTrackConditionsOffset = (_o.AutoTrackConditions == null) ? default(Offset<IAccessQuestCondition>) : IAccessQuestCondition.Pack(builder, _o.AutoTrackConditions);
			VectorOffset recommendPreQuestOffset = default(VectorOffset);
			if (_o.RecommendPreQuest != null)
			{
				int[] data2 = _o.RecommendPreQuest.ToArray();
				recommendPreQuestOffset = IQuest.CreateRecommendPreQuestVector(builder, data2);
			}
			Offset<IQuestUnlockDelayTime> unlockDelayTimeOffset = (_o.UnlockDelayTime == null) ? default(Offset<IQuestUnlockDelayTime>) : IQuestUnlockDelayTime.Pack(builder, _o.UnlockDelayTime);
			Offset<IPreShowInfo> preShowInfoOffset = (_o.PreShowInfo == null) ? default(Offset<IPreShowInfo>) : IPreShowInfo.Pack(builder, _o.PreShowInfo);
			Offset<IAddInteractOption> addInteractOptionOffset = (_o.AddInteractOption == null) ? default(Offset<IAddInteractOption>) : IAddInteractOption.Pack(builder, _o.AddInteractOption);
			VectorOffset activeActionsOffset = default(VectorOffset);
			if (_o.ActiveActions != null)
			{
				Offset<IActionInfo>[] array4 = new Offset<IActionInfo>[_o.ActiveActions.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = IActionInfo.Pack(builder, _o.ActiveActions[l]);
				}
				activeActionsOffset = IQuest.CreateActiveActionsVector(builder, array4);
			}
			VectorOffset acceptActionsOffset = default(VectorOffset);
			if (_o.AcceptActions != null)
			{
				Offset<IActionInfo>[] array5 = new Offset<IActionInfo>[_o.AcceptActions.Count];
				for (int m = 0; m < array5.Length; m++)
				{
					array5[m] = IActionInfo.Pack(builder, _o.AcceptActions[m]);
				}
				acceptActionsOffset = IQuest.CreateAcceptActionsVector(builder, array5);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array6 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int n = 0; n < array6.Length; n++)
				{
					array6[n] = IActionInfo.Pack(builder, _o.FinishActions[n]);
				}
				finishActionsOffset = IQuest.CreateFinishActionsVector(builder, array6);
			}
			VectorOffset terminateActionsOffset = default(VectorOffset);
			if (_o.TerminateActions != null)
			{
				Offset<IActionInfo>[] array7 = new Offset<IActionInfo>[_o.TerminateActions.Count];
				for (int num = 0; num < array7.Length; num++)
				{
					array7[num] = IActionInfo.Pack(builder, _o.TerminateActions[num]);
				}
				terminateActionsOffset = IQuest.CreateTerminateActionsVector(builder, array7);
			}
			VectorOffset terminateActions2Offset = default(VectorOffset);
			if (_o.TerminateActions2 != null)
			{
				Offset<IActionInfo>[] array8 = new Offset<IActionInfo>[_o.TerminateActions2.Count];
				for (int num2 = 0; num2 < array8.Length; num2++)
				{
					array8[num2] = IActionInfo.Pack(builder, _o.TerminateActions2[num2]);
				}
				terminateActions2Offset = IQuest.CreateTerminateActions2Vector(builder, array8);
			}
			VectorOffset referenceAllEntityOffset = default(VectorOffset);
			if (_o.ReferenceAllEntity != null)
			{
				int[] data3 = _o.ReferenceAllEntity.ToArray();
				referenceAllEntityOffset = IQuest.CreateReferenceAllEntityVector(builder, data3);
			}
			Offset<IFocusModeSetting> focusModeSettingOffset = (_o.FocusModeSetting == null) ? default(Offset<IFocusModeSetting>) : IFocusModeSetting.Pack(builder, _o.FocusModeSetting);
			Offset<IBehaviorTree> treeOffset = (_o.Tree == null) ? default(Offset<IBehaviorTree>) : IBehaviorTree.Pack(builder, _o.Tree);
			Offset<IQuestRecallConfig> recallConfigOffset = (_o.RecallConfig == null) ? default(Offset<IQuestRecallConfig>) : IQuestRecallConfig.Pack(builder, _o.RecallConfig);
			Offset<IEntityRefSearchProp> entityRefSearchOffset = (_o._EntityRefSearch == null) ? default(Offset<IEntityRefSearchProp>) : IEntityRefSearchProp.Pack(builder, _o._EntityRefSearch);
			VectorOffset highlightDataPathsOffset = default(VectorOffset);
			if (_o._HighlightDataPaths != null)
			{
				StringOffset[] array9 = new StringOffset[_o._HighlightDataPaths.Count];
				for (int num3 = 0; num3 < array9.Length; num3++)
				{
					array9[num3] = builder.CreateString(_o._HighlightDataPaths[num3]);
				}
				highlightDataPathsOffset = IQuest.Create_HighlightDataPathsVector(builder, array9);
			}
			StringOffset focusDataPathOffset = (_o._FocusDataPath == null) ? default(StringOffset) : builder.CreateString(_o._FocusDataPath);
			return IQuest.CreateIQuest(builder, objTypeOffset, childrenOffset, referenceOffset, weakReferenceOffset, _o.Type, _o.SubType, _o.Id, _o.DungeonId, bindSystemsOffset, tidNameOffset, keyOffset, tidDescOffset, _o.OnlineType, _o.IsAutoTrack, _o.IsAutoCoverCurTrack, _o.RewardId, _o.RegionId, _o.ChapterId, _o.TagId, _o.FunctionId, roleIdOffset, _o.DistributeType, distributeParamsOffset, _o.IsHideAcceptMarkOnNpc, _o.IsHideInTaskList, provideTypeOffset, autoTrackConditionsOffset, recommendPreQuestOffset, _o.RecommendationPriority, unlockDelayTimeOffset, preShowInfoOffset, addInteractOptionOffset, activeActionsOffset, acceptActionsOffset, finishActionsOffset, terminateActionsOffset, terminateActions2Offset, referenceAllEntityOffset, _o.ActivityId, focusModeSettingOffset, _o.DelayDestroy, treeOffset, recallConfigOffset, entityRefSearchOffset, highlightDataPathsOffset, focusDataPathOffset, _o.NullMask);
		}

		// Token: 0x0400BA35 RID: 47669
		private Table __p;
	}
}
