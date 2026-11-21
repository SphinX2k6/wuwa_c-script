using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AC2 RID: 2754
	public sealed class Mp4BackgroundColorPb : IMessage<Mp4BackgroundColorPb>, IMessage, IEquatable<Mp4BackgroundColorPb>, IDeepCloneable<Mp4BackgroundColorPb>, IBufferMessage
	{
		// Token: 0x0600F01D RID: 61469 RVA: 0x00231B81 File Offset: 0x0022FD81
		[NullableContext(1)]
		public static Mp4BackgroundColorPb Create()
		{
			return new Mp4BackgroundColorPb();
		}

		// Token: 0x170030E2 RID: 12514
		// (get) Token: 0x0600F01E RID: 61470 RVA: 0x00231B88 File Offset: 0x0022FD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030E3 RID: 12515
		// (get) Token: 0x0600F01F RID: 61471 RVA: 0x00231B8B File Offset: 0x0022FD8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Mp4BackgroundColorPb.Descriptor;
			}
		}

		// Token: 0x0600F020 RID: 61472 RVA: 0x00231B92 File Offset: 0x0022FD92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Mp4BackgroundColorPb()
		{
		}

		// Token: 0x0600F021 RID: 61473 RVA: 0x00231B9A File Offset: 0x0022FD9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Mp4BackgroundColorPb(Mp4BackgroundColorPb other) : this()
		{
			this.fadeIn_ = other.fadeIn_;
			this.fadeOut_ = other.fadeOut_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F022 RID: 61474 RVA: 0x00231BCB File Offset: 0x0022FDCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Mp4BackgroundColorPb Clone()
		{
			return new Mp4BackgroundColorPb(this);
		}

		// Token: 0x170030E4 RID: 12516
		// (get) Token: 0x0600F023 RID: 61475 RVA: 0x00231BD3 File Offset: 0x0022FDD3
		// (set) Token: 0x0600F024 RID: 61476 RVA: 0x00231BDB File Offset: 0x0022FDDB
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

		// Token: 0x170030E5 RID: 12517
		// (get) Token: 0x0600F025 RID: 61477 RVA: 0x00231BE4 File Offset: 0x0022FDE4
		// (set) Token: 0x0600F026 RID: 61478 RVA: 0x00231BEC File Offset: 0x0022FDEC
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

		// Token: 0x0600F027 RID: 61479 RVA: 0x00231BF5 File Offset: 0x0022FDF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Mp4BackgroundColorPb);
		}

		// Token: 0x0600F028 RID: 61480 RVA: 0x00231C03 File Offset: 0x0022FE03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Mp4BackgroundColorPb other)
		{
			return other != null && (other == this || (this.FadeIn == other.FadeIn && this.FadeOut == other.FadeOut && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F029 RID: 61481 RVA: 0x00231C44 File Offset: 0x0022FE44
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

		// Token: 0x0600F02A RID: 61482 RVA: 0x00231CA8 File Offset: 0x0022FEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F02B RID: 61483 RVA: 0x00231CB5 File Offset: 0x0022FEB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F02C RID: 61484 RVA: 0x00231CC0 File Offset: 0x0022FEC0
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

		// Token: 0x0600F02D RID: 61485 RVA: 0x00231D18 File Offset: 0x0022FF18
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

		// Token: 0x0600F02E RID: 61486 RVA: 0x00231D70 File Offset: 0x0022FF70
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

		// Token: 0x0600F02F RID: 61487 RVA: 0x00231DC0 File Offset: 0x0022FFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F030 RID: 61488 RVA: 0x00231DCC File Offset: 0x0022FFCC
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

		// Token: 0x0400617F RID: 24959
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006180 RID: 24960
		public const int FadeInFieldNumber = 1;

		// Token: 0x04006181 RID: 24961
		private Mp4BackgroundColor fadeIn_;

		// Token: 0x04006182 RID: 24962
		public const int FadeOutFieldNumber = 2;

		// Token: 0x04006183 RID: 24963
		private Mp4BackgroundColor fadeOut_;
	}
}
