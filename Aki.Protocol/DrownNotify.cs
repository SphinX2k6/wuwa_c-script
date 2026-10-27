using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000415 RID: 1045
	[NetMessage(EMessageId.DrownNotify)]
	public sealed class DrownNotify : IMessage<DrownNotify>, IMessage, IEquatable<DrownNotify>, IDeepCloneable<DrownNotify>, IBufferMessage
	{
		// Token: 0x0600648A RID: 25738 RVA: 0x000F158C File Offset: 0x000EF78C
		[NullableContext(1)]
		public static DrownNotify Create()
		{
			return new DrownNotify();
		}

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x0600648B RID: 25739 RVA: 0x000F1593 File Offset: 0x000EF793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x0600648C RID: 25740 RVA: 0x000F1596 File Offset: 0x000EF796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DrownNotify.Descriptor;
			}
		}

		// Token: 0x0600648D RID: 25741 RVA: 0x000F159D File Offset: 0x000EF79D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownNotify()
		{
		}

		// Token: 0x0600648E RID: 25742 RVA: 0x000F15A5 File Offset: 0x000EF7A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownNotify(DrownNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600648F RID: 25743 RVA: 0x000F15BE File Offset: 0x000EF7BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownNotify Clone()
		{
			return new DrownNotify(this);
		}

		// Token: 0x06006490 RID: 25744 RVA: 0x000F15C6 File Offset: 0x000EF7C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DrownNotify);
		}

		// Token: 0x06006491 RID: 25745 RVA: 0x000F15D4 File Offset: 0x000EF7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DrownNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06006492 RID: 25746 RVA: 0x000F15F4 File Offset: 0x000EF7F4
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

		// Token: 0x06006493 RID: 25747 RVA: 0x000F161A File Offset: 0x000EF81A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006494 RID: 25748 RVA: 0x000F1627 File Offset: 0x000EF827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006495 RID: 25749 RVA: 0x000F1630 File Offset: 0x000EF830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006496 RID: 25750 RVA: 0x000F1648 File Offset: 0x000EF848
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

		// Token: 0x06006497 RID: 25751 RVA: 0x000F166E File Offset: 0x000EF86E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DrownNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006498 RID: 25752 RVA: 0x000F168B File Offset: 0x000EF88B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006499 RID: 25753 RVA: 0x000F1694 File Offset: 0x000EF894
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

		// Token: 0x0400386A RID: 14442
		private UnknownFieldSet _unknownFields;
	}
}
