using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013A6 RID: 5030
	[NetMessage(EMessageId.TeleportDataRequest)]
	public sealed class TeleportDataRequest : IMessage<TeleportDataRequest>, IMessage, IEquatable<TeleportDataRequest>, IDeepCloneable<TeleportDataRequest>, IBufferMessage
	{
		// Token: 0x0601AC54 RID: 109652 RVA: 0x003E5FF4 File Offset: 0x003E41F4
		[NullableContext(1)]
		public static TeleportDataRequest Create()
		{
			return new TeleportDataRequest();
		}

		// Token: 0x17005AA3 RID: 23203
		// (get) Token: 0x0601AC55 RID: 109653 RVA: 0x003E5FFB File Offset: 0x003E41FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AA4 RID: 23204
		// (get) Token: 0x0601AC56 RID: 109654 RVA: 0x003E5FFE File Offset: 0x003E41FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportDataRequest.Descriptor;
			}
		}

		// Token: 0x0601AC57 RID: 109655 RVA: 0x003E6005 File Offset: 0x003E4205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDataRequest()
		{
		}

		// Token: 0x0601AC58 RID: 109656 RVA: 0x003E600D File Offset: 0x003E420D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDataRequest(TeleportDataRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AC59 RID: 109657 RVA: 0x003E6026 File Offset: 0x003E4226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDataRequest Clone()
		{
			return new TeleportDataRequest(this);
		}

		// Token: 0x0601AC5A RID: 109658 RVA: 0x003E602E File Offset: 0x003E422E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportDataRequest);
		}

		// Token: 0x0601AC5B RID: 109659 RVA: 0x003E603C File Offset: 0x003E423C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportDataRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601AC5C RID: 109660 RVA: 0x003E605C File Offset: 0x003E425C
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

		// Token: 0x0601AC5D RID: 109661 RVA: 0x003E6082 File Offset: 0x003E4282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AC5E RID: 109662 RVA: 0x003E608F File Offset: 0x003E428F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AC5F RID: 109663 RVA: 0x003E6098 File Offset: 0x003E4298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AC60 RID: 109664 RVA: 0x003E60B0 File Offset: 0x003E42B0
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

		// Token: 0x0601AC61 RID: 109665 RVA: 0x003E60D6 File Offset: 0x003E42D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportDataRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AC62 RID: 109666 RVA: 0x003E60F3 File Offset: 0x003E42F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AC63 RID: 109667 RVA: 0x003E60FC File Offset: 0x003E42FC
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

		// Token: 0x04009CAA RID: 40106
		private UnknownFieldSet _unknownFields;
	}
}
