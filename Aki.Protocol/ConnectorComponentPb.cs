using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002E0 RID: 736
	public sealed class ConnectorComponentPb : IMessage<ConnectorComponentPb>, IMessage, IEquatable<ConnectorComponentPb>, IDeepCloneable<ConnectorComponentPb>, IBufferMessage
	{
		// Token: 0x06004B5C RID: 19292 RVA: 0x000B8371 File Offset: 0x000B6571
		[NullableContext(1)]
		public static ConnectorComponentPb Create()
		{
			return new ConnectorComponentPb();
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x06004B5D RID: 19293 RVA: 0x000B8378 File Offset: 0x000B6578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x06004B5E RID: 19294 RVA: 0x000B837B File Offset: 0x000B657B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectorComponentPb.Descriptor;
			}
		}

		// Token: 0x06004B5F RID: 19295 RVA: 0x000B8382 File Offset: 0x000B6582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorComponentPb()
		{
		}

		// Token: 0x06004B60 RID: 19296 RVA: 0x000B838A File Offset: 0x000B658A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorComponentPb(ConnectorComponentPb other) : this()
		{
			this.hasInitiatedConnect_ = other.hasInitiatedConnect_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B61 RID: 19297 RVA: 0x000B83AF File Offset: 0x000B65AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorComponentPb Clone()
		{
			return new ConnectorComponentPb(this);
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x06004B62 RID: 19298 RVA: 0x000B83B7 File Offset: 0x000B65B7
		// (set) Token: 0x06004B63 RID: 19299 RVA: 0x000B83BF File Offset: 0x000B65BF
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

		// Token: 0x06004B64 RID: 19300 RVA: 0x000B83C8 File Offset: 0x000B65C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectorComponentPb);
		}

		// Token: 0x06004B65 RID: 19301 RVA: 0x000B83D6 File Offset: 0x000B65D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConnectorComponentPb other)
		{
			return other != null && (other == this || (this.HasInitiatedConnect == other.HasInitiatedConnect && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004B66 RID: 19302 RVA: 0x000B8404 File Offset: 0x000B6604
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

		// Token: 0x06004B67 RID: 19303 RVA: 0x000B8443 File Offset: 0x000B6643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004B68 RID: 19304 RVA: 0x000B8450 File Offset: 0x000B6650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B69 RID: 19305 RVA: 0x000B8459 File Offset: 0x000B6659
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

		// Token: 0x06004B6A RID: 19306 RVA: 0x000B848C File Offset: 0x000B668C
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

		// Token: 0x06004B6B RID: 19307 RVA: 0x000B84BE File Offset: 0x000B66BE
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

		// Token: 0x06004B6C RID: 19308 RVA: 0x000B84EF File Offset: 0x000B66EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B6D RID: 19309 RVA: 0x000B84F8 File Offset: 0x000B66F8
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

		// Token: 0x04003117 RID: 12567
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003118 RID: 12568
		public const int HasInitiatedConnectFieldNumber = 1;

		// Token: 0x04003119 RID: 12569
		private bool hasInitiatedConnect_;
	}
}
