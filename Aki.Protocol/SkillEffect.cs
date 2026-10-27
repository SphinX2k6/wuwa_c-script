using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001239 RID: 4665
	public sealed class SkillEffect : IMessage<SkillEffect>, IMessage, IEquatable<SkillEffect>, IDeepCloneable<SkillEffect>, IBufferMessage
	{
		// Token: 0x06018DBF RID: 101823 RVA: 0x0039DFBF File Offset: 0x0039C1BF
		[NullableContext(1)]
		public static SkillEffect Create()
		{
			return new SkillEffect();
		}

		// Token: 0x170053CF RID: 21455
		// (get) Token: 0x06018DC0 RID: 101824 RVA: 0x0039DFC6 File Offset: 0x0039C1C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SkillEffect> Parser
		{
			get
			{
				return SkillEffect._parser;
			}
		}

		// Token: 0x170053D0 RID: 21456
		// (get) Token: 0x06018DC1 RID: 101825 RVA: 0x0039DFCD File Offset: 0x0039C1CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053D1 RID: 21457
		// (get) Token: 0x06018DC2 RID: 101826 RVA: 0x0039DFD0 File Offset: 0x0039C1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillEffect.Descriptor;
			}
		}

		// Token: 0x06018DC3 RID: 101827 RVA: 0x0039DFD7 File Offset: 0x0039C1D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillEffect()
		{
		}

		// Token: 0x06018DC4 RID: 101828 RVA: 0x0039DFEA File Offset: 0x0039C1EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillEffect(SkillEffect other) : this()
		{
			this.level_ = other.level_;
			this.effectDescList_ = other.effectDescList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018DC5 RID: 101829 RVA: 0x0039E020 File Offset: 0x0039C220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillEffect Clone()
		{
			return new SkillEffect(this);
		}

		// Token: 0x170053D2 RID: 21458
		// (get) Token: 0x06018DC6 RID: 101830 RVA: 0x0039E028 File Offset: 0x0039C228
		// (set) Token: 0x06018DC7 RID: 101831 RVA: 0x0039E030 File Offset: 0x0039C230
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

		// Token: 0x170053D3 RID: 21459
		// (get) Token: 0x06018DC8 RID: 101832 RVA: 0x0039E039 File Offset: 0x0039C239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneSkillEffect> EffectDescList
		{
			get
			{
				return this.effectDescList_;
			}
		}

		// Token: 0x06018DC9 RID: 101833 RVA: 0x0039E041 File Offset: 0x0039C241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillEffect);
		}

		// Token: 0x06018DCA RID: 101834 RVA: 0x0039E050 File Offset: 0x0039C250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillEffect other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.effectDescList_.Equals(other.effectDescList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018DCB RID: 101835 RVA: 0x0039E0A0 File Offset: 0x0039C2A0
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

		// Token: 0x06018DCC RID: 101836 RVA: 0x0039E0ED File Offset: 0x0039C2ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018DCD RID: 101837 RVA: 0x0039E0FA File Offset: 0x0039C2FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018DCE RID: 101838 RVA: 0x0039E104 File Offset: 0x0039C304
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

		// Token: 0x06018DCF RID: 101839 RVA: 0x0039E154 File Offset: 0x0039C354
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

		// Token: 0x06018DD0 RID: 101840 RVA: 0x0039E1A8 File Offset: 0x0039C3A8
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

		// Token: 0x06018DD1 RID: 101841 RVA: 0x0039E1F5 File Offset: 0x0039C3F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018DD2 RID: 101842 RVA: 0x0039E200 File Offset: 0x0039C400
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

		// Token: 0x0400929F RID: 37535
		private static readonly MessageParser<SkillEffect> _parser = new MessageParser<SkillEffect>(() => new SkillEffect());

		// Token: 0x040092A0 RID: 37536
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092A1 RID: 37537
		public const int LevelFieldNumber = 1;

		// Token: 0x040092A2 RID: 37538
		private int level_;

		// Token: 0x040092A3 RID: 37539
		public const int EffectDescListFieldNumber = 3;

		// Token: 0x040092A4 RID: 37540
		private static readonly FieldCodec<OneSkillEffect> _repeated_effectDescList_codec = FieldCodec.ForMessage<OneSkillEffect>(26U, OneSkillEffect.Parser);

		// Token: 0x040092A5 RID: 37541
		private readonly RepeatedField<OneSkillEffect> effectDescList_ = new RepeatedField<OneSkillEffect>();
	}
}
