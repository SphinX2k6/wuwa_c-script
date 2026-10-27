using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000543 RID: 1347
	[NetMessage(EMessageId.FishingActivityLimitRewardResponse)]
	public sealed class FishingActivityLimitRewardResponse : IMessage<FishingActivityLimitRewardResponse>, IMessage, IEquatable<FishingActivityLimitRewardResponse>, IDeepCloneable<FishingActivityLimitRewardResponse>, IBufferMessage
	{
		// Token: 0x06007E18 RID: 32280 RVA: 0x001316D9 File Offset: 0x0012F8D9
		[NullableContext(1)]
		public static FishingActivityLimitRewardResponse Create()
		{
			return new FishingActivityLimitRewardResponse();
		}

		// Token: 0x1700188B RID: 6283
		// (get) Token: 0x06007E19 RID: 32281 RVA: 0x001316E0 File Offset: 0x0012F8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700188C RID: 6284
		// (get) Token: 0x06007E1A RID: 32282 RVA: 0x001316E3 File Offset: 0x0012F8E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingActivityLimitRewardResponse.Descriptor;
			}
		}

		// Token: 0x06007E1B RID: 32283 RVA: 0x001316EA File Offset: 0x0012F8EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityLimitRewardResponse()
		{
		}

		// Token: 0x06007E1C RID: 32284 RVA: 0x001316F2 File Offset: 0x0012F8F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityLimitRewardResponse(FishingActivityLimitRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E1D RID: 32285 RVA: 0x00131717 File Offset: 0x0012F917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityLimitRewardResponse Clone()
		{
			return new FishingActivityLimitRewardResponse(this);
		}

		// Token: 0x1700188D RID: 6285
		// (get) Token: 0x06007E1E RID: 32286 RVA: 0x0013171F File Offset: 0x0012F91F
		// (set) Token: 0x06007E1F RID: 32287 RVA: 0x00131727 File Offset: 0x0012F927
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

		// Token: 0x06007E20 RID: 32288 RVA: 0x00131730 File Offset: 0x0012F930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingActivityLimitRewardResponse);
		}

		// Token: 0x06007E21 RID: 32289 RVA: 0x0013173E File Offset: 0x0012F93E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingActivityLimitRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007E22 RID: 32290 RVA: 0x0013176C File Offset: 0x0012F96C
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

		// Token: 0x06007E23 RID: 32291 RVA: 0x001317B1 File Offset: 0x0012F9B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007E24 RID: 32292 RVA: 0x001317BE File Offset: 0x0012F9BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E25 RID: 32293 RVA: 0x001317C7 File Offset: 0x0012F9C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E26 RID: 32294 RVA: 0x001317FC File Offset: 0x0012F9FC
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

		// Token: 0x06007E27 RID: 32295 RVA: 0x0013183A File Offset: 0x0012FA3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingActivityLimitRewardResponse other)
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

		// Token: 0x06007E28 RID: 32296 RVA: 0x0013186B File Offset: 0x0012FA6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E29 RID: 32297 RVA: 0x00131874 File Offset: 0x0012FA74
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004006 RID: 16390
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004007 RID: 16391
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04004008 RID: 16392
		private ErrorCode errorCode_;
	}
}
