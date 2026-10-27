using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F34 RID: 3892
	public sealed class RewardItemInfo : IMessage<RewardItemInfo>, IMessage, IEquatable<RewardItemInfo>, IDeepCloneable<RewardItemInfo>, IBufferMessage
	{
		// Token: 0x06014D3C RID: 85308 RVA: 0x0030590A File Offset: 0x00303B0A
		[NullableContext(1)]
		public static RewardItemInfo Create()
		{
			return new RewardItemInfo();
		}

		// Token: 0x1700453D RID: 17725
		// (get) Token: 0x06014D3D RID: 85309 RVA: 0x00305911 File Offset: 0x00303B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RewardItemInfo> Parser
		{
			get
			{
				return RewardItemInfo._parser;
			}
		}

		// Token: 0x1700453E RID: 17726
		// (get) Token: 0x06014D3E RID: 85310 RVA: 0x00305918 File Offset: 0x00303B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700453F RID: 17727
		// (get) Token: 0x06014D3F RID: 85311 RVA: 0x0030591B File Offset: 0x00303B1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RewardItemInfo.Descriptor;
			}
		}

		// Token: 0x06014D40 RID: 85312 RVA: 0x00305922 File Offset: 0x00303B22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardItemInfo()
		{
		}

		// Token: 0x06014D41 RID: 85313 RVA: 0x0030592C File Offset: 0x00303B2C
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

		// Token: 0x06014D42 RID: 85314 RVA: 0x00305980 File Offset: 0x00303B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardItemInfo Clone()
		{
			return new RewardItemInfo(this);
		}

		// Token: 0x17004540 RID: 17728
		// (get) Token: 0x06014D43 RID: 85315 RVA: 0x00305988 File Offset: 0x00303B88
		// (set) Token: 0x06014D44 RID: 85316 RVA: 0x00305990 File Offset: 0x00303B90
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

		// Token: 0x17004541 RID: 17729
		// (get) Token: 0x06014D45 RID: 85317 RVA: 0x00305999 File Offset: 0x00303B99
		// (set) Token: 0x06014D46 RID: 85318 RVA: 0x003059A1 File Offset: 0x00303BA1
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

		// Token: 0x17004542 RID: 17730
		// (get) Token: 0x06014D47 RID: 85319 RVA: 0x003059AA File Offset: 0x00303BAA
		// (set) Token: 0x06014D48 RID: 85320 RVA: 0x003059B2 File Offset: 0x00303BB2
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

		// Token: 0x17004543 RID: 17731
		// (get) Token: 0x06014D49 RID: 85321 RVA: 0x003059BB File Offset: 0x00303BBB
		// (set) Token: 0x06014D4A RID: 85322 RVA: 0x003059C3 File Offset: 0x00303BC3
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

		// Token: 0x06014D4B RID: 85323 RVA: 0x003059CC File Offset: 0x00303BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RewardItemInfo);
		}

		// Token: 0x06014D4C RID: 85324 RVA: 0x003059DC File Offset: 0x00303BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RewardItemInfo other)
		{
			return other != null && (other == this || (this.ShowPlanId == other.ShowPlanId && this.ItemId == other.ItemId && this.Count == other.Count && this.IncrId == other.IncrId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014D4D RID: 85325 RVA: 0x00305A48 File Offset: 0x00303C48
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

		// Token: 0x06014D4E RID: 85326 RVA: 0x00305AD2 File Offset: 0x00303CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014D4F RID: 85327 RVA: 0x00305ADF File Offset: 0x00303CDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014D50 RID: 85328 RVA: 0x00305AE8 File Offset: 0x00303CE8
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

		// Token: 0x06014D51 RID: 85329 RVA: 0x00305B78 File Offset: 0x00303D78
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

		// Token: 0x06014D52 RID: 85330 RVA: 0x00305C00 File Offset: 0x00303E00
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

		// Token: 0x06014D53 RID: 85331 RVA: 0x00305C78 File Offset: 0x00303E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014D54 RID: 85332 RVA: 0x00305C84 File Offset: 0x00303E84
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

		// Token: 0x04007DAF RID: 32175
		private static readonly MessageParser<RewardItemInfo> _parser = new MessageParser<RewardItemInfo>(() => new RewardItemInfo());

		// Token: 0x04007DB0 RID: 32176
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007DB1 RID: 32177
		public const int ShowPlanIdFieldNumber = 1;

		// Token: 0x04007DB2 RID: 32178
		private int showPlanId_;

		// Token: 0x04007DB3 RID: 32179
		public const int ItemIdFieldNumber = 2;

		// Token: 0x04007DB4 RID: 32180
		private int itemId_;

		// Token: 0x04007DB5 RID: 32181
		public const int CountFieldNumber = 3;

		// Token: 0x04007DB6 RID: 32182
		private int count_;

		// Token: 0x04007DB7 RID: 32183
		public const int IncrIdFieldNumber = 4;

		// Token: 0x04007DB8 RID: 32184
		private int incrId_;
	}
}
