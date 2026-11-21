using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068B9 RID: 26809
	public struct IBvbPlayDialog : IFlatbufferObject
	{
		// Token: 0x1700C50D RID: 50445
		// (get) Token: 0x0602DD8D RID: 187789 RVA: 0x00643CD6 File Offset: 0x00641ED6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DD8E RID: 187790 RVA: 0x00643CE3 File Offset: 0x00641EE3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DD8F RID: 187791 RVA: 0x00643CEC File Offset: 0x00641EEC
		public static IBvbPlayDialog GetRootAsIBvbPlayDialog(ByteBuffer _bb)
		{
			return IBvbPlayDialog.GetRootAsIBvbPlayDialog(_bb, default(IBvbPlayDialog));
		}

		// Token: 0x0602DD90 RID: 187792 RVA: 0x00643D08 File Offset: 0x00641F08
		public static IBvbPlayDialog GetRootAsIBvbPlayDialog(ByteBuffer _bb, IBvbPlayDialog obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DD91 RID: 187793 RVA: 0x00643D25 File Offset: 0x00641F25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DD92 RID: 187794 RVA: 0x00643D34 File Offset: 0x00641F34
		public IBvbPlayDialog __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C50E RID: 50446
		// (get) Token: 0x0602DD93 RID: 187795 RVA: 0x00643D44 File Offset: 0x00641F44
		public EBvbPlayDialogType DialogType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbPlayDialogType.DungeonBegin;
				}
				return (EBvbPlayDialogType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DD94 RID: 187796 RVA: 0x00643D80 File Offset: 0x00641F80
		public static Offset<IBvbPlayDialog> CreateIBvbPlayDialog(FlatBufferBuilder builder, EBvbPlayDialogType DialogType = EBvbPlayDialogType.DungeonBegin)
		{
			builder.StartTable(1);
			IBvbPlayDialog.AddDialogType(builder, DialogType);
			return IBvbPlayDialog.EndIBvbPlayDialog(builder);
		}

		// Token: 0x0602DD95 RID: 187797 RVA: 0x00643D96 File Offset: 0x00641F96
		public static void StartIBvbPlayDialog(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DD96 RID: 187798 RVA: 0x00643D9F File Offset: 0x00641F9F
		public static void AddDialogType(FlatBufferBuilder builder, EBvbPlayDialogType dialogType)
		{
			builder.AddByte(0, (byte)dialogType, 0);
		}

		// Token: 0x0602DD97 RID: 187799 RVA: 0x00643DAA File Offset: 0x00641FAA
		public static Offset<IBvbPlayDialog> EndIBvbPlayDialog(FlatBufferBuilder builder)
		{
			return new Offset<IBvbPlayDialog>(builder.EndTable());
		}

		// Token: 0x0602DD98 RID: 187800 RVA: 0x00643DB8 File Offset: 0x00641FB8
		public IBvbPlayDialogT UnPack()
		{
			IBvbPlayDialogT bvbPlayDialogT = new IBvbPlayDialogT();
			this.UnPackTo(bvbPlayDialogT);
			return bvbPlayDialogT;
		}

		// Token: 0x0602DD99 RID: 187801 RVA: 0x00643DD3 File Offset: 0x00641FD3
		public void UnPackTo(IBvbPlayDialogT _o)
		{
			_o.DialogType = this.DialogType;
		}

		// Token: 0x0602DD9A RID: 187802 RVA: 0x00643DE4 File Offset: 0x00641FE4
		public static Offset<IBvbPlayDialog> Pack(FlatBufferBuilder builder, IBvbPlayDialogT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbPlayDialog>);
			}
			return IBvbPlayDialog.CreateIBvbPlayDialog(builder, _o.DialogType);
		}

		// Token: 0x040115AA RID: 71082
		private Table __p;
	}
}
