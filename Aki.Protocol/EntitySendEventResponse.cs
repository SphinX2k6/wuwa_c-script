using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004A8 RID: 1192
	[NetMessage(EMessageId.EntitySendEventResponse)]
	public sealed class EntitySendEventResponse : IMessage<EntitySendEventResponse>, IMessage, IEquatable<EntitySendEventResponse>, IDeepCloneable<EntitySendEventResponse>, IBufferMessage
	{
		// Token: 0x06007206 RID: 29190 RVA: 0x00118404 File Offset: 0x00116604
		[NullableContext(1)]
		public static EntitySendEventResponse Create()
		{
			return new EntitySendEventResponse();
		}

		// Token: 0x17001607 RID: 5639
		// (get) Token: 0x06007207 RID: 29191 RVA: 0x0011840B File Offset: 0x0011660B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x06007208 RID: 29192 RVA: 0x0011840E File Offset: 0x0011660E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntitySendEventResponse.Descriptor;
			}
		}

		// Token: 0x06007209 RID: 29193 RVA: 0x00118415 File Offset: 0x00116615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySendEventResponse()
		{
		}

		// Token: 0x0600720A RID: 29194 RVA: 0x0011841D File Offset: 0x0011661D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySendEventResponse(EntitySendEventResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600720B RID: 29195 RVA: 0x00118442 File Offset: 0x00116642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySendEventResponse Clone()
		{
			return new EntitySendEventResponse(this);
		}

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x0600720C RID: 29196 RVA: 0x0011844A File Offset: 0x0011664A
		// (set) Token: 0x0600720D RID: 29197 RVA: 0x00118452 File Offset: 0x00116652
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

		// Token: 0x0600720E RID: 29198 RVA: 0x0011845B File Offset: 0x0011665B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntitySendEventResponse);
		}

		// Token: 0x0600720F RID: 29199 RVA: 0x00118469 File Offset: 0x00116669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntitySendEventResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007210 RID: 29200 RVA: 0x00118498 File Offset: 0x00116698
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

		// Token: 0x06007211 RID: 29201 RVA: 0x001184DD File Offset: 0x001166DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007212 RID: 29202 RVA: 0x001184EA File Offset: 0x001166EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007213 RID: 29203 RVA: 0x001184F3 File Offset: 0x001166F3
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

		// Token: 0x06007214 RID: 29204 RVA: 0x00118528 File Offset: 0x00116728
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

		// Token: 0x06007215 RID: 29205 RVA: 0x00118566 File Offset: 0x00116766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntitySendEventResponse other)
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

		// Token: 0x06007216 RID: 29206 RVA: 0x00118597 File Offset: 0x00116797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007217 RID: 29207 RVA: 0x001185A0 File Offset: 0x001167A0
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

		// Token: 0x04003D1A RID: 15642
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D1B RID: 15643
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04003D1C RID: 15644
		private ErrorCode errorCode_;
	}
}
