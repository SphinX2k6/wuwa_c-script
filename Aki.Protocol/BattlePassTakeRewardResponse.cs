using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000178 RID: 376
	[NetMessage(EMessageId.BattlePassTakeRewardResponse)]
	public sealed class BattlePassTakeRewardResponse : IMessage<BattlePassTakeRewardResponse>, IMessage, IEquatable<BattlePassTakeRewardResponse>, IDeepCloneable<BattlePassTakeRewardResponse>, IBufferMessage
	{
		// Token: 0x06002E26 RID: 11814 RVA: 0x0007757B File Offset: 0x0007577B
		[NullableContext(1)]
		public static BattlePassTakeRewardResponse Create()
		{
			return new BattlePassTakeRewardResponse();
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06002E27 RID: 11815 RVA: 0x00077582 File Offset: 0x00075782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06002E28 RID: 11816 RVA: 0x00077585 File Offset: 0x00075785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassTakeRewardResponse.Descriptor;
			}
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x0007758C File Offset: 0x0007578C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTakeRewardResponse()
		{
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x00077594 File Offset: 0x00075794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTakeRewardResponse(BattlePassTakeRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x000775B9 File Offset: 0x000757B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTakeRewardResponse Clone()
		{
			return new BattlePassTakeRewardResponse(this);
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06002E2C RID: 11820 RVA: 0x000775C1 File Offset: 0x000757C1
		// (set) Token: 0x06002E2D RID: 11821 RVA: 0x000775C9 File Offset: 0x000757C9
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

		// Token: 0x06002E2E RID: 11822 RVA: 0x000775D2 File Offset: 0x000757D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassTakeRewardResponse);
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x000775E0 File Offset: 0x000757E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassTakeRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x00077610 File Offset: 0x00075810
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

		// Token: 0x06002E31 RID: 11825 RVA: 0x00077655 File Offset: 0x00075855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x00077662 File Offset: 0x00075862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x0007766B File Offset: 0x0007586B
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

		// Token: 0x06002E34 RID: 11828 RVA: 0x000776A0 File Offset: 0x000758A0
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

		// Token: 0x06002E35 RID: 11829 RVA: 0x000776DE File Offset: 0x000758DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassTakeRewardResponse other)
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

		// Token: 0x06002E36 RID: 11830 RVA: 0x0007770F File Offset: 0x0007590F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x00077718 File Offset: 0x00075918
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

		// Token: 0x040028B9 RID: 10425
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028BA RID: 10426
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040028BB RID: 10427
		private ErrorCode errorCode_;
	}
}
