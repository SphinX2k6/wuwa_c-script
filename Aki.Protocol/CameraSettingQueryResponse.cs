using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200022F RID: 559
	[NetMessage(EMessageId.CameraSettingQueryResponse)]
	public sealed class CameraSettingQueryResponse : IMessage<CameraSettingQueryResponse>, IMessage, IEquatable<CameraSettingQueryResponse>, IDeepCloneable<CameraSettingQueryResponse>, IBufferMessage
	{
		// Token: 0x06003CA3 RID: 15523 RVA: 0x000969CA File Offset: 0x00094BCA
		[NullableContext(1)]
		public static CameraSettingQueryResponse Create()
		{
			return new CameraSettingQueryResponse();
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06003CA4 RID: 15524 RVA: 0x000969D1 File Offset: 0x00094BD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06003CA5 RID: 15525 RVA: 0x000969D4 File Offset: 0x00094BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CameraSettingQueryResponse.Descriptor;
			}
		}

		// Token: 0x06003CA6 RID: 15526 RVA: 0x000969DB File Offset: 0x00094BDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingQueryResponse()
		{
		}

		// Token: 0x06003CA7 RID: 15527 RVA: 0x000969E4 File Offset: 0x00094BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingQueryResponse(CameraSettingQueryResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.cameraSetting_ = ((other.cameraSetting_ != null) ? other.cameraSetting_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003CA8 RID: 15528 RVA: 0x00096A30 File Offset: 0x00094C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingQueryResponse Clone()
		{
			return new CameraSettingQueryResponse(this);
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06003CA9 RID: 15529 RVA: 0x00096A38 File Offset: 0x00094C38
		// (set) Token: 0x06003CAA RID: 15530 RVA: 0x00096A40 File Offset: 0x00094C40
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

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06003CAB RID: 15531 RVA: 0x00096A49 File Offset: 0x00094C49
		// (set) Token: 0x06003CAC RID: 15532 RVA: 0x00096A51 File Offset: 0x00094C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingInfo CameraSetting
		{
			get
			{
				return this.cameraSetting_;
			}
			set
			{
				this.cameraSetting_ = value;
			}
		}

		// Token: 0x06003CAD RID: 15533 RVA: 0x00096A5A File Offset: 0x00094C5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CameraSettingQueryResponse);
		}

		// Token: 0x06003CAE RID: 15534 RVA: 0x00096A68 File Offset: 0x00094C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CameraSettingQueryResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.CameraSetting, other.CameraSetting) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003CAF RID: 15535 RVA: 0x00096AB8 File Offset: 0x00094CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.cameraSetting_ != null)
			{
				num ^= this.CameraSetting.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003CB0 RID: 15536 RVA: 0x00096B13 File Offset: 0x00094D13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003CB1 RID: 15537 RVA: 0x00096B20 File Offset: 0x00094D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003CB2 RID: 15538 RVA: 0x00096B2C File Offset: 0x00094D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.cameraSetting_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.CameraSetting);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003CB3 RID: 15539 RVA: 0x00096B88 File Offset: 0x00094D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.cameraSetting_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CameraSetting);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003CB4 RID: 15540 RVA: 0x00096BE0 File Offset: 0x00094DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CameraSettingQueryResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.cameraSetting_ != null)
			{
				if (this.cameraSetting_ == null)
				{
					this.CameraSetting = new CameraSettingInfo();
				}
				this.CameraSetting.MergeFrom(other.CameraSetting);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003CB5 RID: 15541 RVA: 0x00096C48 File Offset: 0x00094E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003CB6 RID: 15542 RVA: 0x00096C54 File Offset: 0x00094E54
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
				if (num != 48U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.cameraSetting_ == null)
						{
							this.CameraSetting = new CameraSettingInfo();
						}
						input.ReadMessage(this.CameraSetting);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002C7E RID: 11390
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C7F RID: 11391
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04002C80 RID: 11392
		private ErrorCode errorCode_;

		// Token: 0x04002C81 RID: 11393
		public const int CameraSettingFieldNumber = 11;

		// Token: 0x04002C82 RID: 11394
		private CameraSettingInfo cameraSetting_;
	}
}
