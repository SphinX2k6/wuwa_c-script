using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000A9 RID: 169
	[NetMessage(EMessageId.AddPhantomEquipGroupRequest)]
	public sealed class AddPhantomEquipGroupRequest : IMessage<AddPhantomEquipGroupRequest>, IMessage, IEquatable<AddPhantomEquipGroupRequest>, IDeepCloneable<AddPhantomEquipGroupRequest>, IBufferMessage
	{
		// Token: 0x06001CF3 RID: 7411 RVA: 0x0004FEED File Offset: 0x0004E0ED
		[NullableContext(1)]
		public static AddPhantomEquipGroupRequest Create()
		{
			return new AddPhantomEquipGroupRequest();
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06001CF4 RID: 7412 RVA: 0x0004FEF4 File Offset: 0x0004E0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001CF5 RID: 7413 RVA: 0x0004FEF7 File Offset: 0x0004E0F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddPhantomEquipGroupRequest.Descriptor;
			}
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x0004FEFE File Offset: 0x0004E0FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddPhantomEquipGroupRequest()
		{
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x0004FF11 File Offset: 0x0004E111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddPhantomEquipGroupRequest(AddPhantomEquipGroupRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x0004FF42 File Offset: 0x0004E142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddPhantomEquipGroupRequest Clone()
		{
			return new AddPhantomEquipGroupRequest(this);
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06001CF9 RID: 7417 RVA: 0x0004FF4A File Offset: 0x0004E14A
		// (set) Token: 0x06001CFA RID: 7418 RVA: 0x0004FF52 File Offset: 0x0004E152
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

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001CFB RID: 7419 RVA: 0x0004FF5B File Offset: 0x0004E15B
		// (set) Token: 0x06001CFC RID: 7420 RVA: 0x0004FF63 File Offset: 0x0004E163
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

		// Token: 0x06001CFD RID: 7421 RVA: 0x0004FF76 File Offset: 0x0004E176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddPhantomEquipGroupRequest);
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x0004FF84 File Offset: 0x0004E184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddPhantomEquipGroupRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && !(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x0004FFD4 File Offset: 0x0004E1D4
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

		// Token: 0x06001D00 RID: 7424 RVA: 0x0005002E File Offset: 0x0004E22E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x0005003B File Offset: 0x0004E23B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x00050044 File Offset: 0x0004E244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.RoleId);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x000500A4 File Offset: 0x0004E2A4
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

		// Token: 0x06001D04 RID: 7428 RVA: 0x00050100 File Offset: 0x0004E300
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

		// Token: 0x06001D05 RID: 7429 RVA: 0x00050155 File Offset: 0x0004E355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x00050160 File Offset: 0x0004E360
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
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040022FE RID: 8958
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022FF RID: 8959
		public const int RoleIdFieldNumber = 5;

		// Token: 0x04002300 RID: 8960
		private int roleId_;

		// Token: 0x04002301 RID: 8961
		public const int NameFieldNumber = 12;

		// Token: 0x04002302 RID: 8962
		private string name_ = "";
	}
}
