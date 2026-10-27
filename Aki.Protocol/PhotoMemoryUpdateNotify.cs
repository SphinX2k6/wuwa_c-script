using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D3A RID: 3386
	[NetMessage(EMessageId.PhotoMemoryUpdateNotify)]
	public sealed class PhotoMemoryUpdateNotify : IMessage<PhotoMemoryUpdateNotify>, IMessage, IEquatable<PhotoMemoryUpdateNotify>, IDeepCloneable<PhotoMemoryUpdateNotify>, IBufferMessage
	{
		// Token: 0x06012467 RID: 74855 RVA: 0x002AAE64 File Offset: 0x002A9064
		[NullableContext(1)]
		public static PhotoMemoryUpdateNotify Create()
		{
			return new PhotoMemoryUpdateNotify();
		}

		// Token: 0x17003C8E RID: 15502
		// (get) Token: 0x06012468 RID: 74856 RVA: 0x002AAE6B File Offset: 0x002A906B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C8F RID: 15503
		// (get) Token: 0x06012469 RID: 74857 RVA: 0x002AAE6E File Offset: 0x002A906E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoMemoryUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601246A RID: 74858 RVA: 0x002AAE75 File Offset: 0x002A9075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryUpdateNotify()
		{
		}

		// Token: 0x0601246B RID: 74859 RVA: 0x002AAE88 File Offset: 0x002A9088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryUpdateNotify(PhotoMemoryUpdateNotify other) : this()
		{
			this.topics_ = other.topics_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601246C RID: 74860 RVA: 0x002AAEB2 File Offset: 0x002A90B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryUpdateNotify Clone()
		{
			return new PhotoMemoryUpdateNotify(this);
		}

		// Token: 0x17003C90 RID: 15504
		// (get) Token: 0x0601246D RID: 74861 RVA: 0x002AAEBA File Offset: 0x002A90BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhotoMemoryTopicInfo> Topics
		{
			get
			{
				return this.topics_;
			}
		}

		// Token: 0x0601246E RID: 74862 RVA: 0x002AAEC2 File Offset: 0x002A90C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoMemoryUpdateNotify);
		}

		// Token: 0x0601246F RID: 74863 RVA: 0x002AAED0 File Offset: 0x002A90D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoMemoryUpdateNotify other)
		{
			return other != null && (other == this || (this.topics_.Equals(other.topics_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012470 RID: 74864 RVA: 0x002AAF04 File Offset: 0x002A9104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.topics_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012471 RID: 74865 RVA: 0x002AAF38 File Offset: 0x002A9138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012472 RID: 74866 RVA: 0x002AAF45 File Offset: 0x002A9145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012473 RID: 74867 RVA: 0x002AAF4E File Offset: 0x002A914E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.topics_.WriteTo(ref output, PhotoMemoryUpdateNotify._repeated_topics_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012474 RID: 74868 RVA: 0x002AAF78 File Offset: 0x002A9178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.topics_.CalculateSize(PhotoMemoryUpdateNotify._repeated_topics_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012475 RID: 74869 RVA: 0x002AAFB1 File Offset: 0x002A91B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotoMemoryUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.topics_.Add(other.topics_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012476 RID: 74870 RVA: 0x002AAFDF File Offset: 0x002A91DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012477 RID: 74871 RVA: 0x002AAFE8 File Offset: 0x002A91E8
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.topics_.AddEntriesFrom(ref input, PhotoMemoryUpdateNotify._repeated_topics_codec);
				}
			}
		}

		// Token: 0x040071FC RID: 29180
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071FD RID: 29181
		public const int TopicsFieldNumber = 9;

		// Token: 0x040071FE RID: 29182
		private static readonly FieldCodec<PhotoMemoryTopicInfo> _repeated_topics_codec = FieldCodec.ForMessage<PhotoMemoryTopicInfo>(74U, PhotoMemoryTopicInfo.Parser);

		// Token: 0x040071FF RID: 29183
		private readonly RepeatedField<PhotoMemoryTopicInfo> topics_ = new RepeatedField<PhotoMemoryTopicInfo>();
	}
}
