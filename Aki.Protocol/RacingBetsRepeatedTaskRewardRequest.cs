using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E74 RID: 3700
	[NetMessage(EMessageId.RacingBetsRepeatedTaskRewardRequest)]
	public sealed class RacingBetsRepeatedTaskRewardRequest : IMessage<RacingBetsRepeatedTaskRewardRequest>, IMessage, IEquatable<RacingBetsRepeatedTaskRewardRequest>, IDeepCloneable<RacingBetsRepeatedTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x06013E07 RID: 81415 RVA: 0x002E5181 File Offset: 0x002E3381
		[NullableContext(1)]
		public static RacingBetsRepeatedTaskRewardRequest Create()
		{
			return new RacingBetsRepeatedTaskRewardRequest();
		}

		// Token: 0x1700421B RID: 16923
		// (get) Token: 0x06013E08 RID: 81416 RVA: 0x002E5188 File Offset: 0x002E3388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700421C RID: 16924
		// (get) Token: 0x06013E09 RID: 81417 RVA: 0x002E518B File Offset: 0x002E338B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsRepeatedTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x06013E0A RID: 81418 RVA: 0x002E5192 File Offset: 0x002E3392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRepeatedTaskRewardRequest()
		{
		}

		// Token: 0x06013E0B RID: 81419 RVA: 0x002E51A5 File Offset: 0x002E33A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRepeatedTaskRewardRequest(RacingBetsRepeatedTaskRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013E0C RID: 81420 RVA: 0x002E51CF File Offset: 0x002E33CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRepeatedTaskRewardRequest Clone()
		{
			return new RacingBetsRepeatedTaskRewardRequest(this);
		}

		// Token: 0x1700421D RID: 16925
		// (get) Token: 0x06013E0D RID: 81421 RVA: 0x002E51D7 File Offset: 0x002E33D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskId
		{
			get
			{
				return this.taskId_;
			}
		}

		// Token: 0x06013E0E RID: 81422 RVA: 0x002E51DF File Offset: 0x002E33DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsRepeatedTaskRewardRequest);
		}

		// Token: 0x06013E0F RID: 81423 RVA: 0x002E51ED File Offset: 0x002E33ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsRepeatedTaskRewardRequest other)
		{
			return other != null && (other == this || (this.taskId_.Equals(other.taskId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013E10 RID: 81424 RVA: 0x002E5220 File Offset: 0x002E3420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013E11 RID: 81425 RVA: 0x002E5254 File Offset: 0x002E3454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013E12 RID: 81426 RVA: 0x002E5261 File Offset: 0x002E3461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013E13 RID: 81427 RVA: 0x002E526A File Offset: 0x002E346A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskId_.WriteTo(ref output, RacingBetsRepeatedTaskRewardRequest._repeated_taskId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013E14 RID: 81428 RVA: 0x002E5294 File Offset: 0x002E3494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskId_.CalculateSize(RacingBetsRepeatedTaskRewardRequest._repeated_taskId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013E15 RID: 81429 RVA: 0x002E52CD File Offset: 0x002E34CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsRepeatedTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskId_.Add(other.taskId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013E16 RID: 81430 RVA: 0x002E52FB File Offset: 0x002E34FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013E17 RID: 81431 RVA: 0x002E5304 File Offset: 0x002E3504
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
				if (num != 16U && num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskId_.AddEntriesFrom(ref input, RacingBetsRepeatedTaskRewardRequest._repeated_taskId_codec);
				}
			}
		}

		// Token: 0x0400798E RID: 31118
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400798F RID: 31119
		public const int TaskIdFieldNumber = 2;

		// Token: 0x04007990 RID: 31120
		private static readonly FieldCodec<int> _repeated_taskId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04007991 RID: 31121
		private readonly RepeatedField<int> taskId_ = new RepeatedField<int>();
	}
}
