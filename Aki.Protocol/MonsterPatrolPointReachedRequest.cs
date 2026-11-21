using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009F3 RID: 2547
	[NetMessage(EMessageId.MonsterPatrolPointReachedRequest)]
	public sealed class MonsterPatrolPointReachedRequest : IMessage<MonsterPatrolPointReachedRequest>, IMessage, IEquatable<MonsterPatrolPointReachedRequest>, IDeepCloneable<MonsterPatrolPointReachedRequest>, IBufferMessage
	{
		// Token: 0x0600DF4A RID: 57162 RVA: 0x0020BF50 File Offset: 0x0020A150
		[NullableContext(1)]
		public static MonsterPatrolPointReachedRequest Create()
		{
			return new MonsterPatrolPointReachedRequest();
		}

		// Token: 0x17002D3F RID: 11583
		// (get) Token: 0x0600DF4B RID: 57163 RVA: 0x0020BF57 File Offset: 0x0020A157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D40 RID: 11584
		// (get) Token: 0x0600DF4C RID: 57164 RVA: 0x0020BF5A File Offset: 0x0020A15A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterPatrolPointReachedRequest.Descriptor;
			}
		}

		// Token: 0x0600DF4D RID: 57165 RVA: 0x0020BF61 File Offset: 0x0020A161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterPatrolPointReachedRequest()
		{
		}

		// Token: 0x0600DF4E RID: 57166 RVA: 0x0020BF69 File Offset: 0x0020A169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterPatrolPointReachedRequest(MonsterPatrolPointReachedRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.splineEntityConfigId_ = other.splineEntityConfigId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DF4F RID: 57167 RVA: 0x0020BFA6 File Offset: 0x0020A1A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterPatrolPointReachedRequest Clone()
		{
			return new MonsterPatrolPointReachedRequest(this);
		}

		// Token: 0x17002D41 RID: 11585
		// (get) Token: 0x0600DF50 RID: 57168 RVA: 0x0020BFAE File Offset: 0x0020A1AE
		// (set) Token: 0x0600DF51 RID: 57169 RVA: 0x0020BFB6 File Offset: 0x0020A1B6
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

		// Token: 0x17002D42 RID: 11586
		// (get) Token: 0x0600DF52 RID: 57170 RVA: 0x0020BFBF File Offset: 0x0020A1BF
		// (set) Token: 0x0600DF53 RID: 57171 RVA: 0x0020BFC7 File Offset: 0x0020A1C7
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

		// Token: 0x17002D43 RID: 11587
		// (get) Token: 0x0600DF54 RID: 57172 RVA: 0x0020BFD0 File Offset: 0x0020A1D0
		// (set) Token: 0x0600DF55 RID: 57173 RVA: 0x0020BFD8 File Offset: 0x0020A1D8
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

		// Token: 0x0600DF56 RID: 57174 RVA: 0x0020BFE1 File Offset: 0x0020A1E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterPatrolPointReachedRequest);
		}

		// Token: 0x0600DF57 RID: 57175 RVA: 0x0020BFF0 File Offset: 0x0020A1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterPatrolPointReachedRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.SplineEntityConfigId == other.SplineEntityConfigId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DF58 RID: 57176 RVA: 0x0020C04C File Offset: 0x0020A24C
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

		// Token: 0x0600DF59 RID: 57177 RVA: 0x0020C0BD File Offset: 0x0020A2BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DF5A RID: 57178 RVA: 0x0020C0CA File Offset: 0x0020A2CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DF5B RID: 57179 RVA: 0x0020C0D4 File Offset: 0x0020A2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SplineEntityConfigId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SplineEntityConfigId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Index);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DF5C RID: 57180 RVA: 0x0020C14C File Offset: 0x0020A34C
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

		// Token: 0x0600DF5D RID: 57181 RVA: 0x0020C1BC File Offset: 0x0020A3BC
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

		// Token: 0x0600DF5E RID: 57182 RVA: 0x0020C220 File Offset: 0x0020A420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DF5F RID: 57183 RVA: 0x0020C22C File Offset: 0x0020A42C
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
				if (num != 24U)
				{
					if (num != 32U)
					{
						if (num != 40U)
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
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.SplineEntityConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005C69 RID: 23657
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C6A RID: 23658
		public const int EntityIdFieldNumber = 5;

		// Token: 0x04005C6B RID: 23659
		private long entityId_;

		// Token: 0x04005C6C RID: 23660
		public const int SplineEntityConfigIdFieldNumber = 3;

		// Token: 0x04005C6D RID: 23661
		private int splineEntityConfigId_;

		// Token: 0x04005C6E RID: 23662
		public const int IndexFieldNumber = 4;

		// Token: 0x04005C6F RID: 23663
		private int index_;
	}
}
