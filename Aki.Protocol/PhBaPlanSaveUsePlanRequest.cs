using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D1B RID: 3355
	[NetMessage(EMessageId.PhBaPlanSaveUsePlanRequest)]
	public sealed class PhBaPlanSaveUsePlanRequest : IMessage<PhBaPlanSaveUsePlanRequest>, IMessage, IEquatable<PhBaPlanSaveUsePlanRequest>, IDeepCloneable<PhBaPlanSaveUsePlanRequest>, IBufferMessage
	{
		// Token: 0x060121F5 RID: 74229 RVA: 0x002A5CAA File Offset: 0x002A3EAA
		[NullableContext(1)]
		public static PhBaPlanSaveUsePlanRequest Create()
		{
			return new PhBaPlanSaveUsePlanRequest();
		}

		// Token: 0x17003C0C RID: 15372
		// (get) Token: 0x060121F6 RID: 74230 RVA: 0x002A5CB1 File Offset: 0x002A3EB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C0D RID: 15373
		// (get) Token: 0x060121F7 RID: 74231 RVA: 0x002A5CB4 File Offset: 0x002A3EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanSaveUsePlanRequest.Descriptor;
			}
		}

		// Token: 0x060121F8 RID: 74232 RVA: 0x002A5CBB File Offset: 0x002A3EBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSaveUsePlanRequest()
		{
		}

		// Token: 0x060121F9 RID: 74233 RVA: 0x002A5CC3 File Offset: 0x002A3EC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSaveUsePlanRequest(PhBaPlanSaveUsePlanRequest other) : this()
		{
			this.usePlan_ = ((other.usePlan_ != null) ? other.usePlan_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060121FA RID: 74234 RVA: 0x002A5CF8 File Offset: 0x002A3EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSaveUsePlanRequest Clone()
		{
			return new PhBaPlanSaveUsePlanRequest(this);
		}

		// Token: 0x17003C0E RID: 15374
		// (get) Token: 0x060121FB RID: 74235 RVA: 0x002A5D00 File Offset: 0x002A3F00
		// (set) Token: 0x060121FC RID: 74236 RVA: 0x002A5D08 File Offset: 0x002A3F08
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

		// Token: 0x060121FD RID: 74237 RVA: 0x002A5D11 File Offset: 0x002A3F11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanSaveUsePlanRequest);
		}

		// Token: 0x060121FE RID: 74238 RVA: 0x002A5D1F File Offset: 0x002A3F1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanSaveUsePlanRequest other)
		{
			return other != null && (other == this || (object.Equals(this.UsePlan, other.UsePlan) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060121FF RID: 74239 RVA: 0x002A5D54 File Offset: 0x002A3F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.usePlan_ != null)
			{
				num ^= this.UsePlan.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012200 RID: 74240 RVA: 0x002A5D90 File Offset: 0x002A3F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012201 RID: 74241 RVA: 0x002A5D9D File Offset: 0x002A3F9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012202 RID: 74242 RVA: 0x002A5DA6 File Offset: 0x002A3FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.usePlan_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.UsePlan);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012203 RID: 74243 RVA: 0x002A5DD8 File Offset: 0x002A3FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.usePlan_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UsePlan);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012204 RID: 74244 RVA: 0x002A5E18 File Offset: 0x002A4018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhBaPlanSaveUsePlanRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.usePlan_ != null)
			{
				if (this.usePlan_ == null)
				{
					this.UsePlan = new PhBaOneAllSuitPlan();
				}
				this.UsePlan.MergeFrom(other.UsePlan);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012205 RID: 74245 RVA: 0x002A5E6C File Offset: 0x002A406C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012206 RID: 74246 RVA: 0x002A5E78 File Offset: 0x002A4078
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.usePlan_ == null)
					{
						this.UsePlan = new PhBaOneAllSuitPlan();
					}
					input.ReadMessage(this.UsePlan);
				}
			}
		}

		// Token: 0x0400714E RID: 29006
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400714F RID: 29007
		public const int UsePlanFieldNumber = 4;

		// Token: 0x04007150 RID: 29008
		private PhBaOneAllSuitPlan usePlan_;
	}
}
