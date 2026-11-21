using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200048D RID: 1165
	public sealed class EntityMoveSplineComponentPb : IMessage<EntityMoveSplineComponentPb>, IMessage, IEquatable<EntityMoveSplineComponentPb>, IDeepCloneable<EntityMoveSplineComponentPb>, IBufferMessage
	{
		// Token: 0x06006FC3 RID: 28611 RVA: 0x00112FDB File Offset: 0x001111DB
		[NullableContext(1)]
		public static EntityMoveSplineComponentPb Create()
		{
			return new EntityMoveSplineComponentPb();
		}

		// Token: 0x17001587 RID: 5511
		// (get) Token: 0x06006FC4 RID: 28612 RVA: 0x00112FE2 File Offset: 0x001111E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001588 RID: 5512
		// (get) Token: 0x06006FC5 RID: 28613 RVA: 0x00112FE5 File Offset: 0x001111E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityMoveSplineComponentPb.Descriptor;
			}
		}

		// Token: 0x06006FC6 RID: 28614 RVA: 0x00112FEC File Offset: 0x001111EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityMoveSplineComponentPb()
		{
		}

		// Token: 0x06006FC7 RID: 28615 RVA: 0x00112FF4 File Offset: 0x001111F4
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

		// Token: 0x06006FC8 RID: 28616 RVA: 0x0011305B File Offset: 0x0011125B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityMoveSplineComponentPb Clone()
		{
			return new EntityMoveSplineComponentPb(this);
		}

		// Token: 0x17001589 RID: 5513
		// (get) Token: 0x06006FC9 RID: 28617 RVA: 0x00113063 File Offset: 0x00111263
		// (set) Token: 0x06006FCA RID: 28618 RVA: 0x0011306B File Offset: 0x0011126B
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

		// Token: 0x1700158A RID: 5514
		// (get) Token: 0x06006FCB RID: 28619 RVA: 0x00113074 File Offset: 0x00111274
		// (set) Token: 0x06006FCC RID: 28620 RVA: 0x0011307C File Offset: 0x0011127C
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

		// Token: 0x1700158B RID: 5515
		// (get) Token: 0x06006FCD RID: 28621 RVA: 0x00113085 File Offset: 0x00111285
		// (set) Token: 0x06006FCE RID: 28622 RVA: 0x0011309E File Offset: 0x0011129E
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

		// Token: 0x1700158C RID: 5516
		// (get) Token: 0x06006FCF RID: 28623 RVA: 0x001130B5 File Offset: 0x001112B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityMoveSplineComponentPb.RuntimeDataOneofCase RuntimeDataCase
		{
			get
			{
				return this.runtimeDataCase_;
			}
		}

		// Token: 0x06006FD0 RID: 28624 RVA: 0x001130BD File Offset: 0x001112BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearRuntimeData()
		{
			this.runtimeDataCase_ = EntityMoveSplineComponentPb.RuntimeDataOneofCase.None;
			this.runtimeData_ = null;
		}

		// Token: 0x06006FD1 RID: 28625 RVA: 0x001130CD File Offset: 0x001112CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityMoveSplineComponentPb);
		}

		// Token: 0x06006FD2 RID: 28626 RVA: 0x001130DC File Offset: 0x001112DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityMoveSplineComponentPb other)
		{
			return other != null && (other == this || (this.SplineEntityId == other.SplineEntityId && object.Equals(this.MoveSplineConfig, other.MoveSplineConfig) && object.Equals(this.SceneItemRuntimeData, other.SceneItemRuntimeData) && this.RuntimeDataCase == other.RuntimeDataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006FD3 RID: 28627 RVA: 0x00113150 File Offset: 0x00111350
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

		// Token: 0x06006FD4 RID: 28628 RVA: 0x001131C6 File Offset: 0x001113C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006FD5 RID: 28629 RVA: 0x001131D3 File Offset: 0x001113D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006FD6 RID: 28630 RVA: 0x001131DC File Offset: 0x001113DC
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

		// Token: 0x06006FD7 RID: 28631 RVA: 0x00113254 File Offset: 0x00111454
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

		// Token: 0x06006FD8 RID: 28632 RVA: 0x001132C4 File Offset: 0x001114C4
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

		// Token: 0x06006FD9 RID: 28633 RVA: 0x0011335A File Offset: 0x0011155A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006FDA RID: 28634 RVA: 0x00113364 File Offset: 0x00111564
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

		// Token: 0x04003C6B RID: 15467
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C6C RID: 15468
		public const int SplineEntityIdFieldNumber = 1;

		// Token: 0x04003C6D RID: 15469
		private int splineEntityId_;

		// Token: 0x04003C6E RID: 15470
		public const int MoveSplineConfigFieldNumber = 2;

		// Token: 0x04003C6F RID: 15471
		private MoveSplineConfig moveSplineConfig_;

		// Token: 0x04003C70 RID: 15472
		public const int SceneItemRuntimeDataFieldNumber = 11;

		// Token: 0x04003C71 RID: 15473
		private object runtimeData_;

		// Token: 0x04003C72 RID: 15474
		private EntityMoveSplineComponentPb.RuntimeDataOneofCase runtimeDataCase_;

		// Token: 0x020017EB RID: 6123
		public enum RuntimeDataOneofCase
		{
			// Token: 0x0400CBAE RID: 52142
			None,
			// Token: 0x0400CBAF RID: 52143
			SceneItemRuntimeData = 11
		}
	}
}
