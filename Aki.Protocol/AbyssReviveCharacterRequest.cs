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
		// Token: 0x0600132C RID: 4908 RVA: 0x00034371 File Offset: 0x00032571
		[NullableContext(1)]
		public static AbyssReviveCharacterRequest Create()
		{
			return new AbyssReviveCharacterRequest();
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x00034378 File Offset: 0x00032578
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
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x0003437B File Offset: 0x0003257B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssReviveCharacterRequest.Descriptor;
			}
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x00034382 File Offset: 0x00032582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssReviveCharacterRequest()
		{
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x0003438A File Offset: 0x0003258A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssReviveCharacterRequest(AbyssReviveCharacterRequest other) : this()
		{
			this.reviveAll_ = other.reviveAll_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x000343BB File Offset: 0x000325BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssReviveCharacterRequest Clone()
		{
			return new AbyssReviveCharacterRequest(this);
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x000343C3 File Offset: 0x000325C3
		// (set) Token: 0x06001333 RID: 4915 RVA: 0x000343CB File Offset: 0x000325CB
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
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x000343D4 File Offset: 0x000325D4
		// (set) Token: 0x06001335 RID: 4917 RVA: 0x000343DC File Offset: 0x000325DC
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

		// Token: 0x06001336 RID: 4918 RVA: 0x000343E5 File Offset: 0x000325E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssReviveCharacterRequest);
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x000343F3 File Offset: 0x000325F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssReviveCharacterRequest other)
		{
			return other != null && (other == this || (this.ReviveAll == other.ReviveAll && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00034434 File Offset: 0x00032634
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

		// Token: 0x06001339 RID: 4921 RVA: 0x0003448C File Offset: 0x0003268C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x00034499 File Offset: 0x00032699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x000344A4 File Offset: 0x000326A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReviveAll)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.ReviveAll);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x000344FC File Offset: 0x000326FC
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

		// Token: 0x0600133D RID: 4925 RVA: 0x00034548 File Offset: 0x00032748
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

		// Token: 0x0600133E RID: 4926 RVA: 0x00034598 File Offset: 0x00032798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x000345A4 File Offset: 0x000327A4
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
					if (num != 112U)
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

		// Token: 0x04001FFF RID: 8191
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002000 RID: 8192
		public const int ReviveAllFieldNumber = 1;

		// Token: 0x04002001 RID: 8193
		private bool reviveAll_;

		// Token: 0x04002002 RID: 8194
		public const int RoleIdFieldNumber = 14;

		// Token: 0x04002003 RID: 8195
		private int roleId_;
	}
}
