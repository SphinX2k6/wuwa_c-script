using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001424 RID: 5156
	public sealed class TrapDefenseEnvironmentalKillCtxPb : IMessage<TrapDefenseEnvironmentalKillCtxPb>, IMessage, IEquatable<TrapDefenseEnvironmentalKillCtxPb>, IDeepCloneable<TrapDefenseEnvironmentalKillCtxPb>, IBufferMessage
	{
		// Token: 0x0601B533 RID: 111923 RVA: 0x003F5817 File Offset: 0x003F3A17
		[NullableContext(1)]
		public static TrapDefenseEnvironmentalKillCtxPb Create()
		{
			return new TrapDefenseEnvironmentalKillCtxPb();
		}

		// Token: 0x17005C2A RID: 23594
		// (get) Token: 0x0601B534 RID: 111924 RVA: 0x003F581E File Offset: 0x003F3A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C2B RID: 23595
		// (get) Token: 0x0601B535 RID: 111925 RVA: 0x003F5821 File Offset: 0x003F3A21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseEnvironmentalKillCtxPb.Descriptor;
			}
		}

		// Token: 0x0601B536 RID: 111926 RVA: 0x003F5828 File Offset: 0x003F3A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseEnvironmentalKillCtxPb()
		{
		}

		// Token: 0x0601B537 RID: 111927 RVA: 0x003F5830 File Offset: 0x003F3A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseEnvironmentalKillCtxPb(TrapDefenseEnvironmentalKillCtxPb other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.trapId_ = other.trapId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B538 RID: 111928 RVA: 0x003F5861 File Offset: 0x003F3A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseEnvironmentalKillCtxPb Clone()
		{
			return new TrapDefenseEnvironmentalKillCtxPb(this);
		}

		// Token: 0x17005C2C RID: 23596
		// (get) Token: 0x0601B539 RID: 111929 RVA: 0x003F5869 File Offset: 0x003F3A69
		// (set) Token: 0x0601B53A RID: 111930 RVA: 0x003F5881 File Offset: 0x003F3A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TrapId
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.trapId_;
				}
				return TrapDefenseEnvironmentalKillCtxPb.TrapIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.trapId_ = value;
			}
		}

		// Token: 0x17005C2D RID: 23597
		// (get) Token: 0x0601B53B RID: 111931 RVA: 0x003F5898 File Offset: 0x003F3A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTrapId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0601B53C RID: 111932 RVA: 0x003F58A5 File Offset: 0x003F3AA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTrapId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0601B53D RID: 111933 RVA: 0x003F58B6 File Offset: 0x003F3AB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseEnvironmentalKillCtxPb);
		}

		// Token: 0x0601B53E RID: 111934 RVA: 0x003F58C4 File Offset: 0x003F3AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseEnvironmentalKillCtxPb other)
		{
			return other != null && (other == this || (this.TrapId == other.TrapId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B53F RID: 111935 RVA: 0x003F58F4 File Offset: 0x003F3AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HasTrapId)
			{
				num ^= this.TrapId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B540 RID: 111936 RVA: 0x003F5933 File Offset: 0x003F3B33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B541 RID: 111937 RVA: 0x003F5940 File Offset: 0x003F3B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B542 RID: 111938 RVA: 0x003F5949 File Offset: 0x003F3B49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasTrapId)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.TrapId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B543 RID: 111939 RVA: 0x003F597C File Offset: 0x003F3B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HasTrapId)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TrapId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B544 RID: 111940 RVA: 0x003F59BA File Offset: 0x003F3BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseEnvironmentalKillCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HasTrapId)
			{
				this.TrapId = other.TrapId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B545 RID: 111941 RVA: 0x003F59EB File Offset: 0x003F3BEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B546 RID: 111942 RVA: 0x003F59F4 File Offset: 0x003F3BF4
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

		// Token: 0x04009DE5 RID: 40421
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DE6 RID: 40422
		private int _hasBits0;

		// Token: 0x04009DE7 RID: 40423
		public const int TrapIdFieldNumber = 1;

		// Token: 0x04009DE8 RID: 40424
		private static readonly long TrapIdDefaultValue;

		// Token: 0x04009DE9 RID: 40425
		private long trapId_;
	}
}
