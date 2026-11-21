using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000171 RID: 369
	[NetMessage(EMessageId.BattlePassRecurringTakeRequest)]
	public sealed class BattlePassRecurringTakeRequest : IMessage<BattlePassRecurringTakeRequest>, IMessage, IEquatable<BattlePassRecurringTakeRequest>, IDeepCloneable<BattlePassRecurringTakeRequest>, IBufferMessage
	{
		// Token: 0x06002DA1 RID: 11681 RVA: 0x000764E8 File Offset: 0x000746E8
		[NullableContext(1)]
		public static BattlePassRecurringTakeRequest Create()
		{
			return new BattlePassRecurringTakeRequest();
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06002DA2 RID: 11682 RVA: 0x000764EF File Offset: 0x000746EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06002DA3 RID: 11683 RVA: 0x000764F2 File Offset: 0x000746F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassRecurringTakeRequest.Descriptor;
			}
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x000764F9 File Offset: 0x000746F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassRecurringTakeRequest()
		{
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x00076501 File Offset: 0x00074701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassRecurringTakeRequest(BattlePassRecurringTakeRequest other) : this()
		{
			this.type_ = other.type_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x00076532 File Offset: 0x00074732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassRecurringTakeRequest Clone()
		{
			return new BattlePassRecurringTakeRequest(this);
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06002DA7 RID: 11687 RVA: 0x0007653A File Offset: 0x0007473A
		// (set) Token: 0x06002DA8 RID: 11688 RVA: 0x00076542 File Offset: 0x00074742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06002DA9 RID: 11689 RVA: 0x0007654B File Offset: 0x0007474B
		// (set) Token: 0x06002DAA RID: 11690 RVA: 0x00076553 File Offset: 0x00074753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x0007655C File Offset: 0x0007475C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassRecurringTakeRequest);
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x0007656A File Offset: 0x0007476A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassRecurringTakeRequest other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x000765A8 File Offset: 0x000747A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != BattlePassType.Free)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x00076606 File Offset: 0x00074806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x00076613 File Offset: 0x00074813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x0007661C File Offset: 0x0007481C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ItemId);
			}
			if (this.Type != BattlePassType.Free)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x00076678 File Offset: 0x00074878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != BattlePassType.Free)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x000766D0 File Offset: 0x000748D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassRecurringTakeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != BattlePassType.Free)
			{
				this.Type = other.Type;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x00076720 File Offset: 0x00074920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x0007672C File Offset: 0x0007492C
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
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Type = (BattlePassType)input.ReadEnum();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400289A RID: 10394
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400289B RID: 10395
		public const int TypeFieldNumber = 10;

		// Token: 0x0400289C RID: 10396
		private BattlePassType type_;

		// Token: 0x0400289D RID: 10397
		public const int ItemIdFieldNumber = 6;

		// Token: 0x0400289E RID: 10398
		private int itemId_;
	}
}
