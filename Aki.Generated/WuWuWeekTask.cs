using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011AC RID: 4524
	public struct WuWuWeekTask : IFlatbufferObject
	{
		// Token: 0x17003E96 RID: 16022
		// (get) Token: 0x0600E993 RID: 59795 RVA: 0x00346649 File Offset: 0x00344849
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E994 RID: 59796 RVA: 0x00346656 File Offset: 0x00344856
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E995 RID: 59797 RVA: 0x00346660 File Offset: 0x00344860
		public static WuWuWeekTask GetRootAsWuWuWeekTask(ByteBuffer _bb)
		{
			return WuWuWeekTask.GetRootAsWuWuWeekTask(_bb, default(WuWuWeekTask));
		}

		// Token: 0x0600E996 RID: 59798 RVA: 0x0034667C File Offset: 0x0034487C
		public static WuWuWeekTask GetRootAsWuWuWeekTask(ByteBuffer _bb, WuWuWeekTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E997 RID: 59799 RVA: 0x00346699 File Offset: 0x00344899
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E998 RID: 59800 RVA: 0x003466A8 File Offset: 0x003448A8
		public WuWuWeekTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E97 RID: 16023
		// (get) Token: 0x0600E999 RID: 59801 RVA: 0x003466B8 File Offset: 0x003448B8
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

		// Token: 0x17003E98 RID: 16024
		// (get) Token: 0x0600E99A RID: 59802 RVA: 0x003466F4 File Offset: 0x003448F4
		public int WrapId
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

		// Token: 0x17003E99 RID: 16025
		// (get) Token: 0x0600E99B RID: 59803 RVA: 0x00346730 File Offset: 0x00344930
		public int ActivityId
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

		// Token: 0x17003E9A RID: 16026
		// (get) Token: 0x0600E99C RID: 59804 RVA: 0x0034676C File Offset: 0x0034496C
		public int ConditionGroup
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

		// Token: 0x17003E9B RID: 16027
		// (get) Token: 0x0600E99D RID: 59805 RVA: 0x003467AC File Offset: 0x003449AC
		public int ProgressType
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

		// Token: 0x17003E9C RID: 16028
		// (get) Token: 0x0600E99E RID: 59806 RVA: 0x003467EC File Offset: 0x003449EC
		public int ProgressCondition
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

		// Token: 0x17003E9D RID: 16029
		// (get) Token: 0x0600E99F RID: 59807 RVA: 0x0034682C File Offset: 0x00344A2C
		public int DropId
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

		// Token: 0x17003E9E RID: 16030
		// (get) Token: 0x0600E9A0 RID: 59808 RVA: 0x0034686C File Offset: 0x00344A6C
		public string Title
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E9A1 RID: 59809 RVA: 0x003468A4 File Offset: 0x00344AA4
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E9A2 RID: 59810 RVA: 0x003468B4 File Offset: 0x00344AB4
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x040052F9 RID: 21241
		private Table __p;
	}
}
