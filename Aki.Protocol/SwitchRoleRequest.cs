using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001372 RID: 4978
	[NetMessage(EMessageId.SwitchRoleRequest)]
	public sealed class SwitchRoleRequest : IMessage<SwitchRoleRequest>, IMessage, IEquatable<SwitchRoleRequest>, IDeepCloneable<SwitchRoleRequest>, IBufferMessage
	{
		// Token: 0x0601A826 RID: 108582 RVA: 0x003DCD19 File Offset: 0x003DAF19
		[NullableContext(1)]
		public static SwitchRoleRequest Create()
		{
			return new SwitchRoleRequest();
		}

		// Token: 0x170059BF RID: 22975
		// (get) Token: 0x0601A827 RID: 108583 RVA: 0x003DCD20 File Offset: 0x003DAF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059C0 RID: 22976
		// (get) Token: 0x0601A828 RID: 108584 RVA: 0x003DCD23 File Offset: 0x003DAF23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchRoleRequest.Descriptor;
			}
		}

		// Token: 0x0601A829 RID: 108585 RVA: 0x003DCD2A File Offset: 0x003DAF2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchRoleRequest()
		{
		}

		// Token: 0x0601A82A RID: 108586 RVA: 0x003DCD34 File Offset: 0x003DAF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchRoleRequest(SwitchRoleRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.switchType_ = other.switchType_;
			this.onStageWithoutControl_ = other.onStageWithoutControl_;
			this.transform_ = ((other.transform_ != null) ? other.transform_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A82B RID: 108587 RVA: 0x003DCD98 File Offset: 0x003DAF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchRoleRequest Clone()
		{
			return new SwitchRoleRequest(this);
		}

		// Token: 0x170059C1 RID: 22977
		// (get) Token: 0x0601A82C RID: 108588 RVA: 0x003DCDA0 File Offset: 0x003DAFA0
		// (set) Token: 0x0601A82D RID: 108589 RVA: 0x003DCDA8 File Offset: 0x003DAFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x170059C2 RID: 22978
		// (get) Token: 0x0601A82E RID: 108590 RVA: 0x003DCDB1 File Offset: 0x003DAFB1
		// (set) Token: 0x0601A82F RID: 108591 RVA: 0x003DCDB9 File Offset: 0x003DAFB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchRoleType SwitchType
		{
			get
			{
				return this.switchType_;
			}
			set
			{
				this.switchType_ = value;
			}
		}

		// Token: 0x170059C3 RID: 22979
		// (get) Token: 0x0601A830 RID: 108592 RVA: 0x003DCDC2 File Offset: 0x003DAFC2
		// (set) Token: 0x0601A831 RID: 108593 RVA: 0x003DCDCA File Offset: 0x003DAFCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool OnStageWithoutControl
		{
			get
			{
				return this.onStageWithoutControl_;
			}
			set
			{
				this.onStageWithoutControl_ = value;
			}
		}

		// Token: 0x170059C4 RID: 22980
		// (get) Token: 0x0601A832 RID: 108594 RVA: 0x003DCDD3 File Offset: 0x003DAFD3
		// (set) Token: 0x0601A833 RID: 108595 RVA: 0x003DCDDB File Offset: 0x003DAFDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Transform Transform
		{
			get
			{
				return this.transform_;
			}
			set
			{
				this.transform_ = value;
			}
		}

		// Token: 0x0601A834 RID: 108596 RVA: 0x003DCDE4 File Offset: 0x003DAFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchRoleRequest);
		}

		// Token: 0x0601A835 RID: 108597 RVA: 0x003DCDF4 File Offset: 0x003DAFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchRoleRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SwitchType == other.SwitchType && this.OnStageWithoutControl == other.OnStageWithoutControl && object.Equals(this.Transform, other.Transform) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A836 RID: 108598 RVA: 0x003DCE64 File Offset: 0x003DB064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.SwitchType != SwitchRoleType.SignleWorld)
			{
				num ^= this.SwitchType.GetHashCode();
			}
			if (this.OnStageWithoutControl)
			{
				num ^= this.OnStageWithoutControl.GetHashCode();
			}
			if (this.transform_ != null)
			{
				num ^= this.Transform.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A837 RID: 108599 RVA: 0x003DCEF1 File Offset: 0x003DB0F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A838 RID: 108600 RVA: 0x003DCEFE File Offset: 0x003DB0FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A839 RID: 108601 RVA: 0x003DCF08 File Offset: 0x003DB108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RoleId);
			}
			if (this.transform_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Transform);
			}
			if (this.SwitchType != SwitchRoleType.SignleWorld)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.SwitchType);
			}
			if (this.OnStageWithoutControl)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.OnStageWithoutControl);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A83A RID: 108602 RVA: 0x003DCF9C File Offset: 0x003DB19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.SwitchType != SwitchRoleType.SignleWorld)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.SwitchType);
			}
			if (this.OnStageWithoutControl)
			{
				num += 2;
			}
			if (this.transform_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Transform);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A83B RID: 108603 RVA: 0x003DD018 File Offset: 0x003DB218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchRoleRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.SwitchType != SwitchRoleType.SignleWorld)
			{
				this.SwitchType = other.SwitchType;
			}
			if (other.OnStageWithoutControl)
			{
				this.OnStageWithoutControl = other.OnStageWithoutControl;
			}
			if (other.transform_ != null)
			{
				if (this.transform_ == null)
				{
					this.Transform = new Transform();
				}
				this.Transform.MergeFrom(other.Transform);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A83C RID: 108604 RVA: 0x003DD0A8 File Offset: 0x003DB2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A83D RID: 108605 RVA: 0x003DD0B4 File Offset: 0x003DB2B4
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
				if (num <= 58U)
				{
					if (num == 24U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 58U)
					{
						if (this.transform_ == null)
						{
							this.Transform = new Transform();
						}
						input.ReadMessage(this.Transform);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.SwitchType = (SwitchRoleType)input.ReadEnum();
						continue;
					}
					if (num == 112U)
					{
						this.OnStageWithoutControl = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009B70 RID: 39792
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B71 RID: 39793
		public const int RoleIdFieldNumber = 3;

		// Token: 0x04009B72 RID: 39794
		private int roleId_;

		// Token: 0x04009B73 RID: 39795
		public const int SwitchTypeFieldNumber = 8;

		// Token: 0x04009B74 RID: 39796
		private SwitchRoleType switchType_;

		// Token: 0x04009B75 RID: 39797
		public const int OnStageWithoutControlFieldNumber = 14;

		// Token: 0x04009B76 RID: 39798
		private bool onStageWithoutControl_;

		// Token: 0x04009B77 RID: 39799
		public const int TransformFieldNumber = 7;

		// Token: 0x04009B78 RID: 39800
		private Transform transform_;
	}
}
