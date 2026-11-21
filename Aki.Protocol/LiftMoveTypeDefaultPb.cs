using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200090B RID: 2315
	public sealed class LiftMoveTypeDefaultPb : IMessage<LiftMoveTypeDefaultPb>, IMessage, IEquatable<LiftMoveTypeDefaultPb>, IDeepCloneable<LiftMoveTypeDefaultPb>, IBufferMessage
	{
		// Token: 0x0600CCA2 RID: 52386 RVA: 0x001E2B88 File Offset: 0x001E0D88
		[NullableContext(1)]
		public static LiftMoveTypeDefaultPb Create()
		{
			return new LiftMoveTypeDefaultPb();
		}

		// Token: 0x1700294D RID: 10573
		// (get) Token: 0x0600CCA3 RID: 52387 RVA: 0x001E2B8F File Offset: 0x001E0D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700294E RID: 10574
		// (get) Token: 0x0600CCA4 RID: 52388 RVA: 0x001E2B92 File Offset: 0x001E0D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LiftMoveTypeDefaultPb.Descriptor;
			}
		}

		// Token: 0x0600CCA5 RID: 52389 RVA: 0x001E2B99 File Offset: 0x001E0D99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypeDefaultPb()
		{
		}

		// Token: 0x0600CCA6 RID: 52390 RVA: 0x001E2BA1 File Offset: 0x001E0DA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypeDefaultPb(LiftMoveTypeDefaultPb other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CCA7 RID: 52391 RVA: 0x001E2BBA File Offset: 0x001E0DBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypeDefaultPb Clone()
		{
			return new LiftMoveTypeDefaultPb(this);
		}

		// Token: 0x0600CCA8 RID: 52392 RVA: 0x001E2BC2 File Offset: 0x001E0DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LiftMoveTypeDefaultPb);
		}

		// Token: 0x0600CCA9 RID: 52393 RVA: 0x001E2BD0 File Offset: 0x001E0DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LiftMoveTypeDefaultPb other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600CCAA RID: 52394 RVA: 0x001E2BF0 File Offset: 0x001E0DF0
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

		// Token: 0x0600CCAB RID: 52395 RVA: 0x001E2C16 File Offset: 0x001E0E16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CCAC RID: 52396 RVA: 0x001E2C23 File Offset: 0x001E0E23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CCAD RID: 52397 RVA: 0x001E2C2C File Offset: 0x001E0E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CCAE RID: 52398 RVA: 0x001E2C44 File Offset: 0x001E0E44
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

		// Token: 0x0600CCAF RID: 52399 RVA: 0x001E2C6A File Offset: 0x001E0E6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LiftMoveTypeDefaultPb other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CCB0 RID: 52400 RVA: 0x001E2C87 File Offset: 0x001E0E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CCB1 RID: 52401 RVA: 0x001E2C90 File Offset: 0x001E0E90
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

		// Token: 0x0400570E RID: 22286
		private UnknownFieldSet _unknownFields;
	}
}
