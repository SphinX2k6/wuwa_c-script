using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000914 RID: 2324
	[NetMessage(EMessageId.LevelSequenceFrameEventActionResponse)]
	public sealed class LevelSequenceFrameEventActionResponse : IMessage<LevelSequenceFrameEventActionResponse>, IMessage, IEquatable<LevelSequenceFrameEventActionResponse>, IDeepCloneable<LevelSequenceFrameEventActionResponse>, IBufferMessage
	{
		// Token: 0x0600CD20 RID: 52512 RVA: 0x001E3AFE File Offset: 0x001E1CFE
		[NullableContext(1)]
		public static LevelSequenceFrameEventActionResponse Create()
		{
			return new LevelSequenceFrameEventActionResponse();
		}

		// Token: 0x1700296D RID: 10605
		// (get) Token: 0x0600CD21 RID: 52513 RVA: 0x001E3B05 File Offset: 0x001E1D05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700296E RID: 10606
		// (get) Token: 0x0600CD22 RID: 52514 RVA: 0x001E3B08 File Offset: 0x001E1D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelSequenceFrameEventActionResponse.Descriptor;
			}
		}

		// Token: 0x0600CD23 RID: 52515 RVA: 0x001E3B0F File Offset: 0x001E1D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelSequenceFrameEventActionResponse()
		{
		}

		// Token: 0x0600CD24 RID: 52516 RVA: 0x001E3B17 File Offset: 0x001E1D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelSequenceFrameEventActionResponse(LevelSequenceFrameEventActionResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CD25 RID: 52517 RVA: 0x001E3B3C File Offset: 0x001E1D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelSequenceFrameEventActionResponse Clone()
		{
			return new LevelSequenceFrameEventActionResponse(this);
		}

		// Token: 0x1700296F RID: 10607
		// (get) Token: 0x0600CD26 RID: 52518 RVA: 0x001E3B44 File Offset: 0x001E1D44
		// (set) Token: 0x0600CD27 RID: 52519 RVA: 0x001E3B4C File Offset: 0x001E1D4C
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

		// Token: 0x0600CD28 RID: 52520 RVA: 0x001E3B55 File Offset: 0x001E1D55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelSequenceFrameEventActionResponse);
		}

		// Token: 0x0600CD29 RID: 52521 RVA: 0x001E3B63 File Offset: 0x001E1D63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelSequenceFrameEventActionResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CD2A RID: 52522 RVA: 0x001E3B94 File Offset: 0x001E1D94
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

		// Token: 0x0600CD2B RID: 52523 RVA: 0x001E3BD9 File Offset: 0x001E1DD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CD2C RID: 52524 RVA: 0x001E3BE6 File Offset: 0x001E1DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CD2D RID: 52525 RVA: 0x001E3BEF File Offset: 0x001E1DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CD2E RID: 52526 RVA: 0x001E3C24 File Offset: 0x001E1E24
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

		// Token: 0x0600CD2F RID: 52527 RVA: 0x001E3C62 File Offset: 0x001E1E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelSequenceFrameEventActionResponse other)
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

		// Token: 0x0600CD30 RID: 52528 RVA: 0x001E3C93 File Offset: 0x001E1E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CD31 RID: 52529 RVA: 0x001E3C9C File Offset: 0x001E1E9C
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040056E0 RID: 22240
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056E1 RID: 22241
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x040056E2 RID: 22242
		private ErrorCode errorCode_;
	}
}
