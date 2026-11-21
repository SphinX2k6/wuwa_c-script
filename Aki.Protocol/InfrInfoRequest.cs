using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007CA RID: 1994
	[NetMessage(EMessageId.InfrInfoRequest)]
	public sealed class InfrInfoRequest : IMessage<InfrInfoRequest>, IMessage, IEquatable<InfrInfoRequest>, IDeepCloneable<InfrInfoRequest>, IBufferMessage
	{
		// Token: 0x0600B380 RID: 45952 RVA: 0x001AD917 File Offset: 0x001ABB17
		[NullableContext(1)]
		public static InfrInfoRequest Create()
		{
			return new InfrInfoRequest();
		}

		// Token: 0x1700242F RID: 9263
		// (get) Token: 0x0600B381 RID: 45953 RVA: 0x001AD91E File Offset: 0x001ABB1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002430 RID: 9264
		// (get) Token: 0x0600B382 RID: 45954 RVA: 0x001AD921 File Offset: 0x001ABB21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600B383 RID: 45955 RVA: 0x001AD928 File Offset: 0x001ABB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrInfoRequest()
		{
		}

		// Token: 0x0600B384 RID: 45956 RVA: 0x001AD930 File Offset: 0x001ABB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrInfoRequest(InfrInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B385 RID: 45957 RVA: 0x001AD949 File Offset: 0x001ABB49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrInfoRequest Clone()
		{
			return new InfrInfoRequest(this);
		}

		// Token: 0x0600B386 RID: 45958 RVA: 0x001AD951 File Offset: 0x001ABB51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrInfoRequest);
		}

		// Token: 0x0600B387 RID: 45959 RVA: 0x001AD95F File Offset: 0x001ABB5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B388 RID: 45960 RVA: 0x001AD980 File Offset: 0x001ABB80
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

		// Token: 0x0600B389 RID: 45961 RVA: 0x001AD9A6 File Offset: 0x001ABBA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B38A RID: 45962 RVA: 0x001AD9B3 File Offset: 0x001ABBB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B38B RID: 45963 RVA: 0x001AD9BC File Offset: 0x001ABBBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B38C RID: 45964 RVA: 0x001AD9D4 File Offset: 0x001ABBD4
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

		// Token: 0x0600B38D RID: 45965 RVA: 0x001AD9FA File Offset: 0x001ABBFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B38E RID: 45966 RVA: 0x001ADA17 File Offset: 0x001ABC17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B38F RID: 45967 RVA: 0x001ADA20 File Offset: 0x001ABC20
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

		// Token: 0x0400505C RID: 20572
		private UnknownFieldSet _unknownFields;
	}
}
