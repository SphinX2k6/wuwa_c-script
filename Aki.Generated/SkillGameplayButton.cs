using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011BB RID: 4539
	public struct SkillGameplayButton : IFlatbufferObject
	{
		// Token: 0x170037DD RID: 14301
		// (get) Token: 0x0600DCDD RID: 56541 RVA: 0x00336516 File Offset: 0x00334716
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DCDE RID: 56542 RVA: 0x00336523 File Offset: 0x00334723
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DCDF RID: 56543 RVA: 0x0033652C File Offset: 0x0033472C
		public static SkillGameplayButton GetRootAsSkillGameplayButton(ByteBuffer _bb)
		{
			return SkillGameplayButton.GetRootAsSkillGameplayButton(_bb, default(SkillGameplayButton));
		}

		// Token: 0x0600DCE0 RID: 56544 RVA: 0x00336548 File Offset: 0x00334748
		public static SkillGameplayButton GetRootAsSkillGameplayButton(ByteBuffer _bb, SkillGameplayButton obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DCE1 RID: 56545 RVA: 0x00336565 File Offset: 0x00334765
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DCE2 RID: 56546 RVA: 0x00336574 File Offset: 0x00334774
		public SkillGameplayButton __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170037DE RID: 14302
		// (get) Token: 0x0600DCE3 RID: 56547 RVA: 0x00336584 File Offset: 0x00334784
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

		// Token: 0x170037DF RID: 14303
		// (get) Token: 0x0600DCE4 RID: 56548 RVA: 0x003365C0 File Offset: 0x003347C0
		public int GameplayType
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

		// Token: 0x170037E0 RID: 14304
		// (get) Token: 0x0600DCE5 RID: 56549 RVA: 0x003365FC File Offset: 0x003347FC
		public string ActionName
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

		// Token: 0x0600DCE6 RID: 56550 RVA: 0x00336633 File Offset: 0x00334833
		public Span<byte> GetActionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DCE7 RID: 56551 RVA: 0x00336642 File Offset: 0x00334842
		public byte[] GetActionNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170037E1 RID: 14305
		// (get) Token: 0x0600DCE8 RID: 56552 RVA: 0x0033665C File Offset: 0x0033485C
		public string Name
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

		// Token: 0x0600DCE9 RID: 56553 RVA: 0x00336694 File Offset: 0x00334894
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DCEA RID: 56554 RVA: 0x003366A4 File Offset: 0x003348A4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170037E2 RID: 14306
		// (get) Token: 0x0600DCEB RID: 56555 RVA: 0x003366BC File Offset: 0x003348BC
		public int ButtonType
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

		// Token: 0x170037E3 RID: 14307
		// (get) Token: 0x0600DCEC RID: 56556 RVA: 0x003366FC File Offset: 0x003348FC
		public int ActionType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170037E4 RID: 14308
		// (get) Token: 0x0600DCED RID: 56557 RVA: 0x0033673C File Offset: 0x0033493C
		public string SkillIcon
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

		// Token: 0x0600DCEE RID: 56558 RVA: 0x00336774 File Offset: 0x00334974
		public Span<byte> GetSkillIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600DCEF RID: 56559 RVA: 0x00336784 File Offset: 0x00334984
		public byte[] GetSkillIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DCF0 RID: 56560 RVA: 0x0033679C File Offset: 0x0033499C
		public int SkillIconTags(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037E5 RID: 14309
		// (get) Token: 0x0600DCF1 RID: 56561 RVA: 0x003367DC File Offset: 0x003349DC
		public int SkillIconTagsLength
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

		// Token: 0x0600DCF2 RID: 56562 RVA: 0x00336808 File Offset: 0x00334A08
		public Span<int> GetSkillIconTagsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600DCF3 RID: 56563 RVA: 0x00336818 File Offset: 0x00334A18
		public int[] GetSkillIconTagsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x170037E6 RID: 14310
		// (get) Token: 0x0600DCF4 RID: 56564 RVA: 0x00336830 File Offset: 0x00334A30
		public bool IsLongPressControlCamera
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170037E7 RID: 14311
		// (get) Token: 0x0600DCF5 RID: 56565 RVA: 0x00336870 File Offset: 0x00334A70
		public int LongPressTime
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170037E8 RID: 14312
		// (get) Token: 0x0600DCF6 RID: 56566 RVA: 0x003368B0 File Offset: 0x00334AB0
		public int RoleId
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

		// Token: 0x0600DCF7 RID: 56567 RVA: 0x003368ED File Offset: 0x00334AED
		[NullableContext(1)]
		public int[] SkillIconTags()
		{
			return this.GetSkillIconTagsArray();
		}

		// Token: 0x0600DCF8 RID: 56568 RVA: 0x003368F5 File Offset: 0x00334AF5
		[NullableContext(1)]
		public IEnumerable<int> SkillIconTagsIter()
		{
			SkillGameplayButton.<SkillIconTagsIter>d__40 <SkillIconTagsIter>d__ = new SkillGameplayButton.<SkillIconTagsIter>d__40(-2);
			<SkillIconTagsIter>d__.<>3__<>4__this = this;
			return <SkillIconTagsIter>d__;
		}

		// Token: 0x040057E8 RID: 22504
		private Table __p;
	}
}
