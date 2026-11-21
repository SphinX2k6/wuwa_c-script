using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D2A RID: 3370
	[NetMessage(EMessageId.PhotoMemoryUpdateNotify)]
	public sealed class PhotoMemoryUpdateNotify : IMessage<PhotoMemoryUpdateNotify>, IMessage, IEquatable<PhotoMemoryUpdateNotify>, IDeepCloneable<PhotoMemoryUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601236B RID: 74603 RVA: 0x002A923C File Offset: 0x002A743C
		[NullableContext(1)]
		public static PhotoMemoryUpdateNotify Create()
		{
			return new PhotoMemoryUpdateNotify();
		}

		// Token: 0x17003C59 RID: 15449
		// (get) Token: 0x0601236C RID: 74604 RVA: 0x002A9243 File Offset: 0x002A7443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C5A RID: 15450
		// (get) Token: 0x0601236D RID: 74605 RVA: 0x002A9246 File Offset: 0x002A7446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoMemoryUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601236E RID: 74606 RVA: 0x002A924D File Offset: 0x002A744D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryUpdateNotify()
		{
		}

		// Token: 0x0601236F RID: 74607 RVA: 0x002A9260 File Offset: 0x002A7460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryUpdateNotify(PhotoMemoryUpdateNotify other) : this()
		{
			this.topics_ = other.topics_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012370 RID: 74608 RVA: 0x002A928A File Offset: 0x002A748A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryUpdateNotify Clone()
		{
			return new PhotoMemoryUpdateNotify(this);
		}

		// Token: 0x17003C5B RID: 15451
		// (get) Token: 0x06012371 RID: 74609 RVA: 0x002A9292 File Offset: 0x002A7492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhotoMemoryTopicInfo> Topics
		{
			get
			{
				return this.topics_;
			}
		}

		// Token: 0x06012372 RID: 74610 RVA: 0x002A929A File Offset: 0x002A749A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoMemoryUpdateNotify);
		}

		// Token: 0x06012373 RID: 74611 RVA: 0x002A92A8 File Offset: 0x002A74A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoMemoryUpdateNotify other)
		{
			return other != null && (other == this || (this.topics_.Equals(other.topics_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012374 RID: 74612 RVA: 0x002A92DC File Offset: 0x002A74DC
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

		// Token: 0x06012375 RID: 74613 RVA: 0x002A9310 File Offset: 0x002A7510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012376 RID: 74614 RVA: 0x002A931D File Offset: 0x002A751D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012377 RID: 74615 RVA: 0x002A9326 File Offset: 0x002A7526
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

		// Token: 0x06012378 RID: 74616 RVA: 0x002A9350 File Offset: 0x002A7550
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

		// Token: 0x06012379 RID: 74617 RVA: 0x002A9389 File Offset: 0x002A7589
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

		// Token: 0x0601237A RID: 74618 RVA: 0x002A93B7 File Offset: 0x002A75B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601237B RID: 74619 RVA: 0x002A93C0 File Offset: 0x002A75C0
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.topics_.AddEntriesFrom(ref input, PhotoMemoryUpdateNotify._repeated_topics_codec);
				}
			}
		}

		// Token: 0x04007214 RID: 29204
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007215 RID: 29205
		public const int TopicsFieldNumber = 12;

		// Token: 0x04007216 RID: 29206
		private static readonly FieldCodec<PhotoMemoryTopicInfo> _repeated_topics_codec = FieldCodec.ForMessage<PhotoMemoryTopicInfo>(98U, PhotoMemoryTopicInfo.Parser);

		// Token: 0x04007217 RID: 29207
		private readonly RepeatedField<PhotoMemoryTopicInfo> topics_ = new RepeatedField<PhotoMemoryTopicInfo>();
	}
}
