using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006B3 RID: 1715
	[NetMessage(EMessageId.GetFormationDataRequest)]
	public sealed class GetFormationDataRequest : IMessage<GetFormationDataRequest>, IMessage, IEquatable<GetFormationDataRequest>, IDeepCloneable<GetFormationDataRequest>, IBufferMessage
	{
		// Token: 0x06009D63 RID: 40291 RVA: 0x0017E7E4 File Offset: 0x0017C9E4
		[NullableContext(1)]
		public static GetFormationDataRequest Create()
		{
			return new GetFormationDataRequest();
		}

		// Token: 0x17001F9B RID: 8091
		// (get) Token: 0x06009D64 RID: 40292 RVA: 0x0017E7EB File Offset: 0x0017C9EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F9C RID: 8092
		// (get) Token: 0x06009D65 RID: 40293 RVA: 0x0017E7EE File Offset: 0x0017C9EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFormationDataRequest.Descriptor;
			}
		}

		// Token: 0x06009D66 RID: 40294 RVA: 0x0017E7F5 File Offset: 0x0017C9F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFormationDataRequest()
		{
		}

		// Token: 0x06009D67 RID: 40295 RVA: 0x0017E7FD File Offset: 0x0017C9FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFormationDataRequest(GetFormationDataRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D68 RID: 40296 RVA: 0x0017E816 File Offset: 0x0017CA16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFormationDataRequest Clone()
		{
			return new GetFormationDataRequest(this);
		}

		// Token: 0x06009D69 RID: 40297 RVA: 0x0017E81E File Offset: 0x0017CA1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFormationDataRequest);
		}

		// Token: 0x06009D6A RID: 40298 RVA: 0x0017E82C File Offset: 0x0017CA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFormationDataRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009D6B RID: 40299 RVA: 0x0017E84C File Offset: 0x0017CA4C
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

		// Token: 0x06009D6C RID: 40300 RVA: 0x0017E872 File Offset: 0x0017CA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009D6D RID: 40301 RVA: 0x0017E87F File Offset: 0x0017CA7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D6E RID: 40302 RVA: 0x0017E888 File Offset: 0x0017CA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D6F RID: 40303 RVA: 0x0017E8A0 File Offset: 0x0017CAA0
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

		// Token: 0x06009D70 RID: 40304 RVA: 0x0017E8C6 File Offset: 0x0017CAC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFormationDataRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009D71 RID: 40305 RVA: 0x0017E8E3 File Offset: 0x0017CAE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D72 RID: 40306 RVA: 0x0017E8EC File Offset: 0x0017CAEC
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

		// Token: 0x04004A3D RID: 19005
		private UnknownFieldSet _unknownFields;
	}
}
