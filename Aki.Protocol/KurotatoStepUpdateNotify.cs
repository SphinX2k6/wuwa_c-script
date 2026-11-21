using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008C0 RID: 2240
	[NetMessage(EMessageId.KurotatoStepUpdateNotify)]
	public sealed class KurotatoStepUpdateNotify : IMessage<KurotatoStepUpdateNotify>, IMessage, IEquatable<KurotatoStepUpdateNotify>, IDeepCloneable<KurotatoStepUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600C6D6 RID: 50902 RVA: 0x001D6C11 File Offset: 0x001D4E11
		[NullableContext(1)]
		public static KurotatoStepUpdateNotify Create()
		{
			return new KurotatoStepUpdateNotify();
		}

		// Token: 0x17002827 RID: 10279
		// (get) Token: 0x0600C6D7 RID: 50903 RVA: 0x001D6C18 File Offset: 0x001D4E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002828 RID: 10280
		// (get) Token: 0x0600C6D8 RID: 50904 RVA: 0x001D6C1B File Offset: 0x001D4E1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoStepUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600C6D9 RID: 50905 RVA: 0x001D6C22 File Offset: 0x001D4E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStepUpdateNotify()
		{
		}

		// Token: 0x0600C6DA RID: 50906 RVA: 0x001D6C2C File Offset: 0x001D4E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStepUpdateNotify(KurotatoStepUpdateNotify other) : this()
		{
			this.isStart_ = other.isStart_;
			KurotatoStepUpdateNotify.StepPbDataOneofCase stepPbDataCase = other.StepPbDataCase;
			if (stepPbDataCase != KurotatoStepUpdateNotify.StepPbDataOneofCase.ChestRewardStepPbData)
			{
				switch (stepPbDataCase)
				{
				case KurotatoStepUpdateNotify.StepPbDataOneofCase.ShopStepPbData:
					this.ShopStepPbData = other.ShopStepPbData.Clone();
					break;
				case KurotatoStepUpdateNotify.StepPbDataOneofCase.UpdateWavePbData:
					this.UpdateWavePbData = other.UpdateWavePbData.Clone();
					break;
				case KurotatoStepUpdateNotify.StepPbDataOneofCase.EndStepPbData:
					this.EndStepPbData = other.EndStepPbData.Clone();
					break;
				case KurotatoStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData:
					this.PrepareStepPbData = other.PrepareStepPbData.Clone();
					break;
				case KurotatoStepUpdateNotify.StepPbDataOneofCase.UpgradeRewardStepPbData:
					this.UpgradeRewardStepPbData = other.UpgradeRewardStepPbData.Clone();
					break;
				case KurotatoStepUpdateNotify.StepPbDataOneofCase.CombatStepPbData:
					this.CombatStepPbData = other.CombatStepPbData.Clone();
					break;
				}
			}
			else
			{
				this.ChestRewardStepPbData = other.ChestRewardStepPbData.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C6DB RID: 50907 RVA: 0x001D6D23 File Offset: 0x001D4F23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStepUpdateNotify Clone()
		{
			return new KurotatoStepUpdateNotify(this);
		}

		// Token: 0x17002829 RID: 10281
		// (get) Token: 0x0600C6DC RID: 50908 RVA: 0x001D6D2B File Offset: 0x001D4F2B
		// (set) Token: 0x0600C6DD RID: 50909 RVA: 0x001D6D33 File Offset: 0x001D4F33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsStart
		{
			get
			{
				return this.isStart_;
			}
			set
			{
				this.isStart_ = value;
			}
		}

		// Token: 0x1700282A RID: 10282
		// (get) Token: 0x0600C6DE RID: 50910 RVA: 0x001D6D3C File Offset: 0x001D4F3C
		// (set) Token: 0x0600C6DF RID: 50911 RVA: 0x001D6D55 File Offset: 0x001D4F55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoCombatStepPbData CombatStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != KurotatoStepUpdateNotify.StepPbDataOneofCase.CombatStepPbData)
				{
					return null;
				}
				return (KurotatoCombatStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? KurotatoStepUpdateNotify.StepPbDataOneofCase.None : KurotatoStepUpdateNotify.StepPbDataOneofCase.CombatStepPbData);
			}
		}

		// Token: 0x1700282B RID: 10283
		// (get) Token: 0x0600C6E0 RID: 50912 RVA: 0x001D6D6C File Offset: 0x001D4F6C
		// (set) Token: 0x0600C6E1 RID: 50913 RVA: 0x001D6D84 File Offset: 0x001D4F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoChestRewardStepPbData ChestRewardStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != KurotatoStepUpdateNotify.StepPbDataOneofCase.ChestRewardStepPbData)
				{
					return null;
				}
				return (KurotatoChestRewardStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? KurotatoStepUpdateNotify.StepPbDataOneofCase.None : KurotatoStepUpdateNotify.StepPbDataOneofCase.ChestRewardStepPbData);
			}
		}

		// Token: 0x1700282C RID: 10284
		// (get) Token: 0x0600C6E2 RID: 50914 RVA: 0x001D6D9A File Offset: 0x001D4F9A
		// (set) Token: 0x0600C6E3 RID: 50915 RVA: 0x001D6DB2 File Offset: 0x001D4FB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopStepPbData ShopStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != KurotatoStepUpdateNotify.StepPbDataOneofCase.ShopStepPbData)
				{
					return null;
				}
				return (KurotatoShopStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? KurotatoStepUpdateNotify.StepPbDataOneofCase.None : KurotatoStepUpdateNotify.StepPbDataOneofCase.ShopStepPbData);
			}
		}

		// Token: 0x1700282D RID: 10285
		// (get) Token: 0x0600C6E4 RID: 50916 RVA: 0x001D6DC8 File Offset: 0x001D4FC8
		// (set) Token: 0x0600C6E5 RID: 50917 RVA: 0x001D6DE0 File Offset: 0x001D4FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpdateWavePbData UpdateWavePbData
		{
			get
			{
				if (this.stepPbDataCase_ != KurotatoStepUpdateNotify.StepPbDataOneofCase.UpdateWavePbData)
				{
					return null;
				}
				return (KurotatoUpdateWavePbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? KurotatoStepUpdateNotify.StepPbDataOneofCase.None : KurotatoStepUpdateNotify.StepPbDataOneofCase.UpdateWavePbData);
			}
		}

		// Token: 0x1700282E RID: 10286
		// (get) Token: 0x0600C6E6 RID: 50918 RVA: 0x001D6DF6 File Offset: 0x001D4FF6
		// (set) Token: 0x0600C6E7 RID: 50919 RVA: 0x001D6E0F File Offset: 0x001D500F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardStepPbData UpgradeRewardStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != KurotatoStepUpdateNotify.StepPbDataOneofCase.UpgradeRewardStepPbData)
				{
					return null;
				}
				return (KurotatoUpgradeRewardStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? KurotatoStepUpdateNotify.StepPbDataOneofCase.None : KurotatoStepUpdateNotify.StepPbDataOneofCase.UpgradeRewardStepPbData);
			}
		}

		// Token: 0x1700282F RID: 10287
		// (get) Token: 0x0600C6E8 RID: 50920 RVA: 0x001D6E26 File Offset: 0x001D5026
		// (set) Token: 0x0600C6E9 RID: 50921 RVA: 0x001D6E3F File Offset: 0x001D503F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoPrepareStepPbData PrepareStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != KurotatoStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData)
				{
					return null;
				}
				return (KurotatoPrepareStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? KurotatoStepUpdateNotify.StepPbDataOneofCase.None : KurotatoStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData);
			}
		}

		// Token: 0x17002830 RID: 10288
		// (get) Token: 0x0600C6EA RID: 50922 RVA: 0x001D6E56 File Offset: 0x001D5056
		// (set) Token: 0x0600C6EB RID: 50923 RVA: 0x001D6E6F File Offset: 0x001D506F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndStepPbData EndStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != KurotatoStepUpdateNotify.StepPbDataOneofCase.EndStepPbData)
				{
					return null;
				}
				return (KurotatoEndStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? KurotatoStepUpdateNotify.StepPbDataOneofCase.None : KurotatoStepUpdateNotify.StepPbDataOneofCase.EndStepPbData);
			}
		}

		// Token: 0x17002831 RID: 10289
		// (get) Token: 0x0600C6EC RID: 50924 RVA: 0x001D6E86 File Offset: 0x001D5086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStepUpdateNotify.StepPbDataOneofCase StepPbDataCase
		{
			get
			{
				return this.stepPbDataCase_;
			}
		}

		// Token: 0x0600C6ED RID: 50925 RVA: 0x001D6E8E File Offset: 0x001D508E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStepPbData()
		{
			this.stepPbDataCase_ = KurotatoStepUpdateNotify.StepPbDataOneofCase.None;
			this.stepPbData_ = null;
		}

		// Token: 0x0600C6EE RID: 50926 RVA: 0x001D6E9E File Offset: 0x001D509E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoStepUpdateNotify);
		}

		// Token: 0x0600C6EF RID: 50927 RVA: 0x001D6EAC File Offset: 0x001D50AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoStepUpdateNotify other)
		{
			return other != null && (other == this || (this.IsStart == other.IsStart && object.Equals(this.CombatStepPbData, other.CombatStepPbData) && object.Equals(this.ChestRewardStepPbData, other.ChestRewardStepPbData) && object.Equals(this.ShopStepPbData, other.ShopStepPbData) && object.Equals(this.UpdateWavePbData, other.UpdateWavePbData) && object.Equals(this.UpgradeRewardStepPbData, other.UpgradeRewardStepPbData) && object.Equals(this.PrepareStepPbData, other.PrepareStepPbData) && object.Equals(this.EndStepPbData, other.EndStepPbData) && this.StepPbDataCase == other.StepPbDataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C6F0 RID: 50928 RVA: 0x001D6F88 File Offset: 0x001D5188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsStart)
			{
				num ^= this.IsStart.GetHashCode();
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.CombatStepPbData)
			{
				num ^= this.CombatStepPbData.GetHashCode();
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.ChestRewardStepPbData)
			{
				num ^= this.ChestRewardStepPbData.GetHashCode();
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.ShopStepPbData)
			{
				num ^= this.ShopStepPbData.GetHashCode();
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.UpdateWavePbData)
			{
				num ^= this.UpdateWavePbData.GetHashCode();
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.UpgradeRewardStepPbData)
			{
				num ^= this.UpgradeRewardStepPbData.GetHashCode();
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData)
			{
				num ^= this.PrepareStepPbData.GetHashCode();
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.EndStepPbData)
			{
				num ^= this.EndStepPbData.GetHashCode();
			}
			num ^= (int)this.stepPbDataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C6F1 RID: 50929 RVA: 0x001D7075 File Offset: 0x001D5275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C6F2 RID: 50930 RVA: 0x001D7082 File Offset: 0x001D5282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C6F3 RID: 50931 RVA: 0x001D708C File Offset: 0x001D528C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.ChestRewardStepPbData)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ChestRewardStepPbData);
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.ShopStepPbData)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ShopStepPbData);
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.UpdateWavePbData)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.UpdateWavePbData);
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.EndStepPbData)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.EndStepPbData);
			}
			if (this.IsStart)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsStart);
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.PrepareStepPbData);
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.UpgradeRewardStepPbData)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.UpgradeRewardStepPbData);
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.CombatStepPbData)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.CombatStepPbData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C6F4 RID: 50932 RVA: 0x001D7198 File Offset: 0x001D5398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsStart)
			{
				num += 2;
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.CombatStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatStepPbData);
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.ChestRewardStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChestRewardStepPbData);
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.ShopStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ShopStepPbData);
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.UpdateWavePbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UpdateWavePbData);
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.UpgradeRewardStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UpgradeRewardStepPbData);
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PrepareStepPbData);
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.EndStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EndStepPbData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C6F5 RID: 50933 RVA: 0x001D7280 File Offset: 0x001D5480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoStepUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsStart)
			{
				this.IsStart = other.IsStart;
			}
			KurotatoStepUpdateNotify.StepPbDataOneofCase stepPbDataCase = other.StepPbDataCase;
			if (stepPbDataCase != KurotatoStepUpdateNotify.StepPbDataOneofCase.ChestRewardStepPbData)
			{
				switch (stepPbDataCase)
				{
				case KurotatoStepUpdateNotify.StepPbDataOneofCase.ShopStepPbData:
					if (this.ShopStepPbData == null)
					{
						this.ShopStepPbData = new KurotatoShopStepPbData();
					}
					this.ShopStepPbData.MergeFrom(other.ShopStepPbData);
					break;
				case KurotatoStepUpdateNotify.StepPbDataOneofCase.UpdateWavePbData:
					if (this.UpdateWavePbData == null)
					{
						this.UpdateWavePbData = new KurotatoUpdateWavePbData();
					}
					this.UpdateWavePbData.MergeFrom(other.UpdateWavePbData);
					break;
				case KurotatoStepUpdateNotify.StepPbDataOneofCase.EndStepPbData:
					if (this.EndStepPbData == null)
					{
						this.EndStepPbData = new KurotatoEndStepPbData();
					}
					this.EndStepPbData.MergeFrom(other.EndStepPbData);
					break;
				case KurotatoStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData:
					if (this.PrepareStepPbData == null)
					{
						this.PrepareStepPbData = new KurotatoPrepareStepPbData();
					}
					this.PrepareStepPbData.MergeFrom(other.PrepareStepPbData);
					break;
				case KurotatoStepUpdateNotify.StepPbDataOneofCase.UpgradeRewardStepPbData:
					if (this.UpgradeRewardStepPbData == null)
					{
						this.UpgradeRewardStepPbData = new KurotatoUpgradeRewardStepPbData();
					}
					this.UpgradeRewardStepPbData.MergeFrom(other.UpgradeRewardStepPbData);
					break;
				case KurotatoStepUpdateNotify.StepPbDataOneofCase.CombatStepPbData:
					if (this.CombatStepPbData == null)
					{
						this.CombatStepPbData = new KurotatoCombatStepPbData();
					}
					this.CombatStepPbData.MergeFrom(other.CombatStepPbData);
					break;
				}
			}
			else
			{
				if (this.ChestRewardStepPbData == null)
				{
					this.ChestRewardStepPbData = new KurotatoChestRewardStepPbData();
				}
				this.ChestRewardStepPbData.MergeFrom(other.ChestRewardStepPbData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C6F6 RID: 50934 RVA: 0x001D7411 File Offset: 0x001D5611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C6F7 RID: 50935 RVA: 0x001D741C File Offset: 0x001D561C
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
				if (num <= 74U)
				{
					if (num <= 42U)
					{
						if (num == 10U)
						{
							KurotatoChestRewardStepPbData kurotatoChestRewardStepPbData = new KurotatoChestRewardStepPbData();
							if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.ChestRewardStepPbData)
							{
								kurotatoChestRewardStepPbData.MergeFrom(this.ChestRewardStepPbData);
							}
							input.ReadMessage(kurotatoChestRewardStepPbData);
							this.ChestRewardStepPbData = kurotatoChestRewardStepPbData;
							continue;
						}
						if (num == 42U)
						{
							KurotatoShopStepPbData kurotatoShopStepPbData = new KurotatoShopStepPbData();
							if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.ShopStepPbData)
							{
								kurotatoShopStepPbData.MergeFrom(this.ShopStepPbData);
							}
							input.ReadMessage(kurotatoShopStepPbData);
							this.ShopStepPbData = kurotatoShopStepPbData;
							continue;
						}
					}
					else
					{
						if (num == 58U)
						{
							KurotatoUpdateWavePbData kurotatoUpdateWavePbData = new KurotatoUpdateWavePbData();
							if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.UpdateWavePbData)
							{
								kurotatoUpdateWavePbData.MergeFrom(this.UpdateWavePbData);
							}
							input.ReadMessage(kurotatoUpdateWavePbData);
							this.UpdateWavePbData = kurotatoUpdateWavePbData;
							continue;
						}
						if (num == 74U)
						{
							KurotatoEndStepPbData kurotatoEndStepPbData = new KurotatoEndStepPbData();
							if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.EndStepPbData)
							{
								kurotatoEndStepPbData.MergeFrom(this.EndStepPbData);
							}
							input.ReadMessage(kurotatoEndStepPbData);
							this.EndStepPbData = kurotatoEndStepPbData;
							continue;
						}
					}
				}
				else if (num <= 90U)
				{
					if (num == 80U)
					{
						this.IsStart = input.ReadBool();
						continue;
					}
					if (num == 90U)
					{
						KurotatoPrepareStepPbData kurotatoPrepareStepPbData = new KurotatoPrepareStepPbData();
						if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData)
						{
							kurotatoPrepareStepPbData.MergeFrom(this.PrepareStepPbData);
						}
						input.ReadMessage(kurotatoPrepareStepPbData);
						this.PrepareStepPbData = kurotatoPrepareStepPbData;
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						KurotatoUpgradeRewardStepPbData kurotatoUpgradeRewardStepPbData = new KurotatoUpgradeRewardStepPbData();
						if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.UpgradeRewardStepPbData)
						{
							kurotatoUpgradeRewardStepPbData.MergeFrom(this.UpgradeRewardStepPbData);
						}
						input.ReadMessage(kurotatoUpgradeRewardStepPbData);
						this.UpgradeRewardStepPbData = kurotatoUpgradeRewardStepPbData;
						continue;
					}
					if (num == 122U)
					{
						KurotatoCombatStepPbData kurotatoCombatStepPbData = new KurotatoCombatStepPbData();
						if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.CombatStepPbData)
						{
							kurotatoCombatStepPbData.MergeFrom(this.CombatStepPbData);
						}
						input.ReadMessage(kurotatoCombatStepPbData);
						this.CombatStepPbData = kurotatoCombatStepPbData;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400559E RID: 21918
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400559F RID: 21919
		public const int IsStartFieldNumber = 10;

		// Token: 0x040055A0 RID: 21920
		private bool isStart_;

		// Token: 0x040055A1 RID: 21921
		public const int CombatStepPbDataFieldNumber = 15;

		// Token: 0x040055A2 RID: 21922
		public const int ChestRewardStepPbDataFieldNumber = 1;

		// Token: 0x040055A3 RID: 21923
		public const int ShopStepPbDataFieldNumber = 5;

		// Token: 0x040055A4 RID: 21924
		public const int UpdateWavePbDataFieldNumber = 7;

		// Token: 0x040055A5 RID: 21925
		public const int UpgradeRewardStepPbDataFieldNumber = 14;

		// Token: 0x040055A6 RID: 21926
		public const int PrepareStepPbDataFieldNumber = 11;

		// Token: 0x040055A7 RID: 21927
		public const int EndStepPbDataFieldNumber = 9;

		// Token: 0x040055A8 RID: 21928
		private object stepPbData_;

		// Token: 0x040055A9 RID: 21929
		private KurotatoStepUpdateNotify.StepPbDataOneofCase stepPbDataCase_;

		// Token: 0x0200188D RID: 6285
		public enum StepPbDataOneofCase
		{
			// Token: 0x0400CCF6 RID: 52470
			None,
			// Token: 0x0400CCF7 RID: 52471
			CombatStepPbData = 15,
			// Token: 0x0400CCF8 RID: 52472
			ChestRewardStepPbData = 1,
			// Token: 0x0400CCF9 RID: 52473
			ShopStepPbData = 5,
			// Token: 0x0400CCFA RID: 52474
			UpdateWavePbData = 7,
			// Token: 0x0400CCFB RID: 52475
			UpgradeRewardStepPbData = 14,
			// Token: 0x0400CCFC RID: 52476
			PrepareStepPbData = 11,
			// Token: 0x0400CCFD RID: 52477
			EndStepPbData = 9
		}
	}
}
