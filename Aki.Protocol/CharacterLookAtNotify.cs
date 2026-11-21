using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200027B RID: 635
	[NetMessage(EMessageId.CharacterLookAtNotify)]
	public sealed class CharacterLookAtNotify : IMessage<CharacterLookAtNotify>, IMessage, IEquatable<CharacterLookAtNotify>, IDeepCloneable<CharacterLookAtNotify>, IBufferMessage
	{
		// Token: 0x060042E4 RID: 17124 RVA: 0x000A4494 File Offset: 0x000A2694
		[NullableContext(1)]
		public static CharacterLookAtNotify Create()
		{
			return new CharacterLookAtNotify();
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x060042E5 RID: 17125 RVA: 0x000A449B File Offset: 0x000A269B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x060042E6 RID: 17126 RVA: 0x000A449E File Offset: 0x000A269E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharacterLookAtNotify.Descriptor;
			}
		}

		// Token: 0x060042E7 RID: 17127 RVA: 0x000A44A5 File Offset: 0x000A26A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterLookAtNotify()
		{
		}

		// Token: 0x060042E8 RID: 17128 RVA: 0x000A44B8 File Offset: 0x000A26B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterLookAtNotify(CharacterLookAtNotify other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.characterLookAtInfos_ = other.characterLookAtInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060042E9 RID: 17129 RVA: 0x000A4505 File Offset: 0x000A2705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterLookAtNotify Clone()
		{
			return new CharacterLookAtNotify(this);
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x060042EA RID: 17130 RVA: 0x000A450D File Offset: 0x000A270D
		// (set) Token: 0x060042EB RID: 17131 RVA: 0x000A4515 File Offset: 0x000A2715
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

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x060042EC RID: 17132 RVA: 0x000A451E File Offset: 0x000A271E
		// (set) Token: 0x060042ED RID: 17133 RVA: 0x000A4526 File Offset: 0x000A2726
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

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x060042EE RID: 17134 RVA: 0x000A452F File Offset: 0x000A272F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CharacterLookAtInfo> CharacterLookAtInfos
		{
			get
			{
				return this.characterLookAtInfos_;
			}
		}

		// Token: 0x060042EF RID: 17135 RVA: 0x000A4537 File Offset: 0x000A2737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharacterLookAtNotify);
		}

		// Token: 0x060042F0 RID: 17136 RVA: 0x000A4548 File Offset: 0x000A2748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CharacterLookAtNotify other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.characterLookAtInfos_.Equals(other.characterLookAtInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060042F1 RID: 17137 RVA: 0x000A45A8 File Offset: 0x000A27A8
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

		// Token: 0x060042F2 RID: 17138 RVA: 0x000A460E File Offset: 0x000A280E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060042F3 RID: 17139 RVA: 0x000A461B File Offset: 0x000A281B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060042F4 RID: 17140 RVA: 0x000A4624 File Offset: 0x000A2824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.characterLookAtInfos_.WriteTo(ref output, CharacterLookAtNotify._repeated_characterLookAtInfos_codec);
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060042F5 RID: 17141 RVA: 0x000A4690 File Offset: 0x000A2890
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

		// Token: 0x060042F6 RID: 17142 RVA: 0x000A46FC File Offset: 0x000A28FC
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

		// Token: 0x060042F7 RID: 17143 RVA: 0x000A475D File Offset: 0x000A295D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060042F8 RID: 17144 RVA: 0x000A4768 File Offset: 0x000A2968
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
				if (num != 82U)
				{
					if (num != 104U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TreeIncId = input.ReadInt64();
						}
					}
					else
					{
						this.TreeOwnerId = input.ReadInt32();
					}
				}
				else
				{
					this.characterLookAtInfos_.AddEntriesFrom(ref input, CharacterLookAtNotify._repeated_characterLookAtInfos_codec);
				}
			}
		}

		// Token: 0x04002E78 RID: 11896
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E79 RID: 11897
		public const int TreeOwnerIdFieldNumber = 13;

		// Token: 0x04002E7A RID: 11898
		private int treeOwnerId_;

		// Token: 0x04002E7B RID: 11899
		public const int TreeIncIdFieldNumber = 15;

		// Token: 0x04002E7C RID: 11900
		private long treeIncId_;

		// Token: 0x04002E7D RID: 11901
		public const int CharacterLookAtInfosFieldNumber = 10;

		// Token: 0x04002E7E RID: 11902
		private static readonly FieldCodec<CharacterLookAtInfo> _repeated_characterLookAtInfos_codec = FieldCodec.ForMessage<CharacterLookAtInfo>(82U, CharacterLookAtInfo.Parser);

		// Token: 0x04002E7F RID: 11903
		private readonly RepeatedField<CharacterLookAtInfo> characterLookAtInfos_ = new RepeatedField<CharacterLookAtInfo>();
	}
}
