using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001360 RID: 4960
	public sealed class SurvivorsWeaponEvolve : IMessage<SurvivorsWeaponEvolve>, IMessage, IEquatable<SurvivorsWeaponEvolve>, IDeepCloneable<SurvivorsWeaponEvolve>, IBufferMessage
	{
		// Token: 0x0601A6C1 RID: 108225 RVA: 0x003D9CA8 File Offset: 0x003D7EA8
		[NullableContext(1)]
		public static SurvivorsWeaponEvolve Create()
		{
			return new SurvivorsWeaponEvolve();
		}

		// Token: 0x17005978 RID: 22904
		// (get) Token: 0x0601A6C2 RID: 108226 RVA: 0x003D9CAF File Offset: 0x003D7EAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005979 RID: 22905
		// (get) Token: 0x0601A6C3 RID: 108227 RVA: 0x003D9CB2 File Offset: 0x003D7EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsWeaponEvolve.Descriptor;
			}
		}

		// Token: 0x0601A6C4 RID: 108228 RVA: 0x003D9CB9 File Offset: 0x003D7EB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponEvolve()
		{
		}

		// Token: 0x0601A6C5 RID: 108229 RVA: 0x003D9CC1 File Offset: 0x003D7EC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponEvolve(SurvivorsWeaponEvolve other) : this()
		{
			this.weaponId_ = other.weaponId_;
			this.weaponBondId_ = other.weaponBondId_;
			this.weaponIncId_ = other.weaponIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A6C6 RID: 108230 RVA: 0x003D9CFE File Offset: 0x003D7EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponEvolve Clone()
		{
			return new SurvivorsWeaponEvolve(this);
		}

		// Token: 0x1700597A RID: 22906
		// (get) Token: 0x0601A6C7 RID: 108231 RVA: 0x003D9D06 File Offset: 0x003D7F06
		// (set) Token: 0x0601A6C8 RID: 108232 RVA: 0x003D9D0E File Offset: 0x003D7F0E
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

		// Token: 0x1700597B RID: 22907
		// (get) Token: 0x0601A6C9 RID: 108233 RVA: 0x003D9D17 File Offset: 0x003D7F17
		// (set) Token: 0x0601A6CA RID: 108234 RVA: 0x003D9D1F File Offset: 0x003D7F1F
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

		// Token: 0x1700597C RID: 22908
		// (get) Token: 0x0601A6CB RID: 108235 RVA: 0x003D9D28 File Offset: 0x003D7F28
		// (set) Token: 0x0601A6CC RID: 108236 RVA: 0x003D9D30 File Offset: 0x003D7F30
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

		// Token: 0x0601A6CD RID: 108237 RVA: 0x003D9D39 File Offset: 0x003D7F39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsWeaponEvolve);
		}

		// Token: 0x0601A6CE RID: 108238 RVA: 0x003D9D48 File Offset: 0x003D7F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsWeaponEvolve other)
		{
			return other != null && (other == this || (this.WeaponId == other.WeaponId && this.WeaponBondId == other.WeaponBondId && this.WeaponIncId == other.WeaponIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A6CF RID: 108239 RVA: 0x003D9DA4 File Offset: 0x003D7FA4
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

		// Token: 0x0601A6D0 RID: 108240 RVA: 0x003D9E15 File Offset: 0x003D8015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A6D1 RID: 108241 RVA: 0x003D9E22 File Offset: 0x003D8022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A6D2 RID: 108242 RVA: 0x003D9E2C File Offset: 0x003D802C
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

		// Token: 0x0601A6D3 RID: 108243 RVA: 0x003D9EA0 File Offset: 0x003D80A0
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

		// Token: 0x0601A6D4 RID: 108244 RVA: 0x003D9F10 File Offset: 0x003D8110
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

		// Token: 0x0601A6D5 RID: 108245 RVA: 0x003D9F74 File Offset: 0x003D8174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A6D6 RID: 108246 RVA: 0x003D9F80 File Offset: 0x003D8180
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

		// Token: 0x04009B15 RID: 39701
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B16 RID: 39702
		public const int WeaponIdFieldNumber = 1;

		// Token: 0x04009B17 RID: 39703
		private int weaponId_;

		// Token: 0x04009B18 RID: 39704
		public const int WeaponBondIdFieldNumber = 2;

		// Token: 0x04009B19 RID: 39705
		private int weaponBondId_;

		// Token: 0x04009B1A RID: 39706
		public const int WeaponIncIdFieldNumber = 3;

		// Token: 0x04009B1B RID: 39707
		private int weaponIncId_;
	}
}
