using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000679 RID: 1657
	[NetMessage(EMessageId.GachaAccumulateRewardResponse)]
	public sealed class GachaAccumulateRewardResponse : IMessage<GachaAccumulateRewardResponse>, IMessage, IEquatable<GachaAccumulateRewardResponse>, IDeepCloneable<GachaAccumulateRewardResponse>, IBufferMessage
	{
		// Token: 0x06009829 RID: 38953 RVA: 0x0016F290 File Offset: 0x0016D490
		[NullableContext(1)]
		public static GachaAccumulateRewardResponse Create()
		{
			return new GachaAccumulateRewardResponse();
		}

		// Token: 0x17001E53 RID: 7763
		// (get) Token: 0x0600982A RID: 38954 RVA: 0x0016F297 File Offset: 0x0016D497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E54 RID: 7764
		// (get) Token: 0x0600982B RID: 38955 RVA: 0x0016F29A File Offset: 0x0016D49A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaAccumulateRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600982C RID: 38956 RVA: 0x0016F2A1 File Offset: 0x0016D4A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateRewardResponse()
		{
		}

		// Token: 0x0600982D RID: 38957 RVA: 0x0016F2A9 File Offset: 0x0016D4A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateRewardResponse(GachaAccumulateRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600982E RID: 38958 RVA: 0x0016F2CE File Offset: 0x0016D4CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateRewardResponse Clone()
		{
			return new GachaAccumulateRewardResponse(this);
		}

		// Token: 0x17001E55 RID: 7765
		// (get) Token: 0x0600982F RID: 38959 RVA: 0x0016F2D6 File Offset: 0x0016D4D6
		// (set) Token: 0x06009830 RID: 38960 RVA: 0x0016F2DE File Offset: 0x0016D4DE
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

		// Token: 0x06009831 RID: 38961 RVA: 0x0016F2E7 File Offset: 0x0016D4E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaAccumulateRewardResponse);
		}

		// Token: 0x06009832 RID: 38962 RVA: 0x0016F2F5 File Offset: 0x0016D4F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaAccumulateRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009833 RID: 38963 RVA: 0x0016F324 File Offset: 0x0016D524
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

		// Token: 0x06009834 RID: 38964 RVA: 0x0016F369 File Offset: 0x0016D569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009835 RID: 38965 RVA: 0x0016F376 File Offset: 0x0016D576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009836 RID: 38966 RVA: 0x0016F37F File Offset: 0x0016D57F
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

		// Token: 0x06009837 RID: 38967 RVA: 0x0016F3B4 File Offset: 0x0016D5B4
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

		// Token: 0x06009838 RID: 38968 RVA: 0x0016F3F2 File Offset: 0x0016D5F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaAccumulateRewardResponse other)
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

		// Token: 0x06009839 RID: 38969 RVA: 0x0016F423 File Offset: 0x0016D623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600983A RID: 38970 RVA: 0x0016F42C File Offset: 0x0016D62C
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

		// Token: 0x04004896 RID: 18582
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004897 RID: 18583
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04004898 RID: 18584
		private ErrorCode errorCode_;
	}
}
