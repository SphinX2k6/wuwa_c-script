using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C3B RID: 3131
	[NetMessage(EMessageId.PhantomBattleBvBFightNotify)]
	public sealed class PhantomBattleBvBFightNotify : IMessage<PhantomBattleBvBFightNotify>, IMessage, IEquatable<PhantomBattleBvBFightNotify>, IDeepCloneable<PhantomBattleBvBFightNotify>, IBufferMessage
	{
		// Token: 0x06010FAC RID: 69548 RVA: 0x0027C4FE File Offset: 0x0027A6FE
		[NullableContext(1)]
		public static PhantomBattleBvBFightNotify Create()
		{
			return new PhantomBattleBvBFightNotify();
		}

		// Token: 0x17003813 RID: 14355
		// (get) Token: 0x06010FAD RID: 69549 RVA: 0x0027C505 File Offset: 0x0027A705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003814 RID: 14356
		// (get) Token: 0x06010FAE RID: 69550 RVA: 0x0027C508 File Offset: 0x0027A708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBvBFightNotify.Descriptor;
			}
		}

		// Token: 0x06010FAF RID: 69551 RVA: 0x0027C50F File Offset: 0x0027A70F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBFightNotify()
		{
		}

		// Token: 0x06010FB0 RID: 69552 RVA: 0x0027C517 File Offset: 0x0027A717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBFightNotify(PhantomBattleBvBFightNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010FB1 RID: 69553 RVA: 0x0027C530 File Offset: 0x0027A730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBFightNotify Clone()
		{
			return new PhantomBattleBvBFightNotify(this);
		}

		// Token: 0x06010FB2 RID: 69554 RVA: 0x0027C538 File Offset: 0x0027A738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBvBFightNotify);
		}

		// Token: 0x06010FB3 RID: 69555 RVA: 0x0027C546 File Offset: 0x0027A746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBvBFightNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06010FB4 RID: 69556 RVA: 0x0027C564 File Offset: 0x0027A764
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

		// Token: 0x06010FB5 RID: 69557 RVA: 0x0027C58A File Offset: 0x0027A78A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010FB6 RID: 69558 RVA: 0x0027C597 File Offset: 0x0027A797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010FB7 RID: 69559 RVA: 0x0027C5A0 File Offset: 0x0027A7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010FB8 RID: 69560 RVA: 0x0027C5B8 File Offset: 0x0027A7B8
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

		// Token: 0x06010FB9 RID: 69561 RVA: 0x0027C5DE File Offset: 0x0027A7DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBvBFightNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010FBA RID: 69562 RVA: 0x0027C5FB File Offset: 0x0027A7FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010FBB RID: 69563 RVA: 0x0027C604 File Offset: 0x0027A804
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

		// Token: 0x04006B9F RID: 27551
		private UnknownFieldSet _unknownFields;
	}
}
