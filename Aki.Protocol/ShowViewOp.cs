using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200124F RID: 4687
	public sealed class ShowViewOp : IMessage<ShowViewOp>, IMessage, IEquatable<ShowViewOp>, IDeepCloneable<ShowViewOp>, IBufferMessage
	{
		// Token: 0x0601905F RID: 102495 RVA: 0x003A5B7C File Offset: 0x003A3D7C
		[NullableContext(1)]
		public static ShowViewOp Create()
		{
			return new ShowViewOp();
		}

		// Token: 0x1700548E RID: 21646
		// (get) Token: 0x06019060 RID: 102496 RVA: 0x003A5B83 File Offset: 0x003A3D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700548F RID: 21647
		// (get) Token: 0x06019061 RID: 102497 RVA: 0x003A5B86 File Offset: 0x003A3D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShowViewOp.Descriptor;
			}
		}

		// Token: 0x06019062 RID: 102498 RVA: 0x003A5B8D File Offset: 0x003A3D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowViewOp()
		{
		}

		// Token: 0x06019063 RID: 102499 RVA: 0x003A5B98 File Offset: 0x003A3D98
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

		// Token: 0x06019064 RID: 102500 RVA: 0x003A5C69 File Offset: 0x003A3E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowViewOp Clone()
		{
			return new ShowViewOp(this);
		}

		// Token: 0x17005490 RID: 21648
		// (get) Token: 0x06019065 RID: 102501 RVA: 0x003A5C71 File Offset: 0x003A3E71
		// (set) Token: 0x06019066 RID: 102502 RVA: 0x003A5C79 File Offset: 0x003A3E79
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

		// Token: 0x17005491 RID: 21649
		// (get) Token: 0x06019067 RID: 102503 RVA: 0x003A5C82 File Offset: 0x003A3E82
		// (set) Token: 0x06019068 RID: 102504 RVA: 0x003A5C9A File Offset: 0x003A3E9A
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

		// Token: 0x17005492 RID: 21650
		// (get) Token: 0x06019069 RID: 102505 RVA: 0x003A5CB0 File Offset: 0x003A3EB0
		// (set) Token: 0x0601906A RID: 102506 RVA: 0x003A5CC8 File Offset: 0x003A3EC8
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

		// Token: 0x17005493 RID: 21651
		// (get) Token: 0x0601906B RID: 102507 RVA: 0x003A5CDE File Offset: 0x003A3EDE
		// (set) Token: 0x0601906C RID: 102508 RVA: 0x003A5CF6 File Offset: 0x003A3EF6
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

		// Token: 0x17005494 RID: 21652
		// (get) Token: 0x0601906D RID: 102509 RVA: 0x003A5D0C File Offset: 0x003A3F0C
		// (set) Token: 0x0601906E RID: 102510 RVA: 0x003A5D24 File Offset: 0x003A3F24
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

		// Token: 0x17005495 RID: 21653
		// (get) Token: 0x0601906F RID: 102511 RVA: 0x003A5D3A File Offset: 0x003A3F3A
		// (set) Token: 0x06019070 RID: 102512 RVA: 0x003A5D52 File Offset: 0x003A3F52
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

		// Token: 0x17005496 RID: 21654
		// (get) Token: 0x06019071 RID: 102513 RVA: 0x003A5D68 File Offset: 0x003A3F68
		// (set) Token: 0x06019072 RID: 102514 RVA: 0x003A5D80 File Offset: 0x003A3F80
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

		// Token: 0x17005497 RID: 21655
		// (get) Token: 0x06019073 RID: 102515 RVA: 0x003A5D96 File Offset: 0x003A3F96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowViewOp.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06019074 RID: 102516 RVA: 0x003A5D9E File Offset: 0x003A3F9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = ShowViewOp.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06019075 RID: 102517 RVA: 0x003A5DAE File Offset: 0x003A3FAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShowViewOp);
		}

		// Token: 0x06019076 RID: 102518 RVA: 0x003A5DBC File Offset: 0x003A3FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShowViewOp other)
		{
			return other != null && (other == this || (this.ShowViewType == other.ShowViewType && object.Equals(this.GridTakeView, other.GridTakeView) && object.Equals(this.AddRoleView, other.AddRoleView) && object.Equals(this.RoleBuffUnlockView, other.RoleBuffUnlockView) && object.Equals(this.InstResultView, other.InstResultView) && object.Equals(this.RoleBondInfoView, other.RoleBondInfoView) && object.Equals(this.AddTokenView, other.AddTokenView) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019077 RID: 102519 RVA: 0x003A5E84 File Offset: 0x003A4084
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

		// Token: 0x06019078 RID: 102520 RVA: 0x003A5F5C File Offset: 0x003A415C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019079 RID: 102521 RVA: 0x003A5F69 File Offset: 0x003A4169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601907A RID: 102522 RVA: 0x003A5F74 File Offset: 0x003A4174
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

		// Token: 0x0601907B RID: 102523 RVA: 0x003A6064 File Offset: 0x003A4264
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

		// Token: 0x0601907C RID: 102524 RVA: 0x003A6138 File Offset: 0x003A4338
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

		// Token: 0x0601907D RID: 102525 RVA: 0x003A6290 File Offset: 0x003A4490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601907E RID: 102526 RVA: 0x003A629C File Offset: 0x003A449C
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

		// Token: 0x04009455 RID: 37973
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009456 RID: 37974
		public const int ShowViewTypeFieldNumber = 1000;

		// Token: 0x04009457 RID: 37975
		private ShowViewType showViewType_;

		// Token: 0x04009458 RID: 37976
		public const int GridTakeViewFieldNumber = 1;

		// Token: 0x04009459 RID: 37977
		public const int AddRoleViewFieldNumber = 2;

		// Token: 0x0400945A RID: 37978
		public const int RoleBuffUnlockViewFieldNumber = 4;

		// Token: 0x0400945B RID: 37979
		public const int InstResultViewFieldNumber = 5;

		// Token: 0x0400945C RID: 37980
		public const int RoleBondInfoViewFieldNumber = 7;

		// Token: 0x0400945D RID: 37981
		public const int AddTokenViewFieldNumber = 8;

		// Token: 0x0400945E RID: 37982
		private object data_;

		// Token: 0x0400945F RID: 37983
		private ShowViewOp.DataOneofCase dataCase_;

		// Token: 0x02001A1D RID: 6685
		public enum DataOneofCase
		{
			// Token: 0x0400CF52 RID: 53074
			None,
			// Token: 0x0400CF53 RID: 53075
			GridTakeView,
			// Token: 0x0400CF54 RID: 53076
			AddRoleView,
			// Token: 0x0400CF55 RID: 53077
			RoleBuffUnlockView = 4,
			// Token: 0x0400CF56 RID: 53078
			InstResultView,
			// Token: 0x0400CF57 RID: 53079
			RoleBondInfoView = 7,
			// Token: 0x0400CF58 RID: 53080
			AddTokenView
		}
	}
}
