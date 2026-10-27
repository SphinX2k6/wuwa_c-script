using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200131B RID: 4891
	public sealed class TagComponentPb : IMessage<TagComponentPb>, IMessage, IEquatable<TagComponentPb>, IDeepCloneable<TagComponentPb>, IBufferMessage
	{
		// Token: 0x06019FE5 RID: 106469 RVA: 0x003C6C96 File Offset: 0x003C4E96
		[NullableContext(1)]
		public static TagComponentPb Create()
		{
			return new TagComponentPb();
		}

		// Token: 0x170057AA RID: 22442
		// (get) Token: 0x06019FE6 RID: 106470 RVA: 0x003C6C9D File Offset: 0x003C4E9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057AB RID: 22443
		// (get) Token: 0x06019FE7 RID: 106471 RVA: 0x003C6CA0 File Offset: 0x003C4EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TagComponentPb.Descriptor;
			}
		}

		// Token: 0x06019FE8 RID: 106472 RVA: 0x003C6CA7 File Offset: 0x003C4EA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TagComponentPb()
		{
		}

		// Token: 0x06019FE9 RID: 106473 RVA: 0x003C6CC8 File Offset: 0x003C4EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TagComponentPb(TagComponentPb other) : this()
		{
			this.gameplayTags_ = other.gameplayTags_.Clone();
			this.entityCommonTags_ = other.entityCommonTags_.Clone();
			this.initGameplayTag_ = other.initGameplayTag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019FEA RID: 106474 RVA: 0x003C6D1A File Offset: 0x003C4F1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TagComponentPb Clone()
		{
			return new TagComponentPb(this);
		}

		// Token: 0x170057AC RID: 22444
		// (get) Token: 0x06019FEB RID: 106475 RVA: 0x003C6D22 File Offset: 0x003C4F22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayTagData> GameplayTags
		{
			get
			{
				return this.gameplayTags_;
			}
		}

		// Token: 0x170057AD RID: 22445
		// (get) Token: 0x06019FEC RID: 106476 RVA: 0x003C6D2A File Offset: 0x003C4F2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EntityCommonTags
		{
			get
			{
				return this.entityCommonTags_;
			}
		}

		// Token: 0x170057AE RID: 22446
		// (get) Token: 0x06019FED RID: 106477 RVA: 0x003C6D32 File Offset: 0x003C4F32
		// (set) Token: 0x06019FEE RID: 106478 RVA: 0x003C6D3A File Offset: 0x003C4F3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool InitGameplayTag
		{
			get
			{
				return this.initGameplayTag_;
			}
			set
			{
				this.initGameplayTag_ = value;
			}
		}

		// Token: 0x06019FEF RID: 106479 RVA: 0x003C6D43 File Offset: 0x003C4F43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TagComponentPb);
		}

		// Token: 0x06019FF0 RID: 106480 RVA: 0x003C6D54 File Offset: 0x003C4F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TagComponentPb other)
		{
			return other != null && (other == this || (this.gameplayTags_.Equals(other.gameplayTags_) && this.entityCommonTags_.Equals(other.entityCommonTags_) && this.InitGameplayTag == other.InitGameplayTag && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019FF1 RID: 106481 RVA: 0x003C6DB8 File Offset: 0x003C4FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gameplayTags_.GetHashCode();
			num ^= this.entityCommonTags_.GetHashCode();
			if (this.InitGameplayTag)
			{
				num ^= this.InitGameplayTag.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019FF2 RID: 106482 RVA: 0x003C6E13 File Offset: 0x003C5013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019FF3 RID: 106483 RVA: 0x003C6E20 File Offset: 0x003C5020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019FF4 RID: 106484 RVA: 0x003C6E2C File Offset: 0x003C502C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gameplayTags_.WriteTo(ref output, TagComponentPb._repeated_gameplayTags_codec);
			this.entityCommonTags_.WriteTo(ref output, TagComponentPb._repeated_entityCommonTags_codec);
			if (this.InitGameplayTag)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.InitGameplayTag);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019FF5 RID: 106485 RVA: 0x003C6E8C File Offset: 0x003C508C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gameplayTags_.CalculateSize(TagComponentPb._repeated_gameplayTags_codec);
			num += this.entityCommonTags_.CalculateSize(TagComponentPb._repeated_entityCommonTags_codec);
			if (this.InitGameplayTag)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019FF6 RID: 106486 RVA: 0x003C6EE4 File Offset: 0x003C50E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TagComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.gameplayTags_.Add(other.gameplayTags_);
			this.entityCommonTags_.Add(other.entityCommonTags_);
			if (other.InitGameplayTag)
			{
				this.InitGameplayTag = other.InitGameplayTag;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019FF7 RID: 106487 RVA: 0x003C6F42 File Offset: 0x003C5142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019FF8 RID: 106488 RVA: 0x003C6F4C File Offset: 0x003C514C
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
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.gameplayTags_.AddEntriesFrom(ref input, TagComponentPb._repeated_gameplayTags_codec);
						continue;
					}
					if (num == 16U)
					{
						goto IL_4B;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_4B;
					}
					if (num == 24U)
					{
						this.InitGameplayTag = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4B:
				this.entityCommonTags_.AddEntriesFrom(ref input, TagComponentPb._repeated_entityCommonTags_codec);
			}
		}

		// Token: 0x040097DF RID: 38879
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097E0 RID: 38880
		public const int GameplayTagsFieldNumber = 1;

		// Token: 0x040097E1 RID: 38881
		private static readonly FieldCodec<GameplayTagData> _repeated_gameplayTags_codec = FieldCodec.ForMessage<GameplayTagData>(10U, GameplayTagData.Parser);

		// Token: 0x040097E2 RID: 38882
		private readonly RepeatedField<GameplayTagData> gameplayTags_ = new RepeatedField<GameplayTagData>();

		// Token: 0x040097E3 RID: 38883
		public const int EntityCommonTagsFieldNumber = 2;

		// Token: 0x040097E4 RID: 38884
		private static readonly FieldCodec<int> _repeated_entityCommonTags_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040097E5 RID: 38885
		private readonly RepeatedField<int> entityCommonTags_ = new RepeatedField<int>();

		// Token: 0x040097E6 RID: 38886
		public const int InitGameplayTagFieldNumber = 3;

		// Token: 0x040097E7 RID: 38887
		private bool initGameplayTag_;
	}
}
