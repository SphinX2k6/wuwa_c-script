using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D9C RID: 3484
	public sealed class PlayerSceneGroupData : IMessage<PlayerSceneGroupData>, IMessage, IEquatable<PlayerSceneGroupData>, IDeepCloneable<PlayerSceneGroupData>, IBufferMessage
	{
		// Token: 0x06012CB6 RID: 76982 RVA: 0x002BE4A6 File Offset: 0x002BC6A6
		[NullableContext(1)]
		public static PlayerSceneGroupData Create()
		{
			return new PlayerSceneGroupData();
		}

		// Token: 0x17003E5B RID: 15963
		// (get) Token: 0x06012CB7 RID: 76983 RVA: 0x002BE4AD File Offset: 0x002BC6AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerSceneGroupData> Parser
		{
			get
			{
				return PlayerSceneGroupData._parser;
			}
		}

		// Token: 0x17003E5C RID: 15964
		// (get) Token: 0x06012CB8 RID: 76984 RVA: 0x002BE4B4 File Offset: 0x002BC6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E5D RID: 15965
		// (get) Token: 0x06012CB9 RID: 76985 RVA: 0x002BE4B7 File Offset: 0x002BC6B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerSceneGroupData.Descriptor;
			}
		}

		// Token: 0x06012CBA RID: 76986 RVA: 0x002BE4BE File Offset: 0x002BC6BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSceneGroupData()
		{
		}

		// Token: 0x06012CBB RID: 76987 RVA: 0x002BE4D4 File Offset: 0x002BC6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSceneGroupData(PlayerSceneGroupData other) : this()
		{
			this.group_ = other.group_;
			this.fightRoleInfos_ = other.fightRoleInfos_.Clone();
			this.curRole_ = other.curRole_;
			this.livingStatus_ = other.livingStatus_;
			this.fixedLocationByCfg_ = other.fixedLocationByCfg_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012CBC RID: 76988 RVA: 0x002BE539 File Offset: 0x002BC739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSceneGroupData Clone()
		{
			return new PlayerSceneGroupData(this);
		}

		// Token: 0x17003E5E RID: 15966
		// (get) Token: 0x06012CBD RID: 76989 RVA: 0x002BE541 File Offset: 0x002BC741
		// (set) Token: 0x06012CBE RID: 76990 RVA: 0x002BE549 File Offset: 0x002BC749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Group
		{
			get
			{
				return this.group_;
			}
			set
			{
				this.group_ = value;
			}
		}

		// Token: 0x17003E5F RID: 15967
		// (get) Token: 0x06012CBF RID: 76991 RVA: 0x002BE552 File Offset: 0x002BC752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneRoleInformation> FightRoleInfos
		{
			get
			{
				return this.fightRoleInfos_;
			}
		}

		// Token: 0x17003E60 RID: 15968
		// (get) Token: 0x06012CC0 RID: 76992 RVA: 0x002BE55A File Offset: 0x002BC75A
		// (set) Token: 0x06012CC1 RID: 76993 RVA: 0x002BE562 File Offset: 0x002BC762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurRole
		{
			get
			{
				return this.curRole_;
			}
			set
			{
				this.curRole_ = value;
			}
		}

		// Token: 0x17003E61 RID: 15969
		// (get) Token: 0x06012CC2 RID: 76994 RVA: 0x002BE56B File Offset: 0x002BC76B
		// (set) Token: 0x06012CC3 RID: 76995 RVA: 0x002BE573 File Offset: 0x002BC773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivingStatus LivingStatus
		{
			get
			{
				return this.livingStatus_;
			}
			set
			{
				this.livingStatus_ = value;
			}
		}

		// Token: 0x17003E62 RID: 15970
		// (get) Token: 0x06012CC4 RID: 76996 RVA: 0x002BE57C File Offset: 0x002BC77C
		// (set) Token: 0x06012CC5 RID: 76997 RVA: 0x002BE584 File Offset: 0x002BC784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool FixedLocationByCfg
		{
			get
			{
				return this.fixedLocationByCfg_;
			}
			set
			{
				this.fixedLocationByCfg_ = value;
			}
		}

		// Token: 0x06012CC6 RID: 76998 RVA: 0x002BE58D File Offset: 0x002BC78D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerSceneGroupData);
		}

		// Token: 0x06012CC7 RID: 76999 RVA: 0x002BE59C File Offset: 0x002BC79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerSceneGroupData other)
		{
			return other != null && (other == this || (this.Group == other.Group && this.fightRoleInfos_.Equals(other.fightRoleInfos_) && this.CurRole == other.CurRole && this.LivingStatus == other.LivingStatus && this.FixedLocationByCfg == other.FixedLocationByCfg && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012CC8 RID: 77000 RVA: 0x002BE61C File Offset: 0x002BC81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Group != 0)
			{
				num ^= this.Group.GetHashCode();
			}
			num ^= this.fightRoleInfos_.GetHashCode();
			if (this.CurRole != 0)
			{
				num ^= this.CurRole.GetHashCode();
			}
			if (this.LivingStatus != LivingStatus.Alive)
			{
				num ^= this.LivingStatus.GetHashCode();
			}
			if (this.FixedLocationByCfg)
			{
				num ^= this.FixedLocationByCfg.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012CC9 RID: 77001 RVA: 0x002BE6BA File Offset: 0x002BC8BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012CCA RID: 77002 RVA: 0x002BE6C7 File Offset: 0x002BC8C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012CCB RID: 77003 RVA: 0x002BE6D0 File Offset: 0x002BC8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Group != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Group);
			}
			this.fightRoleInfos_.WriteTo(ref output, PlayerSceneGroupData._repeated_fightRoleInfos_codec);
			if (this.CurRole != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CurRole);
			}
			if (this.LivingStatus != LivingStatus.Alive)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.LivingStatus);
			}
			if (this.FixedLocationByCfg)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.FixedLocationByCfg);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012CCC RID: 77004 RVA: 0x002BE774 File Offset: 0x002BC974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Group != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Group);
			}
			num += this.fightRoleInfos_.CalculateSize(PlayerSceneGroupData._repeated_fightRoleInfos_codec);
			if (this.CurRole != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurRole);
			}
			if (this.LivingStatus != LivingStatus.Alive)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.LivingStatus);
			}
			if (this.FixedLocationByCfg)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012CCD RID: 77005 RVA: 0x002BE804 File Offset: 0x002BCA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerSceneGroupData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Group != 0)
			{
				this.Group = other.Group;
			}
			this.fightRoleInfos_.Add(other.fightRoleInfos_);
			if (other.CurRole != 0)
			{
				this.CurRole = other.CurRole;
			}
			if (other.LivingStatus != LivingStatus.Alive)
			{
				this.LivingStatus = other.LivingStatus;
			}
			if (other.FixedLocationByCfg)
			{
				this.FixedLocationByCfg = other.FixedLocationByCfg;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012CCE RID: 77006 RVA: 0x002BE88D File Offset: 0x002BCA8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012CCF RID: 77007 RVA: 0x002BE898 File Offset: 0x002BCA98
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.Group = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.fightRoleInfos_.AddEntriesFrom(ref input, PlayerSceneGroupData._repeated_fightRoleInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.CurRole = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.LivingStatus = (LivingStatus)input.ReadEnum();
						continue;
					}
					if (num == 40U)
					{
						this.FixedLocationByCfg = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040074CC RID: 29900
		private static readonly MessageParser<PlayerSceneGroupData> _parser = new MessageParser<PlayerSceneGroupData>(() => new PlayerSceneGroupData());

		// Token: 0x040074CD RID: 29901
		private UnknownFieldSet _unknownFields;

		// Token: 0x040074CE RID: 29902
		public const int GroupFieldNumber = 1;

		// Token: 0x040074CF RID: 29903
		private int group_;

		// Token: 0x040074D0 RID: 29904
		public const int FightRoleInfosFieldNumber = 2;

		// Token: 0x040074D1 RID: 29905
		private static readonly FieldCodec<SceneRoleInformation> _repeated_fightRoleInfos_codec = FieldCodec.ForMessage<SceneRoleInformation>(18U, SceneRoleInformation.Parser);

		// Token: 0x040074D2 RID: 29906
		private readonly RepeatedField<SceneRoleInformation> fightRoleInfos_ = new RepeatedField<SceneRoleInformation>();

		// Token: 0x040074D3 RID: 29907
		public const int CurRoleFieldNumber = 3;

		// Token: 0x040074D4 RID: 29908
		private int curRole_;

		// Token: 0x040074D5 RID: 29909
		public const int LivingStatusFieldNumber = 4;

		// Token: 0x040074D6 RID: 29910
		private LivingStatus livingStatus_;

		// Token: 0x040074D7 RID: 29911
		public const int FixedLocationByCfgFieldNumber = 5;

		// Token: 0x040074D8 RID: 29912
		private bool fixedLocationByCfg_;
	}
}
