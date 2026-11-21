using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005E9 RID: 1513
	public sealed class FlowOptionInfo : IMessage<FlowOptionInfo>, IMessage, IEquatable<FlowOptionInfo>, IDeepCloneable<FlowOptionInfo>, IBufferMessage
	{
		// Token: 0x06008C84 RID: 35972 RVA: 0x0015555B File Offset: 0x0015375B
		[NullableContext(1)]
		public static FlowOptionInfo Create()
		{
			return new FlowOptionInfo();
		}

		// Token: 0x17001BD8 RID: 7128
		// (get) Token: 0x06008C85 RID: 35973 RVA: 0x00155562 File Offset: 0x00153762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FlowOptionInfo> Parser
		{
			get
			{
				return FlowOptionInfo._parser;
			}
		}

		// Token: 0x17001BD9 RID: 7129
		// (get) Token: 0x06008C86 RID: 35974 RVA: 0x00155569 File Offset: 0x00153769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BDA RID: 7130
		// (get) Token: 0x06008C87 RID: 35975 RVA: 0x0015556C File Offset: 0x0015376C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowOptionInfo.Descriptor;
			}
		}

		// Token: 0x06008C88 RID: 35976 RVA: 0x00155573 File Offset: 0x00153773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowOptionInfo()
		{
		}

		// Token: 0x06008C89 RID: 35977 RVA: 0x0015557B File Offset: 0x0015377B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowOptionInfo(FlowOptionInfo other) : this()
		{
			this.talkId_ = other.talkId_;
			this.optionIndex_ = other.optionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008C8A RID: 35978 RVA: 0x001555AC File Offset: 0x001537AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowOptionInfo Clone()
		{
			return new FlowOptionInfo(this);
		}

		// Token: 0x17001BDB RID: 7131
		// (get) Token: 0x06008C8B RID: 35979 RVA: 0x001555B4 File Offset: 0x001537B4
		// (set) Token: 0x06008C8C RID: 35980 RVA: 0x001555BC File Offset: 0x001537BC
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

		// Token: 0x17001BDC RID: 7132
		// (get) Token: 0x06008C8D RID: 35981 RVA: 0x001555C5 File Offset: 0x001537C5
		// (set) Token: 0x06008C8E RID: 35982 RVA: 0x001555CD File Offset: 0x001537CD
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

		// Token: 0x06008C8F RID: 35983 RVA: 0x001555D6 File Offset: 0x001537D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowOptionInfo);
		}

		// Token: 0x06008C90 RID: 35984 RVA: 0x001555E4 File Offset: 0x001537E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowOptionInfo other)
		{
			return other != null && (other == this || (this.TalkId == other.TalkId && this.OptionIndex == other.OptionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008C91 RID: 35985 RVA: 0x00155624 File Offset: 0x00153824
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

		// Token: 0x06008C92 RID: 35986 RVA: 0x0015567C File Offset: 0x0015387C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008C93 RID: 35987 RVA: 0x00155689 File Offset: 0x00153889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C94 RID: 35988 RVA: 0x00155694 File Offset: 0x00153894
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

		// Token: 0x06008C95 RID: 35989 RVA: 0x001556EC File Offset: 0x001538EC
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

		// Token: 0x06008C96 RID: 35990 RVA: 0x00155744 File Offset: 0x00153944
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

		// Token: 0x06008C97 RID: 35991 RVA: 0x00155794 File Offset: 0x00153994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C98 RID: 35992 RVA: 0x001557A0 File Offset: 0x001539A0
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

		// Token: 0x04004527 RID: 17703
		private static readonly MessageParser<FlowOptionInfo> _parser = new MessageParser<FlowOptionInfo>(() => new FlowOptionInfo());

		// Token: 0x04004528 RID: 17704
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004529 RID: 17705
		public const int TalkIdFieldNumber = 1;

		// Token: 0x0400452A RID: 17706
		private int talkId_;

		// Token: 0x0400452B RID: 17707
		public const int OptionIndexFieldNumber = 2;

		// Token: 0x0400452C RID: 17708
		private int optionIndex_;
	}
}
