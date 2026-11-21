using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A35 RID: 2613
	[NetMessage(EMessageId.MotorFightLastSaveDataRequest)]
	public sealed class MotorFightLastSaveDataRequest : IMessage<MotorFightLastSaveDataRequest>, IMessage, IEquatable<MotorFightLastSaveDataRequest>, IDeepCloneable<MotorFightLastSaveDataRequest>, IBufferMessage
	{
		// Token: 0x0600E477 RID: 58487 RVA: 0x00216C1E File Offset: 0x00214E1E
		[NullableContext(1)]
		public static MotorFightLastSaveDataRequest Create()
		{
			return new MotorFightLastSaveDataRequest();
		}

		// Token: 0x17002E4D RID: 11853
		// (get) Token: 0x0600E478 RID: 58488 RVA: 0x00216C25 File Offset: 0x00214E25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E4E RID: 11854
		// (get) Token: 0x0600E479 RID: 58489 RVA: 0x00216C28 File Offset: 0x00214E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightLastSaveDataRequest.Descriptor;
			}
		}

		// Token: 0x0600E47A RID: 58490 RVA: 0x00216C2F File Offset: 0x00214E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLastSaveDataRequest()
		{
		}

		// Token: 0x0600E47B RID: 58491 RVA: 0x00216C37 File Offset: 0x00214E37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLastSaveDataRequest(MotorFightLastSaveDataRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E47C RID: 58492 RVA: 0x00216C50 File Offset: 0x00214E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLastSaveDataRequest Clone()
		{
			return new MotorFightLastSaveDataRequest(this);
		}

		// Token: 0x0600E47D RID: 58493 RVA: 0x00216C58 File Offset: 0x00214E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightLastSaveDataRequest);
		}

		// Token: 0x0600E47E RID: 58494 RVA: 0x00216C66 File Offset: 0x00214E66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightLastSaveDataRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600E47F RID: 58495 RVA: 0x00216C84 File Offset: 0x00214E84
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

		// Token: 0x0600E480 RID: 58496 RVA: 0x00216CAA File Offset: 0x00214EAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E481 RID: 58497 RVA: 0x00216CB7 File Offset: 0x00214EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E482 RID: 58498 RVA: 0x00216CC0 File Offset: 0x00214EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E483 RID: 58499 RVA: 0x00216CD8 File Offset: 0x00214ED8
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

		// Token: 0x0600E484 RID: 58500 RVA: 0x00216CFE File Offset: 0x00214EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightLastSaveDataRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E485 RID: 58501 RVA: 0x00216D1B File Offset: 0x00214F1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E486 RID: 58502 RVA: 0x00216D24 File Offset: 0x00214F24
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

		// Token: 0x04005DD0 RID: 24016
		private UnknownFieldSet _unknownFields;
	}
}
