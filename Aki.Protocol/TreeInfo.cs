using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001465 RID: 5221
	public sealed class TreeInfo : IMessage<TreeInfo>, IMessage, IEquatable<TreeInfo>, IDeepCloneable<TreeInfo>, IBufferMessage
	{
		// Token: 0x0601BA43 RID: 113219 RVA: 0x004000C9 File Offset: 0x003FE2C9
		[NullableContext(1)]
		public static TreeInfo Create()
		{
			return new TreeInfo();
		}

		// Token: 0x17005D32 RID: 23858
		// (get) Token: 0x0601BA44 RID: 113220 RVA: 0x004000D0 File Offset: 0x003FE2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TreeInfo> Parser
		{
			get
			{
				return TreeInfo._parser;
			}
		}

		// Token: 0x17005D33 RID: 23859
		// (get) Token: 0x0601BA45 RID: 113221 RVA: 0x004000D7 File Offset: 0x003FE2D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D34 RID: 23860
		// (get) Token: 0x0601BA46 RID: 113222 RVA: 0x004000DA File Offset: 0x003FE2DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TreeInfo.Descriptor;
			}
		}

		// Token: 0x0601BA47 RID: 113223 RVA: 0x004000E4 File Offset: 0x003FE2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreeInfo()
		{
		}

		// Token: 0x0601BA48 RID: 113224 RVA: 0x0040013C File Offset: 0x003FE33C
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

		// Token: 0x0601BA49 RID: 113225 RVA: 0x0040021A File Offset: 0x003FE41A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreeInfo Clone()
		{
			return new TreeInfo(this);
		}

		// Token: 0x17005D35 RID: 23861
		// (get) Token: 0x0601BA4A RID: 113226 RVA: 0x00400222 File Offset: 0x003FE422
		// (set) Token: 0x0601BA4B RID: 113227 RVA: 0x0040022A File Offset: 0x003FE42A
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

		// Token: 0x17005D36 RID: 23862
		// (get) Token: 0x0601BA4C RID: 113228 RVA: 0x00400233 File Offset: 0x003FE433
		// (set) Token: 0x0601BA4D RID: 113229 RVA: 0x0040023B File Offset: 0x003FE43B
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

		// Token: 0x17005D37 RID: 23863
		// (get) Token: 0x0601BA4E RID: 113230 RVA: 0x00400244 File Offset: 0x003FE444
		// (set) Token: 0x0601BA4F RID: 113231 RVA: 0x0040024C File Offset: 0x003FE44C
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

		// Token: 0x17005D38 RID: 23864
		// (get) Token: 0x0601BA50 RID: 113232 RVA: 0x00400255 File Offset: 0x003FE455
		// (set) Token: 0x0601BA51 RID: 113233 RVA: 0x0040025D File Offset: 0x003FE45D
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

		// Token: 0x17005D39 RID: 23865
		// (get) Token: 0x0601BA52 RID: 113234 RVA: 0x00400266 File Offset: 0x003FE466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, NodeInfo> Nodes
		{
			get
			{
				return this.nodes_;
			}
		}

		// Token: 0x17005D3A RID: 23866
		// (get) Token: 0x0601BA53 RID: 113235 RVA: 0x0040026E File Offset: 0x003FE46E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, VarDefinePb> Vars
		{
			get
			{
				return this.vars_;
			}
		}

		// Token: 0x17005D3B RID: 23867
		// (get) Token: 0x0601BA54 RID: 113236 RVA: 0x00400276 File Offset: 0x003FE476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TimerInfoPb> TimerInfos
		{
			get
			{
				return this.timerInfos_;
			}
		}

		// Token: 0x17005D3C RID: 23868
		// (get) Token: 0x0601BA55 RID: 113237 RVA: 0x0040027E File Offset: 0x003FE47E
		// (set) Token: 0x0601BA56 RID: 113238 RVA: 0x00400286 File Offset: 0x003FE486
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

		// Token: 0x17005D3D RID: 23869
		// (get) Token: 0x0601BA57 RID: 113239 RVA: 0x0040028F File Offset: 0x003FE48F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OccupationPbInfo> OccupationInfo
		{
			get
			{
				return this.occupationInfo_;
			}
		}

		// Token: 0x17005D3E RID: 23870
		// (get) Token: 0x0601BA58 RID: 113240 RVA: 0x00400297 File Offset: 0x003FE497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, string> AudioStates
		{
			get
			{
				return this.audioStates_;
			}
		}

		// Token: 0x17005D3F RID: 23871
		// (get) Token: 0x0601BA59 RID: 113241 RVA: 0x0040029F File Offset: 0x003FE49F
		// (set) Token: 0x0601BA5A RID: 113242 RVA: 0x004002A7 File Offset: 0x003FE4A7
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

		// Token: 0x17005D40 RID: 23872
		// (get) Token: 0x0601BA5B RID: 113243 RVA: 0x004002B0 File Offset: 0x003FE4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CharacterLookAtInfo> CharacterLookAtInfos
		{
			get
			{
				return this.characterLookAtInfos_;
			}
		}

		// Token: 0x17005D41 RID: 23873
		// (get) Token: 0x0601BA5C RID: 113244 RVA: 0x004002B8 File Offset: 0x003FE4B8
		// (set) Token: 0x0601BA5D RID: 113245 RVA: 0x004002C0 File Offset: 0x003FE4C0
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

		// Token: 0x0601BA5E RID: 113246 RVA: 0x004002C9 File Offset: 0x003FE4C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TreeInfo);
		}

		// Token: 0x0601BA5F RID: 113247 RVA: 0x004002D8 File Offset: 0x003FE4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TreeInfo other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.BtType == other.BtType && this.BlackboardId == other.BlackboardId && this.Nodes.Equals(other.Nodes) && this.Vars.Equals(other.Vars) && this.timerInfos_.Equals(other.timerInfos_) && this.SuspendType == other.SuspendType && this.occupationInfo_.Equals(other.occupationInfo_) && this.AudioStates.Equals(other.AudioStates) && this.IsScreenOccupy == other.IsScreenOccupy && this.characterLookAtInfos_.Equals(other.characterLookAtInfos_) && this.SuspendNodeId == other.SuspendNodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BA60 RID: 113248 RVA: 0x004003F0 File Offset: 0x003FE5F0
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

		// Token: 0x0601BA61 RID: 113249 RVA: 0x00400520 File Offset: 0x003FE720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BA62 RID: 113250 RVA: 0x0040052D File Offset: 0x003FE72D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BA63 RID: 113251 RVA: 0x00400538 File Offset: 0x003FE738
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

		// Token: 0x0601BA64 RID: 113252 RVA: 0x00400684 File Offset: 0x003FE884
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

		// Token: 0x0601BA65 RID: 113253 RVA: 0x004007B8 File Offset: 0x003FE9B8
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

		// Token: 0x0601BA66 RID: 113254 RVA: 0x004008D2 File Offset: 0x003FEAD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BA67 RID: 113255 RVA: 0x004008DC File Offset: 0x003FEADC
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

		// Token: 0x04009F41 RID: 40769
		private static readonly MessageParser<TreeInfo> _parser = new MessageParser<TreeInfo>(() => new TreeInfo());

		// Token: 0x04009F42 RID: 40770
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F43 RID: 40771
		public const int TreeOwnerIdFieldNumber = 1;

		// Token: 0x04009F44 RID: 40772
		private int treeOwnerId_;

		// Token: 0x04009F45 RID: 40773
		public const int TreeIncIdFieldNumber = 2;

		// Token: 0x04009F46 RID: 40774
		private long treeIncId_;

		// Token: 0x04009F47 RID: 40775
		public const int BtTypeFieldNumber = 3;

		// Token: 0x04009F48 RID: 40776
		private BtType btType_;

		// Token: 0x04009F49 RID: 40777
		public const int BlackboardIdFieldNumber = 4;

		// Token: 0x04009F4A RID: 40778
		private int blackboardId_;

		// Token: 0x04009F4B RID: 40779
		public const int NodesFieldNumber = 5;

		// Token: 0x04009F4C RID: 40780
		private static readonly MapField<int, NodeInfo>.Codec _map_nodes_codec = new MapField<int, NodeInfo>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<NodeInfo>(18U, NodeInfo.Parser), 42U);

		// Token: 0x04009F4D RID: 40781
		private readonly MapField<int, NodeInfo> nodes_ = new MapField<int, NodeInfo>();

		// Token: 0x04009F4E RID: 40782
		public const int VarsFieldNumber = 6;

		// Token: 0x04009F4F RID: 40783
		private static readonly MapField<string, VarDefinePb>.Codec _map_vars_codec = new MapField<string, VarDefinePb>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForMessage<VarDefinePb>(18U, VarDefinePb.Parser), 50U);

		// Token: 0x04009F50 RID: 40784
		private readonly MapField<string, VarDefinePb> vars_ = new MapField<string, VarDefinePb>();

		// Token: 0x04009F51 RID: 40785
		public const int TimerInfosFieldNumber = 7;

		// Token: 0x04009F52 RID: 40786
		private static readonly FieldCodec<TimerInfoPb> _repeated_timerInfos_codec = FieldCodec.ForMessage<TimerInfoPb>(58U, TimerInfoPb.Parser);

		// Token: 0x04009F53 RID: 40787
		private readonly RepeatedField<TimerInfoPb> timerInfos_ = new RepeatedField<TimerInfoPb>();

		// Token: 0x04009F54 RID: 40788
		public const int SuspendTypeFieldNumber = 8;

		// Token: 0x04009F55 RID: 40789
		private int suspendType_;

		// Token: 0x04009F56 RID: 40790
		public const int OccupationInfoFieldNumber = 9;

		// Token: 0x04009F57 RID: 40791
		private static readonly FieldCodec<OccupationPbInfo> _repeated_occupationInfo_codec = FieldCodec.ForMessage<OccupationPbInfo>(74U, OccupationPbInfo.Parser);

		// Token: 0x04009F58 RID: 40792
		private readonly RepeatedField<OccupationPbInfo> occupationInfo_ = new RepeatedField<OccupationPbInfo>();

		// Token: 0x04009F59 RID: 40793
		public const int AudioStatesFieldNumber = 10;

		// Token: 0x04009F5A RID: 40794
		private static readonly MapField<string, string>.Codec _map_audioStates_codec = new MapField<string, string>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForString(18U, ""), 82U);

		// Token: 0x04009F5B RID: 40795
		private readonly MapField<string, string> audioStates_ = new MapField<string, string>();

		// Token: 0x04009F5C RID: 40796
		public const int IsScreenOccupyFieldNumber = 11;

		// Token: 0x04009F5D RID: 40797
		private bool isScreenOccupy_;

		// Token: 0x04009F5E RID: 40798
		public const int CharacterLookAtInfosFieldNumber = 12;

		// Token: 0x04009F5F RID: 40799
		private static readonly FieldCodec<CharacterLookAtInfo> _repeated_characterLookAtInfos_codec = FieldCodec.ForMessage<CharacterLookAtInfo>(98U, CharacterLookAtInfo.Parser);

		// Token: 0x04009F60 RID: 40800
		private readonly RepeatedField<CharacterLookAtInfo> characterLookAtInfos_ = new RepeatedField<CharacterLookAtInfo>();

		// Token: 0x04009F61 RID: 40801
		public const int SuspendNodeIdFieldNumber = 13;

		// Token: 0x04009F62 RID: 40802
		private int suspendNodeId_;
	}
}
