using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001213 RID: 4627
	public sealed class ShowViewOp : IMessage<ShowViewOp>, IMessage, IEquatable<ShowViewOp>, IDeepCloneable<ShowViewOp>, IBufferMessage
	{
		// Token: 0x06018A85 RID: 100997 RVA: 0x00395CD4 File Offset: 0x00393ED4
		[NullableContext(1)]
		public static ShowViewOp Create()
		{
			return new ShowViewOp();
		}

		// Token: 0x17005311 RID: 21265
		// (get) Token: 0x06018A86 RID: 100998 RVA: 0x00395CDB File Offset: 0x00393EDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005312 RID: 21266
		// (get) Token: 0x06018A87 RID: 100999 RVA: 0x00395CDE File Offset: 0x00393EDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShowViewOp.Descriptor;
			}
		}

		// Token: 0x06018A88 RID: 101000 RVA: 0x00395CE5 File Offset: 0x00393EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowViewOp()
		{
		}

		// Token: 0x06018A89 RID: 101001 RVA: 0x00395CF0 File Offset: 0x00393EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowViewOp(ShowViewOp other) : this()
		{
			this.showViewType_ = other.showViewType_;
			switch (other.DataCase)
			{
			case ShowViewOp.DataOneofCase.GridTakeView:
				this.GridTakeView = other.GridTakeView.Clone();
				break;
			case ShowViewOp.DataOneofCase.AddRoleView:
				this.AddRoleView = other.AddRoleView.Clone();
				break;
			case ShowViewOp.DataOneofCase.RoleBuffUnlockView:
				this.RoleBuffUnlockView = other.RoleBuffUnlockView.Clone();
				break;
			case ShowViewOp.DataOneofCase.InstResultView:
				this.InstResultView = other.InstResultView.Clone();
				break;
			case ShowViewOp.DataOneofCase.RoleBondInfoView:
				this.RoleBondInfoView = other.RoleBondInfoView.Clone();
				break;
			case ShowViewOp.DataOneofCase.AddTokenView:
				this.AddTokenView = other.AddTokenView.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018A8A RID: 101002 RVA: 0x00395DC1 File Offset: 0x00393FC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowViewOp Clone()
		{
			return new ShowViewOp(this);
		}

		// Token: 0x17005313 RID: 21267
		// (get) Token: 0x06018A8B RID: 101003 RVA: 0x00395DC9 File Offset: 0x00393FC9
		// (set) Token: 0x06018A8C RID: 101004 RVA: 0x00395DD1 File Offset: 0x00393FD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowViewType ShowViewType
		{
			get
			{
				return this.showViewType_;
			}
			set
			{
				this.showViewType_ = value;
			}
		}

		// Token: 0x17005314 RID: 21268
		// (get) Token: 0x06018A8D RID: 101005 RVA: 0x00395DDA File Offset: 0x00393FDA
		// (set) Token: 0x06018A8E RID: 101006 RVA: 0x00395DF2 File Offset: 0x00393FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridTakeView GridTakeView
		{
			get
			{
				if (this.dataCase_ != ShowViewOp.DataOneofCase.GridTakeView)
				{
					return null;
				}
				return (GridTakeView)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ShowViewOp.DataOneofCase.None : ShowViewOp.DataOneofCase.GridTakeView);
			}
		}

		// Token: 0x17005315 RID: 21269
		// (get) Token: 0x06018A8F RID: 101007 RVA: 0x00395E08 File Offset: 0x00394008
		// (set) Token: 0x06018A90 RID: 101008 RVA: 0x00395E20 File Offset: 0x00394020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddRoleView AddRoleView
		{
			get
			{
				if (this.dataCase_ != ShowViewOp.DataOneofCase.AddRoleView)
				{
					return null;
				}
				return (AddRoleView)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ShowViewOp.DataOneofCase.None : ShowViewOp.DataOneofCase.AddRoleView);
			}
		}

		// Token: 0x17005316 RID: 21270
		// (get) Token: 0x06018A91 RID: 101009 RVA: 0x00395E36 File Offset: 0x00394036
		// (set) Token: 0x06018A92 RID: 101010 RVA: 0x00395E4E File Offset: 0x0039404E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBuffUnlockView RoleBuffUnlockView
		{
			get
			{
				if (this.dataCase_ != ShowViewOp.DataOneofCase.RoleBuffUnlockView)
				{
					return null;
				}
				return (RoleBuffUnlockView)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ShowViewOp.DataOneofCase.None : ShowViewOp.DataOneofCase.RoleBuffUnlockView);
			}
		}

		// Token: 0x17005317 RID: 21271
		// (get) Token: 0x06018A93 RID: 101011 RVA: 0x00395E64 File Offset: 0x00394064
		// (set) Token: 0x06018A94 RID: 101012 RVA: 0x00395E7C File Offset: 0x0039407C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstResultView InstResultView
		{
			get
			{
				if (this.dataCase_ != ShowViewOp.DataOneofCase.InstResultView)
				{
					return null;
				}
				return (InstResultView)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ShowViewOp.DataOneofCase.None : ShowViewOp.DataOneofCase.InstResultView);
			}
		}

		// Token: 0x17005318 RID: 21272
		// (get) Token: 0x06018A95 RID: 101013 RVA: 0x00395E92 File Offset: 0x00394092
		// (set) Token: 0x06018A96 RID: 101014 RVA: 0x00395EAA File Offset: 0x003940AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBondInfoView RoleBondInfoView
		{
			get
			{
				if (this.dataCase_ != ShowViewOp.DataOneofCase.RoleBondInfoView)
				{
					return null;
				}
				return (RoleBondInfoView)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ShowViewOp.DataOneofCase.None : ShowViewOp.DataOneofCase.RoleBondInfoView);
			}
		}

		// Token: 0x17005319 RID: 21273
		// (get) Token: 0x06018A97 RID: 101015 RVA: 0x00395EC0 File Offset: 0x003940C0
		// (set) Token: 0x06018A98 RID: 101016 RVA: 0x00395ED8 File Offset: 0x003940D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTokenView AddTokenView
		{
			get
			{
				if (this.dataCase_ != ShowViewOp.DataOneofCase.AddTokenView)
				{
					return null;
				}
				return (AddTokenView)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ShowViewOp.DataOneofCase.None : ShowViewOp.DataOneofCase.AddTokenView);
			}
		}

		// Token: 0x1700531A RID: 21274
		// (get) Token: 0x06018A99 RID: 101017 RVA: 0x00395EEE File Offset: 0x003940EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowViewOp.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06018A9A RID: 101018 RVA: 0x00395EF6 File Offset: 0x003940F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = ShowViewOp.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06018A9B RID: 101019 RVA: 0x00395F06 File Offset: 0x00394106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShowViewOp);
		}

		// Token: 0x06018A9C RID: 101020 RVA: 0x00395F14 File Offset: 0x00394114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShowViewOp other)
		{
			return other != null && (other == this || (this.ShowViewType == other.ShowViewType && object.Equals(this.GridTakeView, other.GridTakeView) && object.Equals(this.AddRoleView, other.AddRoleView) && object.Equals(this.RoleBuffUnlockView, other.RoleBuffUnlockView) && object.Equals(this.InstResultView, other.InstResultView) && object.Equals(this.RoleBondInfoView, other.RoleBondInfoView) && object.Equals(this.AddTokenView, other.AddTokenView) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018A9D RID: 101021 RVA: 0x00395FDC File Offset: 0x003941DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShowViewType != ShowViewType.None)
			{
				num ^= this.ShowViewType.GetHashCode();
			}
			if (this.dataCase_ == ShowViewOp.DataOneofCase.GridTakeView)
			{
				num ^= this.GridTakeView.GetHashCode();
			}
			if (this.dataCase_ == ShowViewOp.DataOneofCase.AddRoleView)
			{
				num ^= this.AddRoleView.GetHashCode();
			}
			if (this.dataCase_ == ShowViewOp.DataOneofCase.RoleBuffUnlockView)
			{
				num ^= this.RoleBuffUnlockView.GetHashCode();
			}
			if (this.dataCase_ == ShowViewOp.DataOneofCase.InstResultView)
			{
				num ^= this.InstResultView.GetHashCode();
			}
			if (this.dataCase_ == ShowViewOp.DataOneofCase.RoleBondInfoView)
			{
				num ^= this.RoleBondInfoView.GetHashCode();
			}
			if (this.dataCase_ == ShowViewOp.DataOneofCase.AddTokenView)
			{
				num ^= this.AddTokenView.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018A9E RID: 101022 RVA: 0x003960B4 File Offset: 0x003942B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018A9F RID: 101023 RVA: 0x003960C1 File Offset: 0x003942C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018AA0 RID: 101024 RVA: 0x003960CC File Offset: 0x003942CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dataCase_ == ShowViewOp.DataOneofCase.GridTakeView)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GridTakeView);
			}
			if (this.dataCase_ == ShowViewOp.DataOneofCase.AddRoleView)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.AddRoleView);
			}
			if (this.dataCase_ == ShowViewOp.DataOneofCase.RoleBuffUnlockView)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RoleBuffUnlockView);
			}
			if (this.dataCase_ == ShowViewOp.DataOneofCase.InstResultView)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.InstResultView);
			}
			if (this.dataCase_ == ShowViewOp.DataOneofCase.RoleBondInfoView)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RoleBondInfoView);
			}
			if (this.dataCase_ == ShowViewOp.DataOneofCase.AddTokenView)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.AddTokenView);
			}
			if (this.ShowViewType != ShowViewType.None)
			{
				output.WriteRawTag(192, 62);
				output.WriteEnum((int)this.ShowViewType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018AA1 RID: 101025 RVA: 0x003961BC File Offset: 0x003943BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShowViewType != ShowViewType.None)
			{
				num += 2 + CodedOutputStream.ComputeEnumSize((int)this.ShowViewType);
			}
			if (this.dataCase_ == ShowViewOp.DataOneofCase.GridTakeView)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GridTakeView);
			}
			if (this.dataCase_ == ShowViewOp.DataOneofCase.AddRoleView)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AddRoleView);
			}
			if (this.dataCase_ == ShowViewOp.DataOneofCase.RoleBuffUnlockView)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleBuffUnlockView);
			}
			if (this.dataCase_ == ShowViewOp.DataOneofCase.InstResultView)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InstResultView);
			}
			if (this.dataCase_ == ShowViewOp.DataOneofCase.RoleBondInfoView)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleBondInfoView);
			}
			if (this.dataCase_ == ShowViewOp.DataOneofCase.AddTokenView)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AddTokenView);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018AA2 RID: 101026 RVA: 0x00396290 File Offset: 0x00394490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShowViewOp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShowViewType != ShowViewType.None)
			{
				this.ShowViewType = other.ShowViewType;
			}
			switch (other.DataCase)
			{
			case ShowViewOp.DataOneofCase.GridTakeView:
				if (this.GridTakeView == null)
				{
					this.GridTakeView = new GridTakeView();
				}
				this.GridTakeView.MergeFrom(other.GridTakeView);
				break;
			case ShowViewOp.DataOneofCase.AddRoleView:
				if (this.AddRoleView == null)
				{
					this.AddRoleView = new AddRoleView();
				}
				this.AddRoleView.MergeFrom(other.AddRoleView);
				break;
			case ShowViewOp.DataOneofCase.RoleBuffUnlockView:
				if (this.RoleBuffUnlockView == null)
				{
					this.RoleBuffUnlockView = new RoleBuffUnlockView();
				}
				this.RoleBuffUnlockView.MergeFrom(other.RoleBuffUnlockView);
				break;
			case ShowViewOp.DataOneofCase.InstResultView:
				if (this.InstResultView == null)
				{
					this.InstResultView = new InstResultView();
				}
				this.InstResultView.MergeFrom(other.InstResultView);
				break;
			case ShowViewOp.DataOneofCase.RoleBondInfoView:
				if (this.RoleBondInfoView == null)
				{
					this.RoleBondInfoView = new RoleBondInfoView();
				}
				this.RoleBondInfoView.MergeFrom(other.RoleBondInfoView);
				break;
			case ShowViewOp.DataOneofCase.AddTokenView:
				if (this.AddTokenView == null)
				{
					this.AddTokenView = new AddTokenView();
				}
				this.AddTokenView.MergeFrom(other.AddTokenView);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018AA3 RID: 101027 RVA: 0x003963E8 File Offset: 0x003945E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018AA4 RID: 101028 RVA: 0x003963F4 File Offset: 0x003945F4
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
					if (num == 10U)
					{
						GridTakeView gridTakeView = new GridTakeView();
						if (this.dataCase_ == ShowViewOp.DataOneofCase.GridTakeView)
						{
							gridTakeView.MergeFrom(this.GridTakeView);
						}
						input.ReadMessage(gridTakeView);
						this.GridTakeView = gridTakeView;
						continue;
					}
					if (num == 18U)
					{
						AddRoleView addRoleView = new AddRoleView();
						if (this.dataCase_ == ShowViewOp.DataOneofCase.AddRoleView)
						{
							addRoleView.MergeFrom(this.AddRoleView);
						}
						input.ReadMessage(addRoleView);
						this.AddRoleView = addRoleView;
						continue;
					}
					if (num == 34U)
					{
						RoleBuffUnlockView roleBuffUnlockView = new RoleBuffUnlockView();
						if (this.dataCase_ == ShowViewOp.DataOneofCase.RoleBuffUnlockView)
						{
							roleBuffUnlockView.MergeFrom(this.RoleBuffUnlockView);
						}
						input.ReadMessage(roleBuffUnlockView);
						this.RoleBuffUnlockView = roleBuffUnlockView;
						continue;
					}
				}
				else if (num <= 58U)
				{
					if (num == 42U)
					{
						InstResultView instResultView = new InstResultView();
						if (this.dataCase_ == ShowViewOp.DataOneofCase.InstResultView)
						{
							instResultView.MergeFrom(this.InstResultView);
						}
						input.ReadMessage(instResultView);
						this.InstResultView = instResultView;
						continue;
					}
					if (num == 58U)
					{
						RoleBondInfoView roleBondInfoView = new RoleBondInfoView();
						if (this.dataCase_ == ShowViewOp.DataOneofCase.RoleBondInfoView)
						{
							roleBondInfoView.MergeFrom(this.RoleBondInfoView);
						}
						input.ReadMessage(roleBondInfoView);
						this.RoleBondInfoView = roleBondInfoView;
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						AddTokenView addTokenView = new AddTokenView();
						if (this.dataCase_ == ShowViewOp.DataOneofCase.AddTokenView)
						{
							addTokenView.MergeFrom(this.AddTokenView);
						}
						input.ReadMessage(addTokenView);
						this.AddTokenView = addTokenView;
						continue;
					}
					if (num == 8000U)
					{
						this.ShowViewType = (ShowViewType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040091A4 RID: 37284
		private UnknownFieldSet _unknownFields;

		// Token: 0x040091A5 RID: 37285
		public const int ShowViewTypeFieldNumber = 1000;

		// Token: 0x040091A6 RID: 37286
		private ShowViewType showViewType_;

		// Token: 0x040091A7 RID: 37287
		public const int GridTakeViewFieldNumber = 1;

		// Token: 0x040091A8 RID: 37288
		public const int AddRoleViewFieldNumber = 2;

		// Token: 0x040091A9 RID: 37289
		public const int RoleBuffUnlockViewFieldNumber = 4;

		// Token: 0x040091AA RID: 37290
		public const int InstResultViewFieldNumber = 5;

		// Token: 0x040091AB RID: 37291
		public const int RoleBondInfoViewFieldNumber = 7;

		// Token: 0x040091AC RID: 37292
		public const int AddTokenViewFieldNumber = 8;

		// Token: 0x040091AD RID: 37293
		private object data_;

		// Token: 0x040091AE RID: 37294
		private ShowViewOp.DataOneofCase dataCase_;

		// Token: 0x02001991 RID: 6545
		public enum DataOneofCase
		{
			// Token: 0x0400CA07 RID: 51719
			None,
			// Token: 0x0400CA08 RID: 51720
			GridTakeView,
			// Token: 0x0400CA09 RID: 51721
			AddRoleView,
			// Token: 0x0400CA0A RID: 51722
			RoleBuffUnlockView = 4,
			// Token: 0x0400CA0B RID: 51723
			InstResultView,
			// Token: 0x0400CA0C RID: 51724
			RoleBondInfoView = 7,
			// Token: 0x0400CA0D RID: 51725
			AddTokenView
		}
	}
}
