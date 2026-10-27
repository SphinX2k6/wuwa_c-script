using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000527 RID: 1319
	[NetMessage(EMessageId.FarmGoldPointRepeatedResponse)]
	public sealed class FarmGoldPointRepeatedResponse : IMessage<FarmGoldPointRepeatedResponse>, IMessage, IEquatable<FarmGoldPointRepeatedResponse>, IDeepCloneable<FarmGoldPointRepeatedResponse>, IBufferMessage
	{
		// Token: 0x06007BBA RID: 31674 RVA: 0x0012C0AC File Offset: 0x0012A2AC
		[NullableContext(1)]
		public static FarmGoldPointRepeatedResponse Create()
		{
			return new FarmGoldPointRepeatedResponse();
		}

		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x06007BBB RID: 31675 RVA: 0x0012C0B3 File Offset: 0x0012A2B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x06007BBC RID: 31676 RVA: 0x0012C0B6 File Offset: 0x0012A2B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldPointRepeatedResponse.Descriptor;
			}
		}

		// Token: 0x06007BBD RID: 31677 RVA: 0x0012C0BD File Offset: 0x0012A2BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldPointRepeatedResponse()
		{
		}

		// Token: 0x06007BBE RID: 31678 RVA: 0x0012C0C5 File Offset: 0x0012A2C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldPointRepeatedResponse(FarmGoldPointRepeatedResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007BBF RID: 31679 RVA: 0x0012C0EA File Offset: 0x0012A2EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldPointRepeatedResponse Clone()
		{
			return new FarmGoldPointRepeatedResponse(this);
		}

		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x06007BC0 RID: 31680 RVA: 0x0012C0F2 File Offset: 0x0012A2F2
		// (set) Token: 0x06007BC1 RID: 31681 RVA: 0x0012C0FA File Offset: 0x0012A2FA
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

		// Token: 0x06007BC2 RID: 31682 RVA: 0x0012C103 File Offset: 0x0012A303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldPointRepeatedResponse);
		}

		// Token: 0x06007BC3 RID: 31683 RVA: 0x0012C111 File Offset: 0x0012A311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldPointRepeatedResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007BC4 RID: 31684 RVA: 0x0012C140 File Offset: 0x0012A340
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

		// Token: 0x06007BC5 RID: 31685 RVA: 0x0012C185 File Offset: 0x0012A385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007BC6 RID: 31686 RVA: 0x0012C192 File Offset: 0x0012A392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007BC7 RID: 31687 RVA: 0x0012C19B File Offset: 0x0012A39B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007BC8 RID: 31688 RVA: 0x0012C1D0 File Offset: 0x0012A3D0
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

		// Token: 0x06007BC9 RID: 31689 RVA: 0x0012C20E File Offset: 0x0012A40E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldPointRepeatedResponse other)
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

		// Token: 0x06007BCA RID: 31690 RVA: 0x0012C23F File Offset: 0x0012A43F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007BCB RID: 31691 RVA: 0x0012C248 File Offset: 0x0012A448
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003F41 RID: 16193
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F42 RID: 16194
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04003F43 RID: 16195
		private ErrorCode errorCode_;
	}
}
