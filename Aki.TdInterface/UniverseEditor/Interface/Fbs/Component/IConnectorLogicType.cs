using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005006 RID: 20486
	public struct IConnectorLogicType : IFlatbufferObject
	{
		// Token: 0x17009478 RID: 38008
		// (get) Token: 0x06020C3B RID: 134203 RVA: 0x0048E4D7 File Offset: 0x0048C6D7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020C3C RID: 134204 RVA: 0x0048E4E4 File Offset: 0x0048C6E4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020C3D RID: 134205 RVA: 0x0048E4EC File Offset: 0x0048C6EC
		public static IConnectorLogicType GetRootAsIConnectorLogicType(ByteBuffer _bb)
		{
			return IConnectorLogicType.GetRootAsIConnectorLogicType(_bb, default(IConnectorLogicType));
		}

		// Token: 0x06020C3E RID: 134206 RVA: 0x0048E508 File Offset: 0x0048C708
		public static IConnectorLogicType GetRootAsIConnectorLogicType(ByteBuffer _bb, IConnectorLogicType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020C3F RID: 134207 RVA: 0x0048E525 File Offset: 0x0048C725
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020C40 RID: 134208 RVA: 0x0048E534 File Offset: 0x0048C734
		public IConnectorLogicType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009479 RID: 38009
		// (get) Token: 0x06020C41 RID: 134209 RVA: 0x0048E544 File Offset: 0x0048C744
		public EConnectorLogicType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EConnectorLogicType.Range;
				}
				return (EConnectorLogicType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700947A RID: 38010
		// (get) Token: 0x06020C42 RID: 134210 RVA: 0x0048E580 File Offset: 0x0048C780
		public IConnectorEffectConfig? EffectConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConnectorEffectConfig?(default(IConnectorEffectConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06020C43 RID: 134211 RVA: 0x0048E5DD File Offset: 0x0048C7DD
		public static Offset<IConnectorLogicType> CreateIConnectorLogicType(FlatBufferBuilder builder, EConnectorLogicType Type = EConnectorLogicType.Range, Offset<IConnectorEffectConfig> EffectConfigOffset = default(Offset<IConnectorEffectConfig>))
		{
			builder.StartTable(2);
			IConnectorLogicType.AddEffectConfig(builder, EffectConfigOffset);
			IConnectorLogicType.AddType(builder, Type);
			return IConnectorLogicType.EndIConnectorLogicType(builder);
		}

		// Token: 0x06020C44 RID: 134212 RVA: 0x0048E5FA File Offset: 0x0048C7FA
		public static void StartIConnectorLogicType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020C45 RID: 134213 RVA: 0x0048E603 File Offset: 0x0048C803
		public static void AddType(FlatBufferBuilder builder, EConnectorLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020C46 RID: 134214 RVA: 0x0048E60E File Offset: 0x0048C80E
		public static void AddEffectConfig(FlatBufferBuilder builder, Offset<IConnectorEffectConfig> effectConfigOffset)
		{
			builder.AddOffset(1, effectConfigOffset.Value, 0);
		}

		// Token: 0x06020C47 RID: 134215 RVA: 0x0048E61E File Offset: 0x0048C81E
		public static Offset<IConnectorLogicType> EndIConnectorLogicType(FlatBufferBuilder builder)
		{
			return new Offset<IConnectorLogicType>(builder.EndTable());
		}

		// Token: 0x06020C48 RID: 134216 RVA: 0x0048E62C File Offset: 0x0048C82C
		public IConnectorLogicTypeT UnPack()
		{
			IConnectorLogicTypeT connectorLogicTypeT = new IConnectorLogicTypeT();
			this.UnPackTo(connectorLogicTypeT);
			return connectorLogicTypeT;
		}

		// Token: 0x06020C49 RID: 134217 RVA: 0x0048E648 File Offset: 0x0048C848
		public void UnPackTo(IConnectorLogicTypeT _o)
		{
			_o.Type = this.Type;
			_o.EffectConfig = ((this.EffectConfig != null) ? this.EffectConfig.Value.UnPack() : null);
		}

		// Token: 0x06020C4A RID: 134218 RVA: 0x0048E690 File Offset: 0x0048C890
		public static Offset<IConnectorLogicType> Pack(FlatBufferBuilder builder, IConnectorLogicTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConnectorLogicType>);
			}
			Offset<IConnectorEffectConfig> effectConfigOffset = (_o.EffectConfig == null) ? default(Offset<IConnectorEffectConfig>) : IConnectorEffectConfig.Pack(builder, _o.EffectConfig);
			return IConnectorLogicType.CreateIConnectorLogicType(builder, _o.Type, effectConfigOffset);
		}

		// Token: 0x0400DFC8 RID: 57288
		private Table __p;
	}
}
