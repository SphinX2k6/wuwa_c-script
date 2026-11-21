using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001185 RID: 4485
	[NetMessage(EMessageId.SceneChangeDataLayerNotify)]
	public sealed class SceneChangeDataLayerNotify : IMessage<SceneChangeDataLayerNotify>, IMessage, IEquatable<SceneChangeDataLayerNotify>, IDeepCloneable<SceneChangeDataLayerNotify>, IBufferMessage
	{
		// Token: 0x06017F3B RID: 98107 RVA: 0x0037C37D File Offset: 0x0037A57D
		[NullableContext(1)]
		public static SceneChangeDataLayerNotify Create()
		{
			return new SceneChangeDataLayerNotify();
		}

		// Token: 0x1700509D RID: 20637
		// (get) Token: 0x06017F3C RID: 98108 RVA: 0x0037C384 File Offset: 0x0037A584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700509E RID: 20638
		// (get) Token: 0x06017F3D RID: 98109 RVA: 0x0037C387 File Offset: 0x0037A587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneChangeDataLayerNotify.Descriptor;
			}
		}

		// Token: 0x06017F3E RID: 98110 RVA: 0x0037C390 File Offset: 0x0037A590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneChangeDataLayerNotify()
		{
		}

		// Token: 0x06017F3F RID: 98111 RVA: 0x0037C3E8 File Offset: 0x0037A5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneChangeDataLayerNotify(SceneChangeDataLayerNotify other) : this()
		{
			this.loadDataLayers_ = other.loadDataLayers_.Clone();
			this.unloadDataLayers_ = other.unloadDataLayers_.Clone();
			this.sequencePath_ = other.sequencePath_;
			this.materialDataForLoadedLayers_ = other.materialDataForLoadedLayers_;
			this.materialDataForUnloadLayers_ = other.materialDataForUnloadLayers_;
			this.entityId_ = other.entityId_;
			this.seqMarkBeforeModifyMat_ = other.seqMarkBeforeModifyMat_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017F40 RID: 98112 RVA: 0x0037C46A File Offset: 0x0037A66A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneChangeDataLayerNotify Clone()
		{
			return new SceneChangeDataLayerNotify(this);
		}

		// Token: 0x1700509F RID: 20639
		// (get) Token: 0x06017F41 RID: 98113 RVA: 0x0037C472 File Offset: 0x0037A672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LoadDataLayers
		{
			get
			{
				return this.loadDataLayers_;
			}
		}

		// Token: 0x170050A0 RID: 20640
		// (get) Token: 0x06017F42 RID: 98114 RVA: 0x0037C47A File Offset: 0x0037A67A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnloadDataLayers
		{
			get
			{
				return this.unloadDataLayers_;
			}
		}

		// Token: 0x170050A1 RID: 20641
		// (get) Token: 0x06017F43 RID: 98115 RVA: 0x0037C482 File Offset: 0x0037A682
		// (set) Token: 0x06017F44 RID: 98116 RVA: 0x0037C48A File Offset: 0x0037A68A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SequencePath
		{
			get
			{
				return this.sequencePath_;
			}
			set
			{
				this.sequencePath_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170050A2 RID: 20642
		// (get) Token: 0x06017F45 RID: 98117 RVA: 0x0037C49D File Offset: 0x0037A69D
		// (set) Token: 0x06017F46 RID: 98118 RVA: 0x0037C4A5 File Offset: 0x0037A6A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string MaterialDataForLoadedLayers
		{
			get
			{
				return this.materialDataForLoadedLayers_;
			}
			set
			{
				this.materialDataForLoadedLayers_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170050A3 RID: 20643
		// (get) Token: 0x06017F47 RID: 98119 RVA: 0x0037C4B8 File Offset: 0x0037A6B8
		// (set) Token: 0x06017F48 RID: 98120 RVA: 0x0037C4C0 File Offset: 0x0037A6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string MaterialDataForUnloadLayers
		{
			get
			{
				return this.materialDataForUnloadLayers_;
			}
			set
			{
				this.materialDataForUnloadLayers_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170050A4 RID: 20644
		// (get) Token: 0x06017F49 RID: 98121 RVA: 0x0037C4D3 File Offset: 0x0037A6D3
		// (set) Token: 0x06017F4A RID: 98122 RVA: 0x0037C4DB File Offset: 0x0037A6DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityId
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

		// Token: 0x170050A5 RID: 20645
		// (get) Token: 0x06017F4B RID: 98123 RVA: 0x0037C4E4 File Offset: 0x0037A6E4
		// (set) Token: 0x06017F4C RID: 98124 RVA: 0x0037C4EC File Offset: 0x0037A6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SeqMarkBeforeModifyMat
		{
			get
			{
				return this.seqMarkBeforeModifyMat_;
			}
			set
			{
				this.seqMarkBeforeModifyMat_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06017F4D RID: 98125 RVA: 0x0037C4FF File Offset: 0x0037A6FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneChangeDataLayerNotify);
		}

		// Token: 0x06017F4E RID: 98126 RVA: 0x0037C510 File Offset: 0x0037A710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneChangeDataLayerNotify other)
		{
			return other != null && (other == this || (this.loadDataLayers_.Equals(other.loadDataLayers_) && this.unloadDataLayers_.Equals(other.unloadDataLayers_) && !(this.SequencePath != other.SequencePath) && !(this.MaterialDataForLoadedLayers != other.MaterialDataForLoadedLayers) && !(this.MaterialDataForUnloadLayers != other.MaterialDataForUnloadLayers) && this.EntityId == other.EntityId && !(this.SeqMarkBeforeModifyMat != other.SeqMarkBeforeModifyMat) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017F4F RID: 98127 RVA: 0x0037C5C8 File Offset: 0x0037A7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.loadDataLayers_.GetHashCode();
			num ^= this.unloadDataLayers_.GetHashCode();
			if (this.SequencePath.Length != 0)
			{
				num ^= this.SequencePath.GetHashCode();
			}
			if (this.MaterialDataForLoadedLayers.Length != 0)
			{
				num ^= this.MaterialDataForLoadedLayers.GetHashCode();
			}
			if (this.MaterialDataForUnloadLayers.Length != 0)
			{
				num ^= this.MaterialDataForUnloadLayers.GetHashCode();
			}
			if (this.EntityId != 0)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.SeqMarkBeforeModifyMat.Length != 0)
			{
				num ^= this.SeqMarkBeforeModifyMat.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017F50 RID: 98128 RVA: 0x0037C68F File Offset: 0x0037A88F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017F51 RID: 98129 RVA: 0x0037C69C File Offset: 0x0037A89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017F52 RID: 98130 RVA: 0x0037C6A8 File Offset: 0x0037A8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SequencePath.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.SequencePath);
			}
			if (this.MaterialDataForUnloadLayers.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.MaterialDataForUnloadLayers);
			}
			this.unloadDataLayers_.WriteTo(ref output, SceneChangeDataLayerNotify._repeated_unloadDataLayers_codec);
			if (this.MaterialDataForLoadedLayers.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.MaterialDataForLoadedLayers);
			}
			if (this.EntityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.EntityId);
			}
			if (this.SeqMarkBeforeModifyMat.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.SeqMarkBeforeModifyMat);
			}
			this.loadDataLayers_.WriteTo(ref output, SceneChangeDataLayerNotify._repeated_loadDataLayers_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017F53 RID: 98131 RVA: 0x0037C78C File Offset: 0x0037A98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.loadDataLayers_.CalculateSize(SceneChangeDataLayerNotify._repeated_loadDataLayers_codec);
			num += this.unloadDataLayers_.CalculateSize(SceneChangeDataLayerNotify._repeated_unloadDataLayers_codec);
			if (this.SequencePath.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SequencePath);
			}
			if (this.MaterialDataForLoadedLayers.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MaterialDataForLoadedLayers);
			}
			if (this.MaterialDataForUnloadLayers.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MaterialDataForUnloadLayers);
			}
			if (this.EntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityId);
			}
			if (this.SeqMarkBeforeModifyMat.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SeqMarkBeforeModifyMat);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017F54 RID: 98132 RVA: 0x0037C864 File Offset: 0x0037AA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneChangeDataLayerNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.loadDataLayers_.Add(other.loadDataLayers_);
			this.unloadDataLayers_.Add(other.unloadDataLayers_);
			if (other.SequencePath.Length != 0)
			{
				this.SequencePath = other.SequencePath;
			}
			if (other.MaterialDataForLoadedLayers.Length != 0)
			{
				this.MaterialDataForLoadedLayers = other.MaterialDataForLoadedLayers;
			}
			if (other.MaterialDataForUnloadLayers.Length != 0)
			{
				this.MaterialDataForUnloadLayers = other.MaterialDataForUnloadLayers;
			}
			if (other.EntityId != 0)
			{
				this.EntityId = other.EntityId;
			}
			if (other.SeqMarkBeforeModifyMat.Length != 0)
			{
				this.SeqMarkBeforeModifyMat = other.SeqMarkBeforeModifyMat;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017F55 RID: 98133 RVA: 0x0037C926 File Offset: 0x0037AB26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017F56 RID: 98134 RVA: 0x0037C930 File Offset: 0x0037AB30
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
				if (num <= 42U)
				{
					if (num <= 18U)
					{
						if (num == 10U)
						{
							this.SequencePath = input.ReadString();
							continue;
						}
						if (num == 18U)
						{
							this.MaterialDataForUnloadLayers = input.ReadString();
							continue;
						}
					}
					else if (num == 40U || num == 42U)
					{
						this.unloadDataLayers_.AddEntriesFrom(ref input, SceneChangeDataLayerNotify._repeated_unloadDataLayers_codec);
						continue;
					}
				}
				else if (num <= 64U)
				{
					if (num == 58U)
					{
						this.MaterialDataForLoadedLayers = input.ReadString();
						continue;
					}
					if (num == 64U)
					{
						this.EntityId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						this.SeqMarkBeforeModifyMat = input.ReadString();
						continue;
					}
					if (num == 120U || num == 122U)
					{
						this.loadDataLayers_.AddEntriesFrom(ref input, SceneChangeDataLayerNotify._repeated_loadDataLayers_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008EAB RID: 36523
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008EAC RID: 36524
		public const int LoadDataLayersFieldNumber = 15;

		// Token: 0x04008EAD RID: 36525
		private static readonly FieldCodec<int> _repeated_loadDataLayers_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04008EAE RID: 36526
		private readonly RepeatedField<int> loadDataLayers_ = new RepeatedField<int>();

		// Token: 0x04008EAF RID: 36527
		public const int UnloadDataLayersFieldNumber = 5;

		// Token: 0x04008EB0 RID: 36528
		private static readonly FieldCodec<int> _repeated_unloadDataLayers_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04008EB1 RID: 36529
		private readonly RepeatedField<int> unloadDataLayers_ = new RepeatedField<int>();

		// Token: 0x04008EB2 RID: 36530
		public const int SequencePathFieldNumber = 1;

		// Token: 0x04008EB3 RID: 36531
		private string sequencePath_ = "";

		// Token: 0x04008EB4 RID: 36532
		public const int MaterialDataForLoadedLayersFieldNumber = 7;

		// Token: 0x04008EB5 RID: 36533
		private string materialDataForLoadedLayers_ = "";

		// Token: 0x04008EB6 RID: 36534
		public const int MaterialDataForUnloadLayersFieldNumber = 2;

		// Token: 0x04008EB7 RID: 36535
		private string materialDataForUnloadLayers_ = "";

		// Token: 0x04008EB8 RID: 36536
		public const int EntityIdFieldNumber = 8;

		// Token: 0x04008EB9 RID: 36537
		private int entityId_;

		// Token: 0x04008EBA RID: 36538
		public const int SeqMarkBeforeModifyMatFieldNumber = 10;

		// Token: 0x04008EBB RID: 36539
		private string seqMarkBeforeModifyMat_ = "";
	}
}
