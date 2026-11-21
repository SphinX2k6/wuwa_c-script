using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E92 RID: 3730
	[NetMessage(EMessageId.RealmBetweenMotorRewardResponse)]
	public sealed class RealmBetweenMotorRewardResponse : IMessage<RealmBetweenMotorRewardResponse>, IMessage, IEquatable<RealmBetweenMotorRewardResponse>, IDeepCloneable<RealmBetweenMotorRewardResponse>, IBufferMessage
	{
		// Token: 0x060140D5 RID: 82133 RVA: 0x002EBD69 File Offset: 0x002E9F69
		[NullableContext(1)]
		public static RealmBetweenMotorRewardResponse Create()
		{
			return new RealmBetweenMotorRewardResponse();
		}

		// Token: 0x170042B9 RID: 17081
		// (get) Token: 0x060140D6 RID: 82134 RVA: 0x002EBD70 File Offset: 0x002E9F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042BA RID: 17082
		// (get) Token: 0x060140D7 RID: 82135 RVA: 0x002EBD73 File Offset: 0x002E9F73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RealmBetweenMotorRewardResponse.Descriptor;
			}
		}

		// Token: 0x060140D8 RID: 82136 RVA: 0x002EBD7A File Offset: 0x002E9F7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenMotorRewardResponse()
		{
		}

		// Token: 0x060140D9 RID: 82137 RVA: 0x002EBD8D File Offset: 0x002E9F8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenMotorRewardResponse(RealmBetweenMotorRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060140DA RID: 82138 RVA: 0x002EBDC3 File Offset: 0x002E9FC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenMotorRewardResponse Clone()
		{
			return new RealmBetweenMotorRewardResponse(this);
		}

		// Token: 0x170042BB RID: 17083
		// (get) Token: 0x060140DB RID: 82139 RVA: 0x002EBDCB File Offset: 0x002E9FCB
		// (set) Token: 0x060140DC RID: 82140 RVA: 0x002EBDD3 File Offset: 0x002E9FD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170042BC RID: 17084
		// (get) Token: 0x060140DD RID: 82141 RVA: 0x002EBDDC File Offset: 0x002E9FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x060140DE RID: 82142 RVA: 0x002EBDE4 File Offset: 0x002E9FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RealmBetweenMotorRewardResponse);
		}

		// Token: 0x060140DF RID: 82143 RVA: 0x002EBDF4 File Offset: 0x002E9FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RealmBetweenMotorRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060140E0 RID: 82144 RVA: 0x002EBE44 File Offset: 0x002EA044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060140E1 RID: 82145 RVA: 0x002EBE97 File Offset: 0x002EA097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060140E2 RID: 82146 RVA: 0x002EBEA4 File Offset: 0x002EA0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060140E3 RID: 82147 RVA: 0x002EBEB0 File Offset: 0x002EA0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.taskIds_.WriteTo(ref output, RealmBetweenMotorRewardResponse._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060140E4 RID: 82148 RVA: 0x002EBF00 File Offset: 0x002EA100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.taskIds_.CalculateSize(RealmBetweenMotorRewardResponse._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060140E5 RID: 82149 RVA: 0x002EBF54 File Offset: 0x002EA154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RealmBetweenMotorRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060140E6 RID: 82150 RVA: 0x002EBFA1 File Offset: 0x002EA1A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060140E7 RID: 82151 RVA: 0x002EBFAC File Offset: 0x002EA1AC
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
				if (num != 64U)
				{
					if (num != 80U && num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.taskIds_.AddEntriesFrom(ref input, RealmBetweenMotorRewardResponse._repeated_taskIds_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007AB8 RID: 31416
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AB9 RID: 31417
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04007ABA RID: 31418
		private ErrorCode errorCode_;

		// Token: 0x04007ABB RID: 31419
		public const int TaskIdsFieldNumber = 10;

		// Token: 0x04007ABC RID: 31420
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04007ABD RID: 31421
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
