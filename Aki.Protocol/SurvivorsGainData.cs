using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001335 RID: 4917
	public sealed class SurvivorsGainData : IMessage<SurvivorsGainData>, IMessage, IEquatable<SurvivorsGainData>, IDeepCloneable<SurvivorsGainData>, IBufferMessage
	{
		// Token: 0x0601A359 RID: 107353 RVA: 0x003D1D92 File Offset: 0x003CFF92
		[NullableContext(1)]
		public static SurvivorsGainData Create()
		{
			return new SurvivorsGainData();
		}

		// Token: 0x170058C0 RID: 22720
		// (get) Token: 0x0601A35A RID: 107354 RVA: 0x003D1D99 File Offset: 0x003CFF99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SurvivorsGainData> Parser
		{
			get
			{
				return SurvivorsGainData._parser;
			}
		}

		// Token: 0x170058C1 RID: 22721
		// (get) Token: 0x0601A35B RID: 107355 RVA: 0x003D1DA0 File Offset: 0x003CFFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058C2 RID: 22722
		// (get) Token: 0x0601A35C RID: 107356 RVA: 0x003D1DA3 File Offset: 0x003CFFA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsGainData.Descriptor;
			}
		}

		// Token: 0x0601A35D RID: 107357 RVA: 0x003D1DAA File Offset: 0x003CFFAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGainData()
		{
		}

		// Token: 0x0601A35E RID: 107358 RVA: 0x003D1DB4 File Offset: 0x003CFFB4
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

		// Token: 0x0601A35F RID: 107359 RVA: 0x003D1EA3 File Offset: 0x003D00A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGainData Clone()
		{
			return new SurvivorsGainData(this);
		}

		// Token: 0x170058C3 RID: 22723
		// (get) Token: 0x0601A360 RID: 107360 RVA: 0x003D1EAB File Offset: 0x003D00AB
		// (set) Token: 0x0601A361 RID: 107361 RVA: 0x003D1EB3 File Offset: 0x003D00B3
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

		// Token: 0x170058C4 RID: 22724
		// (get) Token: 0x0601A362 RID: 107362 RVA: 0x003D1EBC File Offset: 0x003D00BC
		// (set) Token: 0x0601A363 RID: 107363 RVA: 0x003D1EC4 File Offset: 0x003D00C4
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

		// Token: 0x170058C5 RID: 22725
		// (get) Token: 0x0601A364 RID: 107364 RVA: 0x003D1ECD File Offset: 0x003D00CD
		// (set) Token: 0x0601A365 RID: 107365 RVA: 0x003D1EE5 File Offset: 0x003D00E5
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

		// Token: 0x170058C6 RID: 22726
		// (get) Token: 0x0601A366 RID: 107366 RVA: 0x003D1EFB File Offset: 0x003D00FB
		// (set) Token: 0x0601A367 RID: 107367 RVA: 0x003D1F13 File Offset: 0x003D0113
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

		// Token: 0x170058C7 RID: 22727
		// (get) Token: 0x0601A368 RID: 107368 RVA: 0x003D1F29 File Offset: 0x003D0129
		// (set) Token: 0x0601A369 RID: 107369 RVA: 0x003D1F41 File Offset: 0x003D0141
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

		// Token: 0x170058C8 RID: 22728
		// (get) Token: 0x0601A36A RID: 107370 RVA: 0x003D1F57 File Offset: 0x003D0157
		// (set) Token: 0x0601A36B RID: 107371 RVA: 0x003D1F6F File Offset: 0x003D016F
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

		// Token: 0x170058C9 RID: 22729
		// (get) Token: 0x0601A36C RID: 107372 RVA: 0x003D1F85 File Offset: 0x003D0185
		// (set) Token: 0x0601A36D RID: 107373 RVA: 0x003D1F9D File Offset: 0x003D019D
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

		// Token: 0x170058CA RID: 22730
		// (get) Token: 0x0601A36E RID: 107374 RVA: 0x003D1FB3 File Offset: 0x003D01B3
		// (set) Token: 0x0601A36F RID: 107375 RVA: 0x003D1FCB File Offset: 0x003D01CB
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

		// Token: 0x170058CB RID: 22731
		// (get) Token: 0x0601A370 RID: 107376 RVA: 0x003D1FE1 File Offset: 0x003D01E1
		// (set) Token: 0x0601A371 RID: 107377 RVA: 0x003D1FF9 File Offset: 0x003D01F9
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

		// Token: 0x170058CC RID: 22732
		// (get) Token: 0x0601A372 RID: 107378 RVA: 0x003D200F File Offset: 0x003D020F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGainData.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x0601A373 RID: 107379 RVA: 0x003D2017 File Offset: 0x003D0217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = SurvivorsGainData.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x0601A374 RID: 107380 RVA: 0x003D2027 File Offset: 0x003D0227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsGainData);
		}

		// Token: 0x0601A375 RID: 107381 RVA: 0x003D2038 File Offset: 0x003D0238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsGainData other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.ConfigId == other.ConfigId && object.Equals(this.SurvivorsRole, other.SurvivorsRole) && object.Equals(this.SurvivorsWeapon, other.SurvivorsWeapon) && object.Equals(this.SurvivorsToken, other.SurvivorsToken) && object.Equals(this.SurvivorsRoleEvolve, other.SurvivorsRoleEvolve) && object.Equals(this.SurvivorsRoleLv, other.SurvivorsRoleLv) && object.Equals(this.SurvivorsWeaponEvolve, other.SurvivorsWeaponEvolve) && object.Equals(this.SurvivorsWeaponLv, other.SurvivorsWeaponLv) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A376 RID: 107382 RVA: 0x003D2124 File Offset: 0x003D0324
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

		// Token: 0x0601A377 RID: 107383 RVA: 0x003D2226 File Offset: 0x003D0426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A378 RID: 107384 RVA: 0x003D2233 File Offset: 0x003D0433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A379 RID: 107385 RVA: 0x003D223C File Offset: 0x003D043C
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

		// Token: 0x0601A37A RID: 107386 RVA: 0x003D236C File Offset: 0x003D056C
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

		// Token: 0x0601A37B RID: 107387 RVA: 0x003D2474 File Offset: 0x003D0674
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

		// Token: 0x0601A37C RID: 107388 RVA: 0x003D2605 File Offset: 0x003D0805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A37D RID: 107389 RVA: 0x003D2610 File Offset: 0x003D0810
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

		// Token: 0x04009A27 RID: 39463
		private static readonly MessageParser<SurvivorsGainData> _parser = new MessageParser<SurvivorsGainData>(() => new SurvivorsGainData());

		// Token: 0x04009A28 RID: 39464
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A29 RID: 39465
		public const int IncIdFieldNumber = 1000;

		// Token: 0x04009A2A RID: 39466
		private int incId_;

		// Token: 0x04009A2B RID: 39467
		public const int ConfigIdFieldNumber = 1001;

		// Token: 0x04009A2C RID: 39468
		private int configId_;

		// Token: 0x04009A2D RID: 39469
		public const int SurvivorsRoleFieldNumber = 1;

		// Token: 0x04009A2E RID: 39470
		public const int SurvivorsWeaponFieldNumber = 2;

		// Token: 0x04009A2F RID: 39471
		public const int SurvivorsTokenFieldNumber = 3;

		// Token: 0x04009A30 RID: 39472
		public const int SurvivorsRoleEvolveFieldNumber = 4;

		// Token: 0x04009A31 RID: 39473
		public const int SurvivorsRoleLvFieldNumber = 5;

		// Token: 0x04009A32 RID: 39474
		public const int SurvivorsWeaponEvolveFieldNumber = 6;

		// Token: 0x04009A33 RID: 39475
		public const int SurvivorsWeaponLvFieldNumber = 7;

		// Token: 0x04009A34 RID: 39476
		private object data_;

		// Token: 0x04009A35 RID: 39477
		private SurvivorsGainData.DataOneofCase dataCase_;

		// Token: 0x02001A4C RID: 6732
		public enum DataOneofCase
		{
			// Token: 0x0400CFAE RID: 53166
			None,
			// Token: 0x0400CFAF RID: 53167
			SurvivorsRole,
			// Token: 0x0400CFB0 RID: 53168
			SurvivorsWeapon,
			// Token: 0x0400CFB1 RID: 53169
			SurvivorsToken,
			// Token: 0x0400CFB2 RID: 53170
			SurvivorsRoleEvolve,
			// Token: 0x0400CFB3 RID: 53171
			SurvivorsRoleLv,
			// Token: 0x0400CFB4 RID: 53172
			SurvivorsWeaponEvolve,
			// Token: 0x0400CFB5 RID: 53173
			SurvivorsWeaponLv
		}
	}
}
