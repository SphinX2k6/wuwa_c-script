using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005AF RID: 1455
	[NetMessage(EMessageId.FloroRanchEventChoiceResponse)]
	public sealed class FloroRanchEventChoiceResponse : IMessage<FloroRanchEventChoiceResponse>, IMessage, IEquatable<FloroRanchEventChoiceResponse>, IDeepCloneable<FloroRanchEventChoiceResponse>, IBufferMessage
	{
		// Token: 0x0600867A RID: 34426 RVA: 0x001433D5 File Offset: 0x001415D5
		[NullableContext(1)]
		public static FloroRanchEventChoiceResponse Create()
		{
			return new FloroRanchEventChoiceResponse();
		}

		// Token: 0x17001A3E RID: 6718
		// (get) Token: 0x0600867B RID: 34427 RVA: 0x001433DC File Offset: 0x001415DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A3F RID: 6719
		// (get) Token: 0x0600867C RID: 34428 RVA: 0x001433DF File Offset: 0x001415DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchEventChoiceResponse.Descriptor;
			}
		}

		// Token: 0x0600867D RID: 34429 RVA: 0x001433E6 File Offset: 0x001415E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchEventChoiceResponse()
		{
		}

		// Token: 0x0600867E RID: 34430 RVA: 0x001433F9 File Offset: 0x001415F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchEventChoiceResponse(FloroRanchEventChoiceResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600867F RID: 34431 RVA: 0x0014342F File Offset: 0x0014162F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchEventChoiceResponse Clone()
		{
			return new FloroRanchEventChoiceResponse(this);
		}

		// Token: 0x17001A40 RID: 6720
		// (get) Token: 0x06008680 RID: 34432 RVA: 0x00143437 File Offset: 0x00141637
		// (set) Token: 0x06008681 RID: 34433 RVA: 0x0014343F File Offset: 0x0014163F
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

		// Token: 0x17001A41 RID: 6721
		// (get) Token: 0x06008682 RID: 34434 RVA: 0x00143448 File Offset: 0x00141648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x06008683 RID: 34435 RVA: 0x00143450 File Offset: 0x00141650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchEventChoiceResponse);
		}

		// Token: 0x06008684 RID: 34436 RVA: 0x00143460 File Offset: 0x00141660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchEventChoiceResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008685 RID: 34437 RVA: 0x001434B0 File Offset: 0x001416B0
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

		// Token: 0x06008686 RID: 34438 RVA: 0x00143503 File Offset: 0x00141703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008687 RID: 34439 RVA: 0x00143510 File Offset: 0x00141710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008688 RID: 34440 RVA: 0x0014351C File Offset: 0x0014171C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.task_.WriteTo(ref output, FloroRanchEventChoiceResponse._repeated_task_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008689 RID: 34441 RVA: 0x0014356C File Offset: 0x0014176C
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

		// Token: 0x0600868A RID: 34442 RVA: 0x001435C0 File Offset: 0x001417C0
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

		// Token: 0x0600868B RID: 34443 RVA: 0x0014360D File Offset: 0x0014180D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600868C RID: 34444 RVA: 0x00143618 File Offset: 0x00141818
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
				if (num != 40U)
				{
					if (num != 98U)
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

		// Token: 0x04004254 RID: 16980
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004255 RID: 16981
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04004256 RID: 16982
		private ErrorCode errorCode_;

		// Token: 0x04004257 RID: 16983
		public const int TaskFieldNumber = 12;

		// Token: 0x04004258 RID: 16984
		private static readonly FieldCodec<FloroRanchPlayTask> _repeated_task_codec = FieldCodec.ForMessage<FloroRanchPlayTask>(98U, FloroRanchPlayTask.Parser);

		// Token: 0x04004259 RID: 16985
		private readonly RepeatedField<FloroRanchPlayTask> task_ = new RepeatedField<FloroRanchPlayTask>();
	}
}
