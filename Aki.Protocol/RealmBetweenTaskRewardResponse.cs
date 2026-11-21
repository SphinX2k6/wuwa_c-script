using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E94 RID: 3732
	[NetMessage(EMessageId.RealmBetweenTaskRewardResponse)]
	public sealed class RealmBetweenTaskRewardResponse : IMessage<RealmBetweenTaskRewardResponse>, IMessage, IEquatable<RealmBetweenTaskRewardResponse>, IDeepCloneable<RealmBetweenTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x060140FB RID: 82171 RVA: 0x002EC1FC File Offset: 0x002EA3FC
		[NullableContext(1)]
		public static RealmBetweenTaskRewardResponse Create()
		{
			return new RealmBetweenTaskRewardResponse();
		}

		// Token: 0x170042C0 RID: 17088
		// (get) Token: 0x060140FC RID: 82172 RVA: 0x002EC203 File Offset: 0x002EA403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042C1 RID: 17089
		// (get) Token: 0x060140FD RID: 82173 RVA: 0x002EC206 File Offset: 0x002EA406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RealmBetweenTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x060140FE RID: 82174 RVA: 0x002EC20D File Offset: 0x002EA40D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenTaskRewardResponse()
		{
		}

		// Token: 0x060140FF RID: 82175 RVA: 0x002EC220 File Offset: 0x002EA420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenTaskRewardResponse(RealmBetweenTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014100 RID: 82176 RVA: 0x002EC256 File Offset: 0x002EA456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenTaskRewardResponse Clone()
		{
			return new RealmBetweenTaskRewardResponse(this);
		}

		// Token: 0x170042C2 RID: 17090
		// (get) Token: 0x06014101 RID: 82177 RVA: 0x002EC25E File Offset: 0x002EA45E
		// (set) Token: 0x06014102 RID: 82178 RVA: 0x002EC266 File Offset: 0x002EA466
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

		// Token: 0x170042C3 RID: 17091
		// (get) Token: 0x06014103 RID: 82179 RVA: 0x002EC26F File Offset: 0x002EA46F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x06014104 RID: 82180 RVA: 0x002EC277 File Offset: 0x002EA477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RealmBetweenTaskRewardResponse);
		}

		// Token: 0x06014105 RID: 82181 RVA: 0x002EC288 File Offset: 0x002EA488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RealmBetweenTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014106 RID: 82182 RVA: 0x002EC2D8 File Offset: 0x002EA4D8
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

		// Token: 0x06014107 RID: 82183 RVA: 0x002EC32B File Offset: 0x002EA52B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014108 RID: 82184 RVA: 0x002EC338 File Offset: 0x002EA538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014109 RID: 82185 RVA: 0x002EC344 File Offset: 0x002EA544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.taskIds_.WriteTo(ref output, RealmBetweenTaskRewardResponse._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601410A RID: 82186 RVA: 0x002EC394 File Offset: 0x002EA594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.taskIds_.CalculateSize(RealmBetweenTaskRewardResponse._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601410B RID: 82187 RVA: 0x002EC3E8 File Offset: 0x002EA5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RealmBetweenTaskRewardResponse other)
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

		// Token: 0x0601410C RID: 82188 RVA: 0x002EC435 File Offset: 0x002EA635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601410D RID: 82189 RVA: 0x002EC440 File Offset: 0x002EA640
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
				if (num != 8U)
				{
					if (num != 56U && num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.taskIds_.AddEntriesFrom(ref input, RealmBetweenTaskRewardResponse._repeated_taskIds_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007AC2 RID: 31426
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AC3 RID: 31427
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04007AC4 RID: 31428
		private ErrorCode errorCode_;

		// Token: 0x04007AC5 RID: 31429
		public const int TaskIdsFieldNumber = 7;

		// Token: 0x04007AC6 RID: 31430
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04007AC7 RID: 31431
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
