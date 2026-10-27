using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000A2 RID: 162
	[NetMessage(EMessageId.AddDecalResponse)]
	public sealed class AddDecalResponse : IMessage<AddDecalResponse>, IMessage, IEquatable<AddDecalResponse>, IDeepCloneable<AddDecalResponse>, IBufferMessage
	{
		// Token: 0x06001C6F RID: 7279 RVA: 0x0004EEED File Offset: 0x0004D0ED
		[NullableContext(1)]
		public static AddDecalResponse Create()
		{
			return new AddDecalResponse();
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06001C70 RID: 7280 RVA: 0x0004EEF4 File Offset: 0x0004D0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06001C71 RID: 7281 RVA: 0x0004EEF7 File Offset: 0x0004D0F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddDecalResponse.Descriptor;
			}
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x0004EEFE File Offset: 0x0004D0FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddDecalResponse()
		{
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x0004EF06 File Offset: 0x0004D106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddDecalResponse(AddDecalResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x0004EF2B File Offset: 0x0004D12B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddDecalResponse Clone()
		{
			return new AddDecalResponse(this);
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06001C75 RID: 7285 RVA: 0x0004EF33 File Offset: 0x0004D133
		// (set) Token: 0x06001C76 RID: 7286 RVA: 0x0004EF3B File Offset: 0x0004D13B
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

		// Token: 0x06001C77 RID: 7287 RVA: 0x0004EF44 File Offset: 0x0004D144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddDecalResponse);
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x0004EF52 File Offset: 0x0004D152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddDecalResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x0004EF80 File Offset: 0x0004D180
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

		// Token: 0x06001C7A RID: 7290 RVA: 0x0004EFC5 File Offset: 0x0004D1C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x0004EFD2 File Offset: 0x0004D1D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x0004EFDB File Offset: 0x0004D1DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x0004F010 File Offset: 0x0004D210
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

		// Token: 0x06001C7E RID: 7294 RVA: 0x0004F04E File Offset: 0x0004D24E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddDecalResponse other)
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

		// Token: 0x06001C7F RID: 7295 RVA: 0x0004F07F File Offset: 0x0004D27F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x0004F088 File Offset: 0x0004D288
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040022E0 RID: 8928
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022E1 RID: 8929
		public const int ErrCodeFieldNumber = 11;

		// Token: 0x040022E2 RID: 8930
		private ErrorCode errCode_;
	}
}
