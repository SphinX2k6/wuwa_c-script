using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000163 RID: 355
	[NetMessage(EMessageId.BathChangeCameraResponse)]
	public sealed class BathChangeCameraResponse : IMessage<BathChangeCameraResponse>, IMessage, IEquatable<BathChangeCameraResponse>, IDeepCloneable<BathChangeCameraResponse>, IBufferMessage
	{
		// Token: 0x06002C55 RID: 11349 RVA: 0x00073645 File Offset: 0x00071845
		[NullableContext(1)]
		public static BathChangeCameraResponse Create()
		{
			return new BathChangeCameraResponse();
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06002C56 RID: 11350 RVA: 0x0007364C File Offset: 0x0007184C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06002C57 RID: 11351 RVA: 0x0007364F File Offset: 0x0007184F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BathChangeCameraResponse.Descriptor;
			}
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x00073656 File Offset: 0x00071856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BathChangeCameraResponse()
		{
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x0007365E File Offset: 0x0007185E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BathChangeCameraResponse(BathChangeCameraResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x00073683 File Offset: 0x00071883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BathChangeCameraResponse Clone()
		{
			return new BathChangeCameraResponse(this);
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06002C5B RID: 11355 RVA: 0x0007368B File Offset: 0x0007188B
		// (set) Token: 0x06002C5C RID: 11356 RVA: 0x00073693 File Offset: 0x00071893
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

		// Token: 0x06002C5D RID: 11357 RVA: 0x0007369C File Offset: 0x0007189C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BathChangeCameraResponse);
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x000736AA File Offset: 0x000718AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BathChangeCameraResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x000736D8 File Offset: 0x000718D8
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

		// Token: 0x06002C60 RID: 11360 RVA: 0x0007371D File Offset: 0x0007191D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x0007372A File Offset: 0x0007192A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x00073733 File Offset: 0x00071933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x00073768 File Offset: 0x00071968
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

		// Token: 0x06002C64 RID: 11364 RVA: 0x000737A6 File Offset: 0x000719A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BathChangeCameraResponse other)
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

		// Token: 0x06002C65 RID: 11365 RVA: 0x000737D7 File Offset: 0x000719D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x000737E0 File Offset: 0x000719E0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040027F2 RID: 10226
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027F3 RID: 10227
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040027F4 RID: 10228
		private ErrorCode errorCode_;
	}
}
