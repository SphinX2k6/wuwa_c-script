using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200059A RID: 1434
	[NetMessage(EMessageId.FloroRanchEventChoiceResponse)]
	public sealed class FloroRanchEventChoiceResponse : IMessage<FloroRanchEventChoiceResponse>, IMessage, IEquatable<FloroRanchEventChoiceResponse>, IDeepCloneable<FloroRanchEventChoiceResponse>, IBufferMessage
	{
		// Token: 0x06008512 RID: 34066 RVA: 0x001407C4 File Offset: 0x0013E9C4
		[NullableContext(1)]
		public static FloroRanchEventChoiceResponse Create()
		{
			return new FloroRanchEventChoiceResponse();
		}

		// Token: 0x170019F1 RID: 6641
		// (get) Token: 0x06008513 RID: 34067 RVA: 0x001407CB File Offset: 0x0013E9CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019F2 RID: 6642
		// (get) Token: 0x06008514 RID: 34068 RVA: 0x001407CE File Offset: 0x0013E9CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchEventChoiceResponse.Descriptor;
			}
		}

		// Token: 0x06008515 RID: 34069 RVA: 0x001407D5 File Offset: 0x0013E9D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchEventChoiceResponse()
		{
		}

		// Token: 0x06008516 RID: 34070 RVA: 0x001407E8 File Offset: 0x0013E9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchEventChoiceResponse(FloroRanchEventChoiceResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008517 RID: 34071 RVA: 0x0014081E File Offset: 0x0013EA1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchEventChoiceResponse Clone()
		{
			return new FloroRanchEventChoiceResponse(this);
		}

		// Token: 0x170019F3 RID: 6643
		// (get) Token: 0x06008518 RID: 34072 RVA: 0x00140826 File Offset: 0x0013EA26
		// (set) Token: 0x06008519 RID: 34073 RVA: 0x0014082E File Offset: 0x0013EA2E
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

		// Token: 0x170019F4 RID: 6644
		// (get) Token: 0x0600851A RID: 34074 RVA: 0x00140837 File Offset: 0x0013EA37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x0600851B RID: 34075 RVA: 0x0014083F File Offset: 0x0013EA3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchEventChoiceResponse);
		}

		// Token: 0x0600851C RID: 34076 RVA: 0x00140850 File Offset: 0x0013EA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchEventChoiceResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600851D RID: 34077 RVA: 0x001408A0 File Offset: 0x0013EAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.task_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600851E RID: 34078 RVA: 0x001408F3 File Offset: 0x0013EAF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600851F RID: 34079 RVA: 0x00140900 File Offset: 0x0013EB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008520 RID: 34080 RVA: 0x0014090C File Offset: 0x0013EB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.task_.WriteTo(ref output, FloroRanchEventChoiceResponse._repeated_task_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008521 RID: 34081 RVA: 0x0014095C File Offset: 0x0013EB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.task_.CalculateSize(FloroRanchEventChoiceResponse._repeated_task_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008522 RID: 34082 RVA: 0x001409B0 File Offset: 0x0013EBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchEventChoiceResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.task_.Add(other.task_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008523 RID: 34083 RVA: 0x001409FD File Offset: 0x0013EBFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008524 RID: 34084 RVA: 0x00140A08 File Offset: 0x0013EC08
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
				if (num != 24U)
				{
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.task_.AddEntriesFrom(ref input, FloroRanchEventChoiceResponse._repeated_task_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400424A RID: 16970
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400424B RID: 16971
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400424C RID: 16972
		private ErrorCode errorCode_;

		// Token: 0x0400424D RID: 16973
		public const int TaskFieldNumber = 7;

		// Token: 0x0400424E RID: 16974
		private static readonly FieldCodec<FloroRanchPlayTask> _repeated_task_codec = FieldCodec.ForMessage<FloroRanchPlayTask>(58U, FloroRanchPlayTask.Parser);

		// Token: 0x0400424F RID: 16975
		private readonly RepeatedField<FloroRanchPlayTask> task_ = new RepeatedField<FloroRanchPlayTask>();
	}
}
