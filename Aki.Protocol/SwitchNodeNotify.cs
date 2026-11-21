using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001370 RID: 4976
	[NetMessage(EMessageId.SwitchNodeNotify)]
	public sealed class SwitchNodeNotify : IMessage<SwitchNodeNotify>, IMessage, IEquatable<SwitchNodeNotify>, IDeepCloneable<SwitchNodeNotify>, IBufferMessage
	{
		// Token: 0x0601A7FC RID: 108540 RVA: 0x003DC70D File Offset: 0x003DA90D
		[NullableContext(1)]
		public static SwitchNodeNotify Create()
		{
			return new SwitchNodeNotify();
		}

		// Token: 0x170059B6 RID: 22966
		// (get) Token: 0x0601A7FD RID: 108541 RVA: 0x003DC714 File Offset: 0x003DA914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059B7 RID: 22967
		// (get) Token: 0x0601A7FE RID: 108542 RVA: 0x003DC717 File Offset: 0x003DA917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchNodeNotify.Descriptor;
			}
		}

		// Token: 0x0601A7FF RID: 108543 RVA: 0x003DC71E File Offset: 0x003DA91E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchNodeNotify()
		{
		}

		// Token: 0x0601A800 RID: 108544 RVA: 0x003DC726 File Offset: 0x003DA926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchNodeNotify(SwitchNodeNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A801 RID: 108545 RVA: 0x003DC73F File Offset: 0x003DA93F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchNodeNotify Clone()
		{
			return new SwitchNodeNotify(this);
		}

		// Token: 0x0601A802 RID: 108546 RVA: 0x003DC747 File Offset: 0x003DA947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchNodeNotify);
		}

		// Token: 0x0601A803 RID: 108547 RVA: 0x003DC755 File Offset: 0x003DA955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchNodeNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601A804 RID: 108548 RVA: 0x003DC774 File Offset: 0x003DA974
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

		// Token: 0x0601A805 RID: 108549 RVA: 0x003DC79A File Offset: 0x003DA99A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A806 RID: 108550 RVA: 0x003DC7A7 File Offset: 0x003DA9A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A807 RID: 108551 RVA: 0x003DC7B0 File Offset: 0x003DA9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A808 RID: 108552 RVA: 0x003DC7C8 File Offset: 0x003DA9C8
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

		// Token: 0x0601A809 RID: 108553 RVA: 0x003DC7EE File Offset: 0x003DA9EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchNodeNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A80A RID: 108554 RVA: 0x003DC80B File Offset: 0x003DAA0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A80B RID: 108555 RVA: 0x003DC814 File Offset: 0x003DAA14
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

		// Token: 0x04009B64 RID: 39780
		private UnknownFieldSet _unknownFields;
	}
}
