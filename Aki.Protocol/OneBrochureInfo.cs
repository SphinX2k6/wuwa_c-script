using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B82 RID: 2946
	public sealed class OneBrochureInfo : IMessage<OneBrochureInfo>, IMessage, IEquatable<OneBrochureInfo>, IDeepCloneable<OneBrochureInfo>, IBufferMessage
	{
		// Token: 0x0600FF50 RID: 65360 RVA: 0x00253B0C File Offset: 0x00251D0C
		[NullableContext(1)]
		public static OneBrochureInfo Create()
		{
			return new OneBrochureInfo();
		}

		// Token: 0x17003421 RID: 13345
		// (get) Token: 0x0600FF51 RID: 65361 RVA: 0x00253B13 File Offset: 0x00251D13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneBrochureInfo> Parser
		{
			get
			{
				return OneBrochureInfo._parser;
			}
		}

		// Token: 0x17003422 RID: 13346
		// (get) Token: 0x0600FF52 RID: 65362 RVA: 0x00253B1A File Offset: 0x00251D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003423 RID: 13347
		// (get) Token: 0x0600FF53 RID: 65363 RVA: 0x00253B1D File Offset: 0x00251D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneBrochureInfo.Descriptor;
			}
		}

		// Token: 0x0600FF54 RID: 65364 RVA: 0x00253B24 File Offset: 0x00251D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneBrochureInfo()
		{
		}

		// Token: 0x0600FF55 RID: 65365 RVA: 0x00253B37 File Offset: 0x00251D37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneBrochureInfo(OneBrochureInfo other) : this()
		{
			this.brochureId_ = other.brochureId_;
			this.bookItemInfos_ = other.bookItemInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FF56 RID: 65366 RVA: 0x00253B6D File Offset: 0x00251D6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneBrochureInfo Clone()
		{
			return new OneBrochureInfo(this);
		}

		// Token: 0x17003424 RID: 13348
		// (get) Token: 0x0600FF57 RID: 65367 RVA: 0x00253B75 File Offset: 0x00251D75
		// (set) Token: 0x0600FF58 RID: 65368 RVA: 0x00253B7D File Offset: 0x00251D7D
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

		// Token: 0x17003425 RID: 13349
		// (get) Token: 0x0600FF59 RID: 65369 RVA: 0x00253B86 File Offset: 0x00251D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BookItemInfo> BookItemInfos
		{
			get
			{
				return this.bookItemInfos_;
			}
		}

		// Token: 0x0600FF5A RID: 65370 RVA: 0x00253B8E File Offset: 0x00251D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneBrochureInfo);
		}

		// Token: 0x0600FF5B RID: 65371 RVA: 0x00253B9C File Offset: 0x00251D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneBrochureInfo other)
		{
			return other != null && (other == this || (this.BrochureId == other.BrochureId && this.bookItemInfos_.Equals(other.bookItemInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FF5C RID: 65372 RVA: 0x00253BEC File Offset: 0x00251DEC
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

		// Token: 0x0600FF5D RID: 65373 RVA: 0x00253C39 File Offset: 0x00251E39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FF5E RID: 65374 RVA: 0x00253C46 File Offset: 0x00251E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FF5F RID: 65375 RVA: 0x00253C50 File Offset: 0x00251E50
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

		// Token: 0x0600FF60 RID: 65376 RVA: 0x00253CA0 File Offset: 0x00251EA0
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

		// Token: 0x0600FF61 RID: 65377 RVA: 0x00253CF4 File Offset: 0x00251EF4
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

		// Token: 0x0600FF62 RID: 65378 RVA: 0x00253D41 File Offset: 0x00251F41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FF63 RID: 65379 RVA: 0x00253D4C File Offset: 0x00251F4C
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

		// Token: 0x040065AE RID: 26030
		private static readonly MessageParser<OneBrochureInfo> _parser = new MessageParser<OneBrochureInfo>(() => new OneBrochureInfo());

		// Token: 0x040065AF RID: 26031
		private UnknownFieldSet _unknownFields;

		// Token: 0x040065B0 RID: 26032
		public const int BrochureIdFieldNumber = 1;

		// Token: 0x040065B1 RID: 26033
		private int brochureId_;

		// Token: 0x040065B2 RID: 26034
		public const int BookItemInfosFieldNumber = 2;

		// Token: 0x040065B3 RID: 26035
		private static readonly FieldCodec<BookItemInfo> _repeated_bookItemInfos_codec = FieldCodec.ForMessage<BookItemInfo>(18U, BookItemInfo.Parser);

		// Token: 0x040065B4 RID: 26036
		private readonly RepeatedField<BookItemInfo> bookItemInfos_ = new RepeatedField<BookItemInfo>();
	}
}
