using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007C5 RID: 1989
	[NetMessage(EMessageId.InfrFireNoticeRequest)]
	public sealed class InfrFireNoticeRequest : IMessage<InfrFireNoticeRequest>, IMessage, IEquatable<InfrFireNoticeRequest>, IDeepCloneable<InfrFireNoticeRequest>, IBufferMessage
	{
		// Token: 0x0600B320 RID: 45856 RVA: 0x001ACD3F File Offset: 0x001AAF3F
		[NullableContext(1)]
		public static InfrFireNoticeRequest Create()
		{
			return new InfrFireNoticeRequest();
		}

		// Token: 0x1700241D RID: 9245
		// (get) Token: 0x0600B321 RID: 45857 RVA: 0x001ACD46 File Offset: 0x001AAF46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700241E RID: 9246
		// (get) Token: 0x0600B322 RID: 45858 RVA: 0x001ACD49 File Offset: 0x001AAF49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrFireNoticeRequest.Descriptor;
			}
		}

		// Token: 0x0600B323 RID: 45859 RVA: 0x001ACD50 File Offset: 0x001AAF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFireNoticeRequest()
		{
		}

		// Token: 0x0600B324 RID: 45860 RVA: 0x001ACD58 File Offset: 0x001AAF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFireNoticeRequest(InfrFireNoticeRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B325 RID: 45861 RVA: 0x001ACD71 File Offset: 0x001AAF71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFireNoticeRequest Clone()
		{
			return new InfrFireNoticeRequest(this);
		}

		// Token: 0x0600B326 RID: 45862 RVA: 0x001ACD79 File Offset: 0x001AAF79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrFireNoticeRequest);
		}

		// Token: 0x0600B327 RID: 45863 RVA: 0x001ACD87 File Offset: 0x001AAF87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrFireNoticeRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B328 RID: 45864 RVA: 0x001ACDA8 File Offset: 0x001AAFA8
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

		// Token: 0x0600B329 RID: 45865 RVA: 0x001ACDCE File Offset: 0x001AAFCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B32A RID: 45866 RVA: 0x001ACDDB File Offset: 0x001AAFDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B32B RID: 45867 RVA: 0x001ACDE4 File Offset: 0x001AAFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B32C RID: 45868 RVA: 0x001ACDFC File Offset: 0x001AAFFC
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

		// Token: 0x0600B32D RID: 45869 RVA: 0x001ACE22 File Offset: 0x001AB022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrFireNoticeRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B32E RID: 45870 RVA: 0x001ACE3F File Offset: 0x001AB03F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B32F RID: 45871 RVA: 0x001ACE48 File Offset: 0x001AB048
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

		// Token: 0x04005046 RID: 20550
		private UnknownFieldSet _unknownFields;
	}
}
