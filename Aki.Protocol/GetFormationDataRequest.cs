using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006C7 RID: 1735
	[NetMessage(EMessageId.GetFormationDataRequest)]
	public sealed class GetFormationDataRequest : IMessage<GetFormationDataRequest>, IMessage, IEquatable<GetFormationDataRequest>, IDeepCloneable<GetFormationDataRequest>, IBufferMessage
	{
		// Token: 0x06009EB9 RID: 40633 RVA: 0x00181219 File Offset: 0x0017F419
		[NullableContext(1)]
		public static GetFormationDataRequest Create()
		{
			return new GetFormationDataRequest();
		}

		// Token: 0x17001FE5 RID: 8165
		// (get) Token: 0x06009EBA RID: 40634 RVA: 0x00181220 File Offset: 0x0017F420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FE6 RID: 8166
		// (get) Token: 0x06009EBB RID: 40635 RVA: 0x00181223 File Offset: 0x0017F423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFormationDataRequest.Descriptor;
			}
		}

		// Token: 0x06009EBC RID: 40636 RVA: 0x0018122A File Offset: 0x0017F42A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFormationDataRequest()
		{
		}

		// Token: 0x06009EBD RID: 40637 RVA: 0x00181232 File Offset: 0x0017F432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFormationDataRequest(GetFormationDataRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009EBE RID: 40638 RVA: 0x0018124B File Offset: 0x0017F44B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFormationDataRequest Clone()
		{
			return new GetFormationDataRequest(this);
		}

		// Token: 0x06009EBF RID: 40639 RVA: 0x00181253 File Offset: 0x0017F453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFormationDataRequest);
		}

		// Token: 0x06009EC0 RID: 40640 RVA: 0x00181261 File Offset: 0x0017F461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFormationDataRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009EC1 RID: 40641 RVA: 0x00181280 File Offset: 0x0017F480
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

		// Token: 0x06009EC2 RID: 40642 RVA: 0x001812A6 File Offset: 0x0017F4A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009EC3 RID: 40643 RVA: 0x001812B3 File Offset: 0x0017F4B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009EC4 RID: 40644 RVA: 0x001812BC File Offset: 0x0017F4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009EC5 RID: 40645 RVA: 0x001812D4 File Offset: 0x0017F4D4
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

		// Token: 0x06009EC6 RID: 40646 RVA: 0x001812FA File Offset: 0x0017F4FA
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

		// Token: 0x06009EC7 RID: 40647 RVA: 0x00181317 File Offset: 0x0017F517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009EC8 RID: 40648 RVA: 0x00181320 File Offset: 0x0017F520
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

		// Token: 0x04004A44 RID: 19012
		private UnknownFieldSet _unknownFields;
	}
}
