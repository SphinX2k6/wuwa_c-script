using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007D0 RID: 2000
	[NetMessage(EMessageId.InfrManualCancelTraceRoadRequest)]
	public sealed class InfrManualCancelTraceRoadRequest : IMessage<InfrManualCancelTraceRoadRequest>, IMessage, IEquatable<InfrManualCancelTraceRoadRequest>, IDeepCloneable<InfrManualCancelTraceRoadRequest>, IBufferMessage
	{
		// Token: 0x0600B3ED RID: 46061 RVA: 0x001AE656 File Offset: 0x001AC856
		[NullableContext(1)]
		public static InfrManualCancelTraceRoadRequest Create()
		{
			return new InfrManualCancelTraceRoadRequest();
		}

		// Token: 0x17002443 RID: 9283
		// (get) Token: 0x0600B3EE RID: 46062 RVA: 0x001AE65D File Offset: 0x001AC85D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002444 RID: 9284
		// (get) Token: 0x0600B3EF RID: 46063 RVA: 0x001AE660 File Offset: 0x001AC860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrManualCancelTraceRoadRequest.Descriptor;
			}
		}

		// Token: 0x0600B3F0 RID: 46064 RVA: 0x001AE667 File Offset: 0x001AC867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrManualCancelTraceRoadRequest()
		{
		}

		// Token: 0x0600B3F1 RID: 46065 RVA: 0x001AE66F File Offset: 0x001AC86F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrManualCancelTraceRoadRequest(InfrManualCancelTraceRoadRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B3F2 RID: 46066 RVA: 0x001AE688 File Offset: 0x001AC888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrManualCancelTraceRoadRequest Clone()
		{
			return new InfrManualCancelTraceRoadRequest(this);
		}

		// Token: 0x0600B3F3 RID: 46067 RVA: 0x001AE690 File Offset: 0x001AC890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrManualCancelTraceRoadRequest);
		}

		// Token: 0x0600B3F4 RID: 46068 RVA: 0x001AE69E File Offset: 0x001AC89E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrManualCancelTraceRoadRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B3F5 RID: 46069 RVA: 0x001AE6BC File Offset: 0x001AC8BC
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

		// Token: 0x0600B3F6 RID: 46070 RVA: 0x001AE6E2 File Offset: 0x001AC8E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B3F7 RID: 46071 RVA: 0x001AE6EF File Offset: 0x001AC8EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B3F8 RID: 46072 RVA: 0x001AE6F8 File Offset: 0x001AC8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B3F9 RID: 46073 RVA: 0x001AE710 File Offset: 0x001AC910
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

		// Token: 0x0600B3FA RID: 46074 RVA: 0x001AE736 File Offset: 0x001AC936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrManualCancelTraceRoadRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B3FB RID: 46075 RVA: 0x001AE753 File Offset: 0x001AC953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B3FC RID: 46076 RVA: 0x001AE75C File Offset: 0x001AC95C
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

		// Token: 0x04005077 RID: 20599
		private UnknownFieldSet _unknownFields;
	}
}
