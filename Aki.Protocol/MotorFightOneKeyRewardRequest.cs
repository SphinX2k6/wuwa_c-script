using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A3B RID: 2619
	[NetMessage(EMessageId.MotorFightOneKeyRewardRequest)]
	public sealed class MotorFightOneKeyRewardRequest : IMessage<MotorFightOneKeyRewardRequest>, IMessage, IEquatable<MotorFightOneKeyRewardRequest>, IDeepCloneable<MotorFightOneKeyRewardRequest>, IBufferMessage
	{
		// Token: 0x0600E4F9 RID: 58617 RVA: 0x00217E2B File Offset: 0x0021602B
		[NullableContext(1)]
		public static MotorFightOneKeyRewardRequest Create()
		{
			return new MotorFightOneKeyRewardRequest();
		}

		// Token: 0x17002E6A RID: 11882
		// (get) Token: 0x0600E4FA RID: 58618 RVA: 0x00217E32 File Offset: 0x00216032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E6B RID: 11883
		// (get) Token: 0x0600E4FB RID: 58619 RVA: 0x00217E35 File Offset: 0x00216035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightOneKeyRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600E4FC RID: 58620 RVA: 0x00217E3C File Offset: 0x0021603C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightOneKeyRewardRequest()
		{
		}

		// Token: 0x0600E4FD RID: 58621 RVA: 0x00217E4F File Offset: 0x0021604F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightOneKeyRewardRequest(MotorFightOneKeyRewardRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E4FE RID: 58622 RVA: 0x00217E79 File Offset: 0x00216079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightOneKeyRewardRequest Clone()
		{
			return new MotorFightOneKeyRewardRequest(this);
		}

		// Token: 0x17002E6C RID: 11884
		// (get) Token: 0x0600E4FF RID: 58623 RVA: 0x00217E81 File Offset: 0x00216081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600E500 RID: 58624 RVA: 0x00217E89 File Offset: 0x00216089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightOneKeyRewardRequest);
		}

		// Token: 0x0600E501 RID: 58625 RVA: 0x00217E97 File Offset: 0x00216097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightOneKeyRewardRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E502 RID: 58626 RVA: 0x00217ECC File Offset: 0x002160CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E503 RID: 58627 RVA: 0x00217F00 File Offset: 0x00216100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E504 RID: 58628 RVA: 0x00217F0D File Offset: 0x0021610D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E505 RID: 58629 RVA: 0x00217F16 File Offset: 0x00216116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, MotorFightOneKeyRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E506 RID: 58630 RVA: 0x00217F40 File Offset: 0x00216140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(MotorFightOneKeyRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E507 RID: 58631 RVA: 0x00217F79 File Offset: 0x00216179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightOneKeyRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E508 RID: 58632 RVA: 0x00217FA7 File Offset: 0x002161A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E509 RID: 58633 RVA: 0x00217FB0 File Offset: 0x002161B0
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
					this.taskIds_.AddEntriesFrom(ref input, MotorFightOneKeyRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04005DF7 RID: 24055
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DF8 RID: 24056
		public const int TaskIdsFieldNumber = 2;

		// Token: 0x04005DF9 RID: 24057
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04005DFA RID: 24058
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
