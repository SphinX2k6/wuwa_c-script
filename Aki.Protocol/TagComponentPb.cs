using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001388 RID: 5000
	public sealed class TagComponentPb : IMessage<TagComponentPb>, IMessage, IEquatable<TagComponentPb>, IDeepCloneable<TagComponentPb>, IBufferMessage
	{
		// Token: 0x0601A9F5 RID: 109045 RVA: 0x003E0F52 File Offset: 0x003DF152
		[NullableContext(1)]
		public static TagComponentPb Create()
		{
			return new TagComponentPb();
		}

		// Token: 0x17005A24 RID: 23076
		// (get) Token: 0x0601A9F6 RID: 109046 RVA: 0x003E0F59 File Offset: 0x003DF159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A25 RID: 23077
		// (get) Token: 0x0601A9F7 RID: 109047 RVA: 0x003E0F5C File Offset: 0x003DF15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TagComponentPb.Descriptor;
			}
		}

		// Token: 0x0601A9F8 RID: 109048 RVA: 0x003E0F63 File Offset: 0x003DF163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TagComponentPb()
		{
		}

		// Token: 0x0601A9F9 RID: 109049 RVA: 0x003E0F84 File Offset: 0x003DF184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TagComponentPb(TagComponentPb other) : this()
		{
			this.gameplayTags_ = other.gameplayTags_.Clone();
			this.entityCommonTags_ = other.entityCommonTags_.Clone();
			this.initGameplayTag_ = other.initGameplayTag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A9FA RID: 109050 RVA: 0x003E0FD6 File Offset: 0x003DF1D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TagComponentPb Clone()
		{
			return new TagComponentPb(this);
		}

		// Token: 0x17005A26 RID: 23078
		// (get) Token: 0x0601A9FB RID: 109051 RVA: 0x003E0FDE File Offset: 0x003DF1DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayTagData> GameplayTags
		{
			get
			{
				return this.gameplayTags_;
			}
		}

		// Token: 0x17005A27 RID: 23079
		// (get) Token: 0x0601A9FC RID: 109052 RVA: 0x003E0FE6 File Offset: 0x003DF1E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EntityCommonTags
		{
			get
			{
				return this.entityCommonTags_;
			}
		}

		// Token: 0x17005A28 RID: 23080
		// (get) Token: 0x0601A9FD RID: 109053 RVA: 0x003E0FEE File Offset: 0x003DF1EE
		// (set) Token: 0x0601A9FE RID: 109054 RVA: 0x003E0FF6 File Offset: 0x003DF1F6
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

		// Token: 0x0601A9FF RID: 109055 RVA: 0x003E0FFF File Offset: 0x003DF1FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TagComponentPb);
		}

		// Token: 0x0601AA00 RID: 109056 RVA: 0x003E1010 File Offset: 0x003DF210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TagComponentPb other)
		{
			return other != null && (other == this || (this.gameplayTags_.Equals(other.gameplayTags_) && this.entityCommonTags_.Equals(other.entityCommonTags_) && this.InitGameplayTag == other.InitGameplayTag && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AA01 RID: 109057 RVA: 0x003E1074 File Offset: 0x003DF274
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

		// Token: 0x0601AA02 RID: 109058 RVA: 0x003E10CF File Offset: 0x003DF2CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AA03 RID: 109059 RVA: 0x003E10DC File Offset: 0x003DF2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AA04 RID: 109060 RVA: 0x003E10E8 File Offset: 0x003DF2E8
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

		// Token: 0x0601AA05 RID: 109061 RVA: 0x003E1148 File Offset: 0x003DF348
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

		// Token: 0x0601AA06 RID: 109062 RVA: 0x003E11A0 File Offset: 0x003DF3A0
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

		// Token: 0x0601AA07 RID: 109063 RVA: 0x003E11FE File Offset: 0x003DF3FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AA08 RID: 109064 RVA: 0x003E1208 File Offset: 0x003DF408
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

		// Token: 0x04009C01 RID: 39937
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C02 RID: 39938
		public const int GameplayTagsFieldNumber = 1;

		// Token: 0x04009C03 RID: 39939
		private static readonly FieldCodec<GameplayTagData> _repeated_gameplayTags_codec = FieldCodec.ForMessage<GameplayTagData>(10U, GameplayTagData.Parser);

		// Token: 0x04009C04 RID: 39940
		private readonly RepeatedField<GameplayTagData> gameplayTags_ = new RepeatedField<GameplayTagData>();

		// Token: 0x04009C05 RID: 39941
		public const int EntityCommonTagsFieldNumber = 2;

		// Token: 0x04009C06 RID: 39942
		private static readonly FieldCodec<int> _repeated_entityCommonTags_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04009C07 RID: 39943
		private readonly RepeatedField<int> entityCommonTags_ = new RepeatedField<int>();

		// Token: 0x04009C08 RID: 39944
		public const int InitGameplayTagFieldNumber = 3;

		// Token: 0x04009C09 RID: 39945
		private bool initGameplayTag_;
	}
}
