using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CC1 RID: 19649
	public struct IEditorConfig : IFlatbufferObject
	{
		// Token: 0x17008B5B RID: 35675
		// (get) Token: 0x0601E2E7 RID: 123623 RVA: 0x0043A79C File Offset: 0x0043899C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E2E8 RID: 123624 RVA: 0x0043A7A9 File Offset: 0x004389A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E2E9 RID: 123625 RVA: 0x0043A7B0 File Offset: 0x004389B0
		public static IEditorConfig GetRootAsIEditorConfig(ByteBuffer _bb)
		{
			return IEditorConfig.GetRootAsIEditorConfig(_bb, default(IEditorConfig));
		}

		// Token: 0x0601E2EA RID: 123626 RVA: 0x0043A7CC File Offset: 0x004389CC
		public static IEditorConfig GetRootAsIEditorConfig(ByteBuffer _bb, IEditorConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E2EB RID: 123627 RVA: 0x0043A7E9 File Offset: 0x004389E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E2EC RID: 123628 RVA: 0x0043A7F8 File Offset: 0x004389F8
		public IEditorConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B5C RID: 35676
		// (get) Token: 0x0601E2ED RID: 123629 RVA: 0x0043A808 File Offset: 0x00438A08
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

		// Token: 0x0601E2EE RID: 123630 RVA: 0x0043A83F File Offset: 0x00438A3F
		public Span<byte> GetVersionBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601E2EF RID: 123631 RVA: 0x0043A84E File Offset: 0x00438A4E
		public byte[] GetVersionArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008B5D RID: 35677
		// (get) Token: 0x0601E2F0 RID: 123632 RVA: 0x0043A85C File Offset: 0x00438A5C
		public bool ShowId
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008B5E RID: 35678
		// (get) Token: 0x0601E2F1 RID: 123633 RVA: 0x0043A89C File Offset: 0x00438A9C
		public bool ShowFlowEditorError
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008B5F RID: 35679
		// (get) Token: 0x0601E2F2 RID: 123634 RVA: 0x0043A8DC File Offset: 0x00438ADC
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

		// Token: 0x17008B60 RID: 35680
		// (get) Token: 0x0601E2F3 RID: 123635 RVA: 0x0043A93C File Offset: 0x00438B3C
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

		// Token: 0x0601E2F4 RID: 123636 RVA: 0x0043A974 File Offset: 0x00438B74
		public Span<byte> GetCsvNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601E2F5 RID: 123637 RVA: 0x0043A984 File Offset: 0x00438B84
		public byte[] GetCsvNameArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x0601E2F6 RID: 123638 RVA: 0x0043A994 File Offset: 0x00438B94
		public int RecentLevels(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008B61 RID: 35681
		// (get) Token: 0x0601E2F7 RID: 123639 RVA: 0x0043A9D4 File Offset: 0x00438BD4
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

		// Token: 0x0601E2F8 RID: 123640 RVA: 0x0043AA00 File Offset: 0x00438C00
		public Span<int> GetRecentLevelsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0601E2F9 RID: 123641 RVA: 0x0043AA10 File Offset: 0x00438C10
		public int[] GetRecentLevelsArray()
		{
			return this.__p.__vector_as_array<int>(14);
		}

		// Token: 0x0601E2FA RID: 123642 RVA: 0x0043AA20 File Offset: 0x00438C20
		public int RecentSubWpMaps(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008B62 RID: 35682
		// (get) Token: 0x0601E2FB RID: 123643 RVA: 0x0043AA60 File Offset: 0x00438C60
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

		// Token: 0x0601E2FC RID: 123644 RVA: 0x0043AA8C File Offset: 0x00438C8C
		public Span<int> GetRecentSubWpMapsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0601E2FD RID: 123645 RVA: 0x0043AA9C File Offset: 0x00438C9C
		public int[] GetRecentSubWpMapsArray()
		{
			return this.__p.__vector_as_array<int>(16);
		}

		// Token: 0x17008B63 RID: 35683
		// (get) Token: 0x0601E2FE RID: 123646 RVA: 0x0043AAAC File Offset: 0x00438CAC
		public bool EnableRecentSelectRecord
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008B64 RID: 35684
		// (get) Token: 0x0601E2FF RID: 123647 RVA: 0x0043AAEC File Offset: 0x00438CEC
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

		// Token: 0x17008B65 RID: 35685
		// (get) Token: 0x0601E300 RID: 123648 RVA: 0x0043AB2C File Offset: 0x00438D2C
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

		// Token: 0x17008B66 RID: 35686
		// (get) Token: 0x0601E301 RID: 123649 RVA: 0x0043AB6C File Offset: 0x00438D6C
		public bool EnableAutoUpdateFile
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008B67 RID: 35687
		// (get) Token: 0x0601E302 RID: 123650 RVA: 0x0043ABAC File Offset: 0x00438DAC
		public bool IsTransientEntityModeDisable
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008B68 RID: 35688
		// (get) Token: 0x0601E303 RID: 123651 RVA: 0x0043ABEC File Offset: 0x00438DEC
		public bool IsAllowSubmitNotOriginFile
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008B69 RID: 35689
		// (get) Token: 0x0601E304 RID: 123652 RVA: 0x0043AC2C File Offset: 0x00438E2C
		public bool IsAllowSubmitAllWpActor
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008B6A RID: 35690
		// (get) Token: 0x0601E305 RID: 123653 RVA: 0x0043AC6C File Offset: 0x00438E6C
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

		// Token: 0x17008B6B RID: 35691
		// (get) Token: 0x0601E306 RID: 123654 RVA: 0x0043ACCC File Offset: 0x00438ECC
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

		// Token: 0x17008B6C RID: 35692
		// (get) Token: 0x0601E307 RID: 123655 RVA: 0x0043AD2C File Offset: 0x00438F2C
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

		// Token: 0x17008B6D RID: 35693
		// (get) Token: 0x0601E308 RID: 123656 RVA: 0x0043AD8C File Offset: 0x00438F8C
		public bool IsEnableBottomAoiCheck
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008B6E RID: 35694
		// (get) Token: 0x0601E309 RID: 123657 RVA: 0x0043ADCC File Offset: 0x00438FCC
		public bool IsLimitFloatBoxWidth
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008B6F RID: 35695
		// (get) Token: 0x0601E30A RID: 123658 RVA: 0x0043AE0C File Offset: 0x0043900C
		public bool IsEnableAutoSaveRes
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008B70 RID: 35696
		// (get) Token: 0x0601E30B RID: 123659 RVA: 0x0043AE4C File Offset: 0x0043904C
		public bool IsAskWhenAutoSaveError
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008B71 RID: 35697
		// (get) Token: 0x0601E30C RID: 123660 RVA: 0x0043AE8C File Offset: 0x0043908C
		public bool IsLoadActorWhenJumpEntity
		{
			get
			{
				int num = this.__p.__offset(46);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008B72 RID: 35698
		// (get) Token: 0x0601E30D RID: 123661 RVA: 0x0043AECC File Offset: 0x004390CC
		public bool IsStayInMainWpWhenNavigateSubWpEntity
		{
			get
			{
				int num = this.__p.__offset(48);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008B73 RID: 35699
		// (get) Token: 0x0601E30E RID: 123662 RVA: 0x0043AF0C File Offset: 0x0043910C
		public EEntityActorLoadMode EntityActorLoadMode
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return EEntityActorLoadMode.Self;
				}
				return (EEntityActorLoadMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008B74 RID: 35700
		// (get) Token: 0x0601E30F RID: 123663 RVA: 0x0043AF4C File Offset: 0x0043914C
		public bool IsAskWhenLoadActor
		{
			get
			{
				int num = this.__p.__offset(52);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008B75 RID: 35701
		// (get) Token: 0x0601E310 RID: 123664 RVA: 0x0043AF8C File Offset: 0x0043918C
		public int ActorLoadCellSize
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

		// Token: 0x17008B76 RID: 35702
		// (get) Token: 0x0601E311 RID: 123665 RVA: 0x0043AFCC File Offset: 0x004391CC
		public int ParentChildAndActorDepth
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

		// Token: 0x17008B77 RID: 35703
		// (get) Token: 0x0601E312 RID: 123666 RVA: 0x0043B00C File Offset: 0x0043920C
		public int ParentChildAndActorLoadedActorTypes
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

		// Token: 0x17008B78 RID: 35704
		// (get) Token: 0x0601E313 RID: 123667 RVA: 0x0043B04C File Offset: 0x0043924C
		public int ParentChildAndActorExcludeFolders
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

		// Token: 0x17008B79 RID: 35705
		// (get) Token: 0x0601E314 RID: 123668 RVA: 0x0043B08C File Offset: 0x0043928C
		public EActorDeleteMode ActorDeleteMode
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return EActorDeleteMode.AskUser;
				}
				return (EActorDeleteMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008B7A RID: 35706
		// (get) Token: 0x0601E315 RID: 123669 RVA: 0x0043B0CC File Offset: 0x004392CC
		public bool IsAskWhenOpenExcel
		{
			get
			{
				int num = this.__p.__offset(64);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601E316 RID: 123670 RVA: 0x0043B10C File Offset: 0x0043930C
		public Record_String_Boolean? SilentRunTestConfig(int j)
		{
			int num = this.__p.__offset(66);
			if (num == 0)
			{
				return null;
			}
			return new Record_String_Boolean?(default(Record_String_Boolean).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008B7B RID: 35707
		// (get) Token: 0x0601E317 RID: 123671 RVA: 0x0043B170 File Offset: 0x00439370
		public int SilentRunTestConfigLength
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

		// Token: 0x0601E318 RID: 123672 RVA: 0x0043B19C File Offset: 0x0043939C
		public Record_String_Boolean? AutoRunTestConfig(int j)
		{
			int num = this.__p.__offset(68);
			if (num == 0)
			{
				return null;
			}
			return new Record_String_Boolean?(default(Record_String_Boolean).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008B7C RID: 35708
		// (get) Token: 0x0601E319 RID: 123673 RVA: 0x0043B200 File Offset: 0x00439400
		public int AutoRunTestConfigLength
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

		// Token: 0x17008B7D RID: 35709
		// (get) Token: 0x0601E31A RID: 123674 RVA: 0x0043B22C File Offset: 0x0043942C
		public bool IsDebugTest
		{
			get
			{
				int num = this.__p.__offset(70);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008B7E RID: 35710
		// (get) Token: 0x0601E31B RID: 123675 RVA: 0x0043B26C File Offset: 0x0043946C
		public EActionDisabledType ActionDisabledType
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return EActionDisabledType.SmartDisabled;
				}
				return (EActionDisabledType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008B7F RID: 35711
		// (get) Token: 0x0601E31C RID: 123676 RVA: 0x0043B2AC File Offset: 0x004394AC
		public ETreeNodeDisabledType TreeNodeDisabledType
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return ETreeNodeDisabledType.LocalDisabled;
				}
				return (ETreeNodeDisabledType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008B80 RID: 35712
		// (get) Token: 0x0601E31D RID: 123677 RVA: 0x0043B2EC File Offset: 0x004394EC
		public bool ShowClipboardTipsInStatusBar
		{
			get
			{
				int num = this.__p.__offset(76);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008B81 RID: 35713
		// (get) Token: 0x0601E31E RID: 123678 RVA: 0x0043B32C File Offset: 0x0043952C
		public bool IsAllowDragDropArray
		{
			get
			{
				int num = this.__p.__offset(78);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008B82 RID: 35714
		// (get) Token: 0x0601E31F RID: 123679 RVA: 0x0043B36C File Offset: 0x0043956C
		public EActionHelpClickMode ActionHelpClickMode
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return EActionHelpClickMode.OpenDetailByClick;
				}
				return (EActionHelpClickMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008B83 RID: 35715
		// (get) Token: 0x0601E320 RID: 123680 RVA: 0x0043B3AC File Offset: 0x004395AC
		public string AkiBasePath
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

		// Token: 0x0601E321 RID: 123681 RVA: 0x0043B3E4 File Offset: 0x004395E4
		public Span<byte> GetAkiBasePathBytes()
		{
			return this.__p.__vector_as_span<byte>(82, 1);
		}

		// Token: 0x0601E322 RID: 123682 RVA: 0x0043B3F4 File Offset: 0x004395F4
		public byte[] GetAkiBasePathArray()
		{
			return this.__p.__vector_as_array<byte>(82);
		}

		// Token: 0x17008B84 RID: 35716
		// (get) Token: 0x0601E323 RID: 123683 RVA: 0x0043B404 File Offset: 0x00439604
		public string ExternalJsonEditor
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E324 RID: 123684 RVA: 0x0043B43C File Offset: 0x0043963C
		public Span<byte> GetExternalJsonEditorBytes()
		{
			return this.__p.__vector_as_span<byte>(84, 1);
		}

		// Token: 0x0601E325 RID: 123685 RVA: 0x0043B44C File Offset: 0x0043964C
		public byte[] GetExternalJsonEditorArray()
		{
			return this.__p.__vector_as_array<byte>(84);
		}

		// Token: 0x0601E326 RID: 123686 RVA: 0x0043B45C File Offset: 0x0043965C
		public static Offset<IEditorConfig> CreateIEditorConfig(FlatBufferBuilder builder, StringOffset VersionOffset = default(StringOffset), bool ShowId = false, bool ShowFlowEditorError = false, Offset<IFlowStateIndex> LastPlayFlowOffset = default(Offset<IFlowStateIndex>), StringOffset CsvNameOffset = default(StringOffset), VectorOffset RecentLevelsOffset = default(VectorOffset), VectorOffset RecentSubWpMapsOffset = default(VectorOffset), bool EnableRecentSelectRecord = false, EMaximumDisplayCountInSelector MaximumDisplayCountInSelector = EMaximumDisplayCountInSelector.None, ERecentSelectRecordMode RecentSelectRecordMode = ERecentSelectRecordMode.SortByCount, bool EnableAutoUpdateFile = false, bool IsTransientEntityModeDisable = false, bool IsAllowSubmitNotOriginFile = false, bool IsAllowSubmitAllWpActor = false, Offset<ILaunchSettingShowInMainEditor> SettingShowInMainEditorOffset = default(Offset<ILaunchSettingShowInMainEditor>), Offset<IEditorStartConfig> EditorStartConfigOffset = default(Offset<IEditorStartConfig>), Offset<IEditorIndentationDisplaySetting> IndentationDisplaySettingOffset = default(Offset<IEditorIndentationDisplaySetting>), bool IsEnableBottomAoiCheck = false, bool IsLimitFloatBoxWidth = false, bool IsEnableAutoSaveRes = false, bool IsAskWhenAutoSaveError = false, bool IsLoadActorWhenJumpEntity = false, bool IsStayInMainWpWhenNavigateSubWpEntity = false, EEntityActorLoadMode EntityActorLoadMode = EEntityActorLoadMode.Self, bool IsAskWhenLoadActor = false, int ActorLoadCellSize = 0, int ParentChildAndActorDepth = 0, int ParentChildAndActorLoadedActorTypes = 0, int ParentChildAndActorExcludeFolders = 0, EActorDeleteMode ActorDeleteMode = EActorDeleteMode.AskUser, bool IsAskWhenOpenExcel = false, VectorOffset SilentRunTestConfigOffset = default(VectorOffset), VectorOffset AutoRunTestConfigOffset = default(VectorOffset), bool IsDebugTest = false, EActionDisabledType ActionDisabledType = EActionDisabledType.SmartDisabled, ETreeNodeDisabledType TreeNodeDisabledType = ETreeNodeDisabledType.LocalDisabled, bool ShowClipboardTipsInStatusBar = false, bool IsAllowDragDropArray = false, EActionHelpClickMode ActionHelpClickMode = EActionHelpClickMode.OpenDetailByClick, StringOffset AkiBasePathOffset = default(StringOffset), StringOffset ExternalJsonEditorOffset = default(StringOffset))
		{
			builder.StartTable(41);
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
			IEditorConfig.AddIsStayInMainWpWhenNavigateSubWpEntity(builder, IsStayInMainWpWhenNavigateSubWpEntity);
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

		// Token: 0x0601E327 RID: 123687 RVA: 0x0043B5BC File Offset: 0x004397BC
		public static void StartIEditorConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(41);
		}

		// Token: 0x0601E328 RID: 123688 RVA: 0x0043B5C6 File Offset: 0x004397C6
		public static void AddVersion(FlatBufferBuilder builder, StringOffset versionOffset)
		{
			builder.AddOffset(0, versionOffset.Value, 0);
		}

		// Token: 0x0601E329 RID: 123689 RVA: 0x0043B5D6 File Offset: 0x004397D6
		public static void AddShowId(FlatBufferBuilder builder, bool showId)
		{
			builder.AddBool(1, showId, false);
		}

		// Token: 0x0601E32A RID: 123690 RVA: 0x0043B5E1 File Offset: 0x004397E1
		public static void AddShowFlowEditorError(FlatBufferBuilder builder, bool showFlowEditorError)
		{
			builder.AddBool(2, showFlowEditorError, false);
		}

		// Token: 0x0601E32B RID: 123691 RVA: 0x0043B5EC File Offset: 0x004397EC
		public static void AddLastPlayFlow(FlatBufferBuilder builder, Offset<IFlowStateIndex> lastPlayFlowOffset)
		{
			builder.AddOffset(3, lastPlayFlowOffset.Value, 0);
		}

		// Token: 0x0601E32C RID: 123692 RVA: 0x0043B5FC File Offset: 0x004397FC
		public static void AddCsvName(FlatBufferBuilder builder, StringOffset csvNameOffset)
		{
			builder.AddOffset(4, csvNameOffset.Value, 0);
		}

		// Token: 0x0601E32D RID: 123693 RVA: 0x0043B60C File Offset: 0x0043980C
		public static void AddRecentLevels(FlatBufferBuilder builder, VectorOffset recentLevelsOffset)
		{
			builder.AddOffset(5, recentLevelsOffset.Value, 0);
		}

		// Token: 0x0601E32E RID: 123694 RVA: 0x0043B61C File Offset: 0x0043981C
		public static VectorOffset CreateRecentLevelsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E32F RID: 123695 RVA: 0x0043B653 File Offset: 0x00439853
		public static VectorOffset CreateRecentLevelsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E330 RID: 123696 RVA: 0x0043B66D File Offset: 0x0043986D
		public static VectorOffset CreateRecentLevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E331 RID: 123697 RVA: 0x0043B68B File Offset: 0x0043988B
		public static VectorOffset CreateRecentLevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E332 RID: 123698 RVA: 0x0043B6A4 File Offset: 0x004398A4
		public static void StartRecentLevelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E333 RID: 123699 RVA: 0x0043B6AF File Offset: 0x004398AF
		public static void AddRecentSubWpMaps(FlatBufferBuilder builder, VectorOffset recentSubWpMapsOffset)
		{
			builder.AddOffset(6, recentSubWpMapsOffset.Value, 0);
		}

		// Token: 0x0601E334 RID: 123700 RVA: 0x0043B6C0 File Offset: 0x004398C0
		public static VectorOffset CreateRecentSubWpMapsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E335 RID: 123701 RVA: 0x0043B6F7 File Offset: 0x004398F7
		public static VectorOffset CreateRecentSubWpMapsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E336 RID: 123702 RVA: 0x0043B711 File Offset: 0x00439911
		public static VectorOffset CreateRecentSubWpMapsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E337 RID: 123703 RVA: 0x0043B72F File Offset: 0x0043992F
		public static VectorOffset CreateRecentSubWpMapsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E338 RID: 123704 RVA: 0x0043B748 File Offset: 0x00439948
		public static void StartRecentSubWpMapsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E339 RID: 123705 RVA: 0x0043B753 File Offset: 0x00439953
		public static void AddEnableRecentSelectRecord(FlatBufferBuilder builder, bool enableRecentSelectRecord)
		{
			builder.AddBool(7, enableRecentSelectRecord, false);
		}

		// Token: 0x0601E33A RID: 123706 RVA: 0x0043B75E File Offset: 0x0043995E
		public static void AddMaximumDisplayCountInSelector(FlatBufferBuilder builder, EMaximumDisplayCountInSelector maximumDisplayCountInSelector)
		{
			builder.AddByte(8, (byte)maximumDisplayCountInSelector, 0);
		}

		// Token: 0x0601E33B RID: 123707 RVA: 0x0043B769 File Offset: 0x00439969
		public static void AddRecentSelectRecordMode(FlatBufferBuilder builder, ERecentSelectRecordMode recentSelectRecordMode)
		{
			builder.AddByte(9, (byte)recentSelectRecordMode, 0);
		}

		// Token: 0x0601E33C RID: 123708 RVA: 0x0043B775 File Offset: 0x00439975
		public static void AddEnableAutoUpdateFile(FlatBufferBuilder builder, bool enableAutoUpdateFile)
		{
			builder.AddBool(10, enableAutoUpdateFile, false);
		}

		// Token: 0x0601E33D RID: 123709 RVA: 0x0043B781 File Offset: 0x00439981
		public static void AddIsTransientEntityModeDisable(FlatBufferBuilder builder, bool isTransientEntityModeDisable)
		{
			builder.AddBool(11, isTransientEntityModeDisable, false);
		}

		// Token: 0x0601E33E RID: 123710 RVA: 0x0043B78D File Offset: 0x0043998D
		public static void AddIsAllowSubmitNotOriginFile(FlatBufferBuilder builder, bool isAllowSubmitNotOriginFile)
		{
			builder.AddBool(12, isAllowSubmitNotOriginFile, false);
		}

		// Token: 0x0601E33F RID: 123711 RVA: 0x0043B799 File Offset: 0x00439999
		public static void AddIsAllowSubmitAllWpActor(FlatBufferBuilder builder, bool isAllowSubmitAllWpActor)
		{
			builder.AddBool(13, isAllowSubmitAllWpActor, false);
		}

		// Token: 0x0601E340 RID: 123712 RVA: 0x0043B7A5 File Offset: 0x004399A5
		public static void AddSettingShowInMainEditor(FlatBufferBuilder builder, Offset<ILaunchSettingShowInMainEditor> settingShowInMainEditorOffset)
		{
			builder.AddOffset(14, settingShowInMainEditorOffset.Value, 0);
		}

		// Token: 0x0601E341 RID: 123713 RVA: 0x0043B7B6 File Offset: 0x004399B6
		public static void AddEditorStartConfig(FlatBufferBuilder builder, Offset<IEditorStartConfig> editorStartConfigOffset)
		{
			builder.AddOffset(15, editorStartConfigOffset.Value, 0);
		}

		// Token: 0x0601E342 RID: 123714 RVA: 0x0043B7C7 File Offset: 0x004399C7
		public static void AddIndentationDisplaySetting(FlatBufferBuilder builder, Offset<IEditorIndentationDisplaySetting> indentationDisplaySettingOffset)
		{
			builder.AddOffset(16, indentationDisplaySettingOffset.Value, 0);
		}

		// Token: 0x0601E343 RID: 123715 RVA: 0x0043B7D8 File Offset: 0x004399D8
		public static void AddIsEnableBottomAoiCheck(FlatBufferBuilder builder, bool isEnableBottomAoiCheck)
		{
			builder.AddBool(17, isEnableBottomAoiCheck, false);
		}

		// Token: 0x0601E344 RID: 123716 RVA: 0x0043B7E4 File Offset: 0x004399E4
		public static void AddIsLimitFloatBoxWidth(FlatBufferBuilder builder, bool isLimitFloatBoxWidth)
		{
			builder.AddBool(18, isLimitFloatBoxWidth, false);
		}

		// Token: 0x0601E345 RID: 123717 RVA: 0x0043B7F0 File Offset: 0x004399F0
		public static void AddIsEnableAutoSaveRes(FlatBufferBuilder builder, bool isEnableAutoSaveRes)
		{
			builder.AddBool(19, isEnableAutoSaveRes, false);
		}

		// Token: 0x0601E346 RID: 123718 RVA: 0x0043B7FC File Offset: 0x004399FC
		public static void AddIsAskWhenAutoSaveError(FlatBufferBuilder builder, bool isAskWhenAutoSaveError)
		{
			builder.AddBool(20, isAskWhenAutoSaveError, false);
		}

		// Token: 0x0601E347 RID: 123719 RVA: 0x0043B808 File Offset: 0x00439A08
		public static void AddIsLoadActorWhenJumpEntity(FlatBufferBuilder builder, bool isLoadActorWhenJumpEntity)
		{
			builder.AddBool(21, isLoadActorWhenJumpEntity, false);
		}

		// Token: 0x0601E348 RID: 123720 RVA: 0x0043B814 File Offset: 0x00439A14
		public static void AddIsStayInMainWpWhenNavigateSubWpEntity(FlatBufferBuilder builder, bool isStayInMainWpWhenNavigateSubWpEntity)
		{
			builder.AddBool(22, isStayInMainWpWhenNavigateSubWpEntity, false);
		}

		// Token: 0x0601E349 RID: 123721 RVA: 0x0043B820 File Offset: 0x00439A20
		public static void AddEntityActorLoadMode(FlatBufferBuilder builder, EEntityActorLoadMode entityActorLoadMode)
		{
			builder.AddByte(23, (byte)entityActorLoadMode, 0);
		}

		// Token: 0x0601E34A RID: 123722 RVA: 0x0043B82C File Offset: 0x00439A2C
		public static void AddIsAskWhenLoadActor(FlatBufferBuilder builder, bool isAskWhenLoadActor)
		{
			builder.AddBool(24, isAskWhenLoadActor, false);
		}

		// Token: 0x0601E34B RID: 123723 RVA: 0x0043B838 File Offset: 0x00439A38
		public static void AddActorLoadCellSize(FlatBufferBuilder builder, int actorLoadCellSize)
		{
			builder.AddInt(25, actorLoadCellSize, 0);
		}

		// Token: 0x0601E34C RID: 123724 RVA: 0x0043B844 File Offset: 0x00439A44
		public static void AddParentChildAndActorDepth(FlatBufferBuilder builder, int parentChildAndActorDepth)
		{
			builder.AddInt(26, parentChildAndActorDepth, 0);
		}

		// Token: 0x0601E34D RID: 123725 RVA: 0x0043B850 File Offset: 0x00439A50
		public static void AddParentChildAndActorLoadedActorTypes(FlatBufferBuilder builder, int parentChildAndActorLoadedActorTypes)
		{
			builder.AddInt(27, parentChildAndActorLoadedActorTypes, 0);
		}

		// Token: 0x0601E34E RID: 123726 RVA: 0x0043B85C File Offset: 0x00439A5C
		public static void AddParentChildAndActorExcludeFolders(FlatBufferBuilder builder, int parentChildAndActorExcludeFolders)
		{
			builder.AddInt(28, parentChildAndActorExcludeFolders, 0);
		}

		// Token: 0x0601E34F RID: 123727 RVA: 0x0043B868 File Offset: 0x00439A68
		public static void AddActorDeleteMode(FlatBufferBuilder builder, EActorDeleteMode actorDeleteMode)
		{
			builder.AddByte(29, (byte)actorDeleteMode, 0);
		}

		// Token: 0x0601E350 RID: 123728 RVA: 0x0043B874 File Offset: 0x00439A74
		public static void AddIsAskWhenOpenExcel(FlatBufferBuilder builder, bool isAskWhenOpenExcel)
		{
			builder.AddBool(30, isAskWhenOpenExcel, false);
		}

		// Token: 0x0601E351 RID: 123729 RVA: 0x0043B880 File Offset: 0x00439A80
		public static void AddSilentRunTestConfig(FlatBufferBuilder builder, VectorOffset silentRunTestConfigOffset)
		{
			builder.AddOffset(31, silentRunTestConfigOffset.Value, 0);
		}

		// Token: 0x0601E352 RID: 123730 RVA: 0x0043B894 File Offset: 0x00439A94
		public static VectorOffset CreateSilentRunTestConfigVector(FlatBufferBuilder builder, Offset<Record_String_Boolean>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E353 RID: 123731 RVA: 0x0043B8D4 File Offset: 0x00439AD4
		public static VectorOffset CreateSilentRunTestConfigVectorBlock(FlatBufferBuilder builder, Offset<Record_String_Boolean>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_String_Boolean>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E354 RID: 123732 RVA: 0x0043B8EE File Offset: 0x00439AEE
		public static VectorOffset CreateSilentRunTestConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_String_Boolean>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_String_Boolean>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E355 RID: 123733 RVA: 0x0043B90C File Offset: 0x00439B0C
		public static VectorOffset CreateSilentRunTestConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_String_Boolean>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E356 RID: 123734 RVA: 0x0043B925 File Offset: 0x00439B25
		public static void StartSilentRunTestConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E357 RID: 123735 RVA: 0x0043B930 File Offset: 0x00439B30
		public static void AddAutoRunTestConfig(FlatBufferBuilder builder, VectorOffset autoRunTestConfigOffset)
		{
			builder.AddOffset(32, autoRunTestConfigOffset.Value, 0);
		}

		// Token: 0x0601E358 RID: 123736 RVA: 0x0043B944 File Offset: 0x00439B44
		public static VectorOffset CreateAutoRunTestConfigVector(FlatBufferBuilder builder, Offset<Record_String_Boolean>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E359 RID: 123737 RVA: 0x0043B984 File Offset: 0x00439B84
		public static VectorOffset CreateAutoRunTestConfigVectorBlock(FlatBufferBuilder builder, Offset<Record_String_Boolean>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_String_Boolean>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E35A RID: 123738 RVA: 0x0043B99E File Offset: 0x00439B9E
		public static VectorOffset CreateAutoRunTestConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_String_Boolean>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_String_Boolean>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E35B RID: 123739 RVA: 0x0043B9BC File Offset: 0x00439BBC
		public static VectorOffset CreateAutoRunTestConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_String_Boolean>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E35C RID: 123740 RVA: 0x0043B9D5 File Offset: 0x00439BD5
		public static void StartAutoRunTestConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E35D RID: 123741 RVA: 0x0043B9E0 File Offset: 0x00439BE0
		public static void AddIsDebugTest(FlatBufferBuilder builder, bool isDebugTest)
		{
			builder.AddBool(33, isDebugTest, false);
		}

		// Token: 0x0601E35E RID: 123742 RVA: 0x0043B9EC File Offset: 0x00439BEC
		public static void AddActionDisabledType(FlatBufferBuilder builder, EActionDisabledType actionDisabledType)
		{
			builder.AddByte(34, (byte)actionDisabledType, 0);
		}

		// Token: 0x0601E35F RID: 123743 RVA: 0x0043B9F8 File Offset: 0x00439BF8
		public static void AddTreeNodeDisabledType(FlatBufferBuilder builder, ETreeNodeDisabledType treeNodeDisabledType)
		{
			builder.AddByte(35, (byte)treeNodeDisabledType, 0);
		}

		// Token: 0x0601E360 RID: 123744 RVA: 0x0043BA04 File Offset: 0x00439C04
		public static void AddShowClipboardTipsInStatusBar(FlatBufferBuilder builder, bool showClipboardTipsInStatusBar)
		{
			builder.AddBool(36, showClipboardTipsInStatusBar, false);
		}

		// Token: 0x0601E361 RID: 123745 RVA: 0x0043BA10 File Offset: 0x00439C10
		public static void AddIsAllowDragDropArray(FlatBufferBuilder builder, bool isAllowDragDropArray)
		{
			builder.AddBool(37, isAllowDragDropArray, false);
		}

		// Token: 0x0601E362 RID: 123746 RVA: 0x0043BA1C File Offset: 0x00439C1C
		public static void AddActionHelpClickMode(FlatBufferBuilder builder, EActionHelpClickMode actionHelpClickMode)
		{
			builder.AddByte(38, (byte)actionHelpClickMode, 0);
		}

		// Token: 0x0601E363 RID: 123747 RVA: 0x0043BA28 File Offset: 0x00439C28
		public static void AddAkiBasePath(FlatBufferBuilder builder, StringOffset akiBasePathOffset)
		{
			builder.AddOffset(39, akiBasePathOffset.Value, 0);
		}

		// Token: 0x0601E364 RID: 123748 RVA: 0x0043BA39 File Offset: 0x00439C39
		public static void AddExternalJsonEditor(FlatBufferBuilder builder, StringOffset externalJsonEditorOffset)
		{
			builder.AddOffset(40, externalJsonEditorOffset.Value, 0);
		}

		// Token: 0x0601E365 RID: 123749 RVA: 0x0043BA4A File Offset: 0x00439C4A
		public static Offset<IEditorConfig> EndIEditorConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEditorConfig>(builder.EndTable());
		}

		// Token: 0x0601E366 RID: 123750 RVA: 0x0043BA58 File Offset: 0x00439C58
		public IEditorConfigT UnPack()
		{
			IEditorConfigT editorConfigT = new IEditorConfigT();
			this.UnPackTo(editorConfigT);
			return editorConfigT;
		}

		// Token: 0x0601E367 RID: 123751 RVA: 0x0043BA74 File Offset: 0x00439C74
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
			_o.IsStayInMainWpWhenNavigateSubWpEntity = this.IsStayInMainWpWhenNavigateSubWpEntity;
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

		// Token: 0x0601E368 RID: 123752 RVA: 0x0043BDE4 File Offset: 0x00439FE4
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
			return IEditorConfig.CreateIEditorConfig(builder, versionOffset, _o.ShowId, _o.ShowFlowEditorError, lastPlayFlowOffset, csvNameOffset, recentLevelsOffset, recentSubWpMapsOffset, _o.EnableRecentSelectRecord, _o.MaximumDisplayCountInSelector, _o.RecentSelectRecordMode, _o.EnableAutoUpdateFile, _o.IsTransientEntityModeDisable, _o.IsAllowSubmitNotOriginFile, _o.IsAllowSubmitAllWpActor, settingShowInMainEditorOffset, editorStartConfigOffset, indentationDisplaySettingOffset, _o.IsEnableBottomAoiCheck, _o.IsLimitFloatBoxWidth, _o.IsEnableAutoSaveRes, _o.IsAskWhenAutoSaveError, _o.IsLoadActorWhenJumpEntity, _o.IsStayInMainWpWhenNavigateSubWpEntity, _o.EntityActorLoadMode, _o.IsAskWhenLoadActor, _o.ActorLoadCellSize, _o.ParentChildAndActorDepth, _o.ParentChildAndActorLoadedActorTypes, _o.ParentChildAndActorExcludeFolders, _o.ActorDeleteMode, _o.IsAskWhenOpenExcel, silentRunTestConfigOffset, autoRunTestConfigOffset, _o.IsDebugTest, _o.ActionDisabledType, _o.TreeNodeDisabledType, _o.ShowClipboardTipsInStatusBar, _o.IsAllowDragDropArray, _o.ActionHelpClickMode, akiBasePathOffset, externalJsonEditorOffset);
		}

		// Token: 0x0400D7D6 RID: 55254
		private Table __p;
	}
}
