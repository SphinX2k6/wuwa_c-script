using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008CF RID: 2255
	[NetMessage(EMessageId.KurotatoStepAdvanceRequest)]
	public sealed class KurotatoStepAdvanceRequest : IMessage<KurotatoStepAdvanceRequest>, IMessage, IEquatable<KurotatoStepAdvanceRequest>, IDeepCloneable<KurotatoStepAdvanceRequest>, IBufferMessage
	{
		// Token: 0x0600C7CC RID: 51148 RVA: 0x001D8A88 File Offset: 0x001D6C88
		[NullableContext(1)]
		public static KurotatoStepAdvanceRequest Create()
		{
			return new KurotatoStepAdvanceRequest();
		}

		// Token: 0x1700285F RID: 10335
		// (get) Token: 0x0600C7CD RID: 51149 RVA: 0x001D8A8F File Offset: 0x001D6C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002860 RID: 10336
		// (get) Token: 0x0600C7CE RID: 51150 RVA: 0x001D8A92 File Offset: 0x001D6C92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoStepAdvanceRequest.Descriptor;
			}
		}

		// Token: 0x0600C7CF RID: 51151 RVA: 0x001D8A99 File Offset: 0x001D6C99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStepAdvanceRequest()
		{
		}

		// Token: 0x0600C7D0 RID: 51152 RVA: 0x001D8AA1 File Offset: 0x001D6CA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStepAdvanceRequest(KurotatoStepAdvanceRequest other) : this()
		{
			if (other.StepPbDataCase == KurotatoStepAdvanceRequest.StepPbDataOneofCase.EndStepPbData)
			{
				this.EndStepPbData = other.EndStepPbData.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C7D1 RID: 51153 RVA: 0x001D8AD4 File Offset: 0x001D6CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStepAdvanceRequest Clone()
		{
			return new KurotatoStepAdvanceRequest(this);
		}

		// Token: 0x17002861 RID: 10337
		// (get) Token: 0x0600C7D2 RID: 51154 RVA: 0x001D8ADC File Offset: 0x001D6CDC
		// (set) Token: 0x0600C7D3 RID: 51155 RVA: 0x001D8AF4 File Offset: 0x001D6CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndStepPbData EndStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != KurotatoStepAdvanceRequest.StepPbDataOneofCase.EndStepPbData)
				{
					return null;
				}
				return (KurotatoEndStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? KurotatoStepAdvanceRequest.StepPbDataOneofCase.None : KurotatoStepAdvanceRequest.StepPbDataOneofCase.EndStepPbData);
			}
		}

		// Token: 0x17002862 RID: 10338
		// (get) Token: 0x0600C7D4 RID: 51156 RVA: 0x001D8B0A File Offset: 0x001D6D0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStepAdvanceRequest.StepPbDataOneofCase StepPbDataCase
		{
			get
			{
				return this.stepPbDataCase_;
			}
		}

		// Token: 0x0600C7D5 RID: 51157 RVA: 0x001D8B12 File Offset: 0x001D6D12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStepPbData()
		{
			this.stepPbDataCase_ = KurotatoStepAdvanceRequest.StepPbDataOneofCase.None;
			this.stepPbData_ = null;
		}

		// Token: 0x0600C7D6 RID: 51158 RVA: 0x001D8B22 File Offset: 0x001D6D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoStepAdvanceRequest);
		}

		// Token: 0x0600C7D7 RID: 51159 RVA: 0x001D8B30 File Offset: 0x001D6D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoStepAdvanceRequest other)
		{
			return other != null && (other == this || (object.Equals(this.EndStepPbData, other.EndStepPbData) && this.StepPbDataCase == other.StepPbDataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C7D8 RID: 51160 RVA: 0x001D8B80 File Offset: 0x001D6D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.stepPbDataCase_ == KurotatoStepAdvanceRequest.StepPbDataOneofCase.EndStepPbData)
			{
				num ^= this.EndStepPbData.GetHashCode();
			}
			num ^= (int)this.stepPbDataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C7D9 RID: 51161 RVA: 0x001D8BC6 File Offset: 0x001D6DC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C7DA RID: 51162 RVA: 0x001D8BD3 File Offset: 0x001D6DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C7DB RID: 51163 RVA: 0x001D8BDC File Offset: 0x001D6DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.stepPbDataCase_ == KurotatoStepAdvanceRequest.StepPbDataOneofCase.EndStepPbData)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.EndStepPbData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C7DC RID: 51164 RVA: 0x001D8C10 File Offset: 0x001D6E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.stepPbDataCase_ == KurotatoStepAdvanceRequest.StepPbDataOneofCase.EndStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EndStepPbData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C7DD RID: 51165 RVA: 0x001D8C50 File Offset: 0x001D6E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoStepAdvanceRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StepPbDataCase == KurotatoStepAdvanceRequest.StepPbDataOneofCase.EndStepPbData)
			{
				if (this.EndStepPbData == null)
				{
					this.EndStepPbData = new KurotatoEndStepPbData();
				}
				this.EndStepPbData.MergeFrom(other.EndStepPbData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C7DE RID: 51166 RVA: 0x001D8CA5 File Offset: 0x001D6EA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C7DF RID: 51167 RVA: 0x001D8CB0 File Offset: 0x001D6EB0
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					KurotatoEndStepPbData kurotatoEndStepPbData = new KurotatoEndStepPbData();
					if (this.stepPbDataCase_ == KurotatoStepAdvanceRequest.StepPbDataOneofCase.EndStepPbData)
					{
						kurotatoEndStepPbData.MergeFrom(this.EndStepPbData);
					}
					input.ReadMessage(kurotatoEndStepPbData);
					this.EndStepPbData = kurotatoEndStepPbData;
				}
			}
		}

		// Token: 0x04005590 RID: 21904
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005591 RID: 21905
		public const int EndStepPbDataFieldNumber = 2;

		// Token: 0x04005592 RID: 21906
		private object stepPbData_;

		// Token: 0x04005593 RID: 21907
		private KurotatoStepAdvanceRequest.StepPbDataOneofCase stepPbDataCase_;

		// Token: 0x02001814 RID: 6164
		public enum StepPbDataOneofCase
		{
			// Token: 0x0400C7C8 RID: 51144
			None,
			// Token: 0x0400C7C9 RID: 51145
			EndStepPbData = 2
		}
	}
}
