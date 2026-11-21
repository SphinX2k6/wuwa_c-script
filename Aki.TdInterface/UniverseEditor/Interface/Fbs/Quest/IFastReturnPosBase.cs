using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200425F RID: 16991
	public struct IFastReturnPosBase : IFlatbufferObject
	{
		// Token: 0x170073E8 RID: 29672
		// (get) Token: 0x06017AD8 RID: 96984 RVA: 0x00360D18 File Offset: 0x0035EF18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017AD9 RID: 96985 RVA: 0x00360D25 File Offset: 0x0035EF25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017ADA RID: 96986 RVA: 0x00360D2C File Offset: 0x0035EF2C
		public static IFastReturnPosBase GetRootAsIFastReturnPosBase(ByteBuffer _bb)
		{
			return IFastReturnPosBase.GetRootAsIFastReturnPosBase(_bb, default(IFastReturnPosBase));
		}

		// Token: 0x06017ADB RID: 96987 RVA: 0x00360D48 File Offset: 0x0035EF48
		public static IFastReturnPosBase GetRootAsIFastReturnPosBase(ByteBuffer _bb, IFastReturnPosBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017ADC RID: 96988 RVA: 0x00360D65 File Offset: 0x0035EF65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017ADD RID: 96989 RVA: 0x00360D74 File Offset: 0x0035EF74
		public IFastReturnPosBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170073E9 RID: 29673
		// (get) Token: 0x06017ADE RID: 96990 RVA: 0x00360D84 File Offset: 0x0035EF84
		public EFastReturnPosType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFastReturnPosType.EntityPos;
				}
				return (EFastReturnPosType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017ADF RID: 96991 RVA: 0x00360DC0 File Offset: 0x0035EFC0
		public static Offset<IFastReturnPosBase> CreateIFastReturnPosBase(FlatBufferBuilder builder, EFastReturnPosType Type = EFastReturnPosType.EntityPos)
		{
			builder.StartTable(1);
			IFastReturnPosBase.AddType(builder, Type);
			return IFastReturnPosBase.EndIFastReturnPosBase(builder);
		}

		// Token: 0x06017AE0 RID: 96992 RVA: 0x00360DD6 File Offset: 0x0035EFD6
		public static void StartIFastReturnPosBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06017AE1 RID: 96993 RVA: 0x00360DDF File Offset: 0x0035EFDF
		public static void AddType(FlatBufferBuilder builder, EFastReturnPosType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017AE2 RID: 96994 RVA: 0x00360DEA File Offset: 0x0035EFEA
		public static Offset<IFastReturnPosBase> EndIFastReturnPosBase(FlatBufferBuilder builder)
		{
			return new Offset<IFastReturnPosBase>(builder.EndTable());
		}

		// Token: 0x06017AE3 RID: 96995 RVA: 0x00360DF8 File Offset: 0x0035EFF8
		public IFastReturnPosBaseT UnPack()
		{
			IFastReturnPosBaseT fastReturnPosBaseT = new IFastReturnPosBaseT();
			this.UnPackTo(fastReturnPosBaseT);
			return fastReturnPosBaseT;
		}

		// Token: 0x06017AE4 RID: 96996 RVA: 0x00360E13 File Offset: 0x0035F013
		public void UnPackTo(IFastReturnPosBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06017AE5 RID: 96997 RVA: 0x00360E24 File Offset: 0x0035F024
		public static Offset<IFastReturnPosBase> Pack(FlatBufferBuilder builder, IFastReturnPosBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFastReturnPosBase>);
			}
			return IFastReturnPosBase.CreateIFastReturnPosBase(builder, _o.Type);
		}

		// Token: 0x0400C17D RID: 49533
		private Table __p;
	}
}
