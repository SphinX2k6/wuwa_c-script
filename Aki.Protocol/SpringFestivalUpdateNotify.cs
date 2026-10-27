using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200127C RID: 4732
	[NetMessage(EMessageId.SpringFestivalUpdateNotify)]
	public sealed class SpringFestivalUpdateNotify : IMessage<SpringFestivalUpdateNotify>, IMessage, IEquatable<SpringFestivalUpdateNotify>, IDeepCloneable<SpringFestivalUpdateNotify>, IBufferMessage
	{
		// Token: 0x06019346 RID: 103238 RVA: 0x003AAB55 File Offset: 0x003A8D55
		[NullableContext(1)]
		public static SpringFestivalUpdateNotify Create()
		{
			return new SpringFestivalUpdateNotify();
		}

		// Token: 0x17005508 RID: 21768
		// (get) Token: 0x06019347 RID: 103239 RVA: 0x003AAB5C File Offset: 0x003A8D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005509 RID: 21769
		// (get) Token: 0x06019348 RID: 103240 RVA: 0x003AAB5F File Offset: 0x003A8D5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringFestivalUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06019349 RID: 103241 RVA: 0x003AAB66 File Offset: 0x003A8D66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalUpdateNotify()
		{
		}

		// Token: 0x0601934A RID: 103242 RVA: 0x003AAB70 File Offset: 0x003A8D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalUpdateNotify(SpringFestivalUpdateNotify other) : this()
		{
			switch (other.DataCase)
			{
			case SpringFestivalUpdateNotify.DataOneofCase.FunctionId:
				this.FunctionId = other.FunctionId;
				break;
			case SpringFestivalUpdateNotify.DataOneofCase.Task:
				this.Task = other.Task.Clone();
				break;
			case SpringFestivalUpdateNotify.DataOneofCase.JokerLevelInfos:
				this.JokerLevelInfos = other.JokerLevelInfos.Clone();
				break;
			case SpringFestivalUpdateNotify.DataOneofCase.SkipEntry:
				this.SkipEntry = other.SkipEntry.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601934B RID: 103243 RVA: 0x003AAC03 File Offset: 0x003A8E03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalUpdateNotify Clone()
		{
			return new SpringFestivalUpdateNotify(this);
		}

		// Token: 0x1700550A RID: 21770
		// (get) Token: 0x0601934C RID: 103244 RVA: 0x003AAC0B File Offset: 0x003A8E0B
		// (set) Token: 0x0601934D RID: 103245 RVA: 0x003AAC22 File Offset: 0x003A8E22
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

		// Token: 0x1700550B RID: 21771
		// (get) Token: 0x0601934E RID: 103246 RVA: 0x003AAC38 File Offset: 0x003A8E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFunctionId
		{
			get
			{
				return this.dataCase_ == SpringFestivalUpdateNotify.DataOneofCase.FunctionId;
			}
		}

		// Token: 0x0601934F RID: 103247 RVA: 0x003AAC44 File Offset: 0x003A8E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFunctionId()
		{
			if (this.HasFunctionId)
			{
				this.ClearData();
			}
		}

		// Token: 0x1700550C RID: 21772
		// (get) Token: 0x06019350 RID: 103248 RVA: 0x003AAC54 File Offset: 0x003A8E54
		// (set) Token: 0x06019351 RID: 103249 RVA: 0x003AAC6D File Offset: 0x003A8E6D
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

		// Token: 0x1700550D RID: 21773
		// (get) Token: 0x06019352 RID: 103250 RVA: 0x003AAC84 File Offset: 0x003A8E84
		// (set) Token: 0x06019353 RID: 103251 RVA: 0x003AAC9D File Offset: 0x003A8E9D
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

		// Token: 0x1700550E RID: 21774
		// (get) Token: 0x06019354 RID: 103252 RVA: 0x003AACB4 File Offset: 0x003A8EB4
		// (set) Token: 0x06019355 RID: 103253 RVA: 0x003AACCD File Offset: 0x003A8ECD
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

		// Token: 0x1700550F RID: 21775
		// (get) Token: 0x06019356 RID: 103254 RVA: 0x003AACE4 File Offset: 0x003A8EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalUpdateNotify.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06019357 RID: 103255 RVA: 0x003AACEC File Offset: 0x003A8EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = SpringFestivalUpdateNotify.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06019358 RID: 103256 RVA: 0x003AACFC File Offset: 0x003A8EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringFestivalUpdateNotify);
		}

		// Token: 0x06019359 RID: 103257 RVA: 0x003AAD0C File Offset: 0x003A8F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringFestivalUpdateNotify other)
		{
			return other != null && (other == this || (this.FunctionId == other.FunctionId && object.Equals(this.Task, other.Task) && object.Equals(this.SkipEntry, other.SkipEntry) && object.Equals(this.JokerLevelInfos, other.JokerLevelInfos) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601935A RID: 103258 RVA: 0x003AAD94 File Offset: 0x003A8F94
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

		// Token: 0x0601935B RID: 103259 RVA: 0x003AAE24 File Offset: 0x003A9024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601935C RID: 103260 RVA: 0x003AAE31 File Offset: 0x003A9031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601935D RID: 103261 RVA: 0x003AAE3C File Offset: 0x003A903C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasFunctionId)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.FunctionId);
			}
			if (this.dataCase_ == SpringFestivalUpdateNotify.DataOneofCase.Task)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Task);
			}
			if (this.dataCase_ == SpringFestivalUpdateNotify.DataOneofCase.JokerLevelInfos)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.JokerLevelInfos);
			}
			if (this.dataCase_ == SpringFestivalUpdateNotify.DataOneofCase.SkipEntry)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.SkipEntry);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601935E RID: 103262 RVA: 0x003AAED4 File Offset: 0x003A90D4
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

		// Token: 0x0601935F RID: 103263 RVA: 0x003AAF60 File Offset: 0x003A9160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringFestivalUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			switch (other.DataCase)
			{
			case SpringFestivalUpdateNotify.DataOneofCase.FunctionId:
				this.FunctionId = other.FunctionId;
				break;
			case SpringFestivalUpdateNotify.DataOneofCase.Task:
				if (this.Task == null)
				{
					this.Task = new ConditionTask();
				}
				this.Task.MergeFrom(other.Task);
				break;
			case SpringFestivalUpdateNotify.DataOneofCase.JokerLevelInfos:
				if (this.JokerLevelInfos == null)
				{
					this.JokerLevelInfos = new GuessJokerLevelInfoArray();
				}
				this.JokerLevelInfos.MergeFrom(other.JokerLevelInfos);
				break;
			case SpringFestivalUpdateNotify.DataOneofCase.SkipEntry:
				if (this.SkipEntry == null)
				{
					this.SkipEntry = new SpringSkipEntry();
				}
				this.SkipEntry.MergeFrom(other.SkipEntry);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019360 RID: 103264 RVA: 0x003AB030 File Offset: 0x003A9230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019361 RID: 103265 RVA: 0x003AB03C File Offset: 0x003A923C
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
				if (num <= 90U)
				{
					if (num == 80U)
					{
						this.FunctionId = input.ReadInt32();
						continue;
					}
					if (num == 90U)
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
				}
				else
				{
					if (num == 114U)
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
					if (num == 122U)
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400945B RID: 37979
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400945C RID: 37980
		public const int FunctionIdFieldNumber = 10;

		// Token: 0x0400945D RID: 37981
		public const int TaskFieldNumber = 11;

		// Token: 0x0400945E RID: 37982
		public const int SkipEntryFieldNumber = 15;

		// Token: 0x0400945F RID: 37983
		public const int JokerLevelInfosFieldNumber = 14;

		// Token: 0x04009460 RID: 37984
		private object data_;

		// Token: 0x04009461 RID: 37985
		private SpringFestivalUpdateNotify.DataOneofCase dataCase_;

		// Token: 0x020019A8 RID: 6568
		public enum DataOneofCase
		{
			// Token: 0x0400CA3C RID: 51772
			None,
			// Token: 0x0400CA3D RID: 51773
			FunctionId = 10,
			// Token: 0x0400CA3E RID: 51774
			Task,
			// Token: 0x0400CA3F RID: 51775
			SkipEntry = 15,
			// Token: 0x0400CA40 RID: 51776
			JokerLevelInfos = 14
		}
	}
}
