using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006D3 RID: 1747
	[NetMessage(EMessageId.GetYuXueModeInfoRequest)]
	public sealed class GetYuXueModeInfoRequest : IMessage<GetYuXueModeInfoRequest>, IMessage, IEquatable<GetYuXueModeInfoRequest>, IDeepCloneable<GetYuXueModeInfoRequest>, IBufferMessage
	{
		// Token: 0x06009F9A RID: 40858 RVA: 0x00182BD8 File Offset: 0x00180DD8
		[NullableContext(1)]
		public static GetYuXueModeInfoRequest Create()
		{
			return new GetYuXueModeInfoRequest();
		}

		// Token: 0x1700200E RID: 8206
		// (get) Token: 0x06009F9B RID: 40859 RVA: 0x00182BDF File Offset: 0x00180DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700200F RID: 8207
		// (get) Token: 0x06009F9C RID: 40860 RVA: 0x00182BE2 File Offset: 0x00180DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetYuXueModeInfoRequest.Descriptor;
			}
		}

		// Token: 0x06009F9D RID: 40861 RVA: 0x00182BE9 File Offset: 0x00180DE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetYuXueModeInfoRequest()
		{
		}

		// Token: 0x06009F9E RID: 40862 RVA: 0x00182BF1 File Offset: 0x00180DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetYuXueModeInfoRequest(GetYuXueModeInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F9F RID: 40863 RVA: 0x00182C0A File Offset: 0x00180E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetYuXueModeInfoRequest Clone()
		{
			return new GetYuXueModeInfoRequest(this);
		}

		// Token: 0x06009FA0 RID: 40864 RVA: 0x00182C12 File Offset: 0x00180E12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetYuXueModeInfoRequest);
		}

		// Token: 0x06009FA1 RID: 40865 RVA: 0x00182C20 File Offset: 0x00180E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetYuXueModeInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009FA2 RID: 40866 RVA: 0x00182C40 File Offset: 0x00180E40
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

		// Token: 0x06009FA3 RID: 40867 RVA: 0x00182C66 File Offset: 0x00180E66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009FA4 RID: 40868 RVA: 0x00182C73 File Offset: 0x00180E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009FA5 RID: 40869 RVA: 0x00182C7C File Offset: 0x00180E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009FA6 RID: 40870 RVA: 0x00182C94 File Offset: 0x00180E94
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

		// Token: 0x06009FA7 RID: 40871 RVA: 0x00182CBA File Offset: 0x00180EBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetYuXueModeInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009FA8 RID: 40872 RVA: 0x00182CD7 File Offset: 0x00180ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009FA9 RID: 40873 RVA: 0x00182CE0 File Offset: 0x00180EE0
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

		// Token: 0x04004A75 RID: 19061
		private UnknownFieldSet _unknownFields;
	}
}
