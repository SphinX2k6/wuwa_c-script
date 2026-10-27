using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AC6 RID: 2758
	[NetMessage(EMessageId.MoveSplineStatusNotify)]
	public sealed class MoveSplineStatusNotify : IMessage<MoveSplineStatusNotify>, IMessage, IEquatable<MoveSplineStatusNotify>, IDeepCloneable<MoveSplineStatusNotify>, IBufferMessage
	{
		// Token: 0x0600F01F RID: 61471 RVA: 0x0023139E File Offset: 0x0022F59E
		[NullableContext(1)]
		public static MoveSplineStatusNotify Create()
		{
			return new MoveSplineStatusNotify();
		}

		// Token: 0x170030DF RID: 12511
		// (get) Token: 0x0600F020 RID: 61472 RVA: 0x002313A5 File Offset: 0x0022F5A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030E0 RID: 12512
		// (get) Token: 0x0600F021 RID: 61473 RVA: 0x002313A8 File Offset: 0x0022F5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoveSplineStatusNotify.Descriptor;
			}
		}

		// Token: 0x0600F022 RID: 61474 RVA: 0x002313AF File Offset: 0x0022F5AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSplineStatusNotify()
		{
		}

		// Token: 0x0600F023 RID: 61475 RVA: 0x002313B8 File Offset: 0x0022F5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSplineStatusNotify(MoveSplineStatusNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.splineEntityId_ = other.splineEntityId_;
			this.moveSplineConfig_ = ((other.moveSplineConfig_ != null) ? other.moveSplineConfig_.Clone() : null);
			this.moveStatus_ = other.moveStatus_;
			if (other.RuntimeDataCase == MoveSplineStatusNotify.RuntimeDataOneofCase.SceneItemRuntimeData)
			{
				this.SceneItemRuntimeData = other.SceneItemRuntimeData.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F024 RID: 61476 RVA: 0x00231437 File Offset: 0x0022F637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSplineStatusNotify Clone()
		{
			return new MoveSplineStatusNotify(this);
		}

		// Token: 0x170030E1 RID: 12513
		// (get) Token: 0x0600F025 RID: 61477 RVA: 0x0023143F File Offset: 0x0022F63F
		// (set) Token: 0x0600F026 RID: 61478 RVA: 0x00231447 File Offset: 0x0022F647
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

		// Token: 0x170030E2 RID: 12514
		// (get) Token: 0x0600F027 RID: 61479 RVA: 0x00231450 File Offset: 0x0022F650
		// (set) Token: 0x0600F028 RID: 61480 RVA: 0x00231458 File Offset: 0x0022F658
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

		// Token: 0x170030E3 RID: 12515
		// (get) Token: 0x0600F029 RID: 61481 RVA: 0x00231461 File Offset: 0x0022F661
		// (set) Token: 0x0600F02A RID: 61482 RVA: 0x00231469 File Offset: 0x0022F669
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

		// Token: 0x170030E4 RID: 12516
		// (get) Token: 0x0600F02B RID: 61483 RVA: 0x00231472 File Offset: 0x0022F672
		// (set) Token: 0x0600F02C RID: 61484 RVA: 0x0023147A File Offset: 0x0022F67A
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

		// Token: 0x170030E5 RID: 12517
		// (get) Token: 0x0600F02D RID: 61485 RVA: 0x00231483 File Offset: 0x0022F683
		// (set) Token: 0x0600F02E RID: 61486 RVA: 0x0023149C File Offset: 0x0022F69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSplineRuntimeData SceneItemRuntimeData
		{
			get
			{
				if (this.runtimeDataCase_ != MoveSplineStatusNotify.RuntimeDataOneofCase.SceneItemRuntimeData)
				{
					return null;
				}
				return (SceneItemSplineRuntimeData)this.runtimeData_;
			}
			set
			{
				this.runtimeData_ = value;
				this.runtimeDataCase_ = ((value == null) ? MoveSplineStatusNotify.RuntimeDataOneofCase.None : MoveSplineStatusNotify.RuntimeDataOneofCase.SceneItemRuntimeData);
			}
		}

		// Token: 0x170030E6 RID: 12518
		// (get) Token: 0x0600F02F RID: 61487 RVA: 0x002314B3 File Offset: 0x0022F6B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSplineStatusNotify.RuntimeDataOneofCase RuntimeDataCase
		{
			get
			{
				return this.runtimeDataCase_;
			}
		}

		// Token: 0x0600F030 RID: 61488 RVA: 0x002314BB File Offset: 0x0022F6BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearRuntimeData()
		{
			this.runtimeDataCase_ = MoveSplineStatusNotify.RuntimeDataOneofCase.None;
			this.runtimeData_ = null;
		}

		// Token: 0x0600F031 RID: 61489 RVA: 0x002314CB File Offset: 0x0022F6CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoveSplineStatusNotify);
		}

		// Token: 0x0600F032 RID: 61490 RVA: 0x002314DC File Offset: 0x0022F6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoveSplineStatusNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.SplineEntityId == other.SplineEntityId && object.Equals(this.MoveSplineConfig, other.MoveSplineConfig) && this.MoveStatus == other.MoveStatus && object.Equals(this.SceneItemRuntimeData, other.SceneItemRuntimeData) && this.RuntimeDataCase == other.RuntimeDataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F033 RID: 61491 RVA: 0x00231570 File Offset: 0x0022F770
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
			if (this.moveSplineConfig_ != null)
			{
				num ^= this.MoveSplineConfig.GetHashCode();
			}
			if (this.MoveStatus != MoveStatus.Stop)
			{
				num ^= this.MoveStatus.GetHashCode();
			}
			if (this.runtimeDataCase_ == MoveSplineStatusNotify.RuntimeDataOneofCase.SceneItemRuntimeData)
			{
				num ^= this.SceneItemRuntimeData.GetHashCode();
			}
			num ^= (int)this.runtimeDataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F034 RID: 61492 RVA: 0x0023161E File Offset: 0x0022F81E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F035 RID: 61493 RVA: 0x0023162B File Offset: 0x0022F82B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F036 RID: 61494 RVA: 0x00231634 File Offset: 0x0022F834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MoveStatus != MoveStatus.Stop)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.MoveStatus);
			}
			if (this.SplineEntityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SplineEntityId);
			}
			if (this.moveSplineConfig_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.MoveSplineConfig);
			}
			if (this.runtimeDataCase_ == MoveSplineStatusNotify.RuntimeDataOneofCase.SceneItemRuntimeData)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.SceneItemRuntimeData);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F037 RID: 61495 RVA: 0x002316E4 File Offset: 0x0022F8E4
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
			if (this.moveSplineConfig_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MoveSplineConfig);
			}
			if (this.MoveStatus != MoveStatus.Stop)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MoveStatus);
			}
			if (this.runtimeDataCase_ == MoveSplineStatusNotify.RuntimeDataOneofCase.SceneItemRuntimeData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SceneItemRuntimeData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F038 RID: 61496 RVA: 0x00231784 File Offset: 0x0022F984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoveSplineStatusNotify other)
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
			if (other.moveSplineConfig_ != null)
			{
				if (this.moveSplineConfig_ == null)
				{
					this.MoveSplineConfig = new MoveSplineConfig();
				}
				this.MoveSplineConfig.MergeFrom(other.MoveSplineConfig);
			}
			if (other.MoveStatus != MoveStatus.Stop)
			{
				this.MoveStatus = other.MoveStatus;
			}
			if (other.RuntimeDataCase == MoveSplineStatusNotify.RuntimeDataOneofCase.SceneItemRuntimeData)
			{
				if (this.SceneItemRuntimeData == null)
				{
					this.SceneItemRuntimeData = new SceneItemSplineRuntimeData();
				}
				this.SceneItemRuntimeData.MergeFrom(other.SceneItemRuntimeData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F039 RID: 61497 RVA: 0x00231842 File Offset: 0x0022FA42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F03A RID: 61498 RVA: 0x0023184C File Offset: 0x0022FA4C
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
				if (num <= 56U)
				{
					if (num == 16U)
					{
						this.MoveStatus = (MoveStatus)input.ReadEnum();
						continue;
					}
					if (num == 56U)
					{
						this.SplineEntityId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						if (this.moveSplineConfig_ == null)
						{
							this.MoveSplineConfig = new MoveSplineConfig();
						}
						input.ReadMessage(this.MoveSplineConfig);
						continue;
					}
					if (num == 106U)
					{
						SceneItemSplineRuntimeData sceneItemSplineRuntimeData = new SceneItemSplineRuntimeData();
						if (this.runtimeDataCase_ == MoveSplineStatusNotify.RuntimeDataOneofCase.SceneItemRuntimeData)
						{
							sceneItemSplineRuntimeData.MergeFrom(this.SceneItemRuntimeData);
						}
						input.ReadMessage(sceneItemSplineRuntimeData);
						this.SceneItemRuntimeData = sceneItemSplineRuntimeData;
						continue;
					}
					if (num == 112U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006115 RID: 24853
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006116 RID: 24854
		public const int EntityIdFieldNumber = 14;

		// Token: 0x04006117 RID: 24855
		private long entityId_;

		// Token: 0x04006118 RID: 24856
		public const int SplineEntityIdFieldNumber = 7;

		// Token: 0x04006119 RID: 24857
		private int splineEntityId_;

		// Token: 0x0400611A RID: 24858
		public const int MoveSplineConfigFieldNumber = 12;

		// Token: 0x0400611B RID: 24859
		private MoveSplineConfig moveSplineConfig_;

		// Token: 0x0400611C RID: 24860
		public const int MoveStatusFieldNumber = 2;

		// Token: 0x0400611D RID: 24861
		private MoveStatus moveStatus_;

		// Token: 0x0400611E RID: 24862
		public const int SceneItemRuntimeDataFieldNumber = 13;

		// Token: 0x0400611F RID: 24863
		private object runtimeData_;

		// Token: 0x04006120 RID: 24864
		private MoveSplineStatusNotify.RuntimeDataOneofCase runtimeDataCase_;

		// Token: 0x02001858 RID: 6232
		public enum RuntimeDataOneofCase
		{
			// Token: 0x0400C82F RID: 51247
			None,
			// Token: 0x0400C830 RID: 51248
			SceneItemRuntimeData = 13
		}
	}
}
