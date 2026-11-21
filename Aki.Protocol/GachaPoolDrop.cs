using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000684 RID: 1668
	public sealed class GachaPoolDrop : IMessage<GachaPoolDrop>, IMessage, IEquatable<GachaPoolDrop>, IDeepCloneable<GachaPoolDrop>, IBufferMessage
	{
		// Token: 0x06009933 RID: 39219 RVA: 0x001721AF File Offset: 0x001703AF
		[NullableContext(1)]
		public static GachaPoolDrop Create()
		{
			return new GachaPoolDrop();
		}

		// Token: 0x17001E9A RID: 7834
		// (get) Token: 0x06009934 RID: 39220 RVA: 0x001721B6 File Offset: 0x001703B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GachaPoolDrop> Parser
		{
			get
			{
				return GachaPoolDrop._parser;
			}
		}

		// Token: 0x17001E9B RID: 7835
		// (get) Token: 0x06009935 RID: 39221 RVA: 0x001721BD File Offset: 0x001703BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E9C RID: 7836
		// (get) Token: 0x06009936 RID: 39222 RVA: 0x001721C0 File Offset: 0x001703C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaPoolDrop.Descriptor;
			}
		}

		// Token: 0x06009937 RID: 39223 RVA: 0x001721C7 File Offset: 0x001703C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolDrop()
		{
		}

		// Token: 0x06009938 RID: 39224 RVA: 0x001721CF File Offset: 0x001703CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolDrop(GachaPoolDrop other) : this()
		{
			this.itemId_ = other.itemId_;
			this.isUp_ = other.isUp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009939 RID: 39225 RVA: 0x00172200 File Offset: 0x00170400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolDrop Clone()
		{
			return new GachaPoolDrop(this);
		}

		// Token: 0x17001E9D RID: 7837
		// (get) Token: 0x0600993A RID: 39226 RVA: 0x00172208 File Offset: 0x00170408
		// (set) Token: 0x0600993B RID: 39227 RVA: 0x00172210 File Offset: 0x00170410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17001E9E RID: 7838
		// (get) Token: 0x0600993C RID: 39228 RVA: 0x00172219 File Offset: 0x00170419
		// (set) Token: 0x0600993D RID: 39229 RVA: 0x00172221 File Offset: 0x00170421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUp
		{
			get
			{
				return this.isUp_;
			}
			set
			{
				this.isUp_ = value;
			}
		}

		// Token: 0x0600993E RID: 39230 RVA: 0x0017222A File Offset: 0x0017042A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaPoolDrop);
		}

		// Token: 0x0600993F RID: 39231 RVA: 0x00172238 File Offset: 0x00170438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaPoolDrop other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.IsUp == other.IsUp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009940 RID: 39232 RVA: 0x00172278 File Offset: 0x00170478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.IsUp)
			{
				num ^= this.IsUp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009941 RID: 39233 RVA: 0x001722D0 File Offset: 0x001704D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009942 RID: 39234 RVA: 0x001722DD File Offset: 0x001704DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009943 RID: 39235 RVA: 0x001722E8 File Offset: 0x001704E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.IsUp)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsUp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009944 RID: 39236 RVA: 0x00172340 File Offset: 0x00170540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.IsUp)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009945 RID: 39237 RVA: 0x0017238C File Offset: 0x0017058C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaPoolDrop other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.IsUp)
			{
				this.IsUp = other.IsUp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009946 RID: 39238 RVA: 0x001723DC File Offset: 0x001705DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009947 RID: 39239 RVA: 0x001723E8 File Offset: 0x001705E8
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
						this.IsUp = input.ReadBool();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400490B RID: 18699
		private static readonly MessageParser<GachaPoolDrop> _parser = new MessageParser<GachaPoolDrop>(() => new GachaPoolDrop());

		// Token: 0x0400490C RID: 18700
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400490D RID: 18701
		public const int ItemIdFieldNumber = 1;

		// Token: 0x0400490E RID: 18702
		private int itemId_;

		// Token: 0x0400490F RID: 18703
		public const int IsUpFieldNumber = 2;

		// Token: 0x04004910 RID: 18704
		private bool isUp_;
	}
}
