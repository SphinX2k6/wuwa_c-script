using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014F0 RID: 5360
	public sealed class UiGamePlayData : IMessage<UiGamePlayData>, IMessage, IEquatable<UiGamePlayData>, IDeepCloneable<UiGamePlayData>, IBufferMessage
	{
		// Token: 0x0601C6B2 RID: 116402 RVA: 0x0041F490 File Offset: 0x0041D690
		[NullableContext(1)]
		public static UiGamePlayData Create()
		{
			return new UiGamePlayData();
		}

		// Token: 0x1700602D RID: 24621
		// (get) Token: 0x0601C6B3 RID: 116403 RVA: 0x0041F497 File Offset: 0x0041D697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700602E RID: 24622
		// (get) Token: 0x0601C6B4 RID: 116404 RVA: 0x0041F49A File Offset: 0x0041D69A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UiGamePlayData.Descriptor;
			}
		}

		// Token: 0x0601C6B5 RID: 116405 RVA: 0x0041F4A1 File Offset: 0x0041D6A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGamePlayData()
		{
		}

		// Token: 0x0601C6B6 RID: 116406 RVA: 0x0041F4A9 File Offset: 0x0041D6A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGamePlayData(UiGamePlayData other) : this()
		{
			if (other.DataCase == UiGamePlayData.DataOneofCase.SheriffInferenceData)
			{
				this.SheriffInferenceData = other.SheriffInferenceData.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C6B7 RID: 116407 RVA: 0x0041F4DC File Offset: 0x0041D6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGamePlayData Clone()
		{
			return new UiGamePlayData(this);
		}

		// Token: 0x1700602F RID: 24623
		// (get) Token: 0x0601C6B8 RID: 116408 RVA: 0x0041F4E4 File Offset: 0x0041D6E4
		// (set) Token: 0x0601C6B9 RID: 116409 RVA: 0x0041F4FC File Offset: 0x0041D6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGameSheriffInferenceData SheriffInferenceData
		{
			get
			{
				if (this.dataCase_ != UiGamePlayData.DataOneofCase.SheriffInferenceData)
				{
					return null;
				}
				return (UiGameSheriffInferenceData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? UiGamePlayData.DataOneofCase.None : UiGamePlayData.DataOneofCase.SheriffInferenceData);
			}
		}

		// Token: 0x17006030 RID: 24624
		// (get) Token: 0x0601C6BA RID: 116410 RVA: 0x0041F512 File Offset: 0x0041D712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGamePlayData.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x0601C6BB RID: 116411 RVA: 0x0041F51A File Offset: 0x0041D71A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = UiGamePlayData.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x0601C6BC RID: 116412 RVA: 0x0041F52A File Offset: 0x0041D72A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UiGamePlayData);
		}

		// Token: 0x0601C6BD RID: 116413 RVA: 0x0041F538 File Offset: 0x0041D738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UiGamePlayData other)
		{
			return other != null && (other == this || (object.Equals(this.SheriffInferenceData, other.SheriffInferenceData) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C6BE RID: 116414 RVA: 0x0041F588 File Offset: 0x0041D788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.dataCase_ == UiGamePlayData.DataOneofCase.SheriffInferenceData)
			{
				num ^= this.SheriffInferenceData.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C6BF RID: 116415 RVA: 0x0041F5CE File Offset: 0x0041D7CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C6C0 RID: 116416 RVA: 0x0041F5DB File Offset: 0x0041D7DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C6C1 RID: 116417 RVA: 0x0041F5E4 File Offset: 0x0041D7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dataCase_ == UiGamePlayData.DataOneofCase.SheriffInferenceData)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SheriffInferenceData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C6C2 RID: 116418 RVA: 0x0041F618 File Offset: 0x0041D818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.dataCase_ == UiGamePlayData.DataOneofCase.SheriffInferenceData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SheriffInferenceData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C6C3 RID: 116419 RVA: 0x0041F658 File Offset: 0x0041D858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UiGamePlayData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DataCase == UiGamePlayData.DataOneofCase.SheriffInferenceData)
			{
				if (this.SheriffInferenceData == null)
				{
					this.SheriffInferenceData = new UiGameSheriffInferenceData();
				}
				this.SheriffInferenceData.MergeFrom(other.SheriffInferenceData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C6C4 RID: 116420 RVA: 0x0041F6AD File Offset: 0x0041D8AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C6C5 RID: 116421 RVA: 0x0041F6B8 File Offset: 0x0041D8B8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					UiGameSheriffInferenceData uiGameSheriffInferenceData = new UiGameSheriffInferenceData();
					if (this.dataCase_ == UiGamePlayData.DataOneofCase.SheriffInferenceData)
					{
						uiGameSheriffInferenceData.MergeFrom(this.SheriffInferenceData);
					}
					input.ReadMessage(uiGameSheriffInferenceData);
					this.SheriffInferenceData = uiGameSheriffInferenceData;
				}
			}
		}

		// Token: 0x0400A418 RID: 42008
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A419 RID: 42009
		public const int SheriffInferenceDataFieldNumber = 1;

		// Token: 0x0400A41A RID: 42010
		private object data_;

		// Token: 0x0400A41B RID: 42011
		private UiGamePlayData.DataOneofCase dataCase_;

		// Token: 0x02001A89 RID: 6793
		public enum DataOneofCase
		{
			// Token: 0x0400D02D RID: 53293
			None,
			// Token: 0x0400D02E RID: 53294
			SheriffInferenceData
		}
	}
}
