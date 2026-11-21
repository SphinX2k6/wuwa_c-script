using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200555F RID: 21855
	public struct IConnectorComponent : IFlatbufferObject
	{
		// Token: 0x17009C4B RID: 40011
		// (get) Token: 0x06022B1D RID: 142109 RVA: 0x004C77F4 File Offset: 0x004C59F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022B1E RID: 142110 RVA: 0x004C7801 File Offset: 0x004C5A01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022B1F RID: 142111 RVA: 0x004C7808 File Offset: 0x004C5A08
		public static IConnectorComponent GetRootAsIConnectorComponent(ByteBuffer _bb)
		{
			return IConnectorComponent.GetRootAsIConnectorComponent(_bb, default(IConnectorComponent));
		}

		// Token: 0x06022B20 RID: 142112 RVA: 0x004C7824 File Offset: 0x004C5A24
		public static IConnectorComponent GetRootAsIConnectorComponent(ByteBuffer _bb, IConnectorComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022B21 RID: 142113 RVA: 0x004C7841 File Offset: 0x004C5A41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022B22 RID: 142114 RVA: 0x004C7850 File Offset: 0x004C5A50
		public IConnectorComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C4C RID: 40012
		// (get) Token: 0x06022B23 RID: 142115 RVA: 0x004C7860 File Offset: 0x004C5A60
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009C4D RID: 40013
		// (get) Token: 0x06022B24 RID: 142116 RVA: 0x004C78A0 File Offset: 0x004C5AA0
		public TConnectorLogic LogicTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TConnectorLogic.NONE;
				}
				return (TConnectorLogic)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022B25 RID: 142117 RVA: 0x004C78DC File Offset: 0x004C5ADC
		public TTable? LogicType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06022B26 RID: 142118 RVA: 0x004C7920 File Offset: 0x004C5B20
		public IConnectorPointToPointPathAdvance LogicTypeAsIConnectorPointToPointPathAdvance()
		{
			return this.LogicType<IConnectorPointToPointPathAdvance>().Value;
		}

		// Token: 0x06022B27 RID: 142119 RVA: 0x004C793C File Offset: 0x004C5B3C
		public IConnectorRange LogicTypeAsIConnectorRange()
		{
			return this.LogicType<IConnectorRange>().Value;
		}

		// Token: 0x17009C4E RID: 40014
		// (get) Token: 0x06022B28 RID: 142120 RVA: 0x004C7958 File Offset: 0x004C5B58
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

		// Token: 0x06022B29 RID: 142121 RVA: 0x004C7995 File Offset: 0x004C5B95
		public static Offset<IConnectorComponent> CreateIConnectorComponent(FlatBufferBuilder builder, bool Disabled = false, TConnectorLogic LogicType_type = TConnectorLogic.NONE, int LogicTypeOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IConnectorComponent.AddLogicType(builder, LogicTypeOffset);
			IConnectorComponent.AddNullMask(builder, NullMask);
			IConnectorComponent.AddLogicTypeType(builder, LogicType_type);
			IConnectorComponent.AddDisabled(builder, Disabled);
			return IConnectorComponent.EndIConnectorComponent(builder);
		}

		// Token: 0x06022B2A RID: 142122 RVA: 0x004C79C1 File Offset: 0x004C5BC1
		public static void StartIConnectorComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06022B2B RID: 142123 RVA: 0x004C79CA File Offset: 0x004C5BCA
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022B2C RID: 142124 RVA: 0x004C79D5 File Offset: 0x004C5BD5
		public static void AddLogicTypeType(FlatBufferBuilder builder, TConnectorLogic logicTypeType)
		{
			builder.AddByte(1, (byte)logicTypeType, 0);
		}

		// Token: 0x06022B2D RID: 142125 RVA: 0x004C79E0 File Offset: 0x004C5BE0
		public static void AddLogicType(FlatBufferBuilder builder, int logicTypeOffset)
		{
			builder.AddOffset(2, logicTypeOffset, 0);
		}

		// Token: 0x06022B2E RID: 142126 RVA: 0x004C79EB File Offset: 0x004C5BEB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06022B2F RID: 142127 RVA: 0x004C79F6 File Offset: 0x004C5BF6
		public static Offset<IConnectorComponent> EndIConnectorComponent(FlatBufferBuilder builder)
		{
			return new Offset<IConnectorComponent>(builder.EndTable());
		}

		// Token: 0x06022B30 RID: 142128 RVA: 0x004C7A04 File Offset: 0x004C5C04
		public IConnectorComponentT UnPack()
		{
			IConnectorComponentT connectorComponentT = new IConnectorComponentT();
			this.UnPackTo(connectorComponentT);
			return connectorComponentT;
		}

		// Token: 0x06022B31 RID: 142129 RVA: 0x004C7A20 File Offset: 0x004C5C20
		public void UnPackTo(IConnectorComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.LogicType = new TConnectorLogicUnion();
			_o.LogicType.Type = this.LogicTypeType;
			TConnectorLogic logicTypeType = this.LogicTypeType;
			if (logicTypeType != TConnectorLogic.IConnectorPointToPointPathAdvance)
			{
				if (logicTypeType == TConnectorLogic.IConnectorRange)
				{
					_o.LogicType.Value = ((this.LogicType<IConnectorRange>() != null) ? this.LogicType<IConnectorRange>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.LogicType.Value = ((this.LogicType<IConnectorPointToPointPathAdvance>() != null) ? this.LogicType<IConnectorPointToPointPathAdvance>().Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022B32 RID: 142130 RVA: 0x004C7AE0 File Offset: 0x004C5CE0
		public static Offset<IConnectorComponent> Pack(FlatBufferBuilder builder, IConnectorComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConnectorComponent>);
			}
			TConnectorLogic logicType_type = (_o.LogicType == null) ? TConnectorLogic.NONE : _o.LogicType.Type;
			int logicTypeOffset = (_o.LogicType == null) ? 0 : TConnectorLogicUnion.Pack(builder, _o.LogicType);
			return IConnectorComponent.CreateIConnectorComponent(builder, _o.Disabled, logicType_type, logicTypeOffset, _o.NullMask);
		}

		// Token: 0x0400EBB6 RID: 60342
		private Table __p;
	}
}
