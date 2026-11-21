using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C59 RID: 3161
	[NetMessage(EMessageId.PhantomBattleCardUpdateNotify)]
	public sealed class PhantomBattleCardUpdateNotify : IMessage<PhantomBattleCardUpdateNotify>, IMessage, IEquatable<PhantomBattleCardUpdateNotify>, IDeepCloneable<PhantomBattleCardUpdateNotify>, IBufferMessage
	{
		// Token: 0x06011286 RID: 70278 RVA: 0x00283781 File Offset: 0x00281981
		[NullableContext(1)]
		public static PhantomBattleCardUpdateNotify Create()
		{
			return new PhantomBattleCardUpdateNotify();
		}

		// Token: 0x170038B8 RID: 14520
		// (get) Token: 0x06011287 RID: 70279 RVA: 0x00283788 File Offset: 0x00281988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038B9 RID: 14521
		// (get) Token: 0x06011288 RID: 70280 RVA: 0x0028378B File Offset: 0x0028198B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06011289 RID: 70281 RVA: 0x00283792 File Offset: 0x00281992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardUpdateNotify()
		{
		}

		// Token: 0x0601128A RID: 70282 RVA: 0x002837B0 File Offset: 0x002819B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardUpdateNotify(PhantomBattleCardUpdateNotify other) : this()
		{
			this.cardUId_ = other.cardUId_;
			this.factors_ = other.factors_.Clone();
			this.canUnlimitedEvolve_ = other.canUnlimitedEvolve_;
			this.lockFactors_ = other.lockFactors_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601128B RID: 70283 RVA: 0x0028380E File Offset: 0x00281A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardUpdateNotify Clone()
		{
			return new PhantomBattleCardUpdateNotify(this);
		}

		// Token: 0x170038BA RID: 14522
		// (get) Token: 0x0601128C RID: 70284 RVA: 0x00283816 File Offset: 0x00281A16
		// (set) Token: 0x0601128D RID: 70285 RVA: 0x0028381E File Offset: 0x00281A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardUId
		{
			get
			{
				return this.cardUId_;
			}
			set
			{
				this.cardUId_ = value;
			}
		}

		// Token: 0x170038BB RID: 14523
		// (get) Token: 0x0601128E RID: 70286 RVA: 0x00283827 File Offset: 0x00281A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Factors
		{
			get
			{
				return this.factors_;
			}
		}

		// Token: 0x170038BC RID: 14524
		// (get) Token: 0x0601128F RID: 70287 RVA: 0x0028382F File Offset: 0x00281A2F
		// (set) Token: 0x06011290 RID: 70288 RVA: 0x00283837 File Offset: 0x00281A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanUnlimitedEvolve
		{
			get
			{
				return this.canUnlimitedEvolve_;
			}
			set
			{
				this.canUnlimitedEvolve_ = value;
			}
		}

		// Token: 0x170038BD RID: 14525
		// (get) Token: 0x06011291 RID: 70289 RVA: 0x00283840 File Offset: 0x00281A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LockFactors
		{
			get
			{
				return this.lockFactors_;
			}
		}

		// Token: 0x06011292 RID: 70290 RVA: 0x00283848 File Offset: 0x00281A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardUpdateNotify);
		}

		// Token: 0x06011293 RID: 70291 RVA: 0x00283858 File Offset: 0x00281A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardUpdateNotify other)
		{
			return other != null && (other == this || (this.CardUId == other.CardUId && this.Factors.Equals(other.Factors) && this.CanUnlimitedEvolve == other.CanUnlimitedEvolve && this.lockFactors_.Equals(other.lockFactors_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011294 RID: 70292 RVA: 0x002838CC File Offset: 0x00281ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CardUId != 0)
			{
				num ^= this.CardUId.GetHashCode();
			}
			num ^= this.Factors.GetHashCode();
			if (this.CanUnlimitedEvolve)
			{
				num ^= this.CanUnlimitedEvolve.GetHashCode();
			}
			num ^= this.lockFactors_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011295 RID: 70293 RVA: 0x00283940 File Offset: 0x00281B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011296 RID: 70294 RVA: 0x0028394D File Offset: 0x00281B4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011297 RID: 70295 RVA: 0x00283958 File Offset: 0x00281B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CanUnlimitedEvolve)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.CanUnlimitedEvolve);
			}
			if (this.CardUId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.CardUId);
			}
			this.lockFactors_.WriteTo(ref output, PhantomBattleCardUpdateNotify._repeated_lockFactors_codec);
			this.factors_.WriteTo(ref output, PhantomBattleCardUpdateNotify._map_factors_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011298 RID: 70296 RVA: 0x002839D4 File Offset: 0x00281BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardUId);
			}
			num += this.factors_.CalculateSize(PhantomBattleCardUpdateNotify._map_factors_codec);
			if (this.CanUnlimitedEvolve)
			{
				num += 2;
			}
			num += this.lockFactors_.CalculateSize(PhantomBattleCardUpdateNotify._repeated_lockFactors_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011299 RID: 70297 RVA: 0x00283A44 File Offset: 0x00281C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CardUId != 0)
			{
				this.CardUId = other.CardUId;
			}
			this.factors_.MergeFrom(other.factors_);
			if (other.CanUnlimitedEvolve)
			{
				this.CanUnlimitedEvolve = other.CanUnlimitedEvolve;
			}
			this.lockFactors_.Add(other.lockFactors_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601129A RID: 70298 RVA: 0x00283AB6 File Offset: 0x00281CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601129B RID: 70299 RVA: 0x00283AC0 File Offset: 0x00281CC0
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
				if (num <= 56U)
				{
					if (num == 48U)
					{
						this.CanUnlimitedEvolve = input.ReadBool();
						continue;
					}
					if (num == 56U)
					{
						this.CardUId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U || num == 66U)
					{
						this.lockFactors_.AddEntriesFrom(ref input, PhantomBattleCardUpdateNotify._repeated_lockFactors_codec);
						continue;
					}
					if (num == 106U)
					{
						this.factors_.AddEntriesFrom(ref input, PhantomBattleCardUpdateNotify._map_factors_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006CF8 RID: 27896
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CF9 RID: 27897
		public const int CardUIdFieldNumber = 7;

		// Token: 0x04006CFA RID: 27898
		private int cardUId_;

		// Token: 0x04006CFB RID: 27899
		public const int FactorsFieldNumber = 13;

		// Token: 0x04006CFC RID: 27900
		private static readonly MapField<int, int>.Codec _map_factors_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 106U);

		// Token: 0x04006CFD RID: 27901
		private readonly MapField<int, int> factors_ = new MapField<int, int>();

		// Token: 0x04006CFE RID: 27902
		public const int CanUnlimitedEvolveFieldNumber = 6;

		// Token: 0x04006CFF RID: 27903
		private bool canUnlimitedEvolve_;

		// Token: 0x04006D00 RID: 27904
		public const int LockFactorsFieldNumber = 8;

		// Token: 0x04006D01 RID: 27905
		private static readonly FieldCodec<int> _repeated_lockFactors_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04006D02 RID: 27906
		private readonly RepeatedField<int> lockFactors_ = new RepeatedField<int>();
	}
}
