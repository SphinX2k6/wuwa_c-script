using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005003 RID: 20483
	public struct IConnectorEffectConfig : IFlatbufferObject
	{
		// Token: 0x17009471 RID: 38001
		// (get) Token: 0x06020C1B RID: 134171 RVA: 0x0048E1B4 File Offset: 0x0048C3B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020C1C RID: 134172 RVA: 0x0048E1C1 File Offset: 0x0048C3C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020C1D RID: 134173 RVA: 0x0048E1C8 File Offset: 0x0048C3C8
		public static IConnectorEffectConfig GetRootAsIConnectorEffectConfig(ByteBuffer _bb)
		{
			return IConnectorEffectConfig.GetRootAsIConnectorEffectConfig(_bb, default(IConnectorEffectConfig));
		}

		// Token: 0x06020C1E RID: 134174 RVA: 0x0048E1E4 File Offset: 0x0048C3E4
		public static IConnectorEffectConfig GetRootAsIConnectorEffectConfig(ByteBuffer _bb, IConnectorEffectConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020C1F RID: 134175 RVA: 0x0048E201 File Offset: 0x0048C401
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020C20 RID: 134176 RVA: 0x0048E210 File Offset: 0x0048C410
		public IConnectorEffectConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009472 RID: 38002
		// (get) Token: 0x06020C21 RID: 134177 RVA: 0x0048E220 File Offset: 0x0048C420
		public string EffectPath
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020C22 RID: 134178 RVA: 0x0048E257 File Offset: 0x0048C457
		public Span<byte> GetEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06020C23 RID: 134179 RVA: 0x0048E266 File Offset: 0x0048C466
		public byte[] GetEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009473 RID: 38003
		// (get) Token: 0x06020C24 RID: 134180 RVA: 0x0048E274 File Offset: 0x0048C474
		public string StartPoint
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020C25 RID: 134181 RVA: 0x0048E2AB File Offset: 0x0048C4AB
		public Span<byte> GetStartPointBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06020C26 RID: 134182 RVA: 0x0048E2BA File Offset: 0x0048C4BA
		public byte[] GetStartPointArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009474 RID: 38004
		// (get) Token: 0x06020C27 RID: 134183 RVA: 0x0048E2C8 File Offset: 0x0048C4C8
		public string EndPoint
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020C28 RID: 134184 RVA: 0x0048E2FF File Offset: 0x0048C4FF
		public Span<byte> GetEndPointBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06020C29 RID: 134185 RVA: 0x0048E30E File Offset: 0x0048C50E
		public byte[] GetEndPointArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06020C2A RID: 134186 RVA: 0x0048E31C File Offset: 0x0048C51C
		public static Offset<IConnectorEffectConfig> CreateIConnectorEffectConfig(FlatBufferBuilder builder, StringOffset EffectPathOffset = default(StringOffset), StringOffset StartPointOffset = default(StringOffset), StringOffset EndPointOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IConnectorEffectConfig.AddEndPoint(builder, EndPointOffset);
			IConnectorEffectConfig.AddStartPoint(builder, StartPointOffset);
			IConnectorEffectConfig.AddEffectPath(builder, EffectPathOffset);
			return IConnectorEffectConfig.EndIConnectorEffectConfig(builder);
		}

		// Token: 0x06020C2B RID: 134187 RVA: 0x0048E340 File Offset: 0x0048C540
		public static void StartIConnectorEffectConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06020C2C RID: 134188 RVA: 0x0048E349 File Offset: 0x0048C549
		public static void AddEffectPath(FlatBufferBuilder builder, StringOffset effectPathOffset)
		{
			builder.AddOffset(0, effectPathOffset.Value, 0);
		}

		// Token: 0x06020C2D RID: 134189 RVA: 0x0048E359 File Offset: 0x0048C559
		public static void AddStartPoint(FlatBufferBuilder builder, StringOffset startPointOffset)
		{
			builder.AddOffset(1, startPointOffset.Value, 0);
		}

		// Token: 0x06020C2E RID: 134190 RVA: 0x0048E369 File Offset: 0x0048C569
		public static void AddEndPoint(FlatBufferBuilder builder, StringOffset endPointOffset)
		{
			builder.AddOffset(2, endPointOffset.Value, 0);
		}

		// Token: 0x06020C2F RID: 134191 RVA: 0x0048E379 File Offset: 0x0048C579
		public static Offset<IConnectorEffectConfig> EndIConnectorEffectConfig(FlatBufferBuilder builder)
		{
			return new Offset<IConnectorEffectConfig>(builder.EndTable());
		}

		// Token: 0x06020C30 RID: 134192 RVA: 0x0048E388 File Offset: 0x0048C588
		public IConnectorEffectConfigT UnPack()
		{
			IConnectorEffectConfigT connectorEffectConfigT = new IConnectorEffectConfigT();
			this.UnPackTo(connectorEffectConfigT);
			return connectorEffectConfigT;
		}

		// Token: 0x06020C31 RID: 134193 RVA: 0x0048E3A3 File Offset: 0x0048C5A3
		public void UnPackTo(IConnectorEffectConfigT _o)
		{
			_o.EffectPath = this.EffectPath;
			_o.StartPoint = this.StartPoint;
			_o.EndPoint = this.EndPoint;
		}

		// Token: 0x06020C32 RID: 134194 RVA: 0x0048E3CC File Offset: 0x0048C5CC
		public static Offset<IConnectorEffectConfig> Pack(FlatBufferBuilder builder, IConnectorEffectConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConnectorEffectConfig>);
			}
			StringOffset effectPathOffset = (_o.EffectPath == null) ? default(StringOffset) : builder.CreateString(_o.EffectPath);
			StringOffset startPointOffset = (_o.StartPoint == null) ? default(StringOffset) : builder.CreateString(_o.StartPoint);
			StringOffset endPointOffset = (_o.EndPoint == null) ? default(StringOffset) : builder.CreateString(_o.EndPoint);
			return IConnectorEffectConfig.CreateIConnectorEffectConfig(builder, effectPathOffset, startPointOffset, endPointOffset);
		}

		// Token: 0x0400DFC4 RID: 57284
		private Table __p;
	}
}
