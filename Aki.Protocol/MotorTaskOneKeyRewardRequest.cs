using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A93 RID: 2707
	[NetMessage(EMessageId.MotorTaskOneKeyRewardRequest)]
	public sealed class MotorTaskOneKeyRewardRequest : IMessage<MotorTaskOneKeyRewardRequest>, IMessage, IEquatable<MotorTaskOneKeyRewardRequest>, IDeepCloneable<MotorTaskOneKeyRewardRequest>, IBufferMessage
	{
		// Token: 0x0600EC09 RID: 60425 RVA: 0x00227C3D File Offset: 0x00225E3D
		[NullableContext(1)]
		public static MotorTaskOneKeyRewardRequest Create()
		{
			return new MotorTaskOneKeyRewardRequest();
		}

		// Token: 0x17002FED RID: 12269
		// (get) Token: 0x0600EC0A RID: 60426 RVA: 0x00227C44 File Offset: 0x00225E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FEE RID: 12270
		// (get) Token: 0x0600EC0B RID: 60427 RVA: 0x00227C47 File Offset: 0x00225E47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTaskOneKeyRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600EC0C RID: 60428 RVA: 0x00227C4E File Offset: 0x00225E4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskOneKeyRewardRequest()
		{
		}

		// Token: 0x0600EC0D RID: 60429 RVA: 0x00227C61 File Offset: 0x00225E61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskOneKeyRewardRequest(MotorTaskOneKeyRewardRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EC0E RID: 60430 RVA: 0x00227C8B File Offset: 0x00225E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskOneKeyRewardRequest Clone()
		{
			return new MotorTaskOneKeyRewardRequest(this);
		}

		// Token: 0x17002FEF RID: 12271
		// (get) Token: 0x0600EC0F RID: 60431 RVA: 0x00227C93 File Offset: 0x00225E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600EC10 RID: 60432 RVA: 0x00227C9B File Offset: 0x00225E9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTaskOneKeyRewardRequest);
		}

		// Token: 0x0600EC11 RID: 60433 RVA: 0x00227CA9 File Offset: 0x00225EA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTaskOneKeyRewardRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EC12 RID: 60434 RVA: 0x00227CDC File Offset: 0x00225EDC
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

		// Token: 0x0600EC13 RID: 60435 RVA: 0x00227D10 File Offset: 0x00225F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EC14 RID: 60436 RVA: 0x00227D1D File Offset: 0x00225F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EC15 RID: 60437 RVA: 0x00227D26 File Offset: 0x00225F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, MotorTaskOneKeyRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EC16 RID: 60438 RVA: 0x00227D50 File Offset: 0x00225F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(MotorTaskOneKeyRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EC17 RID: 60439 RVA: 0x00227D89 File Offset: 0x00225F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorTaskOneKeyRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EC18 RID: 60440 RVA: 0x00227DB7 File Offset: 0x00225FB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EC19 RID: 60441 RVA: 0x00227DC0 File Offset: 0x00225FC0
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
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, MotorTaskOneKeyRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x0400601C RID: 24604
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400601D RID: 24605
		public const int TaskIdsFieldNumber = 9;

		// Token: 0x0400601E RID: 24606
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x0400601F RID: 24607
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
