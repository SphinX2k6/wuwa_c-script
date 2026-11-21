using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007BB RID: 1979
	[NetMessage(EMessageId.InfluenceInfoRequest)]
	public sealed class InfluenceInfoRequest : IMessage<InfluenceInfoRequest>, IMessage, IEquatable<InfluenceInfoRequest>, IDeepCloneable<InfluenceInfoRequest>, IBufferMessage
	{
		// Token: 0x0600B266 RID: 45670 RVA: 0x001AB7E9 File Offset: 0x001A99E9
		[NullableContext(1)]
		public static InfluenceInfoRequest Create()
		{
			return new InfluenceInfoRequest();
		}

		// Token: 0x170023FC RID: 9212
		// (get) Token: 0x0600B267 RID: 45671 RVA: 0x001AB7F0 File Offset: 0x001A99F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023FD RID: 9213
		// (get) Token: 0x0600B268 RID: 45672 RVA: 0x001AB7F3 File Offset: 0x001A99F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfluenceInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600B269 RID: 45673 RVA: 0x001AB7FA File Offset: 0x001A99FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceInfoRequest()
		{
		}

		// Token: 0x0600B26A RID: 45674 RVA: 0x001AB802 File Offset: 0x001A9A02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceInfoRequest(InfluenceInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B26B RID: 45675 RVA: 0x001AB81B File Offset: 0x001A9A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceInfoRequest Clone()
		{
			return new InfluenceInfoRequest(this);
		}

		// Token: 0x0600B26C RID: 45676 RVA: 0x001AB823 File Offset: 0x001A9A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfluenceInfoRequest);
		}

		// Token: 0x0600B26D RID: 45677 RVA: 0x001AB831 File Offset: 0x001A9A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfluenceInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B26E RID: 45678 RVA: 0x001AB850 File Offset: 0x001A9A50
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

		// Token: 0x0600B26F RID: 45679 RVA: 0x001AB876 File Offset: 0x001A9A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B270 RID: 45680 RVA: 0x001AB883 File Offset: 0x001A9A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B271 RID: 45681 RVA: 0x001AB88C File Offset: 0x001A9A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B272 RID: 45682 RVA: 0x001AB8A4 File Offset: 0x001A9AA4
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

		// Token: 0x0600B273 RID: 45683 RVA: 0x001AB8CA File Offset: 0x001A9ACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfluenceInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B274 RID: 45684 RVA: 0x001AB8E7 File Offset: 0x001A9AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B275 RID: 45685 RVA: 0x001AB8F0 File Offset: 0x001A9AF0
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

		// Token: 0x0400501D RID: 20509
		private UnknownFieldSet _unknownFields;
	}
}
