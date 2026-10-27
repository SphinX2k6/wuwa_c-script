using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003AB RID: 939
	[NetMessage(EMessageId.DarkTideMapMarkResponse)]
	public sealed class DarkTideMapMarkResponse : IMessage<DarkTideMapMarkResponse>, IMessage, IEquatable<DarkTideMapMarkResponse>, IDeepCloneable<DarkTideMapMarkResponse>, IBufferMessage
	{
		// Token: 0x06005C49 RID: 23625 RVA: 0x000E03A2 File Offset: 0x000DE5A2
		[NullableContext(1)]
		public static DarkTideMapMarkResponse Create()
		{
			return new DarkTideMapMarkResponse();
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x06005C4A RID: 23626 RVA: 0x000E03A9 File Offset: 0x000DE5A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x06005C4B RID: 23627 RVA: 0x000E03AC File Offset: 0x000DE5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideMapMarkResponse.Descriptor;
			}
		}

		// Token: 0x06005C4C RID: 23628 RVA: 0x000E03B3 File Offset: 0x000DE5B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideMapMarkResponse()
		{
		}

		// Token: 0x06005C4D RID: 23629 RVA: 0x000E03BB File Offset: 0x000DE5BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideMapMarkResponse(DarkTideMapMarkResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C4E RID: 23630 RVA: 0x000E03E0 File Offset: 0x000DE5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideMapMarkResponse Clone()
		{
			return new DarkTideMapMarkResponse(this);
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x06005C4F RID: 23631 RVA: 0x000E03E8 File Offset: 0x000DE5E8
		// (set) Token: 0x06005C50 RID: 23632 RVA: 0x000E03F0 File Offset: 0x000DE5F0
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

		// Token: 0x06005C51 RID: 23633 RVA: 0x000E03F9 File Offset: 0x000DE5F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideMapMarkResponse);
		}

		// Token: 0x06005C52 RID: 23634 RVA: 0x000E0407 File Offset: 0x000DE607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideMapMarkResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005C53 RID: 23635 RVA: 0x000E0438 File Offset: 0x000DE638
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

		// Token: 0x06005C54 RID: 23636 RVA: 0x000E047D File Offset: 0x000DE67D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005C55 RID: 23637 RVA: 0x000E048A File Offset: 0x000DE68A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C56 RID: 23638 RVA: 0x000E0493 File Offset: 0x000DE693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C57 RID: 23639 RVA: 0x000E04C8 File Offset: 0x000DE6C8
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

		// Token: 0x06005C58 RID: 23640 RVA: 0x000E0506 File Offset: 0x000DE706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideMapMarkResponse other)
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

		// Token: 0x06005C59 RID: 23641 RVA: 0x000E0537 File Offset: 0x000DE737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C5A RID: 23642 RVA: 0x000E0540 File Offset: 0x000DE740
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400363C RID: 13884
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400363D RID: 13885
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x0400363E RID: 13886
		private ErrorCode errorCode_;
	}
}
