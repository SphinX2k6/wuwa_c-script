using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200025E RID: 606
	[NetMessage(EMessageId.ChangeStateConfirmPush)]
	public sealed class ChangeStateConfirmPush : IMessage<ChangeStateConfirmPush>, IMessage, IEquatable<ChangeStateConfirmPush>, IDeepCloneable<ChangeStateConfirmPush>, IBufferMessage
	{
		// Token: 0x06004031 RID: 16433 RVA: 0x0009DA24 File Offset: 0x0009BC24
		[NullableContext(1)]
		public static ChangeStateConfirmPush Create()
		{
			return new ChangeStateConfirmPush();
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06004032 RID: 16434 RVA: 0x0009DA2B File Offset: 0x0009BC2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06004033 RID: 16435 RVA: 0x0009DA2E File Offset: 0x0009BC2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeStateConfirmPush.Descriptor;
			}
		}

		// Token: 0x06004034 RID: 16436 RVA: 0x0009DA35 File Offset: 0x0009BC35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmPush()
		{
		}

		// Token: 0x06004035 RID: 16437 RVA: 0x0009DA3D File Offset: 0x0009BC3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmPush(ChangeStateConfirmPush other) : this()
		{
			this.fsmId_ = other.fsmId_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004036 RID: 16438 RVA: 0x0009DA6E File Offset: 0x0009BC6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmPush Clone()
		{
			return new ChangeStateConfirmPush(this);
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06004037 RID: 16439 RVA: 0x0009DA76 File Offset: 0x0009BC76
		// (set) Token: 0x06004038 RID: 16440 RVA: 0x0009DA7E File Offset: 0x0009BC7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FsmId
		{
			get
			{
				return this.fsmId_;
			}
			set
			{
				this.fsmId_ = value;
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06004039 RID: 16441 RVA: 0x0009DA87 File Offset: 0x0009BC87
		// (set) Token: 0x0600403A RID: 16442 RVA: 0x0009DA8F File Offset: 0x0009BC8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int State
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

		// Token: 0x0600403B RID: 16443 RVA: 0x0009DA98 File Offset: 0x0009BC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeStateConfirmPush);
		}

		// Token: 0x0600403C RID: 16444 RVA: 0x0009DAA6 File Offset: 0x0009BCA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeStateConfirmPush other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600403D RID: 16445 RVA: 0x0009DAE4 File Offset: 0x0009BCE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FsmId != 0)
			{
				num ^= this.FsmId.GetHashCode();
			}
			if (this.State != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600403E RID: 16446 RVA: 0x0009DB3C File Offset: 0x0009BD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600403F RID: 16447 RVA: 0x0009DB49 File Offset: 0x0009BD49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004040 RID: 16448 RVA: 0x0009DB54 File Offset: 0x0009BD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.State != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.State);
			}
			if (this.FsmId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.FsmId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004041 RID: 16449 RVA: 0x0009DBAC File Offset: 0x0009BDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FsmId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FsmId);
			}
			if (this.State != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004042 RID: 16450 RVA: 0x0009DC04 File Offset: 0x0009BE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeStateConfirmPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FsmId != 0)
			{
				this.FsmId = other.FsmId;
			}
			if (other.State != 0)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004043 RID: 16451 RVA: 0x0009DC54 File Offset: 0x0009BE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004044 RID: 16452 RVA: 0x0009DC60 File Offset: 0x0009BE60
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FsmId = input.ReadInt32();
					}
				}
				else
				{
					this.State = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002D4F RID: 11599
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D50 RID: 11600
		public const int FsmIdFieldNumber = 2;

		// Token: 0x04002D51 RID: 11601
		private int fsmId_;

		// Token: 0x04002D52 RID: 11602
		public const int StateFieldNumber = 1;

		// Token: 0x04002D53 RID: 11603
		private int state_;
	}
}
