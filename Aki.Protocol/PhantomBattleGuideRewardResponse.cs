using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C91 RID: 3217
	[NetMessage(EMessageId.PhantomBattleGuideRewardResponse)]
	public sealed class PhantomBattleGuideRewardResponse : IMessage<PhantomBattleGuideRewardResponse>, IMessage, IEquatable<PhantomBattleGuideRewardResponse>, IDeepCloneable<PhantomBattleGuideRewardResponse>, IBufferMessage
	{
		// Token: 0x06011708 RID: 71432 RVA: 0x0028E4CA File Offset: 0x0028C6CA
		[NullableContext(1)]
		public static PhantomBattleGuideRewardResponse Create()
		{
			return new PhantomBattleGuideRewardResponse();
		}

		// Token: 0x170039C5 RID: 14789
		// (get) Token: 0x06011709 RID: 71433 RVA: 0x0028E4D1 File Offset: 0x0028C6D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039C6 RID: 14790
		// (get) Token: 0x0601170A RID: 71434 RVA: 0x0028E4D4 File Offset: 0x0028C6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleGuideRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601170B RID: 71435 RVA: 0x0028E4DB File Offset: 0x0028C6DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGuideRewardResponse()
		{
		}

		// Token: 0x0601170C RID: 71436 RVA: 0x0028E4E3 File Offset: 0x0028C6E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGuideRewardResponse(PhantomBattleGuideRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601170D RID: 71437 RVA: 0x0028E508 File Offset: 0x0028C708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGuideRewardResponse Clone()
		{
			return new PhantomBattleGuideRewardResponse(this);
		}

		// Token: 0x170039C7 RID: 14791
		// (get) Token: 0x0601170E RID: 71438 RVA: 0x0028E510 File Offset: 0x0028C710
		// (set) Token: 0x0601170F RID: 71439 RVA: 0x0028E518 File Offset: 0x0028C718
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

		// Token: 0x06011710 RID: 71440 RVA: 0x0028E521 File Offset: 0x0028C721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleGuideRewardResponse);
		}

		// Token: 0x06011711 RID: 71441 RVA: 0x0028E52F File Offset: 0x0028C72F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleGuideRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011712 RID: 71442 RVA: 0x0028E560 File Offset: 0x0028C760
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

		// Token: 0x06011713 RID: 71443 RVA: 0x0028E5A5 File Offset: 0x0028C7A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011714 RID: 71444 RVA: 0x0028E5B2 File Offset: 0x0028C7B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011715 RID: 71445 RVA: 0x0028E5BB File Offset: 0x0028C7BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011716 RID: 71446 RVA: 0x0028E5F0 File Offset: 0x0028C7F0
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

		// Token: 0x06011717 RID: 71447 RVA: 0x0028E62E File Offset: 0x0028C82E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleGuideRewardResponse other)
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

		// Token: 0x06011718 RID: 71448 RVA: 0x0028E65F File Offset: 0x0028C85F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011719 RID: 71449 RVA: 0x0028E668 File Offset: 0x0028C868
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006E1D RID: 28189
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E1E RID: 28190
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04006E1F RID: 28191
		private ErrorCode errorCode_;
	}
}
