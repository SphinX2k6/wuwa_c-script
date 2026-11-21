using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FCD RID: 4045
	[NetMessage(EMessageId.RogueResFovUpdateNotify)]
	public sealed class RogueResFovUpdateNotify : IMessage<RogueResFovUpdateNotify>, IMessage, IEquatable<RogueResFovUpdateNotify>, IDeepCloneable<RogueResFovUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015A56 RID: 88662 RVA: 0x00324C11 File Offset: 0x00322E11
		[NullableContext(1)]
		public static RogueResFovUpdateNotify Create()
		{
			return new RogueResFovUpdateNotify();
		}

		// Token: 0x17004835 RID: 18485
		// (get) Token: 0x06015A57 RID: 88663 RVA: 0x00324C18 File Offset: 0x00322E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004836 RID: 18486
		// (get) Token: 0x06015A58 RID: 88664 RVA: 0x00324C1B File Offset: 0x00322E1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResFovUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015A59 RID: 88665 RVA: 0x00324C22 File Offset: 0x00322E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResFovUpdateNotify()
		{
		}

		// Token: 0x06015A5A RID: 88666 RVA: 0x00324C2A File Offset: 0x00322E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResFovUpdateNotify(RogueResFovUpdateNotify other) : this()
		{
			this.fov_ = other.fov_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015A5B RID: 88667 RVA: 0x00324C4F File Offset: 0x00322E4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResFovUpdateNotify Clone()
		{
			return new RogueResFovUpdateNotify(this);
		}

		// Token: 0x17004837 RID: 18487
		// (get) Token: 0x06015A5C RID: 88668 RVA: 0x00324C57 File Offset: 0x00322E57
		// (set) Token: 0x06015A5D RID: 88669 RVA: 0x00324C5F File Offset: 0x00322E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Fov
		{
			get
			{
				return this.fov_;
			}
			set
			{
				this.fov_ = value;
			}
		}

		// Token: 0x06015A5E RID: 88670 RVA: 0x00324C68 File Offset: 0x00322E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResFovUpdateNotify);
		}

		// Token: 0x06015A5F RID: 88671 RVA: 0x00324C76 File Offset: 0x00322E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResFovUpdateNotify other)
		{
			return other != null && (other == this || (this.Fov == other.Fov && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015A60 RID: 88672 RVA: 0x00324CA4 File Offset: 0x00322EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Fov != 0)
			{
				num ^= this.Fov.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015A61 RID: 88673 RVA: 0x00324CE3 File Offset: 0x00322EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015A62 RID: 88674 RVA: 0x00324CF0 File Offset: 0x00322EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015A63 RID: 88675 RVA: 0x00324CF9 File Offset: 0x00322EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Fov != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Fov);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015A64 RID: 88676 RVA: 0x00324D2C File Offset: 0x00322F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Fov != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Fov);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015A65 RID: 88677 RVA: 0x00324D6A File Offset: 0x00322F6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResFovUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Fov != 0)
			{
				this.Fov = other.Fov;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015A66 RID: 88678 RVA: 0x00324D9B File Offset: 0x00322F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015A67 RID: 88679 RVA: 0x00324DA4 File Offset: 0x00322FA4
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Fov = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008264 RID: 33380
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008265 RID: 33381
		public const int FovFieldNumber = 3;

		// Token: 0x04008266 RID: 33382
		private int fov_;
	}
}
