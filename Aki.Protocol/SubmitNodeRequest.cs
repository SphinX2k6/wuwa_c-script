using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012A3 RID: 4771
	[NetMessage(EMessageId.SubmitNodeRequest)]
	public sealed class SubmitNodeRequest : IMessage<SubmitNodeRequest>, IMessage, IEquatable<SubmitNodeRequest>, IDeepCloneable<SubmitNodeRequest>, IBufferMessage
	{
		// Token: 0x06019646 RID: 104006 RVA: 0x003B0CA5 File Offset: 0x003AEEA5
		[NullableContext(1)]
		public static SubmitNodeRequest Create()
		{
			return new SubmitNodeRequest();
		}

		// Token: 0x170055A0 RID: 21920
		// (get) Token: 0x06019647 RID: 104007 RVA: 0x003B0CAC File Offset: 0x003AEEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055A1 RID: 21921
		// (get) Token: 0x06019648 RID: 104008 RVA: 0x003B0CAF File Offset: 0x003AEEAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitNodeRequest.Descriptor;
			}
		}

		// Token: 0x06019649 RID: 104009 RVA: 0x003B0CB6 File Offset: 0x003AEEB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitNodeRequest()
		{
		}

		// Token: 0x0601964A RID: 104010 RVA: 0x003B0CBE File Offset: 0x003AEEBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitNodeRequest(SubmitNodeRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601964B RID: 104011 RVA: 0x003B0CFB File Offset: 0x003AEEFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitNodeRequest Clone()
		{
			return new SubmitNodeRequest(this);
		}

		// Token: 0x170055A2 RID: 21922
		// (get) Token: 0x0601964C RID: 104012 RVA: 0x003B0D03 File Offset: 0x003AEF03
		// (set) Token: 0x0601964D RID: 104013 RVA: 0x003B0D0B File Offset: 0x003AEF0B
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

		// Token: 0x170055A3 RID: 21923
		// (get) Token: 0x0601964E RID: 104014 RVA: 0x003B0D14 File Offset: 0x003AEF14
		// (set) Token: 0x0601964F RID: 104015 RVA: 0x003B0D1C File Offset: 0x003AEF1C
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

		// Token: 0x170055A4 RID: 21924
		// (get) Token: 0x06019650 RID: 104016 RVA: 0x003B0D25 File Offset: 0x003AEF25
		// (set) Token: 0x06019651 RID: 104017 RVA: 0x003B0D2D File Offset: 0x003AEF2D
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

		// Token: 0x06019652 RID: 104018 RVA: 0x003B0D36 File Offset: 0x003AEF36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitNodeRequest);
		}

		// Token: 0x06019653 RID: 104019 RVA: 0x003B0D44 File Offset: 0x003AEF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitNodeRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019654 RID: 104020 RVA: 0x003B0DA0 File Offset: 0x003AEFA0
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019655 RID: 104021 RVA: 0x003B0E11 File Offset: 0x003AF011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019656 RID: 104022 RVA: 0x003B0E1E File Offset: 0x003AF01E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019657 RID: 104023 RVA: 0x003B0E28 File Offset: 0x003AF028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NodeId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.NodeId);
			}
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

		// Token: 0x06019658 RID: 104024 RVA: 0x003B0EA0 File Offset: 0x003AF0A0
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019659 RID: 104025 RVA: 0x003B0F10 File Offset: 0x003AF110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SubmitNodeRequest other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601965A RID: 104026 RVA: 0x003B0F74 File Offset: 0x003AF174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601965B RID: 104027 RVA: 0x003B0F80 File Offset: 0x003AF180
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
				if (num != 48U)
				{
					if (num != 104U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TreeOwnerId = input.ReadInt32();
						}
					}
					else
					{
						this.TreeIncId = input.ReadInt64();
					}
				}
				else
				{
					this.NodeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400951B RID: 38171
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400951C RID: 38172
		public const int TreeOwnerIdFieldNumber = 15;

		// Token: 0x0400951D RID: 38173
		private int treeOwnerId_;

		// Token: 0x0400951E RID: 38174
		public const int TreeIncIdFieldNumber = 13;

		// Token: 0x0400951F RID: 38175
		private long treeIncId_;

		// Token: 0x04009520 RID: 38176
		public const int NodeIdFieldNumber = 6;

		// Token: 0x04009521 RID: 38177
		private int nodeId_;
	}
}
