using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D12 RID: 3346
	[NetMessage(EMessageId.PhBaPlanUpdatePlanRequest)]
	public sealed class PhBaPlanUpdatePlanRequest : IMessage<PhBaPlanUpdatePlanRequest>, IMessage, IEquatable<PhBaPlanUpdatePlanRequest>, IDeepCloneable<PhBaPlanUpdatePlanRequest>, IBufferMessage
	{
		// Token: 0x06012181 RID: 74113 RVA: 0x002A50DF File Offset: 0x002A32DF
		[NullableContext(1)]
		public static PhBaPlanUpdatePlanRequest Create()
		{
			return new PhBaPlanUpdatePlanRequest();
		}

		// Token: 0x17003BF1 RID: 15345
		// (get) Token: 0x06012182 RID: 74114 RVA: 0x002A50E6 File Offset: 0x002A32E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BF2 RID: 15346
		// (get) Token: 0x06012183 RID: 74115 RVA: 0x002A50E9 File Offset: 0x002A32E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanUpdatePlanRequest.Descriptor;
			}
		}

		// Token: 0x06012184 RID: 74116 RVA: 0x002A50F0 File Offset: 0x002A32F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanUpdatePlanRequest()
		{
		}

		// Token: 0x06012185 RID: 74117 RVA: 0x002A50F8 File Offset: 0x002A32F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanUpdatePlanRequest(PhBaPlanUpdatePlanRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012186 RID: 74118 RVA: 0x002A5111 File Offset: 0x002A3311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanUpdatePlanRequest Clone()
		{
			return new PhBaPlanUpdatePlanRequest(this);
		}

		// Token: 0x06012187 RID: 74119 RVA: 0x002A5119 File Offset: 0x002A3319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanUpdatePlanRequest);
		}

		// Token: 0x06012188 RID: 74120 RVA: 0x002A5127 File Offset: 0x002A3327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanUpdatePlanRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06012189 RID: 74121 RVA: 0x002A5148 File Offset: 0x002A3348
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

		// Token: 0x0601218A RID: 74122 RVA: 0x002A516E File Offset: 0x002A336E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601218B RID: 74123 RVA: 0x002A517B File Offset: 0x002A337B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601218C RID: 74124 RVA: 0x002A5184 File Offset: 0x002A3384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601218D RID: 74125 RVA: 0x002A519C File Offset: 0x002A339C
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

		// Token: 0x0601218E RID: 74126 RVA: 0x002A51C2 File Offset: 0x002A33C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhBaPlanUpdatePlanRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601218F RID: 74127 RVA: 0x002A51DF File Offset: 0x002A33DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012190 RID: 74128 RVA: 0x002A51E8 File Offset: 0x002A33E8
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

		// Token: 0x04007185 RID: 29061
		private UnknownFieldSet _unknownFields;
	}
}
