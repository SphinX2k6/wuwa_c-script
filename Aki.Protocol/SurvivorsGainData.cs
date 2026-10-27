using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012C6 RID: 4806
	public sealed class SurvivorsGainData : IMessage<SurvivorsGainData>, IMessage, IEquatable<SurvivorsGainData>, IDeepCloneable<SurvivorsGainData>, IBufferMessage
	{
		// Token: 0x06019923 RID: 104739 RVA: 0x003B7656 File Offset: 0x003B5856
		[NullableContext(1)]
		public static SurvivorsGainData Create()
		{
			return new SurvivorsGainData();
		}

		// Token: 0x1700563F RID: 22079
		// (get) Token: 0x06019924 RID: 104740 RVA: 0x003B765D File Offset: 0x003B585D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SurvivorsGainData> Parser
		{
			get
			{
				return SurvivorsGainData._parser;
			}
		}

		// Token: 0x17005640 RID: 22080
		// (get) Token: 0x06019925 RID: 104741 RVA: 0x003B7664 File Offset: 0x003B5864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005641 RID: 22081
		// (get) Token: 0x06019926 RID: 104742 RVA: 0x003B7667 File Offset: 0x003B5867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsGainData.Descriptor;
			}
		}

		// Token: 0x06019927 RID: 104743 RVA: 0x003B766E File Offset: 0x003B586E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGainData()
		{
		}

		// Token: 0x06019928 RID: 104744 RVA: 0x003B7678 File Offset: 0x003B5878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGainData(SurvivorsGainData other) : this()
		{
			this.incId_ = other.incId_;
			this.configId_ = other.configId_;
			switch (other.DataCase)
			{
			case SurvivorsGainData.DataOneofCase.SurvivorsRole:
				this.SurvivorsRole = other.SurvivorsRole.Clone();
				break;
			case SurvivorsGainData.DataOneofCase.SurvivorsWeapon:
				this.SurvivorsWeapon = other.SurvivorsWeapon.Clone();
				break;
			case SurvivorsGainData.DataOneofCase.SurvivorsToken:
				this.SurvivorsToken = other.SurvivorsToken.Clone();
				break;
			case SurvivorsGainData.DataOneofCase.SurvivorsRoleEvolve:
				this.SurvivorsRoleEvolve = other.SurvivorsRoleEvolve.Clone();
				break;
			case SurvivorsGainData.DataOneofCase.SurvivorsRoleLv:
				this.SurvivorsRoleLv = other.SurvivorsRoleLv.Clone();
				break;
			case SurvivorsGainData.DataOneofCase.SurvivorsWeaponEvolve:
				this.SurvivorsWeaponEvolve = other.SurvivorsWeaponEvolve.Clone();
				break;
			case SurvivorsGainData.DataOneofCase.SurvivorsWeaponLv:
				this.SurvivorsWeaponLv = other.SurvivorsWeaponLv.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019929 RID: 104745 RVA: 0x003B7767 File Offset: 0x003B5967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGainData Clone()
		{
			return new SurvivorsGainData(this);
		}

		// Token: 0x17005642 RID: 22082
		// (get) Token: 0x0601992A RID: 104746 RVA: 0x003B776F File Offset: 0x003B596F
		// (set) Token: 0x0601992B RID: 104747 RVA: 0x003B7777 File Offset: 0x003B5977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17005643 RID: 22083
		// (get) Token: 0x0601992C RID: 104748 RVA: 0x003B7780 File Offset: 0x003B5980
		// (set) Token: 0x0601992D RID: 104749 RVA: 0x003B7788 File Offset: 0x003B5988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17005644 RID: 22084
		// (get) Token: 0x0601992E RID: 104750 RVA: 0x003B7791 File Offset: 0x003B5991
		// (set) Token: 0x0601992F RID: 104751 RVA: 0x003B77A9 File Offset: 0x003B59A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRole SurvivorsRole
		{
			get
			{
				if (this.dataCase_ != SurvivorsGainData.DataOneofCase.SurvivorsRole)
				{
					return null;
				}
				return (SurvivorsRole)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SurvivorsGainData.DataOneofCase.None : SurvivorsGainData.DataOneofCase.SurvivorsRole);
			}
		}

		// Token: 0x17005645 RID: 22085
		// (get) Token: 0x06019930 RID: 104752 RVA: 0x003B77BF File Offset: 0x003B59BF
		// (set) Token: 0x06019931 RID: 104753 RVA: 0x003B77D7 File Offset: 0x003B59D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeapon SurvivorsWeapon
		{
			get
			{
				if (this.dataCase_ != SurvivorsGainData.DataOneofCase.SurvivorsWeapon)
				{
					return null;
				}
				return (SurvivorsWeapon)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SurvivorsGainData.DataOneofCase.None : SurvivorsGainData.DataOneofCase.SurvivorsWeapon);
			}
		}

		// Token: 0x17005646 RID: 22086
		// (get) Token: 0x06019932 RID: 104754 RVA: 0x003B77ED File Offset: 0x003B59ED
		// (set) Token: 0x06019933 RID: 104755 RVA: 0x003B7805 File Offset: 0x003B5A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsToken SurvivorsToken
		{
			get
			{
				if (this.dataCase_ != SurvivorsGainData.DataOneofCase.SurvivorsToken)
				{
					return null;
				}
				return (SurvivorsToken)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SurvivorsGainData.DataOneofCase.None : SurvivorsGainData.DataOneofCase.SurvivorsToken);
			}
		}

		// Token: 0x17005647 RID: 22087
		// (get) Token: 0x06019934 RID: 104756 RVA: 0x003B781B File Offset: 0x003B5A1B
		// (set) Token: 0x06019935 RID: 104757 RVA: 0x003B7833 File Offset: 0x003B5A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRoleEvolve SurvivorsRoleEvolve
		{
			get
			{
				if (this.dataCase_ != SurvivorsGainData.DataOneofCase.SurvivorsRoleEvolve)
				{
					return null;
				}
				return (SurvivorsRoleEvolve)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SurvivorsGainData.DataOneofCase.None : SurvivorsGainData.DataOneofCase.SurvivorsRoleEvolve);
			}
		}

		// Token: 0x17005648 RID: 22088
		// (get) Token: 0x06019936 RID: 104758 RVA: 0x003B7849 File Offset: 0x003B5A49
		// (set) Token: 0x06019937 RID: 104759 RVA: 0x003B7861 File Offset: 0x003B5A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRoleLv SurvivorsRoleLv
		{
			get
			{
				if (this.dataCase_ != SurvivorsGainData.DataOneofCase.SurvivorsRoleLv)
				{
					return null;
				}
				return (SurvivorsRoleLv)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SurvivorsGainData.DataOneofCase.None : SurvivorsGainData.DataOneofCase.SurvivorsRoleLv);
			}
		}

		// Token: 0x17005649 RID: 22089
		// (get) Token: 0x06019938 RID: 104760 RVA: 0x003B7877 File Offset: 0x003B5A77
		// (set) Token: 0x06019939 RID: 104761 RVA: 0x003B788F File Offset: 0x003B5A8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponEvolve SurvivorsWeaponEvolve
		{
			get
			{
				if (this.dataCase_ != SurvivorsGainData.DataOneofCase.SurvivorsWeaponEvolve)
				{
					return null;
				}
				return (SurvivorsWeaponEvolve)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SurvivorsGainData.DataOneofCase.None : SurvivorsGainData.DataOneofCase.SurvivorsWeaponEvolve);
			}
		}

		// Token: 0x1700564A RID: 22090
		// (get) Token: 0x0601993A RID: 104762 RVA: 0x003B78A5 File Offset: 0x003B5AA5
		// (set) Token: 0x0601993B RID: 104763 RVA: 0x003B78BD File Offset: 0x003B5ABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponLv SurvivorsWeaponLv
		{
			get
			{
				if (this.dataCase_ != SurvivorsGainData.DataOneofCase.SurvivorsWeaponLv)
				{
					return null;
				}
				return (SurvivorsWeaponLv)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SurvivorsGainData.DataOneofCase.None : SurvivorsGainData.DataOneofCase.SurvivorsWeaponLv);
			}
		}

		// Token: 0x1700564B RID: 22091
		// (get) Token: 0x0601993C RID: 104764 RVA: 0x003B78D3 File Offset: 0x003B5AD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGainData.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x0601993D RID: 104765 RVA: 0x003B78DB File Offset: 0x003B5ADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = SurvivorsGainData.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x0601993E RID: 104766 RVA: 0x003B78EB File Offset: 0x003B5AEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsGainData);
		}

		// Token: 0x0601993F RID: 104767 RVA: 0x003B78FC File Offset: 0x003B5AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsGainData other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.ConfigId == other.ConfigId && object.Equals(this.SurvivorsRole, other.SurvivorsRole) && object.Equals(this.SurvivorsWeapon, other.SurvivorsWeapon) && object.Equals(this.SurvivorsToken, other.SurvivorsToken) && object.Equals(this.SurvivorsRoleEvolve, other.SurvivorsRoleEvolve) && object.Equals(this.SurvivorsRoleLv, other.SurvivorsRoleLv) && object.Equals(this.SurvivorsWeaponEvolve, other.SurvivorsWeaponEvolve) && object.Equals(this.SurvivorsWeaponLv, other.SurvivorsWeaponLv) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019940 RID: 104768 RVA: 0x003B79E8 File Offset: 0x003B5BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsRole)
			{
				num ^= this.SurvivorsRole.GetHashCode();
			}
			if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsWeapon)
			{
				num ^= this.SurvivorsWeapon.GetHashCode();
			}
			if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsToken)
			{
				num ^= this.SurvivorsToken.GetHashCode();
			}
			if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsRoleEvolve)
			{
				num ^= this.SurvivorsRoleEvolve.GetHashCode();
			}
			if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsRoleLv)
			{
				num ^= this.SurvivorsRoleLv.GetHashCode();
			}
			if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsWeaponEvolve)
			{
				num ^= this.SurvivorsWeaponEvolve.GetHashCode();
			}
			if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsWeaponLv)
			{
				num ^= this.SurvivorsWeaponLv.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019941 RID: 104769 RVA: 0x003B7AEA File Offset: 0x003B5CEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019942 RID: 104770 RVA: 0x003B7AF7 File Offset: 0x003B5CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019943 RID: 104771 RVA: 0x003B7B00 File Offset: 0x003B5D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsRole)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SurvivorsRole);
			}
			if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsWeapon)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SurvivorsWeapon);
			}
			if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsToken)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.SurvivorsToken);
			}
			if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsRoleEvolve)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.SurvivorsRoleEvolve);
			}
			if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsRoleLv)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.SurvivorsRoleLv);
			}
			if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsWeaponEvolve)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.SurvivorsWeaponEvolve);
			}
			if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsWeaponLv)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.SurvivorsWeaponLv);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(192, 62);
				output.WriteInt32(this.IncId);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(200, 62);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019944 RID: 104772 RVA: 0x003B7C30 File Offset: 0x003B5E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.ConfigId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsRole)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorsRole);
			}
			if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsWeapon)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorsWeapon);
			}
			if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsToken)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorsToken);
			}
			if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsRoleEvolve)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorsRoleEvolve);
			}
			if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsRoleLv)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorsRoleLv);
			}
			if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsWeaponEvolve)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorsWeaponEvolve);
			}
			if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsWeaponLv)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorsWeaponLv);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019945 RID: 104773 RVA: 0x003B7D38 File Offset: 0x003B5F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsGainData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			switch (other.DataCase)
			{
			case SurvivorsGainData.DataOneofCase.SurvivorsRole:
				if (this.SurvivorsRole == null)
				{
					this.SurvivorsRole = new SurvivorsRole();
				}
				this.SurvivorsRole.MergeFrom(other.SurvivorsRole);
				break;
			case SurvivorsGainData.DataOneofCase.SurvivorsWeapon:
				if (this.SurvivorsWeapon == null)
				{
					this.SurvivorsWeapon = new SurvivorsWeapon();
				}
				this.SurvivorsWeapon.MergeFrom(other.SurvivorsWeapon);
				break;
			case SurvivorsGainData.DataOneofCase.SurvivorsToken:
				if (this.SurvivorsToken == null)
				{
					this.SurvivorsToken = new SurvivorsToken();
				}
				this.SurvivorsToken.MergeFrom(other.SurvivorsToken);
				break;
			case SurvivorsGainData.DataOneofCase.SurvivorsRoleEvolve:
				if (this.SurvivorsRoleEvolve == null)
				{
					this.SurvivorsRoleEvolve = new SurvivorsRoleEvolve();
				}
				this.SurvivorsRoleEvolve.MergeFrom(other.SurvivorsRoleEvolve);
				break;
			case SurvivorsGainData.DataOneofCase.SurvivorsRoleLv:
				if (this.SurvivorsRoleLv == null)
				{
					this.SurvivorsRoleLv = new SurvivorsRoleLv();
				}
				this.SurvivorsRoleLv.MergeFrom(other.SurvivorsRoleLv);
				break;
			case SurvivorsGainData.DataOneofCase.SurvivorsWeaponEvolve:
				if (this.SurvivorsWeaponEvolve == null)
				{
					this.SurvivorsWeaponEvolve = new SurvivorsWeaponEvolve();
				}
				this.SurvivorsWeaponEvolve.MergeFrom(other.SurvivorsWeaponEvolve);
				break;
			case SurvivorsGainData.DataOneofCase.SurvivorsWeaponLv:
				if (this.SurvivorsWeaponLv == null)
				{
					this.SurvivorsWeaponLv = new SurvivorsWeaponLv();
				}
				this.SurvivorsWeaponLv.MergeFrom(other.SurvivorsWeaponLv);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019946 RID: 104774 RVA: 0x003B7EC9 File Offset: 0x003B60C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019947 RID: 104775 RVA: 0x003B7ED4 File Offset: 0x003B60D4
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
				if (num <= 34U)
				{
					if (num <= 18U)
					{
						if (num == 10U)
						{
							SurvivorsRole survivorsRole = new SurvivorsRole();
							if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsRole)
							{
								survivorsRole.MergeFrom(this.SurvivorsRole);
							}
							input.ReadMessage(survivorsRole);
							this.SurvivorsRole = survivorsRole;
							continue;
						}
						if (num == 18U)
						{
							SurvivorsWeapon survivorsWeapon = new SurvivorsWeapon();
							if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsWeapon)
							{
								survivorsWeapon.MergeFrom(this.SurvivorsWeapon);
							}
							input.ReadMessage(survivorsWeapon);
							this.SurvivorsWeapon = survivorsWeapon;
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							SurvivorsToken survivorsToken = new SurvivorsToken();
							if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsToken)
							{
								survivorsToken.MergeFrom(this.SurvivorsToken);
							}
							input.ReadMessage(survivorsToken);
							this.SurvivorsToken = survivorsToken;
							continue;
						}
						if (num == 34U)
						{
							SurvivorsRoleEvolve survivorsRoleEvolve = new SurvivorsRoleEvolve();
							if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsRoleEvolve)
							{
								survivorsRoleEvolve.MergeFrom(this.SurvivorsRoleEvolve);
							}
							input.ReadMessage(survivorsRoleEvolve);
							this.SurvivorsRoleEvolve = survivorsRoleEvolve;
							continue;
						}
					}
				}
				else if (num <= 50U)
				{
					if (num == 42U)
					{
						SurvivorsRoleLv survivorsRoleLv = new SurvivorsRoleLv();
						if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsRoleLv)
						{
							survivorsRoleLv.MergeFrom(this.SurvivorsRoleLv);
						}
						input.ReadMessage(survivorsRoleLv);
						this.SurvivorsRoleLv = survivorsRoleLv;
						continue;
					}
					if (num == 50U)
					{
						SurvivorsWeaponEvolve survivorsWeaponEvolve = new SurvivorsWeaponEvolve();
						if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsWeaponEvolve)
						{
							survivorsWeaponEvolve.MergeFrom(this.SurvivorsWeaponEvolve);
						}
						input.ReadMessage(survivorsWeaponEvolve);
						this.SurvivorsWeaponEvolve = survivorsWeaponEvolve;
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						SurvivorsWeaponLv survivorsWeaponLv = new SurvivorsWeaponLv();
						if (this.dataCase_ == SurvivorsGainData.DataOneofCase.SurvivorsWeaponLv)
						{
							survivorsWeaponLv.MergeFrom(this.SurvivorsWeaponLv);
						}
						input.ReadMessage(survivorsWeaponLv);
						this.SurvivorsWeaponLv = survivorsWeaponLv;
						continue;
					}
					if (num == 8000U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
					if (num == 8008U)
					{
						this.ConfigId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040095FD RID: 38397
		private static readonly MessageParser<SurvivorsGainData> _parser = new MessageParser<SurvivorsGainData>(() => new SurvivorsGainData());

		// Token: 0x040095FE RID: 38398
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095FF RID: 38399
		public const int IncIdFieldNumber = 1000;

		// Token: 0x04009600 RID: 38400
		private int incId_;

		// Token: 0x04009601 RID: 38401
		public const int ConfigIdFieldNumber = 1001;

		// Token: 0x04009602 RID: 38402
		private int configId_;

		// Token: 0x04009603 RID: 38403
		public const int SurvivorsRoleFieldNumber = 1;

		// Token: 0x04009604 RID: 38404
		public const int SurvivorsWeaponFieldNumber = 2;

		// Token: 0x04009605 RID: 38405
		public const int SurvivorsTokenFieldNumber = 3;

		// Token: 0x04009606 RID: 38406
		public const int SurvivorsRoleEvolveFieldNumber = 4;

		// Token: 0x04009607 RID: 38407
		public const int SurvivorsRoleLvFieldNumber = 5;

		// Token: 0x04009608 RID: 38408
		public const int SurvivorsWeaponEvolveFieldNumber = 6;

		// Token: 0x04009609 RID: 38409
		public const int SurvivorsWeaponLvFieldNumber = 7;

		// Token: 0x0400960A RID: 38410
		private object data_;

		// Token: 0x0400960B RID: 38411
		private SurvivorsGainData.DataOneofCase dataCase_;

		// Token: 0x020019AE RID: 6574
		public enum DataOneofCase
		{
			// Token: 0x0400CA47 RID: 51783
			None,
			// Token: 0x0400CA48 RID: 51784
			SurvivorsRole,
			// Token: 0x0400CA49 RID: 51785
			SurvivorsWeapon,
			// Token: 0x0400CA4A RID: 51786
			SurvivorsToken,
			// Token: 0x0400CA4B RID: 51787
			SurvivorsRoleEvolve,
			// Token: 0x0400CA4C RID: 51788
			SurvivorsRoleLv,
			// Token: 0x0400CA4D RID: 51789
			SurvivorsWeaponEvolve,
			// Token: 0x0400CA4E RID: 51790
			SurvivorsWeaponLv
		}
	}
}
