using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x0200167F RID: 5759
	[NetMessage(EMessageId.CombatDataMaxNotify)]
	public sealed class CombatDataMaxNotify : IMessage<CombatDataMaxNotify>, IMessage, IEquatable<CombatDataMaxNotify>, IDeepCloneable<CombatDataMaxNotify>, IBufferMessage
	{
		// Token: 0x0601CB8F RID: 117647 RVA: 0x004257AD File Offset: 0x004239AD
		[NullableContext(1)]
		public static CombatDataMaxNotify Create()
		{
			return new CombatDataMaxNotify();
		}

		// Token: 0x170060D0 RID: 24784
		// (get) Token: 0x0601CB90 RID: 117648 RVA: 0x004257B4 File Offset: 0x004239B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060D1 RID: 24785
		// (get) Token: 0x0601CB91 RID: 117649 RVA: 0x004257B7 File Offset: 0x004239B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatDataMaxNotify.Descriptor;
			}
		}

		// Token: 0x0601CB92 RID: 117650 RVA: 0x004257BE File Offset: 0x004239BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatDataMaxNotify()
		{
		}

		// Token: 0x0601CB93 RID: 117651 RVA: 0x004257C6 File Offset: 0x004239C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatDataMaxNotify(CombatDataMaxNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CB94 RID: 117652 RVA: 0x004257DF File Offset: 0x004239DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatDataMaxNotify Clone()
		{
			return new CombatDataMaxNotify(this);
		}

		// Token: 0x0601CB95 RID: 117653 RVA: 0x004257E7 File Offset: 0x004239E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatDataMaxNotify);
		}

		// Token: 0x0601CB96 RID: 117654 RVA: 0x004257F5 File Offset: 0x004239F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatDataMaxNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601CB97 RID: 117655 RVA: 0x00425814 File Offset: 0x00423A14
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

		// Token: 0x0601CB98 RID: 117656 RVA: 0x0042583A File Offset: 0x00423A3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CB99 RID: 117657 RVA: 0x00425847 File Offset: 0x00423A47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CB9A RID: 117658 RVA: 0x00425850 File Offset: 0x00423A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CB9B RID: 117659 RVA: 0x00425868 File Offset: 0x00423A68
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

		// Token: 0x0601CB9C RID: 117660 RVA: 0x0042588E File Offset: 0x00423A8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatDataMaxNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CB9D RID: 117661 RVA: 0x004258AB File Offset: 0x00423AAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CB9E RID: 117662 RVA: 0x004258B4 File Offset: 0x00423AB4
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

		// Token: 0x0400C207 RID: 49671
		private UnknownFieldSet _unknownFields;
	}
}
