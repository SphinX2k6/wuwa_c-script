using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000198 RID: 408
	[NetMessage(EMessageId.BirthDayCardRoleRequest)]
	public sealed class BirthDayCardRoleRequest : IMessage<BirthDayCardRoleRequest>, IMessage, IEquatable<BirthDayCardRoleRequest>, IDeepCloneable<BirthDayCardRoleRequest>, IBufferMessage
	{
		// Token: 0x06003061 RID: 12385 RVA: 0x0007B849 File Offset: 0x00079A49
		[NullableContext(1)]
		public static BirthDayCardRoleRequest Create()
		{
			return new BirthDayCardRoleRequest();
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06003062 RID: 12386 RVA: 0x0007B850 File Offset: 0x00079A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06003063 RID: 12387 RVA: 0x0007B853 File Offset: 0x00079A53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BirthDayCardRoleRequest.Descriptor;
			}
		}

		// Token: 0x06003064 RID: 12388 RVA: 0x0007B85A File Offset: 0x00079A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayCardRoleRequest()
		{
		}

		// Token: 0x06003065 RID: 12389 RVA: 0x0007B862 File Offset: 0x00079A62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayCardRoleRequest(BirthDayCardRoleRequest other) : this()
		{
			this.roleID_ = other.roleID_;
			this.yearId_ = other.yearId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003066 RID: 12390 RVA: 0x0007B893 File Offset: 0x00079A93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayCardRoleRequest Clone()
		{
			return new BirthDayCardRoleRequest(this);
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06003067 RID: 12391 RVA: 0x0007B89B File Offset: 0x00079A9B
		// (set) Token: 0x06003068 RID: 12392 RVA: 0x0007B8A3 File Offset: 0x00079AA3
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

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06003069 RID: 12393 RVA: 0x0007B8AC File Offset: 0x00079AAC
		// (set) Token: 0x0600306A RID: 12394 RVA: 0x0007B8B4 File Offset: 0x00079AB4
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

		// Token: 0x0600306B RID: 12395 RVA: 0x0007B8BD File Offset: 0x00079ABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BirthDayCardRoleRequest);
		}

		// Token: 0x0600306C RID: 12396 RVA: 0x0007B8CB File Offset: 0x00079ACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BirthDayCardRoleRequest other)
		{
			return other != null && (other == this || (this.RoleID == other.RoleID && this.YearId == other.YearId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600306D RID: 12397 RVA: 0x0007B90C File Offset: 0x00079B0C
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

		// Token: 0x0600306E RID: 12398 RVA: 0x0007B964 File Offset: 0x00079B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x0007B971 File Offset: 0x00079B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003070 RID: 12400 RVA: 0x0007B97C File Offset: 0x00079B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleID != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.RoleID);
			}
			if (this.YearId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.YearId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003071 RID: 12401 RVA: 0x0007B9D8 File Offset: 0x00079BD8
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

		// Token: 0x06003072 RID: 12402 RVA: 0x0007BA30 File Offset: 0x00079C30
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

		// Token: 0x06003073 RID: 12403 RVA: 0x0007BA80 File Offset: 0x00079C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x0007BA8C File Offset: 0x00079C8C
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
				if (num != 104U)
				{
					if (num != 112U)
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

		// Token: 0x040028F0 RID: 10480
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028F1 RID: 10481
		public const int RoleIDFieldNumber = 13;

		// Token: 0x040028F2 RID: 10482
		private int roleID_;

		// Token: 0x040028F3 RID: 10483
		public const int YearIdFieldNumber = 14;

		// Token: 0x040028F4 RID: 10484
		private int yearId_;
	}
}
