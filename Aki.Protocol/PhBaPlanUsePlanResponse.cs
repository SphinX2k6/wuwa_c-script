using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D15 RID: 3349
	[NetMessage(EMessageId.PhBaPlanUsePlanResponse)]
	public sealed class PhBaPlanUsePlanResponse : IMessage<PhBaPlanUsePlanResponse>, IMessage, IEquatable<PhBaPlanUsePlanResponse>, IDeepCloneable<PhBaPlanUsePlanResponse>, IBufferMessage
	{
		// Token: 0x060121B5 RID: 74165 RVA: 0x002A562A File Offset: 0x002A382A
		[NullableContext(1)]
		public static PhBaPlanUsePlanResponse Create()
		{
			return new PhBaPlanUsePlanResponse();
		}

		// Token: 0x17003BF9 RID: 15353
		// (get) Token: 0x060121B6 RID: 74166 RVA: 0x002A5631 File Offset: 0x002A3831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BFA RID: 15354
		// (get) Token: 0x060121B7 RID: 74167 RVA: 0x002A5634 File Offset: 0x002A3834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanUsePlanResponse.Descriptor;
			}
		}

		// Token: 0x060121B8 RID: 74168 RVA: 0x002A563B File Offset: 0x002A383B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanUsePlanResponse()
		{
		}

		// Token: 0x060121B9 RID: 74169 RVA: 0x002A5650 File Offset: 0x002A3850
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

		// Token: 0x060121BA RID: 74170 RVA: 0x002A56C0 File Offset: 0x002A38C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanUsePlanResponse Clone()
		{
			return new PhBaPlanUsePlanResponse(this);
		}

		// Token: 0x17003BFB RID: 15355
		// (get) Token: 0x060121BB RID: 74171 RVA: 0x002A56C8 File Offset: 0x002A38C8
		// (set) Token: 0x060121BC RID: 74172 RVA: 0x002A56D0 File Offset: 0x002A38D0
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

		// Token: 0x17003BFC RID: 15356
		// (get) Token: 0x060121BD RID: 74173 RVA: 0x002A56D9 File Offset: 0x002A38D9
		// (set) Token: 0x060121BE RID: 74174 RVA: 0x002A56E1 File Offset: 0x002A38E1
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

		// Token: 0x17003BFD RID: 15357
		// (get) Token: 0x060121BF RID: 74175 RVA: 0x002A56F4 File Offset: 0x002A38F4
		// (set) Token: 0x060121C0 RID: 74176 RVA: 0x002A56FC File Offset: 0x002A38FC
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

		// Token: 0x17003BFE RID: 15358
		// (get) Token: 0x060121C1 RID: 74177 RVA: 0x002A5705 File Offset: 0x002A3905
		// (set) Token: 0x060121C2 RID: 74178 RVA: 0x002A570D File Offset: 0x002A390D
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

		// Token: 0x17003BFF RID: 15359
		// (get) Token: 0x060121C3 RID: 74179 RVA: 0x002A5716 File Offset: 0x002A3916
		// (set) Token: 0x060121C4 RID: 74180 RVA: 0x002A571E File Offset: 0x002A391E
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

		// Token: 0x060121C5 RID: 74181 RVA: 0x002A5727 File Offset: 0x002A3927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanUsePlanResponse);
		}

		// Token: 0x060121C6 RID: 74182 RVA: 0x002A5738 File Offset: 0x002A3938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanUsePlanResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && !(this.SelfPlanCode != other.SelfPlanCode) && object.Equals(this.UsePlan, other.UsePlan) && this.FiveStarSwitch == other.FiveStarSwitch && this.TowPlanSame == other.TowPlanSame && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060121C7 RID: 74183 RVA: 0x002A57BC File Offset: 0x002A39BC
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

		// Token: 0x060121C8 RID: 74184 RVA: 0x002A5864 File Offset: 0x002A3A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060121C9 RID: 74185 RVA: 0x002A5871 File Offset: 0x002A3A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060121CA RID: 74186 RVA: 0x002A587C File Offset: 0x002A3A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SelfPlanCode.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.SelfPlanCode);
			}
			if (this.TowPlanSame)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.TowPlanSame);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.Code);
			}
			if (this.FiveStarSwitch)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.FiveStarSwitch);
			}
			if (this.usePlan_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.UsePlan);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060121CB RID: 74187 RVA: 0x002A5930 File Offset: 0x002A3B30
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

		// Token: 0x060121CC RID: 74188 RVA: 0x002A59BC File Offset: 0x002A3BBC
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

		// Token: 0x060121CD RID: 74189 RVA: 0x002A5A65 File Offset: 0x002A3C65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060121CE RID: 74190 RVA: 0x002A5A70 File Offset: 0x002A3C70
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
				if (num <= 64U)
				{
					if (num == 42U)
					{
						this.SelfPlanCode = input.ReadString();
						continue;
					}
					if (num == 64U)
					{
						this.TowPlanSame = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 80U)
					{
						this.FiveStarSwitch = input.ReadBool();
						continue;
					}
					if (num == 114U)
					{
						if (this.usePlan_ == null)
						{
							this.UsePlan = new PhBaOneAllSuitPlan();
						}
						input.ReadMessage(this.UsePlan);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400718C RID: 29068
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400718D RID: 29069
		public const int CodeFieldNumber = 9;

		// Token: 0x0400718E RID: 29070
		private ErrorCode code_;

		// Token: 0x0400718F RID: 29071
		public const int SelfPlanCodeFieldNumber = 5;

		// Token: 0x04007190 RID: 29072
		private string selfPlanCode_ = "";

		// Token: 0x04007191 RID: 29073
		public const int UsePlanFieldNumber = 14;

		// Token: 0x04007192 RID: 29074
		private PhBaOneAllSuitPlan usePlan_;

		// Token: 0x04007193 RID: 29075
		public const int FiveStarSwitchFieldNumber = 10;

		// Token: 0x04007194 RID: 29076
		private bool fiveStarSwitch_;

		// Token: 0x04007195 RID: 29077
		public const int TowPlanSameFieldNumber = 8;

		// Token: 0x04007196 RID: 29078
		private bool towPlanSame_;
	}
}
