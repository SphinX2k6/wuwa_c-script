using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D1C RID: 3356
	[NetMessage(EMessageId.PhBaPlanSaveUsePlanResponse)]
	public sealed class PhBaPlanSaveUsePlanResponse : IMessage<PhBaPlanSaveUsePlanResponse>, IMessage, IEquatable<PhBaPlanSaveUsePlanResponse>, IDeepCloneable<PhBaPlanSaveUsePlanResponse>, IBufferMessage
	{
		// Token: 0x06012207 RID: 74247 RVA: 0x002A5ED0 File Offset: 0x002A40D0
		[NullableContext(1)]
		public static PhBaPlanSaveUsePlanResponse Create()
		{
			return new PhBaPlanSaveUsePlanResponse();
		}

		// Token: 0x17003C0F RID: 15375
		// (get) Token: 0x06012208 RID: 74248 RVA: 0x002A5ED7 File Offset: 0x002A40D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C10 RID: 15376
		// (get) Token: 0x06012209 RID: 74249 RVA: 0x002A5EDA File Offset: 0x002A40DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanSaveUsePlanResponse.Descriptor;
			}
		}

		// Token: 0x0601220A RID: 74250 RVA: 0x002A5EE1 File Offset: 0x002A40E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSaveUsePlanResponse()
		{
		}

		// Token: 0x0601220B RID: 74251 RVA: 0x002A5EF4 File Offset: 0x002A40F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSaveUsePlanResponse(PhBaPlanSaveUsePlanResponse other) : this()
		{
			this.code_ = other.code_;
			this.selfPlanCode_ = other.selfPlanCode_;
			this.towPlanSame_ = other.towPlanSame_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601220C RID: 74252 RVA: 0x002A5F31 File Offset: 0x002A4131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSaveUsePlanResponse Clone()
		{
			return new PhBaPlanSaveUsePlanResponse(this);
		}

		// Token: 0x17003C11 RID: 15377
		// (get) Token: 0x0601220D RID: 74253 RVA: 0x002A5F39 File Offset: 0x002A4139
		// (set) Token: 0x0601220E RID: 74254 RVA: 0x002A5F41 File Offset: 0x002A4141
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

		// Token: 0x17003C12 RID: 15378
		// (get) Token: 0x0601220F RID: 74255 RVA: 0x002A5F4A File Offset: 0x002A414A
		// (set) Token: 0x06012210 RID: 74256 RVA: 0x002A5F52 File Offset: 0x002A4152
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

		// Token: 0x17003C13 RID: 15379
		// (get) Token: 0x06012211 RID: 74257 RVA: 0x002A5F65 File Offset: 0x002A4165
		// (set) Token: 0x06012212 RID: 74258 RVA: 0x002A5F6D File Offset: 0x002A416D
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

		// Token: 0x06012213 RID: 74259 RVA: 0x002A5F76 File Offset: 0x002A4176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanSaveUsePlanResponse);
		}

		// Token: 0x06012214 RID: 74260 RVA: 0x002A5F84 File Offset: 0x002A4184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanSaveUsePlanResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && !(this.SelfPlanCode != other.SelfPlanCode) && this.TowPlanSame == other.TowPlanSame && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012215 RID: 74261 RVA: 0x002A5FE4 File Offset: 0x002A41E4
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

		// Token: 0x06012216 RID: 74262 RVA: 0x002A605D File Offset: 0x002A425D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012217 RID: 74263 RVA: 0x002A606A File Offset: 0x002A426A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012218 RID: 74264 RVA: 0x002A6074 File Offset: 0x002A4274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Code);
			}
			if (this.SelfPlanCode.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.SelfPlanCode);
			}
			if (this.TowPlanSame)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.TowPlanSame);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012219 RID: 74265 RVA: 0x002A60F0 File Offset: 0x002A42F0
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

		// Token: 0x0601221A RID: 74266 RVA: 0x002A6158 File Offset: 0x002A4358
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

		// Token: 0x0601221B RID: 74267 RVA: 0x002A61C1 File Offset: 0x002A43C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601221C RID: 74268 RVA: 0x002A61CC File Offset: 0x002A43CC
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
				if (num != 64U)
				{
					if (num != 98U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TowPlanSame = input.ReadBool();
						}
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
		}

		// Token: 0x04007151 RID: 29009
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007152 RID: 29010
		public const int CodeFieldNumber = 8;

		// Token: 0x04007153 RID: 29011
		private ErrorCode code_;

		// Token: 0x04007154 RID: 29012
		public const int SelfPlanCodeFieldNumber = 12;

		// Token: 0x04007155 RID: 29013
		private string selfPlanCode_ = "";

		// Token: 0x04007156 RID: 29014
		public const int TowPlanSameFieldNumber = 13;

		// Token: 0x04007157 RID: 29015
		private bool towPlanSame_;
	}
}
