using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B99 RID: 2969
	[NetMessage(EMessageId.OrderRemoveBuffByTagsRequest)]
	public sealed class OrderRemoveBuffByTagsRequest : IMessage<OrderRemoveBuffByTagsRequest>, IMessage, IEquatable<OrderRemoveBuffByTagsRequest>, IDeepCloneable<OrderRemoveBuffByTagsRequest>, IBufferMessage
	{
		// Token: 0x06010206 RID: 66054 RVA: 0x0025B580 File Offset: 0x00259780
		[NullableContext(1)]
		public static OrderRemoveBuffByTagsRequest Create()
		{
			return new OrderRemoveBuffByTagsRequest();
		}

		// Token: 0x170034E2 RID: 13538
		// (get) Token: 0x06010207 RID: 66055 RVA: 0x0025B587 File Offset: 0x00259787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034E3 RID: 13539
		// (get) Token: 0x06010208 RID: 66056 RVA: 0x0025B58A File Offset: 0x0025978A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrderRemoveBuffByTagsRequest.Descriptor;
			}
		}

		// Token: 0x06010209 RID: 66057 RVA: 0x0025B591 File Offset: 0x00259791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffByTagsRequest()
		{
		}

		// Token: 0x0601020A RID: 66058 RVA: 0x0025B5A4 File Offset: 0x002597A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffByTagsRequest(OrderRemoveBuffByTagsRequest other) : this()
		{
			this.tagIds_ = other.tagIds_.Clone();
			this.instigatorId_ = other.instigatorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601020B RID: 66059 RVA: 0x0025B5DA File Offset: 0x002597DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffByTagsRequest Clone()
		{
			return new OrderRemoveBuffByTagsRequest(this);
		}

		// Token: 0x170034E4 RID: 13540
		// (get) Token: 0x0601020C RID: 66060 RVA: 0x0025B5E2 File Offset: 0x002597E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TagIds
		{
			get
			{
				return this.tagIds_;
			}
		}

		// Token: 0x170034E5 RID: 13541
		// (get) Token: 0x0601020D RID: 66061 RVA: 0x0025B5EA File Offset: 0x002597EA
		// (set) Token: 0x0601020E RID: 66062 RVA: 0x0025B5F2 File Offset: 0x002597F2
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

		// Token: 0x0601020F RID: 66063 RVA: 0x0025B5FB File Offset: 0x002597FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrderRemoveBuffByTagsRequest);
		}

		// Token: 0x06010210 RID: 66064 RVA: 0x0025B60C File Offset: 0x0025980C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrderRemoveBuffByTagsRequest other)
		{
			return other != null && (other == this || (this.tagIds_.Equals(other.tagIds_) && this.InstigatorId == other.InstigatorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010211 RID: 66065 RVA: 0x0025B65C File Offset: 0x0025985C
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

		// Token: 0x06010212 RID: 66066 RVA: 0x0025B6A9 File Offset: 0x002598A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010213 RID: 66067 RVA: 0x0025B6B6 File Offset: 0x002598B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010214 RID: 66068 RVA: 0x0025B6C0 File Offset: 0x002598C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.InstigatorId);
			}
			this.tagIds_.WriteTo(ref output, OrderRemoveBuffByTagsRequest._repeated_tagIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010215 RID: 66069 RVA: 0x0025B710 File Offset: 0x00259910
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

		// Token: 0x06010216 RID: 66070 RVA: 0x0025B764 File Offset: 0x00259964
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

		// Token: 0x06010217 RID: 66071 RVA: 0x0025B7B1 File Offset: 0x002599B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010218 RID: 66072 RVA: 0x0025B7BC File Offset: 0x002599BC
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
				if (num != 96U)
				{
					if (num != 120U && num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.tagIds_.AddEntriesFrom(ref input, OrderRemoveBuffByTagsRequest._repeated_tagIds_codec);
					}
				}
				else
				{
					this.InstigatorId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04006737 RID: 26423
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006738 RID: 26424
		public const int TagIdsFieldNumber = 15;

		// Token: 0x04006739 RID: 26425
		private static readonly FieldCodec<int> _repeated_tagIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x0400673A RID: 26426
		private readonly RepeatedField<int> tagIds_ = new RepeatedField<int>();

		// Token: 0x0400673B RID: 26427
		public const int InstigatorIdFieldNumber = 12;

		// Token: 0x0400673C RID: 26428
		private long instigatorId_;
	}
}
