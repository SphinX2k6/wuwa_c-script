using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BA9 RID: 2985
	[NetMessage(EMessageId.OrderRemoveBuffByTagsRequest)]
	public sealed class OrderRemoveBuffByTagsRequest : IMessage<OrderRemoveBuffByTagsRequest>, IMessage, IEquatable<OrderRemoveBuffByTagsRequest>, IDeepCloneable<OrderRemoveBuffByTagsRequest>, IBufferMessage
	{
		// Token: 0x0601030A RID: 66314 RVA: 0x0025D438 File Offset: 0x0025B638
		[NullableContext(1)]
		public static OrderRemoveBuffByTagsRequest Create()
		{
			return new OrderRemoveBuffByTagsRequest();
		}

		// Token: 0x1700351B RID: 13595
		// (get) Token: 0x0601030B RID: 66315 RVA: 0x0025D43F File Offset: 0x0025B63F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700351C RID: 13596
		// (get) Token: 0x0601030C RID: 66316 RVA: 0x0025D442 File Offset: 0x0025B642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrderRemoveBuffByTagsRequest.Descriptor;
			}
		}

		// Token: 0x0601030D RID: 66317 RVA: 0x0025D449 File Offset: 0x0025B649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffByTagsRequest()
		{
		}

		// Token: 0x0601030E RID: 66318 RVA: 0x0025D45C File Offset: 0x0025B65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffByTagsRequest(OrderRemoveBuffByTagsRequest other) : this()
		{
			this.tagIds_ = other.tagIds_.Clone();
			this.instigatorId_ = other.instigatorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601030F RID: 66319 RVA: 0x0025D492 File Offset: 0x0025B692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffByTagsRequest Clone()
		{
			return new OrderRemoveBuffByTagsRequest(this);
		}

		// Token: 0x1700351D RID: 13597
		// (get) Token: 0x06010310 RID: 66320 RVA: 0x0025D49A File Offset: 0x0025B69A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TagIds
		{
			get
			{
				return this.tagIds_;
			}
		}

		// Token: 0x1700351E RID: 13598
		// (get) Token: 0x06010311 RID: 66321 RVA: 0x0025D4A2 File Offset: 0x0025B6A2
		// (set) Token: 0x06010312 RID: 66322 RVA: 0x0025D4AA File Offset: 0x0025B6AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long InstigatorId
		{
			get
			{
				return this.instigatorId_;
			}
			set
			{
				this.instigatorId_ = value;
			}
		}

		// Token: 0x06010313 RID: 66323 RVA: 0x0025D4B3 File Offset: 0x0025B6B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrderRemoveBuffByTagsRequest);
		}

		// Token: 0x06010314 RID: 66324 RVA: 0x0025D4C4 File Offset: 0x0025B6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrderRemoveBuffByTagsRequest other)
		{
			return other != null && (other == this || (this.tagIds_.Equals(other.tagIds_) && this.InstigatorId == other.InstigatorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010315 RID: 66325 RVA: 0x0025D514 File Offset: 0x0025B714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.tagIds_.GetHashCode();
			if (this.InstigatorId != 0L)
			{
				num ^= this.InstigatorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010316 RID: 66326 RVA: 0x0025D561 File Offset: 0x0025B761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010317 RID: 66327 RVA: 0x0025D56E File Offset: 0x0025B76E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010318 RID: 66328 RVA: 0x0025D578 File Offset: 0x0025B778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.tagIds_.WriteTo(ref output, OrderRemoveBuffByTagsRequest._repeated_tagIds_codec);
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.InstigatorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010319 RID: 66329 RVA: 0x0025D5C8 File Offset: 0x0025B7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.tagIds_.CalculateSize(OrderRemoveBuffByTagsRequest._repeated_tagIds_codec);
			if (this.InstigatorId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InstigatorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601031A RID: 66330 RVA: 0x0025D61C File Offset: 0x0025B81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OrderRemoveBuffByTagsRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.tagIds_.Add(other.tagIds_);
			if (other.InstigatorId != 0L)
			{
				this.InstigatorId = other.InstigatorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601031B RID: 66331 RVA: 0x0025D669 File Offset: 0x0025B869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601031C RID: 66332 RVA: 0x0025D674 File Offset: 0x0025B874
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
				if (num != 88U && num != 90U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InstigatorId = input.ReadInt64();
					}
				}
				else
				{
					this.tagIds_.AddEntriesFrom(ref input, OrderRemoveBuffByTagsRequest._repeated_tagIds_codec);
				}
			}
		}

		// Token: 0x04006727 RID: 26407
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006728 RID: 26408
		public const int TagIdsFieldNumber = 11;

		// Token: 0x04006729 RID: 26409
		private static readonly FieldCodec<int> _repeated_tagIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x0400672A RID: 26410
		private readonly RepeatedField<int> tagIds_ = new RepeatedField<int>();

		// Token: 0x0400672B RID: 26411
		public const int InstigatorIdFieldNumber = 15;

		// Token: 0x0400672C RID: 26412
		private long instigatorId_;
	}
}
