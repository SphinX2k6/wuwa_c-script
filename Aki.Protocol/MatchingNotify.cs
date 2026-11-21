using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009AA RID: 2474
	[NetMessage(EMessageId.MatchingNotify)]
	public sealed class MatchingNotify : IMessage<MatchingNotify>, IMessage, IEquatable<MatchingNotify>, IDeepCloneable<MatchingNotify>, IBufferMessage
	{
		// Token: 0x0600D967 RID: 55655 RVA: 0x001FF075 File Offset: 0x001FD275
		[NullableContext(1)]
		public static MatchingNotify Create()
		{
			return new MatchingNotify();
		}

		// Token: 0x17002C00 RID: 11264
		// (get) Token: 0x0600D968 RID: 55656 RVA: 0x001FF07C File Offset: 0x001FD27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C01 RID: 11265
		// (get) Token: 0x0600D969 RID: 55657 RVA: 0x001FF07F File Offset: 0x001FD27F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchingNotify.Descriptor;
			}
		}

		// Token: 0x0600D96A RID: 55658 RVA: 0x001FF086 File Offset: 0x001FD286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchingNotify()
		{
		}

		// Token: 0x0600D96B RID: 55659 RVA: 0x001FF08E File Offset: 0x001FD28E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchingNotify(MatchingNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D96C RID: 55660 RVA: 0x001FF0A7 File Offset: 0x001FD2A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchingNotify Clone()
		{
			return new MatchingNotify(this);
		}

		// Token: 0x0600D96D RID: 55661 RVA: 0x001FF0AF File Offset: 0x001FD2AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchingNotify);
		}

		// Token: 0x0600D96E RID: 55662 RVA: 0x001FF0BD File Offset: 0x001FD2BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchingNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D96F RID: 55663 RVA: 0x001FF0DC File Offset: 0x001FD2DC
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

		// Token: 0x0600D970 RID: 55664 RVA: 0x001FF102 File Offset: 0x001FD302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D971 RID: 55665 RVA: 0x001FF10F File Offset: 0x001FD30F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D972 RID: 55666 RVA: 0x001FF118 File Offset: 0x001FD318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D973 RID: 55667 RVA: 0x001FF130 File Offset: 0x001FD330
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

		// Token: 0x0600D974 RID: 55668 RVA: 0x001FF156 File Offset: 0x001FD356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchingNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D975 RID: 55669 RVA: 0x001FF173 File Offset: 0x001FD373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D976 RID: 55670 RVA: 0x001FF17C File Offset: 0x001FD37C
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

		// Token: 0x04005ABE RID: 23230
		private UnknownFieldSet _unknownFields;
	}
}
