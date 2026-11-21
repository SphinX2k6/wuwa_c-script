using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000472 RID: 1138
	[NetMessage(EMessageId.EntityEnterVehicleResponse)]
	public sealed class EntityEnterVehicleResponse : IMessage<EntityEnterVehicleResponse>, IMessage, IEquatable<EntityEnterVehicleResponse>, IDeepCloneable<EntityEnterVehicleResponse>, IBufferMessage
	{
		// Token: 0x06006D92 RID: 28050 RVA: 0x0010DE5D File Offset: 0x0010C05D
		[NullableContext(1)]
		public static EntityEnterVehicleResponse Create()
		{
			return new EntityEnterVehicleResponse();
		}

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x06006D93 RID: 28051 RVA: 0x0010DE64 File Offset: 0x0010C064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x06006D94 RID: 28052 RVA: 0x0010DE67 File Offset: 0x0010C067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityEnterVehicleResponse.Descriptor;
			}
		}

		// Token: 0x06006D95 RID: 28053 RVA: 0x0010DE6E File Offset: 0x0010C06E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityEnterVehicleResponse()
		{
		}

		// Token: 0x06006D96 RID: 28054 RVA: 0x0010DE76 File Offset: 0x0010C076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityEnterVehicleResponse(EntityEnterVehicleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006D97 RID: 28055 RVA: 0x0010DE9B File Offset: 0x0010C09B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityEnterVehicleResponse Clone()
		{
			return new EntityEnterVehicleResponse(this);
		}

		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x06006D98 RID: 28056 RVA: 0x0010DEA3 File Offset: 0x0010C0A3
		// (set) Token: 0x06006D99 RID: 28057 RVA: 0x0010DEAB File Offset: 0x0010C0AB
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

		// Token: 0x06006D9A RID: 28058 RVA: 0x0010DEB4 File Offset: 0x0010C0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityEnterVehicleResponse);
		}

		// Token: 0x06006D9B RID: 28059 RVA: 0x0010DEC2 File Offset: 0x0010C0C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityEnterVehicleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006D9C RID: 28060 RVA: 0x0010DEF0 File Offset: 0x0010C0F0
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

		// Token: 0x06006D9D RID: 28061 RVA: 0x0010DF35 File Offset: 0x0010C135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006D9E RID: 28062 RVA: 0x0010DF42 File Offset: 0x0010C142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006D9F RID: 28063 RVA: 0x0010DF4B File Offset: 0x0010C14B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006DA0 RID: 28064 RVA: 0x0010DF80 File Offset: 0x0010C180
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

		// Token: 0x06006DA1 RID: 28065 RVA: 0x0010DFBE File Offset: 0x0010C1BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityEnterVehicleResponse other)
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

		// Token: 0x06006DA2 RID: 28066 RVA: 0x0010DFEF File Offset: 0x0010C1EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006DA3 RID: 28067 RVA: 0x0010DFF8 File Offset: 0x0010C1F8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003BC8 RID: 15304
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BC9 RID: 15305
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04003BCA RID: 15306
		private ErrorCode errorCode_;
	}
}
