using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000177 RID: 375
	[NetMessage(EMessageId.BattlePassTakeRewardRequest)]
	public sealed class BattlePassTakeRewardRequest : IMessage<BattlePassTakeRewardRequest>, IMessage, IEquatable<BattlePassTakeRewardRequest>, IDeepCloneable<BattlePassTakeRewardRequest>, IBufferMessage
	{
		// Token: 0x06002E10 RID: 11792 RVA: 0x0007722C File Offset: 0x0007542C
		[NullableContext(1)]
		public static BattlePassTakeRewardRequest Create()
		{
			return new BattlePassTakeRewardRequest();
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06002E11 RID: 11793 RVA: 0x00077233 File Offset: 0x00075433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06002E12 RID: 11794 RVA: 0x00077236 File Offset: 0x00075436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassTakeRewardRequest.Descriptor;
			}
		}

		// Token: 0x06002E13 RID: 11795 RVA: 0x0007723D File Offset: 0x0007543D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTakeRewardRequest()
		{
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x00077245 File Offset: 0x00075445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTakeRewardRequest(BattlePassTakeRewardRequest other) : this()
		{
			this.type_ = other.type_;
			this.level_ = other.level_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E15 RID: 11797 RVA: 0x00077282 File Offset: 0x00075482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTakeRewardRequest Clone()
		{
			return new BattlePassTakeRewardRequest(this);
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06002E16 RID: 11798 RVA: 0x0007728A File Offset: 0x0007548A
		// (set) Token: 0x06002E17 RID: 11799 RVA: 0x00077292 File Offset: 0x00075492
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

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06002E18 RID: 11800 RVA: 0x0007729B File Offset: 0x0007549B
		// (set) Token: 0x06002E19 RID: 11801 RVA: 0x000772A3 File Offset: 0x000754A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06002E1A RID: 11802 RVA: 0x000772AC File Offset: 0x000754AC
		// (set) Token: 0x06002E1B RID: 11803 RVA: 0x000772B4 File Offset: 0x000754B4
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

		// Token: 0x06002E1C RID: 11804 RVA: 0x000772BD File Offset: 0x000754BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassTakeRewardRequest);
		}

		// Token: 0x06002E1D RID: 11805 RVA: 0x000772CC File Offset: 0x000754CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassTakeRewardRequest other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Level == other.Level && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x00077328 File Offset: 0x00075528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != BattlePassType.Free)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
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

		// Token: 0x06002E1F RID: 11807 RVA: 0x0007739F File Offset: 0x0007559F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x000773AC File Offset: 0x000755AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x000773B8 File Offset: 0x000755B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ItemId);
			}
			if (this.Type != BattlePassType.Free)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Type);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x00077430 File Offset: 0x00075630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != BattlePassType.Free)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
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

		// Token: 0x06002E23 RID: 11811 RVA: 0x000774A0 File Offset: 0x000756A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassTakeRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != BattlePassType.Free)
			{
				this.Type = other.Type;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x00077504 File Offset: 0x00075704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x00077510 File Offset: 0x00075710
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
				if (num != 56U)
				{
					if (num != 80U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Level = input.ReadInt32();
						}
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

		// Token: 0x040028B2 RID: 10418
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028B3 RID: 10419
		public const int TypeFieldNumber = 10;

		// Token: 0x040028B4 RID: 10420
		private BattlePassType type_;

		// Token: 0x040028B5 RID: 10421
		public const int LevelFieldNumber = 15;

		// Token: 0x040028B6 RID: 10422
		private int level_;

		// Token: 0x040028B7 RID: 10423
		public const int ItemIdFieldNumber = 7;

		// Token: 0x040028B8 RID: 10424
		private int itemId_;
	}
}
