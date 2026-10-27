using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000537 RID: 1335
	public sealed class FightBuffEffectContext : IMessage<FightBuffEffectContext>, IMessage, IEquatable<FightBuffEffectContext>, IDeepCloneable<FightBuffEffectContext>, IBufferMessage
	{
		// Token: 0x06007CFA RID: 31994 RVA: 0x0012E9A7 File Offset: 0x0012CBA7
		[NullableContext(1)]
		public static FightBuffEffectContext Create()
		{
			return new FightBuffEffectContext();
		}

		// Token: 0x17001842 RID: 6210
		// (get) Token: 0x06007CFB RID: 31995 RVA: 0x0012E9AE File Offset: 0x0012CBAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightBuffEffectContext> Parser
		{
			get
			{
				return FightBuffEffectContext._parser;
			}
		}

		// Token: 0x17001843 RID: 6211
		// (get) Token: 0x06007CFC RID: 31996 RVA: 0x0012E9B5 File Offset: 0x0012CBB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001844 RID: 6212
		// (get) Token: 0x06007CFD RID: 31997 RVA: 0x0012E9B8 File Offset: 0x0012CBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightBuffEffectContext.Descriptor;
			}
		}

		// Token: 0x06007CFE RID: 31998 RVA: 0x0012E9BF File Offset: 0x0012CBBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightBuffEffectContext()
		{
		}

		// Token: 0x06007CFF RID: 31999 RVA: 0x0012E9C8 File Offset: 0x0012CBC8
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

		// Token: 0x06007D00 RID: 32000 RVA: 0x0012EA1E File Offset: 0x0012CC1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightBuffEffectContext Clone()
		{
			return new FightBuffEffectContext(this);
		}

		// Token: 0x17001845 RID: 6213
		// (get) Token: 0x06007D01 RID: 32001 RVA: 0x0012EA26 File Offset: 0x0012CC26
		// (set) Token: 0x06007D02 RID: 32002 RVA: 0x0012EA3E File Offset: 0x0012CC3E
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

		// Token: 0x17001846 RID: 6214
		// (get) Token: 0x06007D03 RID: 32003 RVA: 0x0012EA55 File Offset: 0x0012CC55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasLeftCooldown
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007D04 RID: 32004 RVA: 0x0012EA62 File Offset: 0x0012CC62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearLeftCooldown()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001847 RID: 6215
		// (get) Token: 0x06007D05 RID: 32005 RVA: 0x0012EA73 File Offset: 0x0012CC73
		// (set) Token: 0x06007D06 RID: 32006 RVA: 0x0012EA8B File Offset: 0x0012CC8B
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

		// Token: 0x17001848 RID: 6216
		// (get) Token: 0x06007D07 RID: 32007 RVA: 0x0012EAA1 File Offset: 0x0012CCA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightBuffEffectContext.EffectDataOneofCase EffectDataCase
		{
			get
			{
				return this.effectDataCase_;
			}
		}

		// Token: 0x06007D08 RID: 32008 RVA: 0x0012EAA9 File Offset: 0x0012CCA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearEffectData()
		{
			this.effectDataCase_ = FightBuffEffectContext.EffectDataOneofCase.None;
			this.effectData_ = null;
		}

		// Token: 0x06007D09 RID: 32009 RVA: 0x0012EAB9 File Offset: 0x0012CCB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightBuffEffectContext);
		}

		// Token: 0x06007D0A RID: 32010 RVA: 0x0012EAC8 File Offset: 0x0012CCC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightBuffEffectContext other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.LeftCooldown, other.LeftCooldown) && object.Equals(this.AttributeEventEffectData, other.AttributeEventEffectData) && this.EffectDataCase == other.EffectDataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007D0B RID: 32011 RVA: 0x0012EB30 File Offset: 0x0012CD30
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

		// Token: 0x06007D0C RID: 32012 RVA: 0x0012EB91 File Offset: 0x0012CD91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007D0D RID: 32013 RVA: 0x0012EB9E File Offset: 0x0012CD9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D0E RID: 32014 RVA: 0x0012EBA8 File Offset: 0x0012CDA8
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

		// Token: 0x06007D0F RID: 32015 RVA: 0x0012EC04 File Offset: 0x0012CE04
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

		// Token: 0x06007D10 RID: 32016 RVA: 0x0012EC50 File Offset: 0x0012CE50
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

		// Token: 0x06007D11 RID: 32017 RVA: 0x0012ECB9 File Offset: 0x0012CEB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007D12 RID: 32018 RVA: 0x0012ECC4 File Offset: 0x0012CEC4
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

		// Token: 0x04003F98 RID: 16280
		private static readonly MessageParser<FightBuffEffectContext> _parser = new MessageParser<FightBuffEffectContext>(() => new FightBuffEffectContext());

		// Token: 0x04003F99 RID: 16281
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F9A RID: 16282
		private int _hasBits0;

		// Token: 0x04003F9B RID: 16283
		public const int LeftCooldownFieldNumber = 1;

		// Token: 0x04003F9C RID: 16284
		private static readonly float LeftCooldownDefaultValue = 0f;

		// Token: 0x04003F9D RID: 16285
		private float leftCooldown_;

		// Token: 0x04003F9E RID: 16286
		public const int AttributeEventEffectDataFieldNumber = 6;

		// Token: 0x04003F9F RID: 16287
		private object effectData_;

		// Token: 0x04003FA0 RID: 16288
		private FightBuffEffectContext.EffectDataOneofCase effectDataCase_;

		// Token: 0x0200178E RID: 6030
		public enum EffectDataOneofCase
		{
			// Token: 0x0400C6B1 RID: 50865
			None,
			// Token: 0x0400C6B2 RID: 50866
			AttributeEventEffectData = 6
		}
	}
}
