using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000567 RID: 1383
	[NetMessage(EMessageId.FishingSellResponse)]
	public sealed class FishingSellResponse : IMessage<FishingSellResponse>, IMessage, IEquatable<FishingSellResponse>, IDeepCloneable<FishingSellResponse>, IBufferMessage
	{
		// Token: 0x06008114 RID: 33044 RVA: 0x0013808D File Offset: 0x0013628D
		[NullableContext(1)]
		public static FishingSellResponse Create()
		{
			return new FishingSellResponse();
		}

		// Token: 0x17001922 RID: 6434
		// (get) Token: 0x06008115 RID: 33045 RVA: 0x00138094 File Offset: 0x00136294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001923 RID: 6435
		// (get) Token: 0x06008116 RID: 33046 RVA: 0x00138097 File Offset: 0x00136297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSellResponse.Descriptor;
			}
		}

		// Token: 0x06008117 RID: 33047 RVA: 0x0013809E File Offset: 0x0013629E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSellResponse()
		{
		}

		// Token: 0x06008118 RID: 33048 RVA: 0x001380A6 File Offset: 0x001362A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSellResponse(FishingSellResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008119 RID: 33049 RVA: 0x001380CB File Offset: 0x001362CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSellResponse Clone()
		{
			return new FishingSellResponse(this);
		}

		// Token: 0x17001924 RID: 6436
		// (get) Token: 0x0600811A RID: 33050 RVA: 0x001380D3 File Offset: 0x001362D3
		// (set) Token: 0x0600811B RID: 33051 RVA: 0x001380DB File Offset: 0x001362DB
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

		// Token: 0x0600811C RID: 33052 RVA: 0x001380E4 File Offset: 0x001362E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSellResponse);
		}

		// Token: 0x0600811D RID: 33053 RVA: 0x001380F2 File Offset: 0x001362F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSellResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600811E RID: 33054 RVA: 0x00138120 File Offset: 0x00136320
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

		// Token: 0x0600811F RID: 33055 RVA: 0x00138165 File Offset: 0x00136365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008120 RID: 33056 RVA: 0x00138172 File Offset: 0x00136372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008121 RID: 33057 RVA: 0x0013817B File Offset: 0x0013637B
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

		// Token: 0x06008122 RID: 33058 RVA: 0x001381AC File Offset: 0x001363AC
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

		// Token: 0x06008123 RID: 33059 RVA: 0x001381EA File Offset: 0x001363EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingSellResponse other)
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

		// Token: 0x06008124 RID: 33060 RVA: 0x0013821B File Offset: 0x0013641B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008125 RID: 33061 RVA: 0x00138224 File Offset: 0x00136424
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

		// Token: 0x04004139 RID: 16697
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400413A RID: 16698
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400413B RID: 16699
		private ErrorCode errorCode_;
	}
}
