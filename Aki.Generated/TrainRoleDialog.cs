using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001286 RID: 4742
	public struct TrainRoleDialog : IFlatbufferObject
	{
		// Token: 0x17003EBD RID: 16061
		// (get) Token: 0x0600EEB7 RID: 61111 RVA: 0x0035EAF4 File Offset: 0x0035CCF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EEB8 RID: 61112 RVA: 0x0035EB01 File Offset: 0x0035CD01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EEB9 RID: 61113 RVA: 0x0035EB08 File Offset: 0x0035CD08
		public static TrainRoleDialog GetRootAsTrainRoleDialog(ByteBuffer _bb)
		{
			return TrainRoleDialog.GetRootAsTrainRoleDialog(_bb, default(TrainRoleDialog));
		}

		// Token: 0x0600EEBA RID: 61114 RVA: 0x0035EB24 File Offset: 0x0035CD24
		public static TrainRoleDialog GetRootAsTrainRoleDialog(ByteBuffer _bb, TrainRoleDialog obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EEBB RID: 61115 RVA: 0x0035EB41 File Offset: 0x0035CD41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EEBC RID: 61116 RVA: 0x0035EB50 File Offset: 0x0035CD50
		public TrainRoleDialog __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EBE RID: 16062
		// (get) Token: 0x0600EEBD RID: 61117 RVA: 0x0035EB60 File Offset: 0x0035CD60
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

		// Token: 0x17003EBF RID: 16063
		// (get) Token: 0x0600EEBE RID: 61118 RVA: 0x0035EB9C File Offset: 0x0035CD9C
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

		// Token: 0x17003EC0 RID: 16064
		// (get) Token: 0x0600EEBF RID: 61119 RVA: 0x0035EBD8 File Offset: 0x0035CDD8
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

		// Token: 0x17003EC1 RID: 16065
		// (get) Token: 0x0600EEC0 RID: 61120 RVA: 0x0035EC14 File Offset: 0x0035CE14
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

		// Token: 0x0600EEC1 RID: 61121 RVA: 0x0035EC4C File Offset: 0x0035CE4C
		public Span<byte> GetDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600EEC2 RID: 61122 RVA: 0x0035EC5C File Offset: 0x0035CE5C
		public byte[] GetDialogArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040058D8 RID: 22744
		private Table __p;
	}
}
