using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AEB RID: 2795
	public sealed class MutiplayerInfo : IMessage<MutiplayerInfo>, IMessage, IEquatable<MutiplayerInfo>, IDeepCloneable<MutiplayerInfo>, IBufferMessage
	{
		// Token: 0x0600F308 RID: 62216 RVA: 0x002378FD File Offset: 0x00235AFD
		[NullableContext(1)]
		public static MutiplayerInfo Create()
		{
			return new MutiplayerInfo();
		}

		// Token: 0x1700317A RID: 12666
		// (get) Token: 0x0600F309 RID: 62217 RVA: 0x00237904 File Offset: 0x00235B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MutiplayerInfo> Parser
		{
			get
			{
				return MutiplayerInfo._parser;
			}
		}

		// Token: 0x1700317B RID: 12667
		// (get) Token: 0x0600F30A RID: 62218 RVA: 0x0023790B File Offset: 0x00235B0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700317C RID: 12668
		// (get) Token: 0x0600F30B RID: 62219 RVA: 0x0023790E File Offset: 0x00235B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MutiplayerInfo.Descriptor;
			}
		}

		// Token: 0x0600F30C RID: 62220 RVA: 0x00237915 File Offset: 0x00235B15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MutiplayerInfo()
		{
		}

		// Token: 0x0600F30D RID: 62221 RVA: 0x00237940 File Offset: 0x00235B40
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

		// Token: 0x0600F30E RID: 62222 RVA: 0x002379AC File Offset: 0x00235BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MutiplayerInfo Clone()
		{
			return new MutiplayerInfo(this);
		}

		// Token: 0x1700317D RID: 12669
		// (get) Token: 0x0600F30F RID: 62223 RVA: 0x002379B4 File Offset: 0x00235BB4
		// (set) Token: 0x0600F310 RID: 62224 RVA: 0x002379BC File Offset: 0x00235BBC
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

		// Token: 0x1700317E RID: 12670
		// (get) Token: 0x0600F311 RID: 62225 RVA: 0x002379C5 File Offset: 0x00235BC5
		// (set) Token: 0x0600F312 RID: 62226 RVA: 0x002379CD File Offset: 0x00235BCD
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

		// Token: 0x1700317F RID: 12671
		// (get) Token: 0x0600F313 RID: 62227 RVA: 0x002379E0 File Offset: 0x00235BE0
		// (set) Token: 0x0600F314 RID: 62228 RVA: 0x002379E8 File Offset: 0x00235BE8
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

		// Token: 0x17003180 RID: 12672
		// (get) Token: 0x0600F315 RID: 62229 RVA: 0x002379F1 File Offset: 0x00235BF1
		// (set) Token: 0x0600F316 RID: 62230 RVA: 0x002379F9 File Offset: 0x00235BF9
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

		// Token: 0x17003181 RID: 12673
		// (get) Token: 0x0600F317 RID: 62231 RVA: 0x00237A02 File Offset: 0x00235C02
		// (set) Token: 0x0600F318 RID: 62232 RVA: 0x00237A0A File Offset: 0x00235C0A
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

		// Token: 0x17003182 RID: 12674
		// (get) Token: 0x0600F319 RID: 62233 RVA: 0x00237A1D File Offset: 0x00235C1D
		// (set) Token: 0x0600F31A RID: 62234 RVA: 0x00237A25 File Offset: 0x00235C25
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

		// Token: 0x0600F31B RID: 62235 RVA: 0x00237A38 File Offset: 0x00235C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MutiplayerInfo);
		}

		// Token: 0x0600F31C RID: 62236 RVA: 0x00237A48 File Offset: 0x00235C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MutiplayerInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && !(this.Name != other.Name) && this.IconId == other.IconId && this.Level == other.Level && !(this.GuildName != other.GuildName) && !(this.GuildIntro != other.GuildIntro) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F31D RID: 62237 RVA: 0x00237AE0 File Offset: 0x00235CE0
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

		// Token: 0x0600F31E RID: 62238 RVA: 0x00237BA2 File Offset: 0x00235DA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F31F RID: 62239 RVA: 0x00237BAF File Offset: 0x00235DAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F320 RID: 62240 RVA: 0x00237BB8 File Offset: 0x00235DB8
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

		// Token: 0x0600F321 RID: 62241 RVA: 0x00237C90 File Offset: 0x00235E90
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

		// Token: 0x0600F322 RID: 62242 RVA: 0x00237D58 File Offset: 0x00235F58
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

		// Token: 0x0600F323 RID: 62243 RVA: 0x00237E07 File Offset: 0x00236007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F324 RID: 62244 RVA: 0x00237E10 File Offset: 0x00236010
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

		// Token: 0x040061FB RID: 25083
		private static readonly MessageParser<MutiplayerInfo> _parser = new MessageParser<MutiplayerInfo>(() => new MutiplayerInfo());

		// Token: 0x040061FC RID: 25084
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061FD RID: 25085
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x040061FE RID: 25086
		private int playerId_;

		// Token: 0x040061FF RID: 25087
		public const int NameFieldNumber = 2;

		// Token: 0x04006200 RID: 25088
		private string name_ = "";

		// Token: 0x04006201 RID: 25089
		public const int IconIdFieldNumber = 3;

		// Token: 0x04006202 RID: 25090
		private int iconId_;

		// Token: 0x04006203 RID: 25091
		public const int LevelFieldNumber = 4;

		// Token: 0x04006204 RID: 25092
		private int level_;

		// Token: 0x04006205 RID: 25093
		public const int GuildNameFieldNumber = 5;

		// Token: 0x04006206 RID: 25094
		private string guildName_ = "";

		// Token: 0x04006207 RID: 25095
		public const int GuildIntroFieldNumber = 6;

		// Token: 0x04006208 RID: 25096
		private string guildIntro_ = "";
	}
}
