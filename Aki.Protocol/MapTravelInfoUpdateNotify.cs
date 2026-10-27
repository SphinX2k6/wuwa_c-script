using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009A0 RID: 2464
	[NetMessage(EMessageId.MapTravelInfoUpdateNotify)]
	public sealed class MapTravelInfoUpdateNotify : IMessage<MapTravelInfoUpdateNotify>, IMessage, IEquatable<MapTravelInfoUpdateNotify>, IDeepCloneable<MapTravelInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600D861 RID: 55393 RVA: 0x001FCC25 File Offset: 0x001FAE25
		[NullableContext(1)]
		public static MapTravelInfoUpdateNotify Create()
		{
			return new MapTravelInfoUpdateNotify();
		}

		// Token: 0x17002BCF RID: 11215
		// (get) Token: 0x0600D862 RID: 55394 RVA: 0x001FCC2C File Offset: 0x001FAE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BD0 RID: 11216
		// (get) Token: 0x0600D863 RID: 55395 RVA: 0x001FCC2F File Offset: 0x001FAE2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTravelInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600D864 RID: 55396 RVA: 0x001FCC36 File Offset: 0x001FAE36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelInfoUpdateNotify()
		{
		}

		// Token: 0x0600D865 RID: 55397 RVA: 0x001FCC40 File Offset: 0x001FAE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelInfoUpdateNotify(MapTravelInfoUpdateNotify other) : this()
		{
			MapTravelInfoUpdateNotify.DataOneofCase dataCase = other.DataCase;
			if (dataCase != MapTravelInfoUpdateNotify.DataOneofCase.UnLockMonsterId)
			{
				switch (dataCase)
				{
				case MapTravelInfoUpdateNotify.DataOneofCase.ActivityTask:
					this.ActivityTask = other.ActivityTask.Clone();
					break;
				case MapTravelInfoUpdateNotify.DataOneofCase.SoarLevel:
					this.SoarLevel = other.SoarLevel.Clone();
					break;
				case MapTravelInfoUpdateNotify.DataOneofCase.UnLockArea:
					this.UnLockArea = other.UnLockArea;
					break;
				}
			}
			else
			{
				this.UnLockMonsterId = other.UnLockMonsterId;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D866 RID: 55398 RVA: 0x001FCCCD File Offset: 0x001FAECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelInfoUpdateNotify Clone()
		{
			return new MapTravelInfoUpdateNotify(this);
		}

		// Token: 0x17002BD1 RID: 11217
		// (get) Token: 0x0600D867 RID: 55399 RVA: 0x001FCCD5 File Offset: 0x001FAED5
		// (set) Token: 0x0600D868 RID: 55400 RVA: 0x001FCCED File Offset: 0x001FAEED
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

		// Token: 0x17002BD2 RID: 11218
		// (get) Token: 0x0600D869 RID: 55401 RVA: 0x001FCD03 File Offset: 0x001FAF03
		// (set) Token: 0x0600D86A RID: 55402 RVA: 0x001FCD1A File Offset: 0x001FAF1A
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

		// Token: 0x17002BD3 RID: 11219
		// (get) Token: 0x0600D86B RID: 55403 RVA: 0x001FCD2F File Offset: 0x001FAF2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasUnLockMonsterId
		{
			get
			{
				return this.dataCase_ == MapTravelInfoUpdateNotify.DataOneofCase.UnLockMonsterId;
			}
		}

		// Token: 0x0600D86C RID: 55404 RVA: 0x001FCD3A File Offset: 0x001FAF3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearUnLockMonsterId()
		{
			if (this.HasUnLockMonsterId)
			{
				this.ClearData();
			}
		}

		// Token: 0x17002BD4 RID: 11220
		// (get) Token: 0x0600D86D RID: 55405 RVA: 0x001FCD4A File Offset: 0x001FAF4A
		// (set) Token: 0x0600D86E RID: 55406 RVA: 0x001FCD61 File Offset: 0x001FAF61
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

		// Token: 0x17002BD5 RID: 11221
		// (get) Token: 0x0600D86F RID: 55407 RVA: 0x001FCD77 File Offset: 0x001FAF77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasUnLockArea
		{
			get
			{
				return this.dataCase_ == MapTravelInfoUpdateNotify.DataOneofCase.UnLockArea;
			}
		}

		// Token: 0x0600D870 RID: 55408 RVA: 0x001FCD83 File Offset: 0x001FAF83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearUnLockArea()
		{
			if (this.HasUnLockArea)
			{
				this.ClearData();
			}
		}

		// Token: 0x17002BD6 RID: 11222
		// (get) Token: 0x0600D871 RID: 55409 RVA: 0x001FCD93 File Offset: 0x001FAF93
		// (set) Token: 0x0600D872 RID: 55410 RVA: 0x001FCDAC File Offset: 0x001FAFAC
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

		// Token: 0x17002BD7 RID: 11223
		// (get) Token: 0x0600D873 RID: 55411 RVA: 0x001FCDC3 File Offset: 0x001FAFC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelInfoUpdateNotify.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x0600D874 RID: 55412 RVA: 0x001FCDCB File Offset: 0x001FAFCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = MapTravelInfoUpdateNotify.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x0600D875 RID: 55413 RVA: 0x001FCDDB File Offset: 0x001FAFDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTravelInfoUpdateNotify);
		}

		// Token: 0x0600D876 RID: 55414 RVA: 0x001FCDEC File Offset: 0x001FAFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTravelInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityTask, other.ActivityTask) && this.UnLockMonsterId == other.UnLockMonsterId && this.UnLockArea == other.UnLockArea && object.Equals(this.SoarLevel, other.SoarLevel) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D877 RID: 55415 RVA: 0x001FCE70 File Offset: 0x001FB070
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

		// Token: 0x0600D878 RID: 55416 RVA: 0x001FCF00 File Offset: 0x001FB100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D879 RID: 55417 RVA: 0x001FCF0D File Offset: 0x001FB10D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D87A RID: 55418 RVA: 0x001FCF18 File Offset: 0x001FB118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasUnLockMonsterId)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.UnLockMonsterId);
			}
			if (this.dataCase_ == MapTravelInfoUpdateNotify.DataOneofCase.ActivityTask)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.ActivityTask);
			}
			if (this.dataCase_ == MapTravelInfoUpdateNotify.DataOneofCase.SoarLevel)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.SoarLevel);
			}
			if (this.HasUnLockArea)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.UnLockArea);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D87B RID: 55419 RVA: 0x001FCFAC File Offset: 0x001FB1AC
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

		// Token: 0x0600D87C RID: 55420 RVA: 0x001FD038 File Offset: 0x001FB238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapTravelInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			MapTravelInfoUpdateNotify.DataOneofCase dataCase = other.DataCase;
			if (dataCase != MapTravelInfoUpdateNotify.DataOneofCase.UnLockMonsterId)
			{
				switch (dataCase)
				{
				case MapTravelInfoUpdateNotify.DataOneofCase.ActivityTask:
					if (this.ActivityTask == null)
					{
						this.ActivityTask = new ActivityTask();
					}
					this.ActivityTask.MergeFrom(other.ActivityTask);
					break;
				case MapTravelInfoUpdateNotify.DataOneofCase.SoarLevel:
					if (this.SoarLevel == null)
					{
						this.SoarLevel = new SoarLevelPlayInfo();
					}
					this.SoarLevel.MergeFrom(other.SoarLevel);
					break;
				case MapTravelInfoUpdateNotify.DataOneofCase.UnLockArea:
					this.UnLockArea = other.UnLockArea;
					break;
				}
			}
			else
			{
				this.UnLockMonsterId = other.UnLockMonsterId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D87D RID: 55421 RVA: 0x001FD0EF File Offset: 0x001FB2EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D87E RID: 55422 RVA: 0x001FD0F8 File Offset: 0x001FB2F8
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
				if (num <= 66U)
				{
					if (num == 40U)
					{
						this.UnLockMonsterId = input.ReadInt32();
						continue;
					}
					if (num == 66U)
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
				}
				else
				{
					if (num == 82U)
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
					if (num == 96U)
					{
						this.UnLockArea = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005A2D RID: 23085
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A2E RID: 23086
		public const int ActivityTaskFieldNumber = 8;

		// Token: 0x04005A2F RID: 23087
		public const int UnLockMonsterIdFieldNumber = 5;

		// Token: 0x04005A30 RID: 23088
		public const int UnLockAreaFieldNumber = 12;

		// Token: 0x04005A31 RID: 23089
		public const int SoarLevelFieldNumber = 10;

		// Token: 0x04005A32 RID: 23090
		private object data_;

		// Token: 0x04005A33 RID: 23091
		private MapTravelInfoUpdateNotify.DataOneofCase dataCase_;

		// Token: 0x0200182B RID: 6187
		public enum DataOneofCase
		{
			// Token: 0x0400C7F3 RID: 51187
			None,
			// Token: 0x0400C7F4 RID: 51188
			ActivityTask = 8,
			// Token: 0x0400C7F5 RID: 51189
			UnLockMonsterId = 5,
			// Token: 0x0400C7F6 RID: 51190
			UnLockArea = 12,
			// Token: 0x0400C7F7 RID: 51191
			SoarLevel = 10
		}
	}
}
