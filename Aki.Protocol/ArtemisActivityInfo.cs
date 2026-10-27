using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000114 RID: 276
	public sealed class ArtemisActivityInfo : IMessage<ArtemisActivityInfo>, IMessage, IEquatable<ArtemisActivityInfo>, IDeepCloneable<ArtemisActivityInfo>, IBufferMessage
	{
		// Token: 0x060025E3 RID: 9699 RVA: 0x00064DF6 File Offset: 0x00062FF6
		[NullableContext(1)]
		public static ArtemisActivityInfo Create()
		{
			return new ArtemisActivityInfo();
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x060025E4 RID: 9700 RVA: 0x00064DFD File Offset: 0x00062FFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x060025E5 RID: 9701 RVA: 0x00064E00 File Offset: 0x00063000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ArtemisActivityInfo.Descriptor;
			}
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x00064E07 File Offset: 0x00063007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisActivityInfo()
		{
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x00064E0F File Offset: 0x0006300F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisActivityInfo(ArtemisActivityInfo other) : this()
		{
			this.activityId_ = other.activityId_;
			this.unlockIndex_ = other.unlockIndex_;
			this.rewardedIndex_ = other.rewardedIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x00064E4C File Offset: 0x0006304C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisActivityInfo Clone()
		{
			return new ArtemisActivityInfo(this);
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x060025E9 RID: 9705 RVA: 0x00064E54 File Offset: 0x00063054
		// (set) Token: 0x060025EA RID: 9706 RVA: 0x00064E5C File Offset: 0x0006305C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x060025EB RID: 9707 RVA: 0x00064E65 File Offset: 0x00063065
		// (set) Token: 0x060025EC RID: 9708 RVA: 0x00064E6D File Offset: 0x0006306D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnlockIndex
		{
			get
			{
				return this.unlockIndex_;
			}
			set
			{
				this.unlockIndex_ = value;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x060025ED RID: 9709 RVA: 0x00064E76 File Offset: 0x00063076
		// (set) Token: 0x060025EE RID: 9710 RVA: 0x00064E7E File Offset: 0x0006307E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardedIndex
		{
			get
			{
				return this.rewardedIndex_;
			}
			set
			{
				this.rewardedIndex_ = value;
			}
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x00064E87 File Offset: 0x00063087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ArtemisActivityInfo);
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x00064E98 File Offset: 0x00063098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ArtemisActivityInfo other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.UnlockIndex == other.UnlockIndex && this.RewardedIndex == other.RewardedIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060025F1 RID: 9713 RVA: 0x00064EF4 File Offset: 0x000630F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.UnlockIndex != 0)
			{
				num ^= this.UnlockIndex.GetHashCode();
			}
			if (this.RewardedIndex != 0)
			{
				num ^= this.RewardedIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x00064F65 File Offset: 0x00063165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x00064F72 File Offset: 0x00063172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x00064F7C File Offset: 0x0006317C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this.UnlockIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.UnlockIndex);
			}
			if (this.RewardedIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RewardedIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x00064FF0 File Offset: 0x000631F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.UnlockIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnlockIndex);
			}
			if (this.RewardedIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardedIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060025F6 RID: 9718 RVA: 0x00065060 File Offset: 0x00063260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ArtemisActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.UnlockIndex != 0)
			{
				this.UnlockIndex = other.UnlockIndex;
			}
			if (other.RewardedIndex != 0)
			{
				this.RewardedIndex = other.RewardedIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x000650C4 File Offset: 0x000632C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060025F8 RID: 9720 RVA: 0x000650D0 File Offset: 0x000632D0
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
							this.RewardedIndex = input.ReadInt32();
						}
					}
					else
					{
						this.UnlockIndex = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040025EC RID: 9708
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025ED RID: 9709
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x040025EE RID: 9710
		private int activityId_;

		// Token: 0x040025EF RID: 9711
		public const int UnlockIndexFieldNumber = 2;

		// Token: 0x040025F0 RID: 9712
		private int unlockIndex_;

		// Token: 0x040025F1 RID: 9713
		public const int RewardedIndexFieldNumber = 3;

		// Token: 0x040025F2 RID: 9714
		private int rewardedIndex_;
	}
}
