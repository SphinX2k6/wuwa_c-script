using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011FB RID: 4603
	[NetMessage(EMessageId.ShopUpdateResponse)]
	public sealed class ShopUpdateResponse : IMessage<ShopUpdateResponse>, IMessage, IEquatable<ShopUpdateResponse>, IDeepCloneable<ShopUpdateResponse>, IBufferMessage
	{
		// Token: 0x060188A7 RID: 100519 RVA: 0x00391B55 File Offset: 0x0038FD55
		[NullableContext(1)]
		public static ShopUpdateResponse Create()
		{
			return new ShopUpdateResponse();
		}

		// Token: 0x170052AC RID: 21164
		// (get) Token: 0x060188A8 RID: 100520 RVA: 0x00391B5C File Offset: 0x0038FD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052AD RID: 21165
		// (get) Token: 0x060188A9 RID: 100521 RVA: 0x00391B5F File Offset: 0x0038FD5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopUpdateResponse.Descriptor;
			}
		}

		// Token: 0x060188AA RID: 100522 RVA: 0x00391B66 File Offset: 0x0038FD66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopUpdateResponse()
		{
		}

		// Token: 0x060188AB RID: 100523 RVA: 0x00391B70 File Offset: 0x0038FD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopUpdateResponse(ShopUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060188AC RID: 100524 RVA: 0x00391BBC File Offset: 0x0038FDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopUpdateResponse Clone()
		{
			return new ShopUpdateResponse(this);
		}

		// Token: 0x170052AE RID: 21166
		// (get) Token: 0x060188AD RID: 100525 RVA: 0x00391BC4 File Offset: 0x0038FDC4
		// (set) Token: 0x060188AE RID: 100526 RVA: 0x00391BCC File Offset: 0x0038FDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170052AF RID: 21167
		// (get) Token: 0x060188AF RID: 100527 RVA: 0x00391BD5 File Offset: 0x0038FDD5
		// (set) Token: 0x060188B0 RID: 100528 RVA: 0x00391BDD File Offset: 0x0038FDDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x060188B1 RID: 100529 RVA: 0x00391BE6 File Offset: 0x0038FDE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopUpdateResponse);
		}

		// Token: 0x060188B2 RID: 100530 RVA: 0x00391BF4 File Offset: 0x0038FDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Info, other.Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060188B3 RID: 100531 RVA: 0x00391C44 File Offset: 0x0038FE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060188B4 RID: 100532 RVA: 0x00391C9F File Offset: 0x0038FE9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060188B5 RID: 100533 RVA: 0x00391CAC File Offset: 0x0038FEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060188B6 RID: 100534 RVA: 0x00391CB8 File Offset: 0x0038FEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.info_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060188B7 RID: 100535 RVA: 0x00391D14 File Offset: 0x0038FF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060188B8 RID: 100536 RVA: 0x00391D6C File Offset: 0x0038FF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShopUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new ShopInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060188B9 RID: 100537 RVA: 0x00391DD4 File Offset: 0x0038FFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060188BA RID: 100538 RVA: 0x00391DE0 File Offset: 0x0038FFE0
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
				if (num != 64U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.info_ == null)
						{
							this.Info = new ShopInfo();
						}
						input.ReadMessage(this.Info);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009112 RID: 37138
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009113 RID: 37139
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04009114 RID: 37140
		private ErrorCode errorCode_;

		// Token: 0x04009115 RID: 37141
		public const int InfoFieldNumber = 15;

		// Token: 0x04009116 RID: 37142
		private ShopInfo info_;
	}
}
