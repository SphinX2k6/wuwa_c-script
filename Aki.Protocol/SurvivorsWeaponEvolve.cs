using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012F1 RID: 4849
	public sealed class SurvivorsWeaponEvolve : IMessage<SurvivorsWeaponEvolve>, IMessage, IEquatable<SurvivorsWeaponEvolve>, IDeepCloneable<SurvivorsWeaponEvolve>, IBufferMessage
	{
		// Token: 0x06019C8B RID: 105611 RVA: 0x003BF588 File Offset: 0x003BD788
		[NullableContext(1)]
		public static SurvivorsWeaponEvolve Create()
		{
			return new SurvivorsWeaponEvolve();
		}

		// Token: 0x170056F7 RID: 22263
		// (get) Token: 0x06019C8C RID: 105612 RVA: 0x003BF58F File Offset: 0x003BD78F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056F8 RID: 22264
		// (get) Token: 0x06019C8D RID: 105613 RVA: 0x003BF592 File Offset: 0x003BD792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsWeaponEvolve.Descriptor;
			}
		}

		// Token: 0x06019C8E RID: 105614 RVA: 0x003BF599 File Offset: 0x003BD799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponEvolve()
		{
		}

		// Token: 0x06019C8F RID: 105615 RVA: 0x003BF5A1 File Offset: 0x003BD7A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponEvolve(SurvivorsWeaponEvolve other) : this()
		{
			this.weaponId_ = other.weaponId_;
			this.weaponBondId_ = other.weaponBondId_;
			this.weaponIncId_ = other.weaponIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019C90 RID: 105616 RVA: 0x003BF5DE File Offset: 0x003BD7DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponEvolve Clone()
		{
			return new SurvivorsWeaponEvolve(this);
		}

		// Token: 0x170056F9 RID: 22265
		// (get) Token: 0x06019C91 RID: 105617 RVA: 0x003BF5E6 File Offset: 0x003BD7E6
		// (set) Token: 0x06019C92 RID: 105618 RVA: 0x003BF5EE File Offset: 0x003BD7EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponId
		{
			get
			{
				return this.weaponId_;
			}
			set
			{
				this.weaponId_ = value;
			}
		}

		// Token: 0x170056FA RID: 22266
		// (get) Token: 0x06019C93 RID: 105619 RVA: 0x003BF5F7 File Offset: 0x003BD7F7
		// (set) Token: 0x06019C94 RID: 105620 RVA: 0x003BF5FF File Offset: 0x003BD7FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponBondId
		{
			get
			{
				return this.weaponBondId_;
			}
			set
			{
				this.weaponBondId_ = value;
			}
		}

		// Token: 0x170056FB RID: 22267
		// (get) Token: 0x06019C95 RID: 105621 RVA: 0x003BF608 File Offset: 0x003BD808
		// (set) Token: 0x06019C96 RID: 105622 RVA: 0x003BF610 File Offset: 0x003BD810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponIncId
		{
			get
			{
				return this.weaponIncId_;
			}
			set
			{
				this.weaponIncId_ = value;
			}
		}

		// Token: 0x06019C97 RID: 105623 RVA: 0x003BF619 File Offset: 0x003BD819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsWeaponEvolve);
		}

		// Token: 0x06019C98 RID: 105624 RVA: 0x003BF628 File Offset: 0x003BD828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsWeaponEvolve other)
		{
			return other != null && (other == this || (this.WeaponId == other.WeaponId && this.WeaponBondId == other.WeaponBondId && this.WeaponIncId == other.WeaponIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019C99 RID: 105625 RVA: 0x003BF684 File Offset: 0x003BD884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeaponId != 0)
			{
				num ^= this.WeaponId.GetHashCode();
			}
			if (this.WeaponBondId != 0)
			{
				num ^= this.WeaponBondId.GetHashCode();
			}
			if (this.WeaponIncId != 0)
			{
				num ^= this.WeaponIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019C9A RID: 105626 RVA: 0x003BF6F5 File Offset: 0x003BD8F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019C9B RID: 105627 RVA: 0x003BF702 File Offset: 0x003BD902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019C9C RID: 105628 RVA: 0x003BF70C File Offset: 0x003BD90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeaponId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WeaponId);
			}
			if (this.WeaponBondId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.WeaponBondId);
			}
			if (this.WeaponIncId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.WeaponIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019C9D RID: 105629 RVA: 0x003BF780 File Offset: 0x003BD980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeaponId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponId);
			}
			if (this.WeaponBondId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponBondId);
			}
			if (this.WeaponIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019C9E RID: 105630 RVA: 0x003BF7F0 File Offset: 0x003BD9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsWeaponEvolve other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeaponId != 0)
			{
				this.WeaponId = other.WeaponId;
			}
			if (other.WeaponBondId != 0)
			{
				this.WeaponBondId = other.WeaponBondId;
			}
			if (other.WeaponIncId != 0)
			{
				this.WeaponIncId = other.WeaponIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019C9F RID: 105631 RVA: 0x003BF854 File Offset: 0x003BDA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019CA0 RID: 105632 RVA: 0x003BF860 File Offset: 0x003BDA60
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.WeaponIncId = input.ReadInt32();
						}
					}
					else
					{
						this.WeaponBondId = input.ReadInt32();
					}
				}
				else
				{
					this.WeaponId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040096EB RID: 38635
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096EC RID: 38636
		public const int WeaponIdFieldNumber = 1;

		// Token: 0x040096ED RID: 38637
		private int weaponId_;

		// Token: 0x040096EE RID: 38638
		public const int WeaponBondIdFieldNumber = 2;

		// Token: 0x040096EF RID: 38639
		private int weaponBondId_;

		// Token: 0x040096F0 RID: 38640
		public const int WeaponIncIdFieldNumber = 3;

		// Token: 0x040096F1 RID: 38641
		private int weaponIncId_;
	}
}
