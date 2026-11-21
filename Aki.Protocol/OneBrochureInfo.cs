using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B72 RID: 2930
	public sealed class OneBrochureInfo : IMessage<OneBrochureInfo>, IMessage, IEquatable<OneBrochureInfo>, IDeepCloneable<OneBrochureInfo>, IBufferMessage
	{
		// Token: 0x0600FE4C RID: 65100 RVA: 0x00251C3C File Offset: 0x0024FE3C
		[NullableContext(1)]
		public static OneBrochureInfo Create()
		{
			return new OneBrochureInfo();
		}

		// Token: 0x170033E8 RID: 13288
		// (get) Token: 0x0600FE4D RID: 65101 RVA: 0x00251C43 File Offset: 0x0024FE43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneBrochureInfo> Parser
		{
			get
			{
				return OneBrochureInfo._parser;
			}
		}

		// Token: 0x170033E9 RID: 13289
		// (get) Token: 0x0600FE4E RID: 65102 RVA: 0x00251C4A File Offset: 0x0024FE4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033EA RID: 13290
		// (get) Token: 0x0600FE4F RID: 65103 RVA: 0x00251C4D File Offset: 0x0024FE4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneBrochureInfo.Descriptor;
			}
		}

		// Token: 0x0600FE50 RID: 65104 RVA: 0x00251C54 File Offset: 0x0024FE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneBrochureInfo()
		{
		}

		// Token: 0x0600FE51 RID: 65105 RVA: 0x00251C67 File Offset: 0x0024FE67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneBrochureInfo(OneBrochureInfo other) : this()
		{
			this.brochureId_ = other.brochureId_;
			this.bookItemInfos_ = other.bookItemInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FE52 RID: 65106 RVA: 0x00251C9D File Offset: 0x0024FE9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneBrochureInfo Clone()
		{
			return new OneBrochureInfo(this);
		}

		// Token: 0x170033EB RID: 13291
		// (get) Token: 0x0600FE53 RID: 65107 RVA: 0x00251CA5 File Offset: 0x0024FEA5
		// (set) Token: 0x0600FE54 RID: 65108 RVA: 0x00251CAD File Offset: 0x0024FEAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BrochureId
		{
			get
			{
				return this.brochureId_;
			}
			set
			{
				this.brochureId_ = value;
			}
		}

		// Token: 0x170033EC RID: 13292
		// (get) Token: 0x0600FE55 RID: 65109 RVA: 0x00251CB6 File Offset: 0x0024FEB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BookItemInfo> BookItemInfos
		{
			get
			{
				return this.bookItemInfos_;
			}
		}

		// Token: 0x0600FE56 RID: 65110 RVA: 0x00251CBE File Offset: 0x0024FEBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneBrochureInfo);
		}

		// Token: 0x0600FE57 RID: 65111 RVA: 0x00251CCC File Offset: 0x0024FECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneBrochureInfo other)
		{
			return other != null && (other == this || (this.BrochureId == other.BrochureId && this.bookItemInfos_.Equals(other.bookItemInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FE58 RID: 65112 RVA: 0x00251D1C File Offset: 0x0024FF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BrochureId != 0)
			{
				num ^= this.BrochureId.GetHashCode();
			}
			num ^= this.bookItemInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FE59 RID: 65113 RVA: 0x00251D69 File Offset: 0x0024FF69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FE5A RID: 65114 RVA: 0x00251D76 File Offset: 0x0024FF76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FE5B RID: 65115 RVA: 0x00251D80 File Offset: 0x0024FF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BrochureId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BrochureId);
			}
			this.bookItemInfos_.WriteTo(ref output, OneBrochureInfo._repeated_bookItemInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FE5C RID: 65116 RVA: 0x00251DD0 File Offset: 0x0024FFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BrochureId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BrochureId);
			}
			num += this.bookItemInfos_.CalculateSize(OneBrochureInfo._repeated_bookItemInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FE5D RID: 65117 RVA: 0x00251E24 File Offset: 0x00250024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OneBrochureInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BrochureId != 0)
			{
				this.BrochureId = other.BrochureId;
			}
			this.bookItemInfos_.Add(other.bookItemInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FE5E RID: 65118 RVA: 0x00251E71 File Offset: 0x00250071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FE5F RID: 65119 RVA: 0x00251E7C File Offset: 0x0025007C
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.bookItemInfos_.AddEntriesFrom(ref input, OneBrochureInfo._repeated_bookItemInfos_codec);
					}
				}
				else
				{
					this.BrochureId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040065BE RID: 26046
		private static readonly MessageParser<OneBrochureInfo> _parser = new MessageParser<OneBrochureInfo>(() => new OneBrochureInfo());

		// Token: 0x040065BF RID: 26047
		private UnknownFieldSet _unknownFields;

		// Token: 0x040065C0 RID: 26048
		public const int BrochureIdFieldNumber = 1;

		// Token: 0x040065C1 RID: 26049
		private int brochureId_;

		// Token: 0x040065C2 RID: 26050
		public const int BookItemInfosFieldNumber = 2;

		// Token: 0x040065C3 RID: 26051
		private static readonly FieldCodec<BookItemInfo> _repeated_bookItemInfos_codec = FieldCodec.ForMessage<BookItemInfo>(18U, BookItemInfo.Parser);

		// Token: 0x040065C4 RID: 26052
		private readonly RepeatedField<BookItemInfo> bookItemInfos_ = new RepeatedField<BookItemInfo>();
	}
}
