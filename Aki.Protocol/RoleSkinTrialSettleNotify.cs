using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010C1 RID: 4289
	[NetMessage(EMessageId.RoleSkinTrialSettleNotify)]
	public sealed class RoleSkinTrialSettleNotify : IMessage<RoleSkinTrialSettleNotify>, IMessage, IEquatable<RoleSkinTrialSettleNotify>, IDeepCloneable<RoleSkinTrialSettleNotify>, IBufferMessage
	{
		// Token: 0x06016E43 RID: 93763 RVA: 0x00353085 File Offset: 0x00351285
		[NullableContext(1)]
		public static RoleSkinTrialSettleNotify Create()
		{
			return new RoleSkinTrialSettleNotify();
		}

		// Token: 0x17004CAF RID: 19631
		// (get) Token: 0x06016E44 RID: 93764 RVA: 0x0035308C File Offset: 0x0035128C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CB0 RID: 19632
		// (get) Token: 0x06016E45 RID: 93765 RVA: 0x0035308F File Offset: 0x0035128F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinTrialSettleNotify.Descriptor;
			}
		}

		// Token: 0x06016E46 RID: 93766 RVA: 0x00353096 File Offset: 0x00351296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialSettleNotify()
		{
		}

		// Token: 0x06016E47 RID: 93767 RVA: 0x0035309E File Offset: 0x0035129E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialSettleNotify(RoleSkinTrialSettleNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016E48 RID: 93768 RVA: 0x003530C3 File Offset: 0x003512C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialSettleNotify Clone()
		{
			return new RoleSkinTrialSettleNotify(this);
		}

		// Token: 0x17004CB1 RID: 19633
		// (get) Token: 0x06016E49 RID: 93769 RVA: 0x003530CB File Offset: 0x003512CB
		// (set) Token: 0x06016E4A RID: 93770 RVA: 0x003530D3 File Offset: 0x003512D3
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

		// Token: 0x06016E4B RID: 93771 RVA: 0x003530DC File Offset: 0x003512DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinTrialSettleNotify);
		}

		// Token: 0x06016E4C RID: 93772 RVA: 0x003530EA File Offset: 0x003512EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinTrialSettleNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016E4D RID: 93773 RVA: 0x00353118 File Offset: 0x00351318
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

		// Token: 0x06016E4E RID: 93774 RVA: 0x0035315D File Offset: 0x0035135D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016E4F RID: 93775 RVA: 0x0035316A File Offset: 0x0035136A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016E50 RID: 93776 RVA: 0x00353173 File Offset: 0x00351373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016E51 RID: 93777 RVA: 0x003531A8 File Offset: 0x003513A8
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

		// Token: 0x06016E52 RID: 93778 RVA: 0x003531E6 File Offset: 0x003513E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkinTrialSettleNotify other)
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

		// Token: 0x06016E53 RID: 93779 RVA: 0x00353217 File Offset: 0x00351417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016E54 RID: 93780 RVA: 0x00353220 File Offset: 0x00351420
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400887A RID: 34938
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400887B RID: 34939
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x0400887C RID: 34940
		private ErrorCode errorCode_;
	}
}
