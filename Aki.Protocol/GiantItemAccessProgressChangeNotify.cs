using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006C8 RID: 1736
	[NetMessage(EMessageId.GiantItemAccessProgressChangeNotify)]
	public sealed class GiantItemAccessProgressChangeNotify : IMessage<GiantItemAccessProgressChangeNotify>, IMessage, IEquatable<GiantItemAccessProgressChangeNotify>, IDeepCloneable<GiantItemAccessProgressChangeNotify>, IBufferMessage
	{
		// Token: 0x06009EFE RID: 40702 RVA: 0x00181B1C File Offset: 0x0017FD1C
		[NullableContext(1)]
		public static GiantItemAccessProgressChangeNotify Create()
		{
			return new GiantItemAccessProgressChangeNotify();
		}

		// Token: 0x17001FEC RID: 8172
		// (get) Token: 0x06009EFF RID: 40703 RVA: 0x00181B23 File Offset: 0x0017FD23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FED RID: 8173
		// (get) Token: 0x06009F00 RID: 40704 RVA: 0x00181B26 File Offset: 0x0017FD26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantItemAccessProgressChangeNotify.Descriptor;
			}
		}

		// Token: 0x06009F01 RID: 40705 RVA: 0x00181B2D File Offset: 0x0017FD2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantItemAccessProgressChangeNotify()
		{
		}

		// Token: 0x06009F02 RID: 40706 RVA: 0x00181B35 File Offset: 0x0017FD35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantItemAccessProgressChangeNotify(GiantItemAccessProgressChangeNotify other) : this()
		{
			this.giantItemAccessPb_ = ((other.giantItemAccessPb_ != null) ? other.giantItemAccessPb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F03 RID: 40707 RVA: 0x00181B6A File Offset: 0x0017FD6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantItemAccessProgressChangeNotify Clone()
		{
			return new GiantItemAccessProgressChangeNotify(this);
		}

		// Token: 0x17001FEE RID: 8174
		// (get) Token: 0x06009F04 RID: 40708 RVA: 0x00181B72 File Offset: 0x0017FD72
		// (set) Token: 0x06009F05 RID: 40709 RVA: 0x00181B7A File Offset: 0x0017FD7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantItemAccessPb GiantItemAccessPb
		{
			get
			{
				return this.giantItemAccessPb_;
			}
			set
			{
				this.giantItemAccessPb_ = value;
			}
		}

		// Token: 0x06009F06 RID: 40710 RVA: 0x00181B83 File Offset: 0x0017FD83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantItemAccessProgressChangeNotify);
		}

		// Token: 0x06009F07 RID: 40711 RVA: 0x00181B91 File Offset: 0x0017FD91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantItemAccessProgressChangeNotify other)
		{
			return other != null && (other == this || (object.Equals(this.GiantItemAccessPb, other.GiantItemAccessPb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009F08 RID: 40712 RVA: 0x00181BC4 File Offset: 0x0017FDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.giantItemAccessPb_ != null)
			{
				num ^= this.GiantItemAccessPb.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009F09 RID: 40713 RVA: 0x00181C00 File Offset: 0x0017FE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009F0A RID: 40714 RVA: 0x00181C0D File Offset: 0x0017FE0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F0B RID: 40715 RVA: 0x00181C16 File Offset: 0x0017FE16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.giantItemAccessPb_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.GiantItemAccessPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F0C RID: 40716 RVA: 0x00181C48 File Offset: 0x0017FE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.giantItemAccessPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GiantItemAccessPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009F0D RID: 40717 RVA: 0x00181C88 File Offset: 0x0017FE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantItemAccessProgressChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.giantItemAccessPb_ != null)
			{
				if (this.giantItemAccessPb_ == null)
				{
					this.GiantItemAccessPb = new GiantItemAccessPb();
				}
				this.GiantItemAccessPb.MergeFrom(other.GiantItemAccessPb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009F0E RID: 40718 RVA: 0x00181CDC File Offset: 0x0017FEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F0F RID: 40719 RVA: 0x00181CE8 File Offset: 0x0017FEE8
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.giantItemAccessPb_ == null)
					{
						this.GiantItemAccessPb = new GiantItemAccessPb();
					}
					input.ReadMessage(this.GiantItemAccessPb);
				}
			}
		}

		// Token: 0x04004AA6 RID: 19110
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AA7 RID: 19111
		public const int GiantItemAccessPbFieldNumber = 10;

		// Token: 0x04004AA8 RID: 19112
		private GiantItemAccessPb giantItemAccessPb_;
	}
}
