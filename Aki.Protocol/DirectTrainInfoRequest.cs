using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003C3 RID: 963
	[NetMessage(EMessageId.DirectTrainInfoRequest)]
	public sealed class DirectTrainInfoRequest : IMessage<DirectTrainInfoRequest>, IMessage, IEquatable<DirectTrainInfoRequest>, IDeepCloneable<DirectTrainInfoRequest>, IBufferMessage
	{
		// Token: 0x06005E7B RID: 24187 RVA: 0x000E5574 File Offset: 0x000E3774
		[NullableContext(1)]
		public static DirectTrainInfoRequest Create()
		{
			return new DirectTrainInfoRequest();
		}

		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x06005E7C RID: 24188 RVA: 0x000E557B File Offset: 0x000E377B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x06005E7D RID: 24189 RVA: 0x000E557E File Offset: 0x000E377E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DirectTrainInfoRequest.Descriptor;
			}
		}

		// Token: 0x06005E7E RID: 24190 RVA: 0x000E5585 File Offset: 0x000E3785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainInfoRequest()
		{
		}

		// Token: 0x06005E7F RID: 24191 RVA: 0x000E558D File Offset: 0x000E378D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainInfoRequest(DirectTrainInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E80 RID: 24192 RVA: 0x000E55A6 File Offset: 0x000E37A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainInfoRequest Clone()
		{
			return new DirectTrainInfoRequest(this);
		}

		// Token: 0x06005E81 RID: 24193 RVA: 0x000E55AE File Offset: 0x000E37AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DirectTrainInfoRequest);
		}

		// Token: 0x06005E82 RID: 24194 RVA: 0x000E55BC File Offset: 0x000E37BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DirectTrainInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005E83 RID: 24195 RVA: 0x000E55DC File Offset: 0x000E37DC
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

		// Token: 0x06005E84 RID: 24196 RVA: 0x000E5602 File Offset: 0x000E3802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005E85 RID: 24197 RVA: 0x000E560F File Offset: 0x000E380F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E86 RID: 24198 RVA: 0x000E5618 File Offset: 0x000E3818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005E87 RID: 24199 RVA: 0x000E5630 File Offset: 0x000E3830
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

		// Token: 0x06005E88 RID: 24200 RVA: 0x000E5656 File Offset: 0x000E3856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DirectTrainInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005E89 RID: 24201 RVA: 0x000E5673 File Offset: 0x000E3873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E8A RID: 24202 RVA: 0x000E567C File Offset: 0x000E387C
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

		// Token: 0x04003739 RID: 14137
		private UnknownFieldSet _unknownFields;
	}
}
