using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000469 RID: 1129
	[NetMessage(EMessageId.EntityAdsorbResponse)]
	public sealed class EntityAdsorbResponse : IMessage<EntityAdsorbResponse>, IMessage, IEquatable<EntityAdsorbResponse>, IDeepCloneable<EntityAdsorbResponse>, IBufferMessage
	{
		// Token: 0x06006BB4 RID: 27572 RVA: 0x00103D31 File Offset: 0x00101F31
		[NullableContext(1)]
		public static EntityAdsorbResponse Create()
		{
			return new EntityAdsorbResponse();
		}

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x06006BB5 RID: 27573 RVA: 0x00103D38 File Offset: 0x00101F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x06006BB6 RID: 27574 RVA: 0x00103D3B File Offset: 0x00101F3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityAdsorbResponse.Descriptor;
			}
		}

		// Token: 0x06006BB7 RID: 27575 RVA: 0x00103D42 File Offset: 0x00101F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAdsorbResponse()
		{
		}

		// Token: 0x06006BB8 RID: 27576 RVA: 0x00103D4A File Offset: 0x00101F4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAdsorbResponse(EntityAdsorbResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006BB9 RID: 27577 RVA: 0x00103D6F File Offset: 0x00101F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAdsorbResponse Clone()
		{
			return new EntityAdsorbResponse(this);
		}

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x06006BBA RID: 27578 RVA: 0x00103D77 File Offset: 0x00101F77
		// (set) Token: 0x06006BBB RID: 27579 RVA: 0x00103D7F File Offset: 0x00101F7F
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

		// Token: 0x06006BBC RID: 27580 RVA: 0x00103D88 File Offset: 0x00101F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityAdsorbResponse);
		}

		// Token: 0x06006BBD RID: 27581 RVA: 0x00103D96 File Offset: 0x00101F96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityAdsorbResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006BBE RID: 27582 RVA: 0x00103DC4 File Offset: 0x00101FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006BBF RID: 27583 RVA: 0x00103E09 File Offset: 0x00102009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006BC0 RID: 27584 RVA: 0x00103E16 File Offset: 0x00102016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006BC1 RID: 27585 RVA: 0x00103E1F File Offset: 0x0010201F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006BC2 RID: 27586 RVA: 0x00103E54 File Offset: 0x00102054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006BC3 RID: 27587 RVA: 0x00103E92 File Offset: 0x00102092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityAdsorbResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006BC4 RID: 27588 RVA: 0x00103EC3 File Offset: 0x001020C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006BC5 RID: 27589 RVA: 0x00103ECC File Offset: 0x001020CC
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003AAB RID: 15019
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AAC RID: 15020
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04003AAD RID: 15021
		private ErrorCode errorCode_;
	}
}
