using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015AA RID: 5546
	[NetMessage(EMessageId.ZitherPlayStateResponse)]
	public sealed class ZitherPlayStateResponse : IMessage<ZitherPlayStateResponse>, IMessage, IEquatable<ZitherPlayStateResponse>, IDeepCloneable<ZitherPlayStateResponse>, IBufferMessage
	{
		// Token: 0x0601D59B RID: 120219 RVA: 0x0043F701 File Offset: 0x0043D901
		[NullableContext(1)]
		public static ZitherPlayStateResponse Create()
		{
			return new ZitherPlayStateResponse();
		}

		// Token: 0x1700634A RID: 25418
		// (get) Token: 0x0601D59C RID: 120220 RVA: 0x0043F708 File Offset: 0x0043D908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700634B RID: 25419
		// (get) Token: 0x0601D59D RID: 120221 RVA: 0x0043F70B File Offset: 0x0043D90B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ZitherPlayStateResponse.Descriptor;
			}
		}

		// Token: 0x0601D59E RID: 120222 RVA: 0x0043F712 File Offset: 0x0043D912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherPlayStateResponse()
		{
		}

		// Token: 0x0601D59F RID: 120223 RVA: 0x0043F71A File Offset: 0x0043D91A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherPlayStateResponse(ZitherPlayStateResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D5A0 RID: 120224 RVA: 0x0043F73F File Offset: 0x0043D93F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherPlayStateResponse Clone()
		{
			return new ZitherPlayStateResponse(this);
		}

		// Token: 0x1700634C RID: 25420
		// (get) Token: 0x0601D5A1 RID: 120225 RVA: 0x0043F747 File Offset: 0x0043D947
		// (set) Token: 0x0601D5A2 RID: 120226 RVA: 0x0043F74F File Offset: 0x0043D94F
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

		// Token: 0x0601D5A3 RID: 120227 RVA: 0x0043F758 File Offset: 0x0043D958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ZitherPlayStateResponse);
		}

		// Token: 0x0601D5A4 RID: 120228 RVA: 0x0043F766 File Offset: 0x0043D966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ZitherPlayStateResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D5A5 RID: 120229 RVA: 0x0043F794 File Offset: 0x0043D994
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

		// Token: 0x0601D5A6 RID: 120230 RVA: 0x0043F7D9 File Offset: 0x0043D9D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D5A7 RID: 120231 RVA: 0x0043F7E6 File Offset: 0x0043D9E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D5A8 RID: 120232 RVA: 0x0043F7EF File Offset: 0x0043D9EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D5A9 RID: 120233 RVA: 0x0043F824 File Offset: 0x0043DA24
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

		// Token: 0x0601D5AA RID: 120234 RVA: 0x0043F862 File Offset: 0x0043DA62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ZitherPlayStateResponse other)
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

		// Token: 0x0601D5AB RID: 120235 RVA: 0x0043F893 File Offset: 0x0043DA93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D5AC RID: 120236 RVA: 0x0043F89C File Offset: 0x0043DA9C
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A836 RID: 43062
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A837 RID: 43063
		public const int ErrCodeFieldNumber = 15;

		// Token: 0x0400A838 RID: 43064
		private ErrorCode errCode_;
	}
}
