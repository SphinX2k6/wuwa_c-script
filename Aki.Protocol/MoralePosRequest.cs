using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A18 RID: 2584
	[NetMessage(EMessageId.MoralePosRequest)]
	public sealed class MoralePosRequest : IMessage<MoralePosRequest>, IMessage, IEquatable<MoralePosRequest>, IDeepCloneable<MoralePosRequest>, IBufferMessage
	{
		// Token: 0x0600E20A RID: 57866 RVA: 0x00211C76 File Offset: 0x0020FE76
		[NullableContext(1)]
		public static MoralePosRequest Create()
		{
			return new MoralePosRequest();
		}

		// Token: 0x17002DD9 RID: 11737
		// (get) Token: 0x0600E20B RID: 57867 RVA: 0x00211C7D File Offset: 0x0020FE7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DDA RID: 11738
		// (get) Token: 0x0600E20C RID: 57868 RVA: 0x00211C80 File Offset: 0x0020FE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoralePosRequest.Descriptor;
			}
		}

		// Token: 0x0600E20D RID: 57869 RVA: 0x00211C87 File Offset: 0x0020FE87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoralePosRequest()
		{
		}

		// Token: 0x0600E20E RID: 57870 RVA: 0x00211C8F File Offset: 0x0020FE8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoralePosRequest(MoralePosRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E20F RID: 57871 RVA: 0x00211CA8 File Offset: 0x0020FEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoralePosRequest Clone()
		{
			return new MoralePosRequest(this);
		}

		// Token: 0x0600E210 RID: 57872 RVA: 0x00211CB0 File Offset: 0x0020FEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoralePosRequest);
		}

		// Token: 0x0600E211 RID: 57873 RVA: 0x00211CBE File Offset: 0x0020FEBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoralePosRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600E212 RID: 57874 RVA: 0x00211CDC File Offset: 0x0020FEDC
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

		// Token: 0x0600E213 RID: 57875 RVA: 0x00211D02 File Offset: 0x0020FF02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E214 RID: 57876 RVA: 0x00211D0F File Offset: 0x0020FF0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E215 RID: 57877 RVA: 0x00211D18 File Offset: 0x0020FF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E216 RID: 57878 RVA: 0x00211D30 File Offset: 0x0020FF30
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

		// Token: 0x0600E217 RID: 57879 RVA: 0x00211D56 File Offset: 0x0020FF56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoralePosRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E218 RID: 57880 RVA: 0x00211D73 File Offset: 0x0020FF73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E219 RID: 57881 RVA: 0x00211D7C File Offset: 0x0020FF7C
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

		// Token: 0x04005CDE RID: 23774
		private UnknownFieldSet _unknownFields;
	}
}
