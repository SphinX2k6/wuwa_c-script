using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012C5 RID: 4805
	public sealed class SurvivorsEndStepPbData : IMessage<SurvivorsEndStepPbData>, IMessage, IEquatable<SurvivorsEndStepPbData>, IDeepCloneable<SurvivorsEndStepPbData>, IBufferMessage
	{
		// Token: 0x06019913 RID: 104723 RVA: 0x003B751E File Offset: 0x003B571E
		[NullableContext(1)]
		public static SurvivorsEndStepPbData Create()
		{
			return new SurvivorsEndStepPbData();
		}

		// Token: 0x1700563D RID: 22077
		// (get) Token: 0x06019914 RID: 104724 RVA: 0x003B7525 File Offset: 0x003B5725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700563E RID: 22078
		// (get) Token: 0x06019915 RID: 104725 RVA: 0x003B7528 File Offset: 0x003B5728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsEndStepPbData.Descriptor;
			}
		}

		// Token: 0x06019916 RID: 104726 RVA: 0x003B752F File Offset: 0x003B572F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsEndStepPbData()
		{
		}

		// Token: 0x06019917 RID: 104727 RVA: 0x003B7537 File Offset: 0x003B5737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsEndStepPbData(SurvivorsEndStepPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019918 RID: 104728 RVA: 0x003B7550 File Offset: 0x003B5750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsEndStepPbData Clone()
		{
			return new SurvivorsEndStepPbData(this);
		}

		// Token: 0x06019919 RID: 104729 RVA: 0x003B7558 File Offset: 0x003B5758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsEndStepPbData);
		}

		// Token: 0x0601991A RID: 104730 RVA: 0x003B7566 File Offset: 0x003B5766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsEndStepPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601991B RID: 104731 RVA: 0x003B7584 File Offset: 0x003B5784
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

		// Token: 0x0601991C RID: 104732 RVA: 0x003B75AA File Offset: 0x003B57AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601991D RID: 104733 RVA: 0x003B75B7 File Offset: 0x003B57B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601991E RID: 104734 RVA: 0x003B75C0 File Offset: 0x003B57C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601991F RID: 104735 RVA: 0x003B75D8 File Offset: 0x003B57D8
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

		// Token: 0x06019920 RID: 104736 RVA: 0x003B75FE File Offset: 0x003B57FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsEndStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019921 RID: 104737 RVA: 0x003B761B File Offset: 0x003B581B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019922 RID: 104738 RVA: 0x003B7624 File Offset: 0x003B5824
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

		// Token: 0x040095FC RID: 38396
		private UnknownFieldSet _unknownFields;
	}
}
