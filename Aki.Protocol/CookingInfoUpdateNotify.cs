using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002FA RID: 762
	[NetMessage(EMessageId.CookingInfoUpdateNotify)]
	public sealed class CookingInfoUpdateNotify : IMessage<CookingInfoUpdateNotify>, IMessage, IEquatable<CookingInfoUpdateNotify>, IDeepCloneable<CookingInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06004D1B RID: 19739 RVA: 0x000BB883 File Offset: 0x000B9A83
		[NullableContext(1)]
		public static CookingInfoUpdateNotify Create()
		{
			return new CookingInfoUpdateNotify();
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x06004D1C RID: 19740 RVA: 0x000BB88A File Offset: 0x000B9A8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x06004D1D RID: 19741 RVA: 0x000BB88D File Offset: 0x000B9A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CookingInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06004D1E RID: 19742 RVA: 0x000BB894 File Offset: 0x000B9A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingInfoUpdateNotify()
		{
		}

		// Token: 0x06004D1F RID: 19743 RVA: 0x000BB89C File Offset: 0x000B9A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingInfoUpdateNotify(CookingInfoUpdateNotify other) : this()
		{
			this.cookingInfo_ = ((other.cookingInfo_ != null) ? other.cookingInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004D20 RID: 19744 RVA: 0x000BB8D1 File Offset: 0x000B9AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingInfoUpdateNotify Clone()
		{
			return new CookingInfoUpdateNotify(this);
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x06004D21 RID: 19745 RVA: 0x000BB8D9 File Offset: 0x000B9AD9
		// (set) Token: 0x06004D22 RID: 19746 RVA: 0x000BB8E1 File Offset: 0x000B9AE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingInfo CookingInfo
		{
			get
			{
				return this.cookingInfo_;
			}
			set
			{
				this.cookingInfo_ = value;
			}
		}

		// Token: 0x06004D23 RID: 19747 RVA: 0x000BB8EA File Offset: 0x000B9AEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CookingInfoUpdateNotify);
		}

		// Token: 0x06004D24 RID: 19748 RVA: 0x000BB8F8 File Offset: 0x000B9AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CookingInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CookingInfo, other.CookingInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004D25 RID: 19749 RVA: 0x000BB92C File Offset: 0x000B9B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.cookingInfo_ != null)
			{
				num ^= this.CookingInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004D26 RID: 19750 RVA: 0x000BB968 File Offset: 0x000B9B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004D27 RID: 19751 RVA: 0x000BB975 File Offset: 0x000B9B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D28 RID: 19752 RVA: 0x000BB97E File Offset: 0x000B9B7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.cookingInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.CookingInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D29 RID: 19753 RVA: 0x000BB9B0 File Offset: 0x000B9BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.cookingInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CookingInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004D2A RID: 19754 RVA: 0x000BB9F0 File Offset: 0x000B9BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CookingInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.cookingInfo_ != null)
			{
				if (this.cookingInfo_ == null)
				{
					this.CookingInfo = new CookingInfo();
				}
				this.CookingInfo.MergeFrom(other.CookingInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004D2B RID: 19755 RVA: 0x000BBA44 File Offset: 0x000B9C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D2C RID: 19756 RVA: 0x000BBA50 File Offset: 0x000B9C50
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.cookingInfo_ == null)
					{
						this.CookingInfo = new CookingInfo();
					}
					input.ReadMessage(this.CookingInfo);
				}
			}
		}

		// Token: 0x04003136 RID: 12598
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003137 RID: 12599
		public const int CookingInfoFieldNumber = 13;

		// Token: 0x04003138 RID: 12600
		private CookingInfo cookingInfo_;
	}
}
