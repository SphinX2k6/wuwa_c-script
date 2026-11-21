using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000918 RID: 2328
	[NetMessage(EMessageId.LinkageRewardRequest)]
	public sealed class LinkageRewardRequest : IMessage<LinkageRewardRequest>, IMessage, IEquatable<LinkageRewardRequest>, IDeepCloneable<LinkageRewardRequest>, IBufferMessage
	{
		// Token: 0x0600CDB5 RID: 52661 RVA: 0x001E52E9 File Offset: 0x001E34E9
		[NullableContext(1)]
		public static LinkageRewardRequest Create()
		{
			return new LinkageRewardRequest();
		}

		// Token: 0x17002989 RID: 10633
		// (get) Token: 0x0600CDB6 RID: 52662 RVA: 0x001E52F0 File Offset: 0x001E34F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700298A RID: 10634
		// (get) Token: 0x0600CDB7 RID: 52663 RVA: 0x001E52F3 File Offset: 0x001E34F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LinkageRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600CDB8 RID: 52664 RVA: 0x001E52FA File Offset: 0x001E34FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageRewardRequest()
		{
		}

		// Token: 0x0600CDB9 RID: 52665 RVA: 0x001E5302 File Offset: 0x001E3502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageRewardRequest(LinkageRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.activityPageId_ = other.activityPageId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CDBA RID: 52666 RVA: 0x001E5333 File Offset: 0x001E3533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageRewardRequest Clone()
		{
			return new LinkageRewardRequest(this);
		}

		// Token: 0x1700298B RID: 10635
		// (get) Token: 0x0600CDBB RID: 52667 RVA: 0x001E533B File Offset: 0x001E353B
		// (set) Token: 0x0600CDBC RID: 52668 RVA: 0x001E5343 File Offset: 0x001E3543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x1700298C RID: 10636
		// (get) Token: 0x0600CDBD RID: 52669 RVA: 0x001E534C File Offset: 0x001E354C
		// (set) Token: 0x0600CDBE RID: 52670 RVA: 0x001E5354 File Offset: 0x001E3554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityPageId
		{
			get
			{
				return this.activityPageId_;
			}
			set
			{
				this.activityPageId_ = value;
			}
		}

		// Token: 0x0600CDBF RID: 52671 RVA: 0x001E535D File Offset: 0x001E355D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LinkageRewardRequest);
		}

		// Token: 0x0600CDC0 RID: 52672 RVA: 0x001E536B File Offset: 0x001E356B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LinkageRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.ActivityPageId == other.ActivityPageId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CDC1 RID: 52673 RVA: 0x001E53AC File Offset: 0x001E35AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.ActivityPageId != 0)
			{
				num ^= this.ActivityPageId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CDC2 RID: 52674 RVA: 0x001E5404 File Offset: 0x001E3604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CDC3 RID: 52675 RVA: 0x001E5411 File Offset: 0x001E3611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CDC4 RID: 52676 RVA: 0x001E541C File Offset: 0x001E361C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityPageId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityPageId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CDC5 RID: 52677 RVA: 0x001E5478 File Offset: 0x001E3678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.ActivityPageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityPageId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CDC6 RID: 52678 RVA: 0x001E54D0 File Offset: 0x001E36D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LinkageRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.ActivityPageId != 0)
			{
				this.ActivityPageId = other.ActivityPageId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CDC7 RID: 52679 RVA: 0x001E5520 File Offset: 0x001E3720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CDC8 RID: 52680 RVA: 0x001E552C File Offset: 0x001E372C
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
				if (num != 80U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityPageId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005761 RID: 22369
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005762 RID: 22370
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x04005763 RID: 22371
		private int activityId_;

		// Token: 0x04005764 RID: 22372
		public const int ActivityPageIdFieldNumber = 10;

		// Token: 0x04005765 RID: 22373
		private int activityPageId_;
	}
}
