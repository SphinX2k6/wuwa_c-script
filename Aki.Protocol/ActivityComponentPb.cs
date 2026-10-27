using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000082 RID: 130
	public sealed class ActivityComponentPb : IMessage<ActivityComponentPb>, IMessage, IEquatable<ActivityComponentPb>, IDeepCloneable<ActivityComponentPb>, IBufferMessage
	{
		// Token: 0x060018E5 RID: 6373 RVA: 0x00040ED7 File Offset: 0x0003F0D7
		[NullableContext(1)]
		public static ActivityComponentPb Create()
		{
			return new ActivityComponentPb();
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060018E6 RID: 6374 RVA: 0x00040EDE File Offset: 0x0003F0DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060018E7 RID: 6375 RVA: 0x00040EE1 File Offset: 0x0003F0E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityComponentPb.Descriptor;
			}
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x00040EE8 File Offset: 0x0003F0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityComponentPb()
		{
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x00040EF0 File Offset: 0x0003F0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityComponentPb(ActivityComponentPb other) : this()
		{
			this.configId_ = other.configId_;
			switch (other.DataCase)
			{
			case ActivityComponentPb.DataOneofCase.SurvivorsMonsterPbData:
				this.SurvivorsMonsterPbData = other.SurvivorsMonsterPbData.Clone();
				break;
			case ActivityComponentPb.DataOneofCase.SurvivorsWeaponPbData:
				this.SurvivorsWeaponPbData = other.SurvivorsWeaponPbData.Clone();
				break;
			case ActivityComponentPb.DataOneofCase.SurvivorsPlayerCharacterPbData:
				this.SurvivorsPlayerCharacterPbData = other.SurvivorsPlayerCharacterPbData.Clone();
				break;
			case ActivityComponentPb.DataOneofCase.SurvivorsGoldenCoinPbData:
				this.SurvivorsGoldenCoinPbData = other.SurvivorsGoldenCoinPbData.Clone();
				break;
			case ActivityComponentPb.DataOneofCase.PinballKSCRolePbData:
				this.PinballKSCRolePbData = other.PinballKSCRolePbData.Clone();
				break;
			case ActivityComponentPb.DataOneofCase.KurotatoCharacterEntityPbData:
				this.KurotatoCharacterEntityPbData = other.KurotatoCharacterEntityPbData.Clone();
				break;
			case ActivityComponentPb.DataOneofCase.KurotatoDropEntityPbData:
				this.KurotatoDropEntityPbData = other.KurotatoDropEntityPbData.Clone();
				break;
			case ActivityComponentPb.DataOneofCase.KurotatoWeaponEntityPbData:
				this.KurotatoWeaponEntityPbData = other.KurotatoWeaponEntityPbData.Clone();
				break;
			case ActivityComponentPb.DataOneofCase.KurotatoMonsterEntityPbData:
				this.KurotatoMonsterEntityPbData = other.KurotatoMonsterEntityPbData.Clone();
				break;
			case ActivityComponentPb.DataOneofCase.KurotatoStructureEntityPbData:
				this.KurotatoStructureEntityPbData = other.KurotatoStructureEntityPbData.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x00041021 File Offset: 0x0003F221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityComponentPb Clone()
		{
			return new ActivityComponentPb(this);
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060018EB RID: 6379 RVA: 0x00041029 File Offset: 0x0003F229
		// (set) Token: 0x060018EC RID: 6380 RVA: 0x00041031 File Offset: 0x0003F231
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

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x0004103A File Offset: 0x0003F23A
		// (set) Token: 0x060018EE RID: 6382 RVA: 0x00041052 File Offset: 0x0003F252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsMonsterPbData SurvivorsMonsterPbData
		{
			get
			{
				if (this.dataCase_ != ActivityComponentPb.DataOneofCase.SurvivorsMonsterPbData)
				{
					return null;
				}
				return (SurvivorsMonsterPbData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityComponentPb.DataOneofCase.None : ActivityComponentPb.DataOneofCase.SurvivorsMonsterPbData);
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060018EF RID: 6383 RVA: 0x00041068 File Offset: 0x0003F268
		// (set) Token: 0x060018F0 RID: 6384 RVA: 0x00041080 File Offset: 0x0003F280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponPbData SurvivorsWeaponPbData
		{
			get
			{
				if (this.dataCase_ != ActivityComponentPb.DataOneofCase.SurvivorsWeaponPbData)
				{
					return null;
				}
				return (SurvivorsWeaponPbData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityComponentPb.DataOneofCase.None : ActivityComponentPb.DataOneofCase.SurvivorsWeaponPbData);
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060018F1 RID: 6385 RVA: 0x00041096 File Offset: 0x0003F296
		// (set) Token: 0x060018F2 RID: 6386 RVA: 0x000410AE File Offset: 0x0003F2AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsPlayerCharacterPbData SurvivorsPlayerCharacterPbData
		{
			get
			{
				if (this.dataCase_ != ActivityComponentPb.DataOneofCase.SurvivorsPlayerCharacterPbData)
				{
					return null;
				}
				return (SurvivorsPlayerCharacterPbData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityComponentPb.DataOneofCase.None : ActivityComponentPb.DataOneofCase.SurvivorsPlayerCharacterPbData);
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060018F3 RID: 6387 RVA: 0x000410C4 File Offset: 0x0003F2C4
		// (set) Token: 0x060018F4 RID: 6388 RVA: 0x000410DC File Offset: 0x0003F2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGoldenCoinPbData SurvivorsGoldenCoinPbData
		{
			get
			{
				if (this.dataCase_ != ActivityComponentPb.DataOneofCase.SurvivorsGoldenCoinPbData)
				{
					return null;
				}
				return (SurvivorsGoldenCoinPbData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityComponentPb.DataOneofCase.None : ActivityComponentPb.DataOneofCase.SurvivorsGoldenCoinPbData);
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060018F5 RID: 6389 RVA: 0x000410F2 File Offset: 0x0003F2F2
		// (set) Token: 0x060018F6 RID: 6390 RVA: 0x0004110A File Offset: 0x0003F30A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballKSCRolePbData PinballKSCRolePbData
		{
			get
			{
				if (this.dataCase_ != ActivityComponentPb.DataOneofCase.PinballKSCRolePbData)
				{
					return null;
				}
				return (PinballKSCRolePbData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityComponentPb.DataOneofCase.None : ActivityComponentPb.DataOneofCase.PinballKSCRolePbData);
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060018F7 RID: 6391 RVA: 0x00041120 File Offset: 0x0003F320
		// (set) Token: 0x060018F8 RID: 6392 RVA: 0x00041138 File Offset: 0x0003F338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoCharacterEntityPbData KurotatoCharacterEntityPbData
		{
			get
			{
				if (this.dataCase_ != ActivityComponentPb.DataOneofCase.KurotatoCharacterEntityPbData)
				{
					return null;
				}
				return (KurotatoCharacterEntityPbData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityComponentPb.DataOneofCase.None : ActivityComponentPb.DataOneofCase.KurotatoCharacterEntityPbData);
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060018F9 RID: 6393 RVA: 0x0004114E File Offset: 0x0003F34E
		// (set) Token: 0x060018FA RID: 6394 RVA: 0x00041166 File Offset: 0x0003F366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoDropEntityPbData KurotatoDropEntityPbData
		{
			get
			{
				if (this.dataCase_ != ActivityComponentPb.DataOneofCase.KurotatoDropEntityPbData)
				{
					return null;
				}
				return (KurotatoDropEntityPbData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityComponentPb.DataOneofCase.None : ActivityComponentPb.DataOneofCase.KurotatoDropEntityPbData);
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060018FB RID: 6395 RVA: 0x0004117C File Offset: 0x0003F37C
		// (set) Token: 0x060018FC RID: 6396 RVA: 0x00041195 File Offset: 0x0003F395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponEntityPbData KurotatoWeaponEntityPbData
		{
			get
			{
				if (this.dataCase_ != ActivityComponentPb.DataOneofCase.KurotatoWeaponEntityPbData)
				{
					return null;
				}
				return (KurotatoWeaponEntityPbData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityComponentPb.DataOneofCase.None : ActivityComponentPb.DataOneofCase.KurotatoWeaponEntityPbData);
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060018FD RID: 6397 RVA: 0x000411AC File Offset: 0x0003F3AC
		// (set) Token: 0x060018FE RID: 6398 RVA: 0x000411C5 File Offset: 0x0003F3C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoMonsterEntityPbData KurotatoMonsterEntityPbData
		{
			get
			{
				if (this.dataCase_ != ActivityComponentPb.DataOneofCase.KurotatoMonsterEntityPbData)
				{
					return null;
				}
				return (KurotatoMonsterEntityPbData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityComponentPb.DataOneofCase.None : ActivityComponentPb.DataOneofCase.KurotatoMonsterEntityPbData);
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060018FF RID: 6399 RVA: 0x000411DC File Offset: 0x0003F3DC
		// (set) Token: 0x06001900 RID: 6400 RVA: 0x000411F5 File Offset: 0x0003F3F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStructureEntityPbData KurotatoStructureEntityPbData
		{
			get
			{
				if (this.dataCase_ != ActivityComponentPb.DataOneofCase.KurotatoStructureEntityPbData)
				{
					return null;
				}
				return (KurotatoStructureEntityPbData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ActivityComponentPb.DataOneofCase.None : ActivityComponentPb.DataOneofCase.KurotatoStructureEntityPbData);
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06001901 RID: 6401 RVA: 0x0004120C File Offset: 0x0003F40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityComponentPb.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x00041214 File Offset: 0x0003F414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = ActivityComponentPb.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x00041224 File Offset: 0x0003F424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityComponentPb);
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x00041234 File Offset: 0x0003F434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityComponentPb other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this.SurvivorsMonsterPbData, other.SurvivorsMonsterPbData) && object.Equals(this.SurvivorsWeaponPbData, other.SurvivorsWeaponPbData) && object.Equals(this.SurvivorsPlayerCharacterPbData, other.SurvivorsPlayerCharacterPbData) && object.Equals(this.SurvivorsGoldenCoinPbData, other.SurvivorsGoldenCoinPbData) && object.Equals(this.PinballKSCRolePbData, other.PinballKSCRolePbData) && object.Equals(this.KurotatoCharacterEntityPbData, other.KurotatoCharacterEntityPbData) && object.Equals(this.KurotatoDropEntityPbData, other.KurotatoDropEntityPbData) && object.Equals(this.KurotatoWeaponEntityPbData, other.KurotatoWeaponEntityPbData) && object.Equals(this.KurotatoMonsterEntityPbData, other.KurotatoMonsterEntityPbData) && object.Equals(this.KurotatoStructureEntityPbData, other.KurotatoStructureEntityPbData) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x00041350 File Offset: 0x0003F550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.SurvivorsMonsterPbData)
			{
				num ^= this.SurvivorsMonsterPbData.GetHashCode();
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.SurvivorsWeaponPbData)
			{
				num ^= this.SurvivorsWeaponPbData.GetHashCode();
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.SurvivorsPlayerCharacterPbData)
			{
				num ^= this.SurvivorsPlayerCharacterPbData.GetHashCode();
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.SurvivorsGoldenCoinPbData)
			{
				num ^= this.SurvivorsGoldenCoinPbData.GetHashCode();
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.PinballKSCRolePbData)
			{
				num ^= this.PinballKSCRolePbData.GetHashCode();
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.KurotatoCharacterEntityPbData)
			{
				num ^= this.KurotatoCharacterEntityPbData.GetHashCode();
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.KurotatoDropEntityPbData)
			{
				num ^= this.KurotatoDropEntityPbData.GetHashCode();
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.KurotatoWeaponEntityPbData)
			{
				num ^= this.KurotatoWeaponEntityPbData.GetHashCode();
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.KurotatoMonsterEntityPbData)
			{
				num ^= this.KurotatoMonsterEntityPbData.GetHashCode();
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.KurotatoStructureEntityPbData)
			{
				num ^= this.KurotatoStructureEntityPbData.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x00041481 File Offset: 0x0003F681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x0004148E File Offset: 0x0003F68E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x00041498 File Offset: 0x0003F698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.SurvivorsMonsterPbData)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SurvivorsMonsterPbData);
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.SurvivorsWeaponPbData)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.SurvivorsWeaponPbData);
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.SurvivorsPlayerCharacterPbData)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.SurvivorsPlayerCharacterPbData);
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.SurvivorsGoldenCoinPbData)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.SurvivorsGoldenCoinPbData);
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.PinballKSCRolePbData)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.PinballKSCRolePbData);
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.KurotatoCharacterEntityPbData)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.KurotatoCharacterEntityPbData);
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.KurotatoDropEntityPbData)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.KurotatoDropEntityPbData);
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.KurotatoWeaponEntityPbData)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.KurotatoWeaponEntityPbData);
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.KurotatoMonsterEntityPbData)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.KurotatoMonsterEntityPbData);
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.KurotatoStructureEntityPbData)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.KurotatoStructureEntityPbData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x000415FC File Offset: 0x0003F7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.SurvivorsMonsterPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorsMonsterPbData);
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.SurvivorsWeaponPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorsWeaponPbData);
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.SurvivorsPlayerCharacterPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorsPlayerCharacterPbData);
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.SurvivorsGoldenCoinPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorsGoldenCoinPbData);
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.PinballKSCRolePbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PinballKSCRolePbData);
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.KurotatoCharacterEntityPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KurotatoCharacterEntityPbData);
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.KurotatoDropEntityPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KurotatoDropEntityPbData);
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.KurotatoWeaponEntityPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KurotatoWeaponEntityPbData);
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.KurotatoMonsterEntityPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KurotatoMonsterEntityPbData);
			}
			if (this.dataCase_ == ActivityComponentPb.DataOneofCase.KurotatoStructureEntityPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KurotatoStructureEntityPbData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x00041738 File Offset: 0x0003F938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			switch (other.DataCase)
			{
			case ActivityComponentPb.DataOneofCase.SurvivorsMonsterPbData:
				if (this.SurvivorsMonsterPbData == null)
				{
					this.SurvivorsMonsterPbData = new SurvivorsMonsterPbData();
				}
				this.SurvivorsMonsterPbData.MergeFrom(other.SurvivorsMonsterPbData);
				break;
			case ActivityComponentPb.DataOneofCase.SurvivorsWeaponPbData:
				if (this.SurvivorsWeaponPbData == null)
				{
					this.SurvivorsWeaponPbData = new SurvivorsWeaponPbData();
				}
				this.SurvivorsWeaponPbData.MergeFrom(other.SurvivorsWeaponPbData);
				break;
			case ActivityComponentPb.DataOneofCase.SurvivorsPlayerCharacterPbData:
				if (this.SurvivorsPlayerCharacterPbData == null)
				{
					this.SurvivorsPlayerCharacterPbData = new SurvivorsPlayerCharacterPbData();
				}
				this.SurvivorsPlayerCharacterPbData.MergeFrom(other.SurvivorsPlayerCharacterPbData);
				break;
			case ActivityComponentPb.DataOneofCase.SurvivorsGoldenCoinPbData:
				if (this.SurvivorsGoldenCoinPbData == null)
				{
					this.SurvivorsGoldenCoinPbData = new SurvivorsGoldenCoinPbData();
				}
				this.SurvivorsGoldenCoinPbData.MergeFrom(other.SurvivorsGoldenCoinPbData);
				break;
			case ActivityComponentPb.DataOneofCase.PinballKSCRolePbData:
				if (this.PinballKSCRolePbData == null)
				{
					this.PinballKSCRolePbData = new PinballKSCRolePbData();
				}
				this.PinballKSCRolePbData.MergeFrom(other.PinballKSCRolePbData);
				break;
			case ActivityComponentPb.DataOneofCase.KurotatoCharacterEntityPbData:
				if (this.KurotatoCharacterEntityPbData == null)
				{
					this.KurotatoCharacterEntityPbData = new KurotatoCharacterEntityPbData();
				}
				this.KurotatoCharacterEntityPbData.MergeFrom(other.KurotatoCharacterEntityPbData);
				break;
			case ActivityComponentPb.DataOneofCase.KurotatoDropEntityPbData:
				if (this.KurotatoDropEntityPbData == null)
				{
					this.KurotatoDropEntityPbData = new KurotatoDropEntityPbData();
				}
				this.KurotatoDropEntityPbData.MergeFrom(other.KurotatoDropEntityPbData);
				break;
			case ActivityComponentPb.DataOneofCase.KurotatoWeaponEntityPbData:
				if (this.KurotatoWeaponEntityPbData == null)
				{
					this.KurotatoWeaponEntityPbData = new KurotatoWeaponEntityPbData();
				}
				this.KurotatoWeaponEntityPbData.MergeFrom(other.KurotatoWeaponEntityPbData);
				break;
			case ActivityComponentPb.DataOneofCase.KurotatoMonsterEntityPbData:
				if (this.KurotatoMonsterEntityPbData == null)
				{
					this.KurotatoMonsterEntityPbData = new KurotatoMonsterEntityPbData();
				}
				this.KurotatoMonsterEntityPbData.MergeFrom(other.KurotatoMonsterEntityPbData);
				break;
			case ActivityComponentPb.DataOneofCase.KurotatoStructureEntityPbData:
				if (this.KurotatoStructureEntityPbData == null)
				{
					this.KurotatoStructureEntityPbData = new KurotatoStructureEntityPbData();
				}
				this.KurotatoStructureEntityPbData.MergeFrom(other.KurotatoStructureEntityPbData);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x0004193C File Offset: 0x0003FB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x00041948 File Offset: 0x0003FB48
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
				if (num <= 42U)
				{
					if (num <= 18U)
					{
						if (num == 8U)
						{
							this.ConfigId = input.ReadInt32();
							continue;
						}
						if (num == 18U)
						{
							SurvivorsMonsterPbData survivorsMonsterPbData = new SurvivorsMonsterPbData();
							if (this.dataCase_ == ActivityComponentPb.DataOneofCase.SurvivorsMonsterPbData)
							{
								survivorsMonsterPbData.MergeFrom(this.SurvivorsMonsterPbData);
							}
							input.ReadMessage(survivorsMonsterPbData);
							this.SurvivorsMonsterPbData = survivorsMonsterPbData;
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							SurvivorsWeaponPbData survivorsWeaponPbData = new SurvivorsWeaponPbData();
							if (this.dataCase_ == ActivityComponentPb.DataOneofCase.SurvivorsWeaponPbData)
							{
								survivorsWeaponPbData.MergeFrom(this.SurvivorsWeaponPbData);
							}
							input.ReadMessage(survivorsWeaponPbData);
							this.SurvivorsWeaponPbData = survivorsWeaponPbData;
							continue;
						}
						if (num == 34U)
						{
							SurvivorsPlayerCharacterPbData survivorsPlayerCharacterPbData = new SurvivorsPlayerCharacterPbData();
							if (this.dataCase_ == ActivityComponentPb.DataOneofCase.SurvivorsPlayerCharacterPbData)
							{
								survivorsPlayerCharacterPbData.MergeFrom(this.SurvivorsPlayerCharacterPbData);
							}
							input.ReadMessage(survivorsPlayerCharacterPbData);
							this.SurvivorsPlayerCharacterPbData = survivorsPlayerCharacterPbData;
							continue;
						}
						if (num == 42U)
						{
							SurvivorsGoldenCoinPbData survivorsGoldenCoinPbData = new SurvivorsGoldenCoinPbData();
							if (this.dataCase_ == ActivityComponentPb.DataOneofCase.SurvivorsGoldenCoinPbData)
							{
								survivorsGoldenCoinPbData.MergeFrom(this.SurvivorsGoldenCoinPbData);
							}
							input.ReadMessage(survivorsGoldenCoinPbData);
							this.SurvivorsGoldenCoinPbData = survivorsGoldenCoinPbData;
							continue;
						}
					}
				}
				else if (num <= 66U)
				{
					if (num == 50U)
					{
						PinballKSCRolePbData pinballKSCRolePbData = new PinballKSCRolePbData();
						if (this.dataCase_ == ActivityComponentPb.DataOneofCase.PinballKSCRolePbData)
						{
							pinballKSCRolePbData.MergeFrom(this.PinballKSCRolePbData);
						}
						input.ReadMessage(pinballKSCRolePbData);
						this.PinballKSCRolePbData = pinballKSCRolePbData;
						continue;
					}
					if (num == 58U)
					{
						KurotatoCharacterEntityPbData kurotatoCharacterEntityPbData = new KurotatoCharacterEntityPbData();
						if (this.dataCase_ == ActivityComponentPb.DataOneofCase.KurotatoCharacterEntityPbData)
						{
							kurotatoCharacterEntityPbData.MergeFrom(this.KurotatoCharacterEntityPbData);
						}
						input.ReadMessage(kurotatoCharacterEntityPbData);
						this.KurotatoCharacterEntityPbData = kurotatoCharacterEntityPbData;
						continue;
					}
					if (num == 66U)
					{
						KurotatoDropEntityPbData kurotatoDropEntityPbData = new KurotatoDropEntityPbData();
						if (this.dataCase_ == ActivityComponentPb.DataOneofCase.KurotatoDropEntityPbData)
						{
							kurotatoDropEntityPbData.MergeFrom(this.KurotatoDropEntityPbData);
						}
						input.ReadMessage(kurotatoDropEntityPbData);
						this.KurotatoDropEntityPbData = kurotatoDropEntityPbData;
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						KurotatoWeaponEntityPbData kurotatoWeaponEntityPbData = new KurotatoWeaponEntityPbData();
						if (this.dataCase_ == ActivityComponentPb.DataOneofCase.KurotatoWeaponEntityPbData)
						{
							kurotatoWeaponEntityPbData.MergeFrom(this.KurotatoWeaponEntityPbData);
						}
						input.ReadMessage(kurotatoWeaponEntityPbData);
						this.KurotatoWeaponEntityPbData = kurotatoWeaponEntityPbData;
						continue;
					}
					if (num == 82U)
					{
						KurotatoMonsterEntityPbData kurotatoMonsterEntityPbData = new KurotatoMonsterEntityPbData();
						if (this.dataCase_ == ActivityComponentPb.DataOneofCase.KurotatoMonsterEntityPbData)
						{
							kurotatoMonsterEntityPbData.MergeFrom(this.KurotatoMonsterEntityPbData);
						}
						input.ReadMessage(kurotatoMonsterEntityPbData);
						this.KurotatoMonsterEntityPbData = kurotatoMonsterEntityPbData;
						continue;
					}
					if (num == 90U)
					{
						KurotatoStructureEntityPbData kurotatoStructureEntityPbData = new KurotatoStructureEntityPbData();
						if (this.dataCase_ == ActivityComponentPb.DataOneofCase.KurotatoStructureEntityPbData)
						{
							kurotatoStructureEntityPbData.MergeFrom(this.KurotatoStructureEntityPbData);
						}
						input.ReadMessage(kurotatoStructureEntityPbData);
						this.KurotatoStructureEntityPbData = kurotatoStructureEntityPbData;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400219C RID: 8604
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400219D RID: 8605
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x0400219E RID: 8606
		private int configId_;

		// Token: 0x0400219F RID: 8607
		public const int SurvivorsMonsterPbDataFieldNumber = 2;

		// Token: 0x040021A0 RID: 8608
		public const int SurvivorsWeaponPbDataFieldNumber = 3;

		// Token: 0x040021A1 RID: 8609
		public const int SurvivorsPlayerCharacterPbDataFieldNumber = 4;

		// Token: 0x040021A2 RID: 8610
		public const int SurvivorsGoldenCoinPbDataFieldNumber = 5;

		// Token: 0x040021A3 RID: 8611
		public const int PinballKSCRolePbDataFieldNumber = 6;

		// Token: 0x040021A4 RID: 8612
		public const int KurotatoCharacterEntityPbDataFieldNumber = 7;

		// Token: 0x040021A5 RID: 8613
		public const int KurotatoDropEntityPbDataFieldNumber = 8;

		// Token: 0x040021A6 RID: 8614
		public const int KurotatoWeaponEntityPbDataFieldNumber = 9;

		// Token: 0x040021A7 RID: 8615
		public const int KurotatoMonsterEntityPbDataFieldNumber = 10;

		// Token: 0x040021A8 RID: 8616
		public const int KurotatoStructureEntityPbDataFieldNumber = 11;

		// Token: 0x040021A9 RID: 8617
		private object data_;

		// Token: 0x040021AA RID: 8618
		private ActivityComponentPb.DataOneofCase dataCase_;

		// Token: 0x020016D4 RID: 5844
		public enum DataOneofCase
		{
			// Token: 0x0400C49C RID: 50332
			None,
			// Token: 0x0400C49D RID: 50333
			SurvivorsMonsterPbData = 2,
			// Token: 0x0400C49E RID: 50334
			SurvivorsWeaponPbData,
			// Token: 0x0400C49F RID: 50335
			SurvivorsPlayerCharacterPbData,
			// Token: 0x0400C4A0 RID: 50336
			SurvivorsGoldenCoinPbData,
			// Token: 0x0400C4A1 RID: 50337
			PinballKSCRolePbData,
			// Token: 0x0400C4A2 RID: 50338
			KurotatoCharacterEntityPbData,
			// Token: 0x0400C4A3 RID: 50339
			KurotatoDropEntityPbData,
			// Token: 0x0400C4A4 RID: 50340
			KurotatoWeaponEntityPbData,
			// Token: 0x0400C4A5 RID: 50341
			KurotatoMonsterEntityPbData,
			// Token: 0x0400C4A6 RID: 50342
			KurotatoStructureEntityPbData
		}
	}
}
