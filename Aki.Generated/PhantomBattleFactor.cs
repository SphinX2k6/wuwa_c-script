using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ED0 RID: 3792
	public struct PhantomBattleFactor : IFlatbufferObject
	{
		// Token: 0x17002634 RID: 9780
		// (get) Token: 0x0600A702 RID: 42754 RVA: 0x002AFB69 File Offset: 0x002ADD69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A703 RID: 42755 RVA: 0x002AFB76 File Offset: 0x002ADD76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A704 RID: 42756 RVA: 0x002AFB80 File Offset: 0x002ADD80
		public static PhantomBattleFactor GetRootAsPhantomBattleFactor(ByteBuffer _bb)
		{
			return PhantomBattleFactor.GetRootAsPhantomBattleFactor(_bb, default(PhantomBattleFactor));
		}

		// Token: 0x0600A705 RID: 42757 RVA: 0x002AFB9C File Offset: 0x002ADD9C
		public static PhantomBattleFactor GetRootAsPhantomBattleFactor(ByteBuffer _bb, PhantomBattleFactor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A706 RID: 42758 RVA: 0x002AFBB9 File Offset: 0x002ADDB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A707 RID: 42759 RVA: 0x002AFBC8 File Offset: 0x002ADDC8
		public PhantomBattleFactor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002635 RID: 9781
		// (get) Token: 0x0600A708 RID: 42760 RVA: 0x002AFBD8 File Offset: 0x002ADDD8
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

		// Token: 0x0600A709 RID: 42761 RVA: 0x002AFC14 File Offset: 0x002ADE14
		public int PhantomBattleEffectId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002636 RID: 9782
		// (get) Token: 0x0600A70A RID: 42762 RVA: 0x002AFC54 File Offset: 0x002ADE54
		public int PhantomBattleEffectIdLength
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

		// Token: 0x0600A70B RID: 42763 RVA: 0x002AFC7F File Offset: 0x002ADE7F
		public Span<int> GetPhantomBattleEffectIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600A70C RID: 42764 RVA: 0x002AFC8E File Offset: 0x002ADE8E
		public int[] GetPhantomBattleEffectIdArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17002637 RID: 9783
		// (get) Token: 0x0600A70D RID: 42765 RVA: 0x002AFCA8 File Offset: 0x002ADEA8
		public bool IsBeforeBattle
		{
			get
			{
				int num = this.__p.__offset(8);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002638 RID: 9784
		// (get) Token: 0x0600A70E RID: 42766 RVA: 0x002AFCE8 File Offset: 0x002ADEE8
		public string Tag
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A70F RID: 42767 RVA: 0x002AFD20 File Offset: 0x002ADF20
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A710 RID: 42768 RVA: 0x002AFD30 File Offset: 0x002ADF30
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002639 RID: 9785
		// (get) Token: 0x0600A711 RID: 42769 RVA: 0x002AFD48 File Offset: 0x002ADF48
		public int Sort
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

		// Token: 0x1700263A RID: 9786
		// (get) Token: 0x0600A712 RID: 42770 RVA: 0x002AFD88 File Offset: 0x002ADF88
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

		// Token: 0x0600A713 RID: 42771 RVA: 0x002AFDC0 File Offset: 0x002ADFC0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A714 RID: 42772 RVA: 0x002AFDD0 File Offset: 0x002ADFD0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700263B RID: 9787
		// (get) Token: 0x0600A715 RID: 42773 RVA: 0x002AFDE8 File Offset: 0x002ADFE8
		public string Description
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A716 RID: 42774 RVA: 0x002AFE20 File Offset: 0x002AE020
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A717 RID: 42775 RVA: 0x002AFE30 File Offset: 0x002AE030
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A718 RID: 42776 RVA: 0x002AFE48 File Offset: 0x002AE048
		public string DescriptionParams(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700263C RID: 9788
		// (get) Token: 0x0600A719 RID: 42777 RVA: 0x002AFE84 File Offset: 0x002AE084
		public int DescriptionParamsLength
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

		// Token: 0x1700263D RID: 9789
		// (get) Token: 0x0600A71A RID: 42778 RVA: 0x002AFEB0 File Offset: 0x002AE0B0
		public string DeActiveDescription
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

		// Token: 0x0600A71B RID: 42779 RVA: 0x002AFEE8 File Offset: 0x002AE0E8
		public Span<byte> GetDeActiveDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A71C RID: 42780 RVA: 0x002AFEF8 File Offset: 0x002AE0F8
		public byte[] GetDeActiveDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A71D RID: 42781 RVA: 0x002AFF10 File Offset: 0x002AE110
		public string DeActiveDescriptionParams(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700263E RID: 9790
		// (get) Token: 0x0600A71E RID: 42782 RVA: 0x002AFF4C File Offset: 0x002AE14C
		public int DeActiveDescriptionParamsLength
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

		// Token: 0x1700263F RID: 9791
		// (get) Token: 0x0600A71F RID: 42783 RVA: 0x002AFF78 File Offset: 0x002AE178
		public int EntryId
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

		// Token: 0x17002640 RID: 9792
		// (get) Token: 0x0600A720 RID: 42784 RVA: 0x002AFFB8 File Offset: 0x002AE1B8
		public int SlotTendency
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

		// Token: 0x0600A721 RID: 42785 RVA: 0x002AFFF5 File Offset: 0x002AE1F5
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DeActiveDescriptionParamsIter()或GetDeActiveDescriptionParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DeActiveDescriptionParams()
		{
			return this.DeActiveDescriptionParamsIter().ToArray<string>();
		}

		// Token: 0x0600A722 RID: 42786 RVA: 0x002B0002 File Offset: 0x002AE202
		[NullableContext(1)]
		public readonly IEnumerable<string> DeActiveDescriptionParamsIter()
		{
			PhantomBattleFactor.<DeActiveDescriptionParamsIter>d__46 <DeActiveDescriptionParamsIter>d__ = new PhantomBattleFactor.<DeActiveDescriptionParamsIter>d__46(-2);
			<DeActiveDescriptionParamsIter>d__.<>3__<>4__this = this;
			return <DeActiveDescriptionParamsIter>d__;
		}

		// Token: 0x0600A723 RID: 42787 RVA: 0x002B0017 File Offset: 0x002AE217
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescriptionParamsIter()或GetDescriptionParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescriptionParams()
		{
			return this.DescriptionParamsIter().ToArray<string>();
		}

		// Token: 0x0600A724 RID: 42788 RVA: 0x002B0024 File Offset: 0x002AE224
		[NullableContext(1)]
		public readonly IEnumerable<string> DescriptionParamsIter()
		{
			PhantomBattleFactor.<DescriptionParamsIter>d__48 <DescriptionParamsIter>d__ = new PhantomBattleFactor.<DescriptionParamsIter>d__48(-2);
			<DescriptionParamsIter>d__.<>3__<>4__this = this;
			return <DescriptionParamsIter>d__;
		}

		// Token: 0x0600A725 RID: 42789 RVA: 0x002B003C File Offset: 0x002AE23C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PhantomBattleEffectIdIter()或GetPhantomBattleEffectIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PhantomBattleEffectId()
		{
			PhantomBattleFactor phantomBattleFactor = this;
			return phantomBattleFactor.GetPhantomBattleEffectIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A726 RID: 42790 RVA: 0x002B0060 File Offset: 0x002AE260
		[NullableContext(1)]
		public readonly IEnumerable<int> PhantomBattleEffectIdIter()
		{
			PhantomBattleFactor.<PhantomBattleEffectIdIter>d__50 <PhantomBattleEffectIdIter>d__ = new PhantomBattleFactor.<PhantomBattleEffectIdIter>d__50(-2);
			<PhantomBattleEffectIdIter>d__.<>3__<>4__this = this;
			return <PhantomBattleEffectIdIter>d__;
		}

		// Token: 0x04004F8E RID: 20366
		private Table __p;
	}
}
