using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200126F RID: 4719
	[NetMessage(EMessageId.SplinePositionNotify)]
	public sealed class SplinePositionNotify : IMessage<SplinePositionNotify>, IMessage, IEquatable<SplinePositionNotify>, IDeepCloneable<SplinePositionNotify>, IBufferMessage
	{
		// Token: 0x0601922E RID: 102958 RVA: 0x003A7FAD File Offset: 0x003A61AD
		[NullableContext(1)]
		public static SplinePositionNotify Create()
		{
			return new SplinePositionNotify();
		}

		// Token: 0x170054C6 RID: 21702
		// (get) Token: 0x0601922F RID: 102959 RVA: 0x003A7FB4 File Offset: 0x003A61B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054C7 RID: 21703
		// (get) Token: 0x06019230 RID: 102960 RVA: 0x003A7FB7 File Offset: 0x003A61B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SplinePositionNotify.Descriptor;
			}
		}

		// Token: 0x06019231 RID: 102961 RVA: 0x003A7FBE File Offset: 0x003A61BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplinePositionNotify()
		{
		}

		// Token: 0x06019232 RID: 102962 RVA: 0x003A7FC8 File Offset: 0x003A61C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplinePositionNotify(SplinePositionNotify other) : this()
		{
			this.timeScheduleId_ = other.timeScheduleId_;
			this.entityId_ = other.entityId_;
			this.splineId_ = other.splineId_;
			this.splineIdx_ = other.splineIdx_;
			this.dir_ = other.dir_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019233 RID: 102963 RVA: 0x003A8028 File Offset: 0x003A6228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplinePositionNotify Clone()
		{
			return new SplinePositionNotify(this);
		}

		// Token: 0x170054C8 RID: 21704
		// (get) Token: 0x06019234 RID: 102964 RVA: 0x003A8030 File Offset: 0x003A6230
		// (set) Token: 0x06019235 RID: 102965 RVA: 0x003A8038 File Offset: 0x003A6238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TimeScheduleId
		{
			get
			{
				return this.timeScheduleId_;
			}
			set
			{
				this.timeScheduleId_ = value;
			}
		}

		// Token: 0x170054C9 RID: 21705
		// (get) Token: 0x06019236 RID: 102966 RVA: 0x003A8041 File Offset: 0x003A6241
		// (set) Token: 0x06019237 RID: 102967 RVA: 0x003A8049 File Offset: 0x003A6249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x170054CA RID: 21706
		// (get) Token: 0x06019238 RID: 102968 RVA: 0x003A8052 File Offset: 0x003A6252
		// (set) Token: 0x06019239 RID: 102969 RVA: 0x003A805A File Offset: 0x003A625A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SplineId
		{
			get
			{
				return this.splineId_;
			}
			set
			{
				this.splineId_ = value;
			}
		}

		// Token: 0x170054CB RID: 21707
		// (get) Token: 0x0601923A RID: 102970 RVA: 0x003A8063 File Offset: 0x003A6263
		// (set) Token: 0x0601923B RID: 102971 RVA: 0x003A806B File Offset: 0x003A626B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SplineIdx
		{
			get
			{
				return this.splineIdx_;
			}
			set
			{
				this.splineIdx_ = value;
			}
		}

		// Token: 0x170054CC RID: 21708
		// (get) Token: 0x0601923C RID: 102972 RVA: 0x003A8074 File Offset: 0x003A6274
		// (set) Token: 0x0601923D RID: 102973 RVA: 0x003A807C File Offset: 0x003A627C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Dir
		{
			get
			{
				return this.dir_;
			}
			set
			{
				this.dir_ = value;
			}
		}

		// Token: 0x0601923E RID: 102974 RVA: 0x003A8085 File Offset: 0x003A6285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SplinePositionNotify);
		}

		// Token: 0x0601923F RID: 102975 RVA: 0x003A8094 File Offset: 0x003A6294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SplinePositionNotify other)
		{
			return other != null && (other == this || (this.TimeScheduleId == other.TimeScheduleId && this.EntityId == other.EntityId && this.SplineId == other.SplineId && this.SplineIdx == other.SplineIdx && this.Dir == other.Dir && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019240 RID: 102976 RVA: 0x003A8110 File Offset: 0x003A6310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TimeScheduleId != 0)
			{
				num ^= this.TimeScheduleId.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.SplineId != 0)
			{
				num ^= this.SplineId.GetHashCode();
			}
			if (this.SplineIdx != 0)
			{
				num ^= this.SplineIdx.GetHashCode();
			}
			if (this.Dir)
			{
				num ^= this.Dir.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019241 RID: 102977 RVA: 0x003A81B3 File Offset: 0x003A63B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019242 RID: 102978 RVA: 0x003A81C0 File Offset: 0x003A63C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019243 RID: 102979 RVA: 0x003A81CC File Offset: 0x003A63CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.TimeScheduleId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TimeScheduleId);
			}
			if (this.Dir)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.Dir);
			}
			if (this.SplineId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SplineId);
			}
			if (this.SplineIdx != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.SplineIdx);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019244 RID: 102980 RVA: 0x003A8278 File Offset: 0x003A6478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TimeScheduleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TimeScheduleId);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.SplineId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SplineId);
			}
			if (this.SplineIdx != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SplineIdx);
			}
			if (this.Dir)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019245 RID: 102981 RVA: 0x003A830C File Offset: 0x003A650C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SplinePositionNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TimeScheduleId != 0)
			{
				this.TimeScheduleId = other.TimeScheduleId;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.SplineId != 0)
			{
				this.SplineId = other.SplineId;
			}
			if (other.SplineIdx != 0)
			{
				this.SplineIdx = other.SplineIdx;
			}
			if (other.Dir)
			{
				this.Dir = other.Dir;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019246 RID: 102982 RVA: 0x003A8398 File Offset: 0x003A6598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019247 RID: 102983 RVA: 0x003A83A4 File Offset: 0x003A65A4
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
				if (num <= 40U)
				{
					if (num == 8U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.TimeScheduleId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.Dir = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						this.SplineId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.SplineIdx = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040093F1 RID: 37873
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093F2 RID: 37874
		public const int TimeScheduleIdFieldNumber = 5;

		// Token: 0x040093F3 RID: 37875
		private int timeScheduleId_;

		// Token: 0x040093F4 RID: 37876
		public const int EntityIdFieldNumber = 1;

		// Token: 0x040093F5 RID: 37877
		private long entityId_;

		// Token: 0x040093F6 RID: 37878
		public const int SplineIdFieldNumber = 8;

		// Token: 0x040093F7 RID: 37879
		private int splineId_;

		// Token: 0x040093F8 RID: 37880
		public const int SplineIdxFieldNumber = 14;

		// Token: 0x040093F9 RID: 37881
		private int splineIdx_;

		// Token: 0x040093FA RID: 37882
		public const int DirFieldNumber = 7;

		// Token: 0x040093FB RID: 37883
		private bool dir_;
	}
}
