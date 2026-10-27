using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000692 RID: 1682
	[NetMessage(EMessageId.GachaInfoRequest)]
	public sealed class GachaInfoRequest : IMessage<GachaInfoRequest>, IMessage, IEquatable<GachaInfoRequest>, IDeepCloneable<GachaInfoRequest>, IBufferMessage
	{
		// Token: 0x06009A05 RID: 39429 RVA: 0x00173538 File Offset: 0x00171738
		[NullableContext(1)]
		public static GachaInfoRequest Create()
		{
			return new GachaInfoRequest();
		}

		// Token: 0x17001EC4 RID: 7876
		// (get) Token: 0x06009A06 RID: 39430 RVA: 0x0017353F File Offset: 0x0017173F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001EC5 RID: 7877
		// (get) Token: 0x06009A07 RID: 39431 RVA: 0x00173542 File Offset: 0x00171742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaInfoRequest.Descriptor;
			}
		}

		// Token: 0x06009A08 RID: 39432 RVA: 0x00173549 File Offset: 0x00171749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaInfoRequest()
		{
		}

		// Token: 0x06009A09 RID: 39433 RVA: 0x00173551 File Offset: 0x00171751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaInfoRequest(GachaInfoRequest other) : this()
		{
			this.language_ = other.language_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009A0A RID: 39434 RVA: 0x00173576 File Offset: 0x00171776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaInfoRequest Clone()
		{
			return new GachaInfoRequest(this);
		}

		// Token: 0x17001EC6 RID: 7878
		// (get) Token: 0x06009A0B RID: 39435 RVA: 0x0017357E File Offset: 0x0017177E
		// (set) Token: 0x06009A0C RID: 39436 RVA: 0x00173586 File Offset: 0x00171786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Language
		{
			get
			{
				return this.language_;
			}
			set
			{
				this.language_ = value;
			}
		}

		// Token: 0x06009A0D RID: 39437 RVA: 0x0017358F File Offset: 0x0017178F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaInfoRequest);
		}

		// Token: 0x06009A0E RID: 39438 RVA: 0x0017359D File Offset: 0x0017179D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaInfoRequest other)
		{
			return other != null && (other == this || (this.Language == other.Language && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009A0F RID: 39439 RVA: 0x001735CC File Offset: 0x001717CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Language != 0)
			{
				num ^= this.Language.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009A10 RID: 39440 RVA: 0x0017360B File Offset: 0x0017180B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009A11 RID: 39441 RVA: 0x00173618 File Offset: 0x00171818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009A12 RID: 39442 RVA: 0x00173621 File Offset: 0x00171821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Language != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Language);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009A13 RID: 39443 RVA: 0x00173654 File Offset: 0x00171854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Language != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Language);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009A14 RID: 39444 RVA: 0x00173692 File Offset: 0x00171892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Language != 0)
			{
				this.Language = other.Language;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009A15 RID: 39445 RVA: 0x001736C3 File Offset: 0x001718C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009A16 RID: 39446 RVA: 0x001736CC File Offset: 0x001718CC
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Language = input.ReadInt32();
				}
			}
		}

		// Token: 0x040048DE RID: 18654
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048DF RID: 18655
		public const int LanguageFieldNumber = 4;

		// Token: 0x040048E0 RID: 18656
		private int language_;
	}
}
