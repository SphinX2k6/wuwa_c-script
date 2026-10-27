using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012A5 RID: 4773
	[NetMessage(EMessageId.SubmitPhotoNodeRequest)]
	public sealed class SubmitPhotoNodeRequest : IMessage<SubmitPhotoNodeRequest>, IMessage, IEquatable<SubmitPhotoNodeRequest>, IDeepCloneable<SubmitPhotoNodeRequest>, IBufferMessage
	{
		// Token: 0x06019674 RID: 104052 RVA: 0x003B13ED File Offset: 0x003AF5ED
		[NullableContext(1)]
		public static SubmitPhotoNodeRequest Create()
		{
			return new SubmitPhotoNodeRequest();
		}

		// Token: 0x170055AB RID: 21931
		// (get) Token: 0x06019675 RID: 104053 RVA: 0x003B13F4 File Offset: 0x003AF5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055AC RID: 21932
		// (get) Token: 0x06019676 RID: 104054 RVA: 0x003B13F7 File Offset: 0x003AF5F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitPhotoNodeRequest.Descriptor;
			}
		}

		// Token: 0x06019677 RID: 104055 RVA: 0x003B13FE File Offset: 0x003AF5FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitPhotoNodeRequest()
		{
		}

		// Token: 0x06019678 RID: 104056 RVA: 0x003B1414 File Offset: 0x003AF614
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

		// Token: 0x06019679 RID: 104057 RVA: 0x003B146D File Offset: 0x003AF66D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitPhotoNodeRequest Clone()
		{
			return new SubmitPhotoNodeRequest(this);
		}

		// Token: 0x170055AD RID: 21933
		// (get) Token: 0x0601967A RID: 104058 RVA: 0x003B1475 File Offset: 0x003AF675
		// (set) Token: 0x0601967B RID: 104059 RVA: 0x003B147D File Offset: 0x003AF67D
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

		// Token: 0x170055AE RID: 21934
		// (get) Token: 0x0601967C RID: 104060 RVA: 0x003B1486 File Offset: 0x003AF686
		// (set) Token: 0x0601967D RID: 104061 RVA: 0x003B148E File Offset: 0x003AF68E
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

		// Token: 0x170055AF RID: 21935
		// (get) Token: 0x0601967E RID: 104062 RVA: 0x003B1497 File Offset: 0x003AF697
		// (set) Token: 0x0601967F RID: 104063 RVA: 0x003B149F File Offset: 0x003AF69F
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

		// Token: 0x170055B0 RID: 21936
		// (get) Token: 0x06019680 RID: 104064 RVA: 0x003B14A8 File Offset: 0x003AF6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x06019681 RID: 104065 RVA: 0x003B14B0 File Offset: 0x003AF6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitPhotoNodeRequest);
		}

		// Token: 0x06019682 RID: 104066 RVA: 0x003B14C0 File Offset: 0x003AF6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitPhotoNodeRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019683 RID: 104067 RVA: 0x003B1530 File Offset: 0x003AF730
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

		// Token: 0x06019684 RID: 104068 RVA: 0x003B15AF File Offset: 0x003AF7AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019685 RID: 104069 RVA: 0x003B15BC File Offset: 0x003AF7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019686 RID: 104070 RVA: 0x003B15C8 File Offset: 0x003AF7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NodeId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.NodeId);
			}
			this.entityIds_.WriteTo(ref output, SubmitPhotoNodeRequest._repeated_entityIds_codec);
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019687 RID: 104071 RVA: 0x003B1650 File Offset: 0x003AF850
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

		// Token: 0x06019688 RID: 104072 RVA: 0x003B16D4 File Offset: 0x003AF8D4
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

		// Token: 0x06019689 RID: 104073 RVA: 0x003B1749 File Offset: 0x003AF949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601968A RID: 104074 RVA: 0x003B1754 File Offset: 0x003AF954
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
				if (num <= 40U)
				{
					if (num == 24U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						goto IL_4B;
					}
				}
				else
				{
					if (num == 42U)
					{
						goto IL_4B;
					}
					if (num == 104U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4B:
				this.entityIds_.AddEntriesFrom(ref input, SubmitPhotoNodeRequest._repeated_entityIds_codec);
			}
		}

		// Token: 0x0400952B RID: 38187
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400952C RID: 38188
		public const int TreeOwnerIdFieldNumber = 15;

		// Token: 0x0400952D RID: 38189
		private int treeOwnerId_;

		// Token: 0x0400952E RID: 38190
		public const int TreeIncIdFieldNumber = 13;

		// Token: 0x0400952F RID: 38191
		private long treeIncId_;

		// Token: 0x04009530 RID: 38192
		public const int NodeIdFieldNumber = 3;

		// Token: 0x04009531 RID: 38193
		private int nodeId_;

		// Token: 0x04009532 RID: 38194
		public const int EntityIdsFieldNumber = 5;

		// Token: 0x04009533 RID: 38195
		private static readonly FieldCodec<int> _repeated_entityIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04009534 RID: 38196
		private readonly RepeatedField<int> entityIds_ = new RepeatedField<int>();
	}
}
