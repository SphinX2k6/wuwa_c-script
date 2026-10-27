using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006D1 RID: 1745
	[NetMessage(EMessageId.GetTraceQuestYuXueModeRequest)]
	public sealed class GetTraceQuestYuXueModeRequest : IMessage<GetTraceQuestYuXueModeRequest>, IMessage, IEquatable<GetTraceQuestYuXueModeRequest>, IDeepCloneable<GetTraceQuestYuXueModeRequest>, IBufferMessage
	{
		// Token: 0x06009F76 RID: 40822 RVA: 0x0018280D File Offset: 0x00180A0D
		[NullableContext(1)]
		public static GetTraceQuestYuXueModeRequest Create()
		{
			return new GetTraceQuestYuXueModeRequest();
		}

		// Token: 0x17002008 RID: 8200
		// (get) Token: 0x06009F77 RID: 40823 RVA: 0x00182814 File Offset: 0x00180A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002009 RID: 8201
		// (get) Token: 0x06009F78 RID: 40824 RVA: 0x00182817 File Offset: 0x00180A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTraceQuestYuXueModeRequest.Descriptor;
			}
		}

		// Token: 0x06009F79 RID: 40825 RVA: 0x0018281E File Offset: 0x00180A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTraceQuestYuXueModeRequest()
		{
		}

		// Token: 0x06009F7A RID: 40826 RVA: 0x00182826 File Offset: 0x00180A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTraceQuestYuXueModeRequest(GetTraceQuestYuXueModeRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F7B RID: 40827 RVA: 0x0018283F File Offset: 0x00180A3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTraceQuestYuXueModeRequest Clone()
		{
			return new GetTraceQuestYuXueModeRequest(this);
		}

		// Token: 0x06009F7C RID: 40828 RVA: 0x00182847 File Offset: 0x00180A47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTraceQuestYuXueModeRequest);
		}

		// Token: 0x06009F7D RID: 40829 RVA: 0x00182855 File Offset: 0x00180A55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetTraceQuestYuXueModeRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009F7E RID: 40830 RVA: 0x00182874 File Offset: 0x00180A74
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

		// Token: 0x06009F7F RID: 40831 RVA: 0x0018289A File Offset: 0x00180A9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009F80 RID: 40832 RVA: 0x001828A7 File Offset: 0x00180AA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F81 RID: 40833 RVA: 0x001828B0 File Offset: 0x00180AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F82 RID: 40834 RVA: 0x001828C8 File Offset: 0x00180AC8
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

		// Token: 0x06009F83 RID: 40835 RVA: 0x001828EE File Offset: 0x00180AEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetTraceQuestYuXueModeRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009F84 RID: 40836 RVA: 0x0018290B File Offset: 0x00180B0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F85 RID: 40837 RVA: 0x00182914 File Offset: 0x00180B14
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

		// Token: 0x04004A6F RID: 19055
		private UnknownFieldSet _unknownFields;
	}
}
