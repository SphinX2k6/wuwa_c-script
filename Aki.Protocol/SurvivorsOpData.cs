using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001344 RID: 4932
	public sealed class SurvivorsOpData : IMessage<SurvivorsOpData>, IMessage, IEquatable<SurvivorsOpData>, IDeepCloneable<SurvivorsOpData>, IBufferMessage
	{
		// Token: 0x0601A489 RID: 107657 RVA: 0x003D4A99 File Offset: 0x003D2C99
		[NullableContext(1)]
		public static SurvivorsOpData Create()
		{
			return new SurvivorsOpData();
		}

		// Token: 0x17005902 RID: 22786
		// (get) Token: 0x0601A48A RID: 107658 RVA: 0x003D4AA0 File Offset: 0x003D2CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SurvivorsOpData> Parser
		{
			get
			{
				return SurvivorsOpData._parser;
			}
		}

		// Token: 0x17005903 RID: 22787
		// (get) Token: 0x0601A48B RID: 107659 RVA: 0x003D4AA7 File Offset: 0x003D2CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005904 RID: 22788
		// (get) Token: 0x0601A48C RID: 107660 RVA: 0x003D4AAA File Offset: 0x003D2CAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsOpData.Descriptor;
			}
		}

		// Token: 0x0601A48D RID: 107661 RVA: 0x003D4AB1 File Offset: 0x003D2CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpData()
		{
		}

		// Token: 0x0601A48E RID: 107662 RVA: 0x003D4ABC File Offset: 0x003D2CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpData(SurvivorsOpData other) : this()
		{
			this.incId_ = other.incId_;
			switch (other.DataCase)
			{
			case SurvivorsOpData.DataOneofCase.TokenAwardView:
				this.TokenAwardView = other.TokenAwardView.Clone();
				break;
			case SurvivorsOpData.DataOneofCase.TokenSelectView:
				this.TokenSelectView = other.TokenSelectView.Clone();
				break;
			case SurvivorsOpData.DataOneofCase.WeaponSelectView:
				this.WeaponSelectView = other.WeaponSelectView.Clone();
				break;
			case SurvivorsOpData.DataOneofCase.ShopView:
				this.ShopView = other.ShopView.Clone();
				break;
			case SurvivorsOpData.DataOneofCase.EvolveView:
				this.EvolveView = other.EvolveView.Clone();
				break;
			case SurvivorsOpData.DataOneofCase.ResultView:
				this.ResultView = other.ResultView.Clone();
				break;
			case SurvivorsOpData.DataOneofCase.RoleOrWeaponUpView:
				this.RoleOrWeaponUpView = other.RoleOrWeaponUpView.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A48F RID: 107663 RVA: 0x003D4BA3 File Offset: 0x003D2DA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpData Clone()
		{
			return new SurvivorsOpData(this);
		}

		// Token: 0x17005905 RID: 22789
		// (get) Token: 0x0601A490 RID: 107664 RVA: 0x003D4BAB File Offset: 0x003D2DAB
		// (set) Token: 0x0601A491 RID: 107665 RVA: 0x003D4BB3 File Offset: 0x003D2DB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17005906 RID: 22790
		// (get) Token: 0x0601A492 RID: 107666 RVA: 0x003D4BBC File Offset: 0x003D2DBC
		// (set) Token: 0x0601A493 RID: 107667 RVA: 0x003D4BD4 File Offset: 0x003D2DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TokenAwardView TokenAwardView
		{
			get
			{
				if (this.dataCase_ != SurvivorsOpData.DataOneofCase.TokenAwardView)
				{
					return null;
				}
				return (TokenAwardView)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SurvivorsOpData.DataOneofCase.None : SurvivorsOpData.DataOneofCase.TokenAwardView);
			}
		}

		// Token: 0x17005907 RID: 22791
		// (get) Token: 0x0601A494 RID: 107668 RVA: 0x003D4BEA File Offset: 0x003D2DEA
		// (set) Token: 0x0601A495 RID: 107669 RVA: 0x003D4C02 File Offset: 0x003D2E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TokenSelectView TokenSelectView
		{
			get
			{
				if (this.dataCase_ != SurvivorsOpData.DataOneofCase.TokenSelectView)
				{
					return null;
				}
				return (TokenSelectView)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SurvivorsOpData.DataOneofCase.None : SurvivorsOpData.DataOneofCase.TokenSelectView);
			}
		}

		// Token: 0x17005908 RID: 22792
		// (get) Token: 0x0601A496 RID: 107670 RVA: 0x003D4C18 File Offset: 0x003D2E18
		// (set) Token: 0x0601A497 RID: 107671 RVA: 0x003D4C30 File Offset: 0x003D2E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponSelectView WeaponSelectView
		{
			get
			{
				if (this.dataCase_ != SurvivorsOpData.DataOneofCase.WeaponSelectView)
				{
					return null;
				}
				return (WeaponSelectView)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SurvivorsOpData.DataOneofCase.None : SurvivorsOpData.DataOneofCase.WeaponSelectView);
			}
		}

		// Token: 0x17005909 RID: 22793
		// (get) Token: 0x0601A498 RID: 107672 RVA: 0x003D4C46 File Offset: 0x003D2E46
		// (set) Token: 0x0601A499 RID: 107673 RVA: 0x003D4C5E File Offset: 0x003D2E5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopView ShopView
		{
			get
			{
				if (this.dataCase_ != SurvivorsOpData.DataOneofCase.ShopView)
				{
					return null;
				}
				return (ShopView)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SurvivorsOpData.DataOneofCase.None : SurvivorsOpData.DataOneofCase.ShopView);
			}
		}

		// Token: 0x1700590A RID: 22794
		// (get) Token: 0x0601A49A RID: 107674 RVA: 0x003D4C74 File Offset: 0x003D2E74
		// (set) Token: 0x0601A49B RID: 107675 RVA: 0x003D4C8C File Offset: 0x003D2E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveView EvolveView
		{
			get
			{
				if (this.dataCase_ != SurvivorsOpData.DataOneofCase.EvolveView)
				{
					return null;
				}
				return (EvolveView)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SurvivorsOpData.DataOneofCase.None : SurvivorsOpData.DataOneofCase.EvolveView);
			}
		}

		// Token: 0x1700590B RID: 22795
		// (get) Token: 0x0601A49C RID: 107676 RVA: 0x003D4CA2 File Offset: 0x003D2EA2
		// (set) Token: 0x0601A49D RID: 107677 RVA: 0x003D4CBA File Offset: 0x003D2EBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResultView ResultView
		{
			get
			{
				if (this.dataCase_ != SurvivorsOpData.DataOneofCase.ResultView)
				{
					return null;
				}
				return (ResultView)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SurvivorsOpData.DataOneofCase.None : SurvivorsOpData.DataOneofCase.ResultView);
			}
		}

		// Token: 0x1700590C RID: 22796
		// (get) Token: 0x0601A49E RID: 107678 RVA: 0x003D4CD0 File Offset: 0x003D2ED0
		// (set) Token: 0x0601A49F RID: 107679 RVA: 0x003D4CE8 File Offset: 0x003D2EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleOrWeaponUpView RoleOrWeaponUpView
		{
			get
			{
				if (this.dataCase_ != SurvivorsOpData.DataOneofCase.RoleOrWeaponUpView)
				{
					return null;
				}
				return (RoleOrWeaponUpView)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? SurvivorsOpData.DataOneofCase.None : SurvivorsOpData.DataOneofCase.RoleOrWeaponUpView);
			}
		}

		// Token: 0x1700590D RID: 22797
		// (get) Token: 0x0601A4A0 RID: 107680 RVA: 0x003D4CFE File Offset: 0x003D2EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpData.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x0601A4A1 RID: 107681 RVA: 0x003D4D06 File Offset: 0x003D2F06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = SurvivorsOpData.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x0601A4A2 RID: 107682 RVA: 0x003D4D16 File Offset: 0x003D2F16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsOpData);
		}

		// Token: 0x0601A4A3 RID: 107683 RVA: 0x003D4D24 File Offset: 0x003D2F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsOpData other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this.TokenAwardView, other.TokenAwardView) && object.Equals(this.TokenSelectView, other.TokenSelectView) && object.Equals(this.WeaponSelectView, other.WeaponSelectView) && object.Equals(this.ShopView, other.ShopView) && object.Equals(this.EvolveView, other.EvolveView) && object.Equals(this.ResultView, other.ResultView) && object.Equals(this.RoleOrWeaponUpView, other.RoleOrWeaponUpView) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A4A4 RID: 107684 RVA: 0x003D4E00 File Offset: 0x003D3000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.dataCase_ == SurvivorsOpData.DataOneofCase.TokenAwardView)
			{
				num ^= this.TokenAwardView.GetHashCode();
			}
			if (this.dataCase_ == SurvivorsOpData.DataOneofCase.TokenSelectView)
			{
				num ^= this.TokenSelectView.GetHashCode();
			}
			if (this.dataCase_ == SurvivorsOpData.DataOneofCase.WeaponSelectView)
			{
				num ^= this.WeaponSelectView.GetHashCode();
			}
			if (this.dataCase_ == SurvivorsOpData.DataOneofCase.ShopView)
			{
				num ^= this.ShopView.GetHashCode();
			}
			if (this.dataCase_ == SurvivorsOpData.DataOneofCase.EvolveView)
			{
				num ^= this.EvolveView.GetHashCode();
			}
			if (this.dataCase_ == SurvivorsOpData.DataOneofCase.ResultView)
			{
				num ^= this.ResultView.GetHashCode();
			}
			if (this.dataCase_ == SurvivorsOpData.DataOneofCase.RoleOrWeaponUpView)
			{
				num ^= this.RoleOrWeaponUpView.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A4A5 RID: 107685 RVA: 0x003D4EE9 File Offset: 0x003D30E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A4A6 RID: 107686 RVA: 0x003D4EF6 File Offset: 0x003D30F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A4A7 RID: 107687 RVA: 0x003D4F00 File Offset: 0x003D3100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dataCase_ == SurvivorsOpData.DataOneofCase.TokenAwardView)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.TokenAwardView);
			}
			if (this.dataCase_ == SurvivorsOpData.DataOneofCase.TokenSelectView)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.TokenSelectView);
			}
			if (this.dataCase_ == SurvivorsOpData.DataOneofCase.WeaponSelectView)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.WeaponSelectView);
			}
			if (this.dataCase_ == SurvivorsOpData.DataOneofCase.ShopView)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ShopView);
			}
			if (this.dataCase_ == SurvivorsOpData.DataOneofCase.EvolveView)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.EvolveView);
			}
			if (this.dataCase_ == SurvivorsOpData.DataOneofCase.ResultView)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.ResultView);
			}
			if (this.dataCase_ == SurvivorsOpData.DataOneofCase.RoleOrWeaponUpView)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.RoleOrWeaponUpView);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(192, 62);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A4A8 RID: 107688 RVA: 0x003D5010 File Offset: 0x003D3210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.dataCase_ == SurvivorsOpData.DataOneofCase.TokenAwardView)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TokenAwardView);
			}
			if (this.dataCase_ == SurvivorsOpData.DataOneofCase.TokenSelectView)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TokenSelectView);
			}
			if (this.dataCase_ == SurvivorsOpData.DataOneofCase.WeaponSelectView)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WeaponSelectView);
			}
			if (this.dataCase_ == SurvivorsOpData.DataOneofCase.ShopView)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ShopView);
			}
			if (this.dataCase_ == SurvivorsOpData.DataOneofCase.EvolveView)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EvolveView);
			}
			if (this.dataCase_ == SurvivorsOpData.DataOneofCase.ResultView)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ResultView);
			}
			if (this.dataCase_ == SurvivorsOpData.DataOneofCase.RoleOrWeaponUpView)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleOrWeaponUpView);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A4A9 RID: 107689 RVA: 0x003D5100 File Offset: 0x003D3300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsOpData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			switch (other.DataCase)
			{
			case SurvivorsOpData.DataOneofCase.TokenAwardView:
				if (this.TokenAwardView == null)
				{
					this.TokenAwardView = new TokenAwardView();
				}
				this.TokenAwardView.MergeFrom(other.TokenAwardView);
				break;
			case SurvivorsOpData.DataOneofCase.TokenSelectView:
				if (this.TokenSelectView == null)
				{
					this.TokenSelectView = new TokenSelectView();
				}
				this.TokenSelectView.MergeFrom(other.TokenSelectView);
				break;
			case SurvivorsOpData.DataOneofCase.WeaponSelectView:
				if (this.WeaponSelectView == null)
				{
					this.WeaponSelectView = new WeaponSelectView();
				}
				this.WeaponSelectView.MergeFrom(other.WeaponSelectView);
				break;
			case SurvivorsOpData.DataOneofCase.ShopView:
				if (this.ShopView == null)
				{
					this.ShopView = new ShopView();
				}
				this.ShopView.MergeFrom(other.ShopView);
				break;
			case SurvivorsOpData.DataOneofCase.EvolveView:
				if (this.EvolveView == null)
				{
					this.EvolveView = new EvolveView();
				}
				this.EvolveView.MergeFrom(other.EvolveView);
				break;
			case SurvivorsOpData.DataOneofCase.ResultView:
				if (this.ResultView == null)
				{
					this.ResultView = new ResultView();
				}
				this.ResultView.MergeFrom(other.ResultView);
				break;
			case SurvivorsOpData.DataOneofCase.RoleOrWeaponUpView:
				if (this.RoleOrWeaponUpView == null)
				{
					this.RoleOrWeaponUpView = new RoleOrWeaponUpView();
				}
				this.RoleOrWeaponUpView.MergeFrom(other.RoleOrWeaponUpView);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A4AA RID: 107690 RVA: 0x003D5281 File Offset: 0x003D3481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A4AB RID: 107691 RVA: 0x003D528C File Offset: 0x003D348C
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
				if (num <= 34U)
				{
					if (num <= 18U)
					{
						if (num == 10U)
						{
							TokenAwardView tokenAwardView = new TokenAwardView();
							if (this.dataCase_ == SurvivorsOpData.DataOneofCase.TokenAwardView)
							{
								tokenAwardView.MergeFrom(this.TokenAwardView);
							}
							input.ReadMessage(tokenAwardView);
							this.TokenAwardView = tokenAwardView;
							continue;
						}
						if (num == 18U)
						{
							TokenSelectView tokenSelectView = new TokenSelectView();
							if (this.dataCase_ == SurvivorsOpData.DataOneofCase.TokenSelectView)
							{
								tokenSelectView.MergeFrom(this.TokenSelectView);
							}
							input.ReadMessage(tokenSelectView);
							this.TokenSelectView = tokenSelectView;
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							WeaponSelectView weaponSelectView = new WeaponSelectView();
							if (this.dataCase_ == SurvivorsOpData.DataOneofCase.WeaponSelectView)
							{
								weaponSelectView.MergeFrom(this.WeaponSelectView);
							}
							input.ReadMessage(weaponSelectView);
							this.WeaponSelectView = weaponSelectView;
							continue;
						}
						if (num == 34U)
						{
							ShopView shopView = new ShopView();
							if (this.dataCase_ == SurvivorsOpData.DataOneofCase.ShopView)
							{
								shopView.MergeFrom(this.ShopView);
							}
							input.ReadMessage(shopView);
							this.ShopView = shopView;
							continue;
						}
					}
				}
				else if (num <= 58U)
				{
					if (num == 50U)
					{
						EvolveView evolveView = new EvolveView();
						if (this.dataCase_ == SurvivorsOpData.DataOneofCase.EvolveView)
						{
							evolveView.MergeFrom(this.EvolveView);
						}
						input.ReadMessage(evolveView);
						this.EvolveView = evolveView;
						continue;
					}
					if (num == 58U)
					{
						ResultView resultView = new ResultView();
						if (this.dataCase_ == SurvivorsOpData.DataOneofCase.ResultView)
						{
							resultView.MergeFrom(this.ResultView);
						}
						input.ReadMessage(resultView);
						this.ResultView = resultView;
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						RoleOrWeaponUpView roleOrWeaponUpView = new RoleOrWeaponUpView();
						if (this.dataCase_ == SurvivorsOpData.DataOneofCase.RoleOrWeaponUpView)
						{
							roleOrWeaponUpView.MergeFrom(this.RoleOrWeaponUpView);
						}
						input.ReadMessage(roleOrWeaponUpView);
						this.RoleOrWeaponUpView = roleOrWeaponUpView;
						continue;
					}
					if (num == 8000U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009A82 RID: 39554
		private static readonly MessageParser<SurvivorsOpData> _parser = new MessageParser<SurvivorsOpData>(() => new SurvivorsOpData());

		// Token: 0x04009A83 RID: 39555
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A84 RID: 39556
		public const int IncIdFieldNumber = 1000;

		// Token: 0x04009A85 RID: 39557
		private int incId_;

		// Token: 0x04009A86 RID: 39558
		public const int TokenAwardViewFieldNumber = 1;

		// Token: 0x04009A87 RID: 39559
		public const int TokenSelectViewFieldNumber = 2;

		// Token: 0x04009A88 RID: 39560
		public const int WeaponSelectViewFieldNumber = 3;

		// Token: 0x04009A89 RID: 39561
		public const int ShopViewFieldNumber = 4;

		// Token: 0x04009A8A RID: 39562
		public const int EvolveViewFieldNumber = 6;

		// Token: 0x04009A8B RID: 39563
		public const int ResultViewFieldNumber = 7;

		// Token: 0x04009A8C RID: 39564
		public const int RoleOrWeaponUpViewFieldNumber = 8;

		// Token: 0x04009A8D RID: 39565
		private object data_;

		// Token: 0x04009A8E RID: 39566
		private SurvivorsOpData.DataOneofCase dataCase_;

		// Token: 0x02001A4E RID: 6734
		public enum DataOneofCase
		{
			// Token: 0x0400CFB8 RID: 53176
			None,
			// Token: 0x0400CFB9 RID: 53177
			TokenAwardView,
			// Token: 0x0400CFBA RID: 53178
			TokenSelectView,
			// Token: 0x0400CFBB RID: 53179
			WeaponSelectView,
			// Token: 0x0400CFBC RID: 53180
			ShopView,
			// Token: 0x0400CFBD RID: 53181
			EvolveView = 6,
			// Token: 0x0400CFBE RID: 53182
			ResultView,
			// Token: 0x0400CFBF RID: 53183
			RoleOrWeaponUpView
		}
	}
}
