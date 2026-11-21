using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000920 RID: 2336
	[NetMessage(EMessageId.LivenessRequest)]
	public sealed class LivenessRequest : IMessage<LivenessRequest>, IMessage, IEquatable<LivenessRequest>, IDeepCloneable<LivenessRequest>, IBufferMessage
	{
		// Token: 0x0600CE5A RID: 52826 RVA: 0x001E6A04 File Offset: 0x001E4C04
		[NullableContext(1)]
		public static LivenessRequest Create()
		{
			return new LivenessRequest();
		}

		// Token: 0x170029AC RID: 10668
		// (get) Token: 0x0600CE5B RID: 52827 RVA: 0x001E6A0B File Offset: 0x001E4C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029AD RID: 10669
		// (get) Token: 0x0600CE5C RID: 52828 RVA: 0x001E6A0E File Offset: 0x001E4C0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LivenessRequest.Descriptor;
			}
		}

		// Token: 0x0600CE5D RID: 52829 RVA: 0x001E6A15 File Offset: 0x001E4C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessRequest()
		{
		}

		// Token: 0x0600CE5E RID: 52830 RVA: 0x001E6A1D File Offset: 0x001E4C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessRequest(LivenessRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CE5F RID: 52831 RVA: 0x001E6A36 File Offset: 0x001E4C36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessRequest Clone()
		{
			return new LivenessRequest(this);
		}

		// Token: 0x0600CE60 RID: 52832 RVA: 0x001E6A3E File Offset: 0x001E4C3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LivenessRequest);
		}

		// Token: 0x0600CE61 RID: 52833 RVA: 0x001E6A4C File Offset: 0x001E4C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LivenessRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600CE62 RID: 52834 RVA: 0x001E6A6C File Offset: 0x001E4C6C
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

		// Token: 0x0600CE63 RID: 52835 RVA: 0x001E6A92 File Offset: 0x001E4C92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CE64 RID: 52836 RVA: 0x001E6A9F File Offset: 0x001E4C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CE65 RID: 52837 RVA: 0x001E6AA8 File Offset: 0x001E4CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CE66 RID: 52838 RVA: 0x001E6AC0 File Offset: 0x001E4CC0
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

		// Token: 0x0600CE67 RID: 52839 RVA: 0x001E6AE6 File Offset: 0x001E4CE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LivenessRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CE68 RID: 52840 RVA: 0x001E6B03 File Offset: 0x001E4D03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CE69 RID: 52841 RVA: 0x001E6B0C File Offset: 0x001E4D0C
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

		// Token: 0x04005792 RID: 22418
		private UnknownFieldSet _unknownFields;
	}
}
