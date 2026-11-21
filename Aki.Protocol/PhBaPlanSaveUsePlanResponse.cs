using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D0C RID: 3340
	[NetMessage(EMessageId.PhBaPlanSaveUsePlanResponse)]
	public sealed class PhBaPlanSaveUsePlanResponse : IMessage<PhBaPlanSaveUsePlanResponse>, IMessage, IEquatable<PhBaPlanSaveUsePlanResponse>, IDeepCloneable<PhBaPlanSaveUsePlanResponse>, IBufferMessage
	{
		// Token: 0x0601210B RID: 73995 RVA: 0x002A42AC File Offset: 0x002A24AC
		[NullableContext(1)]
		public static PhBaPlanSaveUsePlanResponse Create()
		{
			return new PhBaPlanSaveUsePlanResponse();
		}

		// Token: 0x17003BDA RID: 15322
		// (get) Token: 0x0601210C RID: 73996 RVA: 0x002A42B3 File Offset: 0x002A24B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BDB RID: 15323
		// (get) Token: 0x0601210D RID: 73997 RVA: 0x002A42B6 File Offset: 0x002A24B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanSaveUsePlanResponse.Descriptor;
			}
		}

		// Token: 0x0601210E RID: 73998 RVA: 0x002A42BD File Offset: 0x002A24BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSaveUsePlanResponse()
		{
		}

		// Token: 0x0601210F RID: 73999 RVA: 0x002A42D0 File Offset: 0x002A24D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSaveUsePlanResponse(PhBaPlanSaveUsePlanResponse other) : this()
		{
			this.code_ = other.code_;
			this.selfPlanCode_ = other.selfPlanCode_;
			this.towPlanSame_ = other.towPlanSame_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012110 RID: 74000 RVA: 0x002A430D File Offset: 0x002A250D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSaveUsePlanResponse Clone()
		{
			return new PhBaPlanSaveUsePlanResponse(this);
		}

		// Token: 0x17003BDC RID: 15324
		// (get) Token: 0x06012111 RID: 74001 RVA: 0x002A4315 File Offset: 0x002A2515
		// (set) Token: 0x06012112 RID: 74002 RVA: 0x002A431D File Offset: 0x002A251D
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

		// Token: 0x17003BDD RID: 15325
		// (get) Token: 0x06012113 RID: 74003 RVA: 0x002A4326 File Offset: 0x002A2526
		// (set) Token: 0x06012114 RID: 74004 RVA: 0x002A432E File Offset: 0x002A252E
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

		// Token: 0x17003BDE RID: 15326
		// (get) Token: 0x06012115 RID: 74005 RVA: 0x002A4341 File Offset: 0x002A2541
		// (set) Token: 0x06012116 RID: 74006 RVA: 0x002A4349 File Offset: 0x002A2549
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

		// Token: 0x06012117 RID: 74007 RVA: 0x002A4352 File Offset: 0x002A2552
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanSaveUsePlanResponse);
		}

		// Token: 0x06012118 RID: 74008 RVA: 0x002A4360 File Offset: 0x002A2560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanSaveUsePlanResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && !(this.SelfPlanCode != other.SelfPlanCode) && this.TowPlanSame == other.TowPlanSame && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012119 RID: 74009 RVA: 0x002A43C0 File Offset: 0x002A25C0
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

		// Token: 0x0601211A RID: 74010 RVA: 0x002A4439 File Offset: 0x002A2639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601211B RID: 74011 RVA: 0x002A4446 File Offset: 0x002A2646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601211C RID: 74012 RVA: 0x002A4450 File Offset: 0x002A2650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TowPlanSame)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.TowPlanSame);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Code);
			}
			if (this.SelfPlanCode.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.SelfPlanCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601211D RID: 74013 RVA: 0x002A44CC File Offset: 0x002A26CC
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

		// Token: 0x0601211E RID: 74014 RVA: 0x002A4534 File Offset: 0x002A2734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhBaPlanSaveUsePlanResponse other)
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
			if (other.TowPlanSame)
			{
				this.TowPlanSame = other.TowPlanSame;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601211F RID: 74015 RVA: 0x002A459D File Offset: 0x002A279D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012120 RID: 74016 RVA: 0x002A45A8 File Offset: 0x002A27A8
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
				if (num != 8U)
				{
					if (num != 40U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SelfPlanCode = input.ReadString();
						}
					}
					else
					{
						this.Code = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.TowPlanSame = input.ReadBool();
				}
			}
		}

		// Token: 0x04007169 RID: 29033
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400716A RID: 29034
		public const int CodeFieldNumber = 5;

		// Token: 0x0400716B RID: 29035
		private ErrorCode code_;

		// Token: 0x0400716C RID: 29036
		public const int SelfPlanCodeFieldNumber = 15;

		// Token: 0x0400716D RID: 29037
		private string selfPlanCode_ = "";

		// Token: 0x0400716E RID: 29038
		public const int TowPlanSameFieldNumber = 1;

		// Token: 0x0400716F RID: 29039
		private bool towPlanSame_;
	}
}
