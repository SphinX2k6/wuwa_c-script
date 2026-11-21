using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B98 RID: 2968
	[NetMessage(EMessageId.OrderRemoveBuffByTagsNotify)]
	public sealed class OrderRemoveBuffByTagsNotify : IMessage<OrderRemoveBuffByTagsNotify>, IMessage, IEquatable<OrderRemoveBuffByTagsNotify>, IDeepCloneable<OrderRemoveBuffByTagsNotify>, IBufferMessage
	{
		// Token: 0x060101F2 RID: 66034 RVA: 0x0025B2D5 File Offset: 0x002594D5
		[NullableContext(1)]
		public static OrderRemoveBuffByTagsNotify Create()
		{
			return new OrderRemoveBuffByTagsNotify();
		}

		// Token: 0x170034DE RID: 13534
		// (get) Token: 0x060101F3 RID: 66035 RVA: 0x0025B2DC File Offset: 0x002594DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034DF RID: 13535
		// (get) Token: 0x060101F4 RID: 66036 RVA: 0x0025B2DF File Offset: 0x002594DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrderRemoveBuffByTagsNotify.Descriptor;
			}
		}

		// Token: 0x060101F5 RID: 66037 RVA: 0x0025B2E6 File Offset: 0x002594E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffByTagsNotify()
		{
		}

		// Token: 0x060101F6 RID: 66038 RVA: 0x0025B2F9 File Offset: 0x002594F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffByTagsNotify(OrderRemoveBuffByTagsNotify other) : this()
		{
			this.tagIds_ = other.tagIds_.Clone();
			this.instigatorId_ = other.instigatorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060101F7 RID: 66039 RVA: 0x0025B32F File Offset: 0x0025952F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffByTagsNotify Clone()
		{
			return new OrderRemoveBuffByTagsNotify(this);
		}

		// Token: 0x170034E0 RID: 13536
		// (get) Token: 0x060101F8 RID: 66040 RVA: 0x0025B337 File Offset: 0x00259537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TagIds
		{
			get
			{
				return this.tagIds_;
			}
		}

		// Token: 0x170034E1 RID: 13537
		// (get) Token: 0x060101F9 RID: 66041 RVA: 0x0025B33F File Offset: 0x0025953F
		// (set) Token: 0x060101FA RID: 66042 RVA: 0x0025B347 File Offset: 0x00259547
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

		// Token: 0x060101FB RID: 66043 RVA: 0x0025B350 File Offset: 0x00259550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrderRemoveBuffByTagsNotify);
		}

		// Token: 0x060101FC RID: 66044 RVA: 0x0025B360 File Offset: 0x00259560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrderRemoveBuffByTagsNotify other)
		{
			return other != null && (other == this || (this.tagIds_.Equals(other.tagIds_) && this.InstigatorId == other.InstigatorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060101FD RID: 66045 RVA: 0x0025B3B0 File Offset: 0x002595B0
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

		// Token: 0x060101FE RID: 66046 RVA: 0x0025B3FD File Offset: 0x002595FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060101FF RID: 66047 RVA: 0x0025B40A File Offset: 0x0025960A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010200 RID: 66048 RVA: 0x0025B414 File Offset: 0x00259614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.InstigatorId);
			}
			this.tagIds_.WriteTo(ref output, OrderRemoveBuffByTagsNotify._repeated_tagIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010201 RID: 66049 RVA: 0x0025B464 File Offset: 0x00259664
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

		// Token: 0x06010202 RID: 66050 RVA: 0x0025B4B8 File Offset: 0x002596B8
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

		// Token: 0x06010203 RID: 66051 RVA: 0x0025B505 File Offset: 0x00259705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010204 RID: 66052 RVA: 0x0025B510 File Offset: 0x00259710
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
				if (num != 24U)
				{
					if (num != 40U && num != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.tagIds_.AddEntriesFrom(ref input, OrderRemoveBuffByTagsNotify._repeated_tagIds_codec);
					}
				}
				else
				{
					this.InstigatorId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04006731 RID: 26417
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006732 RID: 26418
		public const int TagIdsFieldNumber = 5;

		// Token: 0x04006733 RID: 26419
		private static readonly FieldCodec<int> _repeated_tagIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04006734 RID: 26420
		private readonly RepeatedField<int> tagIds_ = new RepeatedField<int>();

		// Token: 0x04006735 RID: 26421
		public const int InstigatorIdFieldNumber = 3;

		// Token: 0x04006736 RID: 26422
		private long instigatorId_;
	}
}
