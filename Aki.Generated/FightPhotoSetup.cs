using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C6B RID: 3179
	public struct FightPhotoSetup : IFlatbufferObject
	{
		// Token: 0x170010D4 RID: 4308
		// (get) Token: 0x06006DF9 RID: 28153 RVA: 0x0022DF5D File Offset: 0x0022C15D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006DFA RID: 28154 RVA: 0x0022DF6A File Offset: 0x0022C16A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006DFB RID: 28155 RVA: 0x0022DF74 File Offset: 0x0022C174
		public static FightPhotoSetup GetRootAsFightPhotoSetup(ByteBuffer _bb)
		{
			return FightPhotoSetup.GetRootAsFightPhotoSetup(_bb, default(FightPhotoSetup));
		}

		// Token: 0x06006DFC RID: 28156 RVA: 0x0022DF90 File Offset: 0x0022C190
		public static FightPhotoSetup GetRootAsFightPhotoSetup(ByteBuffer _bb, FightPhotoSetup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006DFD RID: 28157 RVA: 0x0022DFAD File Offset: 0x0022C1AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006DFE RID: 28158 RVA: 0x0022DFBC File Offset: 0x0022C1BC
		public FightPhotoSetup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x06006DFF RID: 28159 RVA: 0x0022DFCC File Offset: 0x0022C1CC
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

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x06006E00 RID: 28160 RVA: 0x0022E008 File Offset: 0x0022C208
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

		// Token: 0x06006E01 RID: 28161 RVA: 0x0022E03F File Offset: 0x0022C23F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006E02 RID: 28162 RVA: 0x0022E04E File Offset: 0x0022C24E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x06006E03 RID: 28163 RVA: 0x0022E068 File Offset: 0x0022C268
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

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x06006E04 RID: 28164 RVA: 0x0022E0A4 File Offset: 0x0022C2A4
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

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x06006E05 RID: 28165 RVA: 0x0022E0E4 File Offset: 0x0022C2E4
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

		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x06006E06 RID: 28166 RVA: 0x0022E124 File Offset: 0x0022C324
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

		// Token: 0x06006E07 RID: 28167 RVA: 0x0022E164 File Offset: 0x0022C364
		public int DropDownList(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x06006E08 RID: 28168 RVA: 0x0022E1A4 File Offset: 0x0022C3A4
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

		// Token: 0x06006E09 RID: 28169 RVA: 0x0022E1D0 File Offset: 0x0022C3D0
		public Span<int> GetDropDownListBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06006E0A RID: 28170 RVA: 0x0022E1E0 File Offset: 0x0022C3E0
		public int[] GetDropDownListArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06006E0B RID: 28171 RVA: 0x0022E1F8 File Offset: 0x0022C3F8
		public float ValueRange(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x06006E0C RID: 28172 RVA: 0x0022E23C File Offset: 0x0022C43C
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

		// Token: 0x06006E0D RID: 28173 RVA: 0x0022E268 File Offset: 0x0022C468
		public Span<float> GetValueRangeBytes()
		{
			return this.__p.__vector_as_span<float>(18, 4);
		}

		// Token: 0x06006E0E RID: 28174 RVA: 0x0022E278 File Offset: 0x0022C478
		public float[] GetValueRangeArray()
		{
			return this.__p.__vector_as_array<float>(18) ?? Array.Empty<float>();
		}

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x06006E0F RID: 28175 RVA: 0x0022E290 File Offset: 0x0022C490
		public bool IsReverseSet
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x06006E10 RID: 28176 RVA: 0x0022E2D0 File Offset: 0x0022C4D0
		public bool IsLocalStorage
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x06006E11 RID: 28177 RVA: 0x0022E310 File Offset: 0x0022C510
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

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x06006E12 RID: 28178 RVA: 0x0022E350 File Offset: 0x0022C550
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

		// Token: 0x06006E13 RID: 28179 RVA: 0x0022E388 File Offset: 0x0022C588
		public Span<byte> GetUnitBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06006E14 RID: 28180 RVA: 0x0022E398 File Offset: 0x0022C598
		public byte[] GetUnitArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x06006E15 RID: 28181 RVA: 0x0022E3B0 File Offset: 0x0022C5B0
		public bool IsShowInPS5
		{
			get
			{
				int num = this.__p.__offset(28);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x06006E16 RID: 28182 RVA: 0x0022E3F0 File Offset: 0x0022C5F0
		public bool IsShowText
		{
			get
			{
				int num = this.__p.__offset(30);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06006E17 RID: 28183 RVA: 0x0022E430 File Offset: 0x0022C630
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DropDownListIter()或GetDropDownListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DropDownList()
		{
			FightPhotoSetup fightPhotoSetup = this;
			return fightPhotoSetup.GetDropDownListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006E18 RID: 28184 RVA: 0x0022E454 File Offset: 0x0022C654
		[NullableContext(1)]
		public readonly IEnumerable<int> DropDownListIter()
		{
			FightPhotoSetup.<DropDownListIter>d__47 <DropDownListIter>d__ = new FightPhotoSetup.<DropDownListIter>d__47(-2);
			<DropDownListIter>d__.<>3__<>4__this = this;
			return <DropDownListIter>d__;
		}

		// Token: 0x06006E19 RID: 28185 RVA: 0x0022E46C File Offset: 0x0022C66C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ValueRangeIter()或GetValueRangeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] ValueRange()
		{
			FightPhotoSetup fightPhotoSetup = this;
			return fightPhotoSetup.GetValueRangeArray() ?? Array.Empty<float>();
		}

		// Token: 0x06006E1A RID: 28186 RVA: 0x0022E490 File Offset: 0x0022C690
		[NullableContext(1)]
		public readonly IEnumerable<float> ValueRangeIter()
		{
			FightPhotoSetup.<ValueRangeIter>d__49 <ValueRangeIter>d__ = new FightPhotoSetup.<ValueRangeIter>d__49(-2);
			<ValueRangeIter>d__.<>3__<>4__this = this;
			return <ValueRangeIter>d__;
		}

		// Token: 0x04004CB6 RID: 19638
		private Table __p;
	}
}
