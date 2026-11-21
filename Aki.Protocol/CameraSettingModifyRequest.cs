using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000231 RID: 561
	[NetMessage(EMessageId.CameraSettingModifyRequest)]
	public sealed class CameraSettingModifyRequest : IMessage<CameraSettingModifyRequest>, IMessage, IEquatable<CameraSettingModifyRequest>, IDeepCloneable<CameraSettingModifyRequest>, IBufferMessage
	{
		// Token: 0x06003D14 RID: 15636 RVA: 0x000980A8 File Offset: 0x000962A8
		[NullableContext(1)]
		public static CameraSettingModifyRequest Create()
		{
			return new CameraSettingModifyRequest();
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06003D15 RID: 15637 RVA: 0x000980AF File Offset: 0x000962AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06003D16 RID: 15638 RVA: 0x000980B2 File Offset: 0x000962B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CameraSettingModifyRequest.Descriptor;
			}
		}

		// Token: 0x06003D17 RID: 15639 RVA: 0x000980B9 File Offset: 0x000962B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingModifyRequest()
		{
		}

		// Token: 0x06003D18 RID: 15640 RVA: 0x000980C1 File Offset: 0x000962C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingModifyRequest(CameraSettingModifyRequest other) : this()
		{
			this.cameraSetting_ = ((other.cameraSetting_ != null) ? other.cameraSetting_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D19 RID: 15641 RVA: 0x000980F6 File Offset: 0x000962F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingModifyRequest Clone()
		{
			return new CameraSettingModifyRequest(this);
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06003D1A RID: 15642 RVA: 0x000980FE File Offset: 0x000962FE
		// (set) Token: 0x06003D1B RID: 15643 RVA: 0x00098106 File Offset: 0x00096306
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

		// Token: 0x06003D1C RID: 15644 RVA: 0x0009810F File Offset: 0x0009630F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CameraSettingModifyRequest);
		}

		// Token: 0x06003D1D RID: 15645 RVA: 0x0009811D File Offset: 0x0009631D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CameraSettingModifyRequest other)
		{
			return other != null && (other == this || (object.Equals(this.CameraSetting, other.CameraSetting) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003D1E RID: 15646 RVA: 0x00098150 File Offset: 0x00096350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06003D1F RID: 15647 RVA: 0x0009818C File Offset: 0x0009638C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003D20 RID: 15648 RVA: 0x00098199 File Offset: 0x00096399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D21 RID: 15649 RVA: 0x000981A2 File Offset: 0x000963A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.cameraSetting_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.CameraSetting);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D22 RID: 15650 RVA: 0x000981D4 File Offset: 0x000963D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06003D23 RID: 15651 RVA: 0x00098214 File Offset: 0x00096414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CameraSettingModifyRequest other)
		{
			if (other == null)
			{
				return;
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

		// Token: 0x06003D24 RID: 15652 RVA: 0x00098268 File Offset: 0x00096468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D25 RID: 15653 RVA: 0x00098274 File Offset: 0x00096474
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
				if (num != 50U)
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
		}

		// Token: 0x04002CF9 RID: 11513
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CFA RID: 11514
		public const int CameraSettingFieldNumber = 6;

		// Token: 0x04002CFB RID: 11515
		private CameraSettingInfo cameraSetting_;
	}
}
