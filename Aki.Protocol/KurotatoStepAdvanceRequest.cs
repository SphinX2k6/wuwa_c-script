using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008BE RID: 2238
	[NetMessage(EMessageId.KurotatoStepAdvanceRequest)]
	public sealed class KurotatoStepAdvanceRequest : IMessage<KurotatoStepAdvanceRequest>, IMessage, IEquatable<KurotatoStepAdvanceRequest>, IDeepCloneable<KurotatoStepAdvanceRequest>, IBufferMessage
	{
		// Token: 0x0600C6B0 RID: 50864 RVA: 0x001D679C File Offset: 0x001D499C
		[NullableContext(1)]
		public static KurotatoStepAdvanceRequest Create()
		{
			return new KurotatoStepAdvanceRequest();
		}

		// Token: 0x17002820 RID: 10272
		// (get) Token: 0x0600C6B1 RID: 50865 RVA: 0x001D67A3 File Offset: 0x001D49A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002821 RID: 10273
		// (get) Token: 0x0600C6B2 RID: 50866 RVA: 0x001D67A6 File Offset: 0x001D49A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoStepAdvanceRequest.Descriptor;
			}
		}

		// Token: 0x0600C6B3 RID: 50867 RVA: 0x001D67AD File Offset: 0x001D49AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStepAdvanceRequest()
		{
		}

		// Token: 0x0600C6B4 RID: 50868 RVA: 0x001D67B5 File Offset: 0x001D49B5
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

		// Token: 0x0600C6B5 RID: 50869 RVA: 0x001D67E9 File Offset: 0x001D49E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStepAdvanceRequest Clone()
		{
			return new KurotatoStepAdvanceRequest(this);
		}

		// Token: 0x17002822 RID: 10274
		// (get) Token: 0x0600C6B6 RID: 50870 RVA: 0x001D67F1 File Offset: 0x001D49F1
		// (set) Token: 0x0600C6B7 RID: 50871 RVA: 0x001D680A File Offset: 0x001D4A0A
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

		// Token: 0x17002823 RID: 10275
		// (get) Token: 0x0600C6B8 RID: 50872 RVA: 0x001D6821 File Offset: 0x001D4A21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoStepAdvanceRequest.StepPbDataOneofCase StepPbDataCase
		{
			get
			{
				return this.stepPbDataCase_;
			}
		}

		// Token: 0x0600C6B9 RID: 50873 RVA: 0x001D6829 File Offset: 0x001D4A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStepPbData()
		{
			this.stepPbDataCase_ = KurotatoStepAdvanceRequest.StepPbDataOneofCase.None;
			this.stepPbData_ = null;
		}

		// Token: 0x0600C6BA RID: 50874 RVA: 0x001D6839 File Offset: 0x001D4A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoStepAdvanceRequest);
		}

		// Token: 0x0600C6BB RID: 50875 RVA: 0x001D6848 File Offset: 0x001D4A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoStepAdvanceRequest other)
		{
			return other != null && (other == this || (object.Equals(this.EndStepPbData, other.EndStepPbData) && this.StepPbDataCase == other.StepPbDataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C6BC RID: 50876 RVA: 0x001D6898 File Offset: 0x001D4A98
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

		// Token: 0x0600C6BD RID: 50877 RVA: 0x001D68DF File Offset: 0x001D4ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C6BE RID: 50878 RVA: 0x001D68EC File Offset: 0x001D4AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C6BF RID: 50879 RVA: 0x001D68F5 File Offset: 0x001D4AF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.stepPbDataCase_ == KurotatoStepAdvanceRequest.StepPbDataOneofCase.EndStepPbData)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.EndStepPbData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C6C0 RID: 50880 RVA: 0x001D692C File Offset: 0x001D4B2C
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

		// Token: 0x0600C6C1 RID: 50881 RVA: 0x001D696C File Offset: 0x001D4B6C
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

		// Token: 0x0600C6C2 RID: 50882 RVA: 0x001D69C2 File Offset: 0x001D4BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C6C3 RID: 50883 RVA: 0x001D69CC File Offset: 0x001D4BCC
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
				if (num != 98U)
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

		// Token: 0x04005597 RID: 21911
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005598 RID: 21912
		public const int EndStepPbDataFieldNumber = 12;

		// Token: 0x04005599 RID: 21913
		private object stepPbData_;

		// Token: 0x0400559A RID: 21914
		private KurotatoStepAdvanceRequest.StepPbDataOneofCase stepPbDataCase_;

		// Token: 0x0200188C RID: 6284
		public enum StepPbDataOneofCase
		{
			// Token: 0x0400CCF3 RID: 52467
			None,
			// Token: 0x0400CCF4 RID: 52468
			EndStepPbData = 12
		}
	}
}
