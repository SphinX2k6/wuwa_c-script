using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C9D RID: 3229
	[NetMessage(EMessageId.PhantomBattleRoundOverRequest)]
	public sealed class PhantomBattleRoundOverRequest : IMessage<PhantomBattleRoundOverRequest>, IMessage, IEquatable<PhantomBattleRoundOverRequest>, IDeepCloneable<PhantomBattleRoundOverRequest>, IBufferMessage
	{
		// Token: 0x0601184C RID: 71756 RVA: 0x0029162D File Offset: 0x0028F82D
		[NullableContext(1)]
		public static PhantomBattleRoundOverRequest Create()
		{
			return new PhantomBattleRoundOverRequest();
		}

		// Token: 0x17003A09 RID: 14857
		// (get) Token: 0x0601184D RID: 71757 RVA: 0x00291634 File Offset: 0x0028F834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A0A RID: 14858
		// (get) Token: 0x0601184E RID: 71758 RVA: 0x00291637 File Offset: 0x0028F837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleRoundOverRequest.Descriptor;
			}
		}

		// Token: 0x0601184F RID: 71759 RVA: 0x0029163E File Offset: 0x0028F83E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoundOverRequest()
		{
		}

		// Token: 0x06011850 RID: 71760 RVA: 0x00291646 File Offset: 0x0028F846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoundOverRequest(PhantomBattleRoundOverRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011851 RID: 71761 RVA: 0x0029165F File Offset: 0x0028F85F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoundOverRequest Clone()
		{
			return new PhantomBattleRoundOverRequest(this);
		}

		// Token: 0x06011852 RID: 71762 RVA: 0x00291667 File Offset: 0x0028F867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleRoundOverRequest);
		}

		// Token: 0x06011853 RID: 71763 RVA: 0x00291675 File Offset: 0x0028F875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleRoundOverRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06011854 RID: 71764 RVA: 0x00291694 File Offset: 0x0028F894
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

		// Token: 0x06011855 RID: 71765 RVA: 0x002916BA File Offset: 0x0028F8BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011856 RID: 71766 RVA: 0x002916C7 File Offset: 0x0028F8C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011857 RID: 71767 RVA: 0x002916D0 File Offset: 0x0028F8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011858 RID: 71768 RVA: 0x002916E8 File Offset: 0x0028F8E8
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

		// Token: 0x06011859 RID: 71769 RVA: 0x0029170E File Offset: 0x0028F90E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleRoundOverRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601185A RID: 71770 RVA: 0x0029172B File Offset: 0x0028F92B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601185B RID: 71771 RVA: 0x00291734 File Offset: 0x0028F934
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

		// Token: 0x04006EDD RID: 28381
		private UnknownFieldSet _unknownFields;
	}
}
