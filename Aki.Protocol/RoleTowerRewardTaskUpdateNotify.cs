using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010E1 RID: 4321
	[NetMessage(EMessageId.RoleTowerRewardTaskUpdateNotify)]
	public sealed class RoleTowerRewardTaskUpdateNotify : IMessage<RoleTowerRewardTaskUpdateNotify>, IMessage, IEquatable<RoleTowerRewardTaskUpdateNotify>, IDeepCloneable<RoleTowerRewardTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601719C RID: 94620 RVA: 0x0035C725 File Offset: 0x0035A925
		[NullableContext(1)]
		public static RoleTowerRewardTaskUpdateNotify Create()
		{
			return new RoleTowerRewardTaskUpdateNotify();
		}

		// Token: 0x17004D8F RID: 19855
		// (get) Token: 0x0601719D RID: 94621 RVA: 0x0035C72C File Offset: 0x0035A92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D90 RID: 19856
		// (get) Token: 0x0601719E RID: 94622 RVA: 0x0035C72F File Offset: 0x0035A92F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerRewardTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601719F RID: 94623 RVA: 0x0035C736 File Offset: 0x0035A936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRewardTaskUpdateNotify()
		{
		}

		// Token: 0x060171A0 RID: 94624 RVA: 0x0035C749 File Offset: 0x0035A949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRewardTaskUpdateNotify(RoleTowerRewardTaskUpdateNotify other) : this()
		{
			this.limitTasks_ = other.limitTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060171A1 RID: 94625 RVA: 0x0035C773 File Offset: 0x0035A973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRewardTaskUpdateNotify Clone()
		{
			return new RoleTowerRewardTaskUpdateNotify(this);
		}

		// Token: 0x17004D91 RID: 19857
		// (get) Token: 0x060171A2 RID: 94626 RVA: 0x0035C77B File Offset: 0x0035A97B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> LimitTasks
		{
			get
			{
				return this.limitTasks_;
			}
		}

		// Token: 0x060171A3 RID: 94627 RVA: 0x0035C783 File Offset: 0x0035A983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerRewardTaskUpdateNotify);
		}

		// Token: 0x060171A4 RID: 94628 RVA: 0x0035C791 File Offset: 0x0035A991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerRewardTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.limitTasks_.Equals(other.limitTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060171A5 RID: 94629 RVA: 0x0035C7C4 File Offset: 0x0035A9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.limitTasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060171A6 RID: 94630 RVA: 0x0035C7F8 File Offset: 0x0035A9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060171A7 RID: 94631 RVA: 0x0035C805 File Offset: 0x0035AA05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060171A8 RID: 94632 RVA: 0x0035C80E File Offset: 0x0035AA0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.limitTasks_.WriteTo(ref output, RoleTowerRewardTaskUpdateNotify._repeated_limitTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060171A9 RID: 94633 RVA: 0x0035C838 File Offset: 0x0035AA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.limitTasks_.CalculateSize(RoleTowerRewardTaskUpdateNotify._repeated_limitTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060171AA RID: 94634 RVA: 0x0035C871 File Offset: 0x0035AA71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerRewardTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.limitTasks_.Add(other.limitTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060171AB RID: 94635 RVA: 0x0035C89F File Offset: 0x0035AA9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060171AC RID: 94636 RVA: 0x0035C8A8 File Offset: 0x0035AAA8
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.limitTasks_.AddEntriesFrom(ref input, RoleTowerRewardTaskUpdateNotify._repeated_limitTasks_codec);
				}
			}
		}

		// Token: 0x04008A46 RID: 35398
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A47 RID: 35399
		public const int LimitTasksFieldNumber = 7;

		// Token: 0x04008A48 RID: 35400
		private static readonly FieldCodec<ConditionTask> _repeated_limitTasks_codec = FieldCodec.ForMessage<ConditionTask>(58U, ConditionTask.Parser);

		// Token: 0x04008A49 RID: 35401
		private readonly RepeatedField<ConditionTask> limitTasks_ = new RepeatedField<ConditionTask>();
	}
}
