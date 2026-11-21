using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000083 RID: 131
	public sealed class ActivityComponentPb : IMessage<ActivityComponentPb>, IMessage, IEquatable<ActivityComponentPb>, IDeepCloneable<ActivityComponentPb>, IBufferMessage
	{
		// Token: 0x06001928 RID: 6440 RVA: 0x0004188B File Offset: 0x0003FA8B
		[NullableContext(1)]
		public static ActivityComponentPb Create()
		{
			return new ActivityComponentPb();
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x00041892 File Offset: 0x0003FA92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x00041895 File Offset: 0x0003FA95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityComponentPb.Descriptor;
			}
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x0004189C File Offset: 0x0003FA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityComponentPb()
		{
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x000418A4 File Offset: 0x0003FAA4
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

		// Token: 0x0600192D RID: 6445 RVA: 0x000419D5 File Offset: 0x0003FBD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityComponentPb Clone()
		{
			return new ActivityComponentPb(this);
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x000419DD File Offset: 0x0003FBDD
		// (set) Token: 0x0600192F RID: 6447 RVA: 0x000419E5 File Offset: 0x0003FBE5
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

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x000419EE File Offset: 0x0003FBEE
		// (set) Token: 0x06001931 RID: 6449 RVA: 0x00041A06 File Offset: 0x0003FC06
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

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x00041A1C File Offset: 0x0003FC1C
		// (set) Token: 0x06001933 RID: 6451 RVA: 0x00041A34 File Offset: 0x0003FC34
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

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x00041A4A File Offset: 0x0003FC4A
		// (set) Token: 0x06001935 RID: 6453 RVA: 0x00041A62 File Offset: 0x0003FC62
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

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x00041A78 File Offset: 0x0003FC78
		// (set) Token: 0x06001937 RID: 6455 RVA: 0x00041A90 File Offset: 0x0003FC90
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

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x00041AA6 File Offset: 0x0003FCA6
		// (set) Token: 0x06001939 RID: 6457 RVA: 0x00041ABE File Offset: 0x0003FCBE
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

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x00041AD4 File Offset: 0x0003FCD4
		// (set) Token: 0x0600193B RID: 6459 RVA: 0x00041AEC File Offset: 0x0003FCEC
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

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x00041B02 File Offset: 0x0003FD02
		// (set) Token: 0x0600193D RID: 6461 RVA: 0x00041B1A File Offset: 0x0003FD1A
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

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x00041B30 File Offset: 0x0003FD30
		// (set) Token: 0x0600193F RID: 6463 RVA: 0x00041B49 File Offset: 0x0003FD49
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

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06001940 RID: 6464 RVA: 0x00041B60 File Offset: 0x0003FD60
		// (set) Token: 0x06001941 RID: 6465 RVA: 0x00041B79 File Offset: 0x0003FD79
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

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06001942 RID: 6466 RVA: 0x00041B90 File Offset: 0x0003FD90
		// (set) Token: 0x06001943 RID: 6467 RVA: 0x00041BA9 File Offset: 0x0003FDA9
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

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06001944 RID: 6468 RVA: 0x00041BC0 File Offset: 0x0003FDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityComponentPb.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x00041BC8 File Offset: 0x0003FDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = ActivityComponentPb.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x00041BD8 File Offset: 0x0003FDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityComponentPb);
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x00041BE8 File Offset: 0x0003FDE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityComponentPb other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this.SurvivorsMonsterPbData, other.SurvivorsMonsterPbData) && object.Equals(this.SurvivorsWeaponPbData, other.SurvivorsWeaponPbData) && object.Equals(this.SurvivorsPlayerCharacterPbData, other.SurvivorsPlayerCharacterPbData) && object.Equals(this.SurvivorsGoldenCoinPbData, other.SurvivorsGoldenCoinPbData) && object.Equals(this.PinballKSCRolePbData, other.PinballKSCRolePbData) && object.Equals(this.KurotatoCharacterEntityPbData, other.KurotatoCharacterEntityPbData) && object.Equals(this.KurotatoDropEntityPbData, other.KurotatoDropEntityPbData) && object.Equals(this.KurotatoWeaponEntityPbData, other.KurotatoWeaponEntityPbData) && object.Equals(this.KurotatoMonsterEntityPbData, other.KurotatoMonsterEntityPbData) && object.Equals(this.KurotatoStructureEntityPbData, other.KurotatoStructureEntityPbData) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00041D04 File Offset: 0x0003FF04
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

		// Token: 0x06001949 RID: 6473 RVA: 0x00041E35 File Offset: 0x00040035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x00041E42 File Offset: 0x00040042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x00041E4C File Offset: 0x0004004C
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

		// Token: 0x0600194C RID: 6476 RVA: 0x00041FB0 File Offset: 0x000401B0
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

		// Token: 0x0600194D RID: 6477 RVA: 0x000420EC File Offset: 0x000402EC
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

		// Token: 0x0600194E RID: 6478 RVA: 0x000422F0 File Offset: 0x000404F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x000422FC File Offset: 0x000404FC
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

		// Token: 0x040021FB RID: 8699
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021FC RID: 8700
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x040021FD RID: 8701
		private int configId_;

		// Token: 0x040021FE RID: 8702
		public const int SurvivorsMonsterPbDataFieldNumber = 2;

		// Token: 0x040021FF RID: 8703
		public const int SurvivorsWeaponPbDataFieldNumber = 3;

		// Token: 0x04002200 RID: 8704
		public const int SurvivorsPlayerCharacterPbDataFieldNumber = 4;

		// Token: 0x04002201 RID: 8705
		public const int SurvivorsGoldenCoinPbDataFieldNumber = 5;

		// Token: 0x04002202 RID: 8706
		public const int PinballKSCRolePbDataFieldNumber = 6;

		// Token: 0x04002203 RID: 8707
		public const int KurotatoCharacterEntityPbDataFieldNumber = 7;

		// Token: 0x04002204 RID: 8708
		public const int KurotatoDropEntityPbDataFieldNumber = 8;

		// Token: 0x04002205 RID: 8709
		public const int KurotatoWeaponEntityPbDataFieldNumber = 9;

		// Token: 0x04002206 RID: 8710
		public const int KurotatoMonsterEntityPbDataFieldNumber = 10;

		// Token: 0x04002207 RID: 8711
		public const int KurotatoStructureEntityPbDataFieldNumber = 11;

		// Token: 0x04002208 RID: 8712
		private object data_;

		// Token: 0x04002209 RID: 8713
		private ActivityComponentPb.DataOneofCase dataCase_;

		// Token: 0x02001750 RID: 5968
		public enum DataOneofCase
		{
			// Token: 0x0400C9CB RID: 51659
			None,
			// Token: 0x0400C9CC RID: 51660
			SurvivorsMonsterPbData = 2,
			// Token: 0x0400C9CD RID: 51661
			SurvivorsWeaponPbData,
			// Token: 0x0400C9CE RID: 51662
			SurvivorsPlayerCharacterPbData,
			// Token: 0x0400C9CF RID: 51663
			SurvivorsGoldenCoinPbData,
			// Token: 0x0400C9D0 RID: 51664
			PinballKSCRolePbData,
			// Token: 0x0400C9D1 RID: 51665
			KurotatoCharacterEntityPbData,
			// Token: 0x0400C9D2 RID: 51666
			KurotatoDropEntityPbData,
			// Token: 0x0400C9D3 RID: 51667
			KurotatoWeaponEntityPbData,
			// Token: 0x0400C9D4 RID: 51668
			KurotatoMonsterEntityPbData,
			// Token: 0x0400C9D5 RID: 51669
			KurotatoStructureEntityPbData
		}
	}
}
