using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010FA RID: 4346
	[NetMessage(EMessageId.RoleTowerTimerDurationUpdateNotify)]
	public sealed class RoleTowerTimerDurationUpdateNotify : IMessage<RoleTowerTimerDurationUpdateNotify>, IMessage, IEquatable<RoleTowerTimerDurationUpdateNotify>, IDeepCloneable<RoleTowerTimerDurationUpdateNotify>, IBufferMessage
	{
		// Token: 0x060173C0 RID: 95168 RVA: 0x00361BE8 File Offset: 0x0035FDE8
		[NullableContext(1)]
		public static RoleTowerTimerDurationUpdateNotify Create()
		{
			return new RoleTowerTimerDurationUpdateNotify();
		}

		// Token: 0x17004E0F RID: 19983
		// (get) Token: 0x060173C1 RID: 95169 RVA: 0x00361BEF File Offset: 0x0035FDEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E10 RID: 19984
		// (get) Token: 0x060173C2 RID: 95170 RVA: 0x00361BF2 File Offset: 0x0035FDF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerTimerDurationUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060173C3 RID: 95171 RVA: 0x00361BF9 File Offset: 0x0035FDF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTimerDurationUpdateNotify()
		{
		}

		// Token: 0x060173C4 RID: 95172 RVA: 0x00361C0C File Offset: 0x0035FE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTimerDurationUpdateNotify(RoleTowerTimerDurationUpdateNotify other) : this()
		{
			this.durationUpdates_ = other.durationUpdates_.Clone();
			this.timeData_ = ((other.timeData_ != null) ? other.timeData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060173C5 RID: 95173 RVA: 0x00361C5D File Offset: 0x0035FE5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTimerDurationUpdateNotify Clone()
		{
			return new RoleTowerTimerDurationUpdateNotify(this);
		}

		// Token: 0x17004E11 RID: 19985
		// (get) Token: 0x060173C6 RID: 95174 RVA: 0x00361C65 File Offset: 0x0035FE65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DurationUpdates
		{
			get
			{
				return this.durationUpdates_;
			}
		}

		// Token: 0x17004E12 RID: 19986
		// (get) Token: 0x060173C7 RID: 95175 RVA: 0x00361C6D File Offset: 0x0035FE6D
		// (set) Token: 0x060173C8 RID: 95176 RVA: 0x00361C75 File Offset: 0x0035FE75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTimerData TimeData
		{
			get
			{
				return this.timeData_;
			}
			set
			{
				this.timeData_ = value;
			}
		}

		// Token: 0x060173C9 RID: 95177 RVA: 0x00361C7E File Offset: 0x0035FE7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerTimerDurationUpdateNotify);
		}

		// Token: 0x060173CA RID: 95178 RVA: 0x00361C8C File Offset: 0x0035FE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerTimerDurationUpdateNotify other)
		{
			return other != null && (other == this || (this.durationUpdates_.Equals(other.durationUpdates_) && object.Equals(this.TimeData, other.TimeData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060173CB RID: 95179 RVA: 0x00361CE0 File Offset: 0x0035FEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.durationUpdates_.GetHashCode();
			if (this.timeData_ != null)
			{
				num ^= this.TimeData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060173CC RID: 95180 RVA: 0x00361D2A File Offset: 0x0035FF2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060173CD RID: 95181 RVA: 0x00361D37 File Offset: 0x0035FF37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060173CE RID: 95182 RVA: 0x00361D40 File Offset: 0x0035FF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.timeData_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.TimeData);
			}
			this.durationUpdates_.WriteTo(ref output, RoleTowerTimerDurationUpdateNotify._repeated_durationUpdates_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060173CF RID: 95183 RVA: 0x00361D90 File Offset: 0x0035FF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.durationUpdates_.CalculateSize(RoleTowerTimerDurationUpdateNotify._repeated_durationUpdates_codec);
			if (this.timeData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TimeData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060173D0 RID: 95184 RVA: 0x00361DE4 File Offset: 0x0035FFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerTimerDurationUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.durationUpdates_.Add(other.durationUpdates_);
			if (other.timeData_ != null)
			{
				if (this.timeData_ == null)
				{
					this.TimeData = new RoleTowerTimerData();
				}
				this.TimeData.MergeFrom(other.TimeData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060173D1 RID: 95185 RVA: 0x00361E49 File Offset: 0x00360049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060173D2 RID: 95186 RVA: 0x00361E54 File Offset: 0x00360054
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
					if (num != 64U && num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.durationUpdates_.AddEntriesFrom(ref input, RoleTowerTimerDurationUpdateNotify._repeated_durationUpdates_codec);
					}
				}
				else
				{
					if (this.timeData_ == null)
					{
						this.TimeData = new RoleTowerTimerData();
					}
					input.ReadMessage(this.TimeData);
				}
			}
		}

		// Token: 0x04008AF7 RID: 35575
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008AF8 RID: 35576
		public const int DurationUpdatesFieldNumber = 8;

		// Token: 0x04008AF9 RID: 35577
		private static readonly FieldCodec<int> _repeated_durationUpdates_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04008AFA RID: 35578
		private readonly RepeatedField<int> durationUpdates_ = new RepeatedField<int>();

		// Token: 0x04008AFB RID: 35579
		public const int TimeDataFieldNumber = 2;

		// Token: 0x04008AFC RID: 35580
		private RoleTowerTimerData timeData_;
	}
}
