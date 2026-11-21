using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001354 RID: 4948
	[NetMessage(EMessageId.SurvivorsScoreAwardResponse)]
	public sealed class SurvivorsScoreAwardResponse : IMessage<SurvivorsScoreAwardResponse>, IMessage, IEquatable<SurvivorsScoreAwardResponse>, IDeepCloneable<SurvivorsScoreAwardResponse>, IBufferMessage
	{
		// Token: 0x0601A5D0 RID: 107984 RVA: 0x003D7A29 File Offset: 0x003D5C29
		[NullableContext(1)]
		public static SurvivorsScoreAwardResponse Create()
		{
			return new SurvivorsScoreAwardResponse();
		}

		// Token: 0x17005947 RID: 22855
		// (get) Token: 0x0601A5D1 RID: 107985 RVA: 0x003D7A30 File Offset: 0x003D5C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005948 RID: 22856
		// (get) Token: 0x0601A5D2 RID: 107986 RVA: 0x003D7A33 File Offset: 0x003D5C33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsScoreAwardResponse.Descriptor;
			}
		}

		// Token: 0x0601A5D3 RID: 107987 RVA: 0x003D7A3A File Offset: 0x003D5C3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsScoreAwardResponse()
		{
		}

		// Token: 0x0601A5D4 RID: 107988 RVA: 0x003D7A42 File Offset: 0x003D5C42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsScoreAwardResponse(SurvivorsScoreAwardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A5D5 RID: 107989 RVA: 0x003D7A67 File Offset: 0x003D5C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsScoreAwardResponse Clone()
		{
			return new SurvivorsScoreAwardResponse(this);
		}

		// Token: 0x17005949 RID: 22857
		// (get) Token: 0x0601A5D6 RID: 107990 RVA: 0x003D7A6F File Offset: 0x003D5C6F
		// (set) Token: 0x0601A5D7 RID: 107991 RVA: 0x003D7A77 File Offset: 0x003D5C77
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

		// Token: 0x0601A5D8 RID: 107992 RVA: 0x003D7A80 File Offset: 0x003D5C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsScoreAwardResponse);
		}

		// Token: 0x0601A5D9 RID: 107993 RVA: 0x003D7A8E File Offset: 0x003D5C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsScoreAwardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A5DA RID: 107994 RVA: 0x003D7ABC File Offset: 0x003D5CBC
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

		// Token: 0x0601A5DB RID: 107995 RVA: 0x003D7B01 File Offset: 0x003D5D01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A5DC RID: 107996 RVA: 0x003D7B0E File Offset: 0x003D5D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A5DD RID: 107997 RVA: 0x003D7B17 File Offset: 0x003D5D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A5DE RID: 107998 RVA: 0x003D7B4C File Offset: 0x003D5D4C
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

		// Token: 0x0601A5DF RID: 107999 RVA: 0x003D7B8A File Offset: 0x003D5D8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsScoreAwardResponse other)
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

		// Token: 0x0601A5E0 RID: 108000 RVA: 0x003D7BBB File Offset: 0x003D5DBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A5E1 RID: 108001 RVA: 0x003D7BC4 File Offset: 0x003D5DC4
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009ADC RID: 39644
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009ADD RID: 39645
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04009ADE RID: 39646
		private ErrorCode errorCode_;
	}
}
