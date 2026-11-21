using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001209 RID: 4617
	public struct SolarSchoolTask : IFlatbufferObject
	{
		// Token: 0x17003ACA RID: 15050
		// (get) Token: 0x0600E446 RID: 58438 RVA: 0x00347748 File Offset: 0x00345948
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E447 RID: 58439 RVA: 0x00347755 File Offset: 0x00345955
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E448 RID: 58440 RVA: 0x0034775C File Offset: 0x0034595C
		public static SolarSchoolTask GetRootAsSolarSchoolTask(ByteBuffer _bb)
		{
			return SolarSchoolTask.GetRootAsSolarSchoolTask(_bb, default(SolarSchoolTask));
		}

		// Token: 0x0600E449 RID: 58441 RVA: 0x00347778 File Offset: 0x00345978
		public static SolarSchoolTask GetRootAsSolarSchoolTask(ByteBuffer _bb, SolarSchoolTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E44A RID: 58442 RVA: 0x00347795 File Offset: 0x00345995
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E44B RID: 58443 RVA: 0x003477A4 File Offset: 0x003459A4
		public SolarSchoolTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003ACB RID: 15051
		// (get) Token: 0x0600E44C RID: 58444 RVA: 0x003477B4 File Offset: 0x003459B4
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

		// Token: 0x17003ACC RID: 15052
		// (get) Token: 0x0600E44D RID: 58445 RVA: 0x003477F0 File Offset: 0x003459F0
		public int TaskType
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

		// Token: 0x17003ACD RID: 15053
		// (get) Token: 0x0600E44E RID: 58446 RVA: 0x0034782C File Offset: 0x00345A2C
		public int TaskTab
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

		// Token: 0x17003ACE RID: 15054
		// (get) Token: 0x0600E44F RID: 58447 RVA: 0x00347868 File Offset: 0x00345A68
		public int SortId
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

		// Token: 0x17003ACF RID: 15055
		// (get) Token: 0x0600E450 RID: 58448 RVA: 0x003478A8 File Offset: 0x00345AA8
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 28;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003AD0 RID: 15056
		// (get) Token: 0x0600E451 RID: 58449 RVA: 0x003478E8 File Offset: 0x00345AE8
		public string TaskName
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E452 RID: 58450 RVA: 0x00347920 File Offset: 0x00345B20
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E453 RID: 58451 RVA: 0x00347930 File Offset: 0x00345B30
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003AD1 RID: 15057
		// (get) Token: 0x0600E454 RID: 58452 RVA: 0x00347948 File Offset: 0x00345B48
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

		// Token: 0x04005849 RID: 22601
		private Table __p;
	}
}
