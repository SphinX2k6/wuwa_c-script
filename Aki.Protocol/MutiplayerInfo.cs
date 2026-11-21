using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ADA RID: 2778
	public sealed class MutiplayerInfo : IMessage<MutiplayerInfo>, IMessage, IEquatable<MutiplayerInfo>, IDeepCloneable<MutiplayerInfo>, IBufferMessage
	{
		// Token: 0x0600F1EE RID: 61934 RVA: 0x002356F5 File Offset: 0x002338F5
		[NullableContext(1)]
		public static MutiplayerInfo Create()
		{
			return new MutiplayerInfo();
		}

		// Token: 0x1700313C RID: 12604
		// (get) Token: 0x0600F1EF RID: 61935 RVA: 0x002356FC File Offset: 0x002338FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MutiplayerInfo> Parser
		{
			get
			{
				return MutiplayerInfo._parser;
			}
		}

		// Token: 0x1700313D RID: 12605
		// (get) Token: 0x0600F1F0 RID: 61936 RVA: 0x00235703 File Offset: 0x00233903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700313E RID: 12606
		// (get) Token: 0x0600F1F1 RID: 61937 RVA: 0x00235706 File Offset: 0x00233906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MutiplayerInfo.Descriptor;
			}
		}

		// Token: 0x0600F1F2 RID: 61938 RVA: 0x0023570D File Offset: 0x0023390D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MutiplayerInfo()
		{
		}

		// Token: 0x0600F1F3 RID: 61939 RVA: 0x00235738 File Offset: 0x00233938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MutiplayerInfo(MutiplayerInfo other) : this()
		{
			this.playerId_ = other.playerId_;
			this.name_ = other.name_;
			this.iconId_ = other.iconId_;
			this.level_ = other.level_;
			this.guildName_ = other.guildName_;
			this.guildIntro_ = other.guildIntro_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F1F4 RID: 61940 RVA: 0x002357A4 File Offset: 0x002339A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MutiplayerInfo Clone()
		{
			return new MutiplayerInfo(this);
		}

		// Token: 0x1700313F RID: 12607
		// (get) Token: 0x0600F1F5 RID: 61941 RVA: 0x002357AC File Offset: 0x002339AC
		// (set) Token: 0x0600F1F6 RID: 61942 RVA: 0x002357B4 File Offset: 0x002339B4
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

		// Token: 0x17003140 RID: 12608
		// (get) Token: 0x0600F1F7 RID: 61943 RVA: 0x002357BD File Offset: 0x002339BD
		// (set) Token: 0x0600F1F8 RID: 61944 RVA: 0x002357C5 File Offset: 0x002339C5
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

		// Token: 0x17003141 RID: 12609
		// (get) Token: 0x0600F1F9 RID: 61945 RVA: 0x002357D8 File Offset: 0x002339D8
		// (set) Token: 0x0600F1FA RID: 61946 RVA: 0x002357E0 File Offset: 0x002339E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IconId
		{
			get
			{
				return this.iconId_;
			}
			set
			{
				this.iconId_ = value;
			}
		}

		// Token: 0x17003142 RID: 12610
		// (get) Token: 0x0600F1FB RID: 61947 RVA: 0x002357E9 File Offset: 0x002339E9
		// (set) Token: 0x0600F1FC RID: 61948 RVA: 0x002357F1 File Offset: 0x002339F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17003143 RID: 12611
		// (get) Token: 0x0600F1FD RID: 61949 RVA: 0x002357FA File Offset: 0x002339FA
		// (set) Token: 0x0600F1FE RID: 61950 RVA: 0x00235802 File Offset: 0x00233A02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string GuildName
		{
			get
			{
				return this.guildName_;
			}
			set
			{
				this.guildName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003144 RID: 12612
		// (get) Token: 0x0600F1FF RID: 61951 RVA: 0x00235815 File Offset: 0x00233A15
		// (set) Token: 0x0600F200 RID: 61952 RVA: 0x0023581D File Offset: 0x00233A1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string GuildIntro
		{
			get
			{
				return this.guildIntro_;
			}
			set
			{
				this.guildIntro_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600F201 RID: 61953 RVA: 0x00235830 File Offset: 0x00233A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MutiplayerInfo);
		}

		// Token: 0x0600F202 RID: 61954 RVA: 0x00235840 File Offset: 0x00233A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MutiplayerInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && !(this.Name != other.Name) && this.IconId == other.IconId && this.Level == other.Level && !(this.GuildName != other.GuildName) && !(this.GuildIntro != other.GuildIntro) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F203 RID: 61955 RVA: 0x002358D8 File Offset: 0x00233AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.IconId != 0)
			{
				num ^= this.IconId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.GuildName.Length != 0)
			{
				num ^= this.GuildName.GetHashCode();
			}
			if (this.GuildIntro.Length != 0)
			{
				num ^= this.GuildIntro.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F204 RID: 61956 RVA: 0x0023599A File Offset: 0x00233B9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F205 RID: 61957 RVA: 0x002359A7 File Offset: 0x00233BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F206 RID: 61958 RVA: 0x002359B0 File Offset: 0x00233BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			if (this.IconId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.IconId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Level);
			}
			if (this.GuildName.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.GuildName);
			}
			if (this.GuildIntro.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.GuildIntro);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F207 RID: 61959 RVA: 0x00235A88 File Offset: 0x00233C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.IconId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IconId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.GuildName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GuildName);
			}
			if (this.GuildIntro.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GuildIntro);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F208 RID: 61960 RVA: 0x00235B50 File Offset: 0x00233D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MutiplayerInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.IconId != 0)
			{
				this.IconId = other.IconId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.GuildName.Length != 0)
			{
				this.GuildName = other.GuildName;
			}
			if (other.GuildIntro.Length != 0)
			{
				this.GuildIntro = other.GuildIntro;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F209 RID: 61961 RVA: 0x00235BFF File Offset: 0x00233DFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F20A RID: 61962 RVA: 0x00235C08 File Offset: 0x00233E08
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.Name = input.ReadString();
						continue;
					}
					if (num == 24U)
					{
						this.IconId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						this.GuildName = input.ReadString();
						continue;
					}
					if (num == 50U)
					{
						this.GuildIntro = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006204 RID: 25092
		private static readonly MessageParser<MutiplayerInfo> _parser = new MessageParser<MutiplayerInfo>(() => new MutiplayerInfo());

		// Token: 0x04006205 RID: 25093
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006206 RID: 25094
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04006207 RID: 25095
		private int playerId_;

		// Token: 0x04006208 RID: 25096
		public const int NameFieldNumber = 2;

		// Token: 0x04006209 RID: 25097
		private string name_ = "";

		// Token: 0x0400620A RID: 25098
		public const int IconIdFieldNumber = 3;

		// Token: 0x0400620B RID: 25099
		private int iconId_;

		// Token: 0x0400620C RID: 25100
		public const int LevelFieldNumber = 4;

		// Token: 0x0400620D RID: 25101
		private int level_;

		// Token: 0x0400620E RID: 25102
		public const int GuildNameFieldNumber = 5;

		// Token: 0x0400620F RID: 25103
		private string guildName_ = "";

		// Token: 0x04006210 RID: 25104
		public const int GuildIntroFieldNumber = 6;

		// Token: 0x04006211 RID: 25105
		private string guildIntro_ = "";
	}
}
