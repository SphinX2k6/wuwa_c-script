using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D02 RID: 3330
	public sealed class PhBaOneAllSuitPlan : IMessage<PhBaOneAllSuitPlan>, IMessage, IEquatable<PhBaOneAllSuitPlan>, IDeepCloneable<PhBaOneAllSuitPlan>, IBufferMessage
	{
		// Token: 0x06012042 RID: 73794 RVA: 0x002A2894 File Offset: 0x002A0A94
		[NullableContext(1)]
		public static PhBaOneAllSuitPlan Create()
		{
			return new PhBaOneAllSuitPlan();
		}

		// Token: 0x17003BB0 RID: 15280
		// (get) Token: 0x06012043 RID: 73795 RVA: 0x002A289B File Offset: 0x002A0A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BB1 RID: 15281
		// (get) Token: 0x06012044 RID: 73796 RVA: 0x002A289E File Offset: 0x002A0A9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaOneAllSuitPlan.Descriptor;
			}
		}

		// Token: 0x06012045 RID: 73797 RVA: 0x002A28A5 File Offset: 0x002A0AA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaOneAllSuitPlan()
		{
		}

		// Token: 0x06012046 RID: 73798 RVA: 0x002A28C3 File Offset: 0x002A0AC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaOneAllSuitPlan(PhBaOneAllSuitPlan other) : this()
		{
			this.suitPlanList_ = other.suitPlanList_.Clone();
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012047 RID: 73799 RVA: 0x002A28F9 File Offset: 0x002A0AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaOneAllSuitPlan Clone()
		{
			return new PhBaOneAllSuitPlan(this);
		}

		// Token: 0x17003BB2 RID: 15282
		// (get) Token: 0x06012048 RID: 73800 RVA: 0x002A2901 File Offset: 0x002A0B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhBaOneSuitPlan> SuitPlanList
		{
			get
			{
				return this.suitPlanList_;
			}
		}

		// Token: 0x17003BB3 RID: 15283
		// (get) Token: 0x06012049 RID: 73801 RVA: 0x002A2909 File Offset: 0x002A0B09
		// (set) Token: 0x0601204A RID: 73802 RVA: 0x002A2911 File Offset: 0x002A0B11
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

		// Token: 0x0601204B RID: 73803 RVA: 0x002A2924 File Offset: 0x002A0B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaOneAllSuitPlan);
		}

		// Token: 0x0601204C RID: 73804 RVA: 0x002A2934 File Offset: 0x002A0B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaOneAllSuitPlan other)
		{
			return other != null && (other == this || (this.suitPlanList_.Equals(other.suitPlanList_) && !(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601204D RID: 73805 RVA: 0x002A2988 File Offset: 0x002A0B88
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

		// Token: 0x0601204E RID: 73806 RVA: 0x002A29D7 File Offset: 0x002A0BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601204F RID: 73807 RVA: 0x002A29E4 File Offset: 0x002A0BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012050 RID: 73808 RVA: 0x002A29F0 File Offset: 0x002A0BF0
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

		// Token: 0x06012051 RID: 73809 RVA: 0x002A2A44 File Offset: 0x002A0C44
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

		// Token: 0x06012052 RID: 73810 RVA: 0x002A2A9C File Offset: 0x002A0C9C
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

		// Token: 0x06012053 RID: 73811 RVA: 0x002A2AEE File Offset: 0x002A0CEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012054 RID: 73812 RVA: 0x002A2AF8 File Offset: 0x002A0CF8
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

		// Token: 0x04007132 RID: 28978
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007133 RID: 28979
		public const int SuitPlanListFieldNumber = 1;

		// Token: 0x04007134 RID: 28980
		private static readonly FieldCodec<PhBaOneSuitPlan> _repeated_suitPlanList_codec = FieldCodec.ForMessage<PhBaOneSuitPlan>(10U, PhBaOneSuitPlan.Parser);

		// Token: 0x04007135 RID: 28981
		private readonly RepeatedField<PhBaOneSuitPlan> suitPlanList_ = new RepeatedField<PhBaOneSuitPlan>();

		// Token: 0x04007136 RID: 28982
		public const int NameFieldNumber = 2;

		// Token: 0x04007137 RID: 28983
		private string name_ = "";
	}
}
