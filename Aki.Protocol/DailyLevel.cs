using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200032A RID: 810
	public sealed class DailyLevel : IMessage<DailyLevel>, IMessage, IEquatable<DailyLevel>, IDeepCloneable<DailyLevel>, IBufferMessage
	{
		// Token: 0x06005197 RID: 20887 RVA: 0x000C6EF0 File Offset: 0x000C50F0
		[NullableContext(1)]
		public static DailyLevel Create()
		{
			return new DailyLevel();
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06005198 RID: 20888 RVA: 0x000C6EF7 File Offset: 0x000C50F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06005199 RID: 20889 RVA: 0x000C6EFA File Offset: 0x000C50FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyLevel.Descriptor;
			}
		}

		// Token: 0x0600519A RID: 20890 RVA: 0x000C6F01 File Offset: 0x000C5101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyLevel()
		{
		}

		// Token: 0x0600519B RID: 20891 RVA: 0x000C6F09 File Offset: 0x000C5109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyLevel(DailyLevel other) : this()
		{
			this.randomLevelId_ = other.randomLevelId_;
			this.reward_ = other.reward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600519C RID: 20892 RVA: 0x000C6F3A File Offset: 0x000C513A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyLevel Clone()
		{
			return new DailyLevel(this);
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x0600519D RID: 20893 RVA: 0x000C6F42 File Offset: 0x000C5142
		// (set) Token: 0x0600519E RID: 20894 RVA: 0x000C6F4A File Offset: 0x000C514A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RandomLevelId
		{
			get
			{
				return this.randomLevelId_;
			}
			set
			{
				this.randomLevelId_ = value;
			}
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x0600519F RID: 20895 RVA: 0x000C6F53 File Offset: 0x000C5153
		// (set) Token: 0x060051A0 RID: 20896 RVA: 0x000C6F5B File Offset: 0x000C515B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Reward
		{
			get
			{
				return this.reward_;
			}
			set
			{
				this.reward_ = value;
			}
		}

		// Token: 0x060051A1 RID: 20897 RVA: 0x000C6F64 File Offset: 0x000C5164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyLevel);
		}

		// Token: 0x060051A2 RID: 20898 RVA: 0x000C6F72 File Offset: 0x000C5172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyLevel other)
		{
			return other != null && (other == this || (this.RandomLevelId == other.RandomLevelId && this.Reward == other.Reward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060051A3 RID: 20899 RVA: 0x000C6FB0 File Offset: 0x000C51B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RandomLevelId != 0)
			{
				num ^= this.RandomLevelId.GetHashCode();
			}
			if (this.Reward)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060051A4 RID: 20900 RVA: 0x000C7008 File Offset: 0x000C5208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060051A5 RID: 20901 RVA: 0x000C7015 File Offset: 0x000C5215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060051A6 RID: 20902 RVA: 0x000C7020 File Offset: 0x000C5220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RandomLevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RandomLevelId);
			}
			if (this.Reward)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Reward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060051A7 RID: 20903 RVA: 0x000C7078 File Offset: 0x000C5278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RandomLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RandomLevelId);
			}
			if (this.Reward)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060051A8 RID: 20904 RVA: 0x000C70C4 File Offset: 0x000C52C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyLevel other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RandomLevelId != 0)
			{
				this.RandomLevelId = other.RandomLevelId;
			}
			if (other.Reward)
			{
				this.Reward = other.Reward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060051A9 RID: 20905 RVA: 0x000C7114 File Offset: 0x000C5314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060051AA RID: 20906 RVA: 0x000C7120 File Offset: 0x000C5320
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
						this.Reward = input.ReadBool();
					}
				}
				else
				{
					this.RandomLevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400330E RID: 13070
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400330F RID: 13071
		public const int RandomLevelIdFieldNumber = 1;

		// Token: 0x04003310 RID: 13072
		private int randomLevelId_;

		// Token: 0x04003311 RID: 13073
		public const int RewardFieldNumber = 2;

		// Token: 0x04003312 RID: 13074
		private bool reward_;
	}
}
