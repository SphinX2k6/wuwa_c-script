using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000234 RID: 564
	[NetMessage(EMessageId.CameraSettingQueryResponse)]
	public sealed class CameraSettingQueryResponse : IMessage<CameraSettingQueryResponse>, IMessage, IEquatable<CameraSettingQueryResponse>, IDeepCloneable<CameraSettingQueryResponse>, IBufferMessage
	{
		// Token: 0x06003D48 RID: 15688 RVA: 0x000985E6 File Offset: 0x000967E6
		[NullableContext(1)]
		public static CameraSettingQueryResponse Create()
		{
			return new CameraSettingQueryResponse();
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06003D49 RID: 15689 RVA: 0x000985ED File Offset: 0x000967ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06003D4A RID: 15690 RVA: 0x000985F0 File Offset: 0x000967F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CameraSettingQueryResponse.Descriptor;
			}
		}

		// Token: 0x06003D4B RID: 15691 RVA: 0x000985F7 File Offset: 0x000967F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingQueryResponse()
		{
		}

		// Token: 0x06003D4C RID: 15692 RVA: 0x00098600 File Offset: 0x00096800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingQueryResponse(CameraSettingQueryResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.cameraSetting_ = ((other.cameraSetting_ != null) ? other.cameraSetting_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D4D RID: 15693 RVA: 0x0009864C File Offset: 0x0009684C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingQueryResponse Clone()
		{
			return new CameraSettingQueryResponse(this);
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06003D4E RID: 15694 RVA: 0x00098654 File Offset: 0x00096854
		// (set) Token: 0x06003D4F RID: 15695 RVA: 0x0009865C File Offset: 0x0009685C
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

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06003D50 RID: 15696 RVA: 0x00098665 File Offset: 0x00096865
		// (set) Token: 0x06003D51 RID: 15697 RVA: 0x0009866D File Offset: 0x0009686D
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

		// Token: 0x06003D52 RID: 15698 RVA: 0x00098676 File Offset: 0x00096876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CameraSettingQueryResponse);
		}

		// Token: 0x06003D53 RID: 15699 RVA: 0x00098684 File Offset: 0x00096884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CameraSettingQueryResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.CameraSetting, other.CameraSetting) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003D54 RID: 15700 RVA: 0x000986D4 File Offset: 0x000968D4
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

		// Token: 0x06003D55 RID: 15701 RVA: 0x0009872F File Offset: 0x0009692F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003D56 RID: 15702 RVA: 0x0009873C File Offset: 0x0009693C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D57 RID: 15703 RVA: 0x00098748 File Offset: 0x00096948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.cameraSetting_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.CameraSetting);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D58 RID: 15704 RVA: 0x000987A4 File Offset: 0x000969A4
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

		// Token: 0x06003D59 RID: 15705 RVA: 0x000987FC File Offset: 0x000969FC
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

		// Token: 0x06003D5A RID: 15706 RVA: 0x00098864 File Offset: 0x00096A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D5B RID: 15707 RVA: 0x00098870 File Offset: 0x00096A70
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
				if (num != 58U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
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
		}

		// Token: 0x04002D00 RID: 11520
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D01 RID: 11521
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04002D02 RID: 11522
		private ErrorCode errorCode_;

		// Token: 0x04002D03 RID: 11523
		public const int CameraSettingFieldNumber = 7;

		// Token: 0x04002D04 RID: 11524
		private CameraSettingInfo cameraSetting_;
	}
}
