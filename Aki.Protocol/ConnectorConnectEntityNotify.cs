using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002DA RID: 730
	[NetMessage(EMessageId.ConnectorConnectEntityNotify)]
	public sealed class ConnectorConnectEntityNotify : IMessage<ConnectorConnectEntityNotify>, IMessage, IEquatable<ConnectorConnectEntityNotify>, IDeepCloneable<ConnectorConnectEntityNotify>, IBufferMessage
	{
		// Token: 0x06004A95 RID: 19093 RVA: 0x000B6154 File Offset: 0x000B4354
		[NullableContext(1)]
		public static ConnectorConnectEntityNotify Create()
		{
			return new ConnectorConnectEntityNotify();
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06004A96 RID: 19094 RVA: 0x000B615B File Offset: 0x000B435B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06004A97 RID: 19095 RVA: 0x000B615E File Offset: 0x000B435E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectorConnectEntityNotify.Descriptor;
			}
		}

		// Token: 0x06004A98 RID: 19096 RVA: 0x000B6165 File Offset: 0x000B4365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorConnectEntityNotify()
		{
		}

		// Token: 0x06004A99 RID: 19097 RVA: 0x000B6178 File Offset: 0x000B4378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorConnectEntityNotify(ConnectorConnectEntityNotify other) : this()
		{
			this.connectEntityInfos_ = other.connectEntityInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004A9A RID: 19098 RVA: 0x000B61A2 File Offset: 0x000B43A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorConnectEntityNotify Clone()
		{
			return new ConnectorConnectEntityNotify(this);
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06004A9B RID: 19099 RVA: 0x000B61AA File Offset: 0x000B43AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConnectEntityInfo> ConnectEntityInfos
		{
			get
			{
				return this.connectEntityInfos_;
			}
		}

		// Token: 0x06004A9C RID: 19100 RVA: 0x000B61B2 File Offset: 0x000B43B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectorConnectEntityNotify);
		}

		// Token: 0x06004A9D RID: 19101 RVA: 0x000B61C0 File Offset: 0x000B43C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConnectorConnectEntityNotify other)
		{
			return other != null && (other == this || (this.connectEntityInfos_.Equals(other.connectEntityInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004A9E RID: 19102 RVA: 0x000B61F4 File Offset: 0x000B43F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.connectEntityInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004A9F RID: 19103 RVA: 0x000B6228 File Offset: 0x000B4428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004AA0 RID: 19104 RVA: 0x000B6235 File Offset: 0x000B4435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004AA1 RID: 19105 RVA: 0x000B623E File Offset: 0x000B443E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.connectEntityInfos_.WriteTo(ref output, ConnectorConnectEntityNotify._repeated_connectEntityInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004AA2 RID: 19106 RVA: 0x000B6268 File Offset: 0x000B4468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.connectEntityInfos_.CalculateSize(ConnectorConnectEntityNotify._repeated_connectEntityInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004AA3 RID: 19107 RVA: 0x000B62A1 File Offset: 0x000B44A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConnectorConnectEntityNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.connectEntityInfos_.Add(other.connectEntityInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004AA4 RID: 19108 RVA: 0x000B62CF File Offset: 0x000B44CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004AA5 RID: 19109 RVA: 0x000B62D8 File Offset: 0x000B44D8
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
					this.connectEntityInfos_.AddEntriesFrom(ref input, ConnectorConnectEntityNotify._repeated_connectEntityInfos_codec);
				}
			}
		}

		// Token: 0x04003083 RID: 12419
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003084 RID: 12420
		public const int ConnectEntityInfosFieldNumber = 11;

		// Token: 0x04003085 RID: 12421
		private static readonly FieldCodec<ConnectEntityInfo> _repeated_connectEntityInfos_codec = FieldCodec.ForMessage<ConnectEntityInfo>(90U, ConnectEntityInfo.Parser);

		// Token: 0x04003086 RID: 12422
		private readonly RepeatedField<ConnectEntityInfo> connectEntityInfos_ = new RepeatedField<ConnectEntityInfo>();
	}
}
