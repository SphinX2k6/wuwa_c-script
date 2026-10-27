using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005FE RID: 1534
	public sealed class FlowOptionInfo : IMessage<FlowOptionInfo>, IMessage, IEquatable<FlowOptionInfo>, IDeepCloneable<FlowOptionInfo>, IBufferMessage
	{
		// Token: 0x06008DEC RID: 36332 RVA: 0x0015815B File Offset: 0x0015635B
		[NullableContext(1)]
		public static FlowOptionInfo Create()
		{
			return new FlowOptionInfo();
		}

		// Token: 0x17001C25 RID: 7205
		// (get) Token: 0x06008DED RID: 36333 RVA: 0x00158162 File Offset: 0x00156362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FlowOptionInfo> Parser
		{
			get
			{
				return FlowOptionInfo._parser;
			}
		}

		// Token: 0x17001C26 RID: 7206
		// (get) Token: 0x06008DEE RID: 36334 RVA: 0x00158169 File Offset: 0x00156369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C27 RID: 7207
		// (get) Token: 0x06008DEF RID: 36335 RVA: 0x0015816C File Offset: 0x0015636C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowOptionInfo.Descriptor;
			}
		}

		// Token: 0x06008DF0 RID: 36336 RVA: 0x00158173 File Offset: 0x00156373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowOptionInfo()
		{
		}

		// Token: 0x06008DF1 RID: 36337 RVA: 0x0015817B File Offset: 0x0015637B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowOptionInfo(FlowOptionInfo other) : this()
		{
			this.talkId_ = other.talkId_;
			this.optionIndex_ = other.optionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008DF2 RID: 36338 RVA: 0x001581AC File Offset: 0x001563AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowOptionInfo Clone()
		{
			return new FlowOptionInfo(this);
		}

		// Token: 0x17001C28 RID: 7208
		// (get) Token: 0x06008DF3 RID: 36339 RVA: 0x001581B4 File Offset: 0x001563B4
		// (set) Token: 0x06008DF4 RID: 36340 RVA: 0x001581BC File Offset: 0x001563BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TalkId
		{
			get
			{
				return this.talkId_;
			}
			set
			{
				this.talkId_ = value;
			}
		}

		// Token: 0x17001C29 RID: 7209
		// (get) Token: 0x06008DF5 RID: 36341 RVA: 0x001581C5 File Offset: 0x001563C5
		// (set) Token: 0x06008DF6 RID: 36342 RVA: 0x001581CD File Offset: 0x001563CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OptionIndex
		{
			get
			{
				return this.optionIndex_;
			}
			set
			{
				this.optionIndex_ = value;
			}
		}

		// Token: 0x06008DF7 RID: 36343 RVA: 0x001581D6 File Offset: 0x001563D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowOptionInfo);
		}

		// Token: 0x06008DF8 RID: 36344 RVA: 0x001581E4 File Offset: 0x001563E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowOptionInfo other)
		{
			return other != null && (other == this || (this.TalkId == other.TalkId && this.OptionIndex == other.OptionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008DF9 RID: 36345 RVA: 0x00158224 File Offset: 0x00156424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TalkId != 0)
			{
				num ^= this.TalkId.GetHashCode();
			}
			if (this.OptionIndex != 0)
			{
				num ^= this.OptionIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008DFA RID: 36346 RVA: 0x0015827C File Offset: 0x0015647C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008DFB RID: 36347 RVA: 0x00158289 File Offset: 0x00156489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008DFC RID: 36348 RVA: 0x00158294 File Offset: 0x00156494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TalkId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TalkId);
			}
			if (this.OptionIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.OptionIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008DFD RID: 36349 RVA: 0x001582EC File Offset: 0x001564EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TalkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TalkId);
			}
			if (this.OptionIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OptionIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008DFE RID: 36350 RVA: 0x00158344 File Offset: 0x00156544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowOptionInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TalkId != 0)
			{
				this.TalkId = other.TalkId;
			}
			if (other.OptionIndex != 0)
			{
				this.OptionIndex = other.OptionIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008DFF RID: 36351 RVA: 0x00158394 File Offset: 0x00156594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E00 RID: 36352 RVA: 0x001583A0 File Offset: 0x001565A0
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
						this.OptionIndex = input.ReadInt32();
					}
				}
				else
				{
					this.TalkId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004531 RID: 17713
		private static readonly MessageParser<FlowOptionInfo> _parser = new MessageParser<FlowOptionInfo>(() => new FlowOptionInfo());

		// Token: 0x04004532 RID: 17714
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004533 RID: 17715
		public const int TalkIdFieldNumber = 1;

		// Token: 0x04004534 RID: 17716
		private int talkId_;

		// Token: 0x04004535 RID: 17717
		public const int OptionIndexFieldNumber = 2;

		// Token: 0x04004536 RID: 17718
		private int optionIndex_;
	}
}
