using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006C0 RID: 1728
	[NetMessage(EMessageId.GetAdventureRewardResponse)]
	public sealed class GetAdventureRewardResponse : IMessage<GetAdventureRewardResponse>, IMessage, IEquatable<GetAdventureRewardResponse>, IDeepCloneable<GetAdventureRewardResponse>, IBufferMessage
	{
		// Token: 0x06009E31 RID: 40497 RVA: 0x001800F9 File Offset: 0x0017E2F9
		[NullableContext(1)]
		public static GetAdventureRewardResponse Create()
		{
			return new GetAdventureRewardResponse();
		}

		// Token: 0x17001FCB RID: 8139
		// (get) Token: 0x06009E32 RID: 40498 RVA: 0x00180100 File Offset: 0x0017E300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FCC RID: 8140
		// (get) Token: 0x06009E33 RID: 40499 RVA: 0x00180103 File Offset: 0x0017E303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAdventureRewardResponse.Descriptor;
			}
		}

		// Token: 0x06009E34 RID: 40500 RVA: 0x0018010A File Offset: 0x0017E30A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAdventureRewardResponse()
		{
		}

		// Token: 0x06009E35 RID: 40501 RVA: 0x00180112 File Offset: 0x0017E312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAdventureRewardResponse(GetAdventureRewardResponse other) : this()
		{
			this.code_ = other.code_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E36 RID: 40502 RVA: 0x00180143 File Offset: 0x0017E343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAdventureRewardResponse Clone()
		{
			return new GetAdventureRewardResponse(this);
		}

		// Token: 0x17001FCD RID: 8141
		// (get) Token: 0x06009E37 RID: 40503 RVA: 0x0018014B File Offset: 0x0017E34B
		// (set) Token: 0x06009E38 RID: 40504 RVA: 0x00180153 File Offset: 0x0017E353
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

		// Token: 0x17001FCE RID: 8142
		// (get) Token: 0x06009E39 RID: 40505 RVA: 0x0018015C File Offset: 0x0017E35C
		// (set) Token: 0x06009E3A RID: 40506 RVA: 0x00180164 File Offset: 0x0017E364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
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

		// Token: 0x06009E3B RID: 40507 RVA: 0x0018016D File Offset: 0x0017E36D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAdventureRewardResponse);
		}

		// Token: 0x06009E3C RID: 40508 RVA: 0x0018017B File Offset: 0x0017E37B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAdventureRewardResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009E3D RID: 40509 RVA: 0x001801BC File Offset: 0x0017E3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009E3E RID: 40510 RVA: 0x0018021A File Offset: 0x0017E41A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009E3F RID: 40511 RVA: 0x00180227 File Offset: 0x0017E427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E40 RID: 40512 RVA: 0x00180230 File Offset: 0x0017E430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009E41 RID: 40513 RVA: 0x0018028C File Offset: 0x0017E48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009E42 RID: 40514 RVA: 0x001802E4 File Offset: 0x0017E4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetAdventureRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009E43 RID: 40515 RVA: 0x00180334 File Offset: 0x0017E534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E44 RID: 40516 RVA: 0x00180340 File Offset: 0x0017E540
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Code = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004A24 RID: 18980
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A25 RID: 18981
		public const int CodeFieldNumber = 15;

		// Token: 0x04004A26 RID: 18982
		private ErrorCode code_;

		// Token: 0x04004A27 RID: 18983
		public const int IdFieldNumber = 2;

		// Token: 0x04004A28 RID: 18984
		private int id_;
	}
}
