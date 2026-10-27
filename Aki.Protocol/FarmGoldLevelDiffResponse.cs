using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200051F RID: 1311
	[NetMessage(EMessageId.FarmGoldLevelDiffResponse)]
	public sealed class FarmGoldLevelDiffResponse : IMessage<FarmGoldLevelDiffResponse>, IMessage, IEquatable<FarmGoldLevelDiffResponse>, IDeepCloneable<FarmGoldLevelDiffResponse>, IBufferMessage
	{
		// Token: 0x06007B16 RID: 31510 RVA: 0x0012AAE3 File Offset: 0x00128CE3
		[NullableContext(1)]
		public static FarmGoldLevelDiffResponse Create()
		{
			return new FarmGoldLevelDiffResponse();
		}

		// Token: 0x170017DF RID: 6111
		// (get) Token: 0x06007B17 RID: 31511 RVA: 0x0012AAEA File Offset: 0x00128CEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017E0 RID: 6112
		// (get) Token: 0x06007B18 RID: 31512 RVA: 0x0012AAED File Offset: 0x00128CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldLevelDiffResponse.Descriptor;
			}
		}

		// Token: 0x06007B19 RID: 31513 RVA: 0x0012AAF4 File Offset: 0x00128CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelDiffResponse()
		{
		}

		// Token: 0x06007B1A RID: 31514 RVA: 0x0012AAFC File Offset: 0x00128CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelDiffResponse(FarmGoldLevelDiffResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007B1B RID: 31515 RVA: 0x0012AB21 File Offset: 0x00128D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelDiffResponse Clone()
		{
			return new FarmGoldLevelDiffResponse(this);
		}

		// Token: 0x170017E1 RID: 6113
		// (get) Token: 0x06007B1C RID: 31516 RVA: 0x0012AB29 File Offset: 0x00128D29
		// (set) Token: 0x06007B1D RID: 31517 RVA: 0x0012AB31 File Offset: 0x00128D31
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

		// Token: 0x06007B1E RID: 31518 RVA: 0x0012AB3A File Offset: 0x00128D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldLevelDiffResponse);
		}

		// Token: 0x06007B1F RID: 31519 RVA: 0x0012AB48 File Offset: 0x00128D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldLevelDiffResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007B20 RID: 31520 RVA: 0x0012AB78 File Offset: 0x00128D78
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

		// Token: 0x06007B21 RID: 31521 RVA: 0x0012ABBD File Offset: 0x00128DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007B22 RID: 31522 RVA: 0x0012ABCA File Offset: 0x00128DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007B23 RID: 31523 RVA: 0x0012ABD3 File Offset: 0x00128DD3
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

		// Token: 0x06007B24 RID: 31524 RVA: 0x0012AC08 File Offset: 0x00128E08
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

		// Token: 0x06007B25 RID: 31525 RVA: 0x0012AC46 File Offset: 0x00128E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldLevelDiffResponse other)
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

		// Token: 0x06007B26 RID: 31526 RVA: 0x0012AC77 File Offset: 0x00128E77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007B27 RID: 31527 RVA: 0x0012AC80 File Offset: 0x00128E80
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

		// Token: 0x04003F14 RID: 16148
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F15 RID: 16149
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04003F16 RID: 16150
		private ErrorCode errorCode_;
	}
}
