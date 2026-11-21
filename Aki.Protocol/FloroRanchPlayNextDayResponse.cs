using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005AE RID: 1454
	[NetMessage(EMessageId.FloroRanchPlayNextDayResponse)]
	public sealed class FloroRanchPlayNextDayResponse : IMessage<FloroRanchPlayNextDayResponse>, IMessage, IEquatable<FloroRanchPlayNextDayResponse>, IDeepCloneable<FloroRanchPlayNextDayResponse>, IBufferMessage
	{
		// Token: 0x060086EE RID: 34542 RVA: 0x00145BA4 File Offset: 0x00143DA4
		[NullableContext(1)]
		public static FloroRanchPlayNextDayResponse Create()
		{
			return new FloroRanchPlayNextDayResponse();
		}

		// Token: 0x17001A6E RID: 6766
		// (get) Token: 0x060086EF RID: 34543 RVA: 0x00145BAB File Offset: 0x00143DAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A6F RID: 6767
		// (get) Token: 0x060086F0 RID: 34544 RVA: 0x00145BAE File Offset: 0x00143DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayNextDayResponse.Descriptor;
			}
		}

		// Token: 0x060086F1 RID: 34545 RVA: 0x00145BB5 File Offset: 0x00143DB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayNextDayResponse()
		{
		}

		// Token: 0x060086F2 RID: 34546 RVA: 0x00145BC8 File Offset: 0x00143DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayNextDayResponse(FloroRanchPlayNextDayResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060086F3 RID: 34547 RVA: 0x00145BFE File Offset: 0x00143DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayNextDayResponse Clone()
		{
			return new FloroRanchPlayNextDayResponse(this);
		}

		// Token: 0x17001A70 RID: 6768
		// (get) Token: 0x060086F4 RID: 34548 RVA: 0x00145C06 File Offset: 0x00143E06
		// (set) Token: 0x060086F5 RID: 34549 RVA: 0x00145C0E File Offset: 0x00143E0E
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

		// Token: 0x17001A71 RID: 6769
		// (get) Token: 0x060086F6 RID: 34550 RVA: 0x00145C17 File Offset: 0x00143E17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x060086F7 RID: 34551 RVA: 0x00145C1F File Offset: 0x00143E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayNextDayResponse);
		}

		// Token: 0x060086F8 RID: 34552 RVA: 0x00145C30 File Offset: 0x00143E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayNextDayResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060086F9 RID: 34553 RVA: 0x00145C80 File Offset: 0x00143E80
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

		// Token: 0x060086FA RID: 34554 RVA: 0x00145CD3 File Offset: 0x00143ED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060086FB RID: 34555 RVA: 0x00145CE0 File Offset: 0x00143EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060086FC RID: 34556 RVA: 0x00145CEC File Offset: 0x00143EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.task_.WriteTo(ref output, FloroRanchPlayNextDayResponse._repeated_task_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060086FD RID: 34557 RVA: 0x00145D3C File Offset: 0x00143F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.task_.CalculateSize(FloroRanchPlayNextDayResponse._repeated_task_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060086FE RID: 34558 RVA: 0x00145D90 File Offset: 0x00143F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayNextDayResponse other)
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

		// Token: 0x060086FF RID: 34559 RVA: 0x00145DDD File Offset: 0x00143FDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008700 RID: 34560 RVA: 0x00145DE8 File Offset: 0x00143FE8
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
					if (num != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.task_.AddEntriesFrom(ref input, FloroRanchPlayNextDayResponse._repeated_task_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400431D RID: 17181
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400431E RID: 17182
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400431F RID: 17183
		private ErrorCode errorCode_;

		// Token: 0x04004320 RID: 17184
		public const int TaskFieldNumber = 5;

		// Token: 0x04004321 RID: 17185
		private static readonly FieldCodec<FloroRanchPlayTask> _repeated_task_codec = FieldCodec.ForMessage<FloroRanchPlayTask>(42U, FloroRanchPlayTask.Parser);

		// Token: 0x04004322 RID: 17186
		private readonly RepeatedField<FloroRanchPlayTask> task_ = new RepeatedField<FloroRanchPlayTask>();
	}
}
