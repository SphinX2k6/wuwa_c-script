using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006F7 RID: 1783
	[NetMessage(EMessageId.GivebackUnlockNotify)]
	public sealed class GivebackUnlockNotify : IMessage<GivebackUnlockNotify>, IMessage, IEquatable<GivebackUnlockNotify>, IDeepCloneable<GivebackUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600A279 RID: 41593 RVA: 0x00188F13 File Offset: 0x00187113
		[NullableContext(1)]
		public static GivebackUnlockNotify Create()
		{
			return new GivebackUnlockNotify();
		}

		// Token: 0x170020A9 RID: 8361
		// (get) Token: 0x0600A27A RID: 41594 RVA: 0x00188F1A File Offset: 0x0018711A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020AA RID: 8362
		// (get) Token: 0x0600A27B RID: 41595 RVA: 0x00188F1D File Offset: 0x0018711D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GivebackUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600A27C RID: 41596 RVA: 0x00188F24 File Offset: 0x00187124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackUnlockNotify()
		{
		}

		// Token: 0x0600A27D RID: 41597 RVA: 0x00188F2C File Offset: 0x0018712C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackUnlockNotify(GivebackUnlockNotify other) : this()
		{
			this.givebackInfo_ = ((other.givebackInfo_ != null) ? other.givebackInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A27E RID: 41598 RVA: 0x00188F61 File Offset: 0x00187161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackUnlockNotify Clone()
		{
			return new GivebackUnlockNotify(this);
		}

		// Token: 0x170020AB RID: 8363
		// (get) Token: 0x0600A27F RID: 41599 RVA: 0x00188F69 File Offset: 0x00187169
		// (set) Token: 0x0600A280 RID: 41600 RVA: 0x00188F71 File Offset: 0x00187171
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

		// Token: 0x0600A281 RID: 41601 RVA: 0x00188F7A File Offset: 0x0018717A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GivebackUnlockNotify);
		}

		// Token: 0x0600A282 RID: 41602 RVA: 0x00188F88 File Offset: 0x00187188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GivebackUnlockNotify other)
		{
			return other != null && (other == this || (object.Equals(this.GivebackInfo, other.GivebackInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A283 RID: 41603 RVA: 0x00188FBC File Offset: 0x001871BC
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

		// Token: 0x0600A284 RID: 41604 RVA: 0x00188FF8 File Offset: 0x001871F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A285 RID: 41605 RVA: 0x00189005 File Offset: 0x00187205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A286 RID: 41606 RVA: 0x0018900E File Offset: 0x0018720E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.givebackInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.GivebackInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A287 RID: 41607 RVA: 0x00189040 File Offset: 0x00187240
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

		// Token: 0x0600A288 RID: 41608 RVA: 0x00189080 File Offset: 0x00187280
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

		// Token: 0x0600A289 RID: 41609 RVA: 0x001890D4 File Offset: 0x001872D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A28A RID: 41610 RVA: 0x001890E0 File Offset: 0x001872E0
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
				if (num != 90U)
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

		// Token: 0x04004B4C RID: 19276
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B4D RID: 19277
		public const int GivebackInfoFieldNumber = 11;

		// Token: 0x04004B4E RID: 19278
		private GivebackInfoPb givebackInfo_;
	}
}
