using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009FE RID: 2558
	public sealed class MoonPhaseActivityData : IMessage<MoonPhaseActivityData>, IMessage, IEquatable<MoonPhaseActivityData>, IDeepCloneable<MoonPhaseActivityData>, IBufferMessage
	{
		// Token: 0x0600E02E RID: 57390 RVA: 0x0020DE94 File Offset: 0x0020C094
		[NullableContext(1)]
		public static MoonPhaseActivityData Create()
		{
			return new MoonPhaseActivityData();
		}

		// Token: 0x17002D6F RID: 11631
		// (get) Token: 0x0600E02F RID: 57391 RVA: 0x0020DE9B File Offset: 0x0020C09B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D70 RID: 11632
		// (get) Token: 0x0600E030 RID: 57392 RVA: 0x0020DE9E File Offset: 0x0020C09E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoonPhaseActivityData.Descriptor;
			}
		}

		// Token: 0x0600E031 RID: 57393 RVA: 0x0020DEA5 File Offset: 0x0020C0A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseActivityData()
		{
		}

		// Token: 0x0600E032 RID: 57394 RVA: 0x0020DEB8 File Offset: 0x0020C0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseActivityData(MoonPhaseActivityData other) : this()
		{
			this.moonPhaseSelects_ = other.moonPhaseSelects_.Clone();
			this.moonPhaseSpReward_ = other.moonPhaseSpReward_;
			this.nowMoonParse_ = other.nowMoonParse_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E033 RID: 57395 RVA: 0x0020DF05 File Offset: 0x0020C105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseActivityData Clone()
		{
			return new MoonPhaseActivityData(this);
		}

		// Token: 0x17002D71 RID: 11633
		// (get) Token: 0x0600E034 RID: 57396 RVA: 0x0020DF0D File Offset: 0x0020C10D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MoonPhaseSelect> MoonPhaseSelects
		{
			get
			{
				return this.moonPhaseSelects_;
			}
		}

		// Token: 0x17002D72 RID: 11634
		// (get) Token: 0x0600E035 RID: 57397 RVA: 0x0020DF15 File Offset: 0x0020C115
		// (set) Token: 0x0600E036 RID: 57398 RVA: 0x0020DF1D File Offset: 0x0020C11D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MoonPhaseSpReward
		{
			get
			{
				return this.moonPhaseSpReward_;
			}
			set
			{
				this.moonPhaseSpReward_ = value;
			}
		}

		// Token: 0x17002D73 RID: 11635
		// (get) Token: 0x0600E037 RID: 57399 RVA: 0x0020DF26 File Offset: 0x0020C126
		// (set) Token: 0x0600E038 RID: 57400 RVA: 0x0020DF2E File Offset: 0x0020C12E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NowMoonParse
		{
			get
			{
				return this.nowMoonParse_;
			}
			set
			{
				this.nowMoonParse_ = value;
			}
		}

		// Token: 0x0600E039 RID: 57401 RVA: 0x0020DF37 File Offset: 0x0020C137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoonPhaseActivityData);
		}

		// Token: 0x0600E03A RID: 57402 RVA: 0x0020DF48 File Offset: 0x0020C148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoonPhaseActivityData other)
		{
			return other != null && (other == this || (this.moonPhaseSelects_.Equals(other.moonPhaseSelects_) && this.MoonPhaseSpReward == other.MoonPhaseSpReward && this.NowMoonParse == other.NowMoonParse && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E03B RID: 57403 RVA: 0x0020DFA8 File Offset: 0x0020C1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.moonPhaseSelects_.GetHashCode();
			if (this.MoonPhaseSpReward)
			{
				num ^= this.MoonPhaseSpReward.GetHashCode();
			}
			if (this.NowMoonParse != 0)
			{
				num ^= this.NowMoonParse.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E03C RID: 57404 RVA: 0x0020E00E File Offset: 0x0020C20E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E03D RID: 57405 RVA: 0x0020E01B File Offset: 0x0020C21B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E03E RID: 57406 RVA: 0x0020E024 File Offset: 0x0020C224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.moonPhaseSelects_.WriteTo(ref output, MoonPhaseActivityData._repeated_moonPhaseSelects_codec);
			if (this.MoonPhaseSpReward)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.MoonPhaseSpReward);
			}
			if (this.NowMoonParse != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.NowMoonParse);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E03F RID: 57407 RVA: 0x0020E090 File Offset: 0x0020C290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.moonPhaseSelects_.CalculateSize(MoonPhaseActivityData._repeated_moonPhaseSelects_codec);
			if (this.MoonPhaseSpReward)
			{
				num += 2;
			}
			if (this.NowMoonParse != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NowMoonParse);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E040 RID: 57408 RVA: 0x0020E0F0 File Offset: 0x0020C2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoonPhaseActivityData other)
		{
			if (other == null)
			{
				return;
			}
			this.moonPhaseSelects_.Add(other.moonPhaseSelects_);
			if (other.MoonPhaseSpReward)
			{
				this.MoonPhaseSpReward = other.MoonPhaseSpReward;
			}
			if (other.NowMoonParse != 0)
			{
				this.NowMoonParse = other.NowMoonParse;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E041 RID: 57409 RVA: 0x0020E151 File Offset: 0x0020C351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E042 RID: 57410 RVA: 0x0020E15C File Offset: 0x0020C35C
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.NowMoonParse = input.ReadInt32();
						}
					}
					else
					{
						this.MoonPhaseSpReward = input.ReadBool();
					}
				}
				else
				{
					this.moonPhaseSelects_.AddEntriesFrom(ref input, MoonPhaseActivityData._repeated_moonPhaseSelects_codec);
				}
			}
		}

		// Token: 0x04005CA8 RID: 23720
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005CA9 RID: 23721
		public const int MoonPhaseSelectsFieldNumber = 1;

		// Token: 0x04005CAA RID: 23722
		private static readonly FieldCodec<MoonPhaseSelect> _repeated_moonPhaseSelects_codec = FieldCodec.ForMessage<MoonPhaseSelect>(10U, MoonPhaseSelect.Parser);

		// Token: 0x04005CAB RID: 23723
		private readonly RepeatedField<MoonPhaseSelect> moonPhaseSelects_ = new RepeatedField<MoonPhaseSelect>();

		// Token: 0x04005CAC RID: 23724
		public const int MoonPhaseSpRewardFieldNumber = 2;

		// Token: 0x04005CAD RID: 23725
		private bool moonPhaseSpReward_;

		// Token: 0x04005CAE RID: 23726
		public const int NowMoonParseFieldNumber = 3;

		// Token: 0x04005CAF RID: 23727
		private int nowMoonParse_;
	}
}
