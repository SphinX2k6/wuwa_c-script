using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012A4 RID: 4772
	[NetMessage(EMessageId.SolarSchoolBatchSyncRequest)]
	public sealed class SolarSchoolBatchSyncRequest : IMessage<SolarSchoolBatchSyncRequest>, IMessage, IEquatable<SolarSchoolBatchSyncRequest>, IDeepCloneable<SolarSchoolBatchSyncRequest>, IBufferMessage
	{
		// Token: 0x06019790 RID: 104336 RVA: 0x003B75B6 File Offset: 0x003B57B6
		[NullableContext(1)]
		public static SolarSchoolBatchSyncRequest Create()
		{
			return new SolarSchoolBatchSyncRequest();
		}

		// Token: 0x17005632 RID: 22066
		// (get) Token: 0x06019791 RID: 104337 RVA: 0x003B75BD File Offset: 0x003B57BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005633 RID: 22067
		// (get) Token: 0x06019792 RID: 104338 RVA: 0x003B75C0 File Offset: 0x003B57C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolBatchSyncRequest.Descriptor;
			}
		}

		// Token: 0x06019793 RID: 104339 RVA: 0x003B75C7 File Offset: 0x003B57C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolBatchSyncRequest()
		{
		}

		// Token: 0x06019794 RID: 104340 RVA: 0x003B75DC File Offset: 0x003B57DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolBatchSyncRequest(SolarSchoolBatchSyncRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.syncData_ = other.syncData_.Clone();
			this.traceId_ = other.traceId_;
			this.gameDayNow_ = other.gameDayNow_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019795 RID: 104341 RVA: 0x003B7635 File Offset: 0x003B5835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolBatchSyncRequest Clone()
		{
			return new SolarSchoolBatchSyncRequest(this);
		}

		// Token: 0x17005634 RID: 22068
		// (get) Token: 0x06019796 RID: 104342 RVA: 0x003B763D File Offset: 0x003B583D
		// (set) Token: 0x06019797 RID: 104343 RVA: 0x003B7645 File Offset: 0x003B5845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17005635 RID: 22069
		// (get) Token: 0x06019798 RID: 104344 RVA: 0x003B764E File Offset: 0x003B584E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SolarSchoolBatchSyncData> SyncData
		{
			get
			{
				return this.syncData_;
			}
		}

		// Token: 0x17005636 RID: 22070
		// (get) Token: 0x06019799 RID: 104345 RVA: 0x003B7656 File Offset: 0x003B5856
		// (set) Token: 0x0601979A RID: 104346 RVA: 0x003B765E File Offset: 0x003B585E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TraceId
		{
			get
			{
				return this.traceId_;
			}
			set
			{
				this.traceId_ = value;
			}
		}

		// Token: 0x17005637 RID: 22071
		// (get) Token: 0x0601979B RID: 104347 RVA: 0x003B7667 File Offset: 0x003B5867
		// (set) Token: 0x0601979C RID: 104348 RVA: 0x003B766F File Offset: 0x003B586F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GameDayNow
		{
			get
			{
				return this.gameDayNow_;
			}
			set
			{
				this.gameDayNow_ = value;
			}
		}

		// Token: 0x0601979D RID: 104349 RVA: 0x003B7678 File Offset: 0x003B5878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolBatchSyncRequest);
		}

		// Token: 0x0601979E RID: 104350 RVA: 0x003B7688 File Offset: 0x003B5888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolBatchSyncRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.syncData_.Equals(other.syncData_) && this.TraceId == other.TraceId && this.GameDayNow == other.GameDayNow && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601979F RID: 104351 RVA: 0x003B76F8 File Offset: 0x003B58F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.syncData_.GetHashCode();
			if (this.TraceId != 0)
			{
				num ^= this.TraceId.GetHashCode();
			}
			if (this.GameDayNow != 0)
			{
				num ^= this.GameDayNow.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060197A0 RID: 104352 RVA: 0x003B7777 File Offset: 0x003B5977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060197A1 RID: 104353 RVA: 0x003B7784 File Offset: 0x003B5984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060197A2 RID: 104354 RVA: 0x003B7790 File Offset: 0x003B5990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this.GameDayNow != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.GameDayNow);
			}
			if (this.TraceId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TraceId);
			}
			this.syncData_.WriteTo(ref output, SolarSchoolBatchSyncRequest._repeated_syncData_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060197A3 RID: 104355 RVA: 0x003B7818 File Offset: 0x003B5A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.syncData_.CalculateSize(SolarSchoolBatchSyncRequest._repeated_syncData_codec);
			if (this.TraceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TraceId);
			}
			if (this.GameDayNow != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GameDayNow);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060197A4 RID: 104356 RVA: 0x003B789C File Offset: 0x003B5A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolBatchSyncRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.syncData_.Add(other.syncData_);
			if (other.TraceId != 0)
			{
				this.TraceId = other.TraceId;
			}
			if (other.GameDayNow != 0)
			{
				this.GameDayNow = other.GameDayNow;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060197A5 RID: 104357 RVA: 0x003B7911 File Offset: 0x003B5B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060197A6 RID: 104358 RVA: 0x003B791C File Offset: 0x003B5B1C
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
				if (num <= 32U)
				{
					if (num == 24U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.GameDayNow = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.TraceId = input.ReadInt32();
						continue;
					}
					if (num == 90U)
					{
						this.syncData_.AddEntriesFrom(ref input, SolarSchoolBatchSyncRequest._repeated_syncData_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009691 RID: 38545
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009692 RID: 38546
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04009693 RID: 38547
		private int activityId_;

		// Token: 0x04009694 RID: 38548
		public const int SyncDataFieldNumber = 11;

		// Token: 0x04009695 RID: 38549
		private static readonly FieldCodec<SolarSchoolBatchSyncData> _repeated_syncData_codec = FieldCodec.ForMessage<SolarSchoolBatchSyncData>(90U, SolarSchoolBatchSyncData.Parser);

		// Token: 0x04009696 RID: 38550
		private readonly RepeatedField<SolarSchoolBatchSyncData> syncData_ = new RepeatedField<SolarSchoolBatchSyncData>();

		// Token: 0x04009697 RID: 38551
		public const int TraceIdFieldNumber = 5;

		// Token: 0x04009698 RID: 38552
		private int traceId_;

		// Token: 0x04009699 RID: 38553
		public const int GameDayNowFieldNumber = 4;

		// Token: 0x0400969A RID: 38554
		private int gameDayNow_;
	}
}
