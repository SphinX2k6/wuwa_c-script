using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000854 RID: 2132
	[NetMessage(EMessageId.JoinSceneNotifyConfirmResponse)]
	public sealed class JoinSceneNotifyConfirmResponse : IMessage<JoinSceneNotifyConfirmResponse>, IMessage, IEquatable<JoinSceneNotifyConfirmResponse>, IDeepCloneable<JoinSceneNotifyConfirmResponse>, IBufferMessage
	{
		// Token: 0x0600BE5F RID: 48735 RVA: 0x001C4A89 File Offset: 0x001C2C89
		[NullableContext(1)]
		public static JoinSceneNotifyConfirmResponse Create()
		{
			return new JoinSceneNotifyConfirmResponse();
		}

		// Token: 0x1700266D RID: 9837
		// (get) Token: 0x0600BE60 RID: 48736 RVA: 0x001C4A90 File Offset: 0x001C2C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700266E RID: 9838
		// (get) Token: 0x0600BE61 RID: 48737 RVA: 0x001C4A93 File Offset: 0x001C2C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JoinSceneNotifyConfirmResponse.Descriptor;
			}
		}

		// Token: 0x0600BE62 RID: 48738 RVA: 0x001C4A9A File Offset: 0x001C2C9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinSceneNotifyConfirmResponse()
		{
		}

		// Token: 0x0600BE63 RID: 48739 RVA: 0x001C4AA2 File Offset: 0x001C2CA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinSceneNotifyConfirmResponse(JoinSceneNotifyConfirmResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BE64 RID: 48740 RVA: 0x001C4ABB File Offset: 0x001C2CBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinSceneNotifyConfirmResponse Clone()
		{
			return new JoinSceneNotifyConfirmResponse(this);
		}

		// Token: 0x0600BE65 RID: 48741 RVA: 0x001C4AC3 File Offset: 0x001C2CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JoinSceneNotifyConfirmResponse);
		}

		// Token: 0x0600BE66 RID: 48742 RVA: 0x001C4AD1 File Offset: 0x001C2CD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JoinSceneNotifyConfirmResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600BE67 RID: 48743 RVA: 0x001C4AF0 File Offset: 0x001C2CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BE68 RID: 48744 RVA: 0x001C4B16 File Offset: 0x001C2D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BE69 RID: 48745 RVA: 0x001C4B23 File Offset: 0x001C2D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BE6A RID: 48746 RVA: 0x001C4B2C File Offset: 0x001C2D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BE6B RID: 48747 RVA: 0x001C4B44 File Offset: 0x001C2D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BE6C RID: 48748 RVA: 0x001C4B6A File Offset: 0x001C2D6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JoinSceneNotifyConfirmResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BE6D RID: 48749 RVA: 0x001C4B87 File Offset: 0x001C2D87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BE6E RID: 48750 RVA: 0x001C4B90 File Offset: 0x001C2D90
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005360 RID: 21344
		private UnknownFieldSet _unknownFields;
	}
}
