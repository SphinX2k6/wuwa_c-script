using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001305 RID: 4869
	[NetMessage(EMessageId.SwitchRoleRequest)]
	public sealed class SwitchRoleRequest : IMessage<SwitchRoleRequest>, IMessage, IEquatable<SwitchRoleRequest>, IDeepCloneable<SwitchRoleRequest>, IBufferMessage
	{
		// Token: 0x06019E16 RID: 106006 RVA: 0x003C2A60 File Offset: 0x003C0C60
		[NullableContext(1)]
		public static SwitchRoleRequest Create()
		{
			return new SwitchRoleRequest();
		}

		// Token: 0x17005745 RID: 22341
		// (get) Token: 0x06019E17 RID: 106007 RVA: 0x003C2A67 File Offset: 0x003C0C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005746 RID: 22342
		// (get) Token: 0x06019E18 RID: 106008 RVA: 0x003C2A6A File Offset: 0x003C0C6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchRoleRequest.Descriptor;
			}
		}

		// Token: 0x06019E19 RID: 106009 RVA: 0x003C2A71 File Offset: 0x003C0C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchRoleRequest()
		{
		}

		// Token: 0x06019E1A RID: 106010 RVA: 0x003C2A7C File Offset: 0x003C0C7C
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

		// Token: 0x06019E1B RID: 106011 RVA: 0x003C2AE0 File Offset: 0x003C0CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchRoleRequest Clone()
		{
			return new SwitchRoleRequest(this);
		}

		// Token: 0x17005747 RID: 22343
		// (get) Token: 0x06019E1C RID: 106012 RVA: 0x003C2AE8 File Offset: 0x003C0CE8
		// (set) Token: 0x06019E1D RID: 106013 RVA: 0x003C2AF0 File Offset: 0x003C0CF0
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

		// Token: 0x17005748 RID: 22344
		// (get) Token: 0x06019E1E RID: 106014 RVA: 0x003C2AF9 File Offset: 0x003C0CF9
		// (set) Token: 0x06019E1F RID: 106015 RVA: 0x003C2B01 File Offset: 0x003C0D01
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

		// Token: 0x17005749 RID: 22345
		// (get) Token: 0x06019E20 RID: 106016 RVA: 0x003C2B0A File Offset: 0x003C0D0A
		// (set) Token: 0x06019E21 RID: 106017 RVA: 0x003C2B12 File Offset: 0x003C0D12
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

		// Token: 0x1700574A RID: 22346
		// (get) Token: 0x06019E22 RID: 106018 RVA: 0x003C2B1B File Offset: 0x003C0D1B
		// (set) Token: 0x06019E23 RID: 106019 RVA: 0x003C2B23 File Offset: 0x003C0D23
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

		// Token: 0x06019E24 RID: 106020 RVA: 0x003C2B2C File Offset: 0x003C0D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchRoleRequest);
		}

		// Token: 0x06019E25 RID: 106021 RVA: 0x003C2B3C File Offset: 0x003C0D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchRoleRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SwitchType == other.SwitchType && this.OnStageWithoutControl == other.OnStageWithoutControl && object.Equals(this.Transform, other.Transform) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019E26 RID: 106022 RVA: 0x003C2BAC File Offset: 0x003C0DAC
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

		// Token: 0x06019E27 RID: 106023 RVA: 0x003C2C39 File Offset: 0x003C0E39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019E28 RID: 106024 RVA: 0x003C2C46 File Offset: 0x003C0E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019E29 RID: 106025 RVA: 0x003C2C50 File Offset: 0x003C0E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OnStageWithoutControl)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.OnStageWithoutControl);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RoleId);
			}
			if (this.transform_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Transform);
			}
			if (this.SwitchType != SwitchRoleType.SignleWorld)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.SwitchType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019E2A RID: 106026 RVA: 0x003C2CE4 File Offset: 0x003C0EE4
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

		// Token: 0x06019E2B RID: 106027 RVA: 0x003C2D60 File Offset: 0x003C0F60
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

		// Token: 0x06019E2C RID: 106028 RVA: 0x003C2DF0 File Offset: 0x003C0FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019E2D RID: 106029 RVA: 0x003C2DFC File Offset: 0x003C0FFC
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
				if (num <= 64U)
				{
					if (num == 48U)
					{
						this.OnStageWithoutControl = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						if (this.transform_ == null)
						{
							this.Transform = new Transform();
						}
						input.ReadMessage(this.Transform);
						continue;
					}
					if (num == 120U)
					{
						this.SwitchType = (SwitchRoleType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400974E RID: 38734
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400974F RID: 38735
		public const int RoleIdFieldNumber = 8;

		// Token: 0x04009750 RID: 38736
		private int roleId_;

		// Token: 0x04009751 RID: 38737
		public const int SwitchTypeFieldNumber = 15;

		// Token: 0x04009752 RID: 38738
		private SwitchRoleType switchType_;

		// Token: 0x04009753 RID: 38739
		public const int OnStageWithoutControlFieldNumber = 6;

		// Token: 0x04009754 RID: 38740
		private bool onStageWithoutControl_;

		// Token: 0x04009755 RID: 38741
		public const int TransformFieldNumber = 9;

		// Token: 0x04009756 RID: 38742
		private Transform transform_;
	}
}
