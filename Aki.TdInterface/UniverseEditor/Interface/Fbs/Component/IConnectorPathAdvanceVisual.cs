using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005015 RID: 20501
	public struct IConnectorPathAdvanceVisual : IFlatbufferObject
	{
		// Token: 0x170094A4 RID: 38052
		// (get) Token: 0x06020CE7 RID: 134375 RVA: 0x0048FA60 File Offset: 0x0048DC60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020CE8 RID: 134376 RVA: 0x0048FA6D File Offset: 0x0048DC6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020CE9 RID: 134377 RVA: 0x0048FA74 File Offset: 0x0048DC74
		public static IConnectorPathAdvanceVisual GetRootAsIConnectorPathAdvanceVisual(ByteBuffer _bb)
		{
			return IConnectorPathAdvanceVisual.GetRootAsIConnectorPathAdvanceVisual(_bb, default(IConnectorPathAdvanceVisual));
		}

		// Token: 0x06020CEA RID: 134378 RVA: 0x0048FA90 File Offset: 0x0048DC90
		public static IConnectorPathAdvanceVisual GetRootAsIConnectorPathAdvanceVisual(ByteBuffer _bb, IConnectorPathAdvanceVisual obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020CEB RID: 134379 RVA: 0x0048FAAD File Offset: 0x0048DCAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020CEC RID: 134380 RVA: 0x0048FABC File Offset: 0x0048DCBC
		public IConnectorPathAdvanceVisual __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170094A5 RID: 38053
		// (get) Token: 0x06020CED RID: 134381 RVA: 0x0048FACC File Offset: 0x0048DCCC
		public EConnectorPathAdvanceVisualType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EConnectorPathAdvanceVisualType.VasePlant;
				}
				return (EConnectorPathAdvanceVisualType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020CEE RID: 134382 RVA: 0x0048FB08 File Offset: 0x0048DD08
		public static Offset<IConnectorPathAdvanceVisual> CreateIConnectorPathAdvanceVisual(FlatBufferBuilder builder, EConnectorPathAdvanceVisualType Type = EConnectorPathAdvanceVisualType.VasePlant)
		{
			builder.StartTable(1);
			IConnectorPathAdvanceVisual.AddType(builder, Type);
			return IConnectorPathAdvanceVisual.EndIConnectorPathAdvanceVisual(builder);
		}

		// Token: 0x06020CEF RID: 134383 RVA: 0x0048FB1E File Offset: 0x0048DD1E
		public static void StartIConnectorPathAdvanceVisual(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020CF0 RID: 134384 RVA: 0x0048FB27 File Offset: 0x0048DD27
		public static void AddType(FlatBufferBuilder builder, EConnectorPathAdvanceVisualType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020CF1 RID: 134385 RVA: 0x0048FB32 File Offset: 0x0048DD32
		public static Offset<IConnectorPathAdvanceVisual> EndIConnectorPathAdvanceVisual(FlatBufferBuilder builder)
		{
			return new Offset<IConnectorPathAdvanceVisual>(builder.EndTable());
		}

		// Token: 0x06020CF2 RID: 134386 RVA: 0x0048FB40 File Offset: 0x0048DD40
		public IConnectorPathAdvanceVisualT UnPack()
		{
			IConnectorPathAdvanceVisualT connectorPathAdvanceVisualT = new IConnectorPathAdvanceVisualT();
			this.UnPackTo(connectorPathAdvanceVisualT);
			return connectorPathAdvanceVisualT;
		}

		// Token: 0x06020CF3 RID: 134387 RVA: 0x0048FB5B File Offset: 0x0048DD5B
		public void UnPackTo(IConnectorPathAdvanceVisualT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020CF4 RID: 134388 RVA: 0x0048FB6C File Offset: 0x0048DD6C
		public static Offset<IConnectorPathAdvanceVisual> Pack(FlatBufferBuilder builder, IConnectorPathAdvanceVisualT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConnectorPathAdvanceVisual>);
			}
			return IConnectorPathAdvanceVisual.CreateIConnectorPathAdvanceVisual(builder, _o.Type);
		}

		// Token: 0x0400DFE6 RID: 57318
		private Table __p;
	}
}
