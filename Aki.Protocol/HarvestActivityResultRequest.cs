using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000749 RID: 1865
	[NetMessage(EMessageId.HarvestActivityResultRequest)]
	public sealed class HarvestActivityResultRequest : IMessage<HarvestActivityResultRequest>, IMessage, IEquatable<HarvestActivityResultRequest>, IDeepCloneable<HarvestActivityResultRequest>, IBufferMessage
	{
		// Token: 0x0600A8E6 RID: 43238 RVA: 0x00196419 File Offset: 0x00194619
		[NullableContext(1)]
		public static HarvestActivityResultRequest Create()
		{
			return new HarvestActivityResultRequest();
		}

		// Token: 0x170021F7 RID: 8695
		// (get) Token: 0x0600A8E7 RID: 43239 RVA: 0x00196420 File Offset: 0x00194620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021F8 RID: 8696
		// (get) Token: 0x0600A8E8 RID: 43240 RVA: 0x00196423 File Offset: 0x00194623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestActivityResultRequest.Descriptor;
			}
		}

		// Token: 0x0600A8E9 RID: 43241 RVA: 0x0019642A File Offset: 0x0019462A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityResultRequest()
		{
		}

		// Token: 0x0600A8EA RID: 43242 RVA: 0x00196432 File Offset: 0x00194632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityResultRequest(HarvestActivityResultRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A8EB RID: 43243 RVA: 0x0019644B File Offset: 0x0019464B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityResultRequest Clone()
		{
			return new HarvestActivityResultRequest(this);
		}

		// Token: 0x0600A8EC RID: 43244 RVA: 0x00196453 File Offset: 0x00194653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestActivityResultRequest);
		}

		// Token: 0x0600A8ED RID: 43245 RVA: 0x00196461 File Offset: 0x00194661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestActivityResultRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A8EE RID: 43246 RVA: 0x00196480 File Offset: 0x00194680
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

		// Token: 0x0600A8EF RID: 43247 RVA: 0x001964A6 File Offset: 0x001946A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A8F0 RID: 43248 RVA: 0x001964B3 File Offset: 0x001946B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A8F1 RID: 43249 RVA: 0x001964BC File Offset: 0x001946BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A8F2 RID: 43250 RVA: 0x001964D4 File Offset: 0x001946D4
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

		// Token: 0x0600A8F3 RID: 43251 RVA: 0x001964FA File Offset: 0x001946FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HarvestActivityResultRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A8F4 RID: 43252 RVA: 0x00196517 File Offset: 0x00194717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A8F5 RID: 43253 RVA: 0x00196520 File Offset: 0x00194720
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

		// Token: 0x04004CF9 RID: 19705
		private UnknownFieldSet _unknownFields;
	}
}
