using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006DC RID: 1756
	[NetMessage(EMessageId.GivebackInfoUpdateNotify)]
	public sealed class GivebackInfoUpdateNotify : IMessage<GivebackInfoUpdateNotify>, IMessage, IEquatable<GivebackInfoUpdateNotify>, IDeepCloneable<GivebackInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600A089 RID: 41097 RVA: 0x00184EB5 File Offset: 0x001830B5
		[NullableContext(1)]
		public static GivebackInfoUpdateNotify Create()
		{
			return new GivebackInfoUpdateNotify();
		}

		// Token: 0x1700203B RID: 8251
		// (get) Token: 0x0600A08A RID: 41098 RVA: 0x00184EBC File Offset: 0x001830BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700203C RID: 8252
		// (get) Token: 0x0600A08B RID: 41099 RVA: 0x00184EBF File Offset: 0x001830BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GivebackInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600A08C RID: 41100 RVA: 0x00184EC6 File Offset: 0x001830C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackInfoUpdateNotify()
		{
		}

		// Token: 0x0600A08D RID: 41101 RVA: 0x00184ECE File Offset: 0x001830CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackInfoUpdateNotify(GivebackInfoUpdateNotify other) : this()
		{
			this.givebackInfo_ = ((other.givebackInfo_ != null) ? other.givebackInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A08E RID: 41102 RVA: 0x00184F03 File Offset: 0x00183103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackInfoUpdateNotify Clone()
		{
			return new GivebackInfoUpdateNotify(this);
		}

		// Token: 0x1700203D RID: 8253
		// (get) Token: 0x0600A08F RID: 41103 RVA: 0x00184F0B File Offset: 0x0018310B
		// (set) Token: 0x0600A090 RID: 41104 RVA: 0x00184F13 File Offset: 0x00183113
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

		// Token: 0x0600A091 RID: 41105 RVA: 0x00184F1C File Offset: 0x0018311C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GivebackInfoUpdateNotify);
		}

		// Token: 0x0600A092 RID: 41106 RVA: 0x00184F2A File Offset: 0x0018312A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GivebackInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.GivebackInfo, other.GivebackInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A093 RID: 41107 RVA: 0x00184F60 File Offset: 0x00183160
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

		// Token: 0x0600A094 RID: 41108 RVA: 0x00184F9C File Offset: 0x0018319C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A095 RID: 41109 RVA: 0x00184FA9 File Offset: 0x001831A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A096 RID: 41110 RVA: 0x00184FB2 File Offset: 0x001831B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.givebackInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.GivebackInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A097 RID: 41111 RVA: 0x00184FE4 File Offset: 0x001831E4
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

		// Token: 0x0600A098 RID: 41112 RVA: 0x00185024 File Offset: 0x00183224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GivebackInfoUpdateNotify other)
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

		// Token: 0x0600A099 RID: 41113 RVA: 0x00185078 File Offset: 0x00183278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A09A RID: 41114 RVA: 0x00185084 File Offset: 0x00183284
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
				if (num != 42U)
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

		// Token: 0x04004B11 RID: 19217
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B12 RID: 19218
		public const int GivebackInfoFieldNumber = 5;

		// Token: 0x04004B13 RID: 19219
		private GivebackInfoPb givebackInfo_;
	}
}
