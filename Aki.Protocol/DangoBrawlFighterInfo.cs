using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000358 RID: 856
	public sealed class DangoBrawlFighterInfo : IMessage<DangoBrawlFighterInfo>, IMessage, IEquatable<DangoBrawlFighterInfo>, IDeepCloneable<DangoBrawlFighterInfo>, IBufferMessage
	{
		// Token: 0x06005587 RID: 21895 RVA: 0x000D10A2 File Offset: 0x000CF2A2
		[NullableContext(1)]
		public static DangoBrawlFighterInfo Create()
		{
			return new DangoBrawlFighterInfo();
		}

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06005588 RID: 21896 RVA: 0x000D10A9 File Offset: 0x000CF2A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoBrawlFighterInfo> Parser
		{
			get
			{
				return DangoBrawlFighterInfo._parser;
			}
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06005589 RID: 21897 RVA: 0x000D10B0 File Offset: 0x000CF2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x0600558A RID: 21898 RVA: 0x000D10B3 File Offset: 0x000CF2B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFighterInfo.Descriptor;
			}
		}

		// Token: 0x0600558B RID: 21899 RVA: 0x000D10BA File Offset: 0x000CF2BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFighterInfo()
		{
		}

		// Token: 0x0600558C RID: 21900 RVA: 0x000D10D0 File Offset: 0x000CF2D0
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

		// Token: 0x0600558D RID: 21901 RVA: 0x000D1129 File Offset: 0x000CF329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFighterInfo Clone()
		{
			return new DangoBrawlFighterInfo(this);
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x0600558E RID: 21902 RVA: 0x000D1131 File Offset: 0x000CF331
		// (set) Token: 0x0600558F RID: 21903 RVA: 0x000D1139 File Offset: 0x000CF339
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

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x06005590 RID: 21904 RVA: 0x000D1142 File Offset: 0x000CF342
		// (set) Token: 0x06005591 RID: 21905 RVA: 0x000D114A File Offset: 0x000CF34A
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

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x06005592 RID: 21906 RVA: 0x000D1153 File Offset: 0x000CF353
		// (set) Token: 0x06005593 RID: 21907 RVA: 0x000D115B File Offset: 0x000CF35B
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

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x06005594 RID: 21908 RVA: 0x000D1164 File Offset: 0x000CF364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> InitFinalAttrs
		{
			get
			{
				return this.initFinalAttrs_;
			}
		}

		// Token: 0x06005595 RID: 21909 RVA: 0x000D116C File Offset: 0x000CF36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFighterInfo);
		}

		// Token: 0x06005596 RID: 21910 RVA: 0x000D117C File Offset: 0x000CF37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFighterInfo other)
		{
			return other != null && (other == this || (this.FighterUId == other.FighterUId && this.Camp == other.Camp && this.RoleConfigId == other.RoleConfigId && this.InitFinalAttrs.Equals(other.InitFinalAttrs) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005597 RID: 21911 RVA: 0x000D11EC File Offset: 0x000CF3EC
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

		// Token: 0x06005598 RID: 21912 RVA: 0x000D1271 File Offset: 0x000CF471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005599 RID: 21913 RVA: 0x000D127E File Offset: 0x000CF47E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600559A RID: 21914 RVA: 0x000D1288 File Offset: 0x000CF488
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

		// Token: 0x0600559B RID: 21915 RVA: 0x000D1310 File Offset: 0x000CF510
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

		// Token: 0x0600559C RID: 21916 RVA: 0x000D1394 File Offset: 0x000CF594
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

		// Token: 0x0600559D RID: 21917 RVA: 0x000D1409 File Offset: 0x000CF609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600559E RID: 21918 RVA: 0x000D1414 File Offset: 0x000CF614
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

		// Token: 0x0400342F RID: 13359
		private static readonly MessageParser<DangoBrawlFighterInfo> _parser = new MessageParser<DangoBrawlFighterInfo>(() => new DangoBrawlFighterInfo());

		// Token: 0x04003430 RID: 13360
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003431 RID: 13361
		public const int FighterUIdFieldNumber = 1;

		// Token: 0x04003432 RID: 13362
		private int fighterUId_;

		// Token: 0x04003433 RID: 13363
		public const int CampFieldNumber = 2;

		// Token: 0x04003434 RID: 13364
		private DangoBrawlFightCamp camp_;

		// Token: 0x04003435 RID: 13365
		public const int RoleConfigIdFieldNumber = 3;

		// Token: 0x04003436 RID: 13366
		private int roleConfigId_;

		// Token: 0x04003437 RID: 13367
		public const int InitFinalAttrsFieldNumber = 4;

		// Token: 0x04003438 RID: 13368
		private static readonly MapField<int, int>.Codec _map_initFinalAttrs_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 34U);

		// Token: 0x04003439 RID: 13369
		private readonly MapField<int, int> initFinalAttrs_ = new MapField<int, int>();
	}
}
