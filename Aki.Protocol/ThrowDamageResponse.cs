using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013DE RID: 5086
	[NetMessage(EMessageId.ThrowDamageResponse)]
	public sealed class ThrowDamageResponse : IMessage<ThrowDamageResponse>, IMessage, IEquatable<ThrowDamageResponse>, IDeepCloneable<ThrowDamageResponse>, IBufferMessage
	{
		// Token: 0x0601B0DD RID: 110813 RVA: 0x003F02A0 File Offset: 0x003EE4A0
		[NullableContext(1)]
		public static ThrowDamageResponse Create()
		{
			return new ThrowDamageResponse();
		}

		// Token: 0x17005B9A RID: 23450
		// (get) Token: 0x0601B0DE RID: 110814 RVA: 0x003F02A7 File Offset: 0x003EE4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B9B RID: 23451
		// (get) Token: 0x0601B0DF RID: 110815 RVA: 0x003F02AA File Offset: 0x003EE4AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThrowDamageResponse.Descriptor;
			}
		}

		// Token: 0x0601B0E0 RID: 110816 RVA: 0x003F02B1 File Offset: 0x003EE4B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThrowDamageResponse()
		{
		}

		// Token: 0x0601B0E1 RID: 110817 RVA: 0x003F02B9 File Offset: 0x003EE4B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThrowDamageResponse(ThrowDamageResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B0E2 RID: 110818 RVA: 0x003F02DE File Offset: 0x003EE4DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThrowDamageResponse Clone()
		{
			return new ThrowDamageResponse(this);
		}

		// Token: 0x17005B9C RID: 23452
		// (get) Token: 0x0601B0E3 RID: 110819 RVA: 0x003F02E6 File Offset: 0x003EE4E6
		// (set) Token: 0x0601B0E4 RID: 110820 RVA: 0x003F02EE File Offset: 0x003EE4EE
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

		// Token: 0x0601B0E5 RID: 110821 RVA: 0x003F02F7 File Offset: 0x003EE4F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThrowDamageResponse);
		}

		// Token: 0x0601B0E6 RID: 110822 RVA: 0x003F0305 File Offset: 0x003EE505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThrowDamageResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B0E7 RID: 110823 RVA: 0x003F0334 File Offset: 0x003EE534
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

		// Token: 0x0601B0E8 RID: 110824 RVA: 0x003F0379 File Offset: 0x003EE579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B0E9 RID: 110825 RVA: 0x003F0386 File Offset: 0x003EE586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B0EA RID: 110826 RVA: 0x003F038F File Offset: 0x003EE58F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B0EB RID: 110827 RVA: 0x003F03C4 File Offset: 0x003EE5C4
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

		// Token: 0x0601B0EC RID: 110828 RVA: 0x003F0402 File Offset: 0x003EE602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThrowDamageResponse other)
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

		// Token: 0x0601B0ED RID: 110829 RVA: 0x003F0433 File Offset: 0x003EE633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B0EE RID: 110830 RVA: 0x003F043C File Offset: 0x003EE63C
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009DFC RID: 40444
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DFD RID: 40445
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04009DFE RID: 40446
		private ErrorCode errorCode_;
	}
}
