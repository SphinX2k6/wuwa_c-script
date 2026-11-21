using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A02 RID: 2562
	[NetMessage(EMessageId.MoonPhaseRewardResponse)]
	public sealed class MoonPhaseRewardResponse : IMessage<MoonPhaseRewardResponse>, IMessage, IEquatable<MoonPhaseRewardResponse>, IDeepCloneable<MoonPhaseRewardResponse>, IBufferMessage
	{
		// Token: 0x0600E078 RID: 57464 RVA: 0x0020E74A File Offset: 0x0020C94A
		[NullableContext(1)]
		public static MoonPhaseRewardResponse Create()
		{
			return new MoonPhaseRewardResponse();
		}

		// Token: 0x17002D7C RID: 11644
		// (get) Token: 0x0600E079 RID: 57465 RVA: 0x0020E751 File Offset: 0x0020C951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D7D RID: 11645
		// (get) Token: 0x0600E07A RID: 57466 RVA: 0x0020E754 File Offset: 0x0020C954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoonPhaseRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600E07B RID: 57467 RVA: 0x0020E75B File Offset: 0x0020C95B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseRewardResponse()
		{
		}

		// Token: 0x0600E07C RID: 57468 RVA: 0x0020E763 File Offset: 0x0020C963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseRewardResponse(MoonPhaseRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E07D RID: 57469 RVA: 0x0020E788 File Offset: 0x0020C988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseRewardResponse Clone()
		{
			return new MoonPhaseRewardResponse(this);
		}

		// Token: 0x17002D7E RID: 11646
		// (get) Token: 0x0600E07E RID: 57470 RVA: 0x0020E790 File Offset: 0x0020C990
		// (set) Token: 0x0600E07F RID: 57471 RVA: 0x0020E798 File Offset: 0x0020C998
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

		// Token: 0x0600E080 RID: 57472 RVA: 0x0020E7A1 File Offset: 0x0020C9A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoonPhaseRewardResponse);
		}

		// Token: 0x0600E081 RID: 57473 RVA: 0x0020E7AF File Offset: 0x0020C9AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoonPhaseRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E082 RID: 57474 RVA: 0x0020E7E0 File Offset: 0x0020C9E0
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

		// Token: 0x0600E083 RID: 57475 RVA: 0x0020E825 File Offset: 0x0020CA25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E084 RID: 57476 RVA: 0x0020E832 File Offset: 0x0020CA32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E085 RID: 57477 RVA: 0x0020E83B File Offset: 0x0020CA3B
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

		// Token: 0x0600E086 RID: 57478 RVA: 0x0020E870 File Offset: 0x0020CA70
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

		// Token: 0x0600E087 RID: 57479 RVA: 0x0020E8AE File Offset: 0x0020CAAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoonPhaseRewardResponse other)
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

		// Token: 0x0600E088 RID: 57480 RVA: 0x0020E8DF File Offset: 0x0020CADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E089 RID: 57481 RVA: 0x0020E8E8 File Offset: 0x0020CAE8
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

		// Token: 0x04005CB7 RID: 23735
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005CB8 RID: 23736
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04005CB9 RID: 23737
		private ErrorCode errorCode_;
	}
}
