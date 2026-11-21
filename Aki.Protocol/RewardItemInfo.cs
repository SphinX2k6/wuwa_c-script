using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F24 RID: 3876
	public sealed class RewardItemInfo : IMessage<RewardItemInfo>, IMessage, IEquatable<RewardItemInfo>, IDeepCloneable<RewardItemInfo>, IBufferMessage
	{
		// Token: 0x06014C57 RID: 85079 RVA: 0x0030424E File Offset: 0x0030244E
		[NullableContext(1)]
		public static RewardItemInfo Create()
		{
			return new RewardItemInfo();
		}

		// Token: 0x17004513 RID: 17683
		// (get) Token: 0x06014C58 RID: 85080 RVA: 0x00304255 File Offset: 0x00302455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RewardItemInfo> Parser
		{
			get
			{
				return RewardItemInfo._parser;
			}
		}

		// Token: 0x17004514 RID: 17684
		// (get) Token: 0x06014C59 RID: 85081 RVA: 0x0030425C File Offset: 0x0030245C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004515 RID: 17685
		// (get) Token: 0x06014C5A RID: 85082 RVA: 0x0030425F File Offset: 0x0030245F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RewardItemInfo.Descriptor;
			}
		}

		// Token: 0x06014C5B RID: 85083 RVA: 0x00304266 File Offset: 0x00302466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardItemInfo()
		{
		}

		// Token: 0x06014C5C RID: 85084 RVA: 0x00304270 File Offset: 0x00302470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardItemInfo(RewardItemInfo other) : this()
		{
			this.showPlanId_ = other.showPlanId_;
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this.incrId_ = other.incrId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014C5D RID: 85085 RVA: 0x003042C4 File Offset: 0x003024C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardItemInfo Clone()
		{
			return new RewardItemInfo(this);
		}

		// Token: 0x17004516 RID: 17686
		// (get) Token: 0x06014C5E RID: 85086 RVA: 0x003042CC File Offset: 0x003024CC
		// (set) Token: 0x06014C5F RID: 85087 RVA: 0x003042D4 File Offset: 0x003024D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShowPlanId
		{
			get
			{
				return this.showPlanId_;
			}
			set
			{
				this.showPlanId_ = value;
			}
		}

		// Token: 0x17004517 RID: 17687
		// (get) Token: 0x06014C60 RID: 85088 RVA: 0x003042DD File Offset: 0x003024DD
		// (set) Token: 0x06014C61 RID: 85089 RVA: 0x003042E5 File Offset: 0x003024E5
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

		// Token: 0x17004518 RID: 17688
		// (get) Token: 0x06014C62 RID: 85090 RVA: 0x003042EE File Offset: 0x003024EE
		// (set) Token: 0x06014C63 RID: 85091 RVA: 0x003042F6 File Offset: 0x003024F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x17004519 RID: 17689
		// (get) Token: 0x06014C64 RID: 85092 RVA: 0x003042FF File Offset: 0x003024FF
		// (set) Token: 0x06014C65 RID: 85093 RVA: 0x00304307 File Offset: 0x00302507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x06014C66 RID: 85094 RVA: 0x00304310 File Offset: 0x00302510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RewardItemInfo);
		}

		// Token: 0x06014C67 RID: 85095 RVA: 0x00304320 File Offset: 0x00302520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RewardItemInfo other)
		{
			return other != null && (other == this || (this.ShowPlanId == other.ShowPlanId && this.ItemId == other.ItemId && this.Count == other.Count && this.IncrId == other.IncrId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014C68 RID: 85096 RVA: 0x0030438C File Offset: 0x0030258C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShowPlanId != 0)
			{
				num ^= this.ShowPlanId.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014C69 RID: 85097 RVA: 0x00304416 File Offset: 0x00302616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014C6A RID: 85098 RVA: 0x00304423 File Offset: 0x00302623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014C6B RID: 85099 RVA: 0x0030442C File Offset: 0x0030262C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShowPlanId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ShowPlanId);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Count);
			}
			if (this.IncrId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014C6C RID: 85100 RVA: 0x003044BC File Offset: 0x003026BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShowPlanId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShowPlanId);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014C6D RID: 85101 RVA: 0x00304544 File Offset: 0x00302744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RewardItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShowPlanId != 0)
			{
				this.ShowPlanId = other.ShowPlanId;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014C6E RID: 85102 RVA: 0x003045BC File Offset: 0x003027BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014C6F RID: 85103 RVA: 0x003045C8 File Offset: 0x003027C8
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.ShowPlanId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ItemId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Count = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.IncrId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007DD9 RID: 32217
		private static readonly MessageParser<RewardItemInfo> _parser = new MessageParser<RewardItemInfo>(() => new RewardItemInfo());

		// Token: 0x04007DDA RID: 32218
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007DDB RID: 32219
		public const int ShowPlanIdFieldNumber = 1;

		// Token: 0x04007DDC RID: 32220
		private int showPlanId_;

		// Token: 0x04007DDD RID: 32221
		public const int ItemIdFieldNumber = 2;

		// Token: 0x04007DDE RID: 32222
		private int itemId_;

		// Token: 0x04007DDF RID: 32223
		public const int CountFieldNumber = 3;

		// Token: 0x04007DE0 RID: 32224
		private int count_;

		// Token: 0x04007DE1 RID: 32225
		public const int IncrIdFieldNumber = 4;

		// Token: 0x04007DE2 RID: 32226
		private int incrId_;
	}
}
