using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C65 RID: 27749
	public struct IDisableSkillOperation : IFlatbufferObject
	{
		// Token: 0x1700CB88 RID: 52104
		// (get) Token: 0x0602FCB6 RID: 195766 RVA: 0x006825AB File Offset: 0x006807AB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FCB7 RID: 195767 RVA: 0x006825B8 File Offset: 0x006807B8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FCB8 RID: 195768 RVA: 0x006825C0 File Offset: 0x006807C0
		public static IDisableSkillOperation GetRootAsIDisableSkillOperation(ByteBuffer _bb)
		{
			return IDisableSkillOperation.GetRootAsIDisableSkillOperation(_bb, default(IDisableSkillOperation));
		}

		// Token: 0x0602FCB9 RID: 195769 RVA: 0x006825DC File Offset: 0x006807DC
		public static IDisableSkillOperation GetRootAsIDisableSkillOperation(ByteBuffer _bb, IDisableSkillOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FCBA RID: 195770 RVA: 0x006825F9 File Offset: 0x006807F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FCBB RID: 195771 RVA: 0x00682608 File Offset: 0x00680808
		public IDisableSkillOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB89 RID: 52105
		// (get) Token: 0x0602FCBC RID: 195772 RVA: 0x00682618 File Offset: 0x00680818
		public ESkillOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESkillOperationType.Enable;
				}
				return (ESkillOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CB8A RID: 52106
		// (get) Token: 0x0602FCBD RID: 195773 RVA: 0x00682654 File Offset: 0x00680854
		public EDisplayModeInSkillOp DisplayMode
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EDisplayModeInSkillOp.Ashen;
				}
				return (EDisplayModeInSkillOp)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CB8B RID: 52107
		// (get) Token: 0x0602FCBE RID: 195774 RVA: 0x00682690 File Offset: 0x00680890
		public bool DisableSkillWheel
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB8C RID: 52108
		// (get) Token: 0x0602FCBF RID: 195775 RVA: 0x006826D0 File Offset: 0x006808D0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FCC0 RID: 195776 RVA: 0x0068270D File Offset: 0x0068090D
		public static Offset<IDisableSkillOperation> CreateIDisableSkillOperation(FlatBufferBuilder builder, ESkillOperationType Type = ESkillOperationType.Enable, EDisplayModeInSkillOp DisplayMode = EDisplayModeInSkillOp.Ashen, bool DisableSkillWheel = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IDisableSkillOperation.AddNullMask(builder, NullMask);
			IDisableSkillOperation.AddDisableSkillWheel(builder, DisableSkillWheel);
			IDisableSkillOperation.AddDisplayMode(builder, DisplayMode);
			IDisableSkillOperation.AddType(builder, Type);
			return IDisableSkillOperation.EndIDisableSkillOperation(builder);
		}

		// Token: 0x0602FCC1 RID: 195777 RVA: 0x00682739 File Offset: 0x00680939
		public static void StartIDisableSkillOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602FCC2 RID: 195778 RVA: 0x00682742 File Offset: 0x00680942
		public static void AddType(FlatBufferBuilder builder, ESkillOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FCC3 RID: 195779 RVA: 0x0068274D File Offset: 0x0068094D
		public static void AddDisplayMode(FlatBufferBuilder builder, EDisplayModeInSkillOp displayMode)
		{
			builder.AddByte(1, (byte)displayMode, 0);
		}

		// Token: 0x0602FCC4 RID: 195780 RVA: 0x00682758 File Offset: 0x00680958
		public static void AddDisableSkillWheel(FlatBufferBuilder builder, bool disableSkillWheel)
		{
			builder.AddBool(2, disableSkillWheel, false);
		}

		// Token: 0x0602FCC5 RID: 195781 RVA: 0x00682763 File Offset: 0x00680963
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602FCC6 RID: 195782 RVA: 0x0068276E File Offset: 0x0068096E
		public static Offset<IDisableSkillOperation> EndIDisableSkillOperation(FlatBufferBuilder builder)
		{
			return new Offset<IDisableSkillOperation>(builder.EndTable());
		}

		// Token: 0x0602FCC7 RID: 195783 RVA: 0x0068277C File Offset: 0x0068097C
		public IDisableSkillOperationT UnPack()
		{
			IDisableSkillOperationT disableSkillOperationT = new IDisableSkillOperationT();
			this.UnPackTo(disableSkillOperationT);
			return disableSkillOperationT;
		}

		// Token: 0x0602FCC8 RID: 195784 RVA: 0x00682797 File Offset: 0x00680997
		public void UnPackTo(IDisableSkillOperationT _o)
		{
			_o.Type = this.Type;
			_o.DisplayMode = this.DisplayMode;
			_o.DisableSkillWheel = this.DisableSkillWheel;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602FCC9 RID: 195785 RVA: 0x006827CC File Offset: 0x006809CC
		public static Offset<IDisableSkillOperation> Pack(FlatBufferBuilder builder, IDisableSkillOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableSkillOperation>);
			}
			return IDisableSkillOperation.CreateIDisableSkillOperation(builder, _o.Type, _o.DisplayMode, _o.DisableSkillWheel, _o.NullMask);
		}

		// Token: 0x04011A91 RID: 72337
		private Table __p;
	}
}
