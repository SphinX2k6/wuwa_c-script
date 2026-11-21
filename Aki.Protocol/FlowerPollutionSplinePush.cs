using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005E8 RID: 1512
	[NetMessage(EMessageId.FlowerPollutionSplinePush)]
	public sealed class FlowerPollutionSplinePush : IMessage<FlowerPollutionSplinePush>, IMessage, IEquatable<FlowerPollutionSplinePush>, IDeepCloneable<FlowerPollutionSplinePush>, IBufferMessage
	{
		// Token: 0x06008C6E RID: 35950 RVA: 0x00155221 File Offset: 0x00153421
		[NullableContext(1)]
		public static FlowerPollutionSplinePush Create()
		{
			return new FlowerPollutionSplinePush();
		}

		// Token: 0x17001BD3 RID: 7123
		// (get) Token: 0x06008C6F RID: 35951 RVA: 0x00155228 File Offset: 0x00153428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BD4 RID: 7124
		// (get) Token: 0x06008C70 RID: 35952 RVA: 0x0015522B File Offset: 0x0015342B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowerPollutionSplinePush.Descriptor;
			}
		}

		// Token: 0x06008C71 RID: 35953 RVA: 0x00155232 File Offset: 0x00153432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowerPollutionSplinePush()
		{
		}

		// Token: 0x06008C72 RID: 35954 RVA: 0x0015523A File Offset: 0x0015343A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowerPollutionSplinePush(FlowerPollutionSplinePush other) : this()
		{
			this.managerEntityId_ = other.managerEntityId_;
			this.splineConfigId_ = other.splineConfigId_;
			this.isRemovePollution_ = other.isRemovePollution_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008C73 RID: 35955 RVA: 0x00155277 File Offset: 0x00153477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowerPollutionSplinePush Clone()
		{
			return new FlowerPollutionSplinePush(this);
		}

		// Token: 0x17001BD5 RID: 7125
		// (get) Token: 0x06008C74 RID: 35956 RVA: 0x0015527F File Offset: 0x0015347F
		// (set) Token: 0x06008C75 RID: 35957 RVA: 0x00155287 File Offset: 0x00153487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ManagerEntityId
		{
			get
			{
				return this.managerEntityId_;
			}
			set
			{
				this.managerEntityId_ = value;
			}
		}

		// Token: 0x17001BD6 RID: 7126
		// (get) Token: 0x06008C76 RID: 35958 RVA: 0x00155290 File Offset: 0x00153490
		// (set) Token: 0x06008C77 RID: 35959 RVA: 0x00155298 File Offset: 0x00153498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SplineConfigId
		{
			get
			{
				return this.splineConfigId_;
			}
			set
			{
				this.splineConfigId_ = value;
			}
		}

		// Token: 0x17001BD7 RID: 7127
		// (get) Token: 0x06008C78 RID: 35960 RVA: 0x001552A1 File Offset: 0x001534A1
		// (set) Token: 0x06008C79 RID: 35961 RVA: 0x001552A9 File Offset: 0x001534A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRemovePollution
		{
			get
			{
				return this.isRemovePollution_;
			}
			set
			{
				this.isRemovePollution_ = value;
			}
		}

		// Token: 0x06008C7A RID: 35962 RVA: 0x001552B2 File Offset: 0x001534B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowerPollutionSplinePush);
		}

		// Token: 0x06008C7B RID: 35963 RVA: 0x001552C0 File Offset: 0x001534C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowerPollutionSplinePush other)
		{
			return other != null && (other == this || (this.ManagerEntityId == other.ManagerEntityId && this.SplineConfigId == other.SplineConfigId && this.IsRemovePollution == other.IsRemovePollution && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008C7C RID: 35964 RVA: 0x0015531C File Offset: 0x0015351C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ManagerEntityId != 0L)
			{
				num ^= this.ManagerEntityId.GetHashCode();
			}
			if (this.SplineConfigId != 0)
			{
				num ^= this.SplineConfigId.GetHashCode();
			}
			if (this.IsRemovePollution)
			{
				num ^= this.IsRemovePollution.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008C7D RID: 35965 RVA: 0x0015538D File Offset: 0x0015358D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008C7E RID: 35966 RVA: 0x0015539A File Offset: 0x0015359A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C7F RID: 35967 RVA: 0x001553A4 File Offset: 0x001535A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ManagerEntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.ManagerEntityId);
			}
			if (this.IsRemovePollution)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsRemovePollution);
			}
			if (this.SplineConfigId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.SplineConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008C80 RID: 35968 RVA: 0x0015541C File Offset: 0x0015361C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ManagerEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ManagerEntityId);
			}
			if (this.SplineConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SplineConfigId);
			}
			if (this.IsRemovePollution)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008C81 RID: 35969 RVA: 0x00155480 File Offset: 0x00153680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowerPollutionSplinePush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ManagerEntityId != 0L)
			{
				this.ManagerEntityId = other.ManagerEntityId;
			}
			if (other.SplineConfigId != 0)
			{
				this.SplineConfigId = other.SplineConfigId;
			}
			if (other.IsRemovePollution)
			{
				this.IsRemovePollution = other.IsRemovePollution;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008C82 RID: 35970 RVA: 0x001554E4 File Offset: 0x001536E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C83 RID: 35971 RVA: 0x001554F0 File Offset: 0x001536F0
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
				if (num != 16U)
				{
					if (num != 40U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SplineConfigId = input.ReadInt32();
						}
					}
					else
					{
						this.IsRemovePollution = input.ReadBool();
					}
				}
				else
				{
					this.ManagerEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004520 RID: 17696
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004521 RID: 17697
		public const int ManagerEntityIdFieldNumber = 2;

		// Token: 0x04004522 RID: 17698
		private long managerEntityId_;

		// Token: 0x04004523 RID: 17699
		public const int SplineConfigIdFieldNumber = 9;

		// Token: 0x04004524 RID: 17700
		private int splineConfigId_;

		// Token: 0x04004525 RID: 17701
		public const int IsRemovePollutionFieldNumber = 5;

		// Token: 0x04004526 RID: 17702
		private bool isRemovePollution_;
	}
}
