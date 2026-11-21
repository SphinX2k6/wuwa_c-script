using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012E8 RID: 4840
	[NetMessage(EMessageId.SpringFestivalScoreRewardResponse)]
	public sealed class SpringFestivalScoreRewardResponse : IMessage<SpringFestivalScoreRewardResponse>, IMessage, IEquatable<SpringFestivalScoreRewardResponse>, IDeepCloneable<SpringFestivalScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x06019D44 RID: 105796 RVA: 0x003C4C3C File Offset: 0x003C2E3C
		[NullableContext(1)]
		public static SpringFestivalScoreRewardResponse Create()
		{
			return new SpringFestivalScoreRewardResponse();
		}

		// Token: 0x1700577F RID: 22399
		// (get) Token: 0x06019D45 RID: 105797 RVA: 0x003C4C43 File Offset: 0x003C2E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005780 RID: 22400
		// (get) Token: 0x06019D46 RID: 105798 RVA: 0x003C4C46 File Offset: 0x003C2E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringFestivalScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x06019D47 RID: 105799 RVA: 0x003C4C4D File Offset: 0x003C2E4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalScoreRewardResponse()
		{
		}

		// Token: 0x06019D48 RID: 105800 RVA: 0x003C4C55 File Offset: 0x003C2E55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalScoreRewardResponse(SpringFestivalScoreRewardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019D49 RID: 105801 RVA: 0x003C4C7A File Offset: 0x003C2E7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalScoreRewardResponse Clone()
		{
			return new SpringFestivalScoreRewardResponse(this);
		}

		// Token: 0x17005781 RID: 22401
		// (get) Token: 0x06019D4A RID: 105802 RVA: 0x003C4C82 File Offset: 0x003C2E82
		// (set) Token: 0x06019D4B RID: 105803 RVA: 0x003C4C8A File Offset: 0x003C2E8A
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

		// Token: 0x06019D4C RID: 105804 RVA: 0x003C4C93 File Offset: 0x003C2E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringFestivalScoreRewardResponse);
		}

		// Token: 0x06019D4D RID: 105805 RVA: 0x003C4CA1 File Offset: 0x003C2EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringFestivalScoreRewardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019D4E RID: 105806 RVA: 0x003C4CD0 File Offset: 0x003C2ED0
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

		// Token: 0x06019D4F RID: 105807 RVA: 0x003C4D15 File Offset: 0x003C2F15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019D50 RID: 105808 RVA: 0x003C4D22 File Offset: 0x003C2F22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019D51 RID: 105809 RVA: 0x003C4D2B File Offset: 0x003C2F2B
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

		// Token: 0x06019D52 RID: 105810 RVA: 0x003C4D60 File Offset: 0x003C2F60
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

		// Token: 0x06019D53 RID: 105811 RVA: 0x003C4D9E File Offset: 0x003C2F9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringFestivalScoreRewardResponse other)
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

		// Token: 0x06019D54 RID: 105812 RVA: 0x003C4DCF File Offset: 0x003C2FCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019D55 RID: 105813 RVA: 0x003C4DD8 File Offset: 0x003C2FD8
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

		// Token: 0x04009879 RID: 39033
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400987A RID: 39034
		public const int ErrCodeFieldNumber = 15;

		// Token: 0x0400987B RID: 39035
		private ErrorCode errCode_;
	}
}
