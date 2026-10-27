using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000474 RID: 1140
	[NetMessage(EMessageId.EntityBlackboardResponse)]
	public sealed class EntityBlackboardResponse : IMessage<EntityBlackboardResponse>, IMessage, IEquatable<EntityBlackboardResponse>, IDeepCloneable<EntityBlackboardResponse>, IBufferMessage
	{
		// Token: 0x06006CAC RID: 27820 RVA: 0x001065D4 File Offset: 0x001047D4
		[NullableContext(1)]
		public static EntityBlackboardResponse Create()
		{
			return new EntityBlackboardResponse();
		}

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x06006CAD RID: 27821 RVA: 0x001065DB File Offset: 0x001047DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x06006CAE RID: 27822 RVA: 0x001065DE File Offset: 0x001047DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBlackboardResponse.Descriptor;
			}
		}

		// Token: 0x06006CAF RID: 27823 RVA: 0x001065E5 File Offset: 0x001047E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBlackboardResponse()
		{
		}

		// Token: 0x06006CB0 RID: 27824 RVA: 0x001065ED File Offset: 0x001047ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBlackboardResponse(EntityBlackboardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006CB1 RID: 27825 RVA: 0x00106612 File Offset: 0x00104812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBlackboardResponse Clone()
		{
			return new EntityBlackboardResponse(this);
		}

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x06006CB2 RID: 27826 RVA: 0x0010661A File Offset: 0x0010481A
		// (set) Token: 0x06006CB3 RID: 27827 RVA: 0x00106622 File Offset: 0x00104822
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

		// Token: 0x06006CB4 RID: 27828 RVA: 0x0010662B File Offset: 0x0010482B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBlackboardResponse);
		}

		// Token: 0x06006CB5 RID: 27829 RVA: 0x00106639 File Offset: 0x00104839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBlackboardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006CB6 RID: 27830 RVA: 0x00106668 File Offset: 0x00104868
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

		// Token: 0x06006CB7 RID: 27831 RVA: 0x001066AD File Offset: 0x001048AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006CB8 RID: 27832 RVA: 0x001066BA File Offset: 0x001048BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006CB9 RID: 27833 RVA: 0x001066C3 File Offset: 0x001048C3
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

		// Token: 0x06006CBA RID: 27834 RVA: 0x001066F8 File Offset: 0x001048F8
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

		// Token: 0x06006CBB RID: 27835 RVA: 0x00106736 File Offset: 0x00104936
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

		// Token: 0x06006CBC RID: 27836 RVA: 0x00106767 File Offset: 0x00104967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006CBD RID: 27837 RVA: 0x00106770 File Offset: 0x00104970
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

		// Token: 0x04003B04 RID: 15108
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B05 RID: 15109
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04003B06 RID: 15110
		private ErrorCode errorCode_;
	}
}
