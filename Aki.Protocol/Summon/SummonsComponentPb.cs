using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Summon
{
	// Token: 0x020016F7 RID: 5879
	public sealed class SummonsComponentPb : IMessage<SummonsComponentPb>, IMessage, IEquatable<SummonsComponentPb>, IDeepCloneable<SummonsComponentPb>, IBufferMessage
	{
		// Token: 0x0601D62E RID: 120366 RVA: 0x00440BA8 File Offset: 0x0043EDA8
		[NullableContext(1)]
		public static SummonsComponentPb Create()
		{
			return new SummonsComponentPb();
		}

		// Token: 0x17006369 RID: 25449
		// (get) Token: 0x0601D62F RID: 120367 RVA: 0x00440BAF File Offset: 0x0043EDAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700636A RID: 25450
		// (get) Token: 0x0601D630 RID: 120368 RVA: 0x00440BB2 File Offset: 0x0043EDB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SummonsComponentPb.Descriptor;
			}
		}

		// Token: 0x0601D631 RID: 120369 RVA: 0x00440BB9 File Offset: 0x0043EDB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonsComponentPb()
		{
		}

		// Token: 0x0601D632 RID: 120370 RVA: 0x00440BC1 File Offset: 0x0043EDC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonsComponentPb(SummonsComponentPb other) : this()
		{
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D633 RID: 120371 RVA: 0x00440BE6 File Offset: 0x0043EDE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonsComponentPb Clone()
		{
			return new SummonsComponentPb(this);
		}

		// Token: 0x1700636B RID: 25451
		// (get) Token: 0x0601D634 RID: 120372 RVA: 0x00440BEE File Offset: 0x0043EDEE
		// (set) Token: 0x0601D635 RID: 120373 RVA: 0x00440BF6 File Offset: 0x0043EDF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Version
		{
			get
			{
				return this.version_;
			}
			set
			{
				this.version_ = value;
			}
		}

		// Token: 0x0601D636 RID: 120374 RVA: 0x00440BFF File Offset: 0x0043EDFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SummonsComponentPb);
		}

		// Token: 0x0601D637 RID: 120375 RVA: 0x00440C0D File Offset: 0x0043EE0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SummonsComponentPb other)
		{
			return other != null && (other == this || (this.Version == other.Version && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D638 RID: 120376 RVA: 0x00440C3C File Offset: 0x0043EE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Version != 0)
			{
				num ^= this.Version.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D639 RID: 120377 RVA: 0x00440C7B File Offset: 0x0043EE7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D63A RID: 120378 RVA: 0x00440C88 File Offset: 0x0043EE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D63B RID: 120379 RVA: 0x00440C91 File Offset: 0x0043EE91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Version != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Version);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D63C RID: 120380 RVA: 0x00440CC4 File Offset: 0x0043EEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Version != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Version);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D63D RID: 120381 RVA: 0x00440D02 File Offset: 0x0043EF02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SummonsComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Version != 0)
			{
				this.Version = other.Version;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D63E RID: 120382 RVA: 0x00440D33 File Offset: 0x0043EF33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D63F RID: 120383 RVA: 0x00440D3C File Offset: 0x0043EF3C
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
					this.Version = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400C719 RID: 50969
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C71A RID: 50970
		public const int VersionFieldNumber = 1;

		// Token: 0x0400C71B RID: 50971
		private int version_;
	}
}
