using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A03 RID: 2563
	public sealed class MoonPhaseSelect : IMessage<MoonPhaseSelect>, IMessage, IEquatable<MoonPhaseSelect>, IDeepCloneable<MoonPhaseSelect>, IBufferMessage
	{
		// Token: 0x0600E08A RID: 57482 RVA: 0x0020E92D File Offset: 0x0020CB2D
		[NullableContext(1)]
		public static MoonPhaseSelect Create()
		{
			return new MoonPhaseSelect();
		}

		// Token: 0x17002D7F RID: 11647
		// (get) Token: 0x0600E08B RID: 57483 RVA: 0x0020E934 File Offset: 0x0020CB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MoonPhaseSelect> Parser
		{
			get
			{
				return MoonPhaseSelect._parser;
			}
		}

		// Token: 0x17002D80 RID: 11648
		// (get) Token: 0x0600E08C RID: 57484 RVA: 0x0020E93B File Offset: 0x0020CB3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D81 RID: 11649
		// (get) Token: 0x0600E08D RID: 57485 RVA: 0x0020E93E File Offset: 0x0020CB3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoonPhaseSelect.Descriptor;
			}
		}

		// Token: 0x0600E08E RID: 57486 RVA: 0x0020E945 File Offset: 0x0020CB45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseSelect()
		{
		}

		// Token: 0x0600E08F RID: 57487 RVA: 0x0020E94D File Offset: 0x0020CB4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseSelect(MoonPhaseSelect other) : this()
		{
			this.moonPhaseId_ = other.moonPhaseId_;
			this.label1_ = other.label1_;
			this.label2_ = other.label2_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E090 RID: 57488 RVA: 0x0020E98A File Offset: 0x0020CB8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseSelect Clone()
		{
			return new MoonPhaseSelect(this);
		}

		// Token: 0x17002D82 RID: 11650
		// (get) Token: 0x0600E091 RID: 57489 RVA: 0x0020E992 File Offset: 0x0020CB92
		// (set) Token: 0x0600E092 RID: 57490 RVA: 0x0020E99A File Offset: 0x0020CB9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MoonPhaseId
		{
			get
			{
				return this.moonPhaseId_;
			}
			set
			{
				this.moonPhaseId_ = value;
			}
		}

		// Token: 0x17002D83 RID: 11651
		// (get) Token: 0x0600E093 RID: 57491 RVA: 0x0020E9A3 File Offset: 0x0020CBA3
		// (set) Token: 0x0600E094 RID: 57492 RVA: 0x0020E9AB File Offset: 0x0020CBAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Label1
		{
			get
			{
				return this.label1_;
			}
			set
			{
				this.label1_ = value;
			}
		}

		// Token: 0x17002D84 RID: 11652
		// (get) Token: 0x0600E095 RID: 57493 RVA: 0x0020E9B4 File Offset: 0x0020CBB4
		// (set) Token: 0x0600E096 RID: 57494 RVA: 0x0020E9BC File Offset: 0x0020CBBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Label2
		{
			get
			{
				return this.label2_;
			}
			set
			{
				this.label2_ = value;
			}
		}

		// Token: 0x0600E097 RID: 57495 RVA: 0x0020E9C5 File Offset: 0x0020CBC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoonPhaseSelect);
		}

		// Token: 0x0600E098 RID: 57496 RVA: 0x0020E9D4 File Offset: 0x0020CBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoonPhaseSelect other)
		{
			return other != null && (other == this || (this.MoonPhaseId == other.MoonPhaseId && this.Label1 == other.Label1 && this.Label2 == other.Label2 && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E099 RID: 57497 RVA: 0x0020EA30 File Offset: 0x0020CC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MoonPhaseId != 0)
			{
				num ^= this.MoonPhaseId.GetHashCode();
			}
			if (this.Label1 != 0)
			{
				num ^= this.Label1.GetHashCode();
			}
			if (this.Label2 != 0)
			{
				num ^= this.Label2.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E09A RID: 57498 RVA: 0x0020EAA1 File Offset: 0x0020CCA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E09B RID: 57499 RVA: 0x0020EAAE File Offset: 0x0020CCAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E09C RID: 57500 RVA: 0x0020EAB8 File Offset: 0x0020CCB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MoonPhaseId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MoonPhaseId);
			}
			if (this.Label1 != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Label1);
			}
			if (this.Label2 != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Label2);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E09D RID: 57501 RVA: 0x0020EB2C File Offset: 0x0020CD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MoonPhaseId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MoonPhaseId);
			}
			if (this.Label1 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Label1);
			}
			if (this.Label2 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Label2);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E09E RID: 57502 RVA: 0x0020EB9C File Offset: 0x0020CD9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoonPhaseSelect other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MoonPhaseId != 0)
			{
				this.MoonPhaseId = other.MoonPhaseId;
			}
			if (other.Label1 != 0)
			{
				this.Label1 = other.Label1;
			}
			if (other.Label2 != 0)
			{
				this.Label2 = other.Label2;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E09F RID: 57503 RVA: 0x0020EC00 File Offset: 0x0020CE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E0A0 RID: 57504 RVA: 0x0020EC0C File Offset: 0x0020CE0C
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Label2 = input.ReadInt32();
						}
					}
					else
					{
						this.Label1 = input.ReadInt32();
					}
				}
				else
				{
					this.MoonPhaseId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005CBA RID: 23738
		private static readonly MessageParser<MoonPhaseSelect> _parser = new MessageParser<MoonPhaseSelect>(() => new MoonPhaseSelect());

		// Token: 0x04005CBB RID: 23739
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005CBC RID: 23740
		public const int MoonPhaseIdFieldNumber = 1;

		// Token: 0x04005CBD RID: 23741
		private int moonPhaseId_;

		// Token: 0x04005CBE RID: 23742
		public const int Label1FieldNumber = 2;

		// Token: 0x04005CBF RID: 23743
		private int label1_;

		// Token: 0x04005CC0 RID: 23744
		public const int Label2FieldNumber = 3;

		// Token: 0x04005CC1 RID: 23745
		private int label2_;
	}
}
