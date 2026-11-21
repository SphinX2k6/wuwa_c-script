using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D4F RID: 3407
	public struct FightPhotoSetup : IFlatbufferObject
	{
		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x06007404 RID: 29700 RVA: 0x0024D1D5 File Offset: 0x0024B3D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007405 RID: 29701 RVA: 0x0024D1E2 File Offset: 0x0024B3E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007406 RID: 29702 RVA: 0x0024D1EC File Offset: 0x0024B3EC
		public static FightPhotoSetup GetRootAsFightPhotoSetup(ByteBuffer _bb)
		{
			return FightPhotoSetup.GetRootAsFightPhotoSetup(_bb, default(FightPhotoSetup));
		}

		// Token: 0x06007407 RID: 29703 RVA: 0x0024D208 File Offset: 0x0024B408
		public static FightPhotoSetup GetRootAsFightPhotoSetup(ByteBuffer _bb, FightPhotoSetup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007408 RID: 29704 RVA: 0x0024D225 File Offset: 0x0024B425
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007409 RID: 29705 RVA: 0x0024D234 File Offset: 0x0024B434
		public FightPhotoSetup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x0600740A RID: 29706 RVA: 0x0024D244 File Offset: 0x0024B444
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

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x0600740B RID: 29707 RVA: 0x0024D280 File Offset: 0x0024B480
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600740C RID: 29708 RVA: 0x0024D2B7 File Offset: 0x0024B4B7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600740D RID: 29709 RVA: 0x0024D2C6 File Offset: 0x0024B4C6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x0600740E RID: 29710 RVA: 0x0024D2E0 File Offset: 0x0024B4E0
		public int Type
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

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x0600740F RID: 29711 RVA: 0x0024D31C File Offset: 0x0024B51C
		public int UiType
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

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x06007410 RID: 29712 RVA: 0x0024D35C File Offset: 0x0024B55C
		public int SortId
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

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x06007411 RID: 29713 RVA: 0x0024D39C File Offset: 0x0024B59C
		public int DefaultDropDownIndex
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

		// Token: 0x06007412 RID: 29714 RVA: 0x0024D3DC File Offset: 0x0024B5DC
		public int DropDownList(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x06007413 RID: 29715 RVA: 0x0024D41C File Offset: 0x0024B61C
		public int DropDownListLength
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

		// Token: 0x06007414 RID: 29716 RVA: 0x0024D448 File Offset: 0x0024B648
		public Span<int> GetDropDownListBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06007415 RID: 29717 RVA: 0x0024D458 File Offset: 0x0024B658
		public int[] GetDropDownListArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06007416 RID: 29718 RVA: 0x0024D470 File Offset: 0x0024B670
		public float ValueRange(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x06007417 RID: 29719 RVA: 0x0024D4B4 File Offset: 0x0024B6B4
		public int ValueRangeLength
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

		// Token: 0x06007418 RID: 29720 RVA: 0x0024D4E0 File Offset: 0x0024B6E0
		public Span<float> GetValueRangeBytes()
		{
			return this.__p.__vector_as_span<float>(18, 4);
		}

		// Token: 0x06007419 RID: 29721 RVA: 0x0024D4F0 File Offset: 0x0024B6F0
		public float[] GetValueRangeArray()
		{
			return this.__p.__vector_as_array<float>(18) ?? Array.Empty<float>();
		}

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x0600741A RID: 29722 RVA: 0x0024D508 File Offset: 0x0024B708
		public bool IsReverseSet
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x0600741B RID: 29723 RVA: 0x0024D548 File Offset: 0x0024B748
		public bool IsLocalStorage
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x0600741C RID: 29724 RVA: 0x0024D588 File Offset: 0x0024B788
		public int Digits
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

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x0600741D RID: 29725 RVA: 0x0024D5C8 File Offset: 0x0024B7C8
		public string Unit
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

		// Token: 0x0600741E RID: 29726 RVA: 0x0024D600 File Offset: 0x0024B800
		public Span<byte> GetUnitBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600741F RID: 29727 RVA: 0x0024D610 File Offset: 0x0024B810
		public byte[] GetUnitArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x06007420 RID: 29728 RVA: 0x0024D628 File Offset: 0x0024B828
		public bool IsShowInPS5
		{
			get
			{
				int num = this.__p.__offset(28);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x06007421 RID: 29729 RVA: 0x0024D668 File Offset: 0x0024B868
		public bool IsShowText
		{
			get
			{
				int num = this.__p.__offset(30);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06007422 RID: 29730 RVA: 0x0024D6A8 File Offset: 0x0024B8A8
		[NullableContext(1)]
		public int[] DropDownList()
		{
			return this.GetDropDownListArray();
		}

		// Token: 0x06007423 RID: 29731 RVA: 0x0024D6B0 File Offset: 0x0024B8B0
		[NullableContext(1)]
		public IEnumerable<int> DropDownListIter()
		{
			FightPhotoSetup.<DropDownListIter>d__47 <DropDownListIter>d__ = new FightPhotoSetup.<DropDownListIter>d__47(-2);
			<DropDownListIter>d__.<>3__<>4__this = this;
			return <DropDownListIter>d__;
		}

		// Token: 0x06007424 RID: 29732 RVA: 0x0024D6C5 File Offset: 0x0024B8C5
		[NullableContext(1)]
		public float[] ValueRange()
		{
			return this.GetValueRangeArray();
		}

		// Token: 0x06007425 RID: 29733 RVA: 0x0024D6CD File Offset: 0x0024B8CD
		[NullableContext(1)]
		public IEnumerable<float> ValueRangeIter()
		{
			FightPhotoSetup.<ValueRangeIter>d__49 <ValueRangeIter>d__ = new FightPhotoSetup.<ValueRangeIter>d__49(-2);
			<ValueRangeIter>d__.<>3__<>4__this = this;
			return <ValueRangeIter>d__;
		}

		// Token: 0x0400529A RID: 21146
		private Table __p;
	}
}
