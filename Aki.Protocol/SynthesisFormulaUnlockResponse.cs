using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001378 RID: 4984
	[NetMessage(EMessageId.SynthesisFormulaUnlockResponse)]
	public sealed class SynthesisFormulaUnlockResponse : IMessage<SynthesisFormulaUnlockResponse>, IMessage, IEquatable<SynthesisFormulaUnlockResponse>, IDeepCloneable<SynthesisFormulaUnlockResponse>, IBufferMessage
	{
		// Token: 0x0601A89E RID: 108702 RVA: 0x003DDD1D File Offset: 0x003DBF1D
		[NullableContext(1)]
		public static SynthesisFormulaUnlockResponse Create()
		{
			return new SynthesisFormulaUnlockResponse();
		}

		// Token: 0x170059D7 RID: 22999
		// (get) Token: 0x0601A89F RID: 108703 RVA: 0x003DDD24 File Offset: 0x003DBF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059D8 RID: 23000
		// (get) Token: 0x0601A8A0 RID: 108704 RVA: 0x003DDD27 File Offset: 0x003DBF27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SynthesisFormulaUnlockResponse.Descriptor;
			}
		}

		// Token: 0x0601A8A1 RID: 108705 RVA: 0x003DDD2E File Offset: 0x003DBF2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisFormulaUnlockResponse()
		{
		}

		// Token: 0x0601A8A2 RID: 108706 RVA: 0x003DDD36 File Offset: 0x003DBF36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisFormulaUnlockResponse(SynthesisFormulaUnlockResponse other) : this()
		{
			this.code_ = other.code_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A8A3 RID: 108707 RVA: 0x003DDD67 File Offset: 0x003DBF67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisFormulaUnlockResponse Clone()
		{
			return new SynthesisFormulaUnlockResponse(this);
		}

		// Token: 0x170059D9 RID: 23001
		// (get) Token: 0x0601A8A4 RID: 108708 RVA: 0x003DDD6F File Offset: 0x003DBF6F
		// (set) Token: 0x0601A8A5 RID: 108709 RVA: 0x003DDD77 File Offset: 0x003DBF77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x170059DA RID: 23002
		// (get) Token: 0x0601A8A6 RID: 108710 RVA: 0x003DDD80 File Offset: 0x003DBF80
		// (set) Token: 0x0601A8A7 RID: 108711 RVA: 0x003DDD88 File Offset: 0x003DBF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
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

		// Token: 0x0601A8A8 RID: 108712 RVA: 0x003DDD91 File Offset: 0x003DBF91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SynthesisFormulaUnlockResponse);
		}

		// Token: 0x0601A8A9 RID: 108713 RVA: 0x003DDD9F File Offset: 0x003DBF9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SynthesisFormulaUnlockResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A8AA RID: 108714 RVA: 0x003DDDE0 File Offset: 0x003DBFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A8AB RID: 108715 RVA: 0x003DDE3E File Offset: 0x003DC03E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A8AC RID: 108716 RVA: 0x003DDE4B File Offset: 0x003DC04B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A8AD RID: 108717 RVA: 0x003DDE54 File Offset: 0x003DC054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Code);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A8AE RID: 108718 RVA: 0x003DDEB0 File Offset: 0x003DC0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A8AF RID: 108719 RVA: 0x003DDF08 File Offset: 0x003DC108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SynthesisFormulaUnlockResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A8B0 RID: 108720 RVA: 0x003DDF58 File Offset: 0x003DC158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A8B1 RID: 108721 RVA: 0x003DDF64 File Offset: 0x003DC164
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
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009B8F RID: 39823
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B90 RID: 39824
		public const int CodeFieldNumber = 7;

		// Token: 0x04009B91 RID: 39825
		private ErrorCode code_;

		// Token: 0x04009B92 RID: 39826
		public const int IdFieldNumber = 8;

		// Token: 0x04009B93 RID: 39827
		private int id_;
	}
}
