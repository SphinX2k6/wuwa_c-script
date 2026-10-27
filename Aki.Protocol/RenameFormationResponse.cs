using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F14 RID: 3860
	[NetMessage(EMessageId.RenameFormationResponse)]
	public sealed class RenameFormationResponse : IMessage<RenameFormationResponse>, IMessage, IEquatable<RenameFormationResponse>, IDeepCloneable<RenameFormationResponse>, IBufferMessage
	{
		// Token: 0x06014AA4 RID: 84644 RVA: 0x002FFE14 File Offset: 0x002FE014
		[NullableContext(1)]
		public static RenameFormationResponse Create()
		{
			return new RenameFormationResponse();
		}

		// Token: 0x170044B1 RID: 17585
		// (get) Token: 0x06014AA5 RID: 84645 RVA: 0x002FFE1B File Offset: 0x002FE01B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044B2 RID: 17586
		// (get) Token: 0x06014AA6 RID: 84646 RVA: 0x002FFE1E File Offset: 0x002FE01E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RenameFormationResponse.Descriptor;
			}
		}

		// Token: 0x06014AA7 RID: 84647 RVA: 0x002FFE25 File Offset: 0x002FE025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenameFormationResponse()
		{
		}

		// Token: 0x06014AA8 RID: 84648 RVA: 0x002FFE2D File Offset: 0x002FE02D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenameFormationResponse(RenameFormationResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014AA9 RID: 84649 RVA: 0x002FFE52 File Offset: 0x002FE052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenameFormationResponse Clone()
		{
			return new RenameFormationResponse(this);
		}

		// Token: 0x170044B3 RID: 17587
		// (get) Token: 0x06014AAA RID: 84650 RVA: 0x002FFE5A File Offset: 0x002FE05A
		// (set) Token: 0x06014AAB RID: 84651 RVA: 0x002FFE62 File Offset: 0x002FE062
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

		// Token: 0x06014AAC RID: 84652 RVA: 0x002FFE6B File Offset: 0x002FE06B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RenameFormationResponse);
		}

		// Token: 0x06014AAD RID: 84653 RVA: 0x002FFE79 File Offset: 0x002FE079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RenameFormationResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014AAE RID: 84654 RVA: 0x002FFEA8 File Offset: 0x002FE0A8
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

		// Token: 0x06014AAF RID: 84655 RVA: 0x002FFEED File Offset: 0x002FE0ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014AB0 RID: 84656 RVA: 0x002FFEFA File Offset: 0x002FE0FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014AB1 RID: 84657 RVA: 0x002FFF03 File Offset: 0x002FE103
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

		// Token: 0x06014AB2 RID: 84658 RVA: 0x002FFF38 File Offset: 0x002FE138
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

		// Token: 0x06014AB3 RID: 84659 RVA: 0x002FFF76 File Offset: 0x002FE176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RenameFormationResponse other)
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

		// Token: 0x06014AB4 RID: 84660 RVA: 0x002FFFA7 File Offset: 0x002FE1A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014AB5 RID: 84661 RVA: 0x002FFFB0 File Offset: 0x002FE1B0
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

		// Token: 0x04007CF7 RID: 31991
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CF8 RID: 31992
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04007CF9 RID: 31993
		private ErrorCode errorCode_;
	}
}
