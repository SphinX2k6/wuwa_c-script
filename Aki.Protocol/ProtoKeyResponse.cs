using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DDC RID: 3548
	[NetMessage(EMessageId.ProtoKeyResponse)]
	public sealed class ProtoKeyResponse : IMessage<ProtoKeyResponse>, IMessage, IEquatable<ProtoKeyResponse>, IDeepCloneable<ProtoKeyResponse>, IBufferMessage
	{
		// Token: 0x060131DC RID: 78300 RVA: 0x002C96B7 File Offset: 0x002C78B7
		[NullableContext(1)]
		public static ProtoKeyResponse Create()
		{
			return new ProtoKeyResponse();
		}

		// Token: 0x17003F71 RID: 16241
		// (get) Token: 0x060131DD RID: 78301 RVA: 0x002C96BE File Offset: 0x002C78BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F72 RID: 16242
		// (get) Token: 0x060131DE RID: 78302 RVA: 0x002C96C1 File Offset: 0x002C78C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProtoKeyResponse.Descriptor;
			}
		}

		// Token: 0x060131DF RID: 78303 RVA: 0x002C96C8 File Offset: 0x002C78C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ProtoKeyResponse()
		{
		}

		// Token: 0x060131E0 RID: 78304 RVA: 0x002C96DB File Offset: 0x002C78DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ProtoKeyResponse(ProtoKeyResponse other) : this()
		{
			this.code_ = other.code_;
			this.type_ = other.type_;
			this.key_ = other.key_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060131E1 RID: 78305 RVA: 0x002C9718 File Offset: 0x002C7918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ProtoKeyResponse Clone()
		{
			return new ProtoKeyResponse(this);
		}

		// Token: 0x17003F73 RID: 16243
		// (get) Token: 0x060131E2 RID: 78306 RVA: 0x002C9720 File Offset: 0x002C7920
		// (set) Token: 0x060131E3 RID: 78307 RVA: 0x002C9728 File Offset: 0x002C7928
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

		// Token: 0x17003F74 RID: 16244
		// (get) Token: 0x060131E4 RID: 78308 RVA: 0x002C9731 File Offset: 0x002C7931
		// (set) Token: 0x060131E5 RID: 78309 RVA: 0x002C9739 File Offset: 0x002C7939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17003F75 RID: 16245
		// (get) Token: 0x060131E6 RID: 78310 RVA: 0x002C9742 File Offset: 0x002C7942
		// (set) Token: 0x060131E7 RID: 78311 RVA: 0x002C974A File Offset: 0x002C794A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString Key
		{
			get
			{
				return this.key_;
			}
			set
			{
				this.key_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x060131E8 RID: 78312 RVA: 0x002C975D File Offset: 0x002C795D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ProtoKeyResponse);
		}

		// Token: 0x060131E9 RID: 78313 RVA: 0x002C976C File Offset: 0x002C796C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ProtoKeyResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Type == other.Type && !(this.Key != other.Key) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060131EA RID: 78314 RVA: 0x002C97CC File Offset: 0x002C79CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Key.Length != 0)
			{
				num ^= this.Key.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060131EB RID: 78315 RVA: 0x002C9845 File Offset: 0x002C7A45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060131EC RID: 78316 RVA: 0x002C9852 File Offset: 0x002C7A52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060131ED RID: 78317 RVA: 0x002C985C File Offset: 0x002C7A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Code);
			}
			if (this.Type != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Type);
			}
			if (this.Key.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.Key);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060131EE RID: 78318 RVA: 0x002C98D8 File Offset: 0x002C7AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.Key.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Key);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060131EF RID: 78319 RVA: 0x002C994C File Offset: 0x002C7B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ProtoKeyResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.Key.Length != 0)
			{
				this.Key = other.Key;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060131F0 RID: 78320 RVA: 0x002C99B5 File Offset: 0x002C7BB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060131F1 RID: 78321 RVA: 0x002C99C0 File Offset: 0x002C7BC0
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
					if (num != 16U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Key = input.ReadBytes();
						}
					}
					else
					{
						this.Type = input.ReadInt32();
					}
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400763D RID: 30269
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400763E RID: 30270
		public const int CodeFieldNumber = 1;

		// Token: 0x0400763F RID: 30271
		private ErrorCode code_;

		// Token: 0x04007640 RID: 30272
		public const int TypeFieldNumber = 2;

		// Token: 0x04007641 RID: 30273
		private int type_;

		// Token: 0x04007642 RID: 30274
		public const int KeyFieldNumber = 3;

		// Token: 0x04007643 RID: 30275
		private ByteString key_ = ByteString.Empty;
	}
}
