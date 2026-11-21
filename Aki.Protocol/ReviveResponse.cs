using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F20 RID: 3872
	[NetMessage(EMessageId.ReviveResponse)]
	public sealed class ReviveResponse : IMessage<ReviveResponse>, IMessage, IEquatable<ReviveResponse>, IDeepCloneable<ReviveResponse>, IBufferMessage
	{
		// Token: 0x06014BFF RID: 84991 RVA: 0x003035F8 File Offset: 0x003017F8
		[NullableContext(1)]
		public static ReviveResponse Create()
		{
			return new ReviveResponse();
		}

		// Token: 0x170044FF RID: 17663
		// (get) Token: 0x06014C00 RID: 84992 RVA: 0x003035FF File Offset: 0x003017FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004500 RID: 17664
		// (get) Token: 0x06014C01 RID: 84993 RVA: 0x00303602 File Offset: 0x00301802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReviveResponse.Descriptor;
			}
		}

		// Token: 0x06014C02 RID: 84994 RVA: 0x00303609 File Offset: 0x00301809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReviveResponse()
		{
		}

		// Token: 0x06014C03 RID: 84995 RVA: 0x00303611 File Offset: 0x00301811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReviveResponse(ReviveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014C04 RID: 84996 RVA: 0x00303636 File Offset: 0x00301836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReviveResponse Clone()
		{
			return new ReviveResponse(this);
		}

		// Token: 0x17004501 RID: 17665
		// (get) Token: 0x06014C05 RID: 84997 RVA: 0x0030363E File Offset: 0x0030183E
		// (set) Token: 0x06014C06 RID: 84998 RVA: 0x00303646 File Offset: 0x00301846
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

		// Token: 0x06014C07 RID: 84999 RVA: 0x0030364F File Offset: 0x0030184F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReviveResponse);
		}

		// Token: 0x06014C08 RID: 85000 RVA: 0x0030365D File Offset: 0x0030185D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReviveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014C09 RID: 85001 RVA: 0x0030368C File Offset: 0x0030188C
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

		// Token: 0x06014C0A RID: 85002 RVA: 0x003036D1 File Offset: 0x003018D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014C0B RID: 85003 RVA: 0x003036DE File Offset: 0x003018DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014C0C RID: 85004 RVA: 0x003036E7 File Offset: 0x003018E7
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

		// Token: 0x06014C0D RID: 85005 RVA: 0x0030371C File Offset: 0x0030191C
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

		// Token: 0x06014C0E RID: 85006 RVA: 0x0030375A File Offset: 0x0030195A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReviveResponse other)
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

		// Token: 0x06014C0F RID: 85007 RVA: 0x0030378B File Offset: 0x0030198B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014C10 RID: 85008 RVA: 0x00303794 File Offset: 0x00301994
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

		// Token: 0x04007DBE RID: 32190
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007DBF RID: 32191
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04007DC0 RID: 32192
		private ErrorCode errorCode_;
	}
}
