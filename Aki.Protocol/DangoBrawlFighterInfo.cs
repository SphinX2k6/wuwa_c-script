using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000360 RID: 864
	public sealed class DangoBrawlFighterInfo : IMessage<DangoBrawlFighterInfo>, IMessage, IEquatable<DangoBrawlFighterInfo>, IDeepCloneable<DangoBrawlFighterInfo>, IBufferMessage
	{
		// Token: 0x06005674 RID: 22132 RVA: 0x000D372E File Offset: 0x000D192E
		[NullableContext(1)]
		public static DangoBrawlFighterInfo Create()
		{
			return new DangoBrawlFighterInfo();
		}

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x06005675 RID: 22133 RVA: 0x000D3735 File Offset: 0x000D1935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoBrawlFighterInfo> Parser
		{
			get
			{
				return DangoBrawlFighterInfo._parser;
			}
		}

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x06005676 RID: 22134 RVA: 0x000D373C File Offset: 0x000D193C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x06005677 RID: 22135 RVA: 0x000D373F File Offset: 0x000D193F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFighterInfo.Descriptor;
			}
		}

		// Token: 0x06005678 RID: 22136 RVA: 0x000D3746 File Offset: 0x000D1946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFighterInfo()
		{
		}

		// Token: 0x06005679 RID: 22137 RVA: 0x000D375C File Offset: 0x000D195C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFighterInfo(DangoBrawlFighterInfo other) : this()
		{
			this.fighterUId_ = other.fighterUId_;
			this.camp_ = other.camp_;
			this.roleConfigId_ = other.roleConfigId_;
			this.initFinalAttrs_ = other.initFinalAttrs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600567A RID: 22138 RVA: 0x000D37B5 File Offset: 0x000D19B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFighterInfo Clone()
		{
			return new DangoBrawlFighterInfo(this);
		}

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x0600567B RID: 22139 RVA: 0x000D37BD File Offset: 0x000D19BD
		// (set) Token: 0x0600567C RID: 22140 RVA: 0x000D37C5 File Offset: 0x000D19C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FighterUId
		{
			get
			{
				return this.fighterUId_;
			}
			set
			{
				this.fighterUId_ = value;
			}
		}

		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x0600567D RID: 22141 RVA: 0x000D37CE File Offset: 0x000D19CE
		// (set) Token: 0x0600567E RID: 22142 RVA: 0x000D37D6 File Offset: 0x000D19D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightCamp Camp
		{
			get
			{
				return this.camp_;
			}
			set
			{
				this.camp_ = value;
			}
		}

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x0600567F RID: 22143 RVA: 0x000D37DF File Offset: 0x000D19DF
		// (set) Token: 0x06005680 RID: 22144 RVA: 0x000D37E7 File Offset: 0x000D19E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleConfigId
		{
			get
			{
				return this.roleConfigId_;
			}
			set
			{
				this.roleConfigId_ = value;
			}
		}

		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x06005681 RID: 22145 RVA: 0x000D37F0 File Offset: 0x000D19F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> InitFinalAttrs
		{
			get
			{
				return this.initFinalAttrs_;
			}
		}

		// Token: 0x06005682 RID: 22146 RVA: 0x000D37F8 File Offset: 0x000D19F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFighterInfo);
		}

		// Token: 0x06005683 RID: 22147 RVA: 0x000D3808 File Offset: 0x000D1A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFighterInfo other)
		{
			return other != null && (other == this || (this.FighterUId == other.FighterUId && this.Camp == other.Camp && this.RoleConfigId == other.RoleConfigId && this.InitFinalAttrs.Equals(other.InitFinalAttrs) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005684 RID: 22148 RVA: 0x000D3878 File Offset: 0x000D1A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FighterUId != 0)
			{
				num ^= this.FighterUId.GetHashCode();
			}
			if (this.Camp != DangoBrawlFightCamp.Player)
			{
				num ^= this.Camp.GetHashCode();
			}
			if (this.RoleConfigId != 0)
			{
				num ^= this.RoleConfigId.GetHashCode();
			}
			num ^= this.InitFinalAttrs.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005685 RID: 22149 RVA: 0x000D38FD File Offset: 0x000D1AFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005686 RID: 22150 RVA: 0x000D390A File Offset: 0x000D1B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005687 RID: 22151 RVA: 0x000D3914 File Offset: 0x000D1B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FighterUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FighterUId);
			}
			if (this.Camp != DangoBrawlFightCamp.Player)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Camp);
			}
			if (this.RoleConfigId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RoleConfigId);
			}
			this.initFinalAttrs_.WriteTo(ref output, DangoBrawlFighterInfo._map_initFinalAttrs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005688 RID: 22152 RVA: 0x000D399C File Offset: 0x000D1B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FighterUId);
			}
			if (this.Camp != DangoBrawlFightCamp.Player)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Camp);
			}
			if (this.RoleConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleConfigId);
			}
			num += this.initFinalAttrs_.CalculateSize(DangoBrawlFighterInfo._map_initFinalAttrs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005689 RID: 22153 RVA: 0x000D3A20 File Offset: 0x000D1C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlFighterInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FighterUId != 0)
			{
				this.FighterUId = other.FighterUId;
			}
			if (other.Camp != DangoBrawlFightCamp.Player)
			{
				this.Camp = other.Camp;
			}
			if (other.RoleConfigId != 0)
			{
				this.RoleConfigId = other.RoleConfigId;
			}
			this.initFinalAttrs_.MergeFrom(other.initFinalAttrs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600568A RID: 22154 RVA: 0x000D3A95 File Offset: 0x000D1C95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600568B RID: 22155 RVA: 0x000D3AA0 File Offset: 0x000D1CA0
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.FighterUId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Camp = (DangoBrawlFightCamp)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.RoleConfigId = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						this.initFinalAttrs_.AddEntriesFrom(ref input, DangoBrawlFighterInfo._map_initFinalAttrs_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040034CB RID: 13515
		private static readonly MessageParser<DangoBrawlFighterInfo> _parser = new MessageParser<DangoBrawlFighterInfo>(() => new DangoBrawlFighterInfo());

		// Token: 0x040034CC RID: 13516
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034CD RID: 13517
		public const int FighterUIdFieldNumber = 1;

		// Token: 0x040034CE RID: 13518
		private int fighterUId_;

		// Token: 0x040034CF RID: 13519
		public const int CampFieldNumber = 2;

		// Token: 0x040034D0 RID: 13520
		private DangoBrawlFightCamp camp_;

		// Token: 0x040034D1 RID: 13521
		public const int RoleConfigIdFieldNumber = 3;

		// Token: 0x040034D2 RID: 13522
		private int roleConfigId_;

		// Token: 0x040034D3 RID: 13523
		public const int InitFinalAttrsFieldNumber = 4;

		// Token: 0x040034D4 RID: 13524
		private static readonly MapField<int, int>.Codec _map_initFinalAttrs_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 34U);

		// Token: 0x040034D5 RID: 13525
		private readonly MapField<int, int> initFinalAttrs_ = new MapField<int, int>();
	}
}
