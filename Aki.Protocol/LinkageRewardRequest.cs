using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000929 RID: 2345
	[NetMessage(EMessageId.LinkageRewardRequest)]
	public sealed class LinkageRewardRequest : IMessage<LinkageRewardRequest>, IMessage, IEquatable<LinkageRewardRequest>, IDeepCloneable<LinkageRewardRequest>, IBufferMessage
	{
		// Token: 0x0600CED1 RID: 52945 RVA: 0x001E75B9 File Offset: 0x001E57B9
		[NullableContext(1)]
		public static LinkageRewardRequest Create()
		{
			return new LinkageRewardRequest();
		}

		// Token: 0x170029C8 RID: 10696
		// (get) Token: 0x0600CED2 RID: 52946 RVA: 0x001E75C0 File Offset: 0x001E57C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029C9 RID: 10697
		// (get) Token: 0x0600CED3 RID: 52947 RVA: 0x001E75C3 File Offset: 0x001E57C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LinkageRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600CED4 RID: 52948 RVA: 0x001E75CA File Offset: 0x001E57CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageRewardRequest()
		{
		}

		// Token: 0x0600CED5 RID: 52949 RVA: 0x001E75D2 File Offset: 0x001E57D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageRewardRequest(LinkageRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.activityPageId_ = other.activityPageId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CED6 RID: 52950 RVA: 0x001E7603 File Offset: 0x001E5803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageRewardRequest Clone()
		{
			return new LinkageRewardRequest(this);
		}

		// Token: 0x170029CA RID: 10698
		// (get) Token: 0x0600CED7 RID: 52951 RVA: 0x001E760B File Offset: 0x001E580B
		// (set) Token: 0x0600CED8 RID: 52952 RVA: 0x001E7613 File Offset: 0x001E5813
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

		// Token: 0x170029CB RID: 10699
		// (get) Token: 0x0600CED9 RID: 52953 RVA: 0x001E761C File Offset: 0x001E581C
		// (set) Token: 0x0600CEDA RID: 52954 RVA: 0x001E7624 File Offset: 0x001E5824
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

		// Token: 0x0600CEDB RID: 52955 RVA: 0x001E762D File Offset: 0x001E582D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LinkageRewardRequest);
		}

		// Token: 0x0600CEDC RID: 52956 RVA: 0x001E763B File Offset: 0x001E583B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LinkageRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.ActivityPageId == other.ActivityPageId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CEDD RID: 52957 RVA: 0x001E767C File Offset: 0x001E587C
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

		// Token: 0x0600CEDE RID: 52958 RVA: 0x001E76D4 File Offset: 0x001E58D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CEDF RID: 52959 RVA: 0x001E76E1 File Offset: 0x001E58E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CEE0 RID: 52960 RVA: 0x001E76EC File Offset: 0x001E58EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			if (this.ActivityPageId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ActivityPageId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CEE1 RID: 52961 RVA: 0x001E7748 File Offset: 0x001E5948
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

		// Token: 0x0600CEE2 RID: 52962 RVA: 0x001E77A0 File Offset: 0x001E59A0
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

		// Token: 0x0600CEE3 RID: 52963 RVA: 0x001E77F0 File Offset: 0x001E59F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CEE4 RID: 52964 RVA: 0x001E77FC File Offset: 0x001E59FC
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
				if (num != 32U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityPageId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400575A RID: 22362
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400575B RID: 22363
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x0400575C RID: 22364
		private int activityId_;

		// Token: 0x0400575D RID: 22365
		public const int ActivityPageIdFieldNumber = 9;

		// Token: 0x0400575E RID: 22366
		private int activityPageId_;
	}
}
