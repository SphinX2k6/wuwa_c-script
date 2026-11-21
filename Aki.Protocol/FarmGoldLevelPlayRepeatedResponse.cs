using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200050E RID: 1294
	[NetMessage(EMessageId.FarmGoldLevelPlayRepeatedResponse)]
	public sealed class FarmGoldLevelPlayRepeatedResponse : IMessage<FarmGoldLevelPlayRepeatedResponse>, IMessage, IEquatable<FarmGoldLevelPlayRepeatedResponse>, IDeepCloneable<FarmGoldLevelPlayRepeatedResponse>, IBufferMessage
	{
		// Token: 0x06007A06 RID: 31238 RVA: 0x00128BA8 File Offset: 0x00126DA8
		[NullableContext(1)]
		public static FarmGoldLevelPlayRepeatedResponse Create()
		{
			return new FarmGoldLevelPlayRepeatedResponse();
		}

		// Token: 0x170017A6 RID: 6054
		// (get) Token: 0x06007A07 RID: 31239 RVA: 0x00128BAF File Offset: 0x00126DAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017A7 RID: 6055
		// (get) Token: 0x06007A08 RID: 31240 RVA: 0x00128BB2 File Offset: 0x00126DB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldLevelPlayRepeatedResponse.Descriptor;
			}
		}

		// Token: 0x06007A09 RID: 31241 RVA: 0x00128BB9 File Offset: 0x00126DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayRepeatedResponse()
		{
		}

		// Token: 0x06007A0A RID: 31242 RVA: 0x00128BC1 File Offset: 0x00126DC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayRepeatedResponse(FarmGoldLevelPlayRepeatedResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A0B RID: 31243 RVA: 0x00128BE6 File Offset: 0x00126DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayRepeatedResponse Clone()
		{
			return new FarmGoldLevelPlayRepeatedResponse(this);
		}

		// Token: 0x170017A8 RID: 6056
		// (get) Token: 0x06007A0C RID: 31244 RVA: 0x00128BEE File Offset: 0x00126DEE
		// (set) Token: 0x06007A0D RID: 31245 RVA: 0x00128BF6 File Offset: 0x00126DF6
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

		// Token: 0x06007A0E RID: 31246 RVA: 0x00128BFF File Offset: 0x00126DFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldLevelPlayRepeatedResponse);
		}

		// Token: 0x06007A0F RID: 31247 RVA: 0x00128C0D File Offset: 0x00126E0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldLevelPlayRepeatedResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007A10 RID: 31248 RVA: 0x00128C3C File Offset: 0x00126E3C
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

		// Token: 0x06007A11 RID: 31249 RVA: 0x00128C81 File Offset: 0x00126E81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007A12 RID: 31250 RVA: 0x00128C8E File Offset: 0x00126E8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A13 RID: 31251 RVA: 0x00128C97 File Offset: 0x00126E97
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

		// Token: 0x06007A14 RID: 31252 RVA: 0x00128CC8 File Offset: 0x00126EC8
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

		// Token: 0x06007A15 RID: 31253 RVA: 0x00128D06 File Offset: 0x00126F06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldLevelPlayRepeatedResponse other)
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

		// Token: 0x06007A16 RID: 31254 RVA: 0x00128D37 File Offset: 0x00126F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A17 RID: 31255 RVA: 0x00128D40 File Offset: 0x00126F40
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

		// Token: 0x04003F26 RID: 16166
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F27 RID: 16167
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04003F28 RID: 16168
		private ErrorCode errorCode_;
	}
}
