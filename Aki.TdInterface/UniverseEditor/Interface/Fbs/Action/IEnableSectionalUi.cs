using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CFB RID: 27899
	public struct IEnableSectionalUi : IFlatbufferObject
	{
		// Token: 0x1700CC9D RID: 52381
		// (get) Token: 0x0603018E RID: 197006 RVA: 0x0068ACFC File Offset: 0x00688EFC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603018F RID: 197007 RVA: 0x0068AD09 File Offset: 0x00688F09
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030190 RID: 197008 RVA: 0x0068AD10 File Offset: 0x00688F10
		public static IEnableSectionalUi GetRootAsIEnableSectionalUi(ByteBuffer _bb)
		{
			return IEnableSectionalUi.GetRootAsIEnableSectionalUi(_bb, default(IEnableSectionalUi));
		}

		// Token: 0x06030191 RID: 197009 RVA: 0x0068AD2C File Offset: 0x00688F2C
		public static IEnableSectionalUi GetRootAsIEnableSectionalUi(ByteBuffer _bb, IEnableSectionalUi obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030192 RID: 197010 RVA: 0x0068AD49 File Offset: 0x00688F49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030193 RID: 197011 RVA: 0x0068AD58 File Offset: 0x00688F58
		public IEnableSectionalUi __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC9E RID: 52382
		// (get) Token: 0x06030194 RID: 197012 RVA: 0x0068AD68 File Offset: 0x00688F68
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

		// Token: 0x1700CC9F RID: 52383
		// (get) Token: 0x06030195 RID: 197013 RVA: 0x0068ADA4 File Offset: 0x00688FA4
		public bool ShowMiniMap
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CCA0 RID: 52384
		// (get) Token: 0x06030196 RID: 197014 RVA: 0x0068ADE4 File Offset: 0x00688FE4
		public bool ShowQuestTrack
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CCA1 RID: 52385
		// (get) Token: 0x06030197 RID: 197015 RVA: 0x0068AE24 File Offset: 0x00689024
		public bool ShowEsc
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CCA2 RID: 52386
		// (get) Token: 0x06030198 RID: 197016 RVA: 0x0068AE64 File Offset: 0x00689064
		public bool ShowSystem
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CCA3 RID: 52387
		// (get) Token: 0x06030199 RID: 197017 RVA: 0x0068AEA4 File Offset: 0x006890A4
		public bool ShowScreenEffect
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CCA4 RID: 52388
		// (get) Token: 0x0603019A RID: 197018 RVA: 0x0068AEE4 File Offset: 0x006890E4
		public bool ShowRoleFormation
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CCA5 RID: 52389
		// (get) Token: 0x0603019B RID: 197019 RVA: 0x0068AF24 File Offset: 0x00689124
		public bool ShowRoleStatus
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CCA6 RID: 52390
		// (get) Token: 0x0603019C RID: 197020 RVA: 0x0068AF64 File Offset: 0x00689164
		public bool ShowBossStatus
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CCA7 RID: 52391
		// (get) Token: 0x0603019D RID: 197021 RVA: 0x0068AFA4 File Offset: 0x006891A4
		public bool ShowGuideLayer
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CCA8 RID: 52392
		// (get) Token: 0x0603019E RID: 197022 RVA: 0x0068AFE4 File Offset: 0x006891E4
		public bool ShowMonsterHpBar
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CCA9 RID: 52393
		// (get) Token: 0x0603019F RID: 197023 RVA: 0x0068B024 File Offset: 0x00689224
		public bool ShowDamageText
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CCAA RID: 52394
		// (get) Token: 0x060301A0 RID: 197024 RVA: 0x0068B064 File Offset: 0x00689264
		public bool ShowPing
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CCAB RID: 52395
		// (get) Token: 0x060301A1 RID: 197025 RVA: 0x0068B0A4 File Offset: 0x006892A4
		public bool ShowOther
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060301A2 RID: 197026 RVA: 0x0068B0E4 File Offset: 0x006892E4
		public EUiElement AlwaysShowUiSections(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return EUiElement.Guide;
			}
			return (EUiElement)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700CCAC RID: 52396
		// (get) Token: 0x060301A3 RID: 197027 RVA: 0x0068B124 File Offset: 0x00689324
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

		// Token: 0x060301A4 RID: 197028 RVA: 0x0068B150 File Offset: 0x00689350
		public Span<EUiElement> GetAlwaysShowUiSectionsBytes()
		{
			return this.__p.__vector_as_span<EUiElement>(32, 1);
		}

		// Token: 0x060301A5 RID: 197029 RVA: 0x0068B160 File Offset: 0x00689360
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

		// Token: 0x1700CCAD RID: 52397
		// (get) Token: 0x060301A6 RID: 197030 RVA: 0x0068B1CC File Offset: 0x006893CC
		public bool ShowPositionOfficial
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CCAE RID: 52398
		// (get) Token: 0x060301A7 RID: 197031 RVA: 0x0068B20C File Offset: 0x0068940C
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

		// Token: 0x060301A8 RID: 197032 RVA: 0x0068B24C File Offset: 0x0068944C
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

		// Token: 0x060301A9 RID: 197033 RVA: 0x0068B2EC File Offset: 0x006894EC
		public static void StartIEnableSectionalUi(FlatBufferBuilder builder)
		{
			builder.StartTable(17);
		}

		// Token: 0x060301AA RID: 197034 RVA: 0x0068B2F6 File Offset: 0x006894F6
		public static void AddType(FlatBufferBuilder builder, EUiOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060301AB RID: 197035 RVA: 0x0068B301 File Offset: 0x00689501
		public static void AddShowMiniMap(FlatBufferBuilder builder, bool showMiniMap)
		{
			builder.AddBool(1, showMiniMap, false);
		}

		// Token: 0x060301AC RID: 197036 RVA: 0x0068B30C File Offset: 0x0068950C
		public static void AddShowQuestTrack(FlatBufferBuilder builder, bool showQuestTrack)
		{
			builder.AddBool(2, showQuestTrack, false);
		}

		// Token: 0x060301AD RID: 197037 RVA: 0x0068B317 File Offset: 0x00689517
		public static void AddShowEsc(FlatBufferBuilder builder, bool showEsc)
		{
			builder.AddBool(3, showEsc, false);
		}

		// Token: 0x060301AE RID: 197038 RVA: 0x0068B322 File Offset: 0x00689522
		public static void AddShowSystem(FlatBufferBuilder builder, bool showSystem)
		{
			builder.AddBool(4, showSystem, false);
		}

		// Token: 0x060301AF RID: 197039 RVA: 0x0068B32D File Offset: 0x0068952D
		public static void AddShowScreenEffect(FlatBufferBuilder builder, bool showScreenEffect)
		{
			builder.AddBool(5, showScreenEffect, false);
		}

		// Token: 0x060301B0 RID: 197040 RVA: 0x0068B338 File Offset: 0x00689538
		public static void AddShowRoleFormation(FlatBufferBuilder builder, bool showRoleFormation)
		{
			builder.AddBool(6, showRoleFormation, false);
		}

		// Token: 0x060301B1 RID: 197041 RVA: 0x0068B343 File Offset: 0x00689543
		public static void AddShowRoleStatus(FlatBufferBuilder builder, bool showRoleStatus)
		{
			builder.AddBool(7, showRoleStatus, false);
		}

		// Token: 0x060301B2 RID: 197042 RVA: 0x0068B34E File Offset: 0x0068954E
		public static void AddShowBossStatus(FlatBufferBuilder builder, bool showBossStatus)
		{
			builder.AddBool(8, showBossStatus, false);
		}

		// Token: 0x060301B3 RID: 197043 RVA: 0x0068B359 File Offset: 0x00689559
		public static void AddShowGuideLayer(FlatBufferBuilder builder, bool showGuideLayer)
		{
			builder.AddBool(9, showGuideLayer, false);
		}

		// Token: 0x060301B4 RID: 197044 RVA: 0x0068B365 File Offset: 0x00689565
		public static void AddShowMonsterHpBar(FlatBufferBuilder builder, bool showMonsterHpBar)
		{
			builder.AddBool(10, showMonsterHpBar, false);
		}

		// Token: 0x060301B5 RID: 197045 RVA: 0x0068B371 File Offset: 0x00689571
		public static void AddShowDamageText(FlatBufferBuilder builder, bool showDamageText)
		{
			builder.AddBool(11, showDamageText, false);
		}

		// Token: 0x060301B6 RID: 197046 RVA: 0x0068B37D File Offset: 0x0068957D
		public static void AddShowPing(FlatBufferBuilder builder, bool showPing)
		{
			builder.AddBool(12, showPing, false);
		}

		// Token: 0x060301B7 RID: 197047 RVA: 0x0068B389 File Offset: 0x00689589
		public static void AddShowOther(FlatBufferBuilder builder, bool showOther)
		{
			builder.AddBool(13, showOther, false);
		}

		// Token: 0x060301B8 RID: 197048 RVA: 0x0068B395 File Offset: 0x00689595
		public static void AddAlwaysShowUiSections(FlatBufferBuilder builder, VectorOffset alwaysShowUiSectionsOffset)
		{
			builder.AddOffset(14, alwaysShowUiSectionsOffset.Value, 0);
		}

		// Token: 0x060301B9 RID: 197049 RVA: 0x0068B3A8 File Offset: 0x006895A8
		public static VectorOffset CreateAlwaysShowUiSectionsVector(FlatBufferBuilder builder, EUiElement[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060301BA RID: 197050 RVA: 0x0068B3DF File Offset: 0x006895DF
		public static VectorOffset CreateAlwaysShowUiSectionsVectorBlock(FlatBufferBuilder builder, EUiElement[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EUiElement>(data);
			return builder.EndVector();
		}

		// Token: 0x060301BB RID: 197051 RVA: 0x0068B3F9 File Offset: 0x006895F9
		public static VectorOffset CreateAlwaysShowUiSectionsVectorBlock(FlatBufferBuilder builder, ArraySegment<EUiElement> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EUiElement>(data);
			return builder.EndVector();
		}

		// Token: 0x060301BC RID: 197052 RVA: 0x0068B417 File Offset: 0x00689617
		public static VectorOffset CreateAlwaysShowUiSectionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EUiElement>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060301BD RID: 197053 RVA: 0x0068B430 File Offset: 0x00689630
		public static void StartAlwaysShowUiSectionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060301BE RID: 197054 RVA: 0x0068B43B File Offset: 0x0068963B
		public static void AddShowPositionOfficial(FlatBufferBuilder builder, bool showPositionOfficial)
		{
			builder.AddBool(15, showPositionOfficial, false);
		}

		// Token: 0x060301BF RID: 197055 RVA: 0x0068B447 File Offset: 0x00689647
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(16, nullMask, 0);
		}

		// Token: 0x060301C0 RID: 197056 RVA: 0x0068B453 File Offset: 0x00689653
		public static Offset<IEnableSectionalUi> EndIEnableSectionalUi(FlatBufferBuilder builder)
		{
			return new Offset<IEnableSectionalUi>(builder.EndTable());
		}

		// Token: 0x060301C1 RID: 197057 RVA: 0x0068B460 File Offset: 0x00689660
		public IEnableSectionalUiT UnPack()
		{
			IEnableSectionalUiT enableSectionalUiT = new IEnableSectionalUiT();
			this.UnPackTo(enableSectionalUiT);
			return enableSectionalUiT;
		}

		// Token: 0x060301C2 RID: 197058 RVA: 0x0068B47C File Offset: 0x0068967C
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

		// Token: 0x060301C3 RID: 197059 RVA: 0x0068B578 File Offset: 0x00689778
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

		// Token: 0x04011B4F RID: 72527
		private Table __p;
	}
}
