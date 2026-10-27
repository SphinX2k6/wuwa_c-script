using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001437 RID: 5175
	public sealed class TrapDefensePreviewStepPbData : IMessage<TrapDefensePreviewStepPbData>, IMessage, IEquatable<TrapDefensePreviewStepPbData>, IDeepCloneable<TrapDefensePreviewStepPbData>, IBufferMessage
	{
		// Token: 0x0601B69E RID: 112286 RVA: 0x003F81AB File Offset: 0x003F63AB
		[NullableContext(1)]
		public static TrapDefensePreviewStepPbData Create()
		{
			return new TrapDefensePreviewStepPbData();
		}

		// Token: 0x17005C6E RID: 23662
		// (get) Token: 0x0601B69F RID: 112287 RVA: 0x003F81B2 File Offset: 0x003F63B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C6F RID: 23663
		// (get) Token: 0x0601B6A0 RID: 112288 RVA: 0x003F81B5 File Offset: 0x003F63B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefensePreviewStepPbData.Descriptor;
			}
		}

		// Token: 0x0601B6A1 RID: 112289 RVA: 0x003F81BC File Offset: 0x003F63BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefensePreviewStepPbData()
		{
		}

		// Token: 0x0601B6A2 RID: 112290 RVA: 0x003F81D0 File Offset: 0x003F63D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefensePreviewStepPbData(TrapDefensePreviewStepPbData other) : this()
		{
			this.isShopAppear_ = other.isShopAppear_;
			this.monsterEnhancedTipText_ = other.monsterEnhancedTipText_;
			this.monsterRoutesPreviewInfo_ = other.monsterRoutesPreviewInfo_.Clone();
			this.endCountdownSecond_ = other.endCountdownSecond_;
			this.isWarningPrepareStyle_ = other.isWarningPrepareStyle_;
			this.shopInfo_ = ((other.shopInfo_ != null) ? other.shopInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B6A3 RID: 112291 RVA: 0x003F8251 File Offset: 0x003F6451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefensePreviewStepPbData Clone()
		{
			return new TrapDefensePreviewStepPbData(this);
		}

		// Token: 0x17005C70 RID: 23664
		// (get) Token: 0x0601B6A4 RID: 112292 RVA: 0x003F8259 File Offset: 0x003F6459
		// (set) Token: 0x0601B6A5 RID: 112293 RVA: 0x003F8261 File Offset: 0x003F6461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsShopAppear
		{
			get
			{
				return this.isShopAppear_;
			}
			set
			{
				this.isShopAppear_ = value;
			}
		}

		// Token: 0x17005C71 RID: 23665
		// (get) Token: 0x0601B6A6 RID: 112294 RVA: 0x003F826A File Offset: 0x003F646A
		// (set) Token: 0x0601B6A7 RID: 112295 RVA: 0x003F827B File Offset: 0x003F647B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string MonsterEnhancedTipText
		{
			get
			{
				return this.monsterEnhancedTipText_ ?? TrapDefensePreviewStepPbData.MonsterEnhancedTipTextDefaultValue;
			}
			set
			{
				this.monsterEnhancedTipText_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17005C72 RID: 23666
		// (get) Token: 0x0601B6A8 RID: 112296 RVA: 0x003F828E File Offset: 0x003F648E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasMonsterEnhancedTipText
		{
			get
			{
				return this.monsterEnhancedTipText_ != null;
			}
		}

		// Token: 0x0601B6A9 RID: 112297 RVA: 0x003F8299 File Offset: 0x003F6499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMonsterEnhancedTipText()
		{
			this.monsterEnhancedTipText_ = null;
		}

		// Token: 0x17005C73 RID: 23667
		// (get) Token: 0x0601B6AA RID: 112298 RVA: 0x003F82A2 File Offset: 0x003F64A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, TrapDefenseMonsterPbGroup> MonsterRoutesPreviewInfo
		{
			get
			{
				return this.monsterRoutesPreviewInfo_;
			}
		}

		// Token: 0x17005C74 RID: 23668
		// (get) Token: 0x0601B6AB RID: 112299 RVA: 0x003F82AA File Offset: 0x003F64AA
		// (set) Token: 0x0601B6AC RID: 112300 RVA: 0x003F82B2 File Offset: 0x003F64B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EndCountdownSecond
		{
			get
			{
				return this.endCountdownSecond_;
			}
			set
			{
				this.endCountdownSecond_ = value;
			}
		}

		// Token: 0x17005C75 RID: 23669
		// (get) Token: 0x0601B6AD RID: 112301 RVA: 0x003F82BB File Offset: 0x003F64BB
		// (set) Token: 0x0601B6AE RID: 112302 RVA: 0x003F82C3 File Offset: 0x003F64C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsWarningPrepareStyle
		{
			get
			{
				return this.isWarningPrepareStyle_;
			}
			set
			{
				this.isWarningPrepareStyle_ = value;
			}
		}

		// Token: 0x17005C76 RID: 23670
		// (get) Token: 0x0601B6AF RID: 112303 RVA: 0x003F82CC File Offset: 0x003F64CC
		// (set) Token: 0x0601B6B0 RID: 112304 RVA: 0x003F82D4 File Offset: 0x003F64D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopPanelInfo ShopInfo
		{
			get
			{
				return this.shopInfo_;
			}
			set
			{
				this.shopInfo_ = value;
			}
		}

		// Token: 0x0601B6B1 RID: 112305 RVA: 0x003F82DD File Offset: 0x003F64DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefensePreviewStepPbData);
		}

		// Token: 0x0601B6B2 RID: 112306 RVA: 0x003F82EC File Offset: 0x003F64EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefensePreviewStepPbData other)
		{
			return other != null && (other == this || (this.IsShopAppear == other.IsShopAppear && !(this.MonsterEnhancedTipText != other.MonsterEnhancedTipText) && this.MonsterRoutesPreviewInfo.Equals(other.MonsterRoutesPreviewInfo) && this.EndCountdownSecond == other.EndCountdownSecond && this.IsWarningPrepareStyle == other.IsWarningPrepareStyle && object.Equals(this.ShopInfo, other.ShopInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B6B3 RID: 112307 RVA: 0x003F8384 File Offset: 0x003F6584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsShopAppear)
			{
				num ^= this.IsShopAppear.GetHashCode();
			}
			if (this.HasMonsterEnhancedTipText)
			{
				num ^= this.MonsterEnhancedTipText.GetHashCode();
			}
			num ^= this.MonsterRoutesPreviewInfo.GetHashCode();
			if (this.EndCountdownSecond != 0)
			{
				num ^= this.EndCountdownSecond.GetHashCode();
			}
			if (this.IsWarningPrepareStyle)
			{
				num ^= this.IsWarningPrepareStyle.GetHashCode();
			}
			if (this.shopInfo_ != null)
			{
				num ^= this.ShopInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B6B4 RID: 112308 RVA: 0x003F842F File Offset: 0x003F662F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B6B5 RID: 112309 RVA: 0x003F843C File Offset: 0x003F663C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B6B6 RID: 112310 RVA: 0x003F8448 File Offset: 0x003F6648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsShopAppear)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsShopAppear);
			}
			if (this.HasMonsterEnhancedTipText)
			{
				output.WriteRawTag(18);
				output.WriteString(this.MonsterEnhancedTipText);
			}
			this.monsterRoutesPreviewInfo_.WriteTo(ref output, TrapDefensePreviewStepPbData._map_monsterRoutesPreviewInfo_codec);
			if (this.EndCountdownSecond != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.EndCountdownSecond);
			}
			if (this.IsWarningPrepareStyle)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsWarningPrepareStyle);
			}
			if (this.shopInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.ShopInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B6B7 RID: 112311 RVA: 0x003F8508 File Offset: 0x003F6708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsShopAppear)
			{
				num += 2;
			}
			if (this.HasMonsterEnhancedTipText)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MonsterEnhancedTipText);
			}
			num += this.monsterRoutesPreviewInfo_.CalculateSize(TrapDefensePreviewStepPbData._map_monsterRoutesPreviewInfo_codec);
			if (this.EndCountdownSecond != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EndCountdownSecond);
			}
			if (this.IsWarningPrepareStyle)
			{
				num += 2;
			}
			if (this.shopInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ShopInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B6B8 RID: 112312 RVA: 0x003F85A4 File Offset: 0x003F67A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefensePreviewStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsShopAppear)
			{
				this.IsShopAppear = other.IsShopAppear;
			}
			if (other.HasMonsterEnhancedTipText)
			{
				this.MonsterEnhancedTipText = other.MonsterEnhancedTipText;
			}
			this.monsterRoutesPreviewInfo_.MergeFrom(other.monsterRoutesPreviewInfo_);
			if (other.EndCountdownSecond != 0)
			{
				this.EndCountdownSecond = other.EndCountdownSecond;
			}
			if (other.IsWarningPrepareStyle)
			{
				this.IsWarningPrepareStyle = other.IsWarningPrepareStyle;
			}
			if (other.shopInfo_ != null)
			{
				if (this.shopInfo_ == null)
				{
					this.ShopInfo = new TrapDefenseShopPanelInfo();
				}
				this.ShopInfo.MergeFrom(other.ShopInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B6B9 RID: 112313 RVA: 0x003F8659 File Offset: 0x003F6859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B6BA RID: 112314 RVA: 0x003F8664 File Offset: 0x003F6864
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
				if (num <= 26U)
				{
					if (num == 8U)
					{
						this.IsShopAppear = input.ReadBool();
						continue;
					}
					if (num == 18U)
					{
						this.MonsterEnhancedTipText = input.ReadString();
						continue;
					}
					if (num == 26U)
					{
						this.monsterRoutesPreviewInfo_.AddEntriesFrom(ref input, TrapDefensePreviewStepPbData._map_monsterRoutesPreviewInfo_codec);
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.EndCountdownSecond = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.IsWarningPrepareStyle = input.ReadBool();
						continue;
					}
					if (num == 50U)
					{
						if (this.shopInfo_ == null)
						{
							this.ShopInfo = new TrapDefenseShopPanelInfo();
						}
						input.ReadMessage(this.ShopInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009E36 RID: 40502
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E37 RID: 40503
		public const int IsShopAppearFieldNumber = 1;

		// Token: 0x04009E38 RID: 40504
		private bool isShopAppear_;

		// Token: 0x04009E39 RID: 40505
		public const int MonsterEnhancedTipTextFieldNumber = 2;

		// Token: 0x04009E3A RID: 40506
		private static readonly string MonsterEnhancedTipTextDefaultValue = "";

		// Token: 0x04009E3B RID: 40507
		private string monsterEnhancedTipText_;

		// Token: 0x04009E3C RID: 40508
		public const int MonsterRoutesPreviewInfoFieldNumber = 3;

		// Token: 0x04009E3D RID: 40509
		private static readonly MapField<int, TrapDefenseMonsterPbGroup>.Codec _map_monsterRoutesPreviewInfo_codec = new MapField<int, TrapDefenseMonsterPbGroup>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<TrapDefenseMonsterPbGroup>(18U, TrapDefenseMonsterPbGroup.Parser), 26U);

		// Token: 0x04009E3E RID: 40510
		private readonly MapField<int, TrapDefenseMonsterPbGroup> monsterRoutesPreviewInfo_ = new MapField<int, TrapDefenseMonsterPbGroup>();

		// Token: 0x04009E3F RID: 40511
		public const int EndCountdownSecondFieldNumber = 4;

		// Token: 0x04009E40 RID: 40512
		private int endCountdownSecond_;

		// Token: 0x04009E41 RID: 40513
		public const int IsWarningPrepareStyleFieldNumber = 5;

		// Token: 0x04009E42 RID: 40514
		private bool isWarningPrepareStyle_;

		// Token: 0x04009E43 RID: 40515
		public const int ShopInfoFieldNumber = 6;

		// Token: 0x04009E44 RID: 40516
		private TrapDefenseShopPanelInfo shopInfo_;
	}
}
