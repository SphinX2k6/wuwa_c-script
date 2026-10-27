using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A0F RID: 2575
	public sealed class MoonPhaseActivityData : IMessage<MoonPhaseActivityData>, IMessage, IEquatable<MoonPhaseActivityData>, IDeepCloneable<MoonPhaseActivityData>, IBufferMessage
	{
		// Token: 0x0600E148 RID: 57672 RVA: 0x00210085 File Offset: 0x0020E285
		[NullableContext(1)]
		public static MoonPhaseActivityData Create()
		{
			return new MoonPhaseActivityData();
		}

		// Token: 0x17002DAD RID: 11693
		// (get) Token: 0x0600E149 RID: 57673 RVA: 0x0021008C File Offset: 0x0020E28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DAE RID: 11694
		// (get) Token: 0x0600E14A RID: 57674 RVA: 0x0021008F File Offset: 0x0020E28F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoonPhaseActivityData.Descriptor;
			}
		}

		// Token: 0x0600E14B RID: 57675 RVA: 0x00210096 File Offset: 0x0020E296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseActivityData()
		{
		}

		// Token: 0x0600E14C RID: 57676 RVA: 0x002100AC File Offset: 0x0020E2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseActivityData(MoonPhaseActivityData other) : this()
		{
			this.moonPhaseSelects_ = other.moonPhaseSelects_.Clone();
			this.moonPhaseSpReward_ = other.moonPhaseSpReward_;
			this.nowMoonParse_ = other.nowMoonParse_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E14D RID: 57677 RVA: 0x002100F9 File Offset: 0x0020E2F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseActivityData Clone()
		{
			return new MoonPhaseActivityData(this);
		}

		// Token: 0x17002DAF RID: 11695
		// (get) Token: 0x0600E14E RID: 57678 RVA: 0x00210101 File Offset: 0x0020E301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MoonPhaseSelect> MoonPhaseSelects
		{
			get
			{
				return this.moonPhaseSelects_;
			}
		}

		// Token: 0x17002DB0 RID: 11696
		// (get) Token: 0x0600E14F RID: 57679 RVA: 0x00210109 File Offset: 0x0020E309
		// (set) Token: 0x0600E150 RID: 57680 RVA: 0x00210111 File Offset: 0x0020E311
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

		// Token: 0x17002DB1 RID: 11697
		// (get) Token: 0x0600E151 RID: 57681 RVA: 0x0021011A File Offset: 0x0020E31A
		// (set) Token: 0x0600E152 RID: 57682 RVA: 0x00210122 File Offset: 0x0020E322
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

		// Token: 0x0600E153 RID: 57683 RVA: 0x0021012B File Offset: 0x0020E32B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoonPhaseActivityData);
		}

		// Token: 0x0600E154 RID: 57684 RVA: 0x0021013C File Offset: 0x0020E33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoonPhaseActivityData other)
		{
			return other != null && (other == this || (this.moonPhaseSelects_.Equals(other.moonPhaseSelects_) && this.MoonPhaseSpReward == other.MoonPhaseSpReward && this.NowMoonParse == other.NowMoonParse && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E155 RID: 57685 RVA: 0x0021019C File Offset: 0x0020E39C
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

		// Token: 0x0600E156 RID: 57686 RVA: 0x00210202 File Offset: 0x0020E402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E157 RID: 57687 RVA: 0x0021020F File Offset: 0x0020E40F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E158 RID: 57688 RVA: 0x00210218 File Offset: 0x0020E418
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

		// Token: 0x0600E159 RID: 57689 RVA: 0x00210284 File Offset: 0x0020E484
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

		// Token: 0x0600E15A RID: 57690 RVA: 0x002102E4 File Offset: 0x0020E4E4
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

		// Token: 0x0600E15B RID: 57691 RVA: 0x00210345 File Offset: 0x0020E545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E15C RID: 57692 RVA: 0x00210350 File Offset: 0x0020E550
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

		// Token: 0x04005C9F RID: 23711
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005CA0 RID: 23712
		public const int MoonPhaseSelectsFieldNumber = 1;

		// Token: 0x04005CA1 RID: 23713
		private static readonly FieldCodec<MoonPhaseSelect> _repeated_moonPhaseSelects_codec = FieldCodec.ForMessage<MoonPhaseSelect>(10U, MoonPhaseSelect.Parser);

		// Token: 0x04005CA2 RID: 23714
		private readonly RepeatedField<MoonPhaseSelect> moonPhaseSelects_ = new RepeatedField<MoonPhaseSelect>();

		// Token: 0x04005CA3 RID: 23715
		public const int MoonPhaseSpRewardFieldNumber = 2;

		// Token: 0x04005CA4 RID: 23716
		private bool moonPhaseSpReward_;

		// Token: 0x04005CA5 RID: 23717
		public const int NowMoonParseFieldNumber = 3;

		// Token: 0x04005CA6 RID: 23718
		private int nowMoonParse_;
	}
}
