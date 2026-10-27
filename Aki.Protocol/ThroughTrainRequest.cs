using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001365 RID: 4965
	[NetMessage(EMessageId.ThroughTrainRequest)]
	public sealed class ThroughTrainRequest : IMessage<ThroughTrainRequest>, IMessage, IEquatable<ThroughTrainRequest>, IDeepCloneable<ThroughTrainRequest>, IBufferMessage
	{
		// Token: 0x0601A5E1 RID: 108001 RVA: 0x003D4281 File Offset: 0x003D2481
		[NullableContext(1)]
		public static ThroughTrainRequest Create()
		{
			return new ThroughTrainRequest();
		}

		// Token: 0x170058F0 RID: 22768
		// (get) Token: 0x0601A5E2 RID: 108002 RVA: 0x003D4288 File Offset: 0x003D2488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058F1 RID: 22769
		// (get) Token: 0x0601A5E3 RID: 108003 RVA: 0x003D428B File Offset: 0x003D248B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThroughTrainRequest.Descriptor;
			}
		}

		// Token: 0x0601A5E4 RID: 108004 RVA: 0x003D4292 File Offset: 0x003D2492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainRequest()
		{
		}

		// Token: 0x0601A5E5 RID: 108005 RVA: 0x003D429A File Offset: 0x003D249A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainRequest(ThroughTrainRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A5E6 RID: 108006 RVA: 0x003D42BF File Offset: 0x003D24BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainRequest Clone()
		{
			return new ThroughTrainRequest(this);
		}

		// Token: 0x170058F2 RID: 22770
		// (get) Token: 0x0601A5E7 RID: 108007 RVA: 0x003D42C7 File Offset: 0x003D24C7
		// (set) Token: 0x0601A5E8 RID: 108008 RVA: 0x003D42CF File Offset: 0x003D24CF
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

		// Token: 0x0601A5E9 RID: 108009 RVA: 0x003D42D8 File Offset: 0x003D24D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThroughTrainRequest);
		}

		// Token: 0x0601A5EA RID: 108010 RVA: 0x003D42E6 File Offset: 0x003D24E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThroughTrainRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A5EB RID: 108011 RVA: 0x003D4314 File Offset: 0x003D2514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A5EC RID: 108012 RVA: 0x003D4353 File Offset: 0x003D2553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A5ED RID: 108013 RVA: 0x003D4360 File Offset: 0x003D2560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A5EE RID: 108014 RVA: 0x003D4369 File Offset: 0x003D2569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x0601A5EF RID: 108015 RVA: 0x003D439C File Offset: 0x003D259C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A5F0 RID: 108016 RVA: 0x003D43DA File Offset: 0x003D25DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThroughTrainRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A5F1 RID: 108017 RVA: 0x003D440B File Offset: 0x003D260B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A5F2 RID: 108018 RVA: 0x003D4414 File Offset: 0x003D2614
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400999B RID: 39323
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400999C RID: 39324
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x0400999D RID: 39325
		private int activityId_;
	}
}
