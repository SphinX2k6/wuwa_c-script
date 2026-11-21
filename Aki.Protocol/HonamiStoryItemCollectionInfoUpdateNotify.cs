using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200076B RID: 1899
	[NetMessage(EMessageId.HonamiStoryItemCollectionInfoUpdateNotify)]
	public sealed class HonamiStoryItemCollectionInfoUpdateNotify : IMessage<HonamiStoryItemCollectionInfoUpdateNotify>, IMessage, IEquatable<HonamiStoryItemCollectionInfoUpdateNotify>, IDeepCloneable<HonamiStoryItemCollectionInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600AC16 RID: 44054 RVA: 0x0019E497 File Offset: 0x0019C697
		[NullableContext(1)]
		public static HonamiStoryItemCollectionInfoUpdateNotify Create()
		{
			return new HonamiStoryItemCollectionInfoUpdateNotify();
		}

		// Token: 0x170022B2 RID: 8882
		// (get) Token: 0x0600AC17 RID: 44055 RVA: 0x0019E49E File Offset: 0x0019C69E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022B3 RID: 8883
		// (get) Token: 0x0600AC18 RID: 44056 RVA: 0x0019E4A1 File Offset: 0x0019C6A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryItemCollectionInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600AC19 RID: 44057 RVA: 0x0019E4A8 File Offset: 0x0019C6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemCollectionInfoUpdateNotify()
		{
		}

		// Token: 0x0600AC1A RID: 44058 RVA: 0x0019E4BB File Offset: 0x0019C6BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemCollectionInfoUpdateNotify(HonamiStoryItemCollectionInfoUpdateNotify other) : this()
		{
			this.honamiStoryItemCollectionInfos_ = other.honamiStoryItemCollectionInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC1B RID: 44059 RVA: 0x0019E4E5 File Offset: 0x0019C6E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemCollectionInfoUpdateNotify Clone()
		{
			return new HonamiStoryItemCollectionInfoUpdateNotify(this);
		}

		// Token: 0x170022B4 RID: 8884
		// (get) Token: 0x0600AC1C RID: 44060 RVA: 0x0019E4ED File Offset: 0x0019C6ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryItemCollectionInfo> HonamiStoryItemCollectionInfos
		{
			get
			{
				return this.honamiStoryItemCollectionInfos_;
			}
		}

		// Token: 0x0600AC1D RID: 44061 RVA: 0x0019E4F5 File Offset: 0x0019C6F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryItemCollectionInfoUpdateNotify);
		}

		// Token: 0x0600AC1E RID: 44062 RVA: 0x0019E503 File Offset: 0x0019C703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryItemCollectionInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.honamiStoryItemCollectionInfos_.Equals(other.honamiStoryItemCollectionInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AC1F RID: 44063 RVA: 0x0019E538 File Offset: 0x0019C738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.honamiStoryItemCollectionInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AC20 RID: 44064 RVA: 0x0019E56C File Offset: 0x0019C76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AC21 RID: 44065 RVA: 0x0019E579 File Offset: 0x0019C779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC22 RID: 44066 RVA: 0x0019E582 File Offset: 0x0019C782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.honamiStoryItemCollectionInfos_.WriteTo(ref output, HonamiStoryItemCollectionInfoUpdateNotify._repeated_honamiStoryItemCollectionInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AC23 RID: 44067 RVA: 0x0019E5AC File Offset: 0x0019C7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.honamiStoryItemCollectionInfos_.CalculateSize(HonamiStoryItemCollectionInfoUpdateNotify._repeated_honamiStoryItemCollectionInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AC24 RID: 44068 RVA: 0x0019E5E5 File Offset: 0x0019C7E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryItemCollectionInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.honamiStoryItemCollectionInfos_.Add(other.honamiStoryItemCollectionInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AC25 RID: 44069 RVA: 0x0019E613 File Offset: 0x0019C813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC26 RID: 44070 RVA: 0x0019E61C File Offset: 0x0019C81C
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.honamiStoryItemCollectionInfos_.AddEntriesFrom(ref input, HonamiStoryItemCollectionInfoUpdateNotify._repeated_honamiStoryItemCollectionInfos_codec);
				}
			}
		}

		// Token: 0x04004E6B RID: 20075
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E6C RID: 20076
		public const int HonamiStoryItemCollectionInfosFieldNumber = 4;

		// Token: 0x04004E6D RID: 20077
		private static readonly FieldCodec<HonamiStoryItemCollectionInfo> _repeated_honamiStoryItemCollectionInfos_codec = FieldCodec.ForMessage<HonamiStoryItemCollectionInfo>(34U, HonamiStoryItemCollectionInfo.Parser);

		// Token: 0x04004E6E RID: 20078
		private readonly RepeatedField<HonamiStoryItemCollectionInfo> honamiStoryItemCollectionInfos_ = new RepeatedField<HonamiStoryItemCollectionInfo>();
	}
}
