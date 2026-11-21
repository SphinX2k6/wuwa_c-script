using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BB0 RID: 2992
	[NetMessage(EMessageId.ParkourChallengeTransResponse)]
	public sealed class ParkourChallengeTransResponse : IMessage<ParkourChallengeTransResponse>, IMessage, IEquatable<ParkourChallengeTransResponse>, IDeepCloneable<ParkourChallengeTransResponse>, IBufferMessage
	{
		// Token: 0x060103CB RID: 66507 RVA: 0x0025EF81 File Offset: 0x0025D181
		[NullableContext(1)]
		public static ParkourChallengeTransResponse Create()
		{
			return new ParkourChallengeTransResponse();
		}

		// Token: 0x1700353D RID: 13629
		// (get) Token: 0x060103CC RID: 66508 RVA: 0x0025EF88 File Offset: 0x0025D188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700353E RID: 13630
		// (get) Token: 0x060103CD RID: 66509 RVA: 0x0025EF8B File Offset: 0x0025D18B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParkourChallengeTransResponse.Descriptor;
			}
		}

		// Token: 0x060103CE RID: 66510 RVA: 0x0025EF92 File Offset: 0x0025D192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeTransResponse()
		{
		}

		// Token: 0x060103CF RID: 66511 RVA: 0x0025EF9A File Offset: 0x0025D19A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeTransResponse(ParkourChallengeTransResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060103D0 RID: 66512 RVA: 0x0025EFBF File Offset: 0x0025D1BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeTransResponse Clone()
		{
			return new ParkourChallengeTransResponse(this);
		}

		// Token: 0x1700353F RID: 13631
		// (get) Token: 0x060103D1 RID: 66513 RVA: 0x0025EFC7 File Offset: 0x0025D1C7
		// (set) Token: 0x060103D2 RID: 66514 RVA: 0x0025EFCF File Offset: 0x0025D1CF
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

		// Token: 0x060103D3 RID: 66515 RVA: 0x0025EFD8 File Offset: 0x0025D1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParkourChallengeTransResponse);
		}

		// Token: 0x060103D4 RID: 66516 RVA: 0x0025EFE6 File Offset: 0x0025D1E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ParkourChallengeTransResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060103D5 RID: 66517 RVA: 0x0025F014 File Offset: 0x0025D214
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

		// Token: 0x060103D6 RID: 66518 RVA: 0x0025F059 File Offset: 0x0025D259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060103D7 RID: 66519 RVA: 0x0025F066 File Offset: 0x0025D266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060103D8 RID: 66520 RVA: 0x0025F06F File Offset: 0x0025D26F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060103D9 RID: 66521 RVA: 0x0025F0A4 File Offset: 0x0025D2A4
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

		// Token: 0x060103DA RID: 66522 RVA: 0x0025F0E2 File Offset: 0x0025D2E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ParkourChallengeTransResponse other)
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

		// Token: 0x060103DB RID: 66523 RVA: 0x0025F113 File Offset: 0x0025D313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060103DC RID: 66524 RVA: 0x0025F11C File Offset: 0x0025D31C
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040067B3 RID: 26547
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067B4 RID: 26548
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040067B5 RID: 26549
		private ErrorCode errorCode_;
	}
}
