using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001500 RID: 5376
	[NetMessage(EMessageId.UnlockMarkNotify)]
	public sealed class UnlockMarkNotify : IMessage<UnlockMarkNotify>, IMessage, IEquatable<UnlockMarkNotify>, IDeepCloneable<UnlockMarkNotify>, IBufferMessage
	{
		// Token: 0x0601C7EC RID: 116716 RVA: 0x00421AF9 File Offset: 0x0041FCF9
		[NullableContext(1)]
		public static UnlockMarkNotify Create()
		{
			return new UnlockMarkNotify();
		}

		// Token: 0x1700606B RID: 24683
		// (get) Token: 0x0601C7ED RID: 116717 RVA: 0x00421B00 File Offset: 0x0041FD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700606C RID: 24684
		// (get) Token: 0x0601C7EE RID: 116718 RVA: 0x00421B03 File Offset: 0x0041FD03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockMarkNotify.Descriptor;
			}
		}

		// Token: 0x0601C7EF RID: 116719 RVA: 0x00421B0A File Offset: 0x0041FD0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockMarkNotify()
		{
		}

		// Token: 0x0601C7F0 RID: 116720 RVA: 0x00421B12 File Offset: 0x0041FD12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockMarkNotify(UnlockMarkNotify other) : this()
		{
			this.markId_ = other.markId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C7F1 RID: 116721 RVA: 0x00421B37 File Offset: 0x0041FD37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockMarkNotify Clone()
		{
			return new UnlockMarkNotify(this);
		}

		// Token: 0x1700606D RID: 24685
		// (get) Token: 0x0601C7F2 RID: 116722 RVA: 0x00421B3F File Offset: 0x0041FD3F
		// (set) Token: 0x0601C7F3 RID: 116723 RVA: 0x00421B47 File Offset: 0x0041FD47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MarkId
		{
			get
			{
				return this.markId_;
			}
			set
			{
				this.markId_ = value;
			}
		}

		// Token: 0x0601C7F4 RID: 116724 RVA: 0x00421B50 File Offset: 0x0041FD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockMarkNotify);
		}

		// Token: 0x0601C7F5 RID: 116725 RVA: 0x00421B5E File Offset: 0x0041FD5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockMarkNotify other)
		{
			return other != null && (other == this || (this.MarkId == other.MarkId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C7F6 RID: 116726 RVA: 0x00421B8C File Offset: 0x0041FD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MarkId != 0)
			{
				num ^= this.MarkId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C7F7 RID: 116727 RVA: 0x00421BCB File Offset: 0x0041FDCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C7F8 RID: 116728 RVA: 0x00421BD8 File Offset: 0x0041FDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C7F9 RID: 116729 RVA: 0x00421BE1 File Offset: 0x0041FDE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MarkId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C7FA RID: 116730 RVA: 0x00421C14 File Offset: 0x0041FE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MarkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C7FB RID: 116731 RVA: 0x00421C52 File Offset: 0x0041FE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockMarkNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MarkId != 0)
			{
				this.MarkId = other.MarkId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C7FC RID: 116732 RVA: 0x00421C83 File Offset: 0x0041FE83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C7FD RID: 116733 RVA: 0x00421C8C File Offset: 0x0041FE8C
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MarkId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A464 RID: 42084
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A465 RID: 42085
		public const int MarkIdFieldNumber = 15;

		// Token: 0x0400A466 RID: 42086
		private int markId_;
	}
}
