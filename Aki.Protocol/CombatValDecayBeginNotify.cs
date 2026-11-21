using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002B4 RID: 692
	[NetMessage(EMessageId.CombatValDecayBeginNotify)]
	public sealed class CombatValDecayBeginNotify : IMessage<CombatValDecayBeginNotify>, IMessage, IEquatable<CombatValDecayBeginNotify>, IDeepCloneable<CombatValDecayBeginNotify>, IBufferMessage
	{
		// Token: 0x060047D4 RID: 18388 RVA: 0x000B0B10 File Offset: 0x000AED10
		[NullableContext(1)]
		public static CombatValDecayBeginNotify Create()
		{
			return new CombatValDecayBeginNotify();
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x060047D5 RID: 18389 RVA: 0x000B0B17 File Offset: 0x000AED17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x060047D6 RID: 18390 RVA: 0x000B0B1A File Offset: 0x000AED1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatValDecayBeginNotify.Descriptor;
			}
		}

		// Token: 0x060047D7 RID: 18391 RVA: 0x000B0B21 File Offset: 0x000AED21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatValDecayBeginNotify()
		{
		}

		// Token: 0x060047D8 RID: 18392 RVA: 0x000B0B29 File Offset: 0x000AED29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatValDecayBeginNotify(CombatValDecayBeginNotify other) : this()
		{
			this.type_ = other.type_;
			this.value_ = other.value_;
			this.decayRemain_ = other.decayRemain_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060047D9 RID: 18393 RVA: 0x000B0B66 File Offset: 0x000AED66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatValDecayBeginNotify Clone()
		{
			return new CombatValDecayBeginNotify(this);
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x060047DA RID: 18394 RVA: 0x000B0B6E File Offset: 0x000AED6E
		// (set) Token: 0x060047DB RID: 18395 RVA: 0x000B0B76 File Offset: 0x000AED76
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

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x060047DC RID: 18396 RVA: 0x000B0B7F File Offset: 0x000AED7F
		// (set) Token: 0x060047DD RID: 18397 RVA: 0x000B0B87 File Offset: 0x000AED87
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

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x060047DE RID: 18398 RVA: 0x000B0B90 File Offset: 0x000AED90
		// (set) Token: 0x060047DF RID: 18399 RVA: 0x000B0B98 File Offset: 0x000AED98
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

		// Token: 0x060047E0 RID: 18400 RVA: 0x000B0BA1 File Offset: 0x000AEDA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatValDecayBeginNotify);
		}

		// Token: 0x060047E1 RID: 18401 RVA: 0x000B0BB0 File Offset: 0x000AEDB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatValDecayBeginNotify other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Value == other.Value && this.DecayRemain == other.DecayRemain && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060047E2 RID: 18402 RVA: 0x000B0C0C File Offset: 0x000AEE0C
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

		// Token: 0x060047E3 RID: 18403 RVA: 0x000B0C83 File Offset: 0x000AEE83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060047E4 RID: 18404 RVA: 0x000B0C90 File Offset: 0x000AEE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060047E5 RID: 18405 RVA: 0x000B0C9C File Offset: 0x000AEE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DecayRemain != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DecayRemain);
			}
			if (this.Type != CombatValType.CvtNone)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Type);
			}
			if (this.Value != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Value);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060047E6 RID: 18406 RVA: 0x000B0D10 File Offset: 0x000AEF10
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

		// Token: 0x060047E7 RID: 18407 RVA: 0x000B0D80 File Offset: 0x000AEF80
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

		// Token: 0x060047E8 RID: 18408 RVA: 0x000B0DE4 File Offset: 0x000AEFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060047E9 RID: 18409 RVA: 0x000B0DF0 File Offset: 0x000AEFF0
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
					if (num != 48U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.DecayRemain = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003012 RID: 12306
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003013 RID: 12307
		public const int TypeFieldNumber = 6;

		// Token: 0x04003014 RID: 12308
		private CombatValType type_;

		// Token: 0x04003015 RID: 12309
		public const int ValueFieldNumber = 13;

		// Token: 0x04003016 RID: 12310
		private int value_;

		// Token: 0x04003017 RID: 12311
		public const int DecayRemainFieldNumber = 1;

		// Token: 0x04003018 RID: 12312
		private int decayRemain_;
	}
}
