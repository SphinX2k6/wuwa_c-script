using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001333 RID: 4915
	[NetMessage(EMessageId.TeleportDataRequest)]
	public sealed class TeleportDataRequest : IMessage<TeleportDataRequest>, IMessage, IEquatable<TeleportDataRequest>, IDeepCloneable<TeleportDataRequest>, IBufferMessage
	{
		// Token: 0x0601A1CD RID: 106957 RVA: 0x003CAEBC File Offset: 0x003C90BC
		[NullableContext(1)]
		public static TeleportDataRequest Create()
		{
			return new TeleportDataRequest();
		}

		// Token: 0x17005810 RID: 22544
		// (get) Token: 0x0601A1CE RID: 106958 RVA: 0x003CAEC3 File Offset: 0x003C90C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005811 RID: 22545
		// (get) Token: 0x0601A1CF RID: 106959 RVA: 0x003CAEC6 File Offset: 0x003C90C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportDataRequest.Descriptor;
			}
		}

		// Token: 0x0601A1D0 RID: 106960 RVA: 0x003CAECD File Offset: 0x003C90CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDataRequest()
		{
		}

		// Token: 0x0601A1D1 RID: 106961 RVA: 0x003CAED5 File Offset: 0x003C90D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDataRequest(TeleportDataRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A1D2 RID: 106962 RVA: 0x003CAEEE File Offset: 0x003C90EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDataRequest Clone()
		{
			return new TeleportDataRequest(this);
		}

		// Token: 0x0601A1D3 RID: 106963 RVA: 0x003CAEF6 File Offset: 0x003C90F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportDataRequest);
		}

		// Token: 0x0601A1D4 RID: 106964 RVA: 0x003CAF04 File Offset: 0x003C9104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportDataRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601A1D5 RID: 106965 RVA: 0x003CAF24 File Offset: 0x003C9124
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

		// Token: 0x0601A1D6 RID: 106966 RVA: 0x003CAF4A File Offset: 0x003C914A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A1D7 RID: 106967 RVA: 0x003CAF57 File Offset: 0x003C9157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A1D8 RID: 106968 RVA: 0x003CAF60 File Offset: 0x003C9160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A1D9 RID: 106969 RVA: 0x003CAF78 File Offset: 0x003C9178
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

		// Token: 0x0601A1DA RID: 106970 RVA: 0x003CAF9E File Offset: 0x003C919E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportDataRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A1DB RID: 106971 RVA: 0x003CAFBB File Offset: 0x003C91BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A1DC RID: 106972 RVA: 0x003CAFC4 File Offset: 0x003C91C4
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

		// Token: 0x04009868 RID: 39016
		private UnknownFieldSet _unknownFields;
	}
}
