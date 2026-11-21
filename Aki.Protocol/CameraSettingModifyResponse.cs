using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000232 RID: 562
	[NetMessage(EMessageId.CameraSettingModifyResponse)]
	public sealed class CameraSettingModifyResponse : IMessage<CameraSettingModifyResponse>, IMessage, IEquatable<CameraSettingModifyResponse>, IDeepCloneable<CameraSettingModifyResponse>, IBufferMessage
	{
		// Token: 0x06003D26 RID: 15654 RVA: 0x000982CC File Offset: 0x000964CC
		[NullableContext(1)]
		public static CameraSettingModifyResponse Create()
		{
			return new CameraSettingModifyResponse();
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06003D27 RID: 15655 RVA: 0x000982D3 File Offset: 0x000964D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06003D28 RID: 15656 RVA: 0x000982D6 File Offset: 0x000964D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CameraSettingModifyResponse.Descriptor;
			}
		}

		// Token: 0x06003D29 RID: 15657 RVA: 0x000982DD File Offset: 0x000964DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingModifyResponse()
		{
		}

		// Token: 0x06003D2A RID: 15658 RVA: 0x000982E5 File Offset: 0x000964E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingModifyResponse(CameraSettingModifyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D2B RID: 15659 RVA: 0x0009830A File Offset: 0x0009650A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingModifyResponse Clone()
		{
			return new CameraSettingModifyResponse(this);
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06003D2C RID: 15660 RVA: 0x00098312 File Offset: 0x00096512
		// (set) Token: 0x06003D2D RID: 15661 RVA: 0x0009831A File Offset: 0x0009651A
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

		// Token: 0x06003D2E RID: 15662 RVA: 0x00098323 File Offset: 0x00096523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CameraSettingModifyResponse);
		}

		// Token: 0x06003D2F RID: 15663 RVA: 0x00098331 File Offset: 0x00096531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CameraSettingModifyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003D30 RID: 15664 RVA: 0x00098360 File Offset: 0x00096560
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

		// Token: 0x06003D31 RID: 15665 RVA: 0x000983A5 File Offset: 0x000965A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x000983B2 File Offset: 0x000965B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D33 RID: 15667 RVA: 0x000983BB File Offset: 0x000965BB
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

		// Token: 0x06003D34 RID: 15668 RVA: 0x000983F0 File Offset: 0x000965F0
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

		// Token: 0x06003D35 RID: 15669 RVA: 0x0009842E File Offset: 0x0009662E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CameraSettingModifyResponse other)
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

		// Token: 0x06003D36 RID: 15670 RVA: 0x0009845F File Offset: 0x0009665F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D37 RID: 15671 RVA: 0x00098468 File Offset: 0x00096668
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

		// Token: 0x04002CFC RID: 11516
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CFD RID: 11517
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04002CFE RID: 11518
		private ErrorCode errorCode_;
	}
}
