using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200022A RID: 554
	public sealed class CalabashSkinComponentPb : IMessage<CalabashSkinComponentPb>, IMessage, IEquatable<CalabashSkinComponentPb>, IDeepCloneable<CalabashSkinComponentPb>, IBufferMessage
	{
		// Token: 0x06003C7A RID: 15482 RVA: 0x00096968 File Offset: 0x00094B68
		[NullableContext(1)]
		public static CalabashSkinComponentPb Create()
		{
			return new CalabashSkinComponentPb();
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06003C7B RID: 15483 RVA: 0x0009696F File Offset: 0x00094B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06003C7C RID: 15484 RVA: 0x00096972 File Offset: 0x00094B72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashSkinComponentPb.Descriptor;
			}
		}

		// Token: 0x06003C7D RID: 15485 RVA: 0x00096979 File Offset: 0x00094B79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinComponentPb()
		{
		}

		// Token: 0x06003C7E RID: 15486 RVA: 0x00096981 File Offset: 0x00094B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinComponentPb(CalabashSkinComponentPb other) : this()
		{
			this.calabashSkinId_ = other.calabashSkinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C7F RID: 15487 RVA: 0x000969A6 File Offset: 0x00094BA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinComponentPb Clone()
		{
			return new CalabashSkinComponentPb(this);
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06003C80 RID: 15488 RVA: 0x000969AE File Offset: 0x00094BAE
		// (set) Token: 0x06003C81 RID: 15489 RVA: 0x000969B6 File Offset: 0x00094BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalabashSkinId
		{
			get
			{
				return this.calabashSkinId_;
			}
			set
			{
				this.calabashSkinId_ = value;
			}
		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x000969BF File Offset: 0x00094BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashSkinComponentPb);
		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x000969CD File Offset: 0x00094BCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashSkinComponentPb other)
		{
			return other != null && (other == this || (this.CalabashSkinId == other.CalabashSkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x000969FC File Offset: 0x00094BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CalabashSkinId != 0)
			{
				num ^= this.CalabashSkinId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003C85 RID: 15493 RVA: 0x00096A3B File Offset: 0x00094C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003C86 RID: 15494 RVA: 0x00096A48 File Offset: 0x00094C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C87 RID: 15495 RVA: 0x00096A51 File Offset: 0x00094C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CalabashSkinId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CalabashSkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x00096A84 File Offset: 0x00094C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CalabashSkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CalabashSkinId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003C89 RID: 15497 RVA: 0x00096AC2 File Offset: 0x00094CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashSkinComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CalabashSkinId != 0)
			{
				this.CalabashSkinId = other.CalabashSkinId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003C8A RID: 15498 RVA: 0x00096AF3 File Offset: 0x00094CF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C8B RID: 15499 RVA: 0x00096AFC File Offset: 0x00094CFC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CalabashSkinId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002CC7 RID: 11463
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CC8 RID: 11464
		public const int CalabashSkinIdFieldNumber = 1;

		// Token: 0x04002CC9 RID: 11465
		private int calabashSkinId_;
	}
}
