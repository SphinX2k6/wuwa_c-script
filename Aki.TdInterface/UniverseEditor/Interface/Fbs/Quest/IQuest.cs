using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004406 RID: 17414
	public struct IQuest : IFlatbufferObject
	{
		// Token: 0x170077FB RID: 30715
		// (get) Token: 0x06018C18 RID: 101400 RVA: 0x00387370 File Offset: 0x00385570
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018C19 RID: 101401 RVA: 0x0038737D File Offset: 0x0038557D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018C1A RID: 101402 RVA: 0x00387384 File Offset: 0x00385584
		public static IQuest GetRootAsIQuest(ByteBuffer _bb)
		{
			return IQuest.GetRootAsIQuest(_bb, default(IQuest));
		}

		// Token: 0x06018C1B RID: 101403 RVA: 0x003873A0 File Offset: 0x003855A0
		public static IQuest GetRootAsIQuest(ByteBuffer _bb, IQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018C1C RID: 101404 RVA: 0x003873BD File Offset: 0x003855BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018C1D RID: 101405 RVA: 0x003873CC File Offset: 0x003855CC
		public IQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077FC RID: 30716
		// (get) Token: 0x06018C1E RID: 101406 RVA: 0x003873DC File Offset: 0x003855DC
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

		// Token: 0x06018C1F RID: 101407 RVA: 0x00387413 File Offset: 0x00385613
		public Span<byte> GetObjTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06018C20 RID: 101408 RVA: 0x00387422 File Offset: 0x00385622
		public byte[] GetObjTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06018C21 RID: 101409 RVA: 0x00387430 File Offset: 0x00385630
		public string Children(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170077FD RID: 30717
		// (get) Token: 0x06018C22 RID: 101410 RVA: 0x0038746C File Offset: 0x0038566C
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

		// Token: 0x06018C23 RID: 101411 RVA: 0x00387498 File Offset: 0x00385698
		public string Reference(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170077FE RID: 30718
		// (get) Token: 0x06018C24 RID: 101412 RVA: 0x003874D4 File Offset: 0x003856D4
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

		// Token: 0x06018C25 RID: 101413 RVA: 0x00387500 File Offset: 0x00385700
		public string WeakReference(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170077FF RID: 30719
		// (get) Token: 0x06018C26 RID: 101414 RVA: 0x0038753C File Offset: 0x0038573C
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

		// Token: 0x17007800 RID: 30720
		// (get) Token: 0x06018C27 RID: 101415 RVA: 0x00387568 File Offset: 0x00385768
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

		// Token: 0x17007801 RID: 30721
		// (get) Token: 0x06018C28 RID: 101416 RVA: 0x003875A8 File Offset: 0x003857A8
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

		// Token: 0x17007802 RID: 30722
		// (get) Token: 0x06018C29 RID: 101417 RVA: 0x003875E8 File Offset: 0x003857E8
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

		// Token: 0x17007803 RID: 30723
		// (get) Token: 0x06018C2A RID: 101418 RVA: 0x00387628 File Offset: 0x00385828
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

		// Token: 0x06018C2B RID: 101419 RVA: 0x00387668 File Offset: 0x00385868
		public ESystemModuleName BindSystems(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return ESystemModuleName.Common;
			}
			return (ESystemModuleName)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007804 RID: 30724
		// (get) Token: 0x06018C2C RID: 101420 RVA: 0x003876A8 File Offset: 0x003858A8
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

		// Token: 0x06018C2D RID: 101421 RVA: 0x003876D4 File Offset: 0x003858D4
		public Span<ESystemModuleName> GetBindSystemsBytes()
		{
			return this.__p.__vector_as_span<ESystemModuleName>(20, 1);
		}

		// Token: 0x06018C2E RID: 101422 RVA: 0x003876E4 File Offset: 0x003858E4
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

		// Token: 0x17007805 RID: 30725
		// (get) Token: 0x06018C2F RID: 101423 RVA: 0x00387750 File Offset: 0x00385950
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

		// Token: 0x06018C30 RID: 101424 RVA: 0x00387788 File Offset: 0x00385988
		public Span<byte> GetTidNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06018C31 RID: 101425 RVA: 0x00387798 File Offset: 0x00385998
		public byte[] GetTidNameArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x17007806 RID: 30726
		// (get) Token: 0x06018C32 RID: 101426 RVA: 0x003877A8 File Offset: 0x003859A8
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

		// Token: 0x06018C33 RID: 101427 RVA: 0x003877E0 File Offset: 0x003859E0
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06018C34 RID: 101428 RVA: 0x003877F0 File Offset: 0x003859F0
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(24);
		}

		// Token: 0x17007807 RID: 30727
		// (get) Token: 0x06018C35 RID: 101429 RVA: 0x00387800 File Offset: 0x00385A00
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

		// Token: 0x06018C36 RID: 101430 RVA: 0x00387838 File Offset: 0x00385A38
		public Span<byte> GetTidDescBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06018C37 RID: 101431 RVA: 0x00387848 File Offset: 0x00385A48
		public byte[] GetTidDescArray()
		{
			return this.__p.__vector_as_array<byte>(26);
		}

		// Token: 0x17007808 RID: 30728
		// (get) Token: 0x06018C38 RID: 101432 RVA: 0x00387858 File Offset: 0x00385A58
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

		// Token: 0x17007809 RID: 30729
		// (get) Token: 0x06018C39 RID: 101433 RVA: 0x00387898 File Offset: 0x00385A98
		public bool IsAutoTrack
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700780A RID: 30730
		// (get) Token: 0x06018C3A RID: 101434 RVA: 0x003878D8 File Offset: 0x00385AD8
		public bool IsAutoCoverCurTrack
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700780B RID: 30731
		// (get) Token: 0x06018C3B RID: 101435 RVA: 0x00387918 File Offset: 0x00385B18
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

		// Token: 0x1700780C RID: 30732
		// (get) Token: 0x06018C3C RID: 101436 RVA: 0x00387958 File Offset: 0x00385B58
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

		// Token: 0x1700780D RID: 30733
		// (get) Token: 0x06018C3D RID: 101437 RVA: 0x00387998 File Offset: 0x00385B98
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

		// Token: 0x1700780E RID: 30734
		// (get) Token: 0x06018C3E RID: 101438 RVA: 0x003879D8 File Offset: 0x00385BD8
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

		// Token: 0x1700780F RID: 30735
		// (get) Token: 0x06018C3F RID: 101439 RVA: 0x00387A18 File Offset: 0x00385C18
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

		// Token: 0x17007810 RID: 30736
		// (get) Token: 0x06018C40 RID: 101440 RVA: 0x00387A58 File Offset: 0x00385C58
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

		// Token: 0x06018C41 RID: 101441 RVA: 0x00387A90 File Offset: 0x00385C90
		public Span<byte> GetRoleIdBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06018C42 RID: 101442 RVA: 0x00387AA0 File Offset: 0x00385CA0
		public byte[] GetRoleIdArray()
		{
			return this.__p.__vector_as_array<byte>(44);
		}

		// Token: 0x17007811 RID: 30737
		// (get) Token: 0x06018C43 RID: 101443 RVA: 0x00387AB0 File Offset: 0x00385CB0
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

		// Token: 0x17007812 RID: 30738
		// (get) Token: 0x06018C44 RID: 101444 RVA: 0x00387AF0 File Offset: 0x00385CF0
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

		// Token: 0x17007813 RID: 30739
		// (get) Token: 0x06018C45 RID: 101445 RVA: 0x00387B50 File Offset: 0x00385D50
		public bool IsHideAcceptMarkOnNpc
		{
			get
			{
				int num = this.__p.__offset(50);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007814 RID: 30740
		// (get) Token: 0x06018C46 RID: 101446 RVA: 0x00387B90 File Offset: 0x00385D90
		public bool IsHideInTaskList
		{
			get
			{
				int num = this.__p.__offset(52);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007815 RID: 30741
		// (get) Token: 0x06018C47 RID: 101447 RVA: 0x00387BD0 File Offset: 0x00385DD0
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

		// Token: 0x17007816 RID: 30742
		// (get) Token: 0x06018C48 RID: 101448 RVA: 0x00387C30 File Offset: 0x00385E30
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

		// Token: 0x06018C49 RID: 101449 RVA: 0x00387C90 File Offset: 0x00385E90
		public int RecommendPreQuest(int j)
		{
			int num = this.__p.__offset(58);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007817 RID: 30743
		// (get) Token: 0x06018C4A RID: 101450 RVA: 0x00387CD0 File Offset: 0x00385ED0
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

		// Token: 0x06018C4B RID: 101451 RVA: 0x00387CFC File Offset: 0x00385EFC
		public Span<int> GetRecommendPreQuestBytes()
		{
			return this.__p.__vector_as_span<int>(58, 4);
		}

		// Token: 0x06018C4C RID: 101452 RVA: 0x00387D0C File Offset: 0x00385F0C
		public int[] GetRecommendPreQuestArray()
		{
			return this.__p.__vector_as_array<int>(58);
		}

		// Token: 0x17007818 RID: 30744
		// (get) Token: 0x06018C4D RID: 101453 RVA: 0x00387D1C File Offset: 0x00385F1C
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

		// Token: 0x17007819 RID: 30745
		// (get) Token: 0x06018C4E RID: 101454 RVA: 0x00387D5C File Offset: 0x00385F5C
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

		// Token: 0x1700781A RID: 30746
		// (get) Token: 0x06018C4F RID: 101455 RVA: 0x00387DBC File Offset: 0x00385FBC
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

		// Token: 0x1700781B RID: 30747
		// (get) Token: 0x06018C50 RID: 101456 RVA: 0x00387E1C File Offset: 0x0038601C
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

		// Token: 0x06018C51 RID: 101457 RVA: 0x00387E7C File Offset: 0x0038607C
		public IActionInfo? ActiveActions(int j)
		{
			int num = this.__p.__offset(68);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700781C RID: 30748
		// (get) Token: 0x06018C52 RID: 101458 RVA: 0x00387EE0 File Offset: 0x003860E0
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

		// Token: 0x06018C53 RID: 101459 RVA: 0x00387F0C File Offset: 0x0038610C
		public IActionInfo? AcceptActions(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700781D RID: 30749
		// (get) Token: 0x06018C54 RID: 101460 RVA: 0x00387F70 File Offset: 0x00386170
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

		// Token: 0x06018C55 RID: 101461 RVA: 0x00387F9C File Offset: 0x0038619C
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(72);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700781E RID: 30750
		// (get) Token: 0x06018C56 RID: 101462 RVA: 0x00388000 File Offset: 0x00386200
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

		// Token: 0x06018C57 RID: 101463 RVA: 0x0038802C File Offset: 0x0038622C
		public IActionInfo? TerminateActions(int j)
		{
			int num = this.__p.__offset(74);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700781F RID: 30751
		// (get) Token: 0x06018C58 RID: 101464 RVA: 0x00388090 File Offset: 0x00386290
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

		// Token: 0x06018C59 RID: 101465 RVA: 0x003880BC File Offset: 0x003862BC
		public IActionInfo? TerminateActions2(int j)
		{
			int num = this.__p.__offset(76);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007820 RID: 30752
		// (get) Token: 0x06018C5A RID: 101466 RVA: 0x00388120 File Offset: 0x00386320
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

		// Token: 0x06018C5B RID: 101467 RVA: 0x0038814C File Offset: 0x0038634C
		public int ReferenceAllEntity(int j)
		{
			int num = this.__p.__offset(78);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007821 RID: 30753
		// (get) Token: 0x06018C5C RID: 101468 RVA: 0x0038818C File Offset: 0x0038638C
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

		// Token: 0x06018C5D RID: 101469 RVA: 0x003881B8 File Offset: 0x003863B8
		public Span<int> GetReferenceAllEntityBytes()
		{
			return this.__p.__vector_as_span<int>(78, 4);
		}

		// Token: 0x06018C5E RID: 101470 RVA: 0x003881C8 File Offset: 0x003863C8
		public int[] GetReferenceAllEntityArray()
		{
			return this.__p.__vector_as_array<int>(78);
		}

		// Token: 0x17007822 RID: 30754
		// (get) Token: 0x06018C5F RID: 101471 RVA: 0x003881D8 File Offset: 0x003863D8
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

		// Token: 0x17007823 RID: 30755
		// (get) Token: 0x06018C60 RID: 101472 RVA: 0x00388218 File Offset: 0x00386418
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

		// Token: 0x17007824 RID: 30756
		// (get) Token: 0x06018C61 RID: 101473 RVA: 0x00388278 File Offset: 0x00386478
		public IHardBattleModeSetting? HardBattleModeSetting
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return null;
				}
				return new IHardBattleModeSetting?(default(IHardBattleModeSetting).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007825 RID: 30757
		// (get) Token: 0x06018C62 RID: 101474 RVA: 0x003882D8 File Offset: 0x003864D8
		public bool DelayDestroy
		{
			get
			{
				int num = this.__p.__offset(86);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007826 RID: 30758
		// (get) Token: 0x06018C63 RID: 101475 RVA: 0x00388318 File Offset: 0x00386518
		public IBehaviorTree? Tree
		{
			get
			{
				int num = this.__p.__offset(88);
				if (num == 0)
				{
					return null;
				}
				return new IBehaviorTree?(default(IBehaviorTree).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007827 RID: 30759
		// (get) Token: 0x06018C64 RID: 101476 RVA: 0x00388378 File Offset: 0x00386578
		public IQuestRecallConfig? RecallConfig
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return null;
				}
				return new IQuestRecallConfig?(default(IQuestRecallConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007828 RID: 30760
		// (get) Token: 0x06018C65 RID: 101477 RVA: 0x003883D8 File Offset: 0x003865D8
		public IEntityRefSearchProp? _EntityRefSearch
		{
			get
			{
				int num = this.__p.__offset(92);
				if (num == 0)
				{
					return null;
				}
				return new IEntityRefSearchProp?(default(IEntityRefSearchProp).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06018C66 RID: 101478 RVA: 0x00388438 File Offset: 0x00386638
		public string _HighlightDataPaths(int j)
		{
			int num = this.__p.__offset(94);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007829 RID: 30761
		// (get) Token: 0x06018C67 RID: 101479 RVA: 0x00388474 File Offset: 0x00386674
		public int _HighlightDataPathsLength
		{
			get
			{
				int num = this.__p.__offset(94);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700782A RID: 30762
		// (get) Token: 0x06018C68 RID: 101480 RVA: 0x003884A0 File Offset: 0x003866A0
		public string _FocusDataPath
		{
			get
			{
				int num = this.__p.__offset(96);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018C69 RID: 101481 RVA: 0x003884D8 File Offset: 0x003866D8
		public Span<byte> Get_FocusDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(96, 1);
		}

		// Token: 0x06018C6A RID: 101482 RVA: 0x003884E8 File Offset: 0x003866E8
		public byte[] Get_FocusDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(96);
		}

		// Token: 0x1700782B RID: 30763
		// (get) Token: 0x06018C6B RID: 101483 RVA: 0x003884F8 File Offset: 0x003866F8
		public uint NullMask
		{
			get
			{
				int num = this.__p.__offset(98);
				if (num == 0)
				{
					return 0U;
				}
				return this.__p.bb.GetUint(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018C6C RID: 101484 RVA: 0x00388538 File Offset: 0x00386738
		public static Offset<IQuest> CreateIQuest(FlatBufferBuilder builder, StringOffset ObjTypeOffset = default(StringOffset), VectorOffset ChildrenOffset = default(VectorOffset), VectorOffset ReferenceOffset = default(VectorOffset), VectorOffset WeakReferenceOffset = default(VectorOffset), EQuest Type = EQuest.None, EQuestSubType SubType = EQuestSubType.None, int Id = 0, int DungeonId = 0, VectorOffset BindSystemsOffset = default(VectorOffset), StringOffset TidNameOffset = default(StringOffset), StringOffset KeyOffset = default(StringOffset), StringOffset TidDescOffset = default(StringOffset), EQuestOnlineType OnlineType = EQuestOnlineType.SingleHangUpOnline, bool IsAutoTrack = false, bool IsAutoCoverCurTrack = false, int RewardId = 0, EQuestRegion RegionId = EQuestRegion.None, int ChapterId = 0, int TagId = 0, int FunctionId = 0, StringOffset RoleIdOffset = default(StringOffset), EDistrubuteType DistributeType = EDistrubuteType.Interact, Offset<IDistributeParams> DistributeParamsOffset = default(Offset<IDistributeParams>), bool IsHideAcceptMarkOnNpc = false, bool IsHideInTaskList = false, Offset<IAccessQuestCondition> ProvideTypeOffset = default(Offset<IAccessQuestCondition>), Offset<IAccessQuestCondition> AutoTrackConditionsOffset = default(Offset<IAccessQuestCondition>), VectorOffset RecommendPreQuestOffset = default(VectorOffset), int RecommendationPriority = 0, Offset<IQuestUnlockDelayTime> UnlockDelayTimeOffset = default(Offset<IQuestUnlockDelayTime>), Offset<IPreShowInfo> PreShowInfoOffset = default(Offset<IPreShowInfo>), Offset<IAddInteractOption> AddInteractOptionOffset = default(Offset<IAddInteractOption>), VectorOffset ActiveActionsOffset = default(VectorOffset), VectorOffset AcceptActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), VectorOffset TerminateActionsOffset = default(VectorOffset), VectorOffset TerminateActions2Offset = default(VectorOffset), VectorOffset ReferenceAllEntityOffset = default(VectorOffset), int ActivityId = 0, Offset<IFocusModeSetting> FocusModeSettingOffset = default(Offset<IFocusModeSetting>), Offset<IHardBattleModeSetting> HardBattleModeSettingOffset = default(Offset<IHardBattleModeSetting>), bool DelayDestroy = false, Offset<IBehaviorTree> TreeOffset = default(Offset<IBehaviorTree>), Offset<IQuestRecallConfig> RecallConfigOffset = default(Offset<IQuestRecallConfig>), Offset<IEntityRefSearchProp> _entityRefSearchOffset = default(Offset<IEntityRefSearchProp>), VectorOffset _highlightDataPathsOffset = default(VectorOffset), StringOffset _focusDataPathOffset = default(StringOffset), uint NullMask = 0U)
		{
			builder.StartTable(48);
			IQuest.AddNullMask(builder, NullMask);
			IQuest.Add_FocusDataPath(builder, _focusDataPathOffset);
			IQuest.Add_HighlightDataPaths(builder, _highlightDataPathsOffset);
			IQuest.Add_EntityRefSearch(builder, _entityRefSearchOffset);
			IQuest.AddRecallConfig(builder, RecallConfigOffset);
			IQuest.AddTree(builder, TreeOffset);
			IQuest.AddHardBattleModeSetting(builder, HardBattleModeSettingOffset);
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

		// Token: 0x06018C6D RID: 101485 RVA: 0x003886D0 File Offset: 0x003868D0
		public static void StartIQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(48);
		}

		// Token: 0x06018C6E RID: 101486 RVA: 0x003886DA File Offset: 0x003868DA
		public static void AddObjType(FlatBufferBuilder builder, StringOffset objTypeOffset)
		{
			builder.AddOffset(0, objTypeOffset.Value, 0);
		}

		// Token: 0x06018C6F RID: 101487 RVA: 0x003886EA File Offset: 0x003868EA
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(1, childrenOffset.Value, 0);
		}

		// Token: 0x06018C70 RID: 101488 RVA: 0x003886FC File Offset: 0x003868FC
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018C71 RID: 101489 RVA: 0x0038873C File Offset: 0x0038693C
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06018C72 RID: 101490 RVA: 0x00388756 File Offset: 0x00386956
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06018C73 RID: 101491 RVA: 0x00388774 File Offset: 0x00386974
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018C74 RID: 101492 RVA: 0x0038878D File Offset: 0x0038698D
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018C75 RID: 101493 RVA: 0x00388798 File Offset: 0x00386998
		public static void AddReference(FlatBufferBuilder builder, VectorOffset referenceOffset)
		{
			builder.AddOffset(2, referenceOffset.Value, 0);
		}

		// Token: 0x06018C76 RID: 101494 RVA: 0x003887A8 File Offset: 0x003869A8
		public static VectorOffset CreateReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018C77 RID: 101495 RVA: 0x003887E8 File Offset: 0x003869E8
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06018C78 RID: 101496 RVA: 0x00388802 File Offset: 0x00386A02
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06018C79 RID: 101497 RVA: 0x00388820 File Offset: 0x00386A20
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018C7A RID: 101498 RVA: 0x00388839 File Offset: 0x00386A39
		public static void StartReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018C7B RID: 101499 RVA: 0x00388844 File Offset: 0x00386A44
		public static void AddWeakReference(FlatBufferBuilder builder, VectorOffset weakReferenceOffset)
		{
			builder.AddOffset(3, weakReferenceOffset.Value, 0);
		}

		// Token: 0x06018C7C RID: 101500 RVA: 0x00388854 File Offset: 0x00386A54
		public static VectorOffset CreateWeakReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018C7D RID: 101501 RVA: 0x00388894 File Offset: 0x00386A94
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06018C7E RID: 101502 RVA: 0x003888AE File Offset: 0x00386AAE
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06018C7F RID: 101503 RVA: 0x003888CC File Offset: 0x00386ACC
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018C80 RID: 101504 RVA: 0x003888E5 File Offset: 0x00386AE5
		public static void StartWeakReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018C81 RID: 101505 RVA: 0x003888F0 File Offset: 0x00386AF0
		public static void AddType(FlatBufferBuilder builder, EQuest type)
		{
			builder.AddByte(4, (byte)type, 0);
		}

		// Token: 0x06018C82 RID: 101506 RVA: 0x003888FB File Offset: 0x00386AFB
		public static void AddSubType(FlatBufferBuilder builder, EQuestSubType subType)
		{
			builder.AddByte(5, (byte)subType, 0);
		}

		// Token: 0x06018C83 RID: 101507 RVA: 0x00388906 File Offset: 0x00386B06
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(6, id, 0);
		}

		// Token: 0x06018C84 RID: 101508 RVA: 0x00388911 File Offset: 0x00386B11
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(7, dungeonId, 0);
		}

		// Token: 0x06018C85 RID: 101509 RVA: 0x0038891C File Offset: 0x00386B1C
		public static void AddBindSystems(FlatBufferBuilder builder, VectorOffset bindSystemsOffset)
		{
			builder.AddOffset(8, bindSystemsOffset.Value, 0);
		}

		// Token: 0x06018C86 RID: 101510 RVA: 0x0038892C File Offset: 0x00386B2C
		public static VectorOffset CreateBindSystemsVector(FlatBufferBuilder builder, ESystemModuleName[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018C87 RID: 101511 RVA: 0x00388963 File Offset: 0x00386B63
		public static VectorOffset CreateBindSystemsVectorBlock(FlatBufferBuilder builder, ESystemModuleName[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<ESystemModuleName>(data);
			return builder.EndVector();
		}

		// Token: 0x06018C88 RID: 101512 RVA: 0x0038897D File Offset: 0x00386B7D
		public static VectorOffset CreateBindSystemsVectorBlock(FlatBufferBuilder builder, ArraySegment<ESystemModuleName> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<ESystemModuleName>(data);
			return builder.EndVector();
		}

		// Token: 0x06018C89 RID: 101513 RVA: 0x0038899B File Offset: 0x00386B9B
		public static VectorOffset CreateBindSystemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<ESystemModuleName>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018C8A RID: 101514 RVA: 0x003889B4 File Offset: 0x00386BB4
		public static void StartBindSystemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06018C8B RID: 101515 RVA: 0x003889BF File Offset: 0x00386BBF
		public static void AddTidName(FlatBufferBuilder builder, StringOffset tidNameOffset)
		{
			builder.AddOffset(9, tidNameOffset.Value, 0);
		}

		// Token: 0x06018C8C RID: 101516 RVA: 0x003889D0 File Offset: 0x00386BD0
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(10, keyOffset.Value, 0);
		}

		// Token: 0x06018C8D RID: 101517 RVA: 0x003889E1 File Offset: 0x00386BE1
		public static void AddTidDesc(FlatBufferBuilder builder, StringOffset tidDescOffset)
		{
			builder.AddOffset(11, tidDescOffset.Value, 0);
		}

		// Token: 0x06018C8E RID: 101518 RVA: 0x003889F2 File Offset: 0x00386BF2
		public static void AddOnlineType(FlatBufferBuilder builder, EQuestOnlineType onlineType)
		{
			builder.AddByte(12, (byte)onlineType, 0);
		}

		// Token: 0x06018C8F RID: 101519 RVA: 0x003889FE File Offset: 0x00386BFE
		public static void AddIsAutoTrack(FlatBufferBuilder builder, bool isAutoTrack)
		{
			builder.AddBool(13, isAutoTrack, false);
		}

		// Token: 0x06018C90 RID: 101520 RVA: 0x00388A0A File Offset: 0x00386C0A
		public static void AddIsAutoCoverCurTrack(FlatBufferBuilder builder, bool isAutoCoverCurTrack)
		{
			builder.AddBool(14, isAutoCoverCurTrack, false);
		}

		// Token: 0x06018C91 RID: 101521 RVA: 0x00388A16 File Offset: 0x00386C16
		public static void AddRewardId(FlatBufferBuilder builder, int rewardId)
		{
			builder.AddInt(15, rewardId, 0);
		}

		// Token: 0x06018C92 RID: 101522 RVA: 0x00388A22 File Offset: 0x00386C22
		public static void AddRegionId(FlatBufferBuilder builder, EQuestRegion regionId)
		{
			builder.AddByte(16, (byte)regionId, 0);
		}

		// Token: 0x06018C93 RID: 101523 RVA: 0x00388A2E File Offset: 0x00386C2E
		public static void AddChapterId(FlatBufferBuilder builder, int chapterId)
		{
			builder.AddInt(17, chapterId, 0);
		}

		// Token: 0x06018C94 RID: 101524 RVA: 0x00388A3A File Offset: 0x00386C3A
		public static void AddTagId(FlatBufferBuilder builder, int tagId)
		{
			builder.AddInt(18, tagId, 0);
		}

		// Token: 0x06018C95 RID: 101525 RVA: 0x00388A46 File Offset: 0x00386C46
		public static void AddFunctionId(FlatBufferBuilder builder, int functionId)
		{
			builder.AddInt(19, functionId, 0);
		}

		// Token: 0x06018C96 RID: 101526 RVA: 0x00388A52 File Offset: 0x00386C52
		public static void AddRoleId(FlatBufferBuilder builder, StringOffset roleIdOffset)
		{
			builder.AddOffset(20, roleIdOffset.Value, 0);
		}

		// Token: 0x06018C97 RID: 101527 RVA: 0x00388A63 File Offset: 0x00386C63
		public static void AddDistributeType(FlatBufferBuilder builder, EDistrubuteType distributeType)
		{
			builder.AddByte(21, (byte)distributeType, 0);
		}

		// Token: 0x06018C98 RID: 101528 RVA: 0x00388A6F File Offset: 0x00386C6F
		public static void AddDistributeParams(FlatBufferBuilder builder, Offset<IDistributeParams> distributeParamsOffset)
		{
			builder.AddOffset(22, distributeParamsOffset.Value, 0);
		}

		// Token: 0x06018C99 RID: 101529 RVA: 0x00388A80 File Offset: 0x00386C80
		public static void AddIsHideAcceptMarkOnNpc(FlatBufferBuilder builder, bool isHideAcceptMarkOnNpc)
		{
			builder.AddBool(23, isHideAcceptMarkOnNpc, false);
		}

		// Token: 0x06018C9A RID: 101530 RVA: 0x00388A8C File Offset: 0x00386C8C
		public static void AddIsHideInTaskList(FlatBufferBuilder builder, bool isHideInTaskList)
		{
			builder.AddBool(24, isHideInTaskList, false);
		}

		// Token: 0x06018C9B RID: 101531 RVA: 0x00388A98 File Offset: 0x00386C98
		public static void AddProvideType(FlatBufferBuilder builder, Offset<IAccessQuestCondition> provideTypeOffset)
		{
			builder.AddOffset(25, provideTypeOffset.Value, 0);
		}

		// Token: 0x06018C9C RID: 101532 RVA: 0x00388AA9 File Offset: 0x00386CA9
		public static void AddAutoTrackConditions(FlatBufferBuilder builder, Offset<IAccessQuestCondition> autoTrackConditionsOffset)
		{
			builder.AddOffset(26, autoTrackConditionsOffset.Value, 0);
		}

		// Token: 0x06018C9D RID: 101533 RVA: 0x00388ABA File Offset: 0x00386CBA
		public static void AddRecommendPreQuest(FlatBufferBuilder builder, VectorOffset recommendPreQuestOffset)
		{
			builder.AddOffset(27, recommendPreQuestOffset.Value, 0);
		}

		// Token: 0x06018C9E RID: 101534 RVA: 0x00388ACC File Offset: 0x00386CCC
		public static VectorOffset CreateRecommendPreQuestVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018C9F RID: 101535 RVA: 0x00388B03 File Offset: 0x00386D03
		public static VectorOffset CreateRecommendPreQuestVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018CA0 RID: 101536 RVA: 0x00388B1D File Offset: 0x00386D1D
		public static VectorOffset CreateRecommendPreQuestVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018CA1 RID: 101537 RVA: 0x00388B3B File Offset: 0x00386D3B
		public static VectorOffset CreateRecommendPreQuestVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018CA2 RID: 101538 RVA: 0x00388B54 File Offset: 0x00386D54
		public static void StartRecommendPreQuestVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018CA3 RID: 101539 RVA: 0x00388B5F File Offset: 0x00386D5F
		public static void AddRecommendationPriority(FlatBufferBuilder builder, int recommendationPriority)
		{
			builder.AddInt(28, recommendationPriority, 0);
		}

		// Token: 0x06018CA4 RID: 101540 RVA: 0x00388B6B File Offset: 0x00386D6B
		public static void AddUnlockDelayTime(FlatBufferBuilder builder, Offset<IQuestUnlockDelayTime> unlockDelayTimeOffset)
		{
			builder.AddOffset(29, unlockDelayTimeOffset.Value, 0);
		}

		// Token: 0x06018CA5 RID: 101541 RVA: 0x00388B7C File Offset: 0x00386D7C
		public static void AddPreShowInfo(FlatBufferBuilder builder, Offset<IPreShowInfo> preShowInfoOffset)
		{
			builder.AddOffset(30, preShowInfoOffset.Value, 0);
		}

		// Token: 0x06018CA6 RID: 101542 RVA: 0x00388B8D File Offset: 0x00386D8D
		public static void AddAddInteractOption(FlatBufferBuilder builder, Offset<IAddInteractOption> addInteractOptionOffset)
		{
			builder.AddOffset(31, addInteractOptionOffset.Value, 0);
		}

		// Token: 0x06018CA7 RID: 101543 RVA: 0x00388B9E File Offset: 0x00386D9E
		public static void AddActiveActions(FlatBufferBuilder builder, VectorOffset activeActionsOffset)
		{
			builder.AddOffset(32, activeActionsOffset.Value, 0);
		}

		// Token: 0x06018CA8 RID: 101544 RVA: 0x00388BB0 File Offset: 0x00386DB0
		public static VectorOffset CreateActiveActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018CA9 RID: 101545 RVA: 0x00388BF0 File Offset: 0x00386DF0
		public static VectorOffset CreateActiveActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018CAA RID: 101546 RVA: 0x00388C0A File Offset: 0x00386E0A
		public static VectorOffset CreateActiveActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018CAB RID: 101547 RVA: 0x00388C28 File Offset: 0x00386E28
		public static VectorOffset CreateActiveActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018CAC RID: 101548 RVA: 0x00388C41 File Offset: 0x00386E41
		public static void StartActiveActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018CAD RID: 101549 RVA: 0x00388C4C File Offset: 0x00386E4C
		public static void AddAcceptActions(FlatBufferBuilder builder, VectorOffset acceptActionsOffset)
		{
			builder.AddOffset(33, acceptActionsOffset.Value, 0);
		}

		// Token: 0x06018CAE RID: 101550 RVA: 0x00388C60 File Offset: 0x00386E60
		public static VectorOffset CreateAcceptActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018CAF RID: 101551 RVA: 0x00388CA0 File Offset: 0x00386EA0
		public static VectorOffset CreateAcceptActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018CB0 RID: 101552 RVA: 0x00388CBA File Offset: 0x00386EBA
		public static VectorOffset CreateAcceptActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018CB1 RID: 101553 RVA: 0x00388CD8 File Offset: 0x00386ED8
		public static VectorOffset CreateAcceptActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018CB2 RID: 101554 RVA: 0x00388CF1 File Offset: 0x00386EF1
		public static void StartAcceptActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018CB3 RID: 101555 RVA: 0x00388CFC File Offset: 0x00386EFC
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(34, finishActionsOffset.Value, 0);
		}

		// Token: 0x06018CB4 RID: 101556 RVA: 0x00388D10 File Offset: 0x00386F10
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018CB5 RID: 101557 RVA: 0x00388D50 File Offset: 0x00386F50
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018CB6 RID: 101558 RVA: 0x00388D6A File Offset: 0x00386F6A
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018CB7 RID: 101559 RVA: 0x00388D88 File Offset: 0x00386F88
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018CB8 RID: 101560 RVA: 0x00388DA1 File Offset: 0x00386FA1
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018CB9 RID: 101561 RVA: 0x00388DAC File Offset: 0x00386FAC
		public static void AddTerminateActions(FlatBufferBuilder builder, VectorOffset terminateActionsOffset)
		{
			builder.AddOffset(35, terminateActionsOffset.Value, 0);
		}

		// Token: 0x06018CBA RID: 101562 RVA: 0x00388DC0 File Offset: 0x00386FC0
		public static VectorOffset CreateTerminateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018CBB RID: 101563 RVA: 0x00388E00 File Offset: 0x00387000
		public static VectorOffset CreateTerminateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018CBC RID: 101564 RVA: 0x00388E1A File Offset: 0x0038701A
		public static VectorOffset CreateTerminateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018CBD RID: 101565 RVA: 0x00388E38 File Offset: 0x00387038
		public static VectorOffset CreateTerminateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018CBE RID: 101566 RVA: 0x00388E51 File Offset: 0x00387051
		public static void StartTerminateActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018CBF RID: 101567 RVA: 0x00388E5C File Offset: 0x0038705C
		public static void AddTerminateActions2(FlatBufferBuilder builder, VectorOffset terminateActions2Offset)
		{
			builder.AddOffset(36, terminateActions2Offset.Value, 0);
		}

		// Token: 0x06018CC0 RID: 101568 RVA: 0x00388E70 File Offset: 0x00387070
		public static VectorOffset CreateTerminateActions2Vector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018CC1 RID: 101569 RVA: 0x00388EB0 File Offset: 0x003870B0
		public static VectorOffset CreateTerminateActions2VectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018CC2 RID: 101570 RVA: 0x00388ECA File Offset: 0x003870CA
		public static VectorOffset CreateTerminateActions2VectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018CC3 RID: 101571 RVA: 0x00388EE8 File Offset: 0x003870E8
		public static VectorOffset CreateTerminateActions2VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018CC4 RID: 101572 RVA: 0x00388F01 File Offset: 0x00387101
		public static void StartTerminateActions2Vector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018CC5 RID: 101573 RVA: 0x00388F0C File Offset: 0x0038710C
		public static void AddReferenceAllEntity(FlatBufferBuilder builder, VectorOffset referenceAllEntityOffset)
		{
			builder.AddOffset(37, referenceAllEntityOffset.Value, 0);
		}

		// Token: 0x06018CC6 RID: 101574 RVA: 0x00388F20 File Offset: 0x00387120
		public static VectorOffset CreateReferenceAllEntityVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018CC7 RID: 101575 RVA: 0x00388F57 File Offset: 0x00387157
		public static VectorOffset CreateReferenceAllEntityVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018CC8 RID: 101576 RVA: 0x00388F71 File Offset: 0x00387171
		public static VectorOffset CreateReferenceAllEntityVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018CC9 RID: 101577 RVA: 0x00388F8F File Offset: 0x0038718F
		public static VectorOffset CreateReferenceAllEntityVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018CCA RID: 101578 RVA: 0x00388FA8 File Offset: 0x003871A8
		public static void StartReferenceAllEntityVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018CCB RID: 101579 RVA: 0x00388FB3 File Offset: 0x003871B3
		public static void AddActivityId(FlatBufferBuilder builder, int activityId)
		{
			builder.AddInt(38, activityId, 0);
		}

		// Token: 0x06018CCC RID: 101580 RVA: 0x00388FBF File Offset: 0x003871BF
		public static void AddFocusModeSetting(FlatBufferBuilder builder, Offset<IFocusModeSetting> focusModeSettingOffset)
		{
			builder.AddOffset(39, focusModeSettingOffset.Value, 0);
		}

		// Token: 0x06018CCD RID: 101581 RVA: 0x00388FD0 File Offset: 0x003871D0
		public static void AddHardBattleModeSetting(FlatBufferBuilder builder, Offset<IHardBattleModeSetting> hardBattleModeSettingOffset)
		{
			builder.AddOffset(40, hardBattleModeSettingOffset.Value, 0);
		}

		// Token: 0x06018CCE RID: 101582 RVA: 0x00388FE1 File Offset: 0x003871E1
		public static void AddDelayDestroy(FlatBufferBuilder builder, bool delayDestroy)
		{
			builder.AddBool(41, delayDestroy, false);
		}

		// Token: 0x06018CCF RID: 101583 RVA: 0x00388FED File Offset: 0x003871ED
		public static void AddTree(FlatBufferBuilder builder, Offset<IBehaviorTree> treeOffset)
		{
			builder.AddOffset(42, treeOffset.Value, 0);
		}

		// Token: 0x06018CD0 RID: 101584 RVA: 0x00388FFE File Offset: 0x003871FE
		public static void AddRecallConfig(FlatBufferBuilder builder, Offset<IQuestRecallConfig> recallConfigOffset)
		{
			builder.AddOffset(43, recallConfigOffset.Value, 0);
		}

		// Token: 0x06018CD1 RID: 101585 RVA: 0x0038900F File Offset: 0x0038720F
		public static void Add_EntityRefSearch(FlatBufferBuilder builder, Offset<IEntityRefSearchProp> _EntityRefSearchOffset)
		{
			builder.AddOffset(44, _EntityRefSearchOffset.Value, 0);
		}

		// Token: 0x06018CD2 RID: 101586 RVA: 0x00389020 File Offset: 0x00387220
		public static void Add_HighlightDataPaths(FlatBufferBuilder builder, VectorOffset _HighlightDataPathsOffset)
		{
			builder.AddOffset(45, _HighlightDataPathsOffset.Value, 0);
		}

		// Token: 0x06018CD3 RID: 101587 RVA: 0x00389034 File Offset: 0x00387234
		public static VectorOffset Create_HighlightDataPathsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018CD4 RID: 101588 RVA: 0x00389074 File Offset: 0x00387274
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06018CD5 RID: 101589 RVA: 0x0038908E File Offset: 0x0038728E
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06018CD6 RID: 101590 RVA: 0x003890AC File Offset: 0x003872AC
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018CD7 RID: 101591 RVA: 0x003890C5 File Offset: 0x003872C5
		public static void Start_HighlightDataPathsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018CD8 RID: 101592 RVA: 0x003890D0 File Offset: 0x003872D0
		public static void Add_FocusDataPath(FlatBufferBuilder builder, StringOffset _FocusDataPathOffset)
		{
			builder.AddOffset(46, _FocusDataPathOffset.Value, 0);
		}

		// Token: 0x06018CD9 RID: 101593 RVA: 0x003890E1 File Offset: 0x003872E1
		public static void AddNullMask(FlatBufferBuilder builder, uint nullMask)
		{
			builder.AddUint(47, nullMask, 0U);
		}

		// Token: 0x06018CDA RID: 101594 RVA: 0x003890ED File Offset: 0x003872ED
		public static Offset<IQuest> EndIQuest(FlatBufferBuilder builder)
		{
			return new Offset<IQuest>(builder.EndTable());
		}

		// Token: 0x06018CDB RID: 101595 RVA: 0x003890FC File Offset: 0x003872FC
		public IQuestT UnPack()
		{
			IQuestT questT = new IQuestT();
			this.UnPackTo(questT);
			return questT;
		}

		// Token: 0x06018CDC RID: 101596 RVA: 0x00389118 File Offset: 0x00387318
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
			_o.HardBattleModeSetting = ((this.HardBattleModeSetting != null) ? this.HardBattleModeSetting.Value.UnPack() : null);
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

		// Token: 0x06018CDD RID: 101597 RVA: 0x00389790 File Offset: 0x00387990
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
			Offset<IHardBattleModeSetting> hardBattleModeSettingOffset = (_o.HardBattleModeSetting == null) ? default(Offset<IHardBattleModeSetting>) : IHardBattleModeSetting.Pack(builder, _o.HardBattleModeSetting);
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
			return IQuest.CreateIQuest(builder, objTypeOffset, childrenOffset, referenceOffset, weakReferenceOffset, _o.Type, _o.SubType, _o.Id, _o.DungeonId, bindSystemsOffset, tidNameOffset, keyOffset, tidDescOffset, _o.OnlineType, _o.IsAutoTrack, _o.IsAutoCoverCurTrack, _o.RewardId, _o.RegionId, _o.ChapterId, _o.TagId, _o.FunctionId, roleIdOffset, _o.DistributeType, distributeParamsOffset, _o.IsHideAcceptMarkOnNpc, _o.IsHideInTaskList, provideTypeOffset, autoTrackConditionsOffset, recommendPreQuestOffset, _o.RecommendationPriority, unlockDelayTimeOffset, preShowInfoOffset, addInteractOptionOffset, activeActionsOffset, acceptActionsOffset, finishActionsOffset, terminateActionsOffset, terminateActions2Offset, referenceAllEntityOffset, _o.ActivityId, focusModeSettingOffset, hardBattleModeSettingOffset, _o.DelayDestroy, treeOffset, recallConfigOffset, entityRefSearchOffset, highlightDataPathsOffset, focusDataPathOffset, _o.NullMask);
		}

		// Token: 0x0400C41A RID: 50202
		private Table __p;
	}
}
