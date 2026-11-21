using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C96 RID: 3222
	[NetMessage(EMessageId.PhantomBattleRepeatedTaskRewardResponse)]
	public sealed class PhantomBattleRepeatedTaskRewardResponse : IMessage<PhantomBattleRepeatedTaskRewardResponse>, IMessage, IEquatable<PhantomBattleRepeatedTaskRewardResponse>, IDeepCloneable<PhantomBattleRepeatedTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x060117BF RID: 71615 RVA: 0x002904A9 File Offset: 0x0028E6A9
		[NullableContext(1)]
		public static PhantomBattleRepeatedTaskRewardResponse Create()
		{
			return new PhantomBattleRepeatedTaskRewardResponse();
		}

		// Token: 0x170039EC RID: 14828
		// (get) Token: 0x060117C0 RID: 71616 RVA: 0x002904B0 File Offset: 0x0028E6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039ED RID: 14829
		// (get) Token: 0x060117C1 RID: 71617 RVA: 0x002904B3 File Offset: 0x0028E6B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleRepeatedTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x060117C2 RID: 71618 RVA: 0x002904BA File Offset: 0x0028E6BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRepeatedTaskRewardResponse()
		{
		}

		// Token: 0x060117C3 RID: 71619 RVA: 0x002904C2 File Offset: 0x0028E6C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRepeatedTaskRewardResponse(PhantomBattleRepeatedTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060117C4 RID: 71620 RVA: 0x002904E7 File Offset: 0x0028E6E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRepeatedTaskRewardResponse Clone()
		{
			return new PhantomBattleRepeatedTaskRewardResponse(this);
		}

		// Token: 0x170039EE RID: 14830
		// (get) Token: 0x060117C5 RID: 71621 RVA: 0x002904EF File Offset: 0x0028E6EF
		// (set) Token: 0x060117C6 RID: 71622 RVA: 0x002904F7 File Offset: 0x0028E6F7
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

		// Token: 0x060117C7 RID: 71623 RVA: 0x00290500 File Offset: 0x0028E700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleRepeatedTaskRewardResponse);
		}

		// Token: 0x060117C8 RID: 71624 RVA: 0x0029050E File Offset: 0x0028E70E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleRepeatedTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060117C9 RID: 71625 RVA: 0x0029053C File Offset: 0x0028E73C
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

		// Token: 0x060117CA RID: 71626 RVA: 0x00290581 File Offset: 0x0028E781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060117CB RID: 71627 RVA: 0x0029058E File Offset: 0x0028E78E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060117CC RID: 71628 RVA: 0x00290597 File Offset: 0x0028E797
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

		// Token: 0x060117CD RID: 71629 RVA: 0x002905CC File Offset: 0x0028E7CC
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

		// Token: 0x060117CE RID: 71630 RVA: 0x0029060A File Offset: 0x0028E80A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleRepeatedTaskRewardResponse other)
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

		// Token: 0x060117CF RID: 71631 RVA: 0x0029063B File Offset: 0x0028E83B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060117D0 RID: 71632 RVA: 0x00290644 File Offset: 0x0028E844
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

		// Token: 0x04006EB7 RID: 28343
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006EB8 RID: 28344
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04006EB9 RID: 28345
		private ErrorCode errorCode_;
	}
}
