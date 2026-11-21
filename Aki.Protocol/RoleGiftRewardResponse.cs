using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001071 RID: 4209
	[NetMessage(EMessageId.RoleGiftRewardResponse)]
	public sealed class RoleGiftRewardResponse : IMessage<RoleGiftRewardResponse>, IMessage, IEquatable<RoleGiftRewardResponse>, IDeepCloneable<RoleGiftRewardResponse>, IBufferMessage
	{
		// Token: 0x06016839 RID: 92217 RVA: 0x00346475 File Offset: 0x00344675
		[NullableContext(1)]
		public static RoleGiftRewardResponse Create()
		{
			return new RoleGiftRewardResponse();
		}

		// Token: 0x17004B65 RID: 19301
		// (get) Token: 0x0601683A RID: 92218 RVA: 0x0034647C File Offset: 0x0034467C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B66 RID: 19302
		// (get) Token: 0x0601683B RID: 92219 RVA: 0x0034647F File Offset: 0x0034467F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleGiftRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601683C RID: 92220 RVA: 0x00346486 File Offset: 0x00344686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGiftRewardResponse()
		{
		}

		// Token: 0x0601683D RID: 92221 RVA: 0x0034648E File Offset: 0x0034468E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGiftRewardResponse(RoleGiftRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601683E RID: 92222 RVA: 0x003464B3 File Offset: 0x003446B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGiftRewardResponse Clone()
		{
			return new RoleGiftRewardResponse(this);
		}

		// Token: 0x17004B67 RID: 19303
		// (get) Token: 0x0601683F RID: 92223 RVA: 0x003464BB File Offset: 0x003446BB
		// (set) Token: 0x06016840 RID: 92224 RVA: 0x003464C3 File Offset: 0x003446C3
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

		// Token: 0x06016841 RID: 92225 RVA: 0x003464CC File Offset: 0x003446CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleGiftRewardResponse);
		}

		// Token: 0x06016842 RID: 92226 RVA: 0x003464DA File Offset: 0x003446DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleGiftRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016843 RID: 92227 RVA: 0x00346508 File Offset: 0x00344708
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

		// Token: 0x06016844 RID: 92228 RVA: 0x0034654D File Offset: 0x0034474D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016845 RID: 92229 RVA: 0x0034655A File Offset: 0x0034475A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016846 RID: 92230 RVA: 0x00346563 File Offset: 0x00344763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016847 RID: 92231 RVA: 0x00346598 File Offset: 0x00344798
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

		// Token: 0x06016848 RID: 92232 RVA: 0x003465D6 File Offset: 0x003447D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleGiftRewardResponse other)
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

		// Token: 0x06016849 RID: 92233 RVA: 0x00346607 File Offset: 0x00344807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601684A RID: 92234 RVA: 0x00346610 File Offset: 0x00344810
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008706 RID: 34566
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008707 RID: 34567
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04008708 RID: 34568
		private ErrorCode errorCode_;
	}
}
