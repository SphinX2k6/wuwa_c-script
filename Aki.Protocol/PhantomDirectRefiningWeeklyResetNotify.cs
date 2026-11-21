using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CBA RID: 3258
	[NetMessage(EMessageId.PhantomDirectRefiningWeeklyResetNotify)]
	public sealed class PhantomDirectRefiningWeeklyResetNotify : IMessage<PhantomDirectRefiningWeeklyResetNotify>, IMessage, IEquatable<PhantomDirectRefiningWeeklyResetNotify>, IDeepCloneable<PhantomDirectRefiningWeeklyResetNotify>, IBufferMessage
	{
		// Token: 0x06011A9F RID: 72351 RVA: 0x00296686 File Offset: 0x00294886
		[NullableContext(1)]
		public static PhantomDirectRefiningWeeklyResetNotify Create()
		{
			return new PhantomDirectRefiningWeeklyResetNotify();
		}

		// Token: 0x17003A85 RID: 14981
		// (get) Token: 0x06011AA0 RID: 72352 RVA: 0x0029668D File Offset: 0x0029488D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A86 RID: 14982
		// (get) Token: 0x06011AA1 RID: 72353 RVA: 0x00296690 File Offset: 0x00294890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomDirectRefiningWeeklyResetNotify.Descriptor;
			}
		}

		// Token: 0x06011AA2 RID: 72354 RVA: 0x00296697 File Offset: 0x00294897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomDirectRefiningWeeklyResetNotify()
		{
		}

		// Token: 0x06011AA3 RID: 72355 RVA: 0x0029669F File Offset: 0x0029489F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomDirectRefiningWeeklyResetNotify(PhantomDirectRefiningWeeklyResetNotify other) : this()
		{
			this.directRefineWeekTimes_ = other.directRefineWeekTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011AA4 RID: 72356 RVA: 0x002966C4 File Offset: 0x002948C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomDirectRefiningWeeklyResetNotify Clone()
		{
			return new PhantomDirectRefiningWeeklyResetNotify(this);
		}

		// Token: 0x17003A87 RID: 14983
		// (get) Token: 0x06011AA5 RID: 72357 RVA: 0x002966CC File Offset: 0x002948CC
		// (set) Token: 0x06011AA6 RID: 72358 RVA: 0x002966D4 File Offset: 0x002948D4
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

		// Token: 0x06011AA7 RID: 72359 RVA: 0x002966DD File Offset: 0x002948DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomDirectRefiningWeeklyResetNotify);
		}

		// Token: 0x06011AA8 RID: 72360 RVA: 0x002966EB File Offset: 0x002948EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomDirectRefiningWeeklyResetNotify other)
		{
			return other != null && (other == this || (this.DirectRefineWeekTimes == other.DirectRefineWeekTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011AA9 RID: 72361 RVA: 0x0029671C File Offset: 0x0029491C
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

		// Token: 0x06011AAA RID: 72362 RVA: 0x0029675B File Offset: 0x0029495B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011AAB RID: 72363 RVA: 0x00296768 File Offset: 0x00294968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011AAC RID: 72364 RVA: 0x00296771 File Offset: 0x00294971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DirectRefineWeekTimes != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.DirectRefineWeekTimes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011AAD RID: 72365 RVA: 0x002967A4 File Offset: 0x002949A4
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

		// Token: 0x06011AAE RID: 72366 RVA: 0x002967E2 File Offset: 0x002949E2
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

		// Token: 0x06011AAF RID: 72367 RVA: 0x00296813 File Offset: 0x00294A13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011AB0 RID: 72368 RVA: 0x0029681C File Offset: 0x00294A1C
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DirectRefineWeekTimes = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006F87 RID: 28551
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F88 RID: 28552
		public const int DirectRefineWeekTimesFieldNumber = 14;

		// Token: 0x04006F89 RID: 28553
		private int directRefineWeekTimes_;
	}
}
