using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200144C RID: 5196
	[NetMessage(EMessageId.TrapDefenseSlotUpdateResponse)]
	public sealed class TrapDefenseSlotUpdateResponse : IMessage<TrapDefenseSlotUpdateResponse>, IMessage, IEquatable<TrapDefenseSlotUpdateResponse>, IDeepCloneable<TrapDefenseSlotUpdateResponse>, IBufferMessage
	{
		// Token: 0x0601B854 RID: 112724 RVA: 0x003FC01D File Offset: 0x003FA21D
		[NullableContext(1)]
		public static TrapDefenseSlotUpdateResponse Create()
		{
			return new TrapDefenseSlotUpdateResponse();
		}

		// Token: 0x17005CCE RID: 23758
		// (get) Token: 0x0601B855 RID: 112725 RVA: 0x003FC024 File Offset: 0x003FA224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CCF RID: 23759
		// (get) Token: 0x0601B856 RID: 112726 RVA: 0x003FC027 File Offset: 0x003FA227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSlotUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0601B857 RID: 112727 RVA: 0x003FC02E File Offset: 0x003FA22E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSlotUpdateResponse()
		{
		}

		// Token: 0x0601B858 RID: 112728 RVA: 0x003FC036 File Offset: 0x003FA236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSlotUpdateResponse(TrapDefenseSlotUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B859 RID: 112729 RVA: 0x003FC05B File Offset: 0x003FA25B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSlotUpdateResponse Clone()
		{
			return new TrapDefenseSlotUpdateResponse(this);
		}

		// Token: 0x17005CD0 RID: 23760
		// (get) Token: 0x0601B85A RID: 112730 RVA: 0x003FC063 File Offset: 0x003FA263
		// (set) Token: 0x0601B85B RID: 112731 RVA: 0x003FC06B File Offset: 0x003FA26B
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

		// Token: 0x0601B85C RID: 112732 RVA: 0x003FC074 File Offset: 0x003FA274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSlotUpdateResponse);
		}

		// Token: 0x0601B85D RID: 112733 RVA: 0x003FC082 File Offset: 0x003FA282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSlotUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B85E RID: 112734 RVA: 0x003FC0B0 File Offset: 0x003FA2B0
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

		// Token: 0x0601B85F RID: 112735 RVA: 0x003FC0F5 File Offset: 0x003FA2F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B860 RID: 112736 RVA: 0x003FC102 File Offset: 0x003FA302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B861 RID: 112737 RVA: 0x003FC10B File Offset: 0x003FA30B
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

		// Token: 0x0601B862 RID: 112738 RVA: 0x003FC140 File Offset: 0x003FA340
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

		// Token: 0x0601B863 RID: 112739 RVA: 0x003FC17E File Offset: 0x003FA37E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseSlotUpdateResponse other)
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

		// Token: 0x0601B864 RID: 112740 RVA: 0x003FC1AF File Offset: 0x003FA3AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B865 RID: 112741 RVA: 0x003FC1B8 File Offset: 0x003FA3B8
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

		// Token: 0x04009EBA RID: 40634
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009EBB RID: 40635
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04009EBC RID: 40636
		private ErrorCode errorCode_;
	}
}
