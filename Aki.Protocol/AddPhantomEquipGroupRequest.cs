using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000AA RID: 170
	[NetMessage(EMessageId.AddPhantomEquipGroupRequest)]
	public sealed class AddPhantomEquipGroupRequest : IMessage<AddPhantomEquipGroupRequest>, IMessage, IEquatable<AddPhantomEquipGroupRequest>, IDeepCloneable<AddPhantomEquipGroupRequest>, IBufferMessage
	{
		// Token: 0x06001D3A RID: 7482 RVA: 0x00050B05 File Offset: 0x0004ED05
		[NullableContext(1)]
		public static AddPhantomEquipGroupRequest Create()
		{
			return new AddPhantomEquipGroupRequest();
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06001D3B RID: 7483 RVA: 0x00050B0C File Offset: 0x0004ED0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06001D3C RID: 7484 RVA: 0x00050B0F File Offset: 0x0004ED0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddPhantomEquipGroupRequest.Descriptor;
			}
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x00050B16 File Offset: 0x0004ED16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddPhantomEquipGroupRequest()
		{
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x00050B29 File Offset: 0x0004ED29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddPhantomEquipGroupRequest(AddPhantomEquipGroupRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x00050B5A File Offset: 0x0004ED5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddPhantomEquipGroupRequest Clone()
		{
			return new AddPhantomEquipGroupRequest(this);
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06001D40 RID: 7488 RVA: 0x00050B62 File Offset: 0x0004ED62
		// (set) Token: 0x06001D41 RID: 7489 RVA: 0x00050B6A File Offset: 0x0004ED6A
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

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x00050B73 File Offset: 0x0004ED73
		// (set) Token: 0x06001D43 RID: 7491 RVA: 0x00050B7B File Offset: 0x0004ED7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x00050B8E File Offset: 0x0004ED8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddPhantomEquipGroupRequest);
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x00050B9C File Offset: 0x0004ED9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddPhantomEquipGroupRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && !(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x00050BEC File Offset: 0x0004EDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x00050C46 File Offset: 0x0004EE46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x00050C53 File Offset: 0x0004EE53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x00050C5C File Offset: 0x0004EE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.Name);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x00050CBC File Offset: 0x0004EEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x00050D18 File Offset: 0x0004EF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddPhantomEquipGroupRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x00050D6D File Offset: 0x0004EF6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x00050D78 File Offset: 0x0004EF78
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
				if (num != 58U)
				{
					if (num != 120U)
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
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x0400235F RID: 9055
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002360 RID: 9056
		public const int RoleIdFieldNumber = 15;

		// Token: 0x04002361 RID: 9057
		private int roleId_;

		// Token: 0x04002362 RID: 9058
		public const int NameFieldNumber = 7;

		// Token: 0x04002363 RID: 9059
		private string name_ = "";
	}
}
