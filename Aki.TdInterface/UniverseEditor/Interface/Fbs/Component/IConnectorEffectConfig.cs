using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005562 RID: 21858
	public struct IConnectorEffectConfig : IFlatbufferObject
	{
		// Token: 0x17009C52 RID: 40018
		// (get) Token: 0x06022B3B RID: 142139 RVA: 0x004C7C04 File Offset: 0x004C5E04
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022B3C RID: 142140 RVA: 0x004C7C11 File Offset: 0x004C5E11
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022B3D RID: 142141 RVA: 0x004C7C18 File Offset: 0x004C5E18
		public static IConnectorEffectConfig GetRootAsIConnectorEffectConfig(ByteBuffer _bb)
		{
			return IConnectorEffectConfig.GetRootAsIConnectorEffectConfig(_bb, default(IConnectorEffectConfig));
		}

		// Token: 0x06022B3E RID: 142142 RVA: 0x004C7C34 File Offset: 0x004C5E34
		public static IConnectorEffectConfig GetRootAsIConnectorEffectConfig(ByteBuffer _bb, IConnectorEffectConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022B3F RID: 142143 RVA: 0x004C7C51 File Offset: 0x004C5E51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022B40 RID: 142144 RVA: 0x004C7C60 File Offset: 0x004C5E60
		public IConnectorEffectConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C53 RID: 40019
		// (get) Token: 0x06022B41 RID: 142145 RVA: 0x004C7C70 File Offset: 0x004C5E70
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

		// Token: 0x06022B42 RID: 142146 RVA: 0x004C7CA7 File Offset: 0x004C5EA7
		public Span<byte> GetEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06022B43 RID: 142147 RVA: 0x004C7CB6 File Offset: 0x004C5EB6
		public byte[] GetEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009C54 RID: 40020
		// (get) Token: 0x06022B44 RID: 142148 RVA: 0x004C7CC4 File Offset: 0x004C5EC4
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

		// Token: 0x06022B45 RID: 142149 RVA: 0x004C7CFB File Offset: 0x004C5EFB
		public Span<byte> GetStartPointBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06022B46 RID: 142150 RVA: 0x004C7D0A File Offset: 0x004C5F0A
		public byte[] GetStartPointArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009C55 RID: 40021
		// (get) Token: 0x06022B47 RID: 142151 RVA: 0x004C7D18 File Offset: 0x004C5F18
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

		// Token: 0x06022B48 RID: 142152 RVA: 0x004C7D4F File Offset: 0x004C5F4F
		public Span<byte> GetEndPointBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06022B49 RID: 142153 RVA: 0x004C7D5E File Offset: 0x004C5F5E
		public byte[] GetEndPointArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06022B4A RID: 142154 RVA: 0x004C7D6C File Offset: 0x004C5F6C
		public static Offset<IConnectorEffectConfig> CreateIConnectorEffectConfig(FlatBufferBuilder builder, StringOffset EffectPathOffset = default(StringOffset), StringOffset StartPointOffset = default(StringOffset), StringOffset EndPointOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IConnectorEffectConfig.AddEndPoint(builder, EndPointOffset);
			IConnectorEffectConfig.AddStartPoint(builder, StartPointOffset);
			IConnectorEffectConfig.AddEffectPath(builder, EffectPathOffset);
			return IConnectorEffectConfig.EndIConnectorEffectConfig(builder);
		}

		// Token: 0x06022B4B RID: 142155 RVA: 0x004C7D90 File Offset: 0x004C5F90
		public static void StartIConnectorEffectConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022B4C RID: 142156 RVA: 0x004C7D99 File Offset: 0x004C5F99
		public static void AddEffectPath(FlatBufferBuilder builder, StringOffset effectPathOffset)
		{
			builder.AddOffset(0, effectPathOffset.Value, 0);
		}

		// Token: 0x06022B4D RID: 142157 RVA: 0x004C7DA9 File Offset: 0x004C5FA9
		public static void AddStartPoint(FlatBufferBuilder builder, StringOffset startPointOffset)
		{
			builder.AddOffset(1, startPointOffset.Value, 0);
		}

		// Token: 0x06022B4E RID: 142158 RVA: 0x004C7DB9 File Offset: 0x004C5FB9
		public static void AddEndPoint(FlatBufferBuilder builder, StringOffset endPointOffset)
		{
			builder.AddOffset(2, endPointOffset.Value, 0);
		}

		// Token: 0x06022B4F RID: 142159 RVA: 0x004C7DC9 File Offset: 0x004C5FC9
		public static Offset<IConnectorEffectConfig> EndIConnectorEffectConfig(FlatBufferBuilder builder)
		{
			return new Offset<IConnectorEffectConfig>(builder.EndTable());
		}

		// Token: 0x06022B50 RID: 142160 RVA: 0x004C7DD8 File Offset: 0x004C5FD8
		public IConnectorEffectConfigT UnPack()
		{
			IConnectorEffectConfigT connectorEffectConfigT = new IConnectorEffectConfigT();
			this.UnPackTo(connectorEffectConfigT);
			return connectorEffectConfigT;
		}

		// Token: 0x06022B51 RID: 142161 RVA: 0x004C7DF3 File Offset: 0x004C5FF3
		public void UnPackTo(IConnectorEffectConfigT _o)
		{
			_o.EffectPath = this.EffectPath;
			_o.StartPoint = this.StartPoint;
			_o.EndPoint = this.EndPoint;
		}

		// Token: 0x06022B52 RID: 142162 RVA: 0x004C7E1C File Offset: 0x004C601C
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

		// Token: 0x0400EBBA RID: 60346
		private Table __p;
	}
}
