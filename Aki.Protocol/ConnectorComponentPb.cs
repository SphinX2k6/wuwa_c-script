using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002D9 RID: 729
	public sealed class ConnectorComponentPb : IMessage<ConnectorComponentPb>, IMessage, IEquatable<ConnectorComponentPb>, IDeepCloneable<ConnectorComponentPb>, IBufferMessage
	{
		// Token: 0x06004A83 RID: 19075 RVA: 0x000B5F89 File Offset: 0x000B4189
		[NullableContext(1)]
		public static ConnectorComponentPb Create()
		{
			return new ConnectorComponentPb();
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06004A84 RID: 19076 RVA: 0x000B5F90 File Offset: 0x000B4190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06004A85 RID: 19077 RVA: 0x000B5F93 File Offset: 0x000B4193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectorComponentPb.Descriptor;
			}
		}

		// Token: 0x06004A86 RID: 19078 RVA: 0x000B5F9A File Offset: 0x000B419A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorComponentPb()
		{
		}

		// Token: 0x06004A87 RID: 19079 RVA: 0x000B5FA2 File Offset: 0x000B41A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorComponentPb(ConnectorComponentPb other) : this()
		{
			this.hasInitiatedConnect_ = other.hasInitiatedConnect_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004A88 RID: 19080 RVA: 0x000B5FC7 File Offset: 0x000B41C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorComponentPb Clone()
		{
			return new ConnectorComponentPb(this);
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x06004A89 RID: 19081 RVA: 0x000B5FCF File Offset: 0x000B41CF
		// (set) Token: 0x06004A8A RID: 19082 RVA: 0x000B5FD7 File Offset: 0x000B41D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasInitiatedConnect
		{
			get
			{
				return this.hasInitiatedConnect_;
			}
			set
			{
				this.hasInitiatedConnect_ = value;
			}
		}

		// Token: 0x06004A8B RID: 19083 RVA: 0x000B5FE0 File Offset: 0x000B41E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectorComponentPb);
		}

		// Token: 0x06004A8C RID: 19084 RVA: 0x000B5FEE File Offset: 0x000B41EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConnectorComponentPb other)
		{
			return other != null && (other == this || (this.HasInitiatedConnect == other.HasInitiatedConnect && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004A8D RID: 19085 RVA: 0x000B601C File Offset: 0x000B421C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HasInitiatedConnect)
			{
				num ^= this.HasInitiatedConnect.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004A8E RID: 19086 RVA: 0x000B605B File Offset: 0x000B425B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004A8F RID: 19087 RVA: 0x000B6068 File Offset: 0x000B4268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A90 RID: 19088 RVA: 0x000B6071 File Offset: 0x000B4271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasInitiatedConnect)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.HasInitiatedConnect);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004A91 RID: 19089 RVA: 0x000B60A4 File Offset: 0x000B42A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HasInitiatedConnect)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004A92 RID: 19090 RVA: 0x000B60D6 File Offset: 0x000B42D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConnectorComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HasInitiatedConnect)
			{
				this.HasInitiatedConnect = other.HasInitiatedConnect;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004A93 RID: 19091 RVA: 0x000B6107 File Offset: 0x000B4307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A94 RID: 19092 RVA: 0x000B6110 File Offset: 0x000B4310
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.HasInitiatedConnect = input.ReadBool();
				}
			}
		}

		// Token: 0x04003080 RID: 12416
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003081 RID: 12417
		public const int HasInitiatedConnectFieldNumber = 1;

		// Token: 0x04003082 RID: 12418
		private bool hasInitiatedConnect_;
	}
}
