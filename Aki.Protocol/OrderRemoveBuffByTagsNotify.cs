using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BA8 RID: 2984
	[NetMessage(EMessageId.OrderRemoveBuffByTagsNotify)]
	public sealed class OrderRemoveBuffByTagsNotify : IMessage<OrderRemoveBuffByTagsNotify>, IMessage, IEquatable<OrderRemoveBuffByTagsNotify>, IDeepCloneable<OrderRemoveBuffByTagsNotify>, IBufferMessage
	{
		// Token: 0x060102F6 RID: 66294 RVA: 0x0025D18D File Offset: 0x0025B38D
		[NullableContext(1)]
		public static OrderRemoveBuffByTagsNotify Create()
		{
			return new OrderRemoveBuffByTagsNotify();
		}

		// Token: 0x17003517 RID: 13591
		// (get) Token: 0x060102F7 RID: 66295 RVA: 0x0025D194 File Offset: 0x0025B394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003518 RID: 13592
		// (get) Token: 0x060102F8 RID: 66296 RVA: 0x0025D197 File Offset: 0x0025B397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrderRemoveBuffByTagsNotify.Descriptor;
			}
		}

		// Token: 0x060102F9 RID: 66297 RVA: 0x0025D19E File Offset: 0x0025B39E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffByTagsNotify()
		{
		}

		// Token: 0x060102FA RID: 66298 RVA: 0x0025D1B1 File Offset: 0x0025B3B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffByTagsNotify(OrderRemoveBuffByTagsNotify other) : this()
		{
			this.tagIds_ = other.tagIds_.Clone();
			this.instigatorId_ = other.instigatorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060102FB RID: 66299 RVA: 0x0025D1E7 File Offset: 0x0025B3E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffByTagsNotify Clone()
		{
			return new OrderRemoveBuffByTagsNotify(this);
		}

		// Token: 0x17003519 RID: 13593
		// (get) Token: 0x060102FC RID: 66300 RVA: 0x0025D1EF File Offset: 0x0025B3EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TagIds
		{
			get
			{
				return this.tagIds_;
			}
		}

		// Token: 0x1700351A RID: 13594
		// (get) Token: 0x060102FD RID: 66301 RVA: 0x0025D1F7 File Offset: 0x0025B3F7
		// (set) Token: 0x060102FE RID: 66302 RVA: 0x0025D1FF File Offset: 0x0025B3FF
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

		// Token: 0x060102FF RID: 66303 RVA: 0x0025D208 File Offset: 0x0025B408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrderRemoveBuffByTagsNotify);
		}

		// Token: 0x06010300 RID: 66304 RVA: 0x0025D218 File Offset: 0x0025B418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrderRemoveBuffByTagsNotify other)
		{
			return other != null && (other == this || (this.tagIds_.Equals(other.tagIds_) && this.InstigatorId == other.InstigatorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010301 RID: 66305 RVA: 0x0025D268 File Offset: 0x0025B468
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

		// Token: 0x06010302 RID: 66306 RVA: 0x0025D2B5 File Offset: 0x0025B4B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010303 RID: 66307 RVA: 0x0025D2C2 File Offset: 0x0025B4C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010304 RID: 66308 RVA: 0x0025D2CC File Offset: 0x0025B4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.tagIds_.WriteTo(ref output, OrderRemoveBuffByTagsNotify._repeated_tagIds_codec);
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.InstigatorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010305 RID: 66309 RVA: 0x0025D31C File Offset: 0x0025B51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.tagIds_.CalculateSize(OrderRemoveBuffByTagsNotify._repeated_tagIds_codec);
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

		// Token: 0x06010306 RID: 66310 RVA: 0x0025D370 File Offset: 0x0025B570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OrderRemoveBuffByTagsNotify other)
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

		// Token: 0x06010307 RID: 66311 RVA: 0x0025D3BD File Offset: 0x0025B5BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010308 RID: 66312 RVA: 0x0025D3C8 File Offset: 0x0025B5C8
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
				if (num != 56U && num != 58U)
				{
					if (num != 96U)
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
					this.tagIds_.AddEntriesFrom(ref input, OrderRemoveBuffByTagsNotify._repeated_tagIds_codec);
				}
			}
		}

		// Token: 0x04006721 RID: 26401
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006722 RID: 26402
		public const int TagIdsFieldNumber = 7;

		// Token: 0x04006723 RID: 26403
		private static readonly FieldCodec<int> _repeated_tagIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04006724 RID: 26404
		private readonly RepeatedField<int> tagIds_ = new RepeatedField<int>();

		// Token: 0x04006725 RID: 26405
		public const int InstigatorIdFieldNumber = 12;

		// Token: 0x04006726 RID: 26406
		private long instigatorId_;
	}
}
