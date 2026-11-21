using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CEF RID: 3311
	public struct DropCatchGameplay : IFlatbufferObject
	{
		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06006B46 RID: 27462 RVA: 0x0023A348 File Offset: 0x00238548
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006B47 RID: 27463 RVA: 0x0023A355 File Offset: 0x00238555
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006B48 RID: 27464 RVA: 0x0023A35C File Offset: 0x0023855C
		public static DropCatchGameplay GetRootAsDropCatchGameplay(ByteBuffer _bb)
		{
			return DropCatchGameplay.GetRootAsDropCatchGameplay(_bb, default(DropCatchGameplay));
		}

		// Token: 0x06006B49 RID: 27465 RVA: 0x0023A378 File Offset: 0x00238578
		public static DropCatchGameplay GetRootAsDropCatchGameplay(ByteBuffer _bb, DropCatchGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006B4A RID: 27466 RVA: 0x0023A395 File Offset: 0x00238595
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006B4B RID: 27467 RVA: 0x0023A3A4 File Offset: 0x002385A4
		public DropCatchGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06006B4C RID: 27468 RVA: 0x0023A3B4 File Offset: 0x002385B4
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

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06006B4D RID: 27469 RVA: 0x0023A3F0 File Offset: 0x002385F0
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

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06006B4E RID: 27470 RVA: 0x0023A42C File Offset: 0x0023862C
		public int OpenDay
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

		// Token: 0x06006B4F RID: 27471 RVA: 0x0023A468 File Offset: 0x00238668
		public int RewardIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06006B50 RID: 27472 RVA: 0x0023A4A8 File Offset: 0x002386A8
		public int RewardIdsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006B51 RID: 27473 RVA: 0x0023A4D4 File Offset: 0x002386D4
		public Span<int> GetRewardIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06006B52 RID: 27474 RVA: 0x0023A4E4 File Offset: 0x002386E4
		public int[] GetRewardIdsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06006B53 RID: 27475 RVA: 0x0023A4FC File Offset: 0x002386FC
		public int RoleId
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

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06006B54 RID: 27476 RVA: 0x0023A53C File Offset: 0x0023873C
		public int GameplayTime
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

		// Token: 0x06006B55 RID: 27477 RVA: 0x0023A57C File Offset: 0x0023877C
		public int DropPoolList(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06006B56 RID: 27478 RVA: 0x0023A5BC File Offset: 0x002387BC
		public int DropPoolListLength
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

		// Token: 0x06006B57 RID: 27479 RVA: 0x0023A5E8 File Offset: 0x002387E8
		public Span<int> GetDropPoolListBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06006B58 RID: 27480 RVA: 0x0023A5F8 File Offset: 0x002387F8
		public int[] GetDropPoolListArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06006B59 RID: 27481 RVA: 0x0023A610 File Offset: 0x00238810
		public int DropItemList(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06006B5A RID: 27482 RVA: 0x0023A650 File Offset: 0x00238850
		public int DropItemListLength
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

		// Token: 0x06006B5B RID: 27483 RVA: 0x0023A67C File Offset: 0x0023887C
		public Span<int> GetDropItemListBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06006B5C RID: 27484 RVA: 0x0023A68C File Offset: 0x0023888C
		public int[] GetDropItemListArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x06006B5D RID: 27485 RVA: 0x0023A6A4 File Offset: 0x002388A4
		public float Area(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06006B5E RID: 27486 RVA: 0x0023A6E8 File Offset: 0x002388E8
		public int AreaLength
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

		// Token: 0x06006B5F RID: 27487 RVA: 0x0023A714 File Offset: 0x00238914
		public Span<float> GetAreaBytes()
		{
			return this.__p.__vector_as_span<float>(20, 4);
		}

		// Token: 0x06006B60 RID: 27488 RVA: 0x0023A724 File Offset: 0x00238924
		public float[] GetAreaArray()
		{
			return this.__p.__vector_as_array<float>(20) ?? Array.Empty<float>();
		}

		// Token: 0x06006B61 RID: 27489 RVA: 0x0023A73C File Offset: 0x0023893C
		public float RoleBornPos(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06006B62 RID: 27490 RVA: 0x0023A780 File Offset: 0x00238980
		public int RoleBornPosLength
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

		// Token: 0x06006B63 RID: 27491 RVA: 0x0023A7AC File Offset: 0x002389AC
		public Span<float> GetRoleBornPosBytes()
		{
			return this.__p.__vector_as_span<float>(22, 4);
		}

		// Token: 0x06006B64 RID: 27492 RVA: 0x0023A7BC File Offset: 0x002389BC
		public float[] GetRoleBornPosArray()
		{
			return this.__p.__vector_as_array<float>(22) ?? Array.Empty<float>();
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06006B65 RID: 27493 RVA: 0x0023A7D4 File Offset: 0x002389D4
		public string GameplayTimeCommands
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

		// Token: 0x06006B66 RID: 27494 RVA: 0x0023A80C File Offset: 0x00238A0C
		public Span<byte> GetGameplayTimeCommandsBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06006B67 RID: 27495 RVA: 0x0023A81C File Offset: 0x00238A1C
		public byte[] GetGameplayTimeCommandsArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06006B68 RID: 27496 RVA: 0x0023A834 File Offset: 0x00238A34
		public string RemainingTimeCommands
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

		// Token: 0x06006B69 RID: 27497 RVA: 0x0023A86C File Offset: 0x00238A6C
		public Span<byte> GetRemainingTimeCommandsBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06006B6A RID: 27498 RVA: 0x0023A87C File Offset: 0x00238A7C
		public byte[] GetRemainingTimeCommandsArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06006B6B RID: 27499 RVA: 0x0023A894 File Offset: 0x00238A94
		public string SkillCommands
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

		// Token: 0x06006B6C RID: 27500 RVA: 0x0023A8CC File Offset: 0x00238ACC
		public Span<byte> GetSkillCommandsBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06006B6D RID: 27501 RVA: 0x0023A8DC File Offset: 0x00238ADC
		public byte[] GetSkillCommandsArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06006B6E RID: 27502 RVA: 0x0023A8F4 File Offset: 0x00238AF4
		public int NextGameplayId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06006B6F RID: 27503 RVA: 0x0023A934 File Offset: 0x00238B34
		public string Name
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

		// Token: 0x06006B70 RID: 27504 RVA: 0x0023A96C File Offset: 0x00238B6C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06006B71 RID: 27505 RVA: 0x0023A97C File Offset: 0x00238B7C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06006B72 RID: 27506 RVA: 0x0023A994 File Offset: 0x00238B94
		public string Desc
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

		// Token: 0x06006B73 RID: 27507 RVA: 0x0023A9CC File Offset: 0x00238BCC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06006B74 RID: 27508 RVA: 0x0023A9DC File Offset: 0x00238BDC
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06006B75 RID: 27509 RVA: 0x0023A9F4 File Offset: 0x00238BF4
		public bool IsSpecial
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06006B76 RID: 27510 RVA: 0x0023AA34 File Offset: 0x00238C34
		public bool IsNeedSettle
		{
			get
			{
				int num = this.__p.__offset(38);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06006B77 RID: 27511 RVA: 0x0023AA74 File Offset: 0x00238C74
		public int BgRoleId
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

		// Token: 0x06006B78 RID: 27512 RVA: 0x0023AAB1 File Offset: 0x00238CB1
		[NullableContext(1)]
		public float[] Area()
		{
			return this.GetAreaArray();
		}

		// Token: 0x06006B79 RID: 27513 RVA: 0x0023AAB9 File Offset: 0x00238CB9
		[NullableContext(1)]
		public IEnumerable<float> AreaIter()
		{
			DropCatchGameplay.<AreaIter>d__72 <AreaIter>d__ = new DropCatchGameplay.<AreaIter>d__72(-2);
			<AreaIter>d__.<>3__<>4__this = this;
			return <AreaIter>d__;
		}

		// Token: 0x06006B7A RID: 27514 RVA: 0x0023AACE File Offset: 0x00238CCE
		[NullableContext(1)]
		public int[] DropItemList()
		{
			return this.GetDropItemListArray();
		}

		// Token: 0x06006B7B RID: 27515 RVA: 0x0023AAD6 File Offset: 0x00238CD6
		[NullableContext(1)]
		public IEnumerable<int> DropItemListIter()
		{
			DropCatchGameplay.<DropItemListIter>d__74 <DropItemListIter>d__ = new DropCatchGameplay.<DropItemListIter>d__74(-2);
			<DropItemListIter>d__.<>3__<>4__this = this;
			return <DropItemListIter>d__;
		}

		// Token: 0x06006B7C RID: 27516 RVA: 0x0023AAEB File Offset: 0x00238CEB
		[NullableContext(1)]
		public int[] DropPoolList()
		{
			return this.GetDropPoolListArray();
		}

		// Token: 0x06006B7D RID: 27517 RVA: 0x0023AAF3 File Offset: 0x00238CF3
		[NullableContext(1)]
		public IEnumerable<int> DropPoolListIter()
		{
			DropCatchGameplay.<DropPoolListIter>d__76 <DropPoolListIter>d__ = new DropCatchGameplay.<DropPoolListIter>d__76(-2);
			<DropPoolListIter>d__.<>3__<>4__this = this;
			return <DropPoolListIter>d__;
		}

		// Token: 0x06006B7E RID: 27518 RVA: 0x0023AB08 File Offset: 0x00238D08
		[NullableContext(1)]
		public int[] RewardIds()
		{
			return this.GetRewardIdsArray();
		}

		// Token: 0x06006B7F RID: 27519 RVA: 0x0023AB10 File Offset: 0x00238D10
		[NullableContext(1)]
		public IEnumerable<int> RewardIdsIter()
		{
			DropCatchGameplay.<RewardIdsIter>d__78 <RewardIdsIter>d__ = new DropCatchGameplay.<RewardIdsIter>d__78(-2);
			<RewardIdsIter>d__.<>3__<>4__this = this;
			return <RewardIdsIter>d__;
		}

		// Token: 0x06006B80 RID: 27520 RVA: 0x0023AB25 File Offset: 0x00238D25
		[NullableContext(1)]
		public float[] RoleBornPos()
		{
			return this.GetRoleBornPosArray();
		}

		// Token: 0x06006B81 RID: 27521 RVA: 0x0023AB2D File Offset: 0x00238D2D
		[NullableContext(1)]
		public IEnumerable<float> RoleBornPosIter()
		{
			DropCatchGameplay.<RoleBornPosIter>d__80 <RoleBornPosIter>d__ = new DropCatchGameplay.<RoleBornPosIter>d__80(-2);
			<RoleBornPosIter>d__.<>3__<>4__this = this;
			return <RoleBornPosIter>d__;
		}

		// Token: 0x0400522C RID: 21036
		private Table __p;
	}
}
