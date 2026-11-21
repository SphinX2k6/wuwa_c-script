using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005DB RID: 1499
	[NetMessage(EMessageId.FloroRanchWeeklyRequest)]
	public sealed class FloroRanchWeeklyRequest : IMessage<FloroRanchWeeklyRequest>, IMessage, IEquatable<FloroRanchWeeklyRequest>, IDeepCloneable<FloroRanchWeeklyRequest>, IBufferMessage
	{
		// Token: 0x06008B5A RID: 35674 RVA: 0x00152BC5 File Offset: 0x00150DC5
		[NullableContext(1)]
		public static FloroRanchWeeklyRequest Create()
		{
			return new FloroRanchWeeklyRequest();
		}

		// Token: 0x17001B97 RID: 7063
		// (get) Token: 0x06008B5B RID: 35675 RVA: 0x00152BCC File Offset: 0x00150DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B98 RID: 7064
		// (get) Token: 0x06008B5C RID: 35676 RVA: 0x00152BCF File Offset: 0x00150DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchWeeklyRequest.Descriptor;
			}
		}

		// Token: 0x06008B5D RID: 35677 RVA: 0x00152BD6 File Offset: 0x00150DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchWeeklyRequest()
		{
		}

		// Token: 0x06008B5E RID: 35678 RVA: 0x00152BDE File Offset: 0x00150DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchWeeklyRequest(FloroRanchWeeklyRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008B5F RID: 35679 RVA: 0x00152BF7 File Offset: 0x00150DF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchWeeklyRequest Clone()
		{
			return new FloroRanchWeeklyRequest(this);
		}

		// Token: 0x06008B60 RID: 35680 RVA: 0x00152BFF File Offset: 0x00150DFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchWeeklyRequest);
		}

		// Token: 0x06008B61 RID: 35681 RVA: 0x00152C0D File Offset: 0x00150E0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchWeeklyRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06008B62 RID: 35682 RVA: 0x00152C2C File Offset: 0x00150E2C
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

		// Token: 0x06008B63 RID: 35683 RVA: 0x00152C52 File Offset: 0x00150E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008B64 RID: 35684 RVA: 0x00152C5F File Offset: 0x00150E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008B65 RID: 35685 RVA: 0x00152C68 File Offset: 0x00150E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008B66 RID: 35686 RVA: 0x00152C80 File Offset: 0x00150E80
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

		// Token: 0x06008B67 RID: 35687 RVA: 0x00152CA6 File Offset: 0x00150EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchWeeklyRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008B68 RID: 35688 RVA: 0x00152CC3 File Offset: 0x00150EC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008B69 RID: 35689 RVA: 0x00152CCC File Offset: 0x00150ECC
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

		// Token: 0x040044CF RID: 17615
		private UnknownFieldSet _unknownFields;
	}
}
