using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006DC RID: 1756
	[NetMessage(EMessageId.GiantItemAccessProgressChangeNotify)]
	public sealed class GiantItemAccessProgressChangeNotify : IMessage<GiantItemAccessProgressChangeNotify>, IMessage, IEquatable<GiantItemAccessProgressChangeNotify>, IDeepCloneable<GiantItemAccessProgressChangeNotify>, IBufferMessage
	{
		// Token: 0x0600A054 RID: 41044 RVA: 0x00184550 File Offset: 0x00182750
		[NullableContext(1)]
		public static GiantItemAccessProgressChangeNotify Create()
		{
			return new GiantItemAccessProgressChangeNotify();
		}

		// Token: 0x17002036 RID: 8246
		// (get) Token: 0x0600A055 RID: 41045 RVA: 0x00184557 File Offset: 0x00182757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002037 RID: 8247
		// (get) Token: 0x0600A056 RID: 41046 RVA: 0x0018455A File Offset: 0x0018275A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantItemAccessProgressChangeNotify.Descriptor;
			}
		}

		// Token: 0x0600A057 RID: 41047 RVA: 0x00184561 File Offset: 0x00182761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantItemAccessProgressChangeNotify()
		{
		}

		// Token: 0x0600A058 RID: 41048 RVA: 0x00184569 File Offset: 0x00182769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantItemAccessProgressChangeNotify(GiantItemAccessProgressChangeNotify other) : this()
		{
			this.giantItemAccessPb_ = ((other.giantItemAccessPb_ != null) ? other.giantItemAccessPb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A059 RID: 41049 RVA: 0x0018459E File Offset: 0x0018279E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantItemAccessProgressChangeNotify Clone()
		{
			return new GiantItemAccessProgressChangeNotify(this);
		}

		// Token: 0x17002038 RID: 8248
		// (get) Token: 0x0600A05A RID: 41050 RVA: 0x001845A6 File Offset: 0x001827A6
		// (set) Token: 0x0600A05B RID: 41051 RVA: 0x001845AE File Offset: 0x001827AE
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

		// Token: 0x0600A05C RID: 41052 RVA: 0x001845B7 File Offset: 0x001827B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantItemAccessProgressChangeNotify);
		}

		// Token: 0x0600A05D RID: 41053 RVA: 0x001845C5 File Offset: 0x001827C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantItemAccessProgressChangeNotify other)
		{
			return other != null && (other == this || (object.Equals(this.GiantItemAccessPb, other.GiantItemAccessPb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A05E RID: 41054 RVA: 0x001845F8 File Offset: 0x001827F8
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

		// Token: 0x0600A05F RID: 41055 RVA: 0x00184634 File Offset: 0x00182834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A060 RID: 41056 RVA: 0x00184641 File Offset: 0x00182841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A061 RID: 41057 RVA: 0x0018464A File Offset: 0x0018284A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.giantItemAccessPb_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.GiantItemAccessPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A062 RID: 41058 RVA: 0x0018467C File Offset: 0x0018287C
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

		// Token: 0x0600A063 RID: 41059 RVA: 0x001846BC File Offset: 0x001828BC
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

		// Token: 0x0600A064 RID: 41060 RVA: 0x00184710 File Offset: 0x00182910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A065 RID: 41061 RVA: 0x0018471C File Offset: 0x0018291C
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
				if (num != 26U)
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

		// Token: 0x04004AAD RID: 19117
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AAE RID: 19118
		public const int GiantItemAccessPbFieldNumber = 3;

		// Token: 0x04004AAF RID: 19119
		private GiantItemAccessPb giantItemAccessPb_;
	}
}
