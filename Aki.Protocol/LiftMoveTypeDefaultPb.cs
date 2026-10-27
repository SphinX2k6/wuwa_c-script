using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200091C RID: 2332
	public sealed class LiftMoveTypeDefaultPb : IMessage<LiftMoveTypeDefaultPb>, IMessage, IEquatable<LiftMoveTypeDefaultPb>, IDeepCloneable<LiftMoveTypeDefaultPb>, IBufferMessage
	{
		// Token: 0x0600CDBE RID: 52670 RVA: 0x001E4E58 File Offset: 0x001E3058
		[NullableContext(1)]
		public static LiftMoveTypeDefaultPb Create()
		{
			return new LiftMoveTypeDefaultPb();
		}

		// Token: 0x1700298C RID: 10636
		// (get) Token: 0x0600CDBF RID: 52671 RVA: 0x001E4E5F File Offset: 0x001E305F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700298D RID: 10637
		// (get) Token: 0x0600CDC0 RID: 52672 RVA: 0x001E4E62 File Offset: 0x001E3062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LiftMoveTypeDefaultPb.Descriptor;
			}
		}

		// Token: 0x0600CDC1 RID: 52673 RVA: 0x001E4E69 File Offset: 0x001E3069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypeDefaultPb()
		{
		}

		// Token: 0x0600CDC2 RID: 52674 RVA: 0x001E4E71 File Offset: 0x001E3071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypeDefaultPb(LiftMoveTypeDefaultPb other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CDC3 RID: 52675 RVA: 0x001E4E8A File Offset: 0x001E308A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypeDefaultPb Clone()
		{
			return new LiftMoveTypeDefaultPb(this);
		}

		// Token: 0x0600CDC4 RID: 52676 RVA: 0x001E4E92 File Offset: 0x001E3092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LiftMoveTypeDefaultPb);
		}

		// Token: 0x0600CDC5 RID: 52677 RVA: 0x001E4EA0 File Offset: 0x001E30A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LiftMoveTypeDefaultPb other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600CDC6 RID: 52678 RVA: 0x001E4EC0 File Offset: 0x001E30C0
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

		// Token: 0x0600CDC7 RID: 52679 RVA: 0x001E4EE6 File Offset: 0x001E30E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CDC8 RID: 52680 RVA: 0x001E4EF3 File Offset: 0x001E30F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CDC9 RID: 52681 RVA: 0x001E4EFC File Offset: 0x001E30FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CDCA RID: 52682 RVA: 0x001E4F14 File Offset: 0x001E3114
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

		// Token: 0x0600CDCB RID: 52683 RVA: 0x001E4F3A File Offset: 0x001E313A
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

		// Token: 0x0600CDCC RID: 52684 RVA: 0x001E4F57 File Offset: 0x001E3157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CDCD RID: 52685 RVA: 0x001E4F60 File Offset: 0x001E3160
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

		// Token: 0x04005707 RID: 22279
		private UnknownFieldSet _unknownFields;
	}
}
