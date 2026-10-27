using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012A7 RID: 4775
	[NetMessage(EMessageId.SubmitWalkingPatternPointRequest)]
	public sealed class SubmitWalkingPatternPointRequest : IMessage<SubmitWalkingPatternPointRequest>, IMessage, IEquatable<SubmitWalkingPatternPointRequest>, IDeepCloneable<SubmitWalkingPatternPointRequest>, IBufferMessage
	{
		// Token: 0x0601969E RID: 104094 RVA: 0x003B19D1 File Offset: 0x003AFBD1
		[NullableContext(1)]
		public static SubmitWalkingPatternPointRequest Create()
		{
			return new SubmitWalkingPatternPointRequest();
		}

		// Token: 0x170055B4 RID: 21940
		// (get) Token: 0x0601969F RID: 104095 RVA: 0x003B19D8 File Offset: 0x003AFBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055B5 RID: 21941
		// (get) Token: 0x060196A0 RID: 104096 RVA: 0x003B19DB File Offset: 0x003AFBDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitWalkingPatternPointRequest.Descriptor;
			}
		}

		// Token: 0x060196A1 RID: 104097 RVA: 0x003B19E2 File Offset: 0x003AFBE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitWalkingPatternPointRequest()
		{
		}

		// Token: 0x060196A2 RID: 104098 RVA: 0x003B19EC File Offset: 0x003AFBEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitWalkingPatternPointRequest(SubmitWalkingPatternPointRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this.point_ = other.point_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060196A3 RID: 104099 RVA: 0x003B1A40 File Offset: 0x003AFC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitWalkingPatternPointRequest Clone()
		{
			return new SubmitWalkingPatternPointRequest(this);
		}

		// Token: 0x170055B6 RID: 21942
		// (get) Token: 0x060196A4 RID: 104100 RVA: 0x003B1A48 File Offset: 0x003AFC48
		// (set) Token: 0x060196A5 RID: 104101 RVA: 0x003B1A50 File Offset: 0x003AFC50
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

		// Token: 0x170055B7 RID: 21943
		// (get) Token: 0x060196A6 RID: 104102 RVA: 0x003B1A59 File Offset: 0x003AFC59
		// (set) Token: 0x060196A7 RID: 104103 RVA: 0x003B1A61 File Offset: 0x003AFC61
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

		// Token: 0x170055B8 RID: 21944
		// (get) Token: 0x060196A8 RID: 104104 RVA: 0x003B1A6A File Offset: 0x003AFC6A
		// (set) Token: 0x060196A9 RID: 104105 RVA: 0x003B1A72 File Offset: 0x003AFC72
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

		// Token: 0x170055B9 RID: 21945
		// (get) Token: 0x060196AA RID: 104106 RVA: 0x003B1A7B File Offset: 0x003AFC7B
		// (set) Token: 0x060196AB RID: 104107 RVA: 0x003B1A83 File Offset: 0x003AFC83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Point
		{
			get
			{
				return this.point_;
			}
			set
			{
				this.point_ = value;
			}
		}

		// Token: 0x060196AC RID: 104108 RVA: 0x003B1A8C File Offset: 0x003AFC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitWalkingPatternPointRequest);
		}

		// Token: 0x060196AD RID: 104109 RVA: 0x003B1A9C File Offset: 0x003AFC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitWalkingPatternPointRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.Point == other.Point && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060196AE RID: 104110 RVA: 0x003B1B08 File Offset: 0x003AFD08
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
			if (this.Point != 0)
			{
				num ^= this.Point.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060196AF RID: 104111 RVA: 0x003B1B92 File Offset: 0x003AFD92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060196B0 RID: 104112 RVA: 0x003B1B9F File Offset: 0x003AFD9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060196B1 RID: 104113 RVA: 0x003B1BA8 File Offset: 0x003AFDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.NodeId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.Point != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Point);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060196B2 RID: 104114 RVA: 0x003B1C3C File Offset: 0x003AFE3C
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
			if (this.Point != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Point);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060196B3 RID: 104115 RVA: 0x003B1CC4 File Offset: 0x003AFEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SubmitWalkingPatternPointRequest other)
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
			if (other.Point != 0)
			{
				this.Point = other.Point;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060196B4 RID: 104116 RVA: 0x003B1D3C File Offset: 0x003AFF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060196B5 RID: 104117 RVA: 0x003B1D48 File Offset: 0x003AFF48
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
				if (num <= 48U)
				{
					if (num == 16U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
					if (num == 48U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Point = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009538 RID: 38200
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009539 RID: 38201
		public const int TreeOwnerIdFieldNumber = 12;

		// Token: 0x0400953A RID: 38202
		private int treeOwnerId_;

		// Token: 0x0400953B RID: 38203
		public const int TreeIncIdFieldNumber = 2;

		// Token: 0x0400953C RID: 38204
		private long treeIncId_;

		// Token: 0x0400953D RID: 38205
		public const int NodeIdFieldNumber = 6;

		// Token: 0x0400953E RID: 38206
		private int nodeId_;

		// Token: 0x0400953F RID: 38207
		public const int PointFieldNumber = 15;

		// Token: 0x04009540 RID: 38208
		private int point_;
	}
}
