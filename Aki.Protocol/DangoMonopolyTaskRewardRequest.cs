using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200039A RID: 922
	[NetMessage(EMessageId.DangoMonopolyTaskRewardRequest)]
	public sealed class DangoMonopolyTaskRewardRequest : IMessage<DangoMonopolyTaskRewardRequest>, IMessage, IEquatable<DangoMonopolyTaskRewardRequest>, IDeepCloneable<DangoMonopolyTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x06005B30 RID: 23344 RVA: 0x000DE1B4 File Offset: 0x000DC3B4
		[NullableContext(1)]
		public static DangoMonopolyTaskRewardRequest Create()
		{
			return new DangoMonopolyTaskRewardRequest();
		}

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x06005B31 RID: 23345 RVA: 0x000DE1BB File Offset: 0x000DC3BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x06005B32 RID: 23346 RVA: 0x000DE1BE File Offset: 0x000DC3BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x06005B33 RID: 23347 RVA: 0x000DE1C5 File Offset: 0x000DC3C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskRewardRequest()
		{
		}

		// Token: 0x06005B34 RID: 23348 RVA: 0x000DE1D8 File Offset: 0x000DC3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskRewardRequest(DangoMonopolyTaskRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B35 RID: 23349 RVA: 0x000DE20E File Offset: 0x000DC40E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskRewardRequest Clone()
		{
			return new DangoMonopolyTaskRewardRequest(this);
		}

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x06005B36 RID: 23350 RVA: 0x000DE216 File Offset: 0x000DC416
		// (set) Token: 0x06005B37 RID: 23351 RVA: 0x000DE21E File Offset: 0x000DC41E
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

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x06005B38 RID: 23352 RVA: 0x000DE227 File Offset: 0x000DC427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x06005B39 RID: 23353 RVA: 0x000DE22F File Offset: 0x000DC42F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyTaskRewardRequest);
		}

		// Token: 0x06005B3A RID: 23354 RVA: 0x000DE240 File Offset: 0x000DC440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyTaskRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005B3B RID: 23355 RVA: 0x000DE290 File Offset: 0x000DC490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005B3C RID: 23356 RVA: 0x000DE2DD File Offset: 0x000DC4DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005B3D RID: 23357 RVA: 0x000DE2EA File Offset: 0x000DC4EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B3E RID: 23358 RVA: 0x000DE2F4 File Offset: 0x000DC4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, DangoMonopolyTaskRewardRequest._repeated_taskIds_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B3F RID: 23359 RVA: 0x000DE344 File Offset: 0x000DC544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.taskIds_.CalculateSize(DangoMonopolyTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005B40 RID: 23360 RVA: 0x000DE398 File Offset: 0x000DC598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005B41 RID: 23361 RVA: 0x000DE3E5 File Offset: 0x000DC5E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B42 RID: 23362 RVA: 0x000DE3F0 File Offset: 0x000DC5F0
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
					if (num != 112U)
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
					this.taskIds_.AddEntriesFrom(ref input, DangoMonopolyTaskRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04003644 RID: 13892
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003645 RID: 13893
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x04003646 RID: 13894
		private int activityId_;

		// Token: 0x04003647 RID: 13895
		public const int TaskIdsFieldNumber = 7;

		// Token: 0x04003648 RID: 13896
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04003649 RID: 13897
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
