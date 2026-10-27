using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BBB RID: 3003
	public struct Dango : IFlatbufferObject
	{
		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06005C5E RID: 23646 RVA: 0x00206511 File Offset: 0x00204711
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005C5F RID: 23647 RVA: 0x0020651E File Offset: 0x0020471E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005C60 RID: 23648 RVA: 0x00206528 File Offset: 0x00204728
		public static Dango GetRootAsDango(ByteBuffer _bb)
		{
			return Dango.GetRootAsDango(_bb, default(Dango));
		}

		// Token: 0x06005C61 RID: 23649 RVA: 0x00206544 File Offset: 0x00204744
		public static Dango GetRootAsDango(ByteBuffer _bb, Dango obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005C62 RID: 23650 RVA: 0x00206561 File Offset: 0x00204761
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005C63 RID: 23651 RVA: 0x00206570 File Offset: 0x00204770
		public Dango __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06005C64 RID: 23652 RVA: 0x00206580 File Offset: 0x00204780
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

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06005C65 RID: 23653 RVA: 0x002065BC File Offset: 0x002047BC
		public int Type
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

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06005C66 RID: 23654 RVA: 0x002065F8 File Offset: 0x002047F8
		public int TemplateId
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

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06005C67 RID: 23655 RVA: 0x00206634 File Offset: 0x00204834
		public int ModelId
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

		// Token: 0x06005C68 RID: 23656 RVA: 0x00206674 File Offset: 0x00204874
		public int ActivityId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06005C69 RID: 23657 RVA: 0x002066B4 File Offset: 0x002048B4
		public int ActivityIdLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005C6A RID: 23658 RVA: 0x002066E0 File Offset: 0x002048E0
		public Span<int> GetActivityIdBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06005C6B RID: 23659 RVA: 0x002066F0 File Offset: 0x002048F0
		public int[] GetActivityIdArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06005C6C RID: 23660 RVA: 0x00206708 File Offset: 0x00204908
		public string Name
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

		// Token: 0x06005C6D RID: 23661 RVA: 0x00206740 File Offset: 0x00204940
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005C6E RID: 23662 RVA: 0x00206750 File Offset: 0x00204950
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06005C6F RID: 23663 RVA: 0x00206768 File Offset: 0x00204968
		public int DiceId
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

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06005C70 RID: 23664 RVA: 0x002067A8 File Offset: 0x002049A8
		public int SkillId
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

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06005C71 RID: 23665 RVA: 0x002067E8 File Offset: 0x002049E8
		public string Icon
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

		// Token: 0x06005C72 RID: 23666 RVA: 0x00206820 File Offset: 0x00204A20
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06005C73 RID: 23667 RVA: 0x00206830 File Offset: 0x00204A30
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06005C74 RID: 23668 RVA: 0x00206848 File Offset: 0x00204A48
		public string IconDamage
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

		// Token: 0x06005C75 RID: 23669 RVA: 0x00206880 File Offset: 0x00204A80
		public Span<byte> GetIconDamageBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005C76 RID: 23670 RVA: 0x00206890 File Offset: 0x00204A90
		public byte[] GetIconDamageArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06005C77 RID: 23671 RVA: 0x002068A8 File Offset: 0x00204AA8
		public string IconAttack
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

		// Token: 0x06005C78 RID: 23672 RVA: 0x002068E0 File Offset: 0x00204AE0
		public Span<byte> GetIconAttackBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06005C79 RID: 23673 RVA: 0x002068F0 File Offset: 0x00204AF0
		public byte[] GetIconAttackArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06005C7A RID: 23674 RVA: 0x00206908 File Offset: 0x00204B08
		public string IconSmall
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

		// Token: 0x06005C7B RID: 23675 RVA: 0x00206940 File Offset: 0x00204B40
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06005C7C RID: 23676 RVA: 0x00206950 File Offset: 0x00204B50
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06005C7D RID: 23677 RVA: 0x00206968 File Offset: 0x00204B68
		public string IconDamageSmall
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005C7E RID: 23678 RVA: 0x002069A0 File Offset: 0x00204BA0
		public Span<byte> GetIconDamageSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06005C7F RID: 23679 RVA: 0x002069B0 File Offset: 0x00204BB0
		public byte[] GetIconDamageSmallArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06005C80 RID: 23680 RVA: 0x002069C8 File Offset: 0x00204BC8
		public string IconAttackSmall
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005C81 RID: 23681 RVA: 0x00206A00 File Offset: 0x00204C00
		public Span<byte> GetIconAttackSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06005C82 RID: 23682 RVA: 0x00206A10 File Offset: 0x00204C10
		public byte[] GetIconAttackSmallArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06005C83 RID: 23683 RVA: 0x00206A28 File Offset: 0x00204C28
		public string IconLarge
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005C84 RID: 23684 RVA: 0x00206A60 File Offset: 0x00204C60
		public Span<byte> GetIconLargeBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06005C85 RID: 23685 RVA: 0x00206A70 File Offset: 0x00204C70
		public byte[] GetIconLargeArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06005C86 RID: 23686 RVA: 0x00206A88 File Offset: 0x00204C88
		public string IconDamageLarge
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

		// Token: 0x06005C87 RID: 23687 RVA: 0x00206AC0 File Offset: 0x00204CC0
		public Span<byte> GetIconDamageLargeBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06005C88 RID: 23688 RVA: 0x00206AD0 File Offset: 0x00204CD0
		public byte[] GetIconDamageLargeArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06005C89 RID: 23689 RVA: 0x00206AE8 File Offset: 0x00204CE8
		public string IconAttackLarge
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

		// Token: 0x06005C8A RID: 23690 RVA: 0x00206B20 File Offset: 0x00204D20
		public Span<byte> GetIconAttackLargeBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06005C8B RID: 23691 RVA: 0x00206B30 File Offset: 0x00204D30
		public byte[] GetIconAttackLargeArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06005C8C RID: 23692 RVA: 0x00206B48 File Offset: 0x00204D48
		public string Dialog
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

		// Token: 0x06005C8D RID: 23693 RVA: 0x00206B80 File Offset: 0x00204D80
		public Span<byte> GetDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06005C8E RID: 23694 RVA: 0x00206B90 File Offset: 0x00204D90
		public byte[] GetDialogArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06005C8F RID: 23695 RVA: 0x00206BA8 File Offset: 0x00204DA8
		public string CheerAudio
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

		// Token: 0x06005C90 RID: 23696 RVA: 0x00206BE0 File Offset: 0x00204DE0
		public Span<byte> GetCheerAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06005C91 RID: 23697 RVA: 0x00206BF0 File Offset: 0x00204DF0
		public byte[] GetCheerAudioArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06005C92 RID: 23698 RVA: 0x00206C08 File Offset: 0x00204E08
		public string DeathAudio
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

		// Token: 0x06005C93 RID: 23699 RVA: 0x00206C40 File Offset: 0x00204E40
		public Span<byte> GetDeathAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06005C94 RID: 23700 RVA: 0x00206C50 File Offset: 0x00204E50
		public byte[] GetDeathAudioArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06005C95 RID: 23701 RVA: 0x00206C68 File Offset: 0x00204E68
		public string Audio
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

		// Token: 0x06005C96 RID: 23702 RVA: 0x00206CA0 File Offset: 0x00204EA0
		public Span<byte> GetAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06005C97 RID: 23703 RVA: 0x00206CB0 File Offset: 0x00204EB0
		public byte[] GetAudioArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06005C98 RID: 23704 RVA: 0x00206CC8 File Offset: 0x00204EC8
		public int ModelHeight
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 70;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005C99 RID: 23705 RVA: 0x00206D08 File Offset: 0x00204F08
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ActivityIdIter()或GetActivityIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ActivityId()
		{
			Dango dango = this;
			return dango.GetActivityIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005C9A RID: 23706 RVA: 0x00206D2C File Offset: 0x00204F2C
		[NullableContext(1)]
		public readonly IEnumerable<int> ActivityIdIter()
		{
			Dango.<ActivityIdIter>d__84 <ActivityIdIter>d__ = new Dango.<ActivityIdIter>d__84(-2);
			<ActivityIdIter>d__.<>3__<>4__this = this;
			return <ActivityIdIter>d__;
		}

		// Token: 0x04004BE1 RID: 19425
		private Table __p;
	}
}
