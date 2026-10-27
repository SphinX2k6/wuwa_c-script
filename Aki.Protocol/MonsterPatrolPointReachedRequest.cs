using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A04 RID: 2564
	[NetMessage(EMessageId.MonsterPatrolPointReachedRequest)]
	public sealed class MonsterPatrolPointReachedRequest : IMessage<MonsterPatrolPointReachedRequest>, IMessage, IEquatable<MonsterPatrolPointReachedRequest>, IDeepCloneable<MonsterPatrolPointReachedRequest>, IBufferMessage
	{
		// Token: 0x0600E064 RID: 57444 RVA: 0x0020E13C File Offset: 0x0020C33C
		[NullableContext(1)]
		public static MonsterPatrolPointReachedRequest Create()
		{
			return new MonsterPatrolPointReachedRequest();
		}

		// Token: 0x17002D7D RID: 11645
		// (get) Token: 0x0600E065 RID: 57445 RVA: 0x0020E143 File Offset: 0x0020C343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D7E RID: 11646
		// (get) Token: 0x0600E066 RID: 57446 RVA: 0x0020E146 File Offset: 0x0020C346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterPatrolPointReachedRequest.Descriptor;
			}
		}

		// Token: 0x0600E067 RID: 57447 RVA: 0x0020E14D File Offset: 0x0020C34D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterPatrolPointReachedRequest()
		{
		}

		// Token: 0x0600E068 RID: 57448 RVA: 0x0020E155 File Offset: 0x0020C355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterPatrolPointReachedRequest(MonsterPatrolPointReachedRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.splineEntityConfigId_ = other.splineEntityConfigId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E069 RID: 57449 RVA: 0x0020E192 File Offset: 0x0020C392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterPatrolPointReachedRequest Clone()
		{
			return new MonsterPatrolPointReachedRequest(this);
		}

		// Token: 0x17002D7F RID: 11647
		// (get) Token: 0x0600E06A RID: 57450 RVA: 0x0020E19A File Offset: 0x0020C39A
		// (set) Token: 0x0600E06B RID: 57451 RVA: 0x0020E1A2 File Offset: 0x0020C3A2
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

		// Token: 0x17002D80 RID: 11648
		// (get) Token: 0x0600E06C RID: 57452 RVA: 0x0020E1AB File Offset: 0x0020C3AB
		// (set) Token: 0x0600E06D RID: 57453 RVA: 0x0020E1B3 File Offset: 0x0020C3B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SplineEntityConfigId
		{
			get
			{
				return this.splineEntityConfigId_;
			}
			set
			{
				this.splineEntityConfigId_ = value;
			}
		}

		// Token: 0x17002D81 RID: 11649
		// (get) Token: 0x0600E06E RID: 57454 RVA: 0x0020E1BC File Offset: 0x0020C3BC
		// (set) Token: 0x0600E06F RID: 57455 RVA: 0x0020E1C4 File Offset: 0x0020C3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x0600E070 RID: 57456 RVA: 0x0020E1CD File Offset: 0x0020C3CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterPatrolPointReachedRequest);
		}

		// Token: 0x0600E071 RID: 57457 RVA: 0x0020E1DC File Offset: 0x0020C3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterPatrolPointReachedRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.SplineEntityConfigId == other.SplineEntityConfigId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E072 RID: 57458 RVA: 0x0020E238 File Offset: 0x0020C438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.SplineEntityConfigId != 0)
			{
				num ^= this.SplineEntityConfigId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E073 RID: 57459 RVA: 0x0020E2A9 File Offset: 0x0020C4A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E074 RID: 57460 RVA: 0x0020E2B6 File Offset: 0x0020C4B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E075 RID: 57461 RVA: 0x0020E2C0 File Offset: 0x0020C4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Index);
			}
			if (this.SplineEntityConfigId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.SplineEntityConfigId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E076 RID: 57462 RVA: 0x0020E338 File Offset: 0x0020C538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.SplineEntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SplineEntityConfigId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E077 RID: 57463 RVA: 0x0020E3A8 File Offset: 0x0020C5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterPatrolPointReachedRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.SplineEntityConfigId != 0)
			{
				this.SplineEntityConfigId = other.SplineEntityConfigId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E078 RID: 57464 RVA: 0x0020E40C File Offset: 0x0020C60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E079 RID: 57465 RVA: 0x0020E418 File Offset: 0x0020C618
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
				if (num != 32U)
				{
					if (num != 72U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EntityId = input.ReadInt64();
						}
					}
					else
					{
						this.SplineEntityConfigId = input.ReadInt32();
					}
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005C60 RID: 23648
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C61 RID: 23649
		public const int EntityIdFieldNumber = 13;

		// Token: 0x04005C62 RID: 23650
		private long entityId_;

		// Token: 0x04005C63 RID: 23651
		public const int SplineEntityConfigIdFieldNumber = 9;

		// Token: 0x04005C64 RID: 23652
		private int splineEntityConfigId_;

		// Token: 0x04005C65 RID: 23653
		public const int IndexFieldNumber = 4;

		// Token: 0x04005C66 RID: 23654
		private int index_;
	}
}
