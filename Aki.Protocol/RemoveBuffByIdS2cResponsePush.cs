using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EF1 RID: 3825
	[NetMessage(EMessageId.RemoveBuffByIdS2cResponsePush)]
	public sealed class RemoveBuffByIdS2cResponsePush : IMessage<RemoveBuffByIdS2cResponsePush>, IMessage, IEquatable<RemoveBuffByIdS2cResponsePush>, IDeepCloneable<RemoveBuffByIdS2cResponsePush>, IBufferMessage
	{
		// Token: 0x060147F2 RID: 83954 RVA: 0x002FA711 File Offset: 0x002F8911
		[NullableContext(1)]
		public static RemoveBuffByIdS2cResponsePush Create()
		{
			return new RemoveBuffByIdS2cResponsePush();
		}

		// Token: 0x1700442A RID: 17450
		// (get) Token: 0x060147F3 RID: 83955 RVA: 0x002FA718 File Offset: 0x002F8918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700442B RID: 17451
		// (get) Token: 0x060147F4 RID: 83956 RVA: 0x002FA71B File Offset: 0x002F891B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveBuffByIdS2cResponsePush.Descriptor;
			}
		}

		// Token: 0x060147F5 RID: 83957 RVA: 0x002FA722 File Offset: 0x002F8922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffByIdS2cResponsePush()
		{
		}

		// Token: 0x060147F6 RID: 83958 RVA: 0x002FA72A File Offset: 0x002F892A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffByIdS2cResponsePush(RemoveBuffByIdS2cResponsePush other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060147F7 RID: 83959 RVA: 0x002FA74F File Offset: 0x002F894F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffByIdS2cResponsePush Clone()
		{
			return new RemoveBuffByIdS2cResponsePush(this);
		}

		// Token: 0x1700442C RID: 17452
		// (get) Token: 0x060147F8 RID: 83960 RVA: 0x002FA757 File Offset: 0x002F8957
		// (set) Token: 0x060147F9 RID: 83961 RVA: 0x002FA75F File Offset: 0x002F895F
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

		// Token: 0x060147FA RID: 83962 RVA: 0x002FA768 File Offset: 0x002F8968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveBuffByIdS2cResponsePush);
		}

		// Token: 0x060147FB RID: 83963 RVA: 0x002FA776 File Offset: 0x002F8976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveBuffByIdS2cResponsePush other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060147FC RID: 83964 RVA: 0x002FA7A4 File Offset: 0x002F89A4
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

		// Token: 0x060147FD RID: 83965 RVA: 0x002FA7E9 File Offset: 0x002F89E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060147FE RID: 83966 RVA: 0x002FA7F6 File Offset: 0x002F89F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060147FF RID: 83967 RVA: 0x002FA7FF File Offset: 0x002F89FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x06014800 RID: 83968 RVA: 0x002FA834 File Offset: 0x002F8A34
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

		// Token: 0x06014801 RID: 83969 RVA: 0x002FA872 File Offset: 0x002F8A72
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

		// Token: 0x06014802 RID: 83970 RVA: 0x002FA8A3 File Offset: 0x002F8AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014803 RID: 83971 RVA: 0x002FA8AC File Offset: 0x002F8AAC
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007C4D RID: 31821
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C4E RID: 31822
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04007C4F RID: 31823
		private ErrorCode errorCode_;
	}
}
