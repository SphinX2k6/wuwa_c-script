using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006BD RID: 1725
	[NetMessage(EMessageId.GetTraceQuestYuXueModeRequest)]
	public sealed class GetTraceQuestYuXueModeRequest : IMessage<GetTraceQuestYuXueModeRequest>, IMessage, IEquatable<GetTraceQuestYuXueModeRequest>, IDeepCloneable<GetTraceQuestYuXueModeRequest>, IBufferMessage
	{
		// Token: 0x06009E20 RID: 40480 RVA: 0x0017FDD9 File Offset: 0x0017DFD9
		[NullableContext(1)]
		public static GetTraceQuestYuXueModeRequest Create()
		{
			return new GetTraceQuestYuXueModeRequest();
		}

		// Token: 0x17001FBE RID: 8126
		// (get) Token: 0x06009E21 RID: 40481 RVA: 0x0017FDE0 File Offset: 0x0017DFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FBF RID: 8127
		// (get) Token: 0x06009E22 RID: 40482 RVA: 0x0017FDE3 File Offset: 0x0017DFE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTraceQuestYuXueModeRequest.Descriptor;
			}
		}

		// Token: 0x06009E23 RID: 40483 RVA: 0x0017FDEA File Offset: 0x0017DFEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTraceQuestYuXueModeRequest()
		{
		}

		// Token: 0x06009E24 RID: 40484 RVA: 0x0017FDF2 File Offset: 0x0017DFF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTraceQuestYuXueModeRequest(GetTraceQuestYuXueModeRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E25 RID: 40485 RVA: 0x0017FE0B File Offset: 0x0017E00B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTraceQuestYuXueModeRequest Clone()
		{
			return new GetTraceQuestYuXueModeRequest(this);
		}

		// Token: 0x06009E26 RID: 40486 RVA: 0x0017FE13 File Offset: 0x0017E013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTraceQuestYuXueModeRequest);
		}

		// Token: 0x06009E27 RID: 40487 RVA: 0x0017FE21 File Offset: 0x0017E021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetTraceQuestYuXueModeRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009E28 RID: 40488 RVA: 0x0017FE40 File Offset: 0x0017E040
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

		// Token: 0x06009E29 RID: 40489 RVA: 0x0017FE66 File Offset: 0x0017E066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009E2A RID: 40490 RVA: 0x0017FE73 File Offset: 0x0017E073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E2B RID: 40491 RVA: 0x0017FE7C File Offset: 0x0017E07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009E2C RID: 40492 RVA: 0x0017FE94 File Offset: 0x0017E094
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

		// Token: 0x06009E2D RID: 40493 RVA: 0x0017FEBA File Offset: 0x0017E0BA
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

		// Token: 0x06009E2E RID: 40494 RVA: 0x0017FED7 File Offset: 0x0017E0D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E2F RID: 40495 RVA: 0x0017FEE0 File Offset: 0x0017E0E0
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

		// Token: 0x04004A68 RID: 19048
		private UnknownFieldSet _unknownFields;
	}
}
