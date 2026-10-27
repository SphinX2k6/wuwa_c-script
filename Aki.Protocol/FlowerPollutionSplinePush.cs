using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005FD RID: 1533
	[NetMessage(EMessageId.FlowerPollutionSplinePush)]
	public sealed class FlowerPollutionSplinePush : IMessage<FlowerPollutionSplinePush>, IMessage, IEquatable<FlowerPollutionSplinePush>, IDeepCloneable<FlowerPollutionSplinePush>, IBufferMessage
	{
		// Token: 0x06008DD6 RID: 36310 RVA: 0x00157E21 File Offset: 0x00156021
		[NullableContext(1)]
		public static FlowerPollutionSplinePush Create()
		{
			return new FlowerPollutionSplinePush();
		}

		// Token: 0x17001C20 RID: 7200
		// (get) Token: 0x06008DD7 RID: 36311 RVA: 0x00157E28 File Offset: 0x00156028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C21 RID: 7201
		// (get) Token: 0x06008DD8 RID: 36312 RVA: 0x00157E2B File Offset: 0x0015602B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowerPollutionSplinePush.Descriptor;
			}
		}

		// Token: 0x06008DD9 RID: 36313 RVA: 0x00157E32 File Offset: 0x00156032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowerPollutionSplinePush()
		{
		}

		// Token: 0x06008DDA RID: 36314 RVA: 0x00157E3A File Offset: 0x0015603A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowerPollutionSplinePush(FlowerPollutionSplinePush other) : this()
		{
			this.managerEntityId_ = other.managerEntityId_;
			this.splineConfigId_ = other.splineConfigId_;
			this.isRemovePollution_ = other.isRemovePollution_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008DDB RID: 36315 RVA: 0x00157E77 File Offset: 0x00156077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowerPollutionSplinePush Clone()
		{
			return new FlowerPollutionSplinePush(this);
		}

		// Token: 0x17001C22 RID: 7202
		// (get) Token: 0x06008DDC RID: 36316 RVA: 0x00157E7F File Offset: 0x0015607F
		// (set) Token: 0x06008DDD RID: 36317 RVA: 0x00157E87 File Offset: 0x00156087
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

		// Token: 0x17001C23 RID: 7203
		// (get) Token: 0x06008DDE RID: 36318 RVA: 0x00157E90 File Offset: 0x00156090
		// (set) Token: 0x06008DDF RID: 36319 RVA: 0x00157E98 File Offset: 0x00156098
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

		// Token: 0x17001C24 RID: 7204
		// (get) Token: 0x06008DE0 RID: 36320 RVA: 0x00157EA1 File Offset: 0x001560A1
		// (set) Token: 0x06008DE1 RID: 36321 RVA: 0x00157EA9 File Offset: 0x001560A9
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

		// Token: 0x06008DE2 RID: 36322 RVA: 0x00157EB2 File Offset: 0x001560B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowerPollutionSplinePush);
		}

		// Token: 0x06008DE3 RID: 36323 RVA: 0x00157EC0 File Offset: 0x001560C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowerPollutionSplinePush other)
		{
			return other != null && (other == this || (this.ManagerEntityId == other.ManagerEntityId && this.SplineConfigId == other.SplineConfigId && this.IsRemovePollution == other.IsRemovePollution && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008DE4 RID: 36324 RVA: 0x00157F1C File Offset: 0x0015611C
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

		// Token: 0x06008DE5 RID: 36325 RVA: 0x00157F8D File Offset: 0x0015618D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008DE6 RID: 36326 RVA: 0x00157F9A File Offset: 0x0015619A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008DE7 RID: 36327 RVA: 0x00157FA4 File Offset: 0x001561A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SplineConfigId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SplineConfigId);
			}
			if (this.ManagerEntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.ManagerEntityId);
			}
			if (this.IsRemovePollution)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsRemovePollution);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008DE8 RID: 36328 RVA: 0x0015801C File Offset: 0x0015621C
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

		// Token: 0x06008DE9 RID: 36329 RVA: 0x00158080 File Offset: 0x00156280
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

		// Token: 0x06008DEA RID: 36330 RVA: 0x001580E4 File Offset: 0x001562E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008DEB RID: 36331 RVA: 0x001580F0 File Offset: 0x001562F0
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
					if (num != 88U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.SplineConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400452A RID: 17706
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400452B RID: 17707
		public const int ManagerEntityIdFieldNumber = 11;

		// Token: 0x0400452C RID: 17708
		private long managerEntityId_;

		// Token: 0x0400452D RID: 17709
		public const int SplineConfigIdFieldNumber = 3;

		// Token: 0x0400452E RID: 17710
		private int splineConfigId_;

		// Token: 0x0400452F RID: 17711
		public const int IsRemovePollutionFieldNumber = 12;

		// Token: 0x04004530 RID: 17712
		private bool isRemovePollution_;
	}
}
