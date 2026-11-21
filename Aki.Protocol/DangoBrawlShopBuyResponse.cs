using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000376 RID: 886
	[NetMessage(EMessageId.DangoBrawlShopBuyResponse)]
	public sealed class DangoBrawlShopBuyResponse : IMessage<DangoBrawlShopBuyResponse>, IMessage, IEquatable<DangoBrawlShopBuyResponse>, IDeepCloneable<DangoBrawlShopBuyResponse>, IBufferMessage
	{
		// Token: 0x0600584D RID: 22605 RVA: 0x000D7D46 File Offset: 0x000D5F46
		[NullableContext(1)]
		public static DangoBrawlShopBuyResponse Create()
		{
			return new DangoBrawlShopBuyResponse();
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x0600584E RID: 22606 RVA: 0x000D7D4D File Offset: 0x000D5F4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x0600584F RID: 22607 RVA: 0x000D7D50 File Offset: 0x000D5F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlShopBuyResponse.Descriptor;
			}
		}

		// Token: 0x06005850 RID: 22608 RVA: 0x000D7D57 File Offset: 0x000D5F57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopBuyResponse()
		{
		}

		// Token: 0x06005851 RID: 22609 RVA: 0x000D7D5F File Offset: 0x000D5F5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopBuyResponse(DangoBrawlShopBuyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.useServerBagUpdate_ = other.useServerBagUpdate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005852 RID: 22610 RVA: 0x000D7D90 File Offset: 0x000D5F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopBuyResponse Clone()
		{
			return new DangoBrawlShopBuyResponse(this);
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x06005853 RID: 22611 RVA: 0x000D7D98 File Offset: 0x000D5F98
		// (set) Token: 0x06005854 RID: 22612 RVA: 0x000D7DA0 File Offset: 0x000D5FA0
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

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x06005855 RID: 22613 RVA: 0x000D7DA9 File Offset: 0x000D5FA9
		// (set) Token: 0x06005856 RID: 22614 RVA: 0x000D7DB1 File Offset: 0x000D5FB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool UseServerBagUpdate
		{
			get
			{
				return this.useServerBagUpdate_;
			}
			set
			{
				this.useServerBagUpdate_ = value;
			}
		}

		// Token: 0x06005857 RID: 22615 RVA: 0x000D7DBA File Offset: 0x000D5FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlShopBuyResponse);
		}

		// Token: 0x06005858 RID: 22616 RVA: 0x000D7DC8 File Offset: 0x000D5FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlShopBuyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.UseServerBagUpdate == other.UseServerBagUpdate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005859 RID: 22617 RVA: 0x000D7E08 File Offset: 0x000D6008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.UseServerBagUpdate)
			{
				num ^= this.UseServerBagUpdate.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600585A RID: 22618 RVA: 0x000D7E66 File Offset: 0x000D6066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600585B RID: 22619 RVA: 0x000D7E73 File Offset: 0x000D6073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600585C RID: 22620 RVA: 0x000D7E7C File Offset: 0x000D607C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.UseServerBagUpdate)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.UseServerBagUpdate);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600585D RID: 22621 RVA: 0x000D7ED8 File Offset: 0x000D60D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.UseServerBagUpdate)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600585E RID: 22622 RVA: 0x000D7F24 File Offset: 0x000D6124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlShopBuyResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.UseServerBagUpdate)
			{
				this.UseServerBagUpdate = other.UseServerBagUpdate;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600585F RID: 22623 RVA: 0x000D7F74 File Offset: 0x000D6174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005860 RID: 22624 RVA: 0x000D7F80 File Offset: 0x000D6180
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
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.UseServerBagUpdate = input.ReadBool();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003569 RID: 13673
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400356A RID: 13674
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x0400356B RID: 13675
		private ErrorCode errorCode_;

		// Token: 0x0400356C RID: 13676
		public const int UseServerBagUpdateFieldNumber = 6;

		// Token: 0x0400356D RID: 13677
		private bool useServerBagUpdate_;
	}
}
