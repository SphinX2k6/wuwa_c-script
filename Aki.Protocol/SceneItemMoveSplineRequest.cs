using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011A2 RID: 4514
	[NetMessage(EMessageId.SceneItemMoveSplineRequest)]
	public sealed class SceneItemMoveSplineRequest : IMessage<SceneItemMoveSplineRequest>, IMessage, IEquatable<SceneItemMoveSplineRequest>, IDeepCloneable<SceneItemMoveSplineRequest>, IBufferMessage
	{
		// Token: 0x060181C0 RID: 98752 RVA: 0x00382A34 File Offset: 0x00380C34
		[NullableContext(1)]
		public static SceneItemMoveSplineRequest Create()
		{
			return new SceneItemMoveSplineRequest();
		}

		// Token: 0x1700513A RID: 20794
		// (get) Token: 0x060181C1 RID: 98753 RVA: 0x00382A3B File Offset: 0x00380C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700513B RID: 20795
		// (get) Token: 0x060181C2 RID: 98754 RVA: 0x00382A3E File Offset: 0x00380C3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemMoveSplineRequest.Descriptor;
			}
		}

		// Token: 0x060181C3 RID: 98755 RVA: 0x00382A45 File Offset: 0x00380C45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveSplineRequest()
		{
		}

		// Token: 0x060181C4 RID: 98756 RVA: 0x00382A50 File Offset: 0x00380C50
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

		// Token: 0x060181C5 RID: 98757 RVA: 0x00382AD0 File Offset: 0x00380CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveSplineRequest Clone()
		{
			return new SceneItemMoveSplineRequest(this);
		}

		// Token: 0x1700513C RID: 20796
		// (get) Token: 0x060181C6 RID: 98758 RVA: 0x00382AD8 File Offset: 0x00380CD8
		// (set) Token: 0x060181C7 RID: 98759 RVA: 0x00382AE0 File Offset: 0x00380CE0
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

		// Token: 0x1700513D RID: 20797
		// (get) Token: 0x060181C8 RID: 98760 RVA: 0x00382AE9 File Offset: 0x00380CE9
		// (set) Token: 0x060181C9 RID: 98761 RVA: 0x00382AF1 File Offset: 0x00380CF1
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

		// Token: 0x1700513E RID: 20798
		// (get) Token: 0x060181CA RID: 98762 RVA: 0x00382AFA File Offset: 0x00380CFA
		// (set) Token: 0x060181CB RID: 98763 RVA: 0x00382B02 File Offset: 0x00380D02
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

		// Token: 0x1700513F RID: 20799
		// (get) Token: 0x060181CC RID: 98764 RVA: 0x00382B0B File Offset: 0x00380D0B
		// (set) Token: 0x060181CD RID: 98765 RVA: 0x00382B13 File Offset: 0x00380D13
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

		// Token: 0x17005140 RID: 20800
		// (get) Token: 0x060181CE RID: 98766 RVA: 0x00382B1C File Offset: 0x00380D1C
		// (set) Token: 0x060181CF RID: 98767 RVA: 0x00382B24 File Offset: 0x00380D24
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

		// Token: 0x060181D0 RID: 98768 RVA: 0x00382B2D File Offset: 0x00380D2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemMoveSplineRequest);
		}

		// Token: 0x060181D1 RID: 98769 RVA: 0x00382B3C File Offset: 0x00380D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemMoveSplineRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.SplineEntityId == other.SplineEntityId && this.MoveStatus == other.MoveStatus && object.Equals(this.RuntimeData, other.RuntimeData) && object.Equals(this.MoveSplineConfig, other.MoveSplineConfig) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060181D2 RID: 98770 RVA: 0x00382BC0 File Offset: 0x00380DC0
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

		// Token: 0x060181D3 RID: 98771 RVA: 0x00382C63 File Offset: 0x00380E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060181D4 RID: 98772 RVA: 0x00382C70 File Offset: 0x00380E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060181D5 RID: 98773 RVA: 0x00382C7C File Offset: 0x00380E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MoveStatus != MoveStatus.Stop)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.MoveStatus);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this.runtimeData_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.RuntimeData);
			}
			if (this.SplineEntityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SplineEntityId);
			}
			if (this.moveSplineConfig_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.MoveSplineConfig);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060181D6 RID: 98774 RVA: 0x00382D2C File Offset: 0x00380F2C
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

		// Token: 0x060181D7 RID: 98775 RVA: 0x00382DCC File Offset: 0x00380FCC
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

		// Token: 0x060181D8 RID: 98776 RVA: 0x00382E88 File Offset: 0x00381088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060181D9 RID: 98777 RVA: 0x00382E94 File Offset: 0x00381094
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
				if (num <= 40U)
				{
					if (num == 16U)
					{
						this.MoveStatus = (MoveStatus)input.ReadEnum();
						continue;
					}
					if (num == 40U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						if (this.runtimeData_ == null)
						{
							this.RuntimeData = new SceneItemSplineRuntimeData();
						}
						input.ReadMessage(this.RuntimeData);
						continue;
					}
					if (num == 64U)
					{
						this.SplineEntityId = input.ReadInt32();
						continue;
					}
					if (num == 106U)
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

		// Token: 0x04008F8C RID: 36748
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F8D RID: 36749
		public const int EntityIdFieldNumber = 5;

		// Token: 0x04008F8E RID: 36750
		private long entityId_;

		// Token: 0x04008F8F RID: 36751
		public const int SplineEntityIdFieldNumber = 8;

		// Token: 0x04008F90 RID: 36752
		private int splineEntityId_;

		// Token: 0x04008F91 RID: 36753
		public const int MoveStatusFieldNumber = 2;

		// Token: 0x04008F92 RID: 36754
		private MoveStatus moveStatus_;

		// Token: 0x04008F93 RID: 36755
		public const int RuntimeDataFieldNumber = 6;

		// Token: 0x04008F94 RID: 36756
		private SceneItemSplineRuntimeData runtimeData_;

		// Token: 0x04008F95 RID: 36757
		public const int MoveSplineConfigFieldNumber = 13;

		// Token: 0x04008F96 RID: 36758
		private MoveSplineConfig moveSplineConfig_;
	}
}
