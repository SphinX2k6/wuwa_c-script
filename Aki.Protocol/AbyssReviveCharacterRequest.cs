using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200003B RID: 59
	[NetMessage(EMessageId.AbyssReviveCharacterRequest)]
	public sealed class AbyssReviveCharacterRequest : IMessage<AbyssReviveCharacterRequest>, IMessage, IEquatable<AbyssReviveCharacterRequest>, IDeepCloneable<AbyssReviveCharacterRequest>, IBufferMessage
	{
		// Token: 0x06001357 RID: 4951 RVA: 0x00034925 File Offset: 0x00032B25
		[NullableContext(1)]
		public static AbyssReviveCharacterRequest Create()
		{
			return new AbyssReviveCharacterRequest();
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06001358 RID: 4952 RVA: 0x0003492C File Offset: 0x00032B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06001359 RID: 4953 RVA: 0x0003492F File Offset: 0x00032B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssReviveCharacterRequest.Descriptor;
			}
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x00034936 File Offset: 0x00032B36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssReviveCharacterRequest()
		{
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x0003493E File Offset: 0x00032B3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssReviveCharacterRequest(AbyssReviveCharacterRequest other) : this()
		{
			this.reviveAll_ = other.reviveAll_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x0003496F File Offset: 0x00032B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssReviveCharacterRequest Clone()
		{
			return new AbyssReviveCharacterRequest(this);
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600135D RID: 4957 RVA: 0x00034977 File Offset: 0x00032B77
		// (set) Token: 0x0600135E RID: 4958 RVA: 0x0003497F File Offset: 0x00032B7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ReviveAll
		{
			get
			{
				return this.reviveAll_;
			}
			set
			{
				this.reviveAll_ = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600135F RID: 4959 RVA: 0x00034988 File Offset: 0x00032B88
		// (set) Token: 0x06001360 RID: 4960 RVA: 0x00034990 File Offset: 0x00032B90
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

		// Token: 0x06001361 RID: 4961 RVA: 0x00034999 File Offset: 0x00032B99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssReviveCharacterRequest);
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x000349A7 File Offset: 0x00032BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssReviveCharacterRequest other)
		{
			return other != null && (other == this || (this.ReviveAll == other.ReviveAll && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x000349E8 File Offset: 0x00032BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ReviveAll)
			{
				num ^= this.ReviveAll.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x00034A40 File Offset: 0x00032C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x00034A4D File Offset: 0x00032C4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x00034A58 File Offset: 0x00032C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReviveAll)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.ReviveAll);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x00034AB4 File Offset: 0x00032CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ReviveAll)
			{
				num += 2;
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x00034B00 File Offset: 0x00032D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssReviveCharacterRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ReviveAll)
			{
				this.ReviveAll = other.ReviveAll;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x00034B50 File Offset: 0x00032D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x00034B5C File Offset: 0x00032D5C
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
				if (num != 16U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.ReviveAll = input.ReadBool();
				}
			}
		}

		// Token: 0x04002055 RID: 8277
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002056 RID: 8278
		public const int ReviveAllFieldNumber = 2;

		// Token: 0x04002057 RID: 8279
		private bool reviveAll_;

		// Token: 0x04002058 RID: 8280
		public const int RoleIdFieldNumber = 13;

		// Token: 0x04002059 RID: 8281
		private int roleId_;
	}
}
