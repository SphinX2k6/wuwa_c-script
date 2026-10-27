using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001206 RID: 4614
	[NetMessage(EMessageId.ShortMessageReadResponse)]
	public sealed class ShortMessageReadResponse : IMessage<ShortMessageReadResponse>, IMessage, IEquatable<ShortMessageReadResponse>, IDeepCloneable<ShortMessageReadResponse>, IBufferMessage
	{
		// Token: 0x0601898C RID: 100748 RVA: 0x00393E0C File Offset: 0x0039200C
		[NullableContext(1)]
		public static ShortMessageReadResponse Create()
		{
			return new ShortMessageReadResponse();
		}

		// Token: 0x170052E1 RID: 21217
		// (get) Token: 0x0601898D RID: 100749 RVA: 0x00393E13 File Offset: 0x00392013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052E2 RID: 21218
		// (get) Token: 0x0601898E RID: 100750 RVA: 0x00393E16 File Offset: 0x00392016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageReadResponse.Descriptor;
			}
		}

		// Token: 0x0601898F RID: 100751 RVA: 0x00393E1D File Offset: 0x0039201D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReadResponse()
		{
		}

		// Token: 0x06018990 RID: 100752 RVA: 0x00393E25 File Offset: 0x00392025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReadResponse(ShortMessageReadResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018991 RID: 100753 RVA: 0x00393E4A File Offset: 0x0039204A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReadResponse Clone()
		{
			return new ShortMessageReadResponse(this);
		}

		// Token: 0x170052E3 RID: 21219
		// (get) Token: 0x06018992 RID: 100754 RVA: 0x00393E52 File Offset: 0x00392052
		// (set) Token: 0x06018993 RID: 100755 RVA: 0x00393E5A File Offset: 0x0039205A
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

		// Token: 0x06018994 RID: 100756 RVA: 0x00393E63 File Offset: 0x00392063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageReadResponse);
		}

		// Token: 0x06018995 RID: 100757 RVA: 0x00393E71 File Offset: 0x00392071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageReadResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018996 RID: 100758 RVA: 0x00393EA0 File Offset: 0x003920A0
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

		// Token: 0x06018997 RID: 100759 RVA: 0x00393EE5 File Offset: 0x003920E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018998 RID: 100760 RVA: 0x00393EF2 File Offset: 0x003920F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018999 RID: 100761 RVA: 0x00393EFB File Offset: 0x003920FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601899A RID: 100762 RVA: 0x00393F2C File Offset: 0x0039212C
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

		// Token: 0x0601899B RID: 100763 RVA: 0x00393F6A File Offset: 0x0039216A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageReadResponse other)
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

		// Token: 0x0601899C RID: 100764 RVA: 0x00393F9B File Offset: 0x0039219B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601899D RID: 100765 RVA: 0x00393FA4 File Offset: 0x003921A4
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009165 RID: 37221
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009166 RID: 37222
		public const int ErrCodeFieldNumber = 1;

		// Token: 0x04009167 RID: 37223
		private ErrorCode errCode_;
	}
}
