using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D0B RID: 3339
	[NetMessage(EMessageId.PhBaPlanSaveUsePlanRequest)]
	public sealed class PhBaPlanSaveUsePlanRequest : IMessage<PhBaPlanSaveUsePlanRequest>, IMessage, IEquatable<PhBaPlanSaveUsePlanRequest>, IDeepCloneable<PhBaPlanSaveUsePlanRequest>, IBufferMessage
	{
		// Token: 0x060120F9 RID: 73977 RVA: 0x002A4086 File Offset: 0x002A2286
		[NullableContext(1)]
		public static PhBaPlanSaveUsePlanRequest Create()
		{
			return new PhBaPlanSaveUsePlanRequest();
		}

		// Token: 0x17003BD7 RID: 15319
		// (get) Token: 0x060120FA RID: 73978 RVA: 0x002A408D File Offset: 0x002A228D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BD8 RID: 15320
		// (get) Token: 0x060120FB RID: 73979 RVA: 0x002A4090 File Offset: 0x002A2290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanSaveUsePlanRequest.Descriptor;
			}
		}

		// Token: 0x060120FC RID: 73980 RVA: 0x002A4097 File Offset: 0x002A2297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSaveUsePlanRequest()
		{
		}

		// Token: 0x060120FD RID: 73981 RVA: 0x002A409F File Offset: 0x002A229F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSaveUsePlanRequest(PhBaPlanSaveUsePlanRequest other) : this()
		{
			this.usePlan_ = ((other.usePlan_ != null) ? other.usePlan_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060120FE RID: 73982 RVA: 0x002A40D4 File Offset: 0x002A22D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSaveUsePlanRequest Clone()
		{
			return new PhBaPlanSaveUsePlanRequest(this);
		}

		// Token: 0x17003BD9 RID: 15321
		// (get) Token: 0x060120FF RID: 73983 RVA: 0x002A40DC File Offset: 0x002A22DC
		// (set) Token: 0x06012100 RID: 73984 RVA: 0x002A40E4 File Offset: 0x002A22E4
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

		// Token: 0x06012101 RID: 73985 RVA: 0x002A40ED File Offset: 0x002A22ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanSaveUsePlanRequest);
		}

		// Token: 0x06012102 RID: 73986 RVA: 0x002A40FB File Offset: 0x002A22FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanSaveUsePlanRequest other)
		{
			return other != null && (other == this || (object.Equals(this.UsePlan, other.UsePlan) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012103 RID: 73987 RVA: 0x002A4130 File Offset: 0x002A2330
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

		// Token: 0x06012104 RID: 73988 RVA: 0x002A416C File Offset: 0x002A236C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012105 RID: 73989 RVA: 0x002A4179 File Offset: 0x002A2379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012106 RID: 73990 RVA: 0x002A4182 File Offset: 0x002A2382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.usePlan_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.UsePlan);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012107 RID: 73991 RVA: 0x002A41B4 File Offset: 0x002A23B4
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

		// Token: 0x06012108 RID: 73992 RVA: 0x002A41F4 File Offset: 0x002A23F4
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

		// Token: 0x06012109 RID: 73993 RVA: 0x002A4248 File Offset: 0x002A2448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601210A RID: 73994 RVA: 0x002A4254 File Offset: 0x002A2454
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
				if (num != 106U)
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

		// Token: 0x04007166 RID: 29030
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007167 RID: 29031
		public const int UsePlanFieldNumber = 13;

		// Token: 0x04007168 RID: 29032
		private PhBaOneAllSuitPlan usePlan_;
	}
}
