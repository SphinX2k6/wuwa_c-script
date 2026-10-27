using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200142D RID: 5165
	public sealed class TrapDefenseItemPbData : IMessage<TrapDefenseItemPbData>, IMessage, IEquatable<TrapDefenseItemPbData>, IDeepCloneable<TrapDefenseItemPbData>, IBufferMessage
	{
		// Token: 0x0601B5DB RID: 112091 RVA: 0x003F6A7C File Offset: 0x003F4C7C
		[NullableContext(1)]
		public static TrapDefenseItemPbData Create()
		{
			return new TrapDefenseItemPbData();
		}

		// Token: 0x17005C48 RID: 23624
		// (get) Token: 0x0601B5DC RID: 112092 RVA: 0x003F6A83 File Offset: 0x003F4C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrapDefenseItemPbData> Parser
		{
			get
			{
				return TrapDefenseItemPbData._parser;
			}
		}

		// Token: 0x17005C49 RID: 23625
		// (get) Token: 0x0601B5DD RID: 112093 RVA: 0x003F6A8A File Offset: 0x003F4C8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C4A RID: 23626
		// (get) Token: 0x0601B5DE RID: 112094 RVA: 0x003F6A8D File Offset: 0x003F4C8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseItemPbData.Descriptor;
			}
		}

		// Token: 0x0601B5DF RID: 112095 RVA: 0x003F6A94 File Offset: 0x003F4C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseItemPbData()
		{
		}

		// Token: 0x0601B5E0 RID: 112096 RVA: 0x003F6A9C File Offset: 0x003F4C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseItemPbData(TrapDefenseItemPbData other) : this()
		{
			this.configId_ = other.configId_;
			this.carryCount_ = other.carryCount_;
			this.carryLimit_ = other.carryLimit_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B5E1 RID: 112097 RVA: 0x003F6AD9 File Offset: 0x003F4CD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseItemPbData Clone()
		{
			return new TrapDefenseItemPbData(this);
		}

		// Token: 0x17005C4B RID: 23627
		// (get) Token: 0x0601B5E2 RID: 112098 RVA: 0x003F6AE1 File Offset: 0x003F4CE1
		// (set) Token: 0x0601B5E3 RID: 112099 RVA: 0x003F6AE9 File Offset: 0x003F4CE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17005C4C RID: 23628
		// (get) Token: 0x0601B5E4 RID: 112100 RVA: 0x003F6AF2 File Offset: 0x003F4CF2
		// (set) Token: 0x0601B5E5 RID: 112101 RVA: 0x003F6AFA File Offset: 0x003F4CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CarryCount
		{
			get
			{
				return this.carryCount_;
			}
			set
			{
				this.carryCount_ = value;
			}
		}

		// Token: 0x17005C4D RID: 23629
		// (get) Token: 0x0601B5E6 RID: 112102 RVA: 0x003F6B03 File Offset: 0x003F4D03
		// (set) Token: 0x0601B5E7 RID: 112103 RVA: 0x003F6B0B File Offset: 0x003F4D0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CarryLimit
		{
			get
			{
				return this.carryLimit_;
			}
			set
			{
				this.carryLimit_ = value;
			}
		}

		// Token: 0x0601B5E8 RID: 112104 RVA: 0x003F6B14 File Offset: 0x003F4D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseItemPbData);
		}

		// Token: 0x0601B5E9 RID: 112105 RVA: 0x003F6B24 File Offset: 0x003F4D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseItemPbData other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.CarryCount == other.CarryCount && this.CarryLimit == other.CarryLimit && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B5EA RID: 112106 RVA: 0x003F6B80 File Offset: 0x003F4D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.CarryCount != 0)
			{
				num ^= this.CarryCount.GetHashCode();
			}
			if (this.CarryLimit != 0)
			{
				num ^= this.CarryLimit.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B5EB RID: 112107 RVA: 0x003F6BF1 File Offset: 0x003F4DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B5EC RID: 112108 RVA: 0x003F6BFE File Offset: 0x003F4DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B5ED RID: 112109 RVA: 0x003F6C08 File Offset: 0x003F4E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.CarryCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CarryCount);
			}
			if (this.CarryLimit != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CarryLimit);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B5EE RID: 112110 RVA: 0x003F6C7C File Offset: 0x003F4E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.CarryCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CarryCount);
			}
			if (this.CarryLimit != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CarryLimit);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B5EF RID: 112111 RVA: 0x003F6CEC File Offset: 0x003F4EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseItemPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.CarryCount != 0)
			{
				this.CarryCount = other.CarryCount;
			}
			if (other.CarryLimit != 0)
			{
				this.CarryLimit = other.CarryLimit;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B5F0 RID: 112112 RVA: 0x003F6D50 File Offset: 0x003F4F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B5F1 RID: 112113 RVA: 0x003F6D5C File Offset: 0x003F4F5C
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CarryLimit = input.ReadInt32();
						}
					}
					else
					{
						this.CarryCount = input.ReadInt32();
					}
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009E07 RID: 40455
		private static readonly MessageParser<TrapDefenseItemPbData> _parser = new MessageParser<TrapDefenseItemPbData>(() => new TrapDefenseItemPbData());

		// Token: 0x04009E08 RID: 40456
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E09 RID: 40457
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04009E0A RID: 40458
		private int configId_;

		// Token: 0x04009E0B RID: 40459
		public const int CarryCountFieldNumber = 2;

		// Token: 0x04009E0C RID: 40460
		private int carryCount_;

		// Token: 0x04009E0D RID: 40461
		public const int CarryLimitFieldNumber = 3;

		// Token: 0x04009E0E RID: 40462
		private int carryLimit_;
	}
}
