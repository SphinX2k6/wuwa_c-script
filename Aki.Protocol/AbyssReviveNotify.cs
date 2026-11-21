using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200003D RID: 61
	[NetMessage(EMessageId.AbyssReviveNotify)]
	public sealed class AbyssReviveNotify : IMessage<AbyssReviveNotify>, IMessage, IEquatable<AbyssReviveNotify>, IDeepCloneable<AbyssReviveNotify>, IBufferMessage
	{
		// Token: 0x0600137D RID: 4989 RVA: 0x00034D95 File Offset: 0x00032F95
		[NullableContext(1)]
		public static AbyssReviveNotify Create()
		{
			return new AbyssReviveNotify();
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600137E RID: 4990 RVA: 0x00034D9C File Offset: 0x00032F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600137F RID: 4991 RVA: 0x00034D9F File Offset: 0x00032F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssReviveNotify.Descriptor;
			}
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x00034DA6 File Offset: 0x00032FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssReviveNotify()
		{
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x00034DAE File Offset: 0x00032FAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssReviveNotify(AbyssReviveNotify other) : this()
		{
			this.maxReviveTimes_ = other.maxReviveTimes_;
			this.curReviveTimes_ = other.curReviveTimes_;
			this.curRevieTimes_ = other.curRevieTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x00034DEB File Offset: 0x00032FEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssReviveNotify Clone()
		{
			return new AbyssReviveNotify(this);
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x00034DF3 File Offset: 0x00032FF3
		// (set) Token: 0x06001384 RID: 4996 RVA: 0x00034DFB File Offset: 0x00032FFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxReviveTimes
		{
			get
			{
				return this.maxReviveTimes_;
			}
			set
			{
				this.maxReviveTimes_ = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x00034E04 File Offset: 0x00033004
		// (set) Token: 0x06001386 RID: 4998 RVA: 0x00034E0C File Offset: 0x0003300C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurReviveTimes
		{
			get
			{
				return this.curReviveTimes_;
			}
			set
			{
				this.curReviveTimes_ = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x00034E15 File Offset: 0x00033015
		// (set) Token: 0x06001388 RID: 5000 RVA: 0x00034E1D File Offset: 0x0003301D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurRevieTimes
		{
			get
			{
				return this.curRevieTimes_;
			}
			set
			{
				this.curRevieTimes_ = value;
			}
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x00034E26 File Offset: 0x00033026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssReviveNotify);
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x00034E34 File Offset: 0x00033034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssReviveNotify other)
		{
			return other != null && (other == this || (this.MaxReviveTimes == other.MaxReviveTimes && this.CurReviveTimes == other.CurReviveTimes && this.CurRevieTimes == other.CurRevieTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x00034E90 File Offset: 0x00033090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MaxReviveTimes != 0)
			{
				num ^= this.MaxReviveTimes.GetHashCode();
			}
			if (this.CurReviveTimes != 0)
			{
				num ^= this.CurReviveTimes.GetHashCode();
			}
			if (this.CurRevieTimes != 0)
			{
				num ^= this.CurRevieTimes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x00034F01 File Offset: 0x00033101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x00034F0E File Offset: 0x0003310E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x00034F18 File Offset: 0x00033118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxReviveTimes != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MaxReviveTimes);
			}
			if (this.CurRevieTimes != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurRevieTimes);
			}
			if (this.CurReviveTimes != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.CurReviveTimes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x00034F8C File Offset: 0x0003318C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MaxReviveTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxReviveTimes);
			}
			if (this.CurReviveTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurReviveTimes);
			}
			if (this.CurRevieTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurRevieTimes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x00034FFC File Offset: 0x000331FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssReviveNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MaxReviveTimes != 0)
			{
				this.MaxReviveTimes = other.MaxReviveTimes;
			}
			if (other.CurReviveTimes != 0)
			{
				this.CurReviveTimes = other.CurReviveTimes;
			}
			if (other.CurRevieTimes != 0)
			{
				this.CurRevieTimes = other.CurRevieTimes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x00035060 File Offset: 0x00033260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x0003506C File Offset: 0x0003326C
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
					if (num != 16U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CurReviveTimes = input.ReadInt32();
						}
					}
					else
					{
						this.CurRevieTimes = input.ReadInt32();
					}
				}
				else
				{
					this.MaxReviveTimes = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400205D RID: 8285
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400205E RID: 8286
		public const int MaxReviveTimesFieldNumber = 1;

		// Token: 0x0400205F RID: 8287
		private int maxReviveTimes_;

		// Token: 0x04002060 RID: 8288
		public const int CurReviveTimesFieldNumber = 14;

		// Token: 0x04002061 RID: 8289
		private int curReviveTimes_;

		// Token: 0x04002062 RID: 8290
		public const int CurRevieTimesFieldNumber = 2;

		// Token: 0x04002063 RID: 8291
		private int curRevieTimes_;
	}
}
