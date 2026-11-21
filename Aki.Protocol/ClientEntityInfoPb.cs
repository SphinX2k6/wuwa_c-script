using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002A3 RID: 675
	public sealed class ClientEntityInfoPb : IMessage<ClientEntityInfoPb>, IMessage, IEquatable<ClientEntityInfoPb>, IDeepCloneable<ClientEntityInfoPb>, IBufferMessage
	{
		// Token: 0x06004669 RID: 18025 RVA: 0x000AD596 File Offset: 0x000AB796
		[NullableContext(1)]
		public static ClientEntityInfoPb Create()
		{
			return new ClientEntityInfoPb();
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x0600466A RID: 18026 RVA: 0x000AD59D File Offset: 0x000AB79D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClientEntityInfoPb> Parser
		{
			get
			{
				return ClientEntityInfoPb._parser;
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x0600466B RID: 18027 RVA: 0x000AD5A4 File Offset: 0x000AB7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x0600466C RID: 18028 RVA: 0x000AD5A7 File Offset: 0x000AB7A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientEntityInfoPb.Descriptor;
			}
		}

		// Token: 0x0600466D RID: 18029 RVA: 0x000AD5AE File Offset: 0x000AB7AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientEntityInfoPb()
		{
		}

		// Token: 0x0600466E RID: 18030 RVA: 0x000AD5B8 File Offset: 0x000AB7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientEntityInfoPb(ClientEntityInfoPb other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.entityConfigId_ = other.entityConfigId_;
			this.incId_ = other.incId_;
			this.serverRealExist_ = other.serverRealExist_;
			this.isClientEntityConfig_ = other.isClientEntityConfig_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600466F RID: 18031 RVA: 0x000AD618 File Offset: 0x000AB818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientEntityInfoPb Clone()
		{
			return new ClientEntityInfoPb(this);
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06004670 RID: 18032 RVA: 0x000AD620 File Offset: 0x000AB820
		// (set) Token: 0x06004671 RID: 18033 RVA: 0x000AD628 File Offset: 0x000AB828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfigId
		{
			get
			{
				return this.entityConfigId_;
			}
			set
			{
				this.entityConfigId_ = value;
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06004672 RID: 18034 RVA: 0x000AD631 File Offset: 0x000AB831
		// (set) Token: 0x06004673 RID: 18035 RVA: 0x000AD649 File Offset: 0x000AB849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long IncId
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.incId_;
				}
				return ClientEntityInfoPb.IncIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.incId_ = value;
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06004674 RID: 18036 RVA: 0x000AD660 File Offset: 0x000AB860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasIncId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004675 RID: 18037 RVA: 0x000AD66D File Offset: 0x000AB86D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearIncId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x06004676 RID: 18038 RVA: 0x000AD67E File Offset: 0x000AB87E
		// (set) Token: 0x06004677 RID: 18039 RVA: 0x000AD696 File Offset: 0x000AB896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ServerRealExist
		{
			get
			{
				if ((this._hasBits0 & 2) != 0)
				{
					return this.serverRealExist_;
				}
				return ClientEntityInfoPb.ServerRealExistDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.serverRealExist_ = value;
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06004678 RID: 18040 RVA: 0x000AD6AD File Offset: 0x000AB8AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasServerRealExist
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004679 RID: 18041 RVA: 0x000AD6BA File Offset: 0x000AB8BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearServerRealExist()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x0600467A RID: 18042 RVA: 0x000AD6CB File Offset: 0x000AB8CB
		// (set) Token: 0x0600467B RID: 18043 RVA: 0x000AD6D3 File Offset: 0x000AB8D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsClientEntityConfig
		{
			get
			{
				return this.isClientEntityConfig_;
			}
			set
			{
				this.isClientEntityConfig_ = value;
			}
		}

		// Token: 0x0600467C RID: 18044 RVA: 0x000AD6DC File Offset: 0x000AB8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientEntityInfoPb);
		}

		// Token: 0x0600467D RID: 18045 RVA: 0x000AD6EC File Offset: 0x000AB8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientEntityInfoPb other)
		{
			return other != null && (other == this || (this.EntityConfigId == other.EntityConfigId && this.IncId == other.IncId && this.ServerRealExist == other.ServerRealExist && this.IsClientEntityConfig == other.IsClientEntityConfig && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600467E RID: 18046 RVA: 0x000AD758 File Offset: 0x000AB958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityConfigId != 0)
			{
				num ^= this.EntityConfigId.GetHashCode();
			}
			if (this.HasIncId)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.HasServerRealExist)
			{
				num ^= this.ServerRealExist.GetHashCode();
			}
			if (this.IsClientEntityConfig)
			{
				num ^= this.IsClientEntityConfig.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600467F RID: 18047 RVA: 0x000AD7E2 File Offset: 0x000AB9E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004680 RID: 18048 RVA: 0x000AD7EF File Offset: 0x000AB9EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004681 RID: 18049 RVA: 0x000AD7F8 File Offset: 0x000AB9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this.HasIncId)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.IncId);
			}
			if (this.HasServerRealExist)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.ServerRealExist);
			}
			if (this.IsClientEntityConfig)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsClientEntityConfig);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004682 RID: 18050 RVA: 0x000AD888 File Offset: 0x000ABA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigId);
			}
			if (this.HasIncId)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.IncId);
			}
			if (this.HasServerRealExist)
			{
				num += 2;
			}
			if (this.IsClientEntityConfig)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004683 RID: 18051 RVA: 0x000AD8F8 File Offset: 0x000ABAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientEntityInfoPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityConfigId != 0)
			{
				this.EntityConfigId = other.EntityConfigId;
			}
			if (other.HasIncId)
			{
				this.IncId = other.IncId;
			}
			if (other.HasServerRealExist)
			{
				this.ServerRealExist = other.ServerRealExist;
			}
			if (other.IsClientEntityConfig)
			{
				this.IsClientEntityConfig = other.IsClientEntityConfig;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004684 RID: 18052 RVA: 0x000AD970 File Offset: 0x000ABB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004685 RID: 18053 RVA: 0x000AD97C File Offset: 0x000ABB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.EntityConfigId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.IncId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.ServerRealExist = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.IsClientEntityConfig = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002FAA RID: 12202
		private static readonly MessageParser<ClientEntityInfoPb> _parser = new MessageParser<ClientEntityInfoPb>(() => new ClientEntityInfoPb());

		// Token: 0x04002FAB RID: 12203
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FAC RID: 12204
		private int _hasBits0;

		// Token: 0x04002FAD RID: 12205
		public const int EntityConfigIdFieldNumber = 1;

		// Token: 0x04002FAE RID: 12206
		private int entityConfigId_;

		// Token: 0x04002FAF RID: 12207
		public const int IncIdFieldNumber = 2;

		// Token: 0x04002FB0 RID: 12208
		private static readonly long IncIdDefaultValue = 0L;

		// Token: 0x04002FB1 RID: 12209
		private long incId_;

		// Token: 0x04002FB2 RID: 12210
		public const int ServerRealExistFieldNumber = 3;

		// Token: 0x04002FB3 RID: 12211
		private static readonly bool ServerRealExistDefaultValue = false;

		// Token: 0x04002FB4 RID: 12212
		private bool serverRealExist_;

		// Token: 0x04002FB5 RID: 12213
		public const int IsClientEntityConfigFieldNumber = 4;

		// Token: 0x04002FB6 RID: 12214
		private bool isClientEntityConfig_;
	}
}
