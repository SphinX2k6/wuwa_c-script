using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005565 RID: 21861
	public struct IConnectorLogicType : IFlatbufferObject
	{
		// Token: 0x17009C59 RID: 40025
		// (get) Token: 0x06022B5B RID: 142171 RVA: 0x004C7F27 File Offset: 0x004C6127
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022B5C RID: 142172 RVA: 0x004C7F34 File Offset: 0x004C6134
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022B5D RID: 142173 RVA: 0x004C7F3C File Offset: 0x004C613C
		public static IConnectorLogicType GetRootAsIConnectorLogicType(ByteBuffer _bb)
		{
			return IConnectorLogicType.GetRootAsIConnectorLogicType(_bb, default(IConnectorLogicType));
		}

		// Token: 0x06022B5E RID: 142174 RVA: 0x004C7F58 File Offset: 0x004C6158
		public static IConnectorLogicType GetRootAsIConnectorLogicType(ByteBuffer _bb, IConnectorLogicType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022B5F RID: 142175 RVA: 0x004C7F75 File Offset: 0x004C6175
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022B60 RID: 142176 RVA: 0x004C7F84 File Offset: 0x004C6184
		public IConnectorLogicType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C5A RID: 40026
		// (get) Token: 0x06022B61 RID: 142177 RVA: 0x004C7F94 File Offset: 0x004C6194
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

		// Token: 0x17009C5B RID: 40027
		// (get) Token: 0x06022B62 RID: 142178 RVA: 0x004C7FD0 File Offset: 0x004C61D0
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

		// Token: 0x06022B63 RID: 142179 RVA: 0x004C802D File Offset: 0x004C622D
		public static Offset<IConnectorLogicType> CreateIConnectorLogicType(FlatBufferBuilder builder, EConnectorLogicType Type = EConnectorLogicType.Range, Offset<IConnectorEffectConfig> EffectConfigOffset = default(Offset<IConnectorEffectConfig>))
		{
			builder.StartTable(2);
			IConnectorLogicType.AddEffectConfig(builder, EffectConfigOffset);
			IConnectorLogicType.AddType(builder, Type);
			return IConnectorLogicType.EndIConnectorLogicType(builder);
		}

		// Token: 0x06022B64 RID: 142180 RVA: 0x004C804A File Offset: 0x004C624A
		public static void StartIConnectorLogicType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022B65 RID: 142181 RVA: 0x004C8053 File Offset: 0x004C6253
		public static void AddType(FlatBufferBuilder builder, EConnectorLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022B66 RID: 142182 RVA: 0x004C805E File Offset: 0x004C625E
		public static void AddEffectConfig(FlatBufferBuilder builder, Offset<IConnectorEffectConfig> effectConfigOffset)
		{
			builder.AddOffset(1, effectConfigOffset.Value, 0);
		}

		// Token: 0x06022B67 RID: 142183 RVA: 0x004C806E File Offset: 0x004C626E
		public static Offset<IConnectorLogicType> EndIConnectorLogicType(FlatBufferBuilder builder)
		{
			return new Offset<IConnectorLogicType>(builder.EndTable());
		}

		// Token: 0x06022B68 RID: 142184 RVA: 0x004C807C File Offset: 0x004C627C
		public IConnectorLogicTypeT UnPack()
		{
			IConnectorLogicTypeT connectorLogicTypeT = new IConnectorLogicTypeT();
			this.UnPackTo(connectorLogicTypeT);
			return connectorLogicTypeT;
		}

		// Token: 0x06022B69 RID: 142185 RVA: 0x004C8098 File Offset: 0x004C6298
		public void UnPackTo(IConnectorLogicTypeT _o)
		{
			_o.Type = this.Type;
			_o.EffectConfig = ((this.EffectConfig != null) ? this.EffectConfig.Value.UnPack() : null);
		}

		// Token: 0x06022B6A RID: 142186 RVA: 0x004C80E0 File Offset: 0x004C62E0
		public static Offset<IConnectorLogicType> Pack(FlatBufferBuilder builder, IConnectorLogicTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConnectorLogicType>);
			}
			Offset<IConnectorEffectConfig> effectConfigOffset = (_o.EffectConfig == null) ? default(Offset<IConnectorEffectConfig>) : IConnectorEffectConfig.Pack(builder, _o.EffectConfig);
			return IConnectorLogicType.CreateIConnectorLogicType(builder, _o.Type, effectConfigOffset);
		}

		// Token: 0x0400EBBE RID: 60350
		private Table __p;
	}
}
