using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004859 RID: 18521
	public struct IEditorConfig : IFlatbufferObject
	{
		// Token: 0x1700850E RID: 34062
		// (get) Token: 0x0601CAE4 RID: 117476 RVA: 0x0040DD7C File Offset: 0x0040BF7C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CAE5 RID: 117477 RVA: 0x0040DD89 File Offset: 0x0040BF89
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CAE6 RID: 117478 RVA: 0x0040DD90 File Offset: 0x0040BF90
		public static IEditorConfig GetRootAsIEditorConfig(ByteBuffer _bb)
		{
			return IEditorConfig.GetRootAsIEditorConfig(_bb, default(IEditorConfig));
		}

		// Token: 0x0601CAE7 RID: 117479 RVA: 0x0040DDAC File Offset: 0x0040BFAC
		public static IEditorConfig GetRootAsIEditorConfig(ByteBuffer _bb, IEditorConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CAE8 RID: 117480 RVA: 0x0040DDC9 File Offset: 0x0040BFC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CAE9 RID: 117481 RVA: 0x0040DDD8 File Offset: 0x0040BFD8
		public IEditorConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700850F RID: 34063
		// (get) Token: 0x0601CAEA RID: 117482 RVA: 0x0040DDE8 File Offset: 0x0040BFE8
		public string Version
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

		// Token: 0x0601CAEB RID: 117483 RVA: 0x0040DE1F File Offset: 0x0040C01F
		public Span<byte> GetVersionBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601CAEC RID: 117484 RVA: 0x0040DE2E File Offset: 0x0040C02E
		public byte[] GetVersionArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008510 RID: 34064
		// (get) Token: 0x0601CAED RID: 117485 RVA: 0x0040DE3C File Offset: 0x0040C03C
		public bool ShowId
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008511 RID: 34065
		// (get) Token: 0x0601CAEE RID: 117486 RVA: 0x0040DE7C File Offset: 0x0040C07C
		public bool ShowFlowEditorError
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008512 RID: 34066
		// (get) Token: 0x0601CAEF RID: 117487 RVA: 0x0040DEBC File Offset: 0x0040C0BC
		public IFlowStateIndex? LastPlayFlow
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IFlowStateIndex?(default(IFlowStateIndex).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008513 RID: 34067
		// (get) Token: 0x0601CAF0 RID: 117488 RVA: 0x0040DF1C File Offset: 0x0040C11C
		public string CsvName
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

		// Token: 0x0601CAF1 RID: 117489 RVA: 0x0040DF54 File Offset: 0x0040C154
		public Span<byte> GetCsvNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601CAF2 RID: 117490 RVA: 0x0040DF64 File Offset: 0x0040C164
		public byte[] GetCsvNameArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x0601CAF3 RID: 117491 RVA: 0x0040DF74 File Offset: 0x0040C174
		public int RecentLevels(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008514 RID: 34068
		// (get) Token: 0x0601CAF4 RID: 117492 RVA: 0x0040DFB4 File Offset: 0x0040C1B4
		public int RecentLevelsLength
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

		// Token: 0x0601CAF5 RID: 117493 RVA: 0x0040DFE0 File Offset: 0x0040C1E0
		public Span<int> GetRecentLevelsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0601CAF6 RID: 117494 RVA: 0x0040DFF0 File Offset: 0x0040C1F0
		public int[] GetRecentLevelsArray()
		{
			return this.__p.__vector_as_array<int>(14);
		}

		// Token: 0x0601CAF7 RID: 117495 RVA: 0x0040E000 File Offset: 0x0040C200
		public int RecentSubWpMaps(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008515 RID: 34069
		// (get) Token: 0x0601CAF8 RID: 117496 RVA: 0x0040E040 File Offset: 0x0040C240
		public int RecentSubWpMapsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601CAF9 RID: 117497 RVA: 0x0040E06C File Offset: 0x0040C26C
		public Span<int> GetRecentSubWpMapsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0601CAFA RID: 117498 RVA: 0x0040E07C File Offset: 0x0040C27C
		public int[] GetRecentSubWpMapsArray()
		{
			return this.__p.__vector_as_array<int>(16);
		}

		// Token: 0x17008516 RID: 34070
		// (get) Token: 0x0601CAFB RID: 117499 RVA: 0x0040E08C File Offset: 0x0040C28C
		public bool EnableRecentSelectRecord
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008517 RID: 34071
		// (get) Token: 0x0601CAFC RID: 117500 RVA: 0x0040E0CC File Offset: 0x0040C2CC
		public EMaximumDisplayCountInSelector MaximumDisplayCountInSelector
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return EMaximumDisplayCountInSelector.None;
				}
				return (EMaximumDisplayCountInSelector)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008518 RID: 34072
		// (get) Token: 0x0601CAFD RID: 117501 RVA: 0x0040E10C File Offset: 0x0040C30C
		public ERecentSelectRecordMode RecentSelectRecordMode
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return ERecentSelectRecordMode.SortByCount;
				}
				return (ERecentSelectRecordMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008519 RID: 34073
		// (get) Token: 0x0601CAFE RID: 117502 RVA: 0x0040E14C File Offset: 0x0040C34C
		public bool EnableAutoUpdateFile
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700851A RID: 34074
		// (get) Token: 0x0601CAFF RID: 117503 RVA: 0x0040E18C File Offset: 0x0040C38C
		public bool IsTransientEntityModeDisable
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700851B RID: 34075
		// (get) Token: 0x0601CB00 RID: 117504 RVA: 0x0040E1CC File Offset: 0x0040C3CC
		public bool IsAllowSubmitNotOriginFile
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700851C RID: 34076
		// (get) Token: 0x0601CB01 RID: 117505 RVA: 0x0040E20C File Offset: 0x0040C40C
		public bool IsAllowSubmitAllWpActor
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700851D RID: 34077
		// (get) Token: 0x0601CB02 RID: 117506 RVA: 0x0040E24C File Offset: 0x0040C44C
		public ILaunchSettingShowInMainEditor? SettingShowInMainEditor
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return new ILaunchSettingShowInMainEditor?(default(ILaunchSettingShowInMainEditor).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700851E RID: 34078
		// (get) Token: 0x0601CB03 RID: 117507 RVA: 0x0040E2AC File Offset: 0x0040C4AC
		public IEditorStartConfig? EditorStartConfig
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return new IEditorStartConfig?(default(IEditorStartConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700851F RID: 34079
		// (get) Token: 0x0601CB04 RID: 117508 RVA: 0x0040E30C File Offset: 0x0040C50C
		public IEditorIndentationDisplaySetting? IndentationDisplaySetting
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return new IEditorIndentationDisplaySetting?(default(IEditorIndentationDisplaySetting).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008520 RID: 34080
		// (get) Token: 0x0601CB05 RID: 117509 RVA: 0x0040E36C File Offset: 0x0040C56C
		public bool IsEnableBottomAoiCheck
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008521 RID: 34081
		// (get) Token: 0x0601CB06 RID: 117510 RVA: 0x0040E3AC File Offset: 0x0040C5AC
		public bool IsLimitFloatBoxWidth
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008522 RID: 34082
		// (get) Token: 0x0601CB07 RID: 117511 RVA: 0x0040E3EC File Offset: 0x0040C5EC
		public bool IsEnableAutoSaveRes
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008523 RID: 34083
		// (get) Token: 0x0601CB08 RID: 117512 RVA: 0x0040E42C File Offset: 0x0040C62C
		public bool IsAskWhenAutoSaveError
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008524 RID: 34084
		// (get) Token: 0x0601CB09 RID: 117513 RVA: 0x0040E46C File Offset: 0x0040C66C
		public bool IsLoadActorWhenJumpEntity
		{
			get
			{
				int num = this.__p.__offset(46);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008525 RID: 34085
		// (get) Token: 0x0601CB0A RID: 117514 RVA: 0x0040E4AC File Offset: 0x0040C6AC
		public EEntityActorLoadMode EntityActorLoadMode
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return EEntityActorLoadMode.Self;
				}
				return (EEntityActorLoadMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008526 RID: 34086
		// (get) Token: 0x0601CB0B RID: 117515 RVA: 0x0040E4EC File Offset: 0x0040C6EC
		public bool IsAskWhenLoadActor
		{
			get
			{
				int num = this.__p.__offset(50);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008527 RID: 34087
		// (get) Token: 0x0601CB0C RID: 117516 RVA: 0x0040E52C File Offset: 0x0040C72C
		public int ActorLoadCellSize
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008528 RID: 34088
		// (get) Token: 0x0601CB0D RID: 117517 RVA: 0x0040E56C File Offset: 0x0040C76C
		public int ParentChildAndActorDepth
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008529 RID: 34089
		// (get) Token: 0x0601CB0E RID: 117518 RVA: 0x0040E5AC File Offset: 0x0040C7AC
		public int ParentChildAndActorLoadedActorTypes
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700852A RID: 34090
		// (get) Token: 0x0601CB0F RID: 117519 RVA: 0x0040E5EC File Offset: 0x0040C7EC
		public int ParentChildAndActorExcludeFolders
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700852B RID: 34091
		// (get) Token: 0x0601CB10 RID: 117520 RVA: 0x0040E62C File Offset: 0x0040C82C
		public EActorDeleteMode ActorDeleteMode
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return EActorDeleteMode.AskUser;
				}
				return (EActorDeleteMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700852C RID: 34092
		// (get) Token: 0x0601CB11 RID: 117521 RVA: 0x0040E66C File Offset: 0x0040C86C
		public bool IsAskWhenOpenExcel
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601CB12 RID: 117522 RVA: 0x0040E6AC File Offset: 0x0040C8AC
		public Record_String_Boolean? SilentRunTestConfig(int j)
		{
			int num = this.__p.__offset(64);
			if (num == 0)
			{
				return null;
			}
			return new Record_String_Boolean?(default(Record_String_Boolean).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700852D RID: 34093
		// (get) Token: 0x0601CB13 RID: 117523 RVA: 0x0040E710 File Offset: 0x0040C910
		public int SilentRunTestConfigLength
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601CB14 RID: 117524 RVA: 0x0040E73C File Offset: 0x0040C93C
		public Record_String_Boolean? AutoRunTestConfig(int j)
		{
			int num = this.__p.__offset(66);
			if (num == 0)
			{
				return null;
			}
			return new Record_String_Boolean?(default(Record_String_Boolean).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700852E RID: 34094
		// (get) Token: 0x0601CB15 RID: 117525 RVA: 0x0040E7A0 File Offset: 0x0040C9A0
		public int AutoRunTestConfigLength
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700852F RID: 34095
		// (get) Token: 0x0601CB16 RID: 117526 RVA: 0x0040E7CC File Offset: 0x0040C9CC
		public bool IsDebugTest
		{
			get
			{
				int num = this.__p.__offset(68);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008530 RID: 34096
		// (get) Token: 0x0601CB17 RID: 117527 RVA: 0x0040E80C File Offset: 0x0040CA0C
		public EActionDisabledType ActionDisabledType
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return EActionDisabledType.LocalDisabled;
				}
				return (EActionDisabledType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008531 RID: 34097
		// (get) Token: 0x0601CB18 RID: 117528 RVA: 0x0040E84C File Offset: 0x0040CA4C
		public ETreeNodeDisabledType TreeNodeDisabledType
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return ETreeNodeDisabledType.LocalDisabled;
				}
				return (ETreeNodeDisabledType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008532 RID: 34098
		// (get) Token: 0x0601CB19 RID: 117529 RVA: 0x0040E88C File Offset: 0x0040CA8C
		public bool ShowClipboardTipsInStatusBar
		{
			get
			{
				int num = this.__p.__offset(74);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008533 RID: 34099
		// (get) Token: 0x0601CB1A RID: 117530 RVA: 0x0040E8CC File Offset: 0x0040CACC
		public bool IsAllowDragDropArray
		{
			get
			{
				int num = this.__p.__offset(76);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008534 RID: 34100
		// (get) Token: 0x0601CB1B RID: 117531 RVA: 0x0040E90C File Offset: 0x0040CB0C
		public EActionHelpClickMode ActionHelpClickMode
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return EActionHelpClickMode.OpenDetailByClick;
				}
				return (EActionHelpClickMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008535 RID: 34101
		// (get) Token: 0x0601CB1C RID: 117532 RVA: 0x0040E94C File Offset: 0x0040CB4C
		public string AkiBasePath
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CB1D RID: 117533 RVA: 0x0040E984 File Offset: 0x0040CB84
		public Span<byte> GetAkiBasePathBytes()
		{
			return this.__p.__vector_as_span<byte>(80, 1);
		}

		// Token: 0x0601CB1E RID: 117534 RVA: 0x0040E994 File Offset: 0x0040CB94
		public byte[] GetAkiBasePathArray()
		{
			return this.__p.__vector_as_array<byte>(80);
		}

		// Token: 0x17008536 RID: 34102
		// (get) Token: 0x0601CB1F RID: 117535 RVA: 0x0040E9A4 File Offset: 0x0040CBA4
		public string ExternalJsonEditor
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CB20 RID: 117536 RVA: 0x0040E9DC File Offset: 0x0040CBDC
		public Span<byte> GetExternalJsonEditorBytes()
		{
			return this.__p.__vector_as_span<byte>(82, 1);
		}

		// Token: 0x0601CB21 RID: 117537 RVA: 0x0040E9EC File Offset: 0x0040CBEC
		public byte[] GetExternalJsonEditorArray()
		{
			return this.__p.__vector_as_array<byte>(82);
		}

		// Token: 0x0601CB22 RID: 117538 RVA: 0x0040E9FC File Offset: 0x0040CBFC
		public static Offset<IEditorConfig> CreateIEditorConfig(FlatBufferBuilder builder, StringOffset VersionOffset = default(StringOffset), bool ShowId = false, bool ShowFlowEditorError = false, Offset<IFlowStateIndex> LastPlayFlowOffset = default(Offset<IFlowStateIndex>), StringOffset CsvNameOffset = default(StringOffset), VectorOffset RecentLevelsOffset = default(VectorOffset), VectorOffset RecentSubWpMapsOffset = default(VectorOffset), bool EnableRecentSelectRecord = false, EMaximumDisplayCountInSelector MaximumDisplayCountInSelector = EMaximumDisplayCountInSelector.None, ERecentSelectRecordMode RecentSelectRecordMode = ERecentSelectRecordMode.SortByCount, bool EnableAutoUpdateFile = false, bool IsTransientEntityModeDisable = false, bool IsAllowSubmitNotOriginFile = false, bool IsAllowSubmitAllWpActor = false, Offset<ILaunchSettingShowInMainEditor> SettingShowInMainEditorOffset = default(Offset<ILaunchSettingShowInMainEditor>), Offset<IEditorStartConfig> EditorStartConfigOffset = default(Offset<IEditorStartConfig>), Offset<IEditorIndentationDisplaySetting> IndentationDisplaySettingOffset = default(Offset<IEditorIndentationDisplaySetting>), bool IsEnableBottomAoiCheck = false, bool IsLimitFloatBoxWidth = false, bool IsEnableAutoSaveRes = false, bool IsAskWhenAutoSaveError = false, bool IsLoadActorWhenJumpEntity = false, EEntityActorLoadMode EntityActorLoadMode = EEntityActorLoadMode.Self, bool IsAskWhenLoadActor = false, int ActorLoadCellSize = 0, int ParentChildAndActorDepth = 0, int ParentChildAndActorLoadedActorTypes = 0, int ParentChildAndActorExcludeFolders = 0, EActorDeleteMode ActorDeleteMode = EActorDeleteMode.AskUser, bool IsAskWhenOpenExcel = false, VectorOffset SilentRunTestConfigOffset = default(VectorOffset), VectorOffset AutoRunTestConfigOffset = default(VectorOffset), bool IsDebugTest = false, EActionDisabledType ActionDisabledType = EActionDisabledType.LocalDisabled, ETreeNodeDisabledType TreeNodeDisabledType = ETreeNodeDisabledType.LocalDisabled, bool ShowClipboardTipsInStatusBar = false, bool IsAllowDragDropArray = false, EActionHelpClickMode ActionHelpClickMode = EActionHelpClickMode.OpenDetailByClick, StringOffset AkiBasePathOffset = default(StringOffset), StringOffset ExternalJsonEditorOffset = default(StringOffset))
		{
			builder.StartTable(40);
			IEditorConfig.AddExternalJsonEditor(builder, ExternalJsonEditorOffset);
			IEditorConfig.AddAkiBasePath(builder, AkiBasePathOffset);
			IEditorConfig.AddAutoRunTestConfig(builder, AutoRunTestConfigOffset);
			IEditorConfig.AddSilentRunTestConfig(builder, SilentRunTestConfigOffset);
			IEditorConfig.AddParentChildAndActorExcludeFolders(builder, ParentChildAndActorExcludeFolders);
			IEditorConfig.AddParentChildAndActorLoadedActorTypes(builder, ParentChildAndActorLoadedActorTypes);
			IEditorConfig.AddParentChildAndActorDepth(builder, ParentChildAndActorDepth);
			IEditorConfig.AddActorLoadCellSize(builder, ActorLoadCellSize);
			IEditorConfig.AddIndentationDisplaySetting(builder, IndentationDisplaySettingOffset);
			IEditorConfig.AddEditorStartConfig(builder, EditorStartConfigOffset);
			IEditorConfig.AddSettingShowInMainEditor(builder, SettingShowInMainEditorOffset);
			IEditorConfig.AddRecentSubWpMaps(builder, RecentSubWpMapsOffset);
			IEditorConfig.AddRecentLevels(builder, RecentLevelsOffset);
			IEditorConfig.AddCsvName(builder, CsvNameOffset);
			IEditorConfig.AddLastPlayFlow(builder, LastPlayFlowOffset);
			IEditorConfig.AddVersion(builder, VersionOffset);
			IEditorConfig.AddActionHelpClickMode(builder, ActionHelpClickMode);
			IEditorConfig.AddIsAllowDragDropArray(builder, IsAllowDragDropArray);
			IEditorConfig.AddShowClipboardTipsInStatusBar(builder, ShowClipboardTipsInStatusBar);
			IEditorConfig.AddTreeNodeDisabledType(builder, TreeNodeDisabledType);
			IEditorConfig.AddActionDisabledType(builder, ActionDisabledType);
			IEditorConfig.AddIsDebugTest(builder, IsDebugTest);
			IEditorConfig.AddIsAskWhenOpenExcel(builder, IsAskWhenOpenExcel);
			IEditorConfig.AddActorDeleteMode(builder, ActorDeleteMode);
			IEditorConfig.AddIsAskWhenLoadActor(builder, IsAskWhenLoadActor);
			IEditorConfig.AddEntityActorLoadMode(builder, EntityActorLoadMode);
			IEditorConfig.AddIsLoadActorWhenJumpEntity(builder, IsLoadActorWhenJumpEntity);
			IEditorConfig.AddIsAskWhenAutoSaveError(builder, IsAskWhenAutoSaveError);
			IEditorConfig.AddIsEnableAutoSaveRes(builder, IsEnableAutoSaveRes);
			IEditorConfig.AddIsLimitFloatBoxWidth(builder, IsLimitFloatBoxWidth);
			IEditorConfig.AddIsEnableBottomAoiCheck(builder, IsEnableBottomAoiCheck);
			IEditorConfig.AddIsAllowSubmitAllWpActor(builder, IsAllowSubmitAllWpActor);
			IEditorConfig.AddIsAllowSubmitNotOriginFile(builder, IsAllowSubmitNotOriginFile);
			IEditorConfig.AddIsTransientEntityModeDisable(builder, IsTransientEntityModeDisable);
			IEditorConfig.AddEnableAutoUpdateFile(builder, EnableAutoUpdateFile);
			IEditorConfig.AddRecentSelectRecordMode(builder, RecentSelectRecordMode);
			IEditorConfig.AddMaximumDisplayCountInSelector(builder, MaximumDisplayCountInSelector);
			IEditorConfig.AddEnableRecentSelectRecord(builder, EnableRecentSelectRecord);
			IEditorConfig.AddShowFlowEditorError(builder, ShowFlowEditorError);
			IEditorConfig.AddShowId(builder, ShowId);
			return IEditorConfig.EndIEditorConfig(builder);
		}

		// Token: 0x0601CB23 RID: 117539 RVA: 0x0040EB54 File Offset: 0x0040CD54
		public static void StartIEditorConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(40);
		}

		// Token: 0x0601CB24 RID: 117540 RVA: 0x0040EB5E File Offset: 0x0040CD5E
		public static void AddVersion(FlatBufferBuilder builder, StringOffset versionOffset)
		{
			builder.AddOffset(0, versionOffset.Value, 0);
		}

		// Token: 0x0601CB25 RID: 117541 RVA: 0x0040EB6E File Offset: 0x0040CD6E
		public static void AddShowId(FlatBufferBuilder builder, bool showId)
		{
			builder.AddBool(1, showId, false);
		}

		// Token: 0x0601CB26 RID: 117542 RVA: 0x0040EB79 File Offset: 0x0040CD79
		public static void AddShowFlowEditorError(FlatBufferBuilder builder, bool showFlowEditorError)
		{
			builder.AddBool(2, showFlowEditorError, false);
		}

		// Token: 0x0601CB27 RID: 117543 RVA: 0x0040EB84 File Offset: 0x0040CD84
		public static void AddLastPlayFlow(FlatBufferBuilder builder, Offset<IFlowStateIndex> lastPlayFlowOffset)
		{
			builder.AddOffset(3, lastPlayFlowOffset.Value, 0);
		}

		// Token: 0x0601CB28 RID: 117544 RVA: 0x0040EB94 File Offset: 0x0040CD94
		public static void AddCsvName(FlatBufferBuilder builder, StringOffset csvNameOffset)
		{
			builder.AddOffset(4, csvNameOffset.Value, 0);
		}

		// Token: 0x0601CB29 RID: 117545 RVA: 0x0040EBA4 File Offset: 0x0040CDA4
		public static void AddRecentLevels(FlatBufferBuilder builder, VectorOffset recentLevelsOffset)
		{
			builder.AddOffset(5, recentLevelsOffset.Value, 0);
		}

		// Token: 0x0601CB2A RID: 117546 RVA: 0x0040EBB4 File Offset: 0x0040CDB4
		public static VectorOffset CreateRecentLevelsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601CB2B RID: 117547 RVA: 0x0040EBEB File Offset: 0x0040CDEB
		public static VectorOffset CreateRecentLevelsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CB2C RID: 117548 RVA: 0x0040EC05 File Offset: 0x0040CE05
		public static VectorOffset CreateRecentLevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CB2D RID: 117549 RVA: 0x0040EC23 File Offset: 0x0040CE23
		public static VectorOffset CreateRecentLevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601CB2E RID: 117550 RVA: 0x0040EC3C File Offset: 0x0040CE3C
		public static void StartRecentLevelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601CB2F RID: 117551 RVA: 0x0040EC47 File Offset: 0x0040CE47
		public static void AddRecentSubWpMaps(FlatBufferBuilder builder, VectorOffset recentSubWpMapsOffset)
		{
			builder.AddOffset(6, recentSubWpMapsOffset.Value, 0);
		}

		// Token: 0x0601CB30 RID: 117552 RVA: 0x0040EC58 File Offset: 0x0040CE58
		public static VectorOffset CreateRecentSubWpMapsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601CB31 RID: 117553 RVA: 0x0040EC8F File Offset: 0x0040CE8F
		public static VectorOffset CreateRecentSubWpMapsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CB32 RID: 117554 RVA: 0x0040ECA9 File Offset: 0x0040CEA9
		public static VectorOffset CreateRecentSubWpMapsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CB33 RID: 117555 RVA: 0x0040ECC7 File Offset: 0x0040CEC7
		public static VectorOffset CreateRecentSubWpMapsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601CB34 RID: 117556 RVA: 0x0040ECE0 File Offset: 0x0040CEE0
		public static void StartRecentSubWpMapsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601CB35 RID: 117557 RVA: 0x0040ECEB File Offset: 0x0040CEEB
		public static void AddEnableRecentSelectRecord(FlatBufferBuilder builder, bool enableRecentSelectRecord)
		{
			builder.AddBool(7, enableRecentSelectRecord, false);
		}

		// Token: 0x0601CB36 RID: 117558 RVA: 0x0040ECF6 File Offset: 0x0040CEF6
		public static void AddMaximumDisplayCountInSelector(FlatBufferBuilder builder, EMaximumDisplayCountInSelector maximumDisplayCountInSelector)
		{
			builder.AddByte(8, (byte)maximumDisplayCountInSelector, 0);
		}

		// Token: 0x0601CB37 RID: 117559 RVA: 0x0040ED01 File Offset: 0x0040CF01
		public static void AddRecentSelectRecordMode(FlatBufferBuilder builder, ERecentSelectRecordMode recentSelectRecordMode)
		{
			builder.AddByte(9, (byte)recentSelectRecordMode, 0);
		}

		// Token: 0x0601CB38 RID: 117560 RVA: 0x0040ED0D File Offset: 0x0040CF0D
		public static void AddEnableAutoUpdateFile(FlatBufferBuilder builder, bool enableAutoUpdateFile)
		{
			builder.AddBool(10, enableAutoUpdateFile, false);
		}

		// Token: 0x0601CB39 RID: 117561 RVA: 0x0040ED19 File Offset: 0x0040CF19
		public static void AddIsTransientEntityModeDisable(FlatBufferBuilder builder, bool isTransientEntityModeDisable)
		{
			builder.AddBool(11, isTransientEntityModeDisable, false);
		}

		// Token: 0x0601CB3A RID: 117562 RVA: 0x0040ED25 File Offset: 0x0040CF25
		public static void AddIsAllowSubmitNotOriginFile(FlatBufferBuilder builder, bool isAllowSubmitNotOriginFile)
		{
			builder.AddBool(12, isAllowSubmitNotOriginFile, false);
		}

		// Token: 0x0601CB3B RID: 117563 RVA: 0x0040ED31 File Offset: 0x0040CF31
		public static void AddIsAllowSubmitAllWpActor(FlatBufferBuilder builder, bool isAllowSubmitAllWpActor)
		{
			builder.AddBool(13, isAllowSubmitAllWpActor, false);
		}

		// Token: 0x0601CB3C RID: 117564 RVA: 0x0040ED3D File Offset: 0x0040CF3D
		public static void AddSettingShowInMainEditor(FlatBufferBuilder builder, Offset<ILaunchSettingShowInMainEditor> settingShowInMainEditorOffset)
		{
			builder.AddOffset(14, settingShowInMainEditorOffset.Value, 0);
		}

		// Token: 0x0601CB3D RID: 117565 RVA: 0x0040ED4E File Offset: 0x0040CF4E
		public static void AddEditorStartConfig(FlatBufferBuilder builder, Offset<IEditorStartConfig> editorStartConfigOffset)
		{
			builder.AddOffset(15, editorStartConfigOffset.Value, 0);
		}

		// Token: 0x0601CB3E RID: 117566 RVA: 0x0040ED5F File Offset: 0x0040CF5F
		public static void AddIndentationDisplaySetting(FlatBufferBuilder builder, Offset<IEditorIndentationDisplaySetting> indentationDisplaySettingOffset)
		{
			builder.AddOffset(16, indentationDisplaySettingOffset.Value, 0);
		}

		// Token: 0x0601CB3F RID: 117567 RVA: 0x0040ED70 File Offset: 0x0040CF70
		public static void AddIsEnableBottomAoiCheck(FlatBufferBuilder builder, bool isEnableBottomAoiCheck)
		{
			builder.AddBool(17, isEnableBottomAoiCheck, false);
		}

		// Token: 0x0601CB40 RID: 117568 RVA: 0x0040ED7C File Offset: 0x0040CF7C
		public static void AddIsLimitFloatBoxWidth(FlatBufferBuilder builder, bool isLimitFloatBoxWidth)
		{
			builder.AddBool(18, isLimitFloatBoxWidth, false);
		}

		// Token: 0x0601CB41 RID: 117569 RVA: 0x0040ED88 File Offset: 0x0040CF88
		public static void AddIsEnableAutoSaveRes(FlatBufferBuilder builder, bool isEnableAutoSaveRes)
		{
			builder.AddBool(19, isEnableAutoSaveRes, false);
		}

		// Token: 0x0601CB42 RID: 117570 RVA: 0x0040ED94 File Offset: 0x0040CF94
		public static void AddIsAskWhenAutoSaveError(FlatBufferBuilder builder, bool isAskWhenAutoSaveError)
		{
			builder.AddBool(20, isAskWhenAutoSaveError, false);
		}

		// Token: 0x0601CB43 RID: 117571 RVA: 0x0040EDA0 File Offset: 0x0040CFA0
		public static void AddIsLoadActorWhenJumpEntity(FlatBufferBuilder builder, bool isLoadActorWhenJumpEntity)
		{
			builder.AddBool(21, isLoadActorWhenJumpEntity, false);
		}

		// Token: 0x0601CB44 RID: 117572 RVA: 0x0040EDAC File Offset: 0x0040CFAC
		public static void AddEntityActorLoadMode(FlatBufferBuilder builder, EEntityActorLoadMode entityActorLoadMode)
		{
			builder.AddByte(22, (byte)entityActorLoadMode, 0);
		}

		// Token: 0x0601CB45 RID: 117573 RVA: 0x0040EDB8 File Offset: 0x0040CFB8
		public static void AddIsAskWhenLoadActor(FlatBufferBuilder builder, bool isAskWhenLoadActor)
		{
			builder.AddBool(23, isAskWhenLoadActor, false);
		}

		// Token: 0x0601CB46 RID: 117574 RVA: 0x0040EDC4 File Offset: 0x0040CFC4
		public static void AddActorLoadCellSize(FlatBufferBuilder builder, int actorLoadCellSize)
		{
			builder.AddInt(24, actorLoadCellSize, 0);
		}

		// Token: 0x0601CB47 RID: 117575 RVA: 0x0040EDD0 File Offset: 0x0040CFD0
		public static void AddParentChildAndActorDepth(FlatBufferBuilder builder, int parentChildAndActorDepth)
		{
			builder.AddInt(25, parentChildAndActorDepth, 0);
		}

		// Token: 0x0601CB48 RID: 117576 RVA: 0x0040EDDC File Offset: 0x0040CFDC
		public static void AddParentChildAndActorLoadedActorTypes(FlatBufferBuilder builder, int parentChildAndActorLoadedActorTypes)
		{
			builder.AddInt(26, parentChildAndActorLoadedActorTypes, 0);
		}

		// Token: 0x0601CB49 RID: 117577 RVA: 0x0040EDE8 File Offset: 0x0040CFE8
		public static void AddParentChildAndActorExcludeFolders(FlatBufferBuilder builder, int parentChildAndActorExcludeFolders)
		{
			builder.AddInt(27, parentChildAndActorExcludeFolders, 0);
		}

		// Token: 0x0601CB4A RID: 117578 RVA: 0x0040EDF4 File Offset: 0x0040CFF4
		public static void AddActorDeleteMode(FlatBufferBuilder builder, EActorDeleteMode actorDeleteMode)
		{
			builder.AddByte(28, (byte)actorDeleteMode, 0);
		}

		// Token: 0x0601CB4B RID: 117579 RVA: 0x0040EE00 File Offset: 0x0040D000
		public static void AddIsAskWhenOpenExcel(FlatBufferBuilder builder, bool isAskWhenOpenExcel)
		{
			builder.AddBool(29, isAskWhenOpenExcel, false);
		}

		// Token: 0x0601CB4C RID: 117580 RVA: 0x0040EE0C File Offset: 0x0040D00C
		public static void AddSilentRunTestConfig(FlatBufferBuilder builder, VectorOffset silentRunTestConfigOffset)
		{
			builder.AddOffset(30, silentRunTestConfigOffset.Value, 0);
		}

		// Token: 0x0601CB4D RID: 117581 RVA: 0x0040EE20 File Offset: 0x0040D020
		public static VectorOffset CreateSilentRunTestConfigVector(FlatBufferBuilder builder, Offset<Record_String_Boolean>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601CB4E RID: 117582 RVA: 0x0040EE60 File Offset: 0x0040D060
		public static VectorOffset CreateSilentRunTestConfigVectorBlock(FlatBufferBuilder builder, Offset<Record_String_Boolean>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_String_Boolean>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CB4F RID: 117583 RVA: 0x0040EE7A File Offset: 0x0040D07A
		public static VectorOffset CreateSilentRunTestConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_String_Boolean>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_String_Boolean>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CB50 RID: 117584 RVA: 0x0040EE98 File Offset: 0x0040D098
		public static VectorOffset CreateSilentRunTestConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_String_Boolean>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601CB51 RID: 117585 RVA: 0x0040EEB1 File Offset: 0x0040D0B1
		public static void StartSilentRunTestConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601CB52 RID: 117586 RVA: 0x0040EEBC File Offset: 0x0040D0BC
		public static void AddAutoRunTestConfig(FlatBufferBuilder builder, VectorOffset autoRunTestConfigOffset)
		{
			builder.AddOffset(31, autoRunTestConfigOffset.Value, 0);
		}

		// Token: 0x0601CB53 RID: 117587 RVA: 0x0040EED0 File Offset: 0x0040D0D0
		public static VectorOffset CreateAutoRunTestConfigVector(FlatBufferBuilder builder, Offset<Record_String_Boolean>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601CB54 RID: 117588 RVA: 0x0040EF10 File Offset: 0x0040D110
		public static VectorOffset CreateAutoRunTestConfigVectorBlock(FlatBufferBuilder builder, Offset<Record_String_Boolean>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_String_Boolean>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CB55 RID: 117589 RVA: 0x0040EF2A File Offset: 0x0040D12A
		public static VectorOffset CreateAutoRunTestConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_String_Boolean>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_String_Boolean>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CB56 RID: 117590 RVA: 0x0040EF48 File Offset: 0x0040D148
		public static VectorOffset CreateAutoRunTestConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_String_Boolean>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601CB57 RID: 117591 RVA: 0x0040EF61 File Offset: 0x0040D161
		public static void StartAutoRunTestConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601CB58 RID: 117592 RVA: 0x0040EF6C File Offset: 0x0040D16C
		public static void AddIsDebugTest(FlatBufferBuilder builder, bool isDebugTest)
		{
			builder.AddBool(32, isDebugTest, false);
		}

		// Token: 0x0601CB59 RID: 117593 RVA: 0x0040EF78 File Offset: 0x0040D178
		public static void AddActionDisabledType(FlatBufferBuilder builder, EActionDisabledType actionDisabledType)
		{
			builder.AddByte(33, (byte)actionDisabledType, 0);
		}

		// Token: 0x0601CB5A RID: 117594 RVA: 0x0040EF84 File Offset: 0x0040D184
		public static void AddTreeNodeDisabledType(FlatBufferBuilder builder, ETreeNodeDisabledType treeNodeDisabledType)
		{
			builder.AddByte(34, (byte)treeNodeDisabledType, 0);
		}

		// Token: 0x0601CB5B RID: 117595 RVA: 0x0040EF90 File Offset: 0x0040D190
		public static void AddShowClipboardTipsInStatusBar(FlatBufferBuilder builder, bool showClipboardTipsInStatusBar)
		{
			builder.AddBool(35, showClipboardTipsInStatusBar, false);
		}

		// Token: 0x0601CB5C RID: 117596 RVA: 0x0040EF9C File Offset: 0x0040D19C
		public static void AddIsAllowDragDropArray(FlatBufferBuilder builder, bool isAllowDragDropArray)
		{
			builder.AddBool(36, isAllowDragDropArray, false);
		}

		// Token: 0x0601CB5D RID: 117597 RVA: 0x0040EFA8 File Offset: 0x0040D1A8
		public static void AddActionHelpClickMode(FlatBufferBuilder builder, EActionHelpClickMode actionHelpClickMode)
		{
			builder.AddByte(37, (byte)actionHelpClickMode, 0);
		}

		// Token: 0x0601CB5E RID: 117598 RVA: 0x0040EFB4 File Offset: 0x0040D1B4
		public static void AddAkiBasePath(FlatBufferBuilder builder, StringOffset akiBasePathOffset)
		{
			builder.AddOffset(38, akiBasePathOffset.Value, 0);
		}

		// Token: 0x0601CB5F RID: 117599 RVA: 0x0040EFC5 File Offset: 0x0040D1C5
		public static void AddExternalJsonEditor(FlatBufferBuilder builder, StringOffset externalJsonEditorOffset)
		{
			builder.AddOffset(39, externalJsonEditorOffset.Value, 0);
		}

		// Token: 0x0601CB60 RID: 117600 RVA: 0x0040EFD6 File Offset: 0x0040D1D6
		public static Offset<IEditorConfig> EndIEditorConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEditorConfig>(builder.EndTable());
		}

		// Token: 0x0601CB61 RID: 117601 RVA: 0x0040EFE4 File Offset: 0x0040D1E4
		public IEditorConfigT UnPack()
		{
			IEditorConfigT editorConfigT = new IEditorConfigT();
			this.UnPackTo(editorConfigT);
			return editorConfigT;
		}

		// Token: 0x0601CB62 RID: 117602 RVA: 0x0040F000 File Offset: 0x0040D200
		public void UnPackTo(IEditorConfigT _o)
		{
			_o.Version = this.Version;
			_o.ShowId = this.ShowId;
			_o.ShowFlowEditorError = this.ShowFlowEditorError;
			_o.LastPlayFlow = ((this.LastPlayFlow != null) ? this.LastPlayFlow.Value.UnPack() : null);
			_o.CsvName = this.CsvName;
			_o.RecentLevels = new List<int>();
			for (int i = 0; i < this.RecentLevelsLength; i++)
			{
				_o.RecentLevels.Add(this.RecentLevels(i));
			}
			_o.RecentSubWpMaps = new List<int>();
			for (int j = 0; j < this.RecentSubWpMapsLength; j++)
			{
				_o.RecentSubWpMaps.Add(this.RecentSubWpMaps(j));
			}
			_o.EnableRecentSelectRecord = this.EnableRecentSelectRecord;
			_o.MaximumDisplayCountInSelector = this.MaximumDisplayCountInSelector;
			_o.RecentSelectRecordMode = this.RecentSelectRecordMode;
			_o.EnableAutoUpdateFile = this.EnableAutoUpdateFile;
			_o.IsTransientEntityModeDisable = this.IsTransientEntityModeDisable;
			_o.IsAllowSubmitNotOriginFile = this.IsAllowSubmitNotOriginFile;
			_o.IsAllowSubmitAllWpActor = this.IsAllowSubmitAllWpActor;
			_o.SettingShowInMainEditor = ((this.SettingShowInMainEditor != null) ? this.SettingShowInMainEditor.Value.UnPack() : null);
			_o.EditorStartConfig = ((this.EditorStartConfig != null) ? this.EditorStartConfig.Value.UnPack() : null);
			_o.IndentationDisplaySetting = ((this.IndentationDisplaySetting != null) ? this.IndentationDisplaySetting.Value.UnPack() : null);
			_o.IsEnableBottomAoiCheck = this.IsEnableBottomAoiCheck;
			_o.IsLimitFloatBoxWidth = this.IsLimitFloatBoxWidth;
			_o.IsEnableAutoSaveRes = this.IsEnableAutoSaveRes;
			_o.IsAskWhenAutoSaveError = this.IsAskWhenAutoSaveError;
			_o.IsLoadActorWhenJumpEntity = this.IsLoadActorWhenJumpEntity;
			_o.EntityActorLoadMode = this.EntityActorLoadMode;
			_o.IsAskWhenLoadActor = this.IsAskWhenLoadActor;
			_o.ActorLoadCellSize = this.ActorLoadCellSize;
			_o.ParentChildAndActorDepth = this.ParentChildAndActorDepth;
			_o.ParentChildAndActorLoadedActorTypes = this.ParentChildAndActorLoadedActorTypes;
			_o.ParentChildAndActorExcludeFolders = this.ParentChildAndActorExcludeFolders;
			_o.ActorDeleteMode = this.ActorDeleteMode;
			_o.IsAskWhenOpenExcel = this.IsAskWhenOpenExcel;
			_o.SilentRunTestConfig = new List<Record_String_BooleanT>();
			for (int k = 0; k < this.SilentRunTestConfigLength; k++)
			{
				_o.SilentRunTestConfig.Add((this.SilentRunTestConfig(k) != null) ? this.SilentRunTestConfig(k).Value.UnPack() : null);
			}
			_o.AutoRunTestConfig = new List<Record_String_BooleanT>();
			for (int l = 0; l < this.AutoRunTestConfigLength; l++)
			{
				_o.AutoRunTestConfig.Add((this.AutoRunTestConfig(l) != null) ? this.AutoRunTestConfig(l).Value.UnPack() : null);
			}
			_o.IsDebugTest = this.IsDebugTest;
			_o.ActionDisabledType = this.ActionDisabledType;
			_o.TreeNodeDisabledType = this.TreeNodeDisabledType;
			_o.ShowClipboardTipsInStatusBar = this.ShowClipboardTipsInStatusBar;
			_o.IsAllowDragDropArray = this.IsAllowDragDropArray;
			_o.ActionHelpClickMode = this.ActionHelpClickMode;
			_o.AkiBasePath = this.AkiBasePath;
			_o.ExternalJsonEditor = this.ExternalJsonEditor;
		}

		// Token: 0x0601CB63 RID: 117603 RVA: 0x0040F364 File Offset: 0x0040D564
		public static Offset<IEditorConfig> Pack(FlatBufferBuilder builder, IEditorConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEditorConfig>);
			}
			StringOffset versionOffset = (_o.Version == null) ? default(StringOffset) : builder.CreateString(_o.Version);
			Offset<IFlowStateIndex> lastPlayFlowOffset = (_o.LastPlayFlow == null) ? default(Offset<IFlowStateIndex>) : IFlowStateIndex.Pack(builder, _o.LastPlayFlow);
			StringOffset csvNameOffset = (_o.CsvName == null) ? default(StringOffset) : builder.CreateString(_o.CsvName);
			VectorOffset recentLevelsOffset = default(VectorOffset);
			if (_o.RecentLevels != null)
			{
				int[] data = _o.RecentLevels.ToArray();
				recentLevelsOffset = IEditorConfig.CreateRecentLevelsVector(builder, data);
			}
			VectorOffset recentSubWpMapsOffset = default(VectorOffset);
			if (_o.RecentSubWpMaps != null)
			{
				int[] data2 = _o.RecentSubWpMaps.ToArray();
				recentSubWpMapsOffset = IEditorConfig.CreateRecentSubWpMapsVector(builder, data2);
			}
			Offset<ILaunchSettingShowInMainEditor> settingShowInMainEditorOffset = (_o.SettingShowInMainEditor == null) ? default(Offset<ILaunchSettingShowInMainEditor>) : ILaunchSettingShowInMainEditor.Pack(builder, _o.SettingShowInMainEditor);
			Offset<IEditorStartConfig> editorStartConfigOffset = (_o.EditorStartConfig == null) ? default(Offset<IEditorStartConfig>) : IEditorStartConfig.Pack(builder, _o.EditorStartConfig);
			Offset<IEditorIndentationDisplaySetting> indentationDisplaySettingOffset = (_o.IndentationDisplaySetting == null) ? default(Offset<IEditorIndentationDisplaySetting>) : IEditorIndentationDisplaySetting.Pack(builder, _o.IndentationDisplaySetting);
			VectorOffset silentRunTestConfigOffset = default(VectorOffset);
			if (_o.SilentRunTestConfig != null)
			{
				Offset<Record_String_Boolean>[] array = new Offset<Record_String_Boolean>[_o.SilentRunTestConfig.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = Record_String_Boolean.Pack(builder, _o.SilentRunTestConfig[i]);
				}
				silentRunTestConfigOffset = IEditorConfig.CreateSilentRunTestConfigVector(builder, array);
			}
			VectorOffset autoRunTestConfigOffset = default(VectorOffset);
			if (_o.AutoRunTestConfig != null)
			{
				Offset<Record_String_Boolean>[] array2 = new Offset<Record_String_Boolean>[_o.AutoRunTestConfig.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = Record_String_Boolean.Pack(builder, _o.AutoRunTestConfig[j]);
				}
				autoRunTestConfigOffset = IEditorConfig.CreateAutoRunTestConfigVector(builder, array2);
			}
			StringOffset akiBasePathOffset = (_o.AkiBasePath == null) ? default(StringOffset) : builder.CreateString(_o.AkiBasePath);
			StringOffset externalJsonEditorOffset = (_o.ExternalJsonEditor == null) ? default(StringOffset) : builder.CreateString(_o.ExternalJsonEditor);
			return IEditorConfig.CreateIEditorConfig(builder, versionOffset, _o.ShowId, _o.ShowFlowEditorError, lastPlayFlowOffset, csvNameOffset, recentLevelsOffset, recentSubWpMapsOffset, _o.EnableRecentSelectRecord, _o.MaximumDisplayCountInSelector, _o.RecentSelectRecordMode, _o.EnableAutoUpdateFile, _o.IsTransientEntityModeDisable, _o.IsAllowSubmitNotOriginFile, _o.IsAllowSubmitAllWpActor, settingShowInMainEditorOffset, editorStartConfigOffset, indentationDisplaySettingOffset, _o.IsEnableBottomAoiCheck, _o.IsLimitFloatBoxWidth, _o.IsEnableAutoSaveRes, _o.IsAskWhenAutoSaveError, _o.IsLoadActorWhenJumpEntity, _o.EntityActorLoadMode, _o.IsAskWhenLoadActor, _o.ActorLoadCellSize, _o.ParentChildAndActorDepth, _o.ParentChildAndActorLoadedActorTypes, _o.ParentChildAndActorExcludeFolders, _o.ActorDeleteMode, _o.IsAskWhenOpenExcel, silentRunTestConfigOffset, autoRunTestConfigOffset, _o.IsDebugTest, _o.ActionDisabledType, _o.TreeNodeDisabledType, _o.ShowClipboardTipsInStatusBar, _o.IsAllowDragDropArray, _o.ActionHelpClickMode, akiBasePathOffset, externalJsonEditorOffset);
		}

		// Token: 0x0400CD9A RID: 52634
		private Table __p;
	}
}
