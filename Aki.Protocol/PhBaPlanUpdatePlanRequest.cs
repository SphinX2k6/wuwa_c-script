using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D22 RID: 3362
	[NetMessage(EMessageId.PhBaPlanUpdatePlanRequest)]
	public sealed class PhBaPlanUpdatePlanRequest : IMessage<PhBaPlanUpdatePlanRequest>, IMessage, IEquatable<PhBaPlanUpdatePlanRequest>, IDeepCloneable<PhBaPlanUpdatePlanRequest>, IBufferMessage
	{
		// Token: 0x0601227D RID: 74365 RVA: 0x002A6D03 File Offset: 0x002A4F03
		[NullableContext(1)]
		public static PhBaPlanUpdatePlanRequest Create()
		{
			return new PhBaPlanUpdatePlanRequest();
		}

		// Token: 0x17003C26 RID: 15398
		// (get) Token: 0x0601227E RID: 74366 RVA: 0x002A6D0A File Offset: 0x002A4F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C27 RID: 15399
		// (get) Token: 0x0601227F RID: 74367 RVA: 0x002A6D0D File Offset: 0x002A4F0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanUpdatePlanRequest.Descriptor;
			}
		}

		// Token: 0x06012280 RID: 74368 RVA: 0x002A6D14 File Offset: 0x002A4F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanUpdatePlanRequest()
		{
		}

		// Token: 0x06012281 RID: 74369 RVA: 0x002A6D1C File Offset: 0x002A4F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanUpdatePlanRequest(PhBaPlanUpdatePlanRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012282 RID: 74370 RVA: 0x002A6D35 File Offset: 0x002A4F35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanUpdatePlanRequest Clone()
		{
			return new PhBaPlanUpdatePlanRequest(this);
		}

		// Token: 0x06012283 RID: 74371 RVA: 0x002A6D3D File Offset: 0x002A4F3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanUpdatePlanRequest);
		}

		// Token: 0x06012284 RID: 74372 RVA: 0x002A6D4B File Offset: 0x002A4F4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanUpdatePlanRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06012285 RID: 74373 RVA: 0x002A6D6C File Offset: 0x002A4F6C
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

		// Token: 0x06012286 RID: 74374 RVA: 0x002A6D92 File Offset: 0x002A4F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012287 RID: 74375 RVA: 0x002A6D9F File Offset: 0x002A4F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012288 RID: 74376 RVA: 0x002A6DA8 File Offset: 0x002A4FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012289 RID: 74377 RVA: 0x002A6DC0 File Offset: 0x002A4FC0
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

		// Token: 0x0601228A RID: 74378 RVA: 0x002A6DE6 File Offset: 0x002A4FE6
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

		// Token: 0x0601228B RID: 74379 RVA: 0x002A6E03 File Offset: 0x002A5003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601228C RID: 74380 RVA: 0x002A6E0C File Offset: 0x002A500C
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

		// Token: 0x0400716D RID: 29037
		private UnknownFieldSet _unknownFields;
	}
}
