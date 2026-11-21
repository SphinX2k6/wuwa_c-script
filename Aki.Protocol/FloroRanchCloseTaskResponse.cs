using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000596 RID: 1430
	[NetMessage(EMessageId.FloroRanchCloseTaskResponse)]
	public sealed class FloroRanchCloseTaskResponse : IMessage<FloroRanchCloseTaskResponse>, IMessage, IEquatable<FloroRanchCloseTaskResponse>, IDeepCloneable<FloroRanchCloseTaskResponse>, IBufferMessage
	{
		// Token: 0x060084B5 RID: 33973 RVA: 0x0013F886 File Offset: 0x0013DA86
		[NullableContext(1)]
		public static FloroRanchCloseTaskResponse Create()
		{
			return new FloroRanchCloseTaskResponse();
		}

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x060084B6 RID: 33974 RVA: 0x0013F88D File Offset: 0x0013DA8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x060084B7 RID: 33975 RVA: 0x0013F890 File Offset: 0x0013DA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchCloseTaskResponse.Descriptor;
			}
		}

		// Token: 0x060084B8 RID: 33976 RVA: 0x0013F897 File Offset: 0x0013DA97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchCloseTaskResponse()
		{
		}

		// Token: 0x060084B9 RID: 33977 RVA: 0x0013F8AA File Offset: 0x0013DAAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchCloseTaskResponse(FloroRanchCloseTaskResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060084BA RID: 33978 RVA: 0x0013F8E0 File Offset: 0x0013DAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchCloseTaskResponse Clone()
		{
			return new FloroRanchCloseTaskResponse(this);
		}

		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x060084BB RID: 33979 RVA: 0x0013F8E8 File Offset: 0x0013DAE8
		// (set) Token: 0x060084BC RID: 33980 RVA: 0x0013F8F0 File Offset: 0x0013DAF0
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

		// Token: 0x170019DD RID: 6621
		// (get) Token: 0x060084BD RID: 33981 RVA: 0x0013F8F9 File Offset: 0x0013DAF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x060084BE RID: 33982 RVA: 0x0013F901 File Offset: 0x0013DB01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchCloseTaskResponse);
		}

		// Token: 0x060084BF RID: 33983 RVA: 0x0013F910 File Offset: 0x0013DB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchCloseTaskResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060084C0 RID: 33984 RVA: 0x0013F960 File Offset: 0x0013DB60
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

		// Token: 0x060084C1 RID: 33985 RVA: 0x0013F9B3 File Offset: 0x0013DBB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060084C2 RID: 33986 RVA: 0x0013F9C0 File Offset: 0x0013DBC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060084C3 RID: 33987 RVA: 0x0013F9CC File Offset: 0x0013DBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.task_.WriteTo(ref output, FloroRanchCloseTaskResponse._repeated_task_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060084C4 RID: 33988 RVA: 0x0013FA1C File Offset: 0x0013DC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.task_.CalculateSize(FloroRanchCloseTaskResponse._repeated_task_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060084C5 RID: 33989 RVA: 0x0013FA70 File Offset: 0x0013DC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchCloseTaskResponse other)
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

		// Token: 0x060084C6 RID: 33990 RVA: 0x0013FABD File Offset: 0x0013DCBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060084C7 RID: 33991 RVA: 0x0013FAC8 File Offset: 0x0013DCC8
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
				if (num != 16U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.task_.AddEntriesFrom(ref input, FloroRanchCloseTaskResponse._repeated_task_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004224 RID: 16932
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004225 RID: 16933
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04004226 RID: 16934
		private ErrorCode errorCode_;

		// Token: 0x04004227 RID: 16935
		public const int TaskFieldNumber = 13;

		// Token: 0x04004228 RID: 16936
		private static readonly FieldCodec<FloroRanchPlayTask> _repeated_task_codec = FieldCodec.ForMessage<FloroRanchPlayTask>(106U, FloroRanchPlayTask.Parser);

		// Token: 0x04004229 RID: 16937
		private readonly RepeatedField<FloroRanchPlayTask> task_ = new RepeatedField<FloroRanchPlayTask>();
	}
}
