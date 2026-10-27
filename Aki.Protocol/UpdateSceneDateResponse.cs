using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014A7 RID: 5287
	[NetMessage(EMessageId.UpdateSceneDateResponse)]
	public sealed class UpdateSceneDateResponse : IMessage<UpdateSceneDateResponse>, IMessage, IEquatable<UpdateSceneDateResponse>, IDeepCloneable<UpdateSceneDateResponse>, IBufferMessage
	{
		// Token: 0x0601BF61 RID: 114529 RVA: 0x0040A979 File Offset: 0x00408B79
		[NullableContext(1)]
		public static UpdateSceneDateResponse Create()
		{
			return new UpdateSceneDateResponse();
		}

		// Token: 0x17005E3A RID: 24122
		// (get) Token: 0x0601BF62 RID: 114530 RVA: 0x0040A980 File Offset: 0x00408B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E3B RID: 24123
		// (get) Token: 0x0601BF63 RID: 114531 RVA: 0x0040A983 File Offset: 0x00408B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateSceneDateResponse.Descriptor;
			}
		}

		// Token: 0x0601BF64 RID: 114532 RVA: 0x0040A98A File Offset: 0x00408B8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneDateResponse()
		{
		}

		// Token: 0x0601BF65 RID: 114533 RVA: 0x0040A992 File Offset: 0x00408B92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneDateResponse(UpdateSceneDateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.currDate_ = other.currDate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BF66 RID: 114534 RVA: 0x0040A9C3 File Offset: 0x00408BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneDateResponse Clone()
		{
			return new UpdateSceneDateResponse(this);
		}

		// Token: 0x17005E3C RID: 24124
		// (get) Token: 0x0601BF67 RID: 114535 RVA: 0x0040A9CB File Offset: 0x00408BCB
		// (set) Token: 0x0601BF68 RID: 114536 RVA: 0x0040A9D3 File Offset: 0x00408BD3
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

		// Token: 0x17005E3D RID: 24125
		// (get) Token: 0x0601BF69 RID: 114537 RVA: 0x0040A9DC File Offset: 0x00408BDC
		// (set) Token: 0x0601BF6A RID: 114538 RVA: 0x0040A9E4 File Offset: 0x00408BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurrDate
		{
			get
			{
				return this.currDate_;
			}
			set
			{
				this.currDate_ = value;
			}
		}

		// Token: 0x0601BF6B RID: 114539 RVA: 0x0040A9ED File Offset: 0x00408BED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateSceneDateResponse);
		}

		// Token: 0x0601BF6C RID: 114540 RVA: 0x0040A9FB File Offset: 0x00408BFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateSceneDateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.CurrDate == other.CurrDate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BF6D RID: 114541 RVA: 0x0040AA3C File Offset: 0x00408C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.CurrDate != 0U)
			{
				num ^= this.CurrDate.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BF6E RID: 114542 RVA: 0x0040AA9A File Offset: 0x00408C9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BF6F RID: 114543 RVA: 0x0040AAA7 File Offset: 0x00408CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BF70 RID: 114544 RVA: 0x0040AAB0 File Offset: 0x00408CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurrDate != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.CurrDate);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BF71 RID: 114545 RVA: 0x0040AB0C File Offset: 0x00408D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.CurrDate != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurrDate);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BF72 RID: 114546 RVA: 0x0040AB64 File Offset: 0x00408D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateSceneDateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.CurrDate != 0U)
			{
				this.CurrDate = other.CurrDate;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BF73 RID: 114547 RVA: 0x0040ABB4 File Offset: 0x00408DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BF74 RID: 114548 RVA: 0x0040ABC0 File Offset: 0x00408DC0
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
					if (num != 88U)
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
					this.CurrDate = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400A0A1 RID: 41121
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0A2 RID: 41122
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x0400A0A3 RID: 41123
		private ErrorCode errorCode_;

		// Token: 0x0400A0A4 RID: 41124
		public const int CurrDateFieldNumber = 6;

		// Token: 0x0400A0A5 RID: 41125
		private uint currDate_;
	}
}
