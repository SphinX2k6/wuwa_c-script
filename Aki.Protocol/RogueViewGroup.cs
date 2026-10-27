using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001027 RID: 4135
	public sealed class RogueViewGroup : IMessage<RogueViewGroup>, IMessage, IEquatable<RogueViewGroup>, IDeepCloneable<RogueViewGroup>, IBufferMessage
	{
		// Token: 0x0601619C RID: 90524 RVA: 0x003360F9 File Offset: 0x003342F9
		[NullableContext(1)]
		public static RogueViewGroup Create()
		{
			return new RogueViewGroup();
		}

		// Token: 0x170049DD RID: 18909
		// (get) Token: 0x0601619D RID: 90525 RVA: 0x00336100 File Offset: 0x00334300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueViewGroup> Parser
		{
			get
			{
				return RogueViewGroup._parser;
			}
		}

		// Token: 0x170049DE RID: 18910
		// (get) Token: 0x0601619E RID: 90526 RVA: 0x00336107 File Offset: 0x00334307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049DF RID: 18911
		// (get) Token: 0x0601619F RID: 90527 RVA: 0x0033610A File Offset: 0x0033430A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueViewGroup.Descriptor;
			}
		}

		// Token: 0x060161A0 RID: 90528 RVA: 0x00336111 File Offset: 0x00334311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueViewGroup()
		{
		}

		// Token: 0x060161A1 RID: 90529 RVA: 0x00336124 File Offset: 0x00334324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueViewGroup(RogueViewGroup other) : this()
		{
			this.rogueViewUnit_ = ((other.rogueViewUnit_ != null) ? other.rogueViewUnit_.Clone() : null);
			this.childRogueViewUnits_ = other.childRogueViewUnits_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060161A2 RID: 90530 RVA: 0x00336175 File Offset: 0x00334375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueViewGroup Clone()
		{
			return new RogueViewGroup(this);
		}

		// Token: 0x170049E0 RID: 18912
		// (get) Token: 0x060161A3 RID: 90531 RVA: 0x0033617D File Offset: 0x0033437D
		// (set) Token: 0x060161A4 RID: 90532 RVA: 0x00336185 File Offset: 0x00334385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueViewUnit RogueViewUnit
		{
			get
			{
				return this.rogueViewUnit_;
			}
			set
			{
				this.rogueViewUnit_ = value;
			}
		}

		// Token: 0x170049E1 RID: 18913
		// (get) Token: 0x060161A5 RID: 90533 RVA: 0x0033618E File Offset: 0x0033438E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueViewUnit> ChildRogueViewUnits
		{
			get
			{
				return this.childRogueViewUnits_;
			}
		}

		// Token: 0x060161A6 RID: 90534 RVA: 0x00336196 File Offset: 0x00334396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueViewGroup);
		}

		// Token: 0x060161A7 RID: 90535 RVA: 0x003361A4 File Offset: 0x003343A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueViewGroup other)
		{
			return other != null && (other == this || (object.Equals(this.RogueViewUnit, other.RogueViewUnit) && this.childRogueViewUnits_.Equals(other.childRogueViewUnits_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060161A8 RID: 90536 RVA: 0x003361F8 File Offset: 0x003343F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueViewUnit_ != null)
			{
				num ^= this.RogueViewUnit.GetHashCode();
			}
			num ^= this.childRogueViewUnits_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060161A9 RID: 90537 RVA: 0x00336242 File Offset: 0x00334442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060161AA RID: 90538 RVA: 0x0033624F File Offset: 0x0033444F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060161AB RID: 90539 RVA: 0x00336258 File Offset: 0x00334458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueViewUnit_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RogueViewUnit);
			}
			this.childRogueViewUnits_.WriteTo(ref output, RogueViewGroup._repeated_childRogueViewUnits_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060161AC RID: 90540 RVA: 0x003362A8 File Offset: 0x003344A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueViewUnit_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueViewUnit);
			}
			num += this.childRogueViewUnits_.CalculateSize(RogueViewGroup._repeated_childRogueViewUnits_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060161AD RID: 90541 RVA: 0x003362FC File Offset: 0x003344FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueViewGroup other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueViewUnit_ != null)
			{
				if (this.rogueViewUnit_ == null)
				{
					this.RogueViewUnit = new RogueViewUnit();
				}
				this.RogueViewUnit.MergeFrom(other.RogueViewUnit);
			}
			this.childRogueViewUnits_.Add(other.childRogueViewUnits_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060161AE RID: 90542 RVA: 0x00336361 File Offset: 0x00334561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060161AF RID: 90543 RVA: 0x0033636C File Offset: 0x0033456C
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
						this.childRogueViewUnits_.AddEntriesFrom(ref input, RogueViewGroup._repeated_childRogueViewUnits_codec);
					}
				}
				else
				{
					if (this.rogueViewUnit_ == null)
					{
						this.RogueViewUnit = new RogueViewUnit();
					}
					input.ReadMessage(this.RogueViewUnit);
				}
			}
		}

		// Token: 0x04008462 RID: 33890
		private static readonly MessageParser<RogueViewGroup> _parser = new MessageParser<RogueViewGroup>(() => new RogueViewGroup());

		// Token: 0x04008463 RID: 33891
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008464 RID: 33892
		public const int RogueViewUnitFieldNumber = 1;

		// Token: 0x04008465 RID: 33893
		private RogueViewUnit rogueViewUnit_;

		// Token: 0x04008466 RID: 33894
		public const int ChildRogueViewUnitsFieldNumber = 2;

		// Token: 0x04008467 RID: 33895
		private static readonly FieldCodec<RogueViewUnit> _repeated_childRogueViewUnits_codec = FieldCodec.ForMessage<RogueViewUnit>(18U, RogueViewUnit.Parser);

		// Token: 0x04008468 RID: 33896
		private readonly RepeatedField<RogueViewUnit> childRogueViewUnits_ = new RepeatedField<RogueViewUnit>();
	}
}
