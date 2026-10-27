using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BDF RID: 3039
	public struct DangoSkillEffect : IFlatbufferObject
	{
		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x060060D4 RID: 24788 RVA: 0x002106A6 File Offset: 0x0020E8A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060060D5 RID: 24789 RVA: 0x002106B3 File Offset: 0x0020E8B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060060D6 RID: 24790 RVA: 0x002106BC File Offset: 0x0020E8BC
		public static DangoSkillEffect GetRootAsDangoSkillEffect(ByteBuffer _bb)
		{
			return DangoSkillEffect.GetRootAsDangoSkillEffect(_bb, default(DangoSkillEffect));
		}

		// Token: 0x060060D7 RID: 24791 RVA: 0x002106D8 File Offset: 0x0020E8D8
		public static DangoSkillEffect GetRootAsDangoSkillEffect(ByteBuffer _bb, DangoSkillEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060060D8 RID: 24792 RVA: 0x002106F5 File Offset: 0x0020E8F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060060D9 RID: 24793 RVA: 0x00210704 File Offset: 0x0020E904
		public DangoSkillEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x060060DA RID: 24794 RVA: 0x00210714 File Offset: 0x0020E914
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

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x060060DB RID: 24795 RVA: 0x00210750 File Offset: 0x0020E950
		public int TrigggerPerformance
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x060060DC RID: 24796 RVA: 0x0021078C File Offset: 0x0020E98C
		public int Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x060060DD RID: 24797 RVA: 0x002107C8 File Offset: 0x0020E9C8
		public int TrigggerTiming
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

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x060060DE RID: 24798 RVA: 0x00210808 File Offset: 0x0020EA08
		public int ShowTime
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

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x060060DF RID: 24799 RVA: 0x00210848 File Offset: 0x0020EA48
		public int ParamNum
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

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x060060E0 RID: 24800 RVA: 0x00210888 File Offset: 0x0020EA88
		public bool NeedPerformance
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x060060E1 RID: 24801 RVA: 0x002108C8 File Offset: 0x0020EAC8
		public int PerformanceType
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

		// Token: 0x04004C0C RID: 19468
		private Table __p;
	}
}
