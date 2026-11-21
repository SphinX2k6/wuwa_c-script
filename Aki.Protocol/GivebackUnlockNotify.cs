using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006E3 RID: 1763
	[NetMessage(EMessageId.GivebackUnlockNotify)]
	public sealed class GivebackUnlockNotify : IMessage<GivebackUnlockNotify>, IMessage, IEquatable<GivebackUnlockNotify>, IDeepCloneable<GivebackUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600A123 RID: 41251 RVA: 0x001864DF File Offset: 0x001846DF
		[NullableContext(1)]
		public static GivebackUnlockNotify Create()
		{
			return new GivebackUnlockNotify();
		}

		// Token: 0x1700205F RID: 8287
		// (get) Token: 0x0600A124 RID: 41252 RVA: 0x001864E6 File Offset: 0x001846E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002060 RID: 8288
		// (get) Token: 0x0600A125 RID: 41253 RVA: 0x001864E9 File Offset: 0x001846E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GivebackUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600A126 RID: 41254 RVA: 0x001864F0 File Offset: 0x001846F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackUnlockNotify()
		{
		}

		// Token: 0x0600A127 RID: 41255 RVA: 0x001864F8 File Offset: 0x001846F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackUnlockNotify(GivebackUnlockNotify other) : this()
		{
			this.givebackInfo_ = ((other.givebackInfo_ != null) ? other.givebackInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A128 RID: 41256 RVA: 0x0018652D File Offset: 0x0018472D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackUnlockNotify Clone()
		{
			return new GivebackUnlockNotify(this);
		}

		// Token: 0x17002061 RID: 8289
		// (get) Token: 0x0600A129 RID: 41257 RVA: 0x00186535 File Offset: 0x00184735
		// (set) Token: 0x0600A12A RID: 41258 RVA: 0x0018653D File Offset: 0x0018473D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackInfoPb GivebackInfo
		{
			get
			{
				return this.givebackInfo_;
			}
			set
			{
				this.givebackInfo_ = value;
			}
		}

		// Token: 0x0600A12B RID: 41259 RVA: 0x00186546 File Offset: 0x00184746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GivebackUnlockNotify);
		}

		// Token: 0x0600A12C RID: 41260 RVA: 0x00186554 File Offset: 0x00184754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GivebackUnlockNotify other)
		{
			return other != null && (other == this || (object.Equals(this.GivebackInfo, other.GivebackInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A12D RID: 41261 RVA: 0x00186588 File Offset: 0x00184788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.givebackInfo_ != null)
			{
				num ^= this.GivebackInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A12E RID: 41262 RVA: 0x001865C4 File Offset: 0x001847C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A12F RID: 41263 RVA: 0x001865D1 File Offset: 0x001847D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A130 RID: 41264 RVA: 0x001865DA File Offset: 0x001847DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.givebackInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GivebackInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A131 RID: 41265 RVA: 0x0018660C File Offset: 0x0018480C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.givebackInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GivebackInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A132 RID: 41266 RVA: 0x0018664C File Offset: 0x0018484C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GivebackUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.givebackInfo_ != null)
			{
				if (this.givebackInfo_ == null)
				{
					this.GivebackInfo = new GivebackInfoPb();
				}
				this.GivebackInfo.MergeFrom(other.GivebackInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A133 RID: 41267 RVA: 0x001866A0 File Offset: 0x001848A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A134 RID: 41268 RVA: 0x001866AC File Offset: 0x001848AC
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.givebackInfo_ == null)
					{
						this.GivebackInfo = new GivebackInfoPb();
					}
					input.ReadMessage(this.GivebackInfo);
				}
			}
		}

		// Token: 0x04004B45 RID: 19269
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B46 RID: 19270
		public const int GivebackInfoFieldNumber = 1;

		// Token: 0x04004B47 RID: 19271
		private GivebackInfoPb givebackInfo_;
	}
}
