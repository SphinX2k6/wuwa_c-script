using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D13 RID: 3347
	[NetMessage(EMessageId.PhBaPlanUpdatePlanResponse)]
	public sealed class PhBaPlanUpdatePlanResponse : IMessage<PhBaPlanUpdatePlanResponse>, IMessage, IEquatable<PhBaPlanUpdatePlanResponse>, IDeepCloneable<PhBaPlanUpdatePlanResponse>, IBufferMessage
	{
		// Token: 0x06012191 RID: 74129 RVA: 0x002A521A File Offset: 0x002A341A
		[NullableContext(1)]
		public static PhBaPlanUpdatePlanResponse Create()
		{
			return new PhBaPlanUpdatePlanResponse();
		}

		// Token: 0x17003BF3 RID: 15347
		// (get) Token: 0x06012192 RID: 74130 RVA: 0x002A5221 File Offset: 0x002A3421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BF4 RID: 15348
		// (get) Token: 0x06012193 RID: 74131 RVA: 0x002A5224 File Offset: 0x002A3424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanUpdatePlanResponse.Descriptor;
			}
		}

		// Token: 0x06012194 RID: 74132 RVA: 0x002A522B File Offset: 0x002A342B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanUpdatePlanResponse()
		{
		}

		// Token: 0x06012195 RID: 74133 RVA: 0x002A523E File Offset: 0x002A343E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanUpdatePlanResponse(PhBaPlanUpdatePlanResponse other) : this()
		{
			this.code_ = other.code_;
			this.selfPlanCode_ = other.selfPlanCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012196 RID: 74134 RVA: 0x002A526F File Offset: 0x002A346F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanUpdatePlanResponse Clone()
		{
			return new PhBaPlanUpdatePlanResponse(this);
		}

		// Token: 0x17003BF5 RID: 15349
		// (get) Token: 0x06012197 RID: 74135 RVA: 0x002A5277 File Offset: 0x002A3477
		// (set) Token: 0x06012198 RID: 74136 RVA: 0x002A527F File Offset: 0x002A347F
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

		// Token: 0x17003BF6 RID: 15350
		// (get) Token: 0x06012199 RID: 74137 RVA: 0x002A5288 File Offset: 0x002A3488
		// (set) Token: 0x0601219A RID: 74138 RVA: 0x002A5290 File Offset: 0x002A3490
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

		// Token: 0x0601219B RID: 74139 RVA: 0x002A52A3 File Offset: 0x002A34A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanUpdatePlanResponse);
		}

		// Token: 0x0601219C RID: 74140 RVA: 0x002A52B4 File Offset: 0x002A34B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanUpdatePlanResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && !(this.SelfPlanCode != other.SelfPlanCode) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601219D RID: 74141 RVA: 0x002A5304 File Offset: 0x002A3504
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601219E RID: 74142 RVA: 0x002A5364 File Offset: 0x002A3564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601219F RID: 74143 RVA: 0x002A5371 File Offset: 0x002A3571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060121A0 RID: 74144 RVA: 0x002A537C File Offset: 0x002A357C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Code);
			}
			if (this.SelfPlanCode.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.SelfPlanCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060121A1 RID: 74145 RVA: 0x002A53DC File Offset: 0x002A35DC
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060121A2 RID: 74146 RVA: 0x002A5438 File Offset: 0x002A3638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhBaPlanUpdatePlanResponse other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060121A3 RID: 74147 RVA: 0x002A548D File Offset: 0x002A368D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060121A4 RID: 74148 RVA: 0x002A5498 File Offset: 0x002A3698
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
				if (num != 48U)
				{
					if (num != 58U)
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
		}

		// Token: 0x04007186 RID: 29062
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007187 RID: 29063
		public const int CodeFieldNumber = 6;

		// Token: 0x04007188 RID: 29064
		private ErrorCode code_;

		// Token: 0x04007189 RID: 29065
		public const int SelfPlanCodeFieldNumber = 7;

		// Token: 0x0400718A RID: 29066
		private string selfPlanCode_ = "";
	}
}
