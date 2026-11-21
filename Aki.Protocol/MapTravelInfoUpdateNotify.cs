using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200098F RID: 2447
	[NetMessage(EMessageId.MapTravelInfoUpdateNotify)]
	public sealed class MapTravelInfoUpdateNotify : IMessage<MapTravelInfoUpdateNotify>, IMessage, IEquatable<MapTravelInfoUpdateNotify>, IDeepCloneable<MapTravelInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600D747 RID: 55111 RVA: 0x001FAA35 File Offset: 0x001F8C35
		[NullableContext(1)]
		public static MapTravelInfoUpdateNotify Create()
		{
			return new MapTravelInfoUpdateNotify();
		}

		// Token: 0x17002B91 RID: 11153
		// (get) Token: 0x0600D748 RID: 55112 RVA: 0x001FAA3C File Offset: 0x001F8C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B92 RID: 11154
		// (get) Token: 0x0600D749 RID: 55113 RVA: 0x001FAA3F File Offset: 0x001F8C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTravelInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600D74A RID: 55114 RVA: 0x001FAA46 File Offset: 0x001F8C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelInfoUpdateNotify()
		{
		}

		// Token: 0x0600D74B RID: 55115 RVA: 0x001FAA50 File Offset: 0x001F8C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelInfoUpdateNotify(MapTravelInfoUpdateNotify other) : this()
		{
			MapTravelInfoUpdateNotify.DataOneofCase dataCase = other.DataCase;
			if (dataCase != MapTravelInfoUpdateNotify.DataOneofCase.SoarLevel)
			{
				switch (dataCase)
				{
				case MapTravelInfoUpdateNotify.DataOneofCase.UnLockArea:
					this.UnLockArea = other.UnLockArea;
					break;
				case MapTravelInfoUpdateNotify.DataOneofCase.ActivityTask:
					this.ActivityTask = other.ActivityTask.Clone();
					break;
				case MapTravelInfoUpdateNotify.DataOneofCase.UnLockMonsterId:
					this.UnLockMonsterId = other.UnLockMonsterId;
					break;
				}
			}
			else
			{
				this.SoarLevel = other.SoarLevel.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D74C RID: 55116 RVA: 0x001FAADA File Offset: 0x001F8CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelInfoUpdateNotify Clone()
		{
			return new MapTravelInfoUpdateNotify(this);
		}

		// Token: 0x17002B93 RID: 11155
		// (get) Token: 0x0600D74D RID: 55117 RVA: 0x001FAAE2 File Offset: 0x001F8CE2
		// (set) Token: 0x0600D74E RID: 55118 RVA: 0x001FAAFB File Offset: 0x001F8CFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTask ActivityTask
		{
			get
			{
				if (this.dataCase_ != MapTravelInfoUpdateNotify.DataOneofCase.ActivityTask)
				{
					return null;
				}
				return (ActivityTask)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? MapTravelInfoUpdateNotify.DataOneofCase.None : MapTravelInfoUpdateNotify.DataOneofCase.ActivityTask);
			}
		}

		// Token: 0x17002B94 RID: 11156
		// (get) Token: 0x0600D74F RID: 55119 RVA: 0x001FAB12 File Offset: 0x001F8D12
		// (set) Token: 0x0600D750 RID: 55120 RVA: 0x001FAB29 File Offset: 0x001F8D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnLockMonsterId
		{
			get
			{
				if (!this.HasUnLockMonsterId)
				{
					return 0;
				}
				return (int)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = MapTravelInfoUpdateNotify.DataOneofCase.UnLockMonsterId;
			}
		}

		// Token: 0x17002B95 RID: 11157
		// (get) Token: 0x0600D751 RID: 55121 RVA: 0x001FAB3F File Offset: 0x001F8D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasUnLockMonsterId
		{
			get
			{
				return this.dataCase_ == MapTravelInfoUpdateNotify.DataOneofCase.UnLockMonsterId;
			}
		}

		// Token: 0x0600D752 RID: 55122 RVA: 0x001FAB4B File Offset: 0x001F8D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearUnLockMonsterId()
		{
			if (this.HasUnLockMonsterId)
			{
				this.ClearData();
			}
		}

		// Token: 0x17002B96 RID: 11158
		// (get) Token: 0x0600D753 RID: 55123 RVA: 0x001FAB5B File Offset: 0x001F8D5B
		// (set) Token: 0x0600D754 RID: 55124 RVA: 0x001FAB72 File Offset: 0x001F8D72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnLockArea
		{
			get
			{
				if (!this.HasUnLockArea)
				{
					return 0;
				}
				return (int)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = MapTravelInfoUpdateNotify.DataOneofCase.UnLockArea;
			}
		}

		// Token: 0x17002B97 RID: 11159
		// (get) Token: 0x0600D755 RID: 55125 RVA: 0x001FAB88 File Offset: 0x001F8D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasUnLockArea
		{
			get
			{
				return this.dataCase_ == MapTravelInfoUpdateNotify.DataOneofCase.UnLockArea;
			}
		}

		// Token: 0x0600D756 RID: 55126 RVA: 0x001FAB94 File Offset: 0x001F8D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearUnLockArea()
		{
			if (this.HasUnLockArea)
			{
				this.ClearData();
			}
		}

		// Token: 0x17002B98 RID: 11160
		// (get) Token: 0x0600D757 RID: 55127 RVA: 0x001FABA4 File Offset: 0x001F8DA4
		// (set) Token: 0x0600D758 RID: 55128 RVA: 0x001FABBC File Offset: 0x001F8DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SoarLevelPlayInfo SoarLevel
		{
			get
			{
				if (this.dataCase_ != MapTravelInfoUpdateNotify.DataOneofCase.SoarLevel)
				{
					return null;
				}
				return (SoarLevelPlayInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? MapTravelInfoUpdateNotify.DataOneofCase.None : MapTravelInfoUpdateNotify.DataOneofCase.SoarLevel);
			}
		}

		// Token: 0x17002B99 RID: 11161
		// (get) Token: 0x0600D759 RID: 55129 RVA: 0x001FABD2 File Offset: 0x001F8DD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelInfoUpdateNotify.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x0600D75A RID: 55130 RVA: 0x001FABDA File Offset: 0x001F8DDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = MapTravelInfoUpdateNotify.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x0600D75B RID: 55131 RVA: 0x001FABEA File Offset: 0x001F8DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTravelInfoUpdateNotify);
		}

		// Token: 0x0600D75C RID: 55132 RVA: 0x001FABF8 File Offset: 0x001F8DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTravelInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityTask, other.ActivityTask) && this.UnLockMonsterId == other.UnLockMonsterId && this.UnLockArea == other.UnLockArea && object.Equals(this.SoarLevel, other.SoarLevel) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D75D RID: 55133 RVA: 0x001FAC7C File Offset: 0x001F8E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.dataCase_ == MapTravelInfoUpdateNotify.DataOneofCase.ActivityTask)
			{
				num ^= this.ActivityTask.GetHashCode();
			}
			if (this.HasUnLockMonsterId)
			{
				num ^= this.UnLockMonsterId.GetHashCode();
			}
			if (this.HasUnLockArea)
			{
				num ^= this.UnLockArea.GetHashCode();
			}
			if (this.dataCase_ == MapTravelInfoUpdateNotify.DataOneofCase.SoarLevel)
			{
				num ^= this.SoarLevel.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D75E RID: 55134 RVA: 0x001FAD0C File Offset: 0x001F8F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D75F RID: 55135 RVA: 0x001FAD19 File Offset: 0x001F8F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D760 RID: 55136 RVA: 0x001FAD24 File Offset: 0x001F8F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dataCase_ == MapTravelInfoUpdateNotify.DataOneofCase.SoarLevel)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.SoarLevel);
			}
			if (this.HasUnLockArea)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.UnLockArea);
			}
			if (this.dataCase_ == MapTravelInfoUpdateNotify.DataOneofCase.ActivityTask)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.ActivityTask);
			}
			if (this.HasUnLockMonsterId)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.UnLockMonsterId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D761 RID: 55137 RVA: 0x001FADB8 File Offset: 0x001F8FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.dataCase_ == MapTravelInfoUpdateNotify.DataOneofCase.ActivityTask)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActivityTask);
			}
			if (this.HasUnLockMonsterId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnLockMonsterId);
			}
			if (this.HasUnLockArea)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnLockArea);
			}
			if (this.dataCase_ == MapTravelInfoUpdateNotify.DataOneofCase.SoarLevel)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SoarLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D762 RID: 55138 RVA: 0x001FAE44 File Offset: 0x001F9044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapTravelInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			MapTravelInfoUpdateNotify.DataOneofCase dataCase = other.DataCase;
			if (dataCase != MapTravelInfoUpdateNotify.DataOneofCase.SoarLevel)
			{
				switch (dataCase)
				{
				case MapTravelInfoUpdateNotify.DataOneofCase.UnLockArea:
					this.UnLockArea = other.UnLockArea;
					break;
				case MapTravelInfoUpdateNotify.DataOneofCase.ActivityTask:
					if (this.ActivityTask == null)
					{
						this.ActivityTask = new ActivityTask();
					}
					this.ActivityTask.MergeFrom(other.ActivityTask);
					break;
				case MapTravelInfoUpdateNotify.DataOneofCase.UnLockMonsterId:
					this.UnLockMonsterId = other.UnLockMonsterId;
					break;
				}
			}
			else
			{
				if (this.SoarLevel == null)
				{
					this.SoarLevel = new SoarLevelPlayInfo();
				}
				this.SoarLevel.MergeFrom(other.SoarLevel);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D763 RID: 55139 RVA: 0x001FAEF8 File Offset: 0x001F90F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D764 RID: 55140 RVA: 0x001FAF04 File Offset: 0x001F9104
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
				if (num <= 88U)
				{
					if (num == 26U)
					{
						SoarLevelPlayInfo soarLevelPlayInfo = new SoarLevelPlayInfo();
						if (this.dataCase_ == MapTravelInfoUpdateNotify.DataOneofCase.SoarLevel)
						{
							soarLevelPlayInfo.MergeFrom(this.SoarLevel);
						}
						input.ReadMessage(soarLevelPlayInfo);
						this.SoarLevel = soarLevelPlayInfo;
						continue;
					}
					if (num == 88U)
					{
						this.UnLockArea = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						ActivityTask activityTask = new ActivityTask();
						if (this.dataCase_ == MapTravelInfoUpdateNotify.DataOneofCase.ActivityTask)
						{
							activityTask.MergeFrom(this.ActivityTask);
						}
						input.ReadMessage(activityTask);
						this.ActivityTask = activityTask;
						continue;
					}
					if (num == 112U)
					{
						this.UnLockMonsterId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005A36 RID: 23094
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A37 RID: 23095
		public const int ActivityTaskFieldNumber = 12;

		// Token: 0x04005A38 RID: 23096
		public const int UnLockMonsterIdFieldNumber = 14;

		// Token: 0x04005A39 RID: 23097
		public const int UnLockAreaFieldNumber = 11;

		// Token: 0x04005A3A RID: 23098
		public const int SoarLevelFieldNumber = 3;

		// Token: 0x04005A3B RID: 23099
		private object data_;

		// Token: 0x04005A3C RID: 23100
		private MapTravelInfoUpdateNotify.DataOneofCase dataCase_;

		// Token: 0x020018A3 RID: 6307
		public enum DataOneofCase
		{
			// Token: 0x0400CD1E RID: 52510
			None,
			// Token: 0x0400CD1F RID: 52511
			ActivityTask = 12,
			// Token: 0x0400CD20 RID: 52512
			UnLockMonsterId = 14,
			// Token: 0x0400CD21 RID: 52513
			UnLockArea = 11,
			// Token: 0x0400CD22 RID: 52514
			SoarLevel = 3
		}
	}
}
