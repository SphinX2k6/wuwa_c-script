using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001168 RID: 4456
	[NetMessage(EMessageId.SceneItemMoveSplineRequest)]
	public sealed class SceneItemMoveSplineRequest : IMessage<SceneItemMoveSplineRequest>, IMessage, IEquatable<SceneItemMoveSplineRequest>, IDeepCloneable<SceneItemMoveSplineRequest>, IBufferMessage
	{
		// Token: 0x06017C1F RID: 97311 RVA: 0x003736E4 File Offset: 0x003718E4
		[NullableContext(1)]
		public static SceneItemMoveSplineRequest Create()
		{
			return new SceneItemMoveSplineRequest();
		}

		// Token: 0x17004FCE RID: 20430
		// (get) Token: 0x06017C20 RID: 97312 RVA: 0x003736EB File Offset: 0x003718EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FCF RID: 20431
		// (get) Token: 0x06017C21 RID: 97313 RVA: 0x003736EE File Offset: 0x003718EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemMoveSplineRequest.Descriptor;
			}
		}

		// Token: 0x06017C22 RID: 97314 RVA: 0x003736F5 File Offset: 0x003718F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveSplineRequest()
		{
		}

		// Token: 0x06017C23 RID: 97315 RVA: 0x00373700 File Offset: 0x00371900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveSplineRequest(SceneItemMoveSplineRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.splineEntityId_ = other.splineEntityId_;
			this.moveStatus_ = other.moveStatus_;
			this.runtimeData_ = ((other.runtimeData_ != null) ? other.runtimeData_.Clone() : null);
			this.moveSplineConfig_ = ((other.moveSplineConfig_ != null) ? other.moveSplineConfig_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017C24 RID: 97316 RVA: 0x00373780 File Offset: 0x00371980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveSplineRequest Clone()
		{
			return new SceneItemMoveSplineRequest(this);
		}

		// Token: 0x17004FD0 RID: 20432
		// (get) Token: 0x06017C25 RID: 97317 RVA: 0x00373788 File Offset: 0x00371988
		// (set) Token: 0x06017C26 RID: 97318 RVA: 0x00373790 File Offset: 0x00371990
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

		// Token: 0x17004FD1 RID: 20433
		// (get) Token: 0x06017C27 RID: 97319 RVA: 0x00373799 File Offset: 0x00371999
		// (set) Token: 0x06017C28 RID: 97320 RVA: 0x003737A1 File Offset: 0x003719A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SplineEntityId
		{
			get
			{
				return this.splineEntityId_;
			}
			set
			{
				this.splineEntityId_ = value;
			}
		}

		// Token: 0x17004FD2 RID: 20434
		// (get) Token: 0x06017C29 RID: 97321 RVA: 0x003737AA File Offset: 0x003719AA
		// (set) Token: 0x06017C2A RID: 97322 RVA: 0x003737B2 File Offset: 0x003719B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveStatus MoveStatus
		{
			get
			{
				return this.moveStatus_;
			}
			set
			{
				this.moveStatus_ = value;
			}
		}

		// Token: 0x17004FD3 RID: 20435
		// (get) Token: 0x06017C2B RID: 97323 RVA: 0x003737BB File Offset: 0x003719BB
		// (set) Token: 0x06017C2C RID: 97324 RVA: 0x003737C3 File Offset: 0x003719C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSplineRuntimeData RuntimeData
		{
			get
			{
				return this.runtimeData_;
			}
			set
			{
				this.runtimeData_ = value;
			}
		}

		// Token: 0x17004FD4 RID: 20436
		// (get) Token: 0x06017C2D RID: 97325 RVA: 0x003737CC File Offset: 0x003719CC
		// (set) Token: 0x06017C2E RID: 97326 RVA: 0x003737D4 File Offset: 0x003719D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSplineConfig MoveSplineConfig
		{
			get
			{
				return this.moveSplineConfig_;
			}
			set
			{
				this.moveSplineConfig_ = value;
			}
		}

		// Token: 0x06017C2F RID: 97327 RVA: 0x003737DD File Offset: 0x003719DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemMoveSplineRequest);
		}

		// Token: 0x06017C30 RID: 97328 RVA: 0x003737EC File Offset: 0x003719EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemMoveSplineRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.SplineEntityId == other.SplineEntityId && this.MoveStatus == other.MoveStatus && object.Equals(this.RuntimeData, other.RuntimeData) && object.Equals(this.MoveSplineConfig, other.MoveSplineConfig) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017C31 RID: 97329 RVA: 0x00373870 File Offset: 0x00371A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.SplineEntityId != 0)
			{
				num ^= this.SplineEntityId.GetHashCode();
			}
			if (this.MoveStatus != MoveStatus.Stop)
			{
				num ^= this.MoveStatus.GetHashCode();
			}
			if (this.runtimeData_ != null)
			{
				num ^= this.RuntimeData.GetHashCode();
			}
			if (this.moveSplineConfig_ != null)
			{
				num ^= this.MoveSplineConfig.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017C32 RID: 97330 RVA: 0x00373913 File Offset: 0x00371B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017C33 RID: 97331 RVA: 0x00373920 File Offset: 0x00371B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017C34 RID: 97332 RVA: 0x0037392C File Offset: 0x00371B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.runtimeData_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RuntimeData);
			}
			if (this.MoveStatus != MoveStatus.Stop)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.MoveStatus);
			}
			if (this.SplineEntityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SplineEntityId);
			}
			if (this.moveSplineConfig_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.MoveSplineConfig);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017C35 RID: 97333 RVA: 0x003739DC File Offset: 0x00371BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.SplineEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SplineEntityId);
			}
			if (this.MoveStatus != MoveStatus.Stop)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MoveStatus);
			}
			if (this.runtimeData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RuntimeData);
			}
			if (this.moveSplineConfig_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MoveSplineConfig);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017C36 RID: 97334 RVA: 0x00373A7C File Offset: 0x00371C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemMoveSplineRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.SplineEntityId != 0)
			{
				this.SplineEntityId = other.SplineEntityId;
			}
			if (other.MoveStatus != MoveStatus.Stop)
			{
				this.MoveStatus = other.MoveStatus;
			}
			if (other.runtimeData_ != null)
			{
				if (this.runtimeData_ == null)
				{
					this.RuntimeData = new SceneItemSplineRuntimeData();
				}
				this.RuntimeData.MergeFrom(other.RuntimeData);
			}
			if (other.moveSplineConfig_ != null)
			{
				if (this.moveSplineConfig_ == null)
				{
					this.MoveSplineConfig = new MoveSplineConfig();
				}
				this.MoveSplineConfig.MergeFrom(other.MoveSplineConfig);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017C37 RID: 97335 RVA: 0x00373B38 File Offset: 0x00371D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017C38 RID: 97336 RVA: 0x00373B44 File Offset: 0x00371D44
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
					if (num == 18U)
					{
						if (this.runtimeData_ == null)
						{
							this.RuntimeData = new SceneItemSplineRuntimeData();
						}
						input.ReadMessage(this.RuntimeData);
						continue;
					}
					if (num == 32U)
					{
						this.MoveStatus = (MoveStatus)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.SplineEntityId = input.ReadInt32();
						continue;
					}
					if (num == 58U)
					{
						if (this.moveSplineConfig_ == null)
						{
							this.MoveSplineConfig = new MoveSplineConfig();
						}
						input.ReadMessage(this.MoveSplineConfig);
						continue;
					}
					if (num == 72U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008CF9 RID: 36089
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008CFA RID: 36090
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04008CFB RID: 36091
		private long entityId_;

		// Token: 0x04008CFC RID: 36092
		public const int SplineEntityIdFieldNumber = 5;

		// Token: 0x04008CFD RID: 36093
		private int splineEntityId_;

		// Token: 0x04008CFE RID: 36094
		public const int MoveStatusFieldNumber = 4;

		// Token: 0x04008CFF RID: 36095
		private MoveStatus moveStatus_;

		// Token: 0x04008D00 RID: 36096
		public const int RuntimeDataFieldNumber = 2;

		// Token: 0x04008D01 RID: 36097
		private SceneItemSplineRuntimeData runtimeData_;

		// Token: 0x04008D02 RID: 36098
		public const int MoveSplineConfigFieldNumber = 7;

		// Token: 0x04008D03 RID: 36099
		private MoveSplineConfig moveSplineConfig_;
	}
}
