using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013BF RID: 5055
	[NetMessage(EMessageId.TowerGuideActivityRewardResponse)]
	public sealed class TowerGuideActivityRewardResponse : IMessage<TowerGuideActivityRewardResponse>, IMessage, IEquatable<TowerGuideActivityRewardResponse>, IDeepCloneable<TowerGuideActivityRewardResponse>, IBufferMessage
	{
		// Token: 0x0601AD06 RID: 109830 RVA: 0x003E33B5 File Offset: 0x003E15B5
		[NullableContext(1)]
		public static TowerGuideActivityRewardResponse Create()
		{
			return new TowerGuideActivityRewardResponse();
		}

		// Token: 0x17005A6D RID: 23149
		// (get) Token: 0x0601AD07 RID: 109831 RVA: 0x003E33BC File Offset: 0x003E15BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A6E RID: 23150
		// (get) Token: 0x0601AD08 RID: 109832 RVA: 0x003E33BF File Offset: 0x003E15BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerGuideActivityRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601AD09 RID: 109833 RVA: 0x003E33C6 File Offset: 0x003E15C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerGuideActivityRewardResponse()
		{
		}

		// Token: 0x0601AD0A RID: 109834 RVA: 0x003E33CE File Offset: 0x003E15CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerGuideActivityRewardResponse(TowerGuideActivityRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AD0B RID: 109835 RVA: 0x003E33F3 File Offset: 0x003E15F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerGuideActivityRewardResponse Clone()
		{
			return new TowerGuideActivityRewardResponse(this);
		}

		// Token: 0x17005A6F RID: 23151
		// (get) Token: 0x0601AD0C RID: 109836 RVA: 0x003E33FB File Offset: 0x003E15FB
		// (set) Token: 0x0601AD0D RID: 109837 RVA: 0x003E3403 File Offset: 0x003E1603
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

		// Token: 0x0601AD0E RID: 109838 RVA: 0x003E340C File Offset: 0x003E160C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerGuideActivityRewardResponse);
		}

		// Token: 0x0601AD0F RID: 109839 RVA: 0x003E341A File Offset: 0x003E161A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerGuideActivityRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AD10 RID: 109840 RVA: 0x003E3448 File Offset: 0x003E1648
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

		// Token: 0x0601AD11 RID: 109841 RVA: 0x003E348D File Offset: 0x003E168D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AD12 RID: 109842 RVA: 0x003E349A File Offset: 0x003E169A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AD13 RID: 109843 RVA: 0x003E34A3 File Offset: 0x003E16A3
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

		// Token: 0x0601AD14 RID: 109844 RVA: 0x003E34D8 File Offset: 0x003E16D8
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

		// Token: 0x0601AD15 RID: 109845 RVA: 0x003E3516 File Offset: 0x003E1716
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

		// Token: 0x0601AD16 RID: 109846 RVA: 0x003E3547 File Offset: 0x003E1747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AD17 RID: 109847 RVA: 0x003E3550 File Offset: 0x003E1750
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

		// Token: 0x04009BA0 RID: 39840
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BA1 RID: 39841
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04009BA2 RID: 39842
		private ErrorCode errorCode_;
	}
}
