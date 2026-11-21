using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200134C RID: 4940
	[NetMessage(EMessageId.SurvivorsResultRequest)]
	public sealed class SurvivorsResultRequest : IMessage<SurvivorsResultRequest>, IMessage, IEquatable<SurvivorsResultRequest>, IDeepCloneable<SurvivorsResultRequest>, IBufferMessage
	{
		// Token: 0x0601A53D RID: 107837 RVA: 0x003D68E2 File Offset: 0x003D4AE2
		[NullableContext(1)]
		public static SurvivorsResultRequest Create()
		{
			return new SurvivorsResultRequest();
		}

		// Token: 0x1700592D RID: 22829
		// (get) Token: 0x0601A53E RID: 107838 RVA: 0x003D68E9 File Offset: 0x003D4AE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700592E RID: 22830
		// (get) Token: 0x0601A53F RID: 107839 RVA: 0x003D68EC File Offset: 0x003D4AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsResultRequest.Descriptor;
			}
		}

		// Token: 0x0601A540 RID: 107840 RVA: 0x003D68F3 File Offset: 0x003D4AF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsResultRequest()
		{
		}

		// Token: 0x0601A541 RID: 107841 RVA: 0x003D68FB File Offset: 0x003D4AFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsResultRequest(SurvivorsResultRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A542 RID: 107842 RVA: 0x003D6914 File Offset: 0x003D4B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsResultRequest Clone()
		{
			return new SurvivorsResultRequest(this);
		}

		// Token: 0x0601A543 RID: 107843 RVA: 0x003D691C File Offset: 0x003D4B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsResultRequest);
		}

		// Token: 0x0601A544 RID: 107844 RVA: 0x003D692A File Offset: 0x003D4B2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsResultRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601A545 RID: 107845 RVA: 0x003D6948 File Offset: 0x003D4B48
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

		// Token: 0x0601A546 RID: 107846 RVA: 0x003D696E File Offset: 0x003D4B6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A547 RID: 107847 RVA: 0x003D697B File Offset: 0x003D4B7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A548 RID: 107848 RVA: 0x003D6984 File Offset: 0x003D4B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A549 RID: 107849 RVA: 0x003D699C File Offset: 0x003D4B9C
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

		// Token: 0x0601A54A RID: 107850 RVA: 0x003D69C2 File Offset: 0x003D4BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsResultRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A54B RID: 107851 RVA: 0x003D69DF File Offset: 0x003D4BDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A54C RID: 107852 RVA: 0x003D69E8 File Offset: 0x003D4BE8
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

		// Token: 0x04009ABD RID: 39613
		private UnknownFieldSet _unknownFields;
	}
}
