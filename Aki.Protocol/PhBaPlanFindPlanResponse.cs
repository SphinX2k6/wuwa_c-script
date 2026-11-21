using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D0A RID: 3338
	[NetMessage(EMessageId.PhBaPlanFindPlanResponse)]
	public sealed class PhBaPlanFindPlanResponse : IMessage<PhBaPlanFindPlanResponse>, IMessage, IEquatable<PhBaPlanFindPlanResponse>, IDeepCloneable<PhBaPlanFindPlanResponse>, IBufferMessage
	{
		// Token: 0x060120E3 RID: 73955 RVA: 0x002A3CF9 File Offset: 0x002A1EF9
		[NullableContext(1)]
		public static PhBaPlanFindPlanResponse Create()
		{
			return new PhBaPlanFindPlanResponse();
		}

		// Token: 0x17003BD2 RID: 15314
		// (get) Token: 0x060120E4 RID: 73956 RVA: 0x002A3D00 File Offset: 0x002A1F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BD3 RID: 15315
		// (get) Token: 0x060120E5 RID: 73957 RVA: 0x002A3D03 File Offset: 0x002A1F03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanFindPlanResponse.Descriptor;
			}
		}

		// Token: 0x060120E6 RID: 73958 RVA: 0x002A3D0A File Offset: 0x002A1F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanFindPlanResponse()
		{
		}

		// Token: 0x060120E7 RID: 73959 RVA: 0x002A3D14 File Offset: 0x002A1F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanFindPlanResponse(PhBaPlanFindPlanResponse other) : this()
		{
			this.code_ = other.code_;
			this.plan_ = ((other.plan_ != null) ? other.plan_.Clone() : null);
			this.towPlanSame_ = other.towPlanSame_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060120E8 RID: 73960 RVA: 0x002A3D6C File Offset: 0x002A1F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanFindPlanResponse Clone()
		{
			return new PhBaPlanFindPlanResponse(this);
		}

		// Token: 0x17003BD4 RID: 15316
		// (get) Token: 0x060120E9 RID: 73961 RVA: 0x002A3D74 File Offset: 0x002A1F74
		// (set) Token: 0x060120EA RID: 73962 RVA: 0x002A3D7C File Offset: 0x002A1F7C
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

		// Token: 0x17003BD5 RID: 15317
		// (get) Token: 0x060120EB RID: 73963 RVA: 0x002A3D85 File Offset: 0x002A1F85
		// (set) Token: 0x060120EC RID: 73964 RVA: 0x002A3D8D File Offset: 0x002A1F8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaOneAllSuitPlan Plan
		{
			get
			{
				return this.plan_;
			}
			set
			{
				this.plan_ = value;
			}
		}

		// Token: 0x17003BD6 RID: 15318
		// (get) Token: 0x060120ED RID: 73965 RVA: 0x002A3D96 File Offset: 0x002A1F96
		// (set) Token: 0x060120EE RID: 73966 RVA: 0x002A3D9E File Offset: 0x002A1F9E
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

		// Token: 0x060120EF RID: 73967 RVA: 0x002A3DA7 File Offset: 0x002A1FA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanFindPlanResponse);
		}

		// Token: 0x060120F0 RID: 73968 RVA: 0x002A3DB8 File Offset: 0x002A1FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanFindPlanResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this.Plan, other.Plan) && this.TowPlanSame == other.TowPlanSame && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060120F1 RID: 73969 RVA: 0x002A3E18 File Offset: 0x002A2018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.plan_ != null)
			{
				num ^= this.Plan.GetHashCode();
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

		// Token: 0x060120F2 RID: 73970 RVA: 0x002A3E8C File Offset: 0x002A208C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060120F3 RID: 73971 RVA: 0x002A3E99 File Offset: 0x002A2099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060120F4 RID: 73972 RVA: 0x002A3EA4 File Offset: 0x002A20A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Code);
			}
			if (this.TowPlanSame)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.TowPlanSame);
			}
			if (this.plan_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Plan);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060120F5 RID: 73973 RVA: 0x002A3F1C File Offset: 0x002A211C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.plan_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Plan);
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

		// Token: 0x060120F6 RID: 73974 RVA: 0x002A3F80 File Offset: 0x002A2180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhBaPlanFindPlanResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.plan_ != null)
			{
				if (this.plan_ == null)
				{
					this.Plan = new PhBaOneAllSuitPlan();
				}
				this.Plan.MergeFrom(other.Plan);
			}
			if (other.TowPlanSame)
			{
				this.TowPlanSame = other.TowPlanSame;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060120F7 RID: 73975 RVA: 0x002A3FFC File Offset: 0x002A21FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060120F8 RID: 73976 RVA: 0x002A4008 File Offset: 0x002A2208
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
				if (num != 32U)
				{
					if (num != 72U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.plan_ == null)
							{
								this.Plan = new PhBaOneAllSuitPlan();
							}
							input.ReadMessage(this.Plan);
						}
					}
					else
					{
						this.TowPlanSame = input.ReadBool();
					}
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400715F RID: 29023
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007160 RID: 29024
		public const int CodeFieldNumber = 4;

		// Token: 0x04007161 RID: 29025
		private ErrorCode code_;

		// Token: 0x04007162 RID: 29026
		public const int PlanFieldNumber = 14;

		// Token: 0x04007163 RID: 29027
		private PhBaOneAllSuitPlan plan_;

		// Token: 0x04007164 RID: 29028
		public const int TowPlanSameFieldNumber = 9;

		// Token: 0x04007165 RID: 29029
		private bool towPlanSame_;
	}
}
