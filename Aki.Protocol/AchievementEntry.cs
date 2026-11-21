using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200005B RID: 91
	public sealed class AchievementEntry : IMessage<AchievementEntry>, IMessage, IEquatable<AchievementEntry>, IDeepCloneable<AchievementEntry>, IBufferMessage
	{
		// Token: 0x060015DF RID: 5599 RVA: 0x00039DB0 File Offset: 0x00037FB0
		[NullableContext(1)]
		public static AchievementEntry Create()
		{
			return new AchievementEntry();
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060015E0 RID: 5600 RVA: 0x00039DB7 File Offset: 0x00037FB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AchievementEntry> Parser
		{
			get
			{
				return AchievementEntry._parser;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060015E1 RID: 5601 RVA: 0x00039DBE File Offset: 0x00037FBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060015E2 RID: 5602 RVA: 0x00039DC1 File Offset: 0x00037FC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementEntry.Descriptor;
			}
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x00039DC8 File Offset: 0x00037FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementEntry()
		{
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x00039DD0 File Offset: 0x00037FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementEntry(AchievementEntry other) : this()
		{
			this.id_ = other.id_;
			this.finishTime_ = other.finishTime_;
			this.isReceive_ = other.isReceive_;
			this.progress_ = ((other.progress_ != null) ? other.progress_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x00039E34 File Offset: 0x00038034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementEntry Clone()
		{
			return new AchievementEntry(this);
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060015E6 RID: 5606 RVA: 0x00039E3C File Offset: 0x0003803C
		// (set) Token: 0x060015E7 RID: 5607 RVA: 0x00039E44 File Offset: 0x00038044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060015E8 RID: 5608 RVA: 0x00039E4D File Offset: 0x0003804D
		// (set) Token: 0x060015E9 RID: 5609 RVA: 0x00039E55 File Offset: 0x00038055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FinishTime
		{
			get
			{
				return this.finishTime_;
			}
			set
			{
				this.finishTime_ = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060015EA RID: 5610 RVA: 0x00039E5E File Offset: 0x0003805E
		// (set) Token: 0x060015EB RID: 5611 RVA: 0x00039E66 File Offset: 0x00038066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsReceive
		{
			get
			{
				return this.isReceive_;
			}
			set
			{
				this.isReceive_ = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060015EC RID: 5612 RVA: 0x00039E6F File Offset: 0x0003806F
		// (set) Token: 0x060015ED RID: 5613 RVA: 0x00039E77 File Offset: 0x00038077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementProgress Progress
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

		// Token: 0x060015EE RID: 5614 RVA: 0x00039E80 File Offset: 0x00038080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementEntry);
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00039E90 File Offset: 0x00038090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementEntry other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.FinishTime == other.FinishTime && this.IsReceive == other.IsReceive && object.Equals(this.Progress, other.Progress) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00039F00 File Offset: 0x00038100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.FinishTime != 0U)
			{
				num ^= this.FinishTime.GetHashCode();
			}
			if (this.IsReceive)
			{
				num ^= this.IsReceive.GetHashCode();
			}
			if (this.progress_ != null)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00039F87 File Offset: 0x00038187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00039F94 File Offset: 0x00038194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00039FA0 File Offset: 0x000381A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.FinishTime != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.FinishTime);
			}
			if (this.IsReceive)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsReceive);
			}
			if (this.progress_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Progress);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x0003A030 File Offset: 0x00038230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.FinishTime != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FinishTime);
			}
			if (this.IsReceive)
			{
				num += 2;
			}
			if (this.progress_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Progress);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x0003A0AC File Offset: 0x000382AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AchievementEntry other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.FinishTime != 0U)
			{
				this.FinishTime = other.FinishTime;
			}
			if (other.IsReceive)
			{
				this.IsReceive = other.IsReceive;
			}
			if (other.progress_ != null)
			{
				if (this.progress_ == null)
				{
					this.Progress = new AchievementProgress();
				}
				this.Progress.MergeFrom(other.Progress);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x0003A13C File Offset: 0x0003833C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x0003A148 File Offset: 0x00038348
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
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.FinishTime = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.IsReceive = input.ReadBool();
						continue;
					}
					if (num == 34U)
					{
						if (this.progress_ == null)
						{
							this.Progress = new AchievementProgress();
						}
						input.ReadMessage(this.Progress);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400210A RID: 8458
		private static readonly MessageParser<AchievementEntry> _parser = new MessageParser<AchievementEntry>(() => new AchievementEntry());

		// Token: 0x0400210B RID: 8459
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400210C RID: 8460
		public const int IdFieldNumber = 1;

		// Token: 0x0400210D RID: 8461
		private int id_;

		// Token: 0x0400210E RID: 8462
		public const int FinishTimeFieldNumber = 2;

		// Token: 0x0400210F RID: 8463
		private uint finishTime_;

		// Token: 0x04002110 RID: 8464
		public const int IsReceiveFieldNumber = 3;

		// Token: 0x04002111 RID: 8465
		private bool isReceive_;

		// Token: 0x04002112 RID: 8466
		public const int ProgressFieldNumber = 4;

		// Token: 0x04002113 RID: 8467
		private AchievementProgress progress_;
	}
}
