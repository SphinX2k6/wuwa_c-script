using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006248 RID: 25160
	public struct IBvbPlayDialog : IFlatbufferObject
	{
		// Token: 0x1700BB85 RID: 48005
		// (get) Token: 0x0602B62C RID: 177708 RVA: 0x005F8ECE File Offset: 0x005F70CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B62D RID: 177709 RVA: 0x005F8EDB File Offset: 0x005F70DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B62E RID: 177710 RVA: 0x005F8EE4 File Offset: 0x005F70E4
		public static IBvbPlayDialog GetRootAsIBvbPlayDialog(ByteBuffer _bb)
		{
			return IBvbPlayDialog.GetRootAsIBvbPlayDialog(_bb, default(IBvbPlayDialog));
		}

		// Token: 0x0602B62F RID: 177711 RVA: 0x005F8F00 File Offset: 0x005F7100
		public static IBvbPlayDialog GetRootAsIBvbPlayDialog(ByteBuffer _bb, IBvbPlayDialog obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B630 RID: 177712 RVA: 0x005F8F1D File Offset: 0x005F711D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B631 RID: 177713 RVA: 0x005F8F2C File Offset: 0x005F712C
		public IBvbPlayDialog __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB86 RID: 48006
		// (get) Token: 0x0602B632 RID: 177714 RVA: 0x005F8F3C File Offset: 0x005F713C
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

		// Token: 0x0602B633 RID: 177715 RVA: 0x005F8F78 File Offset: 0x005F7178
		public static Offset<IBvbPlayDialog> CreateIBvbPlayDialog(FlatBufferBuilder builder, EBvbPlayDialogType DialogType = EBvbPlayDialogType.DungeonBegin)
		{
			builder.StartTable(1);
			IBvbPlayDialog.AddDialogType(builder, DialogType);
			return IBvbPlayDialog.EndIBvbPlayDialog(builder);
		}

		// Token: 0x0602B634 RID: 177716 RVA: 0x005F8F8E File Offset: 0x005F718E
		public static void StartIBvbPlayDialog(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B635 RID: 177717 RVA: 0x005F8F97 File Offset: 0x005F7197
		public static void AddDialogType(FlatBufferBuilder builder, EBvbPlayDialogType dialogType)
		{
			builder.AddByte(0, (byte)dialogType, 0);
		}

		// Token: 0x0602B636 RID: 177718 RVA: 0x005F8FA2 File Offset: 0x005F71A2
		public static Offset<IBvbPlayDialog> EndIBvbPlayDialog(FlatBufferBuilder builder)
		{
			return new Offset<IBvbPlayDialog>(builder.EndTable());
		}

		// Token: 0x0602B637 RID: 177719 RVA: 0x005F8FB0 File Offset: 0x005F71B0
		public IBvbPlayDialogT UnPack()
		{
			IBvbPlayDialogT bvbPlayDialogT = new IBvbPlayDialogT();
			this.UnPackTo(bvbPlayDialogT);
			return bvbPlayDialogT;
		}

		// Token: 0x0602B638 RID: 177720 RVA: 0x005F8FCB File Offset: 0x005F71CB
		public void UnPackTo(IBvbPlayDialogT _o)
		{
			_o.DialogType = this.DialogType;
		}

		// Token: 0x0602B639 RID: 177721 RVA: 0x005F8FDC File Offset: 0x005F71DC
		public static Offset<IBvbPlayDialog> Pack(FlatBufferBuilder builder, IBvbPlayDialogT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbPlayDialog>);
			}
			return IBvbPlayDialog.CreateIBvbPlayDialog(builder, _o.DialogType);
		}

		// Token: 0x04010795 RID: 67477
		private Table __p;
	}
}
