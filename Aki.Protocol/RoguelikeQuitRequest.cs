using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FA9 RID: 4009
	[NetMessage(EMessageId.RoguelikeQuitRequest)]
	public sealed class RoguelikeQuitRequest : IMessage<RoguelikeQuitRequest>, IMessage, IEquatable<RoguelikeQuitRequest>, IDeepCloneable<RoguelikeQuitRequest>, IBufferMessage
	{
		// Token: 0x060156FF RID: 87807 RVA: 0x0031C8BF File Offset: 0x0031AABF
		[NullableContext(1)]
		public static RoguelikeQuitRequest Create()
		{
			return new RoguelikeQuitRequest();
		}

		// Token: 0x17004776 RID: 18294
		// (get) Token: 0x06015700 RID: 87808 RVA: 0x0031C8C6 File Offset: 0x0031AAC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004777 RID: 18295
		// (get) Token: 0x06015701 RID: 87809 RVA: 0x0031C8C9 File Offset: 0x0031AAC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeQuitRequest.Descriptor;
			}
		}

		// Token: 0x06015702 RID: 87810 RVA: 0x0031C8D0 File Offset: 0x0031AAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeQuitRequest()
		{
		}

		// Token: 0x06015703 RID: 87811 RVA: 0x0031C8D8 File Offset: 0x0031AAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeQuitRequest(RoguelikeQuitRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015704 RID: 87812 RVA: 0x0031C8F1 File Offset: 0x0031AAF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeQuitRequest Clone()
		{
			return new RoguelikeQuitRequest(this);
		}

		// Token: 0x06015705 RID: 87813 RVA: 0x0031C8F9 File Offset: 0x0031AAF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeQuitRequest);
		}

		// Token: 0x06015706 RID: 87814 RVA: 0x0031C907 File Offset: 0x0031AB07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeQuitRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06015707 RID: 87815 RVA: 0x0031C928 File Offset: 0x0031AB28
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

		// Token: 0x06015708 RID: 87816 RVA: 0x0031C94E File Offset: 0x0031AB4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015709 RID: 87817 RVA: 0x0031C95B File Offset: 0x0031AB5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601570A RID: 87818 RVA: 0x0031C964 File Offset: 0x0031AB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601570B RID: 87819 RVA: 0x0031C97C File Offset: 0x0031AB7C
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

		// Token: 0x0601570C RID: 87820 RVA: 0x0031C9A2 File Offset: 0x0031ABA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeQuitRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601570D RID: 87821 RVA: 0x0031C9BF File Offset: 0x0031ABBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601570E RID: 87822 RVA: 0x0031C9C8 File Offset: 0x0031ABC8
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

		// Token: 0x040080EE RID: 33006
		private UnknownFieldSet _unknownFields;
	}
}
