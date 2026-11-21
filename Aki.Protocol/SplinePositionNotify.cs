using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012DE RID: 4830
	[NetMessage(EMessageId.SplinePositionNotify)]
	public sealed class SplinePositionNotify : IMessage<SplinePositionNotify>, IMessage, IEquatable<SplinePositionNotify>, IDeepCloneable<SplinePositionNotify>, IBufferMessage
	{
		// Token: 0x06019C64 RID: 105572 RVA: 0x003C26F5 File Offset: 0x003C08F5
		[NullableContext(1)]
		public static SplinePositionNotify Create()
		{
			return new SplinePositionNotify();
		}

		// Token: 0x17005747 RID: 22343
		// (get) Token: 0x06019C65 RID: 105573 RVA: 0x003C26FC File Offset: 0x003C08FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005748 RID: 22344
		// (get) Token: 0x06019C66 RID: 105574 RVA: 0x003C26FF File Offset: 0x003C08FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SplinePositionNotify.Descriptor;
			}
		}

		// Token: 0x06019C67 RID: 105575 RVA: 0x003C2706 File Offset: 0x003C0906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplinePositionNotify()
		{
		}

		// Token: 0x06019C68 RID: 105576 RVA: 0x003C2710 File Offset: 0x003C0910
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

		// Token: 0x06019C69 RID: 105577 RVA: 0x003C2770 File Offset: 0x003C0970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplinePositionNotify Clone()
		{
			return new SplinePositionNotify(this);
		}

		// Token: 0x17005749 RID: 22345
		// (get) Token: 0x06019C6A RID: 105578 RVA: 0x003C2778 File Offset: 0x003C0978
		// (set) Token: 0x06019C6B RID: 105579 RVA: 0x003C2780 File Offset: 0x003C0980
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

		// Token: 0x1700574A RID: 22346
		// (get) Token: 0x06019C6C RID: 105580 RVA: 0x003C2789 File Offset: 0x003C0989
		// (set) Token: 0x06019C6D RID: 105581 RVA: 0x003C2791 File Offset: 0x003C0991
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

		// Token: 0x1700574B RID: 22347
		// (get) Token: 0x06019C6E RID: 105582 RVA: 0x003C279A File Offset: 0x003C099A
		// (set) Token: 0x06019C6F RID: 105583 RVA: 0x003C27A2 File Offset: 0x003C09A2
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

		// Token: 0x1700574C RID: 22348
		// (get) Token: 0x06019C70 RID: 105584 RVA: 0x003C27AB File Offset: 0x003C09AB
		// (set) Token: 0x06019C71 RID: 105585 RVA: 0x003C27B3 File Offset: 0x003C09B3
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

		// Token: 0x1700574D RID: 22349
		// (get) Token: 0x06019C72 RID: 105586 RVA: 0x003C27BC File Offset: 0x003C09BC
		// (set) Token: 0x06019C73 RID: 105587 RVA: 0x003C27C4 File Offset: 0x003C09C4
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

		// Token: 0x06019C74 RID: 105588 RVA: 0x003C27CD File Offset: 0x003C09CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SplinePositionNotify);
		}

		// Token: 0x06019C75 RID: 105589 RVA: 0x003C27DC File Offset: 0x003C09DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SplinePositionNotify other)
		{
			return other != null && (other == this || (this.TimeScheduleId == other.TimeScheduleId && this.EntityId == other.EntityId && this.SplineId == other.SplineId && this.SplineIdx == other.SplineIdx && this.Dir == other.Dir && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019C76 RID: 105590 RVA: 0x003C2858 File Offset: 0x003C0A58
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

		// Token: 0x06019C77 RID: 105591 RVA: 0x003C28FB File Offset: 0x003C0AFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019C78 RID: 105592 RVA: 0x003C2908 File Offset: 0x003C0B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019C79 RID: 105593 RVA: 0x003C2914 File Offset: 0x003C0B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SplineIdx != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SplineIdx);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityId);
			}
			if (this.Dir)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.Dir);
			}
			if (this.SplineId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.SplineId);
			}
			if (this.TimeScheduleId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.TimeScheduleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019C7A RID: 105594 RVA: 0x003C29C4 File Offset: 0x003C0BC4
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

		// Token: 0x06019C7B RID: 105595 RVA: 0x003C2A58 File Offset: 0x003C0C58
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

		// Token: 0x06019C7C RID: 105596 RVA: 0x003C2AE4 File Offset: 0x003C0CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019C7D RID: 105597 RVA: 0x003C2AF0 File Offset: 0x003C0CF0
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
				if (num <= 24U)
				{
					if (num == 16U)
					{
						this.SplineIdx = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Dir = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.SplineId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.TimeScheduleId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400981B RID: 38939
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400981C RID: 38940
		public const int TimeScheduleIdFieldNumber = 15;

		// Token: 0x0400981D RID: 38941
		private int timeScheduleId_;

		// Token: 0x0400981E RID: 38942
		public const int EntityIdFieldNumber = 3;

		// Token: 0x0400981F RID: 38943
		private long entityId_;

		// Token: 0x04009820 RID: 38944
		public const int SplineIdFieldNumber = 14;

		// Token: 0x04009821 RID: 38945
		private int splineId_;

		// Token: 0x04009822 RID: 38946
		public const int SplineIdxFieldNumber = 2;

		// Token: 0x04009823 RID: 38947
		private int splineIdx_;

		// Token: 0x04009824 RID: 38948
		public const int DirFieldNumber = 10;

		// Token: 0x04009825 RID: 38949
		private bool dir_;
	}
}
