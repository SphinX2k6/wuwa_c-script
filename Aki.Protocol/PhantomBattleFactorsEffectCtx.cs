using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C87 RID: 3207
	public sealed class PhantomBattleFactorsEffectCtx : IMessage<PhantomBattleFactorsEffectCtx>, IMessage, IEquatable<PhantomBattleFactorsEffectCtx>, IDeepCloneable<PhantomBattleFactorsEffectCtx>, IBufferMessage
	{
		// Token: 0x06011628 RID: 71208 RVA: 0x0028C2AF File Offset: 0x0028A4AF
		[NullableContext(1)]
		public static PhantomBattleFactorsEffectCtx Create()
		{
			return new PhantomBattleFactorsEffectCtx();
		}

		// Token: 0x17003990 RID: 14736
		// (get) Token: 0x06011629 RID: 71209 RVA: 0x0028C2B6 File Offset: 0x0028A4B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003991 RID: 14737
		// (get) Token: 0x0601162A RID: 71210 RVA: 0x0028C2B9 File Offset: 0x0028A4B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleFactorsEffectCtx.Descriptor;
			}
		}

		// Token: 0x0601162B RID: 71211 RVA: 0x0028C2C0 File Offset: 0x0028A4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFactorsEffectCtx()
		{
		}

		// Token: 0x0601162C RID: 71212 RVA: 0x0028C2D3 File Offset: 0x0028A4D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFactorsEffectCtx(PhantomBattleFactorsEffectCtx other) : this()
		{
			this.factors_ = other.factors_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601162D RID: 71213 RVA: 0x0028C2FD File Offset: 0x0028A4FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFactorsEffectCtx Clone()
		{
			return new PhantomBattleFactorsEffectCtx(this);
		}

		// Token: 0x17003992 RID: 14738
		// (get) Token: 0x0601162E RID: 71214 RVA: 0x0028C305 File Offset: 0x0028A505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Factors
		{
			get
			{
				return this.factors_;
			}
		}

		// Token: 0x0601162F RID: 71215 RVA: 0x0028C30D File Offset: 0x0028A50D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleFactorsEffectCtx);
		}

		// Token: 0x06011630 RID: 71216 RVA: 0x0028C31B File Offset: 0x0028A51B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleFactorsEffectCtx other)
		{
			return other != null && (other == this || (this.factors_.Equals(other.factors_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011631 RID: 71217 RVA: 0x0028C350 File Offset: 0x0028A550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.factors_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011632 RID: 71218 RVA: 0x0028C384 File Offset: 0x0028A584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011633 RID: 71219 RVA: 0x0028C391 File Offset: 0x0028A591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011634 RID: 71220 RVA: 0x0028C39A File Offset: 0x0028A59A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.factors_.WriteTo(ref output, PhantomBattleFactorsEffectCtx._repeated_factors_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011635 RID: 71221 RVA: 0x0028C3C4 File Offset: 0x0028A5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.factors_.CalculateSize(PhantomBattleFactorsEffectCtx._repeated_factors_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011636 RID: 71222 RVA: 0x0028C3FD File Offset: 0x0028A5FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleFactorsEffectCtx other)
		{
			if (other == null)
			{
				return;
			}
			this.factors_.Add(other.factors_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011637 RID: 71223 RVA: 0x0028C42B File Offset: 0x0028A62B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011638 RID: 71224 RVA: 0x0028C434 File Offset: 0x0028A634
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.factors_.AddEntriesFrom(ref input, PhantomBattleFactorsEffectCtx._repeated_factors_codec);
				}
			}
		}

		// Token: 0x04006DD1 RID: 28113
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DD2 RID: 28114
		public const int FactorsFieldNumber = 1;

		// Token: 0x04006DD3 RID: 28115
		private static readonly FieldCodec<int> _repeated_factors_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04006DD4 RID: 28116
		private readonly RepeatedField<int> factors_ = new RepeatedField<int>();
	}
}
