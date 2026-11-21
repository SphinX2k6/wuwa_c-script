using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D7F RID: 3455
	[NetMessage(EMessageId.PlayerGameTokenRequest)]
	public sealed class PlayerGameTokenRequest : IMessage<PlayerGameTokenRequest>, IMessage, IEquatable<PlayerGameTokenRequest>, IDeepCloneable<PlayerGameTokenRequest>, IBufferMessage
	{
		// Token: 0x06012A86 RID: 76422 RVA: 0x002B9D0A File Offset: 0x002B7F0A
		[NullableContext(1)]
		public static PlayerGameTokenRequest Create()
		{
			return new PlayerGameTokenRequest();
		}

		// Token: 0x17003DEF RID: 15855
		// (get) Token: 0x06012A87 RID: 76423 RVA: 0x002B9D11 File Offset: 0x002B7F11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DF0 RID: 15856
		// (get) Token: 0x06012A88 RID: 76424 RVA: 0x002B9D14 File Offset: 0x002B7F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerGameTokenRequest.Descriptor;
			}
		}

		// Token: 0x06012A89 RID: 76425 RVA: 0x002B9D1B File Offset: 0x002B7F1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerGameTokenRequest()
		{
		}

		// Token: 0x06012A8A RID: 76426 RVA: 0x002B9D23 File Offset: 0x002B7F23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerGameTokenRequest(PlayerGameTokenRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012A8B RID: 76427 RVA: 0x002B9D3C File Offset: 0x002B7F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerGameTokenRequest Clone()
		{
			return new PlayerGameTokenRequest(this);
		}

		// Token: 0x06012A8C RID: 76428 RVA: 0x002B9D44 File Offset: 0x002B7F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerGameTokenRequest);
		}

		// Token: 0x06012A8D RID: 76429 RVA: 0x002B9D52 File Offset: 0x002B7F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerGameTokenRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06012A8E RID: 76430 RVA: 0x002B9D70 File Offset: 0x002B7F70
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

		// Token: 0x06012A8F RID: 76431 RVA: 0x002B9D96 File Offset: 0x002B7F96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012A90 RID: 76432 RVA: 0x002B9DA3 File Offset: 0x002B7FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012A91 RID: 76433 RVA: 0x002B9DAC File Offset: 0x002B7FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012A92 RID: 76434 RVA: 0x002B9DC4 File Offset: 0x002B7FC4
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

		// Token: 0x06012A93 RID: 76435 RVA: 0x002B9DEA File Offset: 0x002B7FEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerGameTokenRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012A94 RID: 76436 RVA: 0x002B9E07 File Offset: 0x002B8007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012A95 RID: 76437 RVA: 0x002B9E10 File Offset: 0x002B8010
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

		// Token: 0x04007440 RID: 29760
		private UnknownFieldSet _unknownFields;
	}
}
