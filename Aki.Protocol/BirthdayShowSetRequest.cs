using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001A3 RID: 419
	[NetMessage(EMessageId.BirthdayShowSetRequest)]
	public sealed class BirthdayShowSetRequest : IMessage<BirthdayShowSetRequest>, IMessage, IEquatable<BirthdayShowSetRequest>, IDeepCloneable<BirthdayShowSetRequest>, IBufferMessage
	{
		// Token: 0x06003172 RID: 12658 RVA: 0x0007DEF1 File Offset: 0x0007C0F1
		[NullableContext(1)]
		public static BirthdayShowSetRequest Create()
		{
			return new BirthdayShowSetRequest();
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06003173 RID: 12659 RVA: 0x0007DEF8 File Offset: 0x0007C0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06003174 RID: 12660 RVA: 0x0007DEFB File Offset: 0x0007C0FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BirthdayShowSetRequest.Descriptor;
			}
		}

		// Token: 0x06003175 RID: 12661 RVA: 0x0007DF02 File Offset: 0x0007C102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthdayShowSetRequest()
		{
		}

		// Token: 0x06003176 RID: 12662 RVA: 0x0007DF0A File Offset: 0x0007C10A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthdayShowSetRequest(BirthdayShowSetRequest other) : this()
		{
			this.disPlay_ = other.disPlay_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003177 RID: 12663 RVA: 0x0007DF2F File Offset: 0x0007C12F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthdayShowSetRequest Clone()
		{
			return new BirthdayShowSetRequest(this);
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06003178 RID: 12664 RVA: 0x0007DF37 File Offset: 0x0007C137
		// (set) Token: 0x06003179 RID: 12665 RVA: 0x0007DF3F File Offset: 0x0007C13F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DisPlay
		{
			get
			{
				return this.disPlay_;
			}
			set
			{
				this.disPlay_ = value;
			}
		}

		// Token: 0x0600317A RID: 12666 RVA: 0x0007DF48 File Offset: 0x0007C148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BirthdayShowSetRequest);
		}

		// Token: 0x0600317B RID: 12667 RVA: 0x0007DF56 File Offset: 0x0007C156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BirthdayShowSetRequest other)
		{
			return other != null && (other == this || (this.DisPlay == other.DisPlay && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600317C RID: 12668 RVA: 0x0007DF84 File Offset: 0x0007C184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DisPlay)
			{
				num ^= this.DisPlay.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600317D RID: 12669 RVA: 0x0007DFC3 File Offset: 0x0007C1C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600317E RID: 12670 RVA: 0x0007DFD0 File Offset: 0x0007C1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600317F RID: 12671 RVA: 0x0007DFD9 File Offset: 0x0007C1D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DisPlay)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.DisPlay);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003180 RID: 12672 RVA: 0x0007E00C File Offset: 0x0007C20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DisPlay)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x0007E03E File Offset: 0x0007C23E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BirthdayShowSetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DisPlay)
			{
				this.DisPlay = other.DisPlay;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003182 RID: 12674 RVA: 0x0007E06F File Offset: 0x0007C26F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003183 RID: 12675 RVA: 0x0007E078 File Offset: 0x0007C278
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DisPlay = input.ReadBool();
				}
			}
		}

		// Token: 0x04002987 RID: 10631
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002988 RID: 10632
		public const int DisPlayFieldNumber = 7;

		// Token: 0x04002989 RID: 10633
		private bool disPlay_;
	}
}
