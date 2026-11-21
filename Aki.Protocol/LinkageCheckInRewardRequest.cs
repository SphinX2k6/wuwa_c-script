using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000916 RID: 2326
	[NetMessage(EMessageId.LinkageCheckInRewardRequest)]
	public sealed class LinkageCheckInRewardRequest : IMessage<LinkageCheckInRewardRequest>, IMessage, IEquatable<LinkageCheckInRewardRequest>, IDeepCloneable<LinkageCheckInRewardRequest>, IBufferMessage
	{
		// Token: 0x0600CD8F RID: 52623 RVA: 0x001E4E57 File Offset: 0x001E3057
		[NullableContext(1)]
		public static LinkageCheckInRewardRequest Create()
		{
			return new LinkageCheckInRewardRequest();
		}

		// Token: 0x17002982 RID: 10626
		// (get) Token: 0x0600CD90 RID: 52624 RVA: 0x001E4E5E File Offset: 0x001E305E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002983 RID: 10627
		// (get) Token: 0x0600CD91 RID: 52625 RVA: 0x001E4E61 File Offset: 0x001E3061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LinkageCheckInRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600CD92 RID: 52626 RVA: 0x001E4E68 File Offset: 0x001E3068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageCheckInRewardRequest()
		{
		}

		// Token: 0x0600CD93 RID: 52627 RVA: 0x001E4E7B File Offset: 0x001E307B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageCheckInRewardRequest(LinkageCheckInRewardRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CD94 RID: 52628 RVA: 0x001E4EB1 File Offset: 0x001E30B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageCheckInRewardRequest Clone()
		{
			return new LinkageCheckInRewardRequest(this);
		}

		// Token: 0x17002984 RID: 10628
		// (get) Token: 0x0600CD95 RID: 52629 RVA: 0x001E4EB9 File Offset: 0x001E30B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x17002985 RID: 10629
		// (get) Token: 0x0600CD96 RID: 52630 RVA: 0x001E4EC1 File Offset: 0x001E30C1
		// (set) Token: 0x0600CD97 RID: 52631 RVA: 0x001E4EC9 File Offset: 0x001E30C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageCheckInType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x0600CD98 RID: 52632 RVA: 0x001E4ED2 File Offset: 0x001E30D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LinkageCheckInRewardRequest);
		}

		// Token: 0x0600CD99 RID: 52633 RVA: 0x001E4EE0 File Offset: 0x001E30E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LinkageCheckInRewardRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CD9A RID: 52634 RVA: 0x001E4F30 File Offset: 0x001E3130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskIds_.GetHashCode();
			if (this.Type != LinkageCheckInType.NormalCheckIn)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CD9B RID: 52635 RVA: 0x001E4F83 File Offset: 0x001E3183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CD9C RID: 52636 RVA: 0x001E4F90 File Offset: 0x001E3190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CD9D RID: 52637 RVA: 0x001E4F9C File Offset: 0x001E319C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, LinkageCheckInRewardRequest._repeated_taskIds_codec);
			if (this.Type != LinkageCheckInType.NormalCheckIn)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CD9E RID: 52638 RVA: 0x001E4FEC File Offset: 0x001E31EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(LinkageCheckInRewardRequest._repeated_taskIds_codec);
			if (this.Type != LinkageCheckInType.NormalCheckIn)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CD9F RID: 52639 RVA: 0x001E5040 File Offset: 0x001E3240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LinkageCheckInRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			if (other.Type != LinkageCheckInType.NormalCheckIn)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CDA0 RID: 52640 RVA: 0x001E508D File Offset: 0x001E328D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CDA1 RID: 52641 RVA: 0x001E5098 File Offset: 0x001E3298
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
				if (num != 80U && num != 82U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Type = (LinkageCheckInType)input.ReadEnum();
					}
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, LinkageCheckInRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04005758 RID: 22360
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005759 RID: 22361
		public const int TaskIdsFieldNumber = 10;

		// Token: 0x0400575A RID: 22362
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x0400575B RID: 22363
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();

		// Token: 0x0400575C RID: 22364
		public const int TypeFieldNumber = 11;

		// Token: 0x0400575D RID: 22365
		private LinkageCheckInType type_;
	}
}
