using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C03 RID: 3075
	[NetMessage(EMessageId.PbGetRoleListRequest)]
	public sealed class PbGetRoleListRequest : IMessage<PbGetRoleListRequest>, IMessage, IEquatable<PbGetRoleListRequest>, IDeepCloneable<PbGetRoleListRequest>, IBufferMessage
	{
		// Token: 0x06010B18 RID: 68376 RVA: 0x00271C81 File Offset: 0x0026FE81
		[NullableContext(1)]
		public static PbGetRoleListRequest Create()
		{
			return new PbGetRoleListRequest();
		}

		// Token: 0x1700370E RID: 14094
		// (get) Token: 0x06010B19 RID: 68377 RVA: 0x00271C88 File Offset: 0x0026FE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700370F RID: 14095
		// (get) Token: 0x06010B1A RID: 68378 RVA: 0x00271C8B File Offset: 0x0026FE8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbGetRoleListRequest.Descriptor;
			}
		}

		// Token: 0x06010B1B RID: 68379 RVA: 0x00271C92 File Offset: 0x0026FE92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbGetRoleListRequest()
		{
		}

		// Token: 0x06010B1C RID: 68380 RVA: 0x00271C9A File Offset: 0x0026FE9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbGetRoleListRequest(PbGetRoleListRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010B1D RID: 68381 RVA: 0x00271CB3 File Offset: 0x0026FEB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbGetRoleListRequest Clone()
		{
			return new PbGetRoleListRequest(this);
		}

		// Token: 0x06010B1E RID: 68382 RVA: 0x00271CBB File Offset: 0x0026FEBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbGetRoleListRequest);
		}

		// Token: 0x06010B1F RID: 68383 RVA: 0x00271CC9 File Offset: 0x0026FEC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbGetRoleListRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06010B20 RID: 68384 RVA: 0x00271CE8 File Offset: 0x0026FEE8
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

		// Token: 0x06010B21 RID: 68385 RVA: 0x00271D0E File Offset: 0x0026FF0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010B22 RID: 68386 RVA: 0x00271D1B File Offset: 0x0026FF1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010B23 RID: 68387 RVA: 0x00271D24 File Offset: 0x0026FF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010B24 RID: 68388 RVA: 0x00271D3C File Offset: 0x0026FF3C
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

		// Token: 0x06010B25 RID: 68389 RVA: 0x00271D62 File Offset: 0x0026FF62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbGetRoleListRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010B26 RID: 68390 RVA: 0x00271D7F File Offset: 0x0026FF7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010B27 RID: 68391 RVA: 0x00271D88 File Offset: 0x0026FF88
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

		// Token: 0x04006A1B RID: 27163
		private UnknownFieldSet _unknownFields;
	}
}
