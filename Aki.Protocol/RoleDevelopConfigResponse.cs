using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001055 RID: 4181
	[NetMessage(EMessageId.RoleDevelopConfigResponse)]
	public sealed class RoleDevelopConfigResponse : IMessage<RoleDevelopConfigResponse>, IMessage, IEquatable<RoleDevelopConfigResponse>, IDeepCloneable<RoleDevelopConfigResponse>, IBufferMessage
	{
		// Token: 0x060165DB RID: 91611 RVA: 0x003408AD File Offset: 0x0033EAAD
		[NullableContext(1)]
		public static RoleDevelopConfigResponse Create()
		{
			return new RoleDevelopConfigResponse();
		}

		// Token: 0x17004AD9 RID: 19161
		// (get) Token: 0x060165DC RID: 91612 RVA: 0x003408B4 File Offset: 0x0033EAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004ADA RID: 19162
		// (get) Token: 0x060165DD RID: 91613 RVA: 0x003408B7 File Offset: 0x0033EAB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleDevelopConfigResponse.Descriptor;
			}
		}

		// Token: 0x060165DE RID: 91614 RVA: 0x003408BE File Offset: 0x0033EABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigResponse()
		{
		}

		// Token: 0x060165DF RID: 91615 RVA: 0x003408C8 File Offset: 0x0033EAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigResponse(RoleDevelopConfigResponse other) : this()
		{
			this.configs_ = ((other.configs_ != null) ? other.configs_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060165E0 RID: 91616 RVA: 0x00340914 File Offset: 0x0033EB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigResponse Clone()
		{
			return new RoleDevelopConfigResponse(this);
		}

		// Token: 0x17004ADB RID: 19163
		// (get) Token: 0x060165E1 RID: 91617 RVA: 0x0034091C File Offset: 0x0033EB1C
		// (set) Token: 0x060165E2 RID: 91618 RVA: 0x00340924 File Offset: 0x0033EB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigs Configs
		{
			get
			{
				return this.configs_;
			}
			set
			{
				this.configs_ = value;
			}
		}

		// Token: 0x17004ADC RID: 19164
		// (get) Token: 0x060165E3 RID: 91619 RVA: 0x0034092D File Offset: 0x0033EB2D
		// (set) Token: 0x060165E4 RID: 91620 RVA: 0x00340935 File Offset: 0x0033EB35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x060165E5 RID: 91621 RVA: 0x0034093E File Offset: 0x0033EB3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleDevelopConfigResponse);
		}

		// Token: 0x060165E6 RID: 91622 RVA: 0x0034094C File Offset: 0x0033EB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleDevelopConfigResponse other)
		{
			return other != null && (other == this || (object.Equals(this.Configs, other.Configs) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060165E7 RID: 91623 RVA: 0x0034099C File Offset: 0x0033EB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.configs_ != null)
			{
				num ^= this.Configs.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060165E8 RID: 91624 RVA: 0x003409F7 File Offset: 0x0033EBF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060165E9 RID: 91625 RVA: 0x00340A04 File Offset: 0x0033EC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060165EA RID: 91626 RVA: 0x00340A10 File Offset: 0x0033EC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.configs_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Configs);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060165EB RID: 91627 RVA: 0x00340A6C File Offset: 0x0033EC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.configs_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Configs);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060165EC RID: 91628 RVA: 0x00340AC4 File Offset: 0x0033ECC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleDevelopConfigResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.configs_ != null)
			{
				if (this.configs_ == null)
				{
					this.Configs = new RoleDevelopConfigs();
				}
				this.Configs.MergeFrom(other.Configs);
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060165ED RID: 91629 RVA: 0x00340B2C File Offset: 0x0033ED2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060165EE RID: 91630 RVA: 0x00340B38 File Offset: 0x0033ED38
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
				if (num != 18U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.configs_ == null)
					{
						this.Configs = new RoleDevelopConfigs();
					}
					input.ReadMessage(this.Configs);
				}
			}
		}

		// Token: 0x04008635 RID: 34357
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008636 RID: 34358
		public const int ConfigsFieldNumber = 2;

		// Token: 0x04008637 RID: 34359
		private RoleDevelopConfigs configs_;

		// Token: 0x04008638 RID: 34360
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04008639 RID: 34361
		private ErrorCode errorCode_;
	}
}
