using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010B1 RID: 4273
	[NetMessage(EMessageId.RoleSkinTrialSettleNotify)]
	public sealed class RoleSkinTrialSettleNotify : IMessage<RoleSkinTrialSettleNotify>, IMessage, IEquatable<RoleSkinTrialSettleNotify>, IDeepCloneable<RoleSkinTrialSettleNotify>, IBufferMessage
	{
		// Token: 0x06016D5E RID: 93534 RVA: 0x003519A9 File Offset: 0x0034FBA9
		[NullableContext(1)]
		public static RoleSkinTrialSettleNotify Create()
		{
			return new RoleSkinTrialSettleNotify();
		}

		// Token: 0x17004C85 RID: 19589
		// (get) Token: 0x06016D5F RID: 93535 RVA: 0x003519B0 File Offset: 0x0034FBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C86 RID: 19590
		// (get) Token: 0x06016D60 RID: 93536 RVA: 0x003519B3 File Offset: 0x0034FBB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinTrialSettleNotify.Descriptor;
			}
		}

		// Token: 0x06016D61 RID: 93537 RVA: 0x003519BA File Offset: 0x0034FBBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialSettleNotify()
		{
		}

		// Token: 0x06016D62 RID: 93538 RVA: 0x003519C2 File Offset: 0x0034FBC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialSettleNotify(RoleSkinTrialSettleNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016D63 RID: 93539 RVA: 0x003519E7 File Offset: 0x0034FBE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialSettleNotify Clone()
		{
			return new RoleSkinTrialSettleNotify(this);
		}

		// Token: 0x17004C87 RID: 19591
		// (get) Token: 0x06016D64 RID: 93540 RVA: 0x003519EF File Offset: 0x0034FBEF
		// (set) Token: 0x06016D65 RID: 93541 RVA: 0x003519F7 File Offset: 0x0034FBF7
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

		// Token: 0x06016D66 RID: 93542 RVA: 0x00351A00 File Offset: 0x0034FC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinTrialSettleNotify);
		}

		// Token: 0x06016D67 RID: 93543 RVA: 0x00351A0E File Offset: 0x0034FC0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinTrialSettleNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016D68 RID: 93544 RVA: 0x00351A3C File Offset: 0x0034FC3C
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

		// Token: 0x06016D69 RID: 93545 RVA: 0x00351A81 File Offset: 0x0034FC81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016D6A RID: 93546 RVA: 0x00351A8E File Offset: 0x0034FC8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016D6B RID: 93547 RVA: 0x00351A97 File Offset: 0x0034FC97
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

		// Token: 0x06016D6C RID: 93548 RVA: 0x00351ACC File Offset: 0x0034FCCC
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

		// Token: 0x06016D6D RID: 93549 RVA: 0x00351B0A File Offset: 0x0034FD0A
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

		// Token: 0x06016D6E RID: 93550 RVA: 0x00351B3B File Offset: 0x0034FD3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016D6F RID: 93551 RVA: 0x00351B44 File Offset: 0x0034FD44
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

		// Token: 0x040088A4 RID: 34980
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088A5 RID: 34981
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x040088A6 RID: 34982
		private ErrorCode errorCode_;
	}
}
