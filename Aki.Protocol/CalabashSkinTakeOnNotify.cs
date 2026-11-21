using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200022B RID: 555
	[NetMessage(EMessageId.CalabashSkinTakeOnNotify)]
	public sealed class CalabashSkinTakeOnNotify : IMessage<CalabashSkinTakeOnNotify>, IMessage, IEquatable<CalabashSkinTakeOnNotify>, IDeepCloneable<CalabashSkinTakeOnNotify>, IBufferMessage
	{
		// Token: 0x06003C8C RID: 15500 RVA: 0x00096B40 File Offset: 0x00094D40
		[NullableContext(1)]
		public static CalabashSkinTakeOnNotify Create()
		{
			return new CalabashSkinTakeOnNotify();
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06003C8D RID: 15501 RVA: 0x00096B47 File Offset: 0x00094D47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06003C8E RID: 15502 RVA: 0x00096B4A File Offset: 0x00094D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashSkinTakeOnNotify.Descriptor;
			}
		}

		// Token: 0x06003C8F RID: 15503 RVA: 0x00096B51 File Offset: 0x00094D51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinTakeOnNotify()
		{
		}

		// Token: 0x06003C90 RID: 15504 RVA: 0x00096B59 File Offset: 0x00094D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinTakeOnNotify(CalabashSkinTakeOnNotify other) : this()
		{
			this.skinId_ = other.skinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C91 RID: 15505 RVA: 0x00096B7E File Offset: 0x00094D7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinTakeOnNotify Clone()
		{
			return new CalabashSkinTakeOnNotify(this);
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06003C92 RID: 15506 RVA: 0x00096B86 File Offset: 0x00094D86
		// (set) Token: 0x06003C93 RID: 15507 RVA: 0x00096B8E File Offset: 0x00094D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x06003C94 RID: 15508 RVA: 0x00096B97 File Offset: 0x00094D97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashSkinTakeOnNotify);
		}

		// Token: 0x06003C95 RID: 15509 RVA: 0x00096BA5 File Offset: 0x00094DA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashSkinTakeOnNotify other)
		{
			return other != null && (other == this || (this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003C96 RID: 15510 RVA: 0x00096BD4 File Offset: 0x00094DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003C97 RID: 15511 RVA: 0x00096C13 File Offset: 0x00094E13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003C98 RID: 15512 RVA: 0x00096C20 File Offset: 0x00094E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C99 RID: 15513 RVA: 0x00096C29 File Offset: 0x00094E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkinId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003C9A RID: 15514 RVA: 0x00096C5C File Offset: 0x00094E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003C9B RID: 15515 RVA: 0x00096C9A File Offset: 0x00094E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashSkinTakeOnNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003C9C RID: 15516 RVA: 0x00096CCB File Offset: 0x00094ECB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C9D RID: 15517 RVA: 0x00096CD4 File Offset: 0x00094ED4
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
					this.SkinId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002CCA RID: 11466
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CCB RID: 11467
		public const int SkinIdFieldNumber = 3;

		// Token: 0x04002CCC RID: 11468
		private int skinId_;
	}
}
