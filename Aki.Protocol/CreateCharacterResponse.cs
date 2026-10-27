using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000315 RID: 789
	[NetMessage(EMessageId.CreateCharacterResponse)]
	public sealed class CreateCharacterResponse : IMessage<CreateCharacterResponse>, IMessage, IEquatable<CreateCharacterResponse>, IDeepCloneable<CreateCharacterResponse>, IBufferMessage
	{
		// Token: 0x06004F9D RID: 20381 RVA: 0x000C245B File Offset: 0x000C065B
		[NullableContext(1)]
		public static CreateCharacterResponse Create()
		{
			return new CreateCharacterResponse();
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x06004F9E RID: 20382 RVA: 0x000C2462 File Offset: 0x000C0662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06004F9F RID: 20383 RVA: 0x000C2465 File Offset: 0x000C0665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateCharacterResponse.Descriptor;
			}
		}

		// Token: 0x06004FA0 RID: 20384 RVA: 0x000C246C File Offset: 0x000C066C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateCharacterResponse()
		{
		}

		// Token: 0x06004FA1 RID: 20385 RVA: 0x000C2480 File Offset: 0x000C0680
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

		// Token: 0x06004FA2 RID: 20386 RVA: 0x000C24D4 File Offset: 0x000C06D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateCharacterResponse Clone()
		{
			return new CreateCharacterResponse(this);
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06004FA3 RID: 20387 RVA: 0x000C24DC File Offset: 0x000C06DC
		// (set) Token: 0x06004FA4 RID: 20388 RVA: 0x000C24E4 File Offset: 0x000C06E4
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

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06004FA5 RID: 20389 RVA: 0x000C24ED File Offset: 0x000C06ED
		// (set) Token: 0x06004FA6 RID: 20390 RVA: 0x000C24F5 File Offset: 0x000C06F5
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

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06004FA7 RID: 20391 RVA: 0x000C2508 File Offset: 0x000C0708
		// (set) Token: 0x06004FA8 RID: 20392 RVA: 0x000C2510 File Offset: 0x000C0710
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

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06004FA9 RID: 20393 RVA: 0x000C2519 File Offset: 0x000C0719
		// (set) Token: 0x06004FAA RID: 20394 RVA: 0x000C2521 File Offset: 0x000C0721
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

		// Token: 0x06004FAB RID: 20395 RVA: 0x000C252A File Offset: 0x000C072A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateCharacterResponse);
		}

		// Token: 0x06004FAC RID: 20396 RVA: 0x000C2538 File Offset: 0x000C0738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CreateCharacterResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && !(this.Name != other.Name) && this.PlayerId == other.PlayerId && this.CreateTime == other.CreateTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004FAD RID: 20397 RVA: 0x000C25A8 File Offset: 0x000C07A8
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

		// Token: 0x06004FAE RID: 20398 RVA: 0x000C263A File Offset: 0x000C083A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004FAF RID: 20399 RVA: 0x000C2647 File Offset: 0x000C0847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004FB0 RID: 20400 RVA: 0x000C2650 File Offset: 0x000C0850
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

		// Token: 0x06004FB1 RID: 20401 RVA: 0x000C26E8 File Offset: 0x000C08E8
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

		// Token: 0x06004FB2 RID: 20402 RVA: 0x000C2774 File Offset: 0x000C0974
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

		// Token: 0x06004FB3 RID: 20403 RVA: 0x000C27F1 File Offset: 0x000C09F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004FB4 RID: 20404 RVA: 0x000C27FC File Offset: 0x000C09FC
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

		// Token: 0x04003222 RID: 12834
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003223 RID: 12835
		public const int CodeFieldNumber = 1;

		// Token: 0x04003224 RID: 12836
		private ErrorCode code_;

		// Token: 0x04003225 RID: 12837
		public const int NameFieldNumber = 2;

		// Token: 0x04003226 RID: 12838
		private string name_ = "";

		// Token: 0x04003227 RID: 12839
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x04003228 RID: 12840
		private int playerId_;

		// Token: 0x04003229 RID: 12841
		public const int CreateTimeFieldNumber = 4;

		// Token: 0x0400322A RID: 12842
		private int createTime_;
	}
}
