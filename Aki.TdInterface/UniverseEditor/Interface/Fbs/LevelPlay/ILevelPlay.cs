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
	// Token: 0x02004950 RID: 18768
	public struct ILevelPlay : IFlatbufferObject
	{
		// Token: 0x170082D8 RID: 33496
		// (get) Token: 0x0601BE21 RID: 114209 RVA: 0x003F0A83 File Offset: 0x003EEC83
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BE22 RID: 114210 RVA: 0x003F0A90 File Offset: 0x003EEC90
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BE23 RID: 114211 RVA: 0x003F0A98 File Offset: 0x003EEC98
		public static ILevelPlay GetRootAsILevelPlay(ByteBuffer _bb)
		{
			return ILevelPlay.GetRootAsILevelPlay(_bb, default(ILevelPlay));
		}

		// Token: 0x0601BE24 RID: 114212 RVA: 0x003F0AB4 File Offset: 0x003EECB4
		public static ILevelPlay GetRootAsILevelPlay(ByteBuffer _bb, ILevelPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BE25 RID: 114213 RVA: 0x003F0AD1 File Offset: 0x003EECD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BE26 RID: 114214 RVA: 0x003F0AE0 File Offset: 0x003EECE0
		public ILevelPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170082D9 RID: 33497
		// (get) Token: 0x0601BE27 RID: 114215 RVA: 0x003F0AF0 File Offset: 0x003EECF0
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

		// Token: 0x0601BE28 RID: 114216 RVA: 0x003F0B27 File Offset: 0x003EED27
		public Span<byte> GetObjTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601BE29 RID: 114217 RVA: 0x003F0B36 File Offset: 0x003EED36
		public byte[] GetObjTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601BE2A RID: 114218 RVA: 0x003F0B44 File Offset: 0x003EED44
		public string Children(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170082DA RID: 33498
		// (get) Token: 0x0601BE2B RID: 114219 RVA: 0x003F0B80 File Offset: 0x003EED80
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

		// Token: 0x0601BE2C RID: 114220 RVA: 0x003F0BAC File Offset: 0x003EEDAC
		public string Reference(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170082DB RID: 33499
		// (get) Token: 0x0601BE2D RID: 114221 RVA: 0x003F0BE8 File Offset: 0x003EEDE8
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

		// Token: 0x0601BE2E RID: 114222 RVA: 0x003F0C14 File Offset: 0x003EEE14
		public string WeakReference(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170082DC RID: 33500
		// (get) Token: 0x0601BE2F RID: 114223 RVA: 0x003F0C50 File Offset: 0x003EEE50
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

		// Token: 0x170082DD RID: 33501
		// (get) Token: 0x0601BE30 RID: 114224 RVA: 0x003F0C7C File Offset: 0x003EEE7C
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

		// Token: 0x170082DE RID: 33502
		// (get) Token: 0x0601BE31 RID: 114225 RVA: 0x003F0CBC File Offset: 0x003EEEBC
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

		// Token: 0x0601BE32 RID: 114226 RVA: 0x003F0CF4 File Offset: 0x003EEEF4
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0601BE33 RID: 114227 RVA: 0x003F0D04 File Offset: 0x003EEF04
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x170082DF RID: 33503
		// (get) Token: 0x0601BE34 RID: 114228 RVA: 0x003F0D14 File Offset: 0x003EEF14
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

		// Token: 0x170082E0 RID: 33504
		// (get) Token: 0x0601BE35 RID: 114229 RVA: 0x003F0D54 File Offset: 0x003EEF54
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

		// Token: 0x170082E1 RID: 33505
		// (get) Token: 0x0601BE36 RID: 114230 RVA: 0x003F0D94 File Offset: 0x003EEF94
		public int PrefabId
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

		// Token: 0x0601BE37 RID: 114231 RVA: 0x003F0DD4 File Offset: 0x003EEFD4
		public ESystemModuleName BindSystems(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return ESystemModuleName.Common;
			}
			return (ESystemModuleName)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170082E2 RID: 33506
		// (get) Token: 0x0601BE38 RID: 114232 RVA: 0x003F0E14 File Offset: 0x003EF014
		public int BindSystemsLength
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

		// Token: 0x0601BE39 RID: 114233 RVA: 0x003F0E40 File Offset: 0x003EF040
		public Span<ESystemModuleName> GetBindSystemsBytes()
		{
			return this.__p.__vector_as_span<ESystemModuleName>(22, 1);
		}

		// Token: 0x0601BE3A RID: 114234 RVA: 0x003F0E50 File Offset: 0x003EF050
		public ESystemModuleName[] GetBindSystemsArray()
		{
			int num = this.__p.__offset(22);
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

		// Token: 0x170082E3 RID: 33507
		// (get) Token: 0x0601BE3B RID: 114235 RVA: 0x003F0EBC File Offset: 0x003EF0BC
		public string TidName
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

		// Token: 0x0601BE3C RID: 114236 RVA: 0x003F0EF4 File Offset: 0x003EF0F4
		public Span<byte> GetTidNameBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0601BE3D RID: 114237 RVA: 0x003F0F04 File Offset: 0x003EF104
		public byte[] GetTidNameArray()
		{
			return this.__p.__vector_as_array<byte>(24);
		}

		// Token: 0x170082E4 RID: 33508
		// (get) Token: 0x0601BE3E RID: 114238 RVA: 0x003F0F14 File Offset: 0x003EF114
		public int LevelId
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

		// Token: 0x170082E5 RID: 33509
		// (get) Token: 0x0601BE3F RID: 114239 RVA: 0x003F0F54 File Offset: 0x003EF154
		public int PackId
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

		// Token: 0x170082E6 RID: 33510
		// (get) Token: 0x0601BE40 RID: 114240 RVA: 0x003F0F94 File Offset: 0x003EF194
		public int InstanceId
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

		// Token: 0x170082E7 RID: 33511
		// (get) Token: 0x0601BE41 RID: 114241 RVA: 0x003F0FD4 File Offset: 0x003EF1D4
		public bool IsOnlineStandalone
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601BE42 RID: 114242 RVA: 0x003F1014 File Offset: 0x003EF214
		public string SpecifiedOnlineStandaloneParentUids(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170082E8 RID: 33512
		// (get) Token: 0x0601BE43 RID: 114243 RVA: 0x003F1050 File Offset: 0x003EF250
		public int SpecifiedOnlineStandaloneParentUidsLength
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

		// Token: 0x170082E9 RID: 33513
		// (get) Token: 0x0601BE44 RID: 114244 RVA: 0x003F107C File Offset: 0x003EF27C
		public ELevelPlayOnlineType OnlineType
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return ELevelPlayOnlineType.Local;
				}
				return (ELevelPlayOnlineType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170082EA RID: 33514
		// (get) Token: 0x0601BE45 RID: 114245 RVA: 0x003F10BC File Offset: 0x003EF2BC
		public string InternalDest
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

		// Token: 0x0601BE46 RID: 114246 RVA: 0x003F10F4 File Offset: 0x003EF2F4
		public Span<byte> GetInternalDestBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0601BE47 RID: 114247 RVA: 0x003F1104 File Offset: 0x003EF304
		public byte[] GetInternalDestArray()
		{
			return this.__p.__vector_as_array<byte>(38);
		}

		// Token: 0x170082EB RID: 33515
		// (get) Token: 0x0601BE48 RID: 114248 RVA: 0x003F1114 File Offset: 0x003EF314
		public int LevelAdditiveId
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

		// Token: 0x170082EC RID: 33516
		// (get) Token: 0x0601BE49 RID: 114249 RVA: 0x003F1154 File Offset: 0x003EF354
		public int LevelAiTeamLevelId
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

		// Token: 0x170082ED RID: 33517
		// (get) Token: 0x0601BE4A RID: 114250 RVA: 0x003F1194 File Offset: 0x003EF394
		public ILevelPlayZaxis? LevelPlayZaxis
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return new ILevelPlayZaxis?(default(ILevelPlayZaxis).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170082EE RID: 33518
		// (get) Token: 0x0601BE4B RID: 114251 RVA: 0x003F11F4 File Offset: 0x003EF3F4
		public int LevelPlayEntityId
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

		// Token: 0x170082EF RID: 33519
		// (get) Token: 0x0601BE4C RID: 114252 RVA: 0x003F1234 File Offset: 0x003EF434
		public int EnterRadius
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

		// Token: 0x170082F0 RID: 33520
		// (get) Token: 0x0601BE4D RID: 114253 RVA: 0x003F1274 File Offset: 0x003EF474
		public int LeaveRadius
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170082F1 RID: 33521
		// (get) Token: 0x0601BE4E RID: 114254 RVA: 0x003F12B4 File Offset: 0x003EF4B4
		public bool DelayRefresh
		{
			get
			{
				int num = this.__p.__offset(52);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170082F2 RID: 33522
		// (get) Token: 0x0601BE4F RID: 114255 RVA: 0x003F12F4 File Offset: 0x003EF4F4
		public bool DelayDestroy
		{
			get
			{
				int num = this.__p.__offset(54);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170082F3 RID: 33523
		// (get) Token: 0x0601BE50 RID: 114256 RVA: 0x003F1334 File Offset: 0x003EF534
		public bool NotAllowHidedByGroup
		{
			get
			{
				int num = this.__p.__offset(56);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170082F4 RID: 33524
		// (get) Token: 0x0601BE51 RID: 114257 RVA: 0x003F1374 File Offset: 0x003EF574
		public bool AutoRestoreTreeAddedPlayerBuff
		{
			get
			{
				int num = this.__p.__offset(58);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601BE52 RID: 114258 RVA: 0x003F13B4 File Offset: 0x003EF5B4
		public IActionInfo? EnterInRangeActions(int j)
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170082F5 RID: 33525
		// (get) Token: 0x0601BE53 RID: 114259 RVA: 0x003F1418 File Offset: 0x003EF618
		public int EnterInRangeActionsLength
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

		// Token: 0x0601BE54 RID: 114260 RVA: 0x003F1444 File Offset: 0x003EF644
		public IActionInfo? LevelPlayCloseActions(int j)
		{
			int num = this.__p.__offset(62);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170082F6 RID: 33526
		// (get) Token: 0x0601BE55 RID: 114261 RVA: 0x003F14A8 File Offset: 0x003EF6A8
		public int LevelPlayCloseActionsLength
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170082F7 RID: 33527
		// (get) Token: 0x0601BE56 RID: 114262 RVA: 0x003F14D4 File Offset: 0x003EF6D4
		public ILevelPlayMark? LevelPlayMark
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return null;
				}
				return new ILevelPlayMark?(default(ILevelPlayMark).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170082F8 RID: 33528
		// (get) Token: 0x0601BE57 RID: 114263 RVA: 0x003F1534 File Offset: 0x003EF734
		public ILevelPlayTrack? LevelPlayTrack
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return null;
				}
				return new ILevelPlayTrack?(default(ILevelPlayTrack).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170082F9 RID: 33529
		// (get) Token: 0x0601BE58 RID: 114264 RVA: 0x003F1594 File Offset: 0x003EF794
		public TLevelPlayReward LevelPlayRewardConfigType
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return TLevelPlayReward.NONE;
				}
				return (TLevelPlayReward)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BE59 RID: 114265 RVA: 0x003F15D4 File Offset: 0x003EF7D4
		public TTable? LevelPlayRewardConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601BE5A RID: 114266 RVA: 0x003F161C File Offset: 0x003EF81C
		public IAutomaticRewardParam LevelPlayRewardConfigAsIAutomaticRewardParam()
		{
			return this.LevelPlayRewardConfig<IAutomaticRewardParam>().Value;
		}

		// Token: 0x0601BE5B RID: 114267 RVA: 0x003F1638 File Offset: 0x003EF838
		public IInteractRewardParam LevelPlayRewardConfigAsIInteractRewardParam()
		{
			return this.LevelPlayRewardConfig<IInteractRewardParam>().Value;
		}

		// Token: 0x0601BE5C RID: 114268 RVA: 0x003F1654 File Offset: 0x003EF854
		public INoneRewardParam LevelPlayRewardConfigAsINoneRewardParam()
		{
			return this.LevelPlayRewardConfig<INoneRewardParam>().Value;
		}

		// Token: 0x0601BE5D RID: 114269 RVA: 0x003F1670 File Offset: 0x003EF870
		public IVariableRewardParam LevelPlayRewardConfigAsIVariableRewardParam()
		{
			return this.LevelPlayRewardConfig<IVariableRewardParam>().Value;
		}

		// Token: 0x170082FA RID: 33530
		// (get) Token: 0x0601BE5E RID: 114270 RVA: 0x003F168C File Offset: 0x003EF88C
		public TLevelPlayRefresh LevelPlayRefreshConfigType
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return TLevelPlayRefresh.NONE;
				}
				return (TLevelPlayRefresh)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BE5F RID: 114271 RVA: 0x003F16CC File Offset: 0x003EF8CC
		public TTable? LevelPlayRefreshConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(74);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601BE60 RID: 114272 RVA: 0x003F1714 File Offset: 0x003EF914
		public IChildDestroyOrAwardedRefresh LevelPlayRefreshConfigAsIChildDestroyOrAwardedRefresh()
		{
			return this.LevelPlayRefreshConfig<IChildDestroyOrAwardedRefresh>().Value;
		}

		// Token: 0x0601BE61 RID: 114273 RVA: 0x003F1730 File Offset: 0x003EF930
		public IChildDestroyRefresh LevelPlayRefreshConfigAsIChildDestroyRefresh()
		{
			return this.LevelPlayRefreshConfig<IChildDestroyRefresh>().Value;
		}

		// Token: 0x0601BE62 RID: 114274 RVA: 0x003F174C File Offset: 0x003EF94C
		public ICompletedRefresh LevelPlayRefreshConfigAsICompletedRefresh()
		{
			return this.LevelPlayRefreshConfig<ICompletedRefresh>().Value;
		}

		// Token: 0x0601BE63 RID: 114275 RVA: 0x003F1768 File Offset: 0x003EF968
		public ICustomOnlineRefresh LevelPlayRefreshConfigAsICustomOnlineRefresh()
		{
			return this.LevelPlayRefreshConfig<ICustomOnlineRefresh>().Value;
		}

		// Token: 0x0601BE64 RID: 114276 RVA: 0x003F1784 File Offset: 0x003EF984
		public ICustomRefresh LevelPlayRefreshConfigAsICustomRefresh()
		{
			return this.LevelPlayRefreshConfig<ICustomRefresh>().Value;
		}

		// Token: 0x0601BE65 RID: 114277 RVA: 0x003F17A0 File Offset: 0x003EF9A0
		public IFixedDateTimeRefresh LevelPlayRefreshConfigAsIFixedDateTimeRefresh()
		{
			return this.LevelPlayRefreshConfig<IFixedDateTimeRefresh>().Value;
		}

		// Token: 0x0601BE66 RID: 114278 RVA: 0x003F17BC File Offset: 0x003EF9BC
		public INoneRefresh LevelPlayRefreshConfigAsINoneRefresh()
		{
			return this.LevelPlayRefreshConfig<INoneRefresh>().Value;
		}

		// Token: 0x170082FB RID: 33531
		// (get) Token: 0x0601BE67 RID: 114279 RVA: 0x003F17D8 File Offset: 0x003EF9D8
		public ILevelPlayOpenCondition? LevelPlayOpenCondition
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return null;
				}
				return new ILevelPlayOpenCondition?(default(ILevelPlayOpenCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170082FC RID: 33532
		// (get) Token: 0x0601BE68 RID: 114280 RVA: 0x003F1838 File Offset: 0x003EFA38
		public ILevelPlayActive? LevelPlayActive
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return null;
				}
				return new ILevelPlayActive?(default(ILevelPlayActive).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601BE69 RID: 114281 RVA: 0x003F1898 File Offset: 0x003EFA98
		public IActionInfo? LevelPlayOpenActions(int j)
		{
			int num = this.__p.__offset(80);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170082FD RID: 33533
		// (get) Token: 0x0601BE6A RID: 114282 RVA: 0x003F18FC File Offset: 0x003EFAFC
		public int LevelPlayOpenActionsLength
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

		// Token: 0x0601BE6B RID: 114283 RVA: 0x003F1928 File Offset: 0x003EFB28
		public IActionInfo? EscActionsAfterDungeonCompletion(int j)
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170082FE RID: 33534
		// (get) Token: 0x0601BE6C RID: 114284 RVA: 0x003F198C File Offset: 0x003EFB8C
		public int EscActionsAfterDungeonCompletionLength
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170082FF RID: 33535
		// (get) Token: 0x0601BE6D RID: 114285 RVA: 0x003F19B8 File Offset: 0x003EFBB8
		public int ExploratoryDegree
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008300 RID: 33536
		// (get) Token: 0x0601BE6E RID: 114286 RVA: 0x003F19F8 File Offset: 0x003EFBF8
		public ILevelPlayExploratoryConfig? ExploratoryConfig
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return null;
				}
				return new ILevelPlayExploratoryConfig?(default(ILevelPlayExploratoryConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601BE6F RID: 114287 RVA: 0x003F1A58 File Offset: 0x003EFC58
		public int ReferenceAllEntity(int j)
		{
			int num = this.__p.__offset(88);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008301 RID: 33537
		// (get) Token: 0x0601BE70 RID: 114288 RVA: 0x003F1A98 File Offset: 0x003EFC98
		public int ReferenceAllEntityLength
		{
			get
			{
				int num = this.__p.__offset(88);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601BE71 RID: 114289 RVA: 0x003F1AC4 File Offset: 0x003EFCC4
		public Span<int> GetReferenceAllEntityBytes()
		{
			return this.__p.__vector_as_span<int>(88, 4);
		}

		// Token: 0x0601BE72 RID: 114290 RVA: 0x003F1AD4 File Offset: 0x003EFCD4
		public int[] GetReferenceAllEntityArray()
		{
			return this.__p.__vector_as_array<int>(88);
		}

		// Token: 0x17008302 RID: 33538
		// (get) Token: 0x0601BE73 RID: 114291 RVA: 0x003F1AE4 File Offset: 0x003EFCE4
		public IBehaviorTree? Tree
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return null;
				}
				return new IBehaviorTree?(default(IBehaviorTree).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008303 RID: 33539
		// (get) Token: 0x0601BE74 RID: 114292 RVA: 0x003F1B44 File Offset: 0x003EFD44
		public ILevelPlayFixProcessor? FixProcessor
		{
			get
			{
				int num = this.__p.__offset(92);
				if (num == 0)
				{
					return null;
				}
				return new ILevelPlayFixProcessor?(default(ILevelPlayFixProcessor).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008304 RID: 33540
		// (get) Token: 0x0601BE75 RID: 114293 RVA: 0x003F1BA4 File Offset: 0x003EFDA4
		public int CustomIcon
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

		// Token: 0x17008305 RID: 33541
		// (get) Token: 0x0601BE76 RID: 114294 RVA: 0x003F1BE4 File Offset: 0x003EFDE4
		public int CustomTrackUiIcon
		{
			get
			{
				int num = this.__p.__offset(96);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008306 RID: 33542
		// (get) Token: 0x0601BE77 RID: 114295 RVA: 0x003F1C24 File Offset: 0x003EFE24
		public IRangeAbsorbPhantom? RangeAbsorbPhantom
		{
			get
			{
				int num = this.__p.__offset(98);
				if (num == 0)
				{
					return null;
				}
				return new IRangeAbsorbPhantom?(default(IRangeAbsorbPhantom).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008307 RID: 33543
		// (get) Token: 0x0601BE78 RID: 114296 RVA: 0x003F1C84 File Offset: 0x003EFE84
		public IRewardConfig? RewardConfig
		{
			get
			{
				int num = this.__p.__offset(100);
				if (num == 0)
				{
					return null;
				}
				return new IRewardConfig?(default(IRewardConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008308 RID: 33544
		// (get) Token: 0x0601BE79 RID: 114297 RVA: 0x003F1CE4 File Offset: 0x003EFEE4
		public bool IsTrackOnlyWhenQuestBind
		{
			get
			{
				int num = this.__p.__offset(102);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008309 RID: 33545
		// (get) Token: 0x0601BE7A RID: 114298 RVA: 0x003F1D24 File Offset: 0x003EFF24
		public ILevelPlayRecallConfig? RecallConfig
		{
			get
			{
				int num = this.__p.__offset(104);
				if (num == 0)
				{
					return null;
				}
				return new ILevelPlayRecallConfig?(default(ILevelPlayRecallConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700830A RID: 33546
		// (get) Token: 0x0601BE7B RID: 114299 RVA: 0x003F1D84 File Offset: 0x003EFF84
		public IEntityRefSearchProp? _EntityRefSearch
		{
			get
			{
				int num = this.__p.__offset(106);
				if (num == 0)
				{
					return null;
				}
				return new IEntityRefSearchProp?(default(IEntityRefSearchProp).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601BE7C RID: 114300 RVA: 0x003F1DE4 File Offset: 0x003EFFE4
		public string _HighlightDataPaths(int j)
		{
			int num = this.__p.__offset(108);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700830B RID: 33547
		// (get) Token: 0x0601BE7D RID: 114301 RVA: 0x003F1E20 File Offset: 0x003F0020
		public int _HighlightDataPathsLength
		{
			get
			{
				int num = this.__p.__offset(108);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700830C RID: 33548
		// (get) Token: 0x0601BE7E RID: 114302 RVA: 0x003F1E4C File Offset: 0x003F004C
		public string _FocusDataPath
		{
			get
			{
				int num = this.__p.__offset(110);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BE7F RID: 114303 RVA: 0x003F1E84 File Offset: 0x003F0084
		public Span<byte> Get_FocusDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(110, 1);
		}

		// Token: 0x0601BE80 RID: 114304 RVA: 0x003F1E94 File Offset: 0x003F0094
		public byte[] Get_FocusDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(110);
		}

		// Token: 0x1700830D RID: 33549
		// (get) Token: 0x0601BE81 RID: 114305 RVA: 0x003F1EA4 File Offset: 0x003F00A4
		public uint NullMask
		{
			get
			{
				int num = this.__p.__offset(112);
				if (num == 0)
				{
					return 0U;
				}
				return this.__p.bb.GetUint(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BE82 RID: 114306 RVA: 0x003F1EE4 File Offset: 0x003F00E4
		public static Offset<ILevelPlay> CreateILevelPlay(FlatBufferBuilder builder, StringOffset ObjTypeOffset = default(StringOffset), VectorOffset ChildrenOffset = default(VectorOffset), VectorOffset ReferenceOffset = default(VectorOffset), VectorOffset WeakReferenceOffset = default(VectorOffset), int Id = 0, StringOffset KeyOffset = default(StringOffset), ELevelPlayType Type = ELevelPlayType.SilentArea, EDecisionBtType DecisionBtType = EDecisionBtType.Bvb, int PrefabId = 0, VectorOffset BindSystemsOffset = default(VectorOffset), StringOffset TidNameOffset = default(StringOffset), int LevelId = 0, int PackId = 0, int InstanceId = 0, bool IsOnlineStandalone = false, VectorOffset SpecifiedOnlineStandaloneParentUidsOffset = default(VectorOffset), ELevelPlayOnlineType OnlineType = ELevelPlayOnlineType.Local, StringOffset InternalDestOffset = default(StringOffset), int LevelAdditiveId = 0, int LevelAiTeamLevelId = 0, Offset<ILevelPlayZaxis> LevelPlayZaxisOffset = default(Offset<ILevelPlayZaxis>), int LevelPlayEntityId = 0, int EnterRadius = 0, int LeaveRadius = 0, bool DelayRefresh = false, bool DelayDestroy = false, bool NotAllowHidedByGroup = false, bool AutoRestoreTreeAddedPlayerBuff = false, VectorOffset EnterInRangeActionsOffset = default(VectorOffset), VectorOffset LevelPlayCloseActionsOffset = default(VectorOffset), Offset<ILevelPlayMark> LevelPlayMarkOffset = default(Offset<ILevelPlayMark>), Offset<ILevelPlayTrack> LevelPlayTrackOffset = default(Offset<ILevelPlayTrack>), TLevelPlayReward LevelPlayRewardConfig_type = TLevelPlayReward.NONE, int LevelPlayRewardConfigOffset = 0, TLevelPlayRefresh LevelPlayRefreshConfig_type = TLevelPlayRefresh.NONE, int LevelPlayRefreshConfigOffset = 0, Offset<ILevelPlayOpenCondition> LevelPlayOpenConditionOffset = default(Offset<ILevelPlayOpenCondition>), Offset<ILevelPlayActive> LevelPlayActiveOffset = default(Offset<ILevelPlayActive>), VectorOffset LevelPlayOpenActionsOffset = default(VectorOffset), VectorOffset EscActionsAfterDungeonCompletionOffset = default(VectorOffset), int ExploratoryDegree = 0, Offset<ILevelPlayExploratoryConfig> ExploratoryConfigOffset = default(Offset<ILevelPlayExploratoryConfig>), VectorOffset ReferenceAllEntityOffset = default(VectorOffset), Offset<IBehaviorTree> TreeOffset = default(Offset<IBehaviorTree>), Offset<ILevelPlayFixProcessor> FixProcessorOffset = default(Offset<ILevelPlayFixProcessor>), int CustomIcon = 0, int CustomTrackUiIcon = 0, Offset<IRangeAbsorbPhantom> RangeAbsorbPhantomOffset = default(Offset<IRangeAbsorbPhantom>), Offset<IRewardConfig> RewardConfigOffset = default(Offset<IRewardConfig>), bool IsTrackOnlyWhenQuestBind = false, Offset<ILevelPlayRecallConfig> RecallConfigOffset = default(Offset<ILevelPlayRecallConfig>), Offset<IEntityRefSearchProp> _entityRefSearchOffset = default(Offset<IEntityRefSearchProp>), VectorOffset _highlightDataPathsOffset = default(VectorOffset), StringOffset _focusDataPathOffset = default(StringOffset), uint NullMask = 0U)
		{
			builder.StartTable(55);
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
			ILevelPlay.AddPrefabId(builder, PrefabId);
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

		// Token: 0x0601BE83 RID: 114307 RVA: 0x003F20B4 File Offset: 0x003F02B4
		public static void StartILevelPlay(FlatBufferBuilder builder)
		{
			builder.StartTable(55);
		}

		// Token: 0x0601BE84 RID: 114308 RVA: 0x003F20BE File Offset: 0x003F02BE
		public static void AddObjType(FlatBufferBuilder builder, StringOffset objTypeOffset)
		{
			builder.AddOffset(0, objTypeOffset.Value, 0);
		}

		// Token: 0x0601BE85 RID: 114309 RVA: 0x003F20CE File Offset: 0x003F02CE
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(1, childrenOffset.Value, 0);
		}

		// Token: 0x0601BE86 RID: 114310 RVA: 0x003F20E0 File Offset: 0x003F02E0
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BE87 RID: 114311 RVA: 0x003F2120 File Offset: 0x003F0320
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BE88 RID: 114312 RVA: 0x003F213A File Offset: 0x003F033A
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BE89 RID: 114313 RVA: 0x003F2158 File Offset: 0x003F0358
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BE8A RID: 114314 RVA: 0x003F2171 File Offset: 0x003F0371
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BE8B RID: 114315 RVA: 0x003F217C File Offset: 0x003F037C
		public static void AddReference(FlatBufferBuilder builder, VectorOffset referenceOffset)
		{
			builder.AddOffset(2, referenceOffset.Value, 0);
		}

		// Token: 0x0601BE8C RID: 114316 RVA: 0x003F218C File Offset: 0x003F038C
		public static VectorOffset CreateReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BE8D RID: 114317 RVA: 0x003F21CC File Offset: 0x003F03CC
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BE8E RID: 114318 RVA: 0x003F21E6 File Offset: 0x003F03E6
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BE8F RID: 114319 RVA: 0x003F2204 File Offset: 0x003F0404
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BE90 RID: 114320 RVA: 0x003F221D File Offset: 0x003F041D
		public static void StartReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BE91 RID: 114321 RVA: 0x003F2228 File Offset: 0x003F0428
		public static void AddWeakReference(FlatBufferBuilder builder, VectorOffset weakReferenceOffset)
		{
			builder.AddOffset(3, weakReferenceOffset.Value, 0);
		}

		// Token: 0x0601BE92 RID: 114322 RVA: 0x003F2238 File Offset: 0x003F0438
		public static VectorOffset CreateWeakReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BE93 RID: 114323 RVA: 0x003F2278 File Offset: 0x003F0478
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BE94 RID: 114324 RVA: 0x003F2292 File Offset: 0x003F0492
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BE95 RID: 114325 RVA: 0x003F22B0 File Offset: 0x003F04B0
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BE96 RID: 114326 RVA: 0x003F22C9 File Offset: 0x003F04C9
		public static void StartWeakReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BE97 RID: 114327 RVA: 0x003F22D4 File Offset: 0x003F04D4
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(4, id, 0);
		}

		// Token: 0x0601BE98 RID: 114328 RVA: 0x003F22DF File Offset: 0x003F04DF
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(5, keyOffset.Value, 0);
		}

		// Token: 0x0601BE99 RID: 114329 RVA: 0x003F22EF File Offset: 0x003F04EF
		public static void AddType(FlatBufferBuilder builder, ELevelPlayType type)
		{
			builder.AddByte(6, (byte)type, 0);
		}

		// Token: 0x0601BE9A RID: 114330 RVA: 0x003F22FA File Offset: 0x003F04FA
		public static void AddDecisionBtType(FlatBufferBuilder builder, EDecisionBtType decisionBtType)
		{
			builder.AddByte(7, (byte)decisionBtType, 0);
		}

		// Token: 0x0601BE9B RID: 114331 RVA: 0x003F2305 File Offset: 0x003F0505
		public static void AddPrefabId(FlatBufferBuilder builder, int prefabId)
		{
			builder.AddInt(8, prefabId, 0);
		}

		// Token: 0x0601BE9C RID: 114332 RVA: 0x003F2310 File Offset: 0x003F0510
		public static void AddBindSystems(FlatBufferBuilder builder, VectorOffset bindSystemsOffset)
		{
			builder.AddOffset(9, bindSystemsOffset.Value, 0);
		}

		// Token: 0x0601BE9D RID: 114333 RVA: 0x003F2324 File Offset: 0x003F0524
		public static VectorOffset CreateBindSystemsVector(FlatBufferBuilder builder, ESystemModuleName[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BE9E RID: 114334 RVA: 0x003F235B File Offset: 0x003F055B
		public static VectorOffset CreateBindSystemsVectorBlock(FlatBufferBuilder builder, ESystemModuleName[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<ESystemModuleName>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BE9F RID: 114335 RVA: 0x003F2375 File Offset: 0x003F0575
		public static VectorOffset CreateBindSystemsVectorBlock(FlatBufferBuilder builder, ArraySegment<ESystemModuleName> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<ESystemModuleName>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BEA0 RID: 114336 RVA: 0x003F2393 File Offset: 0x003F0593
		public static VectorOffset CreateBindSystemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<ESystemModuleName>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BEA1 RID: 114337 RVA: 0x003F23AC File Offset: 0x003F05AC
		public static void StartBindSystemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601BEA2 RID: 114338 RVA: 0x003F23B7 File Offset: 0x003F05B7
		public static void AddTidName(FlatBufferBuilder builder, StringOffset tidNameOffset)
		{
			builder.AddOffset(10, tidNameOffset.Value, 0);
		}

		// Token: 0x0601BEA3 RID: 114339 RVA: 0x003F23C8 File Offset: 0x003F05C8
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(11, levelId, 0);
		}

		// Token: 0x0601BEA4 RID: 114340 RVA: 0x003F23D4 File Offset: 0x003F05D4
		public static void AddPackId(FlatBufferBuilder builder, int packId)
		{
			builder.AddInt(12, packId, 0);
		}

		// Token: 0x0601BEA5 RID: 114341 RVA: 0x003F23E0 File Offset: 0x003F05E0
		public static void AddInstanceId(FlatBufferBuilder builder, int instanceId)
		{
			builder.AddInt(13, instanceId, 0);
		}

		// Token: 0x0601BEA6 RID: 114342 RVA: 0x003F23EC File Offset: 0x003F05EC
		public static void AddIsOnlineStandalone(FlatBufferBuilder builder, bool isOnlineStandalone)
		{
			builder.AddBool(14, isOnlineStandalone, false);
		}

		// Token: 0x0601BEA7 RID: 114343 RVA: 0x003F23F8 File Offset: 0x003F05F8
		public static void AddSpecifiedOnlineStandaloneParentUids(FlatBufferBuilder builder, VectorOffset specifiedOnlineStandaloneParentUidsOffset)
		{
			builder.AddOffset(15, specifiedOnlineStandaloneParentUidsOffset.Value, 0);
		}

		// Token: 0x0601BEA8 RID: 114344 RVA: 0x003F240C File Offset: 0x003F060C
		public static VectorOffset CreateSpecifiedOnlineStandaloneParentUidsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BEA9 RID: 114345 RVA: 0x003F244C File Offset: 0x003F064C
		public static VectorOffset CreateSpecifiedOnlineStandaloneParentUidsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BEAA RID: 114346 RVA: 0x003F2466 File Offset: 0x003F0666
		public static VectorOffset CreateSpecifiedOnlineStandaloneParentUidsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BEAB RID: 114347 RVA: 0x003F2484 File Offset: 0x003F0684
		public static VectorOffset CreateSpecifiedOnlineStandaloneParentUidsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BEAC RID: 114348 RVA: 0x003F249D File Offset: 0x003F069D
		public static void StartSpecifiedOnlineStandaloneParentUidsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BEAD RID: 114349 RVA: 0x003F24A8 File Offset: 0x003F06A8
		public static void AddOnlineType(FlatBufferBuilder builder, ELevelPlayOnlineType onlineType)
		{
			builder.AddByte(16, (byte)onlineType, 0);
		}

		// Token: 0x0601BEAE RID: 114350 RVA: 0x003F24B4 File Offset: 0x003F06B4
		public static void AddInternalDest(FlatBufferBuilder builder, StringOffset internalDestOffset)
		{
			builder.AddOffset(17, internalDestOffset.Value, 0);
		}

		// Token: 0x0601BEAF RID: 114351 RVA: 0x003F24C5 File Offset: 0x003F06C5
		public static void AddLevelAdditiveId(FlatBufferBuilder builder, int levelAdditiveId)
		{
			builder.AddInt(18, levelAdditiveId, 0);
		}

		// Token: 0x0601BEB0 RID: 114352 RVA: 0x003F24D1 File Offset: 0x003F06D1
		public static void AddLevelAiTeamLevelId(FlatBufferBuilder builder, int levelAiTeamLevelId)
		{
			builder.AddInt(19, levelAiTeamLevelId, 0);
		}

		// Token: 0x0601BEB1 RID: 114353 RVA: 0x003F24DD File Offset: 0x003F06DD
		public static void AddLevelPlayZaxis(FlatBufferBuilder builder, Offset<ILevelPlayZaxis> levelPlayZaxisOffset)
		{
			builder.AddOffset(20, levelPlayZaxisOffset.Value, 0);
		}

		// Token: 0x0601BEB2 RID: 114354 RVA: 0x003F24EE File Offset: 0x003F06EE
		public static void AddLevelPlayEntityId(FlatBufferBuilder builder, int levelPlayEntityId)
		{
			builder.AddInt(21, levelPlayEntityId, 0);
		}

		// Token: 0x0601BEB3 RID: 114355 RVA: 0x003F24FA File Offset: 0x003F06FA
		public static void AddEnterRadius(FlatBufferBuilder builder, int enterRadius)
		{
			builder.AddInt(22, enterRadius, 0);
		}

		// Token: 0x0601BEB4 RID: 114356 RVA: 0x003F2506 File Offset: 0x003F0706
		public static void AddLeaveRadius(FlatBufferBuilder builder, int leaveRadius)
		{
			builder.AddInt(23, leaveRadius, 0);
		}

		// Token: 0x0601BEB5 RID: 114357 RVA: 0x003F2512 File Offset: 0x003F0712
		public static void AddDelayRefresh(FlatBufferBuilder builder, bool delayRefresh)
		{
			builder.AddBool(24, delayRefresh, false);
		}

		// Token: 0x0601BEB6 RID: 114358 RVA: 0x003F251E File Offset: 0x003F071E
		public static void AddDelayDestroy(FlatBufferBuilder builder, bool delayDestroy)
		{
			builder.AddBool(25, delayDestroy, false);
		}

		// Token: 0x0601BEB7 RID: 114359 RVA: 0x003F252A File Offset: 0x003F072A
		public static void AddNotAllowHidedByGroup(FlatBufferBuilder builder, bool notAllowHidedByGroup)
		{
			builder.AddBool(26, notAllowHidedByGroup, false);
		}

		// Token: 0x0601BEB8 RID: 114360 RVA: 0x003F2536 File Offset: 0x003F0736
		public static void AddAutoRestoreTreeAddedPlayerBuff(FlatBufferBuilder builder, bool autoRestoreTreeAddedPlayerBuff)
		{
			builder.AddBool(27, autoRestoreTreeAddedPlayerBuff, false);
		}

		// Token: 0x0601BEB9 RID: 114361 RVA: 0x003F2542 File Offset: 0x003F0742
		public static void AddEnterInRangeActions(FlatBufferBuilder builder, VectorOffset enterInRangeActionsOffset)
		{
			builder.AddOffset(28, enterInRangeActionsOffset.Value, 0);
		}

		// Token: 0x0601BEBA RID: 114362 RVA: 0x003F2554 File Offset: 0x003F0754
		public static VectorOffset CreateEnterInRangeActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BEBB RID: 114363 RVA: 0x003F2594 File Offset: 0x003F0794
		public static VectorOffset CreateEnterInRangeActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BEBC RID: 114364 RVA: 0x003F25AE File Offset: 0x003F07AE
		public static VectorOffset CreateEnterInRangeActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BEBD RID: 114365 RVA: 0x003F25CC File Offset: 0x003F07CC
		public static VectorOffset CreateEnterInRangeActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BEBE RID: 114366 RVA: 0x003F25E5 File Offset: 0x003F07E5
		public static void StartEnterInRangeActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BEBF RID: 114367 RVA: 0x003F25F0 File Offset: 0x003F07F0
		public static void AddLevelPlayCloseActions(FlatBufferBuilder builder, VectorOffset levelPlayCloseActionsOffset)
		{
			builder.AddOffset(29, levelPlayCloseActionsOffset.Value, 0);
		}

		// Token: 0x0601BEC0 RID: 114368 RVA: 0x003F2604 File Offset: 0x003F0804
		public static VectorOffset CreateLevelPlayCloseActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BEC1 RID: 114369 RVA: 0x003F2644 File Offset: 0x003F0844
		public static VectorOffset CreateLevelPlayCloseActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BEC2 RID: 114370 RVA: 0x003F265E File Offset: 0x003F085E
		public static VectorOffset CreateLevelPlayCloseActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BEC3 RID: 114371 RVA: 0x003F267C File Offset: 0x003F087C
		public static VectorOffset CreateLevelPlayCloseActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BEC4 RID: 114372 RVA: 0x003F2695 File Offset: 0x003F0895
		public static void StartLevelPlayCloseActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BEC5 RID: 114373 RVA: 0x003F26A0 File Offset: 0x003F08A0
		public static void AddLevelPlayMark(FlatBufferBuilder builder, Offset<ILevelPlayMark> levelPlayMarkOffset)
		{
			builder.AddOffset(30, levelPlayMarkOffset.Value, 0);
		}

		// Token: 0x0601BEC6 RID: 114374 RVA: 0x003F26B1 File Offset: 0x003F08B1
		public static void AddLevelPlayTrack(FlatBufferBuilder builder, Offset<ILevelPlayTrack> levelPlayTrackOffset)
		{
			builder.AddOffset(31, levelPlayTrackOffset.Value, 0);
		}

		// Token: 0x0601BEC7 RID: 114375 RVA: 0x003F26C2 File Offset: 0x003F08C2
		public static void AddLevelPlayRewardConfigType(FlatBufferBuilder builder, TLevelPlayReward levelPlayRewardConfigType)
		{
			builder.AddByte(32, (byte)levelPlayRewardConfigType, 0);
		}

		// Token: 0x0601BEC8 RID: 114376 RVA: 0x003F26CE File Offset: 0x003F08CE
		public static void AddLevelPlayRewardConfig(FlatBufferBuilder builder, int levelPlayRewardConfigOffset)
		{
			builder.AddOffset(33, levelPlayRewardConfigOffset, 0);
		}

		// Token: 0x0601BEC9 RID: 114377 RVA: 0x003F26DA File Offset: 0x003F08DA
		public static void AddLevelPlayRefreshConfigType(FlatBufferBuilder builder, TLevelPlayRefresh levelPlayRefreshConfigType)
		{
			builder.AddByte(34, (byte)levelPlayRefreshConfigType, 0);
		}

		// Token: 0x0601BECA RID: 114378 RVA: 0x003F26E6 File Offset: 0x003F08E6
		public static void AddLevelPlayRefreshConfig(FlatBufferBuilder builder, int levelPlayRefreshConfigOffset)
		{
			builder.AddOffset(35, levelPlayRefreshConfigOffset, 0);
		}

		// Token: 0x0601BECB RID: 114379 RVA: 0x003F26F2 File Offset: 0x003F08F2
		public static void AddLevelPlayOpenCondition(FlatBufferBuilder builder, Offset<ILevelPlayOpenCondition> levelPlayOpenConditionOffset)
		{
			builder.AddOffset(36, levelPlayOpenConditionOffset.Value, 0);
		}

		// Token: 0x0601BECC RID: 114380 RVA: 0x003F2703 File Offset: 0x003F0903
		public static void AddLevelPlayActive(FlatBufferBuilder builder, Offset<ILevelPlayActive> levelPlayActiveOffset)
		{
			builder.AddOffset(37, levelPlayActiveOffset.Value, 0);
		}

		// Token: 0x0601BECD RID: 114381 RVA: 0x003F2714 File Offset: 0x003F0914
		public static void AddLevelPlayOpenActions(FlatBufferBuilder builder, VectorOffset levelPlayOpenActionsOffset)
		{
			builder.AddOffset(38, levelPlayOpenActionsOffset.Value, 0);
		}

		// Token: 0x0601BECE RID: 114382 RVA: 0x003F2728 File Offset: 0x003F0928
		public static VectorOffset CreateLevelPlayOpenActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BECF RID: 114383 RVA: 0x003F2768 File Offset: 0x003F0968
		public static VectorOffset CreateLevelPlayOpenActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BED0 RID: 114384 RVA: 0x003F2782 File Offset: 0x003F0982
		public static VectorOffset CreateLevelPlayOpenActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BED1 RID: 114385 RVA: 0x003F27A0 File Offset: 0x003F09A0
		public static VectorOffset CreateLevelPlayOpenActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BED2 RID: 114386 RVA: 0x003F27B9 File Offset: 0x003F09B9
		public static void StartLevelPlayOpenActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BED3 RID: 114387 RVA: 0x003F27C4 File Offset: 0x003F09C4
		public static void AddEscActionsAfterDungeonCompletion(FlatBufferBuilder builder, VectorOffset escActionsAfterDungeonCompletionOffset)
		{
			builder.AddOffset(39, escActionsAfterDungeonCompletionOffset.Value, 0);
		}

		// Token: 0x0601BED4 RID: 114388 RVA: 0x003F27D8 File Offset: 0x003F09D8
		public static VectorOffset CreateEscActionsAfterDungeonCompletionVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BED5 RID: 114389 RVA: 0x003F2818 File Offset: 0x003F0A18
		public static VectorOffset CreateEscActionsAfterDungeonCompletionVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BED6 RID: 114390 RVA: 0x003F2832 File Offset: 0x003F0A32
		public static VectorOffset CreateEscActionsAfterDungeonCompletionVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BED7 RID: 114391 RVA: 0x003F2850 File Offset: 0x003F0A50
		public static VectorOffset CreateEscActionsAfterDungeonCompletionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BED8 RID: 114392 RVA: 0x003F2869 File Offset: 0x003F0A69
		public static void StartEscActionsAfterDungeonCompletionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BED9 RID: 114393 RVA: 0x003F2874 File Offset: 0x003F0A74
		public static void AddExploratoryDegree(FlatBufferBuilder builder, int exploratoryDegree)
		{
			builder.AddInt(40, exploratoryDegree, 0);
		}

		// Token: 0x0601BEDA RID: 114394 RVA: 0x003F2880 File Offset: 0x003F0A80
		public static void AddExploratoryConfig(FlatBufferBuilder builder, Offset<ILevelPlayExploratoryConfig> exploratoryConfigOffset)
		{
			builder.AddOffset(41, exploratoryConfigOffset.Value, 0);
		}

		// Token: 0x0601BEDB RID: 114395 RVA: 0x003F2891 File Offset: 0x003F0A91
		public static void AddReferenceAllEntity(FlatBufferBuilder builder, VectorOffset referenceAllEntityOffset)
		{
			builder.AddOffset(42, referenceAllEntityOffset.Value, 0);
		}

		// Token: 0x0601BEDC RID: 114396 RVA: 0x003F28A4 File Offset: 0x003F0AA4
		public static VectorOffset CreateReferenceAllEntityVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BEDD RID: 114397 RVA: 0x003F28DB File Offset: 0x003F0ADB
		public static VectorOffset CreateReferenceAllEntityVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BEDE RID: 114398 RVA: 0x003F28F5 File Offset: 0x003F0AF5
		public static VectorOffset CreateReferenceAllEntityVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BEDF RID: 114399 RVA: 0x003F2913 File Offset: 0x003F0B13
		public static VectorOffset CreateReferenceAllEntityVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BEE0 RID: 114400 RVA: 0x003F292C File Offset: 0x003F0B2C
		public static void StartReferenceAllEntityVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BEE1 RID: 114401 RVA: 0x003F2937 File Offset: 0x003F0B37
		public static void AddTree(FlatBufferBuilder builder, Offset<IBehaviorTree> treeOffset)
		{
			builder.AddOffset(43, treeOffset.Value, 0);
		}

		// Token: 0x0601BEE2 RID: 114402 RVA: 0x003F2948 File Offset: 0x003F0B48
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<ILevelPlayFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(44, fixProcessorOffset.Value, 0);
		}

		// Token: 0x0601BEE3 RID: 114403 RVA: 0x003F2959 File Offset: 0x003F0B59
		public static void AddCustomIcon(FlatBufferBuilder builder, int customIcon)
		{
			builder.AddInt(45, customIcon, 0);
		}

		// Token: 0x0601BEE4 RID: 114404 RVA: 0x003F2965 File Offset: 0x003F0B65
		public static void AddCustomTrackUiIcon(FlatBufferBuilder builder, int customTrackUiIcon)
		{
			builder.AddInt(46, customTrackUiIcon, 0);
		}

		// Token: 0x0601BEE5 RID: 114405 RVA: 0x003F2971 File Offset: 0x003F0B71
		public static void AddRangeAbsorbPhantom(FlatBufferBuilder builder, Offset<IRangeAbsorbPhantom> rangeAbsorbPhantomOffset)
		{
			builder.AddOffset(47, rangeAbsorbPhantomOffset.Value, 0);
		}

		// Token: 0x0601BEE6 RID: 114406 RVA: 0x003F2982 File Offset: 0x003F0B82
		public static void AddRewardConfig(FlatBufferBuilder builder, Offset<IRewardConfig> rewardConfigOffset)
		{
			builder.AddOffset(48, rewardConfigOffset.Value, 0);
		}

		// Token: 0x0601BEE7 RID: 114407 RVA: 0x003F2993 File Offset: 0x003F0B93
		public static void AddIsTrackOnlyWhenQuestBind(FlatBufferBuilder builder, bool isTrackOnlyWhenQuestBind)
		{
			builder.AddBool(49, isTrackOnlyWhenQuestBind, false);
		}

		// Token: 0x0601BEE8 RID: 114408 RVA: 0x003F299F File Offset: 0x003F0B9F
		public static void AddRecallConfig(FlatBufferBuilder builder, Offset<ILevelPlayRecallConfig> recallConfigOffset)
		{
			builder.AddOffset(50, recallConfigOffset.Value, 0);
		}

		// Token: 0x0601BEE9 RID: 114409 RVA: 0x003F29B0 File Offset: 0x003F0BB0
		public static void Add_EntityRefSearch(FlatBufferBuilder builder, Offset<IEntityRefSearchProp> _EntityRefSearchOffset)
		{
			builder.AddOffset(51, _EntityRefSearchOffset.Value, 0);
		}

		// Token: 0x0601BEEA RID: 114410 RVA: 0x003F29C1 File Offset: 0x003F0BC1
		public static void Add_HighlightDataPaths(FlatBufferBuilder builder, VectorOffset _HighlightDataPathsOffset)
		{
			builder.AddOffset(52, _HighlightDataPathsOffset.Value, 0);
		}

		// Token: 0x0601BEEB RID: 114411 RVA: 0x003F29D4 File Offset: 0x003F0BD4
		public static VectorOffset Create_HighlightDataPathsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BEEC RID: 114412 RVA: 0x003F2A14 File Offset: 0x003F0C14
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BEED RID: 114413 RVA: 0x003F2A2E File Offset: 0x003F0C2E
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BEEE RID: 114414 RVA: 0x003F2A4C File Offset: 0x003F0C4C
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BEEF RID: 114415 RVA: 0x003F2A65 File Offset: 0x003F0C65
		public static void Start_HighlightDataPathsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BEF0 RID: 114416 RVA: 0x003F2A70 File Offset: 0x003F0C70
		public static void Add_FocusDataPath(FlatBufferBuilder builder, StringOffset _FocusDataPathOffset)
		{
			builder.AddOffset(53, _FocusDataPathOffset.Value, 0);
		}

		// Token: 0x0601BEF1 RID: 114417 RVA: 0x003F2A81 File Offset: 0x003F0C81
		public static void AddNullMask(FlatBufferBuilder builder, uint nullMask)
		{
			builder.AddUint(54, nullMask, 0U);
		}

		// Token: 0x0601BEF2 RID: 114418 RVA: 0x003F2A8D File Offset: 0x003F0C8D
		public static Offset<ILevelPlay> EndILevelPlay(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlay>(builder.EndTable());
		}

		// Token: 0x0601BEF3 RID: 114419 RVA: 0x003F2A9C File Offset: 0x003F0C9C
		public ILevelPlayT UnPack()
		{
			ILevelPlayT levelPlayT = new ILevelPlayT();
			this.UnPackTo(levelPlayT);
			return levelPlayT;
		}

		// Token: 0x0601BEF4 RID: 114420 RVA: 0x003F2AB8 File Offset: 0x003F0CB8
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
			_o.PrefabId = this.PrefabId;
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

		// Token: 0x0601BEF5 RID: 114421 RVA: 0x003F3438 File Offset: 0x003F1638
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
			return ILevelPlay.CreateILevelPlay(builder, objTypeOffset, childrenOffset, referenceOffset, weakReferenceOffset, _o.Id, keyOffset, _o.Type, _o.DecisionBtType, _o.PrefabId, bindSystemsOffset, tidNameOffset, _o.LevelId, _o.PackId, _o.InstanceId, _o.IsOnlineStandalone, specifiedOnlineStandaloneParentUidsOffset, _o.OnlineType, internalDestOffset, _o.LevelAdditiveId, _o.LevelAiTeamLevelId, levelPlayZaxisOffset, _o.LevelPlayEntityId, _o.EnterRadius, _o.LeaveRadius, _o.DelayRefresh, _o.DelayDestroy, _o.NotAllowHidedByGroup, _o.AutoRestoreTreeAddedPlayerBuff, enterInRangeActionsOffset, levelPlayCloseActionsOffset, levelPlayMarkOffset, levelPlayTrackOffset, levelPlayRewardConfig_type, levelPlayRewardConfigOffset, levelPlayRefreshConfig_type, levelPlayRefreshConfigOffset, levelPlayOpenConditionOffset, levelPlayActiveOffset, levelPlayOpenActionsOffset, escActionsAfterDungeonCompletionOffset, _o.ExploratoryDegree, exploratoryConfigOffset, referenceAllEntityOffset, treeOffset, fixProcessorOffset, _o.CustomIcon, _o.CustomTrackUiIcon, rangeAbsorbPhantomOffset, rewardConfigOffset, _o.IsTrackOnlyWhenQuestBind, recallConfigOffset, entityRefSearchOffset, highlightDataPathsOffset, focusDataPathOffset, _o.NullMask);
		}

		// Token: 0x0400CF3B RID: 53051
		private Table __p;
	}
}
