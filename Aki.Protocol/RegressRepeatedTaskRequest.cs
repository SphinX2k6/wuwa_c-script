using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ED3 RID: 3795
	[NetMessage(EMessageId.RegressRepeatedTaskRequest)]
	public sealed class RegressRepeatedTaskRequest : IMessage<RegressRepeatedTaskRequest>, IMessage, IEquatable<RegressRepeatedTaskRequest>, IDeepCloneable<RegressRepeatedTaskRequest>, IBufferMessage
	{
		// Token: 0x060145EB RID: 83435 RVA: 0x002F6785 File Offset: 0x002F4985
		[NullableContext(1)]
		public static RegressRepeatedTaskRequest Create()
		{
			return new RegressRepeatedTaskRequest();
		}

		// Token: 0x170043C3 RID: 17347
		// (get) Token: 0x060145EC RID: 83436 RVA: 0x002F678C File Offset: 0x002F498C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043C4 RID: 17348
		// (get) Token: 0x060145ED RID: 83437 RVA: 0x002F678F File Offset: 0x002F498F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressRepeatedTaskRequest.Descriptor;
			}
		}

		// Token: 0x060145EE RID: 83438 RVA: 0x002F6796 File Offset: 0x002F4996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressRepeatedTaskRequest()
		{
		}

		// Token: 0x060145EF RID: 83439 RVA: 0x002F67A9 File Offset: 0x002F49A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressRepeatedTaskRequest(RegressRepeatedTaskRequest other) : this()
		{
			this.taskId_ = other.taskId_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060145F0 RID: 83440 RVA: 0x002F67DF File Offset: 0x002F49DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressRepeatedTaskRequest Clone()
		{
			return new RegressRepeatedTaskRequest(this);
		}

		// Token: 0x170043C5 RID: 17349
		// (get) Token: 0x060145F1 RID: 83441 RVA: 0x002F67E7 File Offset: 0x002F49E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskId
		{
			get
			{
				return this.taskId_;
			}
		}

		// Token: 0x170043C6 RID: 17350
		// (get) Token: 0x060145F2 RID: 83442 RVA: 0x002F67EF File Offset: 0x002F49EF
		// (set) Token: 0x060145F3 RID: 83443 RVA: 0x002F67F7 File Offset: 0x002F49F7
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

		// Token: 0x060145F4 RID: 83444 RVA: 0x002F6800 File Offset: 0x002F4A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressRepeatedTaskRequest);
		}

		// Token: 0x060145F5 RID: 83445 RVA: 0x002F6810 File Offset: 0x002F4A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressRepeatedTaskRequest other)
		{
			return other != null && (other == this || (this.taskId_.Equals(other.taskId_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060145F6 RID: 83446 RVA: 0x002F6860 File Offset: 0x002F4A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskId_.GetHashCode();
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

		// Token: 0x060145F7 RID: 83447 RVA: 0x002F68AD File Offset: 0x002F4AAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060145F8 RID: 83448 RVA: 0x002F68BA File Offset: 0x002F4ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060145F9 RID: 83449 RVA: 0x002F68C4 File Offset: 0x002F4AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			this.taskId_.WriteTo(ref output, RegressRepeatedTaskRequest._repeated_taskId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060145FA RID: 83450 RVA: 0x002F6914 File Offset: 0x002F4B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskId_.CalculateSize(RegressRepeatedTaskRequest._repeated_taskId_codec);
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

		// Token: 0x060145FB RID: 83451 RVA: 0x002F6968 File Offset: 0x002F4B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressRepeatedTaskRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskId_.Add(other.taskId_);
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060145FC RID: 83452 RVA: 0x002F69B5 File Offset: 0x002F4BB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060145FD RID: 83453 RVA: 0x002F69C0 File Offset: 0x002F4BC0
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
				if (num != 48U)
				{
					if (num != 64U && num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.taskId_.AddEntriesFrom(ref input, RegressRepeatedTaskRequest._repeated_taskId_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007C23 RID: 31779
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C24 RID: 31780
		public const int TaskIdFieldNumber = 8;

		// Token: 0x04007C25 RID: 31781
		private static readonly FieldCodec<int> _repeated_taskId_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04007C26 RID: 31782
		private readonly RepeatedField<int> taskId_ = new RepeatedField<int>();

		// Token: 0x04007C27 RID: 31783
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x04007C28 RID: 31784
		private int activityId_;
	}
}
