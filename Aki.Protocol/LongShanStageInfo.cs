using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000943 RID: 2371
	public sealed class LongShanStageInfo : IMessage<LongShanStageInfo>, IMessage, IEquatable<LongShanStageInfo>, IDeepCloneable<LongShanStageInfo>, IBufferMessage
	{
		// Token: 0x0600D159 RID: 53593 RVA: 0x001EE1D8 File Offset: 0x001EC3D8
		[NullableContext(1)]
		public static LongShanStageInfo Create()
		{
			return new LongShanStageInfo();
		}

		// Token: 0x17002A5A RID: 10842
		// (get) Token: 0x0600D15A RID: 53594 RVA: 0x001EE1DF File Offset: 0x001EC3DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LongShanStageInfo> Parser
		{
			get
			{
				return LongShanStageInfo._parser;
			}
		}

		// Token: 0x17002A5B RID: 10843
		// (get) Token: 0x0600D15B RID: 53595 RVA: 0x001EE1E6 File Offset: 0x001EC3E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A5C RID: 10844
		// (get) Token: 0x0600D15C RID: 53596 RVA: 0x001EE1E9 File Offset: 0x001EC3E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LongShanStageInfo.Descriptor;
			}
		}

		// Token: 0x0600D15D RID: 53597 RVA: 0x001EE1F0 File Offset: 0x001EC3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanStageInfo()
		{
		}

		// Token: 0x0600D15E RID: 53598 RVA: 0x001EE204 File Offset: 0x001EC404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanStageInfo(LongShanStageInfo other) : this()
		{
			this.id_ = other.id_;
			this.tasks_ = other.tasks_.Clone();
			this.unlock_ = other.unlock_;
			this.beginOpenTime_ = other.beginOpenTime_;
			this.endOpenTime_ = other.endOpenTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D15F RID: 53599 RVA: 0x001EE269 File Offset: 0x001EC469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanStageInfo Clone()
		{
			return new LongShanStageInfo(this);
		}

		// Token: 0x17002A5D RID: 10845
		// (get) Token: 0x0600D160 RID: 53600 RVA: 0x001EE271 File Offset: 0x001EC471
		// (set) Token: 0x0600D161 RID: 53601 RVA: 0x001EE279 File Offset: 0x001EC479
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

		// Token: 0x17002A5E RID: 10846
		// (get) Token: 0x0600D162 RID: 53602 RVA: 0x001EE282 File Offset: 0x001EC482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LongShanTaskInfo> Tasks
		{
			get
			{
				return this.tasks_;
			}
		}

		// Token: 0x17002A5F RID: 10847
		// (get) Token: 0x0600D163 RID: 53603 RVA: 0x001EE28A File Offset: 0x001EC48A
		// (set) Token: 0x0600D164 RID: 53604 RVA: 0x001EE292 File Offset: 0x001EC492
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

		// Token: 0x17002A60 RID: 10848
		// (get) Token: 0x0600D165 RID: 53605 RVA: 0x001EE29B File Offset: 0x001EC49B
		// (set) Token: 0x0600D166 RID: 53606 RVA: 0x001EE2A3 File Offset: 0x001EC4A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginOpenTime
		{
			get
			{
				return this.beginOpenTime_;
			}
			set
			{
				this.beginOpenTime_ = value;
			}
		}

		// Token: 0x17002A61 RID: 10849
		// (get) Token: 0x0600D167 RID: 53607 RVA: 0x001EE2AC File Offset: 0x001EC4AC
		// (set) Token: 0x0600D168 RID: 53608 RVA: 0x001EE2B4 File Offset: 0x001EC4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndOpenTime
		{
			get
			{
				return this.endOpenTime_;
			}
			set
			{
				this.endOpenTime_ = value;
			}
		}

		// Token: 0x0600D169 RID: 53609 RVA: 0x001EE2BD File Offset: 0x001EC4BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LongShanStageInfo);
		}

		// Token: 0x0600D16A RID: 53610 RVA: 0x001EE2CC File Offset: 0x001EC4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LongShanStageInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.tasks_.Equals(other.tasks_) && this.Unlock == other.Unlock && this.BeginOpenTime == other.BeginOpenTime && this.EndOpenTime == other.EndOpenTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D16B RID: 53611 RVA: 0x001EE34C File Offset: 0x001EC54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.tasks_.GetHashCode();
			if (this.Unlock)
			{
				num ^= this.Unlock.GetHashCode();
			}
			if (this.BeginOpenTime != 0L)
			{
				num ^= this.BeginOpenTime.GetHashCode();
			}
			if (this.EndOpenTime != 0L)
			{
				num ^= this.EndOpenTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D16C RID: 53612 RVA: 0x001EE3E4 File Offset: 0x001EC5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D16D RID: 53613 RVA: 0x001EE3F1 File Offset: 0x001EC5F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D16E RID: 53614 RVA: 0x001EE3FC File Offset: 0x001EC5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			this.tasks_.WriteTo(ref output, LongShanStageInfo._repeated_tasks_codec);
			if (this.Unlock)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Unlock);
			}
			if (this.BeginOpenTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.BeginOpenTime);
			}
			if (this.EndOpenTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EndOpenTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D16F RID: 53615 RVA: 0x001EE4A0 File Offset: 0x001EC6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			num += this.tasks_.CalculateSize(LongShanStageInfo._repeated_tasks_codec);
			if (this.Unlock)
			{
				num += 2;
			}
			if (this.BeginOpenTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginOpenTime);
			}
			if (this.EndOpenTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndOpenTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D170 RID: 53616 RVA: 0x001EE530 File Offset: 0x001EC730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LongShanStageInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this.tasks_.Add(other.tasks_);
			if (other.Unlock)
			{
				this.Unlock = other.Unlock;
			}
			if (other.BeginOpenTime != 0L)
			{
				this.BeginOpenTime = other.BeginOpenTime;
			}
			if (other.EndOpenTime != 0L)
			{
				this.EndOpenTime = other.EndOpenTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D171 RID: 53617 RVA: 0x001EE5B9 File Offset: 0x001EC7B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D172 RID: 53618 RVA: 0x001EE5C4 File Offset: 0x001EC7C4
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.tasks_.AddEntriesFrom(ref input, LongShanStageInfo._repeated_tasks_codec);
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
						this.BeginOpenTime = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.EndOpenTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005890 RID: 22672
		private static readonly MessageParser<LongShanStageInfo> _parser = new MessageParser<LongShanStageInfo>(() => new LongShanStageInfo());

		// Token: 0x04005891 RID: 22673
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005892 RID: 22674
		public const int IdFieldNumber = 1;

		// Token: 0x04005893 RID: 22675
		private int id_;

		// Token: 0x04005894 RID: 22676
		public const int TasksFieldNumber = 2;

		// Token: 0x04005895 RID: 22677
		private static readonly FieldCodec<LongShanTaskInfo> _repeated_tasks_codec = FieldCodec.ForMessage<LongShanTaskInfo>(18U, LongShanTaskInfo.Parser);

		// Token: 0x04005896 RID: 22678
		private readonly RepeatedField<LongShanTaskInfo> tasks_ = new RepeatedField<LongShanTaskInfo>();

		// Token: 0x04005897 RID: 22679
		public const int UnlockFieldNumber = 3;

		// Token: 0x04005898 RID: 22680
		private bool unlock_;

		// Token: 0x04005899 RID: 22681
		public const int BeginOpenTimeFieldNumber = 4;

		// Token: 0x0400589A RID: 22682
		private long beginOpenTime_;

		// Token: 0x0400589B RID: 22683
		public const int EndOpenTimeFieldNumber = 5;

		// Token: 0x0400589C RID: 22684
		private long endOpenTime_;
	}
}
