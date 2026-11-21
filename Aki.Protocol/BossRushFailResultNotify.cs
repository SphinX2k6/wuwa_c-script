using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001DB RID: 475
	[NetMessage(EMessageId.BossRushFailResultNotify)]
	public sealed class BossRushFailResultNotify : IMessage<BossRushFailResultNotify>, IMessage, IEquatable<BossRushFailResultNotify>, IDeepCloneable<BossRushFailResultNotify>, IBufferMessage
	{
		// Token: 0x060035EA RID: 13802 RVA: 0x000879F1 File Offset: 0x00085BF1
		[NullableContext(1)]
		public static BossRushFailResultNotify Create()
		{
			return new BossRushFailResultNotify();
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x060035EB RID: 13803 RVA: 0x000879F8 File Offset: 0x00085BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x060035EC RID: 13804 RVA: 0x000879FB File Offset: 0x00085BFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushFailResultNotify.Descriptor;
			}
		}

		// Token: 0x060035ED RID: 13805 RVA: 0x00087A02 File Offset: 0x00085C02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushFailResultNotify()
		{
		}

		// Token: 0x060035EE RID: 13806 RVA: 0x00087A0A File Offset: 0x00085C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushFailResultNotify(BossRushFailResultNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060035EF RID: 13807 RVA: 0x00087A23 File Offset: 0x00085C23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushFailResultNotify Clone()
		{
			return new BossRushFailResultNotify(this);
		}

		// Token: 0x060035F0 RID: 13808 RVA: 0x00087A2B File Offset: 0x00085C2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushFailResultNotify);
		}

		// Token: 0x060035F1 RID: 13809 RVA: 0x00087A39 File Offset: 0x00085C39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushFailResultNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060035F2 RID: 13810 RVA: 0x00087A58 File Offset: 0x00085C58
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

		// Token: 0x060035F3 RID: 13811 RVA: 0x00087A7E File Offset: 0x00085C7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060035F4 RID: 13812 RVA: 0x00087A8B File Offset: 0x00085C8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060035F5 RID: 13813 RVA: 0x00087A94 File Offset: 0x00085C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060035F6 RID: 13814 RVA: 0x00087AAC File Offset: 0x00085CAC
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

		// Token: 0x060035F7 RID: 13815 RVA: 0x00087AD2 File Offset: 0x00085CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushFailResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060035F8 RID: 13816 RVA: 0x00087AEF File Offset: 0x00085CEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060035F9 RID: 13817 RVA: 0x00087AF8 File Offset: 0x00085CF8
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

		// Token: 0x04002AC2 RID: 10946
		private UnknownFieldSet _unknownFields;
	}
}
