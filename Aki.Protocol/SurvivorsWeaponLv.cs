using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001363 RID: 4963
	public sealed class SurvivorsWeaponLv : IMessage<SurvivorsWeaponLv>, IMessage, IEquatable<SurvivorsWeaponLv>, IDeepCloneable<SurvivorsWeaponLv>, IBufferMessage
	{
		// Token: 0x0601A6F9 RID: 108281 RVA: 0x003DA30F File Offset: 0x003D850F
		[NullableContext(1)]
		public static SurvivorsWeaponLv Create()
		{
			return new SurvivorsWeaponLv();
		}

		// Token: 0x17005982 RID: 22914
		// (get) Token: 0x0601A6FA RID: 108282 RVA: 0x003DA316 File Offset: 0x003D8516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005983 RID: 22915
		// (get) Token: 0x0601A6FB RID: 108283 RVA: 0x003DA319 File Offset: 0x003D8519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsWeaponLv.Descriptor;
			}
		}

		// Token: 0x0601A6FC RID: 108284 RVA: 0x003DA320 File Offset: 0x003D8520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponLv()
		{
		}

		// Token: 0x0601A6FD RID: 108285 RVA: 0x003DA328 File Offset: 0x003D8528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponLv(SurvivorsWeaponLv other) : this()
		{
			this.weaponId_ = other.weaponId_;
			this.survivorsWeapon_ = ((other.survivorsWeapon_ != null) ? other.survivorsWeapon_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A6FE RID: 108286 RVA: 0x003DA374 File Offset: 0x003D8574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponLv Clone()
		{
			return new SurvivorsWeaponLv(this);
		}

		// Token: 0x17005984 RID: 22916
		// (get) Token: 0x0601A6FF RID: 108287 RVA: 0x003DA37C File Offset: 0x003D857C
		// (set) Token: 0x0601A700 RID: 108288 RVA: 0x003DA384 File Offset: 0x003D8584
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

		// Token: 0x17005985 RID: 22917
		// (get) Token: 0x0601A701 RID: 108289 RVA: 0x003DA38D File Offset: 0x003D858D
		// (set) Token: 0x0601A702 RID: 108290 RVA: 0x003DA395 File Offset: 0x003D8595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeapon SurvivorsWeapon
		{
			get
			{
				return this.survivorsWeapon_;
			}
			set
			{
				this.survivorsWeapon_ = value;
			}
		}

		// Token: 0x0601A703 RID: 108291 RVA: 0x003DA39E File Offset: 0x003D859E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsWeaponLv);
		}

		// Token: 0x0601A704 RID: 108292 RVA: 0x003DA3AC File Offset: 0x003D85AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsWeaponLv other)
		{
			return other != null && (other == this || (this.WeaponId == other.WeaponId && object.Equals(this.SurvivorsWeapon, other.SurvivorsWeapon) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A705 RID: 108293 RVA: 0x003DA3FC File Offset: 0x003D85FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeaponId != 0)
			{
				num ^= this.WeaponId.GetHashCode();
			}
			if (this.survivorsWeapon_ != null)
			{
				num ^= this.SurvivorsWeapon.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A706 RID: 108294 RVA: 0x003DA451 File Offset: 0x003D8651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A707 RID: 108295 RVA: 0x003DA45E File Offset: 0x003D865E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A708 RID: 108296 RVA: 0x003DA468 File Offset: 0x003D8668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeaponId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WeaponId);
			}
			if (this.survivorsWeapon_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SurvivorsWeapon);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A709 RID: 108297 RVA: 0x003DA4C0 File Offset: 0x003D86C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeaponId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponId);
			}
			if (this.survivorsWeapon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorsWeapon);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A70A RID: 108298 RVA: 0x003DA518 File Offset: 0x003D8718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsWeaponLv other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeaponId != 0)
			{
				this.WeaponId = other.WeaponId;
			}
			if (other.survivorsWeapon_ != null)
			{
				if (this.survivorsWeapon_ == null)
				{
					this.SurvivorsWeapon = new SurvivorsWeapon();
				}
				this.SurvivorsWeapon.MergeFrom(other.SurvivorsWeapon);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A70B RID: 108299 RVA: 0x003DA580 File Offset: 0x003D8780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A70C RID: 108300 RVA: 0x003DA58C File Offset: 0x003D878C
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.survivorsWeapon_ == null)
						{
							this.SurvivorsWeapon = new SurvivorsWeapon();
						}
						input.ReadMessage(this.SurvivorsWeapon);
					}
				}
				else
				{
					this.WeaponId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009B21 RID: 39713
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B22 RID: 39714
		public const int WeaponIdFieldNumber = 1;

		// Token: 0x04009B23 RID: 39715
		private int weaponId_;

		// Token: 0x04009B24 RID: 39716
		public const int SurvivorsWeaponFieldNumber = 2;

		// Token: 0x04009B25 RID: 39717
		private SurvivorsWeapon survivorsWeapon_;
	}
}
