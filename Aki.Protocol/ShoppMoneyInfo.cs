using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011F8 RID: 4600
	public sealed class ShoppMoneyInfo : IMessage<ShoppMoneyInfo>, IMessage, IEquatable<ShoppMoneyInfo>, IDeepCloneable<ShoppMoneyInfo>, IBufferMessage
	{
		// Token: 0x0601886D RID: 100461 RVA: 0x003914E5 File Offset: 0x0038F6E5
		[NullableContext(1)]
		public static ShoppMoneyInfo Create()
		{
			return new ShoppMoneyInfo();
		}

		// Token: 0x170052A1 RID: 21153
		// (get) Token: 0x0601886E RID: 100462 RVA: 0x003914EC File Offset: 0x0038F6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShoppMoneyInfo> Parser
		{
			get
			{
				return ShoppMoneyInfo._parser;
			}
		}

		// Token: 0x170052A2 RID: 21154
		// (get) Token: 0x0601886F RID: 100463 RVA: 0x003914F3 File Offset: 0x0038F6F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052A3 RID: 21155
		// (get) Token: 0x06018870 RID: 100464 RVA: 0x003914F6 File Offset: 0x0038F6F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShoppMoneyInfo.Descriptor;
			}
		}

		// Token: 0x06018871 RID: 100465 RVA: 0x003914FD File Offset: 0x0038F6FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShoppMoneyInfo()
		{
		}

		// Token: 0x06018872 RID: 100466 RVA: 0x00391505 File Offset: 0x0038F705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShoppMoneyInfo(ShoppMoneyInfo other) : this()
		{
			this.moneyId_ = other.moneyId_;
			this.moneyNum_ = other.moneyNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018873 RID: 100467 RVA: 0x00391536 File Offset: 0x0038F736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShoppMoneyInfo Clone()
		{
			return new ShoppMoneyInfo(this);
		}

		// Token: 0x170052A4 RID: 21156
		// (get) Token: 0x06018874 RID: 100468 RVA: 0x0039153E File Offset: 0x0038F73E
		// (set) Token: 0x06018875 RID: 100469 RVA: 0x00391546 File Offset: 0x0038F746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MoneyId
		{
			get
			{
				return this.moneyId_;
			}
			set
			{
				this.moneyId_ = value;
			}
		}

		// Token: 0x170052A5 RID: 21157
		// (get) Token: 0x06018876 RID: 100470 RVA: 0x0039154F File Offset: 0x0038F74F
		// (set) Token: 0x06018877 RID: 100471 RVA: 0x00391557 File Offset: 0x0038F757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MoneyNum
		{
			get
			{
				return this.moneyNum_;
			}
			set
			{
				this.moneyNum_ = value;
			}
		}

		// Token: 0x06018878 RID: 100472 RVA: 0x00391560 File Offset: 0x0038F760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShoppMoneyInfo);
		}

		// Token: 0x06018879 RID: 100473 RVA: 0x0039156E File Offset: 0x0038F76E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShoppMoneyInfo other)
		{
			return other != null && (other == this || (this.MoneyId == other.MoneyId && this.MoneyNum == other.MoneyNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601887A RID: 100474 RVA: 0x003915AC File Offset: 0x0038F7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MoneyId != 0)
			{
				num ^= this.MoneyId.GetHashCode();
			}
			if (this.MoneyNum != 0)
			{
				num ^= this.MoneyNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601887B RID: 100475 RVA: 0x00391604 File Offset: 0x0038F804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601887C RID: 100476 RVA: 0x00391611 File Offset: 0x0038F811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601887D RID: 100477 RVA: 0x0039161C File Offset: 0x0038F81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MoneyId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MoneyId);
			}
			if (this.MoneyNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MoneyNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601887E RID: 100478 RVA: 0x00391674 File Offset: 0x0038F874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MoneyId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MoneyId);
			}
			if (this.MoneyNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MoneyNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601887F RID: 100479 RVA: 0x003916CC File Offset: 0x0038F8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShoppMoneyInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MoneyId != 0)
			{
				this.MoneyId = other.MoneyId;
			}
			if (other.MoneyNum != 0)
			{
				this.MoneyNum = other.MoneyNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018880 RID: 100480 RVA: 0x0039171C File Offset: 0x0038F91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018881 RID: 100481 RVA: 0x00391728 File Offset: 0x0038F928
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MoneyNum = input.ReadInt32();
					}
				}
				else
				{
					this.MoneyId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009105 RID: 37125
		private static readonly MessageParser<ShoppMoneyInfo> _parser = new MessageParser<ShoppMoneyInfo>(() => new ShoppMoneyInfo());

		// Token: 0x04009106 RID: 37126
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009107 RID: 37127
		public const int MoneyIdFieldNumber = 1;

		// Token: 0x04009108 RID: 37128
		private int moneyId_;

		// Token: 0x04009109 RID: 37129
		public const int MoneyNumFieldNumber = 2;

		// Token: 0x0400910A RID: 37130
		private int moneyNum_;
	}
}
