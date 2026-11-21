using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D26 RID: 3366
	[NetMessage(EMessageId.PhotoMemoryResponse)]
	public sealed class PhotoMemoryResponse : IMessage<PhotoMemoryResponse>, IMessage, IEquatable<PhotoMemoryResponse>, IDeepCloneable<PhotoMemoryResponse>, IBufferMessage
	{
		// Token: 0x0601231E RID: 74526 RVA: 0x002A892E File Offset: 0x002A6B2E
		[NullableContext(1)]
		public static PhotoMemoryResponse Create()
		{
			return new PhotoMemoryResponse();
		}

		// Token: 0x17003C4A RID: 15434
		// (get) Token: 0x0601231F RID: 74527 RVA: 0x002A8935 File Offset: 0x002A6B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C4B RID: 15435
		// (get) Token: 0x06012320 RID: 74528 RVA: 0x002A8938 File Offset: 0x002A6B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoMemoryResponse.Descriptor;
			}
		}

		// Token: 0x06012321 RID: 74529 RVA: 0x002A893F File Offset: 0x002A6B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryResponse()
		{
		}

		// Token: 0x06012322 RID: 74530 RVA: 0x002A8952 File Offset: 0x002A6B52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryResponse(PhotoMemoryResponse other) : this()
		{
			this.topics_ = other.topics_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012323 RID: 74531 RVA: 0x002A897C File Offset: 0x002A6B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryResponse Clone()
		{
			return new PhotoMemoryResponse(this);
		}

		// Token: 0x17003C4C RID: 15436
		// (get) Token: 0x06012324 RID: 74532 RVA: 0x002A8984 File Offset: 0x002A6B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhotoMemoryTopicInfo> Topics
		{
			get
			{
				return this.topics_;
			}
		}

		// Token: 0x06012325 RID: 74533 RVA: 0x002A898C File Offset: 0x002A6B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoMemoryResponse);
		}

		// Token: 0x06012326 RID: 74534 RVA: 0x002A899A File Offset: 0x002A6B9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoMemoryResponse other)
		{
			return other != null && (other == this || (this.topics_.Equals(other.topics_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012327 RID: 74535 RVA: 0x002A89D0 File Offset: 0x002A6BD0
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

		// Token: 0x06012328 RID: 74536 RVA: 0x002A8A04 File Offset: 0x002A6C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012329 RID: 74537 RVA: 0x002A8A11 File Offset: 0x002A6C11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601232A RID: 74538 RVA: 0x002A8A1A File Offset: 0x002A6C1A
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

		// Token: 0x0601232B RID: 74539 RVA: 0x002A8A44 File Offset: 0x002A6C44
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

		// Token: 0x0601232C RID: 74540 RVA: 0x002A8A7D File Offset: 0x002A6C7D
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

		// Token: 0x0601232D RID: 74541 RVA: 0x002A8AAB File Offset: 0x002A6CAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601232E RID: 74542 RVA: 0x002A8AB4 File Offset: 0x002A6CB4
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.topics_.AddEntriesFrom(ref input, PhotoMemoryResponse._repeated_topics_codec);
				}
			}
		}

		// Token: 0x04007200 RID: 29184
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007201 RID: 29185
		public const int TopicsFieldNumber = 15;

		// Token: 0x04007202 RID: 29186
		private static readonly FieldCodec<PhotoMemoryTopicInfo> _repeated_topics_codec = FieldCodec.ForMessage<PhotoMemoryTopicInfo>(122U, PhotoMemoryTopicInfo.Parser);

		// Token: 0x04007203 RID: 29187
		private readonly RepeatedField<PhotoMemoryTopicInfo> topics_ = new RepeatedField<PhotoMemoryTopicInfo>();
	}
}
