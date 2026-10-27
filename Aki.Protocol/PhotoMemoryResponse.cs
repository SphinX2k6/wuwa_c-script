using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D36 RID: 3382
	[NetMessage(EMessageId.PhotoMemoryResponse)]
	public sealed class PhotoMemoryResponse : IMessage<PhotoMemoryResponse>, IMessage, IEquatable<PhotoMemoryResponse>, IDeepCloneable<PhotoMemoryResponse>, IBufferMessage
	{
		// Token: 0x0601241A RID: 74778 RVA: 0x002AA556 File Offset: 0x002A8756
		[NullableContext(1)]
		public static PhotoMemoryResponse Create()
		{
			return new PhotoMemoryResponse();
		}

		// Token: 0x17003C7F RID: 15487
		// (get) Token: 0x0601241B RID: 74779 RVA: 0x002AA55D File Offset: 0x002A875D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C80 RID: 15488
		// (get) Token: 0x0601241C RID: 74780 RVA: 0x002AA560 File Offset: 0x002A8760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoMemoryResponse.Descriptor;
			}
		}

		// Token: 0x0601241D RID: 74781 RVA: 0x002AA567 File Offset: 0x002A8767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryResponse()
		{
		}

		// Token: 0x0601241E RID: 74782 RVA: 0x002AA57A File Offset: 0x002A877A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryResponse(PhotoMemoryResponse other) : this()
		{
			this.topics_ = other.topics_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601241F RID: 74783 RVA: 0x002AA5A4 File Offset: 0x002A87A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryResponse Clone()
		{
			return new PhotoMemoryResponse(this);
		}

		// Token: 0x17003C81 RID: 15489
		// (get) Token: 0x06012420 RID: 74784 RVA: 0x002AA5AC File Offset: 0x002A87AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhotoMemoryTopicInfo> Topics
		{
			get
			{
				return this.topics_;
			}
		}

		// Token: 0x06012421 RID: 74785 RVA: 0x002AA5B4 File Offset: 0x002A87B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoMemoryResponse);
		}

		// Token: 0x06012422 RID: 74786 RVA: 0x002AA5C2 File Offset: 0x002A87C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoMemoryResponse other)
		{
			return other != null && (other == this || (this.topics_.Equals(other.topics_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012423 RID: 74787 RVA: 0x002AA5F8 File Offset: 0x002A87F8
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

		// Token: 0x06012424 RID: 74788 RVA: 0x002AA62C File Offset: 0x002A882C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012425 RID: 74789 RVA: 0x002AA639 File Offset: 0x002A8839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012426 RID: 74790 RVA: 0x002AA642 File Offset: 0x002A8842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.topics_.WriteTo(ref output, PhotoMemoryResponse._repeated_topics_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012427 RID: 74791 RVA: 0x002AA66C File Offset: 0x002A886C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.topics_.CalculateSize(PhotoMemoryResponse._repeated_topics_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012428 RID: 74792 RVA: 0x002AA6A5 File Offset: 0x002A88A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotoMemoryResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.topics_.Add(other.topics_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012429 RID: 74793 RVA: 0x002AA6D3 File Offset: 0x002A88D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601242A RID: 74794 RVA: 0x002AA6DC File Offset: 0x002A88DC
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.topics_.AddEntriesFrom(ref input, PhotoMemoryResponse._repeated_topics_codec);
				}
			}
		}

		// Token: 0x040071E8 RID: 29160
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071E9 RID: 29161
		public const int TopicsFieldNumber = 14;

		// Token: 0x040071EA RID: 29162
		private static readonly FieldCodec<PhotoMemoryTopicInfo> _repeated_topics_codec = FieldCodec.ForMessage<PhotoMemoryTopicInfo>(114U, PhotoMemoryTopicInfo.Parser);

		// Token: 0x040071EB RID: 29163
		private readonly RepeatedField<PhotoMemoryTopicInfo> topics_ = new RepeatedField<PhotoMemoryTopicInfo>();
	}
}
