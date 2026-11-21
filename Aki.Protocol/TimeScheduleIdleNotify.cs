using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013F6 RID: 5110
	[NetMessage(EMessageId.TimeScheduleIdleNotify)]
	public sealed class TimeScheduleIdleNotify : IMessage<TimeScheduleIdleNotify>, IMessage, IEquatable<TimeScheduleIdleNotify>, IDeepCloneable<TimeScheduleIdleNotify>, IBufferMessage
	{
		// Token: 0x0601B2C8 RID: 111304 RVA: 0x003F443D File Offset: 0x003F263D
		[NullableContext(1)]
		public static TimeScheduleIdleNotify Create()
		{
			return new TimeScheduleIdleNotify();
		}

		// Token: 0x17005C00 RID: 23552
		// (get) Token: 0x0601B2C9 RID: 111305 RVA: 0x003F4444 File Offset: 0x003F2644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C01 RID: 23553
		// (get) Token: 0x0601B2CA RID: 111306 RVA: 0x003F4447 File Offset: 0x003F2647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimeScheduleIdleNotify.Descriptor;
			}
		}

		// Token: 0x0601B2CB RID: 111307 RVA: 0x003F444E File Offset: 0x003F264E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeScheduleIdleNotify()
		{
		}

		// Token: 0x0601B2CC RID: 111308 RVA: 0x003F4461 File Offset: 0x003F2661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeScheduleIdleNotify(TimeScheduleIdleNotify other) : this()
		{
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B2CD RID: 111309 RVA: 0x003F448B File Offset: 0x003F268B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeScheduleIdleNotify Clone()
		{
			return new TimeScheduleIdleNotify(this);
		}

		// Token: 0x17005C02 RID: 23554
		// (get) Token: 0x0601B2CE RID: 111310 RVA: 0x003F4493 File Offset: 0x003F2693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x0601B2CF RID: 111311 RVA: 0x003F449B File Offset: 0x003F269B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimeScheduleIdleNotify);
		}

		// Token: 0x0601B2D0 RID: 111312 RVA: 0x003F44A9 File Offset: 0x003F26A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimeScheduleIdleNotify other)
		{
			return other != null && (other == this || (this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B2D1 RID: 111313 RVA: 0x003F44DC File Offset: 0x003F26DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B2D2 RID: 111314 RVA: 0x003F4510 File Offset: 0x003F2710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B2D3 RID: 111315 RVA: 0x003F451D File Offset: 0x003F271D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B2D4 RID: 111316 RVA: 0x003F4526 File Offset: 0x003F2726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityIds_.WriteTo(ref output, TimeScheduleIdleNotify._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B2D5 RID: 111317 RVA: 0x003F4550 File Offset: 0x003F2750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityIds_.CalculateSize(TimeScheduleIdleNotify._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B2D6 RID: 111318 RVA: 0x003F4589 File Offset: 0x003F2789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimeScheduleIdleNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.entityIds_.Add(other.entityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B2D7 RID: 111319 RVA: 0x003F45B7 File Offset: 0x003F27B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B2D8 RID: 111320 RVA: 0x003F45C0 File Offset: 0x003F27C0
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
				if (num != 96U && num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityIds_.AddEntriesFrom(ref input, TimeScheduleIdleNotify._repeated_entityIds_codec);
				}
			}
		}

		// Token: 0x04009E83 RID: 40579
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E84 RID: 40580
		public const int EntityIdsFieldNumber = 12;

		// Token: 0x04009E85 RID: 40581
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(98U);

		// Token: 0x04009E86 RID: 40582
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();
	}
}
