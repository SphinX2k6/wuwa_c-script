using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000054 RID: 84
	[NetMessage(EMessageId.AccessPathConfigRequest)]
	public sealed class AccessPathConfigRequest : IMessage<AccessPathConfigRequest>, IMessage, IEquatable<AccessPathConfigRequest>, IDeepCloneable<AccessPathConfigRequest>, IBufferMessage
	{
		// Token: 0x06001558 RID: 5464 RVA: 0x00038CDE File Offset: 0x00036EDE
		[NullableContext(1)]
		public static AccessPathConfigRequest Create()
		{
			return new AccessPathConfigRequest();
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06001559 RID: 5465 RVA: 0x00038CE5 File Offset: 0x00036EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600155A RID: 5466 RVA: 0x00038CE8 File Offset: 0x00036EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccessPathConfigRequest.Descriptor;
			}
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x00038CEF File Offset: 0x00036EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPathConfigRequest()
		{
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00038CF7 File Offset: 0x00036EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPathConfigRequest(AccessPathConfigRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00038D10 File Offset: 0x00036F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPathConfigRequest Clone()
		{
			return new AccessPathConfigRequest(this);
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00038D18 File Offset: 0x00036F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccessPathConfigRequest);
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x00038D26 File Offset: 0x00036F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AccessPathConfigRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x00038D44 File Offset: 0x00036F44
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

		// Token: 0x06001561 RID: 5473 RVA: 0x00038D6A File Offset: 0x00036F6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x00038D77 File Offset: 0x00036F77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00038D80 File Offset: 0x00036F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x00038D98 File Offset: 0x00036F98
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

		// Token: 0x06001565 RID: 5477 RVA: 0x00038DBE File Offset: 0x00036FBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AccessPathConfigRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x00038DDB File Offset: 0x00036FDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x00038DE4 File Offset: 0x00036FE4
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

		// Token: 0x040020EA RID: 8426
		private UnknownFieldSet _unknownFields;
	}
}
