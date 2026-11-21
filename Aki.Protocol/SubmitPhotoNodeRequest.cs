using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001314 RID: 4884
	[NetMessage(EMessageId.SubmitPhotoNodeRequest)]
	public sealed class SubmitPhotoNodeRequest : IMessage<SubmitPhotoNodeRequest>, IMessage, IEquatable<SubmitPhotoNodeRequest>, IDeepCloneable<SubmitPhotoNodeRequest>, IBufferMessage
	{
		// Token: 0x0601A0AA RID: 106666 RVA: 0x003CBB21 File Offset: 0x003C9D21
		[NullableContext(1)]
		public static SubmitPhotoNodeRequest Create()
		{
			return new SubmitPhotoNodeRequest();
		}

		// Token: 0x1700582C RID: 22572
		// (get) Token: 0x0601A0AB RID: 106667 RVA: 0x003CBB28 File Offset: 0x003C9D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700582D RID: 22573
		// (get) Token: 0x0601A0AC RID: 106668 RVA: 0x003CBB2B File Offset: 0x003C9D2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitPhotoNodeRequest.Descriptor;
			}
		}

		// Token: 0x0601A0AD RID: 106669 RVA: 0x003CBB32 File Offset: 0x003C9D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitPhotoNodeRequest()
		{
		}

		// Token: 0x0601A0AE RID: 106670 RVA: 0x003CBB48 File Offset: 0x003C9D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitPhotoNodeRequest(SubmitPhotoNodeRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A0AF RID: 106671 RVA: 0x003CBBA1 File Offset: 0x003C9DA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitPhotoNodeRequest Clone()
		{
			return new SubmitPhotoNodeRequest(this);
		}

		// Token: 0x1700582E RID: 22574
		// (get) Token: 0x0601A0B0 RID: 106672 RVA: 0x003CBBA9 File Offset: 0x003C9DA9
		// (set) Token: 0x0601A0B1 RID: 106673 RVA: 0x003CBBB1 File Offset: 0x003C9DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeOwnerId
		{
			get
			{
				return this.treeOwnerId_;
			}
			set
			{
				this.treeOwnerId_ = value;
			}
		}

		// Token: 0x1700582F RID: 22575
		// (get) Token: 0x0601A0B2 RID: 106674 RVA: 0x003CBBBA File Offset: 0x003C9DBA
		// (set) Token: 0x0601A0B3 RID: 106675 RVA: 0x003CBBC2 File Offset: 0x003C9DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TreeIncId
		{
			get
			{
				return this.treeIncId_;
			}
			set
			{
				this.treeIncId_ = value;
			}
		}

		// Token: 0x17005830 RID: 22576
		// (get) Token: 0x0601A0B4 RID: 106676 RVA: 0x003CBBCB File Offset: 0x003C9DCB
		// (set) Token: 0x0601A0B5 RID: 106677 RVA: 0x003CBBD3 File Offset: 0x003C9DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NodeId
		{
			get
			{
				return this.nodeId_;
			}
			set
			{
				this.nodeId_ = value;
			}
		}

		// Token: 0x17005831 RID: 22577
		// (get) Token: 0x0601A0B6 RID: 106678 RVA: 0x003CBBDC File Offset: 0x003C9DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x0601A0B7 RID: 106679 RVA: 0x003CBBE4 File Offset: 0x003C9DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitPhotoNodeRequest);
		}

		// Token: 0x0601A0B8 RID: 106680 RVA: 0x003CBBF4 File Offset: 0x003C9DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitPhotoNodeRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A0B9 RID: 106681 RVA: 0x003CBC64 File Offset: 0x003C9E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeOwnerId != 0)
			{
				num ^= this.TreeOwnerId.GetHashCode();
			}
			if (this.TreeIncId != 0L)
			{
				num ^= this.TreeIncId.GetHashCode();
			}
			if (this.NodeId != 0)
			{
				num ^= this.NodeId.GetHashCode();
			}
			num ^= this.entityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A0BA RID: 106682 RVA: 0x003CBCE3 File Offset: 0x003C9EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A0BB RID: 106683 RVA: 0x003CBCF0 File Offset: 0x003C9EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A0BC RID: 106684 RVA: 0x003CBCFC File Offset: 0x003C9EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.NodeId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TreeOwnerId);
			}
			this.entityIds_.WriteTo(ref output, SubmitPhotoNodeRequest._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A0BD RID: 106685 RVA: 0x003CBD84 File Offset: 0x003C9F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeOwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TreeIncId);
			}
			if (this.NodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NodeId);
			}
			num += this.entityIds_.CalculateSize(SubmitPhotoNodeRequest._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A0BE RID: 106686 RVA: 0x003CBE08 File Offset: 0x003CA008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SubmitPhotoNodeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeOwnerId != 0)
			{
				this.TreeOwnerId = other.TreeOwnerId;
			}
			if (other.TreeIncId != 0L)
			{
				this.TreeIncId = other.TreeIncId;
			}
			if (other.NodeId != 0)
			{
				this.NodeId = other.NodeId;
			}
			this.entityIds_.Add(other.entityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A0BF RID: 106687 RVA: 0x003CBE7D File Offset: 0x003CA07D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A0C0 RID: 106688 RVA: 0x003CBE88 File Offset: 0x003CA088
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
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
					if (num == 96U || num == 98U)
					{
						this.entityIds_.AddEntriesFrom(ref input, SubmitPhotoNodeRequest._repeated_entityIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009955 RID: 39253
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009956 RID: 39254
		public const int TreeOwnerIdFieldNumber = 7;

		// Token: 0x04009957 RID: 39255
		private int treeOwnerId_;

		// Token: 0x04009958 RID: 39256
		public const int TreeIncIdFieldNumber = 1;

		// Token: 0x04009959 RID: 39257
		private long treeIncId_;

		// Token: 0x0400995A RID: 39258
		public const int NodeIdFieldNumber = 4;

		// Token: 0x0400995B RID: 39259
		private int nodeId_;

		// Token: 0x0400995C RID: 39260
		public const int EntityIdsFieldNumber = 12;

		// Token: 0x0400995D RID: 39261
		private static readonly FieldCodec<int> _repeated_entityIds_codec = FieldCodec.ForInt32(98U);

		// Token: 0x0400995E RID: 39262
		private readonly RepeatedField<int> entityIds_ = new RepeatedField<int>();
	}
}
