using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000089 RID: 137
	public sealed class ActivityLinkageReward : IMessage<ActivityLinkageReward>, IMessage, IEquatable<ActivityLinkageReward>, IDeepCloneable<ActivityLinkageReward>, IBufferMessage
	{
		// Token: 0x06001A74 RID: 6772 RVA: 0x0004AC53 File Offset: 0x00048E53
		[NullableContext(1)]
		public static ActivityLinkageReward Create()
		{
			return new ActivityLinkageReward();
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06001A75 RID: 6773 RVA: 0x0004AC5A File Offset: 0x00048E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ActivityLinkageReward> Parser
		{
			get
			{
				return ActivityLinkageReward._parser;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x0004AC61 File Offset: 0x00048E61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06001A77 RID: 6775 RVA: 0x0004AC64 File Offset: 0x00048E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityLinkageReward.Descriptor;
			}
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x0004AC6B File Offset: 0x00048E6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityLinkageReward()
		{
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x0004AC73 File Offset: 0x00048E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityLinkageReward(ActivityLinkageReward other) : this()
		{
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x0004ACA4 File Offset: 0x00048EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityLinkageReward Clone()
		{
			return new ActivityLinkageReward(this);
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06001A7B RID: 6779 RVA: 0x0004ACAC File Offset: 0x00048EAC
		// (set) Token: 0x06001A7C RID: 6780 RVA: 0x0004ACB4 File Offset: 0x00048EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06001A7D RID: 6781 RVA: 0x0004ACBD File Offset: 0x00048EBD
		// (set) Token: 0x06001A7E RID: 6782 RVA: 0x0004ACC5 File Offset: 0x00048EC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x0004ACCE File Offset: 0x00048ECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityLinkageReward);
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x0004ACDC File Offset: 0x00048EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityLinkageReward other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x0004AD1C File Offset: 0x00048F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x0004AD74 File Offset: 0x00048F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x0004AD81 File Offset: 0x00048F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x0004AD8C File Offset: 0x00048F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x0004ADE4 File Offset: 0x00048FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x0004AE3C File Offset: 0x0004903C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityLinkageReward other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x0004AE8C File Offset: 0x0004908C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x0004AE98 File Offset: 0x00049098
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002256 RID: 8790
		private static readonly MessageParser<ActivityLinkageReward> _parser = new MessageParser<ActivityLinkageReward>(() => new ActivityLinkageReward());

		// Token: 0x04002257 RID: 8791
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002258 RID: 8792
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04002259 RID: 8793
		private int itemId_;

		// Token: 0x0400225A RID: 8794
		public const int CountFieldNumber = 2;

		// Token: 0x0400225B RID: 8795
		private int count_;
	}
}
