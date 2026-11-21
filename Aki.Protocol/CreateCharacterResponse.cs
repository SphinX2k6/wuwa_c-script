using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200031C RID: 796
	[NetMessage(EMessageId.CreateCharacterResponse)]
	public sealed class CreateCharacterResponse : IMessage<CreateCharacterResponse>, IMessage, IEquatable<CreateCharacterResponse>, IDeepCloneable<CreateCharacterResponse>, IBufferMessage
	{
		// Token: 0x06005076 RID: 20598 RVA: 0x000C4847 File Offset: 0x000C2A47
		[NullableContext(1)]
		public static CreateCharacterResponse Create()
		{
			return new CreateCharacterResponse();
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06005077 RID: 20599 RVA: 0x000C484E File Offset: 0x000C2A4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x06005078 RID: 20600 RVA: 0x000C4851 File Offset: 0x000C2A51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateCharacterResponse.Descriptor;
			}
		}

		// Token: 0x06005079 RID: 20601 RVA: 0x000C4858 File Offset: 0x000C2A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateCharacterResponse()
		{
		}

		// Token: 0x0600507A RID: 20602 RVA: 0x000C486C File Offset: 0x000C2A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateCharacterResponse(CreateCharacterResponse other) : this()
		{
			this.code_ = other.code_;
			this.name_ = other.name_;
			this.playerId_ = other.playerId_;
			this.createTime_ = other.createTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600507B RID: 20603 RVA: 0x000C48C0 File Offset: 0x000C2AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateCharacterResponse Clone()
		{
			return new CreateCharacterResponse(this);
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x0600507C RID: 20604 RVA: 0x000C48C8 File Offset: 0x000C2AC8
		// (set) Token: 0x0600507D RID: 20605 RVA: 0x000C48D0 File Offset: 0x000C2AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x0600507E RID: 20606 RVA: 0x000C48D9 File Offset: 0x000C2AD9
		// (set) Token: 0x0600507F RID: 20607 RVA: 0x000C48E1 File Offset: 0x000C2AE1
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

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06005080 RID: 20608 RVA: 0x000C48F4 File Offset: 0x000C2AF4
		// (set) Token: 0x06005081 RID: 20609 RVA: 0x000C48FC File Offset: 0x000C2AFC
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

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06005082 RID: 20610 RVA: 0x000C4905 File Offset: 0x000C2B05
		// (set) Token: 0x06005083 RID: 20611 RVA: 0x000C490D File Offset: 0x000C2B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CreateTime
		{
			get
			{
				return this.createTime_;
			}
			set
			{
				this.createTime_ = value;
			}
		}

		// Token: 0x06005084 RID: 20612 RVA: 0x000C4916 File Offset: 0x000C2B16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateCharacterResponse);
		}

		// Token: 0x06005085 RID: 20613 RVA: 0x000C4924 File Offset: 0x000C2B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CreateCharacterResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && !(this.Name != other.Name) && this.PlayerId == other.PlayerId && this.CreateTime == other.CreateTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005086 RID: 20614 RVA: 0x000C4994 File Offset: 0x000C2B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.CreateTime != 0)
			{
				num ^= this.CreateTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005087 RID: 20615 RVA: 0x000C4A26 File Offset: 0x000C2C26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005088 RID: 20616 RVA: 0x000C4A33 File Offset: 0x000C2C33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005089 RID: 20617 RVA: 0x000C4A3C File Offset: 0x000C2C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Code);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayerId);
			}
			if (this.CreateTime != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CreateTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600508A RID: 20618 RVA: 0x000C4AD4 File Offset: 0x000C2CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.CreateTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CreateTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600508B RID: 20619 RVA: 0x000C4B60 File Offset: 0x000C2D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CreateCharacterResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.CreateTime != 0)
			{
				this.CreateTime = other.CreateTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600508C RID: 20620 RVA: 0x000C4BDD File Offset: 0x000C2DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600508D RID: 20621 RVA: 0x000C4BE8 File Offset: 0x000C2DE8
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 18U)
					{
						this.Name = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.CreateTime = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040032B9 RID: 12985
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032BA RID: 12986
		public const int CodeFieldNumber = 1;

		// Token: 0x040032BB RID: 12987
		private ErrorCode code_;

		// Token: 0x040032BC RID: 12988
		public const int NameFieldNumber = 2;

		// Token: 0x040032BD RID: 12989
		private string name_ = "";

		// Token: 0x040032BE RID: 12990
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x040032BF RID: 12991
		private int playerId_;

		// Token: 0x040032C0 RID: 12992
		public const int CreateTimeFieldNumber = 4;

		// Token: 0x040032C1 RID: 12993
		private int createTime_;
	}
}
