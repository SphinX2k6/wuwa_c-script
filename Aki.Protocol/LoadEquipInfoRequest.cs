using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200092B RID: 2347
	[NetMessage(EMessageId.LoadEquipInfoRequest)]
	public sealed class LoadEquipInfoRequest : IMessage<LoadEquipInfoRequest>, IMessage, IEquatable<LoadEquipInfoRequest>, IDeepCloneable<LoadEquipInfoRequest>, IBufferMessage
	{
		// Token: 0x0600CF34 RID: 53044 RVA: 0x001E854A File Offset: 0x001E674A
		[NullableContext(1)]
		public static LoadEquipInfoRequest Create()
		{
			return new LoadEquipInfoRequest();
		}

		// Token: 0x170029D7 RID: 10711
		// (get) Token: 0x0600CF35 RID: 53045 RVA: 0x001E8551 File Offset: 0x001E6751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029D8 RID: 10712
		// (get) Token: 0x0600CF36 RID: 53046 RVA: 0x001E8554 File Offset: 0x001E6754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoadEquipInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600CF37 RID: 53047 RVA: 0x001E855B File Offset: 0x001E675B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadEquipInfoRequest()
		{
		}

		// Token: 0x0600CF38 RID: 53048 RVA: 0x001E8563 File Offset: 0x001E6763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadEquipInfoRequest(LoadEquipInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CF39 RID: 53049 RVA: 0x001E857C File Offset: 0x001E677C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadEquipInfoRequest Clone()
		{
			return new LoadEquipInfoRequest(this);
		}

		// Token: 0x0600CF3A RID: 53050 RVA: 0x001E8584 File Offset: 0x001E6784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoadEquipInfoRequest);
		}

		// Token: 0x0600CF3B RID: 53051 RVA: 0x001E8592 File Offset: 0x001E6792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LoadEquipInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600CF3C RID: 53052 RVA: 0x001E85B0 File Offset: 0x001E67B0
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

		// Token: 0x0600CF3D RID: 53053 RVA: 0x001E85D6 File Offset: 0x001E67D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CF3E RID: 53054 RVA: 0x001E85E3 File Offset: 0x001E67E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CF3F RID: 53055 RVA: 0x001E85EC File Offset: 0x001E67EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CF40 RID: 53056 RVA: 0x001E8604 File Offset: 0x001E6804
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

		// Token: 0x0600CF41 RID: 53057 RVA: 0x001E862A File Offset: 0x001E682A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LoadEquipInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CF42 RID: 53058 RVA: 0x001E8647 File Offset: 0x001E6847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CF43 RID: 53059 RVA: 0x001E8650 File Offset: 0x001E6850
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

		// Token: 0x040057CA RID: 22474
		private UnknownFieldSet _unknownFields;
	}
}
