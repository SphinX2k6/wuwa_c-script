using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ECF RID: 3791
	[NetMessage(EMessageId.RegressDisposableRewardRequest)]
	public sealed class RegressDisposableRewardRequest : IMessage<RegressDisposableRewardRequest>, IMessage, IEquatable<RegressDisposableRewardRequest>, IDeepCloneable<RegressDisposableRewardRequest>, IBufferMessage
	{
		// Token: 0x060145A5 RID: 83365 RVA: 0x002F60B0 File Offset: 0x002F42B0
		[NullableContext(1)]
		public static RegressDisposableRewardRequest Create()
		{
			return new RegressDisposableRewardRequest();
		}

		// Token: 0x170043B8 RID: 17336
		// (get) Token: 0x060145A6 RID: 83366 RVA: 0x002F60B7 File Offset: 0x002F42B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043B9 RID: 17337
		// (get) Token: 0x060145A7 RID: 83367 RVA: 0x002F60BA File Offset: 0x002F42BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressDisposableRewardRequest.Descriptor;
			}
		}

		// Token: 0x060145A8 RID: 83368 RVA: 0x002F60C1 File Offset: 0x002F42C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressDisposableRewardRequest()
		{
		}

		// Token: 0x060145A9 RID: 83369 RVA: 0x002F60C9 File Offset: 0x002F42C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressDisposableRewardRequest(RegressDisposableRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060145AA RID: 83370 RVA: 0x002F60E2 File Offset: 0x002F42E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressDisposableRewardRequest Clone()
		{
			return new RegressDisposableRewardRequest(this);
		}

		// Token: 0x060145AB RID: 83371 RVA: 0x002F60EA File Offset: 0x002F42EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressDisposableRewardRequest);
		}

		// Token: 0x060145AC RID: 83372 RVA: 0x002F60F8 File Offset: 0x002F42F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressDisposableRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060145AD RID: 83373 RVA: 0x002F6118 File Offset: 0x002F4318
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

		// Token: 0x060145AE RID: 83374 RVA: 0x002F613E File Offset: 0x002F433E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060145AF RID: 83375 RVA: 0x002F614B File Offset: 0x002F434B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060145B0 RID: 83376 RVA: 0x002F6154 File Offset: 0x002F4354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060145B1 RID: 83377 RVA: 0x002F616C File Offset: 0x002F436C
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

		// Token: 0x060145B2 RID: 83378 RVA: 0x002F6192 File Offset: 0x002F4392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressDisposableRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060145B3 RID: 83379 RVA: 0x002F61AF File Offset: 0x002F43AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060145B4 RID: 83380 RVA: 0x002F61B8 File Offset: 0x002F43B8
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

		// Token: 0x04007C19 RID: 31769
		private UnknownFieldSet _unknownFields;
	}
}
