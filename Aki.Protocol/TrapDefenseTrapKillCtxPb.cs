using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014CE RID: 5326
	public sealed class TrapDefenseTrapKillCtxPb : IMessage<TrapDefenseTrapKillCtxPb>, IMessage, IEquatable<TrapDefenseTrapKillCtxPb>, IDeepCloneable<TrapDefenseTrapKillCtxPb>, IBufferMessage
	{
		// Token: 0x0601C405 RID: 115717 RVA: 0x00419A0D File Offset: 0x00417C0D
		[NullableContext(1)]
		public static TrapDefenseTrapKillCtxPb Create()
		{
			return new TrapDefenseTrapKillCtxPb();
		}

		// Token: 0x17005F9E RID: 24478
		// (get) Token: 0x0601C406 RID: 115718 RVA: 0x00419A14 File Offset: 0x00417C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F9F RID: 24479
		// (get) Token: 0x0601C407 RID: 115719 RVA: 0x00419A17 File Offset: 0x00417C17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseTrapKillCtxPb.Descriptor;
			}
		}

		// Token: 0x0601C408 RID: 115720 RVA: 0x00419A1E File Offset: 0x00417C1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTrapKillCtxPb()
		{
		}

		// Token: 0x0601C409 RID: 115721 RVA: 0x00419A26 File Offset: 0x00417C26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTrapKillCtxPb(TrapDefenseTrapKillCtxPb other) : this()
		{
			this.trapId_ = other.trapId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C40A RID: 115722 RVA: 0x00419A4B File Offset: 0x00417C4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTrapKillCtxPb Clone()
		{
			return new TrapDefenseTrapKillCtxPb(this);
		}

		// Token: 0x17005FA0 RID: 24480
		// (get) Token: 0x0601C40B RID: 115723 RVA: 0x00419A53 File Offset: 0x00417C53
		// (set) Token: 0x0601C40C RID: 115724 RVA: 0x00419A5B File Offset: 0x00417C5B
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

		// Token: 0x0601C40D RID: 115725 RVA: 0x00419A64 File Offset: 0x00417C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseTrapKillCtxPb);
		}

		// Token: 0x0601C40E RID: 115726 RVA: 0x00419A72 File Offset: 0x00417C72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseTrapKillCtxPb other)
		{
			return other != null && (other == this || (this.TrapId == other.TrapId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C40F RID: 115727 RVA: 0x00419AA0 File Offset: 0x00417CA0
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

		// Token: 0x0601C410 RID: 115728 RVA: 0x00419ADF File Offset: 0x00417CDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C411 RID: 115729 RVA: 0x00419AEC File Offset: 0x00417CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C412 RID: 115730 RVA: 0x00419AF5 File Offset: 0x00417CF5
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

		// Token: 0x0601C413 RID: 115731 RVA: 0x00419B28 File Offset: 0x00417D28
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

		// Token: 0x0601C414 RID: 115732 RVA: 0x00419B66 File Offset: 0x00417D66
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

		// Token: 0x0601C415 RID: 115733 RVA: 0x00419B97 File Offset: 0x00417D97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C416 RID: 115734 RVA: 0x00419BA0 File Offset: 0x00417DA0
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

		// Token: 0x0400A350 RID: 41808
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A351 RID: 41809
		public const int TrapIdFieldNumber = 1;

		// Token: 0x0400A352 RID: 41810
		private long trapId_;
	}
}
