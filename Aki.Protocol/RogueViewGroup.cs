using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001017 RID: 4119
	public sealed class RogueViewGroup : IMessage<RogueViewGroup>, IMessage, IEquatable<RogueViewGroup>, IDeepCloneable<RogueViewGroup>, IBufferMessage
	{
		// Token: 0x060160B7 RID: 90295 RVA: 0x00334A39 File Offset: 0x00332C39
		[NullableContext(1)]
		public static RogueViewGroup Create()
		{
			return new RogueViewGroup();
		}

		// Token: 0x170049B3 RID: 18867
		// (get) Token: 0x060160B8 RID: 90296 RVA: 0x00334A40 File Offset: 0x00332C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueViewGroup> Parser
		{
			get
			{
				return RogueViewGroup._parser;
			}
		}

		// Token: 0x170049B4 RID: 18868
		// (get) Token: 0x060160B9 RID: 90297 RVA: 0x00334A47 File Offset: 0x00332C47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049B5 RID: 18869
		// (get) Token: 0x060160BA RID: 90298 RVA: 0x00334A4A File Offset: 0x00332C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueViewGroup.Descriptor;
			}
		}

		// Token: 0x060160BB RID: 90299 RVA: 0x00334A51 File Offset: 0x00332C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueViewGroup()
		{
		}

		// Token: 0x060160BC RID: 90300 RVA: 0x00334A64 File Offset: 0x00332C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueViewGroup(RogueViewGroup other) : this()
		{
			this.rogueViewUnit_ = ((other.rogueViewUnit_ != null) ? other.rogueViewUnit_.Clone() : null);
			this.childRogueViewUnits_ = other.childRogueViewUnits_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060160BD RID: 90301 RVA: 0x00334AB5 File Offset: 0x00332CB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueViewGroup Clone()
		{
			return new RogueViewGroup(this);
		}

		// Token: 0x170049B6 RID: 18870
		// (get) Token: 0x060160BE RID: 90302 RVA: 0x00334ABD File Offset: 0x00332CBD
		// (set) Token: 0x060160BF RID: 90303 RVA: 0x00334AC5 File Offset: 0x00332CC5
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

		// Token: 0x170049B7 RID: 18871
		// (get) Token: 0x060160C0 RID: 90304 RVA: 0x00334ACE File Offset: 0x00332CCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueViewUnit> ChildRogueViewUnits
		{
			get
			{
				return this.childRogueViewUnits_;
			}
		}

		// Token: 0x060160C1 RID: 90305 RVA: 0x00334AD6 File Offset: 0x00332CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueViewGroup);
		}

		// Token: 0x060160C2 RID: 90306 RVA: 0x00334AE4 File Offset: 0x00332CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueViewGroup other)
		{
			return other != null && (other == this || (object.Equals(this.RogueViewUnit, other.RogueViewUnit) && this.childRogueViewUnits_.Equals(other.childRogueViewUnits_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060160C3 RID: 90307 RVA: 0x00334B38 File Offset: 0x00332D38
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

		// Token: 0x060160C4 RID: 90308 RVA: 0x00334B82 File Offset: 0x00332D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060160C5 RID: 90309 RVA: 0x00334B8F File Offset: 0x00332D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060160C6 RID: 90310 RVA: 0x00334B98 File Offset: 0x00332D98
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

		// Token: 0x060160C7 RID: 90311 RVA: 0x00334BE8 File Offset: 0x00332DE8
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

		// Token: 0x060160C8 RID: 90312 RVA: 0x00334C3C File Offset: 0x00332E3C
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

		// Token: 0x060160C9 RID: 90313 RVA: 0x00334CA1 File Offset: 0x00332EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060160CA RID: 90314 RVA: 0x00334CAC File Offset: 0x00332EAC
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

		// Token: 0x0400848C RID: 33932
		private static readonly MessageParser<RogueViewGroup> _parser = new MessageParser<RogueViewGroup>(() => new RogueViewGroup());

		// Token: 0x0400848D RID: 33933
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400848E RID: 33934
		public const int RogueViewUnitFieldNumber = 1;

		// Token: 0x0400848F RID: 33935
		private RogueViewUnit rogueViewUnit_;

		// Token: 0x04008490 RID: 33936
		public const int ChildRogueViewUnitsFieldNumber = 2;

		// Token: 0x04008491 RID: 33937
		private static readonly FieldCodec<RogueViewUnit> _repeated_childRogueViewUnits_codec = FieldCodec.ForMessage<RogueViewUnit>(18U, RogueViewUnit.Parser);

		// Token: 0x04008492 RID: 33938
		private readonly RepeatedField<RogueViewUnit> childRogueViewUnits_ = new RepeatedField<RogueViewUnit>();
	}
}
