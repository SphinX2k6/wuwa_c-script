using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200134E RID: 4942
	public sealed class SurvivorsRewardStepPbData : IMessage<SurvivorsRewardStepPbData>, IMessage, IEquatable<SurvivorsRewardStepPbData>, IDeepCloneable<SurvivorsRewardStepPbData>, IBufferMessage
	{
		// Token: 0x0601A561 RID: 107873 RVA: 0x003D6D0F File Offset: 0x003D4F0F
		[NullableContext(1)]
		public static SurvivorsRewardStepPbData Create()
		{
			return new SurvivorsRewardStepPbData();
		}

		// Token: 0x17005933 RID: 22835
		// (get) Token: 0x0601A562 RID: 107874 RVA: 0x003D6D16 File Offset: 0x003D4F16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005934 RID: 22836
		// (get) Token: 0x0601A563 RID: 107875 RVA: 0x003D6D19 File Offset: 0x003D4F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsRewardStepPbData.Descriptor;
			}
		}

		// Token: 0x0601A564 RID: 107876 RVA: 0x003D6D20 File Offset: 0x003D4F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRewardStepPbData()
		{
		}

		// Token: 0x0601A565 RID: 107877 RVA: 0x003D6D28 File Offset: 0x003D4F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRewardStepPbData(SurvivorsRewardStepPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A566 RID: 107878 RVA: 0x003D6D41 File Offset: 0x003D4F41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRewardStepPbData Clone()
		{
			return new SurvivorsRewardStepPbData(this);
		}

		// Token: 0x0601A567 RID: 107879 RVA: 0x003D6D49 File Offset: 0x003D4F49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsRewardStepPbData);
		}

		// Token: 0x0601A568 RID: 107880 RVA: 0x003D6D57 File Offset: 0x003D4F57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsRewardStepPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601A569 RID: 107881 RVA: 0x003D6D78 File Offset: 0x003D4F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A56A RID: 107882 RVA: 0x003D6D9E File Offset: 0x003D4F9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A56B RID: 107883 RVA: 0x003D6DAB File Offset: 0x003D4FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A56C RID: 107884 RVA: 0x003D6DB4 File Offset: 0x003D4FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A56D RID: 107885 RVA: 0x003D6DCC File Offset: 0x003D4FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A56E RID: 107886 RVA: 0x003D6DF2 File Offset: 0x003D4FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsRewardStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A56F RID: 107887 RVA: 0x003D6E0F File Offset: 0x003D500F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A570 RID: 107888 RVA: 0x003D6E18 File Offset: 0x003D5018
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009AC3 RID: 39619
		private UnknownFieldSet _unknownFields;
	}
}
