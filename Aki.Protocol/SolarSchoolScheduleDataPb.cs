using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012C3 RID: 4803
	public sealed class SolarSchoolScheduleDataPb : IMessage<SolarSchoolScheduleDataPb>, IMessage, IEquatable<SolarSchoolScheduleDataPb>, IDeepCloneable<SolarSchoolScheduleDataPb>, IBufferMessage
	{
		// Token: 0x06019A3B RID: 105019 RVA: 0x003BDD00 File Offset: 0x003BBF00
		[NullableContext(1)]
		public static SolarSchoolScheduleDataPb Create()
		{
			return new SolarSchoolScheduleDataPb();
		}

		// Token: 0x170056D2 RID: 22226
		// (get) Token: 0x06019A3C RID: 105020 RVA: 0x003BDD07 File Offset: 0x003BBF07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056D3 RID: 22227
		// (get) Token: 0x06019A3D RID: 105021 RVA: 0x003BDD0A File Offset: 0x003BBF0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolScheduleDataPb.Descriptor;
			}
		}

		// Token: 0x06019A3E RID: 105022 RVA: 0x003BDD11 File Offset: 0x003BBF11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolScheduleDataPb()
		{
		}

		// Token: 0x06019A3F RID: 105023 RVA: 0x003BDD24 File Offset: 0x003BBF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolScheduleDataPb(SolarSchoolScheduleDataPb other) : this()
		{
			this.history_ = other.history_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019A40 RID: 105024 RVA: 0x003BDD4E File Offset: 0x003BBF4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolScheduleDataPb Clone()
		{
			return new SolarSchoolScheduleDataPb(this);
		}

		// Token: 0x170056D4 RID: 22228
		// (get) Token: 0x06019A41 RID: 105025 RVA: 0x003BDD56 File Offset: 0x003BBF56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SolarSchoolWeekSchedulePb> History
		{
			get
			{
				return this.history_;
			}
		}

		// Token: 0x06019A42 RID: 105026 RVA: 0x003BDD5E File Offset: 0x003BBF5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolScheduleDataPb);
		}

		// Token: 0x06019A43 RID: 105027 RVA: 0x003BDD6C File Offset: 0x003BBF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolScheduleDataPb other)
		{
			return other != null && (other == this || (this.history_.Equals(other.history_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019A44 RID: 105028 RVA: 0x003BDDA0 File Offset: 0x003BBFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.history_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019A45 RID: 105029 RVA: 0x003BDDD4 File Offset: 0x003BBFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019A46 RID: 105030 RVA: 0x003BDDE1 File Offset: 0x003BBFE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019A47 RID: 105031 RVA: 0x003BDDEA File Offset: 0x003BBFEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.history_.WriteTo(ref output, SolarSchoolScheduleDataPb._repeated_history_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019A48 RID: 105032 RVA: 0x003BDE14 File Offset: 0x003BC014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.history_.CalculateSize(SolarSchoolScheduleDataPb._repeated_history_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019A49 RID: 105033 RVA: 0x003BDE4D File Offset: 0x003BC04D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolScheduleDataPb other)
		{
			if (other == null)
			{
				return;
			}
			this.history_.Add(other.history_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019A4A RID: 105034 RVA: 0x003BDE7B File Offset: 0x003BC07B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019A4B RID: 105035 RVA: 0x003BDE84 File Offset: 0x003BC084
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.history_.AddEntriesFrom(ref input, SolarSchoolScheduleDataPb._repeated_history_codec);
				}
			}
		}

		// Token: 0x04009780 RID: 38784
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009781 RID: 38785
		public const int HistoryFieldNumber = 2;

		// Token: 0x04009782 RID: 38786
		private static readonly FieldCodec<SolarSchoolWeekSchedulePb> _repeated_history_codec = FieldCodec.ForMessage<SolarSchoolWeekSchedulePb>(18U, SolarSchoolWeekSchedulePb.Parser);

		// Token: 0x04009783 RID: 38787
		private readonly RepeatedField<SolarSchoolWeekSchedulePb> history_ = new RepeatedField<SolarSchoolWeekSchedulePb>();
	}
}
