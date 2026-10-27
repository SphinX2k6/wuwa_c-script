using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200069A RID: 1690
	public sealed class GachaRecord : IMessage<GachaRecord>, IMessage, IEquatable<GachaRecord>, IDeepCloneable<GachaRecord>, IBufferMessage
	{
		// Token: 0x06009AC4 RID: 39620 RVA: 0x00175824 File Offset: 0x00173A24
		[NullableContext(1)]
		public static GachaRecord Create()
		{
			return new GachaRecord();
		}

		// Token: 0x17001EF7 RID: 7927
		// (get) Token: 0x06009AC5 RID: 39621 RVA: 0x0017582B File Offset: 0x00173A2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001EF8 RID: 7928
		// (get) Token: 0x06009AC6 RID: 39622 RVA: 0x0017582E File Offset: 0x00173A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaRecord.Descriptor;
			}
		}

		// Token: 0x06009AC7 RID: 39623 RVA: 0x00175835 File Offset: 0x00173A35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaRecord()
		{
		}

		// Token: 0x06009AC8 RID: 39624 RVA: 0x00175840 File Offset: 0x00173A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaRecord(GachaRecord other) : this()
		{
			this.gachaReward_ = ((other.gachaReward_ != null) ? other.gachaReward_.Clone() : null);
			this.gachaTime_ = other.gachaTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009AC9 RID: 39625 RVA: 0x0017588C File Offset: 0x00173A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaRecord Clone()
		{
			return new GachaRecord(this);
		}

		// Token: 0x17001EF9 RID: 7929
		// (get) Token: 0x06009ACA RID: 39626 RVA: 0x00175894 File Offset: 0x00173A94
		// (set) Token: 0x06009ACB RID: 39627 RVA: 0x0017589C File Offset: 0x00173A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaReward GachaReward
		{
			get
			{
				return this.gachaReward_;
			}
			set
			{
				this.gachaReward_ = value;
			}
		}

		// Token: 0x17001EFA RID: 7930
		// (get) Token: 0x06009ACC RID: 39628 RVA: 0x001758A5 File Offset: 0x00173AA5
		// (set) Token: 0x06009ACD RID: 39629 RVA: 0x001758AD File Offset: 0x00173AAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long GachaTime
		{
			get
			{
				return this.gachaTime_;
			}
			set
			{
				this.gachaTime_ = value;
			}
		}

		// Token: 0x06009ACE RID: 39630 RVA: 0x001758B6 File Offset: 0x00173AB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaRecord);
		}

		// Token: 0x06009ACF RID: 39631 RVA: 0x001758C4 File Offset: 0x00173AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaRecord other)
		{
			return other != null && (other == this || (object.Equals(this.GachaReward, other.GachaReward) && this.GachaTime == other.GachaTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009AD0 RID: 39632 RVA: 0x00175914 File Offset: 0x00173B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gachaReward_ != null)
			{
				num ^= this.GachaReward.GetHashCode();
			}
			if (this.GachaTime != 0L)
			{
				num ^= this.GachaTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009AD1 RID: 39633 RVA: 0x00175969 File Offset: 0x00173B69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009AD2 RID: 39634 RVA: 0x00175976 File Offset: 0x00173B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009AD3 RID: 39635 RVA: 0x00175980 File Offset: 0x00173B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gachaReward_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GachaReward);
			}
			if (this.GachaTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.GachaTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009AD4 RID: 39636 RVA: 0x001759DC File Offset: 0x00173BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gachaReward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GachaReward);
			}
			if (this.GachaTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.GachaTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009AD5 RID: 39637 RVA: 0x00175A34 File Offset: 0x00173C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaRecord other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gachaReward_ != null)
			{
				if (this.gachaReward_ == null)
				{
					this.GachaReward = new GachaReward();
				}
				this.GachaReward.MergeFrom(other.GachaReward);
			}
			if (other.GachaTime != 0L)
			{
				this.GachaTime = other.GachaTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009AD6 RID: 39638 RVA: 0x00175A9C File Offset: 0x00173C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009AD7 RID: 39639 RVA: 0x00175AA8 File Offset: 0x00173CA8
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GachaTime = input.ReadInt64();
					}
				}
				else
				{
					if (this.gachaReward_ == null)
					{
						this.GachaReward = new GachaReward();
					}
					input.ReadMessage(this.GachaReward);
				}
			}
		}

		// Token: 0x04004933 RID: 18739
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004934 RID: 18740
		public const int GachaRewardFieldNumber = 1;

		// Token: 0x04004935 RID: 18741
		private GachaReward gachaReward_;

		// Token: 0x04004936 RID: 18742
		public const int GachaTimeFieldNumber = 2;

		// Token: 0x04004937 RID: 18743
		private long gachaTime_;
	}
}
