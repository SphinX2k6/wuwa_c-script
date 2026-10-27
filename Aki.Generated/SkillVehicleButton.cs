using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010C8 RID: 4296
	public struct SkillVehicleButton : IFlatbufferObject
	{
		// Token: 0x1700370A RID: 14090
		// (get) Token: 0x0600D5CE RID: 54734 RVA: 0x00319205 File Offset: 0x00317405
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D5CF RID: 54735 RVA: 0x00319212 File Offset: 0x00317412
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D5D0 RID: 54736 RVA: 0x0031921C File Offset: 0x0031741C
		public static SkillVehicleButton GetRootAsSkillVehicleButton(ByteBuffer _bb)
		{
			return SkillVehicleButton.GetRootAsSkillVehicleButton(_bb, default(SkillVehicleButton));
		}

		// Token: 0x0600D5D1 RID: 54737 RVA: 0x00319238 File Offset: 0x00317438
		public static SkillVehicleButton GetRootAsSkillVehicleButton(ByteBuffer _bb, SkillVehicleButton obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D5D2 RID: 54738 RVA: 0x00319255 File Offset: 0x00317455
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D5D3 RID: 54739 RVA: 0x00319264 File Offset: 0x00317464
		public SkillVehicleButton __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700370B RID: 14091
		// (get) Token: 0x0600D5D4 RID: 54740 RVA: 0x00319274 File Offset: 0x00317474
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

		// Token: 0x1700370C RID: 14092
		// (get) Token: 0x0600D5D5 RID: 54741 RVA: 0x003192B0 File Offset: 0x003174B0
		public int TemplateId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700370D RID: 14093
		// (get) Token: 0x0600D5D6 RID: 54742 RVA: 0x003192EC File Offset: 0x003174EC
		public string Name
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D5D7 RID: 54743 RVA: 0x00319323 File Offset: 0x00317523
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D5D8 RID: 54744 RVA: 0x00319332 File Offset: 0x00317532
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700370E RID: 14094
		// (get) Token: 0x0600D5D9 RID: 54745 RVA: 0x0031934C File Offset: 0x0031754C
		public int ButtonType
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

		// Token: 0x1700370F RID: 14095
		// (get) Token: 0x0600D5DA RID: 54746 RVA: 0x0031938C File Offset: 0x0031758C
		public int ActionType
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

		// Token: 0x17003710 RID: 14096
		// (get) Token: 0x0600D5DB RID: 54747 RVA: 0x003193CC File Offset: 0x003175CC
		public string ActionName
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

		// Token: 0x0600D5DC RID: 54748 RVA: 0x00319404 File Offset: 0x00317604
		public Span<byte> GetActionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D5DD RID: 54749 RVA: 0x00319414 File Offset: 0x00317614
		public byte[] GetActionNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003711 RID: 14097
		// (get) Token: 0x0600D5DE RID: 54750 RVA: 0x0031942C File Offset: 0x0031762C
		public int SkillId
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

		// Token: 0x0600D5DF RID: 54751 RVA: 0x0031946C File Offset: 0x0031766C
		public DicIntInt? SkillIdTagMap(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003712 RID: 14098
		// (get) Token: 0x0600D5E0 RID: 54752 RVA: 0x003194D0 File Offset: 0x003176D0
		public int SkillIdTagMapLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003713 RID: 14099
		// (get) Token: 0x0600D5E1 RID: 54753 RVA: 0x003194FC File Offset: 0x003176FC
		public string SkillIcon
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

		// Token: 0x0600D5E2 RID: 54754 RVA: 0x00319534 File Offset: 0x00317734
		public Span<byte> GetSkillIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600D5E3 RID: 54755 RVA: 0x00319544 File Offset: 0x00317744
		public byte[] GetSkillIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D5E4 RID: 54756 RVA: 0x0031955C File Offset: 0x0031775C
		public int SkillIconTags(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003714 RID: 14100
		// (get) Token: 0x0600D5E5 RID: 54757 RVA: 0x0031959C File Offset: 0x0031779C
		public int SkillIconTagsLength
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

		// Token: 0x0600D5E6 RID: 54758 RVA: 0x003195C8 File Offset: 0x003177C8
		public Span<int> GetSkillIconTagsBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600D5E7 RID: 54759 RVA: 0x003195D8 File Offset: 0x003177D8
		public int[] GetSkillIconTagsArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600D5E8 RID: 54760 RVA: 0x003195F0 File Offset: 0x003177F0
		public int EnableTags(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003715 RID: 14101
		// (get) Token: 0x0600D5E9 RID: 54761 RVA: 0x00319630 File Offset: 0x00317830
		public int EnableTagsLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D5EA RID: 54762 RVA: 0x0031965C File Offset: 0x0031785C
		public Span<int> GetEnableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600D5EB RID: 54763 RVA: 0x0031966C File Offset: 0x0031786C
		public int[] GetEnableTagsArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x0600D5EC RID: 54764 RVA: 0x00319684 File Offset: 0x00317884
		public int DisableTags(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003716 RID: 14102
		// (get) Token: 0x0600D5ED RID: 54765 RVA: 0x003196C4 File Offset: 0x003178C4
		public int DisableTagsLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D5EE RID: 54766 RVA: 0x003196F0 File Offset: 0x003178F0
		public Span<int> GetDisableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600D5EF RID: 54767 RVA: 0x00319700 File Offset: 0x00317900
		public int[] GetDisableTagsArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x0600D5F0 RID: 54768 RVA: 0x00319718 File Offset: 0x00317918
		public DicIntIntArray? DisableSkillIdTags(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003717 RID: 14103
		// (get) Token: 0x0600D5F1 RID: 54769 RVA: 0x0031977C File Offset: 0x0031797C
		public int DisableSkillIdTagsLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003718 RID: 14104
		// (get) Token: 0x0600D5F2 RID: 54770 RVA: 0x003197A8 File Offset: 0x003179A8
		public bool IsCdVisible
		{
			get
			{
				int num = this.__p.__offset(30);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003719 RID: 14105
		// (get) Token: 0x0600D5F3 RID: 54771 RVA: 0x003197E8 File Offset: 0x003179E8
		public int ElementId
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700371A RID: 14106
		// (get) Token: 0x0600D5F4 RID: 54772 RVA: 0x00319828 File Offset: 0x00317A28
		public int AttributeUsageMode
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

		// Token: 0x0600D5F5 RID: 54773 RVA: 0x00319868 File Offset: 0x00317A68
		public int AttributeUsageParams(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700371B RID: 14107
		// (get) Token: 0x0600D5F6 RID: 54774 RVA: 0x003198A8 File Offset: 0x00317AA8
		public int AttributeUsageParamsLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D5F7 RID: 54775 RVA: 0x003198D4 File Offset: 0x00317AD4
		public Span<int> GetAttributeUsageParamsBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x0600D5F8 RID: 54776 RVA: 0x003198E4 File Offset: 0x00317AE4
		public int[] GetAttributeUsageParamsArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x1700371C RID: 14108
		// (get) Token: 0x0600D5F9 RID: 54777 RVA: 0x003198FC File Offset: 0x00317AFC
		public int AttributeId
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

		// Token: 0x1700371D RID: 14109
		// (get) Token: 0x0600D5FA RID: 54778 RVA: 0x0031993C File Offset: 0x00317B3C
		public int MaxAttributeId
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

		// Token: 0x0600D5FB RID: 54779 RVA: 0x0031997C File Offset: 0x00317B7C
		public DicIntIntArray? AttributeIdTagMap(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700371E RID: 14110
		// (get) Token: 0x0600D5FC RID: 54780 RVA: 0x003199E0 File Offset: 0x00317BE0
		public int AttributeIdTagMapLength
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D5FD RID: 54781 RVA: 0x00319A0C File Offset: 0x00317C0C
		public int AttributeEnableTags(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700371F RID: 14111
		// (get) Token: 0x0600D5FE RID: 54782 RVA: 0x00319A4C File Offset: 0x00317C4C
		public int AttributeEnableTagsLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D5FF RID: 54783 RVA: 0x00319A78 File Offset: 0x00317C78
		public Span<int> GetAttributeEnableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(44, 4);
		}

		// Token: 0x0600D600 RID: 54784 RVA: 0x00319A88 File Offset: 0x00317C88
		public int[] GetAttributeEnableTagsArray()
		{
			return this.__p.__vector_as_array<int>(44) ?? Array.Empty<int>();
		}

		// Token: 0x17003720 RID: 14112
		// (get) Token: 0x0600D601 RID: 54785 RVA: 0x00319AA0 File Offset: 0x00317CA0
		public bool IsLongPressControlCamera
		{
			get
			{
				int num = this.__p.__offset(46);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003721 RID: 14113
		// (get) Token: 0x0600D602 RID: 54786 RVA: 0x00319AE0 File Offset: 0x00317CE0
		public int LongPressTime
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 500;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D603 RID: 54787 RVA: 0x00319B24 File Offset: 0x00317D24
		public DicIntInt? DynamicEffectTagMap(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003722 RID: 14114
		// (get) Token: 0x0600D604 RID: 54788 RVA: 0x00319B88 File Offset: 0x00317D88
		public int DynamicEffectTagMapLength
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

		// Token: 0x17003723 RID: 14115
		// (get) Token: 0x0600D605 RID: 54789 RVA: 0x00319BB4 File Offset: 0x00317DB4
		public bool ShowLongPress
		{
			get
			{
				int num = this.__p.__offset(52);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600D606 RID: 54790 RVA: 0x00319BF4 File Offset: 0x00317DF4
		public int ShowLongPressTags(int j)
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003724 RID: 14116
		// (get) Token: 0x0600D607 RID: 54791 RVA: 0x00319C34 File Offset: 0x00317E34
		public int ShowLongPressTagsLength
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D608 RID: 54792 RVA: 0x00319C60 File Offset: 0x00317E60
		public Span<int> GetShowLongPressTagsBytes()
		{
			return this.__p.__vector_as_span<int>(54, 4);
		}

		// Token: 0x0600D609 RID: 54793 RVA: 0x00319C70 File Offset: 0x00317E70
		public int[] GetShowLongPressTagsArray()
		{
			return this.__p.__vector_as_array<int>(54) ?? Array.Empty<int>();
		}

		// Token: 0x0600D60A RID: 54794 RVA: 0x00319C88 File Offset: 0x00317E88
		public int HideLongPressTags(int j)
		{
			int num = this.__p.__offset(56);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003725 RID: 14117
		// (get) Token: 0x0600D60B RID: 54795 RVA: 0x00319CC8 File Offset: 0x00317EC8
		public int HideLongPressTagsLength
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D60C RID: 54796 RVA: 0x00319CF4 File Offset: 0x00317EF4
		public Span<int> GetHideLongPressTagsBytes()
		{
			return this.__p.__vector_as_span<int>(56, 4);
		}

		// Token: 0x0600D60D RID: 54797 RVA: 0x00319D04 File Offset: 0x00317F04
		public int[] GetHideLongPressTagsArray()
		{
			return this.__p.__vector_as_array<int>(56) ?? Array.Empty<int>();
		}

		// Token: 0x0600D60E RID: 54798 RVA: 0x00319D1C File Offset: 0x00317F1C
		public int CustomHandleIds(int j)
		{
			int num = this.__p.__offset(58);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003726 RID: 14118
		// (get) Token: 0x0600D60F RID: 54799 RVA: 0x00319D5C File Offset: 0x00317F5C
		public int CustomHandleIdsLength
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

		// Token: 0x0600D610 RID: 54800 RVA: 0x00319D88 File Offset: 0x00317F88
		public Span<int> GetCustomHandleIdsBytes()
		{
			return this.__p.__vector_as_span<int>(58, 4);
		}

		// Token: 0x0600D611 RID: 54801 RVA: 0x00319D98 File Offset: 0x00317F98
		public int[] GetCustomHandleIdsArray()
		{
			return this.__p.__vector_as_array<int>(58) ?? Array.Empty<int>();
		}

		// Token: 0x0600D612 RID: 54802 RVA: 0x00319DB0 File Offset: 0x00317FB0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AttributeEnableTagsIter()或GetAttributeEnableTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AttributeEnableTags()
		{
			SkillVehicleButton skillVehicleButton = this;
			return skillVehicleButton.GetAttributeEnableTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D613 RID: 54803 RVA: 0x00319DD4 File Offset: 0x00317FD4
		[NullableContext(1)]
		public readonly IEnumerable<int> AttributeEnableTagsIter()
		{
			SkillVehicleButton.<AttributeEnableTagsIter>d__99 <AttributeEnableTagsIter>d__ = new SkillVehicleButton.<AttributeEnableTagsIter>d__99(-2);
			<AttributeEnableTagsIter>d__.<>3__<>4__this = this;
			return <AttributeEnableTagsIter>d__;
		}

		// Token: 0x0600D614 RID: 54804 RVA: 0x00319DEC File Offset: 0x00317FEC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用AttributeIdTagMapFrozenDict()缓存字典，遍历请使用AttributeIdTagMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> AttributeIdTagMap()
		{
			return this.AttributeIdTagMapIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600D615 RID: 54805 RVA: 0x00319E42 File Offset: 0x00318042
		[NullableContext(1)]
		public readonly IEnumerable<DicIntIntArray> AttributeIdTagMapIter()
		{
			SkillVehicleButton.<AttributeIdTagMapIter>d__101 <AttributeIdTagMapIter>d__ = new SkillVehicleButton.<AttributeIdTagMapIter>d__101(-2);
			<AttributeIdTagMapIter>d__.<>3__<>4__this = this;
			return <AttributeIdTagMapIter>d__;
		}

		// Token: 0x0600D616 RID: 54806 RVA: 0x00319E58 File Offset: 0x00318058
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AttributeUsageParamsIter()或GetAttributeUsageParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AttributeUsageParams()
		{
			SkillVehicleButton skillVehicleButton = this;
			return skillVehicleButton.GetAttributeUsageParamsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D617 RID: 54807 RVA: 0x00319E7C File Offset: 0x0031807C
		[NullableContext(1)]
		public readonly IEnumerable<int> AttributeUsageParamsIter()
		{
			SkillVehicleButton.<AttributeUsageParamsIter>d__103 <AttributeUsageParamsIter>d__ = new SkillVehicleButton.<AttributeUsageParamsIter>d__103(-2);
			<AttributeUsageParamsIter>d__.<>3__<>4__this = this;
			return <AttributeUsageParamsIter>d__;
		}

		// Token: 0x0600D618 RID: 54808 RVA: 0x00319E94 File Offset: 0x00318094
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CustomHandleIdsIter()或GetCustomHandleIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] CustomHandleIds()
		{
			SkillVehicleButton skillVehicleButton = this;
			return skillVehicleButton.GetCustomHandleIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D619 RID: 54809 RVA: 0x00319EB8 File Offset: 0x003180B8
		[NullableContext(1)]
		public readonly IEnumerable<int> CustomHandleIdsIter()
		{
			SkillVehicleButton.<CustomHandleIdsIter>d__105 <CustomHandleIdsIter>d__ = new SkillVehicleButton.<CustomHandleIdsIter>d__105(-2);
			<CustomHandleIdsIter>d__.<>3__<>4__this = this;
			return <CustomHandleIdsIter>d__;
		}

		// Token: 0x0600D61A RID: 54810 RVA: 0x00319ED0 File Offset: 0x003180D0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DisableSkillIdTagsFrozenDict()缓存字典，遍历请使用DisableSkillIdTagsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> DisableSkillIdTags()
		{
			return this.DisableSkillIdTagsIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600D61B RID: 54811 RVA: 0x00319F26 File Offset: 0x00318126
		[NullableContext(1)]
		public readonly IEnumerable<DicIntIntArray> DisableSkillIdTagsIter()
		{
			SkillVehicleButton.<DisableSkillIdTagsIter>d__107 <DisableSkillIdTagsIter>d__ = new SkillVehicleButton.<DisableSkillIdTagsIter>d__107(-2);
			<DisableSkillIdTagsIter>d__.<>3__<>4__this = this;
			return <DisableSkillIdTagsIter>d__;
		}

		// Token: 0x0600D61C RID: 54812 RVA: 0x00319F3C File Offset: 0x0031813C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DisableTagsIter()或GetDisableTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DisableTags()
		{
			SkillVehicleButton skillVehicleButton = this;
			return skillVehicleButton.GetDisableTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D61D RID: 54813 RVA: 0x00319F60 File Offset: 0x00318160
		[NullableContext(1)]
		public readonly IEnumerable<int> DisableTagsIter()
		{
			SkillVehicleButton.<DisableTagsIter>d__109 <DisableTagsIter>d__ = new SkillVehicleButton.<DisableTagsIter>d__109(-2);
			<DisableTagsIter>d__.<>3__<>4__this = this;
			return <DisableTagsIter>d__;
		}

		// Token: 0x0600D61E RID: 54814 RVA: 0x00319F78 File Offset: 0x00318178
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DynamicEffectTagMapFrozenDict()缓存字典，遍历请使用DynamicEffectTagMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> DynamicEffectTagMap()
		{
			return this.DynamicEffectTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D61F RID: 54815 RVA: 0x00319FCE File Offset: 0x003181CE
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> DynamicEffectTagMapIter()
		{
			SkillVehicleButton.<DynamicEffectTagMapIter>d__111 <DynamicEffectTagMapIter>d__ = new SkillVehicleButton.<DynamicEffectTagMapIter>d__111(-2);
			<DynamicEffectTagMapIter>d__.<>3__<>4__this = this;
			return <DynamicEffectTagMapIter>d__;
		}

		// Token: 0x0600D620 RID: 54816 RVA: 0x00319FE4 File Offset: 0x003181E4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EnableTagsIter()或GetEnableTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] EnableTags()
		{
			SkillVehicleButton skillVehicleButton = this;
			return skillVehicleButton.GetEnableTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D621 RID: 54817 RVA: 0x0031A008 File Offset: 0x00318208
		[NullableContext(1)]
		public readonly IEnumerable<int> EnableTagsIter()
		{
			SkillVehicleButton.<EnableTagsIter>d__113 <EnableTagsIter>d__ = new SkillVehicleButton.<EnableTagsIter>d__113(-2);
			<EnableTagsIter>d__.<>3__<>4__this = this;
			return <EnableTagsIter>d__;
		}

		// Token: 0x0600D622 RID: 54818 RVA: 0x0031A020 File Offset: 0x00318220
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用HideLongPressTagsIter()或GetHideLongPressTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] HideLongPressTags()
		{
			SkillVehicleButton skillVehicleButton = this;
			return skillVehicleButton.GetHideLongPressTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D623 RID: 54819 RVA: 0x0031A044 File Offset: 0x00318244
		[NullableContext(1)]
		public readonly IEnumerable<int> HideLongPressTagsIter()
		{
			SkillVehicleButton.<HideLongPressTagsIter>d__115 <HideLongPressTagsIter>d__ = new SkillVehicleButton.<HideLongPressTagsIter>d__115(-2);
			<HideLongPressTagsIter>d__.<>3__<>4__this = this;
			return <HideLongPressTagsIter>d__;
		}

		// Token: 0x0600D624 RID: 54820 RVA: 0x0031A05C File Offset: 0x0031825C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowLongPressTagsIter()或GetShowLongPressTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowLongPressTags()
		{
			SkillVehicleButton skillVehicleButton = this;
			return skillVehicleButton.GetShowLongPressTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D625 RID: 54821 RVA: 0x0031A080 File Offset: 0x00318280
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowLongPressTagsIter()
		{
			SkillVehicleButton.<ShowLongPressTagsIter>d__117 <ShowLongPressTagsIter>d__ = new SkillVehicleButton.<ShowLongPressTagsIter>d__117(-2);
			<ShowLongPressTagsIter>d__.<>3__<>4__this = this;
			return <ShowLongPressTagsIter>d__;
		}

		// Token: 0x0600D626 RID: 54822 RVA: 0x0031A098 File Offset: 0x00318298
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillIconTagsIter()或GetSkillIconTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SkillIconTags()
		{
			SkillVehicleButton skillVehicleButton = this;
			return skillVehicleButton.GetSkillIconTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D627 RID: 54823 RVA: 0x0031A0BC File Offset: 0x003182BC
		[NullableContext(1)]
		public readonly IEnumerable<int> SkillIconTagsIter()
		{
			SkillVehicleButton.<SkillIconTagsIter>d__119 <SkillIconTagsIter>d__ = new SkillVehicleButton.<SkillIconTagsIter>d__119(-2);
			<SkillIconTagsIter>d__.<>3__<>4__this = this;
			return <SkillIconTagsIter>d__;
		}

		// Token: 0x0600D628 RID: 54824 RVA: 0x0031A0D4 File Offset: 0x003182D4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用SkillIdTagMapFrozenDict()缓存字典，遍历请使用SkillIdTagMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> SkillIdTagMap()
		{
			return this.SkillIdTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D629 RID: 54825 RVA: 0x0031A12A File Offset: 0x0031832A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> SkillIdTagMapIter()
		{
			SkillVehicleButton.<SkillIdTagMapIter>d__121 <SkillIdTagMapIter>d__ = new SkillVehicleButton.<SkillIdTagMapIter>d__121(-2);
			<SkillIdTagMapIter>d__.<>3__<>4__this = this;
			return <SkillIdTagMapIter>d__;
		}

		// Token: 0x0600D62A RID: 54826 RVA: 0x0031A140 File Offset: 0x00318340
		public IntArray? GetAttributeIdTagMap(int key)
		{
			this.EnsureAttributeIdTagMapCacheIfNeeded();
			IntArray value;
			if (!this.AttributeIdTagMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x0600D62B RID: 54827 RVA: 0x0031A174 File Offset: 0x00318374
		public IntArray? GetDisableSkillIdTags(int key)
		{
			this.EnsureDisableSkillIdTagsCacheIfNeeded();
			IntArray value;
			if (!this.DisableSkillIdTagsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x0600D62C RID: 54828 RVA: 0x0031A1A8 File Offset: 0x003183A8
		public int? GetDynamicEffectTagMap(int key)
		{
			this.EnsureDynamicEffectTagMapCacheIfNeeded();
			int value;
			if (!this.DynamicEffectTagMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600D62D RID: 54829 RVA: 0x0031A1DC File Offset: 0x003183DC
		public int? GetSkillIdTagMap(int key)
		{
			this.EnsureSkillIdTagMapCacheIfNeeded();
			int value;
			if (!this.SkillIdTagMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600D62E RID: 54830 RVA: 0x0031A210 File Offset: 0x00318410
		private void EnsureAttributeIdTagMapCacheIfNeeded()
		{
			if (this.AttributeIdTagMapCache != null)
			{
				return;
			}
			this.AttributeIdTagMapCache = this.AttributeIdTagMapIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600D62F RID: 54831 RVA: 0x0031A278 File Offset: 0x00318478
		private void EnsureDisableSkillIdTagsCacheIfNeeded()
		{
			if (this.DisableSkillIdTagsCache != null)
			{
				return;
			}
			this.DisableSkillIdTagsCache = this.DisableSkillIdTagsIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600D630 RID: 54832 RVA: 0x0031A2E0 File Offset: 0x003184E0
		private void EnsureDynamicEffectTagMapCacheIfNeeded()
		{
			if (this.DynamicEffectTagMapCache != null)
			{
				return;
			}
			this.DynamicEffectTagMapCache = this.DynamicEffectTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D631 RID: 54833 RVA: 0x0031A348 File Offset: 0x00318548
		private void EnsureSkillIdTagMapCacheIfNeeded()
		{
			if (this.SkillIdTagMapCache != null)
			{
				return;
			}
			this.SkillIdTagMapCache = this.SkillIdTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D632 RID: 54834 RVA: 0x0031A3AE File Offset: 0x003185AE
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetAttributeIdTagMapFrozenDict(int key)
		{
			this.EnsureAttributeIdTagMapCacheIfNeeded();
			return this.AttributeIdTagMapCache;
		}

		// Token: 0x0600D633 RID: 54835 RVA: 0x0031A3BC File Offset: 0x003185BC
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetDisableSkillIdTagsFrozenDict(int key)
		{
			this.EnsureDisableSkillIdTagsCacheIfNeeded();
			return this.DisableSkillIdTagsCache;
		}

		// Token: 0x0600D634 RID: 54836 RVA: 0x0031A3CA File Offset: 0x003185CA
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetDynamicEffectTagMapFrozenDict(int key)
		{
			this.EnsureDynamicEffectTagMapCacheIfNeeded();
			return this.DynamicEffectTagMapCache;
		}

		// Token: 0x0600D635 RID: 54837 RVA: 0x0031A3D8 File Offset: 0x003185D8
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetSkillIdTagMapFrozenDict(int key)
		{
			this.EnsureSkillIdTagMapCacheIfNeeded();
			return this.SkillIdTagMapCache;
		}

		// Token: 0x040051F6 RID: 20982
		private Table __p;

		// Token: 0x040051F7 RID: 20983
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> AttributeIdTagMapCache;

		// Token: 0x040051F8 RID: 20984
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> DisableSkillIdTagsCache;

		// Token: 0x040051F9 RID: 20985
		[Nullable(2)]
		private FrozenDictionary<int, int> DynamicEffectTagMapCache;

		// Token: 0x040051FA RID: 20986
		[Nullable(2)]
		private FrozenDictionary<int, int> SkillIdTagMapCache;
	}
}
