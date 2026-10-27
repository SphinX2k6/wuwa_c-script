using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AD3 RID: 2771
	public sealed class Mp4BackgroundColorPb : IMessage<Mp4BackgroundColorPb>, IMessage, IEquatable<Mp4BackgroundColorPb>, IDeepCloneable<Mp4BackgroundColorPb>, IBufferMessage
	{
		// Token: 0x0600F137 RID: 61751 RVA: 0x00233D8D File Offset: 0x00231F8D
		[NullableContext(1)]
		public static Mp4BackgroundColorPb Create()
		{
			return new Mp4BackgroundColorPb();
		}

		// Token: 0x17003120 RID: 12576
		// (get) Token: 0x0600F138 RID: 61752 RVA: 0x00233D94 File Offset: 0x00231F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003121 RID: 12577
		// (get) Token: 0x0600F139 RID: 61753 RVA: 0x00233D97 File Offset: 0x00231F97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Mp4BackgroundColorPb.Descriptor;
			}
		}

		// Token: 0x0600F13A RID: 61754 RVA: 0x00233D9E File Offset: 0x00231F9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Mp4BackgroundColorPb()
		{
		}

		// Token: 0x0600F13B RID: 61755 RVA: 0x00233DA6 File Offset: 0x00231FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Mp4BackgroundColorPb(Mp4BackgroundColorPb other) : this()
		{
			this.fadeIn_ = other.fadeIn_;
			this.fadeOut_ = other.fadeOut_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F13C RID: 61756 RVA: 0x00233DD7 File Offset: 0x00231FD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Mp4BackgroundColorPb Clone()
		{
			return new Mp4BackgroundColorPb(this);
		}

		// Token: 0x17003122 RID: 12578
		// (get) Token: 0x0600F13D RID: 61757 RVA: 0x00233DDF File Offset: 0x00231FDF
		// (set) Token: 0x0600F13E RID: 61758 RVA: 0x00233DE7 File Offset: 0x00231FE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Mp4BackgroundColor FadeIn
		{
			get
			{
				return this.fadeIn_;
			}
			set
			{
				this.fadeIn_ = value;
			}
		}

		// Token: 0x17003123 RID: 12579
		// (get) Token: 0x0600F13F RID: 61759 RVA: 0x00233DF0 File Offset: 0x00231FF0
		// (set) Token: 0x0600F140 RID: 61760 RVA: 0x00233DF8 File Offset: 0x00231FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Mp4BackgroundColor FadeOut
		{
			get
			{
				return this.fadeOut_;
			}
			set
			{
				this.fadeOut_ = value;
			}
		}

		// Token: 0x0600F141 RID: 61761 RVA: 0x00233E01 File Offset: 0x00232001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Mp4BackgroundColorPb);
		}

		// Token: 0x0600F142 RID: 61762 RVA: 0x00233E0F File Offset: 0x0023200F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Mp4BackgroundColorPb other)
		{
			return other != null && (other == this || (this.FadeIn == other.FadeIn && this.FadeOut == other.FadeOut && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F143 RID: 61763 RVA: 0x00233E50 File Offset: 0x00232050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FadeIn != Mp4BackgroundColor.Black)
			{
				num ^= this.FadeIn.GetHashCode();
			}
			if (this.FadeOut != Mp4BackgroundColor.Black)
			{
				num ^= this.FadeOut.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F144 RID: 61764 RVA: 0x00233EB4 File Offset: 0x002320B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F145 RID: 61765 RVA: 0x00233EC1 File Offset: 0x002320C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F146 RID: 61766 RVA: 0x00233ECC File Offset: 0x002320CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FadeIn != Mp4BackgroundColor.Black)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.FadeIn);
			}
			if (this.FadeOut != Mp4BackgroundColor.Black)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.FadeOut);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F147 RID: 61767 RVA: 0x00233F24 File Offset: 0x00232124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FadeIn != Mp4BackgroundColor.Black)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.FadeIn);
			}
			if (this.FadeOut != Mp4BackgroundColor.Black)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.FadeOut);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F148 RID: 61768 RVA: 0x00233F7C File Offset: 0x0023217C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Mp4BackgroundColorPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FadeIn != Mp4BackgroundColor.Black)
			{
				this.FadeIn = other.FadeIn;
			}
			if (other.FadeOut != Mp4BackgroundColor.Black)
			{
				this.FadeOut = other.FadeOut;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F149 RID: 61769 RVA: 0x00233FCC File Offset: 0x002321CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F14A RID: 61770 RVA: 0x00233FD8 File Offset: 0x002321D8
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
						this.FadeOut = (Mp4BackgroundColor)input.ReadEnum();
					}
				}
				else
				{
					this.FadeIn = (Mp4BackgroundColor)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006176 RID: 24950
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006177 RID: 24951
		public const int FadeInFieldNumber = 1;

		// Token: 0x04006178 RID: 24952
		private Mp4BackgroundColor fadeIn_;

		// Token: 0x04006179 RID: 24953
		public const int FadeOutFieldNumber = 2;

		// Token: 0x0400617A RID: 24954
		private Mp4BackgroundColor fadeOut_;
	}
}
