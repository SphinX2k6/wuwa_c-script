using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D91 RID: 3473
	[NetMessage(EMessageId.PlayerPsnBlockListResponse)]
	public sealed class PlayerPsnBlockListResponse : IMessage<PlayerPsnBlockListResponse>, IMessage, IEquatable<PlayerPsnBlockListResponse>, IDeepCloneable<PlayerPsnBlockListResponse>, IBufferMessage
	{
		// Token: 0x06012BDA RID: 76762 RVA: 0x002BC584 File Offset: 0x002BA784
		[NullableContext(1)]
		public static PlayerPsnBlockListResponse Create()
		{
			return new PlayerPsnBlockListResponse();
		}

		// Token: 0x17003E2D RID: 15917
		// (get) Token: 0x06012BDB RID: 76763 RVA: 0x002BC58B File Offset: 0x002BA78B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E2E RID: 15918
		// (get) Token: 0x06012BDC RID: 76764 RVA: 0x002BC58E File Offset: 0x002BA78E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerPsnBlockListResponse.Descriptor;
			}
		}

		// Token: 0x06012BDD RID: 76765 RVA: 0x002BC595 File Offset: 0x002BA795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnBlockListResponse()
		{
		}

		// Token: 0x06012BDE RID: 76766 RVA: 0x002BC59D File Offset: 0x002BA79D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnBlockListResponse(PlayerPsnBlockListResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012BDF RID: 76767 RVA: 0x002BC5B6 File Offset: 0x002BA7B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnBlockListResponse Clone()
		{
			return new PlayerPsnBlockListResponse(this);
		}

		// Token: 0x06012BE0 RID: 76768 RVA: 0x002BC5BE File Offset: 0x002BA7BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerPsnBlockListResponse);
		}

		// Token: 0x06012BE1 RID: 76769 RVA: 0x002BC5CC File Offset: 0x002BA7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerPsnBlockListResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06012BE2 RID: 76770 RVA: 0x002BC5EC File Offset: 0x002BA7EC
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

		// Token: 0x06012BE3 RID: 76771 RVA: 0x002BC612 File Offset: 0x002BA812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012BE4 RID: 76772 RVA: 0x002BC61F File Offset: 0x002BA81F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012BE5 RID: 76773 RVA: 0x002BC628 File Offset: 0x002BA828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012BE6 RID: 76774 RVA: 0x002BC640 File Offset: 0x002BA840
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

		// Token: 0x06012BE7 RID: 76775 RVA: 0x002BC666 File Offset: 0x002BA866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerPsnBlockListResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012BE8 RID: 76776 RVA: 0x002BC683 File Offset: 0x002BA883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012BE9 RID: 76777 RVA: 0x002BC68C File Offset: 0x002BA88C
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

		// Token: 0x0400748A RID: 29834
		private UnknownFieldSet _unknownFields;
	}
}
