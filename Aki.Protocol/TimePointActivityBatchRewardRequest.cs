using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013EC RID: 5100
	[NetMessage(EMessageId.TimePointActivityBatchRewardRequest)]
	public sealed class TimePointActivityBatchRewardRequest : IMessage<TimePointActivityBatchRewardRequest>, IMessage, IEquatable<TimePointActivityBatchRewardRequest>, IDeepCloneable<TimePointActivityBatchRewardRequest>, IBufferMessage
	{
		// Token: 0x0601B204 RID: 111108 RVA: 0x003F2BB9 File Offset: 0x003F0DB9
		[NullableContext(1)]
		public static TimePointActivityBatchRewardRequest Create()
		{
			return new TimePointActivityBatchRewardRequest();
		}

		// Token: 0x17005BDA RID: 23514
		// (get) Token: 0x0601B205 RID: 111109 RVA: 0x003F2BC0 File Offset: 0x003F0DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BDB RID: 23515
		// (get) Token: 0x0601B206 RID: 111110 RVA: 0x003F2BC3 File Offset: 0x003F0DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimePointActivityBatchRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601B207 RID: 111111 RVA: 0x003F2BCA File Offset: 0x003F0DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointActivityBatchRewardRequest()
		{
		}

		// Token: 0x0601B208 RID: 111112 RVA: 0x003F2BDD File Offset: 0x003F0DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointActivityBatchRewardRequest(TimePointActivityBatchRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B209 RID: 111113 RVA: 0x003F2C13 File Offset: 0x003F0E13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointActivityBatchRewardRequest Clone()
		{
			return new TimePointActivityBatchRewardRequest(this);
		}

		// Token: 0x17005BDC RID: 23516
		// (get) Token: 0x0601B20A RID: 111114 RVA: 0x003F2C1B File Offset: 0x003F0E1B
		// (set) Token: 0x0601B20B RID: 111115 RVA: 0x003F2C23 File Offset: 0x003F0E23
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

		// Token: 0x17005BDD RID: 23517
		// (get) Token: 0x0601B20C RID: 111116 RVA: 0x003F2C2C File Offset: 0x003F0E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601B20D RID: 111117 RVA: 0x003F2C34 File Offset: 0x003F0E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimePointActivityBatchRewardRequest);
		}

		// Token: 0x0601B20E RID: 111118 RVA: 0x003F2C44 File Offset: 0x003F0E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimePointActivityBatchRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B20F RID: 111119 RVA: 0x003F2C94 File Offset: 0x003F0E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B210 RID: 111120 RVA: 0x003F2CE1 File Offset: 0x003F0EE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B211 RID: 111121 RVA: 0x003F2CEE File Offset: 0x003F0EEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B212 RID: 111122 RVA: 0x003F2CF8 File Offset: 0x003F0EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, TimePointActivityBatchRewardRequest._repeated_ids_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B213 RID: 111123 RVA: 0x003F2D48 File Offset: 0x003F0F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.ids_.CalculateSize(TimePointActivityBatchRewardRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B214 RID: 111124 RVA: 0x003F2D9C File Offset: 0x003F0F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimePointActivityBatchRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B215 RID: 111125 RVA: 0x003F2DE9 File Offset: 0x003F0FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B216 RID: 111126 RVA: 0x003F2DF4 File Offset: 0x003F0FF4
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
				if (num != 40U && num != 42U)
				{
					if (num != 48U)
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
					this.ids_.AddEntriesFrom(ref input, TimePointActivityBatchRewardRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04009E54 RID: 40532
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E55 RID: 40533
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x04009E56 RID: 40534
		private int activityId_;

		// Token: 0x04009E57 RID: 40535
		public const int IdsFieldNumber = 5;

		// Token: 0x04009E58 RID: 40536
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04009E59 RID: 40537
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
