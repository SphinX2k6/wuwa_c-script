using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011EE RID: 4590
	[NetMessage(EMessageId.ShopBuyNotify)]
	public sealed class ShopBuyNotify : IMessage<ShopBuyNotify>, IMessage, IEquatable<ShopBuyNotify>, IDeepCloneable<ShopBuyNotify>, IBufferMessage
	{
		// Token: 0x0601877A RID: 100218 RVA: 0x0038EABD File Offset: 0x0038CCBD
		[NullableContext(1)]
		public static ShopBuyNotify Create()
		{
			return new ShopBuyNotify();
		}

		// Token: 0x17005262 RID: 21090
		// (get) Token: 0x0601877B RID: 100219 RVA: 0x0038EAC4 File Offset: 0x0038CCC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005263 RID: 21091
		// (get) Token: 0x0601877C RID: 100220 RVA: 0x0038EAC7 File Offset: 0x0038CCC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopBuyNotify.Descriptor;
			}
		}

		// Token: 0x0601877D RID: 100221 RVA: 0x0038EACE File Offset: 0x0038CCCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopBuyNotify()
		{
		}

		// Token: 0x0601877E RID: 100222 RVA: 0x0038EAD6 File Offset: 0x0038CCD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopBuyNotify(ShopBuyNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601877F RID: 100223 RVA: 0x0038EB07 File Offset: 0x0038CD07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopBuyNotify Clone()
		{
			return new ShopBuyNotify(this);
		}

		// Token: 0x17005264 RID: 21092
		// (get) Token: 0x06018780 RID: 100224 RVA: 0x0038EB0F File Offset: 0x0038CD0F
		// (set) Token: 0x06018781 RID: 100225 RVA: 0x0038EB17 File Offset: 0x0038CD17
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

		// Token: 0x17005265 RID: 21093
		// (get) Token: 0x06018782 RID: 100226 RVA: 0x0038EB20 File Offset: 0x0038CD20
		// (set) Token: 0x06018783 RID: 100227 RVA: 0x0038EB28 File Offset: 0x0038CD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x06018784 RID: 100228 RVA: 0x0038EB31 File Offset: 0x0038CD31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopBuyNotify);
		}

		// Token: 0x06018785 RID: 100229 RVA: 0x0038EB3F File Offset: 0x0038CD3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopBuyNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018786 RID: 100230 RVA: 0x0038EB80 File Offset: 0x0038CD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.EntityId != 0)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018787 RID: 100231 RVA: 0x0038EBDE File Offset: 0x0038CDDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018788 RID: 100232 RVA: 0x0038EBEB File Offset: 0x0038CDEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018789 RID: 100233 RVA: 0x0038EBF4 File Offset: 0x0038CDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.EntityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601878A RID: 100234 RVA: 0x0038EC50 File Offset: 0x0038CE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.EntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601878B RID: 100235 RVA: 0x0038ECA8 File Offset: 0x0038CEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShopBuyNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.EntityId != 0)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601878C RID: 100236 RVA: 0x0038ECF8 File Offset: 0x0038CEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601878D RID: 100237 RVA: 0x0038ED04 File Offset: 0x0038CF04
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
				if (num != 88U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040090A2 RID: 37026
		private UnknownFieldSet _unknownFields;

		// Token: 0x040090A3 RID: 37027
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040090A4 RID: 37028
		private ErrorCode errorCode_;

		// Token: 0x040090A5 RID: 37029
		public const int EntityIdFieldNumber = 13;

		// Token: 0x040090A6 RID: 37030
		private int entityId_;
	}
}
