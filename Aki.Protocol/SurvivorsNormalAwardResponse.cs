using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001343 RID: 4931
	[NetMessage(EMessageId.SurvivorsNormalAwardResponse)]
	public sealed class SurvivorsNormalAwardResponse : IMessage<SurvivorsNormalAwardResponse>, IMessage, IEquatable<SurvivorsNormalAwardResponse>, IDeepCloneable<SurvivorsNormalAwardResponse>, IBufferMessage
	{
		// Token: 0x0601A477 RID: 107639 RVA: 0x003D48B9 File Offset: 0x003D2AB9
		[NullableContext(1)]
		public static SurvivorsNormalAwardResponse Create()
		{
			return new SurvivorsNormalAwardResponse();
		}

		// Token: 0x170058FF RID: 22783
		// (get) Token: 0x0601A478 RID: 107640 RVA: 0x003D48C0 File Offset: 0x003D2AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005900 RID: 22784
		// (get) Token: 0x0601A479 RID: 107641 RVA: 0x003D48C3 File Offset: 0x003D2AC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsNormalAwardResponse.Descriptor;
			}
		}

		// Token: 0x0601A47A RID: 107642 RVA: 0x003D48CA File Offset: 0x003D2ACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsNormalAwardResponse()
		{
		}

		// Token: 0x0601A47B RID: 107643 RVA: 0x003D48D2 File Offset: 0x003D2AD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsNormalAwardResponse(SurvivorsNormalAwardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A47C RID: 107644 RVA: 0x003D48F7 File Offset: 0x003D2AF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsNormalAwardResponse Clone()
		{
			return new SurvivorsNormalAwardResponse(this);
		}

		// Token: 0x17005901 RID: 22785
		// (get) Token: 0x0601A47D RID: 107645 RVA: 0x003D48FF File Offset: 0x003D2AFF
		// (set) Token: 0x0601A47E RID: 107646 RVA: 0x003D4907 File Offset: 0x003D2B07
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

		// Token: 0x0601A47F RID: 107647 RVA: 0x003D4910 File Offset: 0x003D2B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsNormalAwardResponse);
		}

		// Token: 0x0601A480 RID: 107648 RVA: 0x003D491E File Offset: 0x003D2B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsNormalAwardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A481 RID: 107649 RVA: 0x003D494C File Offset: 0x003D2B4C
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

		// Token: 0x0601A482 RID: 107650 RVA: 0x003D4991 File Offset: 0x003D2B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A483 RID: 107651 RVA: 0x003D499E File Offset: 0x003D2B9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A484 RID: 107652 RVA: 0x003D49A7 File Offset: 0x003D2BA7
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

		// Token: 0x0601A485 RID: 107653 RVA: 0x003D49DC File Offset: 0x003D2BDC
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

		// Token: 0x0601A486 RID: 107654 RVA: 0x003D4A1A File Offset: 0x003D2C1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsNormalAwardResponse other)
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

		// Token: 0x0601A487 RID: 107655 RVA: 0x003D4A4B File Offset: 0x003D2C4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A488 RID: 107656 RVA: 0x003D4A54 File Offset: 0x003D2C54
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

		// Token: 0x04009A7F RID: 39551
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A80 RID: 39552
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04009A81 RID: 39553
		private ErrorCode errorCode_;
	}
}
