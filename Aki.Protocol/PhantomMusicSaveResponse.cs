using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CDB RID: 3291
	[NetMessage(EMessageId.PhantomMusicSaveResponse)]
	public sealed class PhantomMusicSaveResponse : IMessage<PhantomMusicSaveResponse>, IMessage, IEquatable<PhantomMusicSaveResponse>, IDeepCloneable<PhantomMusicSaveResponse>, IBufferMessage
	{
		// Token: 0x06011D38 RID: 73016 RVA: 0x0029C165 File Offset: 0x0029A365
		[NullableContext(1)]
		public static PhantomMusicSaveResponse Create()
		{
			return new PhantomMusicSaveResponse();
		}

		// Token: 0x17003B12 RID: 15122
		// (get) Token: 0x06011D39 RID: 73017 RVA: 0x0029C16C File Offset: 0x0029A36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B13 RID: 15123
		// (get) Token: 0x06011D3A RID: 73018 RVA: 0x0029C16F File Offset: 0x0029A36F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomMusicSaveResponse.Descriptor;
			}
		}

		// Token: 0x06011D3B RID: 73019 RVA: 0x0029C176 File Offset: 0x0029A376
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicSaveResponse()
		{
		}

		// Token: 0x06011D3C RID: 73020 RVA: 0x0029C17E File Offset: 0x0029A37E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicSaveResponse(PhantomMusicSaveResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011D3D RID: 73021 RVA: 0x0029C1A3 File Offset: 0x0029A3A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicSaveResponse Clone()
		{
			return new PhantomMusicSaveResponse(this);
		}

		// Token: 0x17003B14 RID: 15124
		// (get) Token: 0x06011D3E RID: 73022 RVA: 0x0029C1AB File Offset: 0x0029A3AB
		// (set) Token: 0x06011D3F RID: 73023 RVA: 0x0029C1B3 File Offset: 0x0029A3B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x06011D40 RID: 73024 RVA: 0x0029C1BC File Offset: 0x0029A3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomMusicSaveResponse);
		}

		// Token: 0x06011D41 RID: 73025 RVA: 0x0029C1CA File Offset: 0x0029A3CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomMusicSaveResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011D42 RID: 73026 RVA: 0x0029C1F8 File Offset: 0x0029A3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011D43 RID: 73027 RVA: 0x0029C23D File Offset: 0x0029A43D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011D44 RID: 73028 RVA: 0x0029C24A File Offset: 0x0029A44A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011D45 RID: 73029 RVA: 0x0029C253 File Offset: 0x0029A453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011D46 RID: 73030 RVA: 0x0029C288 File Offset: 0x0029A488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011D47 RID: 73031 RVA: 0x0029C2C6 File Offset: 0x0029A4C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomMusicSaveResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011D48 RID: 73032 RVA: 0x0029C2F7 File Offset: 0x0029A4F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011D49 RID: 73033 RVA: 0x0029C300 File Offset: 0x0029A500
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007057 RID: 28759
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007058 RID: 28760
		public const int ErrCodeFieldNumber = 4;

		// Token: 0x04007059 RID: 28761
		private ErrorCode errCode_;
	}
}
