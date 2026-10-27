using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D12 RID: 3346
	public sealed class PhBaOneAllSuitPlan : IMessage<PhBaOneAllSuitPlan>, IMessage, IEquatable<PhBaOneAllSuitPlan>, IDeepCloneable<PhBaOneAllSuitPlan>, IBufferMessage
	{
		// Token: 0x0601213E RID: 74046 RVA: 0x002A44B8 File Offset: 0x002A26B8
		[NullableContext(1)]
		public static PhBaOneAllSuitPlan Create()
		{
			return new PhBaOneAllSuitPlan();
		}

		// Token: 0x17003BE5 RID: 15333
		// (get) Token: 0x0601213F RID: 74047 RVA: 0x002A44BF File Offset: 0x002A26BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BE6 RID: 15334
		// (get) Token: 0x06012140 RID: 74048 RVA: 0x002A44C2 File Offset: 0x002A26C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaOneAllSuitPlan.Descriptor;
			}
		}

		// Token: 0x06012141 RID: 74049 RVA: 0x002A44C9 File Offset: 0x002A26C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaOneAllSuitPlan()
		{
		}

		// Token: 0x06012142 RID: 74050 RVA: 0x002A44E7 File Offset: 0x002A26E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaOneAllSuitPlan(PhBaOneAllSuitPlan other) : this()
		{
			this.suitPlanList_ = other.suitPlanList_.Clone();
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012143 RID: 74051 RVA: 0x002A451D File Offset: 0x002A271D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaOneAllSuitPlan Clone()
		{
			return new PhBaOneAllSuitPlan(this);
		}

		// Token: 0x17003BE7 RID: 15335
		// (get) Token: 0x06012144 RID: 74052 RVA: 0x002A4525 File Offset: 0x002A2725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhBaOneSuitPlan> SuitPlanList
		{
			get
			{
				return this.suitPlanList_;
			}
		}

		// Token: 0x17003BE8 RID: 15336
		// (get) Token: 0x06012145 RID: 74053 RVA: 0x002A452D File Offset: 0x002A272D
		// (set) Token: 0x06012146 RID: 74054 RVA: 0x002A4535 File Offset: 0x002A2735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06012147 RID: 74055 RVA: 0x002A4548 File Offset: 0x002A2748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaOneAllSuitPlan);
		}

		// Token: 0x06012148 RID: 74056 RVA: 0x002A4558 File Offset: 0x002A2758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaOneAllSuitPlan other)
		{
			return other != null && (other == this || (this.suitPlanList_.Equals(other.suitPlanList_) && !(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012149 RID: 74057 RVA: 0x002A45AC File Offset: 0x002A27AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.suitPlanList_.GetHashCode();
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601214A RID: 74058 RVA: 0x002A45FB File Offset: 0x002A27FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601214B RID: 74059 RVA: 0x002A4608 File Offset: 0x002A2808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601214C RID: 74060 RVA: 0x002A4614 File Offset: 0x002A2814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.suitPlanList_.WriteTo(ref output, PhBaOneAllSuitPlan._repeated_suitPlanList_codec);
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601214D RID: 74061 RVA: 0x002A4668 File Offset: 0x002A2868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.suitPlanList_.CalculateSize(PhBaOneAllSuitPlan._repeated_suitPlanList_codec);
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601214E RID: 74062 RVA: 0x002A46C0 File Offset: 0x002A28C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhBaOneAllSuitPlan other)
		{
			if (other == null)
			{
				return;
			}
			this.suitPlanList_.Add(other.suitPlanList_);
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601214F RID: 74063 RVA: 0x002A4712 File Offset: 0x002A2912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012150 RID: 74064 RVA: 0x002A471C File Offset: 0x002A291C
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else
				{
					this.suitPlanList_.AddEntriesFrom(ref input, PhBaOneAllSuitPlan._repeated_suitPlanList_codec);
				}
			}
		}

		// Token: 0x0400711A RID: 28954
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400711B RID: 28955
		public const int SuitPlanListFieldNumber = 1;

		// Token: 0x0400711C RID: 28956
		private static readonly FieldCodec<PhBaOneSuitPlan> _repeated_suitPlanList_codec = FieldCodec.ForMessage<PhBaOneSuitPlan>(10U, PhBaOneSuitPlan.Parser);

		// Token: 0x0400711D RID: 28957
		private readonly RepeatedField<PhBaOneSuitPlan> suitPlanList_ = new RepeatedField<PhBaOneSuitPlan>();

		// Token: 0x0400711E RID: 28958
		public const int NameFieldNumber = 2;

		// Token: 0x0400711F RID: 28959
		private string name_ = "";
	}
}
