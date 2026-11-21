using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001418 RID: 5144
	public sealed class TowerDefencePassPlayerInfo : IMessage<TowerDefencePassPlayerInfo>, IMessage, IEquatable<TowerDefencePassPlayerInfo>, IDeepCloneable<TowerDefencePassPlayerInfo>, IBufferMessage
	{
		// Token: 0x0601B57B RID: 111995 RVA: 0x003F9F39 File Offset: 0x003F8139
		[NullableContext(1)]
		public static TowerDefencePassPlayerInfo Create()
		{
			return new TowerDefencePassPlayerInfo();
		}

		// Token: 0x17005C8F RID: 23695
		// (get) Token: 0x0601B57C RID: 111996 RVA: 0x003F9F40 File Offset: 0x003F8140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerDefencePassPlayerInfo> Parser
		{
			get
			{
				return TowerDefencePassPlayerInfo._parser;
			}
		}

		// Token: 0x17005C90 RID: 23696
		// (get) Token: 0x0601B57D RID: 111997 RVA: 0x003F9F47 File Offset: 0x003F8147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C91 RID: 23697
		// (get) Token: 0x0601B57E RID: 111998 RVA: 0x003F9F4A File Offset: 0x003F814A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefencePassPlayerInfo.Descriptor;
			}
		}

		// Token: 0x0601B57F RID: 111999 RVA: 0x003F9F51 File Offset: 0x003F8151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePassPlayerInfo()
		{
		}

		// Token: 0x0601B580 RID: 112000 RVA: 0x003F9F70 File Offset: 0x003F8170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePassPlayerInfo(TowerDefencePassPlayerInfo other) : this()
		{
			this.roleList_ = other.roleList_.Clone();
			this.name_ = other.name_;
			this.playerId_ = other.playerId_;
			this.headId_ = other.headId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B581 RID: 112001 RVA: 0x003F9FC9 File Offset: 0x003F81C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePassPlayerInfo Clone()
		{
			return new TowerDefencePassPlayerInfo(this);
		}

		// Token: 0x17005C92 RID: 23698
		// (get) Token: 0x0601B582 RID: 112002 RVA: 0x003F9FD1 File Offset: 0x003F81D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerDefenceRolePassInfo> RoleList
		{
			get
			{
				return this.roleList_;
			}
		}

		// Token: 0x17005C93 RID: 23699
		// (get) Token: 0x0601B583 RID: 112003 RVA: 0x003F9FD9 File Offset: 0x003F81D9
		// (set) Token: 0x0601B584 RID: 112004 RVA: 0x003F9FE1 File Offset: 0x003F81E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17005C94 RID: 23700
		// (get) Token: 0x0601B585 RID: 112005 RVA: 0x003F9FF4 File Offset: 0x003F81F4
		// (set) Token: 0x0601B586 RID: 112006 RVA: 0x003F9FFC File Offset: 0x003F81FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17005C95 RID: 23701
		// (get) Token: 0x0601B587 RID: 112007 RVA: 0x003FA005 File Offset: 0x003F8205
		// (set) Token: 0x0601B588 RID: 112008 RVA: 0x003FA00D File Offset: 0x003F820D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HeadId
		{
			get
			{
				return this.headId_;
			}
			set
			{
				this.headId_ = value;
			}
		}

		// Token: 0x0601B589 RID: 112009 RVA: 0x003FA016 File Offset: 0x003F8216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefencePassPlayerInfo);
		}

		// Token: 0x0601B58A RID: 112010 RVA: 0x003FA024 File Offset: 0x003F8224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefencePassPlayerInfo other)
		{
			return other != null && (other == this || (this.roleList_.Equals(other.roleList_) && !(this.Name != other.Name) && this.PlayerId == other.PlayerId && this.HeadId == other.HeadId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B58B RID: 112011 RVA: 0x003FA098 File Offset: 0x003F8298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleList_.GetHashCode();
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.HeadId != 0)
			{
				num ^= this.HeadId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B58C RID: 112012 RVA: 0x003FA119 File Offset: 0x003F8319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B58D RID: 112013 RVA: 0x003FA126 File Offset: 0x003F8326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B58E RID: 112014 RVA: 0x003FA130 File Offset: 0x003F8330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleList_.WriteTo(ref output, TowerDefencePassPlayerInfo._repeated_roleList_codec);
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.PlayerId);
			}
			if (this.HeadId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.HeadId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B58F RID: 112015 RVA: 0x003FA1BC File Offset: 0x003F83BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleList_.CalculateSize(TowerDefencePassPlayerInfo._repeated_roleList_codec);
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.HeadId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeadId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B590 RID: 112016 RVA: 0x003FA244 File Offset: 0x003F8444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefencePassPlayerInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.roleList_.Add(other.roleList_);
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.HeadId != 0)
			{
				this.HeadId = other.HeadId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B591 RID: 112017 RVA: 0x003FA2BE File Offset: 0x003F84BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B592 RID: 112018 RVA: 0x003FA2C8 File Offset: 0x003F84C8
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
					if (num == 10U)
					{
						this.roleList_.AddEntriesFrom(ref input, TowerDefencePassPlayerInfo._repeated_roleList_codec);
						continue;
					}
					if (num == 18U)
					{
						this.Name = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.HeadId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009F46 RID: 40774
		private static readonly MessageParser<TowerDefencePassPlayerInfo> _parser = new MessageParser<TowerDefencePassPlayerInfo>(() => new TowerDefencePassPlayerInfo());

		// Token: 0x04009F47 RID: 40775
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F48 RID: 40776
		public const int RoleListFieldNumber = 1;

		// Token: 0x04009F49 RID: 40777
		private static readonly FieldCodec<TowerDefenceRolePassInfo> _repeated_roleList_codec = FieldCodec.ForMessage<TowerDefenceRolePassInfo>(10U, TowerDefenceRolePassInfo.Parser);

		// Token: 0x04009F4A RID: 40778
		private readonly RepeatedField<TowerDefenceRolePassInfo> roleList_ = new RepeatedField<TowerDefenceRolePassInfo>();

		// Token: 0x04009F4B RID: 40779
		public const int NameFieldNumber = 2;

		// Token: 0x04009F4C RID: 40780
		private string name_ = "";

		// Token: 0x04009F4D RID: 40781
		public const int PlayerIdFieldNumber = 4;

		// Token: 0x04009F4E RID: 40782
		private int playerId_;

		// Token: 0x04009F4F RID: 40783
		public const int HeadIdFieldNumber = 5;

		// Token: 0x04009F50 RID: 40784
		private int headId_;
	}
}
