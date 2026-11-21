using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012EB RID: 4843
	[NetMessage(EMessageId.SpringFestivalUpdateNotify)]
	public sealed class SpringFestivalUpdateNotify : IMessage<SpringFestivalUpdateNotify>, IMessage, IEquatable<SpringFestivalUpdateNotify>, IDeepCloneable<SpringFestivalUpdateNotify>, IBufferMessage
	{
		// Token: 0x06019D7C RID: 105852 RVA: 0x003C52A9 File Offset: 0x003C34A9
		[NullableContext(1)]
		public static SpringFestivalUpdateNotify Create()
		{
			return new SpringFestivalUpdateNotify();
		}

		// Token: 0x17005789 RID: 22409
		// (get) Token: 0x06019D7D RID: 105853 RVA: 0x003C52B0 File Offset: 0x003C34B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700578A RID: 22410
		// (get) Token: 0x06019D7E RID: 105854 RVA: 0x003C52B3 File Offset: 0x003C34B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringFestivalUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06019D7F RID: 105855 RVA: 0x003C52BA File Offset: 0x003C34BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalUpdateNotify()
		{
		}

		// Token: 0x06019D80 RID: 105856 RVA: 0x003C52C4 File Offset: 0x003C34C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalUpdateNotify(SpringFestivalUpdateNotify other) : this()
		{
			SpringFestivalUpdateNotify.DataOneofCase dataCase = other.DataCase;
			if (dataCase != SpringFestivalUpdateNotify.DataOneofCase.Task)
			{
				switch (dataCase)
				{
				case SpringFestivalUpdateNotify.DataOneofCase.SkipEntry:
					this.SkipEntry = other.SkipEntry.Clone();
					break;
				case SpringFestivalUpdateNotify.DataOneofCase.JokerLevelInfos:
					this.JokerLevelInfos = other.JokerLevelInfos.Clone();
					break;
				case SpringFestivalUpdateNotify.DataOneofCase.FunctionId:
					this.FunctionId = other.FunctionId;
					break;
				}
			}
			else
			{
				this.Task = other.Task.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019D81 RID: 105857 RVA: 0x003C5352 File Offset: 0x003C3552
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalUpdateNotify Clone()
		{
			return new SpringFestivalUpdateNotify(this);
		}

		// Token: 0x1700578B RID: 22411
		// (get) Token: 0x06019D82 RID: 105858 RVA: 0x003C535A File Offset: 0x003C355A
		// (set) Token: 0x06019D83 RID: 105859 RVA: 0x003C5371 File Offset: 0x003C3571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FunctionId
		{
			get
			{
				if (!this.HasFunctionId)
				{
					return 0;
				}
				return (int)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = SpringFestivalUpdateNotify.DataOneofCase.FunctionId;
			}
		}

		// Token: 0x1700578C RID: 22412
		// (get) Token: 0x06019D84 RID: 105860 RVA: 0x003C5387 File Offset: 0x003C3587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFunctionId
		{
			get
			{
				return this.dataCase_ == SpringFestivalUpdateNotify.DataOneofCase.FunctionId;
			}
		}

		// Token: 0x06019D85 RID: 105861 RVA: 0x003C5393 File Offset: 0x003C3593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFunctionId()
		{
			if (this.HasFunctionId)
			{
				this.ClearData();
			}
		}

		// Token: 0x1700578D RID: 22413
		// (get) Token: 0x06019D86 RID: 105862 RVA: 0x003C53A3 File Offset: 0x003C35A3
		// (set) Token: 0x06019D87 RID: 105863 RVA: 0x003C53BB File Offset: 0x003C35BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTask Task
		{
			get
			{
				if (this.dataCase_ != SpringFestivalUpdateNotify.DataOneofCase.Task)
				{
					return null;
				}
				return (ConditionTask)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SpringFestivalUpdateNotify.DataOneofCase.None : SpringFestivalUpdateNotify.DataOneofCase.Task);
			}
		}

		// Token: 0x1700578E RID: 22414
		// (get) Token: 0x06019D88 RID: 105864 RVA: 0x003C53D1 File Offset: 0x003C35D1
		// (set) Token: 0x06019D89 RID: 105865 RVA: 0x003C53E9 File Offset: 0x003C35E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSkipEntry SkipEntry
		{
			get
			{
				if (this.dataCase_ != SpringFestivalUpdateNotify.DataOneofCase.SkipEntry)
				{
					return null;
				}
				return (SpringSkipEntry)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SpringFestivalUpdateNotify.DataOneofCase.None : SpringFestivalUpdateNotify.DataOneofCase.SkipEntry);
			}
		}

		// Token: 0x1700578F RID: 22415
		// (get) Token: 0x06019D8A RID: 105866 RVA: 0x003C53FF File Offset: 0x003C35FF
		// (set) Token: 0x06019D8B RID: 105867 RVA: 0x003C5417 File Offset: 0x003C3617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuessJokerLevelInfoArray JokerLevelInfos
		{
			get
			{
				if (this.dataCase_ != SpringFestivalUpdateNotify.DataOneofCase.JokerLevelInfos)
				{
					return null;
				}
				return (GuessJokerLevelInfoArray)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SpringFestivalUpdateNotify.DataOneofCase.None : SpringFestivalUpdateNotify.DataOneofCase.JokerLevelInfos);
			}
		}

		// Token: 0x17005790 RID: 22416
		// (get) Token: 0x06019D8C RID: 105868 RVA: 0x003C542D File Offset: 0x003C362D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalUpdateNotify.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06019D8D RID: 105869 RVA: 0x003C5435 File Offset: 0x003C3635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = SpringFestivalUpdateNotify.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06019D8E RID: 105870 RVA: 0x003C5445 File Offset: 0x003C3645
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringFestivalUpdateNotify);
		}

		// Token: 0x06019D8F RID: 105871 RVA: 0x003C5454 File Offset: 0x003C3654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringFestivalUpdateNotify other)
		{
			return other != null && (other == this || (this.FunctionId == other.FunctionId && object.Equals(this.Task, other.Task) && object.Equals(this.SkipEntry, other.SkipEntry) && object.Equals(this.JokerLevelInfos, other.JokerLevelInfos) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019D90 RID: 105872 RVA: 0x003C54DC File Offset: 0x003C36DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HasFunctionId)
			{
				num ^= this.FunctionId.GetHashCode();
			}
			if (this.dataCase_ == SpringFestivalUpdateNotify.DataOneofCase.Task)
			{
				num ^= this.Task.GetHashCode();
			}
			if (this.dataCase_ == SpringFestivalUpdateNotify.DataOneofCase.SkipEntry)
			{
				num ^= this.SkipEntry.GetHashCode();
			}
			if (this.dataCase_ == SpringFestivalUpdateNotify.DataOneofCase.JokerLevelInfos)
			{
				num ^= this.JokerLevelInfos.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019D91 RID: 105873 RVA: 0x003C5569 File Offset: 0x003C3769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019D92 RID: 105874 RVA: 0x003C5576 File Offset: 0x003C3776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019D93 RID: 105875 RVA: 0x003C5580 File Offset: 0x003C3780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dataCase_ == SpringFestivalUpdateNotify.DataOneofCase.Task)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Task);
			}
			if (this.dataCase_ == SpringFestivalUpdateNotify.DataOneofCase.SkipEntry)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.SkipEntry);
			}
			if (this.dataCase_ == SpringFestivalUpdateNotify.DataOneofCase.JokerLevelInfos)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.JokerLevelInfos);
			}
			if (this.HasFunctionId)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.FunctionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019D94 RID: 105876 RVA: 0x003C5614 File Offset: 0x003C3814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HasFunctionId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FunctionId);
			}
			if (this.dataCase_ == SpringFestivalUpdateNotify.DataOneofCase.Task)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Task);
			}
			if (this.dataCase_ == SpringFestivalUpdateNotify.DataOneofCase.SkipEntry)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SkipEntry);
			}
			if (this.dataCase_ == SpringFestivalUpdateNotify.DataOneofCase.JokerLevelInfos)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.JokerLevelInfos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019D95 RID: 105877 RVA: 0x003C56A0 File Offset: 0x003C38A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringFestivalUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			SpringFestivalUpdateNotify.DataOneofCase dataCase = other.DataCase;
			if (dataCase != SpringFestivalUpdateNotify.DataOneofCase.Task)
			{
				switch (dataCase)
				{
				case SpringFestivalUpdateNotify.DataOneofCase.SkipEntry:
					if (this.SkipEntry == null)
					{
						this.SkipEntry = new SpringSkipEntry();
					}
					this.SkipEntry.MergeFrom(other.SkipEntry);
					break;
				case SpringFestivalUpdateNotify.DataOneofCase.JokerLevelInfos:
					if (this.JokerLevelInfos == null)
					{
						this.JokerLevelInfos = new GuessJokerLevelInfoArray();
					}
					this.JokerLevelInfos.MergeFrom(other.JokerLevelInfos);
					break;
				case SpringFestivalUpdateNotify.DataOneofCase.FunctionId:
					this.FunctionId = other.FunctionId;
					break;
				}
			}
			else
			{
				if (this.Task == null)
				{
					this.Task = new ConditionTask();
				}
				this.Task.MergeFrom(other.Task);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019D96 RID: 105878 RVA: 0x003C576B File Offset: 0x003C396B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019D97 RID: 105879 RVA: 0x003C5774 File Offset: 0x003C3974
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
				if (num <= 50U)
				{
					if (num == 18U)
					{
						ConditionTask conditionTask = new ConditionTask();
						if (this.dataCase_ == SpringFestivalUpdateNotify.DataOneofCase.Task)
						{
							conditionTask.MergeFrom(this.Task);
						}
						input.ReadMessage(conditionTask);
						this.Task = conditionTask;
						continue;
					}
					if (num == 50U)
					{
						SpringSkipEntry springSkipEntry = new SpringSkipEntry();
						if (this.dataCase_ == SpringFestivalUpdateNotify.DataOneofCase.SkipEntry)
						{
							springSkipEntry.MergeFrom(this.SkipEntry);
						}
						input.ReadMessage(springSkipEntry);
						this.SkipEntry = springSkipEntry;
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						GuessJokerLevelInfoArray guessJokerLevelInfoArray = new GuessJokerLevelInfoArray();
						if (this.dataCase_ == SpringFestivalUpdateNotify.DataOneofCase.JokerLevelInfos)
						{
							guessJokerLevelInfoArray.MergeFrom(this.JokerLevelInfos);
						}
						input.ReadMessage(guessJokerLevelInfoArray);
						this.JokerLevelInfos = guessJokerLevelInfoArray;
						continue;
					}
					if (num == 72U)
					{
						this.FunctionId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009885 RID: 39045
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009886 RID: 39046
		public const int FunctionIdFieldNumber = 9;

		// Token: 0x04009887 RID: 39047
		public const int TaskFieldNumber = 2;

		// Token: 0x04009888 RID: 39048
		public const int SkipEntryFieldNumber = 6;

		// Token: 0x04009889 RID: 39049
		public const int JokerLevelInfosFieldNumber = 7;

		// Token: 0x0400988A RID: 39050
		private object data_;

		// Token: 0x0400988B RID: 39051
		private SpringFestivalUpdateNotify.DataOneofCase dataCase_;

		// Token: 0x02001A46 RID: 6726
		public enum DataOneofCase
		{
			// Token: 0x0400CFA3 RID: 53155
			None,
			// Token: 0x0400CFA4 RID: 53156
			FunctionId = 9,
			// Token: 0x0400CFA5 RID: 53157
			Task = 2,
			// Token: 0x0400CFA6 RID: 53158
			SkipEntry = 6,
			// Token: 0x0400CFA7 RID: 53159
			JokerLevelInfos
		}
	}
}
