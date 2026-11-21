using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002DD RID: 733
	public sealed class ConnectEntityTarget : IMessage<ConnectEntityTarget>, IMessage, IEquatable<ConnectEntityTarget>, IDeepCloneable<ConnectEntityTarget>, IBufferMessage
	{
		// Token: 0x06004B21 RID: 19233 RVA: 0x000B7C38 File Offset: 0x000B5E38
		[NullableContext(1)]
		public static ConnectEntityTarget Create()
		{
			return new ConnectEntityTarget();
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06004B22 RID: 19234 RVA: 0x000B7C3F File Offset: 0x000B5E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ConnectEntityTarget> Parser
		{
			get
			{
				return ConnectEntityTarget._parser;
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06004B23 RID: 19235 RVA: 0x000B7C46 File Offset: 0x000B5E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x06004B24 RID: 19236 RVA: 0x000B7C49 File Offset: 0x000B5E49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectEntityTarget.Descriptor;
			}
		}

		// Token: 0x06004B25 RID: 19237 RVA: 0x000B7C50 File Offset: 0x000B5E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectEntityTarget()
		{
		}

		// Token: 0x06004B26 RID: 19238 RVA: 0x000B7C63 File Offset: 0x000B5E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectEntityTarget(ConnectEntityTarget other) : this()
		{
			this.targetId_ = other.targetId_;
			this.connectPortalIds_ = other.connectPortalIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B27 RID: 19239 RVA: 0x000B7C99 File Offset: 0x000B5E99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectEntityTarget Clone()
		{
			return new ConnectEntityTarget(this);
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x06004B28 RID: 19240 RVA: 0x000B7CA1 File Offset: 0x000B5EA1
		// (set) Token: 0x06004B29 RID: 19241 RVA: 0x000B7CA9 File Offset: 0x000B5EA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetId
		{
			get
			{
				return this.targetId_;
			}
			set
			{
				this.targetId_ = value;
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x06004B2A RID: 19242 RVA: 0x000B7CB2 File Offset: 0x000B5EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> ConnectPortalIds
		{
			get
			{
				return this.connectPortalIds_;
			}
		}

		// Token: 0x06004B2B RID: 19243 RVA: 0x000B7CBA File Offset: 0x000B5EBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectEntityTarget);
		}

		// Token: 0x06004B2C RID: 19244 RVA: 0x000B7CC8 File Offset: 0x000B5EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConnectEntityTarget other)
		{
			return other != null && (other == this || (this.TargetId == other.TargetId && this.connectPortalIds_.Equals(other.connectPortalIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004B2D RID: 19245 RVA: 0x000B7D18 File Offset: 0x000B5F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetId != 0L)
			{
				num ^= this.TargetId.GetHashCode();
			}
			num ^= this.connectPortalIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004B2E RID: 19246 RVA: 0x000B7D65 File Offset: 0x000B5F65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004B2F RID: 19247 RVA: 0x000B7D72 File Offset: 0x000B5F72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B30 RID: 19248 RVA: 0x000B7D7C File Offset: 0x000B5F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.TargetId);
			}
			this.connectPortalIds_.WriteTo(ref output, ConnectEntityTarget._repeated_connectPortalIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B31 RID: 19249 RVA: 0x000B7DCC File Offset: 0x000B5FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetId);
			}
			num += this.connectPortalIds_.CalculateSize(ConnectEntityTarget._repeated_connectPortalIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004B32 RID: 19250 RVA: 0x000B7E20 File Offset: 0x000B6020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConnectEntityTarget other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetId != 0L)
			{
				this.TargetId = other.TargetId;
			}
			this.connectPortalIds_.Add(other.connectPortalIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004B33 RID: 19251 RVA: 0x000B7E6D File Offset: 0x000B606D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B34 RID: 19252 RVA: 0x000B7E78 File Offset: 0x000B6078
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
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.connectPortalIds_.AddEntriesFrom(ref input, ConnectEntityTarget._repeated_connectPortalIds_codec);
					}
				}
				else
				{
					this.TargetId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003108 RID: 12552
		private static readonly MessageParser<ConnectEntityTarget> _parser = new MessageParser<ConnectEntityTarget>(() => new ConnectEntityTarget());

		// Token: 0x04003109 RID: 12553
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400310A RID: 12554
		public const int TargetIdFieldNumber = 1;

		// Token: 0x0400310B RID: 12555
		private long targetId_;

		// Token: 0x0400310C RID: 12556
		public const int ConnectPortalIdsFieldNumber = 2;

		// Token: 0x0400310D RID: 12557
		private static readonly FieldCodec<long> _repeated_connectPortalIds_codec = FieldCodec.ForInt64(18U);

		// Token: 0x0400310E RID: 12558
		private readonly RepeatedField<long> connectPortalIds_ = new RepeatedField<long>();
	}
}
