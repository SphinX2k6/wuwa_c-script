using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CEF RID: 3311
	[NetMessage(EMessageId.PhantomMusicUnlockResponse)]
	public sealed class PhantomMusicUnlockResponse : IMessage<PhantomMusicUnlockResponse>, IMessage, IEquatable<PhantomMusicUnlockResponse>, IDeepCloneable<PhantomMusicUnlockResponse>, IBufferMessage
	{
		// Token: 0x06011E7C RID: 73340 RVA: 0x0029E4F1 File Offset: 0x0029C6F1
		[NullableContext(1)]
		public static PhantomMusicUnlockResponse Create()
		{
			return new PhantomMusicUnlockResponse();
		}

		// Token: 0x17003B53 RID: 15187
		// (get) Token: 0x06011E7D RID: 73341 RVA: 0x0029E4F8 File Offset: 0x0029C6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B54 RID: 15188
		// (get) Token: 0x06011E7E RID: 73342 RVA: 0x0029E4FB File Offset: 0x0029C6FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomMusicUnlockResponse.Descriptor;
			}
		}

		// Token: 0x06011E7F RID: 73343 RVA: 0x0029E502 File Offset: 0x0029C702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicUnlockResponse()
		{
		}

		// Token: 0x06011E80 RID: 73344 RVA: 0x0029E515 File Offset: 0x0029C715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicUnlockResponse(PhantomMusicUnlockResponse other) : this()
		{
			this.addMusicIds_ = other.addMusicIds_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011E81 RID: 73345 RVA: 0x0029E54B File Offset: 0x0029C74B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicUnlockResponse Clone()
		{
			return new PhantomMusicUnlockResponse(this);
		}

		// Token: 0x17003B55 RID: 15189
		// (get) Token: 0x06011E82 RID: 73346 RVA: 0x0029E553 File Offset: 0x0029C753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AddMusicIds
		{
			get
			{
				return this.addMusicIds_;
			}
		}

		// Token: 0x17003B56 RID: 15190
		// (get) Token: 0x06011E83 RID: 73347 RVA: 0x0029E55B File Offset: 0x0029C75B
		// (set) Token: 0x06011E84 RID: 73348 RVA: 0x0029E563 File Offset: 0x0029C763
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

		// Token: 0x06011E85 RID: 73349 RVA: 0x0029E56C File Offset: 0x0029C76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomMusicUnlockResponse);
		}

		// Token: 0x06011E86 RID: 73350 RVA: 0x0029E57C File Offset: 0x0029C77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomMusicUnlockResponse other)
		{
			return other != null && (other == this || (this.addMusicIds_.Equals(other.addMusicIds_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011E87 RID: 73351 RVA: 0x0029E5CC File Offset: 0x0029C7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.addMusicIds_.GetHashCode();
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

		// Token: 0x06011E88 RID: 73352 RVA: 0x0029E61F File Offset: 0x0029C81F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011E89 RID: 73353 RVA: 0x0029E62C File Offset: 0x0029C82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011E8A RID: 73354 RVA: 0x0029E638 File Offset: 0x0029C838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.addMusicIds_.WriteTo(ref output, PhantomMusicUnlockResponse._repeated_addMusicIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011E8B RID: 73355 RVA: 0x0029E688 File Offset: 0x0029C888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.addMusicIds_.CalculateSize(PhantomMusicUnlockResponse._repeated_addMusicIds_codec);
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

		// Token: 0x06011E8C RID: 73356 RVA: 0x0029E6DC File Offset: 0x0029C8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomMusicUnlockResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.addMusicIds_.Add(other.addMusicIds_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011E8D RID: 73357 RVA: 0x0029E729 File Offset: 0x0029C929
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011E8E RID: 73358 RVA: 0x0029E734 File Offset: 0x0029C934
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
				if (num != 88U)
				{
					if (num != 112U && num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.addMusicIds_.AddEntriesFrom(ref input, PhantomMusicUnlockResponse._repeated_addMusicIds_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400704C RID: 28748
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400704D RID: 28749
		public const int AddMusicIdsFieldNumber = 14;

		// Token: 0x0400704E RID: 28750
		private static readonly FieldCodec<int> _repeated_addMusicIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x0400704F RID: 28751
		private readonly RepeatedField<int> addMusicIds_ = new RepeatedField<int>();

		// Token: 0x04007050 RID: 28752
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04007051 RID: 28753
		private ErrorCode errorCode_;
	}
}
