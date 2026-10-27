using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200016E RID: 366
	[NetMessage(EMessageId.BattlePassRecurringTakeRequest)]
	public sealed class BattlePassRecurringTakeRequest : IMessage<BattlePassRecurringTakeRequest>, IMessage, IEquatable<BattlePassRecurringTakeRequest>, IDeepCloneable<BattlePassRecurringTakeRequest>, IBufferMessage
	{
		// Token: 0x06002D2A RID: 11562 RVA: 0x000750B9 File Offset: 0x000732B9
		[NullableContext(1)]
		public static BattlePassRecurringTakeRequest Create()
		{
			return new BattlePassRecurringTakeRequest();
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06002D2B RID: 11563 RVA: 0x000750C0 File Offset: 0x000732C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06002D2C RID: 11564 RVA: 0x000750C3 File Offset: 0x000732C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassRecurringTakeRequest.Descriptor;
			}
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x000750CA File Offset: 0x000732CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassRecurringTakeRequest()
		{
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x000750D2 File Offset: 0x000732D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassRecurringTakeRequest(BattlePassRecurringTakeRequest other) : this()
		{
			this.type_ = other.type_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x00075103 File Offset: 0x00073303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassRecurringTakeRequest Clone()
		{
			return new BattlePassRecurringTakeRequest(this);
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06002D30 RID: 11568 RVA: 0x0007510B File Offset: 0x0007330B
		// (set) Token: 0x06002D31 RID: 11569 RVA: 0x00075113 File Offset: 0x00073313
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

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06002D32 RID: 11570 RVA: 0x0007511C File Offset: 0x0007331C
		// (set) Token: 0x06002D33 RID: 11571 RVA: 0x00075124 File Offset: 0x00073324
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

		// Token: 0x06002D34 RID: 11572 RVA: 0x0007512D File Offset: 0x0007332D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassRecurringTakeRequest);
		}

		// Token: 0x06002D35 RID: 11573 RVA: 0x0007513B File Offset: 0x0007333B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassRecurringTakeRequest other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x0007517C File Offset: 0x0007337C
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

		// Token: 0x06002D37 RID: 11575 RVA: 0x000751DA File Offset: 0x000733DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002D38 RID: 11576 RVA: 0x000751E7 File Offset: 0x000733E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x000751F0 File Offset: 0x000733F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ItemId);
			}
			if (this.Type != BattlePassType.Free)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x0007524C File Offset: 0x0007344C
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

		// Token: 0x06002D3B RID: 11579 RVA: 0x000752A4 File Offset: 0x000734A4
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

		// Token: 0x06002D3C RID: 11580 RVA: 0x000752F4 File Offset: 0x000734F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D3D RID: 11581 RVA: 0x00075300 File Offset: 0x00073500
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
				if (num != 88U)
				{
					if (num != 120U)
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

		// Token: 0x04002826 RID: 10278
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002827 RID: 10279
		public const int TypeFieldNumber = 15;

		// Token: 0x04002828 RID: 10280
		private BattlePassType type_;

		// Token: 0x04002829 RID: 10281
		public const int ItemIdFieldNumber = 11;

		// Token: 0x0400282A RID: 10282
		private int itemId_;
	}
}
