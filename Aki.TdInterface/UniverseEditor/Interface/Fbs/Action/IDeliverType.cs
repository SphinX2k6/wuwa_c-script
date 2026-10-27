using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006576 RID: 25974
	public struct IDeliverType : IFlatbufferObject
	{
		// Token: 0x1700C0FC RID: 49404
		// (get) Token: 0x0602D0F6 RID: 184566 RVA: 0x0062EC76 File Offset: 0x0062CE76
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D0F7 RID: 184567 RVA: 0x0062EC83 File Offset: 0x0062CE83
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D0F8 RID: 184568 RVA: 0x0062EC8C File Offset: 0x0062CE8C
		public static IDeliverType GetRootAsIDeliverType(ByteBuffer _bb)
		{
			return IDeliverType.GetRootAsIDeliverType(_bb, default(IDeliverType));
		}

		// Token: 0x0602D0F9 RID: 184569 RVA: 0x0062ECA8 File Offset: 0x0062CEA8
		public static IDeliverType GetRootAsIDeliverType(ByteBuffer _bb, IDeliverType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D0FA RID: 184570 RVA: 0x0062ECC5 File Offset: 0x0062CEC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D0FB RID: 184571 RVA: 0x0062ECD4 File Offset: 0x0062CED4
		public IDeliverType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C0FD RID: 49405
		// (get) Token: 0x0602D0FC RID: 184572 RVA: 0x0062ECE4 File Offset: 0x0062CEE4
		public EDeliverType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDeliverType.ItemIdCellIndependent;
				}
				return (EDeliverType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D0FD RID: 184573 RVA: 0x0062ED20 File Offset: 0x0062CF20
		public static Offset<IDeliverType> CreateIDeliverType(FlatBufferBuilder builder, EDeliverType Type = EDeliverType.ItemIdCellIndependent)
		{
			builder.StartTable(1);
			IDeliverType.AddType(builder, Type);
			return IDeliverType.EndIDeliverType(builder);
		}

		// Token: 0x0602D0FE RID: 184574 RVA: 0x0062ED36 File Offset: 0x0062CF36
		public static void StartIDeliverType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D0FF RID: 184575 RVA: 0x0062ED3F File Offset: 0x0062CF3F
		public static void AddType(FlatBufferBuilder builder, EDeliverType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D100 RID: 184576 RVA: 0x0062ED4A File Offset: 0x0062CF4A
		public static Offset<IDeliverType> EndIDeliverType(FlatBufferBuilder builder)
		{
			return new Offset<IDeliverType>(builder.EndTable());
		}

		// Token: 0x0602D101 RID: 184577 RVA: 0x0062ED58 File Offset: 0x0062CF58
		public IDeliverTypeT UnPack()
		{
			IDeliverTypeT deliverTypeT = new IDeliverTypeT();
			this.UnPackTo(deliverTypeT);
			return deliverTypeT;
		}

		// Token: 0x0602D102 RID: 184578 RVA: 0x0062ED73 File Offset: 0x0062CF73
		public void UnPackTo(IDeliverTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D103 RID: 184579 RVA: 0x0062ED84 File Offset: 0x0062CF84
		public static Offset<IDeliverType> Pack(FlatBufferBuilder builder, IDeliverTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDeliverType>);
			}
			return IDeliverType.CreateIDeliverType(builder, _o.Type);
		}

		// Token: 0x04010BCE RID: 68558
		private Table __p;
	}
}
