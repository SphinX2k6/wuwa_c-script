using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001404 RID: 5124
	[NetMessage(EMessageId.TrapDefenseAuxiliaryBranchResponse)]
	public sealed class TrapDefenseAuxiliaryBranchResponse : IMessage<TrapDefenseAuxiliaryBranchResponse>, IMessage, IEquatable<TrapDefenseAuxiliaryBranchResponse>, IDeepCloneable<TrapDefenseAuxiliaryBranchResponse>, IBufferMessage
	{
		// Token: 0x0601B2A9 RID: 111273 RVA: 0x003F029B File Offset: 0x003EE49B
		[NullableContext(1)]
		public static TrapDefenseAuxiliaryBranchResponse Create()
		{
			return new TrapDefenseAuxiliaryBranchResponse();
		}

		// Token: 0x17005BA4 RID: 23460
		// (get) Token: 0x0601B2AA RID: 111274 RVA: 0x003F02A2 File Offset: 0x003EE4A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BA5 RID: 23461
		// (get) Token: 0x0601B2AB RID: 111275 RVA: 0x003F02A5 File Offset: 0x003EE4A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseAuxiliaryBranchResponse.Descriptor;
			}
		}

		// Token: 0x0601B2AC RID: 111276 RVA: 0x003F02AC File Offset: 0x003EE4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryBranchResponse()
		{
		}

		// Token: 0x0601B2AD RID: 111277 RVA: 0x003F02B4 File Offset: 0x003EE4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryBranchResponse(TrapDefenseAuxiliaryBranchResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B2AE RID: 111278 RVA: 0x003F02D9 File Offset: 0x003EE4D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryBranchResponse Clone()
		{
			return new TrapDefenseAuxiliaryBranchResponse(this);
		}

		// Token: 0x17005BA6 RID: 23462
		// (get) Token: 0x0601B2AF RID: 111279 RVA: 0x003F02E1 File Offset: 0x003EE4E1
		// (set) Token: 0x0601B2B0 RID: 111280 RVA: 0x003F02E9 File Offset: 0x003EE4E9
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

		// Token: 0x0601B2B1 RID: 111281 RVA: 0x003F02F2 File Offset: 0x003EE4F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseAuxiliaryBranchResponse);
		}

		// Token: 0x0601B2B2 RID: 111282 RVA: 0x003F0300 File Offset: 0x003EE500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseAuxiliaryBranchResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B2B3 RID: 111283 RVA: 0x003F0330 File Offset: 0x003EE530
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

		// Token: 0x0601B2B4 RID: 111284 RVA: 0x003F0375 File Offset: 0x003EE575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B2B5 RID: 111285 RVA: 0x003F0382 File Offset: 0x003EE582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B2B6 RID: 111286 RVA: 0x003F038B File Offset: 0x003EE58B
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

		// Token: 0x0601B2B7 RID: 111287 RVA: 0x003F03C0 File Offset: 0x003EE5C0
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

		// Token: 0x0601B2B8 RID: 111288 RVA: 0x003F03FE File Offset: 0x003EE5FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseAuxiliaryBranchResponse other)
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

		// Token: 0x0601B2B9 RID: 111289 RVA: 0x003F042F File Offset: 0x003EE62F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B2BA RID: 111290 RVA: 0x003F0438 File Offset: 0x003EE638
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

		// Token: 0x04009D3F RID: 40255
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D40 RID: 40256
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04009D41 RID: 40257
		private ErrorCode errorCode_;
	}
}
