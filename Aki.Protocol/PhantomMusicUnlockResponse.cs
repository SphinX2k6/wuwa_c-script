using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CDF RID: 3295
	[NetMessage(EMessageId.PhantomMusicUnlockResponse)]
	public sealed class PhantomMusicUnlockResponse : IMessage<PhantomMusicUnlockResponse>, IMessage, IEquatable<PhantomMusicUnlockResponse>, IDeepCloneable<PhantomMusicUnlockResponse>, IBufferMessage
	{
		// Token: 0x06011D80 RID: 73088 RVA: 0x0029C8D9 File Offset: 0x0029AAD9
		[NullableContext(1)]
		public static PhantomMusicUnlockResponse Create()
		{
			return new PhantomMusicUnlockResponse();
		}

		// Token: 0x17003B1E RID: 15134
		// (get) Token: 0x06011D81 RID: 73089 RVA: 0x0029C8E0 File Offset: 0x0029AAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B1F RID: 15135
		// (get) Token: 0x06011D82 RID: 73090 RVA: 0x0029C8E3 File Offset: 0x0029AAE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomMusicUnlockResponse.Descriptor;
			}
		}

		// Token: 0x06011D83 RID: 73091 RVA: 0x0029C8EA File Offset: 0x0029AAEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicUnlockResponse()
		{
		}

		// Token: 0x06011D84 RID: 73092 RVA: 0x0029C8FD File Offset: 0x0029AAFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicUnlockResponse(PhantomMusicUnlockResponse other) : this()
		{
			this.addMusicIds_ = other.addMusicIds_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011D85 RID: 73093 RVA: 0x0029C933 File Offset: 0x0029AB33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicUnlockResponse Clone()
		{
			return new PhantomMusicUnlockResponse(this);
		}

		// Token: 0x17003B20 RID: 15136
		// (get) Token: 0x06011D86 RID: 73094 RVA: 0x0029C93B File Offset: 0x0029AB3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AddMusicIds
		{
			get
			{
				return this.addMusicIds_;
			}
		}

		// Token: 0x17003B21 RID: 15137
		// (get) Token: 0x06011D87 RID: 73095 RVA: 0x0029C943 File Offset: 0x0029AB43
		// (set) Token: 0x06011D88 RID: 73096 RVA: 0x0029C94B File Offset: 0x0029AB4B
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

		// Token: 0x06011D89 RID: 73097 RVA: 0x0029C954 File Offset: 0x0029AB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomMusicUnlockResponse);
		}

		// Token: 0x06011D8A RID: 73098 RVA: 0x0029C964 File Offset: 0x0029AB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomMusicUnlockResponse other)
		{
			return other != null && (other == this || (this.addMusicIds_.Equals(other.addMusicIds_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011D8B RID: 73099 RVA: 0x0029C9B4 File Offset: 0x0029ABB4
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

		// Token: 0x06011D8C RID: 73100 RVA: 0x0029CA07 File Offset: 0x0029AC07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011D8D RID: 73101 RVA: 0x0029CA14 File Offset: 0x0029AC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011D8E RID: 73102 RVA: 0x0029CA20 File Offset: 0x0029AC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.addMusicIds_.WriteTo(ref output, PhantomMusicUnlockResponse._repeated_addMusicIds_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011D8F RID: 73103 RVA: 0x0029CA70 File Offset: 0x0029AC70
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

		// Token: 0x06011D90 RID: 73104 RVA: 0x0029CAC4 File Offset: 0x0029ACC4
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

		// Token: 0x06011D91 RID: 73105 RVA: 0x0029CB11 File Offset: 0x0029AD11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011D92 RID: 73106 RVA: 0x0029CB1C File Offset: 0x0029AD1C
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
				if (num != 16U && num != 18U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.addMusicIds_.AddEntriesFrom(ref input, PhantomMusicUnlockResponse._repeated_addMusicIds_codec);
				}
			}
		}

		// Token: 0x04007064 RID: 28772
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007065 RID: 28773
		public const int AddMusicIdsFieldNumber = 2;

		// Token: 0x04007066 RID: 28774
		private static readonly FieldCodec<int> _repeated_addMusicIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04007067 RID: 28775
		private readonly RepeatedField<int> addMusicIds_ = new RepeatedField<int>();

		// Token: 0x04007068 RID: 28776
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04007069 RID: 28777
		private ErrorCode errorCode_;
	}
}
