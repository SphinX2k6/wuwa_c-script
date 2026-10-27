using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008D1 RID: 2257
	[NetMessage(EMessageId.KurotatoStepUpdateNotify)]
	public sealed class KurotatoStepUpdateNotify : IMessage<KurotatoStepUpdateNotify>, IMessage, IEquatable<KurotatoStepUpdateNotify>, IDeepCloneable<KurotatoStepUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600C7F2 RID: 51186 RVA: 0x001D8EF5 File Offset: 0x001D70F5
		[NullableContext(1)]
		public static KurotatoStepUpdateNotify Create()
		{
			return new KurotatoStepUpdateNotify();
		}

		// Token: 0x17002866 RID: 10342
		// (get) Token: 0x0600C7F3 RID: 51187 RVA: 0x001D8EFC File Offset: 0x001D70FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002867 RID: 10343
		// (get) Token: 0x0600C7F4 RID: 51188 RVA: 0x001D8EFF File Offset: 0x001D70FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoStepUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600C7F5 RID: 51189 RVA: 0x001D8F06 File Offset: 0x001D7106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStepUpdateNotify()
		{
		}

		// Token: 0x0600C7F6 RID: 51190 RVA: 0x001D8F10 File Offset: 0x001D7110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStepUpdateNotify(KurotatoStepUpdateNotify other) : this()
		{
			this.isStart_ = other.isStart_;
			switch (other.StepPbDataCase)
			{
			case KurotatoStepUpdateNotify.StepPbDataOneofCase.UpdateWavePbData:
				this.UpdateWavePbData = other.UpdateWavePbData.Clone();
				break;
			case KurotatoStepUpdateNotify.StepPbDataOneofCase.ShopStepPbData:
				this.ShopStepPbData = other.ShopStepPbData.Clone();
				break;
			case KurotatoStepUpdateNotify.StepPbDataOneofCase.ChestRewardStepPbData:
				this.ChestRewardStepPbData = other.ChestRewardStepPbData.Clone();
				break;
			case KurotatoStepUpdateNotify.StepPbDataOneofCase.CombatStepPbData:
				this.CombatStepPbData = other.CombatStepPbData.Clone();
				break;
			case KurotatoStepUpdateNotify.StepPbDataOneofCase.EndStepPbData:
				this.EndStepPbData = other.EndStepPbData.Clone();
				break;
			case KurotatoStepUpdateNotify.StepPbDataOneofCase.UpgradeRewardStepPbData:
				this.UpgradeRewardStepPbData = other.UpgradeRewardStepPbData.Clone();
				break;
			case KurotatoStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData:
				this.PrepareStepPbData = other.PrepareStepPbData.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C7F7 RID: 51191 RVA: 0x001D900B File Offset: 0x001D720B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStepUpdateNotify Clone()
		{
			return new KurotatoStepUpdateNotify(this);
		}

		// Token: 0x17002868 RID: 10344
		// (get) Token: 0x0600C7F8 RID: 51192 RVA: 0x001D9013 File Offset: 0x001D7213
		// (set) Token: 0x0600C7F9 RID: 51193 RVA: 0x001D901B File Offset: 0x001D721B
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

		// Token: 0x17002869 RID: 10345
		// (get) Token: 0x0600C7FA RID: 51194 RVA: 0x001D9024 File Offset: 0x001D7224
		// (set) Token: 0x0600C7FB RID: 51195 RVA: 0x001D903C File Offset: 0x001D723C
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

		// Token: 0x1700286A RID: 10346
		// (get) Token: 0x0600C7FC RID: 51196 RVA: 0x001D9052 File Offset: 0x001D7252
		// (set) Token: 0x0600C7FD RID: 51197 RVA: 0x001D906A File Offset: 0x001D726A
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

		// Token: 0x1700286B RID: 10347
		// (get) Token: 0x0600C7FE RID: 51198 RVA: 0x001D9080 File Offset: 0x001D7280
		// (set) Token: 0x0600C7FF RID: 51199 RVA: 0x001D9098 File Offset: 0x001D7298
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

		// Token: 0x1700286C RID: 10348
		// (get) Token: 0x0600C800 RID: 51200 RVA: 0x001D90AE File Offset: 0x001D72AE
		// (set) Token: 0x0600C801 RID: 51201 RVA: 0x001D90C6 File Offset: 0x001D72C6
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

		// Token: 0x1700286D RID: 10349
		// (get) Token: 0x0600C802 RID: 51202 RVA: 0x001D90DC File Offset: 0x001D72DC
		// (set) Token: 0x0600C803 RID: 51203 RVA: 0x001D90F5 File Offset: 0x001D72F5
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

		// Token: 0x1700286E RID: 10350
		// (get) Token: 0x0600C804 RID: 51204 RVA: 0x001D910C File Offset: 0x001D730C
		// (set) Token: 0x0600C805 RID: 51205 RVA: 0x001D9125 File Offset: 0x001D7325
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

		// Token: 0x1700286F RID: 10351
		// (get) Token: 0x0600C806 RID: 51206 RVA: 0x001D913C File Offset: 0x001D733C
		// (set) Token: 0x0600C807 RID: 51207 RVA: 0x001D9155 File Offset: 0x001D7355
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

		// Token: 0x17002870 RID: 10352
		// (get) Token: 0x0600C808 RID: 51208 RVA: 0x001D916C File Offset: 0x001D736C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStepUpdateNotify.StepPbDataOneofCase StepPbDataCase
		{
			get
			{
				return this.stepPbDataCase_;
			}
		}

		// Token: 0x0600C809 RID: 51209 RVA: 0x001D9174 File Offset: 0x001D7374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStepPbData()
		{
			this.stepPbDataCase_ = KurotatoStepUpdateNotify.StepPbDataOneofCase.None;
			this.stepPbData_ = null;
		}

		// Token: 0x0600C80A RID: 51210 RVA: 0x001D9184 File Offset: 0x001D7384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoStepUpdateNotify);
		}

		// Token: 0x0600C80B RID: 51211 RVA: 0x001D9194 File Offset: 0x001D7394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoStepUpdateNotify other)
		{
			return other != null && (other == this || (this.IsStart == other.IsStart && object.Equals(this.CombatStepPbData, other.CombatStepPbData) && object.Equals(this.ChestRewardStepPbData, other.ChestRewardStepPbData) && object.Equals(this.ShopStepPbData, other.ShopStepPbData) && object.Equals(this.UpdateWavePbData, other.UpdateWavePbData) && object.Equals(this.UpgradeRewardStepPbData, other.UpgradeRewardStepPbData) && object.Equals(this.PrepareStepPbData, other.PrepareStepPbData) && object.Equals(this.EndStepPbData, other.EndStepPbData) && this.StepPbDataCase == other.StepPbDataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C80C RID: 51212 RVA: 0x001D9270 File Offset: 0x001D7470
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

		// Token: 0x0600C80D RID: 51213 RVA: 0x001D935C File Offset: 0x001D755C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C80E RID: 51214 RVA: 0x001D9369 File Offset: 0x001D7569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C80F RID: 51215 RVA: 0x001D9374 File Offset: 0x001D7574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.UpdateWavePbData)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.UpdateWavePbData);
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.ShopStepPbData)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ShopStepPbData);
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.ChestRewardStepPbData)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ChestRewardStepPbData);
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.CombatStepPbData)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.CombatStepPbData);
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.EndStepPbData)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.EndStepPbData);
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.UpgradeRewardStepPbData)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.UpgradeRewardStepPbData);
			}
			if (this.stepPbDataCase_ == KurotatoStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.PrepareStepPbData);
			}
			if (this.IsStart)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsStart);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C810 RID: 51216 RVA: 0x001D9480 File Offset: 0x001D7680
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

		// Token: 0x0600C811 RID: 51217 RVA: 0x001D9564 File Offset: 0x001D7764
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
			switch (other.StepPbDataCase)
			{
			case KurotatoStepUpdateNotify.StepPbDataOneofCase.UpdateWavePbData:
				if (this.UpdateWavePbData == null)
				{
					this.UpdateWavePbData = new KurotatoUpdateWavePbData();
				}
				this.UpdateWavePbData.MergeFrom(other.UpdateWavePbData);
				break;
			case KurotatoStepUpdateNotify.StepPbDataOneofCase.ShopStepPbData:
				if (this.ShopStepPbData == null)
				{
					this.ShopStepPbData = new KurotatoShopStepPbData();
				}
				this.ShopStepPbData.MergeFrom(other.ShopStepPbData);
				break;
			case KurotatoStepUpdateNotify.StepPbDataOneofCase.ChestRewardStepPbData:
				if (this.ChestRewardStepPbData == null)
				{
					this.ChestRewardStepPbData = new KurotatoChestRewardStepPbData();
				}
				this.ChestRewardStepPbData.MergeFrom(other.ChestRewardStepPbData);
				break;
			case KurotatoStepUpdateNotify.StepPbDataOneofCase.CombatStepPbData:
				if (this.CombatStepPbData == null)
				{
					this.CombatStepPbData = new KurotatoCombatStepPbData();
				}
				this.CombatStepPbData.MergeFrom(other.CombatStepPbData);
				break;
			case KurotatoStepUpdateNotify.StepPbDataOneofCase.EndStepPbData:
				if (this.EndStepPbData == null)
				{
					this.EndStepPbData = new KurotatoEndStepPbData();
				}
				this.EndStepPbData.MergeFrom(other.EndStepPbData);
				break;
			case KurotatoStepUpdateNotify.StepPbDataOneofCase.UpgradeRewardStepPbData:
				if (this.UpgradeRewardStepPbData == null)
				{
					this.UpgradeRewardStepPbData = new KurotatoUpgradeRewardStepPbData();
				}
				this.UpgradeRewardStepPbData.MergeFrom(other.UpgradeRewardStepPbData);
				break;
			case KurotatoStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData:
				if (this.PrepareStepPbData == null)
				{
					this.PrepareStepPbData = new KurotatoPrepareStepPbData();
				}
				this.PrepareStepPbData.MergeFrom(other.PrepareStepPbData);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C812 RID: 51218 RVA: 0x001D96F9 File Offset: 0x001D78F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C813 RID: 51219 RVA: 0x001D9704 File Offset: 0x001D7904
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
				if (num <= 58U)
				{
					if (num <= 26U)
					{
						if (num == 10U)
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
						if (num == 26U)
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
						if (num == 34U)
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
						if (num == 58U)
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
				}
				else if (num <= 90U)
				{
					if (num == 82U)
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
					if (num == 90U)
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
				}
				else
				{
					if (num == 106U)
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
					if (num == 112U)
					{
						this.IsStart = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005597 RID: 21911
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005598 RID: 21912
		public const int IsStartFieldNumber = 14;

		// Token: 0x04005599 RID: 21913
		private bool isStart_;

		// Token: 0x0400559A RID: 21914
		public const int CombatStepPbDataFieldNumber = 7;

		// Token: 0x0400559B RID: 21915
		public const int ChestRewardStepPbDataFieldNumber = 4;

		// Token: 0x0400559C RID: 21916
		public const int ShopStepPbDataFieldNumber = 3;

		// Token: 0x0400559D RID: 21917
		public const int UpdateWavePbDataFieldNumber = 1;

		// Token: 0x0400559E RID: 21918
		public const int UpgradeRewardStepPbDataFieldNumber = 11;

		// Token: 0x0400559F RID: 21919
		public const int PrepareStepPbDataFieldNumber = 13;

		// Token: 0x040055A0 RID: 21920
		public const int EndStepPbDataFieldNumber = 10;

		// Token: 0x040055A1 RID: 21921
		private object stepPbData_;

		// Token: 0x040055A2 RID: 21922
		private KurotatoStepUpdateNotify.StepPbDataOneofCase stepPbDataCase_;

		// Token: 0x02001815 RID: 6165
		public enum StepPbDataOneofCase
		{
			// Token: 0x0400C7CB RID: 51147
			None,
			// Token: 0x0400C7CC RID: 51148
			CombatStepPbData = 7,
			// Token: 0x0400C7CD RID: 51149
			ChestRewardStepPbData = 4,
			// Token: 0x0400C7CE RID: 51150
			ShopStepPbData = 3,
			// Token: 0x0400C7CF RID: 51151
			UpdateWavePbData = 1,
			// Token: 0x0400C7D0 RID: 51152
			UpgradeRewardStepPbData = 11,
			// Token: 0x0400C7D1 RID: 51153
			PrepareStepPbData = 13,
			// Token: 0x0400C7D2 RID: 51154
			EndStepPbData = 10
		}
	}
}
