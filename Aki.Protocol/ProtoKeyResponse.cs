using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DEC RID: 3564
	[NetMessage(EMessageId.ProtoKeyResponse)]
	public sealed class ProtoKeyResponse : IMessage<ProtoKeyResponse>, IMessage, IEquatable<ProtoKeyResponse>, IDeepCloneable<ProtoKeyResponse>, IBufferMessage
	{
		// Token: 0x060132C1 RID: 78529 RVA: 0x002CAD7B File Offset: 0x002C8F7B
		[NullableContext(1)]
		public static ProtoKeyResponse Create()
		{
			return new ProtoKeyResponse();
		}

		// Token: 0x17003F9B RID: 16283
		// (get) Token: 0x060132C2 RID: 78530 RVA: 0x002CAD82 File Offset: 0x002C8F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F9C RID: 16284
		// (get) Token: 0x060132C3 RID: 78531 RVA: 0x002CAD85 File Offset: 0x002C8F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProtoKeyResponse.Descriptor;
			}
		}

		// Token: 0x060132C4 RID: 78532 RVA: 0x002CAD8C File Offset: 0x002C8F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ProtoKeyResponse()
		{
		}

		// Token: 0x060132C5 RID: 78533 RVA: 0x002CAD9F File Offset: 0x002C8F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ProtoKeyResponse(ProtoKeyResponse other) : this()
		{
			this.code_ = other.code_;
			this.type_ = other.type_;
			this.key_ = other.key_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060132C6 RID: 78534 RVA: 0x002CADDC File Offset: 0x002C8FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ProtoKeyResponse Clone()
		{
			return new ProtoKeyResponse(this);
		}

		// Token: 0x17003F9D RID: 16285
		// (get) Token: 0x060132C7 RID: 78535 RVA: 0x002CADE4 File Offset: 0x002C8FE4
		// (set) Token: 0x060132C8 RID: 78536 RVA: 0x002CADEC File Offset: 0x002C8FEC
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

		// Token: 0x17003F9E RID: 16286
		// (get) Token: 0x060132C9 RID: 78537 RVA: 0x002CADF5 File Offset: 0x002C8FF5
		// (set) Token: 0x060132CA RID: 78538 RVA: 0x002CADFD File Offset: 0x002C8FFD
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

		// Token: 0x17003F9F RID: 16287
		// (get) Token: 0x060132CB RID: 78539 RVA: 0x002CAE06 File Offset: 0x002C9006
		// (set) Token: 0x060132CC RID: 78540 RVA: 0x002CAE0E File Offset: 0x002C900E
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

		// Token: 0x060132CD RID: 78541 RVA: 0x002CAE21 File Offset: 0x002C9021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ProtoKeyResponse);
		}

		// Token: 0x060132CE RID: 78542 RVA: 0x002CAE30 File Offset: 0x002C9030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ProtoKeyResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Type == other.Type && !(this.Key != other.Key) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060132CF RID: 78543 RVA: 0x002CAE90 File Offset: 0x002C9090
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

		// Token: 0x060132D0 RID: 78544 RVA: 0x002CAF09 File Offset: 0x002C9109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060132D1 RID: 78545 RVA: 0x002CAF16 File Offset: 0x002C9116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060132D2 RID: 78546 RVA: 0x002CAF20 File Offset: 0x002C9120
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

		// Token: 0x060132D3 RID: 78547 RVA: 0x002CAF9C File Offset: 0x002C919C
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

		// Token: 0x060132D4 RID: 78548 RVA: 0x002CB010 File Offset: 0x002C9210
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

		// Token: 0x060132D5 RID: 78549 RVA: 0x002CB079 File Offset: 0x002C9279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060132D6 RID: 78550 RVA: 0x002CB084 File Offset: 0x002C9284
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

		// Token: 0x04007613 RID: 30227
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007614 RID: 30228
		public const int CodeFieldNumber = 1;

		// Token: 0x04007615 RID: 30229
		private ErrorCode code_;

		// Token: 0x04007616 RID: 30230
		public const int TypeFieldNumber = 2;

		// Token: 0x04007617 RID: 30231
		private int type_;

		// Token: 0x04007618 RID: 30232
		public const int KeyFieldNumber = 3;

		// Token: 0x04007619 RID: 30233
		private ByteString key_ = ByteString.Empty;
	}
}
