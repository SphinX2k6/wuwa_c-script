using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000314 RID: 788
	[NetMessage(EMessageId.CreateCharacterRequest)]
	public sealed class CreateCharacterRequest : IMessage<CreateCharacterRequest>, IMessage, IEquatable<CreateCharacterRequest>, IDeepCloneable<CreateCharacterRequest>, IBufferMessage
	{
		// Token: 0x06004F89 RID: 20361 RVA: 0x000C2191 File Offset: 0x000C0391
		[NullableContext(1)]
		public static CreateCharacterRequest Create()
		{
			return new CreateCharacterRequest();
		}

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06004F8A RID: 20362 RVA: 0x000C2198 File Offset: 0x000C0398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06004F8B RID: 20363 RVA: 0x000C219B File Offset: 0x000C039B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateCharacterRequest.Descriptor;
			}
		}

		// Token: 0x06004F8C RID: 20364 RVA: 0x000C21A2 File Offset: 0x000C03A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateCharacterRequest()
		{
		}

		// Token: 0x06004F8D RID: 20365 RVA: 0x000C21B5 File Offset: 0x000C03B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateCharacterRequest(CreateCharacterRequest other) : this()
		{
			this.sex_ = other.sex_;
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004F8E RID: 20366 RVA: 0x000C21E6 File Offset: 0x000C03E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateCharacterRequest Clone()
		{
			return new CreateCharacterRequest(this);
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06004F8F RID: 20367 RVA: 0x000C21EE File Offset: 0x000C03EE
		// (set) Token: 0x06004F90 RID: 20368 RVA: 0x000C21F6 File Offset: 0x000C03F6
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

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06004F91 RID: 20369 RVA: 0x000C21FF File Offset: 0x000C03FF
		// (set) Token: 0x06004F92 RID: 20370 RVA: 0x000C2207 File Offset: 0x000C0407
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

		// Token: 0x06004F93 RID: 20371 RVA: 0x000C221A File Offset: 0x000C041A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateCharacterRequest);
		}

		// Token: 0x06004F94 RID: 20372 RVA: 0x000C2228 File Offset: 0x000C0428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CreateCharacterRequest other)
		{
			return other != null && (other == this || (this.Sex == other.Sex && !(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004F95 RID: 20373 RVA: 0x000C2278 File Offset: 0x000C0478
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

		// Token: 0x06004F96 RID: 20374 RVA: 0x000C22D2 File Offset: 0x000C04D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004F97 RID: 20375 RVA: 0x000C22DF File Offset: 0x000C04DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004F98 RID: 20376 RVA: 0x000C22E8 File Offset: 0x000C04E8
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

		// Token: 0x06004F99 RID: 20377 RVA: 0x000C2348 File Offset: 0x000C0548
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

		// Token: 0x06004F9A RID: 20378 RVA: 0x000C23A4 File Offset: 0x000C05A4
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

		// Token: 0x06004F9B RID: 20379 RVA: 0x000C23F9 File Offset: 0x000C05F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004F9C RID: 20380 RVA: 0x000C2404 File Offset: 0x000C0604
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

		// Token: 0x0400321D RID: 12829
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400321E RID: 12830
		public const int SexFieldNumber = 1;

		// Token: 0x0400321F RID: 12831
		private int sex_;

		// Token: 0x04003220 RID: 12832
		public const int NameFieldNumber = 2;

		// Token: 0x04003221 RID: 12833
		private string name_ = "";
	}
}
