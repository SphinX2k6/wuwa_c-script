using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D39 RID: 3385
	[NetMessage(EMessageId.PinballInGameKickBallRequest)]
	public sealed class PinballInGameKickBallRequest : IMessage<PinballInGameKickBallRequest>, IMessage, IEquatable<PinballInGameKickBallRequest>, IDeepCloneable<PinballInGameKickBallRequest>, IBufferMessage
	{
		// Token: 0x06012497 RID: 74903 RVA: 0x002ABA8E File Offset: 0x002A9C8E
		[NullableContext(1)]
		public static PinballInGameKickBallRequest Create()
		{
			return new PinballInGameKickBallRequest();
		}

		// Token: 0x17003C97 RID: 15511
		// (get) Token: 0x06012498 RID: 74904 RVA: 0x002ABA95 File Offset: 0x002A9C95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C98 RID: 15512
		// (get) Token: 0x06012499 RID: 74905 RVA: 0x002ABA98 File Offset: 0x002A9C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballInGameKickBallRequest.Descriptor;
			}
		}

		// Token: 0x0601249A RID: 74906 RVA: 0x002ABA9F File Offset: 0x002A9C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameKickBallRequest()
		{
		}

		// Token: 0x0601249B RID: 74907 RVA: 0x002ABAA7 File Offset: 0x002A9CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameKickBallRequest(PinballInGameKickBallRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601249C RID: 74908 RVA: 0x002ABAC0 File Offset: 0x002A9CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameKickBallRequest Clone()
		{
			return new PinballInGameKickBallRequest(this);
		}

		// Token: 0x0601249D RID: 74909 RVA: 0x002ABAC8 File Offset: 0x002A9CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballInGameKickBallRequest);
		}

		// Token: 0x0601249E RID: 74910 RVA: 0x002ABAD6 File Offset: 0x002A9CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballInGameKickBallRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601249F RID: 74911 RVA: 0x002ABAF4 File Offset: 0x002A9CF4
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

		// Token: 0x060124A0 RID: 74912 RVA: 0x002ABB1A File Offset: 0x002A9D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060124A1 RID: 74913 RVA: 0x002ABB27 File Offset: 0x002A9D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060124A2 RID: 74914 RVA: 0x002ABB30 File Offset: 0x002A9D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060124A3 RID: 74915 RVA: 0x002ABB48 File Offset: 0x002A9D48
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

		// Token: 0x060124A4 RID: 74916 RVA: 0x002ABB6E File Offset: 0x002A9D6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballInGameKickBallRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060124A5 RID: 74917 RVA: 0x002ABB8B File Offset: 0x002A9D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060124A6 RID: 74918 RVA: 0x002ABB94 File Offset: 0x002A9D94
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

		// Token: 0x04007269 RID: 29289
		private UnknownFieldSet _unknownFields;
	}
}
