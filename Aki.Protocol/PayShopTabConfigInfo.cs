using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BF7 RID: 3063
	public sealed class PayShopTabConfigInfo : IMessage<PayShopTabConfigInfo>, IMessage, IEquatable<PayShopTabConfigInfo>, IDeepCloneable<PayShopTabConfigInfo>, IBufferMessage
	{
		// Token: 0x060109F1 RID: 68081 RVA: 0x0026EC70 File Offset: 0x0026CE70
		[NullableContext(1)]
		public static PayShopTabConfigInfo Create()
		{
			return new PayShopTabConfigInfo();
		}

		// Token: 0x170036C1 RID: 14017
		// (get) Token: 0x060109F2 RID: 68082 RVA: 0x0026EC77 File Offset: 0x0026CE77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PayShopTabConfigInfo> Parser
		{
			get
			{
				return PayShopTabConfigInfo._parser;
			}
		}

		// Token: 0x170036C2 RID: 14018
		// (get) Token: 0x060109F3 RID: 68083 RVA: 0x0026EC7E File Offset: 0x0026CE7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036C3 RID: 14019
		// (get) Token: 0x060109F4 RID: 68084 RVA: 0x0026EC81 File Offset: 0x0026CE81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopTabConfigInfo.Descriptor;
			}
		}

		// Token: 0x060109F5 RID: 68085 RVA: 0x0026EC88 File Offset: 0x0026CE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopTabConfigInfo()
		{
		}

		// Token: 0x060109F6 RID: 68086 RVA: 0x0026ECBC File Offset: 0x0026CEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopTabConfigInfo(PayShopTabConfigInfo other) : this()
		{
			this.shopId_ = other.shopId_;
			this.tabId_ = other.tabId_;
			this.sort_ = other.sort_;
			this.name_ = other.name_;
			this.logic_ = other.logic_;
			this.enable_ = other.enable_;
			this.beginTime_ = other.beginTime_;
			this.endTime_ = other.endTime_;
			this.tabSelectSpritePath_ = other.tabSelectSpritePath_;
			this.tabContentPath_ = other.tabContentPath_;
			this.money_ = other.money_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060109F7 RID: 68087 RVA: 0x0026ED69 File Offset: 0x0026CF69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopTabConfigInfo Clone()
		{
			return new PayShopTabConfigInfo(this);
		}

		// Token: 0x170036C4 RID: 14020
		// (get) Token: 0x060109F8 RID: 68088 RVA: 0x0026ED71 File Offset: 0x0026CF71
		// (set) Token: 0x060109F9 RID: 68089 RVA: 0x0026ED79 File Offset: 0x0026CF79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShopId
		{
			get
			{
				return this.shopId_;
			}
			set
			{
				this.shopId_ = value;
			}
		}

		// Token: 0x170036C5 RID: 14021
		// (get) Token: 0x060109FA RID: 68090 RVA: 0x0026ED82 File Offset: 0x0026CF82
		// (set) Token: 0x060109FB RID: 68091 RVA: 0x0026ED8A File Offset: 0x0026CF8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TabId
		{
			get
			{
				return this.tabId_;
			}
			set
			{
				this.tabId_ = value;
			}
		}

		// Token: 0x170036C6 RID: 14022
		// (get) Token: 0x060109FC RID: 68092 RVA: 0x0026ED93 File Offset: 0x0026CF93
		// (set) Token: 0x060109FD RID: 68093 RVA: 0x0026ED9B File Offset: 0x0026CF9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Sort
		{
			get
			{
				return this.sort_;
			}
			set
			{
				this.sort_ = value;
			}
		}

		// Token: 0x170036C7 RID: 14023
		// (get) Token: 0x060109FE RID: 68094 RVA: 0x0026EDA4 File Offset: 0x0026CFA4
		// (set) Token: 0x060109FF RID: 68095 RVA: 0x0026EDAC File Offset: 0x0026CFAC
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

		// Token: 0x170036C8 RID: 14024
		// (get) Token: 0x06010A00 RID: 68096 RVA: 0x0026EDBF File Offset: 0x0026CFBF
		// (set) Token: 0x06010A01 RID: 68097 RVA: 0x0026EDC7 File Offset: 0x0026CFC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Logic
		{
			get
			{
				return this.logic_;
			}
			set
			{
				this.logic_ = value;
			}
		}

		// Token: 0x170036C9 RID: 14025
		// (get) Token: 0x06010A02 RID: 68098 RVA: 0x0026EDD0 File Offset: 0x0026CFD0
		// (set) Token: 0x06010A03 RID: 68099 RVA: 0x0026EDD8 File Offset: 0x0026CFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Enable
		{
			get
			{
				return this.enable_;
			}
			set
			{
				this.enable_ = value;
			}
		}

		// Token: 0x170036CA RID: 14026
		// (get) Token: 0x06010A04 RID: 68100 RVA: 0x0026EDE1 File Offset: 0x0026CFE1
		// (set) Token: 0x06010A05 RID: 68101 RVA: 0x0026EDE9 File Offset: 0x0026CFE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginTime
		{
			get
			{
				return this.beginTime_;
			}
			set
			{
				this.beginTime_ = value;
			}
		}

		// Token: 0x170036CB RID: 14027
		// (get) Token: 0x06010A06 RID: 68102 RVA: 0x0026EDF2 File Offset: 0x0026CFF2
		// (set) Token: 0x06010A07 RID: 68103 RVA: 0x0026EDFA File Offset: 0x0026CFFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x170036CC RID: 14028
		// (get) Token: 0x06010A08 RID: 68104 RVA: 0x0026EE03 File Offset: 0x0026D003
		// (set) Token: 0x06010A09 RID: 68105 RVA: 0x0026EE0B File Offset: 0x0026D00B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TabSelectSpritePath
		{
			get
			{
				return this.tabSelectSpritePath_;
			}
			set
			{
				this.tabSelectSpritePath_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170036CD RID: 14029
		// (get) Token: 0x06010A0A RID: 68106 RVA: 0x0026EE1E File Offset: 0x0026D01E
		// (set) Token: 0x06010A0B RID: 68107 RVA: 0x0026EE26 File Offset: 0x0026D026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TabContentPath
		{
			get
			{
				return this.tabContentPath_;
			}
			set
			{
				this.tabContentPath_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170036CE RID: 14030
		// (get) Token: 0x06010A0C RID: 68108 RVA: 0x0026EE39 File Offset: 0x0026D039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Money
		{
			get
			{
				return this.money_;
			}
		}

		// Token: 0x06010A0D RID: 68109 RVA: 0x0026EE41 File Offset: 0x0026D041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopTabConfigInfo);
		}

		// Token: 0x06010A0E RID: 68110 RVA: 0x0026EE50 File Offset: 0x0026D050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopTabConfigInfo other)
		{
			return other != null && (other == this || (this.ShopId == other.ShopId && this.TabId == other.TabId && this.Sort == other.Sort && !(this.Name != other.Name) && this.Logic == other.Logic && this.Enable == other.Enable && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && !(this.TabSelectSpritePath != other.TabSelectSpritePath) && !(this.TabContentPath != other.TabContentPath) && this.money_.Equals(other.money_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010A0F RID: 68111 RVA: 0x0026EF40 File Offset: 0x0026D140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShopId != 0)
			{
				num ^= this.ShopId.GetHashCode();
			}
			if (this.TabId != 0)
			{
				num ^= this.TabId.GetHashCode();
			}
			if (this.Sort != 0)
			{
				num ^= this.Sort.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Logic != 0)
			{
				num ^= this.Logic.GetHashCode();
			}
			if (this.Enable)
			{
				num ^= this.Enable.GetHashCode();
			}
			if (this.BeginTime != 0L)
			{
				num ^= this.BeginTime.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this.TabSelectSpritePath.Length != 0)
			{
				num ^= this.TabSelectSpritePath.GetHashCode();
			}
			if (this.TabContentPath.Length != 0)
			{
				num ^= this.TabContentPath.GetHashCode();
			}
			num ^= this.money_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010A10 RID: 68112 RVA: 0x0026F074 File Offset: 0x0026D274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010A11 RID: 68113 RVA: 0x0026F081 File Offset: 0x0026D281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010A12 RID: 68114 RVA: 0x0026F08C File Offset: 0x0026D28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShopId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ShopId);
			}
			if (this.TabId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TabId);
			}
			if (this.Sort != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Sort);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Name);
			}
			if (this.Logic != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Logic);
			}
			if (this.Enable)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.Enable);
			}
			if (this.BeginTime != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EndTime);
			}
			if (this.TabSelectSpritePath.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.TabSelectSpritePath);
			}
			if (this.TabContentPath.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.TabContentPath);
			}
			this.money_.WriteTo(ref output, PayShopTabConfigInfo._repeated_money_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010A13 RID: 68115 RVA: 0x0026F1E4 File Offset: 0x0026D3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShopId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShopId);
			}
			if (this.TabId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TabId);
			}
			if (this.Sort != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Sort);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.Logic != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Logic);
			}
			if (this.Enable)
			{
				num += 2;
			}
			if (this.BeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this.TabSelectSpritePath.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TabSelectSpritePath);
			}
			if (this.TabContentPath.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TabContentPath);
			}
			num += this.money_.CalculateSize(PayShopTabConfigInfo._repeated_money_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010A14 RID: 68116 RVA: 0x0026F310 File Offset: 0x0026D510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayShopTabConfigInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShopId != 0)
			{
				this.ShopId = other.ShopId;
			}
			if (other.TabId != 0)
			{
				this.TabId = other.TabId;
			}
			if (other.Sort != 0)
			{
				this.Sort = other.Sort;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Logic != 0)
			{
				this.Logic = other.Logic;
			}
			if (other.Enable)
			{
				this.Enable = other.Enable;
			}
			if (other.BeginTime != 0L)
			{
				this.BeginTime = other.BeginTime;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			if (other.TabSelectSpritePath.Length != 0)
			{
				this.TabSelectSpritePath = other.TabSelectSpritePath;
			}
			if (other.TabContentPath.Length != 0)
			{
				this.TabContentPath = other.TabContentPath;
			}
			this.money_.Add(other.money_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010A15 RID: 68117 RVA: 0x0026F420 File Offset: 0x0026D620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010A16 RID: 68118 RVA: 0x0026F42C File Offset: 0x0026D62C
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
				if (num <= 48U)
				{
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.ShopId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.TabId = input.ReadInt32();
							continue;
						}
						if (num == 24U)
						{
							this.Sort = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							this.Name = input.ReadString();
							continue;
						}
						if (num == 40U)
						{
							this.Logic = input.ReadInt32();
							continue;
						}
						if (num == 48U)
						{
							this.Enable = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 74U)
				{
					if (num == 56U)
					{
						this.BeginTime = input.ReadInt64();
						continue;
					}
					if (num == 64U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
					if (num == 74U)
					{
						this.TabSelectSpritePath = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						this.TabContentPath = input.ReadString();
						continue;
					}
					if (num == 88U || num == 90U)
					{
						this.money_.AddEntriesFrom(ref input, PayShopTabConfigInfo._repeated_money_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040069A4 RID: 27044
		private static readonly MessageParser<PayShopTabConfigInfo> _parser = new MessageParser<PayShopTabConfigInfo>(() => new PayShopTabConfigInfo());

		// Token: 0x040069A5 RID: 27045
		private UnknownFieldSet _unknownFields;

		// Token: 0x040069A6 RID: 27046
		public const int ShopIdFieldNumber = 1;

		// Token: 0x040069A7 RID: 27047
		private int shopId_;

		// Token: 0x040069A8 RID: 27048
		public const int TabIdFieldNumber = 2;

		// Token: 0x040069A9 RID: 27049
		private int tabId_;

		// Token: 0x040069AA RID: 27050
		public const int SortFieldNumber = 3;

		// Token: 0x040069AB RID: 27051
		private int sort_;

		// Token: 0x040069AC RID: 27052
		public const int NameFieldNumber = 4;

		// Token: 0x040069AD RID: 27053
		private string name_ = "";

		// Token: 0x040069AE RID: 27054
		public const int LogicFieldNumber = 5;

		// Token: 0x040069AF RID: 27055
		private int logic_;

		// Token: 0x040069B0 RID: 27056
		public const int EnableFieldNumber = 6;

		// Token: 0x040069B1 RID: 27057
		private bool enable_;

		// Token: 0x040069B2 RID: 27058
		public const int BeginTimeFieldNumber = 7;

		// Token: 0x040069B3 RID: 27059
		private long beginTime_;

		// Token: 0x040069B4 RID: 27060
		public const int EndTimeFieldNumber = 8;

		// Token: 0x040069B5 RID: 27061
		private long endTime_;

		// Token: 0x040069B6 RID: 27062
		public const int TabSelectSpritePathFieldNumber = 9;

		// Token: 0x040069B7 RID: 27063
		private string tabSelectSpritePath_ = "";

		// Token: 0x040069B8 RID: 27064
		public const int TabContentPathFieldNumber = 10;

		// Token: 0x040069B9 RID: 27065
		private string tabContentPath_ = "";

		// Token: 0x040069BA RID: 27066
		public const int MoneyFieldNumber = 11;

		// Token: 0x040069BB RID: 27067
		private static readonly FieldCodec<int> _repeated_money_codec = FieldCodec.ForInt32(90U);

		// Token: 0x040069BC RID: 27068
		private readonly RepeatedField<int> money_ = new RepeatedField<int>();
	}
}
