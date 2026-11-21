using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000492 RID: 1170
	[NetMessage(EMessageId.EntityPatrolAddTagResponse)]
	public sealed class EntityPatrolAddTagResponse : IMessage<EntityPatrolAddTagResponse>, IMessage, IEquatable<EntityPatrolAddTagResponse>, IDeepCloneable<EntityPatrolAddTagResponse>, IBufferMessage
	{
		// Token: 0x06007027 RID: 28711 RVA: 0x00113CE9 File Offset: 0x00111EE9
		[NullableContext(1)]
		public static EntityPatrolAddTagResponse Create()
		{
			return new EntityPatrolAddTagResponse();
		}

		// Token: 0x1700159B RID: 5531
		// (get) Token: 0x06007028 RID: 28712 RVA: 0x00113CF0 File Offset: 0x00111EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700159C RID: 5532
		// (get) Token: 0x06007029 RID: 28713 RVA: 0x00113CF3 File Offset: 0x00111EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPatrolAddTagResponse.Descriptor;
			}
		}

		// Token: 0x0600702A RID: 28714 RVA: 0x00113CFA File Offset: 0x00111EFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolAddTagResponse()
		{
		}

		// Token: 0x0600702B RID: 28715 RVA: 0x00113D02 File Offset: 0x00111F02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolAddTagResponse(EntityPatrolAddTagResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600702C RID: 28716 RVA: 0x00113D27 File Offset: 0x00111F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolAddTagResponse Clone()
		{
			return new EntityPatrolAddTagResponse(this);
		}

		// Token: 0x1700159D RID: 5533
		// (get) Token: 0x0600702D RID: 28717 RVA: 0x00113D2F File Offset: 0x00111F2F
		// (set) Token: 0x0600702E RID: 28718 RVA: 0x00113D37 File Offset: 0x00111F37
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

		// Token: 0x0600702F RID: 28719 RVA: 0x00113D40 File Offset: 0x00111F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPatrolAddTagResponse);
		}

		// Token: 0x06007030 RID: 28720 RVA: 0x00113D4E File Offset: 0x00111F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPatrolAddTagResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007031 RID: 28721 RVA: 0x00113D7C File Offset: 0x00111F7C
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

		// Token: 0x06007032 RID: 28722 RVA: 0x00113DC1 File Offset: 0x00111FC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007033 RID: 28723 RVA: 0x00113DCE File Offset: 0x00111FCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007034 RID: 28724 RVA: 0x00113DD7 File Offset: 0x00111FD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007035 RID: 28725 RVA: 0x00113E0C File Offset: 0x0011200C
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

		// Token: 0x06007036 RID: 28726 RVA: 0x00113E4A File Offset: 0x0011204A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityPatrolAddTagResponse other)
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

		// Token: 0x06007037 RID: 28727 RVA: 0x00113E7B File Offset: 0x0011207B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007038 RID: 28728 RVA: 0x00113E84 File Offset: 0x00112084
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003C83 RID: 15491
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C84 RID: 15492
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04003C85 RID: 15493
		private ErrorCode errorCode_;
	}
}
