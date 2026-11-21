using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AB5 RID: 2741
	[NetMessage(EMessageId.MoveSplineStatusNotify)]
	public sealed class MoveSplineStatusNotify : IMessage<MoveSplineStatusNotify>, IMessage, IEquatable<MoveSplineStatusNotify>, IDeepCloneable<MoveSplineStatusNotify>, IBufferMessage
	{
		// Token: 0x0600EF05 RID: 61189 RVA: 0x0022F196 File Offset: 0x0022D396
		[NullableContext(1)]
		public static MoveSplineStatusNotify Create()
		{
			return new MoveSplineStatusNotify();
		}

		// Token: 0x170030A1 RID: 12449
		// (get) Token: 0x0600EF06 RID: 61190 RVA: 0x0022F19D File Offset: 0x0022D39D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030A2 RID: 12450
		// (get) Token: 0x0600EF07 RID: 61191 RVA: 0x0022F1A0 File Offset: 0x0022D3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoveSplineStatusNotify.Descriptor;
			}
		}

		// Token: 0x0600EF08 RID: 61192 RVA: 0x0022F1A7 File Offset: 0x0022D3A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSplineStatusNotify()
		{
		}

		// Token: 0x0600EF09 RID: 61193 RVA: 0x0022F1B0 File Offset: 0x0022D3B0
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

		// Token: 0x0600EF0A RID: 61194 RVA: 0x0022F22E File Offset: 0x0022D42E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSplineStatusNotify Clone()
		{
			return new MoveSplineStatusNotify(this);
		}

		// Token: 0x170030A3 RID: 12451
		// (get) Token: 0x0600EF0B RID: 61195 RVA: 0x0022F236 File Offset: 0x0022D436
		// (set) Token: 0x0600EF0C RID: 61196 RVA: 0x0022F23E File Offset: 0x0022D43E
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

		// Token: 0x170030A4 RID: 12452
		// (get) Token: 0x0600EF0D RID: 61197 RVA: 0x0022F247 File Offset: 0x0022D447
		// (set) Token: 0x0600EF0E RID: 61198 RVA: 0x0022F24F File Offset: 0x0022D44F
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

		// Token: 0x170030A5 RID: 12453
		// (get) Token: 0x0600EF0F RID: 61199 RVA: 0x0022F258 File Offset: 0x0022D458
		// (set) Token: 0x0600EF10 RID: 61200 RVA: 0x0022F260 File Offset: 0x0022D460
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

		// Token: 0x170030A6 RID: 12454
		// (get) Token: 0x0600EF11 RID: 61201 RVA: 0x0022F269 File Offset: 0x0022D469
		// (set) Token: 0x0600EF12 RID: 61202 RVA: 0x0022F271 File Offset: 0x0022D471
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

		// Token: 0x170030A7 RID: 12455
		// (get) Token: 0x0600EF13 RID: 61203 RVA: 0x0022F27A File Offset: 0x0022D47A
		// (set) Token: 0x0600EF14 RID: 61204 RVA: 0x0022F292 File Offset: 0x0022D492
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

		// Token: 0x170030A8 RID: 12456
		// (get) Token: 0x0600EF15 RID: 61205 RVA: 0x0022F2A8 File Offset: 0x0022D4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSplineStatusNotify.RuntimeDataOneofCase RuntimeDataCase
		{
			get
			{
				return this.runtimeDataCase_;
			}
		}

		// Token: 0x0600EF16 RID: 61206 RVA: 0x0022F2B0 File Offset: 0x0022D4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearRuntimeData()
		{
			this.runtimeDataCase_ = MoveSplineStatusNotify.RuntimeDataOneofCase.None;
			this.runtimeData_ = null;
		}

		// Token: 0x0600EF17 RID: 61207 RVA: 0x0022F2C0 File Offset: 0x0022D4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoveSplineStatusNotify);
		}

		// Token: 0x0600EF18 RID: 61208 RVA: 0x0022F2D0 File Offset: 0x0022D4D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoveSplineStatusNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.SplineEntityId == other.SplineEntityId && object.Equals(this.MoveSplineConfig, other.MoveSplineConfig) && this.MoveStatus == other.MoveStatus && object.Equals(this.SceneItemRuntimeData, other.SceneItemRuntimeData) && this.RuntimeDataCase == other.RuntimeDataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EF19 RID: 61209 RVA: 0x0022F364 File Offset: 0x0022D564
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

		// Token: 0x0600EF1A RID: 61210 RVA: 0x0022F411 File Offset: 0x0022D611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EF1B RID: 61211 RVA: 0x0022F41E File Offset: 0x0022D61E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EF1C RID: 61212 RVA: 0x0022F428 File Offset: 0x0022D628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.runtimeDataCase_ == MoveSplineStatusNotify.RuntimeDataOneofCase.SceneItemRuntimeData)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.SceneItemRuntimeData);
			}
			if (this.MoveStatus != MoveStatus.Stop)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.MoveStatus);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
			}
			if (this.SplineEntityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SplineEntityId);
			}
			if (this.moveSplineConfig_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.MoveSplineConfig);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EF1D RID: 61213 RVA: 0x0022F4D8 File Offset: 0x0022D6D8
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

		// Token: 0x0600EF1E RID: 61214 RVA: 0x0022F578 File Offset: 0x0022D778
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

		// Token: 0x0600EF1F RID: 61215 RVA: 0x0022F635 File Offset: 0x0022D835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EF20 RID: 61216 RVA: 0x0022F640 File Offset: 0x0022D840
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
					if (num == 26U)
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
					if (num == 56U)
					{
						this.MoveStatus = (MoveStatus)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 88U)
					{
						this.SplineEntityId = input.ReadInt32();
						continue;
					}
					if (num == 98U)
					{
						if (this.moveSplineConfig_ == null)
						{
							this.MoveSplineConfig = new MoveSplineConfig();
						}
						input.ReadMessage(this.MoveSplineConfig);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400611E RID: 24862
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400611F RID: 24863
		public const int EntityIdFieldNumber = 10;

		// Token: 0x04006120 RID: 24864
		private long entityId_;

		// Token: 0x04006121 RID: 24865
		public const int SplineEntityIdFieldNumber = 11;

		// Token: 0x04006122 RID: 24866
		private int splineEntityId_;

		// Token: 0x04006123 RID: 24867
		public const int MoveSplineConfigFieldNumber = 12;

		// Token: 0x04006124 RID: 24868
		private MoveSplineConfig moveSplineConfig_;

		// Token: 0x04006125 RID: 24869
		public const int MoveStatusFieldNumber = 7;

		// Token: 0x04006126 RID: 24870
		private MoveStatus moveStatus_;

		// Token: 0x04006127 RID: 24871
		public const int SceneItemRuntimeDataFieldNumber = 3;

		// Token: 0x04006128 RID: 24872
		private object runtimeData_;

		// Token: 0x04006129 RID: 24873
		private MoveSplineStatusNotify.RuntimeDataOneofCase runtimeDataCase_;

		// Token: 0x020018D0 RID: 6352
		public enum RuntimeDataOneofCase
		{
			// Token: 0x0400CD5A RID: 52570
			None,
			// Token: 0x0400CD5B RID: 52571
			SceneItemRuntimeData = 3
		}
	}
}
