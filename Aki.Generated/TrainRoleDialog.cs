using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001150 RID: 4432
	public struct TrainRoleDialog : IFlatbufferObject
	{
		// Token: 0x17003B59 RID: 15193
		// (get) Token: 0x0600E149 RID: 57673 RVA: 0x00333744 File Offset: 0x00331944
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E14A RID: 57674 RVA: 0x00333751 File Offset: 0x00331951
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E14B RID: 57675 RVA: 0x00333758 File Offset: 0x00331958
		public static TrainRoleDialog GetRootAsTrainRoleDialog(ByteBuffer _bb)
		{
			return TrainRoleDialog.GetRootAsTrainRoleDialog(_bb, default(TrainRoleDialog));
		}

		// Token: 0x0600E14C RID: 57676 RVA: 0x00333774 File Offset: 0x00331974
		public static TrainRoleDialog GetRootAsTrainRoleDialog(ByteBuffer _bb, TrainRoleDialog obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E14D RID: 57677 RVA: 0x00333791 File Offset: 0x00331991
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E14E RID: 57678 RVA: 0x003337A0 File Offset: 0x003319A0
		public TrainRoleDialog __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B5A RID: 15194
		// (get) Token: 0x0600E14F RID: 57679 RVA: 0x003337B0 File Offset: 0x003319B0
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

		// Token: 0x17003B5B RID: 15195
		// (get) Token: 0x0600E150 RID: 57680 RVA: 0x003337EC File Offset: 0x003319EC
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

		// Token: 0x17003B5C RID: 15196
		// (get) Token: 0x0600E151 RID: 57681 RVA: 0x00333828 File Offset: 0x00331A28
		public int TrainType
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

		// Token: 0x17003B5D RID: 15197
		// (get) Token: 0x0600E152 RID: 57682 RVA: 0x00333864 File Offset: 0x00331A64
		public string Dialog
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

		// Token: 0x0600E153 RID: 57683 RVA: 0x0033389C File Offset: 0x00331A9C
		public Span<byte> GetDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E154 RID: 57684 RVA: 0x003338AC File Offset: 0x00331AAC
		public byte[] GetDialogArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005295 RID: 21141
		private Table __p;
	}
}
