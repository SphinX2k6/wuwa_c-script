using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EFB RID: 3835
	[NetMessage(EMessageId.RemoveSummonEntityResponse)]
	public sealed class RemoveSummonEntityResponse : IMessage<RemoveSummonEntityResponse>, IMessage, IEquatable<RemoveSummonEntityResponse>, IDeepCloneable<RemoveSummonEntityResponse>, IBufferMessage
	{
		// Token: 0x06014915 RID: 84245 RVA: 0x002FD400 File Offset: 0x002FB600
		[NullableContext(1)]
		public static RemoveSummonEntityResponse Create()
		{
			return new RemoveSummonEntityResponse();
		}

		// Token: 0x17004468 RID: 17512
		// (get) Token: 0x06014916 RID: 84246 RVA: 0x002FD407 File Offset: 0x002FB607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004469 RID: 17513
		// (get) Token: 0x06014917 RID: 84247 RVA: 0x002FD40A File Offset: 0x002FB60A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveSummonEntityResponse.Descriptor;
			}
		}

		// Token: 0x06014918 RID: 84248 RVA: 0x002FD411 File Offset: 0x002FB611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveSummonEntityResponse()
		{
		}

		// Token: 0x06014919 RID: 84249 RVA: 0x002FD419 File Offset: 0x002FB619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveSummonEntityResponse(RemoveSummonEntityResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601491A RID: 84250 RVA: 0x002FD43E File Offset: 0x002FB63E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveSummonEntityResponse Clone()
		{
			return new RemoveSummonEntityResponse(this);
		}

		// Token: 0x1700446A RID: 17514
		// (get) Token: 0x0601491B RID: 84251 RVA: 0x002FD446 File Offset: 0x002FB646
		// (set) Token: 0x0601491C RID: 84252 RVA: 0x002FD44E File Offset: 0x002FB64E
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

		// Token: 0x0601491D RID: 84253 RVA: 0x002FD457 File Offset: 0x002FB657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveSummonEntityResponse);
		}

		// Token: 0x0601491E RID: 84254 RVA: 0x002FD465 File Offset: 0x002FB665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveSummonEntityResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601491F RID: 84255 RVA: 0x002FD494 File Offset: 0x002FB694
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

		// Token: 0x06014920 RID: 84256 RVA: 0x002FD4D9 File Offset: 0x002FB6D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014921 RID: 84257 RVA: 0x002FD4E6 File Offset: 0x002FB6E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014922 RID: 84258 RVA: 0x002FD4EF File Offset: 0x002FB6EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014923 RID: 84259 RVA: 0x002FD524 File Offset: 0x002FB724
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

		// Token: 0x06014924 RID: 84260 RVA: 0x002FD562 File Offset: 0x002FB762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveSummonEntityResponse other)
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

		// Token: 0x06014925 RID: 84261 RVA: 0x002FD593 File Offset: 0x002FB793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014926 RID: 84262 RVA: 0x002FD59C File Offset: 0x002FB79C
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007CFE RID: 31998
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CFF RID: 31999
		public const int ErrCodeFieldNumber = 14;

		// Token: 0x04007D00 RID: 32000
		private ErrorCode errCode_;
	}
}
