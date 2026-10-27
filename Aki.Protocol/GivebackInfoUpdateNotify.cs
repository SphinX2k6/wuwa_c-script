using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006F0 RID: 1776
	[NetMessage(EMessageId.GivebackInfoUpdateNotify)]
	public sealed class GivebackInfoUpdateNotify : IMessage<GivebackInfoUpdateNotify>, IMessage, IEquatable<GivebackInfoUpdateNotify>, IDeepCloneable<GivebackInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600A1DF RID: 41439 RVA: 0x001878E9 File Offset: 0x00185AE9
		[NullableContext(1)]
		public static GivebackInfoUpdateNotify Create()
		{
			return new GivebackInfoUpdateNotify();
		}

		// Token: 0x17002085 RID: 8325
		// (get) Token: 0x0600A1E0 RID: 41440 RVA: 0x001878F0 File Offset: 0x00185AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002086 RID: 8326
		// (get) Token: 0x0600A1E1 RID: 41441 RVA: 0x001878F3 File Offset: 0x00185AF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GivebackInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600A1E2 RID: 41442 RVA: 0x001878FA File Offset: 0x00185AFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackInfoUpdateNotify()
		{
		}

		// Token: 0x0600A1E3 RID: 41443 RVA: 0x00187902 File Offset: 0x00185B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackInfoUpdateNotify(GivebackInfoUpdateNotify other) : this()
		{
			this.givebackInfo_ = ((other.givebackInfo_ != null) ? other.givebackInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A1E4 RID: 41444 RVA: 0x00187937 File Offset: 0x00185B37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackInfoUpdateNotify Clone()
		{
			return new GivebackInfoUpdateNotify(this);
		}

		// Token: 0x17002087 RID: 8327
		// (get) Token: 0x0600A1E5 RID: 41445 RVA: 0x0018793F File Offset: 0x00185B3F
		// (set) Token: 0x0600A1E6 RID: 41446 RVA: 0x00187947 File Offset: 0x00185B47
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

		// Token: 0x0600A1E7 RID: 41447 RVA: 0x00187950 File Offset: 0x00185B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GivebackInfoUpdateNotify);
		}

		// Token: 0x0600A1E8 RID: 41448 RVA: 0x0018795E File Offset: 0x00185B5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GivebackInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.GivebackInfo, other.GivebackInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A1E9 RID: 41449 RVA: 0x00187994 File Offset: 0x00185B94
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

		// Token: 0x0600A1EA RID: 41450 RVA: 0x001879D0 File Offset: 0x00185BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A1EB RID: 41451 RVA: 0x001879DD File Offset: 0x00185BDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A1EC RID: 41452 RVA: 0x001879E6 File Offset: 0x00185BE6
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

		// Token: 0x0600A1ED RID: 41453 RVA: 0x00187A18 File Offset: 0x00185C18
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

		// Token: 0x0600A1EE RID: 41454 RVA: 0x00187A58 File Offset: 0x00185C58
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

		// Token: 0x0600A1EF RID: 41455 RVA: 0x00187AAC File Offset: 0x00185CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A1F0 RID: 41456 RVA: 0x00187AB8 File Offset: 0x00185CB8
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

		// Token: 0x04004B18 RID: 19224
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B19 RID: 19225
		public const int GivebackInfoFieldNumber = 11;

		// Token: 0x04004B1A RID: 19226
		private GivebackInfoPb givebackInfo_;
	}
}
