using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001434 RID: 5172
	[NetMessage(EMessageId.TrapDefensePreviewFinishRequest)]
	public sealed class TrapDefensePreviewFinishRequest : IMessage<TrapDefensePreviewFinishRequest>, IMessage, IEquatable<TrapDefensePreviewFinishRequest>, IDeepCloneable<TrapDefensePreviewFinishRequest>, IBufferMessage
	{
		// Token: 0x0601B664 RID: 112228 RVA: 0x003F7AFF File Offset: 0x003F5CFF
		[NullableContext(1)]
		public static TrapDefensePreviewFinishRequest Create()
		{
			return new TrapDefensePreviewFinishRequest();
		}

		// Token: 0x17005C63 RID: 23651
		// (get) Token: 0x0601B665 RID: 112229 RVA: 0x003F7B06 File Offset: 0x003F5D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C64 RID: 23652
		// (get) Token: 0x0601B666 RID: 112230 RVA: 0x003F7B09 File Offset: 0x003F5D09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefensePreviewFinishRequest.Descriptor;
			}
		}

		// Token: 0x0601B667 RID: 112231 RVA: 0x003F7B10 File Offset: 0x003F5D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefensePreviewFinishRequest()
		{
		}

		// Token: 0x0601B668 RID: 112232 RVA: 0x003F7B18 File Offset: 0x003F5D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefensePreviewFinishRequest(TrapDefensePreviewFinishRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B669 RID: 112233 RVA: 0x003F7B31 File Offset: 0x003F5D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefensePreviewFinishRequest Clone()
		{
			return new TrapDefensePreviewFinishRequest(this);
		}

		// Token: 0x0601B66A RID: 112234 RVA: 0x003F7B39 File Offset: 0x003F5D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefensePreviewFinishRequest);
		}

		// Token: 0x0601B66B RID: 112235 RVA: 0x003F7B47 File Offset: 0x003F5D47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefensePreviewFinishRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601B66C RID: 112236 RVA: 0x003F7B68 File Offset: 0x003F5D68
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

		// Token: 0x0601B66D RID: 112237 RVA: 0x003F7B8E File Offset: 0x003F5D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B66E RID: 112238 RVA: 0x003F7B9B File Offset: 0x003F5D9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B66F RID: 112239 RVA: 0x003F7BA4 File Offset: 0x003F5DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B670 RID: 112240 RVA: 0x003F7BBC File Offset: 0x003F5DBC
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

		// Token: 0x0601B671 RID: 112241 RVA: 0x003F7BE2 File Offset: 0x003F5DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefensePreviewFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B672 RID: 112242 RVA: 0x003F7BFF File Offset: 0x003F5DFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B673 RID: 112243 RVA: 0x003F7C08 File Offset: 0x003F5E08
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

		// Token: 0x04009E29 RID: 40489
		private UnknownFieldSet _unknownFields;
	}
}
