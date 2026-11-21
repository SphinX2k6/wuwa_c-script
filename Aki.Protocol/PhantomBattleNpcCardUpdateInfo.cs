using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C8A RID: 3210
	public sealed class PhantomBattleNpcCardUpdateInfo : IMessage<PhantomBattleNpcCardUpdateInfo>, IMessage, IEquatable<PhantomBattleNpcCardUpdateInfo>, IDeepCloneable<PhantomBattleNpcCardUpdateInfo>, IBufferMessage
	{
		// Token: 0x060116BE RID: 71358 RVA: 0x0028DF3D File Offset: 0x0028C13D
		[NullableContext(1)]
		public static PhantomBattleNpcCardUpdateInfo Create()
		{
			return new PhantomBattleNpcCardUpdateInfo();
		}

		// Token: 0x170039B3 RID: 14771
		// (get) Token: 0x060116BF RID: 71359 RVA: 0x0028DF44 File Offset: 0x0028C144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039B4 RID: 14772
		// (get) Token: 0x060116C0 RID: 71360 RVA: 0x0028DF47 File Offset: 0x0028C147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleNpcCardUpdateInfo.Descriptor;
			}
		}

		// Token: 0x060116C1 RID: 71361 RVA: 0x0028DF4E File Offset: 0x0028C14E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleNpcCardUpdateInfo()
		{
		}

		// Token: 0x060116C2 RID: 71362 RVA: 0x0028DF6C File Offset: 0x0028C16C
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

		// Token: 0x060116C3 RID: 71363 RVA: 0x0028DFCA File Offset: 0x0028C1CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleNpcCardUpdateInfo Clone()
		{
			return new PhantomBattleNpcCardUpdateInfo(this);
		}

		// Token: 0x170039B5 RID: 14773
		// (get) Token: 0x060116C4 RID: 71364 RVA: 0x0028DFD2 File Offset: 0x0028C1D2
		// (set) Token: 0x060116C5 RID: 71365 RVA: 0x0028DFDA File Offset: 0x0028C1DA
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

		// Token: 0x170039B6 RID: 14774
		// (get) Token: 0x060116C6 RID: 71366 RVA: 0x0028DFE3 File Offset: 0x0028C1E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Factors
		{
			get
			{
				return this.factors_;
			}
		}

		// Token: 0x170039B7 RID: 14775
		// (get) Token: 0x060116C7 RID: 71367 RVA: 0x0028DFEB File Offset: 0x0028C1EB
		// (set) Token: 0x060116C8 RID: 71368 RVA: 0x0028DFF3 File Offset: 0x0028C1F3
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

		// Token: 0x170039B8 RID: 14776
		// (get) Token: 0x060116C9 RID: 71369 RVA: 0x0028DFFC File Offset: 0x0028C1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LockFactor
		{
			get
			{
				return this.lockFactor_;
			}
		}

		// Token: 0x060116CA RID: 71370 RVA: 0x0028E004 File Offset: 0x0028C204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleNpcCardUpdateInfo);
		}

		// Token: 0x060116CB RID: 71371 RVA: 0x0028E014 File Offset: 0x0028C214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleNpcCardUpdateInfo other)
		{
			return other != null && (other == this || (this.CardUId == other.CardUId && this.Factors.Equals(other.Factors) && this.CanUnlimitedEvolve == other.CanUnlimitedEvolve && this.lockFactor_.Equals(other.lockFactor_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060116CC RID: 71372 RVA: 0x0028E088 File Offset: 0x0028C288
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

		// Token: 0x060116CD RID: 71373 RVA: 0x0028E0FC File Offset: 0x0028C2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060116CE RID: 71374 RVA: 0x0028E109 File Offset: 0x0028C309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060116CF RID: 71375 RVA: 0x0028E114 File Offset: 0x0028C314
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

		// Token: 0x060116D0 RID: 71376 RVA: 0x0028E190 File Offset: 0x0028C390
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

		// Token: 0x060116D1 RID: 71377 RVA: 0x0028E200 File Offset: 0x0028C400
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

		// Token: 0x060116D2 RID: 71378 RVA: 0x0028E272 File Offset: 0x0028C472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060116D3 RID: 71379 RVA: 0x0028E27C File Offset: 0x0028C47C
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

		// Token: 0x04006E61 RID: 28257
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E62 RID: 28258
		public const int CardUIdFieldNumber = 1;

		// Token: 0x04006E63 RID: 28259
		private int cardUId_;

		// Token: 0x04006E64 RID: 28260
		public const int FactorsFieldNumber = 2;

		// Token: 0x04006E65 RID: 28261
		private static readonly MapField<int, int>.Codec _map_factors_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x04006E66 RID: 28262
		private readonly MapField<int, int> factors_ = new MapField<int, int>();

		// Token: 0x04006E67 RID: 28263
		public const int CanUnlimitedEvolveFieldNumber = 3;

		// Token: 0x04006E68 RID: 28264
		private bool canUnlimitedEvolve_;

		// Token: 0x04006E69 RID: 28265
		public const int LockFactorFieldNumber = 4;

		// Token: 0x04006E6A RID: 28266
		private static readonly FieldCodec<int> _repeated_lockFactor_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04006E6B RID: 28267
		private readonly RepeatedField<int> lockFactor_ = new RepeatedField<int>();
	}
}
