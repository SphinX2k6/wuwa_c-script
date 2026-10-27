using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001105 RID: 4357
	public struct SurvivorsRoleLv : IFlatbufferObject
	{
		// Token: 0x17003919 RID: 14617
		// (get) Token: 0x0600DB55 RID: 56149 RVA: 0x00325D51 File Offset: 0x00323F51
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DB56 RID: 56150 RVA: 0x00325D5E File Offset: 0x00323F5E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DB57 RID: 56151 RVA: 0x00325D68 File Offset: 0x00323F68
		public static SurvivorsRoleLv GetRootAsSurvivorsRoleLv(ByteBuffer _bb)
		{
			return SurvivorsRoleLv.GetRootAsSurvivorsRoleLv(_bb, default(SurvivorsRoleLv));
		}

		// Token: 0x0600DB58 RID: 56152 RVA: 0x00325D84 File Offset: 0x00323F84
		public static SurvivorsRoleLv GetRootAsSurvivorsRoleLv(ByteBuffer _bb, SurvivorsRoleLv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DB59 RID: 56153 RVA: 0x00325DA1 File Offset: 0x00323FA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DB5A RID: 56154 RVA: 0x00325DB0 File Offset: 0x00323FB0
		public SurvivorsRoleLv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700391A RID: 14618
		// (get) Token: 0x0600DB5B RID: 56155 RVA: 0x00325DC0 File Offset: 0x00323FC0
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

		// Token: 0x1700391B RID: 14619
		// (get) Token: 0x0600DB5C RID: 56156 RVA: 0x00325DFC File Offset: 0x00323FFC
		public int RoleId
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

		// Token: 0x1700391C RID: 14620
		// (get) Token: 0x0600DB5D RID: 56157 RVA: 0x00325E38 File Offset: 0x00324038
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

		// Token: 0x1700391D RID: 14621
		// (get) Token: 0x0600DB5E RID: 56158 RVA: 0x00325E74 File Offset: 0x00324074
		public int Effect
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

		// Token: 0x1700391E RID: 14622
		// (get) Token: 0x0600DB5F RID: 56159 RVA: 0x00325EB4 File Offset: 0x003240B4
		public int BuffCategoryType
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

		// Token: 0x1700391F RID: 14623
		// (get) Token: 0x0600DB60 RID: 56160 RVA: 0x00325EF4 File Offset: 0x003240F4
		public int Quality
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

		// Token: 0x17003920 RID: 14624
		// (get) Token: 0x0600DB61 RID: 56161 RVA: 0x00325F34 File Offset: 0x00324134
		public string Describe
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

		// Token: 0x0600DB62 RID: 56162 RVA: 0x00325F6C File Offset: 0x0032416C
		public Span<byte> GetDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600DB63 RID: 56163 RVA: 0x00325F7C File Offset: 0x0032417C
		public byte[] GetDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003921 RID: 14625
		// (get) Token: 0x0600DB64 RID: 56164 RVA: 0x00325F94 File Offset: 0x00324194
		public int PropertyId
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

		// Token: 0x17003922 RID: 14626
		// (get) Token: 0x0600DB65 RID: 56165 RVA: 0x00325FD4 File Offset: 0x003241D4
		public int PropertyValue
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

		// Token: 0x17003923 RID: 14627
		// (get) Token: 0x0600DB66 RID: 56166 RVA: 0x00326014 File Offset: 0x00324214
		public bool IsPercent
		{
			get
			{
				int num = this.__p.__offset(22);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0400523E RID: 21054
		private Table __p;
	}
}
