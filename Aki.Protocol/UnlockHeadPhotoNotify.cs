using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014FA RID: 5370
	[NetMessage(EMessageId.UnlockHeadPhotoNotify)]
	public sealed class UnlockHeadPhotoNotify : IMessage<UnlockHeadPhotoNotify>, IMessage, IEquatable<UnlockHeadPhotoNotify>, IDeepCloneable<UnlockHeadPhotoNotify>, IBufferMessage
	{
		// Token: 0x0601C775 RID: 116597 RVA: 0x00420CB9 File Offset: 0x0041EEB9
		[NullableContext(1)]
		public static UnlockHeadPhotoNotify Create()
		{
			return new UnlockHeadPhotoNotify();
		}

		// Token: 0x17006053 RID: 24659
		// (get) Token: 0x0601C776 RID: 116598 RVA: 0x00420CC0 File Offset: 0x0041EEC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006054 RID: 24660
		// (get) Token: 0x0601C777 RID: 116599 RVA: 0x00420CC3 File Offset: 0x0041EEC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockHeadPhotoNotify.Descriptor;
			}
		}

		// Token: 0x0601C778 RID: 116600 RVA: 0x00420CCA File Offset: 0x0041EECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockHeadPhotoNotify()
		{
		}

		// Token: 0x0601C779 RID: 116601 RVA: 0x00420CD2 File Offset: 0x0041EED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockHeadPhotoNotify(UnlockHeadPhotoNotify other) : this()
		{
			this.headPhotoId_ = other.headPhotoId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C77A RID: 116602 RVA: 0x00420CF7 File Offset: 0x0041EEF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockHeadPhotoNotify Clone()
		{
			return new UnlockHeadPhotoNotify(this);
		}

		// Token: 0x17006055 RID: 24661
		// (get) Token: 0x0601C77B RID: 116603 RVA: 0x00420CFF File Offset: 0x0041EEFF
		// (set) Token: 0x0601C77C RID: 116604 RVA: 0x00420D07 File Offset: 0x0041EF07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HeadPhotoId
		{
			get
			{
				return this.headPhotoId_;
			}
			set
			{
				this.headPhotoId_ = value;
			}
		}

		// Token: 0x0601C77D RID: 116605 RVA: 0x00420D10 File Offset: 0x0041EF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockHeadPhotoNotify);
		}

		// Token: 0x0601C77E RID: 116606 RVA: 0x00420D1E File Offset: 0x0041EF1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockHeadPhotoNotify other)
		{
			return other != null && (other == this || (this.HeadPhotoId == other.HeadPhotoId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C77F RID: 116607 RVA: 0x00420D4C File Offset: 0x0041EF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HeadPhotoId != 0)
			{
				num ^= this.HeadPhotoId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C780 RID: 116608 RVA: 0x00420D8B File Offset: 0x0041EF8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C781 RID: 116609 RVA: 0x00420D98 File Offset: 0x0041EF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C782 RID: 116610 RVA: 0x00420DA1 File Offset: 0x0041EFA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HeadPhotoId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.HeadPhotoId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C783 RID: 116611 RVA: 0x00420DD4 File Offset: 0x0041EFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HeadPhotoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeadPhotoId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C784 RID: 116612 RVA: 0x00420E12 File Offset: 0x0041F012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockHeadPhotoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HeadPhotoId != 0)
			{
				this.HeadPhotoId = other.HeadPhotoId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C785 RID: 116613 RVA: 0x00420E43 File Offset: 0x0041F043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C786 RID: 116614 RVA: 0x00420E4C File Offset: 0x0041F04C
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.HeadPhotoId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A446 RID: 42054
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A447 RID: 42055
		public const int HeadPhotoIdFieldNumber = 14;

		// Token: 0x0400A448 RID: 42056
		private int headPhotoId_;
	}
}
