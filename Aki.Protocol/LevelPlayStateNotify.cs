using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200090C RID: 2316
	[NetMessage(EMessageId.LevelPlayStateNotify)]
	public sealed class LevelPlayStateNotify : IMessage<LevelPlayStateNotify>, IMessage, IEquatable<LevelPlayStateNotify>, IDeepCloneable<LevelPlayStateNotify>, IBufferMessage
	{
		// Token: 0x0600CC7E RID: 52350 RVA: 0x001E2510 File Offset: 0x001E0710
		[NullableContext(1)]
		public static LevelPlayStateNotify Create()
		{
			return new LevelPlayStateNotify();
		}

		// Token: 0x1700294C RID: 10572
		// (get) Token: 0x0600CC7F RID: 52351 RVA: 0x001E2517 File Offset: 0x001E0717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700294D RID: 10573
		// (get) Token: 0x0600CC80 RID: 52352 RVA: 0x001E251A File Offset: 0x001E071A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayStateNotify.Descriptor;
			}
		}

		// Token: 0x0600CC81 RID: 52353 RVA: 0x001E2521 File Offset: 0x001E0721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateNotify()
		{
		}

		// Token: 0x0600CC82 RID: 52354 RVA: 0x001E2529 File Offset: 0x001E0729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateNotify(LevelPlayStateNotify other) : this()
		{
			this.id_ = other.id_;
			this.state_ = other.state_;
			this.completeNumber_ = other.completeNumber_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CC83 RID: 52355 RVA: 0x001E2566 File Offset: 0x001E0766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateNotify Clone()
		{
			return new LevelPlayStateNotify(this);
		}

		// Token: 0x1700294E RID: 10574
		// (get) Token: 0x0600CC84 RID: 52356 RVA: 0x001E256E File Offset: 0x001E076E
		// (set) Token: 0x0600CC85 RID: 52357 RVA: 0x001E2576 File Offset: 0x001E0776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700294F RID: 10575
		// (get) Token: 0x0600CC86 RID: 52358 RVA: 0x001E257F File Offset: 0x001E077F
		// (set) Token: 0x0600CC87 RID: 52359 RVA: 0x001E2587 File Offset: 0x001E0787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x17002950 RID: 10576
		// (get) Token: 0x0600CC88 RID: 52360 RVA: 0x001E2590 File Offset: 0x001E0790
		// (set) Token: 0x0600CC89 RID: 52361 RVA: 0x001E2598 File Offset: 0x001E0798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CompleteNumber
		{
			get
			{
				return this.completeNumber_;
			}
			set
			{
				this.completeNumber_ = value;
			}
		}

		// Token: 0x0600CC8A RID: 52362 RVA: 0x001E25A1 File Offset: 0x001E07A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayStateNotify);
		}

		// Token: 0x0600CC8B RID: 52363 RVA: 0x001E25B0 File Offset: 0x001E07B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayStateNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.State == other.State && this.CompleteNumber == other.CompleteNumber && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CC8C RID: 52364 RVA: 0x001E260C File Offset: 0x001E080C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.State != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.CompleteNumber != 0)
			{
				num ^= this.CompleteNumber.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CC8D RID: 52365 RVA: 0x001E267D File Offset: 0x001E087D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CC8E RID: 52366 RVA: 0x001E268A File Offset: 0x001E088A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CC8F RID: 52367 RVA: 0x001E2694 File Offset: 0x001E0894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CompleteNumber != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CompleteNumber);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Id);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CC90 RID: 52368 RVA: 0x001E270C File Offset: 0x001E090C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.State != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.State);
			}
			if (this.CompleteNumber != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CompleteNumber);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CC91 RID: 52369 RVA: 0x001E277C File Offset: 0x001E097C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.State != 0)
			{
				this.State = other.State;
			}
			if (other.CompleteNumber != 0)
			{
				this.CompleteNumber = other.CompleteNumber;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CC92 RID: 52370 RVA: 0x001E27E0 File Offset: 0x001E09E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CC93 RID: 52371 RVA: 0x001E27EC File Offset: 0x001E09EC
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
					if (num != 88U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.State = input.ReadInt32();
						}
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.CompleteNumber = input.ReadInt32();
				}
			}
		}

		// Token: 0x040056B4 RID: 22196
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056B5 RID: 22197
		public const int IdFieldNumber = 11;

		// Token: 0x040056B6 RID: 22198
		private int id_;

		// Token: 0x040056B7 RID: 22199
		public const int StateFieldNumber = 12;

		// Token: 0x040056B8 RID: 22200
		private int state_;

		// Token: 0x040056B9 RID: 22201
		public const int CompleteNumberFieldNumber = 3;

		// Token: 0x040056BA RID: 22202
		private int completeNumber_;
	}
}
