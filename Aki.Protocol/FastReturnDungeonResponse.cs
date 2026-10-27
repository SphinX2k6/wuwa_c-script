using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200052E RID: 1326
	[NetMessage(EMessageId.FastReturnDungeonResponse)]
	public sealed class FastReturnDungeonResponse : IMessage<FastReturnDungeonResponse>, IMessage, IEquatable<FastReturnDungeonResponse>, IDeepCloneable<FastReturnDungeonResponse>, IBufferMessage
	{
		// Token: 0x06007C46 RID: 31814 RVA: 0x0012D2BA File Offset: 0x0012B4BA
		[NullableContext(1)]
		public static FastReturnDungeonResponse Create()
		{
			return new FastReturnDungeonResponse();
		}

		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x06007C47 RID: 31815 RVA: 0x0012D2C1 File Offset: 0x0012B4C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x06007C48 RID: 31816 RVA: 0x0012D2C4 File Offset: 0x0012B4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FastReturnDungeonResponse.Descriptor;
			}
		}

		// Token: 0x06007C49 RID: 31817 RVA: 0x0012D2CB File Offset: 0x0012B4CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FastReturnDungeonResponse()
		{
		}

		// Token: 0x06007C4A RID: 31818 RVA: 0x0012D2D3 File Offset: 0x0012B4D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FastReturnDungeonResponse(FastReturnDungeonResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C4B RID: 31819 RVA: 0x0012D2F8 File Offset: 0x0012B4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FastReturnDungeonResponse Clone()
		{
			return new FastReturnDungeonResponse(this);
		}

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x06007C4C RID: 31820 RVA: 0x0012D300 File Offset: 0x0012B500
		// (set) Token: 0x06007C4D RID: 31821 RVA: 0x0012D308 File Offset: 0x0012B508
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

		// Token: 0x06007C4E RID: 31822 RVA: 0x0012D311 File Offset: 0x0012B511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FastReturnDungeonResponse);
		}

		// Token: 0x06007C4F RID: 31823 RVA: 0x0012D31F File Offset: 0x0012B51F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FastReturnDungeonResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007C50 RID: 31824 RVA: 0x0012D350 File Offset: 0x0012B550
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

		// Token: 0x06007C51 RID: 31825 RVA: 0x0012D395 File Offset: 0x0012B595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007C52 RID: 31826 RVA: 0x0012D3A2 File Offset: 0x0012B5A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C53 RID: 31827 RVA: 0x0012D3AB File Offset: 0x0012B5AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007C54 RID: 31828 RVA: 0x0012D3E0 File Offset: 0x0012B5E0
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

		// Token: 0x06007C55 RID: 31829 RVA: 0x0012D41E File Offset: 0x0012B61E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FastReturnDungeonResponse other)
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

		// Token: 0x06007C56 RID: 31830 RVA: 0x0012D44F File Offset: 0x0012B64F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C57 RID: 31831 RVA: 0x0012D458 File Offset: 0x0012B658
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003F65 RID: 16229
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F66 RID: 16230
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04003F67 RID: 16231
		private ErrorCode errorCode_;
	}
}
