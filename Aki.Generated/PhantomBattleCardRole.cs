using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EC7 RID: 3783
	public struct PhantomBattleCardRole : IFlatbufferObject
	{
		// Token: 0x170025C7 RID: 9671
		// (get) Token: 0x0600A5DA RID: 42458 RVA: 0x002AD0C5 File Offset: 0x002AB2C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A5DB RID: 42459 RVA: 0x002AD0D2 File Offset: 0x002AB2D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A5DC RID: 42460 RVA: 0x002AD0DC File Offset: 0x002AB2DC
		public static PhantomBattleCardRole GetRootAsPhantomBattleCardRole(ByteBuffer _bb)
		{
			return PhantomBattleCardRole.GetRootAsPhantomBattleCardRole(_bb, default(PhantomBattleCardRole));
		}

		// Token: 0x0600A5DD RID: 42461 RVA: 0x002AD0F8 File Offset: 0x002AB2F8
		public static PhantomBattleCardRole GetRootAsPhantomBattleCardRole(ByteBuffer _bb, PhantomBattleCardRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A5DE RID: 42462 RVA: 0x002AD115 File Offset: 0x002AB315
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A5DF RID: 42463 RVA: 0x002AD124 File Offset: 0x002AB324
		public PhantomBattleCardRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170025C8 RID: 9672
		// (get) Token: 0x0600A5E0 RID: 42464 RVA: 0x002AD134 File Offset: 0x002AB334
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

		// Token: 0x170025C9 RID: 9673
		// (get) Token: 0x0600A5E1 RID: 42465 RVA: 0x002AD170 File Offset: 0x002AB370
		public int ActivityId
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

		// Token: 0x170025CA RID: 9674
		// (get) Token: 0x0600A5E2 RID: 42466 RVA: 0x002AD1AC File Offset: 0x002AB3AC
		public int RoleConfigId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170025CB RID: 9675
		// (get) Token: 0x0600A5E3 RID: 42467 RVA: 0x002AD1E8 File Offset: 0x002AB3E8
		public int Type
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

		// Token: 0x170025CC RID: 9676
		// (get) Token: 0x0600A5E4 RID: 42468 RVA: 0x002AD228 File Offset: 0x002AB428
		public int DropId
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

		// Token: 0x0600A5E5 RID: 42469 RVA: 0x002AD268 File Offset: 0x002AB468
		public int ActiveSkillId(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170025CD RID: 9677
		// (get) Token: 0x0600A5E6 RID: 42470 RVA: 0x002AD2A8 File Offset: 0x002AB4A8
		public int ActiveSkillIdLength
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

		// Token: 0x0600A5E7 RID: 42471 RVA: 0x002AD2D4 File Offset: 0x002AB4D4
		public Span<int> GetActiveSkillIdBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600A5E8 RID: 42472 RVA: 0x002AD2E4 File Offset: 0x002AB4E4
		public int[] GetActiveSkillIdArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600A5E9 RID: 42473 RVA: 0x002AD2FC File Offset: 0x002AB4FC
		public int PassiveSkillId(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170025CE RID: 9678
		// (get) Token: 0x0600A5EA RID: 42474 RVA: 0x002AD33C File Offset: 0x002AB53C
		public int PassiveSkillIdLength
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

		// Token: 0x0600A5EB RID: 42475 RVA: 0x002AD368 File Offset: 0x002AB568
		public Span<int> GetPassiveSkillIdBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600A5EC RID: 42476 RVA: 0x002AD378 File Offset: 0x002AB578
		public int[] GetPassiveSkillIdArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600A5ED RID: 42477 RVA: 0x002AD390 File Offset: 0x002AB590
		public string SkillIconList(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170025CF RID: 9679
		// (get) Token: 0x0600A5EE RID: 42478 RVA: 0x002AD3CC File Offset: 0x002AB5CC
		public int SkillIconListLength
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

		// Token: 0x0600A5EF RID: 42479 RVA: 0x002AD3F8 File Offset: 0x002AB5F8
		public string SkillNameList(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170025D0 RID: 9680
		// (get) Token: 0x0600A5F0 RID: 42480 RVA: 0x002AD434 File Offset: 0x002AB634
		public int SkillNameListLength
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

		// Token: 0x0600A5F1 RID: 42481 RVA: 0x002AD460 File Offset: 0x002AB660
		public string SkillDescList(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170025D1 RID: 9681
		// (get) Token: 0x0600A5F2 RID: 42482 RVA: 0x002AD49C File Offset: 0x002AB69C
		public int SkillDescListLength
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

		// Token: 0x0600A5F3 RID: 42483 RVA: 0x002AD4C8 File Offset: 0x002AB6C8
		public StringArray? SkillDescParamsList(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new StringArray?(default(StringArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170025D2 RID: 9682
		// (get) Token: 0x0600A5F4 RID: 42484 RVA: 0x002AD52C File Offset: 0x002AB72C
		public int SkillDescParamsListLength
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

		// Token: 0x0600A5F5 RID: 42485 RVA: 0x002AD558 File Offset: 0x002AB758
		public string PassiveSkillIconList(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170025D3 RID: 9683
		// (get) Token: 0x0600A5F6 RID: 42486 RVA: 0x002AD594 File Offset: 0x002AB794
		public int PassiveSkillIconListLength
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

		// Token: 0x0600A5F7 RID: 42487 RVA: 0x002AD5C0 File Offset: 0x002AB7C0
		public string PassiveSkillNameList(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170025D4 RID: 9684
		// (get) Token: 0x0600A5F8 RID: 42488 RVA: 0x002AD5FC File Offset: 0x002AB7FC
		public int PassiveSkillNameListLength
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

		// Token: 0x0600A5F9 RID: 42489 RVA: 0x002AD628 File Offset: 0x002AB828
		public string PassiveSkillDescList(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170025D5 RID: 9685
		// (get) Token: 0x0600A5FA RID: 42490 RVA: 0x002AD664 File Offset: 0x002AB864
		public int PassiveSkillDescListLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A5FB RID: 42491 RVA: 0x002AD690 File Offset: 0x002AB890
		public StringArray? PassiveSkillDescParamsList(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new StringArray?(default(StringArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170025D6 RID: 9686
		// (get) Token: 0x0600A5FC RID: 42492 RVA: 0x002AD6F4 File Offset: 0x002AB8F4
		public int PassiveSkillDescParamsListLength
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

		// Token: 0x170025D7 RID: 9687
		// (get) Token: 0x0600A5FD RID: 42493 RVA: 0x002AD720 File Offset: 0x002AB920
		public string UnlockConditionTip
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A5FE RID: 42494 RVA: 0x002AD758 File Offset: 0x002AB958
		public Span<byte> GetUnlockConditionTipBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600A5FF RID: 42495 RVA: 0x002AD768 File Offset: 0x002AB968
		public byte[] GetUnlockConditionTipArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170025D8 RID: 9688
		// (get) Token: 0x0600A600 RID: 42496 RVA: 0x002AD780 File Offset: 0x002AB980
		public string RoleSkillTexture
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

		// Token: 0x0600A601 RID: 42497 RVA: 0x002AD7B8 File Offset: 0x002AB9B8
		public Span<byte> GetRoleSkillTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600A602 RID: 42498 RVA: 0x002AD7C8 File Offset: 0x002AB9C8
		public byte[] GetRoleSkillTextureArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x170025D9 RID: 9689
		// (get) Token: 0x0600A603 RID: 42499 RVA: 0x002AD7E0 File Offset: 0x002AB9E0
		public string RoleHeadTexture
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

		// Token: 0x0600A604 RID: 42500 RVA: 0x002AD818 File Offset: 0x002ABA18
		public Span<byte> GetRoleHeadTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600A605 RID: 42501 RVA: 0x002AD828 File Offset: 0x002ABA28
		public byte[] GetRoleHeadTextureArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x170025DA RID: 9690
		// (get) Token: 0x0600A606 RID: 42502 RVA: 0x002AD840 File Offset: 0x002ABA40
		public string RoleSpinePrefabPath
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A607 RID: 42503 RVA: 0x002AD878 File Offset: 0x002ABA78
		public Span<byte> GetRoleSpinePrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600A608 RID: 42504 RVA: 0x002AD888 File Offset: 0x002ABA88
		public byte[] GetRoleSpinePrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x170025DB RID: 9691
		// (get) Token: 0x0600A609 RID: 42505 RVA: 0x002AD8A0 File Offset: 0x002ABAA0
		public string RoleTexture
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A60A RID: 42506 RVA: 0x002AD8D8 File Offset: 0x002ABAD8
		public Span<byte> GetRoleTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600A60B RID: 42507 RVA: 0x002AD8E8 File Offset: 0x002ABAE8
		public byte[] GetRoleTextureArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x170025DC RID: 9692
		// (get) Token: 0x0600A60C RID: 42508 RVA: 0x002AD900 File Offset: 0x002ABB00
		public string RoleMaskTexture
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

		// Token: 0x0600A60D RID: 42509 RVA: 0x002AD938 File Offset: 0x002ABB38
		public Span<byte> GetRoleMaskTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600A60E RID: 42510 RVA: 0x002AD948 File Offset: 0x002ABB48
		public byte[] GetRoleMaskTextureArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x170025DD RID: 9693
		// (get) Token: 0x0600A60F RID: 42511 RVA: 0x002AD960 File Offset: 0x002ABB60
		public string LightTextureColor
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A610 RID: 42512 RVA: 0x002AD998 File Offset: 0x002ABB98
		public Span<byte> GetLightTextureColorBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600A611 RID: 42513 RVA: 0x002AD9A8 File Offset: 0x002ABBA8
		public byte[] GetLightTextureColorArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x170025DE RID: 9694
		// (get) Token: 0x0600A612 RID: 42514 RVA: 0x002AD9C0 File Offset: 0x002ABBC0
		public string RolePreviewTexture
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A613 RID: 42515 RVA: 0x002AD9F8 File Offset: 0x002ABBF8
		public Span<byte> GetRolePreviewTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x0600A614 RID: 42516 RVA: 0x002ADA08 File Offset: 0x002ABC08
		public byte[] GetRolePreviewTextureArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x170025DF RID: 9695
		// (get) Token: 0x0600A615 RID: 42517 RVA: 0x002ADA20 File Offset: 0x002ABC20
		public bool IsTrail
		{
			get
			{
				int num = this.__p.__offset(50);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170025E0 RID: 9696
		// (get) Token: 0x0600A616 RID: 42518 RVA: 0x002ADA60 File Offset: 0x002ABC60
		public string BgDesc
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A617 RID: 42519 RVA: 0x002ADA98 File Offset: 0x002ABC98
		public Span<byte> GetBgDescBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x0600A618 RID: 42520 RVA: 0x002ADAA8 File Offset: 0x002ABCA8
		public byte[] GetBgDescArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A619 RID: 42521 RVA: 0x002ADAC0 File Offset: 0x002ABCC0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ActiveSkillIdIter()或GetActiveSkillIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ActiveSkillId()
		{
			PhantomBattleCardRole phantomBattleCardRole = this;
			return phantomBattleCardRole.GetActiveSkillIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A61A RID: 42522 RVA: 0x002ADAE4 File Offset: 0x002ABCE4
		[NullableContext(1)]
		public readonly IEnumerable<int> ActiveSkillIdIter()
		{
			PhantomBattleCardRole.<ActiveSkillIdIter>d__91 <ActiveSkillIdIter>d__ = new PhantomBattleCardRole.<ActiveSkillIdIter>d__91(-2);
			<ActiveSkillIdIter>d__.<>3__<>4__this = this;
			return <ActiveSkillIdIter>d__;
		}

		// Token: 0x0600A61B RID: 42523 RVA: 0x002ADAF9 File Offset: 0x002ABCF9
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PassiveSkillDescListIter()或GetPassiveSkillDescListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] PassiveSkillDescList()
		{
			return this.PassiveSkillDescListIter().ToArray<string>();
		}

		// Token: 0x0600A61C RID: 42524 RVA: 0x002ADB06 File Offset: 0x002ABD06
		[NullableContext(1)]
		public readonly IEnumerable<string> PassiveSkillDescListIter()
		{
			PhantomBattleCardRole.<PassiveSkillDescListIter>d__93 <PassiveSkillDescListIter>d__ = new PhantomBattleCardRole.<PassiveSkillDescListIter>d__93(-2);
			<PassiveSkillDescListIter>d__.<>3__<>4__this = this;
			return <PassiveSkillDescListIter>d__;
		}

		// Token: 0x0600A61D RID: 42525 RVA: 0x002ADB1B File Offset: 0x002ABD1B
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PassiveSkillDescParamsListIter()或GetPassiveSkillDescParamsListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly StringArray[] PassiveSkillDescParamsList()
		{
			return this.PassiveSkillDescParamsListIter().ToArray<StringArray>();
		}

		// Token: 0x0600A61E RID: 42526 RVA: 0x002ADB28 File Offset: 0x002ABD28
		[NullableContext(1)]
		public readonly IEnumerable<StringArray> PassiveSkillDescParamsListIter()
		{
			PhantomBattleCardRole.<PassiveSkillDescParamsListIter>d__95 <PassiveSkillDescParamsListIter>d__ = new PhantomBattleCardRole.<PassiveSkillDescParamsListIter>d__95(-2);
			<PassiveSkillDescParamsListIter>d__.<>3__<>4__this = this;
			return <PassiveSkillDescParamsListIter>d__;
		}

		// Token: 0x0600A61F RID: 42527 RVA: 0x002ADB3D File Offset: 0x002ABD3D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PassiveSkillIconListIter()或GetPassiveSkillIconListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] PassiveSkillIconList()
		{
			return this.PassiveSkillIconListIter().ToArray<string>();
		}

		// Token: 0x0600A620 RID: 42528 RVA: 0x002ADB4A File Offset: 0x002ABD4A
		[NullableContext(1)]
		public readonly IEnumerable<string> PassiveSkillIconListIter()
		{
			PhantomBattleCardRole.<PassiveSkillIconListIter>d__97 <PassiveSkillIconListIter>d__ = new PhantomBattleCardRole.<PassiveSkillIconListIter>d__97(-2);
			<PassiveSkillIconListIter>d__.<>3__<>4__this = this;
			return <PassiveSkillIconListIter>d__;
		}

		// Token: 0x0600A621 RID: 42529 RVA: 0x002ADB60 File Offset: 0x002ABD60
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PassiveSkillIdIter()或GetPassiveSkillIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PassiveSkillId()
		{
			PhantomBattleCardRole phantomBattleCardRole = this;
			return phantomBattleCardRole.GetPassiveSkillIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A622 RID: 42530 RVA: 0x002ADB84 File Offset: 0x002ABD84
		[NullableContext(1)]
		public readonly IEnumerable<int> PassiveSkillIdIter()
		{
			PhantomBattleCardRole.<PassiveSkillIdIter>d__99 <PassiveSkillIdIter>d__ = new PhantomBattleCardRole.<PassiveSkillIdIter>d__99(-2);
			<PassiveSkillIdIter>d__.<>3__<>4__this = this;
			return <PassiveSkillIdIter>d__;
		}

		// Token: 0x0600A623 RID: 42531 RVA: 0x002ADB99 File Offset: 0x002ABD99
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PassiveSkillNameListIter()或GetPassiveSkillNameListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] PassiveSkillNameList()
		{
			return this.PassiveSkillNameListIter().ToArray<string>();
		}

		// Token: 0x0600A624 RID: 42532 RVA: 0x002ADBA6 File Offset: 0x002ABDA6
		[NullableContext(1)]
		public readonly IEnumerable<string> PassiveSkillNameListIter()
		{
			PhantomBattleCardRole.<PassiveSkillNameListIter>d__101 <PassiveSkillNameListIter>d__ = new PhantomBattleCardRole.<PassiveSkillNameListIter>d__101(-2);
			<PassiveSkillNameListIter>d__.<>3__<>4__this = this;
			return <PassiveSkillNameListIter>d__;
		}

		// Token: 0x0600A625 RID: 42533 RVA: 0x002ADBBB File Offset: 0x002ABDBB
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillDescListIter()或GetSkillDescListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SkillDescList()
		{
			return this.SkillDescListIter().ToArray<string>();
		}

		// Token: 0x0600A626 RID: 42534 RVA: 0x002ADBC8 File Offset: 0x002ABDC8
		[NullableContext(1)]
		public readonly IEnumerable<string> SkillDescListIter()
		{
			PhantomBattleCardRole.<SkillDescListIter>d__103 <SkillDescListIter>d__ = new PhantomBattleCardRole.<SkillDescListIter>d__103(-2);
			<SkillDescListIter>d__.<>3__<>4__this = this;
			return <SkillDescListIter>d__;
		}

		// Token: 0x0600A627 RID: 42535 RVA: 0x002ADBDD File Offset: 0x002ABDDD
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillDescParamsListIter()或GetSkillDescParamsListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly StringArray[] SkillDescParamsList()
		{
			return this.SkillDescParamsListIter().ToArray<StringArray>();
		}

		// Token: 0x0600A628 RID: 42536 RVA: 0x002ADBEA File Offset: 0x002ABDEA
		[NullableContext(1)]
		public readonly IEnumerable<StringArray> SkillDescParamsListIter()
		{
			PhantomBattleCardRole.<SkillDescParamsListIter>d__105 <SkillDescParamsListIter>d__ = new PhantomBattleCardRole.<SkillDescParamsListIter>d__105(-2);
			<SkillDescParamsListIter>d__.<>3__<>4__this = this;
			return <SkillDescParamsListIter>d__;
		}

		// Token: 0x0600A629 RID: 42537 RVA: 0x002ADBFF File Offset: 0x002ABDFF
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillIconListIter()或GetSkillIconListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SkillIconList()
		{
			return this.SkillIconListIter().ToArray<string>();
		}

		// Token: 0x0600A62A RID: 42538 RVA: 0x002ADC0C File Offset: 0x002ABE0C
		[NullableContext(1)]
		public readonly IEnumerable<string> SkillIconListIter()
		{
			PhantomBattleCardRole.<SkillIconListIter>d__107 <SkillIconListIter>d__ = new PhantomBattleCardRole.<SkillIconListIter>d__107(-2);
			<SkillIconListIter>d__.<>3__<>4__this = this;
			return <SkillIconListIter>d__;
		}

		// Token: 0x0600A62B RID: 42539 RVA: 0x002ADC21 File Offset: 0x002ABE21
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillNameListIter()或GetSkillNameListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SkillNameList()
		{
			return this.SkillNameListIter().ToArray<string>();
		}

		// Token: 0x0600A62C RID: 42540 RVA: 0x002ADC2E File Offset: 0x002ABE2E
		[NullableContext(1)]
		public readonly IEnumerable<string> SkillNameListIter()
		{
			PhantomBattleCardRole.<SkillNameListIter>d__109 <SkillNameListIter>d__ = new PhantomBattleCardRole.<SkillNameListIter>d__109(-2);
			<SkillNameListIter>d__.<>3__<>4__this = this;
			return <SkillNameListIter>d__;
		}

		// Token: 0x04004F83 RID: 20355
		private Table __p;
	}
}
