using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001514 RID: 5396
	[NetMessage(EMessageId.WillSwitchSceneGroupNotify)]
	public sealed class WillSwitchSceneGroupNotify : IMessage<WillSwitchSceneGroupNotify>, IMessage, IEquatable<WillSwitchSceneGroupNotify>, IDeepCloneable<WillSwitchSceneGroupNotify>, IBufferMessage
	{
		// Token: 0x0601C847 RID: 116807 RVA: 0x0041E520 File Offset: 0x0041C720
		[NullableContext(1)]
		public static WillSwitchSceneGroupNotify Create()
		{
			return new WillSwitchSceneGroupNotify();
		}

		// Token: 0x17006022 RID: 24610
		// (get) Token: 0x0601C848 RID: 116808 RVA: 0x0041E527 File Offset: 0x0041C727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006023 RID: 24611
		// (get) Token: 0x0601C849 RID: 116809 RVA: 0x0041E52A File Offset: 0x0041C72A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WillSwitchSceneGroupNotify.Descriptor;
			}
		}

		// Token: 0x0601C84A RID: 116810 RVA: 0x0041E531 File Offset: 0x0041C731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WillSwitchSceneGroupNotify()
		{
		}

		// Token: 0x0601C84B RID: 116811 RVA: 0x0041E539 File Offset: 0x0041C739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WillSwitchSceneGroupNotify(WillSwitchSceneGroupNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C84C RID: 116812 RVA: 0x0041E552 File Offset: 0x0041C752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WillSwitchSceneGroupNotify Clone()
		{
			return new WillSwitchSceneGroupNotify(this);
		}

		// Token: 0x0601C84D RID: 116813 RVA: 0x0041E55A File Offset: 0x0041C75A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WillSwitchSceneGroupNotify);
		}

		// Token: 0x0601C84E RID: 116814 RVA: 0x0041E568 File Offset: 0x0041C768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WillSwitchSceneGroupNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601C84F RID: 116815 RVA: 0x0041E588 File Offset: 0x0041C788
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

		// Token: 0x0601C850 RID: 116816 RVA: 0x0041E5AE File Offset: 0x0041C7AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C851 RID: 116817 RVA: 0x0041E5BB File Offset: 0x0041C7BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C852 RID: 116818 RVA: 0x0041E5C4 File Offset: 0x0041C7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C853 RID: 116819 RVA: 0x0041E5DC File Offset: 0x0041C7DC
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

		// Token: 0x0601C854 RID: 116820 RVA: 0x0041E602 File Offset: 0x0041C802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WillSwitchSceneGroupNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C855 RID: 116821 RVA: 0x0041E61F File Offset: 0x0041C81F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C856 RID: 116822 RVA: 0x0041E628 File Offset: 0x0041C828
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

		// Token: 0x0400A329 RID: 41769
		private UnknownFieldSet _unknownFields;
	}
}
