using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D29 RID: 3369
	public sealed class PhotoMemoryTopicInfo : IMessage<PhotoMemoryTopicInfo>, IMessage, IEquatable<PhotoMemoryTopicInfo>, IDeepCloneable<PhotoMemoryTopicInfo>, IBufferMessage
	{
		// Token: 0x06012354 RID: 74580 RVA: 0x002A8ED1 File Offset: 0x002A70D1
		[NullableContext(1)]
		public static PhotoMemoryTopicInfo Create()
		{
			return new PhotoMemoryTopicInfo();
		}

		// Token: 0x17003C53 RID: 15443
		// (get) Token: 0x06012355 RID: 74581 RVA: 0x002A8ED8 File Offset: 0x002A70D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhotoMemoryTopicInfo> Parser
		{
			get
			{
				return PhotoMemoryTopicInfo._parser;
			}
		}

		// Token: 0x17003C54 RID: 15444
		// (get) Token: 0x06012356 RID: 74582 RVA: 0x002A8EDF File Offset: 0x002A70DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C55 RID: 15445
		// (get) Token: 0x06012357 RID: 74583 RVA: 0x002A8EE2 File Offset: 0x002A70E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoMemoryTopicInfo.Descriptor;
			}
		}

		// Token: 0x06012358 RID: 74584 RVA: 0x002A8EE9 File Offset: 0x002A70E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryTopicInfo()
		{
		}

		// Token: 0x06012359 RID: 74585 RVA: 0x002A8EFC File Offset: 0x002A70FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryTopicInfo(PhotoMemoryTopicInfo other) : this()
		{
			this.id_ = other.id_;
			this.collectInfos_ = other.collectInfos_.Clone();
			this.isUnlock_ = other.isUnlock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601235A RID: 74586 RVA: 0x002A8F49 File Offset: 0x002A7149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryTopicInfo Clone()
		{
			return new PhotoMemoryTopicInfo(this);
		}

		// Token: 0x17003C56 RID: 15446
		// (get) Token: 0x0601235B RID: 74587 RVA: 0x002A8F51 File Offset: 0x002A7151
		// (set) Token: 0x0601235C RID: 74588 RVA: 0x002A8F59 File Offset: 0x002A7159
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

		// Token: 0x17003C57 RID: 15447
		// (get) Token: 0x0601235D RID: 74589 RVA: 0x002A8F62 File Offset: 0x002A7162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhotoMemoryCollectInfo> CollectInfos
		{
			get
			{
				return this.collectInfos_;
			}
		}

		// Token: 0x17003C58 RID: 15448
		// (get) Token: 0x0601235E RID: 74590 RVA: 0x002A8F6A File Offset: 0x002A716A
		// (set) Token: 0x0601235F RID: 74591 RVA: 0x002A8F72 File Offset: 0x002A7172
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

		// Token: 0x06012360 RID: 74592 RVA: 0x002A8F7B File Offset: 0x002A717B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoMemoryTopicInfo);
		}

		// Token: 0x06012361 RID: 74593 RVA: 0x002A8F8C File Offset: 0x002A718C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoMemoryTopicInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.collectInfos_.Equals(other.collectInfos_) && this.IsUnlock == other.IsUnlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012362 RID: 74594 RVA: 0x002A8FEC File Offset: 0x002A71EC
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

		// Token: 0x06012363 RID: 74595 RVA: 0x002A9052 File Offset: 0x002A7252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012364 RID: 74596 RVA: 0x002A905F File Offset: 0x002A725F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012365 RID: 74597 RVA: 0x002A9068 File Offset: 0x002A7268
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

		// Token: 0x06012366 RID: 74598 RVA: 0x002A90D4 File Offset: 0x002A72D4
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

		// Token: 0x06012367 RID: 74599 RVA: 0x002A9134 File Offset: 0x002A7334
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

		// Token: 0x06012368 RID: 74600 RVA: 0x002A9195 File Offset: 0x002A7395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012369 RID: 74601 RVA: 0x002A91A0 File Offset: 0x002A73A0
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

		// Token: 0x0400720B RID: 29195
		private static readonly MessageParser<PhotoMemoryTopicInfo> _parser = new MessageParser<PhotoMemoryTopicInfo>(() => new PhotoMemoryTopicInfo());

		// Token: 0x0400720C RID: 29196
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400720D RID: 29197
		public const int IdFieldNumber = 1;

		// Token: 0x0400720E RID: 29198
		private int id_;

		// Token: 0x0400720F RID: 29199
		public const int CollectInfosFieldNumber = 2;

		// Token: 0x04007210 RID: 29200
		private static readonly FieldCodec<PhotoMemoryCollectInfo> _repeated_collectInfos_codec = FieldCodec.ForMessage<PhotoMemoryCollectInfo>(18U, PhotoMemoryCollectInfo.Parser);

		// Token: 0x04007211 RID: 29201
		private readonly RepeatedField<PhotoMemoryCollectInfo> collectInfos_ = new RepeatedField<PhotoMemoryCollectInfo>();

		// Token: 0x04007212 RID: 29202
		public const int IsUnlockFieldNumber = 3;

		// Token: 0x04007213 RID: 29203
		private bool isUnlock_;
	}
}
