using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000148 RID: 328
	[NetMessage(EMessageId.BabelActivityUseReviveCountNotify)]
	public sealed class BabelActivityUseReviveCountNotify : IMessage<BabelActivityUseReviveCountNotify>, IMessage, IEquatable<BabelActivityUseReviveCountNotify>, IDeepCloneable<BabelActivityUseReviveCountNotify>, IBufferMessage
	{
		// Token: 0x06002A36 RID: 10806 RVA: 0x0006EDCD File Offset: 0x0006CFCD
		[NullableContext(1)]
		public static BabelActivityUseReviveCountNotify Create()
		{
			return new BabelActivityUseReviveCountNotify();
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06002A37 RID: 10807 RVA: 0x0006EDD4 File Offset: 0x0006CFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06002A38 RID: 10808 RVA: 0x0006EDD7 File Offset: 0x0006CFD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivityUseReviveCountNotify.Descriptor;
			}
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x0006EDDE File Offset: 0x0006CFDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityUseReviveCountNotify()
		{
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x0006EDE6 File Offset: 0x0006CFE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityUseReviveCountNotify(BabelActivityUseReviveCountNotify other) : this()
		{
			this.useReviveCount_ = other.useReviveCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x0006EE0B File Offset: 0x0006D00B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityUseReviveCountNotify Clone()
		{
			return new BabelActivityUseReviveCountNotify(this);
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06002A3C RID: 10812 RVA: 0x0006EE13 File Offset: 0x0006D013
		// (set) Token: 0x06002A3D RID: 10813 RVA: 0x0006EE1B File Offset: 0x0006D01B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UseReviveCount
		{
			get
			{
				return this.useReviveCount_;
			}
			set
			{
				this.useReviveCount_ = value;
			}
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x0006EE24 File Offset: 0x0006D024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivityUseReviveCountNotify);
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x0006EE32 File Offset: 0x0006D032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivityUseReviveCountNotify other)
		{
			return other != null && (other == this || (this.UseReviveCount == other.UseReviveCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x0006EE60 File Offset: 0x0006D060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.UseReviveCount != 0)
			{
				num ^= this.UseReviveCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x0006EE9F File Offset: 0x0006D09F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002A42 RID: 10818 RVA: 0x0006EEAC File Offset: 0x0006D0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x0006EEB5 File Offset: 0x0006D0B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UseReviveCount != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.UseReviveCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x0006EEE8 File Offset: 0x0006D0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.UseReviveCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UseReviveCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002A45 RID: 10821 RVA: 0x0006EF26 File Offset: 0x0006D126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelActivityUseReviveCountNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.UseReviveCount != 0)
			{
				this.UseReviveCount = other.UseReviveCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002A46 RID: 10822 RVA: 0x0006EF57 File Offset: 0x0006D157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x0006EF60 File Offset: 0x0006D160
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.UseReviveCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002756 RID: 10070
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002757 RID: 10071
		public const int UseReviveCountFieldNumber = 10;

		// Token: 0x04002758 RID: 10072
		private int useReviveCount_;
	}
}
