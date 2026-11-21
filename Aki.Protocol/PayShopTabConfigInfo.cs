using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BE7 RID: 3047
	public sealed class PayShopTabConfigInfo : IMessage<PayShopTabConfigInfo>, IMessage, IEquatable<PayShopTabConfigInfo>, IDeepCloneable<PayShopTabConfigInfo>, IBufferMessage
	{
		// Token: 0x060108F1 RID: 67825 RVA: 0x0026CF08 File Offset: 0x0026B108
		[NullableContext(1)]
		public static PayShopTabConfigInfo Create()
		{
			return new PayShopTabConfigInfo();
		}

		// Token: 0x1700368A RID: 13962
		// (get) Token: 0x060108F2 RID: 67826 RVA: 0x0026CF0F File Offset: 0x0026B10F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PayShopTabConfigInfo> Parser
		{
			get
			{
				return PayShopTabConfigInfo._parser;
			}
		}

		// Token: 0x1700368B RID: 13963
		// (get) Token: 0x060108F3 RID: 67827 RVA: 0x0026CF16 File Offset: 0x0026B116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700368C RID: 13964
		// (get) Token: 0x060108F4 RID: 67828 RVA: 0x0026CF19 File Offset: 0x0026B119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopTabConfigInfo.Descriptor;
			}
		}

		// Token: 0x060108F5 RID: 67829 RVA: 0x0026CF20 File Offset: 0x0026B120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopTabConfigInfo()
		{
		}

		// Token: 0x060108F6 RID: 67830 RVA: 0x0026CF54 File Offset: 0x0026B154
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

		// Token: 0x060108F7 RID: 67831 RVA: 0x0026D001 File Offset: 0x0026B201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopTabConfigInfo Clone()
		{
			return new PayShopTabConfigInfo(this);
		}

		// Token: 0x1700368D RID: 13965
		// (get) Token: 0x060108F8 RID: 67832 RVA: 0x0026D009 File Offset: 0x0026B209
		// (set) Token: 0x060108F9 RID: 67833 RVA: 0x0026D011 File Offset: 0x0026B211
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

		// Token: 0x1700368E RID: 13966
		// (get) Token: 0x060108FA RID: 67834 RVA: 0x0026D01A File Offset: 0x0026B21A
		// (set) Token: 0x060108FB RID: 67835 RVA: 0x0026D022 File Offset: 0x0026B222
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

		// Token: 0x1700368F RID: 13967
		// (get) Token: 0x060108FC RID: 67836 RVA: 0x0026D02B File Offset: 0x0026B22B
		// (set) Token: 0x060108FD RID: 67837 RVA: 0x0026D033 File Offset: 0x0026B233
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

		// Token: 0x17003690 RID: 13968
		// (get) Token: 0x060108FE RID: 67838 RVA: 0x0026D03C File Offset: 0x0026B23C
		// (set) Token: 0x060108FF RID: 67839 RVA: 0x0026D044 File Offset: 0x0026B244
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

		// Token: 0x17003691 RID: 13969
		// (get) Token: 0x06010900 RID: 67840 RVA: 0x0026D057 File Offset: 0x0026B257
		// (set) Token: 0x06010901 RID: 67841 RVA: 0x0026D05F File Offset: 0x0026B25F
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

		// Token: 0x17003692 RID: 13970
		// (get) Token: 0x06010902 RID: 67842 RVA: 0x0026D068 File Offset: 0x0026B268
		// (set) Token: 0x06010903 RID: 67843 RVA: 0x0026D070 File Offset: 0x0026B270
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

		// Token: 0x17003693 RID: 13971
		// (get) Token: 0x06010904 RID: 67844 RVA: 0x0026D079 File Offset: 0x0026B279
		// (set) Token: 0x06010905 RID: 67845 RVA: 0x0026D081 File Offset: 0x0026B281
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

		// Token: 0x17003694 RID: 13972
		// (get) Token: 0x06010906 RID: 67846 RVA: 0x0026D08A File Offset: 0x0026B28A
		// (set) Token: 0x06010907 RID: 67847 RVA: 0x0026D092 File Offset: 0x0026B292
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

		// Token: 0x17003695 RID: 13973
		// (get) Token: 0x06010908 RID: 67848 RVA: 0x0026D09B File Offset: 0x0026B29B
		// (set) Token: 0x06010909 RID: 67849 RVA: 0x0026D0A3 File Offset: 0x0026B2A3
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

		// Token: 0x17003696 RID: 13974
		// (get) Token: 0x0601090A RID: 67850 RVA: 0x0026D0B6 File Offset: 0x0026B2B6
		// (set) Token: 0x0601090B RID: 67851 RVA: 0x0026D0BE File Offset: 0x0026B2BE
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

		// Token: 0x17003697 RID: 13975
		// (get) Token: 0x0601090C RID: 67852 RVA: 0x0026D0D1 File Offset: 0x0026B2D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Money
		{
			get
			{
				return this.money_;
			}
		}

		// Token: 0x0601090D RID: 67853 RVA: 0x0026D0D9 File Offset: 0x0026B2D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopTabConfigInfo);
		}

		// Token: 0x0601090E RID: 67854 RVA: 0x0026D0E8 File Offset: 0x0026B2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopTabConfigInfo other)
		{
			return other != null && (other == this || (this.ShopId == other.ShopId && this.TabId == other.TabId && this.Sort == other.Sort && !(this.Name != other.Name) && this.Logic == other.Logic && this.Enable == other.Enable && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && !(this.TabSelectSpritePath != other.TabSelectSpritePath) && !(this.TabContentPath != other.TabContentPath) && this.money_.Equals(other.money_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601090F RID: 67855 RVA: 0x0026D1D8 File Offset: 0x0026B3D8
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

		// Token: 0x06010910 RID: 67856 RVA: 0x0026D30C File Offset: 0x0026B50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010911 RID: 67857 RVA: 0x0026D319 File Offset: 0x0026B519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010912 RID: 67858 RVA: 0x0026D324 File Offset: 0x0026B524
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

		// Token: 0x06010913 RID: 67859 RVA: 0x0026D47C File Offset: 0x0026B67C
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

		// Token: 0x06010914 RID: 67860 RVA: 0x0026D5A8 File Offset: 0x0026B7A8
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

		// Token: 0x06010915 RID: 67861 RVA: 0x0026D6B8 File Offset: 0x0026B8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010916 RID: 67862 RVA: 0x0026D6C4 File Offset: 0x0026B8C4
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

		// Token: 0x040069B8 RID: 27064
		private static readonly MessageParser<PayShopTabConfigInfo> _parser = new MessageParser<PayShopTabConfigInfo>(() => new PayShopTabConfigInfo());

		// Token: 0x040069B9 RID: 27065
		private UnknownFieldSet _unknownFields;

		// Token: 0x040069BA RID: 27066
		public const int ShopIdFieldNumber = 1;

		// Token: 0x040069BB RID: 27067
		private int shopId_;

		// Token: 0x040069BC RID: 27068
		public const int TabIdFieldNumber = 2;

		// Token: 0x040069BD RID: 27069
		private int tabId_;

		// Token: 0x040069BE RID: 27070
		public const int SortFieldNumber = 3;

		// Token: 0x040069BF RID: 27071
		private int sort_;

		// Token: 0x040069C0 RID: 27072
		public const int NameFieldNumber = 4;

		// Token: 0x040069C1 RID: 27073
		private string name_ = "";

		// Token: 0x040069C2 RID: 27074
		public const int LogicFieldNumber = 5;

		// Token: 0x040069C3 RID: 27075
		private int logic_;

		// Token: 0x040069C4 RID: 27076
		public const int EnableFieldNumber = 6;

		// Token: 0x040069C5 RID: 27077
		private bool enable_;

		// Token: 0x040069C6 RID: 27078
		public const int BeginTimeFieldNumber = 7;

		// Token: 0x040069C7 RID: 27079
		private long beginTime_;

		// Token: 0x040069C8 RID: 27080
		public const int EndTimeFieldNumber = 8;

		// Token: 0x040069C9 RID: 27081
		private long endTime_;

		// Token: 0x040069CA RID: 27082
		public const int TabSelectSpritePathFieldNumber = 9;

		// Token: 0x040069CB RID: 27083
		private string tabSelectSpritePath_ = "";

		// Token: 0x040069CC RID: 27084
		public const int TabContentPathFieldNumber = 10;

		// Token: 0x040069CD RID: 27085
		private string tabContentPath_ = "";

		// Token: 0x040069CE RID: 27086
		public const int MoneyFieldNumber = 11;

		// Token: 0x040069CF RID: 27087
		private static readonly FieldCodec<int> _repeated_money_codec = FieldCodec.ForInt32(90U);

		// Token: 0x040069D0 RID: 27088
		private readonly RepeatedField<int> money_ = new RepeatedField<int>();
	}
}
