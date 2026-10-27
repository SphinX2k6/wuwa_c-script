using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DAC RID: 3500
	public sealed class PlayerSceneGroupData : IMessage<PlayerSceneGroupData>, IMessage, IEquatable<PlayerSceneGroupData>, IDeepCloneable<PlayerSceneGroupData>, IBufferMessage
	{
		// Token: 0x06012DB2 RID: 77234 RVA: 0x002C00CA File Offset: 0x002BE2CA
		[NullableContext(1)]
		public static PlayerSceneGroupData Create()
		{
			return new PlayerSceneGroupData();
		}

		// Token: 0x17003E90 RID: 16016
		// (get) Token: 0x06012DB3 RID: 77235 RVA: 0x002C00D1 File Offset: 0x002BE2D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerSceneGroupData> Parser
		{
			get
			{
				return PlayerSceneGroupData._parser;
			}
		}

		// Token: 0x17003E91 RID: 16017
		// (get) Token: 0x06012DB4 RID: 77236 RVA: 0x002C00D8 File Offset: 0x002BE2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E92 RID: 16018
		// (get) Token: 0x06012DB5 RID: 77237 RVA: 0x002C00DB File Offset: 0x002BE2DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerSceneGroupData.Descriptor;
			}
		}

		// Token: 0x06012DB6 RID: 77238 RVA: 0x002C00E2 File Offset: 0x002BE2E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSceneGroupData()
		{
		}

		// Token: 0x06012DB7 RID: 77239 RVA: 0x002C00F8 File Offset: 0x002BE2F8
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

		// Token: 0x06012DB8 RID: 77240 RVA: 0x002C015D File Offset: 0x002BE35D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSceneGroupData Clone()
		{
			return new PlayerSceneGroupData(this);
		}

		// Token: 0x17003E93 RID: 16019
		// (get) Token: 0x06012DB9 RID: 77241 RVA: 0x002C0165 File Offset: 0x002BE365
		// (set) Token: 0x06012DBA RID: 77242 RVA: 0x002C016D File Offset: 0x002BE36D
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

		// Token: 0x17003E94 RID: 16020
		// (get) Token: 0x06012DBB RID: 77243 RVA: 0x002C0176 File Offset: 0x002BE376
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneRoleInformation> FightRoleInfos
		{
			get
			{
				return this.fightRoleInfos_;
			}
		}

		// Token: 0x17003E95 RID: 16021
		// (get) Token: 0x06012DBC RID: 77244 RVA: 0x002C017E File Offset: 0x002BE37E
		// (set) Token: 0x06012DBD RID: 77245 RVA: 0x002C0186 File Offset: 0x002BE386
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

		// Token: 0x17003E96 RID: 16022
		// (get) Token: 0x06012DBE RID: 77246 RVA: 0x002C018F File Offset: 0x002BE38F
		// (set) Token: 0x06012DBF RID: 77247 RVA: 0x002C0197 File Offset: 0x002BE397
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

		// Token: 0x17003E97 RID: 16023
		// (get) Token: 0x06012DC0 RID: 77248 RVA: 0x002C01A0 File Offset: 0x002BE3A0
		// (set) Token: 0x06012DC1 RID: 77249 RVA: 0x002C01A8 File Offset: 0x002BE3A8
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

		// Token: 0x06012DC2 RID: 77250 RVA: 0x002C01B1 File Offset: 0x002BE3B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerSceneGroupData);
		}

		// Token: 0x06012DC3 RID: 77251 RVA: 0x002C01C0 File Offset: 0x002BE3C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerSceneGroupData other)
		{
			return other != null && (other == this || (this.Group == other.Group && this.fightRoleInfos_.Equals(other.fightRoleInfos_) && this.CurRole == other.CurRole && this.LivingStatus == other.LivingStatus && this.FixedLocationByCfg == other.FixedLocationByCfg && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012DC4 RID: 77252 RVA: 0x002C0240 File Offset: 0x002BE440
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

		// Token: 0x06012DC5 RID: 77253 RVA: 0x002C02DE File Offset: 0x002BE4DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012DC6 RID: 77254 RVA: 0x002C02EB File Offset: 0x002BE4EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012DC7 RID: 77255 RVA: 0x002C02F4 File Offset: 0x002BE4F4
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

		// Token: 0x06012DC8 RID: 77256 RVA: 0x002C0398 File Offset: 0x002BE598
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

		// Token: 0x06012DC9 RID: 77257 RVA: 0x002C0428 File Offset: 0x002BE628
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

		// Token: 0x06012DCA RID: 77258 RVA: 0x002C04B1 File Offset: 0x002BE6B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012DCB RID: 77259 RVA: 0x002C04BC File Offset: 0x002BE6BC
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

		// Token: 0x040074B4 RID: 29876
		private static readonly MessageParser<PlayerSceneGroupData> _parser = new MessageParser<PlayerSceneGroupData>(() => new PlayerSceneGroupData());

		// Token: 0x040074B5 RID: 29877
		private UnknownFieldSet _unknownFields;

		// Token: 0x040074B6 RID: 29878
		public const int GroupFieldNumber = 1;

		// Token: 0x040074B7 RID: 29879
		private int group_;

		// Token: 0x040074B8 RID: 29880
		public const int FightRoleInfosFieldNumber = 2;

		// Token: 0x040074B9 RID: 29881
		private static readonly FieldCodec<SceneRoleInformation> _repeated_fightRoleInfos_codec = FieldCodec.ForMessage<SceneRoleInformation>(18U, SceneRoleInformation.Parser);

		// Token: 0x040074BA RID: 29882
		private readonly RepeatedField<SceneRoleInformation> fightRoleInfos_ = new RepeatedField<SceneRoleInformation>();

		// Token: 0x040074BB RID: 29883
		public const int CurRoleFieldNumber = 3;

		// Token: 0x040074BC RID: 29884
		private int curRole_;

		// Token: 0x040074BD RID: 29885
		public const int LivingStatusFieldNumber = 4;

		// Token: 0x040074BE RID: 29886
		private LivingStatus livingStatus_;

		// Token: 0x040074BF RID: 29887
		public const int FixedLocationByCfgFieldNumber = 5;

		// Token: 0x040074C0 RID: 29888
		private bool fixedLocationByCfg_;
	}
}
