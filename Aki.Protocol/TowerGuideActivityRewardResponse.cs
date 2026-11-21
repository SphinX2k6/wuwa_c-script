using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001432 RID: 5170
	[NetMessage(EMessageId.TowerGuideActivityRewardResponse)]
	public sealed class TowerGuideActivityRewardResponse : IMessage<TowerGuideActivityRewardResponse>, IMessage, IEquatable<TowerGuideActivityRewardResponse>, IDeepCloneable<TowerGuideActivityRewardResponse>, IBufferMessage
	{
		// Token: 0x0601B791 RID: 112529 RVA: 0x003FE679 File Offset: 0x003FC879
		[NullableContext(1)]
		public static TowerGuideActivityRewardResponse Create()
		{
			return new TowerGuideActivityRewardResponse();
		}

		// Token: 0x17005D02 RID: 23810
		// (get) Token: 0x0601B792 RID: 112530 RVA: 0x003FE680 File Offset: 0x003FC880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D03 RID: 23811
		// (get) Token: 0x0601B793 RID: 112531 RVA: 0x003FE683 File Offset: 0x003FC883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerGuideActivityRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601B794 RID: 112532 RVA: 0x003FE68A File Offset: 0x003FC88A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerGuideActivityRewardResponse()
		{
		}

		// Token: 0x0601B795 RID: 112533 RVA: 0x003FE692 File Offset: 0x003FC892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerGuideActivityRewardResponse(TowerGuideActivityRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B796 RID: 112534 RVA: 0x003FE6B7 File Offset: 0x003FC8B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerGuideActivityRewardResponse Clone()
		{
			return new TowerGuideActivityRewardResponse(this);
		}

		// Token: 0x17005D04 RID: 23812
		// (get) Token: 0x0601B797 RID: 112535 RVA: 0x003FE6BF File Offset: 0x003FC8BF
		// (set) Token: 0x0601B798 RID: 112536 RVA: 0x003FE6C7 File Offset: 0x003FC8C7
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

		// Token: 0x0601B799 RID: 112537 RVA: 0x003FE6D0 File Offset: 0x003FC8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerGuideActivityRewardResponse);
		}

		// Token: 0x0601B79A RID: 112538 RVA: 0x003FE6DE File Offset: 0x003FC8DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerGuideActivityRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B79B RID: 112539 RVA: 0x003FE70C File Offset: 0x003FC90C
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

		// Token: 0x0601B79C RID: 112540 RVA: 0x003FE751 File Offset: 0x003FC951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B79D RID: 112541 RVA: 0x003FE75E File Offset: 0x003FC95E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B79E RID: 112542 RVA: 0x003FE767 File Offset: 0x003FC967
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

		// Token: 0x0601B79F RID: 112543 RVA: 0x003FE79C File Offset: 0x003FC99C
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

		// Token: 0x0601B7A0 RID: 112544 RVA: 0x003FE7DA File Offset: 0x003FC9DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerGuideActivityRewardResponse other)
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

		// Token: 0x0601B7A1 RID: 112545 RVA: 0x003FE80B File Offset: 0x003FCA0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B7A2 RID: 112546 RVA: 0x003FE814 File Offset: 0x003FCA14
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

		// Token: 0x04009FE7 RID: 40935
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FE8 RID: 40936
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04009FE9 RID: 40937
		private ErrorCode errorCode_;
	}
}
