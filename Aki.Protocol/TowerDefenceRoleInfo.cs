using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001420 RID: 5152
	public sealed class TowerDefenceRoleInfo : IMessage<TowerDefenceRoleInfo>, IMessage, IEquatable<TowerDefenceRoleInfo>, IDeepCloneable<TowerDefenceRoleInfo>, IBufferMessage
	{
		// Token: 0x0601B61F RID: 112159 RVA: 0x003FB4E1 File Offset: 0x003F96E1
		[NullableContext(1)]
		public static TowerDefenceRoleInfo Create()
		{
			return new TowerDefenceRoleInfo();
		}

		// Token: 0x17005CB2 RID: 23730
		// (get) Token: 0x0601B620 RID: 112160 RVA: 0x003FB4E8 File Offset: 0x003F96E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerDefenceRoleInfo> Parser
		{
			get
			{
				return TowerDefenceRoleInfo._parser;
			}
		}

		// Token: 0x17005CB3 RID: 23731
		// (get) Token: 0x0601B621 RID: 112161 RVA: 0x003FB4EF File Offset: 0x003F96EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CB4 RID: 23732
		// (get) Token: 0x0601B622 RID: 112162 RVA: 0x003FB4F2 File Offset: 0x003F96F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceRoleInfo.Descriptor;
			}
		}

		// Token: 0x0601B623 RID: 112163 RVA: 0x003FB4F9 File Offset: 0x003F96F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRoleInfo()
		{
		}

		// Token: 0x0601B624 RID: 112164 RVA: 0x003FB504 File Offset: 0x003F9704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRoleInfo(TowerDefenceRoleInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.phantom_ = ((other.phantom_ != null) ? other.phantom_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B625 RID: 112165 RVA: 0x003FB550 File Offset: 0x003F9750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRoleInfo Clone()
		{
			return new TowerDefenceRoleInfo(this);
		}

		// Token: 0x17005CB5 RID: 23733
		// (get) Token: 0x0601B626 RID: 112166 RVA: 0x003FB558 File Offset: 0x003F9758
		// (set) Token: 0x0601B627 RID: 112167 RVA: 0x003FB560 File Offset: 0x003F9760
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

		// Token: 0x17005CB6 RID: 23734
		// (get) Token: 0x0601B628 RID: 112168 RVA: 0x003FB569 File Offset: 0x003F9769
		// (set) Token: 0x0601B629 RID: 112169 RVA: 0x003FB571 File Offset: 0x003F9771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePhantomInfo Phantom
		{
			get
			{
				return this.phantom_;
			}
			set
			{
				this.phantom_ = value;
			}
		}

		// Token: 0x0601B62A RID: 112170 RVA: 0x003FB57A File Offset: 0x003F977A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceRoleInfo);
		}

		// Token: 0x0601B62B RID: 112171 RVA: 0x003FB588 File Offset: 0x003F9788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceRoleInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this.Phantom, other.Phantom) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B62C RID: 112172 RVA: 0x003FB5D8 File Offset: 0x003F97D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.phantom_ != null)
			{
				num ^= this.Phantom.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B62D RID: 112173 RVA: 0x003FB62D File Offset: 0x003F982D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B62E RID: 112174 RVA: 0x003FB63A File Offset: 0x003F983A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B62F RID: 112175 RVA: 0x003FB644 File Offset: 0x003F9844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.phantom_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Phantom);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B630 RID: 112176 RVA: 0x003FB69C File Offset: 0x003F989C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.phantom_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Phantom);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B631 RID: 112177 RVA: 0x003FB6F4 File Offset: 0x003F98F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceRoleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.phantom_ != null)
			{
				if (this.phantom_ == null)
				{
					this.Phantom = new TowerDefencePhantomInfo();
				}
				this.Phantom.MergeFrom(other.Phantom);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B632 RID: 112178 RVA: 0x003FB75C File Offset: 0x003F995C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B633 RID: 112179 RVA: 0x003FB768 File Offset: 0x003F9968
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.phantom_ == null)
						{
							this.Phantom = new TowerDefencePhantomInfo();
						}
						input.ReadMessage(this.Phantom);
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009F76 RID: 40822
		private static readonly MessageParser<TowerDefenceRoleInfo> _parser = new MessageParser<TowerDefenceRoleInfo>(() => new TowerDefenceRoleInfo());

		// Token: 0x04009F77 RID: 40823
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F78 RID: 40824
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04009F79 RID: 40825
		private int roleId_;

		// Token: 0x04009F7A RID: 40826
		public const int PhantomFieldNumber = 2;

		// Token: 0x04009F7B RID: 40827
		private TowerDefencePhantomInfo phantom_;
	}
}
