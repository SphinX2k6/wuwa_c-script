using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BC9 RID: 3017
	public sealed class PatrolComponentPb : IMessage<PatrolComponentPb>, IMessage, IEquatable<PatrolComponentPb>, IDeepCloneable<PatrolComponentPb>, IBufferMessage
	{
		// Token: 0x060105BB RID: 67003 RVA: 0x00262E2D File Offset: 0x0026102D
		[NullableContext(1)]
		public static PatrolComponentPb Create()
		{
			return new PatrolComponentPb();
		}

		// Token: 0x1700359F RID: 13727
		// (get) Token: 0x060105BC RID: 67004 RVA: 0x00262E34 File Offset: 0x00261034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035A0 RID: 13728
		// (get) Token: 0x060105BD RID: 67005 RVA: 0x00262E37 File Offset: 0x00261037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PatrolComponentPb.Descriptor;
			}
		}

		// Token: 0x060105BE RID: 67006 RVA: 0x00262E3E File Offset: 0x0026103E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PatrolComponentPb()
		{
		}

		// Token: 0x060105BF RID: 67007 RVA: 0x00262E46 File Offset: 0x00261046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PatrolComponentPb(PatrolComponentPb other) : this()
		{
			this.dir_ = other.dir_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060105C0 RID: 67008 RVA: 0x00262E6B File Offset: 0x0026106B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PatrolComponentPb Clone()
		{
			return new PatrolComponentPb(this);
		}

		// Token: 0x170035A1 RID: 13729
		// (get) Token: 0x060105C1 RID: 67009 RVA: 0x00262E73 File Offset: 0x00261073
		// (set) Token: 0x060105C2 RID: 67010 RVA: 0x00262E7B File Offset: 0x0026107B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Dir
		{
			get
			{
				return this.dir_;
			}
			set
			{
				this.dir_ = value;
			}
		}

		// Token: 0x060105C3 RID: 67011 RVA: 0x00262E84 File Offset: 0x00261084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PatrolComponentPb);
		}

		// Token: 0x060105C4 RID: 67012 RVA: 0x00262E92 File Offset: 0x00261092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PatrolComponentPb other)
		{
			return other != null && (other == this || (this.Dir == other.Dir && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060105C5 RID: 67013 RVA: 0x00262EC0 File Offset: 0x002610C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Dir)
			{
				num ^= this.Dir.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060105C6 RID: 67014 RVA: 0x00262EFF File Offset: 0x002610FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060105C7 RID: 67015 RVA: 0x00262F0C File Offset: 0x0026110C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060105C8 RID: 67016 RVA: 0x00262F15 File Offset: 0x00261115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Dir)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Dir);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060105C9 RID: 67017 RVA: 0x00262F48 File Offset: 0x00261148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Dir)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060105CA RID: 67018 RVA: 0x00262F7A File Offset: 0x0026117A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PatrolComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Dir)
			{
				this.Dir = other.Dir;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060105CB RID: 67019 RVA: 0x00262FAB File Offset: 0x002611AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060105CC RID: 67020 RVA: 0x00262FB4 File Offset: 0x002611B4
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Dir = input.ReadBool();
				}
			}
		}

		// Token: 0x04006830 RID: 26672
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006831 RID: 26673
		public const int DirFieldNumber = 1;

		// Token: 0x04006832 RID: 26674
		private bool dir_;
	}
}
