using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014AA RID: 5290
	public sealed class TrapDefensePreviewStepPbData : IMessage<TrapDefensePreviewStepPbData>, IMessage, IEquatable<TrapDefensePreviewStepPbData>, IDeepCloneable<TrapDefensePreviewStepPbData>, IBufferMessage
	{
		// Token: 0x0601C129 RID: 114985 RVA: 0x0041347F File Offset: 0x0041167F
		[NullableContext(1)]
		public static TrapDefensePreviewStepPbData Create()
		{
			return new TrapDefensePreviewStepPbData();
		}

		// Token: 0x17005F03 RID: 24323
		// (get) Token: 0x0601C12A RID: 114986 RVA: 0x00413486 File Offset: 0x00411686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F04 RID: 24324
		// (get) Token: 0x0601C12B RID: 114987 RVA: 0x00413489 File Offset: 0x00411689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefensePreviewStepPbData.Descriptor;
			}
		}

		// Token: 0x0601C12C RID: 114988 RVA: 0x00413490 File Offset: 0x00411690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefensePreviewStepPbData()
		{
		}

		// Token: 0x0601C12D RID: 114989 RVA: 0x004134A4 File Offset: 0x004116A4
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

		// Token: 0x0601C12E RID: 114990 RVA: 0x00413525 File Offset: 0x00411725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefensePreviewStepPbData Clone()
		{
			return new TrapDefensePreviewStepPbData(this);
		}

		// Token: 0x17005F05 RID: 24325
		// (get) Token: 0x0601C12F RID: 114991 RVA: 0x0041352D File Offset: 0x0041172D
		// (set) Token: 0x0601C130 RID: 114992 RVA: 0x00413535 File Offset: 0x00411735
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

		// Token: 0x17005F06 RID: 24326
		// (get) Token: 0x0601C131 RID: 114993 RVA: 0x0041353E File Offset: 0x0041173E
		// (set) Token: 0x0601C132 RID: 114994 RVA: 0x0041354F File Offset: 0x0041174F
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

		// Token: 0x17005F07 RID: 24327
		// (get) Token: 0x0601C133 RID: 114995 RVA: 0x00413562 File Offset: 0x00411762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasMonsterEnhancedTipText
		{
			get
			{
				return this.monsterEnhancedTipText_ != null;
			}
		}

		// Token: 0x0601C134 RID: 114996 RVA: 0x0041356D File Offset: 0x0041176D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMonsterEnhancedTipText()
		{
			this.monsterEnhancedTipText_ = null;
		}

		// Token: 0x17005F08 RID: 24328
		// (get) Token: 0x0601C135 RID: 114997 RVA: 0x00413576 File Offset: 0x00411776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, TrapDefenseMonsterPbGroup> MonsterRoutesPreviewInfo
		{
			get
			{
				return this.monsterRoutesPreviewInfo_;
			}
		}

		// Token: 0x17005F09 RID: 24329
		// (get) Token: 0x0601C136 RID: 114998 RVA: 0x0041357E File Offset: 0x0041177E
		// (set) Token: 0x0601C137 RID: 114999 RVA: 0x00413586 File Offset: 0x00411786
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

		// Token: 0x17005F0A RID: 24330
		// (get) Token: 0x0601C138 RID: 115000 RVA: 0x0041358F File Offset: 0x0041178F
		// (set) Token: 0x0601C139 RID: 115001 RVA: 0x00413597 File Offset: 0x00411797
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

		// Token: 0x17005F0B RID: 24331
		// (get) Token: 0x0601C13A RID: 115002 RVA: 0x004135A0 File Offset: 0x004117A0
		// (set) Token: 0x0601C13B RID: 115003 RVA: 0x004135A8 File Offset: 0x004117A8
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

		// Token: 0x0601C13C RID: 115004 RVA: 0x004135B1 File Offset: 0x004117B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefensePreviewStepPbData);
		}

		// Token: 0x0601C13D RID: 115005 RVA: 0x004135C0 File Offset: 0x004117C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefensePreviewStepPbData other)
		{
			return other != null && (other == this || (this.IsShopAppear == other.IsShopAppear && !(this.MonsterEnhancedTipText != other.MonsterEnhancedTipText) && this.MonsterRoutesPreviewInfo.Equals(other.MonsterRoutesPreviewInfo) && this.EndCountdownSecond == other.EndCountdownSecond && this.IsWarningPrepareStyle == other.IsWarningPrepareStyle && object.Equals(this.ShopInfo, other.ShopInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C13E RID: 115006 RVA: 0x00413658 File Offset: 0x00411858
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

		// Token: 0x0601C13F RID: 115007 RVA: 0x00413703 File Offset: 0x00411903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C140 RID: 115008 RVA: 0x00413710 File Offset: 0x00411910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C141 RID: 115009 RVA: 0x0041371C File Offset: 0x0041191C
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

		// Token: 0x0601C142 RID: 115010 RVA: 0x004137DC File Offset: 0x004119DC
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

		// Token: 0x0601C143 RID: 115011 RVA: 0x00413878 File Offset: 0x00411A78
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

		// Token: 0x0601C144 RID: 115012 RVA: 0x0041392D File Offset: 0x00411B2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C145 RID: 115013 RVA: 0x00413938 File Offset: 0x00411B38
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

		// Token: 0x0400A27D RID: 41597
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A27E RID: 41598
		public const int IsShopAppearFieldNumber = 1;

		// Token: 0x0400A27F RID: 41599
		private bool isShopAppear_;

		// Token: 0x0400A280 RID: 41600
		public const int MonsterEnhancedTipTextFieldNumber = 2;

		// Token: 0x0400A281 RID: 41601
		private static readonly string MonsterEnhancedTipTextDefaultValue = "";

		// Token: 0x0400A282 RID: 41602
		private string monsterEnhancedTipText_;

		// Token: 0x0400A283 RID: 41603
		public const int MonsterRoutesPreviewInfoFieldNumber = 3;

		// Token: 0x0400A284 RID: 41604
		private static readonly MapField<int, TrapDefenseMonsterPbGroup>.Codec _map_monsterRoutesPreviewInfo_codec = new MapField<int, TrapDefenseMonsterPbGroup>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<TrapDefenseMonsterPbGroup>(18U, TrapDefenseMonsterPbGroup.Parser), 26U);

		// Token: 0x0400A285 RID: 41605
		private readonly MapField<int, TrapDefenseMonsterPbGroup> monsterRoutesPreviewInfo_ = new MapField<int, TrapDefenseMonsterPbGroup>();

		// Token: 0x0400A286 RID: 41606
		public const int EndCountdownSecondFieldNumber = 4;

		// Token: 0x0400A287 RID: 41607
		private int endCountdownSecond_;

		// Token: 0x0400A288 RID: 41608
		public const int IsWarningPrepareStyleFieldNumber = 5;

		// Token: 0x0400A289 RID: 41609
		private bool isWarningPrepareStyle_;

		// Token: 0x0400A28A RID: 41610
		public const int ShopInfoFieldNumber = 6;

		// Token: 0x0400A28B RID: 41611
		private TrapDefenseShopPanelInfo shopInfo_;
	}
}
