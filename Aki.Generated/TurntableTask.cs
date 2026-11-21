using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012B5 RID: 4789
	public struct TurntableTask : IFlatbufferObject
	{
		// Token: 0x17004070 RID: 16496
		// (get) Token: 0x0600F33D RID: 62269 RVA: 0x0036885D File Offset: 0x00366A5D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F33E RID: 62270 RVA: 0x0036886A File Offset: 0x00366A6A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F33F RID: 62271 RVA: 0x00368874 File Offset: 0x00366A74
		public static TurntableTask GetRootAsTurntableTask(ByteBuffer _bb)
		{
			return TurntableTask.GetRootAsTurntableTask(_bb, default(TurntableTask));
		}

		// Token: 0x0600F340 RID: 62272 RVA: 0x00368890 File Offset: 0x00366A90
		public static TurntableTask GetRootAsTurntableTask(ByteBuffer _bb, TurntableTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F341 RID: 62273 RVA: 0x003688AD File Offset: 0x00366AAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F342 RID: 62274 RVA: 0x003688BC File Offset: 0x00366ABC
		public TurntableTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004071 RID: 16497
		// (get) Token: 0x0600F343 RID: 62275 RVA: 0x003688CC File Offset: 0x00366ACC
		public int TaskId
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

		// Token: 0x17004072 RID: 16498
		// (get) Token: 0x0600F344 RID: 62276 RVA: 0x00368908 File Offset: 0x00366B08
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

		// Token: 0x17004073 RID: 16499
		// (get) Token: 0x0600F345 RID: 62277 RVA: 0x00368944 File Offset: 0x00366B44
		public string TaskDescription
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

		// Token: 0x0600F346 RID: 62278 RVA: 0x0036897B File Offset: 0x00366B7B
		public Span<byte> GetTaskDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600F347 RID: 62279 RVA: 0x0036898A File Offset: 0x00366B8A
		public byte[] GetTaskDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17004074 RID: 16500
		// (get) Token: 0x0600F348 RID: 62280 RVA: 0x003689A4 File Offset: 0x00366BA4
		public int TaskReward
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

		// Token: 0x17004075 RID: 16501
		// (get) Token: 0x0600F349 RID: 62281 RVA: 0x003689E4 File Offset: 0x00366BE4
		public int TaskSort
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

		// Token: 0x04005909 RID: 22793
		private Table __p;
	}
}
