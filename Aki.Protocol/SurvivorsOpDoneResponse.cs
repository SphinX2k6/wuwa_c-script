using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001348 RID: 4936
	[NetMessage(EMessageId.SurvivorsOpDoneResponse)]
	public sealed class SurvivorsOpDoneResponse : IMessage<SurvivorsOpDoneResponse>, IMessage, IEquatable<SurvivorsOpDoneResponse>, IDeepCloneable<SurvivorsOpDoneResponse>, IBufferMessage
	{
		// Token: 0x0601A4E9 RID: 107753 RVA: 0x003D5D14 File Offset: 0x003D3F14
		[NullableContext(1)]
		public static SurvivorsOpDoneResponse Create()
		{
			return new SurvivorsOpDoneResponse();
		}

		// Token: 0x1700591B RID: 22811
		// (get) Token: 0x0601A4EA RID: 107754 RVA: 0x003D5D1B File Offset: 0x003D3F1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700591C RID: 22812
		// (get) Token: 0x0601A4EB RID: 107755 RVA: 0x003D5D1E File Offset: 0x003D3F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsOpDoneResponse.Descriptor;
			}
		}

		// Token: 0x0601A4EC RID: 107756 RVA: 0x003D5D25 File Offset: 0x003D3F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpDoneResponse()
		{
		}

		// Token: 0x0601A4ED RID: 107757 RVA: 0x003D5D2D File Offset: 0x003D3F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpDoneResponse(SurvivorsOpDoneResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A4EE RID: 107758 RVA: 0x003D5D52 File Offset: 0x003D3F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpDoneResponse Clone()
		{
			return new SurvivorsOpDoneResponse(this);
		}

		// Token: 0x1700591D RID: 22813
		// (get) Token: 0x0601A4EF RID: 107759 RVA: 0x003D5D5A File Offset: 0x003D3F5A
		// (set) Token: 0x0601A4F0 RID: 107760 RVA: 0x003D5D62 File Offset: 0x003D3F62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x0601A4F1 RID: 107761 RVA: 0x003D5D6B File Offset: 0x003D3F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsOpDoneResponse);
		}

		// Token: 0x0601A4F2 RID: 107762 RVA: 0x003D5D79 File Offset: 0x003D3F79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsOpDoneResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A4F3 RID: 107763 RVA: 0x003D5DA8 File Offset: 0x003D3FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A4F4 RID: 107764 RVA: 0x003D5DED File Offset: 0x003D3FED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A4F5 RID: 107765 RVA: 0x003D5DFA File Offset: 0x003D3FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A4F6 RID: 107766 RVA: 0x003D5E03 File Offset: 0x003D4003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A4F7 RID: 107767 RVA: 0x003D5E38 File Offset: 0x003D4038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A4F8 RID: 107768 RVA: 0x003D5E76 File Offset: 0x003D4076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsOpDoneResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A4F9 RID: 107769 RVA: 0x003D5EA7 File Offset: 0x003D40A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A4FA RID: 107770 RVA: 0x003D5EB0 File Offset: 0x003D40B0
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009AA4 RID: 39588
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009AA5 RID: 39589
		public const int ErrCodeFieldNumber = 3;

		// Token: 0x04009AA6 RID: 39590
		private ErrorCode errCode_;
	}
}
