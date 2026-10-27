using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200055C RID: 1372
	public sealed class FishingHandInData : IMessage<FishingHandInData>, IMessage, IEquatable<FishingHandInData>, IDeepCloneable<FishingHandInData>, IBufferMessage
	{
		// Token: 0x06007FF5 RID: 32757 RVA: 0x001351C1 File Offset: 0x001333C1
		[NullableContext(1)]
		public static FishingHandInData Create()
		{
			return new FishingHandInData();
		}

		// Token: 0x170018E5 RID: 6373
		// (get) Token: 0x06007FF6 RID: 32758 RVA: 0x001351C8 File Offset: 0x001333C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018E6 RID: 6374
		// (get) Token: 0x06007FF7 RID: 32759 RVA: 0x001351CB File Offset: 0x001333CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingHandInData.Descriptor;
			}
		}

		// Token: 0x06007FF8 RID: 32760 RVA: 0x001351D2 File Offset: 0x001333D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingHandInData()
		{
		}

		// Token: 0x06007FF9 RID: 32761 RVA: 0x001351DA File Offset: 0x001333DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingHandInData(FishingHandInData other) : this()
		{
			this.handInId_ = other.handInId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007FFA RID: 32762 RVA: 0x001351FF File Offset: 0x001333FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingHandInData Clone()
		{
			return new FishingHandInData(this);
		}

		// Token: 0x170018E7 RID: 6375
		// (get) Token: 0x06007FFB RID: 32763 RVA: 0x00135207 File Offset: 0x00133407
		// (set) Token: 0x06007FFC RID: 32764 RVA: 0x0013520F File Offset: 0x0013340F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandInId
		{
			get
			{
				return this.handInId_;
			}
			set
			{
				this.handInId_ = value;
			}
		}

		// Token: 0x06007FFD RID: 32765 RVA: 0x00135218 File Offset: 0x00133418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingHandInData);
		}

		// Token: 0x06007FFE RID: 32766 RVA: 0x00135226 File Offset: 0x00133426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingHandInData other)
		{
			return other != null && (other == this || (this.HandInId == other.HandInId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007FFF RID: 32767 RVA: 0x00135254 File Offset: 0x00133454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HandInId != 0)
			{
				num ^= this.HandInId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008000 RID: 32768 RVA: 0x00135293 File Offset: 0x00133493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008001 RID: 32769 RVA: 0x001352A0 File Offset: 0x001334A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008002 RID: 32770 RVA: 0x001352A9 File Offset: 0x001334A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HandInId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.HandInId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008003 RID: 32771 RVA: 0x001352DC File Offset: 0x001334DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HandInId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandInId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008004 RID: 32772 RVA: 0x0013531A File Offset: 0x0013351A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingHandInData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HandInId != 0)
			{
				this.HandInId = other.HandInId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008005 RID: 32773 RVA: 0x0013534B File Offset: 0x0013354B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008006 RID: 32774 RVA: 0x00135354 File Offset: 0x00133554
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
					this.HandInId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004079 RID: 16505
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400407A RID: 16506
		public const int HandInIdFieldNumber = 1;

		// Token: 0x0400407B RID: 16507
		private int handInId_;
	}
}
