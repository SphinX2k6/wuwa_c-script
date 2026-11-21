using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200159F RID: 5535
	[NetMessage(EMessageId.WuWuTaskRewardResponse)]
	public sealed class WuWuTaskRewardResponse : IMessage<WuWuTaskRewardResponse>, IMessage, IEquatable<WuWuTaskRewardResponse>, IDeepCloneable<WuWuTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0601D4CE RID: 120014 RVA: 0x0043DEF5 File Offset: 0x0043C0F5
		[NullableContext(1)]
		public static WuWuTaskRewardResponse Create()
		{
			return new WuWuTaskRewardResponse();
		}

		// Token: 0x17006325 RID: 25381
		// (get) Token: 0x0601D4CF RID: 120015 RVA: 0x0043DEFC File Offset: 0x0043C0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006326 RID: 25382
		// (get) Token: 0x0601D4D0 RID: 120016 RVA: 0x0043DEFF File Offset: 0x0043C0FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WuWuTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601D4D1 RID: 120017 RVA: 0x0043DF06 File Offset: 0x0043C106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuTaskRewardResponse()
		{
		}

		// Token: 0x0601D4D2 RID: 120018 RVA: 0x0043DF0E File Offset: 0x0043C10E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuTaskRewardResponse(WuWuTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D4D3 RID: 120019 RVA: 0x0043DF33 File Offset: 0x0043C133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuTaskRewardResponse Clone()
		{
			return new WuWuTaskRewardResponse(this);
		}

		// Token: 0x17006327 RID: 25383
		// (get) Token: 0x0601D4D4 RID: 120020 RVA: 0x0043DF3B File Offset: 0x0043C13B
		// (set) Token: 0x0601D4D5 RID: 120021 RVA: 0x0043DF43 File Offset: 0x0043C143
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

		// Token: 0x0601D4D6 RID: 120022 RVA: 0x0043DF4C File Offset: 0x0043C14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WuWuTaskRewardResponse);
		}

		// Token: 0x0601D4D7 RID: 120023 RVA: 0x0043DF5A File Offset: 0x0043C15A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WuWuTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D4D8 RID: 120024 RVA: 0x0043DF88 File Offset: 0x0043C188
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

		// Token: 0x0601D4D9 RID: 120025 RVA: 0x0043DFCD File Offset: 0x0043C1CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D4DA RID: 120026 RVA: 0x0043DFDA File Offset: 0x0043C1DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D4DB RID: 120027 RVA: 0x0043DFE3 File Offset: 0x0043C1E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D4DC RID: 120028 RVA: 0x0043E018 File Offset: 0x0043C218
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

		// Token: 0x0601D4DD RID: 120029 RVA: 0x0043E056 File Offset: 0x0043C256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WuWuTaskRewardResponse other)
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

		// Token: 0x0601D4DE RID: 120030 RVA: 0x0043E087 File Offset: 0x0043C287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D4DF RID: 120031 RVA: 0x0043E090 File Offset: 0x0043C290
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A80A RID: 43018
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A80B RID: 43019
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x0400A80C RID: 43020
		private ErrorCode errorCode_;
	}
}
