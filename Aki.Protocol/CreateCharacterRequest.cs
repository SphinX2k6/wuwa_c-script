using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200031B RID: 795
	[NetMessage(EMessageId.CreateCharacterRequest)]
	public sealed class CreateCharacterRequest : IMessage<CreateCharacterRequest>, IMessage, IEquatable<CreateCharacterRequest>, IDeepCloneable<CreateCharacterRequest>, IBufferMessage
	{
		// Token: 0x06005062 RID: 20578 RVA: 0x000C457D File Offset: 0x000C277D
		[NullableContext(1)]
		public static CreateCharacterRequest Create()
		{
			return new CreateCharacterRequest();
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06005063 RID: 20579 RVA: 0x000C4584 File Offset: 0x000C2784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06005064 RID: 20580 RVA: 0x000C4587 File Offset: 0x000C2787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateCharacterRequest.Descriptor;
			}
		}

		// Token: 0x06005065 RID: 20581 RVA: 0x000C458E File Offset: 0x000C278E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateCharacterRequest()
		{
		}

		// Token: 0x06005066 RID: 20582 RVA: 0x000C45A1 File Offset: 0x000C27A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateCharacterRequest(CreateCharacterRequest other) : this()
		{
			this.sex_ = other.sex_;
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005067 RID: 20583 RVA: 0x000C45D2 File Offset: 0x000C27D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateCharacterRequest Clone()
		{
			return new CreateCharacterRequest(this);
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06005068 RID: 20584 RVA: 0x000C45DA File Offset: 0x000C27DA
		// (set) Token: 0x06005069 RID: 20585 RVA: 0x000C45E2 File Offset: 0x000C27E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Sex
		{
			get
			{
				return this.sex_;
			}
			set
			{
				this.sex_ = value;
			}
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x0600506A RID: 20586 RVA: 0x000C45EB File Offset: 0x000C27EB
		// (set) Token: 0x0600506B RID: 20587 RVA: 0x000C45F3 File Offset: 0x000C27F3
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

		// Token: 0x0600506C RID: 20588 RVA: 0x000C4606 File Offset: 0x000C2806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateCharacterRequest);
		}

		// Token: 0x0600506D RID: 20589 RVA: 0x000C4614 File Offset: 0x000C2814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CreateCharacterRequest other)
		{
			return other != null && (other == this || (this.Sex == other.Sex && !(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600506E RID: 20590 RVA: 0x000C4664 File Offset: 0x000C2864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Sex != 0)
			{
				num ^= this.Sex.GetHashCode();
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

		// Token: 0x0600506F RID: 20591 RVA: 0x000C46BE File Offset: 0x000C28BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005070 RID: 20592 RVA: 0x000C46CB File Offset: 0x000C28CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005071 RID: 20593 RVA: 0x000C46D4 File Offset: 0x000C28D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Sex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Sex);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005072 RID: 20594 RVA: 0x000C4734 File Offset: 0x000C2934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Sex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Sex);
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

		// Token: 0x06005073 RID: 20595 RVA: 0x000C4790 File Offset: 0x000C2990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CreateCharacterRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Sex != 0)
			{
				this.Sex = other.Sex;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005074 RID: 20596 RVA: 0x000C47E5 File Offset: 0x000C29E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005075 RID: 20597 RVA: 0x000C47F0 File Offset: 0x000C29F0
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
						this.Name = input.ReadString();
					}
				}
				else
				{
					this.Sex = input.ReadInt32();
				}
			}
		}

		// Token: 0x040032B4 RID: 12980
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032B5 RID: 12981
		public const int SexFieldNumber = 1;

		// Token: 0x040032B6 RID: 12982
		private int sex_;

		// Token: 0x040032B7 RID: 12983
		public const int NameFieldNumber = 2;

		// Token: 0x040032B8 RID: 12984
		private string name_ = "";
	}
}
