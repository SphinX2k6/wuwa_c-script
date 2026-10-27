using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001480 RID: 5248
	public sealed class UiGameSheriffInferenceData : IMessage<UiGameSheriffInferenceData>, IMessage, IEquatable<UiGameSheriffInferenceData>, IDeepCloneable<UiGameSheriffInferenceData>, IBufferMessage
	{
		// Token: 0x0601BC63 RID: 113763 RVA: 0x004049F5 File Offset: 0x00402BF5
		[NullableContext(1)]
		public static UiGameSheriffInferenceData Create()
		{
			return new UiGameSheriffInferenceData();
		}

		// Token: 0x17005DA4 RID: 23972
		// (get) Token: 0x0601BC64 RID: 113764 RVA: 0x004049FC File Offset: 0x00402BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DA5 RID: 23973
		// (get) Token: 0x0601BC65 RID: 113765 RVA: 0x004049FF File Offset: 0x00402BFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UiGameSheriffInferenceData.Descriptor;
			}
		}

		// Token: 0x0601BC66 RID: 113766 RVA: 0x00404A06 File Offset: 0x00402C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGameSheriffInferenceData()
		{
		}

		// Token: 0x0601BC67 RID: 113767 RVA: 0x00404A0E File Offset: 0x00402C0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGameSheriffInferenceData(UiGameSheriffInferenceData other) : this()
		{
			this.progressId_ = other.progressId_;
			this.endingId_ = other.endingId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BC68 RID: 113768 RVA: 0x00404A3F File Offset: 0x00402C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGameSheriffInferenceData Clone()
		{
			return new UiGameSheriffInferenceData(this);
		}

		// Token: 0x17005DA6 RID: 23974
		// (get) Token: 0x0601BC69 RID: 113769 RVA: 0x00404A47 File Offset: 0x00402C47
		// (set) Token: 0x0601BC6A RID: 113770 RVA: 0x00404A4F File Offset: 0x00402C4F
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

		// Token: 0x17005DA7 RID: 23975
		// (get) Token: 0x0601BC6B RID: 113771 RVA: 0x00404A58 File Offset: 0x00402C58
		// (set) Token: 0x0601BC6C RID: 113772 RVA: 0x00404A60 File Offset: 0x00402C60
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

		// Token: 0x0601BC6D RID: 113773 RVA: 0x00404A69 File Offset: 0x00402C69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UiGameSheriffInferenceData);
		}

		// Token: 0x0601BC6E RID: 113774 RVA: 0x00404A77 File Offset: 0x00402C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UiGameSheriffInferenceData other)
		{
			return other != null && (other == this || (this.ProgressId == other.ProgressId && this.EndingId == other.EndingId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BC6F RID: 113775 RVA: 0x00404AB8 File Offset: 0x00402CB8
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

		// Token: 0x0601BC70 RID: 113776 RVA: 0x00404B10 File Offset: 0x00402D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BC71 RID: 113777 RVA: 0x00404B1D File Offset: 0x00402D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BC72 RID: 113778 RVA: 0x00404B28 File Offset: 0x00402D28
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

		// Token: 0x0601BC73 RID: 113779 RVA: 0x00404B80 File Offset: 0x00402D80
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

		// Token: 0x0601BC74 RID: 113780 RVA: 0x00404BD8 File Offset: 0x00402DD8
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

		// Token: 0x0601BC75 RID: 113781 RVA: 0x00404C28 File Offset: 0x00402E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BC76 RID: 113782 RVA: 0x00404C34 File Offset: 0x00402E34
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

		// Token: 0x04009FDF RID: 40927
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FE0 RID: 40928
		public const int ProgressIdFieldNumber = 1;

		// Token: 0x04009FE1 RID: 40929
		private int progressId_;

		// Token: 0x04009FE2 RID: 40930
		public const int EndingIdFieldNumber = 2;

		// Token: 0x04009FE3 RID: 40931
		private int endingId_;
	}
}
