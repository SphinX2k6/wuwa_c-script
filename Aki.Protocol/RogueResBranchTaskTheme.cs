using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FC0 RID: 4032
	public sealed class RogueResBranchTaskTheme : IMessage<RogueResBranchTaskTheme>, IMessage, IEquatable<RogueResBranchTaskTheme>, IDeepCloneable<RogueResBranchTaskTheme>, IBufferMessage
	{
		// Token: 0x0601594F RID: 88399 RVA: 0x00322817 File Offset: 0x00320A17
		[NullableContext(1)]
		public static RogueResBranchTaskTheme Create()
		{
			return new RogueResBranchTaskTheme();
		}

		// Token: 0x170047FE RID: 18430
		// (get) Token: 0x06015950 RID: 88400 RVA: 0x0032281E File Offset: 0x00320A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047FF RID: 18431
		// (get) Token: 0x06015951 RID: 88401 RVA: 0x00322821 File Offset: 0x00320A21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResBranchTaskTheme.Descriptor;
			}
		}

		// Token: 0x06015952 RID: 88402 RVA: 0x00322828 File Offset: 0x00320A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResBranchTaskTheme()
		{
		}

		// Token: 0x06015953 RID: 88403 RVA: 0x0032283C File Offset: 0x00320A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResBranchTaskTheme(RogueResBranchTaskTheme other) : this()
		{
			this.branchActivityTasks_ = other.branchActivityTasks_.Clone();
			this.rogueResTaskThemeId_ = other.rogueResTaskThemeId_;
			this.endTime_ = other.endTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015954 RID: 88404 RVA: 0x00322889 File Offset: 0x00320A89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResBranchTaskTheme Clone()
		{
			return new RogueResBranchTaskTheme(this);
		}

		// Token: 0x17004800 RID: 18432
		// (get) Token: 0x06015955 RID: 88405 RVA: 0x00322891 File Offset: 0x00320A91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> BranchActivityTasks
		{
			get
			{
				return this.branchActivityTasks_;
			}
		}

		// Token: 0x17004801 RID: 18433
		// (get) Token: 0x06015956 RID: 88406 RVA: 0x00322899 File Offset: 0x00320A99
		// (set) Token: 0x06015957 RID: 88407 RVA: 0x003228A1 File Offset: 0x00320AA1
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

		// Token: 0x17004802 RID: 18434
		// (get) Token: 0x06015958 RID: 88408 RVA: 0x003228AA File Offset: 0x00320AAA
		// (set) Token: 0x06015959 RID: 88409 RVA: 0x003228B2 File Offset: 0x00320AB2
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

		// Token: 0x0601595A RID: 88410 RVA: 0x003228BB File Offset: 0x00320ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResBranchTaskTheme);
		}

		// Token: 0x0601595B RID: 88411 RVA: 0x003228CC File Offset: 0x00320ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResBranchTaskTheme other)
		{
			return other != null && (other == this || (this.branchActivityTasks_.Equals(other.branchActivityTasks_) && this.RogueResTaskThemeId == other.RogueResTaskThemeId && this.EndTime == other.EndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601595C RID: 88412 RVA: 0x0032292C File Offset: 0x00320B2C
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

		// Token: 0x0601595D RID: 88413 RVA: 0x00322992 File Offset: 0x00320B92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601595E RID: 88414 RVA: 0x0032299F File Offset: 0x00320B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601595F RID: 88415 RVA: 0x003229A8 File Offset: 0x00320BA8
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

		// Token: 0x06015960 RID: 88416 RVA: 0x00322A14 File Offset: 0x00320C14
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

		// Token: 0x06015961 RID: 88417 RVA: 0x00322A80 File Offset: 0x00320C80
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

		// Token: 0x06015962 RID: 88418 RVA: 0x00322AE1 File Offset: 0x00320CE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015963 RID: 88419 RVA: 0x00322AEC File Offset: 0x00320CEC
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

		// Token: 0x04008214 RID: 33300
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008215 RID: 33301
		public const int BranchActivityTasksFieldNumber = 1;

		// Token: 0x04008216 RID: 33302
		private static readonly FieldCodec<ActivityTask> _repeated_branchActivityTasks_codec = FieldCodec.ForMessage<ActivityTask>(10U, ActivityTask.Parser);

		// Token: 0x04008217 RID: 33303
		private readonly RepeatedField<ActivityTask> branchActivityTasks_ = new RepeatedField<ActivityTask>();

		// Token: 0x04008218 RID: 33304
		public const int RogueResTaskThemeIdFieldNumber = 2;

		// Token: 0x04008219 RID: 33305
		private int rogueResTaskThemeId_;

		// Token: 0x0400821A RID: 33306
		public const int EndTimeFieldNumber = 3;

		// Token: 0x0400821B RID: 33307
		private long endTime_;
	}
}
