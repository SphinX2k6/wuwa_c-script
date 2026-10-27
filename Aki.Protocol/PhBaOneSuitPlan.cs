using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D14 RID: 3348
	public sealed class PhBaOneSuitPlan : IMessage<PhBaOneSuitPlan>, IMessage, IEquatable<PhBaOneSuitPlan>, IDeepCloneable<PhBaOneSuitPlan>, IBufferMessage
	{
		// Token: 0x06012167 RID: 74087 RVA: 0x002A4A5D File Offset: 0x002A2C5D
		[NullableContext(1)]
		public static PhBaOneSuitPlan Create()
		{
			return new PhBaOneSuitPlan();
		}

		// Token: 0x17003BEE RID: 15342
		// (get) Token: 0x06012168 RID: 74088 RVA: 0x002A4A64 File Offset: 0x002A2C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhBaOneSuitPlan> Parser
		{
			get
			{
				return PhBaOneSuitPlan._parser;
			}
		}

		// Token: 0x17003BEF RID: 15343
		// (get) Token: 0x06012169 RID: 74089 RVA: 0x002A4A6B File Offset: 0x002A2C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BF0 RID: 15344
		// (get) Token: 0x0601216A RID: 74090 RVA: 0x002A4A6E File Offset: 0x002A2C6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaOneSuitPlan.Descriptor;
			}
		}

		// Token: 0x0601216B RID: 74091 RVA: 0x002A4A75 File Offset: 0x002A2C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaOneSuitPlan()
		{
		}

		// Token: 0x0601216C RID: 74092 RVA: 0x002A4A88 File Offset: 0x002A2C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaOneSuitPlan(PhBaOneSuitPlan other) : this()
		{
			this.suitId_ = other.suitId_;
			this.oneCostList_ = other.oneCostList_.Clone();
			this.isOpen_ = other.isOpen_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601216D RID: 74093 RVA: 0x002A4AD5 File Offset: 0x002A2CD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaOneSuitPlan Clone()
		{
			return new PhBaOneSuitPlan(this);
		}

		// Token: 0x17003BF1 RID: 15345
		// (get) Token: 0x0601216E RID: 74094 RVA: 0x002A4ADD File Offset: 0x002A2CDD
		// (set) Token: 0x0601216F RID: 74095 RVA: 0x002A4AE5 File Offset: 0x002A2CE5
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

		// Token: 0x17003BF2 RID: 15346
		// (get) Token: 0x06012170 RID: 74096 RVA: 0x002A4AEE File Offset: 0x002A2CEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhBaOneCostPlan> OneCostList
		{
			get
			{
				return this.oneCostList_;
			}
		}

		// Token: 0x17003BF3 RID: 15347
		// (get) Token: 0x06012171 RID: 74097 RVA: 0x002A4AF6 File Offset: 0x002A2CF6
		// (set) Token: 0x06012172 RID: 74098 RVA: 0x002A4AFE File Offset: 0x002A2CFE
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

		// Token: 0x06012173 RID: 74099 RVA: 0x002A4B07 File Offset: 0x002A2D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaOneSuitPlan);
		}

		// Token: 0x06012174 RID: 74100 RVA: 0x002A4B18 File Offset: 0x002A2D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaOneSuitPlan other)
		{
			return other != null && (other == this || (this.SuitId == other.SuitId && this.oneCostList_.Equals(other.oneCostList_) && this.IsOpen == other.IsOpen && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012175 RID: 74101 RVA: 0x002A4B78 File Offset: 0x002A2D78
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

		// Token: 0x06012176 RID: 74102 RVA: 0x002A4BDE File Offset: 0x002A2DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012177 RID: 74103 RVA: 0x002A4BEB File Offset: 0x002A2DEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012178 RID: 74104 RVA: 0x002A4BF4 File Offset: 0x002A2DF4
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

		// Token: 0x06012179 RID: 74105 RVA: 0x002A4C60 File Offset: 0x002A2E60
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

		// Token: 0x0601217A RID: 74106 RVA: 0x002A4CC0 File Offset: 0x002A2EC0
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

		// Token: 0x0601217B RID: 74107 RVA: 0x002A4D21 File Offset: 0x002A2F21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601217C RID: 74108 RVA: 0x002A4D2C File Offset: 0x002A2F2C
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

		// Token: 0x04007127 RID: 28967
		private static readonly MessageParser<PhBaOneSuitPlan> _parser = new MessageParser<PhBaOneSuitPlan>(() => new PhBaOneSuitPlan());

		// Token: 0x04007128 RID: 28968
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007129 RID: 28969
		public const int SuitIdFieldNumber = 1;

		// Token: 0x0400712A RID: 28970
		private int suitId_;

		// Token: 0x0400712B RID: 28971
		public const int OneCostListFieldNumber = 2;

		// Token: 0x0400712C RID: 28972
		private static readonly FieldCodec<PhBaOneCostPlan> _repeated_oneCostList_codec = FieldCodec.ForMessage<PhBaOneCostPlan>(18U, PhBaOneCostPlan.Parser);

		// Token: 0x0400712D RID: 28973
		private readonly RepeatedField<PhBaOneCostPlan> oneCostList_ = new RepeatedField<PhBaOneCostPlan>();

		// Token: 0x0400712E RID: 28974
		public const int IsOpenFieldNumber = 3;

		// Token: 0x0400712F RID: 28975
		private bool isOpen_;
	}
}
