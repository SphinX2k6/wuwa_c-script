using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002AE RID: 686
	[NetMessage(EMessageId.CombatValDecayBeginNotify)]
	public sealed class CombatValDecayBeginNotify : IMessage<CombatValDecayBeginNotify>, IMessage, IEquatable<CombatValDecayBeginNotify>, IDeepCloneable<CombatValDecayBeginNotify>, IBufferMessage
	{
		// Token: 0x0600470D RID: 18189 RVA: 0x000AE908 File Offset: 0x000ACB08
		[NullableContext(1)]
		public static CombatValDecayBeginNotify Create()
		{
			return new CombatValDecayBeginNotify();
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x0600470E RID: 18190 RVA: 0x000AE90F File Offset: 0x000ACB0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x0600470F RID: 18191 RVA: 0x000AE912 File Offset: 0x000ACB12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatValDecayBeginNotify.Descriptor;
			}
		}

		// Token: 0x06004710 RID: 18192 RVA: 0x000AE919 File Offset: 0x000ACB19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatValDecayBeginNotify()
		{
		}

		// Token: 0x06004711 RID: 18193 RVA: 0x000AE921 File Offset: 0x000ACB21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatValDecayBeginNotify(CombatValDecayBeginNotify other) : this()
		{
			this.type_ = other.type_;
			this.value_ = other.value_;
			this.decayRemain_ = other.decayRemain_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004712 RID: 18194 RVA: 0x000AE95E File Offset: 0x000ACB5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatValDecayBeginNotify Clone()
		{
			return new CombatValDecayBeginNotify(this);
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06004713 RID: 18195 RVA: 0x000AE966 File Offset: 0x000ACB66
		// (set) Token: 0x06004714 RID: 18196 RVA: 0x000AE96E File Offset: 0x000ACB6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatValType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x06004715 RID: 18197 RVA: 0x000AE977 File Offset: 0x000ACB77
		// (set) Token: 0x06004716 RID: 18198 RVA: 0x000AE97F File Offset: 0x000ACB7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = value;
			}
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x06004717 RID: 18199 RVA: 0x000AE988 File Offset: 0x000ACB88
		// (set) Token: 0x06004718 RID: 18200 RVA: 0x000AE990 File Offset: 0x000ACB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DecayRemain
		{
			get
			{
				return this.decayRemain_;
			}
			set
			{
				this.decayRemain_ = value;
			}
		}

		// Token: 0x06004719 RID: 18201 RVA: 0x000AE999 File Offset: 0x000ACB99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatValDecayBeginNotify);
		}

		// Token: 0x0600471A RID: 18202 RVA: 0x000AE9A8 File Offset: 0x000ACBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatValDecayBeginNotify other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Value == other.Value && this.DecayRemain == other.DecayRemain && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600471B RID: 18203 RVA: 0x000AEA04 File Offset: 0x000ACC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != CombatValType.CvtNone)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Value != 0)
			{
				num ^= this.Value.GetHashCode();
			}
			if (this.DecayRemain != 0)
			{
				num ^= this.DecayRemain.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600471C RID: 18204 RVA: 0x000AEA7B File Offset: 0x000ACC7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600471D RID: 18205 RVA: 0x000AEA88 File Offset: 0x000ACC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600471E RID: 18206 RVA: 0x000AEA94 File Offset: 0x000ACC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != CombatValType.CvtNone)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Type);
			}
			if (this.Value != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Value);
			}
			if (this.DecayRemain != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.DecayRemain);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600471F RID: 18207 RVA: 0x000AEB0C File Offset: 0x000ACD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != CombatValType.CvtNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.Value != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Value);
			}
			if (this.DecayRemain != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DecayRemain);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004720 RID: 18208 RVA: 0x000AEB7C File Offset: 0x000ACD7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatValDecayBeginNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != CombatValType.CvtNone)
			{
				this.Type = other.Type;
			}
			if (other.Value != 0)
			{
				this.Value = other.Value;
			}
			if (other.DecayRemain != 0)
			{
				this.DecayRemain = other.DecayRemain;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004721 RID: 18209 RVA: 0x000AEBE0 File Offset: 0x000ACDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004722 RID: 18210 RVA: 0x000AEBEC File Offset: 0x000ACDEC
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
				if (num != 40U)
				{
					if (num != 56U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.DecayRemain = input.ReadInt32();
						}
					}
					else
					{
						this.Value = input.ReadInt32();
					}
				}
				else
				{
					this.Type = (CombatValType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002F7F RID: 12159
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F80 RID: 12160
		public const int TypeFieldNumber = 5;

		// Token: 0x04002F81 RID: 12161
		private CombatValType type_;

		// Token: 0x04002F82 RID: 12162
		public const int ValueFieldNumber = 7;

		// Token: 0x04002F83 RID: 12163
		private int value_;

		// Token: 0x04002F84 RID: 12164
		public const int DecayRemainFieldNumber = 13;

		// Token: 0x04002F85 RID: 12165
		private int decayRemain_;
	}
}
