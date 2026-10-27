using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005F0 RID: 1520
	[NetMessage(EMessageId.FloroRanchWeeklyRequest)]
	public sealed class FloroRanchWeeklyRequest : IMessage<FloroRanchWeeklyRequest>, IMessage, IEquatable<FloroRanchWeeklyRequest>, IDeepCloneable<FloroRanchWeeklyRequest>, IBufferMessage
	{
		// Token: 0x06008CC2 RID: 36034 RVA: 0x001557CD File Offset: 0x001539CD
		[NullableContext(1)]
		public static FloroRanchWeeklyRequest Create()
		{
			return new FloroRanchWeeklyRequest();
		}

		// Token: 0x17001BE4 RID: 7140
		// (get) Token: 0x06008CC3 RID: 36035 RVA: 0x001557D4 File Offset: 0x001539D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BE5 RID: 7141
		// (get) Token: 0x06008CC4 RID: 36036 RVA: 0x001557D7 File Offset: 0x001539D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchWeeklyRequest.Descriptor;
			}
		}

		// Token: 0x06008CC5 RID: 36037 RVA: 0x001557DE File Offset: 0x001539DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchWeeklyRequest()
		{
		}

		// Token: 0x06008CC6 RID: 36038 RVA: 0x001557E6 File Offset: 0x001539E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchWeeklyRequest(FloroRanchWeeklyRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008CC7 RID: 36039 RVA: 0x001557FF File Offset: 0x001539FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchWeeklyRequest Clone()
		{
			return new FloroRanchWeeklyRequest(this);
		}

		// Token: 0x06008CC8 RID: 36040 RVA: 0x00155807 File Offset: 0x00153A07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchWeeklyRequest);
		}

		// Token: 0x06008CC9 RID: 36041 RVA: 0x00155815 File Offset: 0x00153A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchWeeklyRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06008CCA RID: 36042 RVA: 0x00155834 File Offset: 0x00153A34
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

		// Token: 0x06008CCB RID: 36043 RVA: 0x0015585A File Offset: 0x00153A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008CCC RID: 36044 RVA: 0x00155867 File Offset: 0x00153A67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008CCD RID: 36045 RVA: 0x00155870 File Offset: 0x00153A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008CCE RID: 36046 RVA: 0x00155888 File Offset: 0x00153A88
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

		// Token: 0x06008CCF RID: 36047 RVA: 0x001558AE File Offset: 0x00153AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchWeeklyRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008CD0 RID: 36048 RVA: 0x001558CB File Offset: 0x00153ACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008CD1 RID: 36049 RVA: 0x001558D4 File Offset: 0x00153AD4
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

		// Token: 0x040044D9 RID: 17625
		private UnknownFieldSet _unknownFields;
	}
}
