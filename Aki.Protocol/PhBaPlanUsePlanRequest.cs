using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D24 RID: 3364
	[NetMessage(EMessageId.PhBaPlanUsePlanRequest)]
	public sealed class PhBaPlanUsePlanRequest : IMessage<PhBaPlanUsePlanRequest>, IMessage, IEquatable<PhBaPlanUsePlanRequest>, IDeepCloneable<PhBaPlanUsePlanRequest>, IBufferMessage
	{
		// Token: 0x060122A1 RID: 74401 RVA: 0x002A7114 File Offset: 0x002A5314
		[NullableContext(1)]
		public static PhBaPlanUsePlanRequest Create()
		{
			return new PhBaPlanUsePlanRequest();
		}

		// Token: 0x17003C2C RID: 15404
		// (get) Token: 0x060122A2 RID: 74402 RVA: 0x002A711B File Offset: 0x002A531B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C2D RID: 15405
		// (get) Token: 0x060122A3 RID: 74403 RVA: 0x002A711E File Offset: 0x002A531E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanUsePlanRequest.Descriptor;
			}
		}

		// Token: 0x060122A4 RID: 74404 RVA: 0x002A7125 File Offset: 0x002A5325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanUsePlanRequest()
		{
		}

		// Token: 0x060122A5 RID: 74405 RVA: 0x002A712D File Offset: 0x002A532D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanUsePlanRequest(PhBaPlanUsePlanRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060122A6 RID: 74406 RVA: 0x002A7146 File Offset: 0x002A5346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanUsePlanRequest Clone()
		{
			return new PhBaPlanUsePlanRequest(this);
		}

		// Token: 0x060122A7 RID: 74407 RVA: 0x002A714E File Offset: 0x002A534E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanUsePlanRequest);
		}

		// Token: 0x060122A8 RID: 74408 RVA: 0x002A715C File Offset: 0x002A535C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanUsePlanRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060122A9 RID: 74409 RVA: 0x002A717C File Offset: 0x002A537C
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

		// Token: 0x060122AA RID: 74410 RVA: 0x002A71A2 File Offset: 0x002A53A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060122AB RID: 74411 RVA: 0x002A71AF File Offset: 0x002A53AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060122AC RID: 74412 RVA: 0x002A71B8 File Offset: 0x002A53B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060122AD RID: 74413 RVA: 0x002A71D0 File Offset: 0x002A53D0
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

		// Token: 0x060122AE RID: 74414 RVA: 0x002A71F6 File Offset: 0x002A53F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhBaPlanUsePlanRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060122AF RID: 74415 RVA: 0x002A7213 File Offset: 0x002A5413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060122B0 RID: 74416 RVA: 0x002A721C File Offset: 0x002A541C
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

		// Token: 0x04007173 RID: 29043
		private UnknownFieldSet _unknownFields;
	}
}
