using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200138F RID: 5007
	[NetMessage(EMessageId.TotalTopUpRewardResponse)]
	public sealed class TotalTopUpRewardResponse : IMessage<TotalTopUpRewardResponse>, IMessage, IEquatable<TotalTopUpRewardResponse>, IDeepCloneable<TotalTopUpRewardResponse>, IBufferMessage
	{
		// Token: 0x0601A926 RID: 108838 RVA: 0x003DAF04 File Offset: 0x003D9104
		[NullableContext(1)]
		public static TotalTopUpRewardResponse Create()
		{
			return new TotalTopUpRewardResponse();
		}

		// Token: 0x17005998 RID: 22936
		// (get) Token: 0x0601A927 RID: 108839 RVA: 0x003DAF0B File Offset: 0x003D910B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005999 RID: 22937
		// (get) Token: 0x0601A928 RID: 108840 RVA: 0x003DAF0E File Offset: 0x003D910E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TotalTopUpRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601A929 RID: 108841 RVA: 0x003DAF15 File Offset: 0x003D9115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpRewardResponse()
		{
		}

		// Token: 0x0601A92A RID: 108842 RVA: 0x003DAF1D File Offset: 0x003D911D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpRewardResponse(TotalTopUpRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A92B RID: 108843 RVA: 0x003DAF42 File Offset: 0x003D9142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpRewardResponse Clone()
		{
			return new TotalTopUpRewardResponse(this);
		}

		// Token: 0x1700599A RID: 22938
		// (get) Token: 0x0601A92C RID: 108844 RVA: 0x003DAF4A File Offset: 0x003D914A
		// (set) Token: 0x0601A92D RID: 108845 RVA: 0x003DAF52 File Offset: 0x003D9152
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

		// Token: 0x0601A92E RID: 108846 RVA: 0x003DAF5B File Offset: 0x003D915B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TotalTopUpRewardResponse);
		}

		// Token: 0x0601A92F RID: 108847 RVA: 0x003DAF69 File Offset: 0x003D9169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TotalTopUpRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A930 RID: 108848 RVA: 0x003DAF98 File Offset: 0x003D9198
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

		// Token: 0x0601A931 RID: 108849 RVA: 0x003DAFDD File Offset: 0x003D91DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A932 RID: 108850 RVA: 0x003DAFEA File Offset: 0x003D91EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A933 RID: 108851 RVA: 0x003DAFF3 File Offset: 0x003D91F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A934 RID: 108852 RVA: 0x003DB028 File Offset: 0x003D9228
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

		// Token: 0x0601A935 RID: 108853 RVA: 0x003DB066 File Offset: 0x003D9266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TotalTopUpRewardResponse other)
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

		// Token: 0x0601A936 RID: 108854 RVA: 0x003DB097 File Offset: 0x003D9297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A937 RID: 108855 RVA: 0x003DB0A0 File Offset: 0x003D92A0
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009A78 RID: 39544
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A79 RID: 39545
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04009A7A RID: 39546
		private ErrorCode errorCode_;
	}
}
