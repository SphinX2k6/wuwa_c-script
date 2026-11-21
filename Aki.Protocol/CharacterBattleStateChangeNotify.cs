using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000275 RID: 629
	[NetMessage(EMessageId.CharacterBattleStateChangeNotify)]
	public sealed class CharacterBattleStateChangeNotify : IMessage<CharacterBattleStateChangeNotify>, IMessage, IEquatable<CharacterBattleStateChangeNotify>, IDeepCloneable<CharacterBattleStateChangeNotify>, IBufferMessage
	{
		// Token: 0x06004268 RID: 17000 RVA: 0x000A34F4 File Offset: 0x000A16F4
		[NullableContext(1)]
		public static CharacterBattleStateChangeNotify Create()
		{
			return new CharacterBattleStateChangeNotify();
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06004269 RID: 17001 RVA: 0x000A34FB File Offset: 0x000A16FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x0600426A RID: 17002 RVA: 0x000A34FE File Offset: 0x000A16FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharacterBattleStateChangeNotify.Descriptor;
			}
		}

		// Token: 0x0600426B RID: 17003 RVA: 0x000A3505 File Offset: 0x000A1705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterBattleStateChangeNotify()
		{
		}

		// Token: 0x0600426C RID: 17004 RVA: 0x000A3518 File Offset: 0x000A1718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterBattleStateChangeNotify(CharacterBattleStateChangeNotify other) : this()
		{
			this.characterBattleStateInfo_ = other.characterBattleStateInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600426D RID: 17005 RVA: 0x000A3542 File Offset: 0x000A1742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterBattleStateChangeNotify Clone()
		{
			return new CharacterBattleStateChangeNotify(this);
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x0600426E RID: 17006 RVA: 0x000A354A File Offset: 0x000A174A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CharacterBattleStateInfo> CharacterBattleStateInfo
		{
			get
			{
				return this.characterBattleStateInfo_;
			}
		}

		// Token: 0x0600426F RID: 17007 RVA: 0x000A3552 File Offset: 0x000A1752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharacterBattleStateChangeNotify);
		}

		// Token: 0x06004270 RID: 17008 RVA: 0x000A3560 File Offset: 0x000A1760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CharacterBattleStateChangeNotify other)
		{
			return other != null && (other == this || (this.characterBattleStateInfo_.Equals(other.characterBattleStateInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004271 RID: 17009 RVA: 0x000A3594 File Offset: 0x000A1794
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

		// Token: 0x06004272 RID: 17010 RVA: 0x000A35C8 File Offset: 0x000A17C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004273 RID: 17011 RVA: 0x000A35D5 File Offset: 0x000A17D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004274 RID: 17012 RVA: 0x000A35DE File Offset: 0x000A17DE
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

		// Token: 0x06004275 RID: 17013 RVA: 0x000A3608 File Offset: 0x000A1808
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

		// Token: 0x06004276 RID: 17014 RVA: 0x000A3641 File Offset: 0x000A1841
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

		// Token: 0x06004277 RID: 17015 RVA: 0x000A366F File Offset: 0x000A186F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004278 RID: 17016 RVA: 0x000A3678 File Offset: 0x000A1878
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.characterBattleStateInfo_.AddEntriesFrom(ref input, CharacterBattleStateChangeNotify._repeated_characterBattleStateInfo_codec);
				}
			}
		}

		// Token: 0x04002E57 RID: 11863
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E58 RID: 11864
		public const int CharacterBattleStateInfoFieldNumber = 11;

		// Token: 0x04002E59 RID: 11865
		private static readonly FieldCodec<CharacterBattleStateInfo> _repeated_characterBattleStateInfo_codec = FieldCodec.ForMessage<CharacterBattleStateInfo>(90U, Aki.Protocol.CharacterBattleStateInfo.Parser);

		// Token: 0x04002E5A RID: 11866
		private readonly RepeatedField<CharacterBattleStateInfo> characterBattleStateInfo_ = new RepeatedField<CharacterBattleStateInfo>();
	}
}
