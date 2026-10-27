using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010E8 RID: 4328
	public struct SpringFestivalMainTask : IFlatbufferObject
	{
		// Token: 0x17003821 RID: 14369
		// (get) Token: 0x0600D8BA RID: 55482 RVA: 0x0031FE46 File Offset: 0x0031E046
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D8BB RID: 55483 RVA: 0x0031FE53 File Offset: 0x0031E053
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D8BC RID: 55484 RVA: 0x0031FE5C File Offset: 0x0031E05C
		public static SpringFestivalMainTask GetRootAsSpringFestivalMainTask(ByteBuffer _bb)
		{
			return SpringFestivalMainTask.GetRootAsSpringFestivalMainTask(_bb, default(SpringFestivalMainTask));
		}

		// Token: 0x0600D8BD RID: 55485 RVA: 0x0031FE78 File Offset: 0x0031E078
		public static SpringFestivalMainTask GetRootAsSpringFestivalMainTask(ByteBuffer _bb, SpringFestivalMainTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D8BE RID: 55486 RVA: 0x0031FE95 File Offset: 0x0031E095
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D8BF RID: 55487 RVA: 0x0031FEA4 File Offset: 0x0031E0A4
		public SpringFestivalMainTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003822 RID: 14370
		// (get) Token: 0x0600D8C0 RID: 55488 RVA: 0x0031FEB4 File Offset: 0x0031E0B4
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

		// Token: 0x17003823 RID: 14371
		// (get) Token: 0x0600D8C1 RID: 55489 RVA: 0x0031FEF0 File Offset: 0x0031E0F0
		public int QuestId
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

		// Token: 0x17003824 RID: 14372
		// (get) Token: 0x0600D8C2 RID: 55490 RVA: 0x0031FF2C File Offset: 0x0031E12C
		public int OpenDay
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

		// Token: 0x17003825 RID: 14373
		// (get) Token: 0x0600D8C3 RID: 55491 RVA: 0x0031FF68 File Offset: 0x0031E168
		public string LockDesc
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

		// Token: 0x0600D8C4 RID: 55492 RVA: 0x0031FFA0 File Offset: 0x0031E1A0
		public Span<byte> GetLockDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D8C5 RID: 55493 RVA: 0x0031FFB0 File Offset: 0x0031E1B0
		public byte[] GetLockDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0400521C RID: 21020
		private Table __p;
	}
}
