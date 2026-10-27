using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000865 RID: 2149
	[NetMessage(EMessageId.JoinSceneNotifyConfirmResponse)]
	public sealed class JoinSceneNotifyConfirmResponse : IMessage<JoinSceneNotifyConfirmResponse>, IMessage, IEquatable<JoinSceneNotifyConfirmResponse>, IDeepCloneable<JoinSceneNotifyConfirmResponse>, IBufferMessage
	{
		// Token: 0x0600BF7B RID: 49019 RVA: 0x001C6D71 File Offset: 0x001C4F71
		[NullableContext(1)]
		public static JoinSceneNotifyConfirmResponse Create()
		{
			return new JoinSceneNotifyConfirmResponse();
		}

		// Token: 0x170026AC RID: 9900
		// (get) Token: 0x0600BF7C RID: 49020 RVA: 0x001C6D78 File Offset: 0x001C4F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026AD RID: 9901
		// (get) Token: 0x0600BF7D RID: 49021 RVA: 0x001C6D7B File Offset: 0x001C4F7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JoinSceneNotifyConfirmResponse.Descriptor;
			}
		}

		// Token: 0x0600BF7E RID: 49022 RVA: 0x001C6D82 File Offset: 0x001C4F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinSceneNotifyConfirmResponse()
		{
		}

		// Token: 0x0600BF7F RID: 49023 RVA: 0x001C6D8A File Offset: 0x001C4F8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinSceneNotifyConfirmResponse(JoinSceneNotifyConfirmResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BF80 RID: 49024 RVA: 0x001C6DA3 File Offset: 0x001C4FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinSceneNotifyConfirmResponse Clone()
		{
			return new JoinSceneNotifyConfirmResponse(this);
		}

		// Token: 0x0600BF81 RID: 49025 RVA: 0x001C6DAB File Offset: 0x001C4FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JoinSceneNotifyConfirmResponse);
		}

		// Token: 0x0600BF82 RID: 49026 RVA: 0x001C6DB9 File Offset: 0x001C4FB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JoinSceneNotifyConfirmResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600BF83 RID: 49027 RVA: 0x001C6DD8 File Offset: 0x001C4FD8
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

		// Token: 0x0600BF84 RID: 49028 RVA: 0x001C6DFE File Offset: 0x001C4FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BF85 RID: 49029 RVA: 0x001C6E0B File Offset: 0x001C500B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BF86 RID: 49030 RVA: 0x001C6E14 File Offset: 0x001C5014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BF87 RID: 49031 RVA: 0x001C6E2C File Offset: 0x001C502C
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

		// Token: 0x0600BF88 RID: 49032 RVA: 0x001C6E52 File Offset: 0x001C5052
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

		// Token: 0x0600BF89 RID: 49033 RVA: 0x001C6E6F File Offset: 0x001C506F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BF8A RID: 49034 RVA: 0x001C6E78 File Offset: 0x001C5078
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

		// Token: 0x04005359 RID: 21337
		private UnknownFieldSet _unknownFields;
	}
}
