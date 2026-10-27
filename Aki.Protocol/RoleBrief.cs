using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200105A RID: 4186
	public sealed class RoleBrief : IMessage<RoleBrief>, IMessage, IEquatable<RoleBrief>, IDeepCloneable<RoleBrief>, IBufferMessage
	{
		// Token: 0x060165E2 RID: 91618 RVA: 0x0034024F File Offset: 0x0033E44F
		[NullableContext(1)]
		public static RoleBrief Create()
		{
			return new RoleBrief();
		}

		// Token: 0x17004AD5 RID: 19157
		// (get) Token: 0x060165E3 RID: 91619 RVA: 0x00340256 File Offset: 0x0033E456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleBrief> Parser
		{
			get
			{
				return RoleBrief._parser;
			}
		}

		// Token: 0x17004AD6 RID: 19158
		// (get) Token: 0x060165E4 RID: 91620 RVA: 0x0034025D File Offset: 0x0033E45D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AD7 RID: 19159
		// (get) Token: 0x060165E5 RID: 91621 RVA: 0x00340260 File Offset: 0x0033E460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleBrief.Descriptor;
			}
		}

		// Token: 0x060165E6 RID: 91622 RVA: 0x00340267 File Offset: 0x0033E467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBrief()
		{
		}

		// Token: 0x060165E7 RID: 91623 RVA: 0x0034026F File Offset: 0x0033E46F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBrief(RoleBrief other) : this()
		{
			this.roleId_ = other.roleId_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060165E8 RID: 91624 RVA: 0x003402A0 File Offset: 0x0033E4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBrief Clone()
		{
			return new RoleBrief(this);
		}

		// Token: 0x17004AD8 RID: 19160
		// (get) Token: 0x060165E9 RID: 91625 RVA: 0x003402A8 File Offset: 0x0033E4A8
		// (set) Token: 0x060165EA RID: 91626 RVA: 0x003402B0 File Offset: 0x0033E4B0
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

		// Token: 0x17004AD9 RID: 19161
		// (get) Token: 0x060165EB RID: 91627 RVA: 0x003402B9 File Offset: 0x0033E4B9
		// (set) Token: 0x060165EC RID: 91628 RVA: 0x003402C1 File Offset: 0x0033E4C1
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

		// Token: 0x060165ED RID: 91629 RVA: 0x003402CA File Offset: 0x0033E4CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleBrief);
		}

		// Token: 0x060165EE RID: 91630 RVA: 0x003402D8 File Offset: 0x0033E4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleBrief other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060165EF RID: 91631 RVA: 0x00340318 File Offset: 0x0033E518
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060165F0 RID: 91632 RVA: 0x00340370 File Offset: 0x0033E570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060165F1 RID: 91633 RVA: 0x0034037D File Offset: 0x0033E57D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060165F2 RID: 91634 RVA: 0x00340388 File Offset: 0x0033E588
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
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060165F3 RID: 91635 RVA: 0x003403E0 File Offset: 0x0033E5E0
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060165F4 RID: 91636 RVA: 0x00340438 File Offset: 0x0033E638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleBrief other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060165F5 RID: 91637 RVA: 0x00340488 File Offset: 0x0033E688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060165F6 RID: 91638 RVA: 0x00340494 File Offset: 0x0033E694
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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

		// Token: 0x040085CB RID: 34251
		private static readonly MessageParser<RoleBrief> _parser = new MessageParser<RoleBrief>(() => new RoleBrief());

		// Token: 0x040085CC RID: 34252
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085CD RID: 34253
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040085CE RID: 34254
		private int roleId_;

		// Token: 0x040085CF RID: 34255
		public const int LevelFieldNumber = 2;

		// Token: 0x040085D0 RID: 34256
		private int level_;
	}
}
