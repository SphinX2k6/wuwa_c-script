using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002E1 RID: 737
	[NetMessage(EMessageId.ConnectorConnectEntityNotify)]
	public sealed class ConnectorConnectEntityNotify : IMessage<ConnectorConnectEntityNotify>, IMessage, IEquatable<ConnectorConnectEntityNotify>, IDeepCloneable<ConnectorConnectEntityNotify>, IBufferMessage
	{
		// Token: 0x06004B6E RID: 19310 RVA: 0x000B853C File Offset: 0x000B673C
		[NullableContext(1)]
		public static ConnectorConnectEntityNotify Create()
		{
			return new ConnectorConnectEntityNotify();
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x06004B6F RID: 19311 RVA: 0x000B8543 File Offset: 0x000B6743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x06004B70 RID: 19312 RVA: 0x000B8546 File Offset: 0x000B6746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectorConnectEntityNotify.Descriptor;
			}
		}

		// Token: 0x06004B71 RID: 19313 RVA: 0x000B854D File Offset: 0x000B674D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorConnectEntityNotify()
		{
		}

		// Token: 0x06004B72 RID: 19314 RVA: 0x000B8560 File Offset: 0x000B6760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorConnectEntityNotify(ConnectorConnectEntityNotify other) : this()
		{
			this.connectEntityInfos_ = other.connectEntityInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B73 RID: 19315 RVA: 0x000B858A File Offset: 0x000B678A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorConnectEntityNotify Clone()
		{
			return new ConnectorConnectEntityNotify(this);
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x06004B74 RID: 19316 RVA: 0x000B8592 File Offset: 0x000B6792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConnectEntityInfo> ConnectEntityInfos
		{
			get
			{
				return this.connectEntityInfos_;
			}
		}

		// Token: 0x06004B75 RID: 19317 RVA: 0x000B859A File Offset: 0x000B679A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectorConnectEntityNotify);
		}

		// Token: 0x06004B76 RID: 19318 RVA: 0x000B85A8 File Offset: 0x000B67A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConnectorConnectEntityNotify other)
		{
			return other != null && (other == this || (this.connectEntityInfos_.Equals(other.connectEntityInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004B77 RID: 19319 RVA: 0x000B85DC File Offset: 0x000B67DC
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

		// Token: 0x06004B78 RID: 19320 RVA: 0x000B8610 File Offset: 0x000B6810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004B79 RID: 19321 RVA: 0x000B861D File Offset: 0x000B681D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B7A RID: 19322 RVA: 0x000B8626 File Offset: 0x000B6826
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

		// Token: 0x06004B7B RID: 19323 RVA: 0x000B8650 File Offset: 0x000B6850
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

		// Token: 0x06004B7C RID: 19324 RVA: 0x000B8689 File Offset: 0x000B6889
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

		// Token: 0x06004B7D RID: 19325 RVA: 0x000B86B7 File Offset: 0x000B68B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B7E RID: 19326 RVA: 0x000B86C0 File Offset: 0x000B68C0
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

		// Token: 0x0400311A RID: 12570
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400311B RID: 12571
		public const int ConnectEntityInfosFieldNumber = 11;

		// Token: 0x0400311C RID: 12572
		private static readonly FieldCodec<ConnectEntityInfo> _repeated_connectEntityInfos_codec = FieldCodec.ForMessage<ConnectEntityInfo>(90U, ConnectEntityInfo.Parser);

		// Token: 0x0400311D RID: 12573
		private readonly RepeatedField<ConnectEntityInfo> connectEntityInfos_ = new RepeatedField<ConnectEntityInfo>();
	}
}
