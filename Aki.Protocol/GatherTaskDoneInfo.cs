using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006A8 RID: 1704
	public sealed class GatherTaskDoneInfo : IMessage<GatherTaskDoneInfo>, IMessage, IEquatable<GatherTaskDoneInfo>, IDeepCloneable<GatherTaskDoneInfo>, IBufferMessage
	{
		// Token: 0x06009C8C RID: 40076 RVA: 0x0017CD87 File Offset: 0x0017AF87
		[NullableContext(1)]
		public static GatherTaskDoneInfo Create()
		{
			return new GatherTaskDoneInfo();
		}

		// Token: 0x17001F71 RID: 8049
		// (get) Token: 0x06009C8D RID: 40077 RVA: 0x0017CD8E File Offset: 0x0017AF8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GatherTaskDoneInfo> Parser
		{
			get
			{
				return GatherTaskDoneInfo._parser;
			}
		}

		// Token: 0x17001F72 RID: 8050
		// (get) Token: 0x06009C8E RID: 40078 RVA: 0x0017CD95 File Offset: 0x0017AF95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F73 RID: 8051
		// (get) Token: 0x06009C8F RID: 40079 RVA: 0x0017CD98 File Offset: 0x0017AF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GatherTaskDoneInfo.Descriptor;
			}
		}

		// Token: 0x06009C90 RID: 40080 RVA: 0x0017CD9F File Offset: 0x0017AF9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherTaskDoneInfo()
		{
		}

		// Token: 0x06009C91 RID: 40081 RVA: 0x0017CDA7 File Offset: 0x0017AFA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherTaskDoneInfo(GatherTaskDoneInfo other) : this()
		{
			this.taskId_ = other.taskId_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C92 RID: 40082 RVA: 0x0017CDD8 File Offset: 0x0017AFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherTaskDoneInfo Clone()
		{
			return new GatherTaskDoneInfo(this);
		}

		// Token: 0x17001F74 RID: 8052
		// (get) Token: 0x06009C93 RID: 40083 RVA: 0x0017CDE0 File Offset: 0x0017AFE0
		// (set) Token: 0x06009C94 RID: 40084 RVA: 0x0017CDE8 File Offset: 0x0017AFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TaskId
		{
			get
			{
				return this.taskId_;
			}
			set
			{
				this.taskId_ = value;
			}
		}

		// Token: 0x17001F75 RID: 8053
		// (get) Token: 0x06009C95 RID: 40085 RVA: 0x0017CDF1 File Offset: 0x0017AFF1
		// (set) Token: 0x06009C96 RID: 40086 RVA: 0x0017CDF9 File Offset: 0x0017AFF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherActivityTaskState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x06009C97 RID: 40087 RVA: 0x0017CE02 File Offset: 0x0017B002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GatherTaskDoneInfo);
		}

		// Token: 0x06009C98 RID: 40088 RVA: 0x0017CE10 File Offset: 0x0017B010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GatherTaskDoneInfo other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009C99 RID: 40089 RVA: 0x0017CE50 File Offset: 0x0017B050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TaskId != 0)
			{
				num ^= this.TaskId.GetHashCode();
			}
			if (this.State != GatherActivityTaskState.GatherLock)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009C9A RID: 40090 RVA: 0x0017CEAE File Offset: 0x0017B0AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009C9B RID: 40091 RVA: 0x0017CEBB File Offset: 0x0017B0BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C9C RID: 40092 RVA: 0x0017CEC4 File Offset: 0x0017B0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TaskId);
			}
			if (this.State != GatherActivityTaskState.GatherLock)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C9D RID: 40093 RVA: 0x0017CF1C File Offset: 0x0017B11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TaskId);
			}
			if (this.State != GatherActivityTaskState.GatherLock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009C9E RID: 40094 RVA: 0x0017CF74 File Offset: 0x0017B174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GatherTaskDoneInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TaskId != 0)
			{
				this.TaskId = other.TaskId;
			}
			if (other.State != GatherActivityTaskState.GatherLock)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009C9F RID: 40095 RVA: 0x0017CFC4 File Offset: 0x0017B1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009CA0 RID: 40096 RVA: 0x0017CFD0 File Offset: 0x0017B1D0
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
						this.State = (GatherActivityTaskState)input.ReadEnum();
					}
				}
				else
				{
					this.TaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004A09 RID: 18953
		private static readonly MessageParser<GatherTaskDoneInfo> _parser = new MessageParser<GatherTaskDoneInfo>(() => new GatherTaskDoneInfo());

		// Token: 0x04004A0A RID: 18954
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A0B RID: 18955
		public const int TaskIdFieldNumber = 1;

		// Token: 0x04004A0C RID: 18956
		private int taskId_;

		// Token: 0x04004A0D RID: 18957
		public const int StateFieldNumber = 2;

		// Token: 0x04004A0E RID: 18958
		private GatherActivityTaskState state_;
	}
}
