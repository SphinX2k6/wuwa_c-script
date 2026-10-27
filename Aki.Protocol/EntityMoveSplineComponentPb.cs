using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004A4 RID: 1188
	public sealed class EntityMoveSplineComponentPb : IMessage<EntityMoveSplineComponentPb>, IMessage, IEquatable<EntityMoveSplineComponentPb>, IDeepCloneable<EntityMoveSplineComponentPb>, IBufferMessage
	{
		// Token: 0x06007151 RID: 29009 RVA: 0x00116053 File Offset: 0x00114253
		[NullableContext(1)]
		public static EntityMoveSplineComponentPb Create()
		{
			return new EntityMoveSplineComponentPb();
		}

		// Token: 0x170015DB RID: 5595
		// (get) Token: 0x06007152 RID: 29010 RVA: 0x0011605A File Offset: 0x0011425A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015DC RID: 5596
		// (get) Token: 0x06007153 RID: 29011 RVA: 0x0011605D File Offset: 0x0011425D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityMoveSplineComponentPb.Descriptor;
			}
		}

		// Token: 0x06007154 RID: 29012 RVA: 0x00116064 File Offset: 0x00114264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityMoveSplineComponentPb()
		{
		}

		// Token: 0x06007155 RID: 29013 RVA: 0x0011606C File Offset: 0x0011426C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityMoveSplineComponentPb(EntityMoveSplineComponentPb other) : this()
		{
			this.splineEntityId_ = other.splineEntityId_;
			this.moveSplineConfig_ = ((other.moveSplineConfig_ != null) ? other.moveSplineConfig_.Clone() : null);
			if (other.RuntimeDataCase == EntityMoveSplineComponentPb.RuntimeDataOneofCase.SceneItemRuntimeData)
			{
				this.SceneItemRuntimeData = other.SceneItemRuntimeData.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007156 RID: 29014 RVA: 0x001160D3 File Offset: 0x001142D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityMoveSplineComponentPb Clone()
		{
			return new EntityMoveSplineComponentPb(this);
		}

		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x06007157 RID: 29015 RVA: 0x001160DB File Offset: 0x001142DB
		// (set) Token: 0x06007158 RID: 29016 RVA: 0x001160E3 File Offset: 0x001142E3
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

		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x06007159 RID: 29017 RVA: 0x001160EC File Offset: 0x001142EC
		// (set) Token: 0x0600715A RID: 29018 RVA: 0x001160F4 File Offset: 0x001142F4
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

		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x0600715B RID: 29019 RVA: 0x001160FD File Offset: 0x001142FD
		// (set) Token: 0x0600715C RID: 29020 RVA: 0x00116116 File Offset: 0x00114316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSplineRuntimeData SceneItemRuntimeData
		{
			get
			{
				if (this.runtimeDataCase_ != EntityMoveSplineComponentPb.RuntimeDataOneofCase.SceneItemRuntimeData)
				{
					return null;
				}
				return (SceneItemSplineRuntimeData)this.runtimeData_;
			}
			set
			{
				this.runtimeData_ = value;
				this.runtimeDataCase_ = ((value == null) ? EntityMoveSplineComponentPb.RuntimeDataOneofCase.None : EntityMoveSplineComponentPb.RuntimeDataOneofCase.SceneItemRuntimeData);
			}
		}

		// Token: 0x170015E0 RID: 5600
		// (get) Token: 0x0600715D RID: 29021 RVA: 0x0011612D File Offset: 0x0011432D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityMoveSplineComponentPb.RuntimeDataOneofCase RuntimeDataCase
		{
			get
			{
				return this.runtimeDataCase_;
			}
		}

		// Token: 0x0600715E RID: 29022 RVA: 0x00116135 File Offset: 0x00114335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearRuntimeData()
		{
			this.runtimeDataCase_ = EntityMoveSplineComponentPb.RuntimeDataOneofCase.None;
			this.runtimeData_ = null;
		}

		// Token: 0x0600715F RID: 29023 RVA: 0x00116145 File Offset: 0x00114345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityMoveSplineComponentPb);
		}

		// Token: 0x06007160 RID: 29024 RVA: 0x00116154 File Offset: 0x00114354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityMoveSplineComponentPb other)
		{
			return other != null && (other == this || (this.SplineEntityId == other.SplineEntityId && object.Equals(this.MoveSplineConfig, other.MoveSplineConfig) && object.Equals(this.SceneItemRuntimeData, other.SceneItemRuntimeData) && this.RuntimeDataCase == other.RuntimeDataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007161 RID: 29025 RVA: 0x001161C8 File Offset: 0x001143C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SplineEntityId != 0)
			{
				num ^= this.SplineEntityId.GetHashCode();
			}
			if (this.moveSplineConfig_ != null)
			{
				num ^= this.MoveSplineConfig.GetHashCode();
			}
			if (this.runtimeDataCase_ == EntityMoveSplineComponentPb.RuntimeDataOneofCase.SceneItemRuntimeData)
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

		// Token: 0x06007162 RID: 29026 RVA: 0x0011623E File Offset: 0x0011443E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007163 RID: 29027 RVA: 0x0011624B File Offset: 0x0011444B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007164 RID: 29028 RVA: 0x00116254 File Offset: 0x00114454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SplineEntityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SplineEntityId);
			}
			if (this.moveSplineConfig_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.MoveSplineConfig);
			}
			if (this.runtimeDataCase_ == EntityMoveSplineComponentPb.RuntimeDataOneofCase.SceneItemRuntimeData)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.SceneItemRuntimeData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007165 RID: 29029 RVA: 0x001162CC File Offset: 0x001144CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SplineEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SplineEntityId);
			}
			if (this.moveSplineConfig_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MoveSplineConfig);
			}
			if (this.runtimeDataCase_ == EntityMoveSplineComponentPb.RuntimeDataOneofCase.SceneItemRuntimeData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SceneItemRuntimeData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007166 RID: 29030 RVA: 0x0011633C File Offset: 0x0011453C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityMoveSplineComponentPb other)
		{
			if (other == null)
			{
				return;
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
			if (other.RuntimeDataCase == EntityMoveSplineComponentPb.RuntimeDataOneofCase.SceneItemRuntimeData)
			{
				if (this.SceneItemRuntimeData == null)
				{
					this.SceneItemRuntimeData = new SceneItemSplineRuntimeData();
				}
				this.SceneItemRuntimeData.MergeFrom(other.SceneItemRuntimeData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007167 RID: 29031 RVA: 0x001163D2 File Offset: 0x001145D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007168 RID: 29032 RVA: 0x001163DC File Offset: 0x001145DC
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							SceneItemSplineRuntimeData sceneItemSplineRuntimeData = new SceneItemSplineRuntimeData();
							if (this.runtimeDataCase_ == EntityMoveSplineComponentPb.RuntimeDataOneofCase.SceneItemRuntimeData)
							{
								sceneItemSplineRuntimeData.MergeFrom(this.SceneItemRuntimeData);
							}
							input.ReadMessage(sceneItemSplineRuntimeData);
							this.SceneItemRuntimeData = sceneItemSplineRuntimeData;
						}
					}
					else
					{
						if (this.moveSplineConfig_ == null)
						{
							this.MoveSplineConfig = new MoveSplineConfig();
						}
						input.ReadMessage(this.MoveSplineConfig);
					}
				}
				else
				{
					this.SplineEntityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003C7D RID: 15485
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C7E RID: 15486
		public const int SplineEntityIdFieldNumber = 1;

		// Token: 0x04003C7F RID: 15487
		private int splineEntityId_;

		// Token: 0x04003C80 RID: 15488
		public const int MoveSplineConfigFieldNumber = 2;

		// Token: 0x04003C81 RID: 15489
		private MoveSplineConfig moveSplineConfig_;

		// Token: 0x04003C82 RID: 15490
		public const int SceneItemRuntimeDataFieldNumber = 11;

		// Token: 0x04003C83 RID: 15491
		private object runtimeData_;

		// Token: 0x04003C84 RID: 15492
		private EntityMoveSplineComponentPb.RuntimeDataOneofCase runtimeDataCase_;

		// Token: 0x02001773 RID: 6003
		public enum RuntimeDataOneofCase
		{
			// Token: 0x0400C683 RID: 50819
			None,
			// Token: 0x0400C684 RID: 50820
			SceneItemRuntimeData = 11
		}
	}
}
