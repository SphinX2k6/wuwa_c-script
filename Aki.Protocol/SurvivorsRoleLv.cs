using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001352 RID: 4946
	public sealed class SurvivorsRoleLv : IMessage<SurvivorsRoleLv>, IMessage, IEquatable<SurvivorsRoleLv>, IDeepCloneable<SurvivorsRoleLv>, IBufferMessage
	{
		// Token: 0x0601A5AA RID: 107946 RVA: 0x003D755E File Offset: 0x003D575E
		[NullableContext(1)]
		public static SurvivorsRoleLv Create()
		{
			return new SurvivorsRoleLv();
		}

		// Token: 0x17005940 RID: 22848
		// (get) Token: 0x0601A5AB RID: 107947 RVA: 0x003D7565 File Offset: 0x003D5765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005941 RID: 22849
		// (get) Token: 0x0601A5AC RID: 107948 RVA: 0x003D7568 File Offset: 0x003D5768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsRoleLv.Descriptor;
			}
		}

		// Token: 0x0601A5AD RID: 107949 RVA: 0x003D756F File Offset: 0x003D576F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRoleLv()
		{
		}

		// Token: 0x0601A5AE RID: 107950 RVA: 0x003D7578 File Offset: 0x003D5778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRoleLv(SurvivorsRoleLv other) : this()
		{
			this.roleId_ = other.roleId_;
			this.survivorsRole_ = ((other.survivorsRole_ != null) ? other.survivorsRole_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A5AF RID: 107951 RVA: 0x003D75C4 File Offset: 0x003D57C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRoleLv Clone()
		{
			return new SurvivorsRoleLv(this);
		}

		// Token: 0x17005942 RID: 22850
		// (get) Token: 0x0601A5B0 RID: 107952 RVA: 0x003D75CC File Offset: 0x003D57CC
		// (set) Token: 0x0601A5B1 RID: 107953 RVA: 0x003D75D4 File Offset: 0x003D57D4
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

		// Token: 0x17005943 RID: 22851
		// (get) Token: 0x0601A5B2 RID: 107954 RVA: 0x003D75DD File Offset: 0x003D57DD
		// (set) Token: 0x0601A5B3 RID: 107955 RVA: 0x003D75E5 File Offset: 0x003D57E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRole SurvivorsRole
		{
			get
			{
				return this.survivorsRole_;
			}
			set
			{
				this.survivorsRole_ = value;
			}
		}

		// Token: 0x0601A5B4 RID: 107956 RVA: 0x003D75EE File Offset: 0x003D57EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsRoleLv);
		}

		// Token: 0x0601A5B5 RID: 107957 RVA: 0x003D75FC File Offset: 0x003D57FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsRoleLv other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this.SurvivorsRole, other.SurvivorsRole) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A5B6 RID: 107958 RVA: 0x003D764C File Offset: 0x003D584C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.survivorsRole_ != null)
			{
				num ^= this.SurvivorsRole.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A5B7 RID: 107959 RVA: 0x003D76A1 File Offset: 0x003D58A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A5B8 RID: 107960 RVA: 0x003D76AE File Offset: 0x003D58AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A5B9 RID: 107961 RVA: 0x003D76B8 File Offset: 0x003D58B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.survivorsRole_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SurvivorsRole);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A5BA RID: 107962 RVA: 0x003D7710 File Offset: 0x003D5910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.survivorsRole_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorsRole);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A5BB RID: 107963 RVA: 0x003D7768 File Offset: 0x003D5968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsRoleLv other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.survivorsRole_ != null)
			{
				if (this.survivorsRole_ == null)
				{
					this.SurvivorsRole = new SurvivorsRole();
				}
				this.SurvivorsRole.MergeFrom(other.SurvivorsRole);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A5BC RID: 107964 RVA: 0x003D77D0 File Offset: 0x003D59D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A5BD RID: 107965 RVA: 0x003D77DC File Offset: 0x003D59DC
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
						if (this.survivorsRole_ == null)
						{
							this.SurvivorsRole = new SurvivorsRole();
						}
						input.ReadMessage(this.SurvivorsRole);
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009AD3 RID: 39635
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009AD4 RID: 39636
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04009AD5 RID: 39637
		private int roleId_;

		// Token: 0x04009AD6 RID: 39638
		public const int SurvivorsRoleFieldNumber = 2;

		// Token: 0x04009AD7 RID: 39639
		private SurvivorsRole survivorsRole_;
	}
}
