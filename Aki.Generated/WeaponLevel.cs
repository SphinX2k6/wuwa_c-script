using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001196 RID: 4502
	public struct WeaponLevel : IFlatbufferObject
	{
		// Token: 0x17003DEC RID: 15852
		// (get) Token: 0x0600E7E8 RID: 59368 RVA: 0x00342969 File Offset: 0x00340B69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E7E9 RID: 59369 RVA: 0x00342976 File Offset: 0x00340B76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E7EA RID: 59370 RVA: 0x00342980 File Offset: 0x00340B80
		public static WeaponLevel GetRootAsWeaponLevel(ByteBuffer _bb)
		{
			return WeaponLevel.GetRootAsWeaponLevel(_bb, default(WeaponLevel));
		}

		// Token: 0x0600E7EB RID: 59371 RVA: 0x0034299C File Offset: 0x00340B9C
		public static WeaponLevel GetRootAsWeaponLevel(ByteBuffer _bb, WeaponLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E7EC RID: 59372 RVA: 0x003429B9 File Offset: 0x00340BB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E7ED RID: 59373 RVA: 0x003429C8 File Offset: 0x00340BC8
		public WeaponLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003DED RID: 15853
		// (get) Token: 0x0600E7EE RID: 59374 RVA: 0x003429D8 File Offset: 0x00340BD8
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

		// Token: 0x17003DEE RID: 15854
		// (get) Token: 0x0600E7EF RID: 59375 RVA: 0x00342A14 File Offset: 0x00340C14
		public int LevelId
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

		// Token: 0x17003DEF RID: 15855
		// (get) Token: 0x0600E7F0 RID: 59376 RVA: 0x00342A50 File Offset: 0x00340C50
		public int Level
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

		// Token: 0x17003DF0 RID: 15856
		// (get) Token: 0x0600E7F1 RID: 59377 RVA: 0x00342A8C File Offset: 0x00340C8C
		public int Exp
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

		// Token: 0x040052E1 RID: 21217
		private Table __p;
	}
}
