using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013B2 RID: 5042
	[NetMessage(EMessageId.TowerDefenceScoreRewardResponse)]
	public sealed class TowerDefenceScoreRewardResponse : IMessage<TowerDefenceScoreRewardResponse>, IMessage, IEquatable<TowerDefenceScoreRewardResponse>, IDeepCloneable<TowerDefenceScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x0601AC06 RID: 109574 RVA: 0x003E1345 File Offset: 0x003DF545
		[NullableContext(1)]
		public static TowerDefenceScoreRewardResponse Create()
		{
			return new TowerDefenceScoreRewardResponse();
		}

		// Token: 0x17005A39 RID: 23097
		// (get) Token: 0x0601AC07 RID: 109575 RVA: 0x003E134C File Offset: 0x003DF54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A3A RID: 23098
		// (get) Token: 0x0601AC08 RID: 109576 RVA: 0x003E134F File Offset: 0x003DF54F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601AC09 RID: 109577 RVA: 0x003E1356 File Offset: 0x003DF556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceScoreRewardResponse()
		{
		}

		// Token: 0x0601AC0A RID: 109578 RVA: 0x003E135E File Offset: 0x003DF55E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceScoreRewardResponse(TowerDefenceScoreRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AC0B RID: 109579 RVA: 0x003E1383 File Offset: 0x003DF583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceScoreRewardResponse Clone()
		{
			return new TowerDefenceScoreRewardResponse(this);
		}

		// Token: 0x17005A3B RID: 23099
		// (get) Token: 0x0601AC0C RID: 109580 RVA: 0x003E138B File Offset: 0x003DF58B
		// (set) Token: 0x0601AC0D RID: 109581 RVA: 0x003E1393 File Offset: 0x003DF593
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

		// Token: 0x0601AC0E RID: 109582 RVA: 0x003E139C File Offset: 0x003DF59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceScoreRewardResponse);
		}

		// Token: 0x0601AC0F RID: 109583 RVA: 0x003E13AA File Offset: 0x003DF5AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceScoreRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AC10 RID: 109584 RVA: 0x003E13D8 File Offset: 0x003DF5D8
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

		// Token: 0x0601AC11 RID: 109585 RVA: 0x003E141D File Offset: 0x003DF61D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AC12 RID: 109586 RVA: 0x003E142A File Offset: 0x003DF62A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AC13 RID: 109587 RVA: 0x003E1433 File Offset: 0x003DF633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AC14 RID: 109588 RVA: 0x003E1468 File Offset: 0x003DF668
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

		// Token: 0x0601AC15 RID: 109589 RVA: 0x003E14A6 File Offset: 0x003DF6A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceScoreRewardResponse other)
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

		// Token: 0x0601AC16 RID: 109590 RVA: 0x003E14D7 File Offset: 0x003DF6D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AC17 RID: 109591 RVA: 0x003E14E0 File Offset: 0x003DF6E0
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009B58 RID: 39768
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B59 RID: 39769
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04009B5A RID: 39770
		private ErrorCode errorCode_;
	}
}
