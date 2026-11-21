using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006C6 RID: 1734
	[NetMessage(EMessageId.GiantEcoUnlockNotify)]
	public sealed class GiantEcoUnlockNotify : IMessage<GiantEcoUnlockNotify>, IMessage, IEquatable<GiantEcoUnlockNotify>, IDeepCloneable<GiantEcoUnlockNotify>, IBufferMessage
	{
		// Token: 0x06009ED3 RID: 40659 RVA: 0x00181518 File Offset: 0x0017F718
		[NullableContext(1)]
		public static GiantEcoUnlockNotify Create()
		{
			return new GiantEcoUnlockNotify();
		}

		// Token: 0x17001FE2 RID: 8162
		// (get) Token: 0x06009ED4 RID: 40660 RVA: 0x0018151F File Offset: 0x0017F71F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FE3 RID: 8163
		// (get) Token: 0x06009ED5 RID: 40661 RVA: 0x00181522 File Offset: 0x0017F722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantEcoUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06009ED6 RID: 40662 RVA: 0x00181529 File Offset: 0x0017F729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantEcoUnlockNotify()
		{
		}

		// Token: 0x06009ED7 RID: 40663 RVA: 0x00181531 File Offset: 0x0017F731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantEcoUnlockNotify(GiantEcoUnlockNotify other) : this()
		{
			this.giantEcoType_ = other.giantEcoType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009ED8 RID: 40664 RVA: 0x00181556 File Offset: 0x0017F756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantEcoUnlockNotify Clone()
		{
			return new GiantEcoUnlockNotify(this);
		}

		// Token: 0x17001FE4 RID: 8164
		// (get) Token: 0x06009ED9 RID: 40665 RVA: 0x0018155E File Offset: 0x0017F75E
		// (set) Token: 0x06009EDA RID: 40666 RVA: 0x00181566 File Offset: 0x0017F766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantEcoNetType GiantEcoType
		{
			get
			{
				return this.giantEcoType_;
			}
			set
			{
				this.giantEcoType_ = value;
			}
		}

		// Token: 0x06009EDB RID: 40667 RVA: 0x0018156F File Offset: 0x0017F76F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantEcoUnlockNotify);
		}

		// Token: 0x06009EDC RID: 40668 RVA: 0x0018157D File Offset: 0x0017F77D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantEcoUnlockNotify other)
		{
			return other != null && (other == this || (this.GiantEcoType == other.GiantEcoType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009EDD RID: 40669 RVA: 0x001815AC File Offset: 0x0017F7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GiantEcoType != GiantEcoNetType.Fire)
			{
				num ^= this.GiantEcoType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009EDE RID: 40670 RVA: 0x001815F1 File Offset: 0x0017F7F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009EDF RID: 40671 RVA: 0x001815FE File Offset: 0x0017F7FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009EE0 RID: 40672 RVA: 0x00181607 File Offset: 0x0017F807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GiantEcoType != GiantEcoNetType.Fire)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.GiantEcoType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009EE1 RID: 40673 RVA: 0x0018163C File Offset: 0x0017F83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GiantEcoType != GiantEcoNetType.Fire)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.GiantEcoType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009EE2 RID: 40674 RVA: 0x0018167A File Offset: 0x0017F87A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantEcoUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GiantEcoType != GiantEcoNetType.Fire)
			{
				this.GiantEcoType = other.GiantEcoType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009EE3 RID: 40675 RVA: 0x001816AB File Offset: 0x0017F8AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009EE4 RID: 40676 RVA: 0x001816B4 File Offset: 0x0017F8B4
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GiantEcoType = (GiantEcoNetType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004A98 RID: 19096
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A99 RID: 19097
		public const int GiantEcoTypeFieldNumber = 13;

		// Token: 0x04004A9A RID: 19098
		private GiantEcoNetType giantEcoType_;
	}
}
