using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200145B RID: 5211
	public sealed class TrapDefenseTrapKillCtxPb : IMessage<TrapDefenseTrapKillCtxPb>, IMessage, IEquatable<TrapDefenseTrapKillCtxPb>, IDeepCloneable<TrapDefenseTrapKillCtxPb>, IBufferMessage
	{
		// Token: 0x0601B97A RID: 113018 RVA: 0x003FE738 File Offset: 0x003FC938
		[NullableContext(1)]
		public static TrapDefenseTrapKillCtxPb Create()
		{
			return new TrapDefenseTrapKillCtxPb();
		}

		// Token: 0x17005D09 RID: 23817
		// (get) Token: 0x0601B97B RID: 113019 RVA: 0x003FE73F File Offset: 0x003FC93F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D0A RID: 23818
		// (get) Token: 0x0601B97C RID: 113020 RVA: 0x003FE742 File Offset: 0x003FC942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseTrapKillCtxPb.Descriptor;
			}
		}

		// Token: 0x0601B97D RID: 113021 RVA: 0x003FE749 File Offset: 0x003FC949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTrapKillCtxPb()
		{
		}

		// Token: 0x0601B97E RID: 113022 RVA: 0x003FE751 File Offset: 0x003FC951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTrapKillCtxPb(TrapDefenseTrapKillCtxPb other) : this()
		{
			this.trapId_ = other.trapId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B97F RID: 113023 RVA: 0x003FE776 File Offset: 0x003FC976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTrapKillCtxPb Clone()
		{
			return new TrapDefenseTrapKillCtxPb(this);
		}

		// Token: 0x17005D0B RID: 23819
		// (get) Token: 0x0601B980 RID: 113024 RVA: 0x003FE77E File Offset: 0x003FC97E
		// (set) Token: 0x0601B981 RID: 113025 RVA: 0x003FE786 File Offset: 0x003FC986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TrapId
		{
			get
			{
				return this.trapId_;
			}
			set
			{
				this.trapId_ = value;
			}
		}

		// Token: 0x0601B982 RID: 113026 RVA: 0x003FE78F File Offset: 0x003FC98F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseTrapKillCtxPb);
		}

		// Token: 0x0601B983 RID: 113027 RVA: 0x003FE79D File Offset: 0x003FC99D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseTrapKillCtxPb other)
		{
			return other != null && (other == this || (this.TrapId == other.TrapId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B984 RID: 113028 RVA: 0x003FE7CC File Offset: 0x003FC9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TrapId != 0L)
			{
				num ^= this.TrapId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B985 RID: 113029 RVA: 0x003FE80B File Offset: 0x003FCA0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B986 RID: 113030 RVA: 0x003FE818 File Offset: 0x003FCA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B987 RID: 113031 RVA: 0x003FE821 File Offset: 0x003FCA21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TrapId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.TrapId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B988 RID: 113032 RVA: 0x003FE854 File Offset: 0x003FCA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TrapId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TrapId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B989 RID: 113033 RVA: 0x003FE892 File Offset: 0x003FCA92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseTrapKillCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TrapId != 0L)
			{
				this.TrapId = other.TrapId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B98A RID: 113034 RVA: 0x003FE8C3 File Offset: 0x003FCAC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B98B RID: 113035 RVA: 0x003FE8CC File Offset: 0x003FCACC
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
					this.TrapId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009F09 RID: 40713
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F0A RID: 40714
		public const int TrapIdFieldNumber = 1;

		// Token: 0x04009F0B RID: 40715
		private long trapId_;
	}
}
