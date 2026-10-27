using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D25 RID: 3365
	[NetMessage(EMessageId.PhBaPlanUsePlanResponse)]
	public sealed class PhBaPlanUsePlanResponse : IMessage<PhBaPlanUsePlanResponse>, IMessage, IEquatable<PhBaPlanUsePlanResponse>, IDeepCloneable<PhBaPlanUsePlanResponse>, IBufferMessage
	{
		// Token: 0x060122B1 RID: 74417 RVA: 0x002A724E File Offset: 0x002A544E
		[NullableContext(1)]
		public static PhBaPlanUsePlanResponse Create()
		{
			return new PhBaPlanUsePlanResponse();
		}

		// Token: 0x17003C2E RID: 15406
		// (get) Token: 0x060122B2 RID: 74418 RVA: 0x002A7255 File Offset: 0x002A5455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C2F RID: 15407
		// (get) Token: 0x060122B3 RID: 74419 RVA: 0x002A7258 File Offset: 0x002A5458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanUsePlanResponse.Descriptor;
			}
		}

		// Token: 0x060122B4 RID: 74420 RVA: 0x002A725F File Offset: 0x002A545F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanUsePlanResponse()
		{
		}

		// Token: 0x060122B5 RID: 74421 RVA: 0x002A7274 File Offset: 0x002A5474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanUsePlanResponse(PhBaPlanUsePlanResponse other) : this()
		{
			this.code_ = other.code_;
			this.selfPlanCode_ = other.selfPlanCode_;
			this.usePlan_ = ((other.usePlan_ != null) ? other.usePlan_.Clone() : null);
			this.fiveStarSwitch_ = other.fiveStarSwitch_;
			this.towPlanSame_ = other.towPlanSame_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060122B6 RID: 74422 RVA: 0x002A72E4 File Offset: 0x002A54E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanUsePlanResponse Clone()
		{
			return new PhBaPlanUsePlanResponse(this);
		}

		// Token: 0x17003C30 RID: 15408
		// (get) Token: 0x060122B7 RID: 74423 RVA: 0x002A72EC File Offset: 0x002A54EC
		// (set) Token: 0x060122B8 RID: 74424 RVA: 0x002A72F4 File Offset: 0x002A54F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17003C31 RID: 15409
		// (get) Token: 0x060122B9 RID: 74425 RVA: 0x002A72FD File Offset: 0x002A54FD
		// (set) Token: 0x060122BA RID: 74426 RVA: 0x002A7305 File Offset: 0x002A5505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SelfPlanCode
		{
			get
			{
				return this.selfPlanCode_;
			}
			set
			{
				this.selfPlanCode_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003C32 RID: 15410
		// (get) Token: 0x060122BB RID: 74427 RVA: 0x002A7318 File Offset: 0x002A5518
		// (set) Token: 0x060122BC RID: 74428 RVA: 0x002A7320 File Offset: 0x002A5520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaOneAllSuitPlan UsePlan
		{
			get
			{
				return this.usePlan_;
			}
			set
			{
				this.usePlan_ = value;
			}
		}

		// Token: 0x17003C33 RID: 15411
		// (get) Token: 0x060122BD RID: 74429 RVA: 0x002A7329 File Offset: 0x002A5529
		// (set) Token: 0x060122BE RID: 74430 RVA: 0x002A7331 File Offset: 0x002A5531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool FiveStarSwitch
		{
			get
			{
				return this.fiveStarSwitch_;
			}
			set
			{
				this.fiveStarSwitch_ = value;
			}
		}

		// Token: 0x17003C34 RID: 15412
		// (get) Token: 0x060122BF RID: 74431 RVA: 0x002A733A File Offset: 0x002A553A
		// (set) Token: 0x060122C0 RID: 74432 RVA: 0x002A7342 File Offset: 0x002A5542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool TowPlanSame
		{
			get
			{
				return this.towPlanSame_;
			}
			set
			{
				this.towPlanSame_ = value;
			}
		}

		// Token: 0x060122C1 RID: 74433 RVA: 0x002A734B File Offset: 0x002A554B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanUsePlanResponse);
		}

		// Token: 0x060122C2 RID: 74434 RVA: 0x002A735C File Offset: 0x002A555C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanUsePlanResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && !(this.SelfPlanCode != other.SelfPlanCode) && object.Equals(this.UsePlan, other.UsePlan) && this.FiveStarSwitch == other.FiveStarSwitch && this.TowPlanSame == other.TowPlanSame && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060122C3 RID: 74435 RVA: 0x002A73E0 File Offset: 0x002A55E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.SelfPlanCode.Length != 0)
			{
				num ^= this.SelfPlanCode.GetHashCode();
			}
			if (this.usePlan_ != null)
			{
				num ^= this.UsePlan.GetHashCode();
			}
			if (this.FiveStarSwitch)
			{
				num ^= this.FiveStarSwitch.GetHashCode();
			}
			if (this.TowPlanSame)
			{
				num ^= this.TowPlanSame.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060122C4 RID: 74436 RVA: 0x002A7488 File Offset: 0x002A5688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060122C5 RID: 74437 RVA: 0x002A7495 File Offset: 0x002A5695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060122C6 RID: 74438 RVA: 0x002A74A0 File Offset: 0x002A56A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TowPlanSame)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.TowPlanSame);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Code);
			}
			if (this.usePlan_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.UsePlan);
			}
			if (this.FiveStarSwitch)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.FiveStarSwitch);
			}
			if (this.SelfPlanCode.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.SelfPlanCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060122C7 RID: 74439 RVA: 0x002A7554 File Offset: 0x002A5754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.SelfPlanCode.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SelfPlanCode);
			}
			if (this.usePlan_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UsePlan);
			}
			if (this.FiveStarSwitch)
			{
				num += 2;
			}
			if (this.TowPlanSame)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060122C8 RID: 74440 RVA: 0x002A75E0 File Offset: 0x002A57E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhBaPlanUsePlanResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.SelfPlanCode.Length != 0)
			{
				this.SelfPlanCode = other.SelfPlanCode;
			}
			if (other.usePlan_ != null)
			{
				if (this.usePlan_ == null)
				{
					this.UsePlan = new PhBaOneAllSuitPlan();
				}
				this.UsePlan.MergeFrom(other.UsePlan);
			}
			if (other.FiveStarSwitch)
			{
				this.FiveStarSwitch = other.FiveStarSwitch;
			}
			if (other.TowPlanSame)
			{
				this.TowPlanSame = other.TowPlanSame;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060122C9 RID: 74441 RVA: 0x002A7689 File Offset: 0x002A5889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060122CA RID: 74442 RVA: 0x002A7694 File Offset: 0x002A5894
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
				if (num <= 48U)
				{
					if (num == 32U)
					{
						this.TowPlanSame = input.ReadBool();
						continue;
					}
					if (num == 48U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						if (this.usePlan_ == null)
						{
							this.UsePlan = new PhBaOneAllSuitPlan();
						}
						input.ReadMessage(this.UsePlan);
						continue;
					}
					if (num == 80U)
					{
						this.FiveStarSwitch = input.ReadBool();
						continue;
					}
					if (num == 106U)
					{
						this.SelfPlanCode = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007174 RID: 29044
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007175 RID: 29045
		public const int CodeFieldNumber = 6;

		// Token: 0x04007176 RID: 29046
		private ErrorCode code_;

		// Token: 0x04007177 RID: 29047
		public const int SelfPlanCodeFieldNumber = 13;

		// Token: 0x04007178 RID: 29048
		private string selfPlanCode_ = "";

		// Token: 0x04007179 RID: 29049
		public const int UsePlanFieldNumber = 7;

		// Token: 0x0400717A RID: 29050
		private PhBaOneAllSuitPlan usePlan_;

		// Token: 0x0400717B RID: 29051
		public const int FiveStarSwitchFieldNumber = 10;

		// Token: 0x0400717C RID: 29052
		private bool fiveStarSwitch_;

		// Token: 0x0400717D RID: 29053
		public const int TowPlanSameFieldNumber = 4;

		// Token: 0x0400717E RID: 29054
		private bool towPlanSame_;
	}
}
