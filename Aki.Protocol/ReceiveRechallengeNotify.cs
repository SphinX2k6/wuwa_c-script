using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ECD RID: 3789
	[NetMessage(EMessageId.ReceiveRechallengeNotify)]
	public sealed class ReceiveRechallengeNotify : IMessage<ReceiveRechallengeNotify>, IMessage, IEquatable<ReceiveRechallengeNotify>, IDeepCloneable<ReceiveRechallengeNotify>, IBufferMessage
	{
		// Token: 0x060144FE RID: 83198 RVA: 0x002F3A6A File Offset: 0x002F1C6A
		[NullableContext(1)]
		public static ReceiveRechallengeNotify Create()
		{
			return new ReceiveRechallengeNotify();
		}

		// Token: 0x17004384 RID: 17284
		// (get) Token: 0x060144FF RID: 83199 RVA: 0x002F3A71 File Offset: 0x002F1C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004385 RID: 17285
		// (get) Token: 0x06014500 RID: 83200 RVA: 0x002F3A74 File Offset: 0x002F1C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReceiveRechallengeNotify.Descriptor;
			}
		}

		// Token: 0x06014501 RID: 83201 RVA: 0x002F3A7B File Offset: 0x002F1C7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceiveRechallengeNotify()
		{
		}

		// Token: 0x06014502 RID: 83202 RVA: 0x002F3A83 File Offset: 0x002F1C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceiveRechallengeNotify(ReceiveRechallengeNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.result_ = other.result_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014503 RID: 83203 RVA: 0x002F3AB4 File Offset: 0x002F1CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceiveRechallengeNotify Clone()
		{
			return new ReceiveRechallengeNotify(this);
		}

		// Token: 0x17004386 RID: 17286
		// (get) Token: 0x06014504 RID: 83204 RVA: 0x002F3ABC File Offset: 0x002F1CBC
		// (set) Token: 0x06014505 RID: 83205 RVA: 0x002F3AC4 File Offset: 0x002F1CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17004387 RID: 17287
		// (get) Token: 0x06014506 RID: 83206 RVA: 0x002F3ACD File Offset: 0x002F1CCD
		// (set) Token: 0x06014507 RID: 83207 RVA: 0x002F3AD5 File Offset: 0x002F1CD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ERechallengeResultResult Result
		{
			get
			{
				return this.result_;
			}
			set
			{
				this.result_ = value;
			}
		}

		// Token: 0x06014508 RID: 83208 RVA: 0x002F3ADE File Offset: 0x002F1CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReceiveRechallengeNotify);
		}

		// Token: 0x06014509 RID: 83209 RVA: 0x002F3AEC File Offset: 0x002F1CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReceiveRechallengeNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.Result == other.Result && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601450A RID: 83210 RVA: 0x002F3B2C File Offset: 0x002F1D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.Result != ERechallengeResultResult.Accept)
			{
				num ^= this.Result.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601450B RID: 83211 RVA: 0x002F3B8A File Offset: 0x002F1D8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601450C RID: 83212 RVA: 0x002F3B97 File Offset: 0x002F1D97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601450D RID: 83213 RVA: 0x002F3BA0 File Offset: 0x002F1DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Result != ERechallengeResultResult.Accept)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Result);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601450E RID: 83214 RVA: 0x002F3BFC File Offset: 0x002F1DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.Result != ERechallengeResultResult.Accept)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Result);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601450F RID: 83215 RVA: 0x002F3C54 File Offset: 0x002F1E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReceiveRechallengeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.Result != ERechallengeResultResult.Accept)
			{
				this.Result = other.Result;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014510 RID: 83216 RVA: 0x002F3CA4 File Offset: 0x002F1EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014511 RID: 83217 RVA: 0x002F3CB0 File Offset: 0x002F1EB0
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
				if (num != 16U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Result = (ERechallengeResultResult)input.ReadEnum();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007B5E RID: 31582
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B5F RID: 31583
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x04007B60 RID: 31584
		private int playerId_;

		// Token: 0x04007B61 RID: 31585
		public const int ResultFieldNumber = 10;

		// Token: 0x04007B62 RID: 31586
		private ERechallengeResultResult result_;
	}
}
