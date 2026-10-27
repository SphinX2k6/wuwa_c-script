using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001486 RID: 5254
	[NetMessage(EMessageId.UnlockHeadFrameNotify)]
	public sealed class UnlockHeadFrameNotify : IMessage<UnlockHeadFrameNotify>, IMessage, IEquatable<UnlockHeadFrameNotify>, IDeepCloneable<UnlockHeadFrameNotify>, IBufferMessage
	{
		// Token: 0x0601BCD8 RID: 113880 RVA: 0x0040581C File Offset: 0x00403A1C
		[NullableContext(1)]
		public static UnlockHeadFrameNotify Create()
		{
			return new UnlockHeadFrameNotify();
		}

		// Token: 0x17005DBB RID: 23995
		// (get) Token: 0x0601BCD9 RID: 113881 RVA: 0x00405823 File Offset: 0x00403A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DBC RID: 23996
		// (get) Token: 0x0601BCDA RID: 113882 RVA: 0x00405826 File Offset: 0x00403A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockHeadFrameNotify.Descriptor;
			}
		}

		// Token: 0x0601BCDB RID: 113883 RVA: 0x0040582D File Offset: 0x00403A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockHeadFrameNotify()
		{
		}

		// Token: 0x0601BCDC RID: 113884 RVA: 0x00405835 File Offset: 0x00403A35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockHeadFrameNotify(UnlockHeadFrameNotify other) : this()
		{
			this.headFrameId_ = other.headFrameId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BCDD RID: 113885 RVA: 0x0040585A File Offset: 0x00403A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockHeadFrameNotify Clone()
		{
			return new UnlockHeadFrameNotify(this);
		}

		// Token: 0x17005DBD RID: 23997
		// (get) Token: 0x0601BCDE RID: 113886 RVA: 0x00405862 File Offset: 0x00403A62
		// (set) Token: 0x0601BCDF RID: 113887 RVA: 0x0040586A File Offset: 0x00403A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HeadFrameId
		{
			get
			{
				return this.headFrameId_;
			}
			set
			{
				this.headFrameId_ = value;
			}
		}

		// Token: 0x0601BCE0 RID: 113888 RVA: 0x00405873 File Offset: 0x00403A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockHeadFrameNotify);
		}

		// Token: 0x0601BCE1 RID: 113889 RVA: 0x00405881 File Offset: 0x00403A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockHeadFrameNotify other)
		{
			return other != null && (other == this || (this.HeadFrameId == other.HeadFrameId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BCE2 RID: 113890 RVA: 0x004058B0 File Offset: 0x00403AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HeadFrameId != 0)
			{
				num ^= this.HeadFrameId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BCE3 RID: 113891 RVA: 0x004058EF File Offset: 0x00403AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BCE4 RID: 113892 RVA: 0x004058FC File Offset: 0x00403AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BCE5 RID: 113893 RVA: 0x00405905 File Offset: 0x00403B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HeadFrameId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.HeadFrameId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BCE6 RID: 113894 RVA: 0x00405938 File Offset: 0x00403B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HeadFrameId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeadFrameId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BCE7 RID: 113895 RVA: 0x00405976 File Offset: 0x00403B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockHeadFrameNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HeadFrameId != 0)
			{
				this.HeadFrameId = other.HeadFrameId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BCE8 RID: 113896 RVA: 0x004059A7 File Offset: 0x00403BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BCE9 RID: 113897 RVA: 0x004059B0 File Offset: 0x00403BB0
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.HeadFrameId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009FFC RID: 40956
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FFD RID: 40957
		public const int HeadFrameIdFieldNumber = 7;

		// Token: 0x04009FFE RID: 40958
		private int headFrameId_;
	}
}
