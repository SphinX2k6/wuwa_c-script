using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012D1 RID: 4817
	public sealed class SolarSchoolWeekSchedulePb : IMessage<SolarSchoolWeekSchedulePb>, IMessage, IEquatable<SolarSchoolWeekSchedulePb>, IDeepCloneable<SolarSchoolWeekSchedulePb>, IBufferMessage
	{
		// Token: 0x06019B5F RID: 105311 RVA: 0x003C04AC File Offset: 0x003BE6AC
		[NullableContext(1)]
		public static SolarSchoolWeekSchedulePb Create()
		{
			return new SolarSchoolWeekSchedulePb();
		}

		// Token: 0x17005711 RID: 22289
		// (get) Token: 0x06019B60 RID: 105312 RVA: 0x003C04B3 File Offset: 0x003BE6B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SolarSchoolWeekSchedulePb> Parser
		{
			get
			{
				return SolarSchoolWeekSchedulePb._parser;
			}
		}

		// Token: 0x17005712 RID: 22290
		// (get) Token: 0x06019B61 RID: 105313 RVA: 0x003C04BA File Offset: 0x003BE6BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005713 RID: 22291
		// (get) Token: 0x06019B62 RID: 105314 RVA: 0x003C04BD File Offset: 0x003BE6BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolWeekSchedulePb.Descriptor;
			}
		}

		// Token: 0x06019B63 RID: 105315 RVA: 0x003C04C4 File Offset: 0x003BE6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolWeekSchedulePb()
		{
		}

		// Token: 0x06019B64 RID: 105316 RVA: 0x003C04F0 File Offset: 0x003BE6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolWeekSchedulePb(SolarSchoolWeekSchedulePb other) : this()
		{
			this.cell_ = other.cell_.Clone();
			this.instanceId_ = other.instanceId_.Clone();
			this.skippedWeekday_ = other.skippedWeekday_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019B65 RID: 105317 RVA: 0x003C0547 File Offset: 0x003BE747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolWeekSchedulePb Clone()
		{
			return new SolarSchoolWeekSchedulePb(this);
		}

		// Token: 0x17005714 RID: 22292
		// (get) Token: 0x06019B66 RID: 105318 RVA: 0x003C054F File Offset: 0x003BE74F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SolarSchoolSlotCellPb> Cell
		{
			get
			{
				return this.cell_;
			}
		}

		// Token: 0x17005715 RID: 22293
		// (get) Token: 0x06019B67 RID: 105319 RVA: 0x003C0557 File Offset: 0x003BE757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> InstanceId
		{
			get
			{
				return this.instanceId_;
			}
		}

		// Token: 0x17005716 RID: 22294
		// (get) Token: 0x06019B68 RID: 105320 RVA: 0x003C055F File Offset: 0x003BE75F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkippedWeekday
		{
			get
			{
				return this.skippedWeekday_;
			}
		}

		// Token: 0x06019B69 RID: 105321 RVA: 0x003C0567 File Offset: 0x003BE767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolWeekSchedulePb);
		}

		// Token: 0x06019B6A RID: 105322 RVA: 0x003C0578 File Offset: 0x003BE778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolWeekSchedulePb other)
		{
			return other != null && (other == this || (this.cell_.Equals(other.cell_) && this.instanceId_.Equals(other.instanceId_) && this.skippedWeekday_.Equals(other.skippedWeekday_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019B6B RID: 105323 RVA: 0x003C05E0 File Offset: 0x003BE7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.cell_.GetHashCode();
			num ^= this.instanceId_.GetHashCode();
			num ^= this.skippedWeekday_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019B6C RID: 105324 RVA: 0x003C0630 File Offset: 0x003BE830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019B6D RID: 105325 RVA: 0x003C063D File Offset: 0x003BE83D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019B6E RID: 105326 RVA: 0x003C0648 File Offset: 0x003BE848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.cell_.WriteTo(ref output, SolarSchoolWeekSchedulePb._repeated_cell_codec);
			this.instanceId_.WriteTo(ref output, SolarSchoolWeekSchedulePb._repeated_instanceId_codec);
			this.skippedWeekday_.WriteTo(ref output, SolarSchoolWeekSchedulePb._repeated_skippedWeekday_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019B6F RID: 105327 RVA: 0x003C069C File Offset: 0x003BE89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.cell_.CalculateSize(SolarSchoolWeekSchedulePb._repeated_cell_codec);
			num += this.instanceId_.CalculateSize(SolarSchoolWeekSchedulePb._repeated_instanceId_codec);
			num += this.skippedWeekday_.CalculateSize(SolarSchoolWeekSchedulePb._repeated_skippedWeekday_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019B70 RID: 105328 RVA: 0x003C06FC File Offset: 0x003BE8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolWeekSchedulePb other)
		{
			if (other == null)
			{
				return;
			}
			this.cell_.Add(other.cell_);
			this.instanceId_.Add(other.instanceId_);
			this.skippedWeekday_.Add(other.skippedWeekday_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019B71 RID: 105329 RVA: 0x003C0757 File Offset: 0x003BE957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019B72 RID: 105330 RVA: 0x003C0760 File Offset: 0x003BE960
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
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.cell_.AddEntriesFrom(ref input, SolarSchoolWeekSchedulePb._repeated_cell_codec);
						continue;
					}
					if (num == 16U)
					{
						goto IL_50;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_50;
					}
					if (num == 24U || num == 26U)
					{
						this.skippedWeekday_.AddEntriesFrom(ref input, SolarSchoolWeekSchedulePb._repeated_skippedWeekday_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_50:
				this.instanceId_.AddEntriesFrom(ref input, SolarSchoolWeekSchedulePb._repeated_instanceId_codec);
			}
		}

		// Token: 0x040097D7 RID: 38871
		private static readonly MessageParser<SolarSchoolWeekSchedulePb> _parser = new MessageParser<SolarSchoolWeekSchedulePb>(() => new SolarSchoolWeekSchedulePb());

		// Token: 0x040097D8 RID: 38872
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097D9 RID: 38873
		public const int CellFieldNumber = 1;

		// Token: 0x040097DA RID: 38874
		private static readonly FieldCodec<SolarSchoolSlotCellPb> _repeated_cell_codec = FieldCodec.ForMessage<SolarSchoolSlotCellPb>(10U, SolarSchoolSlotCellPb.Parser);

		// Token: 0x040097DB RID: 38875
		private readonly RepeatedField<SolarSchoolSlotCellPb> cell_ = new RepeatedField<SolarSchoolSlotCellPb>();

		// Token: 0x040097DC RID: 38876
		public const int InstanceIdFieldNumber = 2;

		// Token: 0x040097DD RID: 38877
		private static readonly FieldCodec<int> _repeated_instanceId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040097DE RID: 38878
		private readonly RepeatedField<int> instanceId_ = new RepeatedField<int>();

		// Token: 0x040097DF RID: 38879
		public const int SkippedWeekdayFieldNumber = 3;

		// Token: 0x040097E0 RID: 38880
		private static readonly FieldCodec<int> _repeated_skippedWeekday_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040097E1 RID: 38881
		private readonly RepeatedField<int> skippedWeekday_ = new RepeatedField<int>();
	}
}
