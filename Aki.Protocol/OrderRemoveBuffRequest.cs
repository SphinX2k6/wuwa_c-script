using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BAC RID: 2988
	[NetMessage(EMessageId.OrderRemoveBuffRequest)]
	public sealed class OrderRemoveBuffRequest : IMessage<OrderRemoveBuffRequest>, IMessage, IEquatable<OrderRemoveBuffRequest>, IDeepCloneable<OrderRemoveBuffRequest>, IBufferMessage
	{
		// Token: 0x06010344 RID: 66372 RVA: 0x0025DB60 File Offset: 0x0025BD60
		[NullableContext(1)]
		public static OrderRemoveBuffRequest Create()
		{
			return new OrderRemoveBuffRequest();
		}

		// Token: 0x17003526 RID: 13606
		// (get) Token: 0x06010345 RID: 66373 RVA: 0x0025DB67 File Offset: 0x0025BD67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003527 RID: 13607
		// (get) Token: 0x06010346 RID: 66374 RVA: 0x0025DB6A File Offset: 0x0025BD6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrderRemoveBuffRequest.Descriptor;
			}
		}

		// Token: 0x06010347 RID: 66375 RVA: 0x0025DB71 File Offset: 0x0025BD71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffRequest()
		{
		}

		// Token: 0x06010348 RID: 66376 RVA: 0x0025DB84 File Offset: 0x0025BD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffRequest(OrderRemoveBuffRequest other) : this()
		{
			this.id_ = other.id_;
			this.stackCount_ = other.stackCount_;
			this.reason_ = other.reason_;
			this.instigatorId_ = other.instigatorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010349 RID: 66377 RVA: 0x0025DBD8 File Offset: 0x0025BDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffRequest Clone()
		{
			return new OrderRemoveBuffRequest(this);
		}

		// Token: 0x17003528 RID: 13608
		// (get) Token: 0x0601034A RID: 66378 RVA: 0x0025DBE0 File Offset: 0x0025BDE0
		// (set) Token: 0x0601034B RID: 66379 RVA: 0x0025DBE8 File Offset: 0x0025BDE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17003529 RID: 13609
		// (get) Token: 0x0601034C RID: 66380 RVA: 0x0025DBF1 File Offset: 0x0025BDF1
		// (set) Token: 0x0601034D RID: 66381 RVA: 0x0025DBF9 File Offset: 0x0025BDF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StackCount
		{
			get
			{
				return this.stackCount_;
			}
			set
			{
				this.stackCount_ = value;
			}
		}

		// Token: 0x1700352A RID: 13610
		// (get) Token: 0x0601034E RID: 66382 RVA: 0x0025DC02 File Offset: 0x0025BE02
		// (set) Token: 0x0601034F RID: 66383 RVA: 0x0025DC0A File Offset: 0x0025BE0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700352B RID: 13611
		// (get) Token: 0x06010350 RID: 66384 RVA: 0x0025DC1D File Offset: 0x0025BE1D
		// (set) Token: 0x06010351 RID: 66385 RVA: 0x0025DC25 File Offset: 0x0025BE25
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

		// Token: 0x06010352 RID: 66386 RVA: 0x0025DC2E File Offset: 0x0025BE2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrderRemoveBuffRequest);
		}

		// Token: 0x06010353 RID: 66387 RVA: 0x0025DC3C File Offset: 0x0025BE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrderRemoveBuffRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.StackCount == other.StackCount && !(this.Reason != other.Reason) && this.InstigatorId == other.InstigatorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010354 RID: 66388 RVA: 0x0025DCAC File Offset: 0x0025BEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.StackCount != 0)
			{
				num ^= this.StackCount.GetHashCode();
			}
			if (this.Reason.Length != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
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

		// Token: 0x06010355 RID: 66389 RVA: 0x0025DD38 File Offset: 0x0025BF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010356 RID: 66390 RVA: 0x0025DD45 File Offset: 0x0025BF45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010357 RID: 66391 RVA: 0x0025DD50 File Offset: 0x0025BF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.Id);
			}
			if (this.Reason.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.Reason);
			}
			if (this.StackCount != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.StackCount);
			}
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

		// Token: 0x06010358 RID: 66392 RVA: 0x0025DDE8 File Offset: 0x0025BFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.StackCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StackCount);
			}
			if (this.Reason.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Reason);
			}
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

		// Token: 0x06010359 RID: 66393 RVA: 0x0025DE74 File Offset: 0x0025C074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OrderRemoveBuffRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.StackCount != 0)
			{
				this.StackCount = other.StackCount;
			}
			if (other.Reason.Length != 0)
			{
				this.Reason = other.Reason;
			}
			if (other.InstigatorId != 0L)
			{
				this.InstigatorId = other.InstigatorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601035A RID: 66394 RVA: 0x0025DEF1 File Offset: 0x0025C0F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601035B RID: 66395 RVA: 0x0025DEFC File Offset: 0x0025C0FC
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
				if (num <= 74U)
				{
					if (num == 56U)
					{
						this.Id = input.ReadInt64();
						continue;
					}
					if (num == 74U)
					{
						this.Reason = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.StackCount = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.InstigatorId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006735 RID: 26421
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006736 RID: 26422
		public const int IdFieldNumber = 7;

		// Token: 0x04006737 RID: 26423
		private long id_;

		// Token: 0x04006738 RID: 26424
		public const int StackCountFieldNumber = 10;

		// Token: 0x04006739 RID: 26425
		private int stackCount_;

		// Token: 0x0400673A RID: 26426
		public const int ReasonFieldNumber = 9;

		// Token: 0x0400673B RID: 26427
		private string reason_ = "";

		// Token: 0x0400673C RID: 26428
		public const int InstigatorIdFieldNumber = 15;

		// Token: 0x0400673D RID: 26429
		private long instigatorId_;
	}
}
