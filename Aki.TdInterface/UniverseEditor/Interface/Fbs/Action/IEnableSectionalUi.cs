using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006681 RID: 26241
	public struct IEnableSectionalUi : IFlatbufferObject
	{
		// Token: 0x1700C2EC RID: 49900
		// (get) Token: 0x0602D971 RID: 186737 RVA: 0x0063DA48 File Offset: 0x0063BC48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D972 RID: 186738 RVA: 0x0063DA55 File Offset: 0x0063BC55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D973 RID: 186739 RVA: 0x0063DA5C File Offset: 0x0063BC5C
		public static IEnableSectionalUi GetRootAsIEnableSectionalUi(ByteBuffer _bb)
		{
			return IEnableSectionalUi.GetRootAsIEnableSectionalUi(_bb, default(IEnableSectionalUi));
		}

		// Token: 0x0602D974 RID: 186740 RVA: 0x0063DA78 File Offset: 0x0063BC78
		public static IEnableSectionalUi GetRootAsIEnableSectionalUi(ByteBuffer _bb, IEnableSectionalUi obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D975 RID: 186741 RVA: 0x0063DA95 File Offset: 0x0063BC95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D976 RID: 186742 RVA: 0x0063DAA4 File Offset: 0x0063BCA4
		public IEnableSectionalUi __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C2ED RID: 49901
		// (get) Token: 0x0602D977 RID: 186743 RVA: 0x0063DAB4 File Offset: 0x0063BCB4
		public EUiOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EUiOperationType.Enable;
				}
				return (EUiOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C2EE RID: 49902
		// (get) Token: 0x0602D978 RID: 186744 RVA: 0x0063DAF0 File Offset: 0x0063BCF0
		public bool ShowMiniMap
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2EF RID: 49903
		// (get) Token: 0x0602D979 RID: 186745 RVA: 0x0063DB30 File Offset: 0x0063BD30
		public bool ShowQuestTrack
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2F0 RID: 49904
		// (get) Token: 0x0602D97A RID: 186746 RVA: 0x0063DB70 File Offset: 0x0063BD70
		public bool ShowEsc
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2F1 RID: 49905
		// (get) Token: 0x0602D97B RID: 186747 RVA: 0x0063DBB0 File Offset: 0x0063BDB0
		public bool ShowSystem
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2F2 RID: 49906
		// (get) Token: 0x0602D97C RID: 186748 RVA: 0x0063DBF0 File Offset: 0x0063BDF0
		public bool ShowScreenEffect
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2F3 RID: 49907
		// (get) Token: 0x0602D97D RID: 186749 RVA: 0x0063DC30 File Offset: 0x0063BE30
		public bool ShowRoleFormation
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2F4 RID: 49908
		// (get) Token: 0x0602D97E RID: 186750 RVA: 0x0063DC70 File Offset: 0x0063BE70
		public bool ShowRoleStatus
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2F5 RID: 49909
		// (get) Token: 0x0602D97F RID: 186751 RVA: 0x0063DCB0 File Offset: 0x0063BEB0
		public bool ShowBossStatus
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2F6 RID: 49910
		// (get) Token: 0x0602D980 RID: 186752 RVA: 0x0063DCF0 File Offset: 0x0063BEF0
		public bool ShowGuideLayer
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2F7 RID: 49911
		// (get) Token: 0x0602D981 RID: 186753 RVA: 0x0063DD30 File Offset: 0x0063BF30
		public bool ShowMonsterHpBar
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2F8 RID: 49912
		// (get) Token: 0x0602D982 RID: 186754 RVA: 0x0063DD70 File Offset: 0x0063BF70
		public bool ShowDamageText
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2F9 RID: 49913
		// (get) Token: 0x0602D983 RID: 186755 RVA: 0x0063DDB0 File Offset: 0x0063BFB0
		public bool ShowPing
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2FA RID: 49914
		// (get) Token: 0x0602D984 RID: 186756 RVA: 0x0063DDF0 File Offset: 0x0063BFF0
		public bool ShowOther
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602D985 RID: 186757 RVA: 0x0063DE30 File Offset: 0x0063C030
		public EUiElement AlwaysShowUiSections(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return EUiElement.Guide;
			}
			return (EUiElement)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700C2FB RID: 49915
		// (get) Token: 0x0602D986 RID: 186758 RVA: 0x0063DE70 File Offset: 0x0063C070
		public int AlwaysShowUiSectionsLength
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

		// Token: 0x0602D987 RID: 186759 RVA: 0x0063DE9C File Offset: 0x0063C09C
		public Span<EUiElement> GetAlwaysShowUiSectionsBytes()
		{
			return this.__p.__vector_as_span<EUiElement>(32, 1);
		}

		// Token: 0x0602D988 RID: 186760 RVA: 0x0063DEAC File Offset: 0x0063C0AC
		public EUiElement[] GetAlwaysShowUiSectionsArray()
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			EUiElement[] array = new EUiElement[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (EUiElement)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x1700C2FC RID: 49916
		// (get) Token: 0x0602D989 RID: 186761 RVA: 0x0063DF18 File Offset: 0x0063C118
		public bool ShowPositionOfficial
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2FD RID: 49917
		// (get) Token: 0x0602D98A RID: 186762 RVA: 0x0063DF58 File Offset: 0x0063C158
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D98B RID: 186763 RVA: 0x0063DF98 File Offset: 0x0063C198
		public static Offset<IEnableSectionalUi> CreateIEnableSectionalUi(FlatBufferBuilder builder, EUiOperationType Type = EUiOperationType.Enable, bool ShowMiniMap = false, bool ShowQuestTrack = false, bool ShowEsc = false, bool ShowSystem = false, bool ShowScreenEffect = false, bool ShowRoleFormation = false, bool ShowRoleStatus = false, bool ShowBossStatus = false, bool ShowGuideLayer = false, bool ShowMonsterHpBar = false, bool ShowDamageText = false, bool ShowPing = false, bool ShowOther = false, VectorOffset AlwaysShowUiSectionsOffset = default(VectorOffset), bool ShowPositionOfficial = false, ushort NullMask = 0)
		{
			builder.StartTable(17);
			IEnableSectionalUi.AddAlwaysShowUiSections(builder, AlwaysShowUiSectionsOffset);
			IEnableSectionalUi.AddNullMask(builder, NullMask);
			IEnableSectionalUi.AddShowPositionOfficial(builder, ShowPositionOfficial);
			IEnableSectionalUi.AddShowOther(builder, ShowOther);
			IEnableSectionalUi.AddShowPing(builder, ShowPing);
			IEnableSectionalUi.AddShowDamageText(builder, ShowDamageText);
			IEnableSectionalUi.AddShowMonsterHpBar(builder, ShowMonsterHpBar);
			IEnableSectionalUi.AddShowGuideLayer(builder, ShowGuideLayer);
			IEnableSectionalUi.AddShowBossStatus(builder, ShowBossStatus);
			IEnableSectionalUi.AddShowRoleStatus(builder, ShowRoleStatus);
			IEnableSectionalUi.AddShowRoleFormation(builder, ShowRoleFormation);
			IEnableSectionalUi.AddShowScreenEffect(builder, ShowScreenEffect);
			IEnableSectionalUi.AddShowSystem(builder, ShowSystem);
			IEnableSectionalUi.AddShowEsc(builder, ShowEsc);
			IEnableSectionalUi.AddShowQuestTrack(builder, ShowQuestTrack);
			IEnableSectionalUi.AddShowMiniMap(builder, ShowMiniMap);
			IEnableSectionalUi.AddType(builder, Type);
			return IEnableSectionalUi.EndIEnableSectionalUi(builder);
		}

		// Token: 0x0602D98C RID: 186764 RVA: 0x0063E038 File Offset: 0x0063C238
		public static void StartIEnableSectionalUi(FlatBufferBuilder builder)
		{
			builder.StartTable(17);
		}

		// Token: 0x0602D98D RID: 186765 RVA: 0x0063E042 File Offset: 0x0063C242
		public static void AddType(FlatBufferBuilder builder, EUiOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D98E RID: 186766 RVA: 0x0063E04D File Offset: 0x0063C24D
		public static void AddShowMiniMap(FlatBufferBuilder builder, bool showMiniMap)
		{
			builder.AddBool(1, showMiniMap, false);
		}

		// Token: 0x0602D98F RID: 186767 RVA: 0x0063E058 File Offset: 0x0063C258
		public static void AddShowQuestTrack(FlatBufferBuilder builder, bool showQuestTrack)
		{
			builder.AddBool(2, showQuestTrack, false);
		}

		// Token: 0x0602D990 RID: 186768 RVA: 0x0063E063 File Offset: 0x0063C263
		public static void AddShowEsc(FlatBufferBuilder builder, bool showEsc)
		{
			builder.AddBool(3, showEsc, false);
		}

		// Token: 0x0602D991 RID: 186769 RVA: 0x0063E06E File Offset: 0x0063C26E
		public static void AddShowSystem(FlatBufferBuilder builder, bool showSystem)
		{
			builder.AddBool(4, showSystem, false);
		}

		// Token: 0x0602D992 RID: 186770 RVA: 0x0063E079 File Offset: 0x0063C279
		public static void AddShowScreenEffect(FlatBufferBuilder builder, bool showScreenEffect)
		{
			builder.AddBool(5, showScreenEffect, false);
		}

		// Token: 0x0602D993 RID: 186771 RVA: 0x0063E084 File Offset: 0x0063C284
		public static void AddShowRoleFormation(FlatBufferBuilder builder, bool showRoleFormation)
		{
			builder.AddBool(6, showRoleFormation, false);
		}

		// Token: 0x0602D994 RID: 186772 RVA: 0x0063E08F File Offset: 0x0063C28F
		public static void AddShowRoleStatus(FlatBufferBuilder builder, bool showRoleStatus)
		{
			builder.AddBool(7, showRoleStatus, false);
		}

		// Token: 0x0602D995 RID: 186773 RVA: 0x0063E09A File Offset: 0x0063C29A
		public static void AddShowBossStatus(FlatBufferBuilder builder, bool showBossStatus)
		{
			builder.AddBool(8, showBossStatus, false);
		}

		// Token: 0x0602D996 RID: 186774 RVA: 0x0063E0A5 File Offset: 0x0063C2A5
		public static void AddShowGuideLayer(FlatBufferBuilder builder, bool showGuideLayer)
		{
			builder.AddBool(9, showGuideLayer, false);
		}

		// Token: 0x0602D997 RID: 186775 RVA: 0x0063E0B1 File Offset: 0x0063C2B1
		public static void AddShowMonsterHpBar(FlatBufferBuilder builder, bool showMonsterHpBar)
		{
			builder.AddBool(10, showMonsterHpBar, false);
		}

		// Token: 0x0602D998 RID: 186776 RVA: 0x0063E0BD File Offset: 0x0063C2BD
		public static void AddShowDamageText(FlatBufferBuilder builder, bool showDamageText)
		{
			builder.AddBool(11, showDamageText, false);
		}

		// Token: 0x0602D999 RID: 186777 RVA: 0x0063E0C9 File Offset: 0x0063C2C9
		public static void AddShowPing(FlatBufferBuilder builder, bool showPing)
		{
			builder.AddBool(12, showPing, false);
		}

		// Token: 0x0602D99A RID: 186778 RVA: 0x0063E0D5 File Offset: 0x0063C2D5
		public static void AddShowOther(FlatBufferBuilder builder, bool showOther)
		{
			builder.AddBool(13, showOther, false);
		}

		// Token: 0x0602D99B RID: 186779 RVA: 0x0063E0E1 File Offset: 0x0063C2E1
		public static void AddAlwaysShowUiSections(FlatBufferBuilder builder, VectorOffset alwaysShowUiSectionsOffset)
		{
			builder.AddOffset(14, alwaysShowUiSectionsOffset.Value, 0);
		}

		// Token: 0x0602D99C RID: 186780 RVA: 0x0063E0F4 File Offset: 0x0063C2F4
		public static VectorOffset CreateAlwaysShowUiSectionsVector(FlatBufferBuilder builder, EUiElement[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602D99D RID: 186781 RVA: 0x0063E12B File Offset: 0x0063C32B
		public static VectorOffset CreateAlwaysShowUiSectionsVectorBlock(FlatBufferBuilder builder, EUiElement[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EUiElement>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D99E RID: 186782 RVA: 0x0063E145 File Offset: 0x0063C345
		public static VectorOffset CreateAlwaysShowUiSectionsVectorBlock(FlatBufferBuilder builder, ArraySegment<EUiElement> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EUiElement>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D99F RID: 186783 RVA: 0x0063E163 File Offset: 0x0063C363
		public static VectorOffset CreateAlwaysShowUiSectionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EUiElement>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602D9A0 RID: 186784 RVA: 0x0063E17C File Offset: 0x0063C37C
		public static void StartAlwaysShowUiSectionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602D9A1 RID: 186785 RVA: 0x0063E187 File Offset: 0x0063C387
		public static void AddShowPositionOfficial(FlatBufferBuilder builder, bool showPositionOfficial)
		{
			builder.AddBool(15, showPositionOfficial, false);
		}

		// Token: 0x0602D9A2 RID: 186786 RVA: 0x0063E193 File Offset: 0x0063C393
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(16, nullMask, 0);
		}

		// Token: 0x0602D9A3 RID: 186787 RVA: 0x0063E19F File Offset: 0x0063C39F
		public static Offset<IEnableSectionalUi> EndIEnableSectionalUi(FlatBufferBuilder builder)
		{
			return new Offset<IEnableSectionalUi>(builder.EndTable());
		}

		// Token: 0x0602D9A4 RID: 186788 RVA: 0x0063E1AC File Offset: 0x0063C3AC
		public IEnableSectionalUiT UnPack()
		{
			IEnableSectionalUiT enableSectionalUiT = new IEnableSectionalUiT();
			this.UnPackTo(enableSectionalUiT);
			return enableSectionalUiT;
		}

		// Token: 0x0602D9A5 RID: 186789 RVA: 0x0063E1C8 File Offset: 0x0063C3C8
		public void UnPackTo(IEnableSectionalUiT _o)
		{
			_o.Type = this.Type;
			_o.ShowMiniMap = this.ShowMiniMap;
			_o.ShowQuestTrack = this.ShowQuestTrack;
			_o.ShowEsc = this.ShowEsc;
			_o.ShowSystem = this.ShowSystem;
			_o.ShowScreenEffect = this.ShowScreenEffect;
			_o.ShowRoleFormation = this.ShowRoleFormation;
			_o.ShowRoleStatus = this.ShowRoleStatus;
			_o.ShowBossStatus = this.ShowBossStatus;
			_o.ShowGuideLayer = this.ShowGuideLayer;
			_o.ShowMonsterHpBar = this.ShowMonsterHpBar;
			_o.ShowDamageText = this.ShowDamageText;
			_o.ShowPing = this.ShowPing;
			_o.ShowOther = this.ShowOther;
			_o.AlwaysShowUiSections = new List<EUiElement>();
			for (int i = 0; i < this.AlwaysShowUiSectionsLength; i++)
			{
				_o.AlwaysShowUiSections.Add(this.AlwaysShowUiSections(i));
			}
			_o.ShowPositionOfficial = this.ShowPositionOfficial;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D9A6 RID: 186790 RVA: 0x0063E2C4 File Offset: 0x0063C4C4
		public static Offset<IEnableSectionalUi> Pack(FlatBufferBuilder builder, IEnableSectionalUiT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableSectionalUi>);
			}
			VectorOffset alwaysShowUiSectionsOffset = default(VectorOffset);
			if (_o.AlwaysShowUiSections != null)
			{
				EUiElement[] data = _o.AlwaysShowUiSections.ToArray();
				alwaysShowUiSectionsOffset = IEnableSectionalUi.CreateAlwaysShowUiSectionsVector(builder, data);
			}
			return IEnableSectionalUi.CreateIEnableSectionalUi(builder, _o.Type, _o.ShowMiniMap, _o.ShowQuestTrack, _o.ShowEsc, _o.ShowSystem, _o.ShowScreenEffect, _o.ShowRoleFormation, _o.ShowRoleStatus, _o.ShowBossStatus, _o.ShowGuideLayer, _o.ShowMonsterHpBar, _o.ShowDamageText, _o.ShowPing, _o.ShowOther, alwaysShowUiSectionsOffset, _o.ShowPositionOfficial, _o.NullMask);
		}

		// Token: 0x04010D29 RID: 68905
		private Table __p;
	}
}
