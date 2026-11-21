using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006AC RID: 1708
	[NetMessage(EMessageId.GetAdventureRewardResponse)]
	public sealed class GetAdventureRewardResponse : IMessage<GetAdventureRewardResponse>, IMessage, IEquatable<GetAdventureRewardResponse>, IDeepCloneable<GetAdventureRewardResponse>, IBufferMessage
	{
		// Token: 0x06009CDB RID: 40155 RVA: 0x0017D6C9 File Offset: 0x0017B8C9
		[NullableContext(1)]
		public static GetAdventureRewardResponse Create()
		{
			return new GetAdventureRewardResponse();
		}

		// Token: 0x17001F81 RID: 8065
		// (get) Token: 0x06009CDC RID: 40156 RVA: 0x0017D6D0 File Offset: 0x0017B8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F82 RID: 8066
		// (get) Token: 0x06009CDD RID: 40157 RVA: 0x0017D6D3 File Offset: 0x0017B8D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAdventureRewardResponse.Descriptor;
			}
		}

		// Token: 0x06009CDE RID: 40158 RVA: 0x0017D6DA File Offset: 0x0017B8DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAdventureRewardResponse()
		{
		}

		// Token: 0x06009CDF RID: 40159 RVA: 0x0017D6E2 File Offset: 0x0017B8E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAdventureRewardResponse(GetAdventureRewardResponse other) : this()
		{
			this.code_ = other.code_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009CE0 RID: 40160 RVA: 0x0017D713 File Offset: 0x0017B913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAdventureRewardResponse Clone()
		{
			return new GetAdventureRewardResponse(this);
		}

		// Token: 0x17001F83 RID: 8067
		// (get) Token: 0x06009CE1 RID: 40161 RVA: 0x0017D71B File Offset: 0x0017B91B
		// (set) Token: 0x06009CE2 RID: 40162 RVA: 0x0017D723 File Offset: 0x0017B923
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

		// Token: 0x17001F84 RID: 8068
		// (get) Token: 0x06009CE3 RID: 40163 RVA: 0x0017D72C File Offset: 0x0017B92C
		// (set) Token: 0x06009CE4 RID: 40164 RVA: 0x0017D734 File Offset: 0x0017B934
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

		// Token: 0x06009CE5 RID: 40165 RVA: 0x0017D73D File Offset: 0x0017B93D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAdventureRewardResponse);
		}

		// Token: 0x06009CE6 RID: 40166 RVA: 0x0017D74B File Offset: 0x0017B94B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAdventureRewardResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009CE7 RID: 40167 RVA: 0x0017D78C File Offset: 0x0017B98C
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

		// Token: 0x06009CE8 RID: 40168 RVA: 0x0017D7EA File Offset: 0x0017B9EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009CE9 RID: 40169 RVA: 0x0017D7F7 File Offset: 0x0017B9F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009CEA RID: 40170 RVA: 0x0017D800 File Offset: 0x0017BA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Id);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009CEB RID: 40171 RVA: 0x0017D85C File Offset: 0x0017BA5C
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

		// Token: 0x06009CEC RID: 40172 RVA: 0x0017D8B4 File Offset: 0x0017BAB4
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

		// Token: 0x06009CED RID: 40173 RVA: 0x0017D904 File Offset: 0x0017BB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009CEE RID: 40174 RVA: 0x0017D910 File Offset: 0x0017BB10
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
				if (num != 72U)
				{
					if (num != 96U)
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

		// Token: 0x04004A1D RID: 18973
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A1E RID: 18974
		public const int CodeFieldNumber = 12;

		// Token: 0x04004A1F RID: 18975
		private ErrorCode code_;

		// Token: 0x04004A20 RID: 18976
		public const int IdFieldNumber = 9;

		// Token: 0x04004A21 RID: 18977
		private int id_;
	}
}
