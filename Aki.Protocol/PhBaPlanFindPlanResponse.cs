using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D1A RID: 3354
	[NetMessage(EMessageId.PhBaPlanFindPlanResponse)]
	public sealed class PhBaPlanFindPlanResponse : IMessage<PhBaPlanFindPlanResponse>, IMessage, IEquatable<PhBaPlanFindPlanResponse>, IDeepCloneable<PhBaPlanFindPlanResponse>, IBufferMessage
	{
		// Token: 0x060121DF RID: 74207 RVA: 0x002A591D File Offset: 0x002A3B1D
		[NullableContext(1)]
		public static PhBaPlanFindPlanResponse Create()
		{
			return new PhBaPlanFindPlanResponse();
		}

		// Token: 0x17003C07 RID: 15367
		// (get) Token: 0x060121E0 RID: 74208 RVA: 0x002A5924 File Offset: 0x002A3B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C08 RID: 15368
		// (get) Token: 0x060121E1 RID: 74209 RVA: 0x002A5927 File Offset: 0x002A3B27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanFindPlanResponse.Descriptor;
			}
		}

		// Token: 0x060121E2 RID: 74210 RVA: 0x002A592E File Offset: 0x002A3B2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanFindPlanResponse()
		{
		}

		// Token: 0x060121E3 RID: 74211 RVA: 0x002A5938 File Offset: 0x002A3B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanFindPlanResponse(PhBaPlanFindPlanResponse other) : this()
		{
			this.code_ = other.code_;
			this.plan_ = ((other.plan_ != null) ? other.plan_.Clone() : null);
			this.towPlanSame_ = other.towPlanSame_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060121E4 RID: 74212 RVA: 0x002A5990 File Offset: 0x002A3B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanFindPlanResponse Clone()
		{
			return new PhBaPlanFindPlanResponse(this);
		}

		// Token: 0x17003C09 RID: 15369
		// (get) Token: 0x060121E5 RID: 74213 RVA: 0x002A5998 File Offset: 0x002A3B98
		// (set) Token: 0x060121E6 RID: 74214 RVA: 0x002A59A0 File Offset: 0x002A3BA0
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

		// Token: 0x17003C0A RID: 15370
		// (get) Token: 0x060121E7 RID: 74215 RVA: 0x002A59A9 File Offset: 0x002A3BA9
		// (set) Token: 0x060121E8 RID: 74216 RVA: 0x002A59B1 File Offset: 0x002A3BB1
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

		// Token: 0x17003C0B RID: 15371
		// (get) Token: 0x060121E9 RID: 74217 RVA: 0x002A59BA File Offset: 0x002A3BBA
		// (set) Token: 0x060121EA RID: 74218 RVA: 0x002A59C2 File Offset: 0x002A3BC2
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

		// Token: 0x060121EB RID: 74219 RVA: 0x002A59CB File Offset: 0x002A3BCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanFindPlanResponse);
		}

		// Token: 0x060121EC RID: 74220 RVA: 0x002A59DC File Offset: 0x002A3BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanFindPlanResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this.Plan, other.Plan) && this.TowPlanSame == other.TowPlanSame && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060121ED RID: 74221 RVA: 0x002A5A3C File Offset: 0x002A3C3C
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

		// Token: 0x060121EE RID: 74222 RVA: 0x002A5AB0 File Offset: 0x002A3CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060121EF RID: 74223 RVA: 0x002A5ABD File Offset: 0x002A3CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060121F0 RID: 74224 RVA: 0x002A5AC8 File Offset: 0x002A3CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TowPlanSame)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.TowPlanSame);
			}
			if (this.plan_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Plan);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060121F1 RID: 74225 RVA: 0x002A5B40 File Offset: 0x002A3D40
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

		// Token: 0x060121F2 RID: 74226 RVA: 0x002A5BA4 File Offset: 0x002A3DA4
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

		// Token: 0x060121F3 RID: 74227 RVA: 0x002A5C20 File Offset: 0x002A3E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060121F4 RID: 74228 RVA: 0x002A5C2C File Offset: 0x002A3E2C
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
				if (num != 24U)
				{
					if (num != 106U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Code = (ErrorCode)input.ReadEnum();
						}
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
		}

		// Token: 0x04007147 RID: 28999
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007148 RID: 29000
		public const int CodeFieldNumber = 15;

		// Token: 0x04007149 RID: 29001
		private ErrorCode code_;

		// Token: 0x0400714A RID: 29002
		public const int PlanFieldNumber = 13;

		// Token: 0x0400714B RID: 29003
		private PhBaOneAllSuitPlan plan_;

		// Token: 0x0400714C RID: 29004
		public const int TowPlanSameFieldNumber = 3;

		// Token: 0x0400714D RID: 29005
		private bool towPlanSame_;
	}
}
