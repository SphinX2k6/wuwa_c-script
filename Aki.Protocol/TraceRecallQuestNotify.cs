using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200144B RID: 5195
	[NetMessage(EMessageId.TraceRecallQuestNotify)]
	public sealed class TraceRecallQuestNotify : IMessage<TraceRecallQuestNotify>, IMessage, IEquatable<TraceRecallQuestNotify>, IDeepCloneable<TraceRecallQuestNotify>, IBufferMessage
	{
		// Token: 0x0601B988 RID: 113032 RVA: 0x004027F5 File Offset: 0x004009F5
		[NullableContext(1)]
		public static TraceRecallQuestNotify Create()
		{
			return new TraceRecallQuestNotify();
		}

		// Token: 0x17005D68 RID: 23912
		// (get) Token: 0x0601B989 RID: 113033 RVA: 0x004027FC File Offset: 0x004009FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D69 RID: 23913
		// (get) Token: 0x0601B98A RID: 113034 RVA: 0x004027FF File Offset: 0x004009FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TraceRecallQuestNotify.Descriptor;
			}
		}

		// Token: 0x0601B98B RID: 113035 RVA: 0x00402806 File Offset: 0x00400A06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceRecallQuestNotify()
		{
		}

		// Token: 0x0601B98C RID: 113036 RVA: 0x0040280E File Offset: 0x00400A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceRecallQuestNotify(TraceRecallQuestNotify other) : this()
		{
			this.recallQuestId_ = other.recallQuestId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B98D RID: 113037 RVA: 0x00402833 File Offset: 0x00400A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceRecallQuestNotify Clone()
		{
			return new TraceRecallQuestNotify(this);
		}

		// Token: 0x17005D6A RID: 23914
		// (get) Token: 0x0601B98E RID: 113038 RVA: 0x0040283B File Offset: 0x00400A3B
		// (set) Token: 0x0601B98F RID: 113039 RVA: 0x00402843 File Offset: 0x00400A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecallQuestId
		{
			get
			{
				return this.recallQuestId_;
			}
			set
			{
				this.recallQuestId_ = value;
			}
		}

		// Token: 0x0601B990 RID: 113040 RVA: 0x0040284C File Offset: 0x00400A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TraceRecallQuestNotify);
		}

		// Token: 0x0601B991 RID: 113041 RVA: 0x0040285A File Offset: 0x00400A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TraceRecallQuestNotify other)
		{
			return other != null && (other == this || (this.RecallQuestId == other.RecallQuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B992 RID: 113042 RVA: 0x00402888 File Offset: 0x00400A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RecallQuestId != 0)
			{
				num ^= this.RecallQuestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B993 RID: 113043 RVA: 0x004028C7 File Offset: 0x00400AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B994 RID: 113044 RVA: 0x004028D4 File Offset: 0x00400AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B995 RID: 113045 RVA: 0x004028DD File Offset: 0x00400ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallQuestId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RecallQuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B996 RID: 113046 RVA: 0x00402910 File Offset: 0x00400B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallQuestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B997 RID: 113047 RVA: 0x0040294E File Offset: 0x00400B4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TraceRecallQuestNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RecallQuestId != 0)
			{
				this.RecallQuestId = other.RecallQuestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B998 RID: 113048 RVA: 0x0040297F File Offset: 0x00400B7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B999 RID: 113049 RVA: 0x00402988 File Offset: 0x00400B88
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RecallQuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A06A RID: 41066
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A06B RID: 41067
		public const int RecallQuestIdFieldNumber = 6;

		// Token: 0x0400A06C RID: 41068
		private int recallQuestId_;
	}
}
