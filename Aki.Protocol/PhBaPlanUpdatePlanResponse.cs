using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D23 RID: 3363
	[NetMessage(EMessageId.PhBaPlanUpdatePlanResponse)]
	public sealed class PhBaPlanUpdatePlanResponse : IMessage<PhBaPlanUpdatePlanResponse>, IMessage, IEquatable<PhBaPlanUpdatePlanResponse>, IDeepCloneable<PhBaPlanUpdatePlanResponse>, IBufferMessage
	{
		// Token: 0x0601228D RID: 74381 RVA: 0x002A6E3E File Offset: 0x002A503E
		[NullableContext(1)]
		public static PhBaPlanUpdatePlanResponse Create()
		{
			return new PhBaPlanUpdatePlanResponse();
		}

		// Token: 0x17003C28 RID: 15400
		// (get) Token: 0x0601228E RID: 74382 RVA: 0x002A6E45 File Offset: 0x002A5045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C29 RID: 15401
		// (get) Token: 0x0601228F RID: 74383 RVA: 0x002A6E48 File Offset: 0x002A5048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanUpdatePlanResponse.Descriptor;
			}
		}

		// Token: 0x06012290 RID: 74384 RVA: 0x002A6E4F File Offset: 0x002A504F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanUpdatePlanResponse()
		{
		}

		// Token: 0x06012291 RID: 74385 RVA: 0x002A6E62 File Offset: 0x002A5062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanUpdatePlanResponse(PhBaPlanUpdatePlanResponse other) : this()
		{
			this.code_ = other.code_;
			this.selfPlanCode_ = other.selfPlanCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012292 RID: 74386 RVA: 0x002A6E93 File Offset: 0x002A5093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanUpdatePlanResponse Clone()
		{
			return new PhBaPlanUpdatePlanResponse(this);
		}

		// Token: 0x17003C2A RID: 15402
		// (get) Token: 0x06012293 RID: 74387 RVA: 0x002A6E9B File Offset: 0x002A509B
		// (set) Token: 0x06012294 RID: 74388 RVA: 0x002A6EA3 File Offset: 0x002A50A3
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

		// Token: 0x17003C2B RID: 15403
		// (get) Token: 0x06012295 RID: 74389 RVA: 0x002A6EAC File Offset: 0x002A50AC
		// (set) Token: 0x06012296 RID: 74390 RVA: 0x002A6EB4 File Offset: 0x002A50B4
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

		// Token: 0x06012297 RID: 74391 RVA: 0x002A6EC7 File Offset: 0x002A50C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanUpdatePlanResponse);
		}

		// Token: 0x06012298 RID: 74392 RVA: 0x002A6ED8 File Offset: 0x002A50D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanUpdatePlanResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && !(this.SelfPlanCode != other.SelfPlanCode) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012299 RID: 74393 RVA: 0x002A6F28 File Offset: 0x002A5128
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

		// Token: 0x0601229A RID: 74394 RVA: 0x002A6F88 File Offset: 0x002A5188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601229B RID: 74395 RVA: 0x002A6F95 File Offset: 0x002A5195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601229C RID: 74396 RVA: 0x002A6FA0 File Offset: 0x002A51A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Code);
			}
			if (this.SelfPlanCode.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.SelfPlanCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601229D RID: 74397 RVA: 0x002A7000 File Offset: 0x002A5200
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

		// Token: 0x0601229E RID: 74398 RVA: 0x002A705C File Offset: 0x002A525C
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

		// Token: 0x0601229F RID: 74399 RVA: 0x002A70B1 File Offset: 0x002A52B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060122A0 RID: 74400 RVA: 0x002A70BC File Offset: 0x002A52BC
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
				if (num != 56U)
				{
					if (num != 82U)
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

		// Token: 0x0400716E RID: 29038
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400716F RID: 29039
		public const int CodeFieldNumber = 7;

		// Token: 0x04007170 RID: 29040
		private ErrorCode code_;

		// Token: 0x04007171 RID: 29041
		public const int SelfPlanCodeFieldNumber = 10;

		// Token: 0x04007172 RID: 29042
		private string selfPlanCode_ = "";
	}
}
