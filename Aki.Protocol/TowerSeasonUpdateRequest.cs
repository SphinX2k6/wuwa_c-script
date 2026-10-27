using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013CC RID: 5068
	[NetMessage(EMessageId.TowerSeasonUpdateRequest)]
	public sealed class TowerSeasonUpdateRequest : IMessage<TowerSeasonUpdateRequest>, IMessage, IEquatable<TowerSeasonUpdateRequest>, IDeepCloneable<TowerSeasonUpdateRequest>, IBufferMessage
	{
		// Token: 0x0601AE19 RID: 110105 RVA: 0x003E59BE File Offset: 0x003E3BBE
		[NullableContext(1)]
		public static TowerSeasonUpdateRequest Create()
		{
			return new TowerSeasonUpdateRequest();
		}

		// Token: 0x17005AA9 RID: 23209
		// (get) Token: 0x0601AE1A RID: 110106 RVA: 0x003E59C5 File Offset: 0x003E3BC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AAA RID: 23210
		// (get) Token: 0x0601AE1B RID: 110107 RVA: 0x003E59C8 File Offset: 0x003E3BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerSeasonUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0601AE1C RID: 110108 RVA: 0x003E59CF File Offset: 0x003E3BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerSeasonUpdateRequest()
		{
		}

		// Token: 0x0601AE1D RID: 110109 RVA: 0x003E59D7 File Offset: 0x003E3BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerSeasonUpdateRequest(TowerSeasonUpdateRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AE1E RID: 110110 RVA: 0x003E59F0 File Offset: 0x003E3BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerSeasonUpdateRequest Clone()
		{
			return new TowerSeasonUpdateRequest(this);
		}

		// Token: 0x0601AE1F RID: 110111 RVA: 0x003E59F8 File Offset: 0x003E3BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerSeasonUpdateRequest);
		}

		// Token: 0x0601AE20 RID: 110112 RVA: 0x003E5A06 File Offset: 0x003E3C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerSeasonUpdateRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601AE21 RID: 110113 RVA: 0x003E5A24 File Offset: 0x003E3C24
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

		// Token: 0x0601AE22 RID: 110114 RVA: 0x003E5A4A File Offset: 0x003E3C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AE23 RID: 110115 RVA: 0x003E5A57 File Offset: 0x003E3C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AE24 RID: 110116 RVA: 0x003E5A60 File Offset: 0x003E3C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AE25 RID: 110117 RVA: 0x003E5A78 File Offset: 0x003E3C78
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

		// Token: 0x0601AE26 RID: 110118 RVA: 0x003E5A9E File Offset: 0x003E3C9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerSeasonUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AE27 RID: 110119 RVA: 0x003E5ABB File Offset: 0x003E3CBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AE28 RID: 110120 RVA: 0x003E5AC4 File Offset: 0x003E3CC4
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

		// Token: 0x04009BF2 RID: 39922
		private UnknownFieldSet _unknownFields;
	}
}
