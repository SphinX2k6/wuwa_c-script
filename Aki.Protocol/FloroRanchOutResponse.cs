using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005B6 RID: 1462
	[NetMessage(EMessageId.FloroRanchOutResponse)]
	public sealed class FloroRanchOutResponse : IMessage<FloroRanchOutResponse>, IMessage, IEquatable<FloroRanchOutResponse>, IDeepCloneable<FloroRanchOutResponse>, IBufferMessage
	{
		// Token: 0x0600870B RID: 34571 RVA: 0x00144828 File Offset: 0x00142A28
		[NullableContext(1)]
		public static FloroRanchOutResponse Create()
		{
			return new FloroRanchOutResponse();
		}

		// Token: 0x17001A5D RID: 6749
		// (get) Token: 0x0600870C RID: 34572 RVA: 0x0014482F File Offset: 0x00142A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A5E RID: 6750
		// (get) Token: 0x0600870D RID: 34573 RVA: 0x00144832 File Offset: 0x00142A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchOutResponse.Descriptor;
			}
		}

		// Token: 0x0600870E RID: 34574 RVA: 0x00144839 File Offset: 0x00142A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchOutResponse()
		{
		}

		// Token: 0x0600870F RID: 34575 RVA: 0x00144841 File Offset: 0x00142A41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchOutResponse(FloroRanchOutResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008710 RID: 34576 RVA: 0x00144866 File Offset: 0x00142A66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchOutResponse Clone()
		{
			return new FloroRanchOutResponse(this);
		}

		// Token: 0x17001A5F RID: 6751
		// (get) Token: 0x06008711 RID: 34577 RVA: 0x0014486E File Offset: 0x00142A6E
		// (set) Token: 0x06008712 RID: 34578 RVA: 0x00144876 File Offset: 0x00142A76
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

		// Token: 0x06008713 RID: 34579 RVA: 0x0014487F File Offset: 0x00142A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchOutResponse);
		}

		// Token: 0x06008714 RID: 34580 RVA: 0x0014488D File Offset: 0x00142A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchOutResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008715 RID: 34581 RVA: 0x001448BC File Offset: 0x00142ABC
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

		// Token: 0x06008716 RID: 34582 RVA: 0x00144901 File Offset: 0x00142B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008717 RID: 34583 RVA: 0x0014490E File Offset: 0x00142B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008718 RID: 34584 RVA: 0x00144917 File Offset: 0x00142B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008719 RID: 34585 RVA: 0x0014494C File Offset: 0x00142B4C
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

		// Token: 0x0600871A RID: 34586 RVA: 0x0014498A File Offset: 0x00142B8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchOutResponse other)
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

		// Token: 0x0600871B RID: 34587 RVA: 0x001449BB File Offset: 0x00142BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600871C RID: 34588 RVA: 0x001449C4 File Offset: 0x00142BC4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004281 RID: 17025
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004282 RID: 17026
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04004283 RID: 17027
		private ErrorCode errorCode_;
	}
}
