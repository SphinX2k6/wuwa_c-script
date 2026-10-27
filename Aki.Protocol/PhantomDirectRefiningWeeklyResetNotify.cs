using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CCA RID: 3274
	[NetMessage(EMessageId.PhantomDirectRefiningWeeklyResetNotify)]
	public sealed class PhantomDirectRefiningWeeklyResetNotify : IMessage<PhantomDirectRefiningWeeklyResetNotify>, IMessage, IEquatable<PhantomDirectRefiningWeeklyResetNotify>, IDeepCloneable<PhantomDirectRefiningWeeklyResetNotify>, IBufferMessage
	{
		// Token: 0x06011B9F RID: 72607 RVA: 0x002983E6 File Offset: 0x002965E6
		[NullableContext(1)]
		public static PhantomDirectRefiningWeeklyResetNotify Create()
		{
			return new PhantomDirectRefiningWeeklyResetNotify();
		}

		// Token: 0x17003ABC RID: 15036
		// (get) Token: 0x06011BA0 RID: 72608 RVA: 0x002983ED File Offset: 0x002965ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003ABD RID: 15037
		// (get) Token: 0x06011BA1 RID: 72609 RVA: 0x002983F0 File Offset: 0x002965F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomDirectRefiningWeeklyResetNotify.Descriptor;
			}
		}

		// Token: 0x06011BA2 RID: 72610 RVA: 0x002983F7 File Offset: 0x002965F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomDirectRefiningWeeklyResetNotify()
		{
		}

		// Token: 0x06011BA3 RID: 72611 RVA: 0x002983FF File Offset: 0x002965FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomDirectRefiningWeeklyResetNotify(PhantomDirectRefiningWeeklyResetNotify other) : this()
		{
			this.directRefineWeekTimes_ = other.directRefineWeekTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011BA4 RID: 72612 RVA: 0x00298424 File Offset: 0x00296624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomDirectRefiningWeeklyResetNotify Clone()
		{
			return new PhantomDirectRefiningWeeklyResetNotify(this);
		}

		// Token: 0x17003ABE RID: 15038
		// (get) Token: 0x06011BA5 RID: 72613 RVA: 0x0029842C File Offset: 0x0029662C
		// (set) Token: 0x06011BA6 RID: 72614 RVA: 0x00298434 File Offset: 0x00296634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DirectRefineWeekTimes
		{
			get
			{
				return this.directRefineWeekTimes_;
			}
			set
			{
				this.directRefineWeekTimes_ = value;
			}
		}

		// Token: 0x06011BA7 RID: 72615 RVA: 0x0029843D File Offset: 0x0029663D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomDirectRefiningWeeklyResetNotify);
		}

		// Token: 0x06011BA8 RID: 72616 RVA: 0x0029844B File Offset: 0x0029664B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomDirectRefiningWeeklyResetNotify other)
		{
			return other != null && (other == this || (this.DirectRefineWeekTimes == other.DirectRefineWeekTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011BA9 RID: 72617 RVA: 0x0029847C File Offset: 0x0029667C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DirectRefineWeekTimes != 0)
			{
				num ^= this.DirectRefineWeekTimes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011BAA RID: 72618 RVA: 0x002984BB File Offset: 0x002966BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011BAB RID: 72619 RVA: 0x002984C8 File Offset: 0x002966C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011BAC RID: 72620 RVA: 0x002984D1 File Offset: 0x002966D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DirectRefineWeekTimes != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DirectRefineWeekTimes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011BAD RID: 72621 RVA: 0x00298504 File Offset: 0x00296704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DirectRefineWeekTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DirectRefineWeekTimes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011BAE RID: 72622 RVA: 0x00298542 File Offset: 0x00296742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomDirectRefiningWeeklyResetNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DirectRefineWeekTimes != 0)
			{
				this.DirectRefineWeekTimes = other.DirectRefineWeekTimes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011BAF RID: 72623 RVA: 0x00298573 File Offset: 0x00296773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011BB0 RID: 72624 RVA: 0x0029857C File Offset: 0x0029677C
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
					this.DirectRefineWeekTimes = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006F73 RID: 28531
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F74 RID: 28532
		public const int DirectRefineWeekTimesFieldNumber = 1;

		// Token: 0x04006F75 RID: 28533
		private int directRefineWeekTimes_;
	}
}
