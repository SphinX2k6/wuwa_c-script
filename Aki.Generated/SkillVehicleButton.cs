using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011C3 RID: 4547
	public struct SkillVehicleButton : IFlatbufferObject
	{
		// Token: 0x1700381B RID: 14363
		// (get) Token: 0x0600DDAB RID: 56747 RVA: 0x003382ED File Offset: 0x003364ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DDAC RID: 56748 RVA: 0x003382FA File Offset: 0x003364FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DDAD RID: 56749 RVA: 0x00338304 File Offset: 0x00336504
		public static SkillVehicleButton GetRootAsSkillVehicleButton(ByteBuffer _bb)
		{
			return SkillVehicleButton.GetRootAsSkillVehicleButton(_bb, default(SkillVehicleButton));
		}

		// Token: 0x0600DDAE RID: 56750 RVA: 0x00338320 File Offset: 0x00336520
		public static SkillVehicleButton GetRootAsSkillVehicleButton(ByteBuffer _bb, SkillVehicleButton obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DDAF RID: 56751 RVA: 0x0033833D File Offset: 0x0033653D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DDB0 RID: 56752 RVA: 0x0033834C File Offset: 0x0033654C
		public SkillVehicleButton __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700381C RID: 14364
		// (get) Token: 0x0600DDB1 RID: 56753 RVA: 0x0033835C File Offset: 0x0033655C
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

		// Token: 0x1700381D RID: 14365
		// (get) Token: 0x0600DDB2 RID: 56754 RVA: 0x00338398 File Offset: 0x00336598
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

		// Token: 0x1700381E RID: 14366
		// (get) Token: 0x0600DDB3 RID: 56755 RVA: 0x003383D4 File Offset: 0x003365D4
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

		// Token: 0x0600DDB4 RID: 56756 RVA: 0x0033840B File Offset: 0x0033660B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DDB5 RID: 56757 RVA: 0x0033841A File Offset: 0x0033661A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700381F RID: 14367
		// (get) Token: 0x0600DDB6 RID: 56758 RVA: 0x00338434 File Offset: 0x00336634
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

		// Token: 0x17003820 RID: 14368
		// (get) Token: 0x0600DDB7 RID: 56759 RVA: 0x00338474 File Offset: 0x00336674
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

		// Token: 0x17003821 RID: 14369
		// (get) Token: 0x0600DDB8 RID: 56760 RVA: 0x003384B4 File Offset: 0x003366B4
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

		// Token: 0x0600DDB9 RID: 56761 RVA: 0x003384EC File Offset: 0x003366EC
		public Span<byte> GetActionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600DDBA RID: 56762 RVA: 0x003384FC File Offset: 0x003366FC
		public byte[] GetActionNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003822 RID: 14370
		// (get) Token: 0x0600DDBB RID: 56763 RVA: 0x00338514 File Offset: 0x00336714
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

		// Token: 0x0600DDBC RID: 56764 RVA: 0x00338554 File Offset: 0x00336754
		public DicIntInt? SkillIdTagMap(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003823 RID: 14371
		// (get) Token: 0x0600DDBD RID: 56765 RVA: 0x003385B8 File Offset: 0x003367B8
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

		// Token: 0x17003824 RID: 14372
		// (get) Token: 0x0600DDBE RID: 56766 RVA: 0x003385E4 File Offset: 0x003367E4
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

		// Token: 0x0600DDBF RID: 56767 RVA: 0x0033861C File Offset: 0x0033681C
		public Span<byte> GetSkillIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600DDC0 RID: 56768 RVA: 0x0033862C File Offset: 0x0033682C
		public byte[] GetSkillIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DDC1 RID: 56769 RVA: 0x00338644 File Offset: 0x00336844
		public int SkillIconTags(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003825 RID: 14373
		// (get) Token: 0x0600DDC2 RID: 56770 RVA: 0x00338684 File Offset: 0x00336884
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

		// Token: 0x0600DDC3 RID: 56771 RVA: 0x003386B0 File Offset: 0x003368B0
		public Span<int> GetSkillIconTagsBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600DDC4 RID: 56772 RVA: 0x003386C0 File Offset: 0x003368C0
		public int[] GetSkillIconTagsArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600DDC5 RID: 56773 RVA: 0x003386D8 File Offset: 0x003368D8
		public int EnableTags(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003826 RID: 14374
		// (get) Token: 0x0600DDC6 RID: 56774 RVA: 0x00338718 File Offset: 0x00336918
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

		// Token: 0x0600DDC7 RID: 56775 RVA: 0x00338744 File Offset: 0x00336944
		public Span<int> GetEnableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600DDC8 RID: 56776 RVA: 0x00338754 File Offset: 0x00336954
		public int[] GetEnableTagsArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x0600DDC9 RID: 56777 RVA: 0x0033876C File Offset: 0x0033696C
		public int DisableTags(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003827 RID: 14375
		// (get) Token: 0x0600DDCA RID: 56778 RVA: 0x003387AC File Offset: 0x003369AC
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

		// Token: 0x0600DDCB RID: 56779 RVA: 0x003387D8 File Offset: 0x003369D8
		public Span<int> GetDisableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600DDCC RID: 56780 RVA: 0x003387E8 File Offset: 0x003369E8
		public int[] GetDisableTagsArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x0600DDCD RID: 56781 RVA: 0x00338800 File Offset: 0x00336A00
		public DicIntIntArray? DisableSkillIdTags(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003828 RID: 14376
		// (get) Token: 0x0600DDCE RID: 56782 RVA: 0x00338864 File Offset: 0x00336A64
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

		// Token: 0x17003829 RID: 14377
		// (get) Token: 0x0600DDCF RID: 56783 RVA: 0x00338890 File Offset: 0x00336A90
		public bool IsCdVisible
		{
			get
			{
				int num = this.__p.__offset(30);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700382A RID: 14378
		// (get) Token: 0x0600DDD0 RID: 56784 RVA: 0x003388D0 File Offset: 0x00336AD0
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

		// Token: 0x1700382B RID: 14379
		// (get) Token: 0x0600DDD1 RID: 56785 RVA: 0x00338910 File Offset: 0x00336B10
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

		// Token: 0x0600DDD2 RID: 56786 RVA: 0x00338950 File Offset: 0x00336B50
		public int AttributeUsageParams(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700382C RID: 14380
		// (get) Token: 0x0600DDD3 RID: 56787 RVA: 0x00338990 File Offset: 0x00336B90
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

		// Token: 0x0600DDD4 RID: 56788 RVA: 0x003389BC File Offset: 0x00336BBC
		public Span<int> GetAttributeUsageParamsBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x0600DDD5 RID: 56789 RVA: 0x003389CC File Offset: 0x00336BCC
		public int[] GetAttributeUsageParamsArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x1700382D RID: 14381
		// (get) Token: 0x0600DDD6 RID: 56790 RVA: 0x003389E4 File Offset: 0x00336BE4
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

		// Token: 0x1700382E RID: 14382
		// (get) Token: 0x0600DDD7 RID: 56791 RVA: 0x00338A24 File Offset: 0x00336C24
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

		// Token: 0x0600DDD8 RID: 56792 RVA: 0x00338A64 File Offset: 0x00336C64
		public DicIntIntArray? AttributeIdTagMap(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700382F RID: 14383
		// (get) Token: 0x0600DDD9 RID: 56793 RVA: 0x00338AC8 File Offset: 0x00336CC8
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

		// Token: 0x0600DDDA RID: 56794 RVA: 0x00338AF4 File Offset: 0x00336CF4
		public int AttributeEnableTags(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003830 RID: 14384
		// (get) Token: 0x0600DDDB RID: 56795 RVA: 0x00338B34 File Offset: 0x00336D34
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

		// Token: 0x0600DDDC RID: 56796 RVA: 0x00338B60 File Offset: 0x00336D60
		public Span<int> GetAttributeEnableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(44, 4);
		}

		// Token: 0x0600DDDD RID: 56797 RVA: 0x00338B70 File Offset: 0x00336D70
		public int[] GetAttributeEnableTagsArray()
		{
			return this.__p.__vector_as_array<int>(44) ?? Array.Empty<int>();
		}

		// Token: 0x17003831 RID: 14385
		// (get) Token: 0x0600DDDE RID: 56798 RVA: 0x00338B88 File Offset: 0x00336D88
		public bool IsLongPressControlCamera
		{
			get
			{
				int num = this.__p.__offset(46);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003832 RID: 14386
		// (get) Token: 0x0600DDDF RID: 56799 RVA: 0x00338BC8 File Offset: 0x00336DC8
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

		// Token: 0x0600DDE0 RID: 56800 RVA: 0x00338C0C File Offset: 0x00336E0C
		public DicIntInt? DynamicEffectTagMap(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003833 RID: 14387
		// (get) Token: 0x0600DDE1 RID: 56801 RVA: 0x00338C70 File Offset: 0x00336E70
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

		// Token: 0x17003834 RID: 14388
		// (get) Token: 0x0600DDE2 RID: 56802 RVA: 0x00338C9C File Offset: 0x00336E9C
		public bool ShowLongPress
		{
			get
			{
				int num = this.__p.__offset(52);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600DDE3 RID: 56803 RVA: 0x00338CDC File Offset: 0x00336EDC
		public int ShowLongPressTags(int j)
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003835 RID: 14389
		// (get) Token: 0x0600DDE4 RID: 56804 RVA: 0x00338D1C File Offset: 0x00336F1C
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

		// Token: 0x0600DDE5 RID: 56805 RVA: 0x00338D48 File Offset: 0x00336F48
		public Span<int> GetShowLongPressTagsBytes()
		{
			return this.__p.__vector_as_span<int>(54, 4);
		}

		// Token: 0x0600DDE6 RID: 56806 RVA: 0x00338D58 File Offset: 0x00336F58
		public int[] GetShowLongPressTagsArray()
		{
			return this.__p.__vector_as_array<int>(54) ?? Array.Empty<int>();
		}

		// Token: 0x0600DDE7 RID: 56807 RVA: 0x00338D70 File Offset: 0x00336F70
		public int HideLongPressTags(int j)
		{
			int num = this.__p.__offset(56);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003836 RID: 14390
		// (get) Token: 0x0600DDE8 RID: 56808 RVA: 0x00338DB0 File Offset: 0x00336FB0
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

		// Token: 0x0600DDE9 RID: 56809 RVA: 0x00338DDC File Offset: 0x00336FDC
		public Span<int> GetHideLongPressTagsBytes()
		{
			return this.__p.__vector_as_span<int>(56, 4);
		}

		// Token: 0x0600DDEA RID: 56810 RVA: 0x00338DEC File Offset: 0x00336FEC
		public int[] GetHideLongPressTagsArray()
		{
			return this.__p.__vector_as_array<int>(56) ?? Array.Empty<int>();
		}

		// Token: 0x0600DDEB RID: 56811 RVA: 0x00338E04 File Offset: 0x00337004
		public int CustomHandleIds(int j)
		{
			int num = this.__p.__offset(58);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003837 RID: 14391
		// (get) Token: 0x0600DDEC RID: 56812 RVA: 0x00338E44 File Offset: 0x00337044
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

		// Token: 0x0600DDED RID: 56813 RVA: 0x00338E70 File Offset: 0x00337070
		public Span<int> GetCustomHandleIdsBytes()
		{
			return this.__p.__vector_as_span<int>(58, 4);
		}

		// Token: 0x0600DDEE RID: 56814 RVA: 0x00338E80 File Offset: 0x00337080
		public int[] GetCustomHandleIdsArray()
		{
			return this.__p.__vector_as_array<int>(58) ?? Array.Empty<int>();
		}

		// Token: 0x0600DDEF RID: 56815 RVA: 0x00338E98 File Offset: 0x00337098
		[NullableContext(1)]
		public int[] AttributeEnableTags()
		{
			return this.GetAttributeEnableTagsArray();
		}

		// Token: 0x0600DDF0 RID: 56816 RVA: 0x00338EA0 File Offset: 0x003370A0
		[NullableContext(1)]
		public IEnumerable<int> AttributeEnableTagsIter()
		{
			SkillVehicleButton.<AttributeEnableTagsIter>d__99 <AttributeEnableTagsIter>d__ = new SkillVehicleButton.<AttributeEnableTagsIter>d__99(-2);
			<AttributeEnableTagsIter>d__.<>3__<>4__this = this;
			return <AttributeEnableTagsIter>d__;
		}

		// Token: 0x0600DDF1 RID: 56817 RVA: 0x00338EB8 File Offset: 0x003370B8
		[NullableContext(1)]
		public Dictionary<int, IntArray> AttributeIdTagMap()
		{
			return this.AttributeIdTagMapIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600DDF2 RID: 56818 RVA: 0x00338F0E File Offset: 0x0033710E
		[NullableContext(1)]
		public IEnumerable<DicIntIntArray> AttributeIdTagMapIter()
		{
			SkillVehicleButton.<AttributeIdTagMapIter>d__101 <AttributeIdTagMapIter>d__ = new SkillVehicleButton.<AttributeIdTagMapIter>d__101(-2);
			<AttributeIdTagMapIter>d__.<>3__<>4__this = this;
			return <AttributeIdTagMapIter>d__;
		}

		// Token: 0x0600DDF3 RID: 56819 RVA: 0x00338F23 File Offset: 0x00337123
		[NullableContext(1)]
		public int[] AttributeUsageParams()
		{
			return this.GetAttributeUsageParamsArray();
		}

		// Token: 0x0600DDF4 RID: 56820 RVA: 0x00338F2B File Offset: 0x0033712B
		[NullableContext(1)]
		public IEnumerable<int> AttributeUsageParamsIter()
		{
			SkillVehicleButton.<AttributeUsageParamsIter>d__103 <AttributeUsageParamsIter>d__ = new SkillVehicleButton.<AttributeUsageParamsIter>d__103(-2);
			<AttributeUsageParamsIter>d__.<>3__<>4__this = this;
			return <AttributeUsageParamsIter>d__;
		}

		// Token: 0x0600DDF5 RID: 56821 RVA: 0x00338F40 File Offset: 0x00337140
		[NullableContext(1)]
		public int[] CustomHandleIds()
		{
			return this.GetCustomHandleIdsArray();
		}

		// Token: 0x0600DDF6 RID: 56822 RVA: 0x00338F48 File Offset: 0x00337148
		[NullableContext(1)]
		public IEnumerable<int> CustomHandleIdsIter()
		{
			SkillVehicleButton.<CustomHandleIdsIter>d__105 <CustomHandleIdsIter>d__ = new SkillVehicleButton.<CustomHandleIdsIter>d__105(-2);
			<CustomHandleIdsIter>d__.<>3__<>4__this = this;
			return <CustomHandleIdsIter>d__;
		}

		// Token: 0x0600DDF7 RID: 56823 RVA: 0x00338F60 File Offset: 0x00337160
		[NullableContext(1)]
		public Dictionary<int, IntArray> DisableSkillIdTags()
		{
			return this.DisableSkillIdTagsIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600DDF8 RID: 56824 RVA: 0x00338FB6 File Offset: 0x003371B6
		[NullableContext(1)]
		public IEnumerable<DicIntIntArray> DisableSkillIdTagsIter()
		{
			SkillVehicleButton.<DisableSkillIdTagsIter>d__107 <DisableSkillIdTagsIter>d__ = new SkillVehicleButton.<DisableSkillIdTagsIter>d__107(-2);
			<DisableSkillIdTagsIter>d__.<>3__<>4__this = this;
			return <DisableSkillIdTagsIter>d__;
		}

		// Token: 0x0600DDF9 RID: 56825 RVA: 0x00338FCB File Offset: 0x003371CB
		[NullableContext(1)]
		public int[] DisableTags()
		{
			return this.GetDisableTagsArray();
		}

		// Token: 0x0600DDFA RID: 56826 RVA: 0x00338FD3 File Offset: 0x003371D3
		[NullableContext(1)]
		public IEnumerable<int> DisableTagsIter()
		{
			SkillVehicleButton.<DisableTagsIter>d__109 <DisableTagsIter>d__ = new SkillVehicleButton.<DisableTagsIter>d__109(-2);
			<DisableTagsIter>d__.<>3__<>4__this = this;
			return <DisableTagsIter>d__;
		}

		// Token: 0x0600DDFB RID: 56827 RVA: 0x00338FE8 File Offset: 0x003371E8
		[NullableContext(1)]
		public Dictionary<int, int> DynamicEffectTagMap()
		{
			return this.DynamicEffectTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DDFC RID: 56828 RVA: 0x0033903E File Offset: 0x0033723E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> DynamicEffectTagMapIter()
		{
			SkillVehicleButton.<DynamicEffectTagMapIter>d__111 <DynamicEffectTagMapIter>d__ = new SkillVehicleButton.<DynamicEffectTagMapIter>d__111(-2);
			<DynamicEffectTagMapIter>d__.<>3__<>4__this = this;
			return <DynamicEffectTagMapIter>d__;
		}

		// Token: 0x0600DDFD RID: 56829 RVA: 0x00339053 File Offset: 0x00337253
		[NullableContext(1)]
		public int[] EnableTags()
		{
			return this.GetEnableTagsArray();
		}

		// Token: 0x0600DDFE RID: 56830 RVA: 0x0033905B File Offset: 0x0033725B
		[NullableContext(1)]
		public IEnumerable<int> EnableTagsIter()
		{
			SkillVehicleButton.<EnableTagsIter>d__113 <EnableTagsIter>d__ = new SkillVehicleButton.<EnableTagsIter>d__113(-2);
			<EnableTagsIter>d__.<>3__<>4__this = this;
			return <EnableTagsIter>d__;
		}

		// Token: 0x0600DDFF RID: 56831 RVA: 0x00339070 File Offset: 0x00337270
		[NullableContext(1)]
		public int[] HideLongPressTags()
		{
			return this.GetHideLongPressTagsArray();
		}

		// Token: 0x0600DE00 RID: 56832 RVA: 0x00339078 File Offset: 0x00337278
		[NullableContext(1)]
		public IEnumerable<int> HideLongPressTagsIter()
		{
			SkillVehicleButton.<HideLongPressTagsIter>d__115 <HideLongPressTagsIter>d__ = new SkillVehicleButton.<HideLongPressTagsIter>d__115(-2);
			<HideLongPressTagsIter>d__.<>3__<>4__this = this;
			return <HideLongPressTagsIter>d__;
		}

		// Token: 0x0600DE01 RID: 56833 RVA: 0x0033908D File Offset: 0x0033728D
		[NullableContext(1)]
		public int[] ShowLongPressTags()
		{
			return this.GetShowLongPressTagsArray();
		}

		// Token: 0x0600DE02 RID: 56834 RVA: 0x00339095 File Offset: 0x00337295
		[NullableContext(1)]
		public IEnumerable<int> ShowLongPressTagsIter()
		{
			SkillVehicleButton.<ShowLongPressTagsIter>d__117 <ShowLongPressTagsIter>d__ = new SkillVehicleButton.<ShowLongPressTagsIter>d__117(-2);
			<ShowLongPressTagsIter>d__.<>3__<>4__this = this;
			return <ShowLongPressTagsIter>d__;
		}

		// Token: 0x0600DE03 RID: 56835 RVA: 0x003390AA File Offset: 0x003372AA
		[NullableContext(1)]
		public int[] SkillIconTags()
		{
			return this.GetSkillIconTagsArray();
		}

		// Token: 0x0600DE04 RID: 56836 RVA: 0x003390B2 File Offset: 0x003372B2
		[NullableContext(1)]
		public IEnumerable<int> SkillIconTagsIter()
		{
			SkillVehicleButton.<SkillIconTagsIter>d__119 <SkillIconTagsIter>d__ = new SkillVehicleButton.<SkillIconTagsIter>d__119(-2);
			<SkillIconTagsIter>d__.<>3__<>4__this = this;
			return <SkillIconTagsIter>d__;
		}

		// Token: 0x0600DE05 RID: 56837 RVA: 0x003390C8 File Offset: 0x003372C8
		[NullableContext(1)]
		public Dictionary<int, int> SkillIdTagMap()
		{
			return this.SkillIdTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DE06 RID: 56838 RVA: 0x0033911E File Offset: 0x0033731E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> SkillIdTagMapIter()
		{
			SkillVehicleButton.<SkillIdTagMapIter>d__121 <SkillIdTagMapIter>d__ = new SkillVehicleButton.<SkillIdTagMapIter>d__121(-2);
			<SkillIdTagMapIter>d__.<>3__<>4__this = this;
			return <SkillIdTagMapIter>d__;
		}

		// Token: 0x0600DE07 RID: 56839 RVA: 0x00339134 File Offset: 0x00337334
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

		// Token: 0x0600DE08 RID: 56840 RVA: 0x00339168 File Offset: 0x00337368
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

		// Token: 0x0600DE09 RID: 56841 RVA: 0x0033919C File Offset: 0x0033739C
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

		// Token: 0x0600DE0A RID: 56842 RVA: 0x003391D0 File Offset: 0x003373D0
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

		// Token: 0x0600DE0B RID: 56843 RVA: 0x00339204 File Offset: 0x00337404
		private void EnsureAttributeIdTagMapCacheIfNeeded()
		{
			if (this.AttributeIdTagMapCache != null)
			{
				return;
			}
			this.AttributeIdTagMapCache = this.AttributeIdTagMapIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600DE0C RID: 56844 RVA: 0x0033926C File Offset: 0x0033746C
		private void EnsureDisableSkillIdTagsCacheIfNeeded()
		{
			if (this.DisableSkillIdTagsCache != null)
			{
				return;
			}
			this.DisableSkillIdTagsCache = this.DisableSkillIdTagsIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600DE0D RID: 56845 RVA: 0x003392D4 File Offset: 0x003374D4
		private void EnsureDynamicEffectTagMapCacheIfNeeded()
		{
			if (this.DynamicEffectTagMapCache != null)
			{
				return;
			}
			this.DynamicEffectTagMapCache = this.DynamicEffectTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DE0E RID: 56846 RVA: 0x0033933C File Offset: 0x0033753C
		private void EnsureSkillIdTagMapCacheIfNeeded()
		{
			if (this.SkillIdTagMapCache != null)
			{
				return;
			}
			this.SkillIdTagMapCache = this.SkillIdTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DE0F RID: 56847 RVA: 0x003393A2 File Offset: 0x003375A2
		[NullableContext(1)]
		public FrozenDictionary<int, IntArray> GetAttributeIdTagMapFrozenDict()
		{
			this.EnsureAttributeIdTagMapCacheIfNeeded();
			return this.AttributeIdTagMapCache;
		}

		// Token: 0x0600DE10 RID: 56848 RVA: 0x003393B0 File Offset: 0x003375B0
		[NullableContext(1)]
		public FrozenDictionary<int, IntArray> GetDisableSkillIdTagsFrozenDict()
		{
			this.EnsureDisableSkillIdTagsCacheIfNeeded();
			return this.DisableSkillIdTagsCache;
		}

		// Token: 0x0600DE11 RID: 56849 RVA: 0x003393BE File Offset: 0x003375BE
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetDynamicEffectTagMapFrozenDict()
		{
			this.EnsureDynamicEffectTagMapCacheIfNeeded();
			return this.DynamicEffectTagMapCache;
		}

		// Token: 0x0600DE12 RID: 56850 RVA: 0x003393CC File Offset: 0x003375CC
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetSkillIdTagMapFrozenDict()
		{
			this.EnsureSkillIdTagMapCacheIfNeeded();
			return this.SkillIdTagMapCache;
		}

		// Token: 0x040057F5 RID: 22517
		private Table __p;

		// Token: 0x040057F6 RID: 22518
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> AttributeIdTagMapCache;

		// Token: 0x040057F7 RID: 22519
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> DisableSkillIdTagsCache;

		// Token: 0x040057F8 RID: 22520
		[Nullable(2)]
		private FrozenDictionary<int, int> DynamicEffectTagMapCache;

		// Token: 0x040057F9 RID: 22521
		[Nullable(2)]
		private FrozenDictionary<int, int> SkillIdTagMapCache;
	}
}
