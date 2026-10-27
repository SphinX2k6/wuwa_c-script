using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001487 RID: 5255
	[NetMessage(EMessageId.UnlockHeadPhotoNotify)]
	public sealed class UnlockHeadPhotoNotify : IMessage<UnlockHeadPhotoNotify>, IMessage, IEquatable<UnlockHeadPhotoNotify>, IDeepCloneable<UnlockHeadPhotoNotify>, IBufferMessage
	{
		// Token: 0x0601BCEA RID: 113898 RVA: 0x004059F5 File Offset: 0x00403BF5
		[NullableContext(1)]
		public static UnlockHeadPhotoNotify Create()
		{
			return new UnlockHeadPhotoNotify();
		}

		// Token: 0x17005DBE RID: 23998
		// (get) Token: 0x0601BCEB RID: 113899 RVA: 0x004059FC File Offset: 0x00403BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DBF RID: 23999
		// (get) Token: 0x0601BCEC RID: 113900 RVA: 0x004059FF File Offset: 0x00403BFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockHeadPhotoNotify.Descriptor;
			}
		}

		// Token: 0x0601BCED RID: 113901 RVA: 0x00405A06 File Offset: 0x00403C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockHeadPhotoNotify()
		{
		}

		// Token: 0x0601BCEE RID: 113902 RVA: 0x00405A0E File Offset: 0x00403C0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockHeadPhotoNotify(UnlockHeadPhotoNotify other) : this()
		{
			this.headPhotoId_ = other.headPhotoId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BCEF RID: 113903 RVA: 0x00405A33 File Offset: 0x00403C33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockHeadPhotoNotify Clone()
		{
			return new UnlockHeadPhotoNotify(this);
		}

		// Token: 0x17005DC0 RID: 24000
		// (get) Token: 0x0601BCF0 RID: 113904 RVA: 0x00405A3B File Offset: 0x00403C3B
		// (set) Token: 0x0601BCF1 RID: 113905 RVA: 0x00405A43 File Offset: 0x00403C43
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

		// Token: 0x0601BCF2 RID: 113906 RVA: 0x00405A4C File Offset: 0x00403C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockHeadPhotoNotify);
		}

		// Token: 0x0601BCF3 RID: 113907 RVA: 0x00405A5A File Offset: 0x00403C5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockHeadPhotoNotify other)
		{
			return other != null && (other == this || (this.HeadPhotoId == other.HeadPhotoId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BCF4 RID: 113908 RVA: 0x00405A88 File Offset: 0x00403C88
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

		// Token: 0x0601BCF5 RID: 113909 RVA: 0x00405AC7 File Offset: 0x00403CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BCF6 RID: 113910 RVA: 0x00405AD4 File Offset: 0x00403CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BCF7 RID: 113911 RVA: 0x00405ADD File Offset: 0x00403CDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HeadPhotoId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.HeadPhotoId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BCF8 RID: 113912 RVA: 0x00405B10 File Offset: 0x00403D10
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

		// Token: 0x0601BCF9 RID: 113913 RVA: 0x00405B4E File Offset: 0x00403D4E
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

		// Token: 0x0601BCFA RID: 113914 RVA: 0x00405B7F File Offset: 0x00403D7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BCFB RID: 113915 RVA: 0x00405B88 File Offset: 0x00403D88
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.HeadPhotoId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009FFF RID: 40959
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A000 RID: 40960
		public const int HeadPhotoIdFieldNumber = 13;

		// Token: 0x0400A001 RID: 40961
		private int headPhotoId_;
	}
}
