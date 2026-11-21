using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000536 RID: 1334
	[NetMessage(EMessageId.FishingCabinPutResponse)]
	public sealed class FishingCabinPutResponse : IMessage<FishingCabinPutResponse>, IMessage, IEquatable<FishingCabinPutResponse>, IDeepCloneable<FishingCabinPutResponse>, IBufferMessage
	{
		// Token: 0x06007D4D RID: 32077 RVA: 0x0012FF80 File Offset: 0x0012E180
		[NullableContext(1)]
		public static FishingCabinPutResponse Create()
		{
			return new FishingCabinPutResponse();
		}

		// Token: 0x1700185D RID: 6237
		// (get) Token: 0x06007D4E RID: 32078 RVA: 0x0012FF87 File Offset: 0x0012E187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700185E RID: 6238
		// (get) Token: 0x06007D4F RID: 32079 RVA: 0x0012FF8A File Offset: 0x0012E18A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingCabinPutResponse.Descriptor;
			}
		}

		// Token: 0x06007D50 RID: 32080 RVA: 0x0012FF91 File Offset: 0x0012E191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCabinPutResponse()
		{
		}

		// Token: 0x06007D51 RID: 32081 RVA: 0x0012FF99 File Offset: 0x0012E199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCabinPutResponse(FishingCabinPutResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007D52 RID: 32082 RVA: 0x0012FFBE File Offset: 0x0012E1BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCabinPutResponse Clone()
		{
			return new FishingCabinPutResponse(this);
		}

		// Token: 0x1700185F RID: 6239
		// (get) Token: 0x06007D53 RID: 32083 RVA: 0x0012FFC6 File Offset: 0x0012E1C6
		// (set) Token: 0x06007D54 RID: 32084 RVA: 0x0012FFCE File Offset: 0x0012E1CE
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

		// Token: 0x06007D55 RID: 32085 RVA: 0x0012FFD7 File Offset: 0x0012E1D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingCabinPutResponse);
		}

		// Token: 0x06007D56 RID: 32086 RVA: 0x0012FFE5 File Offset: 0x0012E1E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingCabinPutResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007D57 RID: 32087 RVA: 0x00130014 File Offset: 0x0012E214
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

		// Token: 0x06007D58 RID: 32088 RVA: 0x00130059 File Offset: 0x0012E259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007D59 RID: 32089 RVA: 0x00130066 File Offset: 0x0012E266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D5A RID: 32090 RVA: 0x0013006F File Offset: 0x0012E26F
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

		// Token: 0x06007D5B RID: 32091 RVA: 0x001300A4 File Offset: 0x0012E2A4
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

		// Token: 0x06007D5C RID: 32092 RVA: 0x001300E2 File Offset: 0x0012E2E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingCabinPutResponse other)
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

		// Token: 0x06007D5D RID: 32093 RVA: 0x00130113 File Offset: 0x0012E313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007D5E RID: 32094 RVA: 0x0013011C File Offset: 0x0012E31C
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

		// Token: 0x04004027 RID: 16423
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004028 RID: 16424
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04004029 RID: 16425
		private ErrorCode errorCode_;
	}
}
