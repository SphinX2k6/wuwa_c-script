using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001383 RID: 4995
	[NetMessage(EMessageId.TimeScheduleIdleNotify)]
	public sealed class TimeScheduleIdleNotify : IMessage<TimeScheduleIdleNotify>, IMessage, IEquatable<TimeScheduleIdleNotify>, IDeepCloneable<TimeScheduleIdleNotify>, IBufferMessage
	{
		// Token: 0x0601A83F RID: 108607 RVA: 0x003D9229 File Offset: 0x003D7429
		[NullableContext(1)]
		public static TimeScheduleIdleNotify Create()
		{
			return new TimeScheduleIdleNotify();
		}

		// Token: 0x1700596C RID: 22892
		// (get) Token: 0x0601A840 RID: 108608 RVA: 0x003D9230 File Offset: 0x003D7430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700596D RID: 22893
		// (get) Token: 0x0601A841 RID: 108609 RVA: 0x003D9233 File Offset: 0x003D7433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimeScheduleIdleNotify.Descriptor;
			}
		}

		// Token: 0x0601A842 RID: 108610 RVA: 0x003D923A File Offset: 0x003D743A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeScheduleIdleNotify()
		{
		}

		// Token: 0x0601A843 RID: 108611 RVA: 0x003D924D File Offset: 0x003D744D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeScheduleIdleNotify(TimeScheduleIdleNotify other) : this()
		{
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A844 RID: 108612 RVA: 0x003D9277 File Offset: 0x003D7477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeScheduleIdleNotify Clone()
		{
			return new TimeScheduleIdleNotify(this);
		}

		// Token: 0x1700596E RID: 22894
		// (get) Token: 0x0601A845 RID: 108613 RVA: 0x003D927F File Offset: 0x003D747F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x0601A846 RID: 108614 RVA: 0x003D9287 File Offset: 0x003D7487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimeScheduleIdleNotify);
		}

		// Token: 0x0601A847 RID: 108615 RVA: 0x003D9295 File Offset: 0x003D7495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimeScheduleIdleNotify other)
		{
			return other != null && (other == this || (this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A848 RID: 108616 RVA: 0x003D92C8 File Offset: 0x003D74C8
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

		// Token: 0x0601A849 RID: 108617 RVA: 0x003D92FC File Offset: 0x003D74FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A84A RID: 108618 RVA: 0x003D9309 File Offset: 0x003D7509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A84B RID: 108619 RVA: 0x003D9312 File Offset: 0x003D7512
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

		// Token: 0x0601A84C RID: 108620 RVA: 0x003D933C File Offset: 0x003D753C
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

		// Token: 0x0601A84D RID: 108621 RVA: 0x003D9375 File Offset: 0x003D7575
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

		// Token: 0x0601A84E RID: 108622 RVA: 0x003D93A3 File Offset: 0x003D75A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A84F RID: 108623 RVA: 0x003D93AC File Offset: 0x003D75AC
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityIds_.AddEntriesFrom(ref input, TimeScheduleIdleNotify._repeated_entityIds_codec);
				}
			}
		}

		// Token: 0x04009A3E RID: 39486
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A3F RID: 39487
		public const int EntityIdsFieldNumber = 1;

		// Token: 0x04009A40 RID: 39488
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(10U);

		// Token: 0x04009A41 RID: 39489
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();
	}
}
