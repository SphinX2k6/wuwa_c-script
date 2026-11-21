using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014FB RID: 5371
	public sealed class UnlockIllustratedPhantom : IMessage<UnlockIllustratedPhantom>, IMessage, IEquatable<UnlockIllustratedPhantom>, IDeepCloneable<UnlockIllustratedPhantom>, IBufferMessage
	{
		// Token: 0x0601C787 RID: 116615 RVA: 0x00420E91 File Offset: 0x0041F091
		[NullableContext(1)]
		public static UnlockIllustratedPhantom Create()
		{
			return new UnlockIllustratedPhantom();
		}

		// Token: 0x17006056 RID: 24662
		// (get) Token: 0x0601C788 RID: 116616 RVA: 0x00420E98 File Offset: 0x0041F098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UnlockIllustratedPhantom> Parser
		{
			get
			{
				return UnlockIllustratedPhantom._parser;
			}
		}

		// Token: 0x17006057 RID: 24663
		// (get) Token: 0x0601C789 RID: 116617 RVA: 0x00420E9F File Offset: 0x0041F09F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006058 RID: 24664
		// (get) Token: 0x0601C78A RID: 116618 RVA: 0x00420EA2 File Offset: 0x0041F0A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockIllustratedPhantom.Descriptor;
			}
		}

		// Token: 0x0601C78B RID: 116619 RVA: 0x00420EA9 File Offset: 0x0041F0A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockIllustratedPhantom()
		{
		}

		// Token: 0x0601C78C RID: 116620 RVA: 0x00420EBC File Offset: 0x0041F0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockIllustratedPhantom(UnlockIllustratedPhantom other) : this()
		{
			this.monsterId_ = other.monsterId_;
			this.skinIds_ = other.skinIds_.Clone();
			this.equpiedSkin_ = other.equpiedSkin_;
			this.isSpecial_ = other.isSpecial_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C78D RID: 116621 RVA: 0x00420F15 File Offset: 0x0041F115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockIllustratedPhantom Clone()
		{
			return new UnlockIllustratedPhantom(this);
		}

		// Token: 0x17006059 RID: 24665
		// (get) Token: 0x0601C78E RID: 116622 RVA: 0x00420F1D File Offset: 0x0041F11D
		// (set) Token: 0x0601C78F RID: 116623 RVA: 0x00420F25 File Offset: 0x0041F125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MonsterId
		{
			get
			{
				return this.monsterId_;
			}
			set
			{
				this.monsterId_ = value;
			}
		}

		// Token: 0x1700605A RID: 24666
		// (get) Token: 0x0601C790 RID: 116624 RVA: 0x00420F2E File Offset: 0x0041F12E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkinIds
		{
			get
			{
				return this.skinIds_;
			}
		}

		// Token: 0x1700605B RID: 24667
		// (get) Token: 0x0601C791 RID: 116625 RVA: 0x00420F36 File Offset: 0x0041F136
		// (set) Token: 0x0601C792 RID: 116626 RVA: 0x00420F3E File Offset: 0x0041F13E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EqupiedSkin
		{
			get
			{
				return this.equpiedSkin_;
			}
			set
			{
				this.equpiedSkin_ = value;
			}
		}

		// Token: 0x1700605C RID: 24668
		// (get) Token: 0x0601C793 RID: 116627 RVA: 0x00420F47 File Offset: 0x0041F147
		// (set) Token: 0x0601C794 RID: 116628 RVA: 0x00420F4F File Offset: 0x0041F14F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSpecial
		{
			get
			{
				return this.isSpecial_;
			}
			set
			{
				this.isSpecial_ = value;
			}
		}

		// Token: 0x0601C795 RID: 116629 RVA: 0x00420F58 File Offset: 0x0041F158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockIllustratedPhantom);
		}

		// Token: 0x0601C796 RID: 116630 RVA: 0x00420F68 File Offset: 0x0041F168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockIllustratedPhantom other)
		{
			return other != null && (other == this || (this.MonsterId == other.MonsterId && this.skinIds_.Equals(other.skinIds_) && this.EqupiedSkin == other.EqupiedSkin && this.IsSpecial == other.IsSpecial && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C797 RID: 116631 RVA: 0x00420FD8 File Offset: 0x0041F1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MonsterId != 0)
			{
				num ^= this.MonsterId.GetHashCode();
			}
			num ^= this.skinIds_.GetHashCode();
			if (this.EqupiedSkin != 0)
			{
				num ^= this.EqupiedSkin.GetHashCode();
			}
			if (this.IsSpecial)
			{
				num ^= this.IsSpecial.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C798 RID: 116632 RVA: 0x00421057 File Offset: 0x0041F257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C799 RID: 116633 RVA: 0x00421064 File Offset: 0x0041F264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C79A RID: 116634 RVA: 0x00421070 File Offset: 0x0041F270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MonsterId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MonsterId);
			}
			this.skinIds_.WriteTo(ref output, UnlockIllustratedPhantom._repeated_skinIds_codec);
			if (this.EqupiedSkin != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.EqupiedSkin);
			}
			if (this.IsSpecial)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsSpecial);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C79B RID: 116635 RVA: 0x004210F8 File Offset: 0x0041F2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MonsterId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MonsterId);
			}
			num += this.skinIds_.CalculateSize(UnlockIllustratedPhantom._repeated_skinIds_codec);
			if (this.EqupiedSkin != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EqupiedSkin);
			}
			if (this.IsSpecial)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C79C RID: 116636 RVA: 0x00421170 File Offset: 0x0041F370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockIllustratedPhantom other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MonsterId != 0)
			{
				this.MonsterId = other.MonsterId;
			}
			this.skinIds_.Add(other.skinIds_);
			if (other.EqupiedSkin != 0)
			{
				this.EqupiedSkin = other.EqupiedSkin;
			}
			if (other.IsSpecial)
			{
				this.IsSpecial = other.IsSpecial;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C79D RID: 116637 RVA: 0x004211E5 File Offset: 0x0041F3E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C79E RID: 116638 RVA: 0x004211F0 File Offset: 0x0041F3F0
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
					if (num == 8U)
					{
						this.MonsterId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						goto IL_4A;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_4A;
					}
					if (num == 24U)
					{
						this.EqupiedSkin = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.IsSpecial = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4A:
				this.skinIds_.AddEntriesFrom(ref input, UnlockIllustratedPhantom._repeated_skinIds_codec);
			}
		}

		// Token: 0x0400A449 RID: 42057
		private static readonly MessageParser<UnlockIllustratedPhantom> _parser = new MessageParser<UnlockIllustratedPhantom>(() => new UnlockIllustratedPhantom());

		// Token: 0x0400A44A RID: 42058
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A44B RID: 42059
		public const int MonsterIdFieldNumber = 1;

		// Token: 0x0400A44C RID: 42060
		private int monsterId_;

		// Token: 0x0400A44D RID: 42061
		public const int SkinIdsFieldNumber = 2;

		// Token: 0x0400A44E RID: 42062
		private static readonly FieldCodec<int> _repeated_skinIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400A44F RID: 42063
		private readonly RepeatedField<int> skinIds_ = new RepeatedField<int>();

		// Token: 0x0400A450 RID: 42064
		public const int EqupiedSkinFieldNumber = 3;

		// Token: 0x0400A451 RID: 42065
		private int equpiedSkin_;

		// Token: 0x0400A452 RID: 42066
		public const int IsSpecialFieldNumber = 4;

		// Token: 0x0400A453 RID: 42067
		private bool isSpecial_;
	}
}
