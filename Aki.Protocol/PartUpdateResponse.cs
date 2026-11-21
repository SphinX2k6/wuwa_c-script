using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BBA RID: 3002
	[NetMessage(EMessageId.PartUpdateResponse)]
	public sealed class PartUpdateResponse : IMessage<PartUpdateResponse>, IMessage, IEquatable<PartUpdateResponse>, IDeepCloneable<PartUpdateResponse>, IBufferMessage
	{
		// Token: 0x06010497 RID: 66711 RVA: 0x00260A7F File Offset: 0x0025EC7F
		[NullableContext(1)]
		public static PartUpdateResponse Create()
		{
			return new PartUpdateResponse();
		}

		// Token: 0x17003567 RID: 13671
		// (get) Token: 0x06010498 RID: 66712 RVA: 0x00260A86 File Offset: 0x0025EC86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003568 RID: 13672
		// (get) Token: 0x06010499 RID: 66713 RVA: 0x00260A89 File Offset: 0x0025EC89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0601049A RID: 66714 RVA: 0x00260A90 File Offset: 0x0025EC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateResponse()
		{
		}

		// Token: 0x0601049B RID: 66715 RVA: 0x00260A98 File Offset: 0x0025EC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateResponse(PartUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601049C RID: 66716 RVA: 0x00260ABD File Offset: 0x0025ECBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateResponse Clone()
		{
			return new PartUpdateResponse(this);
		}

		// Token: 0x17003569 RID: 13673
		// (get) Token: 0x0601049D RID: 66717 RVA: 0x00260AC5 File Offset: 0x0025ECC5
		// (set) Token: 0x0601049E RID: 66718 RVA: 0x00260ACD File Offset: 0x0025ECCD
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

		// Token: 0x0601049F RID: 66719 RVA: 0x00260AD6 File Offset: 0x0025ECD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartUpdateResponse);
		}

		// Token: 0x060104A0 RID: 66720 RVA: 0x00260AE4 File Offset: 0x0025ECE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PartUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060104A1 RID: 66721 RVA: 0x00260B14 File Offset: 0x0025ED14
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

		// Token: 0x060104A2 RID: 66722 RVA: 0x00260B59 File Offset: 0x0025ED59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060104A3 RID: 66723 RVA: 0x00260B66 File Offset: 0x0025ED66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060104A4 RID: 66724 RVA: 0x00260B6F File Offset: 0x0025ED6F
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

		// Token: 0x060104A5 RID: 66725 RVA: 0x00260BA4 File Offset: 0x0025EDA4
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

		// Token: 0x060104A6 RID: 66726 RVA: 0x00260BE2 File Offset: 0x0025EDE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PartUpdateResponse other)
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

		// Token: 0x060104A7 RID: 66727 RVA: 0x00260C13 File Offset: 0x0025EE13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060104A8 RID: 66728 RVA: 0x00260C1C File Offset: 0x0025EE1C
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

		// Token: 0x040067EB RID: 26603
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067EC RID: 26604
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040067ED RID: 26605
		private ErrorCode errorCode_;
	}
}
