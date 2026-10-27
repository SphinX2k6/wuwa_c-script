using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013F4 RID: 5108
	[NetMessage(EMessageId.TrampleGearTransitionNotify)]
	public sealed class TrampleGearTransitionNotify : IMessage<TrampleGearTransitionNotify>, IMessage, IEquatable<TrampleGearTransitionNotify>, IDeepCloneable<TrampleGearTransitionNotify>, IBufferMessage
	{
		// Token: 0x0601B111 RID: 110865 RVA: 0x003EB558 File Offset: 0x003E9758
		[NullableContext(1)]
		public static TrampleGearTransitionNotify Create()
		{
			return new TrampleGearTransitionNotify();
		}

		// Token: 0x17005B35 RID: 23349
		// (get) Token: 0x0601B112 RID: 110866 RVA: 0x003EB55F File Offset: 0x003E975F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B36 RID: 23350
		// (get) Token: 0x0601B113 RID: 110867 RVA: 0x003EB562 File Offset: 0x003E9762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrampleGearTransitionNotify.Descriptor;
			}
		}

		// Token: 0x0601B114 RID: 110868 RVA: 0x003EB569 File Offset: 0x003E9769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrampleGearTransitionNotify()
		{
		}

		// Token: 0x0601B115 RID: 110869 RVA: 0x003EB571 File Offset: 0x003E9771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrampleGearTransitionNotify(TrampleGearTransitionNotify other) : this()
		{
			this.trampleGearEntiyId_ = other.trampleGearEntiyId_;
			this.trampleGearTransition_ = other.trampleGearTransition_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B116 RID: 110870 RVA: 0x003EB5A2 File Offset: 0x003E97A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrampleGearTransitionNotify Clone()
		{
			return new TrampleGearTransitionNotify(this);
		}

		// Token: 0x17005B37 RID: 23351
		// (get) Token: 0x0601B117 RID: 110871 RVA: 0x003EB5AA File Offset: 0x003E97AA
		// (set) Token: 0x0601B118 RID: 110872 RVA: 0x003EB5B2 File Offset: 0x003E97B2
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

		// Token: 0x17005B38 RID: 23352
		// (get) Token: 0x0601B119 RID: 110873 RVA: 0x003EB5BB File Offset: 0x003E97BB
		// (set) Token: 0x0601B11A RID: 110874 RVA: 0x003EB5C3 File Offset: 0x003E97C3
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

		// Token: 0x0601B11B RID: 110875 RVA: 0x003EB5CC File Offset: 0x003E97CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrampleGearTransitionNotify);
		}

		// Token: 0x0601B11C RID: 110876 RVA: 0x003EB5DA File Offset: 0x003E97DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrampleGearTransitionNotify other)
		{
			return other != null && (other == this || (this.TrampleGearEntiyId == other.TrampleGearEntiyId && this.TrampleGearTransition == other.TrampleGearTransition && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B11D RID: 110877 RVA: 0x003EB618 File Offset: 0x003E9818
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

		// Token: 0x0601B11E RID: 110878 RVA: 0x003EB676 File Offset: 0x003E9876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B11F RID: 110879 RVA: 0x003EB683 File Offset: 0x003E9883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B120 RID: 110880 RVA: 0x003EB68C File Offset: 0x003E988C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TrampleGearEntiyId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.TrampleGearEntiyId);
			}
			if (this.TrampleGearTransition != TrampleGearTransition.Up)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.TrampleGearTransition);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B121 RID: 110881 RVA: 0x003EB6E8 File Offset: 0x003E98E8
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

		// Token: 0x0601B122 RID: 110882 RVA: 0x003EB740 File Offset: 0x003E9940
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

		// Token: 0x0601B123 RID: 110883 RVA: 0x003EB790 File Offset: 0x003E9990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B124 RID: 110884 RVA: 0x003EB79C File Offset: 0x003E999C
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
				if (num != 48U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TrampleGearTransition = (TrampleGearTransition)input.ReadEnum();
					}
				}
				else
				{
					this.TrampleGearEntiyId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009C97 RID: 40087
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C98 RID: 40088
		public const int TrampleGearEntiyIdFieldNumber = 6;

		// Token: 0x04009C99 RID: 40089
		private long trampleGearEntiyId_;

		// Token: 0x04009C9A RID: 40090
		public const int TrampleGearTransitionFieldNumber = 15;

		// Token: 0x04009C9B RID: 40091
		private TrampleGearTransition trampleGearTransition_;
	}
}
