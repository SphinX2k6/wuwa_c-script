using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EE1 RID: 3809
	[NetMessage(EMessageId.RemoveBuffByIdS2cResponsePush)]
	public sealed class RemoveBuffByIdS2cResponsePush : IMessage<RemoveBuffByIdS2cResponsePush>, IMessage, IEquatable<RemoveBuffByIdS2cResponsePush>, IDeepCloneable<RemoveBuffByIdS2cResponsePush>, IBufferMessage
	{
		// Token: 0x0601470D RID: 83725 RVA: 0x002F905D File Offset: 0x002F725D
		[NullableContext(1)]
		public static RemoveBuffByIdS2cResponsePush Create()
		{
			return new RemoveBuffByIdS2cResponsePush();
		}

		// Token: 0x17004400 RID: 17408
		// (get) Token: 0x0601470E RID: 83726 RVA: 0x002F9064 File Offset: 0x002F7264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004401 RID: 17409
		// (get) Token: 0x0601470F RID: 83727 RVA: 0x002F9067 File Offset: 0x002F7267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveBuffByIdS2cResponsePush.Descriptor;
			}
		}

		// Token: 0x06014710 RID: 83728 RVA: 0x002F906E File Offset: 0x002F726E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffByIdS2cResponsePush()
		{
		}

		// Token: 0x06014711 RID: 83729 RVA: 0x002F9076 File Offset: 0x002F7276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffByIdS2cResponsePush(RemoveBuffByIdS2cResponsePush other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014712 RID: 83730 RVA: 0x002F909B File Offset: 0x002F729B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffByIdS2cResponsePush Clone()
		{
			return new RemoveBuffByIdS2cResponsePush(this);
		}

		// Token: 0x17004402 RID: 17410
		// (get) Token: 0x06014713 RID: 83731 RVA: 0x002F90A3 File Offset: 0x002F72A3
		// (set) Token: 0x06014714 RID: 83732 RVA: 0x002F90AB File Offset: 0x002F72AB
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

		// Token: 0x06014715 RID: 83733 RVA: 0x002F90B4 File Offset: 0x002F72B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveBuffByIdS2cResponsePush);
		}

		// Token: 0x06014716 RID: 83734 RVA: 0x002F90C2 File Offset: 0x002F72C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveBuffByIdS2cResponsePush other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014717 RID: 83735 RVA: 0x002F90F0 File Offset: 0x002F72F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014718 RID: 83736 RVA: 0x002F9135 File Offset: 0x002F7335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014719 RID: 83737 RVA: 0x002F9142 File Offset: 0x002F7342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601471A RID: 83738 RVA: 0x002F914B File Offset: 0x002F734B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601471B RID: 83739 RVA: 0x002F9180 File Offset: 0x002F7380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601471C RID: 83740 RVA: 0x002F91BE File Offset: 0x002F73BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveBuffByIdS2cResponsePush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601471D RID: 83741 RVA: 0x002F91EF File Offset: 0x002F73EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601471E RID: 83742 RVA: 0x002F91F8 File Offset: 0x002F73F8
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007C77 RID: 31863
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C78 RID: 31864
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04007C79 RID: 31865
		private ErrorCode errorCode_;
	}
}
