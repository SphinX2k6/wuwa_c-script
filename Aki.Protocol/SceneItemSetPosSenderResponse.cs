using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001175 RID: 4469
	[NetMessage(EMessageId.SceneItemSetPosSenderResponse)]
	public sealed class SceneItemSetPosSenderResponse : IMessage<SceneItemSetPosSenderResponse>, IMessage, IEquatable<SceneItemSetPosSenderResponse>, IDeepCloneable<SceneItemSetPosSenderResponse>, IBufferMessage
	{
		// Token: 0x06017D2D RID: 97581 RVA: 0x00375DF8 File Offset: 0x00373FF8
		[NullableContext(1)]
		public static SceneItemSetPosSenderResponse Create()
		{
			return new SceneItemSetPosSenderResponse();
		}

		// Token: 0x17005007 RID: 20487
		// (get) Token: 0x06017D2E RID: 97582 RVA: 0x00375DFF File Offset: 0x00373FFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005008 RID: 20488
		// (get) Token: 0x06017D2F RID: 97583 RVA: 0x00375E02 File Offset: 0x00374002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemSetPosSenderResponse.Descriptor;
			}
		}

		// Token: 0x06017D30 RID: 97584 RVA: 0x00375E09 File Offset: 0x00374009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSetPosSenderResponse()
		{
		}

		// Token: 0x06017D31 RID: 97585 RVA: 0x00375E11 File Offset: 0x00374011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSetPosSenderResponse(SceneItemSetPosSenderResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017D32 RID: 97586 RVA: 0x00375E36 File Offset: 0x00374036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSetPosSenderResponse Clone()
		{
			return new SceneItemSetPosSenderResponse(this);
		}

		// Token: 0x17005009 RID: 20489
		// (get) Token: 0x06017D33 RID: 97587 RVA: 0x00375E3E File Offset: 0x0037403E
		// (set) Token: 0x06017D34 RID: 97588 RVA: 0x00375E46 File Offset: 0x00374046
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

		// Token: 0x06017D35 RID: 97589 RVA: 0x00375E4F File Offset: 0x0037404F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemSetPosSenderResponse);
		}

		// Token: 0x06017D36 RID: 97590 RVA: 0x00375E5D File Offset: 0x0037405D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemSetPosSenderResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017D37 RID: 97591 RVA: 0x00375E8C File Offset: 0x0037408C
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

		// Token: 0x06017D38 RID: 97592 RVA: 0x00375ED1 File Offset: 0x003740D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017D39 RID: 97593 RVA: 0x00375EDE File Offset: 0x003740DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017D3A RID: 97594 RVA: 0x00375EE7 File Offset: 0x003740E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017D3B RID: 97595 RVA: 0x00375F1C File Offset: 0x0037411C
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

		// Token: 0x06017D3C RID: 97596 RVA: 0x00375F5A File Offset: 0x0037415A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemSetPosSenderResponse other)
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

		// Token: 0x06017D3D RID: 97597 RVA: 0x00375F8B File Offset: 0x0037418B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017D3E RID: 97598 RVA: 0x00375F94 File Offset: 0x00374194
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008D44 RID: 36164
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D45 RID: 36165
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04008D46 RID: 36166
		private ErrorCode errorCode_;
	}
}
