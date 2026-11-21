using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000C7 RID: 199
	[NetMessage(EMessageId.AdviceContentUpdateNotify)]
	public sealed class AdviceContentUpdateNotify : IMessage<AdviceContentUpdateNotify>, IMessage, IEquatable<AdviceContentUpdateNotify>, IDeepCloneable<AdviceContentUpdateNotify>, IBufferMessage
	{
		// Token: 0x06001F88 RID: 8072 RVA: 0x00055E2A File Offset: 0x0005402A
		[NullableContext(1)]
		public static AdviceContentUpdateNotify Create()
		{
			return new AdviceContentUpdateNotify();
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001F89 RID: 8073 RVA: 0x00055E31 File Offset: 0x00054031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001F8A RID: 8074 RVA: 0x00055E34 File Offset: 0x00054034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceContentUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x00055E3B File Offset: 0x0005403B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceContentUpdateNotify()
		{
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x00055E4E File Offset: 0x0005404E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceContentUpdateNotify(AdviceContentUpdateNotify other) : this()
		{
			this.id_ = other.id_;
			this.contents_ = other.contents_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x00055E84 File Offset: 0x00054084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceContentUpdateNotify Clone()
		{
			return new AdviceContentUpdateNotify(this);
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001F8E RID: 8078 RVA: 0x00055E8C File Offset: 0x0005408C
		// (set) Token: 0x06001F8F RID: 8079 RVA: 0x00055E94 File Offset: 0x00054094
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

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001F90 RID: 8080 RVA: 0x00055E9D File Offset: 0x0005409D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbAdviceContent> Contents
		{
			get
			{
				return this.contents_;
			}
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x00055EA5 File Offset: 0x000540A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceContentUpdateNotify);
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x00055EB4 File Offset: 0x000540B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceContentUpdateNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.contents_.Equals(other.contents_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x00055F04 File Offset: 0x00054104
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

		// Token: 0x06001F94 RID: 8084 RVA: 0x00055F51 File Offset: 0x00054151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x00055F5E File Offset: 0x0005415E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x00055F68 File Offset: 0x00054168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.contents_.WriteTo(ref output, AdviceContentUpdateNotify._repeated_contents_codec);
			if (this.Id != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x00055FB8 File Offset: 0x000541B8
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

		// Token: 0x06001F98 RID: 8088 RVA: 0x0005600C File Offset: 0x0005420C
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

		// Token: 0x06001F99 RID: 8089 RVA: 0x00056059 File Offset: 0x00054259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x00056064 File Offset: 0x00054264
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
				if (num != 50U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt64();
					}
				}
				else
				{
					this.contents_.AddEntriesFrom(ref input, AdviceContentUpdateNotify._repeated_contents_codec);
				}
			}
		}

		// Token: 0x04002410 RID: 9232
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002411 RID: 9233
		public const int IdFieldNumber = 11;

		// Token: 0x04002412 RID: 9234
		private long id_;

		// Token: 0x04002413 RID: 9235
		public const int ContentsFieldNumber = 6;

		// Token: 0x04002414 RID: 9236
		private static readonly FieldCodec<PbAdviceContent> _repeated_contents_codec = FieldCodec.ForMessage<PbAdviceContent>(50U, PbAdviceContent.Parser);

		// Token: 0x04002415 RID: 9237
		private readonly RepeatedField<PbAdviceContent> contents_ = new RepeatedField<PbAdviceContent>();
	}
}
