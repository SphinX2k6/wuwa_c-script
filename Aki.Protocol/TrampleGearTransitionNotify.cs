using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001467 RID: 5223
	[NetMessage(EMessageId.TrampleGearTransitionNotify)]
	public sealed class TrampleGearTransitionNotify : IMessage<TrampleGearTransitionNotify>, IMessage, IEquatable<TrampleGearTransitionNotify>, IDeepCloneable<TrampleGearTransitionNotify>, IBufferMessage
	{
		// Token: 0x0601BB9C RID: 113564 RVA: 0x0040682C File Offset: 0x00404A2C
		[NullableContext(1)]
		public static TrampleGearTransitionNotify Create()
		{
			return new TrampleGearTransitionNotify();
		}

		// Token: 0x17005DCA RID: 24010
		// (get) Token: 0x0601BB9D RID: 113565 RVA: 0x00406833 File Offset: 0x00404A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DCB RID: 24011
		// (get) Token: 0x0601BB9E RID: 113566 RVA: 0x00406836 File Offset: 0x00404A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrampleGearTransitionNotify.Descriptor;
			}
		}

		// Token: 0x0601BB9F RID: 113567 RVA: 0x0040683D File Offset: 0x00404A3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrampleGearTransitionNotify()
		{
		}

		// Token: 0x0601BBA0 RID: 113568 RVA: 0x00406845 File Offset: 0x00404A45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrampleGearTransitionNotify(TrampleGearTransitionNotify other) : this()
		{
			this.trampleGearEntiyId_ = other.trampleGearEntiyId_;
			this.trampleGearTransition_ = other.trampleGearTransition_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BBA1 RID: 113569 RVA: 0x00406876 File Offset: 0x00404A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrampleGearTransitionNotify Clone()
		{
			return new TrampleGearTransitionNotify(this);
		}

		// Token: 0x17005DCC RID: 24012
		// (get) Token: 0x0601BBA2 RID: 113570 RVA: 0x0040687E File Offset: 0x00404A7E
		// (set) Token: 0x0601BBA3 RID: 113571 RVA: 0x00406886 File Offset: 0x00404A86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TrampleGearEntiyId
		{
			get
			{
				return this.trampleGearEntiyId_;
			}
			set
			{
				this.trampleGearEntiyId_ = value;
			}
		}

		// Token: 0x17005DCD RID: 24013
		// (get) Token: 0x0601BBA4 RID: 113572 RVA: 0x0040688F File Offset: 0x00404A8F
		// (set) Token: 0x0601BBA5 RID: 113573 RVA: 0x00406897 File Offset: 0x00404A97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrampleGearTransition TrampleGearTransition
		{
			get
			{
				return this.trampleGearTransition_;
			}
			set
			{
				this.trampleGearTransition_ = value;
			}
		}

		// Token: 0x0601BBA6 RID: 113574 RVA: 0x004068A0 File Offset: 0x00404AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrampleGearTransitionNotify);
		}

		// Token: 0x0601BBA7 RID: 113575 RVA: 0x004068AE File Offset: 0x00404AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrampleGearTransitionNotify other)
		{
			return other != null && (other == this || (this.TrampleGearEntiyId == other.TrampleGearEntiyId && this.TrampleGearTransition == other.TrampleGearTransition && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BBA8 RID: 113576 RVA: 0x004068EC File Offset: 0x00404AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TrampleGearEntiyId != 0L)
			{
				num ^= this.TrampleGearEntiyId.GetHashCode();
			}
			if (this.TrampleGearTransition != TrampleGearTransition.Up)
			{
				num ^= this.TrampleGearTransition.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BBA9 RID: 113577 RVA: 0x0040694A File Offset: 0x00404B4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BBAA RID: 113578 RVA: 0x00406957 File Offset: 0x00404B57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BBAB RID: 113579 RVA: 0x00406960 File Offset: 0x00404B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TrampleGearTransition != TrampleGearTransition.Up)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.TrampleGearTransition);
			}
			if (this.TrampleGearEntiyId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.TrampleGearEntiyId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BBAC RID: 113580 RVA: 0x004069BC File Offset: 0x00404BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TrampleGearEntiyId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TrampleGearEntiyId);
			}
			if (this.TrampleGearTransition != TrampleGearTransition.Up)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.TrampleGearTransition);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BBAD RID: 113581 RVA: 0x00406A14 File Offset: 0x00404C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrampleGearTransitionNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TrampleGearEntiyId != 0L)
			{
				this.TrampleGearEntiyId = other.TrampleGearEntiyId;
			}
			if (other.TrampleGearTransition != TrampleGearTransition.Up)
			{
				this.TrampleGearTransition = other.TrampleGearTransition;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BBAE RID: 113582 RVA: 0x00406A64 File Offset: 0x00404C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BBAF RID: 113583 RVA: 0x00406A70 File Offset: 0x00404C70
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
				if (num != 24U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TrampleGearEntiyId = input.ReadInt64();
					}
				}
				else
				{
					this.TrampleGearTransition = (TrampleGearTransition)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A0DE RID: 41182
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0DF RID: 41183
		public const int TrampleGearEntiyIdFieldNumber = 14;

		// Token: 0x0400A0E0 RID: 41184
		private long trampleGearEntiyId_;

		// Token: 0x0400A0E1 RID: 41185
		public const int TrampleGearTransitionFieldNumber = 3;

		// Token: 0x0400A0E2 RID: 41186
		private TrampleGearTransition trampleGearTransition_;
	}
}
