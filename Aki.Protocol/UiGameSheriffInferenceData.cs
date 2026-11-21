using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014F3 RID: 5363
	public sealed class UiGameSheriffInferenceData : IMessage<UiGameSheriffInferenceData>, IMessage, IEquatable<UiGameSheriffInferenceData>, IDeepCloneable<UiGameSheriffInferenceData>, IBufferMessage
	{
		// Token: 0x0601C6EE RID: 116462 RVA: 0x0041FCB9 File Offset: 0x0041DEB9
		[NullableContext(1)]
		public static UiGameSheriffInferenceData Create()
		{
			return new UiGameSheriffInferenceData();
		}

		// Token: 0x17006039 RID: 24633
		// (get) Token: 0x0601C6EF RID: 116463 RVA: 0x0041FCC0 File Offset: 0x0041DEC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700603A RID: 24634
		// (get) Token: 0x0601C6F0 RID: 116464 RVA: 0x0041FCC3 File Offset: 0x0041DEC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UiGameSheriffInferenceData.Descriptor;
			}
		}

		// Token: 0x0601C6F1 RID: 116465 RVA: 0x0041FCCA File Offset: 0x0041DECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGameSheriffInferenceData()
		{
		}

		// Token: 0x0601C6F2 RID: 116466 RVA: 0x0041FCD2 File Offset: 0x0041DED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGameSheriffInferenceData(UiGameSheriffInferenceData other) : this()
		{
			this.progressId_ = other.progressId_;
			this.endingId_ = other.endingId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C6F3 RID: 116467 RVA: 0x0041FD03 File Offset: 0x0041DF03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGameSheriffInferenceData Clone()
		{
			return new UiGameSheriffInferenceData(this);
		}

		// Token: 0x1700603B RID: 24635
		// (get) Token: 0x0601C6F4 RID: 116468 RVA: 0x0041FD0B File Offset: 0x0041DF0B
		// (set) Token: 0x0601C6F5 RID: 116469 RVA: 0x0041FD13 File Offset: 0x0041DF13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ProgressId
		{
			get
			{
				return this.progressId_;
			}
			set
			{
				this.progressId_ = value;
			}
		}

		// Token: 0x1700603C RID: 24636
		// (get) Token: 0x0601C6F6 RID: 116470 RVA: 0x0041FD1C File Offset: 0x0041DF1C
		// (set) Token: 0x0601C6F7 RID: 116471 RVA: 0x0041FD24 File Offset: 0x0041DF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EndingId
		{
			get
			{
				return this.endingId_;
			}
			set
			{
				this.endingId_ = value;
			}
		}

		// Token: 0x0601C6F8 RID: 116472 RVA: 0x0041FD2D File Offset: 0x0041DF2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UiGameSheriffInferenceData);
		}

		// Token: 0x0601C6F9 RID: 116473 RVA: 0x0041FD3B File Offset: 0x0041DF3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UiGameSheriffInferenceData other)
		{
			return other != null && (other == this || (this.ProgressId == other.ProgressId && this.EndingId == other.EndingId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C6FA RID: 116474 RVA: 0x0041FD7C File Offset: 0x0041DF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ProgressId != 0)
			{
				num ^= this.ProgressId.GetHashCode();
			}
			if (this.EndingId != 0)
			{
				num ^= this.EndingId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C6FB RID: 116475 RVA: 0x0041FDD4 File Offset: 0x0041DFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C6FC RID: 116476 RVA: 0x0041FDE1 File Offset: 0x0041DFE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C6FD RID: 116477 RVA: 0x0041FDEC File Offset: 0x0041DFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ProgressId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ProgressId);
			}
			if (this.EndingId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EndingId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C6FE RID: 116478 RVA: 0x0041FE44 File Offset: 0x0041E044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ProgressId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ProgressId);
			}
			if (this.EndingId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EndingId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C6FF RID: 116479 RVA: 0x0041FE9C File Offset: 0x0041E09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UiGameSheriffInferenceData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ProgressId != 0)
			{
				this.ProgressId = other.ProgressId;
			}
			if (other.EndingId != 0)
			{
				this.EndingId = other.EndingId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C700 RID: 116480 RVA: 0x0041FEEC File Offset: 0x0041E0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C701 RID: 116481 RVA: 0x0041FEF8 File Offset: 0x0041E0F8
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EndingId = input.ReadInt32();
					}
				}
				else
				{
					this.ProgressId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A426 RID: 42022
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A427 RID: 42023
		public const int ProgressIdFieldNumber = 1;

		// Token: 0x0400A428 RID: 42024
		private int progressId_;

		// Token: 0x0400A429 RID: 42025
		public const int EndingIdFieldNumber = 2;

		// Token: 0x0400A42A RID: 42026
		private int endingId_;
	}
}
