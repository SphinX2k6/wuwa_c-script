using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001A2 RID: 418
	[NetMessage(EMessageId.BirthDayRewardResponse)]
	public sealed class BirthDayRewardResponse : IMessage<BirthDayRewardResponse>, IMessage, IEquatable<BirthDayRewardResponse>, IDeepCloneable<BirthDayRewardResponse>, IBufferMessage
	{
		// Token: 0x06003160 RID: 12640 RVA: 0x0007DD11 File Offset: 0x0007BF11
		[NullableContext(1)]
		public static BirthDayRewardResponse Create()
		{
			return new BirthDayRewardResponse();
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06003161 RID: 12641 RVA: 0x0007DD18 File Offset: 0x0007BF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06003162 RID: 12642 RVA: 0x0007DD1B File Offset: 0x0007BF1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BirthDayRewardResponse.Descriptor;
			}
		}

		// Token: 0x06003163 RID: 12643 RVA: 0x0007DD22 File Offset: 0x0007BF22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayRewardResponse()
		{
		}

		// Token: 0x06003164 RID: 12644 RVA: 0x0007DD2A File Offset: 0x0007BF2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayRewardResponse(BirthDayRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003165 RID: 12645 RVA: 0x0007DD4F File Offset: 0x0007BF4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayRewardResponse Clone()
		{
			return new BirthDayRewardResponse(this);
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06003166 RID: 12646 RVA: 0x0007DD57 File Offset: 0x0007BF57
		// (set) Token: 0x06003167 RID: 12647 RVA: 0x0007DD5F File Offset: 0x0007BF5F
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

		// Token: 0x06003168 RID: 12648 RVA: 0x0007DD68 File Offset: 0x0007BF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BirthDayRewardResponse);
		}

		// Token: 0x06003169 RID: 12649 RVA: 0x0007DD76 File Offset: 0x0007BF76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BirthDayRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600316A RID: 12650 RVA: 0x0007DDA4 File Offset: 0x0007BFA4
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

		// Token: 0x0600316B RID: 12651 RVA: 0x0007DDE9 File Offset: 0x0007BFE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600316C RID: 12652 RVA: 0x0007DDF6 File Offset: 0x0007BFF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600316D RID: 12653 RVA: 0x0007DDFF File Offset: 0x0007BFFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600316E RID: 12654 RVA: 0x0007DE34 File Offset: 0x0007C034
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

		// Token: 0x0600316F RID: 12655 RVA: 0x0007DE72 File Offset: 0x0007C072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BirthDayRewardResponse other)
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

		// Token: 0x06003170 RID: 12656 RVA: 0x0007DEA3 File Offset: 0x0007C0A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003171 RID: 12657 RVA: 0x0007DEAC File Offset: 0x0007C0AC
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002984 RID: 10628
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002985 RID: 10629
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04002986 RID: 10630
		private ErrorCode errorCode_;
	}
}
