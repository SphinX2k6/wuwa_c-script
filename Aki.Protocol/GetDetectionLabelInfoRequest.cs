using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006AF RID: 1711
	[NetMessage(EMessageId.GetDetectionLabelInfoRequest)]
	public sealed class GetDetectionLabelInfoRequest : IMessage<GetDetectionLabelInfoRequest>, IMessage, IEquatable<GetDetectionLabelInfoRequest>, IDeepCloneable<GetDetectionLabelInfoRequest>, IBufferMessage
	{
		// Token: 0x06009D15 RID: 40213 RVA: 0x0017DDDC File Offset: 0x0017BFDC
		[NullableContext(1)]
		public static GetDetectionLabelInfoRequest Create()
		{
			return new GetDetectionLabelInfoRequest();
		}

		// Token: 0x17001F8C RID: 8076
		// (get) Token: 0x06009D16 RID: 40214 RVA: 0x0017DDE3 File Offset: 0x0017BFE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F8D RID: 8077
		// (get) Token: 0x06009D17 RID: 40215 RVA: 0x0017DDE6 File Offset: 0x0017BFE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetDetectionLabelInfoRequest.Descriptor;
			}
		}

		// Token: 0x06009D18 RID: 40216 RVA: 0x0017DDED File Offset: 0x0017BFED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDetectionLabelInfoRequest()
		{
		}

		// Token: 0x06009D19 RID: 40217 RVA: 0x0017DDF5 File Offset: 0x0017BFF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDetectionLabelInfoRequest(GetDetectionLabelInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D1A RID: 40218 RVA: 0x0017DE0E File Offset: 0x0017C00E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDetectionLabelInfoRequest Clone()
		{
			return new GetDetectionLabelInfoRequest(this);
		}

		// Token: 0x06009D1B RID: 40219 RVA: 0x0017DE16 File Offset: 0x0017C016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetDetectionLabelInfoRequest);
		}

		// Token: 0x06009D1C RID: 40220 RVA: 0x0017DE24 File Offset: 0x0017C024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetDetectionLabelInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009D1D RID: 40221 RVA: 0x0017DE44 File Offset: 0x0017C044
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

		// Token: 0x06009D1E RID: 40222 RVA: 0x0017DE6A File Offset: 0x0017C06A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009D1F RID: 40223 RVA: 0x0017DE77 File Offset: 0x0017C077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D20 RID: 40224 RVA: 0x0017DE80 File Offset: 0x0017C080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D21 RID: 40225 RVA: 0x0017DE98 File Offset: 0x0017C098
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

		// Token: 0x06009D22 RID: 40226 RVA: 0x0017DEBE File Offset: 0x0017C0BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetDetectionLabelInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009D23 RID: 40227 RVA: 0x0017DEDB File Offset: 0x0017C0DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D24 RID: 40228 RVA: 0x0017DEE4 File Offset: 0x0017C0E4
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

		// Token: 0x04004A2A RID: 18986
		private UnknownFieldSet _unknownFields;
	}
}
