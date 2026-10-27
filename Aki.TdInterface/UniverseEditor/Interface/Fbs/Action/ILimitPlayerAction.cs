using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A11 RID: 27153
	public struct ILimitPlayerAction : IFlatbufferObject
	{
		// Token: 0x1700C974 RID: 51572
		// (get) Token: 0x0602F83D RID: 194621 RVA: 0x00678438 File Offset: 0x00676638
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F83E RID: 194622 RVA: 0x00678445 File Offset: 0x00676645
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F83F RID: 194623 RVA: 0x0067844C File Offset: 0x0067664C
		public static ILimitPlayerAction GetRootAsILimitPlayerAction(ByteBuffer _bb)
		{
			return ILimitPlayerAction.GetRootAsILimitPlayerAction(_bb, default(ILimitPlayerAction));
		}

		// Token: 0x0602F840 RID: 194624 RVA: 0x00678468 File Offset: 0x00676668
		public static ILimitPlayerAction GetRootAsILimitPlayerAction(ByteBuffer _bb, ILimitPlayerAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F841 RID: 194625 RVA: 0x00678485 File Offset: 0x00676685
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F842 RID: 194626 RVA: 0x00678494 File Offset: 0x00676694
		public ILimitPlayerAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C975 RID: 51573
		// (get) Token: 0x0602F843 RID: 194627 RVA: 0x006784A4 File Offset: 0x006766A4
		public ELimitPlayOperation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELimitPlayOperation.AllowCamera;
				}
				return (ELimitPlayOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F844 RID: 194628 RVA: 0x006784E0 File Offset: 0x006766E0
		public static Offset<ILimitPlayerAction> CreateILimitPlayerAction(FlatBufferBuilder builder, ELimitPlayOperation Type = ELimitPlayOperation.AllowCamera)
		{
			builder.StartTable(1);
			ILimitPlayerAction.AddType(builder, Type);
			return ILimitPlayerAction.EndILimitPlayerAction(builder);
		}

		// Token: 0x0602F845 RID: 194629 RVA: 0x006784F6 File Offset: 0x006766F6
		public static void StartILimitPlayerAction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F846 RID: 194630 RVA: 0x006784FF File Offset: 0x006766FF
		public static void AddType(FlatBufferBuilder builder, ELimitPlayOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F847 RID: 194631 RVA: 0x0067850A File Offset: 0x0067670A
		public static Offset<ILimitPlayerAction> EndILimitPlayerAction(FlatBufferBuilder builder)
		{
			return new Offset<ILimitPlayerAction>(builder.EndTable());
		}

		// Token: 0x0602F848 RID: 194632 RVA: 0x00678518 File Offset: 0x00676718
		public ILimitPlayerActionT UnPack()
		{
			ILimitPlayerActionT limitPlayerActionT = new ILimitPlayerActionT();
			this.UnPackTo(limitPlayerActionT);
			return limitPlayerActionT;
		}

		// Token: 0x0602F849 RID: 194633 RVA: 0x00678533 File Offset: 0x00676733
		public void UnPackTo(ILimitPlayerActionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F84A RID: 194634 RVA: 0x00678544 File Offset: 0x00676744
		public static Offset<ILimitPlayerAction> Pack(FlatBufferBuilder builder, ILimitPlayerActionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILimitPlayerAction>);
			}
			return ILimitPlayerAction.CreateILimitPlayerAction(builder, _o.Type);
		}

		// Token: 0x04011219 RID: 70169
		private Table __p;
	}
}
