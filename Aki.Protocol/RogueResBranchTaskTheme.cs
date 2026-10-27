using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FD0 RID: 4048
	public sealed class RogueResBranchTaskTheme : IMessage<RogueResBranchTaskTheme>, IMessage, IEquatable<RogueResBranchTaskTheme>, IDeepCloneable<RogueResBranchTaskTheme>, IBufferMessage
	{
		// Token: 0x06015A34 RID: 88628 RVA: 0x00323ECB File Offset: 0x003220CB
		[NullableContext(1)]
		public static RogueResBranchTaskTheme Create()
		{
			return new RogueResBranchTaskTheme();
		}

		// Token: 0x17004828 RID: 18472
		// (get) Token: 0x06015A35 RID: 88629 RVA: 0x00323ED2 File Offset: 0x003220D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004829 RID: 18473
		// (get) Token: 0x06015A36 RID: 88630 RVA: 0x00323ED5 File Offset: 0x003220D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResBranchTaskTheme.Descriptor;
			}
		}

		// Token: 0x06015A37 RID: 88631 RVA: 0x00323EDC File Offset: 0x003220DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResBranchTaskTheme()
		{
		}

		// Token: 0x06015A38 RID: 88632 RVA: 0x00323EF0 File Offset: 0x003220F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResBranchTaskTheme(RogueResBranchTaskTheme other) : this()
		{
			this.branchActivityTasks_ = other.branchActivityTasks_.Clone();
			this.rogueResTaskThemeId_ = other.rogueResTaskThemeId_;
			this.endTime_ = other.endTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015A39 RID: 88633 RVA: 0x00323F3D File Offset: 0x0032213D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResBranchTaskTheme Clone()
		{
			return new RogueResBranchTaskTheme(this);
		}

		// Token: 0x1700482A RID: 18474
		// (get) Token: 0x06015A3A RID: 88634 RVA: 0x00323F45 File Offset: 0x00322145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> BranchActivityTasks
		{
			get
			{
				return this.branchActivityTasks_;
			}
		}

		// Token: 0x1700482B RID: 18475
		// (get) Token: 0x06015A3B RID: 88635 RVA: 0x00323F4D File Offset: 0x0032214D
		// (set) Token: 0x06015A3C RID: 88636 RVA: 0x00323F55 File Offset: 0x00322155
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RogueResTaskThemeId
		{
			get
			{
				return this.rogueResTaskThemeId_;
			}
			set
			{
				this.rogueResTaskThemeId_ = value;
			}
		}

		// Token: 0x1700482C RID: 18476
		// (get) Token: 0x06015A3D RID: 88637 RVA: 0x00323F5E File Offset: 0x0032215E
		// (set) Token: 0x06015A3E RID: 88638 RVA: 0x00323F66 File Offset: 0x00322166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x06015A3F RID: 88639 RVA: 0x00323F6F File Offset: 0x0032216F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResBranchTaskTheme);
		}

		// Token: 0x06015A40 RID: 88640 RVA: 0x00323F80 File Offset: 0x00322180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResBranchTaskTheme other)
		{
			return other != null && (other == this || (this.branchActivityTasks_.Equals(other.branchActivityTasks_) && this.RogueResTaskThemeId == other.RogueResTaskThemeId && this.EndTime == other.EndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015A41 RID: 88641 RVA: 0x00323FE0 File Offset: 0x003221E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.branchActivityTasks_.GetHashCode();
			if (this.RogueResTaskThemeId != 0)
			{
				num ^= this.RogueResTaskThemeId.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015A42 RID: 88642 RVA: 0x00324046 File Offset: 0x00322246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015A43 RID: 88643 RVA: 0x00324053 File Offset: 0x00322253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015A44 RID: 88644 RVA: 0x0032405C File Offset: 0x0032225C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.branchActivityTasks_.WriteTo(ref output, RogueResBranchTaskTheme._repeated_branchActivityTasks_codec);
			if (this.RogueResTaskThemeId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RogueResTaskThemeId);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015A45 RID: 88645 RVA: 0x003240C8 File Offset: 0x003222C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.branchActivityTasks_.CalculateSize(RogueResBranchTaskTheme._repeated_branchActivityTasks_codec);
			if (this.RogueResTaskThemeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RogueResTaskThemeId);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015A46 RID: 88646 RVA: 0x00324134 File Offset: 0x00322334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResBranchTaskTheme other)
		{
			if (other == null)
			{
				return;
			}
			this.branchActivityTasks_.Add(other.branchActivityTasks_);
			if (other.RogueResTaskThemeId != 0)
			{
				this.RogueResTaskThemeId = other.RogueResTaskThemeId;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015A47 RID: 88647 RVA: 0x00324195 File Offset: 0x00322395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015A48 RID: 88648 RVA: 0x003241A0 File Offset: 0x003223A0
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EndTime = input.ReadInt64();
						}
					}
					else
					{
						this.RogueResTaskThemeId = input.ReadInt32();
					}
				}
				else
				{
					this.branchActivityTasks_.AddEntriesFrom(ref input, RogueResBranchTaskTheme._repeated_branchActivityTasks_codec);
				}
			}
		}

		// Token: 0x040081EA RID: 33258
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081EB RID: 33259
		public const int BranchActivityTasksFieldNumber = 1;

		// Token: 0x040081EC RID: 33260
		private static readonly FieldCodec<ActivityTask> _repeated_branchActivityTasks_codec = FieldCodec.ForMessage<ActivityTask>(10U, ActivityTask.Parser);

		// Token: 0x040081ED RID: 33261
		private readonly RepeatedField<ActivityTask> branchActivityTasks_ = new RepeatedField<ActivityTask>();

		// Token: 0x040081EE RID: 33262
		public const int RogueResTaskThemeIdFieldNumber = 2;

		// Token: 0x040081EF RID: 33263
		private int rogueResTaskThemeId_;

		// Token: 0x040081F0 RID: 33264
		public const int EndTimeFieldNumber = 3;

		// Token: 0x040081F1 RID: 33265
		private long endTime_;
	}
}
