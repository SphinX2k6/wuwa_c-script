using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000C6 RID: 198
	[NetMessage(EMessageId.AdviceContentUpdateNotify)]
	public sealed class AdviceContentUpdateNotify : IMessage<AdviceContentUpdateNotify>, IMessage, IEquatable<AdviceContentUpdateNotify>, IDeepCloneable<AdviceContentUpdateNotify>, IBufferMessage
	{
		// Token: 0x06001F3F RID: 7999 RVA: 0x00055176 File Offset: 0x00053376
		[NullableContext(1)]
		public static AdviceContentUpdateNotify Create()
		{
			return new AdviceContentUpdateNotify();
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001F40 RID: 8000 RVA: 0x0005517D File Offset: 0x0005337D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001F41 RID: 8001 RVA: 0x00055180 File Offset: 0x00053380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceContentUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x00055187 File Offset: 0x00053387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceContentUpdateNotify()
		{
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x0005519A File Offset: 0x0005339A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceContentUpdateNotify(AdviceContentUpdateNotify other) : this()
		{
			this.id_ = other.id_;
			this.contents_ = other.contents_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x000551D0 File Offset: 0x000533D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceContentUpdateNotify Clone()
		{
			return new AdviceContentUpdateNotify(this);
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001F45 RID: 8005 RVA: 0x000551D8 File Offset: 0x000533D8
		// (set) Token: 0x06001F46 RID: 8006 RVA: 0x000551E0 File Offset: 0x000533E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001F47 RID: 8007 RVA: 0x000551E9 File Offset: 0x000533E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbAdviceContent> Contents
		{
			get
			{
				return this.contents_;
			}
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x000551F1 File Offset: 0x000533F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceContentUpdateNotify);
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x00055200 File Offset: 0x00053400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceContentUpdateNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.contents_.Equals(other.contents_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x00055250 File Offset: 0x00053450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.contents_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x0005529D File Offset: 0x0005349D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x000552AA File Offset: 0x000534AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x000552B4 File Offset: 0x000534B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.Id);
			}
			this.contents_.WriteTo(ref output, AdviceContentUpdateNotify._repeated_contents_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001F4E RID: 8014 RVA: 0x00055304 File Offset: 0x00053504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			num += this.contents_.CalculateSize(AdviceContentUpdateNotify._repeated_contents_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x00055358 File Offset: 0x00053558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceContentUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this.contents_.Add(other.contents_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001F50 RID: 8016 RVA: 0x000553A5 File Offset: 0x000535A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x000553B0 File Offset: 0x000535B0
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
					if (num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.contents_.AddEntriesFrom(ref input, AdviceContentUpdateNotify._repeated_contents_codec);
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x040023AD RID: 9133
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023AE RID: 9134
		public const int IdFieldNumber = 1;

		// Token: 0x040023AF RID: 9135
		private long id_;

		// Token: 0x040023B0 RID: 9136
		public const int ContentsFieldNumber = 6;

		// Token: 0x040023B1 RID: 9137
		private static readonly FieldCodec<PbAdviceContent> _repeated_contents_codec = FieldCodec.ForMessage<PbAdviceContent>(50U, PbAdviceContent.Parser);

		// Token: 0x040023B2 RID: 9138
		private readonly RepeatedField<PbAdviceContent> contents_ = new RepeatedField<PbAdviceContent>();
	}
}
