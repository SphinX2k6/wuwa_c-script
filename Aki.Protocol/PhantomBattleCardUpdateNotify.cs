using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C69 RID: 3177
	[NetMessage(EMessageId.PhantomBattleCardUpdateNotify)]
	public sealed class PhantomBattleCardUpdateNotify : IMessage<PhantomBattleCardUpdateNotify>, IMessage, IEquatable<PhantomBattleCardUpdateNotify>, IDeepCloneable<PhantomBattleCardUpdateNotify>, IBufferMessage
	{
		// Token: 0x06011386 RID: 70534 RVA: 0x002854F1 File Offset: 0x002836F1
		[NullableContext(1)]
		public static PhantomBattleCardUpdateNotify Create()
		{
			return new PhantomBattleCardUpdateNotify();
		}

		// Token: 0x170038EF RID: 14575
		// (get) Token: 0x06011387 RID: 70535 RVA: 0x002854F8 File Offset: 0x002836F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038F0 RID: 14576
		// (get) Token: 0x06011388 RID: 70536 RVA: 0x002854FB File Offset: 0x002836FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06011389 RID: 70537 RVA: 0x00285502 File Offset: 0x00283702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardUpdateNotify()
		{
		}

		// Token: 0x0601138A RID: 70538 RVA: 0x00285520 File Offset: 0x00283720
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

		// Token: 0x0601138B RID: 70539 RVA: 0x0028557E File Offset: 0x0028377E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardUpdateNotify Clone()
		{
			return new PhantomBattleCardUpdateNotify(this);
		}

		// Token: 0x170038F1 RID: 14577
		// (get) Token: 0x0601138C RID: 70540 RVA: 0x00285586 File Offset: 0x00283786
		// (set) Token: 0x0601138D RID: 70541 RVA: 0x0028558E File Offset: 0x0028378E
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

		// Token: 0x170038F2 RID: 14578
		// (get) Token: 0x0601138E RID: 70542 RVA: 0x00285597 File Offset: 0x00283797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Factors
		{
			get
			{
				return this.factors_;
			}
		}

		// Token: 0x170038F3 RID: 14579
		// (get) Token: 0x0601138F RID: 70543 RVA: 0x0028559F File Offset: 0x0028379F
		// (set) Token: 0x06011390 RID: 70544 RVA: 0x002855A7 File Offset: 0x002837A7
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

		// Token: 0x170038F4 RID: 14580
		// (get) Token: 0x06011391 RID: 70545 RVA: 0x002855B0 File Offset: 0x002837B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LockFactors
		{
			get
			{
				return this.lockFactors_;
			}
		}

		// Token: 0x06011392 RID: 70546 RVA: 0x002855B8 File Offset: 0x002837B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardUpdateNotify);
		}

		// Token: 0x06011393 RID: 70547 RVA: 0x002855C8 File Offset: 0x002837C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardUpdateNotify other)
		{
			return other != null && (other == this || (this.CardUId == other.CardUId && this.Factors.Equals(other.Factors) && this.CanUnlimitedEvolve == other.CanUnlimitedEvolve && this.lockFactors_.Equals(other.lockFactors_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011394 RID: 70548 RVA: 0x0028563C File Offset: 0x0028383C
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

		// Token: 0x06011395 RID: 70549 RVA: 0x002856B0 File Offset: 0x002838B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011396 RID: 70550 RVA: 0x002856BD File Offset: 0x002838BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011397 RID: 70551 RVA: 0x002856C8 File Offset: 0x002838C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lockFactors_.WriteTo(ref output, PhantomBattleCardUpdateNotify._repeated_lockFactors_codec);
			if (this.CardUId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.CardUId);
			}
			if (this.CanUnlimitedEvolve)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.CanUnlimitedEvolve);
			}
			this.factors_.WriteTo(ref output, PhantomBattleCardUpdateNotify._map_factors_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011398 RID: 70552 RVA: 0x00285744 File Offset: 0x00283944
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

		// Token: 0x06011399 RID: 70553 RVA: 0x002857B4 File Offset: 0x002839B4
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

		// Token: 0x0601139A RID: 70554 RVA: 0x00285826 File Offset: 0x00283A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601139B RID: 70555 RVA: 0x00285830 File Offset: 0x00283A30
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
				if (num <= 74U)
				{
					if (num == 72U || num == 74U)
					{
						this.lockFactors_.AddEntriesFrom(ref input, PhantomBattleCardUpdateNotify._repeated_lockFactors_codec);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.CardUId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.CanUnlimitedEvolve = input.ReadBool();
						continue;
					}
					if (num == 122U)
					{
						this.factors_.AddEntriesFrom(ref input, PhantomBattleCardUpdateNotify._map_factors_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006CE4 RID: 27876
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CE5 RID: 27877
		public const int CardUIdFieldNumber = 12;

		// Token: 0x04006CE6 RID: 27878
		private int cardUId_;

		// Token: 0x04006CE7 RID: 27879
		public const int FactorsFieldNumber = 15;

		// Token: 0x04006CE8 RID: 27880
		private static readonly MapField<int, int>.Codec _map_factors_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 122U);

		// Token: 0x04006CE9 RID: 27881
		private readonly MapField<int, int> factors_ = new MapField<int, int>();

		// Token: 0x04006CEA RID: 27882
		public const int CanUnlimitedEvolveFieldNumber = 14;

		// Token: 0x04006CEB RID: 27883
		private bool canUnlimitedEvolve_;

		// Token: 0x04006CEC RID: 27884
		public const int LockFactorsFieldNumber = 9;

		// Token: 0x04006CED RID: 27885
		private static readonly FieldCodec<int> _repeated_lockFactors_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04006CEE RID: 27886
		private readonly RepeatedField<int> lockFactors_ = new RepeatedField<int>();
	}
}
