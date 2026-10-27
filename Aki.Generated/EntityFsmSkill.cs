using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C34 RID: 3124
	public struct EntityFsmSkill : IFlatbufferObject
	{
		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x06006964 RID: 26980 RVA: 0x00223AD1 File Offset: 0x00221CD1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006965 RID: 26981 RVA: 0x00223ADE File Offset: 0x00221CDE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006966 RID: 26982 RVA: 0x00223AE8 File Offset: 0x00221CE8
		public static EntityFsmSkill GetRootAsEntityFsmSkill(ByteBuffer _bb)
		{
			return EntityFsmSkill.GetRootAsEntityFsmSkill(_bb, default(EntityFsmSkill));
		}

		// Token: 0x06006967 RID: 26983 RVA: 0x00223B04 File Offset: 0x00221D04
		public static EntityFsmSkill GetRootAsEntityFsmSkill(ByteBuffer _bb, EntityFsmSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006968 RID: 26984 RVA: 0x00223B21 File Offset: 0x00221D21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006969 RID: 26985 RVA: 0x00223B30 File Offset: 0x00221D30
		public EntityFsmSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x0600696A RID: 26986 RVA: 0x00223B40 File Offset: 0x00221D40
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

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x0600696B RID: 26987 RVA: 0x00223B7C File Offset: 0x00221D7C
		public int ConfigId
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

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x0600696C RID: 26988 RVA: 0x00223BB8 File Offset: 0x00221DB8
		public string SkillName
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

		// Token: 0x0600696D RID: 26989 RVA: 0x00223BEF File Offset: 0x00221DEF
		public Span<byte> GetSkillNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600696E RID: 26990 RVA: 0x00223BFE File Offset: 0x00221DFE
		public byte[] GetSkillNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x0600696F RID: 26991 RVA: 0x00223C18 File Offset: 0x00221E18
		public int SkillId
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

		// Token: 0x04004C74 RID: 19572
		private Table __p;
	}
}
