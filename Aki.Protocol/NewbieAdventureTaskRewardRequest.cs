using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AEA RID: 2794
	[NetMessage(EMessageId.NewbieAdventureTaskRewardRequest)]
	public sealed class NewbieAdventureTaskRewardRequest : IMessage<NewbieAdventureTaskRewardRequest>, IMessage, IEquatable<NewbieAdventureTaskRewardRequest>, IDeepCloneable<NewbieAdventureTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F347 RID: 62279 RVA: 0x00238B05 File Offset: 0x00236D05
		[NullableContext(1)]
		public static NewbieAdventureTaskRewardRequest Create()
		{
			return new NewbieAdventureTaskRewardRequest();
		}

		// Token: 0x17003189 RID: 12681
		// (get) Token: 0x0600F348 RID: 62280 RVA: 0x00238B0C File Offset: 0x00236D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700318A RID: 12682
		// (get) Token: 0x0600F349 RID: 62281 RVA: 0x00238B0F File Offset: 0x00236D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieAdventureTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F34A RID: 62282 RVA: 0x00238B16 File Offset: 0x00236D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureTaskRewardRequest()
		{
		}

		// Token: 0x0600F34B RID: 62283 RVA: 0x00238B29 File Offset: 0x00236D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureTaskRewardRequest(NewbieAdventureTaskRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F34C RID: 62284 RVA: 0x00238B5F File Offset: 0x00236D5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureTaskRewardRequest Clone()
		{
			return new NewbieAdventureTaskRewardRequest(this);
		}

		// Token: 0x1700318B RID: 12683
		// (get) Token: 0x0600F34D RID: 62285 RVA: 0x00238B67 File Offset: 0x00236D67
		// (set) Token: 0x0600F34E RID: 62286 RVA: 0x00238B6F File Offset: 0x00236D6F
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

		// Token: 0x1700318C RID: 12684
		// (get) Token: 0x0600F34F RID: 62287 RVA: 0x00238B78 File Offset: 0x00236D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600F350 RID: 62288 RVA: 0x00238B80 File Offset: 0x00236D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieAdventureTaskRewardRequest);
		}

		// Token: 0x0600F351 RID: 62289 RVA: 0x00238B90 File Offset: 0x00236D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieAdventureTaskRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F352 RID: 62290 RVA: 0x00238BE0 File Offset: 0x00236DE0
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

		// Token: 0x0600F353 RID: 62291 RVA: 0x00238C2D File Offset: 0x00236E2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F354 RID: 62292 RVA: 0x00238C3A File Offset: 0x00236E3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F355 RID: 62293 RVA: 0x00238C44 File Offset: 0x00236E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			this.taskIds_.WriteTo(ref output, NewbieAdventureTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F356 RID: 62294 RVA: 0x00238C94 File Offset: 0x00236E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.taskIds_.CalculateSize(NewbieAdventureTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F357 RID: 62295 RVA: 0x00238CE8 File Offset: 0x00236EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieAdventureTaskRewardRequest other)
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

		// Token: 0x0600F358 RID: 62296 RVA: 0x00238D35 File Offset: 0x00236F35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F359 RID: 62297 RVA: 0x00238D40 File Offset: 0x00236F40
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
				if (num != 40U)
				{
					if (num != 72U && num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.taskIds_.AddEntriesFrom(ref input, NewbieAdventureTaskRewardRequest._repeated_taskIds_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006270 RID: 25200
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006271 RID: 25201
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x04006272 RID: 25202
		private int activityId_;

		// Token: 0x04006273 RID: 25203
		public const int TaskIdsFieldNumber = 9;

		// Token: 0x04006274 RID: 25204
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04006275 RID: 25205
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
