using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013D5 RID: 5077
	[NetMessage(EMessageId.TraceQuestNotify)]
	public sealed class TraceQuestNotify : IMessage<TraceQuestNotify>, IMessage, IEquatable<TraceQuestNotify>, IDeepCloneable<TraceQuestNotify>, IBufferMessage
	{
		// Token: 0x0601AEC3 RID: 110275 RVA: 0x003E6E31 File Offset: 0x003E5031
		[NullableContext(1)]
		public static TraceQuestNotify Create()
		{
			return new TraceQuestNotify();
		}

		// Token: 0x17005AC8 RID: 23240
		// (get) Token: 0x0601AEC4 RID: 110276 RVA: 0x003E6E38 File Offset: 0x003E5038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AC9 RID: 23241
		// (get) Token: 0x0601AEC5 RID: 110277 RVA: 0x003E6E3B File Offset: 0x003E503B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TraceQuestNotify.Descriptor;
			}
		}

		// Token: 0x0601AEC6 RID: 110278 RVA: 0x003E6E42 File Offset: 0x003E5042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceQuestNotify()
		{
		}

		// Token: 0x0601AEC7 RID: 110279 RVA: 0x003E6E4A File Offset: 0x003E504A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceQuestNotify(TraceQuestNotify other) : this()
		{
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AEC8 RID: 110280 RVA: 0x003E6E6F File Offset: 0x003E506F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceQuestNotify Clone()
		{
			return new TraceQuestNotify(this);
		}

		// Token: 0x17005ACA RID: 23242
		// (get) Token: 0x0601AEC9 RID: 110281 RVA: 0x003E6E77 File Offset: 0x003E5077
		// (set) Token: 0x0601AECA RID: 110282 RVA: 0x003E6E7F File Offset: 0x003E507F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestId
		{
			get
			{
				return this.questId_;
			}
			set
			{
				this.questId_ = value;
			}
		}

		// Token: 0x0601AECB RID: 110283 RVA: 0x003E6E88 File Offset: 0x003E5088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TraceQuestNotify);
		}

		// Token: 0x0601AECC RID: 110284 RVA: 0x003E6E96 File Offset: 0x003E5096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TraceQuestNotify other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AECD RID: 110285 RVA: 0x003E6EC4 File Offset: 0x003E50C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AECE RID: 110286 RVA: 0x003E6F03 File Offset: 0x003E5103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AECF RID: 110287 RVA: 0x003E6F10 File Offset: 0x003E5110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AED0 RID: 110288 RVA: 0x003E6F19 File Offset: 0x003E5119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AED1 RID: 110289 RVA: 0x003E6F4C File Offset: 0x003E514C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AED2 RID: 110290 RVA: 0x003E6F8A File Offset: 0x003E518A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TraceQuestNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AED3 RID: 110291 RVA: 0x003E6FBB File Offset: 0x003E51BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AED4 RID: 110292 RVA: 0x003E6FC4 File Offset: 0x003E51C4
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.QuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009C16 RID: 39958
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C17 RID: 39959
		public const int QuestIdFieldNumber = 11;

		// Token: 0x04009C18 RID: 39960
		private int questId_;
	}
}
