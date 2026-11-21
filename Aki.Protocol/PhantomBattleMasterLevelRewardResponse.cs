using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C89 RID: 3209
	[NetMessage(EMessageId.PhantomBattleMasterLevelRewardResponse)]
	public sealed class PhantomBattleMasterLevelRewardResponse : IMessage<PhantomBattleMasterLevelRewardResponse>, IMessage, IEquatable<PhantomBattleMasterLevelRewardResponse>, IDeepCloneable<PhantomBattleMasterLevelRewardResponse>, IBufferMessage
	{
		// Token: 0x060116AC RID: 71340 RVA: 0x0028DD5D File Offset: 0x0028BF5D
		[NullableContext(1)]
		public static PhantomBattleMasterLevelRewardResponse Create()
		{
			return new PhantomBattleMasterLevelRewardResponse();
		}

		// Token: 0x170039B0 RID: 14768
		// (get) Token: 0x060116AD RID: 71341 RVA: 0x0028DD64 File Offset: 0x0028BF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039B1 RID: 14769
		// (get) Token: 0x060116AE RID: 71342 RVA: 0x0028DD67 File Offset: 0x0028BF67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleMasterLevelRewardResponse.Descriptor;
			}
		}

		// Token: 0x060116AF RID: 71343 RVA: 0x0028DD6E File Offset: 0x0028BF6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterLevelRewardResponse()
		{
		}

		// Token: 0x060116B0 RID: 71344 RVA: 0x0028DD76 File Offset: 0x0028BF76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterLevelRewardResponse(PhantomBattleMasterLevelRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060116B1 RID: 71345 RVA: 0x0028DD9B File Offset: 0x0028BF9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterLevelRewardResponse Clone()
		{
			return new PhantomBattleMasterLevelRewardResponse(this);
		}

		// Token: 0x170039B2 RID: 14770
		// (get) Token: 0x060116B2 RID: 71346 RVA: 0x0028DDA3 File Offset: 0x0028BFA3
		// (set) Token: 0x060116B3 RID: 71347 RVA: 0x0028DDAB File Offset: 0x0028BFAB
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

		// Token: 0x060116B4 RID: 71348 RVA: 0x0028DDB4 File Offset: 0x0028BFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleMasterLevelRewardResponse);
		}

		// Token: 0x060116B5 RID: 71349 RVA: 0x0028DDC2 File Offset: 0x0028BFC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleMasterLevelRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060116B6 RID: 71350 RVA: 0x0028DDF0 File Offset: 0x0028BFF0
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

		// Token: 0x060116B7 RID: 71351 RVA: 0x0028DE35 File Offset: 0x0028C035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060116B8 RID: 71352 RVA: 0x0028DE42 File Offset: 0x0028C042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060116B9 RID: 71353 RVA: 0x0028DE4B File Offset: 0x0028C04B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060116BA RID: 71354 RVA: 0x0028DE80 File Offset: 0x0028C080
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

		// Token: 0x060116BB RID: 71355 RVA: 0x0028DEBE File Offset: 0x0028C0BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleMasterLevelRewardResponse other)
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

		// Token: 0x060116BC RID: 71356 RVA: 0x0028DEEF File Offset: 0x0028C0EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060116BD RID: 71357 RVA: 0x0028DEF8 File Offset: 0x0028C0F8
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006E5E RID: 28254
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E5F RID: 28255
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04006E60 RID: 28256
		private ErrorCode errorCode_;
	}
}
