using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DD2 RID: 3538
	[NetMessage(EMessageId.PrivateChatOperateRequest)]
	public sealed class PrivateChatOperateRequest : IMessage<PrivateChatOperateRequest>, IMessage, IEquatable<PrivateChatOperateRequest>, IDeepCloneable<PrivateChatOperateRequest>, IBufferMessage
	{
		// Token: 0x0601310D RID: 78093 RVA: 0x002C7A43 File Offset: 0x002C5C43
		[NullableContext(1)]
		public static PrivateChatOperateRequest Create()
		{
			return new PrivateChatOperateRequest();
		}

		// Token: 0x17003F45 RID: 16197
		// (get) Token: 0x0601310E RID: 78094 RVA: 0x002C7A4A File Offset: 0x002C5C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F46 RID: 16198
		// (get) Token: 0x0601310F RID: 78095 RVA: 0x002C7A4D File Offset: 0x002C5C4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateChatOperateRequest.Descriptor;
			}
		}

		// Token: 0x06013110 RID: 78096 RVA: 0x002C7A54 File Offset: 0x002C5C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatOperateRequest()
		{
		}

		// Token: 0x06013111 RID: 78097 RVA: 0x002C7A5C File Offset: 0x002C5C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatOperateRequest(PrivateChatOperateRequest other) : this()
		{
			this.operateType_ = other.operateType_;
			this.tarPlayerId_ = other.tarPlayerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013112 RID: 78098 RVA: 0x002C7A8D File Offset: 0x002C5C8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatOperateRequest Clone()
		{
			return new PrivateChatOperateRequest(this);
		}

		// Token: 0x17003F47 RID: 16199
		// (get) Token: 0x06013113 RID: 78099 RVA: 0x002C7A95 File Offset: 0x002C5C95
		// (set) Token: 0x06013114 RID: 78100 RVA: 0x002C7A9D File Offset: 0x002C5C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatOperateType OperateType
		{
			get
			{
				return this.operateType_;
			}
			set
			{
				this.operateType_ = value;
			}
		}

		// Token: 0x17003F48 RID: 16200
		// (get) Token: 0x06013115 RID: 78101 RVA: 0x002C7AA6 File Offset: 0x002C5CA6
		// (set) Token: 0x06013116 RID: 78102 RVA: 0x002C7AAE File Offset: 0x002C5CAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TarPlayerId
		{
			get
			{
				return this.tarPlayerId_;
			}
			set
			{
				this.tarPlayerId_ = value;
			}
		}

		// Token: 0x06013117 RID: 78103 RVA: 0x002C7AB7 File Offset: 0x002C5CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateChatOperateRequest);
		}

		// Token: 0x06013118 RID: 78104 RVA: 0x002C7AC5 File Offset: 0x002C5CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateChatOperateRequest other)
		{
			return other != null && (other == this || (this.OperateType == other.OperateType && this.TarPlayerId == other.TarPlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013119 RID: 78105 RVA: 0x002C7B04 File Offset: 0x002C5D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OperateType != PrivateChatOperateType.CloseChat)
			{
				num ^= this.OperateType.GetHashCode();
			}
			if (this.TarPlayerId != 0)
			{
				num ^= this.TarPlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601311A RID: 78106 RVA: 0x002C7B62 File Offset: 0x002C5D62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601311B RID: 78107 RVA: 0x002C7B6F File Offset: 0x002C5D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601311C RID: 78108 RVA: 0x002C7B78 File Offset: 0x002C5D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OperateType != PrivateChatOperateType.CloseChat)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.OperateType);
			}
			if (this.TarPlayerId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.TarPlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601311D RID: 78109 RVA: 0x002C7BD4 File Offset: 0x002C5DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OperateType != PrivateChatOperateType.CloseChat)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.OperateType);
			}
			if (this.TarPlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TarPlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601311E RID: 78110 RVA: 0x002C7C2C File Offset: 0x002C5E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrivateChatOperateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OperateType != PrivateChatOperateType.CloseChat)
			{
				this.OperateType = other.OperateType;
			}
			if (other.TarPlayerId != 0)
			{
				this.TarPlayerId = other.TarPlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601311F RID: 78111 RVA: 0x002C7C7C File Offset: 0x002C5E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013120 RID: 78112 RVA: 0x002C7C88 File Offset: 0x002C5E88
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TarPlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.OperateType = (PrivateChatOperateType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007603 RID: 30211
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007604 RID: 30212
		public const int OperateTypeFieldNumber = 5;

		// Token: 0x04007605 RID: 30213
		private PrivateChatOperateType operateType_;

		// Token: 0x04007606 RID: 30214
		public const int TarPlayerIdFieldNumber = 15;

		// Token: 0x04007607 RID: 30215
		private int tarPlayerId_;
	}
}
