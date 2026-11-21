using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001276 RID: 4726
	public sealed class SkillEffect : IMessage<SkillEffect>, IMessage, IEquatable<SkillEffect>, IDeepCloneable<SkillEffect>, IBufferMessage
	{
		// Token: 0x060193A9 RID: 103337 RVA: 0x003ADF1F File Offset: 0x003AC11F
		[NullableContext(1)]
		public static SkillEffect Create()
		{
			return new SkillEffect();
		}

		// Token: 0x1700554E RID: 21838
		// (get) Token: 0x060193AA RID: 103338 RVA: 0x003ADF26 File Offset: 0x003AC126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SkillEffect> Parser
		{
			get
			{
				return SkillEffect._parser;
			}
		}

		// Token: 0x1700554F RID: 21839
		// (get) Token: 0x060193AB RID: 103339 RVA: 0x003ADF2D File Offset: 0x003AC12D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005550 RID: 21840
		// (get) Token: 0x060193AC RID: 103340 RVA: 0x003ADF30 File Offset: 0x003AC130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillEffect.Descriptor;
			}
		}

		// Token: 0x060193AD RID: 103341 RVA: 0x003ADF37 File Offset: 0x003AC137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillEffect()
		{
		}

		// Token: 0x060193AE RID: 103342 RVA: 0x003ADF4A File Offset: 0x003AC14A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillEffect(SkillEffect other) : this()
		{
			this.level_ = other.level_;
			this.effectDescList_ = other.effectDescList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060193AF RID: 103343 RVA: 0x003ADF80 File Offset: 0x003AC180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillEffect Clone()
		{
			return new SkillEffect(this);
		}

		// Token: 0x17005551 RID: 21841
		// (get) Token: 0x060193B0 RID: 103344 RVA: 0x003ADF88 File Offset: 0x003AC188
		// (set) Token: 0x060193B1 RID: 103345 RVA: 0x003ADF90 File Offset: 0x003AC190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17005552 RID: 21842
		// (get) Token: 0x060193B2 RID: 103346 RVA: 0x003ADF99 File Offset: 0x003AC199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneSkillEffect> EffectDescList
		{
			get
			{
				return this.effectDescList_;
			}
		}

		// Token: 0x060193B3 RID: 103347 RVA: 0x003ADFA1 File Offset: 0x003AC1A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillEffect);
		}

		// Token: 0x060193B4 RID: 103348 RVA: 0x003ADFB0 File Offset: 0x003AC1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillEffect other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.effectDescList_.Equals(other.effectDescList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060193B5 RID: 103349 RVA: 0x003AE000 File Offset: 0x003AC200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			num ^= this.effectDescList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060193B6 RID: 103350 RVA: 0x003AE04D File Offset: 0x003AC24D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060193B7 RID: 103351 RVA: 0x003AE05A File Offset: 0x003AC25A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060193B8 RID: 103352 RVA: 0x003AE064 File Offset: 0x003AC264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Level);
			}
			this.effectDescList_.WriteTo(ref output, SkillEffect._repeated_effectDescList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060193B9 RID: 103353 RVA: 0x003AE0B4 File Offset: 0x003AC2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			num += this.effectDescList_.CalculateSize(SkillEffect._repeated_effectDescList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060193BA RID: 103354 RVA: 0x003AE108 File Offset: 0x003AC308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkillEffect other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this.effectDescList_.Add(other.effectDescList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060193BB RID: 103355 RVA: 0x003AE155 File Offset: 0x003AC355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060193BC RID: 103356 RVA: 0x003AE160 File Offset: 0x003AC360
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
					if (num != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.effectDescList_.AddEntriesFrom(ref input, SkillEffect._repeated_effectDescList_codec);
					}
				}
				else
				{
					this.Level = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009551 RID: 38225
		private static readonly MessageParser<SkillEffect> _parser = new MessageParser<SkillEffect>(() => new SkillEffect());

		// Token: 0x04009552 RID: 38226
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009553 RID: 38227
		public const int LevelFieldNumber = 1;

		// Token: 0x04009554 RID: 38228
		private int level_;

		// Token: 0x04009555 RID: 38229
		public const int EffectDescListFieldNumber = 3;

		// Token: 0x04009556 RID: 38230
		private static readonly FieldCodec<OneSkillEffect> _repeated_effectDescList_codec = FieldCodec.ForMessage<OneSkillEffect>(26U, OneSkillEffect.Parser);

		// Token: 0x04009557 RID: 38231
		private readonly RepeatedField<OneSkillEffect> effectDescList_ = new RepeatedField<OneSkillEffect>();
	}
}
