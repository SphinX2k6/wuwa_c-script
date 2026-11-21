using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000202 RID: 514
	[NetMessage(EMessageId.BuffEffectExecuteResponse)]
	public sealed class BuffEffectExecuteResponse : IMessage<BuffEffectExecuteResponse>, IMessage, IEquatable<BuffEffectExecuteResponse>, IDeepCloneable<BuffEffectExecuteResponse>, IBufferMessage
	{
		// Token: 0x06003921 RID: 14625 RVA: 0x0008EE97 File Offset: 0x0008D097
		[NullableContext(1)]
		public static BuffEffectExecuteResponse Create()
		{
			return new BuffEffectExecuteResponse();
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06003922 RID: 14626 RVA: 0x0008EE9E File Offset: 0x0008D09E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06003923 RID: 14627 RVA: 0x0008EEA1 File Offset: 0x0008D0A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffEffectExecuteResponse.Descriptor;
			}
		}

		// Token: 0x06003924 RID: 14628 RVA: 0x0008EEA8 File Offset: 0x0008D0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectExecuteResponse()
		{
		}

		// Token: 0x06003925 RID: 14629 RVA: 0x0008EEB0 File Offset: 0x0008D0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectExecuteResponse(BuffEffectExecuteResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003926 RID: 14630 RVA: 0x0008EED5 File Offset: 0x0008D0D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectExecuteResponse Clone()
		{
			return new BuffEffectExecuteResponse(this);
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06003927 RID: 14631 RVA: 0x0008EEDD File Offset: 0x0008D0DD
		// (set) Token: 0x06003928 RID: 14632 RVA: 0x0008EEE5 File Offset: 0x0008D0E5
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

		// Token: 0x06003929 RID: 14633 RVA: 0x0008EEEE File Offset: 0x0008D0EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffEffectExecuteResponse);
		}

		// Token: 0x0600392A RID: 14634 RVA: 0x0008EEFC File Offset: 0x0008D0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffEffectExecuteResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600392B RID: 14635 RVA: 0x0008EF2C File Offset: 0x0008D12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600392C RID: 14636 RVA: 0x0008EF71 File Offset: 0x0008D171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600392D RID: 14637 RVA: 0x0008EF7E File Offset: 0x0008D17E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600392E RID: 14638 RVA: 0x0008EF87 File Offset: 0x0008D187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600392F RID: 14639 RVA: 0x0008EFBC File Offset: 0x0008D1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003930 RID: 14640 RVA: 0x0008EFFA File Offset: 0x0008D1FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffEffectExecuteResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003931 RID: 14641 RVA: 0x0008F02B File Offset: 0x0008D22B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003932 RID: 14642 RVA: 0x0008F034 File Offset: 0x0008D234
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002BBC RID: 11196
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BBD RID: 11197
		public const int CodeFieldNumber = 15;

		// Token: 0x04002BBE RID: 11198
		private ErrorCode code_;
	}
}
