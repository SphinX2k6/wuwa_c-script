using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200114B RID: 4427
	[NetMessage(EMessageId.SceneChangeDataLayerNotify)]
	public sealed class SceneChangeDataLayerNotify : IMessage<SceneChangeDataLayerNotify>, IMessage, IEquatable<SceneChangeDataLayerNotify>, IDeepCloneable<SceneChangeDataLayerNotify>, IBufferMessage
	{
		// Token: 0x0601799A RID: 96666 RVA: 0x0036D031 File Offset: 0x0036B231
		[NullableContext(1)]
		public static SceneChangeDataLayerNotify Create()
		{
			return new SceneChangeDataLayerNotify();
		}

		// Token: 0x17004F31 RID: 20273
		// (get) Token: 0x0601799B RID: 96667 RVA: 0x0036D038 File Offset: 0x0036B238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F32 RID: 20274
		// (get) Token: 0x0601799C RID: 96668 RVA: 0x0036D03B File Offset: 0x0036B23B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneChangeDataLayerNotify.Descriptor;
			}
		}

		// Token: 0x0601799D RID: 96669 RVA: 0x0036D044 File Offset: 0x0036B244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneChangeDataLayerNotify()
		{
		}

		// Token: 0x0601799E RID: 96670 RVA: 0x0036D09C File Offset: 0x0036B29C
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

		// Token: 0x0601799F RID: 96671 RVA: 0x0036D11E File Offset: 0x0036B31E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneChangeDataLayerNotify Clone()
		{
			return new SceneChangeDataLayerNotify(this);
		}

		// Token: 0x17004F33 RID: 20275
		// (get) Token: 0x060179A0 RID: 96672 RVA: 0x0036D126 File Offset: 0x0036B326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LoadDataLayers
		{
			get
			{
				return this.loadDataLayers_;
			}
		}

		// Token: 0x17004F34 RID: 20276
		// (get) Token: 0x060179A1 RID: 96673 RVA: 0x0036D12E File Offset: 0x0036B32E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnloadDataLayers
		{
			get
			{
				return this.unloadDataLayers_;
			}
		}

		// Token: 0x17004F35 RID: 20277
		// (get) Token: 0x060179A2 RID: 96674 RVA: 0x0036D136 File Offset: 0x0036B336
		// (set) Token: 0x060179A3 RID: 96675 RVA: 0x0036D13E File Offset: 0x0036B33E
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

		// Token: 0x17004F36 RID: 20278
		// (get) Token: 0x060179A4 RID: 96676 RVA: 0x0036D151 File Offset: 0x0036B351
		// (set) Token: 0x060179A5 RID: 96677 RVA: 0x0036D159 File Offset: 0x0036B359
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

		// Token: 0x17004F37 RID: 20279
		// (get) Token: 0x060179A6 RID: 96678 RVA: 0x0036D16C File Offset: 0x0036B36C
		// (set) Token: 0x060179A7 RID: 96679 RVA: 0x0036D174 File Offset: 0x0036B374
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

		// Token: 0x17004F38 RID: 20280
		// (get) Token: 0x060179A8 RID: 96680 RVA: 0x0036D187 File Offset: 0x0036B387
		// (set) Token: 0x060179A9 RID: 96681 RVA: 0x0036D18F File Offset: 0x0036B38F
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

		// Token: 0x17004F39 RID: 20281
		// (get) Token: 0x060179AA RID: 96682 RVA: 0x0036D198 File Offset: 0x0036B398
		// (set) Token: 0x060179AB RID: 96683 RVA: 0x0036D1A0 File Offset: 0x0036B3A0
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

		// Token: 0x060179AC RID: 96684 RVA: 0x0036D1B3 File Offset: 0x0036B3B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneChangeDataLayerNotify);
		}

		// Token: 0x060179AD RID: 96685 RVA: 0x0036D1C4 File Offset: 0x0036B3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneChangeDataLayerNotify other)
		{
			return other != null && (other == this || (this.loadDataLayers_.Equals(other.loadDataLayers_) && this.unloadDataLayers_.Equals(other.unloadDataLayers_) && !(this.SequencePath != other.SequencePath) && !(this.MaterialDataForLoadedLayers != other.MaterialDataForLoadedLayers) && !(this.MaterialDataForUnloadLayers != other.MaterialDataForUnloadLayers) && this.EntityId == other.EntityId && !(this.SeqMarkBeforeModifyMat != other.SeqMarkBeforeModifyMat) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060179AE RID: 96686 RVA: 0x0036D27C File Offset: 0x0036B47C
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

		// Token: 0x060179AF RID: 96687 RVA: 0x0036D343 File Offset: 0x0036B543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060179B0 RID: 96688 RVA: 0x0036D350 File Offset: 0x0036B550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060179B1 RID: 96689 RVA: 0x0036D35C File Offset: 0x0036B55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SeqMarkBeforeModifyMat.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.SeqMarkBeforeModifyMat);
			}
			if (this.EntityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.EntityId);
			}
			if (this.MaterialDataForLoadedLayers.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.MaterialDataForLoadedLayers);
			}
			if (this.SequencePath.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.SequencePath);
			}
			if (this.MaterialDataForUnloadLayers.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.MaterialDataForUnloadLayers);
			}
			this.unloadDataLayers_.WriteTo(ref output, SceneChangeDataLayerNotify._repeated_unloadDataLayers_codec);
			this.loadDataLayers_.WriteTo(ref output, SceneChangeDataLayerNotify._repeated_loadDataLayers_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060179B2 RID: 96690 RVA: 0x0036D440 File Offset: 0x0036B640
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

		// Token: 0x060179B3 RID: 96691 RVA: 0x0036D518 File Offset: 0x0036B718
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

		// Token: 0x060179B4 RID: 96692 RVA: 0x0036D5DA File Offset: 0x0036B7DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060179B5 RID: 96693 RVA: 0x0036D5E4 File Offset: 0x0036B7E4
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
				if (num > 58U)
				{
					if (num <= 88U)
					{
						if (num == 82U)
						{
							this.MaterialDataForUnloadLayers = input.ReadString();
							continue;
						}
						if (num != 88U)
						{
							goto IL_4E;
						}
					}
					else if (num != 90U)
					{
						if (num != 112U && num != 114U)
						{
							goto IL_4E;
						}
						this.loadDataLayers_.AddEntriesFrom(ref input, SceneChangeDataLayerNotify._repeated_loadDataLayers_codec);
						continue;
					}
					this.unloadDataLayers_.AddEntriesFrom(ref input, SceneChangeDataLayerNotify._repeated_unloadDataLayers_codec);
					continue;
				}
				if (num <= 40U)
				{
					if (num == 26U)
					{
						this.SeqMarkBeforeModifyMat = input.ReadString();
						continue;
					}
					if (num == 40U)
					{
						this.EntityId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.MaterialDataForLoadedLayers = input.ReadString();
						continue;
					}
					if (num == 58U)
					{
						this.SequencePath = input.ReadString();
						continue;
					}
				}
				IL_4E:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008C18 RID: 35864
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C19 RID: 35865
		public const int LoadDataLayersFieldNumber = 14;

		// Token: 0x04008C1A RID: 35866
		private static readonly FieldCodec<int> _repeated_loadDataLayers_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04008C1B RID: 35867
		private readonly RepeatedField<int> loadDataLayers_ = new RepeatedField<int>();

		// Token: 0x04008C1C RID: 35868
		public const int UnloadDataLayersFieldNumber = 11;

		// Token: 0x04008C1D RID: 35869
		private static readonly FieldCodec<int> _repeated_unloadDataLayers_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04008C1E RID: 35870
		private readonly RepeatedField<int> unloadDataLayers_ = new RepeatedField<int>();

		// Token: 0x04008C1F RID: 35871
		public const int SequencePathFieldNumber = 7;

		// Token: 0x04008C20 RID: 35872
		private string sequencePath_ = "";

		// Token: 0x04008C21 RID: 35873
		public const int MaterialDataForLoadedLayersFieldNumber = 6;

		// Token: 0x04008C22 RID: 35874
		private string materialDataForLoadedLayers_ = "";

		// Token: 0x04008C23 RID: 35875
		public const int MaterialDataForUnloadLayersFieldNumber = 10;

		// Token: 0x04008C24 RID: 35876
		private string materialDataForUnloadLayers_ = "";

		// Token: 0x04008C25 RID: 35877
		public const int EntityIdFieldNumber = 5;

		// Token: 0x04008C26 RID: 35878
		private int entityId_;

		// Token: 0x04008C27 RID: 35879
		public const int SeqMarkBeforeModifyMatFieldNumber = 3;

		// Token: 0x04008C28 RID: 35880
		private string seqMarkBeforeModifyMat_ = "";
	}
}
