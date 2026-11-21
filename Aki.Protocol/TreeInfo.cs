using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014D8 RID: 5336
	public sealed class TreeInfo : IMessage<TreeInfo>, IMessage, IEquatable<TreeInfo>, IDeepCloneable<TreeInfo>, IBufferMessage
	{
		// Token: 0x0601C4CE RID: 115918 RVA: 0x0041B399 File Offset: 0x00419599
		[NullableContext(1)]
		public static TreeInfo Create()
		{
			return new TreeInfo();
		}

		// Token: 0x17005FC7 RID: 24519
		// (get) Token: 0x0601C4CF RID: 115919 RVA: 0x0041B3A0 File Offset: 0x004195A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TreeInfo> Parser
		{
			get
			{
				return TreeInfo._parser;
			}
		}

		// Token: 0x17005FC8 RID: 24520
		// (get) Token: 0x0601C4D0 RID: 115920 RVA: 0x0041B3A7 File Offset: 0x004195A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FC9 RID: 24521
		// (get) Token: 0x0601C4D1 RID: 115921 RVA: 0x0041B3AA File Offset: 0x004195AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TreeInfo.Descriptor;
			}
		}

		// Token: 0x0601C4D2 RID: 115922 RVA: 0x0041B3B4 File Offset: 0x004195B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreeInfo()
		{
		}

		// Token: 0x0601C4D3 RID: 115923 RVA: 0x0041B40C File Offset: 0x0041960C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreeInfo(TreeInfo other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.btType_ = other.btType_;
			this.blackboardId_ = other.blackboardId_;
			this.nodes_ = other.nodes_.Clone();
			this.vars_ = other.vars_.Clone();
			this.timerInfos_ = other.timerInfos_.Clone();
			this.suspendType_ = other.suspendType_;
			this.occupationInfo_ = other.occupationInfo_.Clone();
			this.audioStates_ = other.audioStates_.Clone();
			this.isScreenOccupy_ = other.isScreenOccupy_;
			this.characterLookAtInfos_ = other.characterLookAtInfos_.Clone();
			this.suspendNodeId_ = other.suspendNodeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C4D4 RID: 115924 RVA: 0x0041B4EA File Offset: 0x004196EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreeInfo Clone()
		{
			return new TreeInfo(this);
		}

		// Token: 0x17005FCA RID: 24522
		// (get) Token: 0x0601C4D5 RID: 115925 RVA: 0x0041B4F2 File Offset: 0x004196F2
		// (set) Token: 0x0601C4D6 RID: 115926 RVA: 0x0041B4FA File Offset: 0x004196FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeOwnerId
		{
			get
			{
				return this.treeOwnerId_;
			}
			set
			{
				this.treeOwnerId_ = value;
			}
		}

		// Token: 0x17005FCB RID: 24523
		// (get) Token: 0x0601C4D7 RID: 115927 RVA: 0x0041B503 File Offset: 0x00419703
		// (set) Token: 0x0601C4D8 RID: 115928 RVA: 0x0041B50B File Offset: 0x0041970B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TreeIncId
		{
			get
			{
				return this.treeIncId_;
			}
			set
			{
				this.treeIncId_ = value;
			}
		}

		// Token: 0x17005FCC RID: 24524
		// (get) Token: 0x0601C4D9 RID: 115929 RVA: 0x0041B514 File Offset: 0x00419714
		// (set) Token: 0x0601C4DA RID: 115930 RVA: 0x0041B51C File Offset: 0x0041971C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtType BtType
		{
			get
			{
				return this.btType_;
			}
			set
			{
				this.btType_ = value;
			}
		}

		// Token: 0x17005FCD RID: 24525
		// (get) Token: 0x0601C4DB RID: 115931 RVA: 0x0041B525 File Offset: 0x00419725
		// (set) Token: 0x0601C4DC RID: 115932 RVA: 0x0041B52D File Offset: 0x0041972D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BlackboardId
		{
			get
			{
				return this.blackboardId_;
			}
			set
			{
				this.blackboardId_ = value;
			}
		}

		// Token: 0x17005FCE RID: 24526
		// (get) Token: 0x0601C4DD RID: 115933 RVA: 0x0041B536 File Offset: 0x00419736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, NodeInfo> Nodes
		{
			get
			{
				return this.nodes_;
			}
		}

		// Token: 0x17005FCF RID: 24527
		// (get) Token: 0x0601C4DE RID: 115934 RVA: 0x0041B53E File Offset: 0x0041973E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, VarDefinePb> Vars
		{
			get
			{
				return this.vars_;
			}
		}

		// Token: 0x17005FD0 RID: 24528
		// (get) Token: 0x0601C4DF RID: 115935 RVA: 0x0041B546 File Offset: 0x00419746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TimerInfoPb> TimerInfos
		{
			get
			{
				return this.timerInfos_;
			}
		}

		// Token: 0x17005FD1 RID: 24529
		// (get) Token: 0x0601C4E0 RID: 115936 RVA: 0x0041B54E File Offset: 0x0041974E
		// (set) Token: 0x0601C4E1 RID: 115937 RVA: 0x0041B556 File Offset: 0x00419756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SuspendType
		{
			get
			{
				return this.suspendType_;
			}
			set
			{
				this.suspendType_ = value;
			}
		}

		// Token: 0x17005FD2 RID: 24530
		// (get) Token: 0x0601C4E2 RID: 115938 RVA: 0x0041B55F File Offset: 0x0041975F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OccupationPbInfo> OccupationInfo
		{
			get
			{
				return this.occupationInfo_;
			}
		}

		// Token: 0x17005FD3 RID: 24531
		// (get) Token: 0x0601C4E3 RID: 115939 RVA: 0x0041B567 File Offset: 0x00419767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, string> AudioStates
		{
			get
			{
				return this.audioStates_;
			}
		}

		// Token: 0x17005FD4 RID: 24532
		// (get) Token: 0x0601C4E4 RID: 115940 RVA: 0x0041B56F File Offset: 0x0041976F
		// (set) Token: 0x0601C4E5 RID: 115941 RVA: 0x0041B577 File Offset: 0x00419777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsScreenOccupy
		{
			get
			{
				return this.isScreenOccupy_;
			}
			set
			{
				this.isScreenOccupy_ = value;
			}
		}

		// Token: 0x17005FD5 RID: 24533
		// (get) Token: 0x0601C4E6 RID: 115942 RVA: 0x0041B580 File Offset: 0x00419780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CharacterLookAtInfo> CharacterLookAtInfos
		{
			get
			{
				return this.characterLookAtInfos_;
			}
		}

		// Token: 0x17005FD6 RID: 24534
		// (get) Token: 0x0601C4E7 RID: 115943 RVA: 0x0041B588 File Offset: 0x00419788
		// (set) Token: 0x0601C4E8 RID: 115944 RVA: 0x0041B590 File Offset: 0x00419790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SuspendNodeId
		{
			get
			{
				return this.suspendNodeId_;
			}
			set
			{
				this.suspendNodeId_ = value;
			}
		}

		// Token: 0x0601C4E9 RID: 115945 RVA: 0x0041B599 File Offset: 0x00419799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TreeInfo);
		}

		// Token: 0x0601C4EA RID: 115946 RVA: 0x0041B5A8 File Offset: 0x004197A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TreeInfo other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.BtType == other.BtType && this.BlackboardId == other.BlackboardId && this.Nodes.Equals(other.Nodes) && this.Vars.Equals(other.Vars) && this.timerInfos_.Equals(other.timerInfos_) && this.SuspendType == other.SuspendType && this.occupationInfo_.Equals(other.occupationInfo_) && this.AudioStates.Equals(other.AudioStates) && this.IsScreenOccupy == other.IsScreenOccupy && this.characterLookAtInfos_.Equals(other.characterLookAtInfos_) && this.SuspendNodeId == other.SuspendNodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C4EB RID: 115947 RVA: 0x0041B6C0 File Offset: 0x004198C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeOwnerId != 0)
			{
				num ^= this.TreeOwnerId.GetHashCode();
			}
			if (this.TreeIncId != 0L)
			{
				num ^= this.TreeIncId.GetHashCode();
			}
			if (this.BtType != BtType.Invalid)
			{
				num ^= this.BtType.GetHashCode();
			}
			if (this.BlackboardId != 0)
			{
				num ^= this.BlackboardId.GetHashCode();
			}
			num ^= this.Nodes.GetHashCode();
			num ^= this.Vars.GetHashCode();
			num ^= this.timerInfos_.GetHashCode();
			if (this.SuspendType != 0)
			{
				num ^= this.SuspendType.GetHashCode();
			}
			num ^= this.occupationInfo_.GetHashCode();
			num ^= this.AudioStates.GetHashCode();
			if (this.IsScreenOccupy)
			{
				num ^= this.IsScreenOccupy.GetHashCode();
			}
			num ^= this.characterLookAtInfos_.GetHashCode();
			if (this.SuspendNodeId != 0)
			{
				num ^= this.SuspendNodeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C4EC RID: 115948 RVA: 0x0041B7F0 File Offset: 0x004199F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C4ED RID: 115949 RVA: 0x0041B7FD File Offset: 0x004199FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C4EE RID: 115950 RVA: 0x0041B808 File Offset: 0x00419A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.BtType != BtType.Invalid)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.BtType);
			}
			if (this.BlackboardId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BlackboardId);
			}
			this.nodes_.WriteTo(ref output, TreeInfo._map_nodes_codec);
			this.vars_.WriteTo(ref output, TreeInfo._map_vars_codec);
			this.timerInfos_.WriteTo(ref output, TreeInfo._repeated_timerInfos_codec);
			if (this.SuspendType != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SuspendType);
			}
			this.occupationInfo_.WriteTo(ref output, TreeInfo._repeated_occupationInfo_codec);
			this.audioStates_.WriteTo(ref output, TreeInfo._map_audioStates_codec);
			if (this.IsScreenOccupy)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsScreenOccupy);
			}
			this.characterLookAtInfos_.WriteTo(ref output, TreeInfo._repeated_characterLookAtInfos_codec);
			if (this.SuspendNodeId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SuspendNodeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C4EF RID: 115951 RVA: 0x0041B954 File Offset: 0x00419B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeOwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TreeIncId);
			}
			if (this.BtType != BtType.Invalid)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.BtType);
			}
			if (this.BlackboardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BlackboardId);
			}
			num += this.nodes_.CalculateSize(TreeInfo._map_nodes_codec);
			num += this.vars_.CalculateSize(TreeInfo._map_vars_codec);
			num += this.timerInfos_.CalculateSize(TreeInfo._repeated_timerInfos_codec);
			if (this.SuspendType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SuspendType);
			}
			num += this.occupationInfo_.CalculateSize(TreeInfo._repeated_occupationInfo_codec);
			num += this.audioStates_.CalculateSize(TreeInfo._map_audioStates_codec);
			if (this.IsScreenOccupy)
			{
				num += 2;
			}
			num += this.characterLookAtInfos_.CalculateSize(TreeInfo._repeated_characterLookAtInfos_codec);
			if (this.SuspendNodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SuspendNodeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C4F0 RID: 115952 RVA: 0x0041BA88 File Offset: 0x00419C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TreeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeOwnerId != 0)
			{
				this.TreeOwnerId = other.TreeOwnerId;
			}
			if (other.TreeIncId != 0L)
			{
				this.TreeIncId = other.TreeIncId;
			}
			if (other.BtType != BtType.Invalid)
			{
				this.BtType = other.BtType;
			}
			if (other.BlackboardId != 0)
			{
				this.BlackboardId = other.BlackboardId;
			}
			this.nodes_.MergeFrom(other.nodes_);
			this.vars_.MergeFrom(other.vars_);
			this.timerInfos_.Add(other.timerInfos_);
			if (other.SuspendType != 0)
			{
				this.SuspendType = other.SuspendType;
			}
			this.occupationInfo_.Add(other.occupationInfo_);
			this.audioStates_.MergeFrom(other.audioStates_);
			if (other.IsScreenOccupy)
			{
				this.IsScreenOccupy = other.IsScreenOccupy;
			}
			this.characterLookAtInfos_.Add(other.characterLookAtInfos_);
			if (other.SuspendNodeId != 0)
			{
				this.SuspendNodeId = other.SuspendNodeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C4F1 RID: 115953 RVA: 0x0041BBA2 File Offset: 0x00419DA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C4F2 RID: 115954 RVA: 0x0041BBAC File Offset: 0x00419DAC
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
				if (num <= 50U)
				{
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.TreeOwnerId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.TreeIncId = input.ReadInt64();
							continue;
						}
						if (num == 24U)
						{
							this.BtType = (BtType)input.ReadEnum();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.BlackboardId = input.ReadInt32();
							continue;
						}
						if (num == 42U)
						{
							this.nodes_.AddEntriesFrom(ref input, TreeInfo._map_nodes_codec);
							continue;
						}
						if (num == 50U)
						{
							this.vars_.AddEntriesFrom(ref input, TreeInfo._map_vars_codec);
							continue;
						}
					}
				}
				else if (num <= 74U)
				{
					if (num == 58U)
					{
						this.timerInfos_.AddEntriesFrom(ref input, TreeInfo._repeated_timerInfos_codec);
						continue;
					}
					if (num == 64U)
					{
						this.SuspendType = input.ReadInt32();
						continue;
					}
					if (num == 74U)
					{
						this.occupationInfo_.AddEntriesFrom(ref input, TreeInfo._repeated_occupationInfo_codec);
						continue;
					}
				}
				else if (num <= 88U)
				{
					if (num == 82U)
					{
						this.audioStates_.AddEntriesFrom(ref input, TreeInfo._map_audioStates_codec);
						continue;
					}
					if (num == 88U)
					{
						this.IsScreenOccupy = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						this.characterLookAtInfos_.AddEntriesFrom(ref input, TreeInfo._repeated_characterLookAtInfos_codec);
						continue;
					}
					if (num == 104U)
					{
						this.SuspendNodeId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A388 RID: 41864
		private static readonly MessageParser<TreeInfo> _parser = new MessageParser<TreeInfo>(() => new TreeInfo());

		// Token: 0x0400A389 RID: 41865
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A38A RID: 41866
		public const int TreeOwnerIdFieldNumber = 1;

		// Token: 0x0400A38B RID: 41867
		private int treeOwnerId_;

		// Token: 0x0400A38C RID: 41868
		public const int TreeIncIdFieldNumber = 2;

		// Token: 0x0400A38D RID: 41869
		private long treeIncId_;

		// Token: 0x0400A38E RID: 41870
		public const int BtTypeFieldNumber = 3;

		// Token: 0x0400A38F RID: 41871
		private BtType btType_;

		// Token: 0x0400A390 RID: 41872
		public const int BlackboardIdFieldNumber = 4;

		// Token: 0x0400A391 RID: 41873
		private int blackboardId_;

		// Token: 0x0400A392 RID: 41874
		public const int NodesFieldNumber = 5;

		// Token: 0x0400A393 RID: 41875
		private static readonly MapField<int, NodeInfo>.Codec _map_nodes_codec = new MapField<int, NodeInfo>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<NodeInfo>(18U, NodeInfo.Parser), 42U);

		// Token: 0x0400A394 RID: 41876
		private readonly MapField<int, NodeInfo> nodes_ = new MapField<int, NodeInfo>();

		// Token: 0x0400A395 RID: 41877
		public const int VarsFieldNumber = 6;

		// Token: 0x0400A396 RID: 41878
		private static readonly MapField<string, VarDefinePb>.Codec _map_vars_codec = new MapField<string, VarDefinePb>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForMessage<VarDefinePb>(18U, VarDefinePb.Parser), 50U);

		// Token: 0x0400A397 RID: 41879
		private readonly MapField<string, VarDefinePb> vars_ = new MapField<string, VarDefinePb>();

		// Token: 0x0400A398 RID: 41880
		public const int TimerInfosFieldNumber = 7;

		// Token: 0x0400A399 RID: 41881
		private static readonly FieldCodec<TimerInfoPb> _repeated_timerInfos_codec = FieldCodec.ForMessage<TimerInfoPb>(58U, TimerInfoPb.Parser);

		// Token: 0x0400A39A RID: 41882
		private readonly RepeatedField<TimerInfoPb> timerInfos_ = new RepeatedField<TimerInfoPb>();

		// Token: 0x0400A39B RID: 41883
		public const int SuspendTypeFieldNumber = 8;

		// Token: 0x0400A39C RID: 41884
		private int suspendType_;

		// Token: 0x0400A39D RID: 41885
		public const int OccupationInfoFieldNumber = 9;

		// Token: 0x0400A39E RID: 41886
		private static readonly FieldCodec<OccupationPbInfo> _repeated_occupationInfo_codec = FieldCodec.ForMessage<OccupationPbInfo>(74U, OccupationPbInfo.Parser);

		// Token: 0x0400A39F RID: 41887
		private readonly RepeatedField<OccupationPbInfo> occupationInfo_ = new RepeatedField<OccupationPbInfo>();

		// Token: 0x0400A3A0 RID: 41888
		public const int AudioStatesFieldNumber = 10;

		// Token: 0x0400A3A1 RID: 41889
		private static readonly MapField<string, string>.Codec _map_audioStates_codec = new MapField<string, string>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForString(18U, ""), 82U);

		// Token: 0x0400A3A2 RID: 41890
		private readonly MapField<string, string> audioStates_ = new MapField<string, string>();

		// Token: 0x0400A3A3 RID: 41891
		public const int IsScreenOccupyFieldNumber = 11;

		// Token: 0x0400A3A4 RID: 41892
		private bool isScreenOccupy_;

		// Token: 0x0400A3A5 RID: 41893
		public const int CharacterLookAtInfosFieldNumber = 12;

		// Token: 0x0400A3A6 RID: 41894
		private static readonly FieldCodec<CharacterLookAtInfo> _repeated_characterLookAtInfos_codec = FieldCodec.ForMessage<CharacterLookAtInfo>(98U, CharacterLookAtInfo.Parser);

		// Token: 0x0400A3A7 RID: 41895
		private readonly RepeatedField<CharacterLookAtInfo> characterLookAtInfos_ = new RepeatedField<CharacterLookAtInfo>();

		// Token: 0x0400A3A8 RID: 41896
		public const int SuspendNodeIdFieldNumber = 13;

		// Token: 0x0400A3A9 RID: 41897
		private int suspendNodeId_;
	}
}
