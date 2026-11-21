using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001285 RID: 4741
	[NetMessage(EMessageId.SlashAndTowerInfoRequest)]
	public sealed class SlashAndTowerInfoRequest : IMessage<SlashAndTowerInfoRequest>, IMessage, IEquatable<SlashAndTowerInfoRequest>, IDeepCloneable<SlashAndTowerInfoRequest>, IBufferMessage
	{
		// Token: 0x060194F1 RID: 103665 RVA: 0x003B107F File Offset: 0x003AF27F
		[NullableContext(1)]
		public static SlashAndTowerInfoRequest Create()
		{
			return new SlashAndTowerInfoRequest();
		}

		// Token: 0x1700559A RID: 21914
		// (get) Token: 0x060194F2 RID: 103666 RVA: 0x003B1086 File Offset: 0x003AF286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700559B RID: 21915
		// (get) Token: 0x060194F3 RID: 103667 RVA: 0x003B1089 File Offset: 0x003AF289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerInfoRequest.Descriptor;
			}
		}

		// Token: 0x060194F4 RID: 103668 RVA: 0x003B1090 File Offset: 0x003AF290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerInfoRequest()
		{
		}

		// Token: 0x060194F5 RID: 103669 RVA: 0x003B1098 File Offset: 0x003AF298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerInfoRequest(SlashAndTowerInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060194F6 RID: 103670 RVA: 0x003B10B1 File Offset: 0x003AF2B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerInfoRequest Clone()
		{
			return new SlashAndTowerInfoRequest(this);
		}

		// Token: 0x060194F7 RID: 103671 RVA: 0x003B10B9 File Offset: 0x003AF2B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerInfoRequest);
		}

		// Token: 0x060194F8 RID: 103672 RVA: 0x003B10C7 File Offset: 0x003AF2C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060194F9 RID: 103673 RVA: 0x003B10E8 File Offset: 0x003AF2E8
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

		// Token: 0x060194FA RID: 103674 RVA: 0x003B110E File Offset: 0x003AF30E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060194FB RID: 103675 RVA: 0x003B111B File Offset: 0x003AF31B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060194FC RID: 103676 RVA: 0x003B1124 File Offset: 0x003AF324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060194FD RID: 103677 RVA: 0x003B113C File Offset: 0x003AF33C
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

		// Token: 0x060194FE RID: 103678 RVA: 0x003B1162 File Offset: 0x003AF362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlashAndTowerInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060194FF RID: 103679 RVA: 0x003B117F File Offset: 0x003AF37F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019500 RID: 103680 RVA: 0x003B1188 File Offset: 0x003AF388
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

		// Token: 0x040095BF RID: 38335
		private UnknownFieldSet _unknownFields;
	}
}
