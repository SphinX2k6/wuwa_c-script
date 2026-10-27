using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x02001680 RID: 5760
	public sealed class CombatDataMaxResponse : IMessage<CombatDataMaxResponse>, IMessage, IEquatable<CombatDataMaxResponse>, IDeepCloneable<CombatDataMaxResponse>, IBufferMessage
	{
		// Token: 0x0601CB9F RID: 117663 RVA: 0x004258E6 File Offset: 0x00423AE6
		[NullableContext(1)]
		public static CombatDataMaxResponse Create()
		{
			return new CombatDataMaxResponse();
		}

		// Token: 0x170060D2 RID: 24786
		// (get) Token: 0x0601CBA0 RID: 117664 RVA: 0x004258ED File Offset: 0x00423AED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060D3 RID: 24787
		// (get) Token: 0x0601CBA1 RID: 117665 RVA: 0x004258F0 File Offset: 0x00423AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatDataMaxResponse.Descriptor;
			}
		}

		// Token: 0x0601CBA2 RID: 117666 RVA: 0x004258F7 File Offset: 0x00423AF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatDataMaxResponse()
		{
		}

		// Token: 0x0601CBA3 RID: 117667 RVA: 0x004258FF File Offset: 0x00423AFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatDataMaxResponse(CombatDataMaxResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CBA4 RID: 117668 RVA: 0x00425918 File Offset: 0x00423B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatDataMaxResponse Clone()
		{
			return new CombatDataMaxResponse(this);
		}

		// Token: 0x0601CBA5 RID: 117669 RVA: 0x00425920 File Offset: 0x00423B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatDataMaxResponse);
		}

		// Token: 0x0601CBA6 RID: 117670 RVA: 0x0042592E File Offset: 0x00423B2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatDataMaxResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601CBA7 RID: 117671 RVA: 0x0042594C File Offset: 0x00423B4C
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

		// Token: 0x0601CBA8 RID: 117672 RVA: 0x00425972 File Offset: 0x00423B72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CBA9 RID: 117673 RVA: 0x0042597F File Offset: 0x00423B7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CBAA RID: 117674 RVA: 0x00425988 File Offset: 0x00423B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CBAB RID: 117675 RVA: 0x004259A0 File Offset: 0x00423BA0
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

		// Token: 0x0601CBAC RID: 117676 RVA: 0x004259C6 File Offset: 0x00423BC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatDataMaxResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CBAD RID: 117677 RVA: 0x004259E3 File Offset: 0x00423BE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CBAE RID: 117678 RVA: 0x004259EC File Offset: 0x00423BEC
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

		// Token: 0x0400C208 RID: 49672
		private UnknownFieldSet _unknownFields;
	}
}
