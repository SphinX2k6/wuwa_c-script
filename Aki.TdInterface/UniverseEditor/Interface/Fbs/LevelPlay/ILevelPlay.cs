using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Aki.UniverseEditor.Interface.Fbs.Quest;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044E8 RID: 17640
	public struct ILevelPlay : IFlatbufferObject
	{
		// Token: 0x17007C99 RID: 31897
		// (get) Token: 0x0601A650 RID: 108112 RVA: 0x003C4877 File Offset: 0x003C2A77
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A651 RID: 108113 RVA: 0x003C4884 File Offset: 0x003C2A84
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A652 RID: 108114 RVA: 0x003C488C File Offset: 0x003C2A8C
		public static ILevelPlay GetRootAsILevelPlay(ByteBuffer _bb)
		{
			return ILevelPlay.GetRootAsILevelPlay(_bb, default(ILevelPlay));
		}

		// Token: 0x0601A653 RID: 108115 RVA: 0x003C48A8 File Offset: 0x003C2AA8
		public static ILevelPlay GetRootAsILevelPlay(ByteBuffer _bb, ILevelPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A654 RID: 108116 RVA: 0x003C48C5 File Offset: 0x003C2AC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A655 RID: 108117 RVA: 0x003C48D4 File Offset: 0x003C2AD4
		public ILevelPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C9A RID: 31898
		// (get) Token: 0x0601A656 RID: 108118 RVA: 0x003C48E4 File Offset: 0x003C2AE4
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

		// Token: 0x0601A657 RID: 108119 RVA: 0x003C491B File Offset: 0x003C2B1B
		public Span<byte> GetObjTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601A658 RID: 108120 RVA: 0x003C492A File Offset: 0x003C2B2A
		public byte[] GetObjTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601A659 RID: 108121 RVA: 0x003C4938 File Offset: 0x003C2B38
		public string Children(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007C9B RID: 31899
		// (get) Token: 0x0601A65A RID: 108122 RVA: 0x003C4974 File Offset: 0x003C2B74
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

		// Token: 0x0601A65B RID: 108123 RVA: 0x003C49A0 File Offset: 0x003C2BA0
		public string Reference(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007C9C RID: 31900
		// (get) Token: 0x0601A65C RID: 108124 RVA: 0x003C49DC File Offset: 0x003C2BDC
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

		// Token: 0x0601A65D RID: 108125 RVA: 0x003C4A08 File Offset: 0x003C2C08
		public string WeakReference(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007C9D RID: 31901
		// (get) Token: 0x0601A65E RID: 108126 RVA: 0x003C4A44 File Offset: 0x003C2C44
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

		// Token: 0x17007C9E RID: 31902
		// (get) Token: 0x0601A65F RID: 108127 RVA: 0x003C4A70 File Offset: 0x003C2C70
		public int Id
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

		// Token: 0x17007C9F RID: 31903
		// (get) Token: 0x0601A660 RID: 108128 RVA: 0x003C4AB0 File Offset: 0x003C2CB0
		public string Key
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

		// Token: 0x0601A661 RID: 108129 RVA: 0x003C4AE8 File Offset: 0x003C2CE8
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0601A662 RID: 108130 RVA: 0x003C4AF8 File Offset: 0x003C2CF8
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x17007CA0 RID: 31904
		// (get) Token: 0x0601A663 RID: 108131 RVA: 0x003C4B08 File Offset: 0x003C2D08
		public ELevelPlayType Type
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return ELevelPlayType.SilentArea;
				}
				return (ELevelPlayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007CA1 RID: 31905
		// (get) Token: 0x0601A664 RID: 108132 RVA: 0x003C4B48 File Offset: 0x003C2D48
		public EDecisionBtType DecisionBtType
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return EDecisionBtType.Bvb;
				}
				return (EDecisionBtType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A665 RID: 108133 RVA: 0x003C4B88 File Offset: 0x003C2D88
		public ESystemModuleName BindSystems(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return ESystemModuleName.Common;
			}
			return (ESystemModuleName)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007CA2 RID: 31906
		// (get) Token: 0x0601A666 RID: 108134 RVA: 0x003C4BC8 File Offset: 0x003C2DC8
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

		// Token: 0x0601A667 RID: 108135 RVA: 0x003C4BF4 File Offset: 0x003C2DF4
		public Span<ESystemModuleName> GetBindSystemsBytes()
		{
			return this.__p.__vector_as_span<ESystemModuleName>(20, 1);
		}

		// Token: 0x0601A668 RID: 108136 RVA: 0x003C4C04 File Offset: 0x003C2E04
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

		// Token: 0x17007CA3 RID: 31907
		// (get) Token: 0x0601A669 RID: 108137 RVA: 0x003C4C70 File Offset: 0x003C2E70
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

		// Token: 0x0601A66A RID: 108138 RVA: 0x003C4CA8 File Offset: 0x003C2EA8
		public Span<byte> GetTidNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0601A66B RID: 108139 RVA: 0x003C4CB8 File Offset: 0x003C2EB8
		public byte[] GetTidNameArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x17007CA4 RID: 31908
		// (get) Token: 0x0601A66C RID: 108140 RVA: 0x003C4CC8 File Offset: 0x003C2EC8
		public int LevelId
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

		// Token: 0x17007CA5 RID: 31909
		// (get) Token: 0x0601A66D RID: 108141 RVA: 0x003C4D08 File Offset: 0x003C2F08
		public int PackId
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

		// Token: 0x17007CA6 RID: 31910
		// (get) Token: 0x0601A66E RID: 108142 RVA: 0x003C4D48 File Offset: 0x003C2F48
		public int InstanceId
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

		// Token: 0x17007CA7 RID: 31911
		// (get) Token: 0x0601A66F RID: 108143 RVA: 0x003C4D88 File Offset: 0x003C2F88
		public bool IsOnlineStandalone
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601A670 RID: 108144 RVA: 0x003C4DC8 File Offset: 0x003C2FC8
		public string SpecifiedOnlineStandaloneParentUids(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007CA8 RID: 31912
		// (get) Token: 0x0601A671 RID: 108145 RVA: 0x003C4E04 File Offset: 0x003C3004
		public int SpecifiedOnlineStandaloneParentUidsLength
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

		// Token: 0x17007CA9 RID: 31913
		// (get) Token: 0x0601A672 RID: 108146 RVA: 0x003C4E30 File Offset: 0x003C3030
		public ELevelPlayOnlineType OnlineType
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return ELevelPlayOnlineType.Local;
				}
				return (ELevelPlayOnlineType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007CAA RID: 31914
		// (get) Token: 0x0601A673 RID: 108147 RVA: 0x003C4E70 File Offset: 0x003C3070
		public string InternalDest
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

		// Token: 0x0601A674 RID: 108148 RVA: 0x003C4EA8 File Offset: 0x003C30A8
		public Span<byte> GetInternalDestBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0601A675 RID: 108149 RVA: 0x003C4EB8 File Offset: 0x003C30B8
		public byte[] GetInternalDestArray()
		{
			return this.__p.__vector_as_array<byte>(36);
		}

		// Token: 0x17007CAB RID: 31915
		// (get) Token: 0x0601A676 RID: 108150 RVA: 0x003C4EC8 File Offset: 0x003C30C8
		public int LevelAdditiveId
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

		// Token: 0x17007CAC RID: 31916
		// (get) Token: 0x0601A677 RID: 108151 RVA: 0x003C4F08 File Offset: 0x003C3108
		public int LevelAiTeamLevelId
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

		// Token: 0x17007CAD RID: 31917
		// (get) Token: 0x0601A678 RID: 108152 RVA: 0x003C4F48 File Offset: 0x003C3148
		public ILevelPlayZaxis? LevelPlayZaxis
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return new ILevelPlayZaxis?(default(ILevelPlayZaxis).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007CAE RID: 31918
		// (get) Token: 0x0601A679 RID: 108153 RVA: 0x003C4FA8 File Offset: 0x003C31A8
		public int LevelPlayEntityId
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007CAF RID: 31919
		// (get) Token: 0x0601A67A RID: 108154 RVA: 0x003C4FE8 File Offset: 0x003C31E8
		public int EnterRadius
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007CB0 RID: 31920
		// (get) Token: 0x0601A67B RID: 108155 RVA: 0x003C5028 File Offset: 0x003C3228
		public int LeaveRadius
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007CB1 RID: 31921
		// (get) Token: 0x0601A67C RID: 108156 RVA: 0x003C5068 File Offset: 0x003C3268
		public bool DelayRefresh
		{
			get
			{
				int num = this.__p.__offset(50);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007CB2 RID: 31922
		// (get) Token: 0x0601A67D RID: 108157 RVA: 0x003C50A8 File Offset: 0x003C32A8
		public bool DelayDestroy
		{
			get
			{
				int num = this.__p.__offset(52);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007CB3 RID: 31923
		// (get) Token: 0x0601A67E RID: 108158 RVA: 0x003C50E8 File Offset: 0x003C32E8
		public bool NotAllowHidedByGroup
		{
			get
			{
				int num = this.__p.__offset(54);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007CB4 RID: 31924
		// (get) Token: 0x0601A67F RID: 108159 RVA: 0x003C5128 File Offset: 0x003C3328
		public bool AutoRestoreTreeAddedPlayerBuff
		{
			get
			{
				int num = this.__p.__offset(56);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601A680 RID: 108160 RVA: 0x003C5168 File Offset: 0x003C3368
		public IActionInfo? EnterInRangeActions(int j)
		{
			int num = this.__p.__offset(58);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007CB5 RID: 31925
		// (get) Token: 0x0601A681 RID: 108161 RVA: 0x003C51CC File Offset: 0x003C33CC
		public int EnterInRangeActionsLength
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

		// Token: 0x0601A682 RID: 108162 RVA: 0x003C51F8 File Offset: 0x003C33F8
		public IActionInfo? LevelPlayCloseActions(int j)
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007CB6 RID: 31926
		// (get) Token: 0x0601A683 RID: 108163 RVA: 0x003C525C File Offset: 0x003C345C
		public int LevelPlayCloseActionsLength
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17007CB7 RID: 31927
		// (get) Token: 0x0601A684 RID: 108164 RVA: 0x003C5288 File Offset: 0x003C3488
		public ILevelPlayMark? LevelPlayMark
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return null;
				}
				return new ILevelPlayMark?(default(ILevelPlayMark).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007CB8 RID: 31928
		// (get) Token: 0x0601A685 RID: 108165 RVA: 0x003C52E8 File Offset: 0x003C34E8
		public ILevelPlayTrack? LevelPlayTrack
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return null;
				}
				return new ILevelPlayTrack?(default(ILevelPlayTrack).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007CB9 RID: 31929
		// (get) Token: 0x0601A686 RID: 108166 RVA: 0x003C5348 File Offset: 0x003C3548
		public TLevelPlayReward LevelPlayRewardConfigType
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return TLevelPlayReward.NONE;
				}
				return (TLevelPlayReward)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A687 RID: 108167 RVA: 0x003C5388 File Offset: 0x003C3588
		public TTable? LevelPlayRewardConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(68);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601A688 RID: 108168 RVA: 0x003C53D0 File Offset: 0x003C35D0
		public IAutomaticRewardParam LevelPlayRewardConfigAsIAutomaticRewardParam()
		{
			return this.LevelPlayRewardConfig<IAutomaticRewardParam>().Value;
		}

		// Token: 0x0601A689 RID: 108169 RVA: 0x003C53EC File Offset: 0x003C35EC
		public IInteractRewardParam LevelPlayRewardConfigAsIInteractRewardParam()
		{
			return this.LevelPlayRewardConfig<IInteractRewardParam>().Value;
		}

		// Token: 0x0601A68A RID: 108170 RVA: 0x003C5408 File Offset: 0x003C3608
		public INoneRewardParam LevelPlayRewardConfigAsINoneRewardParam()
		{
			return this.LevelPlayRewardConfig<INoneRewardParam>().Value;
		}

		// Token: 0x0601A68B RID: 108171 RVA: 0x003C5424 File Offset: 0x003C3624
		public IVariableRewardParam LevelPlayRewardConfigAsIVariableRewardParam()
		{
			return this.LevelPlayRewardConfig<IVariableRewardParam>().Value;
		}

		// Token: 0x17007CBA RID: 31930
		// (get) Token: 0x0601A68C RID: 108172 RVA: 0x003C5440 File Offset: 0x003C3640
		public TLevelPlayRefresh LevelPlayRefreshConfigType
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return TLevelPlayRefresh.NONE;
				}
				return (TLevelPlayRefresh)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A68D RID: 108173 RVA: 0x003C5480 File Offset: 0x003C3680
		public TTable? LevelPlayRefreshConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(72);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601A68E RID: 108174 RVA: 0x003C54C8 File Offset: 0x003C36C8
		public IChildDestroyOrAwardedRefresh LevelPlayRefreshConfigAsIChildDestroyOrAwardedRefresh()
		{
			return this.LevelPlayRefreshConfig<IChildDestroyOrAwardedRefresh>().Value;
		}

		// Token: 0x0601A68F RID: 108175 RVA: 0x003C54E4 File Offset: 0x003C36E4
		public IChildDestroyRefresh LevelPlayRefreshConfigAsIChildDestroyRefresh()
		{
			return this.LevelPlayRefreshConfig<IChildDestroyRefresh>().Value;
		}

		// Token: 0x0601A690 RID: 108176 RVA: 0x003C5500 File Offset: 0x003C3700
		public ICompletedRefresh LevelPlayRefreshConfigAsICompletedRefresh()
		{
			return this.LevelPlayRefreshConfig<ICompletedRefresh>().Value;
		}

		// Token: 0x0601A691 RID: 108177 RVA: 0x003C551C File Offset: 0x003C371C
		public ICustomOnlineRefresh LevelPlayRefreshConfigAsICustomOnlineRefresh()
		{
			return this.LevelPlayRefreshConfig<ICustomOnlineRefresh>().Value;
		}

		// Token: 0x0601A692 RID: 108178 RVA: 0x003C5538 File Offset: 0x003C3738
		public ICustomRefresh LevelPlayRefreshConfigAsICustomRefresh()
		{
			return this.LevelPlayRefreshConfig<ICustomRefresh>().Value;
		}

		// Token: 0x0601A693 RID: 108179 RVA: 0x003C5554 File Offset: 0x003C3754
		public IFixedDateTimeRefresh LevelPlayRefreshConfigAsIFixedDateTimeRefresh()
		{
			return this.LevelPlayRefreshConfig<IFixedDateTimeRefresh>().Value;
		}

		// Token: 0x0601A694 RID: 108180 RVA: 0x003C5570 File Offset: 0x003C3770
		public INoneRefresh LevelPlayRefreshConfigAsINoneRefresh()
		{
			return this.LevelPlayRefreshConfig<INoneRefresh>().Value;
		}

		// Token: 0x17007CBB RID: 31931
		// (get) Token: 0x0601A695 RID: 108181 RVA: 0x003C558C File Offset: 0x003C378C
		public ILevelPlayOpenCondition? LevelPlayOpenCondition
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return null;
				}
				return new ILevelPlayOpenCondition?(default(ILevelPlayOpenCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007CBC RID: 31932
		// (get) Token: 0x0601A696 RID: 108182 RVA: 0x003C55EC File Offset: 0x003C37EC
		public ILevelPlayActive? LevelPlayActive
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return null;
				}
				return new ILevelPlayActive?(default(ILevelPlayActive).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601A697 RID: 108183 RVA: 0x003C564C File Offset: 0x003C384C
		public IActionInfo? LevelPlayOpenActions(int j)
		{
			int num = this.__p.__offset(78);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007CBD RID: 31933
		// (get) Token: 0x0601A698 RID: 108184 RVA: 0x003C56B0 File Offset: 0x003C38B0
		public int LevelPlayOpenActionsLength
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

		// Token: 0x0601A699 RID: 108185 RVA: 0x003C56DC File Offset: 0x003C38DC
		public IActionInfo? EscActionsAfterDungeonCompletion(int j)
		{
			int num = this.__p.__offset(80);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007CBE RID: 31934
		// (get) Token: 0x0601A69A RID: 108186 RVA: 0x003C5740 File Offset: 0x003C3940
		public int EscActionsAfterDungeonCompletionLength
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17007CBF RID: 31935
		// (get) Token: 0x0601A69B RID: 108187 RVA: 0x003C576C File Offset: 0x003C396C
		public int ExploratoryDegree
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007CC0 RID: 31936
		// (get) Token: 0x0601A69C RID: 108188 RVA: 0x003C57AC File Offset: 0x003C39AC
		public ILevelPlayExploratoryConfig? ExploratoryConfig
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return null;
				}
				return new ILevelPlayExploratoryConfig?(default(ILevelPlayExploratoryConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601A69D RID: 108189 RVA: 0x003C580C File Offset: 0x003C3A0C
		public int ReferenceAllEntity(int j)
		{
			int num = this.__p.__offset(86);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007CC1 RID: 31937
		// (get) Token: 0x0601A69E RID: 108190 RVA: 0x003C584C File Offset: 0x003C3A4C
		public int ReferenceAllEntityLength
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601A69F RID: 108191 RVA: 0x003C5878 File Offset: 0x003C3A78
		public Span<int> GetReferenceAllEntityBytes()
		{
			return this.__p.__vector_as_span<int>(86, 4);
		}

		// Token: 0x0601A6A0 RID: 108192 RVA: 0x003C5888 File Offset: 0x003C3A88
		public int[] GetReferenceAllEntityArray()
		{
			return this.__p.__vector_as_array<int>(86);
		}

		// Token: 0x17007CC2 RID: 31938
		// (get) Token: 0x0601A6A1 RID: 108193 RVA: 0x003C5898 File Offset: 0x003C3A98
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

		// Token: 0x17007CC3 RID: 31939
		// (get) Token: 0x0601A6A2 RID: 108194 RVA: 0x003C58F8 File Offset: 0x003C3AF8
		public ILevelPlayFixProcessor? FixProcessor
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return null;
				}
				return new ILevelPlayFixProcessor?(default(ILevelPlayFixProcessor).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007CC4 RID: 31940
		// (get) Token: 0x0601A6A3 RID: 108195 RVA: 0x003C5958 File Offset: 0x003C3B58
		public int CustomIcon
		{
			get
			{
				int num = this.__p.__offset(92);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007CC5 RID: 31941
		// (get) Token: 0x0601A6A4 RID: 108196 RVA: 0x003C5998 File Offset: 0x003C3B98
		public int CustomTrackUiIcon
		{
			get
			{
				int num = this.__p.__offset(94);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007CC6 RID: 31942
		// (get) Token: 0x0601A6A5 RID: 108197 RVA: 0x003C59D8 File Offset: 0x003C3BD8
		public IRangeAbsorbPhantom? RangeAbsorbPhantom
		{
			get
			{
				int num = this.__p.__offset(96);
				if (num == 0)
				{
					return null;
				}
				return new IRangeAbsorbPhantom?(default(IRangeAbsorbPhantom).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007CC7 RID: 31943
		// (get) Token: 0x0601A6A6 RID: 108198 RVA: 0x003C5A38 File Offset: 0x003C3C38
		public IRewardConfig? RewardConfig
		{
			get
			{
				int num = this.__p.__offset(98);
				if (num == 0)
				{
					return null;
				}
				return new IRewardConfig?(default(IRewardConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007CC8 RID: 31944
		// (get) Token: 0x0601A6A7 RID: 108199 RVA: 0x003C5A98 File Offset: 0x003C3C98
		public bool IsTrackOnlyWhenQuestBind
		{
			get
			{
				int num = this.__p.__offset(100);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007CC9 RID: 31945
		// (get) Token: 0x0601A6A8 RID: 108200 RVA: 0x003C5AD8 File Offset: 0x003C3CD8
		public ILevelPlayRecallConfig? RecallConfig
		{
			get
			{
				int num = this.__p.__offset(102);
				if (num == 0)
				{
					return null;
				}
				return new ILevelPlayRecallConfig?(default(ILevelPlayRecallConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007CCA RID: 31946
		// (get) Token: 0x0601A6A9 RID: 108201 RVA: 0x003C5B38 File Offset: 0x003C3D38
		public IEntityRefSearchProp? _EntityRefSearch
		{
			get
			{
				int num = this.__p.__offset(104);
				if (num == 0)
				{
					return null;
				}
				return new IEntityRefSearchProp?(default(IEntityRefSearchProp).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601A6AA RID: 108202 RVA: 0x003C5B98 File Offset: 0x003C3D98
		public string _HighlightDataPaths(int j)
		{
			int num = this.__p.__offset(106);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007CCB RID: 31947
		// (get) Token: 0x0601A6AB RID: 108203 RVA: 0x003C5BD4 File Offset: 0x003C3DD4
		public int _HighlightDataPathsLength
		{
			get
			{
				int num = this.__p.__offset(106);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17007CCC RID: 31948
		// (get) Token: 0x0601A6AC RID: 108204 RVA: 0x003C5C00 File Offset: 0x003C3E00
		public string _FocusDataPath
		{
			get
			{
				int num = this.__p.__offset(108);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A6AD RID: 108205 RVA: 0x003C5C38 File Offset: 0x003C3E38
		public Span<byte> Get_FocusDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(108, 1);
		}

		// Token: 0x0601A6AE RID: 108206 RVA: 0x003C5C48 File Offset: 0x003C3E48
		public byte[] Get_FocusDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(108);
		}

		// Token: 0x17007CCD RID: 31949
		// (get) Token: 0x0601A6AF RID: 108207 RVA: 0x003C5C58 File Offset: 0x003C3E58
		public uint NullMask
		{
			get
			{
				int num = this.__p.__offset(110);
				if (num == 0)
				{
					return 0U;
				}
				return this.__p.bb.GetUint(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A6B0 RID: 108208 RVA: 0x003C5C98 File Offset: 0x003C3E98
		public static Offset<ILevelPlay> CreateILevelPlay(FlatBufferBuilder builder, StringOffset ObjTypeOffset = default(StringOffset), VectorOffset ChildrenOffset = default(VectorOffset), VectorOffset ReferenceOffset = default(VectorOffset), VectorOffset WeakReferenceOffset = default(VectorOffset), int Id = 0, StringOffset KeyOffset = default(StringOffset), ELevelPlayType Type = ELevelPlayType.SilentArea, EDecisionBtType DecisionBtType = EDecisionBtType.Bvb, VectorOffset BindSystemsOffset = default(VectorOffset), StringOffset TidNameOffset = default(StringOffset), int LevelId = 0, int PackId = 0, int InstanceId = 0, bool IsOnlineStandalone = false, VectorOffset SpecifiedOnlineStandaloneParentUidsOffset = default(VectorOffset), ELevelPlayOnlineType OnlineType = ELevelPlayOnlineType.Local, StringOffset InternalDestOffset = default(StringOffset), int LevelAdditiveId = 0, int LevelAiTeamLevelId = 0, Offset<ILevelPlayZaxis> LevelPlayZaxisOffset = default(Offset<ILevelPlayZaxis>), int LevelPlayEntityId = 0, int EnterRadius = 0, int LeaveRadius = 0, bool DelayRefresh = false, bool DelayDestroy = false, bool NotAllowHidedByGroup = false, bool AutoRestoreTreeAddedPlayerBuff = false, VectorOffset EnterInRangeActionsOffset = default(VectorOffset), VectorOffset LevelPlayCloseActionsOffset = default(VectorOffset), Offset<ILevelPlayMark> LevelPlayMarkOffset = default(Offset<ILevelPlayMark>), Offset<ILevelPlayTrack> LevelPlayTrackOffset = default(Offset<ILevelPlayTrack>), TLevelPlayReward LevelPlayRewardConfig_type = TLevelPlayReward.NONE, int LevelPlayRewardConfigOffset = 0, TLevelPlayRefresh LevelPlayRefreshConfig_type = TLevelPlayRefresh.NONE, int LevelPlayRefreshConfigOffset = 0, Offset<ILevelPlayOpenCondition> LevelPlayOpenConditionOffset = default(Offset<ILevelPlayOpenCondition>), Offset<ILevelPlayActive> LevelPlayActiveOffset = default(Offset<ILevelPlayActive>), VectorOffset LevelPlayOpenActionsOffset = default(VectorOffset), VectorOffset EscActionsAfterDungeonCompletionOffset = default(VectorOffset), int ExploratoryDegree = 0, Offset<ILevelPlayExploratoryConfig> ExploratoryConfigOffset = default(Offset<ILevelPlayExploratoryConfig>), VectorOffset ReferenceAllEntityOffset = default(VectorOffset), Offset<IBehaviorTree> TreeOffset = default(Offset<IBehaviorTree>), Offset<ILevelPlayFixProcessor> FixProcessorOffset = default(Offset<ILevelPlayFixProcessor>), int CustomIcon = 0, int CustomTrackUiIcon = 0, Offset<IRangeAbsorbPhantom> RangeAbsorbPhantomOffset = default(Offset<IRangeAbsorbPhantom>), Offset<IRewardConfig> RewardConfigOffset = default(Offset<IRewardConfig>), bool IsTrackOnlyWhenQuestBind = false, Offset<ILevelPlayRecallConfig> RecallConfigOffset = default(Offset<ILevelPlayRecallConfig>), Offset<IEntityRefSearchProp> _entityRefSearchOffset = default(Offset<IEntityRefSearchProp>), VectorOffset _highlightDataPathsOffset = default(VectorOffset), StringOffset _focusDataPathOffset = default(StringOffset), uint NullMask = 0U)
		{
			builder.StartTable(54);
			ILevelPlay.AddNullMask(builder, NullMask);
			ILevelPlay.Add_FocusDataPath(builder, _focusDataPathOffset);
			ILevelPlay.Add_HighlightDataPaths(builder, _highlightDataPathsOffset);
			ILevelPlay.Add_EntityRefSearch(builder, _entityRefSearchOffset);
			ILevelPlay.AddRecallConfig(builder, RecallConfigOffset);
			ILevelPlay.AddRewardConfig(builder, RewardConfigOffset);
			ILevelPlay.AddRangeAbsorbPhantom(builder, RangeAbsorbPhantomOffset);
			ILevelPlay.AddCustomTrackUiIcon(builder, CustomTrackUiIcon);
			ILevelPlay.AddCustomIcon(builder, CustomIcon);
			ILevelPlay.AddFixProcessor(builder, FixProcessorOffset);
			ILevelPlay.AddTree(builder, TreeOffset);
			ILevelPlay.AddReferenceAllEntity(builder, ReferenceAllEntityOffset);
			ILevelPlay.AddExploratoryConfig(builder, ExploratoryConfigOffset);
			ILevelPlay.AddExploratoryDegree(builder, ExploratoryDegree);
			ILevelPlay.AddEscActionsAfterDungeonCompletion(builder, EscActionsAfterDungeonCompletionOffset);
			ILevelPlay.AddLevelPlayOpenActions(builder, LevelPlayOpenActionsOffset);
			ILevelPlay.AddLevelPlayActive(builder, LevelPlayActiveOffset);
			ILevelPlay.AddLevelPlayOpenCondition(builder, LevelPlayOpenConditionOffset);
			ILevelPlay.AddLevelPlayRefreshConfig(builder, LevelPlayRefreshConfigOffset);
			ILevelPlay.AddLevelPlayRewardConfig(builder, LevelPlayRewardConfigOffset);
			ILevelPlay.AddLevelPlayTrack(builder, LevelPlayTrackOffset);
			ILevelPlay.AddLevelPlayMark(builder, LevelPlayMarkOffset);
			ILevelPlay.AddLevelPlayCloseActions(builder, LevelPlayCloseActionsOffset);
			ILevelPlay.AddEnterInRangeActions(builder, EnterInRangeActionsOffset);
			ILevelPlay.AddLeaveRadius(builder, LeaveRadius);
			ILevelPlay.AddEnterRadius(builder, EnterRadius);
			ILevelPlay.AddLevelPlayEntityId(builder, LevelPlayEntityId);
			ILevelPlay.AddLevelPlayZaxis(builder, LevelPlayZaxisOffset);
			ILevelPlay.AddLevelAiTeamLevelId(builder, LevelAiTeamLevelId);
			ILevelPlay.AddLevelAdditiveId(builder, LevelAdditiveId);
			ILevelPlay.AddInternalDest(builder, InternalDestOffset);
			ILevelPlay.AddSpecifiedOnlineStandaloneParentUids(builder, SpecifiedOnlineStandaloneParentUidsOffset);
			ILevelPlay.AddInstanceId(builder, InstanceId);
			ILevelPlay.AddPackId(builder, PackId);
			ILevelPlay.AddLevelId(builder, LevelId);
			ILevelPlay.AddTidName(builder, TidNameOffset);
			ILevelPlay.AddBindSystems(builder, BindSystemsOffset);
			ILevelPlay.AddKey(builder, KeyOffset);
			ILevelPlay.AddId(builder, Id);
			ILevelPlay.AddWeakReference(builder, WeakReferenceOffset);
			ILevelPlay.AddReference(builder, ReferenceOffset);
			ILevelPlay.AddChildren(builder, ChildrenOffset);
			ILevelPlay.AddObjType(builder, ObjTypeOffset);
			ILevelPlay.AddIsTrackOnlyWhenQuestBind(builder, IsTrackOnlyWhenQuestBind);
			ILevelPlay.AddLevelPlayRefreshConfigType(builder, LevelPlayRefreshConfig_type);
			ILevelPlay.AddLevelPlayRewardConfigType(builder, LevelPlayRewardConfig_type);
			ILevelPlay.AddAutoRestoreTreeAddedPlayerBuff(builder, AutoRestoreTreeAddedPlayerBuff);
			ILevelPlay.AddNotAllowHidedByGroup(builder, NotAllowHidedByGroup);
			ILevelPlay.AddDelayDestroy(builder, DelayDestroy);
			ILevelPlay.AddDelayRefresh(builder, DelayRefresh);
			ILevelPlay.AddOnlineType(builder, OnlineType);
			ILevelPlay.AddIsOnlineStandalone(builder, IsOnlineStandalone);
			ILevelPlay.AddDecisionBtType(builder, DecisionBtType);
			ILevelPlay.AddType(builder, Type);
			return ILevelPlay.EndILevelPlay(builder);
		}

		// Token: 0x0601A6B1 RID: 108209 RVA: 0x003C5E60 File Offset: 0x003C4060
		public static void StartILevelPlay(FlatBufferBuilder builder)
		{
			builder.StartTable(54);
		}

		// Token: 0x0601A6B2 RID: 108210 RVA: 0x003C5E6A File Offset: 0x003C406A
		public static void AddObjType(FlatBufferBuilder builder, StringOffset objTypeOffset)
		{
			builder.AddOffset(0, objTypeOffset.Value, 0);
		}

		// Token: 0x0601A6B3 RID: 108211 RVA: 0x003C5E7A File Offset: 0x003C407A
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(1, childrenOffset.Value, 0);
		}

		// Token: 0x0601A6B4 RID: 108212 RVA: 0x003C5E8C File Offset: 0x003C408C
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A6B5 RID: 108213 RVA: 0x003C5ECC File Offset: 0x003C40CC
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A6B6 RID: 108214 RVA: 0x003C5EE6 File Offset: 0x003C40E6
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A6B7 RID: 108215 RVA: 0x003C5F04 File Offset: 0x003C4104
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A6B8 RID: 108216 RVA: 0x003C5F1D File Offset: 0x003C411D
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A6B9 RID: 108217 RVA: 0x003C5F28 File Offset: 0x003C4128
		public static void AddReference(FlatBufferBuilder builder, VectorOffset referenceOffset)
		{
			builder.AddOffset(2, referenceOffset.Value, 0);
		}

		// Token: 0x0601A6BA RID: 108218 RVA: 0x003C5F38 File Offset: 0x003C4138
		public static VectorOffset CreateReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A6BB RID: 108219 RVA: 0x003C5F78 File Offset: 0x003C4178
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A6BC RID: 108220 RVA: 0x003C5F92 File Offset: 0x003C4192
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A6BD RID: 108221 RVA: 0x003C5FB0 File Offset: 0x003C41B0
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A6BE RID: 108222 RVA: 0x003C5FC9 File Offset: 0x003C41C9
		public static void StartReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A6BF RID: 108223 RVA: 0x003C5FD4 File Offset: 0x003C41D4
		public static void AddWeakReference(FlatBufferBuilder builder, VectorOffset weakReferenceOffset)
		{
			builder.AddOffset(3, weakReferenceOffset.Value, 0);
		}

		// Token: 0x0601A6C0 RID: 108224 RVA: 0x003C5FE4 File Offset: 0x003C41E4
		public static VectorOffset CreateWeakReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A6C1 RID: 108225 RVA: 0x003C6024 File Offset: 0x003C4224
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A6C2 RID: 108226 RVA: 0x003C603E File Offset: 0x003C423E
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A6C3 RID: 108227 RVA: 0x003C605C File Offset: 0x003C425C
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A6C4 RID: 108228 RVA: 0x003C6075 File Offset: 0x003C4275
		public static void StartWeakReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A6C5 RID: 108229 RVA: 0x003C6080 File Offset: 0x003C4280
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(4, id, 0);
		}

		// Token: 0x0601A6C6 RID: 108230 RVA: 0x003C608B File Offset: 0x003C428B
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(5, keyOffset.Value, 0);
		}

		// Token: 0x0601A6C7 RID: 108231 RVA: 0x003C609B File Offset: 0x003C429B
		public static void AddType(FlatBufferBuilder builder, ELevelPlayType type)
		{
			builder.AddByte(6, (byte)type, 0);
		}

		// Token: 0x0601A6C8 RID: 108232 RVA: 0x003C60A6 File Offset: 0x003C42A6
		public static void AddDecisionBtType(FlatBufferBuilder builder, EDecisionBtType decisionBtType)
		{
			builder.AddByte(7, (byte)decisionBtType, 0);
		}

		// Token: 0x0601A6C9 RID: 108233 RVA: 0x003C60B1 File Offset: 0x003C42B1
		public static void AddBindSystems(FlatBufferBuilder builder, VectorOffset bindSystemsOffset)
		{
			builder.AddOffset(8, bindSystemsOffset.Value, 0);
		}

		// Token: 0x0601A6CA RID: 108234 RVA: 0x003C60C4 File Offset: 0x003C42C4
		public static VectorOffset CreateBindSystemsVector(FlatBufferBuilder builder, ESystemModuleName[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A6CB RID: 108235 RVA: 0x003C60FB File Offset: 0x003C42FB
		public static VectorOffset CreateBindSystemsVectorBlock(FlatBufferBuilder builder, ESystemModuleName[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<ESystemModuleName>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A6CC RID: 108236 RVA: 0x003C6115 File Offset: 0x003C4315
		public static VectorOffset CreateBindSystemsVectorBlock(FlatBufferBuilder builder, ArraySegment<ESystemModuleName> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<ESystemModuleName>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A6CD RID: 108237 RVA: 0x003C6133 File Offset: 0x003C4333
		public static VectorOffset CreateBindSystemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<ESystemModuleName>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A6CE RID: 108238 RVA: 0x003C614C File Offset: 0x003C434C
		public static void StartBindSystemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601A6CF RID: 108239 RVA: 0x003C6157 File Offset: 0x003C4357
		public static void AddTidName(FlatBufferBuilder builder, StringOffset tidNameOffset)
		{
			builder.AddOffset(9, tidNameOffset.Value, 0);
		}

		// Token: 0x0601A6D0 RID: 108240 RVA: 0x003C6168 File Offset: 0x003C4368
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(10, levelId, 0);
		}

		// Token: 0x0601A6D1 RID: 108241 RVA: 0x003C6174 File Offset: 0x003C4374
		public static void AddPackId(FlatBufferBuilder builder, int packId)
		{
			builder.AddInt(11, packId, 0);
		}

		// Token: 0x0601A6D2 RID: 108242 RVA: 0x003C6180 File Offset: 0x003C4380
		public static void AddInstanceId(FlatBufferBuilder builder, int instanceId)
		{
			builder.AddInt(12, instanceId, 0);
		}

		// Token: 0x0601A6D3 RID: 108243 RVA: 0x003C618C File Offset: 0x003C438C
		public static void AddIsOnlineStandalone(FlatBufferBuilder builder, bool isOnlineStandalone)
		{
			builder.AddBool(13, isOnlineStandalone, false);
		}

		// Token: 0x0601A6D4 RID: 108244 RVA: 0x003C6198 File Offset: 0x003C4398
		public static void AddSpecifiedOnlineStandaloneParentUids(FlatBufferBuilder builder, VectorOffset specifiedOnlineStandaloneParentUidsOffset)
		{
			builder.AddOffset(14, specifiedOnlineStandaloneParentUidsOffset.Value, 0);
		}

		// Token: 0x0601A6D5 RID: 108245 RVA: 0x003C61AC File Offset: 0x003C43AC
		public static VectorOffset CreateSpecifiedOnlineStandaloneParentUidsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A6D6 RID: 108246 RVA: 0x003C61EC File Offset: 0x003C43EC
		public static VectorOffset CreateSpecifiedOnlineStandaloneParentUidsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A6D7 RID: 108247 RVA: 0x003C6206 File Offset: 0x003C4406
		public static VectorOffset CreateSpecifiedOnlineStandaloneParentUidsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A6D8 RID: 108248 RVA: 0x003C6224 File Offset: 0x003C4424
		public static VectorOffset CreateSpecifiedOnlineStandaloneParentUidsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A6D9 RID: 108249 RVA: 0x003C623D File Offset: 0x003C443D
		public static void StartSpecifiedOnlineStandaloneParentUidsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A6DA RID: 108250 RVA: 0x003C6248 File Offset: 0x003C4448
		public static void AddOnlineType(FlatBufferBuilder builder, ELevelPlayOnlineType onlineType)
		{
			builder.AddByte(15, (byte)onlineType, 0);
		}

		// Token: 0x0601A6DB RID: 108251 RVA: 0x003C6254 File Offset: 0x003C4454
		public static void AddInternalDest(FlatBufferBuilder builder, StringOffset internalDestOffset)
		{
			builder.AddOffset(16, internalDestOffset.Value, 0);
		}

		// Token: 0x0601A6DC RID: 108252 RVA: 0x003C6265 File Offset: 0x003C4465
		public static void AddLevelAdditiveId(FlatBufferBuilder builder, int levelAdditiveId)
		{
			builder.AddInt(17, levelAdditiveId, 0);
		}

		// Token: 0x0601A6DD RID: 108253 RVA: 0x003C6271 File Offset: 0x003C4471
		public static void AddLevelAiTeamLevelId(FlatBufferBuilder builder, int levelAiTeamLevelId)
		{
			builder.AddInt(18, levelAiTeamLevelId, 0);
		}

		// Token: 0x0601A6DE RID: 108254 RVA: 0x003C627D File Offset: 0x003C447D
		public static void AddLevelPlayZaxis(FlatBufferBuilder builder, Offset<ILevelPlayZaxis> levelPlayZaxisOffset)
		{
			builder.AddOffset(19, levelPlayZaxisOffset.Value, 0);
		}

		// Token: 0x0601A6DF RID: 108255 RVA: 0x003C628E File Offset: 0x003C448E
		public static void AddLevelPlayEntityId(FlatBufferBuilder builder, int levelPlayEntityId)
		{
			builder.AddInt(20, levelPlayEntityId, 0);
		}

		// Token: 0x0601A6E0 RID: 108256 RVA: 0x003C629A File Offset: 0x003C449A
		public static void AddEnterRadius(FlatBufferBuilder builder, int enterRadius)
		{
			builder.AddInt(21, enterRadius, 0);
		}

		// Token: 0x0601A6E1 RID: 108257 RVA: 0x003C62A6 File Offset: 0x003C44A6
		public static void AddLeaveRadius(FlatBufferBuilder builder, int leaveRadius)
		{
			builder.AddInt(22, leaveRadius, 0);
		}

		// Token: 0x0601A6E2 RID: 108258 RVA: 0x003C62B2 File Offset: 0x003C44B2
		public static void AddDelayRefresh(FlatBufferBuilder builder, bool delayRefresh)
		{
			builder.AddBool(23, delayRefresh, false);
		}

		// Token: 0x0601A6E3 RID: 108259 RVA: 0x003C62BE File Offset: 0x003C44BE
		public static void AddDelayDestroy(FlatBufferBuilder builder, bool delayDestroy)
		{
			builder.AddBool(24, delayDestroy, false);
		}

		// Token: 0x0601A6E4 RID: 108260 RVA: 0x003C62CA File Offset: 0x003C44CA
		public static void AddNotAllowHidedByGroup(FlatBufferBuilder builder, bool notAllowHidedByGroup)
		{
			builder.AddBool(25, notAllowHidedByGroup, false);
		}

		// Token: 0x0601A6E5 RID: 108261 RVA: 0x003C62D6 File Offset: 0x003C44D6
		public static void AddAutoRestoreTreeAddedPlayerBuff(FlatBufferBuilder builder, bool autoRestoreTreeAddedPlayerBuff)
		{
			builder.AddBool(26, autoRestoreTreeAddedPlayerBuff, false);
		}

		// Token: 0x0601A6E6 RID: 108262 RVA: 0x003C62E2 File Offset: 0x003C44E2
		public static void AddEnterInRangeActions(FlatBufferBuilder builder, VectorOffset enterInRangeActionsOffset)
		{
			builder.AddOffset(27, enterInRangeActionsOffset.Value, 0);
		}

		// Token: 0x0601A6E7 RID: 108263 RVA: 0x003C62F4 File Offset: 0x003C44F4
		public static VectorOffset CreateEnterInRangeActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A6E8 RID: 108264 RVA: 0x003C6334 File Offset: 0x003C4534
		public static VectorOffset CreateEnterInRangeActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A6E9 RID: 108265 RVA: 0x003C634E File Offset: 0x003C454E
		public static VectorOffset CreateEnterInRangeActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A6EA RID: 108266 RVA: 0x003C636C File Offset: 0x003C456C
		public static VectorOffset CreateEnterInRangeActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A6EB RID: 108267 RVA: 0x003C6385 File Offset: 0x003C4585
		public static void StartEnterInRangeActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A6EC RID: 108268 RVA: 0x003C6390 File Offset: 0x003C4590
		public static void AddLevelPlayCloseActions(FlatBufferBuilder builder, VectorOffset levelPlayCloseActionsOffset)
		{
			builder.AddOffset(28, levelPlayCloseActionsOffset.Value, 0);
		}

		// Token: 0x0601A6ED RID: 108269 RVA: 0x003C63A4 File Offset: 0x003C45A4
		public static VectorOffset CreateLevelPlayCloseActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A6EE RID: 108270 RVA: 0x003C63E4 File Offset: 0x003C45E4
		public static VectorOffset CreateLevelPlayCloseActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A6EF RID: 108271 RVA: 0x003C63FE File Offset: 0x003C45FE
		public static VectorOffset CreateLevelPlayCloseActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A6F0 RID: 108272 RVA: 0x003C641C File Offset: 0x003C461C
		public static VectorOffset CreateLevelPlayCloseActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A6F1 RID: 108273 RVA: 0x003C6435 File Offset: 0x003C4635
		public static void StartLevelPlayCloseActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A6F2 RID: 108274 RVA: 0x003C6440 File Offset: 0x003C4640
		public static void AddLevelPlayMark(FlatBufferBuilder builder, Offset<ILevelPlayMark> levelPlayMarkOffset)
		{
			builder.AddOffset(29, levelPlayMarkOffset.Value, 0);
		}

		// Token: 0x0601A6F3 RID: 108275 RVA: 0x003C6451 File Offset: 0x003C4651
		public static void AddLevelPlayTrack(FlatBufferBuilder builder, Offset<ILevelPlayTrack> levelPlayTrackOffset)
		{
			builder.AddOffset(30, levelPlayTrackOffset.Value, 0);
		}

		// Token: 0x0601A6F4 RID: 108276 RVA: 0x003C6462 File Offset: 0x003C4662
		public static void AddLevelPlayRewardConfigType(FlatBufferBuilder builder, TLevelPlayReward levelPlayRewardConfigType)
		{
			builder.AddByte(31, (byte)levelPlayRewardConfigType, 0);
		}

		// Token: 0x0601A6F5 RID: 108277 RVA: 0x003C646E File Offset: 0x003C466E
		public static void AddLevelPlayRewardConfig(FlatBufferBuilder builder, int levelPlayRewardConfigOffset)
		{
			builder.AddOffset(32, levelPlayRewardConfigOffset, 0);
		}

		// Token: 0x0601A6F6 RID: 108278 RVA: 0x003C647A File Offset: 0x003C467A
		public static void AddLevelPlayRefreshConfigType(FlatBufferBuilder builder, TLevelPlayRefresh levelPlayRefreshConfigType)
		{
			builder.AddByte(33, (byte)levelPlayRefreshConfigType, 0);
		}

		// Token: 0x0601A6F7 RID: 108279 RVA: 0x003C6486 File Offset: 0x003C4686
		public static void AddLevelPlayRefreshConfig(FlatBufferBuilder builder, int levelPlayRefreshConfigOffset)
		{
			builder.AddOffset(34, levelPlayRefreshConfigOffset, 0);
		}

		// Token: 0x0601A6F8 RID: 108280 RVA: 0x003C6492 File Offset: 0x003C4692
		public static void AddLevelPlayOpenCondition(FlatBufferBuilder builder, Offset<ILevelPlayOpenCondition> levelPlayOpenConditionOffset)
		{
			builder.AddOffset(35, levelPlayOpenConditionOffset.Value, 0);
		}

		// Token: 0x0601A6F9 RID: 108281 RVA: 0x003C64A3 File Offset: 0x003C46A3
		public static void AddLevelPlayActive(FlatBufferBuilder builder, Offset<ILevelPlayActive> levelPlayActiveOffset)
		{
			builder.AddOffset(36, levelPlayActiveOffset.Value, 0);
		}

		// Token: 0x0601A6FA RID: 108282 RVA: 0x003C64B4 File Offset: 0x003C46B4
		public static void AddLevelPlayOpenActions(FlatBufferBuilder builder, VectorOffset levelPlayOpenActionsOffset)
		{
			builder.AddOffset(37, levelPlayOpenActionsOffset.Value, 0);
		}

		// Token: 0x0601A6FB RID: 108283 RVA: 0x003C64C8 File Offset: 0x003C46C8
		public static VectorOffset CreateLevelPlayOpenActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A6FC RID: 108284 RVA: 0x003C6508 File Offset: 0x003C4708
		public static VectorOffset CreateLevelPlayOpenActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A6FD RID: 108285 RVA: 0x003C6522 File Offset: 0x003C4722
		public static VectorOffset CreateLevelPlayOpenActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A6FE RID: 108286 RVA: 0x003C6540 File Offset: 0x003C4740
		public static VectorOffset CreateLevelPlayOpenActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A6FF RID: 108287 RVA: 0x003C6559 File Offset: 0x003C4759
		public static void StartLevelPlayOpenActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A700 RID: 108288 RVA: 0x003C6564 File Offset: 0x003C4764
		public static void AddEscActionsAfterDungeonCompletion(FlatBufferBuilder builder, VectorOffset escActionsAfterDungeonCompletionOffset)
		{
			builder.AddOffset(38, escActionsAfterDungeonCompletionOffset.Value, 0);
		}

		// Token: 0x0601A701 RID: 108289 RVA: 0x003C6578 File Offset: 0x003C4778
		public static VectorOffset CreateEscActionsAfterDungeonCompletionVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A702 RID: 108290 RVA: 0x003C65B8 File Offset: 0x003C47B8
		public static VectorOffset CreateEscActionsAfterDungeonCompletionVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A703 RID: 108291 RVA: 0x003C65D2 File Offset: 0x003C47D2
		public static VectorOffset CreateEscActionsAfterDungeonCompletionVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A704 RID: 108292 RVA: 0x003C65F0 File Offset: 0x003C47F0
		public static VectorOffset CreateEscActionsAfterDungeonCompletionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A705 RID: 108293 RVA: 0x003C6609 File Offset: 0x003C4809
		public static void StartEscActionsAfterDungeonCompletionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A706 RID: 108294 RVA: 0x003C6614 File Offset: 0x003C4814
		public static void AddExploratoryDegree(FlatBufferBuilder builder, int exploratoryDegree)
		{
			builder.AddInt(39, exploratoryDegree, 0);
		}

		// Token: 0x0601A707 RID: 108295 RVA: 0x003C6620 File Offset: 0x003C4820
		public static void AddExploratoryConfig(FlatBufferBuilder builder, Offset<ILevelPlayExploratoryConfig> exploratoryConfigOffset)
		{
			builder.AddOffset(40, exploratoryConfigOffset.Value, 0);
		}

		// Token: 0x0601A708 RID: 108296 RVA: 0x003C6631 File Offset: 0x003C4831
		public static void AddReferenceAllEntity(FlatBufferBuilder builder, VectorOffset referenceAllEntityOffset)
		{
			builder.AddOffset(41, referenceAllEntityOffset.Value, 0);
		}

		// Token: 0x0601A709 RID: 108297 RVA: 0x003C6644 File Offset: 0x003C4844
		public static VectorOffset CreateReferenceAllEntityVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A70A RID: 108298 RVA: 0x003C667B File Offset: 0x003C487B
		public static VectorOffset CreateReferenceAllEntityVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A70B RID: 108299 RVA: 0x003C6695 File Offset: 0x003C4895
		public static VectorOffset CreateReferenceAllEntityVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A70C RID: 108300 RVA: 0x003C66B3 File Offset: 0x003C48B3
		public static VectorOffset CreateReferenceAllEntityVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A70D RID: 108301 RVA: 0x003C66CC File Offset: 0x003C48CC
		public static void StartReferenceAllEntityVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A70E RID: 108302 RVA: 0x003C66D7 File Offset: 0x003C48D7
		public static void AddTree(FlatBufferBuilder builder, Offset<IBehaviorTree> treeOffset)
		{
			builder.AddOffset(42, treeOffset.Value, 0);
		}

		// Token: 0x0601A70F RID: 108303 RVA: 0x003C66E8 File Offset: 0x003C48E8
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<ILevelPlayFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(43, fixProcessorOffset.Value, 0);
		}

		// Token: 0x0601A710 RID: 108304 RVA: 0x003C66F9 File Offset: 0x003C48F9
		public static void AddCustomIcon(FlatBufferBuilder builder, int customIcon)
		{
			builder.AddInt(44, customIcon, 0);
		}

		// Token: 0x0601A711 RID: 108305 RVA: 0x003C6705 File Offset: 0x003C4905
		public static void AddCustomTrackUiIcon(FlatBufferBuilder builder, int customTrackUiIcon)
		{
			builder.AddInt(45, customTrackUiIcon, 0);
		}

		// Token: 0x0601A712 RID: 108306 RVA: 0x003C6711 File Offset: 0x003C4911
		public static void AddRangeAbsorbPhantom(FlatBufferBuilder builder, Offset<IRangeAbsorbPhantom> rangeAbsorbPhantomOffset)
		{
			builder.AddOffset(46, rangeAbsorbPhantomOffset.Value, 0);
		}

		// Token: 0x0601A713 RID: 108307 RVA: 0x003C6722 File Offset: 0x003C4922
		public static void AddRewardConfig(FlatBufferBuilder builder, Offset<IRewardConfig> rewardConfigOffset)
		{
			builder.AddOffset(47, rewardConfigOffset.Value, 0);
		}

		// Token: 0x0601A714 RID: 108308 RVA: 0x003C6733 File Offset: 0x003C4933
		public static void AddIsTrackOnlyWhenQuestBind(FlatBufferBuilder builder, bool isTrackOnlyWhenQuestBind)
		{
			builder.AddBool(48, isTrackOnlyWhenQuestBind, false);
		}

		// Token: 0x0601A715 RID: 108309 RVA: 0x003C673F File Offset: 0x003C493F
		public static void AddRecallConfig(FlatBufferBuilder builder, Offset<ILevelPlayRecallConfig> recallConfigOffset)
		{
			builder.AddOffset(49, recallConfigOffset.Value, 0);
		}

		// Token: 0x0601A716 RID: 108310 RVA: 0x003C6750 File Offset: 0x003C4950
		public static void Add_EntityRefSearch(FlatBufferBuilder builder, Offset<IEntityRefSearchProp> _EntityRefSearchOffset)
		{
			builder.AddOffset(50, _EntityRefSearchOffset.Value, 0);
		}

		// Token: 0x0601A717 RID: 108311 RVA: 0x003C6761 File Offset: 0x003C4961
		public static void Add_HighlightDataPaths(FlatBufferBuilder builder, VectorOffset _HighlightDataPathsOffset)
		{
			builder.AddOffset(51, _HighlightDataPathsOffset.Value, 0);
		}

		// Token: 0x0601A718 RID: 108312 RVA: 0x003C6774 File Offset: 0x003C4974
		public static VectorOffset Create_HighlightDataPathsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A719 RID: 108313 RVA: 0x003C67B4 File Offset: 0x003C49B4
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A71A RID: 108314 RVA: 0x003C67CE File Offset: 0x003C49CE
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A71B RID: 108315 RVA: 0x003C67EC File Offset: 0x003C49EC
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A71C RID: 108316 RVA: 0x003C6805 File Offset: 0x003C4A05
		public static void Start_HighlightDataPathsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A71D RID: 108317 RVA: 0x003C6810 File Offset: 0x003C4A10
		public static void Add_FocusDataPath(FlatBufferBuilder builder, StringOffset _FocusDataPathOffset)
		{
			builder.AddOffset(52, _FocusDataPathOffset.Value, 0);
		}

		// Token: 0x0601A71E RID: 108318 RVA: 0x003C6821 File Offset: 0x003C4A21
		public static void AddNullMask(FlatBufferBuilder builder, uint nullMask)
		{
			builder.AddUint(53, nullMask, 0U);
		}

		// Token: 0x0601A71F RID: 108319 RVA: 0x003C682D File Offset: 0x003C4A2D
		public static Offset<ILevelPlay> EndILevelPlay(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlay>(builder.EndTable());
		}

		// Token: 0x0601A720 RID: 108320 RVA: 0x003C683C File Offset: 0x003C4A3C
		public ILevelPlayT UnPack()
		{
			ILevelPlayT levelPlayT = new ILevelPlayT();
			this.UnPackTo(levelPlayT);
			return levelPlayT;
		}

		// Token: 0x0601A721 RID: 108321 RVA: 0x003C6858 File Offset: 0x003C4A58
		public void UnPackTo(ILevelPlayT _o)
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
			_o.Id = this.Id;
			_o.Key = this.Key;
			_o.Type = this.Type;
			_o.DecisionBtType = this.DecisionBtType;
			_o.BindSystems = new List<ESystemModuleName>();
			for (int l = 0; l < this.BindSystemsLength; l++)
			{
				_o.BindSystems.Add(this.BindSystems(l));
			}
			_o.TidName = this.TidName;
			_o.LevelId = this.LevelId;
			_o.PackId = this.PackId;
			_o.InstanceId = this.InstanceId;
			_o.IsOnlineStandalone = this.IsOnlineStandalone;
			_o.SpecifiedOnlineStandaloneParentUids = new List<string>();
			for (int m = 0; m < this.SpecifiedOnlineStandaloneParentUidsLength; m++)
			{
				_o.SpecifiedOnlineStandaloneParentUids.Add(this.SpecifiedOnlineStandaloneParentUids(m));
			}
			_o.OnlineType = this.OnlineType;
			_o.InternalDest = this.InternalDest;
			_o.LevelAdditiveId = this.LevelAdditiveId;
			_o.LevelAiTeamLevelId = this.LevelAiTeamLevelId;
			_o.LevelPlayZaxis = ((this.LevelPlayZaxis != null) ? this.LevelPlayZaxis.Value.UnPack() : null);
			_o.LevelPlayEntityId = this.LevelPlayEntityId;
			_o.EnterRadius = this.EnterRadius;
			_o.LeaveRadius = this.LeaveRadius;
			_o.DelayRefresh = this.DelayRefresh;
			_o.DelayDestroy = this.DelayDestroy;
			_o.NotAllowHidedByGroup = this.NotAllowHidedByGroup;
			_o.AutoRestoreTreeAddedPlayerBuff = this.AutoRestoreTreeAddedPlayerBuff;
			_o.EnterInRangeActions = new List<IActionInfoT>();
			for (int n = 0; n < this.EnterInRangeActionsLength; n++)
			{
				_o.EnterInRangeActions.Add((this.EnterInRangeActions(n) != null) ? this.EnterInRangeActions(n).Value.UnPack() : null);
			}
			_o.LevelPlayCloseActions = new List<IActionInfoT>();
			for (int num = 0; num < this.LevelPlayCloseActionsLength; num++)
			{
				_o.LevelPlayCloseActions.Add((this.LevelPlayCloseActions(num) != null) ? this.LevelPlayCloseActions(num).Value.UnPack() : null);
			}
			_o.LevelPlayMark = ((this.LevelPlayMark != null) ? this.LevelPlayMark.Value.UnPack() : null);
			_o.LevelPlayTrack = ((this.LevelPlayTrack != null) ? this.LevelPlayTrack.Value.UnPack() : null);
			_o.LevelPlayRewardConfig = new TLevelPlayRewardUnion();
			_o.LevelPlayRewardConfig.Type = this.LevelPlayRewardConfigType;
			switch (this.LevelPlayRewardConfigType)
			{
			case TLevelPlayReward.IAutomaticRewardParam:
				_o.LevelPlayRewardConfig.Value = ((this.LevelPlayRewardConfig<IAutomaticRewardParam>() != null) ? this.LevelPlayRewardConfig<IAutomaticRewardParam>().Value.UnPack() : null);
				break;
			case TLevelPlayReward.IInteractRewardParam:
				_o.LevelPlayRewardConfig.Value = ((this.LevelPlayRewardConfig<IInteractRewardParam>() != null) ? this.LevelPlayRewardConfig<IInteractRewardParam>().Value.UnPack() : null);
				break;
			case TLevelPlayReward.INoneRewardParam:
				_o.LevelPlayRewardConfig.Value = ((this.LevelPlayRewardConfig<INoneRewardParam>() != null) ? this.LevelPlayRewardConfig<INoneRewardParam>().Value.UnPack() : null);
				break;
			case TLevelPlayReward.IVariableRewardParam:
				_o.LevelPlayRewardConfig.Value = ((this.LevelPlayRewardConfig<IVariableRewardParam>() != null) ? this.LevelPlayRewardConfig<IVariableRewardParam>().Value.UnPack() : null);
				break;
			}
			_o.LevelPlayRefreshConfig = new TLevelPlayRefreshUnion();
			_o.LevelPlayRefreshConfig.Type = this.LevelPlayRefreshConfigType;
			switch (this.LevelPlayRefreshConfigType)
			{
			case TLevelPlayRefresh.IChildDestroyOrAwardedRefresh:
				_o.LevelPlayRefreshConfig.Value = ((this.LevelPlayRefreshConfig<IChildDestroyOrAwardedRefresh>() != null) ? this.LevelPlayRefreshConfig<IChildDestroyOrAwardedRefresh>().Value.UnPack() : null);
				break;
			case TLevelPlayRefresh.IChildDestroyRefresh:
				_o.LevelPlayRefreshConfig.Value = ((this.LevelPlayRefreshConfig<IChildDestroyRefresh>() != null) ? this.LevelPlayRefreshConfig<IChildDestroyRefresh>().Value.UnPack() : null);
				break;
			case TLevelPlayRefresh.ICompletedRefresh:
				_o.LevelPlayRefreshConfig.Value = ((this.LevelPlayRefreshConfig<ICompletedRefresh>() != null) ? this.LevelPlayRefreshConfig<ICompletedRefresh>().Value.UnPack() : null);
				break;
			case TLevelPlayRefresh.ICustomOnlineRefresh:
				_o.LevelPlayRefreshConfig.Value = ((this.LevelPlayRefreshConfig<ICustomOnlineRefresh>() != null) ? this.LevelPlayRefreshConfig<ICustomOnlineRefresh>().Value.UnPack() : null);
				break;
			case TLevelPlayRefresh.ICustomRefresh:
				_o.LevelPlayRefreshConfig.Value = ((this.LevelPlayRefreshConfig<ICustomRefresh>() != null) ? this.LevelPlayRefreshConfig<ICustomRefresh>().Value.UnPack() : null);
				break;
			case TLevelPlayRefresh.IFixedDateTimeRefresh:
				_o.LevelPlayRefreshConfig.Value = ((this.LevelPlayRefreshConfig<IFixedDateTimeRefresh>() != null) ? this.LevelPlayRefreshConfig<IFixedDateTimeRefresh>().Value.UnPack() : null);
				break;
			case TLevelPlayRefresh.INoneRefresh:
				_o.LevelPlayRefreshConfig.Value = ((this.LevelPlayRefreshConfig<INoneRefresh>() != null) ? this.LevelPlayRefreshConfig<INoneRefresh>().Value.UnPack() : null);
				break;
			}
			_o.LevelPlayOpenCondition = ((this.LevelPlayOpenCondition != null) ? this.LevelPlayOpenCondition.Value.UnPack() : null);
			_o.LevelPlayActive = ((this.LevelPlayActive != null) ? this.LevelPlayActive.Value.UnPack() : null);
			_o.LevelPlayOpenActions = new List<IActionInfoT>();
			for (int num2 = 0; num2 < this.LevelPlayOpenActionsLength; num2++)
			{
				_o.LevelPlayOpenActions.Add((this.LevelPlayOpenActions(num2) != null) ? this.LevelPlayOpenActions(num2).Value.UnPack() : null);
			}
			_o.EscActionsAfterDungeonCompletion = new List<IActionInfoT>();
			for (int num3 = 0; num3 < this.EscActionsAfterDungeonCompletionLength; num3++)
			{
				_o.EscActionsAfterDungeonCompletion.Add((this.EscActionsAfterDungeonCompletion(num3) != null) ? this.EscActionsAfterDungeonCompletion(num3).Value.UnPack() : null);
			}
			_o.ExploratoryDegree = this.ExploratoryDegree;
			_o.ExploratoryConfig = ((this.ExploratoryConfig != null) ? this.ExploratoryConfig.Value.UnPack() : null);
			_o.ReferenceAllEntity = new List<int>();
			for (int num4 = 0; num4 < this.ReferenceAllEntityLength; num4++)
			{
				_o.ReferenceAllEntity.Add(this.ReferenceAllEntity(num4));
			}
			_o.Tree = ((this.Tree != null) ? this.Tree.Value.UnPack() : null);
			_o.FixProcessor = ((this.FixProcessor != null) ? this.FixProcessor.Value.UnPack() : null);
			_o.CustomIcon = this.CustomIcon;
			_o.CustomTrackUiIcon = this.CustomTrackUiIcon;
			_o.RangeAbsorbPhantom = ((this.RangeAbsorbPhantom != null) ? this.RangeAbsorbPhantom.Value.UnPack() : null);
			_o.RewardConfig = ((this.RewardConfig != null) ? this.RewardConfig.Value.UnPack() : null);
			_o.IsTrackOnlyWhenQuestBind = this.IsTrackOnlyWhenQuestBind;
			_o.RecallConfig = ((this.RecallConfig != null) ? this.RecallConfig.Value.UnPack() : null);
			_o._EntityRefSearch = ((this._EntityRefSearch != null) ? this._EntityRefSearch.Value.UnPack() : null);
			_o._HighlightDataPaths = new List<string>();
			for (int num5 = 0; num5 < this._HighlightDataPathsLength; num5++)
			{
				_o._HighlightDataPaths.Add(this._HighlightDataPaths(num5));
			}
			_o._FocusDataPath = this._FocusDataPath;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A722 RID: 108322 RVA: 0x003C71CC File Offset: 0x003C53CC
		public static Offset<ILevelPlay> Pack(FlatBufferBuilder builder, ILevelPlayT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlay>);
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
				childrenOffset = ILevelPlay.CreateChildrenVector(builder, array);
			}
			VectorOffset referenceOffset = default(VectorOffset);
			if (_o.Reference != null)
			{
				StringOffset[] array2 = new StringOffset[_o.Reference.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = builder.CreateString(_o.Reference[j]);
				}
				referenceOffset = ILevelPlay.CreateReferenceVector(builder, array2);
			}
			VectorOffset weakReferenceOffset = default(VectorOffset);
			if (_o.WeakReference != null)
			{
				StringOffset[] array3 = new StringOffset[_o.WeakReference.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = builder.CreateString(_o.WeakReference[k]);
				}
				weakReferenceOffset = ILevelPlay.CreateWeakReferenceVector(builder, array3);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			VectorOffset bindSystemsOffset = default(VectorOffset);
			if (_o.BindSystems != null)
			{
				ESystemModuleName[] data = _o.BindSystems.ToArray();
				bindSystemsOffset = ILevelPlay.CreateBindSystemsVector(builder, data);
			}
			StringOffset tidNameOffset = (_o.TidName == null) ? default(StringOffset) : builder.CreateString(_o.TidName);
			VectorOffset specifiedOnlineStandaloneParentUidsOffset = default(VectorOffset);
			if (_o.SpecifiedOnlineStandaloneParentUids != null)
			{
				StringOffset[] array4 = new StringOffset[_o.SpecifiedOnlineStandaloneParentUids.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = builder.CreateString(_o.SpecifiedOnlineStandaloneParentUids[l]);
				}
				specifiedOnlineStandaloneParentUidsOffset = ILevelPlay.CreateSpecifiedOnlineStandaloneParentUidsVector(builder, array4);
			}
			StringOffset internalDestOffset = (_o.InternalDest == null) ? default(StringOffset) : builder.CreateString(_o.InternalDest);
			Offset<ILevelPlayZaxis> levelPlayZaxisOffset = (_o.LevelPlayZaxis == null) ? default(Offset<ILevelPlayZaxis>) : ILevelPlayZaxis.Pack(builder, _o.LevelPlayZaxis);
			VectorOffset enterInRangeActionsOffset = default(VectorOffset);
			if (_o.EnterInRangeActions != null)
			{
				Offset<IActionInfo>[] array5 = new Offset<IActionInfo>[_o.EnterInRangeActions.Count];
				for (int m = 0; m < array5.Length; m++)
				{
					array5[m] = IActionInfo.Pack(builder, _o.EnterInRangeActions[m]);
				}
				enterInRangeActionsOffset = ILevelPlay.CreateEnterInRangeActionsVector(builder, array5);
			}
			VectorOffset levelPlayCloseActionsOffset = default(VectorOffset);
			if (_o.LevelPlayCloseActions != null)
			{
				Offset<IActionInfo>[] array6 = new Offset<IActionInfo>[_o.LevelPlayCloseActions.Count];
				for (int n = 0; n < array6.Length; n++)
				{
					array6[n] = IActionInfo.Pack(builder, _o.LevelPlayCloseActions[n]);
				}
				levelPlayCloseActionsOffset = ILevelPlay.CreateLevelPlayCloseActionsVector(builder, array6);
			}
			Offset<ILevelPlayMark> levelPlayMarkOffset = (_o.LevelPlayMark == null) ? default(Offset<ILevelPlayMark>) : ILevelPlayMark.Pack(builder, _o.LevelPlayMark);
			Offset<ILevelPlayTrack> levelPlayTrackOffset = (_o.LevelPlayTrack == null) ? default(Offset<ILevelPlayTrack>) : ILevelPlayTrack.Pack(builder, _o.LevelPlayTrack);
			TLevelPlayReward levelPlayRewardConfig_type = (_o.LevelPlayRewardConfig == null) ? TLevelPlayReward.NONE : _o.LevelPlayRewardConfig.Type;
			int levelPlayRewardConfigOffset = (_o.LevelPlayRewardConfig == null) ? 0 : TLevelPlayRewardUnion.Pack(builder, _o.LevelPlayRewardConfig);
			TLevelPlayRefresh levelPlayRefreshConfig_type = (_o.LevelPlayRefreshConfig == null) ? TLevelPlayRefresh.NONE : _o.LevelPlayRefreshConfig.Type;
			int levelPlayRefreshConfigOffset = (_o.LevelPlayRefreshConfig == null) ? 0 : TLevelPlayRefreshUnion.Pack(builder, _o.LevelPlayRefreshConfig);
			Offset<ILevelPlayOpenCondition> levelPlayOpenConditionOffset = (_o.LevelPlayOpenCondition == null) ? default(Offset<ILevelPlayOpenCondition>) : ILevelPlayOpenCondition.Pack(builder, _o.LevelPlayOpenCondition);
			Offset<ILevelPlayActive> levelPlayActiveOffset = (_o.LevelPlayActive == null) ? default(Offset<ILevelPlayActive>) : ILevelPlayActive.Pack(builder, _o.LevelPlayActive);
			VectorOffset levelPlayOpenActionsOffset = default(VectorOffset);
			if (_o.LevelPlayOpenActions != null)
			{
				Offset<IActionInfo>[] array7 = new Offset<IActionInfo>[_o.LevelPlayOpenActions.Count];
				for (int num = 0; num < array7.Length; num++)
				{
					array7[num] = IActionInfo.Pack(builder, _o.LevelPlayOpenActions[num]);
				}
				levelPlayOpenActionsOffset = ILevelPlay.CreateLevelPlayOpenActionsVector(builder, array7);
			}
			VectorOffset escActionsAfterDungeonCompletionOffset = default(VectorOffset);
			if (_o.EscActionsAfterDungeonCompletion != null)
			{
				Offset<IActionInfo>[] array8 = new Offset<IActionInfo>[_o.EscActionsAfterDungeonCompletion.Count];
				for (int num2 = 0; num2 < array8.Length; num2++)
				{
					array8[num2] = IActionInfo.Pack(builder, _o.EscActionsAfterDungeonCompletion[num2]);
				}
				escActionsAfterDungeonCompletionOffset = ILevelPlay.CreateEscActionsAfterDungeonCompletionVector(builder, array8);
			}
			Offset<ILevelPlayExploratoryConfig> exploratoryConfigOffset = (_o.ExploratoryConfig == null) ? default(Offset<ILevelPlayExploratoryConfig>) : ILevelPlayExploratoryConfig.Pack(builder, _o.ExploratoryConfig);
			VectorOffset referenceAllEntityOffset = default(VectorOffset);
			if (_o.ReferenceAllEntity != null)
			{
				int[] data2 = _o.ReferenceAllEntity.ToArray();
				referenceAllEntityOffset = ILevelPlay.CreateReferenceAllEntityVector(builder, data2);
			}
			Offset<IBehaviorTree> treeOffset = (_o.Tree == null) ? default(Offset<IBehaviorTree>) : IBehaviorTree.Pack(builder, _o.Tree);
			Offset<ILevelPlayFixProcessor> fixProcessorOffset = (_o.FixProcessor == null) ? default(Offset<ILevelPlayFixProcessor>) : ILevelPlayFixProcessor.Pack(builder, _o.FixProcessor);
			Offset<IRangeAbsorbPhantom> rangeAbsorbPhantomOffset = (_o.RangeAbsorbPhantom == null) ? default(Offset<IRangeAbsorbPhantom>) : IRangeAbsorbPhantom.Pack(builder, _o.RangeAbsorbPhantom);
			Offset<IRewardConfig> rewardConfigOffset = (_o.RewardConfig == null) ? default(Offset<IRewardConfig>) : IRewardConfig.Pack(builder, _o.RewardConfig);
			Offset<ILevelPlayRecallConfig> recallConfigOffset = (_o.RecallConfig == null) ? default(Offset<ILevelPlayRecallConfig>) : ILevelPlayRecallConfig.Pack(builder, _o.RecallConfig);
			Offset<IEntityRefSearchProp> entityRefSearchOffset = (_o._EntityRefSearch == null) ? default(Offset<IEntityRefSearchProp>) : IEntityRefSearchProp.Pack(builder, _o._EntityRefSearch);
			VectorOffset highlightDataPathsOffset = default(VectorOffset);
			if (_o._HighlightDataPaths != null)
			{
				StringOffset[] array9 = new StringOffset[_o._HighlightDataPaths.Count];
				for (int num3 = 0; num3 < array9.Length; num3++)
				{
					array9[num3] = builder.CreateString(_o._HighlightDataPaths[num3]);
				}
				highlightDataPathsOffset = ILevelPlay.Create_HighlightDataPathsVector(builder, array9);
			}
			StringOffset focusDataPathOffset = (_o._FocusDataPath == null) ? default(StringOffset) : builder.CreateString(_o._FocusDataPath);
			return ILevelPlay.CreateILevelPlay(builder, objTypeOffset, childrenOffset, referenceOffset, weakReferenceOffset, _o.Id, keyOffset, _o.Type, _o.DecisionBtType, bindSystemsOffset, tidNameOffset, _o.LevelId, _o.PackId, _o.InstanceId, _o.IsOnlineStandalone, specifiedOnlineStandaloneParentUidsOffset, _o.OnlineType, internalDestOffset, _o.LevelAdditiveId, _o.LevelAiTeamLevelId, levelPlayZaxisOffset, _o.LevelPlayEntityId, _o.EnterRadius, _o.LeaveRadius, _o.DelayRefresh, _o.DelayDestroy, _o.NotAllowHidedByGroup, _o.AutoRestoreTreeAddedPlayerBuff, enterInRangeActionsOffset, levelPlayCloseActionsOffset, levelPlayMarkOffset, levelPlayTrackOffset, levelPlayRewardConfig_type, levelPlayRewardConfigOffset, levelPlayRefreshConfig_type, levelPlayRefreshConfigOffset, levelPlayOpenConditionOffset, levelPlayActiveOffset, levelPlayOpenActionsOffset, escActionsAfterDungeonCompletionOffset, _o.ExploratoryDegree, exploratoryConfigOffset, referenceAllEntityOffset, treeOffset, fixProcessorOffset, _o.CustomIcon, _o.CustomTrackUiIcon, rangeAbsorbPhantomOffset, rewardConfigOffset, _o.IsTrackOnlyWhenQuestBind, recallConfigOffset, entityRefSearchOffset, highlightDataPathsOffset, focusDataPathOffset, _o.NullMask);
		}

		// Token: 0x0400C50D RID: 50445
		private Table __p;
	}
}
