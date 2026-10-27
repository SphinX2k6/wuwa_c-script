using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D94 RID: 3476
	[NetMessage(EMessageId.PlayerHeadRequest)]
	public sealed class PlayerHeadRequest : IMessage<PlayerHeadRequest>, IMessage, IEquatable<PlayerHeadRequest>, IDeepCloneable<PlayerHeadRequest>, IBufferMessage
	{
		// Token: 0x06012BDE RID: 76766 RVA: 0x002BC465 File Offset: 0x002BA665
		[NullableContext(1)]
		public static PlayerHeadRequest Create()
		{
			return new PlayerHeadRequest();
		}

		// Token: 0x17003E34 RID: 15924
		// (get) Token: 0x06012BDF RID: 76767 RVA: 0x002BC46C File Offset: 0x002BA66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E35 RID: 15925
		// (get) Token: 0x06012BE0 RID: 76768 RVA: 0x002BC46F File Offset: 0x002BA66F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerHeadRequest.Descriptor;
			}
		}

		// Token: 0x06012BE1 RID: 76769 RVA: 0x002BC476 File Offset: 0x002BA676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeadRequest()
		{
		}

		// Token: 0x06012BE2 RID: 76770 RVA: 0x002BC47E File Offset: 0x002BA67E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeadRequest(PlayerHeadRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012BE3 RID: 76771 RVA: 0x002BC497 File Offset: 0x002BA697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeadRequest Clone()
		{
			return new PlayerHeadRequest(this);
		}

		// Token: 0x06012BE4 RID: 76772 RVA: 0x002BC49F File Offset: 0x002BA69F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerHeadRequest);
		}

		// Token: 0x06012BE5 RID: 76773 RVA: 0x002BC4AD File Offset: 0x002BA6AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerHeadRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06012BE6 RID: 76774 RVA: 0x002BC4CC File Offset: 0x002BA6CC
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

		// Token: 0x06012BE7 RID: 76775 RVA: 0x002BC4F2 File Offset: 0x002BA6F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012BE8 RID: 76776 RVA: 0x002BC4FF File Offset: 0x002BA6FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012BE9 RID: 76777 RVA: 0x002BC508 File Offset: 0x002BA708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012BEA RID: 76778 RVA: 0x002BC520 File Offset: 0x002BA720
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

		// Token: 0x06012BEB RID: 76779 RVA: 0x002BC546 File Offset: 0x002BA746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerHeadRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012BEC RID: 76780 RVA: 0x002BC563 File Offset: 0x002BA763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012BED RID: 76781 RVA: 0x002BC56C File Offset: 0x002BA76C
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

		// Token: 0x0400743A RID: 29754
		private UnknownFieldSet _unknownFields;
	}
}
