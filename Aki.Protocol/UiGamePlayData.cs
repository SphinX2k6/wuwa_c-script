using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200147D RID: 5245
	public sealed class UiGamePlayData : IMessage<UiGamePlayData>, IMessage, IEquatable<UiGamePlayData>, IDeepCloneable<UiGamePlayData>, IBufferMessage
	{
		// Token: 0x0601BC27 RID: 113703 RVA: 0x004041CC File Offset: 0x004023CC
		[NullableContext(1)]
		public static UiGamePlayData Create()
		{
			return new UiGamePlayData();
		}

		// Token: 0x17005D98 RID: 23960
		// (get) Token: 0x0601BC28 RID: 113704 RVA: 0x004041D3 File Offset: 0x004023D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D99 RID: 23961
		// (get) Token: 0x0601BC29 RID: 113705 RVA: 0x004041D6 File Offset: 0x004023D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UiGamePlayData.Descriptor;
			}
		}

		// Token: 0x0601BC2A RID: 113706 RVA: 0x004041DD File Offset: 0x004023DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGamePlayData()
		{
		}

		// Token: 0x0601BC2B RID: 113707 RVA: 0x004041E5 File Offset: 0x004023E5
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

		// Token: 0x0601BC2C RID: 113708 RVA: 0x00404218 File Offset: 0x00402418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGamePlayData Clone()
		{
			return new UiGamePlayData(this);
		}

		// Token: 0x17005D9A RID: 23962
		// (get) Token: 0x0601BC2D RID: 113709 RVA: 0x00404220 File Offset: 0x00402420
		// (set) Token: 0x0601BC2E RID: 113710 RVA: 0x00404238 File Offset: 0x00402438
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

		// Token: 0x17005D9B RID: 23963
		// (get) Token: 0x0601BC2F RID: 113711 RVA: 0x0040424E File Offset: 0x0040244E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGamePlayData.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x0601BC30 RID: 113712 RVA: 0x00404256 File Offset: 0x00402456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = UiGamePlayData.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x0601BC31 RID: 113713 RVA: 0x00404266 File Offset: 0x00402466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UiGamePlayData);
		}

		// Token: 0x0601BC32 RID: 113714 RVA: 0x00404274 File Offset: 0x00402474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UiGamePlayData other)
		{
			return other != null && (other == this || (object.Equals(this.SheriffInferenceData, other.SheriffInferenceData) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BC33 RID: 113715 RVA: 0x004042C4 File Offset: 0x004024C4
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

		// Token: 0x0601BC34 RID: 113716 RVA: 0x0040430A File Offset: 0x0040250A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BC35 RID: 113717 RVA: 0x00404317 File Offset: 0x00402517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BC36 RID: 113718 RVA: 0x00404320 File Offset: 0x00402520
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

		// Token: 0x0601BC37 RID: 113719 RVA: 0x00404354 File Offset: 0x00402554
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

		// Token: 0x0601BC38 RID: 113720 RVA: 0x00404394 File Offset: 0x00402594
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

		// Token: 0x0601BC39 RID: 113721 RVA: 0x004043E9 File Offset: 0x004025E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BC3A RID: 113722 RVA: 0x004043F4 File Offset: 0x004025F4
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

		// Token: 0x04009FD1 RID: 40913
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FD2 RID: 40914
		public const int SheriffInferenceDataFieldNumber = 1;

		// Token: 0x04009FD3 RID: 40915
		private object data_;

		// Token: 0x04009FD4 RID: 40916
		private UiGamePlayData.DataOneofCase dataCase_;

		// Token: 0x020019E7 RID: 6631
		public enum DataOneofCase
		{
			// Token: 0x0400CAC2 RID: 51906
			None,
			// Token: 0x0400CAC3 RID: 51907
			SheriffInferenceData
		}
	}
}
