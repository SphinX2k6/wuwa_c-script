using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A07 RID: 2567
	[NetMessage(EMessageId.MoralePosRequest)]
	public sealed class MoralePosRequest : IMessage<MoralePosRequest>, IMessage, IEquatable<MoralePosRequest>, IDeepCloneable<MoralePosRequest>, IBufferMessage
	{
		// Token: 0x0600E0F0 RID: 57584 RVA: 0x0020FA82 File Offset: 0x0020DC82
		[NullableContext(1)]
		public static MoralePosRequest Create()
		{
			return new MoralePosRequest();
		}

		// Token: 0x17002D9B RID: 11675
		// (get) Token: 0x0600E0F1 RID: 57585 RVA: 0x0020FA89 File Offset: 0x0020DC89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D9C RID: 11676
		// (get) Token: 0x0600E0F2 RID: 57586 RVA: 0x0020FA8C File Offset: 0x0020DC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoralePosRequest.Descriptor;
			}
		}

		// Token: 0x0600E0F3 RID: 57587 RVA: 0x0020FA93 File Offset: 0x0020DC93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoralePosRequest()
		{
		}

		// Token: 0x0600E0F4 RID: 57588 RVA: 0x0020FA9B File Offset: 0x0020DC9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoralePosRequest(MoralePosRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E0F5 RID: 57589 RVA: 0x0020FAB4 File Offset: 0x0020DCB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoralePosRequest Clone()
		{
			return new MoralePosRequest(this);
		}

		// Token: 0x0600E0F6 RID: 57590 RVA: 0x0020FABC File Offset: 0x0020DCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoralePosRequest);
		}

		// Token: 0x0600E0F7 RID: 57591 RVA: 0x0020FACA File Offset: 0x0020DCCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoralePosRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600E0F8 RID: 57592 RVA: 0x0020FAE8 File Offset: 0x0020DCE8
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

		// Token: 0x0600E0F9 RID: 57593 RVA: 0x0020FB0E File Offset: 0x0020DD0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E0FA RID: 57594 RVA: 0x0020FB1B File Offset: 0x0020DD1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E0FB RID: 57595 RVA: 0x0020FB24 File Offset: 0x0020DD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E0FC RID: 57596 RVA: 0x0020FB3C File Offset: 0x0020DD3C
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

		// Token: 0x0600E0FD RID: 57597 RVA: 0x0020FB62 File Offset: 0x0020DD62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoralePosRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E0FE RID: 57598 RVA: 0x0020FB7F File Offset: 0x0020DD7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E0FF RID: 57599 RVA: 0x0020FB88 File Offset: 0x0020DD88
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

		// Token: 0x04005CE7 RID: 23783
		private UnknownFieldSet _unknownFields;
	}
}
