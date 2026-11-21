using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001497 RID: 5271
	public sealed class TrapDefenseEnvironmentalKillCtxPb : IMessage<TrapDefenseEnvironmentalKillCtxPb>, IMessage, IEquatable<TrapDefenseEnvironmentalKillCtxPb>, IDeepCloneable<TrapDefenseEnvironmentalKillCtxPb>, IBufferMessage
	{
		// Token: 0x0601BFBE RID: 114622 RVA: 0x00410AEB File Offset: 0x0040ECEB
		[NullableContext(1)]
		public static TrapDefenseEnvironmentalKillCtxPb Create()
		{
			return new TrapDefenseEnvironmentalKillCtxPb();
		}

		// Token: 0x17005EBF RID: 24255
		// (get) Token: 0x0601BFBF RID: 114623 RVA: 0x00410AF2 File Offset: 0x0040ECF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EC0 RID: 24256
		// (get) Token: 0x0601BFC0 RID: 114624 RVA: 0x00410AF5 File Offset: 0x0040ECF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseEnvironmentalKillCtxPb.Descriptor;
			}
		}

		// Token: 0x0601BFC1 RID: 114625 RVA: 0x00410AFC File Offset: 0x0040ECFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseEnvironmentalKillCtxPb()
		{
		}

		// Token: 0x0601BFC2 RID: 114626 RVA: 0x00410B04 File Offset: 0x0040ED04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseEnvironmentalKillCtxPb(TrapDefenseEnvironmentalKillCtxPb other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.trapId_ = other.trapId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BFC3 RID: 114627 RVA: 0x00410B35 File Offset: 0x0040ED35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseEnvironmentalKillCtxPb Clone()
		{
			return new TrapDefenseEnvironmentalKillCtxPb(this);
		}

		// Token: 0x17005EC1 RID: 24257
		// (get) Token: 0x0601BFC4 RID: 114628 RVA: 0x00410B3D File Offset: 0x0040ED3D
		// (set) Token: 0x0601BFC5 RID: 114629 RVA: 0x00410B55 File Offset: 0x0040ED55
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

		// Token: 0x17005EC2 RID: 24258
		// (get) Token: 0x0601BFC6 RID: 114630 RVA: 0x00410B6C File Offset: 0x0040ED6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTrapId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0601BFC7 RID: 114631 RVA: 0x00410B79 File Offset: 0x0040ED79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTrapId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0601BFC8 RID: 114632 RVA: 0x00410B8A File Offset: 0x0040ED8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseEnvironmentalKillCtxPb);
		}

		// Token: 0x0601BFC9 RID: 114633 RVA: 0x00410B98 File Offset: 0x0040ED98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseEnvironmentalKillCtxPb other)
		{
			return other != null && (other == this || (this.TrapId == other.TrapId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BFCA RID: 114634 RVA: 0x00410BC8 File Offset: 0x0040EDC8
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

		// Token: 0x0601BFCB RID: 114635 RVA: 0x00410C07 File Offset: 0x0040EE07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BFCC RID: 114636 RVA: 0x00410C14 File Offset: 0x0040EE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BFCD RID: 114637 RVA: 0x00410C1D File Offset: 0x0040EE1D
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

		// Token: 0x0601BFCE RID: 114638 RVA: 0x00410C50 File Offset: 0x0040EE50
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

		// Token: 0x0601BFCF RID: 114639 RVA: 0x00410C8E File Offset: 0x0040EE8E
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

		// Token: 0x0601BFD0 RID: 114640 RVA: 0x00410CBF File Offset: 0x0040EEBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BFD1 RID: 114641 RVA: 0x00410CC8 File Offset: 0x0040EEC8
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

		// Token: 0x0400A22C RID: 41516
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A22D RID: 41517
		private int _hasBits0;

		// Token: 0x0400A22E RID: 41518
		public const int TrapIdFieldNumber = 1;

		// Token: 0x0400A22F RID: 41519
		private static readonly long TrapIdDefaultValue;

		// Token: 0x0400A230 RID: 41520
		private long trapId_;
	}
}
