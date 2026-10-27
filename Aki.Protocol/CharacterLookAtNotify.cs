using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000276 RID: 630
	[NetMessage(EMessageId.CharacterLookAtNotify)]
	public sealed class CharacterLookAtNotify : IMessage<CharacterLookAtNotify>, IMessage, IEquatable<CharacterLookAtNotify>, IDeepCloneable<CharacterLookAtNotify>, IBufferMessage
	{
		// Token: 0x0600423D RID: 16957 RVA: 0x000A27C8 File Offset: 0x000A09C8
		[NullableContext(1)]
		public static CharacterLookAtNotify Create()
		{
			return new CharacterLookAtNotify();
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x0600423E RID: 16958 RVA: 0x000A27CF File Offset: 0x000A09CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x0600423F RID: 16959 RVA: 0x000A27D2 File Offset: 0x000A09D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharacterLookAtNotify.Descriptor;
			}
		}

		// Token: 0x06004240 RID: 16960 RVA: 0x000A27D9 File Offset: 0x000A09D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterLookAtNotify()
		{
		}

		// Token: 0x06004241 RID: 16961 RVA: 0x000A27EC File Offset: 0x000A09EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterLookAtNotify(CharacterLookAtNotify other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.characterLookAtInfos_ = other.characterLookAtInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004242 RID: 16962 RVA: 0x000A2839 File Offset: 0x000A0A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterLookAtNotify Clone()
		{
			return new CharacterLookAtNotify(this);
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06004243 RID: 16963 RVA: 0x000A2841 File Offset: 0x000A0A41
		// (set) Token: 0x06004244 RID: 16964 RVA: 0x000A2849 File Offset: 0x000A0A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeOwnerId
		{
			get
			{
				return this.treeOwnerId_;
			}
			set
			{
				this.treeOwnerId_ = value;
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06004245 RID: 16965 RVA: 0x000A2852 File Offset: 0x000A0A52
		// (set) Token: 0x06004246 RID: 16966 RVA: 0x000A285A File Offset: 0x000A0A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TreeIncId
		{
			get
			{
				return this.treeIncId_;
			}
			set
			{
				this.treeIncId_ = value;
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06004247 RID: 16967 RVA: 0x000A2863 File Offset: 0x000A0A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CharacterLookAtInfo> CharacterLookAtInfos
		{
			get
			{
				return this.characterLookAtInfos_;
			}
		}

		// Token: 0x06004248 RID: 16968 RVA: 0x000A286B File Offset: 0x000A0A6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharacterLookAtNotify);
		}

		// Token: 0x06004249 RID: 16969 RVA: 0x000A287C File Offset: 0x000A0A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CharacterLookAtNotify other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.characterLookAtInfos_.Equals(other.characterLookAtInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600424A RID: 16970 RVA: 0x000A28DC File Offset: 0x000A0ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeOwnerId != 0)
			{
				num ^= this.TreeOwnerId.GetHashCode();
			}
			if (this.TreeIncId != 0L)
			{
				num ^= this.TreeIncId.GetHashCode();
			}
			num ^= this.characterLookAtInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600424B RID: 16971 RVA: 0x000A2942 File Offset: 0x000A0B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600424C RID: 16972 RVA: 0x000A294F File Offset: 0x000A0B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600424D RID: 16973 RVA: 0x000A2958 File Offset: 0x000A0B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.characterLookAtInfos_.WriteTo(ref output, CharacterLookAtNotify._repeated_characterLookAtInfos_codec);
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600424E RID: 16974 RVA: 0x000A29C4 File Offset: 0x000A0BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeOwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TreeIncId);
			}
			num += this.characterLookAtInfos_.CalculateSize(CharacterLookAtNotify._repeated_characterLookAtInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600424F RID: 16975 RVA: 0x000A2A30 File Offset: 0x000A0C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CharacterLookAtNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeOwnerId != 0)
			{
				this.TreeOwnerId = other.TreeOwnerId;
			}
			if (other.TreeIncId != 0L)
			{
				this.TreeIncId = other.TreeIncId;
			}
			this.characterLookAtInfos_.Add(other.characterLookAtInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004250 RID: 16976 RVA: 0x000A2A91 File Offset: 0x000A0C91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004251 RID: 16977 RVA: 0x000A2A9C File Offset: 0x000A0C9C
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
				if (num != 10U)
				{
					if (num != 80U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TreeOwnerId = input.ReadInt32();
						}
					}
					else
					{
						this.TreeIncId = input.ReadInt64();
					}
				}
				else
				{
					this.characterLookAtInfos_.AddEntriesFrom(ref input, CharacterLookAtNotify._repeated_characterLookAtInfos_codec);
				}
			}
		}

		// Token: 0x04002DF4 RID: 11764
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DF5 RID: 11765
		public const int TreeOwnerIdFieldNumber = 11;

		// Token: 0x04002DF6 RID: 11766
		private int treeOwnerId_;

		// Token: 0x04002DF7 RID: 11767
		public const int TreeIncIdFieldNumber = 10;

		// Token: 0x04002DF8 RID: 11768
		private long treeIncId_;

		// Token: 0x04002DF9 RID: 11769
		public const int CharacterLookAtInfosFieldNumber = 1;

		// Token: 0x04002DFA RID: 11770
		private static readonly FieldCodec<CharacterLookAtInfo> _repeated_characterLookAtInfos_codec = FieldCodec.ForMessage<CharacterLookAtInfo>(10U, CharacterLookAtInfo.Parser);

		// Token: 0x04002DFB RID: 11771
		private readonly RepeatedField<CharacterLookAtInfo> characterLookAtInfos_ = new RepeatedField<CharacterLookAtInfo>();
	}
}
