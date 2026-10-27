using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000270 RID: 624
	[NetMessage(EMessageId.CharacterBattleStateChangeNotify)]
	public sealed class CharacterBattleStateChangeNotify : IMessage<CharacterBattleStateChangeNotify>, IMessage, IEquatable<CharacterBattleStateChangeNotify>, IDeepCloneable<CharacterBattleStateChangeNotify>, IBufferMessage
	{
		// Token: 0x060041C1 RID: 16833 RVA: 0x000A1828 File Offset: 0x0009FA28
		[NullableContext(1)]
		public static CharacterBattleStateChangeNotify Create()
		{
			return new CharacterBattleStateChangeNotify();
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x060041C2 RID: 16834 RVA: 0x000A182F File Offset: 0x0009FA2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x060041C3 RID: 16835 RVA: 0x000A1832 File Offset: 0x0009FA32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharacterBattleStateChangeNotify.Descriptor;
			}
		}

		// Token: 0x060041C4 RID: 16836 RVA: 0x000A1839 File Offset: 0x0009FA39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterBattleStateChangeNotify()
		{
		}

		// Token: 0x060041C5 RID: 16837 RVA: 0x000A184C File Offset: 0x0009FA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterBattleStateChangeNotify(CharacterBattleStateChangeNotify other) : this()
		{
			this.characterBattleStateInfo_ = other.characterBattleStateInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060041C6 RID: 16838 RVA: 0x000A1876 File Offset: 0x0009FA76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterBattleStateChangeNotify Clone()
		{
			return new CharacterBattleStateChangeNotify(this);
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x060041C7 RID: 16839 RVA: 0x000A187E File Offset: 0x0009FA7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CharacterBattleStateInfo> CharacterBattleStateInfo
		{
			get
			{
				return this.characterBattleStateInfo_;
			}
		}

		// Token: 0x060041C8 RID: 16840 RVA: 0x000A1886 File Offset: 0x0009FA86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharacterBattleStateChangeNotify);
		}

		// Token: 0x060041C9 RID: 16841 RVA: 0x000A1894 File Offset: 0x0009FA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CharacterBattleStateChangeNotify other)
		{
			return other != null && (other == this || (this.characterBattleStateInfo_.Equals(other.characterBattleStateInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060041CA RID: 16842 RVA: 0x000A18C8 File Offset: 0x0009FAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.characterBattleStateInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060041CB RID: 16843 RVA: 0x000A18FC File Offset: 0x0009FAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060041CC RID: 16844 RVA: 0x000A1909 File Offset: 0x0009FB09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060041CD RID: 16845 RVA: 0x000A1912 File Offset: 0x0009FB12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.characterBattleStateInfo_.WriteTo(ref output, CharacterBattleStateChangeNotify._repeated_characterBattleStateInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060041CE RID: 16846 RVA: 0x000A193C File Offset: 0x0009FB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.characterBattleStateInfo_.CalculateSize(CharacterBattleStateChangeNotify._repeated_characterBattleStateInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060041CF RID: 16847 RVA: 0x000A1975 File Offset: 0x0009FB75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CharacterBattleStateChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.characterBattleStateInfo_.Add(other.characterBattleStateInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060041D0 RID: 16848 RVA: 0x000A19A3 File Offset: 0x0009FBA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060041D1 RID: 16849 RVA: 0x000A19AC File Offset: 0x0009FBAC
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.characterBattleStateInfo_.AddEntriesFrom(ref input, CharacterBattleStateChangeNotify._repeated_characterBattleStateInfo_codec);
				}
			}
		}

		// Token: 0x04002DD3 RID: 11731
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DD4 RID: 11732
		public const int CharacterBattleStateInfoFieldNumber = 7;

		// Token: 0x04002DD5 RID: 11733
		private static readonly FieldCodec<CharacterBattleStateInfo> _repeated_characterBattleStateInfo_codec = FieldCodec.ForMessage<CharacterBattleStateInfo>(58U, Aki.Protocol.CharacterBattleStateInfo.Parser);

		// Token: 0x04002DD6 RID: 11734
		private readonly RepeatedField<CharacterBattleStateInfo> characterBattleStateInfo_ = new RepeatedField<CharacterBattleStateInfo>();
	}
}
