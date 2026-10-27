using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008AA RID: 2218
	public sealed class KurotatoPrepareStepPbData : IMessage<KurotatoPrepareStepPbData>, IMessage, IEquatable<KurotatoPrepareStepPbData>, IDeepCloneable<KurotatoPrepareStepPbData>, IBufferMessage
	{
		// Token: 0x0600C4FA RID: 50426 RVA: 0x001D2D78 File Offset: 0x001D0F78
		[NullableContext(1)]
		public static KurotatoPrepareStepPbData Create()
		{
			return new KurotatoPrepareStepPbData();
		}

		// Token: 0x170027D2 RID: 10194
		// (get) Token: 0x0600C4FB RID: 50427 RVA: 0x001D2D7F File Offset: 0x001D0F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027D3 RID: 10195
		// (get) Token: 0x0600C4FC RID: 50428 RVA: 0x001D2D82 File Offset: 0x001D0F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoPrepareStepPbData.Descriptor;
			}
		}

		// Token: 0x0600C4FD RID: 50429 RVA: 0x001D2D89 File Offset: 0x001D0F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoPrepareStepPbData()
		{
		}

		// Token: 0x0600C4FE RID: 50430 RVA: 0x001D2D91 File Offset: 0x001D0F91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoPrepareStepPbData(KurotatoPrepareStepPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C4FF RID: 50431 RVA: 0x001D2DAA File Offset: 0x001D0FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoPrepareStepPbData Clone()
		{
			return new KurotatoPrepareStepPbData(this);
		}

		// Token: 0x0600C500 RID: 50432 RVA: 0x001D2DB2 File Offset: 0x001D0FB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoPrepareStepPbData);
		}

		// Token: 0x0600C501 RID: 50433 RVA: 0x001D2DC0 File Offset: 0x001D0FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoPrepareStepPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C502 RID: 50434 RVA: 0x001D2DE0 File Offset: 0x001D0FE0
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

		// Token: 0x0600C503 RID: 50435 RVA: 0x001D2E06 File Offset: 0x001D1006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C504 RID: 50436 RVA: 0x001D2E13 File Offset: 0x001D1013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C505 RID: 50437 RVA: 0x001D2E1C File Offset: 0x001D101C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C506 RID: 50438 RVA: 0x001D2E34 File Offset: 0x001D1034
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

		// Token: 0x0600C507 RID: 50439 RVA: 0x001D2E5A File Offset: 0x001D105A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoPrepareStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C508 RID: 50440 RVA: 0x001D2E77 File Offset: 0x001D1077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C509 RID: 50441 RVA: 0x001D2E80 File Offset: 0x001D1080
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

		// Token: 0x040054DC RID: 21724
		private UnknownFieldSet _unknownFields;
	}
}
