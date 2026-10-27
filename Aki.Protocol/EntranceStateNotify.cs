using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004D0 RID: 1232
	[NetMessage(EMessageId.EntranceStateNotify)]
	public sealed class EntranceStateNotify : IMessage<EntranceStateNotify>, IMessage, IEquatable<EntranceStateNotify>, IDeepCloneable<EntranceStateNotify>, IBufferMessage
	{
		// Token: 0x06007508 RID: 29960 RVA: 0x0011EA98 File Offset: 0x0011CC98
		[NullableContext(1)]
		public static EntranceStateNotify Create()
		{
			return new EntranceStateNotify();
		}

		// Token: 0x170016AF RID: 5807
		// (get) Token: 0x06007509 RID: 29961 RVA: 0x0011EA9F File Offset: 0x0011CC9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016B0 RID: 5808
		// (get) Token: 0x0600750A RID: 29962 RVA: 0x0011EAA2 File Offset: 0x0011CCA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntranceStateNotify.Descriptor;
			}
		}

		// Token: 0x0600750B RID: 29963 RVA: 0x0011EAA9 File Offset: 0x0011CCA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntranceStateNotify()
		{
		}

		// Token: 0x0600750C RID: 29964 RVA: 0x0011EAB1 File Offset: 0x0011CCB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntranceStateNotify(EntranceStateNotify other) : this()
		{
			this.id_ = other.id_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600750D RID: 29965 RVA: 0x0011EAE2 File Offset: 0x0011CCE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntranceStateNotify Clone()
		{
			return new EntranceStateNotify(this);
		}

		// Token: 0x170016B1 RID: 5809
		// (get) Token: 0x0600750E RID: 29966 RVA: 0x0011EAEA File Offset: 0x0011CCEA
		// (set) Token: 0x0600750F RID: 29967 RVA: 0x0011EAF2 File Offset: 0x0011CCF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170016B2 RID: 5810
		// (get) Token: 0x06007510 RID: 29968 RVA: 0x0011EAFB File Offset: 0x0011CCFB
		// (set) Token: 0x06007511 RID: 29969 RVA: 0x0011EB03 File Offset: 0x0011CD03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntranceState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x06007512 RID: 29970 RVA: 0x0011EB0C File Offset: 0x0011CD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntranceStateNotify);
		}

		// Token: 0x06007513 RID: 29971 RVA: 0x0011EB1A File Offset: 0x0011CD1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntranceStateNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007514 RID: 29972 RVA: 0x0011EB58 File Offset: 0x0011CD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.State != EntranceState.NotUnlock)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007515 RID: 29973 RVA: 0x0011EBB6 File Offset: 0x0011CDB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007516 RID: 29974 RVA: 0x0011EBC3 File Offset: 0x0011CDC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007517 RID: 29975 RVA: 0x0011EBCC File Offset: 0x0011CDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.Id);
			}
			if (this.State != EntranceState.NotUnlock)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007518 RID: 29976 RVA: 0x0011EC24 File Offset: 0x0011CE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.State != EntranceState.NotUnlock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007519 RID: 29977 RVA: 0x0011EC7C File Offset: 0x0011CE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntranceStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.State != EntranceState.NotUnlock)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600751A RID: 29978 RVA: 0x0011ECCC File Offset: 0x0011CECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600751B RID: 29979 RVA: 0x0011ECD8 File Offset: 0x0011CED8
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
				if (num != 8U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.State = (EntranceState)input.ReadEnum();
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003D95 RID: 15765
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D96 RID: 15766
		public const int IdFieldNumber = 1;

		// Token: 0x04003D97 RID: 15767
		private long id_;

		// Token: 0x04003D98 RID: 15768
		public const int StateFieldNumber = 6;

		// Token: 0x04003D99 RID: 15769
		private EntranceState state_;
	}
}
