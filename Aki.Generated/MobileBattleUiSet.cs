using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E0C RID: 3596
	public struct MobileBattleUiSet : IFlatbufferObject
	{
		// Token: 0x17001F14 RID: 7956
		// (get) Token: 0x06009432 RID: 37938 RVA: 0x00285A8C File Offset: 0x00283C8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009433 RID: 37939 RVA: 0x00285A99 File Offset: 0x00283C99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009434 RID: 37940 RVA: 0x00285AA0 File Offset: 0x00283CA0
		public static MobileBattleUiSet GetRootAsMobileBattleUiSet(ByteBuffer _bb)
		{
			return MobileBattleUiSet.GetRootAsMobileBattleUiSet(_bb, default(MobileBattleUiSet));
		}

		// Token: 0x06009435 RID: 37941 RVA: 0x00285ABC File Offset: 0x00283CBC
		public static MobileBattleUiSet GetRootAsMobileBattleUiSet(ByteBuffer _bb, MobileBattleUiSet obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009436 RID: 37942 RVA: 0x00285AD9 File Offset: 0x00283CD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009437 RID: 37943 RVA: 0x00285AE8 File Offset: 0x00283CE8
		public MobileBattleUiSet __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F15 RID: 7957
		// (get) Token: 0x06009438 RID: 37944 RVA: 0x00285AF8 File Offset: 0x00283CF8
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

		// Token: 0x17001F16 RID: 7958
		// (get) Token: 0x06009439 RID: 37945 RVA: 0x00285B34 File Offset: 0x00283D34
		public int PanelIndex
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

		// Token: 0x17001F17 RID: 7959
		// (get) Token: 0x0600943A RID: 37946 RVA: 0x00285B70 File Offset: 0x00283D70
		public int ItemIndex
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

		// Token: 0x17001F18 RID: 7960
		// (get) Token: 0x0600943B RID: 37947 RVA: 0x00285BAC File Offset: 0x00283DAC
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

		// Token: 0x0600943C RID: 37948 RVA: 0x00285BE4 File Offset: 0x00283DE4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600943D RID: 37949 RVA: 0x00285BF4 File Offset: 0x00283DF4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F19 RID: 7961
		// (get) Token: 0x0600943E RID: 37950 RVA: 0x00285C0C File Offset: 0x00283E0C
		public float SourceSize
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F1A RID: 7962
		// (get) Token: 0x0600943F RID: 37951 RVA: 0x00285C50 File Offset: 0x00283E50
		public float SourceAlpha
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F1B RID: 7963
		// (get) Token: 0x06009440 RID: 37952 RVA: 0x00285C94 File Offset: 0x00283E94
		public float SourceOffsetX
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F1C RID: 7964
		// (get) Token: 0x06009441 RID: 37953 RVA: 0x00285CD8 File Offset: 0x00283ED8
		public float SourceOffsetY
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F1D RID: 7965
		// (get) Token: 0x06009442 RID: 37954 RVA: 0x00285D1C File Offset: 0x00283F1C
		public bool IsCheckOverlap
		{
			get
			{
				int num = this.__p.__offset(20);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001F1E RID: 7966
		// (get) Token: 0x06009443 RID: 37955 RVA: 0x00285D5C File Offset: 0x00283F5C
		public bool CanEdit
		{
			get
			{
				int num = this.__p.__offset(22);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001F1F RID: 7967
		// (get) Token: 0x06009444 RID: 37956 RVA: 0x00285D9C File Offset: 0x00283F9C
		public bool IsDefaultSelected
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001F20 RID: 7968
		// (get) Token: 0x06009445 RID: 37957 RVA: 0x00285DDC File Offset: 0x00283FDC
		public int SourceHierarchyIndex
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

		// Token: 0x04004EB1 RID: 20145
		private Table __p;
	}
}
