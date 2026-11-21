using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000412 RID: 1042
	[NetMessage(EMessageId.EdgeRunnerTaskRewardRequest)]
	public sealed class EdgeRunnerTaskRewardRequest : IMessage<EdgeRunnerTaskRewardRequest>, IMessage, IEquatable<EdgeRunnerTaskRewardRequest>, IDeepCloneable<EdgeRunnerTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x060064B7 RID: 25783 RVA: 0x000F2E61 File Offset: 0x000F1061
		[NullableContext(1)]
		public static EdgeRunnerTaskRewardRequest Create()
		{
			return new EdgeRunnerTaskRewardRequest();
		}

		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x060064B8 RID: 25784 RVA: 0x000F2E68 File Offset: 0x000F1068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x060064B9 RID: 25785 RVA: 0x000F2E6B File Offset: 0x000F106B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdgeRunnerTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x060064BA RID: 25786 RVA: 0x000F2E72 File Offset: 0x000F1072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerTaskRewardRequest()
		{
		}

		// Token: 0x060064BB RID: 25787 RVA: 0x000F2E85 File Offset: 0x000F1085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerTaskRewardRequest(EdgeRunnerTaskRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060064BC RID: 25788 RVA: 0x000F2EBB File Offset: 0x000F10BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerTaskRewardRequest Clone()
		{
			return new EdgeRunnerTaskRewardRequest(this);
		}

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x060064BD RID: 25789 RVA: 0x000F2EC3 File Offset: 0x000F10C3
		// (set) Token: 0x060064BE RID: 25790 RVA: 0x000F2ECB File Offset: 0x000F10CB
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

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x060064BF RID: 25791 RVA: 0x000F2ED4 File Offset: 0x000F10D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x060064C0 RID: 25792 RVA: 0x000F2EDC File Offset: 0x000F10DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdgeRunnerTaskRewardRequest);
		}

		// Token: 0x060064C1 RID: 25793 RVA: 0x000F2EEC File Offset: 0x000F10EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdgeRunnerTaskRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060064C2 RID: 25794 RVA: 0x000F2F3C File Offset: 0x000F113C
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

		// Token: 0x060064C3 RID: 25795 RVA: 0x000F2F89 File Offset: 0x000F1189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060064C4 RID: 25796 RVA: 0x000F2F96 File Offset: 0x000F1196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060064C5 RID: 25797 RVA: 0x000F2FA0 File Offset: 0x000F11A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, EdgeRunnerTaskRewardRequest._repeated_taskIds_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060064C6 RID: 25798 RVA: 0x000F2FF0 File Offset: 0x000F11F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.taskIds_.CalculateSize(EdgeRunnerTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060064C7 RID: 25799 RVA: 0x000F3044 File Offset: 0x000F1244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EdgeRunnerTaskRewardRequest other)
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

		// Token: 0x060064C8 RID: 25800 RVA: 0x000F3091 File Offset: 0x000F1291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060064C9 RID: 25801 RVA: 0x000F309C File Offset: 0x000F129C
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
				if (num != 48U && num != 50U)
				{
					if (num != 64U)
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
					this.taskIds_.AddEntriesFrom(ref input, EdgeRunnerTaskRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04003906 RID: 14598
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003907 RID: 14599
		public const int ActivityIdFieldNumber = 8;

		// Token: 0x04003908 RID: 14600
		private int activityId_;

		// Token: 0x04003909 RID: 14601
		public const int TaskIdsFieldNumber = 6;

		// Token: 0x0400390A RID: 14602
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x0400390B RID: 14603
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
