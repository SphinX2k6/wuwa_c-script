using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005000 RID: 20480
	public struct IConnectorComponent : IFlatbufferObject
	{
		// Token: 0x1700946A RID: 37994
		// (get) Token: 0x06020BFD RID: 134141 RVA: 0x0048DDA4 File Offset: 0x0048BFA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020BFE RID: 134142 RVA: 0x0048DDB1 File Offset: 0x0048BFB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020BFF RID: 134143 RVA: 0x0048DDB8 File Offset: 0x0048BFB8
		public static IConnectorComponent GetRootAsIConnectorComponent(ByteBuffer _bb)
		{
			return IConnectorComponent.GetRootAsIConnectorComponent(_bb, default(IConnectorComponent));
		}

		// Token: 0x06020C00 RID: 134144 RVA: 0x0048DDD4 File Offset: 0x0048BFD4
		public static IConnectorComponent GetRootAsIConnectorComponent(ByteBuffer _bb, IConnectorComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020C01 RID: 134145 RVA: 0x0048DDF1 File Offset: 0x0048BFF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020C02 RID: 134146 RVA: 0x0048DE00 File Offset: 0x0048C000
		public IConnectorComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700946B RID: 37995
		// (get) Token: 0x06020C03 RID: 134147 RVA: 0x0048DE10 File Offset: 0x0048C010
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700946C RID: 37996
		// (get) Token: 0x06020C04 RID: 134148 RVA: 0x0048DE50 File Offset: 0x0048C050
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

		// Token: 0x06020C05 RID: 134149 RVA: 0x0048DE8C File Offset: 0x0048C08C
		public TTable? LogicType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06020C06 RID: 134150 RVA: 0x0048DED0 File Offset: 0x0048C0D0
		public IConnectorPointToPointPathAdvance LogicTypeAsIConnectorPointToPointPathAdvance()
		{
			return this.LogicType<IConnectorPointToPointPathAdvance>().Value;
		}

		// Token: 0x06020C07 RID: 134151 RVA: 0x0048DEEC File Offset: 0x0048C0EC
		public IConnectorRange LogicTypeAsIConnectorRange()
		{
			return this.LogicType<IConnectorRange>().Value;
		}

		// Token: 0x1700946D RID: 37997
		// (get) Token: 0x06020C08 RID: 134152 RVA: 0x0048DF08 File Offset: 0x0048C108
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

		// Token: 0x06020C09 RID: 134153 RVA: 0x0048DF45 File Offset: 0x0048C145
		public static Offset<IConnectorComponent> CreateIConnectorComponent(FlatBufferBuilder builder, bool Disabled = false, TConnectorLogic LogicType_type = TConnectorLogic.NONE, int LogicTypeOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IConnectorComponent.AddLogicType(builder, LogicTypeOffset);
			IConnectorComponent.AddNullMask(builder, NullMask);
			IConnectorComponent.AddLogicTypeType(builder, LogicType_type);
			IConnectorComponent.AddDisabled(builder, Disabled);
			return IConnectorComponent.EndIConnectorComponent(builder);
		}

		// Token: 0x06020C0A RID: 134154 RVA: 0x0048DF71 File Offset: 0x0048C171
		public static void StartIConnectorComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06020C0B RID: 134155 RVA: 0x0048DF7A File Offset: 0x0048C17A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06020C0C RID: 134156 RVA: 0x0048DF85 File Offset: 0x0048C185
		public static void AddLogicTypeType(FlatBufferBuilder builder, TConnectorLogic logicTypeType)
		{
			builder.AddByte(1, (byte)logicTypeType, 0);
		}

		// Token: 0x06020C0D RID: 134157 RVA: 0x0048DF90 File Offset: 0x0048C190
		public static void AddLogicType(FlatBufferBuilder builder, int logicTypeOffset)
		{
			builder.AddOffset(2, logicTypeOffset, 0);
		}

		// Token: 0x06020C0E RID: 134158 RVA: 0x0048DF9B File Offset: 0x0048C19B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06020C0F RID: 134159 RVA: 0x0048DFA6 File Offset: 0x0048C1A6
		public static Offset<IConnectorComponent> EndIConnectorComponent(FlatBufferBuilder builder)
		{
			return new Offset<IConnectorComponent>(builder.EndTable());
		}

		// Token: 0x06020C10 RID: 134160 RVA: 0x0048DFB4 File Offset: 0x0048C1B4
		public IConnectorComponentT UnPack()
		{
			IConnectorComponentT connectorComponentT = new IConnectorComponentT();
			this.UnPackTo(connectorComponentT);
			return connectorComponentT;
		}

		// Token: 0x06020C11 RID: 134161 RVA: 0x0048DFD0 File Offset: 0x0048C1D0
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

		// Token: 0x06020C12 RID: 134162 RVA: 0x0048E090 File Offset: 0x0048C290
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

		// Token: 0x0400DFC0 RID: 57280
		private Table __p;
	}
}
