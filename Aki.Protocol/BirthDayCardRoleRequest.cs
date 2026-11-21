using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200019C RID: 412
	[NetMessage(EMessageId.BirthDayCardRoleRequest)]
	public sealed class BirthDayCardRoleRequest : IMessage<BirthDayCardRoleRequest>, IMessage, IEquatable<BirthDayCardRoleRequest>, IDeepCloneable<BirthDayCardRoleRequest>, IBufferMessage
	{
		// Token: 0x060030EE RID: 12526 RVA: 0x0007CFB5 File Offset: 0x0007B1B5
		[NullableContext(1)]
		public static BirthDayCardRoleRequest Create()
		{
			return new BirthDayCardRoleRequest();
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060030EF RID: 12527 RVA: 0x0007CFBC File Offset: 0x0007B1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060030F0 RID: 12528 RVA: 0x0007CFBF File Offset: 0x0007B1BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BirthDayCardRoleRequest.Descriptor;
			}
		}

		// Token: 0x060030F1 RID: 12529 RVA: 0x0007CFC6 File Offset: 0x0007B1C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayCardRoleRequest()
		{
		}

		// Token: 0x060030F2 RID: 12530 RVA: 0x0007CFCE File Offset: 0x0007B1CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayCardRoleRequest(BirthDayCardRoleRequest other) : this()
		{
			this.roleID_ = other.roleID_;
			this.yearId_ = other.yearId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060030F3 RID: 12531 RVA: 0x0007CFFF File Offset: 0x0007B1FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayCardRoleRequest Clone()
		{
			return new BirthDayCardRoleRequest(this);
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x060030F4 RID: 12532 RVA: 0x0007D007 File Offset: 0x0007B207
		// (set) Token: 0x060030F5 RID: 12533 RVA: 0x0007D00F File Offset: 0x0007B20F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleID
		{
			get
			{
				return this.roleID_;
			}
			set
			{
				this.roleID_ = value;
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060030F6 RID: 12534 RVA: 0x0007D018 File Offset: 0x0007B218
		// (set) Token: 0x060030F7 RID: 12535 RVA: 0x0007D020 File Offset: 0x0007B220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int YearId
		{
			get
			{
				return this.yearId_;
			}
			set
			{
				this.yearId_ = value;
			}
		}

		// Token: 0x060030F8 RID: 12536 RVA: 0x0007D029 File Offset: 0x0007B229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BirthDayCardRoleRequest);
		}

		// Token: 0x060030F9 RID: 12537 RVA: 0x0007D037 File Offset: 0x0007B237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BirthDayCardRoleRequest other)
		{
			return other != null && (other == this || (this.RoleID == other.RoleID && this.YearId == other.YearId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060030FA RID: 12538 RVA: 0x0007D078 File Offset: 0x0007B278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleID != 0)
			{
				num ^= this.RoleID.GetHashCode();
			}
			if (this.YearId != 0)
			{
				num ^= this.YearId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060030FB RID: 12539 RVA: 0x0007D0D0 File Offset: 0x0007B2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060030FC RID: 12540 RVA: 0x0007D0DD File Offset: 0x0007B2DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060030FD RID: 12541 RVA: 0x0007D0E8 File Offset: 0x0007B2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleID != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.RoleID);
			}
			if (this.YearId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.YearId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060030FE RID: 12542 RVA: 0x0007D144 File Offset: 0x0007B344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleID != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleID);
			}
			if (this.YearId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.YearId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060030FF RID: 12543 RVA: 0x0007D19C File Offset: 0x0007B39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BirthDayCardRoleRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleID != 0)
			{
				this.RoleID = other.RoleID;
			}
			if (other.YearId != 0)
			{
				this.YearId = other.YearId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003100 RID: 12544 RVA: 0x0007D1EC File Offset: 0x0007B3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003101 RID: 12545 RVA: 0x0007D1F8 File Offset: 0x0007B3F8
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
				if (num != 40U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.YearId = input.ReadInt32();
					}
				}
				else
				{
					this.RoleID = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400296B RID: 10603
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400296C RID: 10604
		public const int RoleIDFieldNumber = 5;

		// Token: 0x0400296D RID: 10605
		private int roleID_;

		// Token: 0x0400296E RID: 10606
		public const int YearIdFieldNumber = 13;

		// Token: 0x0400296F RID: 10607
		private int yearId_;
	}
}
