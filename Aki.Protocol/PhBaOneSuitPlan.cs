using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D04 RID: 3332
	public sealed class PhBaOneSuitPlan : IMessage<PhBaOneSuitPlan>, IMessage, IEquatable<PhBaOneSuitPlan>, IDeepCloneable<PhBaOneSuitPlan>, IBufferMessage
	{
		// Token: 0x0601206B RID: 73835 RVA: 0x002A2E39 File Offset: 0x002A1039
		[NullableContext(1)]
		public static PhBaOneSuitPlan Create()
		{
			return new PhBaOneSuitPlan();
		}

		// Token: 0x17003BB9 RID: 15289
		// (get) Token: 0x0601206C RID: 73836 RVA: 0x002A2E40 File Offset: 0x002A1040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhBaOneSuitPlan> Parser
		{
			get
			{
				return PhBaOneSuitPlan._parser;
			}
		}

		// Token: 0x17003BBA RID: 15290
		// (get) Token: 0x0601206D RID: 73837 RVA: 0x002A2E47 File Offset: 0x002A1047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BBB RID: 15291
		// (get) Token: 0x0601206E RID: 73838 RVA: 0x002A2E4A File Offset: 0x002A104A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaOneSuitPlan.Descriptor;
			}
		}

		// Token: 0x0601206F RID: 73839 RVA: 0x002A2E51 File Offset: 0x002A1051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaOneSuitPlan()
		{
		}

		// Token: 0x06012070 RID: 73840 RVA: 0x002A2E64 File Offset: 0x002A1064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaOneSuitPlan(PhBaOneSuitPlan other) : this()
		{
			this.suitId_ = other.suitId_;
			this.oneCostList_ = other.oneCostList_.Clone();
			this.isOpen_ = other.isOpen_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012071 RID: 73841 RVA: 0x002A2EB1 File Offset: 0x002A10B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaOneSuitPlan Clone()
		{
			return new PhBaOneSuitPlan(this);
		}

		// Token: 0x17003BBC RID: 15292
		// (get) Token: 0x06012072 RID: 73842 RVA: 0x002A2EB9 File Offset: 0x002A10B9
		// (set) Token: 0x06012073 RID: 73843 RVA: 0x002A2EC1 File Offset: 0x002A10C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SuitId
		{
			get
			{
				return this.suitId_;
			}
			set
			{
				this.suitId_ = value;
			}
		}

		// Token: 0x17003BBD RID: 15293
		// (get) Token: 0x06012074 RID: 73844 RVA: 0x002A2ECA File Offset: 0x002A10CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhBaOneCostPlan> OneCostList
		{
			get
			{
				return this.oneCostList_;
			}
		}

		// Token: 0x17003BBE RID: 15294
		// (get) Token: 0x06012075 RID: 73845 RVA: 0x002A2ED2 File Offset: 0x002A10D2
		// (set) Token: 0x06012076 RID: 73846 RVA: 0x002A2EDA File Offset: 0x002A10DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsOpen
		{
			get
			{
				return this.isOpen_;
			}
			set
			{
				this.isOpen_ = value;
			}
		}

		// Token: 0x06012077 RID: 73847 RVA: 0x002A2EE3 File Offset: 0x002A10E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaOneSuitPlan);
		}

		// Token: 0x06012078 RID: 73848 RVA: 0x002A2EF4 File Offset: 0x002A10F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaOneSuitPlan other)
		{
			return other != null && (other == this || (this.SuitId == other.SuitId && this.oneCostList_.Equals(other.oneCostList_) && this.IsOpen == other.IsOpen && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012079 RID: 73849 RVA: 0x002A2F54 File Offset: 0x002A1154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SuitId != 0)
			{
				num ^= this.SuitId.GetHashCode();
			}
			num ^= this.oneCostList_.GetHashCode();
			if (this.IsOpen)
			{
				num ^= this.IsOpen.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601207A RID: 73850 RVA: 0x002A2FBA File Offset: 0x002A11BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601207B RID: 73851 RVA: 0x002A2FC7 File Offset: 0x002A11C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601207C RID: 73852 RVA: 0x002A2FD0 File Offset: 0x002A11D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SuitId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SuitId);
			}
			this.oneCostList_.WriteTo(ref output, PhBaOneSuitPlan._repeated_oneCostList_codec);
			if (this.IsOpen)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsOpen);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601207D RID: 73853 RVA: 0x002A303C File Offset: 0x002A123C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SuitId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SuitId);
			}
			num += this.oneCostList_.CalculateSize(PhBaOneSuitPlan._repeated_oneCostList_codec);
			if (this.IsOpen)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601207E RID: 73854 RVA: 0x002A309C File Offset: 0x002A129C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhBaOneSuitPlan other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SuitId != 0)
			{
				this.SuitId = other.SuitId;
			}
			this.oneCostList_.Add(other.oneCostList_);
			if (other.IsOpen)
			{
				this.IsOpen = other.IsOpen;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601207F RID: 73855 RVA: 0x002A30FD File Offset: 0x002A12FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012080 RID: 73856 RVA: 0x002A3108 File Offset: 0x002A1308
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
					if (num != 18U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsOpen = input.ReadBool();
						}
					}
					else
					{
						this.oneCostList_.AddEntriesFrom(ref input, PhBaOneSuitPlan._repeated_oneCostList_codec);
					}
				}
				else
				{
					this.SuitId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400713F RID: 28991
		private static readonly MessageParser<PhBaOneSuitPlan> _parser = new MessageParser<PhBaOneSuitPlan>(() => new PhBaOneSuitPlan());

		// Token: 0x04007140 RID: 28992
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007141 RID: 28993
		public const int SuitIdFieldNumber = 1;

		// Token: 0x04007142 RID: 28994
		private int suitId_;

		// Token: 0x04007143 RID: 28995
		public const int OneCostListFieldNumber = 2;

		// Token: 0x04007144 RID: 28996
		private static readonly FieldCodec<PhBaOneCostPlan> _repeated_oneCostList_codec = FieldCodec.ForMessage<PhBaOneCostPlan>(18U, PhBaOneCostPlan.Parser);

		// Token: 0x04007145 RID: 28997
		private readonly RepeatedField<PhBaOneCostPlan> oneCostList_ = new RepeatedField<PhBaOneCostPlan>();

		// Token: 0x04007146 RID: 28998
		public const int IsOpenFieldNumber = 3;

		// Token: 0x04007147 RID: 28999
		private bool isOpen_;
	}
}
