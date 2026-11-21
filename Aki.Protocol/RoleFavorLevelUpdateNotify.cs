using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001062 RID: 4194
	[NetMessage(EMessageId.RoleFavorLevelUpdateNotify)]
	public sealed class RoleFavorLevelUpdateNotify : IMessage<RoleFavorLevelUpdateNotify>, IMessage, IEquatable<RoleFavorLevelUpdateNotify>, IDeepCloneable<RoleFavorLevelUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601670E RID: 91918 RVA: 0x00343DD7 File Offset: 0x00341FD7
		[NullableContext(1)]
		public static RoleFavorLevelUpdateNotify Create()
		{
			return new RoleFavorLevelUpdateNotify();
		}

		// Token: 0x17004B29 RID: 19241
		// (get) Token: 0x0601670F RID: 91919 RVA: 0x00343DDE File Offset: 0x00341FDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B2A RID: 19242
		// (get) Token: 0x06016710 RID: 91920 RVA: 0x00343DE1 File Offset: 0x00341FE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorLevelUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06016711 RID: 91921 RVA: 0x00343DE8 File Offset: 0x00341FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorLevelUpdateNotify()
		{
		}

		// Token: 0x06016712 RID: 91922 RVA: 0x00343DF0 File Offset: 0x00341FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorLevelUpdateNotify(RoleFavorLevelUpdateNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.level_ = other.level_;
			this.exp_ = other.exp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016713 RID: 91923 RVA: 0x00343E2D File Offset: 0x0034202D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorLevelUpdateNotify Clone()
		{
			return new RoleFavorLevelUpdateNotify(this);
		}

		// Token: 0x17004B2B RID: 19243
		// (get) Token: 0x06016714 RID: 91924 RVA: 0x00343E35 File Offset: 0x00342035
		// (set) Token: 0x06016715 RID: 91925 RVA: 0x00343E3D File Offset: 0x0034203D
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

		// Token: 0x17004B2C RID: 19244
		// (get) Token: 0x06016716 RID: 91926 RVA: 0x00343E46 File Offset: 0x00342046
		// (set) Token: 0x06016717 RID: 91927 RVA: 0x00343E4E File Offset: 0x0034204E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17004B2D RID: 19245
		// (get) Token: 0x06016718 RID: 91928 RVA: 0x00343E57 File Offset: 0x00342057
		// (set) Token: 0x06016719 RID: 91929 RVA: 0x00343E5F File Offset: 0x0034205F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x0601671A RID: 91930 RVA: 0x00343E68 File Offset: 0x00342068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorLevelUpdateNotify);
		}

		// Token: 0x0601671B RID: 91931 RVA: 0x00343E78 File Offset: 0x00342078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorLevelUpdateNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Level == other.Level && this.Exp == other.Exp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601671C RID: 91932 RVA: 0x00343ED4 File Offset: 0x003420D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Exp != 0)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601671D RID: 91933 RVA: 0x00343F45 File Offset: 0x00342145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601671E RID: 91934 RVA: 0x00343F52 File Offset: 0x00342152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601671F RID: 91935 RVA: 0x00343F5C File Offset: 0x0034215C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Level);
			}
			if (this.Exp != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Exp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016720 RID: 91936 RVA: 0x00343FD0 File Offset: 0x003421D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.Exp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Exp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016721 RID: 91937 RVA: 0x00344040 File Offset: 0x00342240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFavorLevelUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.Exp != 0)
			{
				this.Exp = other.Exp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016722 RID: 91938 RVA: 0x003440A4 File Offset: 0x003422A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016723 RID: 91939 RVA: 0x003440B0 File Offset: 0x003422B0
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
					if (num != 40U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Exp = input.ReadInt32();
						}
					}
					else
					{
						this.Level = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040086B7 RID: 34487
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086B8 RID: 34488
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040086B9 RID: 34489
		private int roleId_;

		// Token: 0x040086BA RID: 34490
		public const int LevelFieldNumber = 5;

		// Token: 0x040086BB RID: 34491
		private int level_;

		// Token: 0x040086BC RID: 34492
		public const int ExpFieldNumber = 12;

		// Token: 0x040086BD RID: 34493
		private int exp_;
	}
}
