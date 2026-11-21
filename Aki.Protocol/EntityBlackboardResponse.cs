using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200045D RID: 1117
	[NetMessage(EMessageId.EntityBlackboardResponse)]
	public sealed class EntityBlackboardResponse : IMessage<EntityBlackboardResponse>, IMessage, IEquatable<EntityBlackboardResponse>, IDeepCloneable<EntityBlackboardResponse>, IBufferMessage
	{
		// Token: 0x06006B1E RID: 27422 RVA: 0x00103560 File Offset: 0x00101760
		[NullableContext(1)]
		public static EntityBlackboardResponse Create()
		{
			return new EntityBlackboardResponse();
		}

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x06006B1F RID: 27423 RVA: 0x00103567 File Offset: 0x00101767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x06006B20 RID: 27424 RVA: 0x0010356A File Offset: 0x0010176A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBlackboardResponse.Descriptor;
			}
		}

		// Token: 0x06006B21 RID: 27425 RVA: 0x00103571 File Offset: 0x00101771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBlackboardResponse()
		{
		}

		// Token: 0x06006B22 RID: 27426 RVA: 0x00103579 File Offset: 0x00101779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBlackboardResponse(EntityBlackboardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006B23 RID: 27427 RVA: 0x0010359E File Offset: 0x0010179E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBlackboardResponse Clone()
		{
			return new EntityBlackboardResponse(this);
		}

		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x06006B24 RID: 27428 RVA: 0x001035A6 File Offset: 0x001017A6
		// (set) Token: 0x06006B25 RID: 27429 RVA: 0x001035AE File Offset: 0x001017AE
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

		// Token: 0x06006B26 RID: 27430 RVA: 0x001035B7 File Offset: 0x001017B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBlackboardResponse);
		}

		// Token: 0x06006B27 RID: 27431 RVA: 0x001035C5 File Offset: 0x001017C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBlackboardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006B28 RID: 27432 RVA: 0x001035F4 File Offset: 0x001017F4
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

		// Token: 0x06006B29 RID: 27433 RVA: 0x00103639 File Offset: 0x00101839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006B2A RID: 27434 RVA: 0x00103646 File Offset: 0x00101846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B2B RID: 27435 RVA: 0x0010364F File Offset: 0x0010184F
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

		// Token: 0x06006B2C RID: 27436 RVA: 0x00103684 File Offset: 0x00101884
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

		// Token: 0x06006B2D RID: 27437 RVA: 0x001036C2 File Offset: 0x001018C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityBlackboardResponse other)
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

		// Token: 0x06006B2E RID: 27438 RVA: 0x001036F3 File Offset: 0x001018F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B2F RID: 27439 RVA: 0x001036FC File Offset: 0x001018FC
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

		// Token: 0x04003AF2 RID: 15090
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AF3 RID: 15091
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04003AF4 RID: 15092
		private ErrorCode errorCode_;
	}
}
