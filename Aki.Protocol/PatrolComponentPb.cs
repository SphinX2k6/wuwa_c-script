using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BD9 RID: 3033
	public sealed class PatrolComponentPb : IMessage<PatrolComponentPb>, IMessage, IEquatable<PatrolComponentPb>, IDeepCloneable<PatrolComponentPb>, IBufferMessage
	{
		// Token: 0x060106BF RID: 67263 RVA: 0x00264CE9 File Offset: 0x00262EE9
		[NullableContext(1)]
		public static PatrolComponentPb Create()
		{
			return new PatrolComponentPb();
		}

		// Token: 0x170035D8 RID: 13784
		// (get) Token: 0x060106C0 RID: 67264 RVA: 0x00264CF0 File Offset: 0x00262EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035D9 RID: 13785
		// (get) Token: 0x060106C1 RID: 67265 RVA: 0x00264CF3 File Offset: 0x00262EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PatrolComponentPb.Descriptor;
			}
		}

		// Token: 0x060106C2 RID: 67266 RVA: 0x00264CFA File Offset: 0x00262EFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PatrolComponentPb()
		{
		}

		// Token: 0x060106C3 RID: 67267 RVA: 0x00264D02 File Offset: 0x00262F02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PatrolComponentPb(PatrolComponentPb other) : this()
		{
			this.dir_ = other.dir_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060106C4 RID: 67268 RVA: 0x00264D27 File Offset: 0x00262F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PatrolComponentPb Clone()
		{
			return new PatrolComponentPb(this);
		}

		// Token: 0x170035DA RID: 13786
		// (get) Token: 0x060106C5 RID: 67269 RVA: 0x00264D2F File Offset: 0x00262F2F
		// (set) Token: 0x060106C6 RID: 67270 RVA: 0x00264D37 File Offset: 0x00262F37
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

		// Token: 0x060106C7 RID: 67271 RVA: 0x00264D40 File Offset: 0x00262F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PatrolComponentPb);
		}

		// Token: 0x060106C8 RID: 67272 RVA: 0x00264D4E File Offset: 0x00262F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PatrolComponentPb other)
		{
			return other != null && (other == this || (this.Dir == other.Dir && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060106C9 RID: 67273 RVA: 0x00264D7C File Offset: 0x00262F7C
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

		// Token: 0x060106CA RID: 67274 RVA: 0x00264DBB File Offset: 0x00262FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060106CB RID: 67275 RVA: 0x00264DC8 File Offset: 0x00262FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060106CC RID: 67276 RVA: 0x00264DD1 File Offset: 0x00262FD1
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

		// Token: 0x060106CD RID: 67277 RVA: 0x00264E04 File Offset: 0x00263004
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

		// Token: 0x060106CE RID: 67278 RVA: 0x00264E36 File Offset: 0x00263036
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

		// Token: 0x060106CF RID: 67279 RVA: 0x00264E67 File Offset: 0x00263067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060106D0 RID: 67280 RVA: 0x00264E70 File Offset: 0x00263070
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

		// Token: 0x04006820 RID: 26656
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006821 RID: 26657
		public const int DirFieldNumber = 1;

		// Token: 0x04006822 RID: 26658
		private bool dir_;
	}
}
