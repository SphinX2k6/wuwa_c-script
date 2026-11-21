using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FD7 RID: 4055
	[NetMessage(EMessageId.RogueResGridEventResponse)]
	public sealed class RogueResGridEventResponse : IMessage<RogueResGridEventResponse>, IMessage, IEquatable<RogueResGridEventResponse>, IDeepCloneable<RogueResGridEventResponse>, IBufferMessage
	{
		// Token: 0x06015B4E RID: 88910 RVA: 0x00327A54 File Offset: 0x00325C54
		[NullableContext(1)]
		public static RogueResGridEventResponse Create()
		{
			return new RogueResGridEventResponse();
		}

		// Token: 0x17004878 RID: 18552
		// (get) Token: 0x06015B4F RID: 88911 RVA: 0x00327A5B File Offset: 0x00325C5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004879 RID: 18553
		// (get) Token: 0x06015B50 RID: 88912 RVA: 0x00327A5E File Offset: 0x00325C5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResGridEventResponse.Descriptor;
			}
		}

		// Token: 0x06015B51 RID: 88913 RVA: 0x00327A65 File Offset: 0x00325C65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridEventResponse()
		{
		}

		// Token: 0x06015B52 RID: 88914 RVA: 0x00327A6D File Offset: 0x00325C6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridEventResponse(RogueResGridEventResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015B53 RID: 88915 RVA: 0x00327A92 File Offset: 0x00325C92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridEventResponse Clone()
		{
			return new RogueResGridEventResponse(this);
		}

		// Token: 0x1700487A RID: 18554
		// (get) Token: 0x06015B54 RID: 88916 RVA: 0x00327A9A File Offset: 0x00325C9A
		// (set) Token: 0x06015B55 RID: 88917 RVA: 0x00327AA2 File Offset: 0x00325CA2
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

		// Token: 0x06015B56 RID: 88918 RVA: 0x00327AAB File Offset: 0x00325CAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResGridEventResponse);
		}

		// Token: 0x06015B57 RID: 88919 RVA: 0x00327AB9 File Offset: 0x00325CB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResGridEventResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015B58 RID: 88920 RVA: 0x00327AE8 File Offset: 0x00325CE8
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

		// Token: 0x06015B59 RID: 88921 RVA: 0x00327B2D File Offset: 0x00325D2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015B5A RID: 88922 RVA: 0x00327B3A File Offset: 0x00325D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015B5B RID: 88923 RVA: 0x00327B43 File Offset: 0x00325D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015B5C RID: 88924 RVA: 0x00327B78 File Offset: 0x00325D78
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

		// Token: 0x06015B5D RID: 88925 RVA: 0x00327BB6 File Offset: 0x00325DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResGridEventResponse other)
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

		// Token: 0x06015B5E RID: 88926 RVA: 0x00327BE7 File Offset: 0x00325DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015B5F RID: 88927 RVA: 0x00327BF0 File Offset: 0x00325DF0
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040082C8 RID: 33480
		private UnknownFieldSet _unknownFields;

		// Token: 0x040082C9 RID: 33481
		public const int ErrCodeFieldNumber = 4;

		// Token: 0x040082CA RID: 33482
		private ErrorCode errCode_;
	}
}
