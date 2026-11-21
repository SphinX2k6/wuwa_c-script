using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001ED RID: 493
	[NetMessage(EMessageId.BtGiveUpRequest)]
	public sealed class BtGiveUpRequest : IMessage<BtGiveUpRequest>, IMessage, IEquatable<BtGiveUpRequest>, IDeepCloneable<BtGiveUpRequest>, IBufferMessage
	{
		// Token: 0x06003756 RID: 14166 RVA: 0x0008AAE9 File Offset: 0x00088CE9
		[NullableContext(1)]
		public static BtGiveUpRequest Create()
		{
			return new BtGiveUpRequest();
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06003757 RID: 14167 RVA: 0x0008AAF0 File Offset: 0x00088CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06003758 RID: 14168 RVA: 0x0008AAF3 File Offset: 0x00088CF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtGiveUpRequest.Descriptor;
			}
		}

		// Token: 0x06003759 RID: 14169 RVA: 0x0008AAFA File Offset: 0x00088CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtGiveUpRequest()
		{
		}

		// Token: 0x0600375A RID: 14170 RVA: 0x0008AB02 File Offset: 0x00088D02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtGiveUpRequest(BtGiveUpRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600375B RID: 14171 RVA: 0x0008AB3F File Offset: 0x00088D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtGiveUpRequest Clone()
		{
			return new BtGiveUpRequest(this);
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x0600375C RID: 14172 RVA: 0x0008AB47 File Offset: 0x00088D47
		// (set) Token: 0x0600375D RID: 14173 RVA: 0x0008AB4F File Offset: 0x00088D4F
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

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x0600375E RID: 14174 RVA: 0x0008AB58 File Offset: 0x00088D58
		// (set) Token: 0x0600375F RID: 14175 RVA: 0x0008AB60 File Offset: 0x00088D60
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

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06003760 RID: 14176 RVA: 0x0008AB69 File Offset: 0x00088D69
		// (set) Token: 0x06003761 RID: 14177 RVA: 0x0008AB71 File Offset: 0x00088D71
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

		// Token: 0x06003762 RID: 14178 RVA: 0x0008AB7A File Offset: 0x00088D7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtGiveUpRequest);
		}

		// Token: 0x06003763 RID: 14179 RVA: 0x0008AB88 File Offset: 0x00088D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtGiveUpRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003764 RID: 14180 RVA: 0x0008ABE4 File Offset: 0x00088DE4
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

		// Token: 0x06003765 RID: 14181 RVA: 0x0008AC55 File Offset: 0x00088E55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003766 RID: 14182 RVA: 0x0008AC62 File Offset: 0x00088E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003767 RID: 14183 RVA: 0x0008AC6C File Offset: 0x00088E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NodeId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.NodeId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003768 RID: 14184 RVA: 0x0008ACE4 File Offset: 0x00088EE4
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

		// Token: 0x06003769 RID: 14185 RVA: 0x0008AD54 File Offset: 0x00088F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BtGiveUpRequest other)
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

		// Token: 0x0600376A RID: 14186 RVA: 0x0008ADB8 File Offset: 0x00088FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600376B RID: 14187 RVA: 0x0008ADC4 File Offset: 0x00088FC4
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
				if (num != 64U)
				{
					if (num != 88U)
					{
						if (num != 104U)
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

		// Token: 0x04002B2E RID: 11054
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B2F RID: 11055
		public const int TreeOwnerIdFieldNumber = 13;

		// Token: 0x04002B30 RID: 11056
		private int treeOwnerId_;

		// Token: 0x04002B31 RID: 11057
		public const int TreeIncIdFieldNumber = 11;

		// Token: 0x04002B32 RID: 11058
		private long treeIncId_;

		// Token: 0x04002B33 RID: 11059
		public const int NodeIdFieldNumber = 8;

		// Token: 0x04002B34 RID: 11060
		private int nodeId_;
	}
}
