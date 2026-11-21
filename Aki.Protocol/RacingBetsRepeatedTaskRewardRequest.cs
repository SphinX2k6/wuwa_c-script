using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E64 RID: 3684
	[NetMessage(EMessageId.RacingBetsRepeatedTaskRewardRequest)]
	public sealed class RacingBetsRepeatedTaskRewardRequest : IMessage<RacingBetsRepeatedTaskRewardRequest>, IMessage, IEquatable<RacingBetsRepeatedTaskRewardRequest>, IDeepCloneable<RacingBetsRepeatedTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x06013D22 RID: 81186 RVA: 0x002E3AC1 File Offset: 0x002E1CC1
		[NullableContext(1)]
		public static RacingBetsRepeatedTaskRewardRequest Create()
		{
			return new RacingBetsRepeatedTaskRewardRequest();
		}

		// Token: 0x170041F1 RID: 16881
		// (get) Token: 0x06013D23 RID: 81187 RVA: 0x002E3AC8 File Offset: 0x002E1CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041F2 RID: 16882
		// (get) Token: 0x06013D24 RID: 81188 RVA: 0x002E3ACB File Offset: 0x002E1CCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsRepeatedTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x06013D25 RID: 81189 RVA: 0x002E3AD2 File Offset: 0x002E1CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRepeatedTaskRewardRequest()
		{
		}

		// Token: 0x06013D26 RID: 81190 RVA: 0x002E3AE5 File Offset: 0x002E1CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRepeatedTaskRewardRequest(RacingBetsRepeatedTaskRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013D27 RID: 81191 RVA: 0x002E3B0F File Offset: 0x002E1D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRepeatedTaskRewardRequest Clone()
		{
			return new RacingBetsRepeatedTaskRewardRequest(this);
		}

		// Token: 0x170041F3 RID: 16883
		// (get) Token: 0x06013D28 RID: 81192 RVA: 0x002E3B17 File Offset: 0x002E1D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskId
		{
			get
			{
				return this.taskId_;
			}
		}

		// Token: 0x06013D29 RID: 81193 RVA: 0x002E3B1F File Offset: 0x002E1D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsRepeatedTaskRewardRequest);
		}

		// Token: 0x06013D2A RID: 81194 RVA: 0x002E3B2D File Offset: 0x002E1D2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsRepeatedTaskRewardRequest other)
		{
			return other != null && (other == this || (this.taskId_.Equals(other.taskId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013D2B RID: 81195 RVA: 0x002E3B60 File Offset: 0x002E1D60
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

		// Token: 0x06013D2C RID: 81196 RVA: 0x002E3B94 File Offset: 0x002E1D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013D2D RID: 81197 RVA: 0x002E3BA1 File Offset: 0x002E1DA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013D2E RID: 81198 RVA: 0x002E3BAA File Offset: 0x002E1DAA
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

		// Token: 0x06013D2F RID: 81199 RVA: 0x002E3BD4 File Offset: 0x002E1DD4
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

		// Token: 0x06013D30 RID: 81200 RVA: 0x002E3C0D File Offset: 0x002E1E0D
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

		// Token: 0x06013D31 RID: 81201 RVA: 0x002E3C3B File Offset: 0x002E1E3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013D32 RID: 81202 RVA: 0x002E3C44 File Offset: 0x002E1E44
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
				if (num != 104U && num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskId_.AddEntriesFrom(ref input, RacingBetsRepeatedTaskRewardRequest._repeated_taskId_codec);
				}
			}
		}

		// Token: 0x040079B8 RID: 31160
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079B9 RID: 31161
		public const int TaskIdFieldNumber = 13;

		// Token: 0x040079BA RID: 31162
		private static readonly FieldCodec<int> _repeated_taskId_codec = FieldCodec.ForInt32(106U);

		// Token: 0x040079BB RID: 31163
		private readonly RepeatedField<int> taskId_ = new RepeatedField<int>();
	}
}
