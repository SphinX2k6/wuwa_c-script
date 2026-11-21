using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200134B RID: 4939
	public sealed class SurvivorsPrepareStepPbData : IMessage<SurvivorsPrepareStepPbData>, IMessage, IEquatable<SurvivorsPrepareStepPbData>, IDeepCloneable<SurvivorsPrepareStepPbData>, IBufferMessage
	{
		// Token: 0x0601A52D RID: 107821 RVA: 0x003D67AA File Offset: 0x003D49AA
		[NullableContext(1)]
		public static SurvivorsPrepareStepPbData Create()
		{
			return new SurvivorsPrepareStepPbData();
		}

		// Token: 0x1700592B RID: 22827
		// (get) Token: 0x0601A52E RID: 107822 RVA: 0x003D67B1 File Offset: 0x003D49B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700592C RID: 22828
		// (get) Token: 0x0601A52F RID: 107823 RVA: 0x003D67B4 File Offset: 0x003D49B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsPrepareStepPbData.Descriptor;
			}
		}

		// Token: 0x0601A530 RID: 107824 RVA: 0x003D67BB File Offset: 0x003D49BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsPrepareStepPbData()
		{
		}

		// Token: 0x0601A531 RID: 107825 RVA: 0x003D67C3 File Offset: 0x003D49C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsPrepareStepPbData(SurvivorsPrepareStepPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A532 RID: 107826 RVA: 0x003D67DC File Offset: 0x003D49DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsPrepareStepPbData Clone()
		{
			return new SurvivorsPrepareStepPbData(this);
		}

		// Token: 0x0601A533 RID: 107827 RVA: 0x003D67E4 File Offset: 0x003D49E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsPrepareStepPbData);
		}

		// Token: 0x0601A534 RID: 107828 RVA: 0x003D67F2 File Offset: 0x003D49F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsPrepareStepPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601A535 RID: 107829 RVA: 0x003D6810 File Offset: 0x003D4A10
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

		// Token: 0x0601A536 RID: 107830 RVA: 0x003D6836 File Offset: 0x003D4A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A537 RID: 107831 RVA: 0x003D6843 File Offset: 0x003D4A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A538 RID: 107832 RVA: 0x003D684C File Offset: 0x003D4A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A539 RID: 107833 RVA: 0x003D6864 File Offset: 0x003D4A64
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

		// Token: 0x0601A53A RID: 107834 RVA: 0x003D688A File Offset: 0x003D4A8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsPrepareStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A53B RID: 107835 RVA: 0x003D68A7 File Offset: 0x003D4AA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A53C RID: 107836 RVA: 0x003D68B0 File Offset: 0x003D4AB0
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

		// Token: 0x04009ABC RID: 39612
		private UnknownFieldSet _unknownFields;
	}
}
