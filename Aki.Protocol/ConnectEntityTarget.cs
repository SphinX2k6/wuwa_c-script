using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002D6 RID: 726
	public sealed class ConnectEntityTarget : IMessage<ConnectEntityTarget>, IMessage, IEquatable<ConnectEntityTarget>, IDeepCloneable<ConnectEntityTarget>, IBufferMessage
	{
		// Token: 0x06004A48 RID: 19016 RVA: 0x000B5850 File Offset: 0x000B3A50
		[NullableContext(1)]
		public static ConnectEntityTarget Create()
		{
			return new ConnectEntityTarget();
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x06004A49 RID: 19017 RVA: 0x000B5857 File Offset: 0x000B3A57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ConnectEntityTarget> Parser
		{
			get
			{
				return ConnectEntityTarget._parser;
			}
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x06004A4A RID: 19018 RVA: 0x000B585E File Offset: 0x000B3A5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x06004A4B RID: 19019 RVA: 0x000B5861 File Offset: 0x000B3A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectEntityTarget.Descriptor;
			}
		}

		// Token: 0x06004A4C RID: 19020 RVA: 0x000B5868 File Offset: 0x000B3A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectEntityTarget()
		{
		}

		// Token: 0x06004A4D RID: 19021 RVA: 0x000B587B File Offset: 0x000B3A7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectEntityTarget(ConnectEntityTarget other) : this()
		{
			this.targetId_ = other.targetId_;
			this.connectPortalIds_ = other.connectPortalIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004A4E RID: 19022 RVA: 0x000B58B1 File Offset: 0x000B3AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectEntityTarget Clone()
		{
			return new ConnectEntityTarget(this);
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x06004A4F RID: 19023 RVA: 0x000B58B9 File Offset: 0x000B3AB9
		// (set) Token: 0x06004A50 RID: 19024 RVA: 0x000B58C1 File Offset: 0x000B3AC1
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

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x06004A51 RID: 19025 RVA: 0x000B58CA File Offset: 0x000B3ACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> ConnectPortalIds
		{
			get
			{
				return this.connectPortalIds_;
			}
		}

		// Token: 0x06004A52 RID: 19026 RVA: 0x000B58D2 File Offset: 0x000B3AD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectEntityTarget);
		}

		// Token: 0x06004A53 RID: 19027 RVA: 0x000B58E0 File Offset: 0x000B3AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConnectEntityTarget other)
		{
			return other != null && (other == this || (this.TargetId == other.TargetId && this.connectPortalIds_.Equals(other.connectPortalIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004A54 RID: 19028 RVA: 0x000B5930 File Offset: 0x000B3B30
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

		// Token: 0x06004A55 RID: 19029 RVA: 0x000B597D File Offset: 0x000B3B7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004A56 RID: 19030 RVA: 0x000B598A File Offset: 0x000B3B8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A57 RID: 19031 RVA: 0x000B5994 File Offset: 0x000B3B94
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

		// Token: 0x06004A58 RID: 19032 RVA: 0x000B59E4 File Offset: 0x000B3BE4
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

		// Token: 0x06004A59 RID: 19033 RVA: 0x000B5A38 File Offset: 0x000B3C38
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

		// Token: 0x06004A5A RID: 19034 RVA: 0x000B5A85 File Offset: 0x000B3C85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A5B RID: 19035 RVA: 0x000B5A90 File Offset: 0x000B3C90
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

		// Token: 0x04003071 RID: 12401
		private static readonly MessageParser<ConnectEntityTarget> _parser = new MessageParser<ConnectEntityTarget>(() => new ConnectEntityTarget());

		// Token: 0x04003072 RID: 12402
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003073 RID: 12403
		public const int TargetIdFieldNumber = 1;

		// Token: 0x04003074 RID: 12404
		private long targetId_;

		// Token: 0x04003075 RID: 12405
		public const int ConnectPortalIdsFieldNumber = 2;

		// Token: 0x04003076 RID: 12406
		private static readonly FieldCodec<long> _repeated_connectPortalIds_codec = FieldCodec.ForInt64(18U);

		// Token: 0x04003077 RID: 12407
		private readonly RepeatedField<long> connectPortalIds_ = new RepeatedField<long>();
	}
}
