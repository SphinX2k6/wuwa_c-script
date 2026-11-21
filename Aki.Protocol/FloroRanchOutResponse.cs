using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005A1 RID: 1441
	[NetMessage(EMessageId.FloroRanchOutResponse)]
	public sealed class FloroRanchOutResponse : IMessage<FloroRanchOutResponse>, IMessage, IEquatable<FloroRanchOutResponse>, IDeepCloneable<FloroRanchOutResponse>, IBufferMessage
	{
		// Token: 0x060085A3 RID: 34211 RVA: 0x00141C18 File Offset: 0x0013FE18
		[NullableContext(1)]
		public static FloroRanchOutResponse Create()
		{
			return new FloroRanchOutResponse();
		}

		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x060085A4 RID: 34212 RVA: 0x00141C1F File Offset: 0x0013FE1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x060085A5 RID: 34213 RVA: 0x00141C22 File Offset: 0x0013FE22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchOutResponse.Descriptor;
			}
		}

		// Token: 0x060085A6 RID: 34214 RVA: 0x00141C29 File Offset: 0x0013FE29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchOutResponse()
		{
		}

		// Token: 0x060085A7 RID: 34215 RVA: 0x00141C31 File Offset: 0x0013FE31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchOutResponse(FloroRanchOutResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060085A8 RID: 34216 RVA: 0x00141C56 File Offset: 0x0013FE56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchOutResponse Clone()
		{
			return new FloroRanchOutResponse(this);
		}

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x060085A9 RID: 34217 RVA: 0x00141C5E File Offset: 0x0013FE5E
		// (set) Token: 0x060085AA RID: 34218 RVA: 0x00141C66 File Offset: 0x0013FE66
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

		// Token: 0x060085AB RID: 34219 RVA: 0x00141C6F File Offset: 0x0013FE6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchOutResponse);
		}

		// Token: 0x060085AC RID: 34220 RVA: 0x00141C7D File Offset: 0x0013FE7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchOutResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060085AD RID: 34221 RVA: 0x00141CAC File Offset: 0x0013FEAC
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

		// Token: 0x060085AE RID: 34222 RVA: 0x00141CF1 File Offset: 0x0013FEF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060085AF RID: 34223 RVA: 0x00141CFE File Offset: 0x0013FEFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060085B0 RID: 34224 RVA: 0x00141D07 File Offset: 0x0013FF07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060085B1 RID: 34225 RVA: 0x00141D3C File Offset: 0x0013FF3C
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

		// Token: 0x060085B2 RID: 34226 RVA: 0x00141D7A File Offset: 0x0013FF7A
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

		// Token: 0x060085B3 RID: 34227 RVA: 0x00141DAB File Offset: 0x0013FFAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060085B4 RID: 34228 RVA: 0x00141DB4 File Offset: 0x0013FFB4
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004277 RID: 17015
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004278 RID: 17016
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04004279 RID: 17017
		private ErrorCode errorCode_;
	}
}
