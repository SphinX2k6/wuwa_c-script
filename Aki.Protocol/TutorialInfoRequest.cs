using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001474 RID: 5236
	[NetMessage(EMessageId.TutorialInfoRequest)]
	public sealed class TutorialInfoRequest : IMessage<TutorialInfoRequest>, IMessage, IEquatable<TutorialInfoRequest>, IDeepCloneable<TutorialInfoRequest>, IBufferMessage
	{
		// Token: 0x0601BB7E RID: 113534 RVA: 0x00402D9A File Offset: 0x00400F9A
		[NullableContext(1)]
		public static TutorialInfoRequest Create()
		{
			return new TutorialInfoRequest();
		}

		// Token: 0x17005D79 RID: 23929
		// (get) Token: 0x0601BB7F RID: 113535 RVA: 0x00402DA1 File Offset: 0x00400FA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D7A RID: 23930
		// (get) Token: 0x0601BB80 RID: 113536 RVA: 0x00402DA4 File Offset: 0x00400FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TutorialInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601BB81 RID: 113537 RVA: 0x00402DAB File Offset: 0x00400FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialInfoRequest()
		{
		}

		// Token: 0x0601BB82 RID: 113538 RVA: 0x00402DB3 File Offset: 0x00400FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialInfoRequest(TutorialInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BB83 RID: 113539 RVA: 0x00402DCC File Offset: 0x00400FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialInfoRequest Clone()
		{
			return new TutorialInfoRequest(this);
		}

		// Token: 0x0601BB84 RID: 113540 RVA: 0x00402DD4 File Offset: 0x00400FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TutorialInfoRequest);
		}

		// Token: 0x0601BB85 RID: 113541 RVA: 0x00402DE2 File Offset: 0x00400FE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TutorialInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601BB86 RID: 113542 RVA: 0x00402E00 File Offset: 0x00401000
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

		// Token: 0x0601BB87 RID: 113543 RVA: 0x00402E26 File Offset: 0x00401026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BB88 RID: 113544 RVA: 0x00402E33 File Offset: 0x00401033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BB89 RID: 113545 RVA: 0x00402E3C File Offset: 0x0040103C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BB8A RID: 113546 RVA: 0x00402E54 File Offset: 0x00401054
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

		// Token: 0x0601BB8B RID: 113547 RVA: 0x00402E7A File Offset: 0x0040107A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TutorialInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BB8C RID: 113548 RVA: 0x00402E97 File Offset: 0x00401097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BB8D RID: 113549 RVA: 0x00402EA0 File Offset: 0x004010A0
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

		// Token: 0x04009FA7 RID: 40871
		private UnknownFieldSet _unknownFields;
	}
}
