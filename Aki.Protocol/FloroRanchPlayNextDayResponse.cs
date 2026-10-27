using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005C3 RID: 1475
	[NetMessage(EMessageId.FloroRanchPlayNextDayResponse)]
	public sealed class FloroRanchPlayNextDayResponse : IMessage<FloroRanchPlayNextDayResponse>, IMessage, IEquatable<FloroRanchPlayNextDayResponse>, IDeepCloneable<FloroRanchPlayNextDayResponse>, IBufferMessage
	{
		// Token: 0x06008856 RID: 34902 RVA: 0x001487BC File Offset: 0x001469BC
		[NullableContext(1)]
		public static FloroRanchPlayNextDayResponse Create()
		{
			return new FloroRanchPlayNextDayResponse();
		}

		// Token: 0x17001ABB RID: 6843
		// (get) Token: 0x06008857 RID: 34903 RVA: 0x001487C3 File Offset: 0x001469C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001ABC RID: 6844
		// (get) Token: 0x06008858 RID: 34904 RVA: 0x001487C6 File Offset: 0x001469C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayNextDayResponse.Descriptor;
			}
		}

		// Token: 0x06008859 RID: 34905 RVA: 0x001487CD File Offset: 0x001469CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayNextDayResponse()
		{
		}

		// Token: 0x0600885A RID: 34906 RVA: 0x001487E0 File Offset: 0x001469E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayNextDayResponse(FloroRanchPlayNextDayResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600885B RID: 34907 RVA: 0x00148816 File Offset: 0x00146A16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayNextDayResponse Clone()
		{
			return new FloroRanchPlayNextDayResponse(this);
		}

		// Token: 0x17001ABD RID: 6845
		// (get) Token: 0x0600885C RID: 34908 RVA: 0x0014881E File Offset: 0x00146A1E
		// (set) Token: 0x0600885D RID: 34909 RVA: 0x00148826 File Offset: 0x00146A26
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

		// Token: 0x17001ABE RID: 6846
		// (get) Token: 0x0600885E RID: 34910 RVA: 0x0014882F File Offset: 0x00146A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x0600885F RID: 34911 RVA: 0x00148837 File Offset: 0x00146A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayNextDayResponse);
		}

		// Token: 0x06008860 RID: 34912 RVA: 0x00148848 File Offset: 0x00146A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayNextDayResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008861 RID: 34913 RVA: 0x00148898 File Offset: 0x00146A98
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

		// Token: 0x06008862 RID: 34914 RVA: 0x001488EB File Offset: 0x00146AEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008863 RID: 34915 RVA: 0x001488F8 File Offset: 0x00146AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008864 RID: 34916 RVA: 0x00148904 File Offset: 0x00146B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.task_.WriteTo(ref output, FloroRanchPlayNextDayResponse._repeated_task_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008865 RID: 34917 RVA: 0x00148954 File Offset: 0x00146B54
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

		// Token: 0x06008866 RID: 34918 RVA: 0x001489A8 File Offset: 0x00146BA8
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

		// Token: 0x06008867 RID: 34919 RVA: 0x001489F5 File Offset: 0x00146BF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008868 RID: 34920 RVA: 0x00148A00 File Offset: 0x00146C00
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
				if (num != 58U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.task_.AddEntriesFrom(ref input, FloroRanchPlayNextDayResponse._repeated_task_codec);
				}
			}
		}

		// Token: 0x04004327 RID: 17191
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004328 RID: 17192
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04004329 RID: 17193
		private ErrorCode errorCode_;

		// Token: 0x0400432A RID: 17194
		public const int TaskFieldNumber = 7;

		// Token: 0x0400432B RID: 17195
		private static readonly FieldCodec<FloroRanchPlayTask> _repeated_task_codec = FieldCodec.ForMessage<FloroRanchPlayTask>(58U, FloroRanchPlayTask.Parser);

		// Token: 0x0400432C RID: 17196
		private readonly RepeatedField<FloroRanchPlayTask> task_ = new RepeatedField<FloroRanchPlayTask>();
	}
}
