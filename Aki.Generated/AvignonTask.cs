using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BF5 RID: 3061
	public struct AvignonTask : IFlatbufferObject
	{
		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06004FB9 RID: 20409 RVA: 0x001FB391 File Offset: 0x001F9591
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004FBA RID: 20410 RVA: 0x001FB39E File Offset: 0x001F959E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004FBB RID: 20411 RVA: 0x001FB3A8 File Offset: 0x001F95A8
		public static AvignonTask GetRootAsAvignonTask(ByteBuffer _bb)
		{
			return AvignonTask.GetRootAsAvignonTask(_bb, default(AvignonTask));
		}

		// Token: 0x06004FBC RID: 20412 RVA: 0x001FB3C4 File Offset: 0x001F95C4
		public static AvignonTask GetRootAsAvignonTask(ByteBuffer _bb, AvignonTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004FBD RID: 20413 RVA: 0x001FB3E1 File Offset: 0x001F95E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004FBE RID: 20414 RVA: 0x001FB3F0 File Offset: 0x001F95F0
		public AvignonTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06004FBF RID: 20415 RVA: 0x001FB400 File Offset: 0x001F9600
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

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06004FC0 RID: 20416 RVA: 0x001FB43C File Offset: 0x001F963C
		public int Step
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

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06004FC1 RID: 20417 RVA: 0x001FB478 File Offset: 0x001F9678
		public string TaskName
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

		// Token: 0x06004FC2 RID: 20418 RVA: 0x001FB4AF File Offset: 0x001F96AF
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004FC3 RID: 20419 RVA: 0x001FB4BE File Offset: 0x001F96BE
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06004FC4 RID: 20420 RVA: 0x001FB4D8 File Offset: 0x001F96D8
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

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06004FC5 RID: 20421 RVA: 0x001FB518 File Offset: 0x001F9718
		public int JumpId
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

		// Token: 0x040050DD RID: 20701
		private Table __p;
	}
}
