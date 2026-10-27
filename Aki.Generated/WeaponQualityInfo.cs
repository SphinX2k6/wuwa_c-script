using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001199 RID: 4505
	public struct WeaponQualityInfo : IFlatbufferObject
	{
		// Token: 0x17003E01 RID: 15873
		// (get) Token: 0x0600E80C RID: 59404 RVA: 0x00342FB5 File Offset: 0x003411B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E80D RID: 59405 RVA: 0x00342FC2 File Offset: 0x003411C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E80E RID: 59406 RVA: 0x00342FCC File Offset: 0x003411CC
		public static WeaponQualityInfo GetRootAsWeaponQualityInfo(ByteBuffer _bb)
		{
			return WeaponQualityInfo.GetRootAsWeaponQualityInfo(_bb, default(WeaponQualityInfo));
		}

		// Token: 0x0600E80F RID: 59407 RVA: 0x00342FE8 File Offset: 0x003411E8
		public static WeaponQualityInfo GetRootAsWeaponQualityInfo(ByteBuffer _bb, WeaponQualityInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E810 RID: 59408 RVA: 0x00343005 File Offset: 0x00341205
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E811 RID: 59409 RVA: 0x00343014 File Offset: 0x00341214
		public WeaponQualityInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E02 RID: 15874
		// (get) Token: 0x0600E812 RID: 59410 RVA: 0x00343024 File Offset: 0x00341224
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

		// Token: 0x17003E03 RID: 15875
		// (get) Token: 0x0600E813 RID: 59411 RVA: 0x00343060 File Offset: 0x00341260
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

		// Token: 0x0600E814 RID: 59412 RVA: 0x00343097 File Offset: 0x00341297
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E815 RID: 59413 RVA: 0x003430A6 File Offset: 0x003412A6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E04 RID: 15876
		// (get) Token: 0x0600E816 RID: 59414 RVA: 0x003430C0 File Offset: 0x003412C0
		public string QualityColor
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

		// Token: 0x0600E817 RID: 59415 RVA: 0x003430F7 File Offset: 0x003412F7
		public Span<byte> GetQualityColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E818 RID: 59416 RVA: 0x00343106 File Offset: 0x00341306
		public byte[] GetQualityColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E05 RID: 15877
		// (get) Token: 0x0600E819 RID: 59417 RVA: 0x00343120 File Offset: 0x00341320
		public int LevelLimit
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

		// Token: 0x17003E06 RID: 15878
		// (get) Token: 0x0600E81A RID: 59418 RVA: 0x00343160 File Offset: 0x00341360
		public int Cost
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

		// Token: 0x17003E07 RID: 15879
		// (get) Token: 0x0600E81B RID: 59419 RVA: 0x003431A0 File Offset: 0x003413A0
		public int BasicExp
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

		// Token: 0x040052E4 RID: 21220
		private Table __p;
	}
}
