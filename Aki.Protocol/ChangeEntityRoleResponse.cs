using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000250 RID: 592
	[NetMessage(EMessageId.ChangeEntityRoleResponse)]
	public sealed class ChangeEntityRoleResponse : IMessage<ChangeEntityRoleResponse>, IMessage, IEquatable<ChangeEntityRoleResponse>, IDeepCloneable<ChangeEntityRoleResponse>, IBufferMessage
	{
		// Token: 0x06003F60 RID: 16224 RVA: 0x0009C6D4 File Offset: 0x0009A8D4
		[NullableContext(1)]
		public static ChangeEntityRoleResponse Create()
		{
			return new ChangeEntityRoleResponse();
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06003F61 RID: 16225 RVA: 0x0009C6DB File Offset: 0x0009A8DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06003F62 RID: 16226 RVA: 0x0009C6DE File Offset: 0x0009A8DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeEntityRoleResponse.Descriptor;
			}
		}

		// Token: 0x06003F63 RID: 16227 RVA: 0x0009C6E5 File Offset: 0x0009A8E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEntityRoleResponse()
		{
		}

		// Token: 0x06003F64 RID: 16228 RVA: 0x0009C6ED File Offset: 0x0009A8ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEntityRoleResponse(ChangeEntityRoleResponse other) : this()
		{
			this.success_ = other.success_;
			this.id_ = other.id_;
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F65 RID: 16229 RVA: 0x0009C72A File Offset: 0x0009A92A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEntityRoleResponse Clone()
		{
			return new ChangeEntityRoleResponse(this);
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06003F66 RID: 16230 RVA: 0x0009C732 File Offset: 0x0009A932
		// (set) Token: 0x06003F67 RID: 16231 RVA: 0x0009C73A File Offset: 0x0009A93A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Success
		{
			get
			{
				return this.success_;
			}
			set
			{
				this.success_ = value;
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06003F68 RID: 16232 RVA: 0x0009C743 File Offset: 0x0009A943
		// (set) Token: 0x06003F69 RID: 16233 RVA: 0x0009C74B File Offset: 0x0009A94B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06003F6A RID: 16234 RVA: 0x0009C754 File Offset: 0x0009A954
		// (set) Token: 0x06003F6B RID: 16235 RVA: 0x0009C75C File Offset: 0x0009A95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x06003F6C RID: 16236 RVA: 0x0009C765 File Offset: 0x0009A965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeEntityRoleResponse);
		}

		// Token: 0x06003F6D RID: 16237 RVA: 0x0009C774 File Offset: 0x0009A974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeEntityRoleResponse other)
		{
			return other != null && (other == this || (this.Success == other.Success && this.Id == other.Id && this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003F6E RID: 16238 RVA: 0x0009C7D0 File Offset: 0x0009A9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Success)
			{
				num ^= this.Success.GetHashCode();
			}
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003F6F RID: 16239 RVA: 0x0009C841 File Offset: 0x0009AA41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x0009C84E File Offset: 0x0009AA4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x0009C858 File Offset: 0x0009AA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Success)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.Success);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F72 RID: 16242 RVA: 0x0009C8D0 File Offset: 0x0009AAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Success)
			{
				num += 2;
			}
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003F73 RID: 16243 RVA: 0x0009C934 File Offset: 0x0009AB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeEntityRoleResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Success)
			{
				this.Success = other.Success;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003F74 RID: 16244 RVA: 0x0009C998 File Offset: 0x0009AB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F75 RID: 16245 RVA: 0x0009C9A4 File Offset: 0x0009ABA4
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
				if (num != 56U)
				{
					if (num != 72U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Id = input.ReadInt64();
						}
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.Success = input.ReadBool();
				}
			}
		}

		// Token: 0x04002D75 RID: 11637
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D76 RID: 11638
		public const int SuccessFieldNumber = 7;

		// Token: 0x04002D77 RID: 11639
		private bool success_;

		// Token: 0x04002D78 RID: 11640
		public const int IdFieldNumber = 11;

		// Token: 0x04002D79 RID: 11641
		private long id_;

		// Token: 0x04002D7A RID: 11642
		public const int PlayerIdFieldNumber = 9;

		// Token: 0x04002D7B RID: 11643
		private int playerId_;
	}
}
