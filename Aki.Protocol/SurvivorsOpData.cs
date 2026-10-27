using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012D5 RID: 4821
	public sealed class SurvivorsOpData : IMessage<SurvivorsOpData>, IMessage, IEquatable<SurvivorsOpData>, IDeepCloneable<SurvivorsOpData>, IBufferMessage
	{
		// Token: 0x06019A53 RID: 105043 RVA: 0x003BA365 File Offset: 0x003B8565
		[NullableContext(1)]
		public static SurvivorsOpData Create()
		{
			return new SurvivorsOpData();
		}

		// Token: 0x17005681 RID: 22145
		// (get) Token: 0x06019A54 RID: 105044 RVA: 0x003BA36C File Offset: 0x003B856C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SurvivorsOpData> Parser
		{
			get
			{
				return SurvivorsOpData._parser;
			}
		}

		// Token: 0x17005682 RID: 22146
		// (get) Token: 0x06019A55 RID: 105045 RVA: 0x003BA373 File Offset: 0x003B8573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005683 RID: 22147
		// (get) Token: 0x06019A56 RID: 105046 RVA: 0x003BA376 File Offset: 0x003B8576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsOpData.Descriptor;
			}
		}

		// Token: 0x06019A57 RID: 105047 RVA: 0x003BA37D File Offset: 0x003B857D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpData()
		{
		}

		// Token: 0x06019A58 RID: 105048 RVA: 0x003BA388 File Offset: 0x003B8588
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

		// Token: 0x06019A59 RID: 105049 RVA: 0x003BA46F File Offset: 0x003B866F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpData Clone()
		{
			return new SurvivorsOpData(this);
		}

		// Token: 0x17005684 RID: 22148
		// (get) Token: 0x06019A5A RID: 105050 RVA: 0x003BA477 File Offset: 0x003B8677
		// (set) Token: 0x06019A5B RID: 105051 RVA: 0x003BA47F File Offset: 0x003B867F
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

		// Token: 0x17005685 RID: 22149
		// (get) Token: 0x06019A5C RID: 105052 RVA: 0x003BA488 File Offset: 0x003B8688
		// (set) Token: 0x06019A5D RID: 105053 RVA: 0x003BA4A0 File Offset: 0x003B86A0
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

		// Token: 0x17005686 RID: 22150
		// (get) Token: 0x06019A5E RID: 105054 RVA: 0x003BA4B6 File Offset: 0x003B86B6
		// (set) Token: 0x06019A5F RID: 105055 RVA: 0x003BA4CE File Offset: 0x003B86CE
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

		// Token: 0x17005687 RID: 22151
		// (get) Token: 0x06019A60 RID: 105056 RVA: 0x003BA4E4 File Offset: 0x003B86E4
		// (set) Token: 0x06019A61 RID: 105057 RVA: 0x003BA4FC File Offset: 0x003B86FC
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

		// Token: 0x17005688 RID: 22152
		// (get) Token: 0x06019A62 RID: 105058 RVA: 0x003BA512 File Offset: 0x003B8712
		// (set) Token: 0x06019A63 RID: 105059 RVA: 0x003BA52A File Offset: 0x003B872A
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

		// Token: 0x17005689 RID: 22153
		// (get) Token: 0x06019A64 RID: 105060 RVA: 0x003BA540 File Offset: 0x003B8740
		// (set) Token: 0x06019A65 RID: 105061 RVA: 0x003BA558 File Offset: 0x003B8758
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

		// Token: 0x1700568A RID: 22154
		// (get) Token: 0x06019A66 RID: 105062 RVA: 0x003BA56E File Offset: 0x003B876E
		// (set) Token: 0x06019A67 RID: 105063 RVA: 0x003BA586 File Offset: 0x003B8786
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

		// Token: 0x1700568B RID: 22155
		// (get) Token: 0x06019A68 RID: 105064 RVA: 0x003BA59C File Offset: 0x003B879C
		// (set) Token: 0x06019A69 RID: 105065 RVA: 0x003BA5B4 File Offset: 0x003B87B4
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

		// Token: 0x1700568C RID: 22156
		// (get) Token: 0x06019A6A RID: 105066 RVA: 0x003BA5CA File Offset: 0x003B87CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpData.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06019A6B RID: 105067 RVA: 0x003BA5D2 File Offset: 0x003B87D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = SurvivorsOpData.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06019A6C RID: 105068 RVA: 0x003BA5E2 File Offset: 0x003B87E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsOpData);
		}

		// Token: 0x06019A6D RID: 105069 RVA: 0x003BA5F0 File Offset: 0x003B87F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsOpData other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this.TokenAwardView, other.TokenAwardView) && object.Equals(this.TokenSelectView, other.TokenSelectView) && object.Equals(this.WeaponSelectView, other.WeaponSelectView) && object.Equals(this.ShopView, other.ShopView) && object.Equals(this.EvolveView, other.EvolveView) && object.Equals(this.ResultView, other.ResultView) && object.Equals(this.RoleOrWeaponUpView, other.RoleOrWeaponUpView) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019A6E RID: 105070 RVA: 0x003BA6CC File Offset: 0x003B88CC
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

		// Token: 0x06019A6F RID: 105071 RVA: 0x003BA7B5 File Offset: 0x003B89B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019A70 RID: 105072 RVA: 0x003BA7C2 File Offset: 0x003B89C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019A71 RID: 105073 RVA: 0x003BA7CC File Offset: 0x003B89CC
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

		// Token: 0x06019A72 RID: 105074 RVA: 0x003BA8DC File Offset: 0x003B8ADC
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

		// Token: 0x06019A73 RID: 105075 RVA: 0x003BA9CC File Offset: 0x003B8BCC
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

		// Token: 0x06019A74 RID: 105076 RVA: 0x003BAB4D File Offset: 0x003B8D4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019A75 RID: 105077 RVA: 0x003BAB58 File Offset: 0x003B8D58
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

		// Token: 0x04009658 RID: 38488
		private static readonly MessageParser<SurvivorsOpData> _parser = new MessageParser<SurvivorsOpData>(() => new SurvivorsOpData());

		// Token: 0x04009659 RID: 38489
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400965A RID: 38490
		public const int IncIdFieldNumber = 1000;

		// Token: 0x0400965B RID: 38491
		private int incId_;

		// Token: 0x0400965C RID: 38492
		public const int TokenAwardViewFieldNumber = 1;

		// Token: 0x0400965D RID: 38493
		public const int TokenSelectViewFieldNumber = 2;

		// Token: 0x0400965E RID: 38494
		public const int WeaponSelectViewFieldNumber = 3;

		// Token: 0x0400965F RID: 38495
		public const int ShopViewFieldNumber = 4;

		// Token: 0x04009660 RID: 38496
		public const int EvolveViewFieldNumber = 6;

		// Token: 0x04009661 RID: 38497
		public const int ResultViewFieldNumber = 7;

		// Token: 0x04009662 RID: 38498
		public const int RoleOrWeaponUpViewFieldNumber = 8;

		// Token: 0x04009663 RID: 38499
		private object data_;

		// Token: 0x04009664 RID: 38500
		private SurvivorsOpData.DataOneofCase dataCase_;

		// Token: 0x020019B0 RID: 6576
		public enum DataOneofCase
		{
			// Token: 0x0400CA51 RID: 51793
			None,
			// Token: 0x0400CA52 RID: 51794
			TokenAwardView,
			// Token: 0x0400CA53 RID: 51795
			TokenSelectView,
			// Token: 0x0400CA54 RID: 51796
			WeaponSelectView,
			// Token: 0x0400CA55 RID: 51797
			ShopView,
			// Token: 0x0400CA56 RID: 51798
			EvolveView = 6,
			// Token: 0x0400CA57 RID: 51799
			ResultView,
			// Token: 0x0400CA58 RID: 51800
			RoleOrWeaponUpView
		}
	}
}
