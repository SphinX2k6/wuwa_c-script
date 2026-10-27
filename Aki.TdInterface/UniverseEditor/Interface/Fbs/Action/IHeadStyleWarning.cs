using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068D6 RID: 26838
	public struct IHeadStyleWarning : IFlatbufferObject
	{
		// Token: 0x1700C721 RID: 50977
		// (get) Token: 0x0602ECF2 RID: 191730 RVA: 0x0066322A File Offset: 0x0066142A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602ECF3 RID: 191731 RVA: 0x00663237 File Offset: 0x00661437
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602ECF4 RID: 191732 RVA: 0x00663240 File Offset: 0x00661440
		public static IHeadStyleWarning GetRootAsIHeadStyleWarning(ByteBuffer _bb)
		{
			return IHeadStyleWarning.GetRootAsIHeadStyleWarning(_bb, default(IHeadStyleWarning));
		}

		// Token: 0x0602ECF5 RID: 191733 RVA: 0x0066325C File Offset: 0x0066145C
		public static IHeadStyleWarning GetRootAsIHeadStyleWarning(ByteBuffer _bb, IHeadStyleWarning obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602ECF6 RID: 191734 RVA: 0x00663279 File Offset: 0x00661479
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602ECF7 RID: 191735 RVA: 0x00663288 File Offset: 0x00661488
		public IHeadStyleWarning __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C722 RID: 50978
		// (get) Token: 0x0602ECF8 RID: 191736 RVA: 0x00663298 File Offset: 0x00661498
		public EHeadStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHeadStyle.Normal;
				}
				return (EHeadStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602ECF9 RID: 191737 RVA: 0x006632D4 File Offset: 0x006614D4
		public static Offset<IHeadStyleWarning> CreateIHeadStyleWarning(FlatBufferBuilder builder, EHeadStyle Type = EHeadStyle.Normal)
		{
			builder.StartTable(1);
			IHeadStyleWarning.AddType(builder, Type);
			return IHeadStyleWarning.EndIHeadStyleWarning(builder);
		}

		// Token: 0x0602ECFA RID: 191738 RVA: 0x006632EA File Offset: 0x006614EA
		public static void StartIHeadStyleWarning(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602ECFB RID: 191739 RVA: 0x006632F3 File Offset: 0x006614F3
		public static void AddType(FlatBufferBuilder builder, EHeadStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602ECFC RID: 191740 RVA: 0x006632FE File Offset: 0x006614FE
		public static Offset<IHeadStyleWarning> EndIHeadStyleWarning(FlatBufferBuilder builder)
		{
			return new Offset<IHeadStyleWarning>(builder.EndTable());
		}

		// Token: 0x0602ECFD RID: 191741 RVA: 0x0066330C File Offset: 0x0066150C
		public IHeadStyleWarningT UnPack()
		{
			IHeadStyleWarningT headStyleWarningT = new IHeadStyleWarningT();
			this.UnPackTo(headStyleWarningT);
			return headStyleWarningT;
		}

		// Token: 0x0602ECFE RID: 191742 RVA: 0x00663327 File Offset: 0x00661527
		public void UnPackTo(IHeadStyleWarningT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602ECFF RID: 191743 RVA: 0x00663338 File Offset: 0x00661538
		public static Offset<IHeadStyleWarning> Pack(FlatBufferBuilder builder, IHeadStyleWarningT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHeadStyleWarning>);
			}
			return IHeadStyleWarning.CreateIHeadStyleWarning(builder, _o.Type);
		}

		// Token: 0x04011032 RID: 69682
		private Table __p;
	}
}
