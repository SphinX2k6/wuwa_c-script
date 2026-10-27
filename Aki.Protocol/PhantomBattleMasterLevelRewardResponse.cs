using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C99 RID: 3225
	[NetMessage(EMessageId.PhantomBattleMasterLevelRewardResponse)]
	public sealed class PhantomBattleMasterLevelRewardResponse : IMessage<PhantomBattleMasterLevelRewardResponse>, IMessage, IEquatable<PhantomBattleMasterLevelRewardResponse>, IDeepCloneable<PhantomBattleMasterLevelRewardResponse>, IBufferMessage
	{
		// Token: 0x060117AC RID: 71596 RVA: 0x0028FAC8 File Offset: 0x0028DCC8
		[NullableContext(1)]
		public static PhantomBattleMasterLevelRewardResponse Create()
		{
			return new PhantomBattleMasterLevelRewardResponse();
		}

		// Token: 0x170039E7 RID: 14823
		// (get) Token: 0x060117AD RID: 71597 RVA: 0x0028FACF File Offset: 0x0028DCCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039E8 RID: 14824
		// (get) Token: 0x060117AE RID: 71598 RVA: 0x0028FAD2 File Offset: 0x0028DCD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleMasterLevelRewardResponse.Descriptor;
			}
		}

		// Token: 0x060117AF RID: 71599 RVA: 0x0028FAD9 File Offset: 0x0028DCD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterLevelRewardResponse()
		{
		}

		// Token: 0x060117B0 RID: 71600 RVA: 0x0028FAE1 File Offset: 0x0028DCE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterLevelRewardResponse(PhantomBattleMasterLevelRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060117B1 RID: 71601 RVA: 0x0028FB06 File Offset: 0x0028DD06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterLevelRewardResponse Clone()
		{
			return new PhantomBattleMasterLevelRewardResponse(this);
		}

		// Token: 0x170039E9 RID: 14825
		// (get) Token: 0x060117B2 RID: 71602 RVA: 0x0028FB0E File Offset: 0x0028DD0E
		// (set) Token: 0x060117B3 RID: 71603 RVA: 0x0028FB16 File Offset: 0x0028DD16
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

		// Token: 0x060117B4 RID: 71604 RVA: 0x0028FB1F File Offset: 0x0028DD1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleMasterLevelRewardResponse);
		}

		// Token: 0x060117B5 RID: 71605 RVA: 0x0028FB2D File Offset: 0x0028DD2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleMasterLevelRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060117B6 RID: 71606 RVA: 0x0028FB5C File Offset: 0x0028DD5C
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

		// Token: 0x060117B7 RID: 71607 RVA: 0x0028FBA1 File Offset: 0x0028DDA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060117B8 RID: 71608 RVA: 0x0028FBAE File Offset: 0x0028DDAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060117B9 RID: 71609 RVA: 0x0028FBB7 File Offset: 0x0028DDB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060117BA RID: 71610 RVA: 0x0028FBEC File Offset: 0x0028DDEC
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

		// Token: 0x060117BB RID: 71611 RVA: 0x0028FC2A File Offset: 0x0028DE2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleMasterLevelRewardResponse other)
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

		// Token: 0x060117BC RID: 71612 RVA: 0x0028FC5B File Offset: 0x0028DE5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060117BD RID: 71613 RVA: 0x0028FC64 File Offset: 0x0028DE64
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006E4A RID: 28234
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E4B RID: 28235
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04006E4C RID: 28236
		private ErrorCode errorCode_;
	}
}
