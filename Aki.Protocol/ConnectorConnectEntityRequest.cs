using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002E2 RID: 738
	[NetMessage(EMessageId.ConnectorConnectEntityRequest)]
	public sealed class ConnectorConnectEntityRequest : IMessage<ConnectorConnectEntityRequest>, IMessage, IEquatable<ConnectorConnectEntityRequest>, IDeepCloneable<ConnectorConnectEntityRequest>, IBufferMessage
	{
		// Token: 0x06004B80 RID: 19328 RVA: 0x000B871D File Offset: 0x000B691D
		[NullableContext(1)]
		public static ConnectorConnectEntityRequest Create()
		{
			return new ConnectorConnectEntityRequest();
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x06004B81 RID: 19329 RVA: 0x000B8724 File Offset: 0x000B6924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x06004B82 RID: 19330 RVA: 0x000B8727 File Offset: 0x000B6927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectorConnectEntityRequest.Descriptor;
			}
		}

		// Token: 0x06004B83 RID: 19331 RVA: 0x000B872E File Offset: 0x000B692E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorConnectEntityRequest()
		{
		}

		// Token: 0x06004B84 RID: 19332 RVA: 0x000B8736 File Offset: 0x000B6936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorConnectEntityRequest(ConnectorConnectEntityRequest other) : this()
		{
			this.connectEntityInfo_ = ((other.connectEntityInfo_ != null) ? other.connectEntityInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B85 RID: 19333 RVA: 0x000B876B File Offset: 0x000B696B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorConnectEntityRequest Clone()
		{
			return new ConnectorConnectEntityRequest(this);
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x06004B86 RID: 19334 RVA: 0x000B8773 File Offset: 0x000B6973
		// (set) Token: 0x06004B87 RID: 19335 RVA: 0x000B877B File Offset: 0x000B697B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectEntityInfo ConnectEntityInfo
		{
			get
			{
				return this.connectEntityInfo_;
			}
			set
			{
				this.connectEntityInfo_ = value;
			}
		}

		// Token: 0x06004B88 RID: 19336 RVA: 0x000B8784 File Offset: 0x000B6984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectorConnectEntityRequest);
		}

		// Token: 0x06004B89 RID: 19337 RVA: 0x000B8792 File Offset: 0x000B6992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConnectorConnectEntityRequest other)
		{
			return other != null && (other == this || (object.Equals(this.ConnectEntityInfo, other.ConnectEntityInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004B8A RID: 19338 RVA: 0x000B87C8 File Offset: 0x000B69C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.connectEntityInfo_ != null)
			{
				num ^= this.ConnectEntityInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004B8B RID: 19339 RVA: 0x000B8804 File Offset: 0x000B6A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004B8C RID: 19340 RVA: 0x000B8811 File Offset: 0x000B6A11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B8D RID: 19341 RVA: 0x000B881A File Offset: 0x000B6A1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.connectEntityInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ConnectEntityInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B8E RID: 19342 RVA: 0x000B884C File Offset: 0x000B6A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.connectEntityInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ConnectEntityInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004B8F RID: 19343 RVA: 0x000B888C File Offset: 0x000B6A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConnectorConnectEntityRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.connectEntityInfo_ != null)
			{
				if (this.connectEntityInfo_ == null)
				{
					this.ConnectEntityInfo = new ConnectEntityInfo();
				}
				this.ConnectEntityInfo.MergeFrom(other.ConnectEntityInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004B90 RID: 19344 RVA: 0x000B88E0 File Offset: 0x000B6AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B91 RID: 19345 RVA: 0x000B88EC File Offset: 0x000B6AEC
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.connectEntityInfo_ == null)
					{
						this.ConnectEntityInfo = new ConnectEntityInfo();
					}
					input.ReadMessage(this.ConnectEntityInfo);
				}
			}
		}

		// Token: 0x0400311E RID: 12574
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400311F RID: 12575
		public const int ConnectEntityInfoFieldNumber = 11;

		// Token: 0x04003120 RID: 12576
		private ConnectEntityInfo connectEntityInfo_;
	}
}
