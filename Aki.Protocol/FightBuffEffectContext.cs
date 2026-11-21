using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000522 RID: 1314
	public sealed class FightBuffEffectContext : IMessage<FightBuffEffectContext>, IMessage, IEquatable<FightBuffEffectContext>, IDeepCloneable<FightBuffEffectContext>, IBufferMessage
	{
		// Token: 0x06007B92 RID: 31634 RVA: 0x0012BDA3 File Offset: 0x00129FA3
		[NullableContext(1)]
		public static FightBuffEffectContext Create()
		{
			return new FightBuffEffectContext();
		}

		// Token: 0x170017F5 RID: 6133
		// (get) Token: 0x06007B93 RID: 31635 RVA: 0x0012BDAA File Offset: 0x00129FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightBuffEffectContext> Parser
		{
			get
			{
				return FightBuffEffectContext._parser;
			}
		}

		// Token: 0x170017F6 RID: 6134
		// (get) Token: 0x06007B94 RID: 31636 RVA: 0x0012BDB1 File Offset: 0x00129FB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017F7 RID: 6135
		// (get) Token: 0x06007B95 RID: 31637 RVA: 0x0012BDB4 File Offset: 0x00129FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightBuffEffectContext.Descriptor;
			}
		}

		// Token: 0x06007B96 RID: 31638 RVA: 0x0012BDBB File Offset: 0x00129FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightBuffEffectContext()
		{
		}

		// Token: 0x06007B97 RID: 31639 RVA: 0x0012BDC4 File Offset: 0x00129FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightBuffEffectContext(FightBuffEffectContext other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.leftCooldown_ = other.leftCooldown_;
			if (other.EffectDataCase == FightBuffEffectContext.EffectDataOneofCase.AttributeEventEffectData)
			{
				this.AttributeEventEffectData = other.AttributeEventEffectData.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007B98 RID: 31640 RVA: 0x0012BE1A File Offset: 0x0012A01A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightBuffEffectContext Clone()
		{
			return new FightBuffEffectContext(this);
		}

		// Token: 0x170017F8 RID: 6136
		// (get) Token: 0x06007B99 RID: 31641 RVA: 0x0012BE22 File Offset: 0x0012A022
		// (set) Token: 0x06007B9A RID: 31642 RVA: 0x0012BE3A File Offset: 0x0012A03A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float LeftCooldown
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.leftCooldown_;
				}
				return FightBuffEffectContext.LeftCooldownDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.leftCooldown_ = value;
			}
		}

		// Token: 0x170017F9 RID: 6137
		// (get) Token: 0x06007B9B RID: 31643 RVA: 0x0012BE51 File Offset: 0x0012A051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasLeftCooldown
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007B9C RID: 31644 RVA: 0x0012BE5E File Offset: 0x0012A05E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearLeftCooldown()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170017FA RID: 6138
		// (get) Token: 0x06007B9D RID: 31645 RVA: 0x0012BE6F File Offset: 0x0012A06F
		// (set) Token: 0x06007B9E RID: 31646 RVA: 0x0012BE87 File Offset: 0x0012A087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeEventEffectData AttributeEventEffectData
		{
			get
			{
				if (this.effectDataCase_ != FightBuffEffectContext.EffectDataOneofCase.AttributeEventEffectData)
				{
					return null;
				}
				return (AttributeEventEffectData)this.effectData_;
			}
			set
			{
				this.effectData_ = value;
				this.effectDataCase_ = ((value == null) ? FightBuffEffectContext.EffectDataOneofCase.None : FightBuffEffectContext.EffectDataOneofCase.AttributeEventEffectData);
			}
		}

		// Token: 0x170017FB RID: 6139
		// (get) Token: 0x06007B9F RID: 31647 RVA: 0x0012BE9D File Offset: 0x0012A09D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightBuffEffectContext.EffectDataOneofCase EffectDataCase
		{
			get
			{
				return this.effectDataCase_;
			}
		}

		// Token: 0x06007BA0 RID: 31648 RVA: 0x0012BEA5 File Offset: 0x0012A0A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearEffectData()
		{
			this.effectDataCase_ = FightBuffEffectContext.EffectDataOneofCase.None;
			this.effectData_ = null;
		}

		// Token: 0x06007BA1 RID: 31649 RVA: 0x0012BEB5 File Offset: 0x0012A0B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightBuffEffectContext);
		}

		// Token: 0x06007BA2 RID: 31650 RVA: 0x0012BEC4 File Offset: 0x0012A0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightBuffEffectContext other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.LeftCooldown, other.LeftCooldown) && object.Equals(this.AttributeEventEffectData, other.AttributeEventEffectData) && this.EffectDataCase == other.EffectDataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007BA3 RID: 31651 RVA: 0x0012BF2C File Offset: 0x0012A12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HasLeftCooldown)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.LeftCooldown);
			}
			if (this.effectDataCase_ == FightBuffEffectContext.EffectDataOneofCase.AttributeEventEffectData)
			{
				num ^= this.AttributeEventEffectData.GetHashCode();
			}
			num ^= (int)this.effectDataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007BA4 RID: 31652 RVA: 0x0012BF8D File Offset: 0x0012A18D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007BA5 RID: 31653 RVA: 0x0012BF9A File Offset: 0x0012A19A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007BA6 RID: 31654 RVA: 0x0012BFA4 File Offset: 0x0012A1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasLeftCooldown)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.LeftCooldown);
			}
			if (this.effectDataCase_ == FightBuffEffectContext.EffectDataOneofCase.AttributeEventEffectData)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.AttributeEventEffectData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007BA7 RID: 31655 RVA: 0x0012C000 File Offset: 0x0012A200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HasLeftCooldown)
			{
				num += 5;
			}
			if (this.effectDataCase_ == FightBuffEffectContext.EffectDataOneofCase.AttributeEventEffectData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AttributeEventEffectData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007BA8 RID: 31656 RVA: 0x0012C04C File Offset: 0x0012A24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightBuffEffectContext other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HasLeftCooldown)
			{
				this.LeftCooldown = other.LeftCooldown;
			}
			if (other.EffectDataCase == FightBuffEffectContext.EffectDataOneofCase.AttributeEventEffectData)
			{
				if (this.AttributeEventEffectData == null)
				{
					this.AttributeEventEffectData = new AttributeEventEffectData();
				}
				this.AttributeEventEffectData.MergeFrom(other.AttributeEventEffectData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007BA9 RID: 31657 RVA: 0x0012C0B5 File Offset: 0x0012A2B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007BAA RID: 31658 RVA: 0x0012C0C0 File Offset: 0x0012A2C0
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
				if (num != 13U)
				{
					if (num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						AttributeEventEffectData attributeEventEffectData = new AttributeEventEffectData();
						if (this.effectDataCase_ == FightBuffEffectContext.EffectDataOneofCase.AttributeEventEffectData)
						{
							attributeEventEffectData.MergeFrom(this.AttributeEventEffectData);
						}
						input.ReadMessage(attributeEventEffectData);
						this.AttributeEventEffectData = attributeEventEffectData;
					}
				}
				else
				{
					this.LeftCooldown = input.ReadFloat();
				}
			}
		}

		// Token: 0x04003F8E RID: 16270
		private static readonly MessageParser<FightBuffEffectContext> _parser = new MessageParser<FightBuffEffectContext>(() => new FightBuffEffectContext());

		// Token: 0x04003F8F RID: 16271
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F90 RID: 16272
		private int _hasBits0;

		// Token: 0x04003F91 RID: 16273
		public const int LeftCooldownFieldNumber = 1;

		// Token: 0x04003F92 RID: 16274
		private static readonly float LeftCooldownDefaultValue = 0f;

		// Token: 0x04003F93 RID: 16275
		private float leftCooldown_;

		// Token: 0x04003F94 RID: 16276
		public const int AttributeEventEffectDataFieldNumber = 6;

		// Token: 0x04003F95 RID: 16277
		private object effectData_;

		// Token: 0x04003F96 RID: 16278
		private FightBuffEffectContext.EffectDataOneofCase effectDataCase_;

		// Token: 0x02001806 RID: 6150
		public enum EffectDataOneofCase
		{
			// Token: 0x0400CBDC RID: 52188
			None,
			// Token: 0x0400CBDD RID: 52189
			AttributeEventEffectData = 6
		}
	}
}
