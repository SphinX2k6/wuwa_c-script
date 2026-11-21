using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000230 RID: 560
	public sealed class CameraSettingInfo : IMessage<CameraSettingInfo>, IMessage, IEquatable<CameraSettingInfo>, IDeepCloneable<CameraSettingInfo>, IBufferMessage
	{
		// Token: 0x06003D02 RID: 15618 RVA: 0x00097E81 File Offset: 0x00096081
		[NullableContext(1)]
		public static CameraSettingInfo Create()
		{
			return new CameraSettingInfo();
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06003D03 RID: 15619 RVA: 0x00097E88 File Offset: 0x00096088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06003D04 RID: 15620 RVA: 0x00097E8B File Offset: 0x0009608B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CameraSettingInfo.Descriptor;
			}
		}

		// Token: 0x06003D05 RID: 15621 RVA: 0x00097E92 File Offset: 0x00096092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingInfo()
		{
		}

		// Token: 0x06003D06 RID: 15622 RVA: 0x00097E9A File Offset: 0x0009609A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingInfo(CameraSettingInfo other) : this()
		{
			this.cameraParam_ = ((other.cameraParam_ != null) ? other.cameraParam_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D07 RID: 15623 RVA: 0x00097ECF File Offset: 0x000960CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingInfo Clone()
		{
			return new CameraSettingInfo(this);
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06003D08 RID: 15624 RVA: 0x00097ED7 File Offset: 0x000960D7
		// (set) Token: 0x06003D09 RID: 15625 RVA: 0x00097EDF File Offset: 0x000960DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraParamInfo CameraParam
		{
			get
			{
				return this.cameraParam_;
			}
			set
			{
				this.cameraParam_ = value;
			}
		}

		// Token: 0x06003D0A RID: 15626 RVA: 0x00097EE8 File Offset: 0x000960E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CameraSettingInfo);
		}

		// Token: 0x06003D0B RID: 15627 RVA: 0x00097EF6 File Offset: 0x000960F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CameraSettingInfo other)
		{
			return other != null && (other == this || (object.Equals(this.CameraParam, other.CameraParam) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003D0C RID: 15628 RVA: 0x00097F2C File Offset: 0x0009612C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.cameraParam_ != null)
			{
				num ^= this.CameraParam.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003D0D RID: 15629 RVA: 0x00097F68 File Offset: 0x00096168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003D0E RID: 15630 RVA: 0x00097F75 File Offset: 0x00096175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D0F RID: 15631 RVA: 0x00097F7E File Offset: 0x0009617E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.cameraParam_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.CameraParam);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D10 RID: 15632 RVA: 0x00097FB0 File Offset: 0x000961B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.cameraParam_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CameraParam);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003D11 RID: 15633 RVA: 0x00097FF0 File Offset: 0x000961F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CameraSettingInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.cameraParam_ != null)
			{
				if (this.cameraParam_ == null)
				{
					this.CameraParam = new CameraParamInfo();
				}
				this.CameraParam.MergeFrom(other.CameraParam);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003D12 RID: 15634 RVA: 0x00098044 File Offset: 0x00096244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D13 RID: 15635 RVA: 0x00098050 File Offset: 0x00096250
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.cameraParam_ == null)
					{
						this.CameraParam = new CameraParamInfo();
					}
					input.ReadMessage(this.CameraParam);
				}
			}
		}

		// Token: 0x04002CF6 RID: 11510
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CF7 RID: 11511
		public const int CameraParamFieldNumber = 1;

		// Token: 0x04002CF8 RID: 11512
		private CameraParamInfo cameraParam_;
	}
}
