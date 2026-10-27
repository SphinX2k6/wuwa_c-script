using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001445 RID: 5189
	[NetMessage(EMessageId.TrapDefenseSelectGainingGroupResponse)]
	public sealed class TrapDefenseSelectGainingGroupResponse : IMessage<TrapDefenseSelectGainingGroupResponse>, IMessage, IEquatable<TrapDefenseSelectGainingGroupResponse>, IDeepCloneable<TrapDefenseSelectGainingGroupResponse>, IBufferMessage
	{
		// Token: 0x0601B7BA RID: 112570 RVA: 0x003FA9B1 File Offset: 0x003F8BB1
		[NullableContext(1)]
		public static TrapDefenseSelectGainingGroupResponse Create()
		{
			return new TrapDefenseSelectGainingGroupResponse();
		}

		// Token: 0x17005CAB RID: 23723
		// (get) Token: 0x0601B7BB RID: 112571 RVA: 0x003FA9B8 File Offset: 0x003F8BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CAC RID: 23724
		// (get) Token: 0x0601B7BC RID: 112572 RVA: 0x003FA9BB File Offset: 0x003F8BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSelectGainingGroupResponse.Descriptor;
			}
		}

		// Token: 0x0601B7BD RID: 112573 RVA: 0x003FA9C2 File Offset: 0x003F8BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSelectGainingGroupResponse()
		{
		}

		// Token: 0x0601B7BE RID: 112574 RVA: 0x003FA9CA File Offset: 0x003F8BCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSelectGainingGroupResponse(TrapDefenseSelectGainingGroupResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B7BF RID: 112575 RVA: 0x003FA9EF File Offset: 0x003F8BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSelectGainingGroupResponse Clone()
		{
			return new TrapDefenseSelectGainingGroupResponse(this);
		}

		// Token: 0x17005CAD RID: 23725
		// (get) Token: 0x0601B7C0 RID: 112576 RVA: 0x003FA9F7 File Offset: 0x003F8BF7
		// (set) Token: 0x0601B7C1 RID: 112577 RVA: 0x003FA9FF File Offset: 0x003F8BFF
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

		// Token: 0x0601B7C2 RID: 112578 RVA: 0x003FAA08 File Offset: 0x003F8C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSelectGainingGroupResponse);
		}

		// Token: 0x0601B7C3 RID: 112579 RVA: 0x003FAA16 File Offset: 0x003F8C16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSelectGainingGroupResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B7C4 RID: 112580 RVA: 0x003FAA44 File Offset: 0x003F8C44
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

		// Token: 0x0601B7C5 RID: 112581 RVA: 0x003FAA89 File Offset: 0x003F8C89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B7C6 RID: 112582 RVA: 0x003FAA96 File Offset: 0x003F8C96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B7C7 RID: 112583 RVA: 0x003FAA9F File Offset: 0x003F8C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B7C8 RID: 112584 RVA: 0x003FAAD4 File Offset: 0x003F8CD4
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

		// Token: 0x0601B7C9 RID: 112585 RVA: 0x003FAB12 File Offset: 0x003F8D12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseSelectGainingGroupResponse other)
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

		// Token: 0x0601B7CA RID: 112586 RVA: 0x003FAB43 File Offset: 0x003F8D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B7CB RID: 112587 RVA: 0x003FAB4C File Offset: 0x003F8D4C
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009E8D RID: 40589
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E8E RID: 40590
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04009E8F RID: 40591
		private ErrorCode errorCode_;
	}
}
