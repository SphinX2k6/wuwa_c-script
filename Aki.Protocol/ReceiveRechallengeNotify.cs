using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EBD RID: 3773
	[NetMessage(EMessageId.ReceiveRechallengeNotify)]
	public sealed class ReceiveRechallengeNotify : IMessage<ReceiveRechallengeNotify>, IMessage, IEquatable<ReceiveRechallengeNotify>, IDeepCloneable<ReceiveRechallengeNotify>, IBufferMessage
	{
		// Token: 0x06014419 RID: 82969 RVA: 0x002F23B6 File Offset: 0x002F05B6
		[NullableContext(1)]
		public static ReceiveRechallengeNotify Create()
		{
			return new ReceiveRechallengeNotify();
		}

		// Token: 0x1700435A RID: 17242
		// (get) Token: 0x0601441A RID: 82970 RVA: 0x002F23BD File Offset: 0x002F05BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700435B RID: 17243
		// (get) Token: 0x0601441B RID: 82971 RVA: 0x002F23C0 File Offset: 0x002F05C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReceiveRechallengeNotify.Descriptor;
			}
		}

		// Token: 0x0601441C RID: 82972 RVA: 0x002F23C7 File Offset: 0x002F05C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceiveRechallengeNotify()
		{
		}

		// Token: 0x0601441D RID: 82973 RVA: 0x002F23CF File Offset: 0x002F05CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceiveRechallengeNotify(ReceiveRechallengeNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.result_ = other.result_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601441E RID: 82974 RVA: 0x002F2400 File Offset: 0x002F0600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceiveRechallengeNotify Clone()
		{
			return new ReceiveRechallengeNotify(this);
		}

		// Token: 0x1700435C RID: 17244
		// (get) Token: 0x0601441F RID: 82975 RVA: 0x002F2408 File Offset: 0x002F0608
		// (set) Token: 0x06014420 RID: 82976 RVA: 0x002F2410 File Offset: 0x002F0610
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

		// Token: 0x1700435D RID: 17245
		// (get) Token: 0x06014421 RID: 82977 RVA: 0x002F2419 File Offset: 0x002F0619
		// (set) Token: 0x06014422 RID: 82978 RVA: 0x002F2421 File Offset: 0x002F0621
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

		// Token: 0x06014423 RID: 82979 RVA: 0x002F242A File Offset: 0x002F062A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReceiveRechallengeNotify);
		}

		// Token: 0x06014424 RID: 82980 RVA: 0x002F2438 File Offset: 0x002F0638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReceiveRechallengeNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.Result == other.Result && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014425 RID: 82981 RVA: 0x002F2478 File Offset: 0x002F0678
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

		// Token: 0x06014426 RID: 82982 RVA: 0x002F24D6 File Offset: 0x002F06D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014427 RID: 82983 RVA: 0x002F24E3 File Offset: 0x002F06E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014428 RID: 82984 RVA: 0x002F24EC File Offset: 0x002F06EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Result != ERechallengeResultResult.Accept)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Result);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014429 RID: 82985 RVA: 0x002F2548 File Offset: 0x002F0748
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

		// Token: 0x0601442A RID: 82986 RVA: 0x002F25A0 File Offset: 0x002F07A0
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

		// Token: 0x0601442B RID: 82987 RVA: 0x002F25F0 File Offset: 0x002F07F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601442C RID: 82988 RVA: 0x002F25FC File Offset: 0x002F07FC
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
					if (num != 104U)
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

		// Token: 0x04007B88 RID: 31624
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B89 RID: 31625
		public const int PlayerIdFieldNumber = 6;

		// Token: 0x04007B8A RID: 31626
		private int playerId_;

		// Token: 0x04007B8B RID: 31627
		public const int ResultFieldNumber = 13;

		// Token: 0x04007B8C RID: 31628
		private ERechallengeResultResult result_;
	}
}
