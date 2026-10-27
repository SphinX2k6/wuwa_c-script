using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D39 RID: 3385
	public sealed class PhotoMemoryTopicInfo : IMessage<PhotoMemoryTopicInfo>, IMessage, IEquatable<PhotoMemoryTopicInfo>, IDeepCloneable<PhotoMemoryTopicInfo>, IBufferMessage
	{
		// Token: 0x06012450 RID: 74832 RVA: 0x002AAAF9 File Offset: 0x002A8CF9
		[NullableContext(1)]
		public static PhotoMemoryTopicInfo Create()
		{
			return new PhotoMemoryTopicInfo();
		}

		// Token: 0x17003C88 RID: 15496
		// (get) Token: 0x06012451 RID: 74833 RVA: 0x002AAB00 File Offset: 0x002A8D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhotoMemoryTopicInfo> Parser
		{
			get
			{
				return PhotoMemoryTopicInfo._parser;
			}
		}

		// Token: 0x17003C89 RID: 15497
		// (get) Token: 0x06012452 RID: 74834 RVA: 0x002AAB07 File Offset: 0x002A8D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C8A RID: 15498
		// (get) Token: 0x06012453 RID: 74835 RVA: 0x002AAB0A File Offset: 0x002A8D0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoMemoryTopicInfo.Descriptor;
			}
		}

		// Token: 0x06012454 RID: 74836 RVA: 0x002AAB11 File Offset: 0x002A8D11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryTopicInfo()
		{
		}

		// Token: 0x06012455 RID: 74837 RVA: 0x002AAB24 File Offset: 0x002A8D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryTopicInfo(PhotoMemoryTopicInfo other) : this()
		{
			this.id_ = other.id_;
			this.collectInfos_ = other.collectInfos_.Clone();
			this.isUnlock_ = other.isUnlock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012456 RID: 74838 RVA: 0x002AAB71 File Offset: 0x002A8D71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryTopicInfo Clone()
		{
			return new PhotoMemoryTopicInfo(this);
		}

		// Token: 0x17003C8B RID: 15499
		// (get) Token: 0x06012457 RID: 74839 RVA: 0x002AAB79 File Offset: 0x002A8D79
		// (set) Token: 0x06012458 RID: 74840 RVA: 0x002AAB81 File Offset: 0x002A8D81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
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

		// Token: 0x17003C8C RID: 15500
		// (get) Token: 0x06012459 RID: 74841 RVA: 0x002AAB8A File Offset: 0x002A8D8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhotoMemoryCollectInfo> CollectInfos
		{
			get
			{
				return this.collectInfos_;
			}
		}

		// Token: 0x17003C8D RID: 15501
		// (get) Token: 0x0601245A RID: 74842 RVA: 0x002AAB92 File Offset: 0x002A8D92
		// (set) Token: 0x0601245B RID: 74843 RVA: 0x002AAB9A File Offset: 0x002A8D9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlock
		{
			get
			{
				return this.isUnlock_;
			}
			set
			{
				this.isUnlock_ = value;
			}
		}

		// Token: 0x0601245C RID: 74844 RVA: 0x002AABA3 File Offset: 0x002A8DA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoMemoryTopicInfo);
		}

		// Token: 0x0601245D RID: 74845 RVA: 0x002AABB4 File Offset: 0x002A8DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoMemoryTopicInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.collectInfos_.Equals(other.collectInfos_) && this.IsUnlock == other.IsUnlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601245E RID: 74846 RVA: 0x002AAC14 File Offset: 0x002A8E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.collectInfos_.GetHashCode();
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601245F RID: 74847 RVA: 0x002AAC7A File Offset: 0x002A8E7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012460 RID: 74848 RVA: 0x002AAC87 File Offset: 0x002A8E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012461 RID: 74849 RVA: 0x002AAC90 File Offset: 0x002A8E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			this.collectInfos_.WriteTo(ref output, PhotoMemoryTopicInfo._repeated_collectInfos_codec);
			if (this.IsUnlock)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsUnlock);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012462 RID: 74850 RVA: 0x002AACFC File Offset: 0x002A8EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			num += this.collectInfos_.CalculateSize(PhotoMemoryTopicInfo._repeated_collectInfos_codec);
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012463 RID: 74851 RVA: 0x002AAD5C File Offset: 0x002A8F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotoMemoryTopicInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this.collectInfos_.Add(other.collectInfos_);
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012464 RID: 74852 RVA: 0x002AADBD File Offset: 0x002A8FBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012465 RID: 74853 RVA: 0x002AADC8 File Offset: 0x002A8FC8
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsUnlock = input.ReadBool();
						}
					}
					else
					{
						this.collectInfos_.AddEntriesFrom(ref input, PhotoMemoryTopicInfo._repeated_collectInfos_codec);
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040071F3 RID: 29171
		private static readonly MessageParser<PhotoMemoryTopicInfo> _parser = new MessageParser<PhotoMemoryTopicInfo>(() => new PhotoMemoryTopicInfo());

		// Token: 0x040071F4 RID: 29172
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071F5 RID: 29173
		public const int IdFieldNumber = 1;

		// Token: 0x040071F6 RID: 29174
		private int id_;

		// Token: 0x040071F7 RID: 29175
		public const int CollectInfosFieldNumber = 2;

		// Token: 0x040071F8 RID: 29176
		private static readonly FieldCodec<PhotoMemoryCollectInfo> _repeated_collectInfos_codec = FieldCodec.ForMessage<PhotoMemoryCollectInfo>(18U, PhotoMemoryCollectInfo.Parser);

		// Token: 0x040071F9 RID: 29177
		private readonly RepeatedField<PhotoMemoryCollectInfo> collectInfos_ = new RepeatedField<PhotoMemoryCollectInfo>();

		// Token: 0x040071FA RID: 29178
		public const int IsUnlockFieldNumber = 3;

		// Token: 0x040071FB RID: 29179
		private bool isUnlock_;
	}
}
