using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200025D RID: 605
	[NetMessage(EMessageId.ChangeStateConfirmNotify)]
	public sealed class ChangeStateConfirmNotify : IMessage<ChangeStateConfirmNotify>, IMessage, IEquatable<ChangeStateConfirmNotify>, IDeepCloneable<ChangeStateConfirmNotify>, IBufferMessage
	{
		// Token: 0x0600401D RID: 16413 RVA: 0x0009D78A File Offset: 0x0009B98A
		[NullableContext(1)]
		public static ChangeStateConfirmNotify Create()
		{
			return new ChangeStateConfirmNotify();
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x0600401E RID: 16414 RVA: 0x0009D791 File Offset: 0x0009B991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x0600401F RID: 16415 RVA: 0x0009D794 File Offset: 0x0009B994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeStateConfirmNotify.Descriptor;
			}
		}

		// Token: 0x06004020 RID: 16416 RVA: 0x0009D79B File Offset: 0x0009B99B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmNotify()
		{
		}

		// Token: 0x06004021 RID: 16417 RVA: 0x0009D7A3 File Offset: 0x0009B9A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmNotify(ChangeStateConfirmNotify other) : this()
		{
			this.fsmId_ = other.fsmId_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004022 RID: 16418 RVA: 0x0009D7D4 File Offset: 0x0009B9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmNotify Clone()
		{
			return new ChangeStateConfirmNotify(this);
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06004023 RID: 16419 RVA: 0x0009D7DC File Offset: 0x0009B9DC
		// (set) Token: 0x06004024 RID: 16420 RVA: 0x0009D7E4 File Offset: 0x0009B9E4
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

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06004025 RID: 16421 RVA: 0x0009D7ED File Offset: 0x0009B9ED
		// (set) Token: 0x06004026 RID: 16422 RVA: 0x0009D7F5 File Offset: 0x0009B9F5
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

		// Token: 0x06004027 RID: 16423 RVA: 0x0009D7FE File Offset: 0x0009B9FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeStateConfirmNotify);
		}

		// Token: 0x06004028 RID: 16424 RVA: 0x0009D80C File Offset: 0x0009BA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeStateConfirmNotify other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004029 RID: 16425 RVA: 0x0009D84C File Offset: 0x0009BA4C
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

		// Token: 0x0600402A RID: 16426 RVA: 0x0009D8A4 File Offset: 0x0009BAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600402B RID: 16427 RVA: 0x0009D8B1 File Offset: 0x0009BAB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600402C RID: 16428 RVA: 0x0009D8BC File Offset: 0x0009BABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FsmId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.FsmId);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600402D RID: 16429 RVA: 0x0009D918 File Offset: 0x0009BB18
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

		// Token: 0x0600402E RID: 16430 RVA: 0x0009D970 File Offset: 0x0009BB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeStateConfirmNotify other)
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

		// Token: 0x0600402F RID: 16431 RVA: 0x0009D9C0 File Offset: 0x0009BBC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004030 RID: 16432 RVA: 0x0009D9CC File Offset: 0x0009BBCC
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
				if (num != 24U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.State = input.ReadInt32();
					}
				}
				else
				{
					this.FsmId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002D4A RID: 11594
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D4B RID: 11595
		public const int FsmIdFieldNumber = 3;

		// Token: 0x04002D4C RID: 11596
		private int fsmId_;

		// Token: 0x04002D4D RID: 11597
		public const int StateFieldNumber = 11;

		// Token: 0x04002D4E RID: 11598
		private int state_;
	}
}
