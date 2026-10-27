using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DB9 RID: 3513
	[NetMessage(EMessageId.PlayerVoiceLanguageRequest)]
	public sealed class PlayerVoiceLanguageRequest : IMessage<PlayerVoiceLanguageRequest>, IMessage, IEquatable<PlayerVoiceLanguageRequest>, IDeepCloneable<PlayerVoiceLanguageRequest>, IBufferMessage
	{
		// Token: 0x06012ED5 RID: 77525 RVA: 0x002C2D2C File Offset: 0x002C0F2C
		[NullableContext(1)]
		public static PlayerVoiceLanguageRequest Create()
		{
			return new PlayerVoiceLanguageRequest();
		}

		// Token: 0x17003ED6 RID: 16086
		// (get) Token: 0x06012ED6 RID: 77526 RVA: 0x002C2D33 File Offset: 0x002C0F33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003ED7 RID: 16087
		// (get) Token: 0x06012ED7 RID: 77527 RVA: 0x002C2D36 File Offset: 0x002C0F36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerVoiceLanguageRequest.Descriptor;
			}
		}

		// Token: 0x06012ED8 RID: 77528 RVA: 0x002C2D3D File Offset: 0x002C0F3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVoiceLanguageRequest()
		{
		}

		// Token: 0x06012ED9 RID: 77529 RVA: 0x002C2D45 File Offset: 0x002C0F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVoiceLanguageRequest(PlayerVoiceLanguageRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012EDA RID: 77530 RVA: 0x002C2D5E File Offset: 0x002C0F5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVoiceLanguageRequest Clone()
		{
			return new PlayerVoiceLanguageRequest(this);
		}

		// Token: 0x06012EDB RID: 77531 RVA: 0x002C2D66 File Offset: 0x002C0F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerVoiceLanguageRequest);
		}

		// Token: 0x06012EDC RID: 77532 RVA: 0x002C2D74 File Offset: 0x002C0F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerVoiceLanguageRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06012EDD RID: 77533 RVA: 0x002C2D94 File Offset: 0x002C0F94
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

		// Token: 0x06012EDE RID: 77534 RVA: 0x002C2DBA File Offset: 0x002C0FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012EDF RID: 77535 RVA: 0x002C2DC7 File Offset: 0x002C0FC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012EE0 RID: 77536 RVA: 0x002C2DD0 File Offset: 0x002C0FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012EE1 RID: 77537 RVA: 0x002C2DE8 File Offset: 0x002C0FE8
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

		// Token: 0x06012EE2 RID: 77538 RVA: 0x002C2E0E File Offset: 0x002C100E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerVoiceLanguageRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012EE3 RID: 77539 RVA: 0x002C2E2B File Offset: 0x002C102B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012EE4 RID: 77540 RVA: 0x002C2E34 File Offset: 0x002C1034
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

		// Token: 0x0400751E RID: 29982
		private UnknownFieldSet _unknownFields;
	}
}
