using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200095C RID: 2396
	[NetMessage(EMessageId.LordGymBeginResponse)]
	public sealed class LordGymBeginResponse : IMessage<LordGymBeginResponse>, IMessage, IEquatable<LordGymBeginResponse>, IDeepCloneable<LordGymBeginResponse>, IBufferMessage
	{
		// Token: 0x0600D321 RID: 54049 RVA: 0x001F1C69 File Offset: 0x001EFE69
		[NullableContext(1)]
		public static LordGymBeginResponse Create()
		{
			return new LordGymBeginResponse();
		}

		// Token: 0x17002AC0 RID: 10944
		// (get) Token: 0x0600D322 RID: 54050 RVA: 0x001F1C70 File Offset: 0x001EFE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AC1 RID: 10945
		// (get) Token: 0x0600D323 RID: 54051 RVA: 0x001F1C73 File Offset: 0x001EFE73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LordGymBeginResponse.Descriptor;
			}
		}

		// Token: 0x0600D324 RID: 54052 RVA: 0x001F1C7A File Offset: 0x001EFE7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymBeginResponse()
		{
		}

		// Token: 0x0600D325 RID: 54053 RVA: 0x001F1C82 File Offset: 0x001EFE82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymBeginResponse(LordGymBeginResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D326 RID: 54054 RVA: 0x001F1CA7 File Offset: 0x001EFEA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymBeginResponse Clone()
		{
			return new LordGymBeginResponse(this);
		}

		// Token: 0x17002AC2 RID: 10946
		// (get) Token: 0x0600D327 RID: 54055 RVA: 0x001F1CAF File Offset: 0x001EFEAF
		// (set) Token: 0x0600D328 RID: 54056 RVA: 0x001F1CB7 File Offset: 0x001EFEB7
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

		// Token: 0x0600D329 RID: 54057 RVA: 0x001F1CC0 File Offset: 0x001EFEC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LordGymBeginResponse);
		}

		// Token: 0x0600D32A RID: 54058 RVA: 0x001F1CCE File Offset: 0x001EFECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LordGymBeginResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D32B RID: 54059 RVA: 0x001F1CFC File Offset: 0x001EFEFC
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

		// Token: 0x0600D32C RID: 54060 RVA: 0x001F1D41 File Offset: 0x001EFF41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D32D RID: 54061 RVA: 0x001F1D4E File Offset: 0x001EFF4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D32E RID: 54062 RVA: 0x001F1D57 File Offset: 0x001EFF57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D32F RID: 54063 RVA: 0x001F1D88 File Offset: 0x001EFF88
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

		// Token: 0x0600D330 RID: 54064 RVA: 0x001F1DC6 File Offset: 0x001EFFC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LordGymBeginResponse other)
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

		// Token: 0x0600D331 RID: 54065 RVA: 0x001F1DF7 File Offset: 0x001EFFF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D332 RID: 54066 RVA: 0x001F1E00 File Offset: 0x001F0000
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040058C2 RID: 22722
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058C3 RID: 22723
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040058C4 RID: 22724
		private ErrorCode errorCode_;
	}
}
