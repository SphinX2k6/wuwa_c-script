using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C77 RID: 3191
	public sealed class PhantomBattleFactorsEffectCtx : IMessage<PhantomBattleFactorsEffectCtx>, IMessage, IEquatable<PhantomBattleFactorsEffectCtx>, IDeepCloneable<PhantomBattleFactorsEffectCtx>, IBufferMessage
	{
		// Token: 0x06011528 RID: 70952 RVA: 0x0028A543 File Offset: 0x00288743
		[NullableContext(1)]
		public static PhantomBattleFactorsEffectCtx Create()
		{
			return new PhantomBattleFactorsEffectCtx();
		}

		// Token: 0x17003959 RID: 14681
		// (get) Token: 0x06011529 RID: 70953 RVA: 0x0028A54A File Offset: 0x0028874A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700395A RID: 14682
		// (get) Token: 0x0601152A RID: 70954 RVA: 0x0028A54D File Offset: 0x0028874D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleFactorsEffectCtx.Descriptor;
			}
		}

		// Token: 0x0601152B RID: 70955 RVA: 0x0028A554 File Offset: 0x00288754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFactorsEffectCtx()
		{
		}

		// Token: 0x0601152C RID: 70956 RVA: 0x0028A567 File Offset: 0x00288767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFactorsEffectCtx(PhantomBattleFactorsEffectCtx other) : this()
		{
			this.factors_ = other.factors_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601152D RID: 70957 RVA: 0x0028A591 File Offset: 0x00288791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFactorsEffectCtx Clone()
		{
			return new PhantomBattleFactorsEffectCtx(this);
		}

		// Token: 0x1700395B RID: 14683
		// (get) Token: 0x0601152E RID: 70958 RVA: 0x0028A599 File Offset: 0x00288799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Factors
		{
			get
			{
				return this.factors_;
			}
		}

		// Token: 0x0601152F RID: 70959 RVA: 0x0028A5A1 File Offset: 0x002887A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleFactorsEffectCtx);
		}

		// Token: 0x06011530 RID: 70960 RVA: 0x0028A5AF File Offset: 0x002887AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleFactorsEffectCtx other)
		{
			return other != null && (other == this || (this.factors_.Equals(other.factors_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011531 RID: 70961 RVA: 0x0028A5E4 File Offset: 0x002887E4
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

		// Token: 0x06011532 RID: 70962 RVA: 0x0028A618 File Offset: 0x00288818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011533 RID: 70963 RVA: 0x0028A625 File Offset: 0x00288825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011534 RID: 70964 RVA: 0x0028A62E File Offset: 0x0028882E
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

		// Token: 0x06011535 RID: 70965 RVA: 0x0028A658 File Offset: 0x00288858
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

		// Token: 0x06011536 RID: 70966 RVA: 0x0028A691 File Offset: 0x00288891
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

		// Token: 0x06011537 RID: 70967 RVA: 0x0028A6BF File Offset: 0x002888BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011538 RID: 70968 RVA: 0x0028A6C8 File Offset: 0x002888C8
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

		// Token: 0x04006DE5 RID: 28133
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DE6 RID: 28134
		public const int FactorsFieldNumber = 1;

		// Token: 0x04006DE7 RID: 28135
		private static readonly FieldCodec<int> _repeated_factors_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04006DE8 RID: 28136
		private readonly RepeatedField<int> factors_ = new RepeatedField<int>();
	}
}
