using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C9A RID: 3226
	public sealed class PhantomBattleNpcCardUpdateInfo : IMessage<PhantomBattleNpcCardUpdateInfo>, IMessage, IEquatable<PhantomBattleNpcCardUpdateInfo>, IDeepCloneable<PhantomBattleNpcCardUpdateInfo>, IBufferMessage
	{
		// Token: 0x060117BE RID: 71614 RVA: 0x0028FCA9 File Offset: 0x0028DEA9
		[NullableContext(1)]
		public static PhantomBattleNpcCardUpdateInfo Create()
		{
			return new PhantomBattleNpcCardUpdateInfo();
		}

		// Token: 0x170039EA RID: 14826
		// (get) Token: 0x060117BF RID: 71615 RVA: 0x0028FCB0 File Offset: 0x0028DEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039EB RID: 14827
		// (get) Token: 0x060117C0 RID: 71616 RVA: 0x0028FCB3 File Offset: 0x0028DEB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleNpcCardUpdateInfo.Descriptor;
			}
		}

		// Token: 0x060117C1 RID: 71617 RVA: 0x0028FCBA File Offset: 0x0028DEBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleNpcCardUpdateInfo()
		{
		}

		// Token: 0x060117C2 RID: 71618 RVA: 0x0028FCD8 File Offset: 0x0028DED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleNpcCardUpdateInfo(PhantomBattleNpcCardUpdateInfo other) : this()
		{
			this.cardUId_ = other.cardUId_;
			this.factors_ = other.factors_.Clone();
			this.canUnlimitedEvolve_ = other.canUnlimitedEvolve_;
			this.lockFactor_ = other.lockFactor_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060117C3 RID: 71619 RVA: 0x0028FD36 File Offset: 0x0028DF36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleNpcCardUpdateInfo Clone()
		{
			return new PhantomBattleNpcCardUpdateInfo(this);
		}

		// Token: 0x170039EC RID: 14828
		// (get) Token: 0x060117C4 RID: 71620 RVA: 0x0028FD3E File Offset: 0x0028DF3E
		// (set) Token: 0x060117C5 RID: 71621 RVA: 0x0028FD46 File Offset: 0x0028DF46
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

		// Token: 0x170039ED RID: 14829
		// (get) Token: 0x060117C6 RID: 71622 RVA: 0x0028FD4F File Offset: 0x0028DF4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Factors
		{
			get
			{
				return this.factors_;
			}
		}

		// Token: 0x170039EE RID: 14830
		// (get) Token: 0x060117C7 RID: 71623 RVA: 0x0028FD57 File Offset: 0x0028DF57
		// (set) Token: 0x060117C8 RID: 71624 RVA: 0x0028FD5F File Offset: 0x0028DF5F
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

		// Token: 0x170039EF RID: 14831
		// (get) Token: 0x060117C9 RID: 71625 RVA: 0x0028FD68 File Offset: 0x0028DF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LockFactor
		{
			get
			{
				return this.lockFactor_;
			}
		}

		// Token: 0x060117CA RID: 71626 RVA: 0x0028FD70 File Offset: 0x0028DF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleNpcCardUpdateInfo);
		}

		// Token: 0x060117CB RID: 71627 RVA: 0x0028FD80 File Offset: 0x0028DF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleNpcCardUpdateInfo other)
		{
			return other != null && (other == this || (this.CardUId == other.CardUId && this.Factors.Equals(other.Factors) && this.CanUnlimitedEvolve == other.CanUnlimitedEvolve && this.lockFactor_.Equals(other.lockFactor_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060117CC RID: 71628 RVA: 0x0028FDF4 File Offset: 0x0028DFF4
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
			num ^= this.lockFactor_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060117CD RID: 71629 RVA: 0x0028FE68 File Offset: 0x0028E068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060117CE RID: 71630 RVA: 0x0028FE75 File Offset: 0x0028E075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060117CF RID: 71631 RVA: 0x0028FE80 File Offset: 0x0028E080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CardUId);
			}
			this.factors_.WriteTo(ref output, PhantomBattleNpcCardUpdateInfo._map_factors_codec);
			if (this.CanUnlimitedEvolve)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.CanUnlimitedEvolve);
			}
			this.lockFactor_.WriteTo(ref output, PhantomBattleNpcCardUpdateInfo._repeated_lockFactor_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060117D0 RID: 71632 RVA: 0x0028FEFC File Offset: 0x0028E0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardUId);
			}
			num += this.factors_.CalculateSize(PhantomBattleNpcCardUpdateInfo._map_factors_codec);
			if (this.CanUnlimitedEvolve)
			{
				num += 2;
			}
			num += this.lockFactor_.CalculateSize(PhantomBattleNpcCardUpdateInfo._repeated_lockFactor_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060117D1 RID: 71633 RVA: 0x0028FF6C File Offset: 0x0028E16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleNpcCardUpdateInfo other)
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
			this.lockFactor_.Add(other.lockFactor_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060117D2 RID: 71634 RVA: 0x0028FFDE File Offset: 0x0028E1DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060117D3 RID: 71635 RVA: 0x0028FFE8 File Offset: 0x0028E1E8
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.CardUId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.factors_.AddEntriesFrom(ref input, PhantomBattleNpcCardUpdateInfo._map_factors_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.CanUnlimitedEvolve = input.ReadBool();
						continue;
					}
					if (num == 32U || num == 34U)
					{
						this.lockFactor_.AddEntriesFrom(ref input, PhantomBattleNpcCardUpdateInfo._repeated_lockFactor_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006E4D RID: 28237
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E4E RID: 28238
		public const int CardUIdFieldNumber = 1;

		// Token: 0x04006E4F RID: 28239
		private int cardUId_;

		// Token: 0x04006E50 RID: 28240
		public const int FactorsFieldNumber = 2;

		// Token: 0x04006E51 RID: 28241
		private static readonly MapField<int, int>.Codec _map_factors_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x04006E52 RID: 28242
		private readonly MapField<int, int> factors_ = new MapField<int, int>();

		// Token: 0x04006E53 RID: 28243
		public const int CanUnlimitedEvolveFieldNumber = 3;

		// Token: 0x04006E54 RID: 28244
		private bool canUnlimitedEvolve_;

		// Token: 0x04006E55 RID: 28245
		public const int LockFactorFieldNumber = 4;

		// Token: 0x04006E56 RID: 28246
		private static readonly FieldCodec<int> _repeated_lockFactor_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04006E57 RID: 28247
		private readonly RepeatedField<int> lockFactor_ = new RepeatedField<int>();
	}
}
