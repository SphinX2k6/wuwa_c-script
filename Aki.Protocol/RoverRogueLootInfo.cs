using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200114A RID: 4426
	public sealed class RoverRogueLootInfo : IMessage<RoverRogueLootInfo>, IMessage, IEquatable<RoverRogueLootInfo>, IDeepCloneable<RoverRogueLootInfo>, IBufferMessage
	{
		// Token: 0x06017A61 RID: 96865 RVA: 0x00371286 File Offset: 0x0036F486
		[NullableContext(1)]
		public static RoverRogueLootInfo Create()
		{
			return new RoverRogueLootInfo();
		}

		// Token: 0x17004F8D RID: 20365
		// (get) Token: 0x06017A62 RID: 96866 RVA: 0x0037128D File Offset: 0x0036F48D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F8E RID: 20366
		// (get) Token: 0x06017A63 RID: 96867 RVA: 0x00371290 File Offset: 0x0036F490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueLootInfo.Descriptor;
			}
		}

		// Token: 0x06017A64 RID: 96868 RVA: 0x00371297 File Offset: 0x0036F497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootInfo()
		{
		}

		// Token: 0x06017A65 RID: 96869 RVA: 0x003712A0 File Offset: 0x0036F4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootInfo(RoverRogueLootInfo other) : this()
		{
			this.lootRoomPassedCounter_ = other.lootRoomPassedCounter_;
			this.lootLv_ = other.lootLv_;
			this.unlock_ = other.unlock_;
			this.progress_ = other.progress_;
			this.target_ = other.target_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017A66 RID: 96870 RVA: 0x00371300 File Offset: 0x0036F500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootInfo Clone()
		{
			return new RoverRogueLootInfo(this);
		}

		// Token: 0x17004F8F RID: 20367
		// (get) Token: 0x06017A67 RID: 96871 RVA: 0x00371308 File Offset: 0x0036F508
		// (set) Token: 0x06017A68 RID: 96872 RVA: 0x00371310 File Offset: 0x0036F510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LootRoomPassedCounter
		{
			get
			{
				return this.lootRoomPassedCounter_;
			}
			set
			{
				this.lootRoomPassedCounter_ = value;
			}
		}

		// Token: 0x17004F90 RID: 20368
		// (get) Token: 0x06017A69 RID: 96873 RVA: 0x00371319 File Offset: 0x0036F519
		// (set) Token: 0x06017A6A RID: 96874 RVA: 0x00371321 File Offset: 0x0036F521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LootLv
		{
			get
			{
				return this.lootLv_;
			}
			set
			{
				this.lootLv_ = value;
			}
		}

		// Token: 0x17004F91 RID: 20369
		// (get) Token: 0x06017A6B RID: 96875 RVA: 0x0037132A File Offset: 0x0036F52A
		// (set) Token: 0x06017A6C RID: 96876 RVA: 0x00371332 File Offset: 0x0036F532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Unlock
		{
			get
			{
				return this.unlock_;
			}
			set
			{
				this.unlock_ = value;
			}
		}

		// Token: 0x17004F92 RID: 20370
		// (get) Token: 0x06017A6D RID: 96877 RVA: 0x0037133B File Offset: 0x0036F53B
		// (set) Token: 0x06017A6E RID: 96878 RVA: 0x00371343 File Offset: 0x0036F543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x17004F93 RID: 20371
		// (get) Token: 0x06017A6F RID: 96879 RVA: 0x0037134C File Offset: 0x0036F54C
		// (set) Token: 0x06017A70 RID: 96880 RVA: 0x00371354 File Offset: 0x0036F554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x06017A71 RID: 96881 RVA: 0x0037135D File Offset: 0x0036F55D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueLootInfo);
		}

		// Token: 0x06017A72 RID: 96882 RVA: 0x0037136C File Offset: 0x0036F56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueLootInfo other)
		{
			return other != null && (other == this || (this.LootRoomPassedCounter == other.LootRoomPassedCounter && this.LootLv == other.LootLv && this.Unlock == other.Unlock && this.Progress == other.Progress && this.Target == other.Target && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017A73 RID: 96883 RVA: 0x003713E8 File Offset: 0x0036F5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LootRoomPassedCounter != 0)
			{
				num ^= this.LootRoomPassedCounter.GetHashCode();
			}
			if (this.LootLv != 0)
			{
				num ^= this.LootLv.GetHashCode();
			}
			if (this.Unlock)
			{
				num ^= this.Unlock.GetHashCode();
			}
			if (this.Progress != 0)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this.Target != 0)
			{
				num ^= this.Target.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017A74 RID: 96884 RVA: 0x0037148B File Offset: 0x0036F68B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017A75 RID: 96885 RVA: 0x00371498 File Offset: 0x0036F698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017A76 RID: 96886 RVA: 0x003714A4 File Offset: 0x0036F6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LootRoomPassedCounter != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LootRoomPassedCounter);
			}
			if (this.LootLv != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LootLv);
			}
			if (this.Unlock)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Unlock);
			}
			if (this.Progress != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Progress);
			}
			if (this.Target != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Target);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017A77 RID: 96887 RVA: 0x00371550 File Offset: 0x0036F750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LootRoomPassedCounter != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LootRoomPassedCounter);
			}
			if (this.LootLv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LootLv);
			}
			if (this.Unlock)
			{
				num += 2;
			}
			if (this.Progress != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Progress);
			}
			if (this.Target != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Target);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017A78 RID: 96888 RVA: 0x003715E4 File Offset: 0x0036F7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueLootInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LootRoomPassedCounter != 0)
			{
				this.LootRoomPassedCounter = other.LootRoomPassedCounter;
			}
			if (other.LootLv != 0)
			{
				this.LootLv = other.LootLv;
			}
			if (other.Unlock)
			{
				this.Unlock = other.Unlock;
			}
			if (other.Progress != 0)
			{
				this.Progress = other.Progress;
			}
			if (other.Target != 0)
			{
				this.Target = other.Target;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017A79 RID: 96889 RVA: 0x00371670 File Offset: 0x0036F870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017A7A RID: 96890 RVA: 0x0037167C File Offset: 0x0036F87C
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
						this.LootRoomPassedCounter = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.LootLv = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Unlock = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.Progress = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.Target = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008D26 RID: 36134
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D27 RID: 36135
		public const int LootRoomPassedCounterFieldNumber = 1;

		// Token: 0x04008D28 RID: 36136
		private int lootRoomPassedCounter_;

		// Token: 0x04008D29 RID: 36137
		public const int LootLvFieldNumber = 2;

		// Token: 0x04008D2A RID: 36138
		private int lootLv_;

		// Token: 0x04008D2B RID: 36139
		public const int UnlockFieldNumber = 3;

		// Token: 0x04008D2C RID: 36140
		private bool unlock_;

		// Token: 0x04008D2D RID: 36141
		public const int ProgressFieldNumber = 4;

		// Token: 0x04008D2E RID: 36142
		private int progress_;

		// Token: 0x04008D2F RID: 36143
		public const int TargetFieldNumber = 5;

		// Token: 0x04008D30 RID: 36144
		private int target_;
	}
}
