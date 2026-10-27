using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200465A RID: 18010
	public struct IGmCommand : IFlatbufferObject
	{
		// Token: 0x17007FD2 RID: 32722
		// (get) Token: 0x0601B4AF RID: 111791 RVA: 0x003E1DC5 File Offset: 0x003DFFC5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B4B0 RID: 111792 RVA: 0x003E1DD2 File Offset: 0x003DFFD2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B4B1 RID: 111793 RVA: 0x003E1DDC File Offset: 0x003DFFDC
		public static IGmCommand GetRootAsIGmCommand(ByteBuffer _bb)
		{
			return IGmCommand.GetRootAsIGmCommand(_bb, default(IGmCommand));
		}

		// Token: 0x0601B4B2 RID: 111794 RVA: 0x003E1DF8 File Offset: 0x003DFFF8
		public static IGmCommand GetRootAsIGmCommand(ByteBuffer _bb, IGmCommand obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B4B3 RID: 111795 RVA: 0x003E1E15 File Offset: 0x003E0015
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B4B4 RID: 111796 RVA: 0x003E1E24 File Offset: 0x003E0024
		public IGmCommand __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007FD3 RID: 32723
		// (get) Token: 0x0601B4B5 RID: 111797 RVA: 0x003E1E34 File Offset: 0x003E0034
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B4B6 RID: 111798 RVA: 0x003E1E70 File Offset: 0x003E0070
		public static Offset<IGmCommand> CreateIGmCommand(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IGmCommand.AddType(builder, Type);
			return IGmCommand.EndIGmCommand(builder);
		}

		// Token: 0x0601B4B7 RID: 111799 RVA: 0x003E1E86 File Offset: 0x003E0086
		public static void StartIGmCommand(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B4B8 RID: 111800 RVA: 0x003E1E8F File Offset: 0x003E008F
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B4B9 RID: 111801 RVA: 0x003E1E9A File Offset: 0x003E009A
		public static Offset<IGmCommand> EndIGmCommand(FlatBufferBuilder builder)
		{
			return new Offset<IGmCommand>(builder.EndTable());
		}

		// Token: 0x0601B4BA RID: 111802 RVA: 0x003E1EA8 File Offset: 0x003E00A8
		public IGmCommandT UnPack()
		{
			IGmCommandT gmCommandT = new IGmCommandT();
			this.UnPackTo(gmCommandT);
			return gmCommandT;
		}

		// Token: 0x0601B4BB RID: 111803 RVA: 0x003E1EC3 File Offset: 0x003E00C3
		public void UnPackTo(IGmCommandT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B4BC RID: 111804 RVA: 0x003E1ED4 File Offset: 0x003E00D4
		public static Offset<IGmCommand> Pack(FlatBufferBuilder builder, IGmCommandT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGmCommand>);
			}
			return IGmCommand.CreateIGmCommand(builder, _o.Type);
		}

		// Token: 0x0400C7D6 RID: 51158
		private Table __p;
	}
}
