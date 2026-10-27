using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200022B RID: 555
	public sealed class CameraSettingInfo : IMessage<CameraSettingInfo>, IMessage, IEquatable<CameraSettingInfo>, IDeepCloneable<CameraSettingInfo>, IBufferMessage
	{
		// Token: 0x06003C5D RID: 15453 RVA: 0x00096265 File Offset: 0x00094465
		[NullableContext(1)]
		public static CameraSettingInfo Create()
		{
			return new CameraSettingInfo();
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06003C5E RID: 15454 RVA: 0x0009626C File Offset: 0x0009446C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06003C5F RID: 15455 RVA: 0x0009626F File Offset: 0x0009446F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CameraSettingInfo.Descriptor;
			}
		}

		// Token: 0x06003C60 RID: 15456 RVA: 0x00096276 File Offset: 0x00094476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingInfo()
		{
		}

		// Token: 0x06003C61 RID: 15457 RVA: 0x0009627E File Offset: 0x0009447E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingInfo(CameraSettingInfo other) : this()
		{
			this.cameraParam_ = ((other.cameraParam_ != null) ? other.cameraParam_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C62 RID: 15458 RVA: 0x000962B3 File Offset: 0x000944B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingInfo Clone()
		{
			return new CameraSettingInfo(this);
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06003C63 RID: 15459 RVA: 0x000962BB File Offset: 0x000944BB
		// (set) Token: 0x06003C64 RID: 15460 RVA: 0x000962C3 File Offset: 0x000944C3
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

		// Token: 0x06003C65 RID: 15461 RVA: 0x000962CC File Offset: 0x000944CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CameraSettingInfo);
		}

		// Token: 0x06003C66 RID: 15462 RVA: 0x000962DA File Offset: 0x000944DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CameraSettingInfo other)
		{
			return other != null && (other == this || (object.Equals(this.CameraParam, other.CameraParam) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003C67 RID: 15463 RVA: 0x00096310 File Offset: 0x00094510
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

		// Token: 0x06003C68 RID: 15464 RVA: 0x0009634C File Offset: 0x0009454C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003C69 RID: 15465 RVA: 0x00096359 File Offset: 0x00094559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C6A RID: 15466 RVA: 0x00096362 File Offset: 0x00094562
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

		// Token: 0x06003C6B RID: 15467 RVA: 0x00096394 File Offset: 0x00094594
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

		// Token: 0x06003C6C RID: 15468 RVA: 0x000963D4 File Offset: 0x000945D4
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

		// Token: 0x06003C6D RID: 15469 RVA: 0x00096428 File Offset: 0x00094628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C6E RID: 15470 RVA: 0x00096434 File Offset: 0x00094634
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

		// Token: 0x04002C74 RID: 11380
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C75 RID: 11381
		public const int CameraParamFieldNumber = 1;

		// Token: 0x04002C76 RID: 11382
		private CameraParamInfo cameraParam_;
	}
}
