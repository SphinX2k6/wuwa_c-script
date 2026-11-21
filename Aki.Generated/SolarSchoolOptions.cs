using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011F3 RID: 4595
	public struct SolarSchoolOptions : IFlatbufferObject
	{
		// Token: 0x170039F5 RID: 14837
		// (get) Token: 0x0600E261 RID: 57953 RVA: 0x0034311B File Offset: 0x0034131B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E262 RID: 57954 RVA: 0x00343128 File Offset: 0x00341328
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E263 RID: 57955 RVA: 0x00343130 File Offset: 0x00341330
		public static SolarSchoolOptions GetRootAsSolarSchoolOptions(ByteBuffer _bb)
		{
			return SolarSchoolOptions.GetRootAsSolarSchoolOptions(_bb, default(SolarSchoolOptions));
		}

		// Token: 0x0600E264 RID: 57956 RVA: 0x0034314C File Offset: 0x0034134C
		public static SolarSchoolOptions GetRootAsSolarSchoolOptions(ByteBuffer _bb, SolarSchoolOptions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E265 RID: 57957 RVA: 0x00343169 File Offset: 0x00341369
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E266 RID: 57958 RVA: 0x00343178 File Offset: 0x00341378
		public SolarSchoolOptions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170039F6 RID: 14838
		// (get) Token: 0x0600E267 RID: 57959 RVA: 0x00343188 File Offset: 0x00341388
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

		// Token: 0x170039F7 RID: 14839
		// (get) Token: 0x0600E268 RID: 57960 RVA: 0x003431C4 File Offset: 0x003413C4
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

		// Token: 0x170039F8 RID: 14840
		// (get) Token: 0x0600E269 RID: 57961 RVA: 0x00343200 File Offset: 0x00341400
		public int InstanceId
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

		// Token: 0x170039F9 RID: 14841
		// (get) Token: 0x0600E26A RID: 57962 RVA: 0x0034323C File Offset: 0x0034143C
		public int OwnerType
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

		// Token: 0x170039FA RID: 14842
		// (get) Token: 0x0600E26B RID: 57963 RVA: 0x0034327C File Offset: 0x0034147C
		public int OwnerId
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

		// Token: 0x170039FB RID: 14843
		// (get) Token: 0x0600E26C RID: 57964 RVA: 0x003432BC File Offset: 0x003414BC
		public int ActionId
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

		// Token: 0x170039FC RID: 14844
		// (get) Token: 0x0600E26D RID: 57965 RVA: 0x003432FC File Offset: 0x003414FC
		public int ConditionId
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

		// Token: 0x170039FD RID: 14845
		// (get) Token: 0x0600E26E RID: 57966 RVA: 0x0034333C File Offset: 0x0034153C
		public int LockMode
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

		// Token: 0x170039FE RID: 14846
		// (get) Token: 0x0600E26F RID: 57967 RVA: 0x0034337C File Offset: 0x0034157C
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170039FF RID: 14847
		// (get) Token: 0x0600E270 RID: 57968 RVA: 0x003433BC File Offset: 0x003415BC
		public string TextKey
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

		// Token: 0x0600E271 RID: 57969 RVA: 0x003433F4 File Offset: 0x003415F4
		public Span<byte> GetTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600E272 RID: 57970 RVA: 0x00343404 File Offset: 0x00341604
		public byte[] GetTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A00 RID: 14848
		// (get) Token: 0x0600E273 RID: 57971 RVA: 0x0034341C File Offset: 0x0034161C
		public string OptionIcon
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

		// Token: 0x0600E274 RID: 57972 RVA: 0x00343454 File Offset: 0x00341654
		public Span<byte> GetOptionIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600E275 RID: 57973 RVA: 0x00343464 File Offset: 0x00341664
		public byte[] GetOptionIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x04005831 RID: 22577
		private Table __p;
	}
}
