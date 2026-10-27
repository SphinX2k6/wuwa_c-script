using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200068D RID: 1677
	[NetMessage(EMessageId.GachaAccumulateRewardResponse)]
	public sealed class GachaAccumulateRewardResponse : IMessage<GachaAccumulateRewardResponse>, IMessage, IEquatable<GachaAccumulateRewardResponse>, IDeepCloneable<GachaAccumulateRewardResponse>, IBufferMessage
	{
		// Token: 0x0600997F RID: 39295 RVA: 0x00171CC4 File Offset: 0x0016FEC4
		[NullableContext(1)]
		public static GachaAccumulateRewardResponse Create()
		{
			return new GachaAccumulateRewardResponse();
		}

		// Token: 0x17001E9D RID: 7837
		// (get) Token: 0x06009980 RID: 39296 RVA: 0x00171CCB File Offset: 0x0016FECB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E9E RID: 7838
		// (get) Token: 0x06009981 RID: 39297 RVA: 0x00171CCE File Offset: 0x0016FECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaAccumulateRewardResponse.Descriptor;
			}
		}

		// Token: 0x06009982 RID: 39298 RVA: 0x00171CD5 File Offset: 0x0016FED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateRewardResponse()
		{
		}

		// Token: 0x06009983 RID: 39299 RVA: 0x00171CDD File Offset: 0x0016FEDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateRewardResponse(GachaAccumulateRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009984 RID: 39300 RVA: 0x00171D02 File Offset: 0x0016FF02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateRewardResponse Clone()
		{
			return new GachaAccumulateRewardResponse(this);
		}

		// Token: 0x17001E9F RID: 7839
		// (get) Token: 0x06009985 RID: 39301 RVA: 0x00171D0A File Offset: 0x0016FF0A
		// (set) Token: 0x06009986 RID: 39302 RVA: 0x00171D12 File Offset: 0x0016FF12
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

		// Token: 0x06009987 RID: 39303 RVA: 0x00171D1B File Offset: 0x0016FF1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaAccumulateRewardResponse);
		}

		// Token: 0x06009988 RID: 39304 RVA: 0x00171D29 File Offset: 0x0016FF29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaAccumulateRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009989 RID: 39305 RVA: 0x00171D58 File Offset: 0x0016FF58
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

		// Token: 0x0600998A RID: 39306 RVA: 0x00171D9D File Offset: 0x0016FF9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600998B RID: 39307 RVA: 0x00171DAA File Offset: 0x0016FFAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600998C RID: 39308 RVA: 0x00171DB3 File Offset: 0x0016FFB3
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

		// Token: 0x0600998D RID: 39309 RVA: 0x00171DE8 File Offset: 0x0016FFE8
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

		// Token: 0x0600998E RID: 39310 RVA: 0x00171E26 File Offset: 0x00170026
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

		// Token: 0x0600998F RID: 39311 RVA: 0x00171E57 File Offset: 0x00170057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009990 RID: 39312 RVA: 0x00171E60 File Offset: 0x00170060
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

		// Token: 0x0400489D RID: 18589
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400489E RID: 18590
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400489F RID: 18591
		private ErrorCode errorCode_;
	}
}
