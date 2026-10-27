using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200022C RID: 556
	[NetMessage(EMessageId.CameraSettingModifyRequest)]
	public sealed class CameraSettingModifyRequest : IMessage<CameraSettingModifyRequest>, IMessage, IEquatable<CameraSettingModifyRequest>, IDeepCloneable<CameraSettingModifyRequest>, IBufferMessage
	{
		// Token: 0x06003C6F RID: 15471 RVA: 0x0009648C File Offset: 0x0009468C
		[NullableContext(1)]
		public static CameraSettingModifyRequest Create()
		{
			return new CameraSettingModifyRequest();
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06003C70 RID: 15472 RVA: 0x00096493 File Offset: 0x00094693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06003C71 RID: 15473 RVA: 0x00096496 File Offset: 0x00094696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CameraSettingModifyRequest.Descriptor;
			}
		}

		// Token: 0x06003C72 RID: 15474 RVA: 0x0009649D File Offset: 0x0009469D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingModifyRequest()
		{
		}

		// Token: 0x06003C73 RID: 15475 RVA: 0x000964A5 File Offset: 0x000946A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingModifyRequest(CameraSettingModifyRequest other) : this()
		{
			this.cameraSetting_ = ((other.cameraSetting_ != null) ? other.cameraSetting_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C74 RID: 15476 RVA: 0x000964DA File Offset: 0x000946DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingModifyRequest Clone()
		{
			return new CameraSettingModifyRequest(this);
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06003C75 RID: 15477 RVA: 0x000964E2 File Offset: 0x000946E2
		// (set) Token: 0x06003C76 RID: 15478 RVA: 0x000964EA File Offset: 0x000946EA
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

		// Token: 0x06003C77 RID: 15479 RVA: 0x000964F3 File Offset: 0x000946F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CameraSettingModifyRequest);
		}

		// Token: 0x06003C78 RID: 15480 RVA: 0x00096501 File Offset: 0x00094701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CameraSettingModifyRequest other)
		{
			return other != null && (other == this || (object.Equals(this.CameraSetting, other.CameraSetting) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003C79 RID: 15481 RVA: 0x00096534 File Offset: 0x00094734
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

		// Token: 0x06003C7A RID: 15482 RVA: 0x00096570 File Offset: 0x00094770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003C7B RID: 15483 RVA: 0x0009657D File Offset: 0x0009477D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C7C RID: 15484 RVA: 0x00096586 File Offset: 0x00094786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.cameraSetting_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.CameraSetting);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003C7D RID: 15485 RVA: 0x000965B8 File Offset: 0x000947B8
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

		// Token: 0x06003C7E RID: 15486 RVA: 0x000965F8 File Offset: 0x000947F8
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

		// Token: 0x06003C7F RID: 15487 RVA: 0x0009664C File Offset: 0x0009484C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C80 RID: 15488 RVA: 0x00096658 File Offset: 0x00094858
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
				if (num != 74U)
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

		// Token: 0x04002C77 RID: 11383
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C78 RID: 11384
		public const int CameraSettingFieldNumber = 9;

		// Token: 0x04002C79 RID: 11385
		private CameraSettingInfo cameraSetting_;
	}
}
