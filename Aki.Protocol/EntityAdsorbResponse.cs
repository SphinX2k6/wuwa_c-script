using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000452 RID: 1106
	[NetMessage(EMessageId.EntityAdsorbResponse)]
	public sealed class EntityAdsorbResponse : IMessage<EntityAdsorbResponse>, IMessage, IEquatable<EntityAdsorbResponse>, IDeepCloneable<EntityAdsorbResponse>, IBufferMessage
	{
		// Token: 0x06006A26 RID: 27174 RVA: 0x00100CC1 File Offset: 0x000FEEC1
		[NullableContext(1)]
		public static EntityAdsorbResponse Create()
		{
			return new EntityAdsorbResponse();
		}

		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x06006A27 RID: 27175 RVA: 0x00100CC8 File Offset: 0x000FEEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x06006A28 RID: 27176 RVA: 0x00100CCB File Offset: 0x000FEECB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityAdsorbResponse.Descriptor;
			}
		}

		// Token: 0x06006A29 RID: 27177 RVA: 0x00100CD2 File Offset: 0x000FEED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAdsorbResponse()
		{
		}

		// Token: 0x06006A2A RID: 27178 RVA: 0x00100CDA File Offset: 0x000FEEDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAdsorbResponse(EntityAdsorbResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A2B RID: 27179 RVA: 0x00100CFF File Offset: 0x000FEEFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAdsorbResponse Clone()
		{
			return new EntityAdsorbResponse(this);
		}

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x06006A2C RID: 27180 RVA: 0x00100D07 File Offset: 0x000FEF07
		// (set) Token: 0x06006A2D RID: 27181 RVA: 0x00100D0F File Offset: 0x000FEF0F
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

		// Token: 0x06006A2E RID: 27182 RVA: 0x00100D18 File Offset: 0x000FEF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityAdsorbResponse);
		}

		// Token: 0x06006A2F RID: 27183 RVA: 0x00100D26 File Offset: 0x000FEF26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityAdsorbResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006A30 RID: 27184 RVA: 0x00100D54 File Offset: 0x000FEF54
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

		// Token: 0x06006A31 RID: 27185 RVA: 0x00100D99 File Offset: 0x000FEF99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006A32 RID: 27186 RVA: 0x00100DA6 File Offset: 0x000FEFA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A33 RID: 27187 RVA: 0x00100DAF File Offset: 0x000FEFAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A34 RID: 27188 RVA: 0x00100DE4 File Offset: 0x000FEFE4
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

		// Token: 0x06006A35 RID: 27189 RVA: 0x00100E22 File Offset: 0x000FF022
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

		// Token: 0x06006A36 RID: 27190 RVA: 0x00100E53 File Offset: 0x000FF053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006A37 RID: 27191 RVA: 0x00100E5C File Offset: 0x000FF05C
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003A99 RID: 15001
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A9A RID: 15002
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04003A9B RID: 15003
		private ErrorCode errorCode_;
	}
}
